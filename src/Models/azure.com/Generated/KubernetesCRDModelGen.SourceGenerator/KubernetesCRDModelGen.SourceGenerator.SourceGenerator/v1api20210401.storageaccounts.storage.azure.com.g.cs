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
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2021-04-01/storage.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210401StorageAccountList : IKubernetesObject<V1ListMeta>, IItems<V1api20210401StorageAccount>
{
    public const string KubeApiVersion = "v1api20210401";
    public const string KubeKind = "StorageAccountList";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v1api20210401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccountList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20210401StorageAccount objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20210401StorageAccount> Items { get; set; }
}

/// <summary>AccessTier: Required for storage accounts where kind = BlobStorage. The access tier used for billing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecAccessTierEnum>))]
public enum V1api20210401StorageAccountSpecAccessTierEnum
{
    [EnumMember(Value = "Cool"), JsonStringEnumMemberName("Cool")]
    Cool,
    [EnumMember(Value = "Hot"), JsonStringEnumMemberName("Hot")]
    Hot
}

/// <summary>ActiveDirectoryProperties: Required if choose AD.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecAzureFilesIdentityBasedAuthenticationActiveDirectoryProperties
{
    /// <summary>AzureStorageSid: Specifies the security identifier (SID) for Azure Storage.</summary>
    [JsonPropertyName("azureStorageSid")]
    public required string AzureStorageSid { get; set; }

    /// <summary>DomainGuid: Specifies the domain GUID.</summary>
    [JsonPropertyName("domainGuid")]
    public required string DomainGuid { get; set; }

    /// <summary>DomainName: Specifies the primary domain that the AD DNS server is authoritative for.</summary>
    [JsonPropertyName("domainName")]
    public required string DomainName { get; set; }

    /// <summary>DomainSid: Specifies the security identifier (SID).</summary>
    [JsonPropertyName("domainSid")]
    public required string DomainSid { get; set; }

    /// <summary>ForestName: Specifies the Active Directory forest to get.</summary>
    [JsonPropertyName("forestName")]
    public required string ForestName { get; set; }

    /// <summary>NetBiosDomainName: Specifies the NetBIOS domain name.</summary>
    [JsonPropertyName("netBiosDomainName")]
    public required string NetBiosDomainName { get; set; }
}

/// <summary>DefaultSharePermission: Default share permission for users using Kerberos authentication if RBAC role is not assigned.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecAzureFilesIdentityBasedAuthenticationDefaultSharePermissionEnum>))]
public enum V1api20210401StorageAccountSpecAzureFilesIdentityBasedAuthenticationDefaultSharePermissionEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "StorageFileDataSmbShareContributor"), JsonStringEnumMemberName("StorageFileDataSmbShareContributor")]
    StorageFileDataSmbShareContributor,
    [EnumMember(Value = "StorageFileDataSmbShareElevatedContributor"), JsonStringEnumMemberName("StorageFileDataSmbShareElevatedContributor")]
    StorageFileDataSmbShareElevatedContributor,
    [EnumMember(Value = "StorageFileDataSmbShareOwner"), JsonStringEnumMemberName("StorageFileDataSmbShareOwner")]
    StorageFileDataSmbShareOwner,
    [EnumMember(Value = "StorageFileDataSmbShareReader"), JsonStringEnumMemberName("StorageFileDataSmbShareReader")]
    StorageFileDataSmbShareReader
}

/// <summary>DirectoryServiceOptions: Indicates the directory service used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecAzureFilesIdentityBasedAuthenticationDirectoryServiceOptionsEnum>))]
public enum V1api20210401StorageAccountSpecAzureFilesIdentityBasedAuthenticationDirectoryServiceOptionsEnum
{
    [EnumMember(Value = "AADDS"), JsonStringEnumMemberName("AADDS")]
    AADDS,
    [EnumMember(Value = "AD"), JsonStringEnumMemberName("AD")]
    AD,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>AzureFilesIdentityBasedAuthentication: Provides the identity based authentication settings for Azure Files.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecAzureFilesIdentityBasedAuthentication
{
    /// <summary>ActiveDirectoryProperties: Required if choose AD.</summary>
    [JsonPropertyName("activeDirectoryProperties")]
    public V1api20210401StorageAccountSpecAzureFilesIdentityBasedAuthenticationActiveDirectoryProperties? ActiveDirectoryProperties { get; set; }

    /// <summary>DefaultSharePermission: Default share permission for users using Kerberos authentication if RBAC role is not assigned.</summary>
    [JsonPropertyName("defaultSharePermission")]
    public V1api20210401StorageAccountSpecAzureFilesIdentityBasedAuthenticationDefaultSharePermissionEnum? DefaultSharePermission { get; set; }

    /// <summary>DirectoryServiceOptions: Indicates the directory service used.</summary>
    [JsonPropertyName("directoryServiceOptions")]
    public required V1api20210401StorageAccountSpecAzureFilesIdentityBasedAuthenticationDirectoryServiceOptionsEnum DirectoryServiceOptions { get; set; }
}

/// <summary>
/// CustomDomain: User domain assigned to the storage account. Name is the CNAME source. Only one custom domain is supported
/// per storage account at this time. To clear the existing custom domain, use an empty string for the custom domain name
/// property.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecCustomDomain
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
/// UserAssignedIdentityReference: Resource identifier of the UserAssigned identity to be associated with server-side
/// encryption on the storage account.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecEncryptionIdentityUserAssignedIdentityReference
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
public partial class V1api20210401StorageAccountSpecEncryptionIdentity
{
    /// <summary>
    /// UserAssignedIdentityReference: Resource identifier of the UserAssigned identity to be associated with server-side
    /// encryption on the storage account.
    /// </summary>
    [JsonPropertyName("userAssignedIdentityReference")]
    public V1api20210401StorageAccountSpecEncryptionIdentityUserAssignedIdentityReference? UserAssignedIdentityReference { get; set; }
}

/// <summary>
/// KeySource: The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage,
/// Microsoft.Keyvault
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecEncryptionKeySourceEnum>))]
public enum V1api20210401StorageAccountSpecEncryptionKeySourceEnum
{
    [EnumMember(Value = "Microsoft.Keyvault"), JsonStringEnumMemberName("Microsoft.Keyvault")]
    MicrosoftKeyvault,
    [EnumMember(Value = "Microsoft.Storage"), JsonStringEnumMemberName("Microsoft.Storage")]
    MicrosoftStorage
}

