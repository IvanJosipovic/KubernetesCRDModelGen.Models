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
/// Storage version of v20250601.StorageAccount
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2025-06-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250601storageStorageAccountList : IKubernetesObject<V1ListMeta>, IItems<V20250601storageStorageAccount>
{
    public const string KubeApiVersion = "v20250601storage";
    public const string KubeKind = "StorageAccountList";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20250601storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250601storageStorageAccount objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250601storageStorageAccount> Items { get; set; }
}

/// <summary>
/// Storage version of v20250601.ActiveDirectoryProperties
/// Settings properties for Active Directory (AD).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecAzureFilesIdentityBasedAuthenticationActiveDirectoryProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("accountType")]
    public string? AccountType { get; set; }

    [JsonPropertyName("azureStorageSid")]
    public string? AzureStorageSid { get; set; }

    [JsonPropertyName("domainGuid")]
    public string? DomainGuid { get; set; }

    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    [JsonPropertyName("domainSid")]
    public string? DomainSid { get; set; }

    [JsonPropertyName("forestName")]
    public string? ForestName { get; set; }

    [JsonPropertyName("netBiosDomainName")]
    public string? NetBiosDomainName { get; set; }

    [JsonPropertyName("samAccountName")]
    public string? SamAccountName { get; set; }
}

/// <summary>
/// Storage version of v20250601.SmbOAuthSettings
/// Setting property for Managed Identity access over SMB using OAuth
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecAzureFilesIdentityBasedAuthenticationSmbOAuthSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSmbOAuthEnabled")]
    public bool? IsSmbOAuthEnabled { get; set; }
}

/// <summary>
/// Storage version of v20250601.AzureFilesIdentityBasedAuthentication
/// Settings for Azure Files identity based authentication.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecAzureFilesIdentityBasedAuthentication
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250601.ActiveDirectoryProperties
    /// Settings properties for Active Directory (AD).
    /// </summary>
    [JsonPropertyName("activeDirectoryProperties")]
    public V20250601storageStorageAccountSpecAzureFilesIdentityBasedAuthenticationActiveDirectoryProperties? ActiveDirectoryProperties { get; set; }

    [JsonPropertyName("defaultSharePermission")]
    public string? DefaultSharePermission { get; set; }

    [JsonPropertyName("directoryServiceOptions")]
    public string? DirectoryServiceOptions { get; set; }

    /// <summary>
    /// Storage version of v20250601.SmbOAuthSettings
    /// Setting property for Managed Identity access over SMB using OAuth
    /// </summary>
    [JsonPropertyName("smbOAuthSettings")]
    public V20250601storageStorageAccountSpecAzureFilesIdentityBasedAuthenticationSmbOAuthSettings? SmbOAuthSettings { get; set; }
}

/// <summary>
/// Storage version of v20250601.CustomDomain
/// The custom domain assigned to this storage account. This can be set via Update.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecCustomDomain
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("useSubDomainName")]
    public bool? UseSubDomainName { get; set; }
}

/// <summary>
/// Storage version of v20250601.DualStackEndpointPreference
/// Dual-stack endpoint preference defines whether IPv6 endpoints are going to be published.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecDualStackEndpointPreference
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("publishIpv6Endpoint")]
    public bool? PublishIpv6Endpoint { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecEncryptionIdentityFederatedIdentityClientIdFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// UserAssignedIdentityReference: Resource identifier of the UserAssigned identity to be associated with server-side
/// encryption on the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecEncryptionIdentityUserAssignedIdentityReference
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
/// Storage version of v20250601.EncryptionIdentity
/// Encryption identity for the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecEncryptionIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("federatedIdentityClientId")]
    public string? FederatedIdentityClientId { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("federatedIdentityClientIdFromConfig")]
    public V20250601storageStorageAccountSpecEncryptionIdentityFederatedIdentityClientIdFromConfig? FederatedIdentityClientIdFromConfig { get; set; }

    /// <summary>
    /// UserAssignedIdentityReference: Resource identifier of the UserAssigned identity to be associated with server-side
    /// encryption on the storage account.
    /// </summary>
    [JsonPropertyName("userAssignedIdentityReference")]
    public V20250601storageStorageAccountSpecEncryptionIdentityUserAssignedIdentityReference? UserAssignedIdentityReference { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecEncryptionKeyvaultpropertiesKeynameFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecEncryptionKeyvaultpropertiesKeyvaulturiFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecEncryptionKeyvaultpropertiesKeyversionFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Storage version of v20250601.KeyVaultProperties
/// Properties of key vault.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecEncryptionKeyvaultproperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyname")]
    public string? Keyname { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("keynameFromConfig")]
    public V20250601storageStorageAccountSpecEncryptionKeyvaultpropertiesKeynameFromConfig? KeynameFromConfig { get; set; }

    [JsonPropertyName("keyvaulturi")]
    public string? Keyvaulturi { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("keyvaulturiFromConfig")]
    public V20250601storageStorageAccountSpecEncryptionKeyvaultpropertiesKeyvaulturiFromConfig? KeyvaulturiFromConfig { get; set; }

    [JsonPropertyName("keyversion")]
    public string? Keyversion { get; set; }

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("keyversionFromConfig")]
    public V20250601storageStorageAccountSpecEncryptionKeyvaultpropertiesKeyversionFromConfig? KeyversionFromConfig { get; set; }
}

/// <summary>
/// Storage version of v20250601.EncryptionService
/// A service that allows server-side encryption to be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecEncryptionServicesBlob
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>
/// Storage version of v20250601.EncryptionService
/// A service that allows server-side encryption to be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecEncryptionServicesFile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>
/// Storage version of v20250601.EncryptionService
/// A service that allows server-side encryption to be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecEncryptionServicesQueue
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>
/// Storage version of v20250601.EncryptionService
/// A service that allows server-side encryption to be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecEncryptionServicesTable
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }
}

/// <summary>
/// Storage version of v20250601.EncryptionServices
/// A list of services that support encryption.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecEncryptionServices
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250601.EncryptionService
    /// A service that allows server-side encryption to be used.
    /// </summary>
    [JsonPropertyName("blob")]
    public V20250601storageStorageAccountSpecEncryptionServicesBlob? Blob { get; set; }

    /// <summary>
    /// Storage version of v20250601.EncryptionService
    /// A service that allows server-side encryption to be used.
    /// </summary>
    [JsonPropertyName("file")]
    public V20250601storageStorageAccountSpecEncryptionServicesFile? File { get; set; }

    /// <summary>
    /// Storage version of v20250601.EncryptionService
    /// A service that allows server-side encryption to be used.
    /// </summary>
    [JsonPropertyName("queue")]
    public V20250601storageStorageAccountSpecEncryptionServicesQueue? Queue { get; set; }

    /// <summary>
    /// Storage version of v20250601.EncryptionService
    /// A service that allows server-side encryption to be used.
    /// </summary>
    [JsonPropertyName("table")]
    public V20250601storageStorageAccountSpecEncryptionServicesTable? Table { get; set; }
}

