#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/DiskRP/stable/2020-09-30/disk.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20200930DiskList : IKubernetesObject<V1ListMeta>, IItems<V1api20200930Disk>
{
    public const string KubeApiVersion = "v1api20200930";
    public const string KubeKind = "DiskList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "disks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20200930";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DiskList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20200930Disk objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20200930Disk> Items { get; set; }
}

/// <summary>CreateOption: This enumerates the possible sources of a disk&apos;s creation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200930DiskSpecCreationDataCreateOptionEnum>))]
public enum V1api20200930DiskSpecCreationDataCreateOptionEnum
{
    [EnumMember(Value = "Attach"), JsonStringEnumMemberName("Attach")]
    Attach,
    [EnumMember(Value = "Copy"), JsonStringEnumMemberName("Copy")]
    Copy,
    [EnumMember(Value = "Empty"), JsonStringEnumMemberName("Empty")]
    Empty,
    [EnumMember(Value = "FromImage"), JsonStringEnumMemberName("FromImage")]
    FromImage,
    [EnumMember(Value = "Import"), JsonStringEnumMemberName("Import")]
    Import,
    [EnumMember(Value = "Restore"), JsonStringEnumMemberName("Restore")]
    Restore,
    [EnumMember(Value = "Upload"), JsonStringEnumMemberName("Upload")]
    Upload
}

/// <summary>Reference: A relative uri containing either a Platform Image Repository or user image reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecCreationDataGalleryImageReferenceReference
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
/// GalleryImageReference: Required if creating from a Gallery Image. The id of the ImageDiskReference will be the ARM id of
/// the shared galley image version from which to create a disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecCreationDataGalleryImageReference
{
    /// <summary>
    /// Lun: If the disk is created from an image&apos;s data disk, this is an index that indicates which of the data disks in the
    /// image to use. For OS disks, this field is null.
    /// </summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>Reference: A relative uri containing either a Platform Image Repository or user image reference.</summary>
    [JsonPropertyName("reference")]
    public required V1api20200930DiskSpecCreationDataGalleryImageReferenceReference Reference { get; set; }
}

/// <summary>Reference: A relative uri containing either a Platform Image Repository or user image reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecCreationDataImageReferenceReference
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

/// <summary>ImageReference: Disk source information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecCreationDataImageReference
{
    /// <summary>
    /// Lun: If the disk is created from an image&apos;s data disk, this is an index that indicates which of the data disks in the
    /// image to use. For OS disks, this field is null.
    /// </summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>Reference: A relative uri containing either a Platform Image Repository or user image reference.</summary>
    [JsonPropertyName("reference")]
    public required V1api20200930DiskSpecCreationDataImageReferenceReference Reference { get; set; }
}

/// <summary>SourceResourceReference: If createOption is Copy, this is the ARM id of the source snapshot or disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecCreationDataSourceResourceReference
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

