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
/// Storage version of v1api20230101.StorageAccount
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2023-01-01/storage.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230101storageStorageAccountList : IKubernetesObject<V1ListMeta>, IItems<V1api20230101storageStorageAccount>
{
    public const string KubeApiVersion = "v1api20230101storage";
    public const string KubeKind = "StorageAccountList";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v1api20230101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20230101storageStorageAccount objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20230101storageStorageAccount> Items { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.ActiveDirectoryProperties
/// Settings properties for Active Directory (AD).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecAzureFilesIdentityBasedAuthenticationActiveDirectoryProperties
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
/// Storage version of v1api20230101.AzureFilesIdentityBasedAuthentication
/// Settings for Azure Files identity based authentication.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecAzureFilesIdentityBasedAuthentication
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.ActiveDirectoryProperties
    /// Settings properties for Active Directory (AD).
    /// </summary>
    [JsonPropertyName("activeDirectoryProperties")]
    public V1api20230101storageStorageAccountSpecAzureFilesIdentityBasedAuthenticationActiveDirectoryProperties? ActiveDirectoryProperties { get; set; }

    [JsonPropertyName("defaultSharePermission")]
    public string? DefaultSharePermission { get; set; }

    [JsonPropertyName("directoryServiceOptions")]
    public string? DirectoryServiceOptions { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.CustomDomain
/// The custom domain assigned to this storage account. This can be set via Update.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecCustomDomain
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
/// UserAssignedIdentityReference: Resource identifier of the UserAssigned identity to be associated with server-side
/// encryption on the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecEncryptionIdentityUserAssignedIdentityReference
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
/// Storage version of v1api20230101.EncryptionIdentity
/// Encryption identity for the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecEncryptionIdentity
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
    /// UserAssignedIdentityReference: Resource identifier of the UserAssigned identity to be associated with server-side
    /// encryption on the storage account.
    /// </summary>
    [JsonPropertyName("userAssignedIdentityReference")]
    public V1api20230101storageStorageAccountSpecEncryptionIdentityUserAssignedIdentityReference? UserAssignedIdentityReference { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.KeyVaultProperties
/// Properties of key vault.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecEncryptionKeyvaultproperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyname")]
    public string? Keyname { get; set; }

    [JsonPropertyName("keyvaulturi")]
    public string? Keyvaulturi { get; set; }

    [JsonPropertyName("keyversion")]
    public string? Keyversion { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.EncryptionService
/// A service that allows server-side encryption to be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecEncryptionServicesBlob
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
/// Storage version of v1api20230101.EncryptionService
/// A service that allows server-side encryption to be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecEncryptionServicesFile
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
/// Storage version of v1api20230101.EncryptionService
/// A service that allows server-side encryption to be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecEncryptionServicesQueue
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
/// Storage version of v1api20230101.EncryptionService
/// A service that allows server-side encryption to be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecEncryptionServicesTable
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
/// Storage version of v1api20230101.EncryptionServices
/// A list of services that support encryption.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecEncryptionServices
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.EncryptionService
    /// A service that allows server-side encryption to be used.
    /// </summary>
    [JsonPropertyName("blob")]
    public V1api20230101storageStorageAccountSpecEncryptionServicesBlob? Blob { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.EncryptionService
    /// A service that allows server-side encryption to be used.
    /// </summary>
    [JsonPropertyName("file")]
    public V1api20230101storageStorageAccountSpecEncryptionServicesFile? File { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.EncryptionService
    /// A service that allows server-side encryption to be used.
    /// </summary>
    [JsonPropertyName("queue")]
    public V1api20230101storageStorageAccountSpecEncryptionServicesQueue? Queue { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.EncryptionService
    /// A service that allows server-side encryption to be used.
    /// </summary>
    [JsonPropertyName("table")]
    public V1api20230101storageStorageAccountSpecEncryptionServicesTable? Table { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.Encryption
/// The encryption settings on the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecEncryption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.EncryptionIdentity
    /// Encryption identity for the storage account.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20230101storageStorageAccountSpecEncryptionIdentity? Identity { get; set; }

    [JsonPropertyName("keySource")]
    public string? KeySource { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.KeyVaultProperties
    /// Properties of key vault.
    /// </summary>
    [JsonPropertyName("keyvaultproperties")]
    public V1api20230101storageStorageAccountSpecEncryptionKeyvaultproperties? Keyvaultproperties { get; set; }

    [JsonPropertyName("requireInfrastructureEncryption")]
    public bool? RequireInfrastructureEncryption { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.EncryptionServices
    /// A list of services that support encryption.
    /// </summary>
    [JsonPropertyName("services")]
    public V1api20230101storageStorageAccountSpecEncryptionServices? Services { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.ExtendedLocation
/// The complex type of the extended location.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecExtendedLocation
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

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecIdentityUserAssignedIdentitiesReference
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
/// Storage version of v1api20230101.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20230101storageStorageAccountSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.Identity
/// Identity for the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecIdentity
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
    public IList<V1api20230101storageStorageAccountSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.AccountImmutabilityPolicyProperties
/// This defines account-level immutability policy properties.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecImmutableStorageWithVersioningImmutabilityPolicy
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
/// Storage version of v1api20230101.ImmutableStorageAccount
/// This property enables and defines account-level immutability. Enabling the feature auto-enables Blob Versioning.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecImmutableStorageWithVersioning
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
    /// Storage version of v1api20230101.AccountImmutabilityPolicyProperties
    /// This defines account-level immutability policy properties.
    /// </summary>
    [JsonPropertyName("immutabilityPolicy")]
    public V1api20230101storageStorageAccountSpecImmutableStorageWithVersioningImmutabilityPolicy? ImmutabilityPolicy { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.KeyPolicy
/// KeyPolicy assigned to the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecKeyPolicy
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecNetworkAclsIpRulesValueFromConfig
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
/// Storage version of v1api20230101.IPRule
/// IP rule with specific IP or IP range in CIDR format.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecNetworkAclsIpRules
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
    public V1api20230101storageStorageAccountSpecNetworkAclsIpRulesValueFromConfig? ValueFromConfig { get; set; }
}

/// <summary>ResourceReference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecNetworkAclsResourceAccessRulesResourceReference
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
/// Storage version of v1api20230101.ResourceAccessRule
/// Resource Access Rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecNetworkAclsResourceAccessRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference: Resource Id</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20230101storageStorageAccountSpecNetworkAclsResourceAccessRulesResourceReference? ResourceReference { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>
/// Reference: Resource ID of a subnet, for example:
/// /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecNetworkAclsVirtualNetworkRulesReference
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
/// Storage version of v1api20230101.VirtualNetworkRule
/// Virtual Network rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecNetworkAclsVirtualNetworkRules
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
    public required V1api20230101storageStorageAccountSpecNetworkAclsVirtualNetworkRulesReference Reference { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.NetworkRuleSet
/// Network rule set
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecNetworkAcls
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
    public IList<V1api20230101storageStorageAccountSpecNetworkAclsIpRules>? IpRules { get; set; }

    [JsonPropertyName("resourceAccessRules")]
    public IList<V1api20230101storageStorageAccountSpecNetworkAclsResourceAccessRules>? ResourceAccessRules { get; set; }

    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20230101storageStorageAccountSpecNetworkAclsVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecConfigMapsBlobEndpoint
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecConfigMapsDfsEndpoint
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecConfigMapsFileEndpoint
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecConfigMapsQueueEndpoint
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecConfigMapsTableEndpoint
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecConfigMapsWebEndpoint
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

/// <summary>Storage version of v1api20230101.StorageAccountOperatorConfigMaps</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecConfigMaps
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
    public V1api20230101storageStorageAccountSpecOperatorSpecConfigMapsBlobEndpoint? BlobEndpoint { get; set; }

    /// <summary>
    /// ConfigMapDestination describes the location to store a single configmap value
    /// Note: This is similar to: SecretDestination in secrets.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("dfsEndpoint")]
    public V1api20230101storageStorageAccountSpecOperatorSpecConfigMapsDfsEndpoint? DfsEndpoint { get; set; }

    /// <summary>
    /// ConfigMapDestination describes the location to store a single configmap value
    /// Note: This is similar to: SecretDestination in secrets.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("fileEndpoint")]
    public V1api20230101storageStorageAccountSpecOperatorSpecConfigMapsFileEndpoint? FileEndpoint { get; set; }

    /// <summary>
    /// ConfigMapDestination describes the location to store a single configmap value
    /// Note: This is similar to: SecretDestination in secrets.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("queueEndpoint")]
    public V1api20230101storageStorageAccountSpecOperatorSpecConfigMapsQueueEndpoint? QueueEndpoint { get; set; }

    /// <summary>
    /// ConfigMapDestination describes the location to store a single configmap value
    /// Note: This is similar to: SecretDestination in secrets.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("tableEndpoint")]
    public V1api20230101storageStorageAccountSpecOperatorSpecConfigMapsTableEndpoint? TableEndpoint { get; set; }

    /// <summary>
    /// ConfigMapDestination describes the location to store a single configmap value
    /// Note: This is similar to: SecretDestination in secrets.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("webEndpoint")]
    public V1api20230101storageStorageAccountSpecOperatorSpecConfigMapsWebEndpoint? WebEndpoint { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecSecretsBlobEndpoint
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecSecretsDfsEndpoint
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecSecretsFileEndpoint
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecSecretsKey1
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecSecretsKey2
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecSecretsQueueEndpoint
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecSecretsTableEndpoint
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecSecretsWebEndpoint
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

/// <summary>Storage version of v1api20230101.StorageAccountOperatorSecrets</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpecSecrets
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
    public V1api20230101storageStorageAccountSpecOperatorSpecSecretsBlobEndpoint? BlobEndpoint { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("dfsEndpoint")]
    public V1api20230101storageStorageAccountSpecOperatorSpecSecretsDfsEndpoint? DfsEndpoint { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("fileEndpoint")]
    public V1api20230101storageStorageAccountSpecOperatorSpecSecretsFileEndpoint? FileEndpoint { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("key1")]
    public V1api20230101storageStorageAccountSpecOperatorSpecSecretsKey1? Key1 { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("key2")]
    public V1api20230101storageStorageAccountSpecOperatorSpecSecretsKey2? Key2 { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("queueEndpoint")]
    public V1api20230101storageStorageAccountSpecOperatorSpecSecretsQueueEndpoint? QueueEndpoint { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("tableEndpoint")]
    public V1api20230101storageStorageAccountSpecOperatorSpecSecretsTableEndpoint? TableEndpoint { get; set; }

    /// <summary>
    /// SecretDestination describes the location to store a single secret value.
    /// Note: This is similar to: ConfigMapDestination in configmaps.go.
    /// Changes to one may need to be made to the others as well.
    /// </summary>
    [JsonPropertyName("webEndpoint")]
    public V1api20230101storageStorageAccountSpecOperatorSpecSecretsWebEndpoint? WebEndpoint { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.StorageAccountOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20230101storageStorageAccountSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>Storage version of v1api20230101.StorageAccountOperatorConfigMaps</summary>
    [JsonPropertyName("configMaps")]
    public V1api20230101storageStorageAccountSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20230101storageStorageAccountSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Storage version of v1api20230101.StorageAccountOperatorSecrets</summary>
    [JsonPropertyName("secrets")]
    public V1api20230101storageStorageAccountSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.RoutingPreference
/// Routing preference defines the type of network, either microsoft or internet routing to be used to deliver the user
/// data, the default option is microsoft routing
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecRoutingPreference
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
/// Storage version of v1api20230101.SasPolicy
/// SasPolicy assigned to the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecSasPolicy
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
/// Storage version of v1api20230101.Sku
/// The SKU of the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpecSku
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

/// <summary>Storage version of v1api20230101.StorageAccount_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountSpec
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
    /// Storage version of v1api20230101.AzureFilesIdentityBasedAuthentication
    /// Settings for Azure Files identity based authentication.
    /// </summary>
    [JsonPropertyName("azureFilesIdentityBasedAuthentication")]
    public V1api20230101storageStorageAccountSpecAzureFilesIdentityBasedAuthentication? AzureFilesIdentityBasedAuthentication { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.CustomDomain
    /// The custom domain assigned to this storage account. This can be set via Update.
    /// </summary>
    [JsonPropertyName("customDomain")]
    public V1api20230101storageStorageAccountSpecCustomDomain? CustomDomain { get; set; }

    [JsonPropertyName("defaultToOAuthAuthentication")]
    public bool? DefaultToOAuthAuthentication { get; set; }

    [JsonPropertyName("dnsEndpointType")]
    public string? DnsEndpointType { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.Encryption
    /// The encryption settings on the storage account.
    /// </summary>
    [JsonPropertyName("encryption")]
    public V1api20230101storageStorageAccountSpecEncryption? Encryption { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.ExtendedLocation
    /// The complex type of the extended location.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20230101storageStorageAccountSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.Identity
    /// Identity for the resource.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20230101storageStorageAccountSpecIdentity? Identity { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.ImmutableStorageAccount
    /// This property enables and defines account-level immutability. Enabling the feature auto-enables Blob Versioning.
    /// </summary>
    [JsonPropertyName("immutableStorageWithVersioning")]
    public V1api20230101storageStorageAccountSpecImmutableStorageWithVersioning? ImmutableStorageWithVersioning { get; set; }

    [JsonPropertyName("isHnsEnabled")]
    public bool? IsHnsEnabled { get; set; }

    [JsonPropertyName("isLocalUserEnabled")]
    public bool? IsLocalUserEnabled { get; set; }

    [JsonPropertyName("isNfsV3Enabled")]
    public bool? IsNfsV3Enabled { get; set; }

    [JsonPropertyName("isSftpEnabled")]
    public bool? IsSftpEnabled { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.KeyPolicy
    /// KeyPolicy assigned to the storage account.
    /// </summary>
    [JsonPropertyName("keyPolicy")]
    public V1api20230101storageStorageAccountSpecKeyPolicy? KeyPolicy { get; set; }

    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    [JsonPropertyName("largeFileSharesState")]
    public string? LargeFileSharesState { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.NetworkRuleSet
    /// Network rule set
    /// </summary>
    [JsonPropertyName("networkAcls")]
    public V1api20230101storageStorageAccountSpecNetworkAcls? NetworkAcls { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.StorageAccountOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20230101storageStorageAccountSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20230101storageStorageAccountSpecOwner Owner { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.RoutingPreference
    /// Routing preference defines the type of network, either microsoft or internet routing to be used to deliver the user
    /// data, the default option is microsoft routing
    /// </summary>
    [JsonPropertyName("routingPreference")]
    public V1api20230101storageStorageAccountSpecRoutingPreference? RoutingPreference { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.SasPolicy
    /// SasPolicy assigned to the storage account.
    /// </summary>
    [JsonPropertyName("sasPolicy")]
    public V1api20230101storageStorageAccountSpecSasPolicy? SasPolicy { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.Sku
    /// The SKU of the storage account.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20230101storageStorageAccountSpecSku? Sku { get; set; }

    [JsonPropertyName("supportsHttpsTrafficOnly")]
    public bool? SupportsHttpsTrafficOnly { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.ActiveDirectoryProperties_STATUS
/// Settings properties for Active Directory (AD).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusAzureFilesIdentityBasedAuthenticationActiveDirectoryProperties
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
/// Storage version of v1api20230101.AzureFilesIdentityBasedAuthentication_STATUS
/// Settings for Azure Files identity based authentication.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusAzureFilesIdentityBasedAuthentication
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.ActiveDirectoryProperties_STATUS
    /// Settings properties for Active Directory (AD).
    /// </summary>
    [JsonPropertyName("activeDirectoryProperties")]
    public V1api20230101storageStorageAccountStatusAzureFilesIdentityBasedAuthenticationActiveDirectoryProperties? ActiveDirectoryProperties { get; set; }

    [JsonPropertyName("defaultSharePermission")]
    public string? DefaultSharePermission { get; set; }

    [JsonPropertyName("directoryServiceOptions")]
    public string? DirectoryServiceOptions { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.BlobRestoreRange_STATUS
/// Blob range
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusBlobRestoreStatusParametersBlobRanges
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
/// Storage version of v1api20230101.BlobRestoreParameters_STATUS
/// Blob restore parameters
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusBlobRestoreStatusParameters
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("blobRanges")]
    public IList<V1api20230101storageStorageAccountStatusBlobRestoreStatusParametersBlobRanges>? BlobRanges { get; set; }

    [JsonPropertyName("timeToRestore")]
    public string? TimeToRestore { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.BlobRestoreStatus_STATUS
/// Blob restore status.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusBlobRestoreStatus
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
    /// Storage version of v1api20230101.BlobRestoreParameters_STATUS
    /// Blob restore parameters
    /// </summary>
    [JsonPropertyName("parameters")]
    public V1api20230101storageStorageAccountStatusBlobRestoreStatusParameters? Parameters { get; set; }

    [JsonPropertyName("restoreId")]
    public string? RestoreId { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusConditions
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
/// Storage version of v1api20230101.CustomDomain_STATUS
/// The custom domain assigned to this storage account. This can be set via Update.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusCustomDomain
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
/// Storage version of v1api20230101.EncryptionIdentity_STATUS
/// Encryption identity for the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusEncryptionIdentity
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
/// Storage version of v1api20230101.KeyVaultProperties_STATUS
/// Properties of key vault.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusEncryptionKeyvaultproperties
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
/// Storage version of v1api20230101.EncryptionService_STATUS
/// A service that allows server-side encryption to be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusEncryptionServicesBlob
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
/// Storage version of v1api20230101.EncryptionService_STATUS
/// A service that allows server-side encryption to be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusEncryptionServicesFile
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
/// Storage version of v1api20230101.EncryptionService_STATUS
/// A service that allows server-side encryption to be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusEncryptionServicesQueue
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
/// Storage version of v1api20230101.EncryptionService_STATUS
/// A service that allows server-side encryption to be used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusEncryptionServicesTable
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
/// Storage version of v1api20230101.EncryptionServices_STATUS
/// A list of services that support encryption.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusEncryptionServices
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.EncryptionService_STATUS
    /// A service that allows server-side encryption to be used.
    /// </summary>
    [JsonPropertyName("blob")]
    public V1api20230101storageStorageAccountStatusEncryptionServicesBlob? Blob { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.EncryptionService_STATUS
    /// A service that allows server-side encryption to be used.
    /// </summary>
    [JsonPropertyName("file")]
    public V1api20230101storageStorageAccountStatusEncryptionServicesFile? File { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.EncryptionService_STATUS
    /// A service that allows server-side encryption to be used.
    /// </summary>
    [JsonPropertyName("queue")]
    public V1api20230101storageStorageAccountStatusEncryptionServicesQueue? Queue { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.EncryptionService_STATUS
    /// A service that allows server-side encryption to be used.
    /// </summary>
    [JsonPropertyName("table")]
    public V1api20230101storageStorageAccountStatusEncryptionServicesTable? Table { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.Encryption_STATUS
/// The encryption settings on the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusEncryption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.EncryptionIdentity_STATUS
    /// Encryption identity for the storage account.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20230101storageStorageAccountStatusEncryptionIdentity? Identity { get; set; }

    [JsonPropertyName("keySource")]
    public string? KeySource { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.KeyVaultProperties_STATUS
    /// Properties of key vault.
    /// </summary>
    [JsonPropertyName("keyvaultproperties")]
    public V1api20230101storageStorageAccountStatusEncryptionKeyvaultproperties? Keyvaultproperties { get; set; }

    [JsonPropertyName("requireInfrastructureEncryption")]
    public bool? RequireInfrastructureEncryption { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.EncryptionServices_STATUS
    /// A list of services that support encryption.
    /// </summary>
    [JsonPropertyName("services")]
    public V1api20230101storageStorageAccountStatusEncryptionServices? Services { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.ExtendedLocation_STATUS
/// The complex type of the extended location.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusExtendedLocation
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
/// Storage version of v1api20230101.GeoReplicationStats_STATUS
/// Statistics related to replication for storage account&apos;s Blob, Table, Queue and File services. It is only available when
/// geo-redundant replication is enabled for the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusGeoReplicationStats
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
/// Storage version of v1api20230101.UserAssignedIdentity_STATUS
/// UserAssignedIdentity for the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusIdentityUserAssignedIdentities
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
/// Storage version of v1api20230101.Identity_STATUS
/// Identity for the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusIdentity
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
    public IDictionary<string, V1api20230101storageStorageAccountStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.AccountImmutabilityPolicyProperties_STATUS
/// This defines account-level immutability policy properties.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusImmutableStorageWithVersioningImmutabilityPolicy
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
/// Storage version of v1api20230101.ImmutableStorageAccount_STATUS
/// This property enables and defines account-level immutability. Enabling the feature auto-enables Blob Versioning.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusImmutableStorageWithVersioning
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
    /// Storage version of v1api20230101.AccountImmutabilityPolicyProperties_STATUS
    /// This defines account-level immutability policy properties.
    /// </summary>
    [JsonPropertyName("immutabilityPolicy")]
    public V1api20230101storageStorageAccountStatusImmutableStorageWithVersioningImmutabilityPolicy? ImmutabilityPolicy { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.KeyCreationTime_STATUS
/// Storage account keys creation time.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusKeyCreationTime
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
/// Storage version of v1api20230101.KeyPolicy_STATUS
/// KeyPolicy assigned to the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusKeyPolicy
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
/// Storage version of v1api20230101.IPRule_STATUS
/// IP rule with specific IP or IP range in CIDR format.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusNetworkAclsIpRules
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
/// Storage version of v1api20230101.ResourceAccessRule_STATUS
/// Resource Access Rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusNetworkAclsResourceAccessRules
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
/// Storage version of v1api20230101.VirtualNetworkRule_STATUS
/// Virtual Network rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusNetworkAclsVirtualNetworkRules
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
/// Storage version of v1api20230101.NetworkRuleSet_STATUS
/// Network rule set
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusNetworkAcls
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
    public IList<V1api20230101storageStorageAccountStatusNetworkAclsIpRules>? IpRules { get; set; }

    [JsonPropertyName("resourceAccessRules")]
    public IList<V1api20230101storageStorageAccountStatusNetworkAclsResourceAccessRules>? ResourceAccessRules { get; set; }

    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20230101storageStorageAccountStatusNetworkAclsVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.StorageAccountInternetEndpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusPrimaryEndpointsInternetEndpoints
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
/// Storage version of v1api20230101.StorageAccountMicrosoftEndpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing
/// endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusPrimaryEndpointsMicrosoftEndpoints
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
/// Storage version of v1api20230101.Endpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusPrimaryEndpoints
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
    /// Storage version of v1api20230101.StorageAccountInternetEndpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint.
    /// </summary>
    [JsonPropertyName("internetEndpoints")]
    public V1api20230101storageStorageAccountStatusPrimaryEndpointsInternetEndpoints? InternetEndpoints { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.StorageAccountMicrosoftEndpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing
    /// endpoint.
    /// </summary>
    [JsonPropertyName("microsoftEndpoints")]
    public V1api20230101storageStorageAccountStatusPrimaryEndpointsMicrosoftEndpoints? MicrosoftEndpoints { get; set; }

    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    [JsonPropertyName("table")]
    public string? Table { get; set; }

    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.PrivateEndpointConnection_STATUS
/// The Private Endpoint Connection resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusPrivateEndpointConnections
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
/// Storage version of v1api20230101.RoutingPreference_STATUS
/// Routing preference defines the type of network, either microsoft or internet routing to be used to deliver the user
/// data, the default option is microsoft routing
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusRoutingPreference
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
/// Storage version of v1api20230101.SasPolicy_STATUS
/// SasPolicy assigned to the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusSasPolicy
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
/// Storage version of v1api20230101.StorageAccountInternetEndpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusSecondaryEndpointsInternetEndpoints
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
/// Storage version of v1api20230101.StorageAccountMicrosoftEndpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing
/// endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusSecondaryEndpointsMicrosoftEndpoints
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
/// Storage version of v1api20230101.Endpoints_STATUS
/// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusSecondaryEndpoints
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
    /// Storage version of v1api20230101.StorageAccountInternetEndpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, file, web or dfs object via a internet routing endpoint.
    /// </summary>
    [JsonPropertyName("internetEndpoints")]
    public V1api20230101storageStorageAccountStatusSecondaryEndpointsInternetEndpoints? InternetEndpoints { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.StorageAccountMicrosoftEndpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing
    /// endpoint.
    /// </summary>
    [JsonPropertyName("microsoftEndpoints")]
    public V1api20230101storageStorageAccountStatusSecondaryEndpointsMicrosoftEndpoints? MicrosoftEndpoints { get; set; }

    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    [JsonPropertyName("table")]
    public string? Table { get; set; }

    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.Sku_STATUS
/// The SKU of the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusSku
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
/// Storage version of v1api20230101.StorageAccountSkuConversionStatus_STATUS
/// This defines the sku conversion status object for asynchronous sku conversions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatusStorageAccountSkuConversionStatus
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
/// Storage version of v1api20230101.StorageAccount_STATUS
/// The storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20230101storageStorageAccountStatus
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
    /// Storage version of v1api20230101.AzureFilesIdentityBasedAuthentication_STATUS
    /// Settings for Azure Files identity based authentication.
    /// </summary>
    [JsonPropertyName("azureFilesIdentityBasedAuthentication")]
    public V1api20230101storageStorageAccountStatusAzureFilesIdentityBasedAuthentication? AzureFilesIdentityBasedAuthentication { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.BlobRestoreStatus_STATUS
    /// Blob restore status.
    /// </summary>
    [JsonPropertyName("blobRestoreStatus")]
    public V1api20230101storageStorageAccountStatusBlobRestoreStatus? BlobRestoreStatus { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20230101storageStorageAccountStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.CustomDomain_STATUS
    /// The custom domain assigned to this storage account. This can be set via Update.
    /// </summary>
    [JsonPropertyName("customDomain")]
    public V1api20230101storageStorageAccountStatusCustomDomain? CustomDomain { get; set; }

    [JsonPropertyName("defaultToOAuthAuthentication")]
    public bool? DefaultToOAuthAuthentication { get; set; }

    [JsonPropertyName("dnsEndpointType")]
    public string? DnsEndpointType { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.Encryption_STATUS
    /// The encryption settings on the storage account.
    /// </summary>
    [JsonPropertyName("encryption")]
    public V1api20230101storageStorageAccountStatusEncryption? Encryption { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.ExtendedLocation_STATUS
    /// The complex type of the extended location.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20230101storageStorageAccountStatusExtendedLocation? ExtendedLocation { get; set; }

    [JsonPropertyName("failoverInProgress")]
    public bool? FailoverInProgress { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.GeoReplicationStats_STATUS
    /// Statistics related to replication for storage account&apos;s Blob, Table, Queue and File services. It is only available when
    /// geo-redundant replication is enabled for the storage account.
    /// </summary>
    [JsonPropertyName("geoReplicationStats")]
    public V1api20230101storageStorageAccountStatusGeoReplicationStats? GeoReplicationStats { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.Identity_STATUS
    /// Identity for the resource.
    /// </summary>
    [JsonPropertyName("identity")]
    public V1api20230101storageStorageAccountStatusIdentity? Identity { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.ImmutableStorageAccount_STATUS
    /// This property enables and defines account-level immutability. Enabling the feature auto-enables Blob Versioning.
    /// </summary>
    [JsonPropertyName("immutableStorageWithVersioning")]
    public V1api20230101storageStorageAccountStatusImmutableStorageWithVersioning? ImmutableStorageWithVersioning { get; set; }

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
    /// Storage version of v1api20230101.KeyCreationTime_STATUS
    /// Storage account keys creation time.
    /// </summary>
    [JsonPropertyName("keyCreationTime")]
    public V1api20230101storageStorageAccountStatusKeyCreationTime? KeyCreationTime { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.KeyPolicy_STATUS
    /// KeyPolicy assigned to the storage account.
    /// </summary>
    [JsonPropertyName("keyPolicy")]
    public V1api20230101storageStorageAccountStatusKeyPolicy? KeyPolicy { get; set; }

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
    /// Storage version of v1api20230101.NetworkRuleSet_STATUS
    /// Network rule set
    /// </summary>
    [JsonPropertyName("networkAcls")]
    public V1api20230101storageStorageAccountStatusNetworkAcls? NetworkAcls { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.Endpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
    /// </summary>
    [JsonPropertyName("primaryEndpoints")]
    public V1api20230101storageStorageAccountStatusPrimaryEndpoints? PrimaryEndpoints { get; set; }

    [JsonPropertyName("primaryLocation")]
    public string? PrimaryLocation { get; set; }

    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20230101storageStorageAccountStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.RoutingPreference_STATUS
    /// Routing preference defines the type of network, either microsoft or internet routing to be used to deliver the user
    /// data, the default option is microsoft routing
    /// </summary>
    [JsonPropertyName("routingPreference")]
    public V1api20230101storageStorageAccountStatusRoutingPreference? RoutingPreference { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.SasPolicy_STATUS
    /// SasPolicy assigned to the storage account.
    /// </summary>
    [JsonPropertyName("sasPolicy")]
    public V1api20230101storageStorageAccountStatusSasPolicy? SasPolicy { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.Endpoints_STATUS
    /// The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object.
    /// </summary>
    [JsonPropertyName("secondaryEndpoints")]
    public V1api20230101storageStorageAccountStatusSecondaryEndpoints? SecondaryEndpoints { get; set; }

    [JsonPropertyName("secondaryLocation")]
    public string? SecondaryLocation { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.Sku_STATUS
    /// The SKU of the storage account.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20230101storageStorageAccountStatusSku? Sku { get; set; }

    [JsonPropertyName("statusOfPrimary")]
    public string? StatusOfPrimary { get; set; }

    [JsonPropertyName("statusOfSecondary")]
    public string? StatusOfSecondary { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.StorageAccountSkuConversionStatus_STATUS
    /// This defines the sku conversion status object for asynchronous sku conversions.
    /// </summary>
    [JsonPropertyName("storageAccountSkuConversionStatus")]
    public V1api20230101storageStorageAccountStatusStorageAccountSkuConversionStatus? StorageAccountSkuConversionStatus { get; set; }

    [JsonPropertyName("supportsHttpsTrafficOnly")]
    public bool? SupportsHttpsTrafficOnly { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20230101.StorageAccount
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2023-01-01/storage.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20230101storageStorageAccount : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20230101storageStorageAccountSpec?>, IStatus<V1api20230101storageStorageAccountStatus?>
{
    public const string KubeApiVersion = "v1api20230101storage";
    public const string KubeKind = "StorageAccount";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v1api20230101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccount";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20230101.StorageAccount_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20230101storageStorageAccountSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v1api20230101.StorageAccount_STATUS
    /// The storage account.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20230101storageStorageAccountStatus? Status { get; set; }
}