/// <summary>
/// Storage version of v20250601.Encryption
/// The encryption settings on the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecEncryption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250601.EncryptionIdentity
    /// Encryption identity for the storage account.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250601storageStorageAccountSpecEncryptionIdentity? Identity { get; set; }

    [JsonPropertyName("keySource")]
    public string? KeySource { get; set; }

    /// <summary>
    /// Storage version of v20250601.KeyVaultProperties
    /// Properties of key vault.
    /// </summary>
    [JsonPropertyName("keyvaultproperties")]
    public V20250601storageStorageAccountSpecEncryptionKeyvaultproperties? Keyvaultproperties { get; set; }

    [JsonPropertyName("requireInfrastructureEncryption")]
    public bool? RequireInfrastructureEncryption { get; set; }

    /// <summary>
    /// Storage version of v20250601.EncryptionServices
    /// A list of services that support encryption.
    /// </summary>
    [JsonPropertyName("services")]
    public V20250601storageStorageAccountSpecEncryptionServices? Services { get; set; }
}

/// <summary>
/// Storage version of v20250601.ExtendedLocation
/// The complex type of the extended location.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecExtendedLocation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20250601.GeoPriorityReplicationStatus
/// Geo Priority Replication enablement status for the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecGeoPriorityReplicationStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isBlobEnabled")]
    public bool? IsBlobEnabled { get; set; }
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecIdentityUserAssignedIdentitiesReference
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
/// Storage version of v20250601.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20250601storageStorageAccountSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20250601.Identity
/// Identity for the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecIdentity
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
    public IList<V20250601storageStorageAccountSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v20250601.AccountImmutabilityPolicyProperties
/// This defines account-level immutability policy properties.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecImmutableStorageWithVersioningImmutabilityPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowProtectedAppendWrites")]
    public bool? AllowProtectedAppendWrites { get; set; }

    [JsonPropertyName("immutabilityPeriodSinceCreationInDays")]
    public int? ImmutabilityPeriodSinceCreationInDays { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v20250601.ImmutableStorageAccount
/// This property enables and defines account-level immutability. Enabling the feature auto-enables Blob Versioning.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecImmutableStorageWithVersioning
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20250601.AccountImmutabilityPolicyProperties
    /// This defines account-level immutability policy properties.
    /// </summary>
    [JsonPropertyName("immutabilityPolicy")]
    public V20250601storageStorageAccountSpecImmutableStorageWithVersioningImmutabilityPolicy? ImmutabilityPolicy { get; set; }
}

/// <summary>
/// Storage version of v20250601.KeyPolicy
/// KeyPolicy assigned to the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecKeyPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyExpirationPeriodInDays")]
    public int? KeyExpirationPeriodInDays { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecNetworkAclsIpRulesValueFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Storage version of v20250601.IPRule
/// IP rule with specific IP or IP range in CIDR format.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecNetworkAclsIpRules
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

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("valueFromConfig")]
    public V20250601storageStorageAccountSpecNetworkAclsIpRulesValueFromConfig? ValueFromConfig { get; set; }
}

/// <summary>
/// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecNetworkAclsIpv6RulesValueFromConfig
{
    /// <summary>Key is the key in the Kubernetes configmap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap being referenced.
    /// The configmap must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Storage version of v20250601.IPRule
/// IP rule with specific IP or IP range in CIDR format.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecNetworkAclsIpv6Rules
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

    /// <summary>
    /// ConfigMapReference is a reference to a Kubernetes configmap and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("valueFromConfig")]
    public V20250601storageStorageAccountSpecNetworkAclsIpv6RulesValueFromConfig? ValueFromConfig { get; set; }
}

