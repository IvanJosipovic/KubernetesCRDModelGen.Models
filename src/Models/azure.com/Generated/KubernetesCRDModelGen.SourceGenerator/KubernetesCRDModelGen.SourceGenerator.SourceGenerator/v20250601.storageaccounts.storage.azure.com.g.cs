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
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2025-06-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250601StorageAccountList : IKubernetesObject<V1ListMeta>, IItems<V20250601StorageAccount>
{
    public const string KubeApiVersion = "v20250601";
    public const string KubeKind = "StorageAccountList";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20250601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250601StorageAccount objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250601StorageAccount> Items { get; set; }
}

/// <summary>
/// AccessTier: Required for storage accounts where kind = BlobStorage. The access tier is used for billing. The &apos;Premium&apos;
/// access tier is the default value for premium block blobs storage account type and it cannot be changed for the premium
/// block blobs storage account type.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecAccessTierEnum>))]
public enum V20250601StorageAccountSpecAccessTierEnum
{
    [EnumMember(Value = "Cold"), JsonStringEnumMemberName("Cold")]
    Cold,
    [EnumMember(Value = "Cool"), JsonStringEnumMemberName("Cool")]
    Cool,
    [EnumMember(Value = "Hot"), JsonStringEnumMemberName("Hot")]
    Hot,
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium
}

/// <summary>AllowedCopyScope: Restrict copy to and from Storage Accounts within an AAD tenant or with Private Links to the same VNet.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecAllowedCopyScopeEnum>))]
public enum V20250601StorageAccountSpecAllowedCopyScopeEnum
{
    [EnumMember(Value = "AAD"), JsonStringEnumMemberName("AAD")]
    AAD,
    [EnumMember(Value = "PrivateLink"), JsonStringEnumMemberName("PrivateLink")]
    PrivateLink
}

/// <summary>
/// AccountType: Specifies the Active Directory account type for Azure Storage. If directoryServiceOptions is set to AD (AD
/// DS authentication), this property is optional. If provided, samAccountName should also be provided. For
/// directoryServiceOptions AADDS (Entra DS authentication) or AADKERB (Entra authentication), this property can be omitted.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecAzureFilesIdentityBasedAuthenticationActiveDirectoryPropertiesAccountTypeEnum>))]
public enum V20250601StorageAccountSpecAzureFilesIdentityBasedAuthenticationActiveDirectoryPropertiesAccountTypeEnum
{
    [EnumMember(Value = "Computer"), JsonStringEnumMemberName("Computer")]
    Computer,
    [EnumMember(Value = "User"), JsonStringEnumMemberName("User")]
    User
}

/// <summary>
/// ActiveDirectoryProperties: Additional information about the directory service. Required if directoryServiceOptions is AD
/// (AD DS authentication). Optional for directoryServiceOptions AADDS (Entra DS authentication) and AADKERB (Entra
/// authentication).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecAzureFilesIdentityBasedAuthenticationActiveDirectoryProperties
{
    /// <summary>
    /// AccountType: Specifies the Active Directory account type for Azure Storage. If directoryServiceOptions is set to AD (AD
    /// DS authentication), this property is optional. If provided, samAccountName should also be provided. For
    /// directoryServiceOptions AADDS (Entra DS authentication) or AADKERB (Entra authentication), this property can be omitted.
    /// </summary>
    [JsonPropertyName("accountType")]
    public V20250601StorageAccountSpecAzureFilesIdentityBasedAuthenticationActiveDirectoryPropertiesAccountTypeEnum? AccountType { get; set; }

    /// <summary>
    /// AzureStorageSid: Specifies the security identifier (SID) for Azure Storage. If directoryServiceOptions is set to AD (AD
    /// DS authentication), this property is required. Otherwise, it can be omitted.
    /// </summary>
    [JsonPropertyName("azureStorageSid")]
    public string? AzureStorageSid { get; set; }

    /// <summary>
    /// DomainGuid: Specifies the domain GUID. If directoryServiceOptions is set to AD (AD DS authentication), this property is
    /// required. If directoryServiceOptions is set to AADDS (Entra DS authentication), this property can be omitted. If
    /// directoryServiceOptions is set to AADKERB (Entra authentication), this property is optional; it is needed to support
    /// configuration of directory- and file-level permissions via Windows File Explorer, but is not required for authentication.
    /// </summary>
    [JsonPropertyName("domainGuid")]
    public string? DomainGuid { get; set; }

    /// <summary>
    /// DomainName: Specifies the primary domain that the AD DNS server is authoritative for. This property is required if
    /// directoryServiceOptions is set to AD (AD DS authentication). If directoryServiceOptions is set to AADDS (Entra DS
    /// authentication), providing this property is optional, as it will be inferred automatically if omitted. If
    /// directoryServiceOptions is set to AADKERB (Entra authentication), this property is optional; it is needed to support
    /// configuration of directory- and file-level permissions via Windows File Explorer, but is not required for authentication.
    /// </summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>
    /// DomainSid: Specifies the security identifier (SID) of the AD domain. If directoryServiceOptions is set to AD (AD DS
    /// authentication), this property is required. Otherwise, it can be omitted.
    /// </summary>
    [JsonPropertyName("domainSid")]
    public string? DomainSid { get; set; }

    /// <summary>
    /// ForestName: Specifies the Active Directory forest to get. If directoryServiceOptions is set to AD (AD DS
    /// authentication), this property is required. Otherwise, it can be omitted.
    /// </summary>
    [JsonPropertyName("forestName")]
    public string? ForestName { get; set; }

    /// <summary>
    /// NetBiosDomainName: Specifies the NetBIOS domain name. If directoryServiceOptions is set to AD (AD DS authentication),
    /// this property is required. Otherwise, it can be omitted.
    /// </summary>
    [JsonPropertyName("netBiosDomainName")]
    public string? NetBiosDomainName { get; set; }

    /// <summary>
    /// SamAccountName: Specifies the Active Directory SAMAccountName for Azure Storage. If directoryServiceOptions is set to AD
    /// (AD DS authentication), this property is optional. If provided, accountType should also be provided. For
    /// directoryServiceOptions AADDS (Entra DS authentication) or AADKERB (Entra authentication), this property can be omitted.
    /// </summary>
    [JsonPropertyName("samAccountName")]
    public string? SamAccountName { get; set; }
}

/// <summary>DefaultSharePermission: Default share permission for users using Kerberos authentication if RBAC role is not assigned.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecAzureFilesIdentityBasedAuthenticationDefaultSharePermissionEnum>))]
public enum V20250601StorageAccountSpecAzureFilesIdentityBasedAuthenticationDefaultSharePermissionEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "StorageFileDataSmbShareContributor"), JsonStringEnumMemberName("StorageFileDataSmbShareContributor")]
    StorageFileDataSmbShareContributor,
    [EnumMember(Value = "StorageFileDataSmbShareElevatedContributor"), JsonStringEnumMemberName("StorageFileDataSmbShareElevatedContributor")]
    StorageFileDataSmbShareElevatedContributor,
    [EnumMember(Value = "StorageFileDataSmbShareReader"), JsonStringEnumMemberName("StorageFileDataSmbShareReader")]
    StorageFileDataSmbShareReader
}

/// <summary>DirectoryServiceOptions: Indicates the directory service used. Note that this enum may be extended in the future.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecAzureFilesIdentityBasedAuthenticationDirectoryServiceOptionsEnum>))]
public enum V20250601StorageAccountSpecAzureFilesIdentityBasedAuthenticationDirectoryServiceOptionsEnum
{
    [EnumMember(Value = "AADDS"), JsonStringEnumMemberName("AADDS")]
    AADDS,
    [EnumMember(Value = "AADKERB"), JsonStringEnumMemberName("AADKERB")]
    AADKERB,
    [EnumMember(Value = "AD"), JsonStringEnumMemberName("AD")]
    AD,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>SmbOAuthSettings: Required for Managed Identities access using OAuth over SMB.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecAzureFilesIdentityBasedAuthenticationSmbOAuthSettings
{
    /// <summary>
    /// IsSmbOAuthEnabled: Specifies if managed identities can access SMB shares using OAuth. The default interpretation is
    /// false for this property.
    /// </summary>
    [JsonPropertyName("isSmbOAuthEnabled")]
    public bool? IsSmbOAuthEnabled { get; set; }
}

/// <summary>AzureFilesIdentityBasedAuthentication: Provides the identity based authentication settings for Azure Files.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecAzureFilesIdentityBasedAuthentication
{
    /// <summary>
    /// ActiveDirectoryProperties: Additional information about the directory service. Required if directoryServiceOptions is AD
    /// (AD DS authentication). Optional for directoryServiceOptions AADDS (Entra DS authentication) and AADKERB (Entra
    /// authentication).
    /// </summary>
    [JsonPropertyName("activeDirectoryProperties")]
    public V20250601StorageAccountSpecAzureFilesIdentityBasedAuthenticationActiveDirectoryProperties? ActiveDirectoryProperties { get; set; }

    /// <summary>DefaultSharePermission: Default share permission for users using Kerberos authentication if RBAC role is not assigned.</summary>
    [JsonPropertyName("defaultSharePermission")]
    public V20250601StorageAccountSpecAzureFilesIdentityBasedAuthenticationDefaultSharePermissionEnum? DefaultSharePermission { get; set; }

    /// <summary>DirectoryServiceOptions: Indicates the directory service used. Note that this enum may be extended in the future.</summary>
    [JsonPropertyName("directoryServiceOptions")]
    public required V20250601StorageAccountSpecAzureFilesIdentityBasedAuthenticationDirectoryServiceOptionsEnum DirectoryServiceOptions { get; set; }

    /// <summary>SmbOAuthSettings: Required for Managed Identities access using OAuth over SMB.</summary>
    [JsonPropertyName("smbOAuthSettings")]
    public V20250601StorageAccountSpecAzureFilesIdentityBasedAuthenticationSmbOAuthSettings? SmbOAuthSettings { get; set; }
}

/// <summary>
/// CustomDomain: User domain assigned to the storage account. Name is the CNAME source. Only one custom domain is supported
/// per storage account at this time. To clear the existing custom domain, use an empty string for the custom domain name
/// property.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecCustomDomain
{
    /// <summary>Name: Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// UseSubDomainName: Indicates whether indirect CName validation is enabled. Default value is false. This should only be
    /// set on updates.
    /// </summary>
    [JsonPropertyName("useSubDomainName")]
    public bool? UseSubDomainName { get; set; }
}

/// <summary>
/// DnsEndpointType: Allows you to specify the type of endpoint. Set this to AzureDNSZone to create a large number of
/// accounts in a single subscription, which creates accounts in an Azure DNS Zone and the endpoint URL will have an
/// alphanumeric DNS Zone identifier.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecDnsEndpointTypeEnum>))]
public enum V20250601StorageAccountSpecDnsEndpointTypeEnum
{
    [EnumMember(Value = "AzureDnsZone"), JsonStringEnumMemberName("AzureDnsZone")]
    AzureDnsZone,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>DualStackEndpointPreference: Maintains information about the Internet protocol opted by the user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecDualStackEndpointPreference
{
    /// <summary>PublishIpv6Endpoint: A boolean flag which indicates whether IPv6 storage endpoints are to be published.</summary>
    [JsonPropertyName("publishIpv6Endpoint")]
    public bool? PublishIpv6Endpoint { get; set; }
}

/// <summary>
/// FederatedIdentityClientIdFromConfig: ClientId of the multi-tenant application to be used in conjunction with the
/// user-assigned identity for cross-tenant customer-managed-keys server-side encryption on the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecEncryptionIdentityFederatedIdentityClientIdFromConfig
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
public partial class V20250601StorageAccountSpecEncryptionIdentityUserAssignedIdentityReference
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

/// <summary>Identity: The identity to be used with service-side encryption at rest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecEncryptionIdentity
{
    /// <summary>
    /// FederatedIdentityClientId: ClientId of the multi-tenant application to be used in conjunction with the user-assigned
    /// identity for cross-tenant customer-managed-keys server-side encryption on the storage account.
    /// </summary>
    [JsonPropertyName("federatedIdentityClientId")]
    public string? FederatedIdentityClientId { get; set; }

    /// <summary>
    /// FederatedIdentityClientIdFromConfig: ClientId of the multi-tenant application to be used in conjunction with the
    /// user-assigned identity for cross-tenant customer-managed-keys server-side encryption on the storage account.
    /// </summary>
    [JsonPropertyName("federatedIdentityClientIdFromConfig")]
    public V20250601StorageAccountSpecEncryptionIdentityFederatedIdentityClientIdFromConfig? FederatedIdentityClientIdFromConfig { get; set; }

    /// <summary>
    /// UserAssignedIdentityReference: Resource identifier of the UserAssigned identity to be associated with server-side
    /// encryption on the storage account.
    /// </summary>
    [JsonPropertyName("userAssignedIdentityReference")]
    public V20250601StorageAccountSpecEncryptionIdentityUserAssignedIdentityReference? UserAssignedIdentityReference { get; set; }
}

/// <summary>
/// KeySource: The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage,
/// Microsoft.Keyvault
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecEncryptionKeySourceEnum>))]
public enum V20250601StorageAccountSpecEncryptionKeySourceEnum
{
    [EnumMember(Value = "Microsoft.Keyvault"), JsonStringEnumMemberName("Microsoft.Keyvault")]
    MicrosoftKeyvault,
    [EnumMember(Value = "Microsoft.Storage"), JsonStringEnumMemberName("Microsoft.Storage")]
    MicrosoftStorage
}