/// <summary>Keyvaultproperties: Properties provided by key vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecEncryptionKeyvaultproperties
{
    /// <summary>Keyname: The name of KeyVault key.</summary>
    [JsonPropertyName("keyname")]
    public string? Keyname { get; set; }

    /// <summary>Keyvaulturi: The Uri of KeyVault.</summary>
    [JsonPropertyName("keyvaulturi")]
    public string? Keyvaulturi { get; set; }

    /// <summary>Keyversion: The version of KeyVault key.</summary>
    [JsonPropertyName("keyversion")]
    public string? Keyversion { get; set; }
}

/// <summary>
/// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
/// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecEncryptionServicesBlobKeyTypeEnum>))]
public enum V1api20210401StorageAccountSpecEncryptionServicesBlobKeyTypeEnum
{
    [EnumMember(Value = "Account"), JsonStringEnumMemberName("Account")]
    Account,
    [EnumMember(Value = "Service"), JsonStringEnumMemberName("Service")]
    Service
}

/// <summary>Blob: The encryption function of the blob storage service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecEncryptionServicesBlob
{
    /// <summary>Enabled: A boolean indicating whether or not the service encrypts the data as it is stored.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
    /// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
    /// </summary>
    [JsonPropertyName("keyType")]
    public V1api20210401StorageAccountSpecEncryptionServicesBlobKeyTypeEnum? KeyType { get; set; }
}

/// <summary>
/// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
/// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecEncryptionServicesFileKeyTypeEnum>))]
public enum V1api20210401StorageAccountSpecEncryptionServicesFileKeyTypeEnum
{
    [EnumMember(Value = "Account"), JsonStringEnumMemberName("Account")]
    Account,
    [EnumMember(Value = "Service"), JsonStringEnumMemberName("Service")]
    Service
}

/// <summary>File: The encryption function of the file storage service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecEncryptionServicesFile
{
    /// <summary>Enabled: A boolean indicating whether or not the service encrypts the data as it is stored.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
    /// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
    /// </summary>
    [JsonPropertyName("keyType")]
    public V1api20210401StorageAccountSpecEncryptionServicesFileKeyTypeEnum? KeyType { get; set; }
}

/// <summary>
/// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
/// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecEncryptionServicesQueueKeyTypeEnum>))]
public enum V1api20210401StorageAccountSpecEncryptionServicesQueueKeyTypeEnum
{
    [EnumMember(Value = "Account"), JsonStringEnumMemberName("Account")]
    Account,
    [EnumMember(Value = "Service"), JsonStringEnumMemberName("Service")]
    Service
}

/// <summary>Queue: The encryption function of the queue storage service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecEncryptionServicesQueue
{
    /// <summary>Enabled: A boolean indicating whether or not the service encrypts the data as it is stored.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
    /// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
    /// </summary>
    [JsonPropertyName("keyType")]
    public V1api20210401StorageAccountSpecEncryptionServicesQueueKeyTypeEnum? KeyType { get; set; }
}

/// <summary>
/// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
/// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecEncryptionServicesTableKeyTypeEnum>))]
public enum V1api20210401StorageAccountSpecEncryptionServicesTableKeyTypeEnum
{
    [EnumMember(Value = "Account"), JsonStringEnumMemberName("Account")]
    Account,
    [EnumMember(Value = "Service"), JsonStringEnumMemberName("Service")]
    Service
}

/// <summary>Table: The encryption function of the table storage service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecEncryptionServicesTable
{
    /// <summary>Enabled: A boolean indicating whether or not the service encrypts the data as it is stored.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
    /// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
    /// </summary>
    [JsonPropertyName("keyType")]
    public V1api20210401StorageAccountSpecEncryptionServicesTableKeyTypeEnum? KeyType { get; set; }
}

/// <summary>Services: List of services which support encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecEncryptionServices
{
    /// <summary>Blob: The encryption function of the blob storage service.</summary>
    [JsonPropertyName("blob")]
    public V1api20210401StorageAccountSpecEncryptionServicesBlob? Blob { get; set; }

    /// <summary>File: The encryption function of the file storage service.</summary>
    [JsonPropertyName("file")]
    public V1api20210401StorageAccountSpecEncryptionServicesFile? File { get; set; }

    /// <summary>Queue: The encryption function of the queue storage service.</summary>
    [JsonPropertyName("queue")]
    public V1api20210401StorageAccountSpecEncryptionServicesQueue? Queue { get; set; }

    /// <summary>Table: The encryption function of the table storage service.</summary>
    [JsonPropertyName("table")]
    public V1api20210401StorageAccountSpecEncryptionServicesTable? Table { get; set; }
}

/// <summary>Encryption: Not applicable. Azure Storage encryption is enabled for all storage accounts and cannot be disabled.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecEncryption
{
    /// <summary>Identity: The identity to be used with service-side encryption at rest.</summary>
    [JsonPropertyName("identity")]
    public V1api20210401StorageAccountSpecEncryptionIdentity? Identity { get; set; }

    /// <summary>
    /// KeySource: The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage,
    /// Microsoft.Keyvault
    /// </summary>
    [JsonPropertyName("keySource")]
    public required V1api20210401StorageAccountSpecEncryptionKeySourceEnum KeySource { get; set; }

    /// <summary>Keyvaultproperties: Properties provided by key vault.</summary>
    [JsonPropertyName("keyvaultproperties")]
    public V1api20210401StorageAccountSpecEncryptionKeyvaultproperties? Keyvaultproperties { get; set; }

    /// <summary>
    /// RequireInfrastructureEncryption: A boolean indicating whether or not the service applies a secondary layer of encryption
    /// with platform managed keys for data at rest.
    /// </summary>
    [JsonPropertyName("requireInfrastructureEncryption")]
    public bool? RequireInfrastructureEncryption { get; set; }

    /// <summary>Services: List of services which support encryption.</summary>
    [JsonPropertyName("services")]
    public V1api20210401StorageAccountSpecEncryptionServices? Services { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecExtendedLocationTypeEnum>))]
public enum V1api20210401StorageAccountSpecExtendedLocationTypeEnum
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
public partial class V1api20210401StorageAccountSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V1api20210401StorageAccountSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>Type: The identity type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecIdentityTypeEnum>))]
public enum V1api20210401StorageAccountSpecIdentityTypeEnum
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
public partial class V1api20210401StorageAccountSpecIdentityUserAssignedIdentitiesReference
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
public partial class V1api20210401StorageAccountSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V1api20210401StorageAccountSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>Identity: The identity of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecIdentity
{
    /// <summary>Type: The identity type.</summary>
    [JsonPropertyName("type")]
    public required V1api20210401StorageAccountSpecIdentityTypeEnum Type { get; set; }