/// <summary>ResourceReference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecNetworkAclsResourceAccessRulesResourceReference
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
/// Storage version of v20250601.ResourceAccessRule
/// Resource Access Rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecNetworkAclsResourceAccessRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference: Resource Id</summary>
    [JsonPropertyName("resourceReference")]
    public V20250601storageStorageAccountSpecNetworkAclsResourceAccessRulesResourceReference? ResourceReference { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>
/// Reference: Resource ID of a subnet, for example:
/// /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecNetworkAclsVirtualNetworkRulesReference
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
/// Storage version of v20250601.VirtualNetworkRule
/// Virtual Network rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecNetworkAclsVirtualNetworkRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// Reference: Resource ID of a subnet, for example:
    /// /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
    /// </summary>
    [JsonPropertyName("reference")]
    public required V20250601storageStorageAccountSpecNetworkAclsVirtualNetworkRulesReference Reference { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v20250601.NetworkRuleSet
/// Network rule set
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecNetworkAcls
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bypass")]
    public string? Bypass { get; set; }

    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    [JsonPropertyName("ipRules")]
    public IList<V20250601storageStorageAccountSpecNetworkAclsIpRules>? IpRules { get; set; }

    [JsonPropertyName("ipv6Rules")]
    public IList<V20250601storageStorageAccountSpecNetworkAclsIpv6Rules>? Ipv6Rules { get; set; }

    [JsonPropertyName("resourceAccessRules")]
    public IList<V20250601storageStorageAccountSpecNetworkAclsResourceAccessRules>? ResourceAccessRules { get; set; }

    [JsonPropertyName("virtualNetworkRules")]
    public IList<V20250601storageStorageAccountSpecNetworkAclsVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecConfigMapExpressions
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
/// ConfigMapDestination describes the location to store a single configmap value
/// Note: This is similar to: SecretDestination in secrets.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecConfigMapsBlobEndpoint
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ConfigMapDestination describes the location to store a single configmap value
/// Note: This is similar to: SecretDestination in secrets.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecConfigMapsDfsEndpoint
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ConfigMapDestination describes the location to store a single configmap value
/// Note: This is similar to: SecretDestination in secrets.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecConfigMapsFileEndpoint
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ConfigMapDestination describes the location to store a single configmap value
/// Note: This is similar to: SecretDestination in secrets.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecConfigMapsQueueEndpoint
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ConfigMapDestination describes the location to store a single configmap value
/// Note: This is similar to: SecretDestination in secrets.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecConfigMapsTableEndpoint
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// ConfigMapDestination describes the location to store a single configmap value
/// Note: This is similar to: SecretDestination in secrets.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecConfigMapsWebEndpoint
{
    /// <summary>Annotations is an optional set of annotations to apply to the ConfigMap.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the ConfigMap being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the ConfigMap.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes ConfigMap to write to.
    /// The ConfigMap will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Storage version of v20250601.StorageAccountOperatorConfigMaps</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecConfigMaps
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// ConfigMapDestination describes the location to store a single configmap value
    /// Note: This is similar to: SecretDestination in secrets.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("blobEndpoint")]
    public V20250601storageStorageAccountSpecOperatorSpecConfigMapsBlobEndpoint? BlobEndpoint { get; set; }

    /// <summary>
    /// ConfigMapDestination describes the location to store a single configmap value
    /// Note: This is similar to: SecretDestination in secrets.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("dfsEndpoint")]
    public V20250601storageStorageAccountSpecOperatorSpecConfigMapsDfsEndpoint? DfsEndpoint { get; set; }

    /// <summary>
    /// ConfigMapDestination describes the location to store a single configmap value
    /// Note: This is similar to: SecretDestination in secrets.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("fileEndpoint")]
    public V20250601storageStorageAccountSpecOperatorSpecConfigMapsFileEndpoint? FileEndpoint { get; set; }

    /// <summary>
    /// ConfigMapDestination describes the location to store a single configmap value
    /// Note: This is similar to: SecretDestination in secrets.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("queueEndpoint")]
    public V20250601storageStorageAccountSpecOperatorSpecConfigMapsQueueEndpoint? QueueEndpoint { get; set; }

    /// <summary>
    /// ConfigMapDestination describes the location to store a single configmap value
    /// Note: This is similar to: SecretDestination in secrets.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("tableEndpoint")]
    public V20250601storageStorageAccountSpecOperatorSpecConfigMapsTableEndpoint? TableEndpoint { get; set; }

    /// <summary>
    /// ConfigMapDestination describes the location to store a single configmap value
    /// Note: This is similar to: SecretDestination in secrets.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("webEndpoint")]
    public V20250601storageStorageAccountSpecOperatorSpecConfigMapsWebEndpoint? WebEndpoint { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecSecretExpressions
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
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecSecretsBlobEndpoint
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecSecretsDfsEndpoint
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecSecretsFileEndpoint
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecSecretsKey1
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecSecretsKey2
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecSecretsQueueEndpoint
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecSecretsTableEndpoint
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// SecretDestination describes the location to store a single secret value.
/// Note: This is similar to: ConfigMapDestination in configmaps.go.
/// Changes to one may need to be made to the others as well.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecSecretsWebEndpoint
{
    /// <summary>Annotations is an optional set of annotations to apply to the secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Key is the key in the Kubernetes secret being referenced.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret to write to.
    /// The secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Storage version of v20250601.StorageAccountOperatorSecrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpecSecrets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("blobEndpoint")]
    public V20250601storageStorageAccountSpecOperatorSpecSecretsBlobEndpoint? BlobEndpoint { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("dfsEndpoint")]
    public V20250601storageStorageAccountSpecOperatorSpecSecretsDfsEndpoint? DfsEndpoint { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("fileEndpoint")]
    public V20250601storageStorageAccountSpecOperatorSpecSecretsFileEndpoint? FileEndpoint { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("key1")]
    public V20250601storageStorageAccountSpecOperatorSpecSecretsKey1? Key1 { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("key2")]
    public V20250601storageStorageAccountSpecOperatorSpecSecretsKey2? Key2 { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("queueEndpoint")]
    public V20250601storageStorageAccountSpecOperatorSpecSecretsQueueEndpoint? QueueEndpoint { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("tableEndpoint")]
    public V20250601storageStorageAccountSpecOperatorSpecSecretsTableEndpoint? TableEndpoint { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("webEndpoint")]
    public V20250601storageStorageAccountSpecOperatorSpecSecretsWebEndpoint? WebEndpoint { get; set; }
}

/// <summary>
/// Storage version of v20250601.StorageAccountOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20250601storageStorageAccountSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>Storage version of v20250601.StorageAccountOperatorConfigMaps</summary>
    [JsonPropertyName("configMaps")]
    public V20250601storageStorageAccountSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20250601storageStorageAccountSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Storage version of v20250601.StorageAccountOperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V20250601storageStorageAccountSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20250601.Placement
/// The complex type of the zonal placement details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecPlacement
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("zonePlacementPolicy")]
    public string? ZonePlacementPolicy { get; set; }
}

/// <summary>
/// Storage version of v20250601.RoutingPreference
/// Routing preference defines the type of network, either microsoft or internet routing to be used to deliver the user
/// data, the default option is microsoft routing
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecRoutingPreference
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("publishInternetEndpoints")]
    public bool? PublishInternetEndpoints { get; set; }

    [JsonPropertyName("publishMicrosoftEndpoints")]
    public bool? PublishMicrosoftEndpoints { get; set; }

    [JsonPropertyName("routingChoice")]
    public string? RoutingChoice { get; set; }
}

/// <summary>
/// Storage version of v20250601.SasPolicy
/// SasPolicy assigned to the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecSasPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("expirationAction")]
    public string? ExpirationAction { get; set; }

    [JsonPropertyName("sasExpirationPeriod")]
    public string? SasExpirationPeriod { get; set; }
}