/// <summary>KeynameFromConfig: The name of KeyVault key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecEncryptionKeyvaultpropertiesKeynameFromConfig
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

/// <summary>KeyvaulturiFromConfig: The Uri of KeyVault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecEncryptionKeyvaultpropertiesKeyvaulturiFromConfig
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

/// <summary>KeyversionFromConfig: The version of KeyVault key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecEncryptionKeyvaultpropertiesKeyversionFromConfig
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

/// <summary>Keyvaultproperties: Properties provided by key vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecEncryptionKeyvaultproperties
{
    /// <summary>Keyname: The name of KeyVault key.</summary>
    [JsonPropertyName("keyname")]
    public string? Keyname { get; set; }

    /// <summary>KeynameFromConfig: The name of KeyVault key.</summary>
    [JsonPropertyName("keynameFromConfig")]
    public V20250601StorageAccountSpecEncryptionKeyvaultpropertiesKeynameFromConfig? KeynameFromConfig { get; set; }

    /// <summary>Keyvaulturi: The Uri of KeyVault.</summary>
    [JsonPropertyName("keyvaulturi")]
    public string? Keyvaulturi { get; set; }

    /// <summary>KeyvaulturiFromConfig: The Uri of KeyVault.</summary>
    [JsonPropertyName("keyvaulturiFromConfig")]
    public V20250601StorageAccountSpecEncryptionKeyvaultpropertiesKeyvaulturiFromConfig? KeyvaulturiFromConfig { get; set; }

    /// <summary>Keyversion: The version of KeyVault key.</summary>
    [JsonPropertyName("keyversion")]
    public string? Keyversion { get; set; }

    /// <summary>KeyversionFromConfig: The version of KeyVault key.</summary>
    [JsonPropertyName("keyversionFromConfig")]
    public V20250601StorageAccountSpecEncryptionKeyvaultpropertiesKeyversionFromConfig? KeyversionFromConfig { get; set; }
}

/// <summary>
/// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
/// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecEncryptionServicesBlobKeyTypeEnum>))]
public enum V20250601StorageAccountSpecEncryptionServicesBlobKeyTypeEnum
{
    [EnumMember(Value = "Account"), JsonStringEnumMemberName("Account")]
    Account,
    [EnumMember(Value = "Service"), JsonStringEnumMemberName("Service")]
    Service
}

/// <summary>Blob: The encryption function of the blob storage service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecEncryptionServicesBlob
{
    /// <summary>
    /// Enabled: A boolean indicating whether or not the service encrypts the data as it is stored. Encryption at rest is
    /// enabled by default today and cannot be disabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
    /// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
    /// </summary>
    [JsonPropertyName("keyType")]
    public V20250601StorageAccountSpecEncryptionServicesBlobKeyTypeEnum? KeyType { get; set; }
}

/// <summary>
/// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
/// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecEncryptionServicesFileKeyTypeEnum>))]
public enum V20250601StorageAccountSpecEncryptionServicesFileKeyTypeEnum
{
    [EnumMember(Value = "Account"), JsonStringEnumMemberName("Account")]
    Account,
    [EnumMember(Value = "Service"), JsonStringEnumMemberName("Service")]
    Service
}

/// <summary>File: The encryption function of the file storage service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecEncryptionServicesFile
{
    /// <summary>
    /// Enabled: A boolean indicating whether or not the service encrypts the data as it is stored. Encryption at rest is
    /// enabled by default today and cannot be disabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
    /// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
    /// </summary>
    [JsonPropertyName("keyType")]
    public V20250601StorageAccountSpecEncryptionServicesFileKeyTypeEnum? KeyType { get; set; }
}

/// <summary>
/// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
/// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecEncryptionServicesQueueKeyTypeEnum>))]
public enum V20250601StorageAccountSpecEncryptionServicesQueueKeyTypeEnum
{
    [EnumMember(Value = "Account"), JsonStringEnumMemberName("Account")]
    Account,
    [EnumMember(Value = "Service"), JsonStringEnumMemberName("Service")]
    Service
}

/// <summary>Queue: The encryption function of the queue storage service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecEncryptionServicesQueue
{
    /// <summary>
    /// Enabled: A boolean indicating whether or not the service encrypts the data as it is stored. Encryption at rest is
    /// enabled by default today and cannot be disabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
    /// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
    /// </summary>
    [JsonPropertyName("keyType")]
    public V20250601StorageAccountSpecEncryptionServicesQueueKeyTypeEnum? KeyType { get; set; }
}

/// <summary>
/// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
/// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecEncryptionServicesTableKeyTypeEnum>))]
public enum V20250601StorageAccountSpecEncryptionServicesTableKeyTypeEnum
{
    [EnumMember(Value = "Account"), JsonStringEnumMemberName("Account")]
    Account,
    [EnumMember(Value = "Service"), JsonStringEnumMemberName("Service")]
    Service
}

/// <summary>Table: The encryption function of the table storage service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecEncryptionServicesTable
{
    /// <summary>
    /// Enabled: A boolean indicating whether or not the service encrypts the data as it is stored. Encryption at rest is
    /// enabled by default today and cannot be disabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
    /// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
    /// </summary>
    [JsonPropertyName("keyType")]
    public V20250601StorageAccountSpecEncryptionServicesTableKeyTypeEnum? KeyType { get; set; }
}

/// <summary>Services: List of services which support encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecEncryptionServices
{
    /// <summary>Blob: The encryption function of the blob storage service.</summary>
    [JsonPropertyName("blob")]
    public V20250601StorageAccountSpecEncryptionServicesBlob? Blob { get; set; }

    /// <summary>File: The encryption function of the file storage service.</summary>
    [JsonPropertyName("file")]
    public V20250601StorageAccountSpecEncryptionServicesFile? File { get; set; }

    /// <summary>Queue: The encryption function of the queue storage service.</summary>
    [JsonPropertyName("queue")]
    public V20250601StorageAccountSpecEncryptionServicesQueue? Queue { get; set; }

    /// <summary>Table: The encryption function of the table storage service.</summary>
    [JsonPropertyName("table")]
    public V20250601StorageAccountSpecEncryptionServicesTable? Table { get; set; }
}

/// <summary>Encryption: Encryption settings to be used for server-side encryption for the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecEncryption
{
    /// <summary>Identity: The identity to be used with service-side encryption at rest.</summary>
    [JsonPropertyName("identity")]
    public V20250601StorageAccountSpecEncryptionIdentity? Identity { get; set; }

    /// <summary>
    /// KeySource: The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage,
    /// Microsoft.Keyvault
    /// </summary>
    [JsonPropertyName("keySource")]
    public V20250601StorageAccountSpecEncryptionKeySourceEnum? KeySource { get; set; }

    /// <summary>Keyvaultproperties: Properties provided by key vault.</summary>
    [JsonPropertyName("keyvaultproperties")]
    public V20250601StorageAccountSpecEncryptionKeyvaultproperties? Keyvaultproperties { get; set; }

    /// <summary>
    /// RequireInfrastructureEncryption: A boolean indicating whether or not the service applies a secondary layer of encryption
    /// with platform managed keys for data at rest.
    /// </summary>
    [JsonPropertyName("requireInfrastructureEncryption")]
    public bool? RequireInfrastructureEncryption { get; set; }

    /// <summary>Services: List of services which support encryption.</summary>
    [JsonPropertyName("services")]
    public V20250601StorageAccountSpecEncryptionServices? Services { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecExtendedLocationTypeEnum>))]
public enum V20250601StorageAccountSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>
/// ExtendedLocation: Optional. Set the extended location of the resource. If not set, the storage account will be created
/// in Azure main region. Otherwise it will be created in the specified extended location
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V20250601StorageAccountSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>GeoPriorityReplicationStatus: Status indicating whether Geo Priority Replication is enabled for the account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecGeoPriorityReplicationStatus
{
    /// <summary>IsBlobEnabled: Indicates whether Blob Geo Priority Replication is enabled for the storage account.</summary>
    [JsonPropertyName("isBlobEnabled")]
    public bool? IsBlobEnabled { get; set; }
}

/// <summary>Type: The identity type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecIdentityTypeEnum>))]
public enum V20250601StorageAccountSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned,UserAssigned"), JsonStringEnumMemberName("SystemAssigned,UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecIdentityUserAssignedIdentitiesReference
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

/// <summary>Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20250601StorageAccountSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecIdentity
{
    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public required V20250601StorageAccountSpecIdentityTypeEnum Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: Gets or sets a list of key value pairs that describe the set of User Assigned identities that
    /// will be used with this storage account. The key is the ARM resource identifier of the identity. Only 1 User Assigned
    /// identity is permitted here.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20250601StorageAccountSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// State: The ImmutabilityPolicy state defines the mode of the policy. Disabled state disables the policy, Unlocked state
/// allows increase and decrease of immutability retention time and also allows toggling allowProtectedAppendWrites
/// property, Locked state only allows the increase of the immutability retention time. A policy can only be created in a
/// Disabled or Unlocked state and can be toggled between the two states. Only a policy in an Unlocked state can transition
/// to a Locked state which cannot be reverted.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecImmutableStorageWithVersioningImmutabilityPolicyStateEnum>))]
public enum V20250601StorageAccountSpecImmutableStorageWithVersioningImmutabilityPolicyStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Locked"), JsonStringEnumMemberName("Locked")]
    Locked,
    [EnumMember(Value = "Unlocked"), JsonStringEnumMemberName("Unlocked")]
    Unlocked
}

/// <summary>
/// ImmutabilityPolicy: Specifies the default account-level immutability policy which is inherited and applied to objects
/// that do not possess an explicit immutability policy at the object level. The object-level immutability policy has higher
/// precedence than the container-level immutability policy, which has a higher precedence than the account-level
/// immutability policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecImmutableStorageWithVersioningImmutabilityPolicy
{
    /// <summary>
    /// AllowProtectedAppendWrites: This property can only be changed for disabled and unlocked time-based retention policies.
    /// When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only
    /// new blocks can be added and any existing blocks cannot be modified or deleted.
    /// </summary>
    [JsonPropertyName("allowProtectedAppendWrites")]
    public bool? AllowProtectedAppendWrites { get; set; }

    /// <summary>
    /// ImmutabilityPeriodSinceCreationInDays: The immutability period for the blobs in the container since the policy creation,
    /// in days.
    /// </summary>
    [JsonPropertyName("immutabilityPeriodSinceCreationInDays")]
    public int? ImmutabilityPeriodSinceCreationInDays { get; set; }

    /// <summary>
    /// State: The ImmutabilityPolicy state defines the mode of the policy. Disabled state disables the policy, Unlocked state
    /// allows increase and decrease of immutability retention time and also allows toggling allowProtectedAppendWrites
    /// property, Locked state only allows the increase of the immutability retention time. A policy can only be created in a
    /// Disabled or Unlocked state and can be toggled between the two states. Only a policy in an Unlocked state can transition
    /// to a Locked state which cannot be reverted.
    /// </summary>
    [JsonPropertyName("state")]
    public V20250601StorageAccountSpecImmutableStorageWithVersioningImmutabilityPolicyStateEnum? State { get; set; }
}

/// <summary>
/// ImmutableStorageWithVersioning: The property is immutable and can only be set to true at the account creation time. When
/// set to true, it enables object level immutability for all the new containers in the account by default.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecImmutableStorageWithVersioning
{
    /// <summary>
    /// Enabled: A boolean flag which enables account-level immutability. All the containers under such an account have
    /// object-level immutability enabled by default.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// ImmutabilityPolicy: Specifies the default account-level immutability policy which is inherited and applied to objects
    /// that do not possess an explicit immutability policy at the object level. The object-level immutability policy has higher
    /// precedence than the container-level immutability policy, which has a higher precedence than the account-level
    /// immutability policy.
    /// </summary>
    [JsonPropertyName("immutabilityPolicy")]
    public V20250601StorageAccountSpecImmutableStorageWithVersioningImmutabilityPolicy? ImmutabilityPolicy { get; set; }
}