/// <summary>CreationData: Disk source information. CreationData information cannot be changed after the disk has been created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecCreationData
{
    /// <summary>CreateOption: This enumerates the possible sources of a disk&apos;s creation.</summary>
    [JsonPropertyName("createOption")]
    public required V1api20200930DiskSpecCreationDataCreateOptionEnum CreateOption { get; set; }

    /// <summary>
    /// GalleryImageReference: Required if creating from a Gallery Image. The id of the ImageDiskReference will be the ARM id of
    /// the shared galley image version from which to create a disk.
    /// </summary>
    [JsonPropertyName("galleryImageReference")]
    public V1api20200930DiskSpecCreationDataGalleryImageReference? GalleryImageReference { get; set; }

    /// <summary>ImageReference: Disk source information.</summary>
    [JsonPropertyName("imageReference")]
    public V1api20200930DiskSpecCreationDataImageReference? ImageReference { get; set; }

    /// <summary>LogicalSectorSize: Logical sector size in bytes for Ultra disks. Supported values are 512 ad 4096. 4096 is the default.</summary>
    [JsonPropertyName("logicalSectorSize")]
    public int? LogicalSectorSize { get; set; }

    /// <summary>SourceResourceReference: If createOption is Copy, this is the ARM id of the source snapshot or disk.</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V1api20200930DiskSpecCreationDataSourceResourceReference? SourceResourceReference { get; set; }

    /// <summary>SourceUri: If createOption is Import, this is the URI of a blob to be imported into a managed disk.</summary>
    [JsonPropertyName("sourceUri")]
    public string? SourceUri { get; set; }

    /// <summary>
    /// StorageAccountId: Required if createOption is Import. The Azure Resource Manager identifier of the storage account
    /// containing the blob to import as a disk.
    /// </summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>
    /// UploadSizeBytes: If createOption is Upload, this is the size of the contents of the upload including the VHD footer.
    /// This value should be between 20972032 (20 MiB + 512 bytes for the VHD footer) and 35183298347520 bytes (32 TiB + 512
    /// bytes for the VHD footer).
    /// </summary>
    [JsonPropertyName("uploadSizeBytes")]
    public int? UploadSizeBytes { get; set; }
}

/// <summary>DiskAccessReference: ARM id of the DiskAccess resource for using private endpoints on disks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecDiskAccessReference
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

/// <summary>DiskEncryptionSetReference: ResourceId of the disk encryption set to use for enabling encryption at rest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecEncryptionDiskEncryptionSetReference
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

/// <summary>Type: The type of key used to encrypt the data of the disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200930DiskSpecEncryptionTypeEnum>))]
public enum V1api20200930DiskSpecEncryptionTypeEnum
{
    [EnumMember(Value = "EncryptionAtRestWithCustomerKey"), JsonStringEnumMemberName("EncryptionAtRestWithCustomerKey")]
    EncryptionAtRestWithCustomerKey,
    [EnumMember(Value = "EncryptionAtRestWithPlatformAndCustomerKeys"), JsonStringEnumMemberName("EncryptionAtRestWithPlatformAndCustomerKeys")]
    EncryptionAtRestWithPlatformAndCustomerKeys,
    [EnumMember(Value = "EncryptionAtRestWithPlatformKey"), JsonStringEnumMemberName("EncryptionAtRestWithPlatformKey")]
    EncryptionAtRestWithPlatformKey
}