/// <summary>
/// Storage version of v20250601.Sku
/// The SKU of the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpecSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v20250601.StorageAccount_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("accessTier")]
    public string? AccessTier { get; set; }

    [JsonPropertyName("allowBlobPublicAccess")]
    public bool? AllowBlobPublicAccess { get; set; }

    [JsonPropertyName("allowCrossTenantReplication")]
    public bool? AllowCrossTenantReplication { get; set; }

    [JsonPropertyName("allowSharedKeyAccess")]
    public bool? AllowSharedKeyAccess { get; set; }

    [JsonPropertyName("allowedCopyScope")]
    public string? AllowedCopyScope { get; set; }

    /// <summary>
    /// Storage version of v20250601.AzureFilesIdentityBasedAuthentication
    /// Settings for Azure Files identity based authentication.
    /// </summary>
    [JsonPropertyName("azureFilesIdentityBasedAuthentication")]
    public V20250601storageStorageAccountSpecAzureFilesIdentityBasedAuthentication? AzureFilesIdentityBasedAuthentication { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v20250601.CustomDomain
    /// The custom domain assigned to this storage account. This can be set via Update.
    /// </summary>
    [JsonPropertyName("customDomain")]
    public V20250601storageStorageAccountSpecCustomDomain? CustomDomain { get; set; }

    [JsonPropertyName("defaultToOAuthAuthentication")]
    public bool? DefaultToOAuthAuthentication { get; set; }

    [JsonPropertyName("dnsEndpointType")]
    public string? DnsEndpointType { get; set; }

    /// <summary>
    /// Storage version of v20250601.DualStackEndpointPreference
    /// Dual-stack endpoint preference defines whether IPv6 endpoints are going to be published.
    /// </summary>
    [JsonPropertyName("dualStackEndpointPreference")]
    public V20250601storageStorageAccountSpecDualStackEndpointPreference? DualStackEndpointPreference { get; set; }

    [JsonPropertyName("enableExtendedGroups")]
    public bool? EnableExtendedGroups { get; set; }

    /// <summary>
    /// Storage version of v20250601.Encryption
    /// The encryption settings on the storage account.
    /// </summary>
    [JsonPropertyName("encryption")]
    public V20250601storageStorageAccountSpecEncryption? Encryption { get; set; }

    /// <summary>
    /// Storage version of v20250601.ExtendedLocation
    /// The complex type of the extended location.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V20250601storageStorageAccountSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// Storage version of v20250601.GeoPriorityReplicationStatus
    /// Geo Priority Replication enablement status for the storage account.
    /// </summary>
    [JsonPropertyName("geoPriorityReplicationStatus")]
    public V20250601storageStorageAccountSpecGeoPriorityReplicationStatus? GeoPriorityReplicationStatus { get; set; }

    /// <summary>
    /// Storage version of v20250601.Identity
    /// Identity for the resource.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250601storageStorageAccountSpecIdentity? Identity { get; set; }

    /// <summary>
    /// Storage version of v20250601.ImmutableStorageAccount
    /// This property enables and defines account-level immutability. Enabling the feature auto-enables Blob Versioning.
    /// </summary>
    [JsonPropertyName("immutableStorageWithVersioning")]
    public V20250601storageStorageAccountSpecImmutableStorageWithVersioning? ImmutableStorageWithVersioning { get; set; }

    [JsonPropertyName("isHnsEnabled")]
    public bool? IsHnsEnabled { get; set; }

    [JsonPropertyName("isLocalUserEnabled")]
    public bool? IsLocalUserEnabled { get; set; }

    [JsonPropertyName("isNfsV3Enabled")]
    public bool? IsNfsV3Enabled { get; set; }

    [JsonPropertyName("isSftpEnabled")]
    public bool? IsSftpEnabled { get; set; }

    /// <summary>
    /// Storage version of v20250601.KeyPolicy
    /// KeyPolicy assigned to the storage account.
    /// </summary>
    [JsonPropertyName("keyPolicy")]
    public V20250601storageStorageAccountSpecKeyPolicy? KeyPolicy { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("largeFileSharesState")]
    public string? LargeFileSharesState { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>
    /// Storage version of v20250601.NetworkRuleSet
    /// Network rule set
    /// </summary>
    [JsonPropertyName("networkAcls")]
    public V20250601storageStorageAccountSpecNetworkAcls? NetworkAcls { get; set; }

    /// <summary>
    /// Storage version of v20250601.StorageAccountOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250601storageStorageAccountSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250601storageStorageAccountSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v20250601.Placement
    /// The complex type of the zonal placement details.
    /// </summary>
    [JsonPropertyName("placement")]
    public V20250601storageStorageAccountSpecPlacement? Placement { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// Storage version of v20250601.RoutingPreference
    /// Routing preference defines the type of network, either microsoft or internet routing to be used to deliver the user
    /// data, the default option is microsoft routing
    /// </summary>
    [JsonPropertyName("routingPreference")]
    public V20250601storageStorageAccountSpecRoutingPreference? RoutingPreference { get; set; }

    /// <summary>
    /// Storage version of v20250601.SasPolicy
    /// SasPolicy assigned to the storage account.
    /// </summary>
    [JsonPropertyName("sasPolicy")]
    public V20250601storageStorageAccountSpecSasPolicy? SasPolicy { get; set; }

    /// <summary>
    /// Storage version of v20250601.Sku
    /// The SKU of the storage account.
    /// </summary>
    [JsonPropertyName("sku")]
    public V20250601storageStorageAccountSpecSku? Sku { get; set; }

    [JsonPropertyName("supportsHttpsTrafficOnly")]
    public bool? SupportsHttpsTrafficOnly { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Storage version of v20250601.ActiveDirectoryProperties_STATUS
/// Settings properties for Active Directory (AD).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusAzureFilesIdentityBasedAuthenticationActiveDirectoryProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("accountType")]
    public string? AccountType { get; set; }

    [JsonPropertyName("azureStorageSid")]
    public string? AzureStorageSid { get; set; }

    [JsonPropertyName("domainGuid")]
    public string? DomainGuid { get; set; }

    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    [JsonPropertyName("domainSid")]
    public string? DomainSid { get; set; }

    [JsonPropertyName("forestName")]
    public string? ForestName { get; set; }

    [JsonPropertyName("netBiosDomainName")]
    public string? NetBiosDomainName { get; set; }

    [JsonPropertyName("samAccountName")]
    public string? SamAccountName { get; set; }
}

/// <summary>
/// Storage version of v20250601.SmbOAuthSettings_STATUS
/// Setting property for Managed Identity access over SMB using OAuth
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusAzureFilesIdentityBasedAuthenticationSmbOAuthSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isSmbOAuthEnabled")]
    public bool? IsSmbOAuthEnabled { get; set; }
}

/// <summary>
/// Storage version of v20250601.AzureFilesIdentityBasedAuthentication_STATUS
/// Settings for Azure Files identity based authentication.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusAzureFilesIdentityBasedAuthentication
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250601.ActiveDirectoryProperties_STATUS
    /// Settings properties for Active Directory (AD).
    /// </summary>
    [JsonPropertyName("activeDirectoryProperties")]
    public V20250601storageStorageAccountStatusAzureFilesIdentityBasedAuthenticationActiveDirectoryProperties? ActiveDirectoryProperties { get; set; }

    [JsonPropertyName("defaultSharePermission")]
    public string? DefaultSharePermission { get; set; }

    [JsonPropertyName("directoryServiceOptions")]
    public string? DirectoryServiceOptions { get; set; }

    /// <summary>
    /// Storage version of v20250601.SmbOAuthSettings_STATUS
    /// Setting property for Managed Identity access over SMB using OAuth
    /// </summary>
    [JsonPropertyName("smbOAuthSettings")]
    public V20250601storageStorageAccountStatusAzureFilesIdentityBasedAuthenticationSmbOAuthSettings? SmbOAuthSettings { get; set; }
}

/// <summary>
/// Storage version of v20250601.BlobRestoreRange_STATUS
/// Blob range
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusBlobRestoreStatusParametersBlobRanges
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endRange")]
    public string? EndRange { get; set; }

    [JsonPropertyName("startRange")]
    public string? StartRange { get; set; }
}

/// <summary>
/// Storage version of v20250601.BlobRestoreParameters_STATUS
/// Blob restore parameters
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusBlobRestoreStatusParameters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blobRanges")]
    public IList<V20250601storageStorageAccountStatusBlobRestoreStatusParametersBlobRanges>? BlobRanges { get; set; }

    [JsonPropertyName("timeToRestore")]
    public string? TimeToRestore { get; set; }
}