/// <summary>KeyPolicy: KeyPolicy assigned to the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecKeyPolicy
{
    /// <summary>KeyExpirationPeriodInDays: The key expiration period in days.</summary>
    [JsonPropertyName("keyExpirationPeriodInDays")]
    public required int KeyExpirationPeriodInDays { get; set; }
}

/// <summary>Kind: Required. Indicates the type of storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecKindEnum>))]
public enum V20250601StorageAccountSpecKindEnum
{
    [EnumMember(Value = "BlobStorage"), JsonStringEnumMemberName("BlobStorage")]
    BlobStorage,
    [EnumMember(Value = "BlockBlobStorage"), JsonStringEnumMemberName("BlockBlobStorage")]
    BlockBlobStorage,
    [EnumMember(Value = "FileStorage"), JsonStringEnumMemberName("FileStorage")]
    FileStorage,
    [EnumMember(Value = "Storage"), JsonStringEnumMemberName("Storage")]
    Storage,
    [EnumMember(Value = "StorageV2"), JsonStringEnumMemberName("StorageV2")]
    StorageV2
}

/// <summary>LargeFileSharesState: Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecLargeFileSharesStateEnum>))]
public enum V20250601StorageAccountSpecLargeFileSharesStateEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// MinimumTlsVersion: Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS
/// 1.0 for this property.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecMinimumTlsVersionEnum>))]
public enum V20250601StorageAccountSpecMinimumTlsVersionEnum
{
    [EnumMember(Value = "TLS1_0"), JsonStringEnumMemberName("TLS1_0")]
    TLS10,
    [EnumMember(Value = "TLS1_1"), JsonStringEnumMemberName("TLS1_1")]
    TLS11,
    [EnumMember(Value = "TLS1_2"), JsonStringEnumMemberName("TLS1_2")]
    TLS12,
    [EnumMember(Value = "TLS1_3"), JsonStringEnumMemberName("TLS1_3")]
    TLS13
}

/// <summary>DefaultAction: Specifies the default action of allow or deny when no other rules match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecNetworkAclsDefaultActionEnum>))]
public enum V20250601StorageAccountSpecNetworkAclsDefaultActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny
}

/// <summary>Action: The action of IP ACL rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecNetworkAclsIpRulesActionEnum>))]
public enum V20250601StorageAccountSpecNetworkAclsIpRulesActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow
}

/// <summary>ValueFromConfig: Specifies the IP or IP range in CIDR format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecNetworkAclsIpRulesValueFromConfig
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

/// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecNetworkAclsIpRules
{
    /// <summary>Action: The action of IP ACL rule.</summary>
    [JsonPropertyName("action")]
    public V20250601StorageAccountSpecNetworkAclsIpRulesActionEnum? Action { get; set; }

    /// <summary>Value: Specifies the IP or IP range in CIDR format.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFromConfig: Specifies the IP or IP range in CIDR format.</summary>
    [JsonPropertyName("valueFromConfig")]
    public V20250601StorageAccountSpecNetworkAclsIpRulesValueFromConfig? ValueFromConfig { get; set; }
}

/// <summary>Action: The action of IP ACL rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecNetworkAclsIpv6RulesActionEnum>))]
public enum V20250601StorageAccountSpecNetworkAclsIpv6RulesActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow
}

/// <summary>ValueFromConfig: Specifies the IP or IP range in CIDR format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecNetworkAclsIpv6RulesValueFromConfig
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

/// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecNetworkAclsIpv6Rules
{
    /// <summary>Action: The action of IP ACL rule.</summary>
    [JsonPropertyName("action")]
    public V20250601StorageAccountSpecNetworkAclsIpv6RulesActionEnum? Action { get; set; }

    /// <summary>Value: Specifies the IP or IP range in CIDR format.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFromConfig: Specifies the IP or IP range in CIDR format.</summary>
    [JsonPropertyName("valueFromConfig")]
    public V20250601StorageAccountSpecNetworkAclsIpv6RulesValueFromConfig? ValueFromConfig { get; set; }
}

/// <summary>ResourceReference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecNetworkAclsResourceAccessRulesResourceReference
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

/// <summary>Resource Access Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecNetworkAclsResourceAccessRules
{
    /// <summary>ResourceReference: Resource Id</summary>
    [JsonPropertyName("resourceReference")]
    public V20250601StorageAccountSpecNetworkAclsResourceAccessRulesResourceReference? ResourceReference { get; set; }

    /// <summary>TenantId: Tenant Id</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Action: The action of virtual network rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecNetworkAclsVirtualNetworkRulesActionEnum>))]
public enum V20250601StorageAccountSpecNetworkAclsVirtualNetworkRulesActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow
}

/// <summary>
/// Reference: Resource ID of a subnet, for example:
/// /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecNetworkAclsVirtualNetworkRulesReference
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

/// <summary>State: Gets the state of virtual network rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecNetworkAclsVirtualNetworkRulesStateEnum>))]
public enum V20250601StorageAccountSpecNetworkAclsVirtualNetworkRulesStateEnum
{
    [EnumMember(Value = "Deprovisioning"), JsonStringEnumMemberName("Deprovisioning")]
    Deprovisioning,
    [EnumMember(Value = "Failed"), JsonStringEnumMemberName("Failed")]
    Failed,
    [EnumMember(Value = "NetworkSourceDeleted"), JsonStringEnumMemberName("NetworkSourceDeleted")]
    NetworkSourceDeleted,
    [EnumMember(Value = "Provisioning"), JsonStringEnumMemberName("Provisioning")]
    Provisioning,
    [EnumMember(Value = "Succeeded"), JsonStringEnumMemberName("Succeeded")]
    Succeeded
}

/// <summary>Virtual Network rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecNetworkAclsVirtualNetworkRules
{
    /// <summary>Action: The action of virtual network rule.</summary>
    [JsonPropertyName("action")]
    public V20250601StorageAccountSpecNetworkAclsVirtualNetworkRulesActionEnum? Action { get; set; }

    /// <summary>
    /// Reference: Resource ID of a subnet, for example:
    /// /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
    /// </summary>
    [JsonPropertyName("reference")]
    public required V20250601StorageAccountSpecNetworkAclsVirtualNetworkRulesReference Reference { get; set; }

    /// <summary>State: Gets the state of virtual network rule.</summary>
    [JsonPropertyName("state")]
    public V20250601StorageAccountSpecNetworkAclsVirtualNetworkRulesStateEnum? State { get; set; }
}