    /// <summary>
    /// UserAssignedIdentities: Gets or sets a list of key value pairs that describe the set of User Assigned identities that
    /// will be used with this storage account. The key is the ARM resource identifier of the identity. Only 1 User Assigned
    /// identity is permitted here.
    /// </summary>
    [JsonPropertyName("userAssignedIdentities")]
    public IList<V1api20210401StorageAccountSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>KeyPolicy: KeyPolicy assigned to the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecKeyPolicy
{
    /// <summary>KeyExpirationPeriodInDays: The key expiration period in days.</summary>
    [JsonPropertyName("keyExpirationPeriodInDays")]
    public required int KeyExpirationPeriodInDays { get; set; }
}

/// <summary>Kind: Required. Indicates the type of storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecKindEnum>))]
public enum V1api20210401StorageAccountSpecKindEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecLargeFileSharesStateEnum>))]
public enum V1api20210401StorageAccountSpecLargeFileSharesStateEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecMinimumTlsVersionEnum>))]
public enum V1api20210401StorageAccountSpecMinimumTlsVersionEnum
{
    [EnumMember(Value = "TLS1_0"), JsonStringEnumMemberName("TLS1_0")]
    TLS10,
    [EnumMember(Value = "TLS1_1"), JsonStringEnumMemberName("TLS1_1")]
    TLS11,
    [EnumMember(Value = "TLS1_2"), JsonStringEnumMemberName("TLS1_2")]
    TLS12
}

/// <summary>DefaultAction: Specifies the default action of allow or deny when no other rules match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecNetworkAclsDefaultActionEnum>))]
public enum V1api20210401StorageAccountSpecNetworkAclsDefaultActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow,
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny
}

/// <summary>Action: The action of IP ACL rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecNetworkAclsIpRulesActionEnum>))]
public enum V1api20210401StorageAccountSpecNetworkAclsIpRulesActionEnum
{
    [EnumMember(Value = "Allow"), JsonStringEnumMemberName("Allow")]
    Allow
}

/// <summary>ValueFromConfig: Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecNetworkAclsIpRulesValueFromConfig
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
public partial class V1api20210401StorageAccountSpecNetworkAclsIpRules
{
    /// <summary>Action: The action of IP ACL rule.</summary>
    [JsonPropertyName("action")]
    public V1api20210401StorageAccountSpecNetworkAclsIpRulesActionEnum? Action { get; set; }

    /// <summary>Value: Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>ValueFromConfig: Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.</summary>
    [JsonPropertyName("valueFromConfig")]
    public V1api20210401StorageAccountSpecNetworkAclsIpRulesValueFromConfig? ValueFromConfig { get; set; }
}

/// <summary>ResourceReference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecNetworkAclsResourceAccessRulesResourceReference
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
public partial class V1api20210401StorageAccountSpecNetworkAclsResourceAccessRules
{
    /// <summary>ResourceReference: Resource Id</summary>
    [JsonPropertyName("resourceReference")]
    public V1api20210401StorageAccountSpecNetworkAclsResourceAccessRulesResourceReference? ResourceReference { get; set; }

    /// <summary>TenantId: Tenant Id</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }
}

/// <summary>Action: The action of virtual network rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecNetworkAclsVirtualNetworkRulesActionEnum>))]
public enum V1api20210401StorageAccountSpecNetworkAclsVirtualNetworkRulesActionEnum
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
public partial class V1api20210401StorageAccountSpecNetworkAclsVirtualNetworkRulesReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecNetworkAclsVirtualNetworkRulesStateEnum>))]
public enum V1api20210401StorageAccountSpecNetworkAclsVirtualNetworkRulesStateEnum
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
public partial class V1api20210401StorageAccountSpecNetworkAclsVirtualNetworkRules
{
    /// <summary>Action: The action of virtual network rule.</summary>
    [JsonPropertyName("action")]
    public V1api20210401StorageAccountSpecNetworkAclsVirtualNetworkRulesActionEnum? Action { get; set; }

    /// <summary>
    /// Reference: Resource ID of a subnet, for example:
    /// /subscriptions/{subscriptionId}/resourceGroups/{groupName}/providers/Microsoft.Network/virtualNetworks/{vnetName}/subnets/{subnetName}.
    /// </summary>
    [JsonPropertyName("reference")]
    public required V1api20210401StorageAccountSpecNetworkAclsVirtualNetworkRulesReference Reference { get; set; }

    /// <summary>State: Gets the state of virtual network rule.</summary>
    [JsonPropertyName("state")]
    public V1api20210401StorageAccountSpecNetworkAclsVirtualNetworkRulesStateEnum? State { get; set; }
}