/// <summary>
/// Storage version of v20250601.BlobRestoreStatus_STATUS
/// Blob restore status.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusBlobRestoreStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>
    /// Storage version of v20250601.BlobRestoreParameters_STATUS
    /// Blob restore parameters
    /// </summary>
    [JsonPropertyName("parameters")]
    public V20250601storageStorageAccountStatusBlobRestoreStatusParameters? Parameters { get; set; }

    [JsonPropertyName("restoreId")]
    public string? RestoreId { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusConditions
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
/// Storage version of v20250601.CustomDomain_STATUS
/// The custom domain assigned to this storage account. This can be set via Update.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusCustomDomain
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("useSubDomainName")]
    public bool? UseSubDomainName { get; set; }
}

/// <summary>
/// Storage version of v20250601.DualStackEndpointPreference_STATUS
/// Dual-stack endpoint preference defines whether IPv6 endpoints are going to be published.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusDualStackEndpointPreference
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("publishIpv6Endpoint")]
    public bool? PublishIpv6Endpoint { get; set; }
}

/// <summary>
/// Storage version of v20250601.EncryptionIdentity_STATUS
/// Encryption identity for the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusEncryptionIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("federatedIdentityClientId")]
    public string? FederatedIdentityClientId { get; set; }

    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>
/// Storage version of v20250601.KeyVaultProperties_STATUS
/// Properties of key vault.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusEncryptionKeyvaultproperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("currentVersionedKeyExpirationTimestamp")]
    public string? CurrentVersionedKeyExpirationTimestamp { get; set; }

    [JsonPropertyName("currentVersionedKeyIdentifier")]
    public string? CurrentVersionedKeyIdentifier { get; set; }

    [JsonPropertyName("keyname")]
    public string? Keyname { get; set; }

    [JsonPropertyName("keyvaulturi")]
    public string? Keyvaulturi { get; set; }

    [JsonPropertyName("keyversion")]
    public string? Keyversion { get; set; }

    [JsonPropertyName("lastKeyRotationTimestamp")]
    public string? LastKeyRotationTimestamp { get; set; }
}

/// <summary>
/// Storage version of v20250601.EncryptionService_STATUS
/// A service that allows server-side encryption to be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusEncryptionServicesBlob
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    [JsonPropertyName("lastEnabledTime")]
    public string? LastEnabledTime { get; set; }
}

/// <summary>
/// Storage version of v20250601.EncryptionService_STATUS
/// A service that allows server-side encryption to be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusEncryptionServicesFile
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    [JsonPropertyName("lastEnabledTime")]
    public string? LastEnabledTime { get; set; }
}

/// <summary>
/// Storage version of v20250601.EncryptionService_STATUS
/// A service that allows server-side encryption to be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusEncryptionServicesQueue
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    [JsonPropertyName("lastEnabledTime")]
    public string? LastEnabledTime { get; set; }
}

/// <summary>
/// Storage version of v20250601.EncryptionService_STATUS
/// A service that allows server-side encryption to be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusEncryptionServicesTable
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    [JsonPropertyName("lastEnabledTime")]
    public string? LastEnabledTime { get; set; }
}

/// <summary>
/// Storage version of v20250601.EncryptionServices_STATUS
/// A list of services that support encryption.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusEncryptionServices
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250601.EncryptionService_STATUS
    /// A service that allows server-side encryption to be used.
    /// </summary>
    [JsonPropertyName("blob")]
    public V20250601storageStorageAccountStatusEncryptionServicesBlob? Blob { get; set; }

    /// <summary>
    /// Storage version of v20250601.EncryptionService_STATUS
    /// A service that allows server-side encryption to be used.
    /// </summary>
    [JsonPropertyName("file")]
    public V20250601storageStorageAccountStatusEncryptionServicesFile? File { get; set; }

    /// <summary>
    /// Storage version of v20250601.EncryptionService_STATUS
    /// A service that allows server-side encryption to be used.
    /// </summary>
    [JsonPropertyName("queue")]
    public V20250601storageStorageAccountStatusEncryptionServicesQueue? Queue { get; set; }

    /// <summary>
    /// Storage version of v20250601.EncryptionService_STATUS
    /// A service that allows server-side encryption to be used.
    /// </summary>
    [JsonPropertyName("table")]
    public V20250601storageStorageAccountStatusEncryptionServicesTable? Table { get; set; }
}

/// <summary>
/// Storage version of v20250601.Encryption_STATUS
/// The encryption settings on the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusEncryption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v20250601.EncryptionIdentity_STATUS
    /// Encryption identity for the storage account.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250601storageStorageAccountStatusEncryptionIdentity? Identity { get; set; }

    [JsonPropertyName("keySource")]
    public string? KeySource { get; set; }

    /// <summary>
    /// Storage version of v20250601.KeyVaultProperties_STATUS
    /// Properties of key vault.
    /// </summary>
    [JsonPropertyName("keyvaultproperties")]
    public V20250601storageStorageAccountStatusEncryptionKeyvaultproperties? Keyvaultproperties { get; set; }

    [JsonPropertyName("requireInfrastructureEncryption")]
    public bool? RequireInfrastructureEncryption { get; set; }

    /// <summary>
    /// Storage version of v20250601.EncryptionServices_STATUS
    /// A list of services that support encryption.
    /// </summary>
    [JsonPropertyName("services")]
    public V20250601storageStorageAccountStatusEncryptionServices? Services { get; set; }
}

/// <summary>
/// Storage version of v20250601.ExtendedLocation_STATUS
/// The complex type of the extended location.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusExtendedLocation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20250601.GeoPriorityReplicationStatus_STATUS
/// Geo Priority Replication enablement status for the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusGeoPriorityReplicationStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("isBlobEnabled")]
    public bool? IsBlobEnabled { get; set; }
}