/// <summary>Encryption: Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecEncryption
{
    /// <summary>DiskEncryptionSetReference: ResourceId of the disk encryption set to use for enabling encryption at rest.</summary>
    [JsonPropertyName("diskEncryptionSetReference")]
    public V1api20200930DiskSpecEncryptionDiskEncryptionSetReference? DiskEncryptionSetReference { get; set; }

    /// <summary>Type: The type of key used to encrypt the data of the disk.</summary>
    [JsonPropertyName("type")]
    public V1api20200930DiskSpecEncryptionTypeEnum? Type { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVaultReference
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

/// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20200930DiskSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVaultReference? Reference { get; set; }
}

/// <summary>DiskEncryptionKey: Key Vault Secret Url and vault id of the disk encryption key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey
{
    /// <summary>SecretUrl: Url pointing to a key or secret in KeyVault</summary>
    [JsonPropertyName("secretUrl")]
    public required string SecretUrl { get; set; }

    /// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
    [JsonPropertyName("sourceVault")]
    public required V1api20200930DiskSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault SourceVault { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVaultReference
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

/// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20200930DiskSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVaultReference? Reference { get; set; }
}

/// <summary>
/// KeyEncryptionKey: Key Vault Key Url and vault id of the key encryption key. KeyEncryptionKey is optional and when
/// provided is used to unwrap the disk encryption key.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey
{
    /// <summary>KeyUrl: Url pointing to a key or secret in KeyVault</summary>
    [JsonPropertyName("keyUrl")]
    public required string KeyUrl { get; set; }

    /// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
    [JsonPropertyName("sourceVault")]
    public required V1api20200930DiskSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault SourceVault { get; set; }
}

/// <summary>Encryption settings for one disk volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecEncryptionSettingsCollectionEncryptionSettings
{
    /// <summary>DiskEncryptionKey: Key Vault Secret Url and vault id of the disk encryption key</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20200930DiskSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>
    /// KeyEncryptionKey: Key Vault Key Url and vault id of the key encryption key. KeyEncryptionKey is optional and when
    /// provided is used to unwrap the disk encryption key.
    /// </summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20200930DiskSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>
/// EncryptionSettingsCollection: Encryption settings collection used for Azure Disk Encryption, can contain multiple
/// encryption settings per disk or snapshot.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecEncryptionSettingsCollection
{
    /// <summary>
    /// Enabled: Set this flag to true and provide DiskEncryptionKey and optional KeyEncryptionKey to enable encryption. Set
    /// this flag to false and remove DiskEncryptionKey and KeyEncryptionKey to disable encryption. If EncryptionSettings is
    /// null in the request object, the existing settings remain unchanged.
    /// </summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }

    /// <summary>EncryptionSettings: A collection of encryption settings, one for each disk volume.</summary>
    [JsonPropertyName("encryptionSettings")]
    public IList<V1api20200930DiskSpecEncryptionSettingsCollectionEncryptionSettings>? EncryptionSettings { get; set; }

    /// <summary>
    /// EncryptionSettingsVersion: Describes what type of encryption is used for the disks. Once this field is set, it cannot be
    /// overwritten. &apos;1.0&apos; corresponds to Azure Disk Encryption with AAD app.&apos;1.1&apos; corresponds to Azure Disk Encryption.
    /// </summary>
    [JsonPropertyName("encryptionSettingsVersion")]
    public string? EncryptionSettingsVersion { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200930DiskSpecExtendedLocationTypeEnum>))]
public enum V1api20200930DiskSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location where the disk will be created. Extended location cannot be changed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V1api20200930DiskSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>HyperVGeneration: The hypervisor generation of the Virtual Machine. Applicable to OS disks only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200930DiskSpecHyperVGenerationEnum>))]
public enum V1api20200930DiskSpecHyperVGenerationEnum
{
    [EnumMember(Value = "V1"), JsonStringEnumMemberName("V1")]
    V1,
    [EnumMember(Value = "V2"), JsonStringEnumMemberName("V2")]
    V2
}