/// <summary>NetworkAcls: Network rule set</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecNetworkAcls
{
    /// <summary>
    /// Bypass: Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of
    /// Logging|Metrics|AzureServices (For example, &quot;Logging, Metrics&quot;), or None to bypass none of those traffics.
    /// </summary>
    [JsonPropertyName("bypass")]
    public string? Bypass { get; set; }

    /// <summary>DefaultAction: Specifies the default action of allow or deny when no other rules match.</summary>
    [JsonPropertyName("defaultAction")]
    public required V20250601StorageAccountSpecNetworkAclsDefaultActionEnum DefaultAction { get; set; }

    /// <summary>IpRules: Sets the IP ACL rules</summary>
    [JsonPropertyName("ipRules")]
    public IList<V20250601StorageAccountSpecNetworkAclsIpRules>? IpRules { get; set; }

    /// <summary>Ipv6Rules: Sets the IPv6 ACL rules.</summary>
    [JsonPropertyName("ipv6Rules")]
    public IList<V20250601StorageAccountSpecNetworkAclsIpv6Rules>? Ipv6Rules { get; set; }

    /// <summary>ResourceAccessRules: Sets the resource access rules</summary>
    [JsonPropertyName("resourceAccessRules")]
    public IList<V20250601StorageAccountSpecNetworkAclsResourceAccessRules>? ResourceAccessRules { get; set; }

    /// <summary>VirtualNetworkRules: Sets the virtual network rules</summary>
    [JsonPropertyName("virtualNetworkRules")]
    public IList<V20250601StorageAccountSpecNetworkAclsVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecConfigMapExpressions
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

/// <summary>BlobEndpoint: indicates where the BlobEndpoint config map should be placed. If omitted, no config map will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecConfigMapsBlobEndpoint
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

/// <summary>DfsEndpoint: indicates where the DfsEndpoint config map should be placed. If omitted, no config map will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecConfigMapsDfsEndpoint
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

/// <summary>FileEndpoint: indicates where the FileEndpoint config map should be placed. If omitted, no config map will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecConfigMapsFileEndpoint
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

/// <summary>QueueEndpoint: indicates where the QueueEndpoint config map should be placed. If omitted, no config map will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecConfigMapsQueueEndpoint
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

/// <summary>TableEndpoint: indicates where the TableEndpoint config map should be placed. If omitted, no config map will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecConfigMapsTableEndpoint
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

/// <summary>WebEndpoint: indicates where the WebEndpoint config map should be placed. If omitted, no config map will be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecConfigMapsWebEndpoint
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

/// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecConfigMaps
{
    /// <summary>BlobEndpoint: indicates where the BlobEndpoint config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("blobEndpoint")]
    public V20250601StorageAccountSpecOperatorSpecConfigMapsBlobEndpoint? BlobEndpoint { get; set; }

    /// <summary>DfsEndpoint: indicates where the DfsEndpoint config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("dfsEndpoint")]
    public V20250601StorageAccountSpecOperatorSpecConfigMapsDfsEndpoint? DfsEndpoint { get; set; }

    /// <summary>FileEndpoint: indicates where the FileEndpoint config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("fileEndpoint")]
    public V20250601StorageAccountSpecOperatorSpecConfigMapsFileEndpoint? FileEndpoint { get; set; }

    /// <summary>QueueEndpoint: indicates where the QueueEndpoint config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("queueEndpoint")]
    public V20250601StorageAccountSpecOperatorSpecConfigMapsQueueEndpoint? QueueEndpoint { get; set; }

    /// <summary>TableEndpoint: indicates where the TableEndpoint config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("tableEndpoint")]
    public V20250601StorageAccountSpecOperatorSpecConfigMapsTableEndpoint? TableEndpoint { get; set; }

    /// <summary>WebEndpoint: indicates where the WebEndpoint config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("webEndpoint")]
    public V20250601StorageAccountSpecOperatorSpecConfigMapsWebEndpoint? WebEndpoint { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecSecretExpressions
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
/// BlobEndpoint: indicates where the BlobEndpoint secret should be placed. If omitted, the secret will not be retrieved
/// from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecSecretsBlobEndpoint
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
/// DfsEndpoint: indicates where the DfsEndpoint secret should be placed. If omitted, the secret will not be retrieved from
/// Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecSecretsDfsEndpoint
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
/// FileEndpoint: indicates where the FileEndpoint secret should be placed. If omitted, the secret will not be retrieved
/// from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecSecretsFileEndpoint
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

/// <summary>Key1: indicates where the Key1 secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecSecretsKey1
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

/// <summary>Key2: indicates where the Key2 secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecSecretsKey2
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
/// QueueEndpoint: indicates where the QueueEndpoint secret should be placed. If omitted, the secret will not be retrieved
/// from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecSecretsQueueEndpoint
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
/// TableEndpoint: indicates where the TableEndpoint secret should be placed. If omitted, the secret will not be retrieved
/// from Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecSecretsTableEndpoint
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
/// WebEndpoint: indicates where the WebEndpoint secret should be placed. If omitted, the secret will not be retrieved from
/// Azure.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecSecretsWebEndpoint
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

/// <summary>Secrets: configures where to place Azure generated secrets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpecSecrets
{
    /// <summary>
    /// BlobEndpoint: indicates where the BlobEndpoint secret should be placed. If omitted, the secret will not be retrieved
    /// from Azure.
    /// </summary>
    [JsonPropertyName("blobEndpoint")]
    public V20250601StorageAccountSpecOperatorSpecSecretsBlobEndpoint? BlobEndpoint { get; set; }

    /// <summary>
    /// DfsEndpoint: indicates where the DfsEndpoint secret should be placed. If omitted, the secret will not be retrieved from
    /// Azure.
    /// </summary>
    [JsonPropertyName("dfsEndpoint")]
    public V20250601StorageAccountSpecOperatorSpecSecretsDfsEndpoint? DfsEndpoint { get; set; }

    /// <summary>
    /// FileEndpoint: indicates where the FileEndpoint secret should be placed. If omitted, the secret will not be retrieved
    /// from Azure.
    /// </summary>
    [JsonPropertyName("fileEndpoint")]
    public V20250601StorageAccountSpecOperatorSpecSecretsFileEndpoint? FileEndpoint { get; set; }

    /// <summary>Key1: indicates where the Key1 secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
    [JsonPropertyName("key1")]
    public V20250601StorageAccountSpecOperatorSpecSecretsKey1? Key1 { get; set; }

    /// <summary>Key2: indicates where the Key2 secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
    [JsonPropertyName("key2")]
    public V20250601StorageAccountSpecOperatorSpecSecretsKey2? Key2 { get; set; }

    /// <summary>
    /// QueueEndpoint: indicates where the QueueEndpoint secret should be placed. If omitted, the secret will not be retrieved
    /// from Azure.
    /// </summary>
    [JsonPropertyName("queueEndpoint")]
    public V20250601StorageAccountSpecOperatorSpecSecretsQueueEndpoint? QueueEndpoint { get; set; }

    /// <summary>
    /// TableEndpoint: indicates where the TableEndpoint secret should be placed. If omitted, the secret will not be retrieved
    /// from Azure.
    /// </summary>
    [JsonPropertyName("tableEndpoint")]
    public V20250601StorageAccountSpecOperatorSpecSecretsTableEndpoint? TableEndpoint { get; set; }

    /// <summary>
    /// WebEndpoint: indicates where the WebEndpoint secret should be placed. If omitted, the secret will not be retrieved from
    /// Azure.
    /// </summary>
    [JsonPropertyName("webEndpoint")]
    public V20250601StorageAccountSpecOperatorSpecSecretsWebEndpoint? WebEndpoint { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20250601StorageAccountSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V20250601StorageAccountSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20250601StorageAccountSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V20250601StorageAccountSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ZonePlacementPolicy: The availability zone pinning policy for the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecPlacementZonePlacementPolicyEnum>))]
public enum V20250601StorageAccountSpecPlacementZonePlacementPolicyEnum
{
    [EnumMember(Value = "Any"), JsonStringEnumMemberName("Any")]
    Any,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>Placement: Optional. Gets or sets the zonal placement details for the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecPlacement
{
    /// <summary>ZonePlacementPolicy: The availability zone pinning policy for the storage account.</summary>
    [JsonPropertyName("zonePlacementPolicy")]
    public V20250601StorageAccountSpecPlacementZonePlacementPolicyEnum? ZonePlacementPolicy { get; set; }
}

/// <summary>
/// PublicNetworkAccess: Allow, disallow, or let Network Security Perimeter configuration to evaluate public network access
/// to Storage Account. Value is optional but if passed in, must be &apos;Enabled&apos;, &apos;Disabled&apos; or &apos;SecuredByPerimeter&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecPublicNetworkAccessEnum>))]
public enum V20250601StorageAccountSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled,
    [EnumMember(Value = "SecuredByPerimeter"), JsonStringEnumMemberName("SecuredByPerimeter")]
    SecuredByPerimeter
}

/// <summary>RoutingChoice: Routing Choice defines the kind of network routing opted by the user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecRoutingPreferenceRoutingChoiceEnum>))]
public enum V20250601StorageAccountSpecRoutingPreferenceRoutingChoiceEnum
{
    [EnumMember(Value = "InternetRouting"), JsonStringEnumMemberName("InternetRouting")]
    InternetRouting,
    [EnumMember(Value = "MicrosoftRouting"), JsonStringEnumMemberName("MicrosoftRouting")]
    MicrosoftRouting
}

/// <summary>RoutingPreference: Maintains information about the network routing choice opted by the user for data transfer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecRoutingPreference
{
    /// <summary>PublishInternetEndpoints: A boolean flag which indicates whether internet routing storage endpoints are to be published</summary>
    [JsonPropertyName("publishInternetEndpoints")]
    public bool? PublishInternetEndpoints { get; set; }

    /// <summary>PublishMicrosoftEndpoints: A boolean flag which indicates whether microsoft routing storage endpoints are to be published</summary>
    [JsonPropertyName("publishMicrosoftEndpoints")]
    public bool? PublishMicrosoftEndpoints { get; set; }

    /// <summary>RoutingChoice: Routing Choice defines the kind of network routing opted by the user.</summary>
    [JsonPropertyName("routingChoice")]
    public V20250601StorageAccountSpecRoutingPreferenceRoutingChoiceEnum? RoutingChoice { get; set; }
}

/// <summary>
/// ExpirationAction: The SAS Expiration Action defines the action to be performed when sasPolicy.sasExpirationPeriod is
/// violated. The &apos;Log&apos; action can be used for audit purposes and the &apos;Block&apos; action can be used to block and deny the usage
/// of SAS tokens that do not adhere to the sas policy expiration period.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecSasPolicyExpirationActionEnum>))]
public enum V20250601StorageAccountSpecSasPolicyExpirationActionEnum
{
    [EnumMember(Value = "Block"), JsonStringEnumMemberName("Block")]
    Block,
    [EnumMember(Value = "Log"), JsonStringEnumMemberName("Log")]
    Log
}

/// <summary>SasPolicy: SasPolicy assigned to the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecSasPolicy
{
    /// <summary>
    /// ExpirationAction: The SAS Expiration Action defines the action to be performed when sasPolicy.sasExpirationPeriod is
    /// violated. The &apos;Log&apos; action can be used for audit purposes and the &apos;Block&apos; action can be used to block and deny the usage
    /// of SAS tokens that do not adhere to the sas policy expiration period.
    /// </summary>
    [JsonPropertyName("expirationAction")]
    public required V20250601StorageAccountSpecSasPolicyExpirationActionEnum ExpirationAction { get; set; }

    /// <summary>SasExpirationPeriod: The SAS expiration period, DD.HH:MM:SS.</summary>
    [JsonPropertyName("sasExpirationPeriod")]
    public required string SasExpirationPeriod { get; set; }
}

/// <summary>
/// Name: The SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called
/// accountType.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20250601StorageAccountSpecSkuNameEnum>))]
public enum V20250601StorageAccountSpecSkuNameEnum
{
    [EnumMember(Value = "PremiumV2_LRS"), JsonStringEnumMemberName("PremiumV2_LRS")]
    PremiumV2LRS,
    [EnumMember(Value = "PremiumV2_ZRS"), JsonStringEnumMemberName("PremiumV2_ZRS")]
    PremiumV2ZRS,
    [EnumMember(Value = "Premium_LRS"), JsonStringEnumMemberName("Premium_LRS")]
    PremiumLRS,
    [EnumMember(Value = "Premium_ZRS"), JsonStringEnumMemberName("Premium_ZRS")]
    PremiumZRS,
    [EnumMember(Value = "StandardV2_GRS"), JsonStringEnumMemberName("StandardV2_GRS")]
    StandardV2GRS,
    [EnumMember(Value = "StandardV2_GZRS"), JsonStringEnumMemberName("StandardV2_GZRS")]
    StandardV2GZRS,
    [EnumMember(Value = "StandardV2_LRS"), JsonStringEnumMemberName("StandardV2_LRS")]
    StandardV2LRS,
    [EnumMember(Value = "StandardV2_ZRS"), JsonStringEnumMemberName("StandardV2_ZRS")]
    StandardV2ZRS,
    [EnumMember(Value = "Standard_GRS"), JsonStringEnumMemberName("Standard_GRS")]
    StandardGRS,
    [EnumMember(Value = "Standard_GZRS"), JsonStringEnumMemberName("Standard_GZRS")]
    StandardGZRS,
    [EnumMember(Value = "Standard_LRS"), JsonStringEnumMemberName("Standard_LRS")]
    StandardLRS,
    [EnumMember(Value = "Standard_RAGRS"), JsonStringEnumMemberName("Standard_RAGRS")]
    StandardRAGRS,
    [EnumMember(Value = "Standard_RAGZRS"), JsonStringEnumMemberName("Standard_RAGZRS")]
    StandardRAGZRS,
    [EnumMember(Value = "Standard_ZRS"), JsonStringEnumMemberName("Standard_ZRS")]
    StandardZRS
}

/// <summary>Sku: Required. Gets or sets the SKU name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpecSku
{
    /// <summary>
    /// Name: The SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called
    /// accountType.
    /// </summary>
    [JsonPropertyName("name")]
    public required V20250601StorageAccountSpecSkuNameEnum Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountSpec
{
    /// <summary>
    /// AccessTier: Required for storage accounts where kind = BlobStorage. The access tier is used for billing. The &apos;Premium&apos;
    /// access tier is the default value for premium block blobs storage account type and it cannot be changed for the premium
    /// block blobs storage account type.
    /// </summary>
    [JsonPropertyName("accessTier")]
    public V20250601StorageAccountSpecAccessTierEnum? AccessTier { get; set; }

    /// <summary>
    /// AllowBlobPublicAccess: Allow or disallow public access to all blobs or containers in the storage account. The default
    /// interpretation is false for this property.
    /// </summary>
    [JsonPropertyName("allowBlobPublicAccess")]
    public bool? AllowBlobPublicAccess { get; set; }

    /// <summary>
    /// AllowCrossTenantReplication: Allow or disallow cross AAD tenant object replication. Set this property to true for new or
    /// existing accounts only if object replication policies will involve storage accounts in different AAD tenants. The
    /// default interpretation is false for new accounts to follow best security practices by default.
    /// </summary>
    [JsonPropertyName("allowCrossTenantReplication")]
    public bool? AllowCrossTenantReplication { get; set; }

    /// <summary>
    /// AllowSharedKeyAccess: Indicates whether the storage account permits requests to be authorized with the account access
    /// key via Shared Key. If false, then all requests, including shared access signatures, must be authorized with Azure
    /// Active Directory (Azure AD). The default value is null, which is equivalent to true.
    /// </summary>
    [JsonPropertyName("allowSharedKeyAccess")]
    public bool? AllowSharedKeyAccess { get; set; }

    /// <summary>AllowedCopyScope: Restrict copy to and from Storage Accounts within an AAD tenant or with Private Links to the same VNet.</summary>
    [JsonPropertyName("allowedCopyScope")]
    public V20250601StorageAccountSpecAllowedCopyScopeEnum? AllowedCopyScope { get; set; }

    /// <summary>AzureFilesIdentityBasedAuthentication: Provides the identity based authentication settings for Azure Files.</summary>
    [JsonPropertyName("azureFilesIdentityBasedAuthentication")]
    public V20250601StorageAccountSpecAzureFilesIdentityBasedAuthentication? AzureFilesIdentityBasedAuthentication { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// CustomDomain: User domain assigned to the storage account. Name is the CNAME source. Only one custom domain is supported
    /// per storage account at this time. To clear the existing custom domain, use an empty string for the custom domain name
    /// property.
    /// </summary>
    [JsonPropertyName("customDomain")]
    public V20250601StorageAccountSpecCustomDomain? CustomDomain { get; set; }

    /// <summary>
    /// DefaultToOAuthAuthentication: A boolean flag which indicates whether the default authentication is OAuth or not. The
    /// default interpretation is false for this property.
    /// </summary>
    [JsonPropertyName("defaultToOAuthAuthentication")]
    public bool? DefaultToOAuthAuthentication { get; set; }

    /// <summary>
    /// DnsEndpointType: Allows you to specify the type of endpoint. Set this to AzureDNSZone to create a large number of
    /// accounts in a single subscription, which creates accounts in an Azure DNS Zone and the endpoint URL will have an
    /// alphanumeric DNS Zone identifier.
    /// </summary>
    [JsonPropertyName("dnsEndpointType")]
    public V20250601StorageAccountSpecDnsEndpointTypeEnum? DnsEndpointType { get; set; }

    /// <summary>DualStackEndpointPreference: Maintains information about the Internet protocol opted by the user.</summary>
    [JsonPropertyName("dualStackEndpointPreference")]
    public V20250601StorageAccountSpecDualStackEndpointPreference? DualStackEndpointPreference { get; set; }

    /// <summary>EnableExtendedGroups: Enables extended group support with local users feature, if set to true</summary>
    [JsonPropertyName("enableExtendedGroups")]
    public bool? EnableExtendedGroups { get; set; }

    /// <summary>Encryption: Encryption settings to be used for server-side encryption for the storage account.</summary>
    [JsonPropertyName("encryption")]
    public V20250601StorageAccountSpecEncryption? Encryption { get; set; }

    /// <summary>
    /// ExtendedLocation: Optional. Set the extended location of the resource. If not set, the storage account will be created
    /// in Azure main region. Otherwise it will be created in the specified extended location
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V20250601StorageAccountSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>GeoPriorityReplicationStatus: Status indicating whether Geo Priority Replication is enabled for the account.</summary>
    [JsonPropertyName("geoPriorityReplicationStatus")]
    public V20250601StorageAccountSpecGeoPriorityReplicationStatus? GeoPriorityReplicationStatus { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V20250601StorageAccountSpecIdentity? Identity { get; set; }

    /// <summary>
    /// ImmutableStorageWithVersioning: The property is immutable and can only be set to true at the account creation time. When
    /// set to true, it enables object level immutability for all the new containers in the account by default.
    /// </summary>
    [JsonPropertyName("immutableStorageWithVersioning")]
    public V20250601StorageAccountSpecImmutableStorageWithVersioning? ImmutableStorageWithVersioning { get; set; }

    /// <summary>IsHnsEnabled: Account HierarchicalNamespace enabled if sets to true.</summary>
    [JsonPropertyName("isHnsEnabled")]
    public bool? IsHnsEnabled { get; set; }

    /// <summary>IsLocalUserEnabled: Enables local users feature, if set to true</summary>
    [JsonPropertyName("isLocalUserEnabled")]
    public bool? IsLocalUserEnabled { get; set; }

    /// <summary>IsNfsV3Enabled: NFS 3.0 protocol support enabled if set to true.</summary>
    [JsonPropertyName("isNfsV3Enabled")]
    public bool? IsNfsV3Enabled { get; set; }

    /// <summary>IsSftpEnabled: Enables Secure File Transfer Protocol, if set to true</summary>
    [JsonPropertyName("isSftpEnabled")]
    public bool? IsSftpEnabled { get; set; }

    /// <summary>KeyPolicy: KeyPolicy assigned to the storage account.</summary>
    [JsonPropertyName("keyPolicy")]
    public V20250601StorageAccountSpecKeyPolicy? KeyPolicy { get; set; }

    /// <summary>Kind: Required. Indicates the type of storage account.</summary>
    [JsonPropertyName("kind")]
    public required V20250601StorageAccountSpecKindEnum Kind { get; set; }

    /// <summary>LargeFileSharesState: Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled.</summary>
    [JsonPropertyName("largeFileSharesState")]
    public V20250601StorageAccountSpecLargeFileSharesStateEnum? LargeFileSharesState { get; set; }

    /// <summary>
    /// Location: Required. Gets or sets the location of the resource. This will be one of the supported and registered Azure
    /// Geo Regions (e.g. West US, East US, Southeast Asia, etc.). The geo region of a resource cannot be changed once it is
    /// created, but if an identical geo region is specified on update, the request will succeed.
    /// </summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// MinimumTlsVersion: Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS
    /// 1.0 for this property.
    /// </summary>
    [JsonPropertyName("minimumTlsVersion")]
    public V20250601StorageAccountSpecMinimumTlsVersionEnum? MinimumTlsVersion { get; set; }

    /// <summary>NetworkAcls: Network rule set</summary>
    [JsonPropertyName("networkAcls")]
    public V20250601StorageAccountSpecNetworkAcls? NetworkAcls { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250601StorageAccountSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250601StorageAccountSpecOwner Owner { get; set; }

    /// <summary>Placement: Optional. Gets or sets the zonal placement details for the storage account.</summary>
    [JsonPropertyName("placement")]
    public V20250601StorageAccountSpecPlacement? Placement { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Allow, disallow, or let Network Security Perimeter configuration to evaluate public network access
    /// to Storage Account. Value is optional but if passed in, must be &apos;Enabled&apos;, &apos;Disabled&apos; or &apos;SecuredByPerimeter&apos;.
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V20250601StorageAccountSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>RoutingPreference: Maintains information about the network routing choice opted by the user for data transfer</summary>
    [JsonPropertyName("routingPreference")]
    public V20250601StorageAccountSpecRoutingPreference? RoutingPreference { get; set; }

    /// <summary>SasPolicy: SasPolicy assigned to the storage account.</summary>
    [JsonPropertyName("sasPolicy")]
    public V20250601StorageAccountSpecSasPolicy? SasPolicy { get; set; }

    /// <summary>Sku: Required. Gets or sets the SKU name.</summary>
    [JsonPropertyName("sku")]
    public required V20250601StorageAccountSpecSku Sku { get; set; }

    /// <summary>
    /// SupportsHttpsTrafficOnly: Allows https traffic only to storage service if sets to true. The default value is true since
    /// API version 2019-04-01.
    /// </summary>
    [JsonPropertyName("supportsHttpsTrafficOnly")]
    public bool? SupportsHttpsTrafficOnly { get; set; }

    /// <summary>
    /// Tags: Gets or sets a list of key value pairs that describe the resource. These tags can be used for viewing and grouping
    /// this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key
    /// with a length no greater than 128 characters and a value with a length no greater than 256 characters.
    /// </summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Zones: Optional. Gets or sets the pinned logical availability zone for the storage account.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// ActiveDirectoryProperties: Additional information about the directory service. Required if directoryServiceOptions is AD
/// (AD DS authentication). Optional for directoryServiceOptions AADDS (Entra DS authentication) and AADKERB (Entra
/// authentication).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusAzureFilesIdentityBasedAuthenticationActiveDirectoryProperties
{
    /// <summary>
    /// AccountType: Specifies the Active Directory account type for Azure Storage. If directoryServiceOptions is set to AD (AD
    /// DS authentication), this property is optional. If provided, samAccountName should also be provided. For
    /// directoryServiceOptions AADDS (Entra DS authentication) or AADKERB (Entra authentication), this property can be omitted.
    /// </summary>
    [JsonPropertyName("accountType")]
    public string? AccountType { get; set; }

    /// <summary>
    /// AzureStorageSid: Specifies the security identifier (SID) for Azure Storage. If directoryServiceOptions is set to AD (AD
    /// DS authentication), this property is required. Otherwise, it can be omitted.
    /// </summary>
    [JsonPropertyName("azureStorageSid")]
    public string? AzureStorageSid { get; set; }

    /// <summary>
    /// DomainGuid: Specifies the domain GUID. If directoryServiceOptions is set to AD (AD DS authentication), this property is
    /// required. If directoryServiceOptions is set to AADDS (Entra DS authentication), this property can be omitted. If
    /// directoryServiceOptions is set to AADKERB (Entra authentication), this property is optional; it is needed to support
    /// configuration of directory- and file-level permissions via Windows File Explorer, but is not required for authentication.
    /// </summary>
    [JsonPropertyName("domainGuid")]
    public string? DomainGuid { get; set; }

    /// <summary>
    /// DomainName: Specifies the primary domain that the AD DNS server is authoritative for. This property is required if
    /// directoryServiceOptions is set to AD (AD DS authentication). If directoryServiceOptions is set to AADDS (Entra DS
    /// authentication), providing this property is optional, as it will be inferred automatically if omitted. If
    /// directoryServiceOptions is set to AADKERB (Entra authentication), this property is optional; it is needed to support
    /// configuration of directory- and file-level permissions via Windows File Explorer, but is not required for authentication.
    /// </summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>
    /// DomainSid: Specifies the security identifier (SID) of the AD domain. If directoryServiceOptions is set to AD (AD DS
    /// authentication), this property is required. Otherwise, it can be omitted.
    /// </summary>
    [JsonPropertyName("domainSid")]
    public string? DomainSid { get; set; }

    /// <summary>
    /// ForestName: Specifies the Active Directory forest to get. If directoryServiceOptions is set to AD (AD DS
    /// authentication), this property is required. Otherwise, it can be omitted.
    /// </summary>
    [JsonPropertyName("forestName")]
    public string? ForestName { get; set; }

    /// <summary>
    /// NetBiosDomainName: Specifies the NetBIOS domain name. If directoryServiceOptions is set to AD (AD DS authentication),
    /// this property is required. Otherwise, it can be omitted.
    /// </summary>
    [JsonPropertyName("netBiosDomainName")]
    public string? NetBiosDomainName { get; set; }

    /// <summary>
    /// SamAccountName: Specifies the Active Directory SAMAccountName for Azure Storage. If directoryServiceOptions is set to AD
    /// (AD DS authentication), this property is optional. If provided, accountType should also be provided. For
    /// directoryServiceOptions AADDS (Entra DS authentication) or AADKERB (Entra authentication), this property can be omitted.
    /// </summary>
    [JsonPropertyName("samAccountName")]
    public string? SamAccountName { get; set; }
}

/// <summary>SmbOAuthSettings: Required for Managed Identities access using OAuth over SMB.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusAzureFilesIdentityBasedAuthenticationSmbOAuthSettings
{
    /// <summary>
    /// IsSmbOAuthEnabled: Specifies if managed identities can access SMB shares using OAuth. The default interpretation is
    /// false for this property.
    /// </summary>
    [JsonPropertyName("isSmbOAuthEnabled")]
    public bool? IsSmbOAuthEnabled { get; set; }
}

/// <summary>AzureFilesIdentityBasedAuthentication: Provides the identity based authentication settings for Azure Files.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusAzureFilesIdentityBasedAuthentication
{
    /// <summary>
    /// ActiveDirectoryProperties: Additional information about the directory service. Required if directoryServiceOptions is AD
    /// (AD DS authentication). Optional for directoryServiceOptions AADDS (Entra DS authentication) and AADKERB (Entra
    /// authentication).
    /// </summary>
    [JsonPropertyName("activeDirectoryProperties")]
    public V20250601StorageAccountStatusAzureFilesIdentityBasedAuthenticationActiveDirectoryProperties? ActiveDirectoryProperties { get; set; }

    /// <summary>DefaultSharePermission: Default share permission for users using Kerberos authentication if RBAC role is not assigned.</summary>
    [JsonPropertyName("defaultSharePermission")]
    public string? DefaultSharePermission { get; set; }

    /// <summary>DirectoryServiceOptions: Indicates the directory service used. Note that this enum may be extended in the future.</summary>
    [JsonPropertyName("directoryServiceOptions")]
    public string? DirectoryServiceOptions { get; set; }

    /// <summary>SmbOAuthSettings: Required for Managed Identities access using OAuth over SMB.</summary>
    [JsonPropertyName("smbOAuthSettings")]
    public V20250601StorageAccountStatusAzureFilesIdentityBasedAuthenticationSmbOAuthSettings? SmbOAuthSettings { get; set; }
}

/// <summary>Blob range</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusBlobRestoreStatusParametersBlobRanges
{
    /// <summary>EndRange: Blob end range. This is exclusive. Empty means account end.</summary>
    [JsonPropertyName("endRange")]
    public string? EndRange { get; set; }

    /// <summary>StartRange: Blob start range. This is inclusive. Empty means account start.</summary>
    [JsonPropertyName("startRange")]
    public string? StartRange { get; set; }
}

/// <summary>Parameters: Blob restore request parameters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusBlobRestoreStatusParameters
{
    /// <summary>BlobRanges: Blob ranges to restore.</summary>
    [JsonPropertyName("blobRanges")]
    public IList<V20250601StorageAccountStatusBlobRestoreStatusParametersBlobRanges>? BlobRanges { get; set; }

    /// <summary>TimeToRestore: Restore blob to the specified time.</summary>
    [JsonPropertyName("timeToRestore")]
    public string? TimeToRestore { get; set; }
}

/// <summary>BlobRestoreStatus: Blob restore status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusBlobRestoreStatus
{
    /// <summary>FailureReason: Failure reason when blob restore is failed.</summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>Parameters: Blob restore request parameters.</summary>
    [JsonPropertyName("parameters")]
    public V20250601StorageAccountStatusBlobRestoreStatusParameters? Parameters { get; set; }

    /// <summary>RestoreId: Id for tracking blob restore request.</summary>
    [JsonPropertyName("restoreId")]
    public string? RestoreId { get; set; }

    /// <summary>
    /// Status: The status of blob restore progress. Possible values are: - InProgress: Indicates that blob restore is ongoing.
    /// - Complete: Indicates that blob restore has been completed successfully. - Failed: Indicates that blob restore is failed.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusConditions
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

/// <summary>CustomDomain: Gets the custom domain the user assigned to this storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusCustomDomain
{
    /// <summary>Name: Gets or sets the custom domain name assigned to the storage account. Name is the CNAME source.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// UseSubDomainName: Indicates whether indirect CName validation is enabled. Default value is false. This should only be
    /// set on updates.
    /// </summary>
    [JsonPropertyName("useSubDomainName")]
    public bool? UseSubDomainName { get; set; }
}

/// <summary>DualStackEndpointPreference: Maintains information about the Internet protocol opted by the user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusDualStackEndpointPreference
{
    /// <summary>PublishIpv6Endpoint: A boolean flag which indicates whether IPv6 storage endpoints are to be published.</summary>
    [JsonPropertyName("publishIpv6Endpoint")]
    public bool? PublishIpv6Endpoint { get; set; }
}

/// <summary>Identity: The identity to be used with service-side encryption at rest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusEncryptionIdentity
{
    /// <summary>
    /// FederatedIdentityClientId: ClientId of the multi-tenant application to be used in conjunction with the user-assigned
    /// identity for cross-tenant customer-managed-keys server-side encryption on the storage account.
    /// </summary>
    [JsonPropertyName("federatedIdentityClientId")]
    public string? FederatedIdentityClientId { get; set; }

    /// <summary>
    /// UserAssignedIdentity: Resource identifier of the UserAssigned identity to be associated with server-side encryption on
    /// the storage account.
    /// </summary>
    [JsonPropertyName("userAssignedIdentity")]
    public string? UserAssignedIdentity { get; set; }
}

/// <summary>Keyvaultproperties: Properties provided by key vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusEncryptionKeyvaultproperties
{
    /// <summary>
    /// CurrentVersionedKeyExpirationTimestamp: This is a read only property that represents the expiration time of the current
    /// version of the customer managed key used for encryption.
    /// </summary>
    [JsonPropertyName("currentVersionedKeyExpirationTimestamp")]
    public string? CurrentVersionedKeyExpirationTimestamp { get; set; }

    /// <summary>CurrentVersionedKeyIdentifier: The object identifier of the current versioned Key Vault Key in use.</summary>
    [JsonPropertyName("currentVersionedKeyIdentifier")]
    public string? CurrentVersionedKeyIdentifier { get; set; }

    /// <summary>Keyname: The name of KeyVault key.</summary>
    [JsonPropertyName("keyname")]
    public string? Keyname { get; set; }

    /// <summary>Keyvaulturi: The Uri of KeyVault.</summary>
    [JsonPropertyName("keyvaulturi")]
    public string? Keyvaulturi { get; set; }

    /// <summary>Keyversion: The version of KeyVault key.</summary>
    [JsonPropertyName("keyversion")]
    public string? Keyversion { get; set; }

    /// <summary>LastKeyRotationTimestamp: Timestamp of last rotation of the Key Vault Key.</summary>
    [JsonPropertyName("lastKeyRotationTimestamp")]
    public string? LastKeyRotationTimestamp { get; set; }
}

/// <summary>Blob: The encryption function of the blob storage service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusEncryptionServicesBlob
{
    /// <summary>
    /// Enabled: A boolean indicating whether or not the service encrypts the data as it is stored. Encryption at rest is
    /// enabled by default today and cannot be disabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
    /// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// LastEnabledTime: Gets a rough estimate of the date/time when the encryption was last enabled by the user. Data is
    /// encrypted at rest by default today and cannot be disabled.
    /// </summary>
    [JsonPropertyName("lastEnabledTime")]
    public string? LastEnabledTime { get; set; }
}

/// <summary>File: The encryption function of the file storage service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusEncryptionServicesFile
{
    /// <summary>
    /// Enabled: A boolean indicating whether or not the service encrypts the data as it is stored. Encryption at rest is
    /// enabled by default today and cannot be disabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
    /// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// LastEnabledTime: Gets a rough estimate of the date/time when the encryption was last enabled by the user. Data is
    /// encrypted at rest by default today and cannot be disabled.
    /// </summary>
    [JsonPropertyName("lastEnabledTime")]
    public string? LastEnabledTime { get; set; }
}

/// <summary>Queue: The encryption function of the queue storage service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusEncryptionServicesQueue
{
    /// <summary>
    /// Enabled: A boolean indicating whether or not the service encrypts the data as it is stored. Encryption at rest is
    /// enabled by default today and cannot be disabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
    /// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// LastEnabledTime: Gets a rough estimate of the date/time when the encryption was last enabled by the user. Data is
    /// encrypted at rest by default today and cannot be disabled.
    /// </summary>
    [JsonPropertyName("lastEnabledTime")]
    public string? LastEnabledTime { get; set; }
}

/// <summary>Table: The encryption function of the table storage service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusEncryptionServicesTable
{
    /// <summary>
    /// Enabled: A boolean indicating whether or not the service encrypts the data as it is stored. Encryption at rest is
    /// enabled by default today and cannot be disabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
    /// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// LastEnabledTime: Gets a rough estimate of the date/time when the encryption was last enabled by the user. Data is
    /// encrypted at rest by default today and cannot be disabled.
    /// </summary>
    [JsonPropertyName("lastEnabledTime")]
    public string? LastEnabledTime { get; set; }
}

/// <summary>Services: List of services which support encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusEncryptionServices
{
    /// <summary>Blob: The encryption function of the blob storage service.</summary>
    [JsonPropertyName("blob")]
    public V20250601StorageAccountStatusEncryptionServicesBlob? Blob { get; set; }

    /// <summary>File: The encryption function of the file storage service.</summary>
    [JsonPropertyName("file")]
    public V20250601StorageAccountStatusEncryptionServicesFile? File { get; set; }

    /// <summary>Queue: The encryption function of the queue storage service.</summary>
    [JsonPropertyName("queue")]
    public V20250601StorageAccountStatusEncryptionServicesQueue? Queue { get; set; }

    /// <summary>Table: The encryption function of the table storage service.</summary>
    [JsonPropertyName("table")]
    public V20250601StorageAccountStatusEncryptionServicesTable? Table { get; set; }
}

/// <summary>Encryption: Encryption settings to be used for server-side encryption for the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusEncryption
{
    /// <summary>Identity: The identity to be used with service-side encryption at rest.</summary>
    [JsonPropertyName("identity")]
    public V20250601StorageAccountStatusEncryptionIdentity? Identity { get; set; }

    /// <summary>
    /// KeySource: The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage,
    /// Microsoft.Keyvault
    /// </summary>
    [JsonPropertyName("keySource")]
    public string? KeySource { get; set; }

    /// <summary>Keyvaultproperties: Properties provided by key vault.</summary>
    [JsonPropertyName("keyvaultproperties")]
    public V20250601StorageAccountStatusEncryptionKeyvaultproperties? Keyvaultproperties { get; set; }

    /// <summary>
    /// RequireInfrastructureEncryption: A boolean indicating whether or not the service applies a secondary layer of encryption
    /// with platform managed keys for data at rest.
    /// </summary>
    [JsonPropertyName("requireInfrastructureEncryption")]
    public bool? RequireInfrastructureEncryption { get; set; }

    /// <summary>Services: List of services which support encryption.</summary>
    [JsonPropertyName("services")]
    public V20250601StorageAccountStatusEncryptionServices? Services { get; set; }
}

/// <summary>ExtendedLocation: The extendedLocation of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>GeoPriorityReplicationStatus: Status indicating whether Geo Priority Replication is enabled for the account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusGeoPriorityReplicationStatus
{
    /// <summary>IsBlobEnabled: Indicates whether Blob Geo Priority Replication is enabled for the storage account.</summary>
    [JsonPropertyName("isBlobEnabled")]
    public bool? IsBlobEnabled { get; set; }
}

/// <summary>GeoReplicationStats: Geo Replication Stats</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusGeoReplicationStats
{
    /// <summary>CanFailover: A boolean flag which indicates whether or not account failover is supported for the account.</summary>
    [JsonPropertyName("canFailover")]
    public bool? CanFailover { get; set; }

    /// <summary>CanPlannedFailover: A boolean flag which indicates whether or not planned account failover is supported for the account.</summary>
    [JsonPropertyName("canPlannedFailover")]
    public bool? CanPlannedFailover { get; set; }

    /// <summary>
    /// LastSyncTime: All primary writes preceding this UTC date/time value are guaranteed to be available for read operations.
    /// Primary writes following this point in time may or may not be available for reads. Element may be default value if value
    /// of LastSyncTime is not available, this can happen if secondary is offline or we are in bootstrap.
    /// </summary>
    [JsonPropertyName("lastSyncTime")]
    public string? LastSyncTime { get; set; }

    /// <summary>PostFailoverRedundancy: The redundancy type of the account after an account failover is performed.</summary>
    [JsonPropertyName("postFailoverRedundancy")]
    public string? PostFailoverRedundancy { get; set; }

    /// <summary>PostPlannedFailoverRedundancy: The redundancy type of the account after a planned account failover is performed.</summary>
    [JsonPropertyName("postPlannedFailoverRedundancy")]
    public string? PostPlannedFailoverRedundancy { get; set; }

    /// <summary>
    /// Status: The status of the secondary location. Possible values are: - Live: Indicates that the secondary location is
    /// active and operational. - Bootstrap: Indicates initial synchronization from the primary location to the secondary
    /// location is in progress.This typically occurs when replication is first enabled. - Unavailable: Indicates that the
    /// secondary location is temporarily unavailable.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>UserAssignedIdentity for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client ID of the identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal ID of the identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>Identity: The identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusIdentity
{
    /// <summary>PrincipalId: The principal ID of resource identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>TenantId: The tenant ID of resource.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: Gets or sets a list of key value pairs that describe the set of User Assigned identities that
    /// will be used with this storage account. The key is the ARM resource identifier of the identity. Only 1 User Assigned
    /// identity is permitted here.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20250601StorageAccountStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// ImmutabilityPolicy: Specifies the default account-level immutability policy which is inherited and applied to objects
/// that do not possess an explicit immutability policy at the object level. The object-level immutability policy has higher
/// precedence than the container-level immutability policy, which has a higher precedence than the account-level
/// immutability policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusImmutableStorageWithVersioningImmutabilityPolicy
{
    /// <summary>
    /// AllowProtectedAppendWrites: This property can only be changed for disabled and unlocked time-based retention policies.
    /// When enabled, new blocks can be written to an append blob while maintaining immutability protection and compliance. Only
    /// new blocks can be added and any existing blocks cannot be modified or deleted.
    /// </summary>
    [JsonPropertyName("allowProtectedAppendWrites")]
    public bool? AllowProtectedAppendWrites { get; set; }

    /// <summary>
    /// ImmutabilityPeriodSinceCreationInDays: The immutability period for the blobs in the container since the policy creation,
    /// in days.
    /// </summary>
    [JsonPropertyName("immutabilityPeriodSinceCreationInDays")]
    public int? ImmutabilityPeriodSinceCreationInDays { get; set; }

    /// <summary>
    /// State: The ImmutabilityPolicy state defines the mode of the policy. Disabled state disables the policy, Unlocked state
    /// allows increase and decrease of immutability retention time and also allows toggling allowProtectedAppendWrites
    /// property, Locked state only allows the increase of the immutability retention time. A policy can only be created in a
    /// Disabled or Unlocked state and can be toggled between the two states. Only a policy in an Unlocked state can transition
    /// to a Locked state which cannot be reverted.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// ImmutableStorageWithVersioning: The property is immutable and can only be set to true at the account creation time. When
/// set to true, it enables object level immutability for all the containers in the account by default.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusImmutableStorageWithVersioning
{
    /// <summary>
    /// Enabled: A boolean flag which enables account-level immutability. All the containers under such an account have
    /// object-level immutability enabled by default.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// ImmutabilityPolicy: Specifies the default account-level immutability policy which is inherited and applied to objects
    /// that do not possess an explicit immutability policy at the object level. The object-level immutability policy has higher
    /// precedence than the container-level immutability policy, which has a higher precedence than the account-level
    /// immutability policy.
    /// </summary>
    [JsonPropertyName("immutabilityPolicy")]
    public V20250601StorageAccountStatusImmutableStorageWithVersioningImmutabilityPolicy? ImmutabilityPolicy { get; set; }
}

/// <summary>KeyCreationTime: Storage account keys creation time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusKeyCreationTime
{
    [JsonPropertyName("key1")]
    public string? Key1 { get; set; }

    [JsonPropertyName("key2")]
    public string? Key2 { get; set; }
}

/// <summary>KeyPolicy: KeyPolicy assigned to the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusKeyPolicy
{
    /// <summary>KeyExpirationPeriodInDays: The key expiration period in days.</summary>
    [JsonPropertyName("keyExpirationPeriodInDays")]
    public int? KeyExpirationPeriodInDays { get; set; }
}

/// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusNetworkAclsIpRules
{
    /// <summary>Action: The action of IP ACL rule.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Value: Specifies the IP or IP range in CIDR format.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusNetworkAclsIpv6Rules
{
    /// <summary>Action: The action of IP ACL rule.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Value: Specifies the IP or IP range in CIDR format.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Resource Access Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusNetworkAclsResourceAccessRules
{
    /// <summary>ResourceId: Resource Id</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>TenantId: Tenant Id</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Virtual Network rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusNetworkAclsVirtualNetworkRules
{
    /// <summary>Action: The action of virtual network rule.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>
    /// Id: Resource ID of a subnet, for example:
    /// /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>State: Gets the state of virtual network rule.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>NetworkAcls: Network rule set</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusNetworkAcls
{
    /// <summary>
    /// Bypass: Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of
    /// Logging|Metrics|AzureServices (For example, &quot;Logging, Metrics&quot;), or None to bypass none of those traffics.
    /// </summary>
    [JsonPropertyName("bypass")]
    public string? Bypass { get; set; }

    /// <summary>DefaultAction: Specifies the default action of allow or deny when no other rules match.</summary>
    [JsonPropertyName("defaultAction")]
    public string? DefaultAction { get; set; }

    /// <summary>IpRules: Sets the IP ACL rules</summary>
    [JsonPropertyName("ipRules")]
    public IList<V20250601StorageAccountStatusNetworkAclsIpRules>? IpRules { get; set; }

    /// <summary>Ipv6Rules: Sets the IPv6 ACL rules.</summary>
    [JsonPropertyName("ipv6Rules")]
    public IList<V20250601StorageAccountStatusNetworkAclsIpv6Rules>? Ipv6Rules { get; set; }

    /// <summary>ResourceAccessRules: Sets the resource access rules</summary>
    [JsonPropertyName("resourceAccessRules")]
    public IList<V20250601StorageAccountStatusNetworkAclsResourceAccessRules>? ResourceAccessRules { get; set; }

    /// <summary>VirtualNetworkRules: Sets the virtual network rules</summary>
    [JsonPropertyName("virtualNetworkRules")]
    public IList<V20250601StorageAccountStatusNetworkAclsVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>Placement: Optional. Gets or sets the zonal placement details for the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusPlacement
{
    /// <summary>ZonePlacementPolicy: The availability zone pinning policy for the storage account.</summary>
    [JsonPropertyName("zonePlacementPolicy")]
    public string? ZonePlacementPolicy { get; set; }
}

/// <summary>InternetEndpoints: Gets the internet routing storage endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusPrimaryEndpointsInternetEndpoints
{
    /// <summary>Blob: Gets the blob endpoint.</summary>
    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    /// <summary>Dfs: Gets the dfs endpoint.</summary>
    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    /// <summary>File: Gets the file endpoint.</summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>Web: Gets the web endpoint.</summary>
    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>InternetEndpoints: Gets the internet routing storage endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusPrimaryEndpointsIpv6EndpointsInternetEndpoints
{
    /// <summary>Blob: Gets the blob endpoint.</summary>
    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    /// <summary>Dfs: Gets the dfs endpoint.</summary>
    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    /// <summary>File: Gets the file endpoint.</summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>Web: Gets the web endpoint.</summary>
    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>MicrosoftEndpoints: Gets the microsoft routing storage endpoints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusPrimaryEndpointsIpv6EndpointsMicrosoftEndpoints
{
    /// <summary>Blob: Gets the blob endpoint.</summary>
    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    /// <summary>Dfs: Gets the dfs endpoint.</summary>
    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    /// <summary>File: Gets the file endpoint.</summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>Queue: Gets the queue endpoint.</summary>
    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    /// <summary>Table: Gets the table endpoint.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>Web: Gets the web endpoint.</summary>
    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>Ipv6Endpoints: Gets the IPv6 storage endpoints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusPrimaryEndpointsIpv6Endpoints
{
    /// <summary>Blob: Gets the blob endpoint.</summary>
    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    /// <summary>Dfs: Gets the dfs endpoint.</summary>
    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    /// <summary>File: Gets the file endpoint.</summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>InternetEndpoints: Gets the internet routing storage endpoints</summary>
    [JsonPropertyName("internetEndpoints")]
    public V20250601StorageAccountStatusPrimaryEndpointsIpv6EndpointsInternetEndpoints? InternetEndpoints { get; set; }

    /// <summary>MicrosoftEndpoints: Gets the microsoft routing storage endpoints.</summary>
    [JsonPropertyName("microsoftEndpoints")]
    public V20250601StorageAccountStatusPrimaryEndpointsIpv6EndpointsMicrosoftEndpoints? MicrosoftEndpoints { get; set; }

    /// <summary>Queue: Gets the queue endpoint.</summary>
    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    /// <summary>Table: Gets the table endpoint.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>Web: Gets the web endpoint.</summary>
    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>MicrosoftEndpoints: Gets the microsoft routing storage endpoints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusPrimaryEndpointsMicrosoftEndpoints
{
    /// <summary>Blob: Gets the blob endpoint.</summary>
    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    /// <summary>Dfs: Gets the dfs endpoint.</summary>
    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    /// <summary>File: Gets the file endpoint.</summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>Queue: Gets the queue endpoint.</summary>
    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    /// <summary>Table: Gets the table endpoint.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>Web: Gets the web endpoint.</summary>
    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>
/// PrimaryEndpoints: Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object. Note that
/// Standard_ZRS and Premium_LRS accounts only return the blob endpoint.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusPrimaryEndpoints
{
    /// <summary>Blob: Gets the blob endpoint.</summary>
    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    /// <summary>Dfs: Gets the dfs endpoint.</summary>
    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    /// <summary>File: Gets the file endpoint.</summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>InternetEndpoints: Gets the internet routing storage endpoints</summary>
    [JsonPropertyName("internetEndpoints")]
    public V20250601StorageAccountStatusPrimaryEndpointsInternetEndpoints? InternetEndpoints { get; set; }

    /// <summary>Ipv6Endpoints: Gets the IPv6 storage endpoints.</summary>
    [JsonPropertyName("ipv6Endpoints")]
    public V20250601StorageAccountStatusPrimaryEndpointsIpv6Endpoints? Ipv6Endpoints { get; set; }

    /// <summary>MicrosoftEndpoints: Gets the microsoft routing storage endpoints.</summary>
    [JsonPropertyName("microsoftEndpoints")]
    public V20250601StorageAccountStatusPrimaryEndpointsMicrosoftEndpoints? MicrosoftEndpoints { get; set; }

    /// <summary>Queue: Gets the queue endpoint.</summary>
    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    /// <summary>Table: Gets the table endpoint.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>Web: Gets the web endpoint.</summary>
    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>The Private Endpoint Connection resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>RoutingPreference: Maintains information about the network routing choice opted by the user for data transfer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusRoutingPreference
{
    /// <summary>PublishInternetEndpoints: A boolean flag which indicates whether internet routing storage endpoints are to be published</summary>
    [JsonPropertyName("publishInternetEndpoints")]
    public bool? PublishInternetEndpoints { get; set; }

    /// <summary>PublishMicrosoftEndpoints: A boolean flag which indicates whether microsoft routing storage endpoints are to be published</summary>
    [JsonPropertyName("publishMicrosoftEndpoints")]
    public bool? PublishMicrosoftEndpoints { get; set; }

    /// <summary>RoutingChoice: Routing Choice defines the kind of network routing opted by the user.</summary>
    [JsonPropertyName("routingChoice")]
    public string? RoutingChoice { get; set; }
}

/// <summary>SasPolicy: SasPolicy assigned to the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusSasPolicy
{
    /// <summary>
    /// ExpirationAction: The SAS Expiration Action defines the action to be performed when sasPolicy.sasExpirationPeriod is
    /// violated. The &apos;Log&apos; action can be used for audit purposes and the &apos;Block&apos; action can be used to block and deny the usage
    /// of SAS tokens that do not adhere to the sas policy expiration period.
    /// </summary>
    [JsonPropertyName("expirationAction")]
    public string? ExpirationAction { get; set; }

    /// <summary>SasExpirationPeriod: The SAS expiration period, DD.HH:MM:SS.</summary>
    [JsonPropertyName("sasExpirationPeriod")]
    public string? SasExpirationPeriod { get; set; }
}

/// <summary>InternetEndpoints: Gets the internet routing storage endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusSecondaryEndpointsInternetEndpoints
{
    /// <summary>Blob: Gets the blob endpoint.</summary>
    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    /// <summary>Dfs: Gets the dfs endpoint.</summary>
    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    /// <summary>File: Gets the file endpoint.</summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>Web: Gets the web endpoint.</summary>
    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>InternetEndpoints: Gets the internet routing storage endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusSecondaryEndpointsIpv6EndpointsInternetEndpoints
{
    /// <summary>Blob: Gets the blob endpoint.</summary>
    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    /// <summary>Dfs: Gets the dfs endpoint.</summary>
    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    /// <summary>File: Gets the file endpoint.</summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>Web: Gets the web endpoint.</summary>
    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>MicrosoftEndpoints: Gets the microsoft routing storage endpoints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusSecondaryEndpointsIpv6EndpointsMicrosoftEndpoints
{
    /// <summary>Blob: Gets the blob endpoint.</summary>
    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    /// <summary>Dfs: Gets the dfs endpoint.</summary>
    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    /// <summary>File: Gets the file endpoint.</summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>Queue: Gets the queue endpoint.</summary>
    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    /// <summary>Table: Gets the table endpoint.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>Web: Gets the web endpoint.</summary>
    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>Ipv6Endpoints: Gets the IPv6 storage endpoints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusSecondaryEndpointsIpv6Endpoints
{
    /// <summary>Blob: Gets the blob endpoint.</summary>
    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    /// <summary>Dfs: Gets the dfs endpoint.</summary>
    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    /// <summary>File: Gets the file endpoint.</summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>InternetEndpoints: Gets the internet routing storage endpoints</summary>
    [JsonPropertyName("internetEndpoints")]
    public V20250601StorageAccountStatusSecondaryEndpointsIpv6EndpointsInternetEndpoints? InternetEndpoints { get; set; }

    /// <summary>MicrosoftEndpoints: Gets the microsoft routing storage endpoints.</summary>
    [JsonPropertyName("microsoftEndpoints")]
    public V20250601StorageAccountStatusSecondaryEndpointsIpv6EndpointsMicrosoftEndpoints? MicrosoftEndpoints { get; set; }

    /// <summary>Queue: Gets the queue endpoint.</summary>
    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    /// <summary>Table: Gets the table endpoint.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>Web: Gets the web endpoint.</summary>
    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>MicrosoftEndpoints: Gets the microsoft routing storage endpoints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusSecondaryEndpointsMicrosoftEndpoints
{
    /// <summary>Blob: Gets the blob endpoint.</summary>
    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    /// <summary>Dfs: Gets the dfs endpoint.</summary>
    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    /// <summary>File: Gets the file endpoint.</summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>Queue: Gets the queue endpoint.</summary>
    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    /// <summary>Table: Gets the table endpoint.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>Web: Gets the web endpoint.</summary>
    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>
/// SecondaryEndpoints: Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object from the
/// secondary location of the storage account. Only available if the SKU name is Standard_RAGRS.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusSecondaryEndpoints
{
    /// <summary>Blob: Gets the blob endpoint.</summary>
    [JsonPropertyName("blob")]
    public string? Blob { get; set; }

    /// <summary>Dfs: Gets the dfs endpoint.</summary>
    [JsonPropertyName("dfs")]
    public string? Dfs { get; set; }

    /// <summary>File: Gets the file endpoint.</summary>
    [JsonPropertyName("file")]
    public string? File { get; set; }

    /// <summary>InternetEndpoints: Gets the internet routing storage endpoints</summary>
    [JsonPropertyName("internetEndpoints")]
    public V20250601StorageAccountStatusSecondaryEndpointsInternetEndpoints? InternetEndpoints { get; set; }

    /// <summary>Ipv6Endpoints: Gets the IPv6 storage endpoints.</summary>
    [JsonPropertyName("ipv6Endpoints")]
    public V20250601StorageAccountStatusSecondaryEndpointsIpv6Endpoints? Ipv6Endpoints { get; set; }

    /// <summary>MicrosoftEndpoints: Gets the microsoft routing storage endpoints.</summary>
    [JsonPropertyName("microsoftEndpoints")]
    public V20250601StorageAccountStatusSecondaryEndpointsMicrosoftEndpoints? MicrosoftEndpoints { get; set; }

    /// <summary>Queue: Gets the queue endpoint.</summary>
    [JsonPropertyName("queue")]
    public string? Queue { get; set; }

    /// <summary>Table: Gets the table endpoint.</summary>
    [JsonPropertyName("table")]
    public string? Table { get; set; }

    /// <summary>Web: Gets the web endpoint.</summary>
    [JsonPropertyName("web")]
    public string? Web { get; set; }
}

/// <summary>Sku: Gets the SKU.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusSku
{
    /// <summary>
    /// Name: The SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called
    /// accountType.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: The SKU tier. This is based on the SKU name.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// StorageAccountSkuConversionStatus: This property is readOnly and is set by server during asynchronous storage account
/// sku conversion operations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusStorageAccountSkuConversionStatus
{
    /// <summary>EndTime: This property represents the sku conversion end time.</summary>
    [JsonPropertyName("endTime")]
    public string? EndTime { get; set; }

    /// <summary>SkuConversionStatus: This property indicates the current sku conversion status.</summary>
    [JsonPropertyName("skuConversionStatus")]
    public string? SkuConversionStatus { get; set; }

    /// <summary>StartTime: This property represents the sku conversion start time.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>TargetSkuName: This property represents the target sku name to which the account sku is being converted asynchronously.</summary>
    [JsonPropertyName("targetSkuName")]
    public string? TargetSkuName { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>The storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250601StorageAccountStatus
{
    /// <summary>
    /// AccessTier: Required for storage accounts where kind = BlobStorage. The access tier is used for billing. The &apos;Premium&apos;
    /// access tier is the default value for premium block blobs storage account type and it cannot be changed for the premium
    /// block blobs storage account type.
    /// </summary>
    [JsonPropertyName("accessTier")]
    public string? AccessTier { get; set; }

    /// <summary>
    /// AccountMigrationInProgress: If customer initiated account migration is in progress, the value will be true else it will
    /// be null.
    /// </summary>
    [JsonPropertyName("accountMigrationInProgress")]
    public bool? AccountMigrationInProgress { get; set; }

    /// <summary>
    /// AllowBlobPublicAccess: Allow or disallow public access to all blobs or containers in the storage account. The default
    /// interpretation is false for this property.
    /// </summary>
    [JsonPropertyName("allowBlobPublicAccess")]
    public bool? AllowBlobPublicAccess { get; set; }

    /// <summary>
    /// AllowCrossTenantReplication: Allow or disallow cross AAD tenant object replication. Set this property to true for new or
    /// existing accounts only if object replication policies will involve storage accounts in different AAD tenants. The
    /// default interpretation is false for new accounts to follow best security practices by default.
    /// </summary>
    [JsonPropertyName("allowCrossTenantReplication")]
    public bool? AllowCrossTenantReplication { get; set; }

    /// <summary>
    /// AllowSharedKeyAccess: Indicates whether the storage account permits requests to be authorized with the account access
    /// key via Shared Key. If false, then all requests, including shared access signatures, must be authorized with Azure
    /// Active Directory (Azure AD). The default value is null, which is equivalent to true.
    /// </summary>
    [JsonPropertyName("allowSharedKeyAccess")]
    public bool? AllowSharedKeyAccess { get; set; }

    /// <summary>AllowedCopyScope: Restrict copy to and from Storage Accounts within an AAD tenant or with Private Links to the same VNet.</summary>
    [JsonPropertyName("allowedCopyScope")]
    public string? AllowedCopyScope { get; set; }

    /// <summary>AzureFilesIdentityBasedAuthentication: Provides the identity based authentication settings for Azure Files.</summary>
    [JsonPropertyName("azureFilesIdentityBasedAuthentication")]
    public V20250601StorageAccountStatusAzureFilesIdentityBasedAuthentication? AzureFilesIdentityBasedAuthentication { get; set; }

    /// <summary>BlobRestoreStatus: Blob restore status</summary>
    [JsonPropertyName("blobRestoreStatus")]
    public V20250601StorageAccountStatusBlobRestoreStatus? BlobRestoreStatus { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20250601StorageAccountStatusConditions>? Conditions { get; set; }

    /// <summary>CreationTime: Gets the creation date and time of the storage account in UTC.</summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>CustomDomain: Gets the custom domain the user assigned to this storage account.</summary>
    [JsonPropertyName("customDomain")]
    public V20250601StorageAccountStatusCustomDomain? CustomDomain { get; set; }

    /// <summary>
    /// DefaultToOAuthAuthentication: A boolean flag which indicates whether the default authentication is OAuth or not. The
    /// default interpretation is false for this property.
    /// </summary>
    [JsonPropertyName("defaultToOAuthAuthentication")]
    public bool? DefaultToOAuthAuthentication { get; set; }

    /// <summary>
    /// DnsEndpointType: Allows you to specify the type of endpoint. Set this to AzureDNSZone to create a large number of
    /// accounts in a single subscription, which creates accounts in an Azure DNS Zone and the endpoint URL will have an
    /// alphanumeric DNS Zone identifier.
    /// </summary>
    [JsonPropertyName("dnsEndpointType")]
    public string? DnsEndpointType { get; set; }

    /// <summary>DualStackEndpointPreference: Maintains information about the Internet protocol opted by the user.</summary>
    [JsonPropertyName("dualStackEndpointPreference")]
    public V20250601StorageAccountStatusDualStackEndpointPreference? DualStackEndpointPreference { get; set; }

    /// <summary>EnableExtendedGroups: Enables extended group support with local users feature, if set to true</summary>
    [JsonPropertyName("enableExtendedGroups")]
    public bool? EnableExtendedGroups { get; set; }

    /// <summary>Encryption: Encryption settings to be used for server-side encryption for the storage account.</summary>
    [JsonPropertyName("encryption")]
    public V20250601StorageAccountStatusEncryption? Encryption { get; set; }

    /// <summary>ExtendedLocation: The extendedLocation of the resource.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20250601StorageAccountStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>FailoverInProgress: If the failover is in progress, the value will be true, otherwise, it will be null.</summary>
    [JsonPropertyName("failoverInProgress")]
    public bool? FailoverInProgress { get; set; }

    /// <summary>GeoPriorityReplicationStatus: Status indicating whether Geo Priority Replication is enabled for the account.</summary>
    [JsonPropertyName("geoPriorityReplicationStatus")]
    public V20250601StorageAccountStatusGeoPriorityReplicationStatus? GeoPriorityReplicationStatus { get; set; }

    /// <summary>GeoReplicationStats: Geo Replication Stats</summary>
    [JsonPropertyName("geoReplicationStats")]
    public V20250601StorageAccountStatusGeoReplicationStats? GeoReplicationStats { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V20250601StorageAccountStatusIdentity? Identity { get; set; }

    /// <summary>
    /// ImmutableStorageWithVersioning: The property is immutable and can only be set to true at the account creation time. When
    /// set to true, it enables object level immutability for all the containers in the account by default.
    /// </summary>
    [JsonPropertyName("immutableStorageWithVersioning")]
    public V20250601StorageAccountStatusImmutableStorageWithVersioning? ImmutableStorageWithVersioning { get; set; }

    /// <summary>IsHnsEnabled: Account HierarchicalNamespace enabled if sets to true.</summary>
    [JsonPropertyName("isHnsEnabled")]
    public bool? IsHnsEnabled { get; set; }

    /// <summary>IsLocalUserEnabled: Enables local users feature, if set to true</summary>
    [JsonPropertyName("isLocalUserEnabled")]
    public bool? IsLocalUserEnabled { get; set; }

    /// <summary>IsNfsV3Enabled: NFS 3.0 protocol support enabled if set to true.</summary>
    [JsonPropertyName("isNfsV3Enabled")]
    public bool? IsNfsV3Enabled { get; set; }

    /// <summary>IsSftpEnabled: Enables Secure File Transfer Protocol, if set to true</summary>
    [JsonPropertyName("isSftpEnabled")]
    public bool? IsSftpEnabled { get; set; }

    /// <summary>
    /// IsSkuConversionBlocked: This property will be set to true or false on an event of ongoing migration. Default value is
    /// null.
    /// </summary>
    [JsonPropertyName("isSkuConversionBlocked")]
    public bool? IsSkuConversionBlocked { get; set; }

    /// <summary>KeyCreationTime: Storage account keys creation time.</summary>
    [JsonPropertyName("keyCreationTime")]
    public V20250601StorageAccountStatusKeyCreationTime? KeyCreationTime { get; set; }

    /// <summary>KeyPolicy: KeyPolicy assigned to the storage account.</summary>
    [JsonPropertyName("keyPolicy")]
    public V20250601StorageAccountStatusKeyPolicy? KeyPolicy { get; set; }

    /// <summary>Kind: Gets the Kind.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>LargeFileSharesState: Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled.</summary>
    [JsonPropertyName("largeFileSharesState")]
    public string? LargeFileSharesState { get; set; }

    /// <summary>
    /// LastGeoFailoverTime: Gets the timestamp of the most recent instance of a failover to the secondary location. Only the
    /// most recent timestamp is retained. This element is not returned if there has never been a failover instance. Only
    /// available if the accountType is Standard_GRS or Standard_RAGRS.
    /// </summary>
    [JsonPropertyName("lastGeoFailoverTime")]
    public string? LastGeoFailoverTime { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// MinimumTlsVersion: Set the minimum TLS version to be permitted on requests to storage. The default interpretation is TLS
    /// 1.0 for this property.
    /// </summary>
    [JsonPropertyName("minimumTlsVersion")]
    public string? MinimumTlsVersion { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkAcls: Network rule set</summary>
    [JsonPropertyName("networkAcls")]
    public V20250601StorageAccountStatusNetworkAcls? NetworkAcls { get; set; }

    /// <summary>Placement: Optional. Gets or sets the zonal placement details for the storage account.</summary>
    [JsonPropertyName("placement")]
    public V20250601StorageAccountStatusPlacement? Placement { get; set; }

    /// <summary>
    /// PrimaryEndpoints: Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object. Note that
    /// Standard_ZRS and Premium_LRS accounts only return the blob endpoint.
    /// </summary>
    [JsonPropertyName("primaryEndpoints")]
    public V20250601StorageAccountStatusPrimaryEndpoints? PrimaryEndpoints { get; set; }

    /// <summary>PrimaryLocation: Gets the location of the primary data center for the storage account.</summary>
    [JsonPropertyName("primaryLocation")]
    public string? PrimaryLocation { get; set; }

    /// <summary>PrivateEndpointConnections: List of private endpoint connection associated with the specified storage account</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V20250601StorageAccountStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>ProvisioningState: Gets the status of the storage account at the time the operation was called.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// PublicNetworkAccess: Allow, disallow, or let Network Security Perimeter configuration to evaluate public network access
    /// to Storage Account.
    /// </summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>RoutingPreference: Maintains information about the network routing choice opted by the user for data transfer</summary>
    [JsonPropertyName("routingPreference")]
    public V20250601StorageAccountStatusRoutingPreference? RoutingPreference { get; set; }

    /// <summary>SasPolicy: SasPolicy assigned to the storage account.</summary>
    [JsonPropertyName("sasPolicy")]
    public V20250601StorageAccountStatusSasPolicy? SasPolicy { get; set; }

    /// <summary>
    /// SecondaryEndpoints: Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object from the
    /// secondary location of the storage account. Only available if the SKU name is Standard_RAGRS.
    /// </summary>
    [JsonPropertyName("secondaryEndpoints")]
    public V20250601StorageAccountStatusSecondaryEndpoints? SecondaryEndpoints { get; set; }

    /// <summary>
    /// SecondaryLocation: Gets the location of the geo-replicated secondary for the storage account. Only available if the
    /// accountType is Standard_GRS or Standard_RAGRS.
    /// </summary>
    [JsonPropertyName("secondaryLocation")]
    public string? SecondaryLocation { get; set; }

    /// <summary>Sku: Gets the SKU.</summary>
    [JsonPropertyName("sku")]
    public V20250601StorageAccountStatusSku? Sku { get; set; }

    /// <summary>
    /// StatusOfPrimary: Gets the status indicating whether the primary location of the storage account is available or
    /// unavailable.
    /// </summary>
    [JsonPropertyName("statusOfPrimary")]
    public string? StatusOfPrimary { get; set; }

    /// <summary>
    /// StatusOfSecondary: Gets the status indicating whether the secondary location of the storage account is available or
    /// unavailable. Only available if the SKU name is Standard_GRS or Standard_RAGRS.
    /// </summary>
    [JsonPropertyName("statusOfSecondary")]
    public string? StatusOfSecondary { get; set; }

    /// <summary>
    /// StorageAccountSkuConversionStatus: This property is readOnly and is set by server during asynchronous storage account
    /// sku conversion operations.
    /// </summary>
    [JsonPropertyName("storageAccountSkuConversionStatus")]
    public V20250601StorageAccountStatusStorageAccountSkuConversionStatus? StorageAccountSkuConversionStatus { get; set; }

    /// <summary>SupportsHttpsTrafficOnly: Allows https traffic only to storage service if sets to true.</summary>
    [JsonPropertyName("supportsHttpsTrafficOnly")]
    public bool? SupportsHttpsTrafficOnly { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20250601StorageAccountStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Zones: The availability zones.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2025-06-01/openapi.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250601StorageAccount : IKubernetesObject<V1ObjectMeta>, ISpec<V20250601StorageAccountSpec?>, IStatus<V20250601StorageAccountStatus?>
{
    public const string KubeApiVersion = "v20250601";
    public const string KubeKind = "StorageAccount";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v20250601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccount";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20250601StorageAccountSpec? Spec { get; set; }

    /// <summary>The storage account.</summary>
    [JsonPropertyName("status")]
    public V20250601StorageAccountStatus? Status { get; set; }
}