/// <summary>
/// Storage version of v20250601.GeoReplicationStats_STATUS
/// Statistics related to replication for storage account&apos;s Blob, Table, Queue and File services. It is only available when
/// geo-redundant replication is enabled for the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusGeoReplicationStats
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("canFailover")]
    public bool? CanFailover { get; set; }

    [JsonPropertyName("canPlannedFailover")]
    public bool? CanPlannedFailover { get; set; }

    [JsonPropertyName("lastSyncTime")]
    public string? LastSyncTime { get; set; }

    [JsonPropertyName("postFailoverRedundancy")]
    public string? PostFailoverRedundancy { get; set; }

    [JsonPropertyName("postPlannedFailoverRedundancy")]
    public string? PostPlannedFailoverRedundancy { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Storage version of v20250601.UserAssignedIdentity_STATUS
/// UserAssignedIdentity for the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusIdentityUserAssignedIdentities
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
/// Storage version of v20250601.Identity_STATUS
/// Identity for the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusIdentity
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
    public IDictionary<string, V20250601storageStorageAccountStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v20250601.AccountImmutabilityPolicyProperties_STATUS
/// This defines account-level immutability policy properties.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusImmutableStorageWithVersioningImmutabilityPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("allowProtectedAppendWrites")]
    public bool? AllowProtectedAppendWrites { get; set; }

    [JsonPropertyName("immutabilityPeriodSinceCreationInDays")]
    public int? ImmutabilityPeriodSinceCreationInDays { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v20250601.ImmutableStorageAccount_STATUS
/// This property enables and defines account-level immutability. Enabling the feature auto-enables Blob Versioning.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusImmutableStorageWithVersioning
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Storage version of v20250601.AccountImmutabilityPolicyProperties_STATUS
    /// This defines account-level immutability policy properties.
    /// </summary>
    [JsonPropertyName("immutabilityPolicy")]
    public V20250601storageStorageAccountStatusImmutableStorageWithVersioningImmutabilityPolicy? ImmutabilityPolicy { get; set; }
}

/// <summary>
/// Storage version of v20250601.KeyCreationTime_STATUS
/// Storage account keys creation time.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusKeyCreationTime
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("key1")]
    public string? Key1 { get; set; }

    [JsonPropertyName("key2")]
    public string? Key2 { get; set; }
}

/// <summary>
/// Storage version of v20250601.KeyPolicy_STATUS
/// KeyPolicy assigned to the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusKeyPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyExpirationPeriodInDays")]
    public int? KeyExpirationPeriodInDays { get; set; }
}

/// <summary>
/// Storage version of v20250601.IPRule_STATUS
/// IP rule with specific IP or IP range in CIDR format.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusNetworkAclsIpRules
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
/// Storage version of v20250601.IPRule_STATUS
/// IP rule with specific IP or IP range in CIDR format.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusNetworkAclsIpv6Rules
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
/// Storage version of v20250601.ResourceAccessRule_STATUS
/// Resource Access Rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusNetworkAclsResourceAccessRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>
/// Storage version of v20250601.VirtualNetworkRule_STATUS
/// Virtual Network rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusNetworkAclsVirtualNetworkRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("action")]
    public string? Action { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v20250601.NetworkRuleSet_STATUS
/// Network rule set
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusNetworkAcls
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("bypass")]
    public string? Bypass { get; set; }

    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    [JsonPropertyName("ipRules")]
    public IList<V20250601storageStorageAccountStatusNetworkAclsIpRules>? IpRules { get; set; }

    [JsonPropertyName("ipv6Rules")]
    public IList<V20250601storageStorageAccountStatusNetworkAclsIpv6Rules>? Ipv6Rules { get; set; }

    [JsonPropertyName("resourceAccessRules")]
    public IList<V20250601storageStorageAccountStatusNetworkAclsResourceAccessRules>? ResourceAccessRules { get; set; }

    [JsonPropertyName("virtualNetworkRules")]
    public IList<V20250601storageStorageAccountStatusNetworkAclsVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>
/// Storage version of v20250601.Placement_STATUS
/// The complex type of the zonal placement details.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusPlacement
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("zonePlacementPolicy")]
    public string? ZonePlacementPolicy { get; set; }
}

/// <summary>
/// Storage version of v20250601.StorageAccountInternetEndpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusPrimaryEndpointsInternetEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    [JsonPropertyName("file")]
    public string? File { get; set; }

    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>
/// Storage version of v20250601.StorageAccountInternetEndpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusPrimaryEndpointsIpv6EndpointsInternetEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    [JsonPropertyName("file")]
    public string? File { get; set; }

    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>
/// Storage version of v20250601.StorageAccountMicrosoftEndpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing
/// endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusPrimaryEndpointsIpv6EndpointsMicrosoftEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    [JsonPropertyName("file")]
    public string? File { get; set; }

    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    [JsonPropertyName("table")]
    public string? Table { get; set; }

    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>
/// Storage version of v20250601.StorageAccountIpv6Endpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via an IPv6 endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusPrimaryEndpointsIpv6Endpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>
    /// Storage version of v20250601.StorageAccountInternetEndpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint.
    /// </summary>
    [JsonPropertyName("internetEndpoints")]
    public V20250601storageStorageAccountStatusPrimaryEndpointsIpv6EndpointsInternetEndpoints? InternetEndpoints { get; set; }

    /// <summary>
    /// Storage version of v20250601.StorageAccountMicrosoftEndpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing
    /// endpoint.
    /// </summary>
    [JsonPropertyName("microsoftEndpoints")]
    public V20250601storageStorageAccountStatusPrimaryEndpointsIpv6EndpointsMicrosoftEndpoints? MicrosoftEndpoints { get; set; }

    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    [JsonPropertyName("table")]
    public string? Table { get; set; }

    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>
/// Storage version of v20250601.StorageAccountMicrosoftEndpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing
/// endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusPrimaryEndpointsMicrosoftEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    [JsonPropertyName("file")]
    public string? File { get; set; }

    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    [JsonPropertyName("table")]
    public string? Table { get; set; }

    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>
/// Storage version of v20250601.Endpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusPrimaryEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>
    /// Storage version of v20250601.StorageAccountInternetEndpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint.
    /// </summary>
    [JsonPropertyName("internetEndpoints")]
    public V20250601storageStorageAccountStatusPrimaryEndpointsInternetEndpoints? InternetEndpoints { get; set; }

    /// <summary>
    /// Storage version of v20250601.StorageAccountIpv6Endpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via an IPv6 endpoint.
    /// </summary>
    [JsonPropertyName("ipv6Endpoints")]
    public V20250601storageStorageAccountStatusPrimaryEndpointsIpv6Endpoints? Ipv6Endpoints { get; set; }

    /// <summary>
    /// Storage version of v20250601.StorageAccountMicrosoftEndpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing
    /// endpoint.
    /// </summary>
    [JsonPropertyName("microsoftEndpoints")]
    public V20250601storageStorageAccountStatusPrimaryEndpointsMicrosoftEndpoints? MicrosoftEndpoints { get; set; }

    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    [JsonPropertyName("table")]
    public string? Table { get; set; }

    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>
/// Storage version of v20250601.PrivateEndpointConnection_STATUS
/// The Private Endpoint Connection resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusPrivateEndpointConnections
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
/// Storage version of v20250601.RoutingPreference_STATUS
/// Routing preference defines the type of network, either microsoft or internet routing to be used to deliver the user
/// data, the default option is microsoft routing
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusRoutingPreference
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("publishInternetEndpoints")]
    public bool? PublishInternetEndpoints { get; set; }

    [JsonPropertyName("publishMicrosoftEndpoints")]
    public bool? PublishMicrosoftEndpoints { get; set; }

    [JsonPropertyName("routingChoice")]
    public string? RoutingChoice { get; set; }
}