/// <summary>NetworkAcls: Network rule set</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecNetworkAcls
{
    /// <summary>
    /// Bypass: Specifies whether traffic is bypassed for Logging/Metrics/AzureServices. Possible values are any combination of
    /// Logging|Metrics|AzureServices (For example, &quot;Logging, Metrics&quot;), or None to bypass none of those traffics.
    /// </summary>
    [JsonPropertyName("bypass")]
    public string? Bypass { get; set; }

    /// <summary>DefaultAction: Specifies the default action of allow or deny when no other rules match.</summary>
    [JsonPropertyName("defaultAction")]
    public required V1api20210401StorageAccountSpecNetworkAclsDefaultActionEnum DefaultAction { get; set; }

    /// <summary>IpRules: Sets the IP ACL rules</summary>
    [JsonPropertyName("ipRules")]
    public IList<V1api20210401StorageAccountSpecNetworkAclsIpRules>? IpRules { get; set; }

    /// <summary>ResourceAccessRules: Sets the resource access rules</summary>
    [JsonPropertyName("resourceAccessRules")]
    public IList<V1api20210401StorageAccountSpecNetworkAclsResourceAccessRules>? ResourceAccessRules { get; set; }

    /// <summary>VirtualNetworkRules: Sets the virtual network rules</summary>
    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20210401StorageAccountSpecNetworkAclsVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20210401StorageAccountSpecOperatorSpecConfigMapsBlobEndpoint
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
public partial class V1api20210401StorageAccountSpecOperatorSpecConfigMapsDfsEndpoint
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
public partial class V1api20210401StorageAccountSpecOperatorSpecConfigMapsFileEndpoint
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
public partial class V1api20210401StorageAccountSpecOperatorSpecConfigMapsQueueEndpoint
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
public partial class V1api20210401StorageAccountSpecOperatorSpecConfigMapsTableEndpoint
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
public partial class V1api20210401StorageAccountSpecOperatorSpecConfigMapsWebEndpoint
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
public partial class V1api20210401StorageAccountSpecOperatorSpecConfigMaps
{
    /// <summary>BlobEndpoint: indicates where the BlobEndpoint config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("blobEndpoint")]
    public V1api20210401StorageAccountSpecOperatorSpecConfigMapsBlobEndpoint? BlobEndpoint { get; set; }

    /// <summary>DfsEndpoint: indicates where the DfsEndpoint config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("dfsEndpoint")]
    public V1api20210401StorageAccountSpecOperatorSpecConfigMapsDfsEndpoint? DfsEndpoint { get; set; }

    /// <summary>FileEndpoint: indicates where the FileEndpoint config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("fileEndpoint")]
    public V1api20210401StorageAccountSpecOperatorSpecConfigMapsFileEndpoint? FileEndpoint { get; set; }

    /// <summary>QueueEndpoint: indicates where the QueueEndpoint config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("queueEndpoint")]
    public V1api20210401StorageAccountSpecOperatorSpecConfigMapsQueueEndpoint? QueueEndpoint { get; set; }

    /// <summary>TableEndpoint: indicates where the TableEndpoint config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("tableEndpoint")]
    public V1api20210401StorageAccountSpecOperatorSpecConfigMapsTableEndpoint? TableEndpoint { get; set; }

    /// <summary>WebEndpoint: indicates where the WebEndpoint config map should be placed. If omitted, no config map will be created.</summary>
    [JsonPropertyName("webEndpoint")]
    public V1api20210401StorageAccountSpecOperatorSpecConfigMapsWebEndpoint? WebEndpoint { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecOperatorSpecSecretExpressions
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
public partial class V1api20210401StorageAccountSpecOperatorSpecSecretsBlobEndpoint
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
public partial class V1api20210401StorageAccountSpecOperatorSpecSecretsDfsEndpoint
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
public partial class V1api20210401StorageAccountSpecOperatorSpecSecretsFileEndpoint
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
public partial class V1api20210401StorageAccountSpecOperatorSpecSecretsKey1
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
public partial class V1api20210401StorageAccountSpecOperatorSpecSecretsKey2
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
public partial class V1api20210401StorageAccountSpecOperatorSpecSecretsQueueEndpoint
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
public partial class V1api20210401StorageAccountSpecOperatorSpecSecretsTableEndpoint
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
public partial class V1api20210401StorageAccountSpecOperatorSpecSecretsWebEndpoint
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
public partial class V1api20210401StorageAccountSpecOperatorSpecSecrets
{
    /// <summary>
    /// BlobEndpoint: indicates where the BlobEndpoint secret should be placed. If omitted, the secret will not be retrieved
    /// from Azure.
    /// </summary>
    [JsonPropertyName("blobEndpoint")]
    public V1api20210401StorageAccountSpecOperatorSpecSecretsBlobEndpoint? BlobEndpoint { get; set; }

    /// <summary>
    /// DfsEndpoint: indicates where the DfsEndpoint secret should be placed. If omitted, the secret will not be retrieved from
    /// Azure.
    /// </summary>
    [JsonPropertyName("dfsEndpoint")]
    public V1api20210401StorageAccountSpecOperatorSpecSecretsDfsEndpoint? DfsEndpoint { get; set; }

    /// <summary>
    /// FileEndpoint: indicates where the FileEndpoint secret should be placed. If omitted, the secret will not be retrieved
    /// from Azure.
    /// </summary>
    [JsonPropertyName("fileEndpoint")]
    public V1api20210401StorageAccountSpecOperatorSpecSecretsFileEndpoint? FileEndpoint { get; set; }

    /// <summary>Key1: indicates where the Key1 secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
    [JsonPropertyName("key1")]
    public V1api20210401StorageAccountSpecOperatorSpecSecretsKey1? Key1 { get; set; }

    /// <summary>Key2: indicates where the Key2 secret should be placed. If omitted, the secret will not be retrieved from Azure.</summary>
    [JsonPropertyName("key2")]
    public V1api20210401StorageAccountSpecOperatorSpecSecretsKey2? Key2 { get; set; }

    /// <summary>
    /// QueueEndpoint: indicates where the QueueEndpoint secret should be placed. If omitted, the secret will not be retrieved
    /// from Azure.
    /// </summary>
    [JsonPropertyName("queueEndpoint")]
    public V1api20210401StorageAccountSpecOperatorSpecSecretsQueueEndpoint? QueueEndpoint { get; set; }

    /// <summary>
    /// TableEndpoint: indicates where the TableEndpoint secret should be placed. If omitted, the secret will not be retrieved
    /// from Azure.
    /// </summary>
    [JsonPropertyName("tableEndpoint")]
    public V1api20210401StorageAccountSpecOperatorSpecSecretsTableEndpoint? TableEndpoint { get; set; }

    /// <summary>
    /// WebEndpoint: indicates where the WebEndpoint secret should be placed. If omitted, the secret will not be retrieved from
    /// Azure.
    /// </summary>
    [JsonPropertyName("webEndpoint")]
    public V1api20210401StorageAccountSpecOperatorSpecSecretsWebEndpoint? WebEndpoint { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210401StorageAccountSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>ConfigMaps: configures where to place operator written ConfigMaps.</summary>
    [JsonPropertyName("configMaps")]
    public V1api20210401StorageAccountSpecOperatorSpecConfigMaps? ConfigMaps { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210401StorageAccountSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }

    /// <summary>Secrets: configures where to place Azure generated secrets.</summary>
    [JsonPropertyName("secrets")]
    public V1api20210401StorageAccountSpecOperatorSpecSecrets? Secrets { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>RoutingChoice: Routing Choice defines the kind of network routing opted by the user.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecRoutingPreferenceRoutingChoiceEnum>))]
public enum V1api20210401StorageAccountSpecRoutingPreferenceRoutingChoiceEnum
{
    [EnumMember(Value = "InternetRouting"), JsonStringEnumMemberName("InternetRouting")]
    InternetRouting,
    [EnumMember(Value = "MicrosoftRouting"), JsonStringEnumMemberName("MicrosoftRouting")]
    MicrosoftRouting
}

/// <summary>RoutingPreference: Maintains information about the network routing choice opted by the user for data transfer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecRoutingPreference
{
    /// <summary>PublishInternetEndpoints: A boolean flag which indicates whether internet routing storage endpoints are to be published</summary>
    [JsonPropertyName("publishInternetEndpoints")]
    public bool? PublishInternetEndpoints { get; set; }

    /// <summary>PublishMicrosoftEndpoints: A boolean flag which indicates whether microsoft routing storage endpoints are to be published</summary>
    [JsonPropertyName("publishMicrosoftEndpoints")]
    public bool? PublishMicrosoftEndpoints { get; set; }

    /// <summary>RoutingChoice: Routing Choice defines the kind of network routing opted by the user.</summary>
    [JsonPropertyName("routingChoice")]
    public V1api20210401StorageAccountSpecRoutingPreferenceRoutingChoiceEnum? RoutingChoice { get; set; }
}

/// <summary>ExpirationAction: The SAS expiration action. Can only be Log.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecSasPolicyExpirationActionEnum>))]
public enum V1api20210401StorageAccountSpecSasPolicyExpirationActionEnum
{
    [EnumMember(Value = "Log"), JsonStringEnumMemberName("Log")]
    Log
}

/// <summary>SasPolicy: SasPolicy assigned to the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecSasPolicy
{
    /// <summary>ExpirationAction: The SAS expiration action. Can only be Log.</summary>
    [JsonPropertyName("expirationAction")]
    public required V1api20210401StorageAccountSpecSasPolicyExpirationActionEnum ExpirationAction { get; set; }

    /// <summary>SasExpirationPeriod: The SAS expiration period, DD.HH:MM:SS.</summary>
    [JsonPropertyName("sasExpirationPeriod")]
    public required string SasExpirationPeriod { get; set; }
}

/// <summary>
/// Name: The SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called
///  accountType.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecSkuNameEnum>))]
public enum V1api20210401StorageAccountSpecSkuNameEnum
{
    [EnumMember(Value = "Premium_LRS"), JsonStringEnumMemberName("Premium_LRS")]
    PremiumLRS,
    [EnumMember(Value = "Premium_ZRS"), JsonStringEnumMemberName("Premium_ZRS")]
    PremiumZRS,
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

/// <summary>Tier: The SKU tier. This is based on the SKU name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20210401StorageAccountSpecSkuTierEnum>))]
public enum V1api20210401StorageAccountSpecSkuTierEnum
{
    [EnumMember(Value = "Premium"), JsonStringEnumMemberName("Premium")]
    Premium,
    [EnumMember(Value = "Standard"), JsonStringEnumMemberName("Standard")]
    Standard
}

/// <summary>Sku: Required. Gets or sets the SKU name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpecSku
{
    /// <summary>
    /// Name: The SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called
    ///  accountType.
    /// </summary>
    [JsonPropertyName("name")]
    public required V1api20210401StorageAccountSpecSkuNameEnum Name { get; set; }

    /// <summary>Tier: The SKU tier. This is based on the SKU name.</summary>
    [JsonPropertyName("tier")]
    public V1api20210401StorageAccountSpecSkuTierEnum? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountSpec
{
    /// <summary>AccessTier: Required for storage accounts where kind = BlobStorage. The access tier used for billing.</summary>
    [JsonPropertyName("accessTier")]
    public V1api20210401StorageAccountSpecAccessTierEnum? AccessTier { get; set; }

    /// <summary>
    /// AllowBlobPublicAccess: Allow or disallow public access to all blobs or containers in the storage account. The default
    /// interpretation is true for this property.
    /// </summary>
    [JsonPropertyName("allowBlobPublicAccess")]
    public bool? AllowBlobPublicAccess { get; set; }

    /// <summary>
    /// AllowCrossTenantReplication: Allow or disallow cross AAD tenant object replication. The default interpretation is true
    /// for this property.
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

    /// <summary>AzureFilesIdentityBasedAuthentication: Provides the identity based authentication settings for Azure Files.</summary>
    [JsonPropertyName("azureFilesIdentityBasedAuthentication")]
    public V1api20210401StorageAccountSpecAzureFilesIdentityBasedAuthentication? AzureFilesIdentityBasedAuthentication { get; set; }

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
    public V1api20210401StorageAccountSpecCustomDomain? CustomDomain { get; set; }

    /// <summary>Encryption: Not applicable. Azure Storage encryption is enabled for all storage accounts and cannot be disabled.</summary>
    [JsonPropertyName("encryption")]
    public V1api20210401StorageAccountSpecEncryption? Encryption { get; set; }

    /// <summary>
    /// ExtendedLocation: Optional. Set the extended location of the resource. If not set, the storage account will be created
    /// in Azure main region. Otherwise it will be created in the specified extended location
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20210401StorageAccountSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20210401StorageAccountSpecIdentity? Identity { get; set; }

    /// <summary>IsHnsEnabled: Account HierarchicalNamespace enabled if sets to true.</summary>
    [JsonPropertyName("isHnsEnabled")]
    public bool? IsHnsEnabled { get; set; }

    /// <summary>IsNfsV3Enabled: NFS 3.0 protocol support enabled if set to true.</summary>
    [JsonPropertyName("isNfsV3Enabled")]
    public bool? IsNfsV3Enabled { get; set; }

    /// <summary>KeyPolicy: KeyPolicy assigned to the storage account.</summary>
    [JsonPropertyName("keyPolicy")]
    public V1api20210401StorageAccountSpecKeyPolicy? KeyPolicy { get; set; }

    /// <summary>Kind: Required. Indicates the type of storage account.</summary>
    [JsonPropertyName("kind")]
    public required V1api20210401StorageAccountSpecKindEnum Kind { get; set; }

    /// <summary>LargeFileSharesState: Allow large file shares if sets to Enabled. It cannot be disabled once it is enabled.</summary>
    [JsonPropertyName("largeFileSharesState")]
    public V1api20210401StorageAccountSpecLargeFileSharesStateEnum? LargeFileSharesState { get; set; }

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
    public V1api20210401StorageAccountSpecMinimumTlsVersionEnum? MinimumTlsVersion { get; set; }

    /// <summary>NetworkAcls: Network rule set</summary>
    [JsonPropertyName("networkAcls")]
    public V1api20210401StorageAccountSpecNetworkAcls? NetworkAcls { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210401StorageAccountSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20210401StorageAccountSpecOwner Owner { get; set; }

    /// <summary>RoutingPreference: Maintains information about the network routing choice opted by the user for data transfer</summary>
    [JsonPropertyName("routingPreference")]
    public V1api20210401StorageAccountSpecRoutingPreference? RoutingPreference { get; set; }

    /// <summary>SasPolicy: SasPolicy assigned to the storage account.</summary>
    [JsonPropertyName("sasPolicy")]
    public V1api20210401StorageAccountSpecSasPolicy? SasPolicy { get; set; }

    /// <summary>Sku: Required. Gets or sets the SKU name.</summary>
    [JsonPropertyName("sku")]
    public required V1api20210401StorageAccountSpecSku Sku { get; set; }

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
}

/// <summary>ActiveDirectoryProperties: Required if choose AD.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusAzureFilesIdentityBasedAuthenticationActiveDirectoryProperties
{
    /// <summary>AzureStorageSid: Specifies the security identifier (SID) for Azure Storage.</summary>
    [JsonPropertyName("azureStorageSid")]
    public string? AzureStorageSid { get; set; }

    /// <summary>DomainGuid: Specifies the domain GUID.</summary>
    [JsonPropertyName("domainGuid")]
    public string? DomainGuid { get; set; }

    /// <summary>DomainName: Specifies the primary domain that the AD DNS server is authoritative for.</summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>DomainSid: Specifies the security identifier (SID).</summary>
    [JsonPropertyName("domainSid")]
    public string? DomainSid { get; set; }

    /// <summary>ForestName: Specifies the Active Directory forest to get.</summary>
    [JsonPropertyName("forestName")]
    public string? ForestName { get; set; }

    /// <summary>NetBiosDomainName: Specifies the NetBIOS domain name.</summary>
    [JsonPropertyName("netBiosDomainName")]
    public string? NetBiosDomainName { get; set; }
}

/// <summary>AzureFilesIdentityBasedAuthentication: Provides the identity based authentication settings for Azure Files.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusAzureFilesIdentityBasedAuthentication
{
    /// <summary>ActiveDirectoryProperties: Required if choose AD.</summary>
    [JsonPropertyName("activeDirectoryProperties")]
    public V1api20210401StorageAccountStatusAzureFilesIdentityBasedAuthenticationActiveDirectoryProperties? ActiveDirectoryProperties { get; set; }

    /// <summary>DefaultSharePermission: Default share permission for users using Kerberos authentication if RBAC role is not assigned.</summary>
    [JsonPropertyName("defaultSharePermission")]
    public string? DefaultSharePermission { get; set; }

    /// <summary>DirectoryServiceOptions: Indicates the directory service used.</summary>
    [JsonPropertyName("directoryServiceOptions")]
    public string? DirectoryServiceOptions { get; set; }
}

/// <summary>Blob range</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusBlobRestoreStatusParametersBlobRanges
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
public partial class V1api20210401StorageAccountStatusBlobRestoreStatusParameters
{
    /// <summary>BlobRanges: Blob ranges to restore.</summary>
    [JsonPropertyName("blobRanges")]
    public IList<V1api20210401StorageAccountStatusBlobRestoreStatusParametersBlobRanges>? BlobRanges { get; set; }

    /// <summary>TimeToRestore: Restore blob to the specified time.</summary>
    [JsonPropertyName("timeToRestore")]
    public string? TimeToRestore { get; set; }
}

/// <summary>BlobRestoreStatus: Blob restore status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusBlobRestoreStatus
{
    /// <summary>FailureReason: Failure reason when blob restore is failed.</summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>Parameters: Blob restore request parameters.</summary>
    [JsonPropertyName("parameters")]
    public V1api20210401StorageAccountStatusBlobRestoreStatusParameters? Parameters { get; set; }

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
public partial class V1api20210401StorageAccountStatusConditions
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
public partial class V1api20210401StorageAccountStatusCustomDomain
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

/// <summary>Identity: The identity to be used with service-side encryption at rest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusEncryptionIdentity
{
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
public partial class V1api20210401StorageAccountStatusEncryptionKeyvaultproperties
{
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
public partial class V1api20210401StorageAccountStatusEncryptionServicesBlob
{
    /// <summary>Enabled: A boolean indicating whether or not the service encrypts the data as it is stored.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
    /// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// LastEnabledTime: Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned
    /// when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a
    /// rough estimate.
    /// </summary>
    [JsonPropertyName("lastEnabledTime")]
    public string? LastEnabledTime { get; set; }
}

/// <summary>File: The encryption function of the file storage service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusEncryptionServicesFile
{
    /// <summary>Enabled: A boolean indicating whether or not the service encrypts the data as it is stored.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
    /// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// LastEnabledTime: Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned
    /// when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a
    /// rough estimate.
    /// </summary>
    [JsonPropertyName("lastEnabledTime")]
    public string? LastEnabledTime { get; set; }
}

/// <summary>Queue: The encryption function of the queue storage service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusEncryptionServicesQueue
{
    /// <summary>Enabled: A boolean indicating whether or not the service encrypts the data as it is stored.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
    /// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// LastEnabledTime: Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned
    /// when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a
    /// rough estimate.
    /// </summary>
    [JsonPropertyName("lastEnabledTime")]
    public string? LastEnabledTime { get; set; }
}

/// <summary>Table: The encryption function of the table storage service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusEncryptionServicesTable
{
    /// <summary>Enabled: A boolean indicating whether or not the service encrypts the data as it is stored.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// KeyType: Encryption key type to be used for the encryption service. &apos;Account&apos; key type implies that an account-scoped
    /// encryption key will be used. &apos;Service&apos; key type implies that a default service key is used.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// LastEnabledTime: Gets a rough estimate of the date/time when the encryption was last enabled by the user. Only returned
    /// when encryption is enabled. There might be some unencrypted blobs which were written after this time, as it is just a
    /// rough estimate.
    /// </summary>
    [JsonPropertyName("lastEnabledTime")]
    public string? LastEnabledTime { get; set; }
}

/// <summary>Services: List of services which support encryption.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusEncryptionServices
{
    /// <summary>Blob: The encryption function of the blob storage service.</summary>
    [JsonPropertyName("blob")]
    public V1api20210401StorageAccountStatusEncryptionServicesBlob? Blob { get; set; }

    /// <summary>File: The encryption function of the file storage service.</summary>
    [JsonPropertyName("file")]
    public V1api20210401StorageAccountStatusEncryptionServicesFile? File { get; set; }

    /// <summary>Queue: The encryption function of the queue storage service.</summary>
    [JsonPropertyName("queue")]
    public V1api20210401StorageAccountStatusEncryptionServicesQueue? Queue { get; set; }

    /// <summary>Table: The encryption function of the table storage service.</summary>
    [JsonPropertyName("table")]
    public V1api20210401StorageAccountStatusEncryptionServicesTable? Table { get; set; }
}

/// <summary>Encryption: Gets the encryption settings on the account. If unspecified, the account is unencrypted.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusEncryption
{
    /// <summary>Identity: The identity to be used with service-side encryption at rest.</summary>
    [JsonPropertyName("identity")]
    public V1api20210401StorageAccountStatusEncryptionIdentity? Identity { get; set; }

    /// <summary>
    /// KeySource: The encryption keySource (provider). Possible values (case-insensitive):  Microsoft.Storage,
    /// Microsoft.Keyvault
    /// </summary>
    [JsonPropertyName("keySource")]
    public string? KeySource { get; set; }

    /// <summary>Keyvaultproperties: Properties provided by key vault.</summary>
    [JsonPropertyName("keyvaultproperties")]
    public V1api20210401StorageAccountStatusEncryptionKeyvaultproperties? Keyvaultproperties { get; set; }

    /// <summary>
    /// RequireInfrastructureEncryption: A boolean indicating whether or not the service applies a secondary layer of encryption
    /// with platform managed keys for data at rest.
    /// </summary>
    [JsonPropertyName("requireInfrastructureEncryption")]
    public bool? RequireInfrastructureEncryption { get; set; }

    /// <summary>Services: List of services which support encryption.</summary>
    [JsonPropertyName("services")]
    public V1api20210401StorageAccountStatusEncryptionServices? Services { get; set; }
}

/// <summary>ExtendedLocation: The extendedLocation of the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>GeoReplicationStats: Geo Replication Stats</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusGeoReplicationStats
{
    /// <summary>CanFailover: A boolean flag which indicates whether or not account failover is supported for the account.</summary>
    [JsonPropertyName("canFailover")]
    public bool? CanFailover { get; set; }

    /// <summary>
    /// LastSyncTime: All primary writes preceding this UTC date/time value are guaranteed to be available for read operations.
    /// Primary writes following this point in time may or may not be available for reads. Element may be default value if value
    /// of LastSyncTime is not available, this can happen if secondary is offline or we are in bootstrap.
    /// </summary>
    [JsonPropertyName("lastSyncTime")]
    public string? LastSyncTime { get; set; }

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
public partial class V1api20210401StorageAccountStatusIdentityUserAssignedIdentities
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
public partial class V1api20210401StorageAccountStatusIdentity
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
    public IDictionary<string, V1api20210401StorageAccountStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>KeyCreationTime: Storage account keys creation time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusKeyCreationTime
{
    [JsonPropertyName("key1")]
    public string? Key1 { get; set; }

    [JsonPropertyName("key2")]
    public string? Key2 { get; set; }
}

/// <summary>KeyPolicy: KeyPolicy assigned to the storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusKeyPolicy
{
    /// <summary>KeyExpirationPeriodInDays: The key expiration period in days.</summary>
    [JsonPropertyName("keyExpirationPeriodInDays")]
    public int? KeyExpirationPeriodInDays { get; set; }
}

/// <summary>IP rule with specific IP or IP range in CIDR format.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusNetworkAclsIpRules
{
    /// <summary>Action: The action of IP ACL rule.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Value: Specifies the IP or IP range in CIDR format. Only IPV4 address is allowed.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Resource Access Rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusNetworkAclsResourceAccessRules
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
public partial class V1api20210401StorageAccountStatusNetworkAclsVirtualNetworkRules
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
public partial class V1api20210401StorageAccountStatusNetworkAcls
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
    public IList<V1api20210401StorageAccountStatusNetworkAclsIpRules>? IpRules { get; set; }

    /// <summary>ResourceAccessRules: Sets the resource access rules</summary>
    [JsonPropertyName("resourceAccessRules")]
    public IList<V1api20210401StorageAccountStatusNetworkAclsResourceAccessRules>? ResourceAccessRules { get; set; }

    /// <summary>VirtualNetworkRules: Sets the virtual network rules</summary>
    [JsonPropertyName("virtualNetworkRules")]
    public IList<V1api20210401StorageAccountStatusNetworkAclsVirtualNetworkRules>? VirtualNetworkRules { get; set; }
}

/// <summary>InternetEndpoints: Gets the internet routing storage endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusPrimaryEndpointsInternetEndpoints
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
public partial class V1api20210401StorageAccountStatusPrimaryEndpointsMicrosoftEndpoints
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
public partial class V1api20210401StorageAccountStatusPrimaryEndpoints
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
    public V1api20210401StorageAccountStatusPrimaryEndpointsInternetEndpoints? InternetEndpoints { get; set; }

    /// <summary>MicrosoftEndpoints: Gets the microsoft routing storage endpoints.</summary>
    [JsonPropertyName("microsoftEndpoints")]
    public V1api20210401StorageAccountStatusPrimaryEndpointsMicrosoftEndpoints? MicrosoftEndpoints { get; set; }

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
public partial class V1api20210401StorageAccountStatusPrivateEndpointConnections
{
    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>RoutingPreference: Maintains information about the network routing choice opted by the user for data transfer</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusRoutingPreference
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
public partial class V1api20210401StorageAccountStatusSasPolicy
{
    /// <summary>ExpirationAction: The SAS expiration action. Can only be Log.</summary>
    [JsonPropertyName("expirationAction")]
    public string? ExpirationAction { get; set; }

    /// <summary>SasExpirationPeriod: The SAS expiration period, DD.HH:MM:SS.</summary>
    [JsonPropertyName("sasExpirationPeriod")]
    public string? SasExpirationPeriod { get; set; }
}

/// <summary>InternetEndpoints: Gets the internet routing storage endpoints</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatusSecondaryEndpointsInternetEndpoints
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
public partial class V1api20210401StorageAccountStatusSecondaryEndpointsMicrosoftEndpoints
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
public partial class V1api20210401StorageAccountStatusSecondaryEndpoints
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
    public V1api20210401StorageAccountStatusSecondaryEndpointsInternetEndpoints? InternetEndpoints { get; set; }

    /// <summary>MicrosoftEndpoints: Gets the microsoft routing storage endpoints.</summary>
    [JsonPropertyName("microsoftEndpoints")]
    public V1api20210401StorageAccountStatusSecondaryEndpointsMicrosoftEndpoints? MicrosoftEndpoints { get; set; }

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
public partial class V1api20210401StorageAccountStatusSku
{
    /// <summary>
    /// Name: The SKU name. Required for account creation; optional for update. Note that in older versions, SKU name was called
    ///  accountType.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: The SKU tier. This is based on the SKU name.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>The storage account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210401StorageAccountStatus
{
    /// <summary>AccessTier: Required for storage accounts where kind = BlobStorage. The access tier used for billing.</summary>
    [JsonPropertyName("accessTier")]
    public string? AccessTier { get; set; }

    /// <summary>
    /// AllowBlobPublicAccess: Allow or disallow public access to all blobs or containers in the storage account. The default
    /// interpretation is true for this property.
    /// </summary>
    [JsonPropertyName("allowBlobPublicAccess")]
    public bool? AllowBlobPublicAccess { get; set; }

    /// <summary>
    /// AllowCrossTenantReplication: Allow or disallow cross AAD tenant object replication. The default interpretation is true
    /// for this property.
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

    /// <summary>AzureFilesIdentityBasedAuthentication: Provides the identity based authentication settings for Azure Files.</summary>
    [JsonPropertyName("azureFilesIdentityBasedAuthentication")]
    public V1api20210401StorageAccountStatusAzureFilesIdentityBasedAuthentication? AzureFilesIdentityBasedAuthentication { get; set; }

    /// <summary>BlobRestoreStatus: Blob restore status</summary>
    [JsonPropertyName("blobRestoreStatus")]
    public V1api20210401StorageAccountStatusBlobRestoreStatus? BlobRestoreStatus { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20210401StorageAccountStatusConditions>? Conditions { get; set; }

    /// <summary>CreationTime: Gets the creation date and time of the storage account in UTC.</summary>
    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    /// <summary>CustomDomain: Gets the custom domain the user assigned to this storage account.</summary>
    [JsonPropertyName("customDomain")]
    public V1api20210401StorageAccountStatusCustomDomain? CustomDomain { get; set; }

    /// <summary>Encryption: Gets the encryption settings on the account. If unspecified, the account is unencrypted.</summary>
    [JsonPropertyName("encryption")]
    public V1api20210401StorageAccountStatusEncryption? Encryption { get; set; }

    /// <summary>ExtendedLocation: The extendedLocation of the resource.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20210401StorageAccountStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>FailoverInProgress: If the failover is in progress, the value will be true, otherwise, it will be null.</summary>
    [JsonPropertyName("failoverInProgress")]
    public bool? FailoverInProgress { get; set; }

    /// <summary>GeoReplicationStats: Geo Replication Stats</summary>
    [JsonPropertyName("geoReplicationStats")]
    public V1api20210401StorageAccountStatusGeoReplicationStats? GeoReplicationStats { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Identity: The identity of the resource.</summary>
    [JsonPropertyName("identity")]
    public V1api20210401StorageAccountStatusIdentity? Identity { get; set; }

    /// <summary>IsHnsEnabled: Account HierarchicalNamespace enabled if sets to true.</summary>
    [JsonPropertyName("isHnsEnabled")]
    public bool? IsHnsEnabled { get; set; }

    /// <summary>IsNfsV3Enabled: NFS 3.0 protocol support enabled if set to true.</summary>
    [JsonPropertyName("isNfsV3Enabled")]
    public bool? IsNfsV3Enabled { get; set; }

    /// <summary>KeyCreationTime: Storage account keys creation time.</summary>
    [JsonPropertyName("keyCreationTime")]
    public V1api20210401StorageAccountStatusKeyCreationTime? KeyCreationTime { get; set; }

    /// <summary>KeyPolicy: KeyPolicy assigned to the storage account.</summary>
    [JsonPropertyName("keyPolicy")]
    public V1api20210401StorageAccountStatusKeyPolicy? KeyPolicy { get; set; }

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
    public V1api20210401StorageAccountStatusNetworkAcls? NetworkAcls { get; set; }

    /// <summary>
    /// PrimaryEndpoints: Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object. Note that
    /// Standard_ZRS and Premium_LRS accounts only return the blob endpoint.
    /// </summary>
    [JsonPropertyName("primaryEndpoints")]
    public V1api20210401StorageAccountStatusPrimaryEndpoints? PrimaryEndpoints { get; set; }

    /// <summary>PrimaryLocation: Gets the location of the primary data center for the storage account.</summary>
    [JsonPropertyName("primaryLocation")]
    public string? PrimaryLocation { get; set; }

    /// <summary>PrivateEndpointConnections: List of private endpoint connection associated with the specified storage account</summary>
    [JsonPropertyName("privateEndpointConnections")]
    public IList<V1api20210401StorageAccountStatusPrivateEndpointConnections>? PrivateEndpointConnections { get; set; }

    /// <summary>ProvisioningState: Gets the status of the storage account at the time the operation was called.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>RoutingPreference: Maintains information about the network routing choice opted by the user for data transfer</summary>
    [JsonPropertyName("routingPreference")]
    public V1api20210401StorageAccountStatusRoutingPreference? RoutingPreference { get; set; }

    /// <summary>SasPolicy: SasPolicy assigned to the storage account.</summary>
    [JsonPropertyName("sasPolicy")]
    public V1api20210401StorageAccountStatusSasPolicy? SasPolicy { get; set; }

    /// <summary>
    /// SecondaryEndpoints: Gets the URLs that are used to perform a retrieval of a public blob, queue, or table object from the
    /// secondary location of the storage account. Only available if the SKU name is Standard_RAGRS.
    /// </summary>
    [JsonPropertyName("secondaryEndpoints")]
    public V1api20210401StorageAccountStatusSecondaryEndpoints? SecondaryEndpoints { get; set; }

    /// <summary>
    /// SecondaryLocation: Gets the location of the geo-replicated secondary for the storage account. Only available if the
    /// accountType is Standard_GRS or Standard_RAGRS.
    /// </summary>
    [JsonPropertyName("secondaryLocation")]
    public string? SecondaryLocation { get; set; }

    /// <summary>Sku: Gets the SKU.</summary>
    [JsonPropertyName("sku")]
    public V1api20210401StorageAccountStatusSku? Sku { get; set; }

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

    /// <summary>SupportsHttpsTrafficOnly: Allows https traffic only to storage service if sets to true.</summary>
    [JsonPropertyName("supportsHttpsTrafficOnly")]
    public bool? SupportsHttpsTrafficOnly { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /storage/resource-manager/Microsoft.Storage/stable/2021-04-01/storage.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/storageAccounts/{accountName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210401StorageAccount : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210401StorageAccountSpec?>, IStatus<V1api20210401StorageAccountStatus?>
{
    public const string KubeApiVersion = "v1api20210401";
    public const string KubeKind = "StorageAccount";
    public const string KubeGroup = "storage.azure.com";
    public const string KubePluralName = "storageaccounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "storage.azure.com/v1api20210401";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "StorageAccount";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20210401StorageAccountSpec? Spec { get; set; }

    /// <summary>The storage account.</summary>
    [JsonPropertyName("status")]
    public V1api20210401StorageAccountStatus? Status { get; set; }
}