/// <summary>NetworkAccessPolicy: Policy for accessing the disk via network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200930DiskSpecNetworkAccessPolicyEnum>))]
public enum V1api20200930DiskSpecNetworkAccessPolicyEnum
{
    [EnumMember(Value = "AllowAll"), JsonStringEnumMemberName("AllowAll")]
    AllowAll,
    [EnumMember(Value = "AllowPrivate"), JsonStringEnumMemberName("AllowPrivate")]
    AllowPrivate,
    [EnumMember(Value = "DenyAll"), JsonStringEnumMemberName("DenyAll")]
    DenyAll
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20200930DiskSpecOperatorSpecSecretExpressions
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
public partial class V1api20200930DiskSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20200930DiskSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20200930DiskSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>OsType: The Operating System type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200930DiskSpecOsTypeEnum>))]
public enum V1api20200930DiskSpecOsTypeEnum
{
    [EnumMember(Value = "Linux"), JsonStringEnumMemberName("Linux")]
    Linux,
    [EnumMember(Value = "Windows"), JsonStringEnumMemberName("Windows")]
    Windows
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// PurchasePlan: Purchase plan information for the the image from which the OS disk was created. E.g. - {name:
/// 2019-Datacenter, publisher: MicrosoftWindowsServer, product: WindowsServer}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecPurchasePlan
{
    /// <summary>Name: The plan ID.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Product: Specifies the product of the image from the marketplace. This is the same value as Offer under the
    /// imageReference element.
    /// </summary>
    [JsonPropertyName("product")]
    public required string Product { get; set; }

    /// <summary>PromotionCode: The Offer Promotion Code.</summary>
    [JsonPropertyName("promotionCode")]
    public string? PromotionCode { get; set; }

    /// <summary>Publisher: The publisher ID.</summary>
    [JsonPropertyName("publisher")]
    public required string Publisher { get; set; }
}

/// <summary>Name: The sku name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20200930DiskSpecSkuNameEnum>))]
public enum V1api20200930DiskSpecSkuNameEnum
{
    [EnumMember(Value = "Premium_LRS"), JsonStringEnumMemberName("Premium_LRS")]
    PremiumLRS,
    [EnumMember(Value = "StandardSSD_LRS"), JsonStringEnumMemberName("StandardSSD_LRS")]
    StandardSSDLRS,
    [EnumMember(Value = "Standard_LRS"), JsonStringEnumMemberName("Standard_LRS")]
    StandardLRS,
    [EnumMember(Value = "UltraSSD_LRS"), JsonStringEnumMemberName("UltraSSD_LRS")]
    UltraSSDLRS
}

/// <summary>Sku: The disks sku name. Can be Standard_LRS, Premium_LRS, StandardSSD_LRS, or UltraSSD_LRS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpecSku
{
    /// <summary>Name: The sku name.</summary>
    [JsonPropertyName("name")]
    public V1api20200930DiskSpecSkuNameEnum? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// BurstingEnabled: Set to true to enable bursting beyond the provisioned performance target of the disk. Bursting is
    /// disabled by default. Does not apply to Ultra disks.
    /// </summary>
    [JsonPropertyName("burstingEnabled")]
    public bool? BurstingEnabled { get; set; }

    /// <summary>CreationData: Disk source information. CreationData information cannot be changed after the disk has been created.</summary>
    [JsonPropertyName("creationData")]
    public required V1api20200930DiskSpecCreationData CreationData { get; set; }

    /// <summary>DiskAccessReference: ARM id of the DiskAccess resource for using private endpoints on disks.</summary>
    [JsonPropertyName("diskAccessReference")]
    public V1api20200930DiskSpecDiskAccessReference? DiskAccessReference { get; set; }

    /// <summary>
    /// DiskIOPSReadOnly: The total number of IOPS that will be allowed across all VMs mounting the shared disk as ReadOnly. One
    /// operation can transfer between 4k and 256k bytes.
    /// </summary>
    [JsonPropertyName("diskIOPSReadOnly")]
    public int? DiskIOPSReadOnly { get; set; }

    /// <summary>
    /// DiskIOPSReadWrite: The number of IOPS allowed for this disk; only settable for UltraSSD disks. One operation can
    /// transfer between 4k and 256k bytes.
    /// </summary>
    [JsonPropertyName("diskIOPSReadWrite")]
    public int? DiskIOPSReadWrite { get; set; }

    /// <summary>
    /// DiskMBpsReadOnly: The total throughput (MBps) that will be allowed across all VMs mounting the shared disk as ReadOnly.
    /// MBps means millions of bytes per second - MB here uses the ISO notation, of powers of 10.
    /// </summary>
    [JsonPropertyName("diskMBpsReadOnly")]
    public int? DiskMBpsReadOnly { get; set; }

    /// <summary>
    /// DiskMBpsReadWrite: The bandwidth allowed for this disk; only settable for UltraSSD disks. MBps means millions of bytes
    /// per second - MB here uses the ISO notation, of powers of 10.
    /// </summary>
    [JsonPropertyName("diskMBpsReadWrite")]
    public int? DiskMBpsReadWrite { get; set; }

    /// <summary>
    /// DiskSizeGB: If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to
    /// create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only
    /// allowed if the disk is not attached to a running VM, and can only increase the disk&apos;s size.
    /// </summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>Encryption: Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys.</summary>
    [JsonPropertyName("encryption")]
    public V1api20200930DiskSpecEncryption? Encryption { get; set; }

    /// <summary>
    /// EncryptionSettingsCollection: Encryption settings collection used for Azure Disk Encryption, can contain multiple
    /// encryption settings per disk or snapshot.
    /// </summary>
    [JsonPropertyName("encryptionSettingsCollection")]
    public V1api20200930DiskSpecEncryptionSettingsCollection? EncryptionSettingsCollection { get; set; }

    /// <summary>ExtendedLocation: The extended location where the disk will be created. Extended location cannot be changed.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20200930DiskSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>HyperVGeneration: The hypervisor generation of the Virtual Machine. Applicable to OS disks only.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public V1api20200930DiskSpecHyperVGenerationEnum? HyperVGeneration { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// MaxShares: The maximum number of VMs that can attach to the disk at the same time. Value greater than one indicates a
    /// disk that can be mounted on multiple VMs at the same time.
    /// </summary>
    [JsonPropertyName("maxShares")]
    public int? MaxShares { get; set; }

    /// <summary>NetworkAccessPolicy: Policy for accessing the disk via network.</summary>
    [JsonPropertyName("networkAccessPolicy")]
    public V1api20200930DiskSpecNetworkAccessPolicyEnum? NetworkAccessPolicy { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20200930DiskSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>OsType: The Operating System type.</summary>
    [JsonPropertyName("osType")]
    public V1api20200930DiskSpecOsTypeEnum? OsType { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20200930DiskSpecOwner Owner { get; set; }

    /// <summary>
    /// PurchasePlan: Purchase plan information for the the image from which the OS disk was created. E.g. - {name:
    /// 2019-Datacenter, publisher: MicrosoftWindowsServer, product: WindowsServer}
    /// </summary>
    [JsonPropertyName("purchasePlan")]
    public V1api20200930DiskSpecPurchasePlan? PurchasePlan { get; set; }

    /// <summary>Sku: The disks sku name. Can be Standard_LRS, Premium_LRS, StandardSSD_LRS, or UltraSSD_LRS.</summary>
    [JsonPropertyName("sku")]
    public V1api20200930DiskSpecSku? Sku { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// Tier: Performance tier of the disk (e.g, P4, S10) as described here:
    /// https://azure.microsoft.com/en-us/pricing/details/managed-disks/. Does not apply to Ultra disks.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>Zones: The Logical zone list for Disk.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskStatusConditions
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
/// GalleryImageReference: Required if creating from a Gallery Image. The id of the ImageDiskReference will be the ARM id of
/// the shared galley image version from which to create a disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskStatusCreationDataGalleryImageReference
{
    /// <summary>Id: A relative uri containing either a Platform Image Repository or user image reference.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Lun: If the disk is created from an image&apos;s data disk, this is an index that indicates which of the data disks in the
    /// image to use. For OS disks, this field is null.
    /// </summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }
}

/// <summary>ImageReference: Disk source information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskStatusCreationDataImageReference
{
    /// <summary>Id: A relative uri containing either a Platform Image Repository or user image reference.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Lun: If the disk is created from an image&apos;s data disk, this is an index that indicates which of the data disks in the
    /// image to use. For OS disks, this field is null.
    /// </summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }
}

/// <summary>CreationData: Disk source information. CreationData information cannot be changed after the disk has been created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskStatusCreationData
{
    /// <summary>CreateOption: This enumerates the possible sources of a disk&apos;s creation.</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>
    /// GalleryImageReference: Required if creating from a Gallery Image. The id of the ImageDiskReference will be the ARM id of
    /// the shared galley image version from which to create a disk.
    /// </summary>
    [JsonPropertyName("galleryImageReference")]
    public V1api20200930DiskStatusCreationDataGalleryImageReference? GalleryImageReference { get; set; }

    /// <summary>ImageReference: Disk source information.</summary>
    [JsonPropertyName("imageReference")]
    public V1api20200930DiskStatusCreationDataImageReference? ImageReference { get; set; }

    /// <summary>LogicalSectorSize: Logical sector size in bytes for Ultra disks. Supported values are 512 ad 4096. 4096 is the default.</summary>
    [JsonPropertyName("logicalSectorSize")]
    public int? LogicalSectorSize { get; set; }

    /// <summary>SourceResourceId: If createOption is Copy, this is the ARM id of the source snapshot or disk.</summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }

    /// <summary>SourceUniqueId: If this field is set, this is the unique id identifying the source of this resource.</summary>
    [JsonPropertyName("sourceUniqueId")]
    public string? SourceUniqueId { get; set; }

    /// <summary>SourceUri: If createOption is Import, this is the URI of a blob to be imported into a managed disk.</summary>
    [JsonPropertyName("sourceUri")]
    public string? SourceUri { get; set; }

    /// <summary>
    /// StorageAccountId: Required if createOption is Import. The Azure Resource Manager identifier of the storage account
    /// containing the blob to import as a disk.
    /// </summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>
    /// UploadSizeBytes: If createOption is Upload, this is the size of the contents of the upload including the VHD footer.
    /// This value should be between 20972032 (20 MiB + 512 bytes for the VHD footer) and 35183298347520 bytes (32 TiB + 512
    /// bytes for the VHD footer).
    /// </summary>
    [JsonPropertyName("uploadSizeBytes")]
    public int? UploadSizeBytes { get; set; }
}

/// <summary>Encryption: Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskStatusEncryption
{
    /// <summary>DiskEncryptionSetId: ResourceId of the disk encryption set to use for enabling encryption at rest.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>Type: The type of key used to encrypt the data of the disk.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>DiskEncryptionKey: Key Vault Secret Url and vault id of the disk encryption key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey
{
    /// <summary>SecretUrl: Url pointing to a key or secret in KeyVault</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20200930DiskStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// KeyEncryptionKey: Key Vault Key Url and vault id of the key encryption key. KeyEncryptionKey is optional and when
/// provided is used to unwrap the disk encryption key.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey
{
    /// <summary>KeyUrl: Url pointing to a key or secret in KeyVault</summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20200930DiskStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>Encryption settings for one disk volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskStatusEncryptionSettingsCollectionEncryptionSettings
{
    /// <summary>DiskEncryptionKey: Key Vault Secret Url and vault id of the disk encryption key</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20200930DiskStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>
    /// KeyEncryptionKey: Key Vault Key Url and vault id of the key encryption key. KeyEncryptionKey is optional and when
    /// provided is used to unwrap the disk encryption key.
    /// </summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20200930DiskStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>
/// EncryptionSettingsCollection: Encryption settings collection used for Azure Disk Encryption, can contain multiple
/// encryption settings per disk or snapshot.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskStatusEncryptionSettingsCollection
{
    /// <summary>
    /// Enabled: Set this flag to true and provide DiskEncryptionKey and optional KeyEncryptionKey to enable encryption. Set
    /// this flag to false and remove DiskEncryptionKey and KeyEncryptionKey to disable encryption. If EncryptionSettings is
    /// null in the request object, the existing settings remain unchanged.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>EncryptionSettings: A collection of encryption settings, one for each disk volume.</summary>
    [JsonPropertyName("encryptionSettings")]
    public IList<V1api20200930DiskStatusEncryptionSettingsCollectionEncryptionSettings>? EncryptionSettings { get; set; }

    /// <summary>
    /// EncryptionSettingsVersion: Describes what type of encryption is used for the disks. Once this field is set, it cannot be
    /// overwritten. &apos;1.0&apos; corresponds to Azure Disk Encryption with AAD app.&apos;1.1&apos; corresponds to Azure Disk Encryption.
    /// </summary>
    [JsonPropertyName("encryptionSettingsVersion")]
    public string? EncryptionSettingsVersion { get; set; }
}

/// <summary>ExtendedLocation: The extended location where the disk will be created. Extended location cannot be changed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// PurchasePlan: Purchase plan information for the the image from which the OS disk was created. E.g. - {name:
/// 2019-Datacenter, publisher: MicrosoftWindowsServer, product: WindowsServer}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskStatusPurchasePlan
{
    /// <summary>Name: The plan ID.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Product: Specifies the product of the image from the marketplace. This is the same value as Offer under the
    /// imageReference element.
    /// </summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>PromotionCode: The Offer Promotion Code.</summary>
    [JsonPropertyName("promotionCode")]
    public string? PromotionCode { get; set; }

    /// <summary>Publisher: The publisher ID.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskStatusShareInfo
{
    /// <summary>VmUri: A relative URI containing the ID of the VM that has the disk attached.</summary>
    [JsonPropertyName("vmUri")]
    public string? VmUri { get; set; }
}

/// <summary>Sku: The disks sku name. Can be Standard_LRS, Premium_LRS, StandardSSD_LRS, or UltraSSD_LRS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskStatusSku
{
    /// <summary>Name: The sku name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: The sku tier.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>Disk resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930DiskStatus
{
    /// <summary>
    /// BurstingEnabled: Set to true to enable bursting beyond the provisioned performance target of the disk. Bursting is
    /// disabled by default. Does not apply to Ultra disks.
    /// </summary>
    [JsonPropertyName("burstingEnabled")]
    public bool? BurstingEnabled { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20200930DiskStatusConditions>? Conditions { get; set; }

    /// <summary>CreationData: Disk source information. CreationData information cannot be changed after the disk has been created.</summary>
    [JsonPropertyName("creationData")]
    public V1api20200930DiskStatusCreationData? CreationData { get; set; }

    /// <summary>DiskAccessId: ARM id of the DiskAccess resource for using private endpoints on disks.</summary>
    [JsonPropertyName("diskAccessId")]
    public string? DiskAccessId { get; set; }

    /// <summary>
    /// DiskIOPSReadOnly: The total number of IOPS that will be allowed across all VMs mounting the shared disk as ReadOnly. One
    /// operation can transfer between 4k and 256k bytes.
    /// </summary>
    [JsonPropertyName("diskIOPSReadOnly")]
    public int? DiskIOPSReadOnly { get; set; }

    /// <summary>
    /// DiskIOPSReadWrite: The number of IOPS allowed for this disk; only settable for UltraSSD disks. One operation can
    /// transfer between 4k and 256k bytes.
    /// </summary>
    [JsonPropertyName("diskIOPSReadWrite")]
    public int? DiskIOPSReadWrite { get; set; }

    /// <summary>
    /// DiskMBpsReadOnly: The total throughput (MBps) that will be allowed across all VMs mounting the shared disk as ReadOnly.
    /// MBps means millions of bytes per second - MB here uses the ISO notation, of powers of 10.
    /// </summary>
    [JsonPropertyName("diskMBpsReadOnly")]
    public int? DiskMBpsReadOnly { get; set; }

    /// <summary>
    /// DiskMBpsReadWrite: The bandwidth allowed for this disk; only settable for UltraSSD disks. MBps means millions of bytes
    /// per second - MB here uses the ISO notation, of powers of 10.
    /// </summary>
    [JsonPropertyName("diskMBpsReadWrite")]
    public int? DiskMBpsReadWrite { get; set; }

    /// <summary>DiskSizeBytes: The size of the disk in bytes. This field is read only.</summary>
    [JsonPropertyName("diskSizeBytes")]
    public int? DiskSizeBytes { get; set; }

    /// <summary>
    /// DiskSizeGB: If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to
    /// create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only
    /// allowed if the disk is not attached to a running VM, and can only increase the disk&apos;s size.
    /// </summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>DiskState: The state of the disk.</summary>
    [JsonPropertyName("diskState")]
    public string? DiskState { get; set; }

    /// <summary>Encryption: Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys.</summary>
    [JsonPropertyName("encryption")]
    public V1api20200930DiskStatusEncryption? Encryption { get; set; }

    /// <summary>
    /// EncryptionSettingsCollection: Encryption settings collection used for Azure Disk Encryption, can contain multiple
    /// encryption settings per disk or snapshot.
    /// </summary>
    [JsonPropertyName("encryptionSettingsCollection")]
    public V1api20200930DiskStatusEncryptionSettingsCollection? EncryptionSettingsCollection { get; set; }

    /// <summary>ExtendedLocation: The extended location where the disk will be created. Extended location cannot be changed.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20200930DiskStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>HyperVGeneration: The hypervisor generation of the Virtual Machine. Applicable to OS disks only.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagedBy: A relative URI containing the ID of the VM that has the disk attached.</summary>
    [JsonPropertyName("managedBy")]
    public string? ManagedBy { get; set; }

    /// <summary>
    /// ManagedByExtended: List of relative URIs containing the IDs of the VMs that have the disk attached. maxShares should be
    /// set to a value greater than one for disks to allow attaching them to multiple VMs.
    /// </summary>
    [JsonPropertyName("managedByExtended")]
    public IList<string>? ManagedByExtended { get; set; }

    /// <summary>
    /// MaxShares: The maximum number of VMs that can attach to the disk at the same time. Value greater than one indicates a
    /// disk that can be mounted on multiple VMs at the same time.
    /// </summary>
    [JsonPropertyName("maxShares")]
    public int? MaxShares { get; set; }

    /// <summary>Name: Resource name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkAccessPolicy: Policy for accessing the disk via network.</summary>
    [JsonPropertyName("networkAccessPolicy")]
    public string? NetworkAccessPolicy { get; set; }

    /// <summary>OsType: The Operating System type.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>ProvisioningState: The disk provisioning state.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// PurchasePlan: Purchase plan information for the the image from which the OS disk was created. E.g. - {name:
    /// 2019-Datacenter, publisher: MicrosoftWindowsServer, product: WindowsServer}
    /// </summary>
    [JsonPropertyName("purchasePlan")]
    public V1api20200930DiskStatusPurchasePlan? PurchasePlan { get; set; }

    /// <summary>
    /// ShareInfo: Details of the list of all VMs that have the disk attached. maxShares should be set to a value greater than
    /// one for disks to allow attaching them to multiple VMs.
    /// </summary>
    [JsonPropertyName("shareInfo")]
    public IList<V1api20200930DiskStatusShareInfo>? ShareInfo { get; set; }

    /// <summary>Sku: The disks sku name. Can be Standard_LRS, Premium_LRS, StandardSSD_LRS, or UltraSSD_LRS.</summary>
    [JsonPropertyName("sku")]
    public V1api20200930DiskStatusSku? Sku { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// Tier: Performance tier of the disk (e.g, P4, S10) as described here:
    /// https://azure.microsoft.com/en-us/pricing/details/managed-disks/. Does not apply to Ultra disks.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>TimeCreated: The time when the disk was created.</summary>
    [JsonPropertyName("timeCreated")]
    public string? TimeCreated { get; set; }

    /// <summary>Type: Resource type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UniqueId: Unique Guid identifying the resource.</summary>
    [JsonPropertyName("uniqueId")]
    public string? UniqueId { get; set; }

    /// <summary>Zones: The Logical zone list for Disk.</summary>
    [JsonPropertyName("zones")]
    public IList<string>? Zones { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/DiskRP/stable/2020-09-30/disk.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20200930Disk : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20200930DiskSpec?>, IStatus<V1api20200930DiskStatus?>
{
    public const string KubeApiVersion = "v1api20200930";
    public const string KubeKind = "Disk";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "disks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20200930";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Disk";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20200930DiskSpec? Spec { get; set; }

    /// <summary>Disk resource.</summary>
    [JsonPropertyName("status")]
    public V1api20200930DiskStatus? Status { get; set; }
}