/// <summary>
/// Storage version of v20250601.SasPolicy_STATUS
/// SasPolicy assigned to the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusSasPolicy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("expirationAction")]
    public string? ExpirationAction { get; set; }

    [JsonPropertyName("sasExpirationPeriod")]
    public string? SasExpirationPeriod { get; set; }
}

/// <summary>
/// Storage version of v20250601.StorageAccountInternetEndpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusSecondaryEndpointsInternetEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    [JsonPropertyName("file")]
    public string? File { get; set; }

    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>
/// Storage version of v20250601.StorageAccountInternetEndpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusSecondaryEndpointsIpv6EndpointsInternetEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    [JsonPropertyName("file")]
    public string? File { get; set; }

    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>
/// Storage version of v20250601.StorageAccountMicrosoftEndpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing
/// endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusSecondaryEndpointsIpv6EndpointsMicrosoftEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    [JsonPropertyName("file")]
    public string? File { get; set; }

    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    [JsonPropertyName("table")]
    public string? Table { get; set; }

    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>
/// Storage version of v20250601.StorageAccountIpv6Endpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via an IPv6 endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusSecondaryEndpointsIpv6Endpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>
    /// Storage version of v20250601.StorageAccountInternetEndpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint.
    /// </summary>
    [JsonPropertyName("internetEndpoints")]
    public V20250601storageStorageAccountStatusSecondaryEndpointsIpv6EndpointsInternetEndpoints? InternetEndpoints { get; set; }

    /// <summary>
    /// Storage version of v20250601.StorageAccountMicrosoftEndpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing
    /// endpoint.
    /// </summary>
    [JsonPropertyName("microsoftEndpoints")]
    public V20250601storageStorageAccountStatusSecondaryEndpointsIpv6EndpointsMicrosoftEndpoints? MicrosoftEndpoints { get; set; }

    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    [JsonPropertyName("table")]
    public string? Table { get; set; }

    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>
/// Storage version of v20250601.StorageAccountMicrosoftEndpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing
/// endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusSecondaryEndpointsMicrosoftEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    [JsonPropertyName("file")]
    public string? File { get; set; }

    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    [JsonPropertyName("table")]
    public string? Table { get; set; }

    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>
/// Storage version of v20250601.Endpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusSecondaryEndpoints
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>
    /// Storage version of v20250601.StorageAccountInternetEndpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint.
    /// </summary>
    [JsonPropertyName("internetEndpoints")]
    public V20250601storageStorageAccountStatusSecondaryEndpointsInternetEndpoints? InternetEndpoints { get; set; }

    /// <summary>
    /// Storage version of v20250601.StorageAccountIpv6Endpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via an IPv6 endpoint.
    /// </summary>
    [JsonPropertyName("ipv6Endpoints")]
    public V20250601storageStorageAccountStatusSecondaryEndpointsIpv6Endpoints? Ipv6Endpoints { get; set; }

    /// <summary>
    /// Storage version of v20250601.StorageAccountMicrosoftEndpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing
    /// endpoint.
    /// </summary>
    [JsonPropertyName("microsoftEndpoints")]
    public V20250601storageStorageAccountStatusSecondaryEndpointsMicrosoftEndpoints? MicrosoftEndpoints { get; set; }

    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    [JsonPropertyName("table")]
    public string? Table { get; set; }

    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>
/// Storage version of v20250601.Sku_STATUS
/// The SKU of the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// Storage version of v20250601.StorageAccountSkuConversionStatus_STATUS
/// This defines the sku conversion status object for asynchronous sku conversions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusStorageAccountSkuConversionStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    [JsonPropertyName("skuConversionStatus")]
    public string? SkuConversionStatus { get; set; }

    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    [JsonPropertyName("targetSkuName")]
    public string? TargetSkuName { get; set; }
}

/// <summary>
/// Storage version of v20250601.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatusSystemData
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
/// Storage version of v20250601.StorageAccount_STATUS
/// The storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601storageStorageAccountStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("accessTier")]
    public string? AccessTier { get; set; }

    [JsonPropertyName("accountMigrationInProgress")]
    public bool? AccountMigrationInProgress { get; set; }

    [JsonPropertyName("allowBlobPublicAccess")]
    public bool? AllowBlobPublicAccess { get; set; }

    [JsonPropertyName("allowCrossTenantReplication")]
    public bool? AllowCrossTenantReplication { get; set; }

    [JsonPropertyName("allowSharedKeyAccess")]
    public bool? AllowSharedKeyAccess { get; set; }

    [JsonPropertyName("allowedCopyScope")]
    public string? AllowedCopyScope { get; set; }

    /// <summary>
    /// Storage version of v20250601.AzureFilesIdentityBasedAuthentication_STATUS
    /// Settings for Azure Files identity based authentication.
    /// </summary>
    [JsonPropertyName("azureFilesIdentityBasedAuthentication")]
    public V20250601storageStorageAccountStatusAzureFilesIdentityBasedAuthentication? AzureFilesIdentityBasedAuthentication { get; set; }

    /// <summary>
    /// Storage version of v20250601.BlobRestoreStatus_STATUS
    /// Blob restore status.
    /// </summary>
    [JsonPropertyName("blobRestoreStatus")]
    public V20250601storageStorageAccountStatusBlobRestoreStatus? BlobRestoreStatus { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20250601storageStorageAccountStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>
    /// Storage version of v20250601.CustomDomain_STATUS
    /// The custom domain assigned to this storage account. This can be set via Update.
    /// </summary>
    [JsonPropertyName("customDomain")]
    public V20250601storageStorageAccountStatusCustomDomain? CustomDomain { get; set; }

    [JsonPropertyName("defaultToOAuthAuthentication")]
    public bool? DefaultToOAuthAuthentication { get; set; }

    [JsonPropertyName("dnsEndpointType")]
    public string? DnsEndpointType { get; set; }

    /// <summary>
    /// Storage version of v20250601.DualStackEndpointPreference_STATUS
    /// Dual-stack endpoint preference defines whether IPv6 endpoints are going to be published.
    /// </summary>
    [JsonPropertyName("dualStackEndpointPreference")]
    public V20250601storageStorageAccountStatusDualStackEndpointPreference? DualStackEndpointPreference { get; set; }

    [JsonPropertyName("enableExtendedGroups")]
    public bool? EnableExtendedGroups { get; set; }

    /// <summary>
    /// Storage version of v20250601.Encryption_STATUS
    /// The encryption settings on the storage account.
    /// </summary>
    [JsonPropertyName("encryption")]
    public V20250601storageStorageAccountStatusEncryption? Encryption { get; set; }

    /// <summary>
    /// Storage version of v20250601.ExtendedLocation_STATUS
    /// The complex type of the extended location.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V20250601storageStorageAccountStatusExtendedLocation? ExtendedLocation { get; set; }

    [JsonPropertyName("failoverInProgress")]
    public bool? FailoverInProgress { get; set; }

    /// <summary>
    /// Storage version of v20250601.GeoPriorityReplicationStatus_STATUS
    /// Geo Priority Replication enablement status for the storage account.
    /// </summary>
    [JsonPropertyName("geoPriorityReplicationStatus")]
    public V20250601storageStorageAccountStatusGeoPriorityReplicationStatus? GeoPriorityReplicationStatus { get; set; }

    /// <summary>
    /// Storage version of v20250601.GeoReplicationStats_STATUS
    /// Statistics related to replication for storage account&apos;s Blob, Table, Queue and File services. It is only available when
    /// geo-redundant replication is enabled for the storage account.
    /// </summary>
    [JsonPropertyName("geoReplicationStats")]
    public V20250601storageStorageAccountStatusGeoReplicationStats? GeoReplicationStats { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v20250601.Identity_STATUS
    /// Identity for the resource.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250601storageStorageAccountStatusIdentity? Identity { get; set; }

    /// <summary>
    /// Storage version of v20250601.ImmutableStorageAccount_STATUS
    /// This property enables and defines account-level immutability. Enabling the feature auto-enables Blob Versioning.
    /// </summary>
    [JsonPropertyName("immutableStorageWithVersioning")]
    public V20250601storageStorageAccountStatusImmutableStorageWithVersioning? ImmutableStorageWithVersioning { get; set; }

    [JsonPropertyName("isHnsEnabled")]
    public bool? IsHnsEnabled { get; set; }

    [JsonPropertyName("isLocalUserEnabled")]
    public bool? IsLocalUserEnabled { get; set; }

    [JsonPropertyName("isNfsV3Enabled")]
    public bool? IsNfsV3Enabled { get; set; }

    [JsonPropertyName("isSftpEnabled")]
    public bool? IsSftpEnabled { get; set; }

    [JsonPropertyName("isSkuConversionBlocked")]
    public bool? IsSkuConversionBlocked { get; set; }

    /// <summary>
    /// Storage version of v20250601.KeyCreationTime_STATUS
    /// Storage account keys creation time.
    /// </summary>
    [JsonPropertyName("keyCreationTime")]
    public V20250601storageStorageAccountStatusKeyCreationTime? KeyCreationTime { get; set; }

    /// <summary>
    /// Storage version of v20250601.KeyPolicy_STATUS
    /// KeyPolicy assigned to the storage account.
    /// </summary>
    [JsonPropertyName("keyPolicy")]
    public V20250601storageStorageAccountStatusKeyPolicy? KeyPolicy { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("largeFileSharesState")]
    public string? LargeFileSharesState { get; set; }

    [JsonPropertyName("lastGeoFailoverTime")]
    public string? LastGeoFailoverTime { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v20250601.NetworkRuleSet_STATUS
    /// Network rule set
    /// </summary>
    [JsonPropertyName("networkAcls")]
    public V20250601storageStorageAccountStatusNetworkAcls? NetworkAcls { get; set; }

    /// <summary>
    /// Storage version of v20250601.Placement_STATUS
    /// The complex type of the zonal placement details.
    /// </summary>
    [JsonPropertyName("placement")]
    public V20250601storageStorageAccountStatusPlacement? Placement { get; set; }

    /// <summary>
    /// Storage version of v20250601.Endpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
    /// </summary>
    [JsonPropertyName("primaryEndpoints")]
    public V20250601storageStorageAccountStatusPrimaryEndpoints? PrimaryEndpoints { get; set; }

    [JsonPropertyName("primaryLocation")]
    public string? PrimaryLocation { get; set; }

    [JsonPropertyName("privateEndpointConnections")]
    public IList<V20250601storageStorageAccountStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// Storage version of v20250601.RoutingPreference_STATUS
    /// Routing preference defines the type of network, either microsoft or internet routing to be used to deliver the user
    /// data, the default option is microsoft routing
    /// </summary>
    [JsonPropertyName("routingPreference")]
    public V20250601storageStorageAccountStatusRoutingPreference? RoutingPreference { get; set; }

    /// <summary>
    /// Storage version of v20250601.SasPolicy_STATUS
    /// SasPolicy assigned to the storage account.
    /// </summary>
    [JsonPropertyName("sasPolicy")]
    public V20250601storageStorageAccountStatusSasPolicy? SasPolicy { get; set; }

    /// <summary>
    /// Storage version of v20250601.Endpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
    /// </summary>
    [JsonPropertyName("secondaryEndpoints")]
    public V20250601storageStorageAccountStatusSecondaryEndpoints? SecondaryEndpoints { get; set; }

    [JsonPropertyName("secondaryLocation")]
    public string? SecondaryLocation { get; set; }

    /// <summary>
    /// Storage version of v20250601.Sku_STATUS
    /// The SKU of the storage account.
    /// </summary>
    [JsonPropertyName("sku")]
    public V20250601storageStorageAccountStatusSku? Sku { get; set; }

    [JsonPropertyName("statusOfPrimary")]
    public string? StatusOfPrimary { get; set; }

    [JsonPropertyName("statusOfSecondary")]
    public string? StatusOfSecondary { get; set; }

    /// <summary>
    /// Storage version of v20250601.StorageAccountSkuConversionStatus_STATUS
    /// This defines the sku conversion status object for asynchronous sku conversions.
    /// </summary>
    [JsonPropertyName("storageAccountSkuConversionStatus")]
    public V20250601storageStorageAccountStatusStorageAccountSkuConversionStatus? StorageAccountSkuConversionStatus { get; set; }

    [JsonPropertyName("supportsHttpsTrafficOnly")]
    public bool? SupportsHttpsTrafficOnly { get; set; }

    /// <summary>
    /// Storage version of v20250601.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V20250601storageStorageAccountStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Storage version of v20250601.StorageAccount
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2025-06-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250601storageStorageAccount : IKubernetesObject<V1ObjectMeta>, ISpec<V20250601storageStorageAccountSpec?>, IStatus<V20250601storageStorageAccountStatus?>
{
    public const string KubeApiVersion = "v20250601storage";
    public const string KubeKind = "StorageAccount";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20250601storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccount";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20250601.StorageAccount_Spec</summary>
    [JsonPropertyName("spec")]
    public V20250601storageStorageAccountSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v20250601.StorageAccount_STATUS
    /// The storage account.
    /// </summary>
    [JsonPropertyName("status")]
    public V20250601storageStorageAccountStatus? Status { get; set; }
}