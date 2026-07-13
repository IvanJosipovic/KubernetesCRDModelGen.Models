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
/// - Generated from: /compute/resource-manager/Microsoft.Compute/DiskRP/stable/2024-03-02/DiskRP.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240302DiskList : IKubernetesObject<V1ListMeta>, IItems<V1api20240302Disk>
{
    public const string KubeApiVersion = "v1api20240302";
    public const string KubeKind = "DiskList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "disks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20240302";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DiskList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20240302Disk objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20240302Disk> Items { get; set; }
}

/// <summary>CreateOption: This enumerates the possible sources of a disk&apos;s creation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240302DiskSpecCreationDataCreateOptionEnum>))]
public enum V1api20240302DiskSpecCreationDataCreateOptionEnum
{
    [EnumMember(Value = "Attach"), JsonStringEnumMemberName("Attach")]
    Attach,
    [EnumMember(Value = "Copy"), JsonStringEnumMemberName("Copy")]
    Copy,
    [EnumMember(Value = "CopyFromSanSnapshot"), JsonStringEnumMemberName("CopyFromSanSnapshot")]
    CopyFromSanSnapshot,
    [EnumMember(Value = "CopyStart"), JsonStringEnumMemberName("CopyStart")]
    CopyStart,
    [EnumMember(Value = "Empty"), JsonStringEnumMemberName("Empty")]
    Empty,
    [EnumMember(Value = "FromImage"), JsonStringEnumMemberName("FromImage")]
    FromImage,
    [EnumMember(Value = "Import"), JsonStringEnumMemberName("Import")]
    Import,
    [EnumMember(Value = "ImportSecure"), JsonStringEnumMemberName("ImportSecure")]
    ImportSecure,
    [EnumMember(Value = "Restore"), JsonStringEnumMemberName("Restore")]
    Restore,
    [EnumMember(Value = "Upload"), JsonStringEnumMemberName("Upload")]
    Upload,
    [EnumMember(Value = "UploadPreparedSecure"), JsonStringEnumMemberName("UploadPreparedSecure")]
    UploadPreparedSecure
}

/// <summary>
/// ElasticSanResourceReference: Required if createOption is CopyFromSanSnapshot. This is the ARM id of the source elastic
/// san volume snapshot.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecCreationDataElasticSanResourceReference
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
/// Reference: A relative uri containing either a Platform Image Repository, user image, or Azure Compute Gallery image
/// reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecCreationDataGalleryImageReferenceReference
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
/// GalleryImageReference: Required if creating from a Gallery Image. The id/sharedGalleryImageId/communityGalleryImageId of
/// the ImageDiskReference will be the ARM id of the shared galley image version from which to create a disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecCreationDataGalleryImageReference
{
    /// <summary>CommunityGalleryImageId: A relative uri containing a community Azure Compute Gallery image reference.</summary>
    [JsonPropertyName("communityGalleryImageId")]
    public string? CommunityGalleryImageId { get; set; }

    /// <summary>
    /// Lun: If the disk is created from an image&apos;s data disk, this is an index that indicates which of the data disks in the
    /// image to use. For OS disks, this field is null.
    /// </summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>
    /// Reference: A relative uri containing either a Platform Image Repository, user image, or Azure Compute Gallery image
    /// reference.
    /// </summary>
    [JsonPropertyName("reference")]
    public V1api20240302DiskSpecCreationDataGalleryImageReferenceReference? Reference { get; set; }

    /// <summary>SharedGalleryImageId: A relative uri containing a direct shared Azure Compute Gallery image reference.</summary>
    [JsonPropertyName("sharedGalleryImageId")]
    public string? SharedGalleryImageId { get; set; }
}

/// <summary>
/// Reference: A relative uri containing either a Platform Image Repository, user image, or Azure Compute Gallery image
/// reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecCreationDataImageReferenceReference
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

/// <summary>ImageReference: Disk source information for PIR or user images.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecCreationDataImageReference
{
    /// <summary>CommunityGalleryImageId: A relative uri containing a community Azure Compute Gallery image reference.</summary>
    [JsonPropertyName("communityGalleryImageId")]
    public string? CommunityGalleryImageId { get; set; }

    /// <summary>
    /// Lun: If the disk is created from an image&apos;s data disk, this is an index that indicates which of the data disks in the
    /// image to use. For OS disks, this field is null.
    /// </summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>
    /// Reference: A relative uri containing either a Platform Image Repository, user image, or Azure Compute Gallery image
    /// reference.
    /// </summary>
    [JsonPropertyName("reference")]
    public V1api20240302DiskSpecCreationDataImageReferenceReference? Reference { get; set; }

    /// <summary>SharedGalleryImageId: A relative uri containing a direct shared Azure Compute Gallery image reference.</summary>
    [JsonPropertyName("sharedGalleryImageId")]
    public string? SharedGalleryImageId { get; set; }
}

/// <summary>
/// ProvisionedBandwidthCopySpeed: If this field is set on a snapshot and createOption is CopyStart, the snapshot will be
/// copied at a quicker speed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240302DiskSpecCreationDataProvisionedBandwidthCopySpeedEnum>))]
public enum V1api20240302DiskSpecCreationDataProvisionedBandwidthCopySpeedEnum
{
    [EnumMember(Value = "Enhanced"), JsonStringEnumMemberName("Enhanced")]
    Enhanced,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>SourceResourceReference: If createOption is Copy, this is the ARM id of the source snapshot or disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecCreationDataSourceResourceReference
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
public partial class V1api20240302DiskSpecCreationData
{
    /// <summary>CreateOption: This enumerates the possible sources of a disk&apos;s creation.</summary>
    [JsonPropertyName("createOption")]
    public required V1api20240302DiskSpecCreationDataCreateOptionEnum CreateOption { get; set; }

    /// <summary>
    /// ElasticSanResourceReference: Required if createOption is CopyFromSanSnapshot. This is the ARM id of the source elastic
    /// san volume snapshot.
    /// </summary>
    [JsonPropertyName("elasticSanResourceReference")]
    public V1api20240302DiskSpecCreationDataElasticSanResourceReference? ElasticSanResourceReference { get; set; }

    /// <summary>
    /// GalleryImageReference: Required if creating from a Gallery Image. The id/sharedGalleryImageId/communityGalleryImageId of
    /// the ImageDiskReference will be the ARM id of the shared galley image version from which to create a disk.
    /// </summary>
    [JsonPropertyName("galleryImageReference")]
    public V1api20240302DiskSpecCreationDataGalleryImageReference? GalleryImageReference { get; set; }

    /// <summary>ImageReference: Disk source information for PIR or user images.</summary>
    [JsonPropertyName("imageReference")]
    public V1api20240302DiskSpecCreationDataImageReference? ImageReference { get; set; }

    /// <summary>LogicalSectorSize: Logical sector size in bytes for Ultra disks. Supported values are 512 ad 4096. 4096 is the default.</summary>
    [JsonPropertyName("logicalSectorSize")]
    public int? LogicalSectorSize { get; set; }

    /// <summary>
    /// PerformancePlus: Set this flag to true to get a boost on the performance target of the disk deployed, see here on the
    /// respective performance target. This flag can only be set on disk creation time and cannot be disabled after enabled.
    /// </summary>
    [JsonPropertyName("performancePlus")]
    public bool? PerformancePlus { get; set; }

    /// <summary>
    /// ProvisionedBandwidthCopySpeed: If this field is set on a snapshot and createOption is CopyStart, the snapshot will be
    /// copied at a quicker speed.
    /// </summary>
    [JsonPropertyName("provisionedBandwidthCopySpeed")]
    public V1api20240302DiskSpecCreationDataProvisionedBandwidthCopySpeedEnum? ProvisionedBandwidthCopySpeed { get; set; }

    /// <summary>SecurityDataUri: If createOption is ImportSecure, this is the URI of a blob to be imported into VM guest state.</summary>
    [JsonPropertyName("securityDataUri")]
    public string? SecurityDataUri { get; set; }

    /// <summary>SourceResourceReference: If createOption is Copy, this is the ARM id of the source snapshot or disk.</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V1api20240302DiskSpecCreationDataSourceResourceReference? SourceResourceReference { get; set; }

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

/// <summary>DataAccessAuthMode: Additional authentication requirements when exporting or uploading to a disk or snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240302DiskSpecDataAccessAuthModeEnum>))]
public enum V1api20240302DiskSpecDataAccessAuthModeEnum
{
    [EnumMember(Value = "AzureActiveDirectory"), JsonStringEnumMemberName("AzureActiveDirectory")]
    AzureActiveDirectory,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>DiskAccessReference: ARM id of the DiskAccess resource for using private endpoints on disks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecDiskAccessReference
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
public partial class V1api20240302DiskSpecEncryptionDiskEncryptionSetReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240302DiskSpecEncryptionTypeEnum>))]
public enum V1api20240302DiskSpecEncryptionTypeEnum
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
public partial class V1api20240302DiskSpecEncryption
{
    /// <summary>DiskEncryptionSetReference: ResourceId of the disk encryption set to use for enabling encryption at rest.</summary>
    [JsonPropertyName("diskEncryptionSetReference")]
    public V1api20240302DiskSpecEncryptionDiskEncryptionSetReference? DiskEncryptionSetReference { get; set; }

    /// <summary>Type: The type of key used to encrypt the data of the disk.</summary>
    [JsonPropertyName("type")]
    public V1api20240302DiskSpecEncryptionTypeEnum? Type { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVaultReference
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
public partial class V1api20240302DiskSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20240302DiskSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVaultReference? Reference { get; set; }
}

/// <summary>DiskEncryptionKey: Key Vault Secret Url and vault id of the disk encryption key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey
{
    /// <summary>SecretUrl: Url pointing to a key or secret in KeyVault</summary>
    [JsonPropertyName("secretUrl")]
    public required string SecretUrl { get; set; }

    /// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
    [JsonPropertyName("sourceVault")]
    public required V1api20240302DiskSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault SourceVault { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVaultReference
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
public partial class V1api20240302DiskSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20240302DiskSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVaultReference? Reference { get; set; }
}

/// <summary>
/// KeyEncryptionKey: Key Vault Key Url and vault id of the key encryption key. KeyEncryptionKey is optional and when
/// provided is used to unwrap the disk encryption key.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey
{
    /// <summary>KeyUrl: Url pointing to a key or secret in KeyVault</summary>
    [JsonPropertyName("keyUrl")]
    public required string KeyUrl { get; set; }

    /// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
    [JsonPropertyName("sourceVault")]
    public required V1api20240302DiskSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault SourceVault { get; set; }
}

/// <summary>Encryption settings for one disk volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecEncryptionSettingsCollectionEncryptionSettings
{
    /// <summary>DiskEncryptionKey: Key Vault Secret Url and vault id of the disk encryption key</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20240302DiskSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>
    /// KeyEncryptionKey: Key Vault Key Url and vault id of the key encryption key. KeyEncryptionKey is optional and when
    /// provided is used to unwrap the disk encryption key.
    /// </summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20240302DiskSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>
/// EncryptionSettingsCollection: Encryption settings collection used for Azure Disk Encryption, can contain multiple
/// encryption settings per disk or snapshot.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecEncryptionSettingsCollection
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
    public IList<V1api20240302DiskSpecEncryptionSettingsCollectionEncryptionSettings>? EncryptionSettings { get; set; }

    /// <summary>
    /// EncryptionSettingsVersion: Describes what type of encryption is used for the disks. Once this field is set, it cannot be
    /// overwritten. &apos;1.0&apos; corresponds to Azure Disk Encryption with AAD app.&apos;1.1&apos; corresponds to Azure Disk Encryption.
    /// </summary>
    [JsonPropertyName("encryptionSettingsVersion")]
    public string? EncryptionSettingsVersion { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240302DiskSpecExtendedLocationTypeEnum>))]
public enum V1api20240302DiskSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location where the disk will be created. Extended location cannot be changed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V1api20240302DiskSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>HyperVGeneration: The hypervisor generation of the Virtual Machine. Applicable to OS disks only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240302DiskSpecHyperVGenerationEnum>))]
public enum V1api20240302DiskSpecHyperVGenerationEnum
{
    [EnumMember(Value = "V1"), JsonStringEnumMemberName("V1")]
    V1,
    [EnumMember(Value = "V2"), JsonStringEnumMemberName("V2")]
    V2
}

/// <summary>NetworkAccessPolicy: Policy for accessing the disk via network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240302DiskSpecNetworkAccessPolicyEnum>))]
public enum V1api20240302DiskSpecNetworkAccessPolicyEnum
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
public partial class V1api20240302DiskSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20240302DiskSpecOperatorSpecSecretExpressions
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
public partial class V1api20240302DiskSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20240302DiskSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20240302DiskSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>OsType: The Operating System type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240302DiskSpecOsTypeEnum>))]
public enum V1api20240302DiskSpecOsTypeEnum
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
public partial class V1api20240302DiskSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PublicNetworkAccess: Policy for controlling export on the disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240302DiskSpecPublicNetworkAccessEnum>))]
public enum V1api20240302DiskSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>
/// PurchasePlan: Purchase plan information for the the image from which the OS disk was created. E.g. - {name:
/// 2019-Datacenter, publisher: MicrosoftWindowsServer, product: WindowsServer}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecPurchasePlan
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

/// <summary>
/// SecureVMDiskEncryptionSetReference: ResourceId of the disk encryption set associated to Confidential VM supported disk
/// encrypted with customer managed key
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecSecurityProfileSecureVMDiskEncryptionSetReference
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

/// <summary>SecurityType: Specifies the SecurityType of the VM. Applicable for OS disks only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240302DiskSpecSecurityProfileSecurityTypeEnum>))]
public enum V1api20240302DiskSpecSecurityProfileSecurityTypeEnum
{
    [EnumMember(Value = "ConfidentialVM_DiskEncryptedWithCustomerKey"), JsonStringEnumMemberName("ConfidentialVM_DiskEncryptedWithCustomerKey")]
    ConfidentialVMDiskEncryptedWithCustomerKey,
    [EnumMember(Value = "ConfidentialVM_DiskEncryptedWithPlatformKey"), JsonStringEnumMemberName("ConfidentialVM_DiskEncryptedWithPlatformKey")]
    ConfidentialVMDiskEncryptedWithPlatformKey,
    [EnumMember(Value = "ConfidentialVM_NonPersistedTPM"), JsonStringEnumMemberName("ConfidentialVM_NonPersistedTPM")]
    ConfidentialVMNonPersistedTPM,
    [EnumMember(Value = "ConfidentialVM_VMGuestStateOnlyEncryptedWithPlatformKey"), JsonStringEnumMemberName("ConfidentialVM_VMGuestStateOnlyEncryptedWithPlatformKey")]
    ConfidentialVMVMGuestStateOnlyEncryptedWithPlatformKey,
    [EnumMember(Value = "TrustedLaunch"), JsonStringEnumMemberName("TrustedLaunch")]
    TrustedLaunch
}

/// <summary>SecurityProfile: Contains the security related information for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecSecurityProfile
{
    /// <summary>
    /// SecureVMDiskEncryptionSetReference: ResourceId of the disk encryption set associated to Confidential VM supported disk
    /// encrypted with customer managed key
    /// </summary>
    [JsonPropertyName("secureVMDiskEncryptionSetReference")]
    public V1api20240302DiskSpecSecurityProfileSecureVMDiskEncryptionSetReference? SecureVMDiskEncryptionSetReference { get; set; }

    /// <summary>SecurityType: Specifies the SecurityType of the VM. Applicable for OS disks only.</summary>
    [JsonPropertyName("securityType")]
    public V1api20240302DiskSpecSecurityProfileSecurityTypeEnum? SecurityType { get; set; }
}

/// <summary>Name: The sku name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240302DiskSpecSkuNameEnum>))]
public enum V1api20240302DiskSpecSkuNameEnum
{
    [EnumMember(Value = "PremiumV2_LRS"), JsonStringEnumMemberName("PremiumV2_LRS")]
    PremiumV2LRS,
    [EnumMember(Value = "Premium_LRS"), JsonStringEnumMemberName("Premium_LRS")]
    PremiumLRS,
    [EnumMember(Value = "Premium_ZRS"), JsonStringEnumMemberName("Premium_ZRS")]
    PremiumZRS,
    [EnumMember(Value = "StandardSSD_LRS"), JsonStringEnumMemberName("StandardSSD_LRS")]
    StandardSSDLRS,
    [EnumMember(Value = "StandardSSD_ZRS"), JsonStringEnumMemberName("StandardSSD_ZRS")]
    StandardSSDZRS,
    [EnumMember(Value = "Standard_LRS"), JsonStringEnumMemberName("Standard_LRS")]
    StandardLRS,
    [EnumMember(Value = "UltraSSD_LRS"), JsonStringEnumMemberName("UltraSSD_LRS")]
    UltraSSDLRS
}

/// <summary>
/// Sku: The disks sku name. Can be Standard_LRS, Premium_LRS, StandardSSD_LRS, UltraSSD_LRS, Premium_ZRS, StandardSSD_ZRS,
/// or PremiumV2_LRS.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecSku
{
    /// <summary>Name: The sku name.</summary>
    [JsonPropertyName("name")]
    public V1api20240302DiskSpecSkuNameEnum? Name { get; set; }
}

/// <summary>Architecture: CPU architecture supported by an OS disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20240302DiskSpecSupportedCapabilitiesArchitectureEnum>))]
public enum V1api20240302DiskSpecSupportedCapabilitiesArchitectureEnum
{
    [EnumMember(Value = "Arm64"), JsonStringEnumMemberName("Arm64")]
    Arm64,
    [EnumMember(Value = "x64"), JsonStringEnumMemberName("x64")]
    X64
}

/// <summary>SupportedCapabilities: List of supported capabilities for the image from which the OS disk was created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpecSupportedCapabilities
{
    /// <summary>AcceleratedNetwork: True if the image from which the OS disk is created supports accelerated networking.</summary>
    [JsonPropertyName("acceleratedNetwork")]
    public bool? AcceleratedNetwork { get; set; }

    /// <summary>Architecture: CPU architecture supported by an OS disk.</summary>
    [JsonPropertyName("architecture")]
    public V1api20240302DiskSpecSupportedCapabilitiesArchitectureEnum? Architecture { get; set; }

    /// <summary>DiskControllerTypes: The disk controllers that an OS disk supports. If set it can be SCSI or SCSI, NVME or NVME, SCSI.</summary>
    [JsonPropertyName("diskControllerTypes")]
    public string? DiskControllerTypes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskSpec
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

    /// <summary>CompletionPercent: Percentage complete for the background copy when a resource is created via the CopyStart operation.</summary>
    [JsonPropertyName("completionPercent")]
    public double? CompletionPercent { get; set; }

    /// <summary>CreationData: Disk source information. CreationData information cannot be changed after the disk has been created.</summary>
    [JsonPropertyName("creationData")]
    public required V1api20240302DiskSpecCreationData CreationData { get; set; }

    /// <summary>DataAccessAuthMode: Additional authentication requirements when exporting or uploading to a disk or snapshot.</summary>
    [JsonPropertyName("dataAccessAuthMode")]
    public V1api20240302DiskSpecDataAccessAuthModeEnum? DataAccessAuthMode { get; set; }

    /// <summary>DiskAccessReference: ARM id of the DiskAccess resource for using private endpoints on disks.</summary>
    [JsonPropertyName("diskAccessReference")]
    public V1api20240302DiskSpecDiskAccessReference? DiskAccessReference { get; set; }

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
    public V1api20240302DiskSpecEncryption? Encryption { get; set; }

    /// <summary>
    /// EncryptionSettingsCollection: Encryption settings collection used for Azure Disk Encryption, can contain multiple
    /// encryption settings per disk or snapshot.
    /// </summary>
    [JsonPropertyName("encryptionSettingsCollection")]
    public V1api20240302DiskSpecEncryptionSettingsCollection? EncryptionSettingsCollection { get; set; }

    /// <summary>ExtendedLocation: The extended location where the disk will be created. Extended location cannot be changed.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20240302DiskSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>HyperVGeneration: The hypervisor generation of the Virtual Machine. Applicable to OS disks only.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public V1api20240302DiskSpecHyperVGenerationEnum? HyperVGeneration { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
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
    public V1api20240302DiskSpecNetworkAccessPolicyEnum? NetworkAccessPolicy { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20240302DiskSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// OptimizedForFrequentAttach: Setting this property to true improves reliability and performance of data disks that are
    /// frequently (more than 5 times a day) by detached from one virtual machine and attached to another. This property should
    /// not be set for disks that are not detached and attached frequently as it causes the disks to not align with the fault
    /// domain of the virtual machine.
    /// </summary>
    [JsonPropertyName("optimizedForFrequentAttach")]
    public bool? OptimizedForFrequentAttach { get; set; }

    /// <summary>OsType: The Operating System type.</summary>
    [JsonPropertyName("osType")]
    public V1api20240302DiskSpecOsTypeEnum? OsType { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20240302DiskSpecOwner Owner { get; set; }

    /// <summary>PublicNetworkAccess: Policy for controlling export on the disk.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V1api20240302DiskSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>
    /// PurchasePlan: Purchase plan information for the the image from which the OS disk was created. E.g. - {name:
    /// 2019-Datacenter, publisher: MicrosoftWindowsServer, product: WindowsServer}
    /// </summary>
    [JsonPropertyName("purchasePlan")]
    public V1api20240302DiskSpecPurchasePlan? PurchasePlan { get; set; }

    /// <summary>SecurityProfile: Contains the security related information for the resource.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20240302DiskSpecSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// Sku: The disks sku name. Can be Standard_LRS, Premium_LRS, StandardSSD_LRS, UltraSSD_LRS, Premium_ZRS, StandardSSD_ZRS,
    /// or PremiumV2_LRS.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20240302DiskSpecSku? Sku { get; set; }

    /// <summary>SupportedCapabilities: List of supported capabilities for the image from which the OS disk was created.</summary>
    [JsonPropertyName("supportedCapabilities")]
    public V1api20240302DiskSpecSupportedCapabilities? SupportedCapabilities { get; set; }

    /// <summary>SupportsHibernation: Indicates the OS on a disk supports hibernation.</summary>
    [JsonPropertyName("supportsHibernation")]
    public bool? SupportsHibernation { get; set; }

    /// <summary>Tags: Resource tags.</summary>
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
public partial class V1api20240302DiskStatusConditions
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
/// GalleryImageReference: Required if creating from a Gallery Image. The id/sharedGalleryImageId/communityGalleryImageId of
/// the ImageDiskReference will be the ARM id of the shared galley image version from which to create a disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskStatusCreationDataGalleryImageReference
{
    /// <summary>CommunityGalleryImageId: A relative uri containing a community Azure Compute Gallery image reference.</summary>
    [JsonPropertyName("communityGalleryImageId")]
    public string? CommunityGalleryImageId { get; set; }

    /// <summary>Id: A relative uri containing either a Platform Image Repository, user image, or Azure Compute Gallery image reference.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Lun: If the disk is created from an image&apos;s data disk, this is an index that indicates which of the data disks in the
    /// image to use. For OS disks, this field is null.
    /// </summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>SharedGalleryImageId: A relative uri containing a direct shared Azure Compute Gallery image reference.</summary>
    [JsonPropertyName("sharedGalleryImageId")]
    public string? SharedGalleryImageId { get; set; }
}

/// <summary>ImageReference: Disk source information for PIR or user images.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskStatusCreationDataImageReference
{
    /// <summary>CommunityGalleryImageId: A relative uri containing a community Azure Compute Gallery image reference.</summary>
    [JsonPropertyName("communityGalleryImageId")]
    public string? CommunityGalleryImageId { get; set; }

    /// <summary>Id: A relative uri containing either a Platform Image Repository, user image, or Azure Compute Gallery image reference.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Lun: If the disk is created from an image&apos;s data disk, this is an index that indicates which of the data disks in the
    /// image to use. For OS disks, this field is null.
    /// </summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>SharedGalleryImageId: A relative uri containing a direct shared Azure Compute Gallery image reference.</summary>
    [JsonPropertyName("sharedGalleryImageId")]
    public string? SharedGalleryImageId { get; set; }
}

/// <summary>CreationData: Disk source information. CreationData information cannot be changed after the disk has been created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskStatusCreationData
{
    /// <summary>CreateOption: This enumerates the possible sources of a disk&apos;s creation.</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>
    /// ElasticSanResourceId: Required if createOption is CopyFromSanSnapshot. This is the ARM id of the source elastic san
    /// volume snapshot.
    /// </summary>
    [JsonPropertyName("elasticSanResourceId")]
    public string? ElasticSanResourceId { get; set; }

    /// <summary>
    /// GalleryImageReference: Required if creating from a Gallery Image. The id/sharedGalleryImageId/communityGalleryImageId of
    /// the ImageDiskReference will be the ARM id of the shared galley image version from which to create a disk.
    /// </summary>
    [JsonPropertyName("galleryImageReference")]
    public V1api20240302DiskStatusCreationDataGalleryImageReference? GalleryImageReference { get; set; }

    /// <summary>ImageReference: Disk source information for PIR or user images.</summary>
    [JsonPropertyName("imageReference")]
    public V1api20240302DiskStatusCreationDataImageReference? ImageReference { get; set; }

    /// <summary>LogicalSectorSize: Logical sector size in bytes for Ultra disks. Supported values are 512 ad 4096. 4096 is the default.</summary>
    [JsonPropertyName("logicalSectorSize")]
    public int? LogicalSectorSize { get; set; }

    /// <summary>
    /// PerformancePlus: Set this flag to true to get a boost on the performance target of the disk deployed, see here on the
    /// respective performance target. This flag can only be set on disk creation time and cannot be disabled after enabled.
    /// </summary>
    [JsonPropertyName("performancePlus")]
    public bool? PerformancePlus { get; set; }

    /// <summary>
    /// ProvisionedBandwidthCopySpeed: If this field is set on a snapshot and createOption is CopyStart, the snapshot will be
    /// copied at a quicker speed.
    /// </summary>
    [JsonPropertyName("provisionedBandwidthCopySpeed")]
    public string? ProvisionedBandwidthCopySpeed { get; set; }

    /// <summary>SecurityDataUri: If createOption is ImportSecure, this is the URI of a blob to be imported into VM guest state.</summary>
    [JsonPropertyName("securityDataUri")]
    public string? SecurityDataUri { get; set; }

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
public partial class V1api20240302DiskStatusEncryption
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
public partial class V1api20240302DiskStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>DiskEncryptionKey: Key Vault Secret Url and vault id of the disk encryption key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey
{
    /// <summary>SecretUrl: Url pointing to a key or secret in KeyVault</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20240302DiskStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault
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
public partial class V1api20240302DiskStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey
{
    /// <summary>KeyUrl: Url pointing to a key or secret in KeyVault</summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
    [JsonPropertyName("sourceVault")]
    public V1api20240302DiskStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>Encryption settings for one disk volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskStatusEncryptionSettingsCollectionEncryptionSettings
{
    /// <summary>DiskEncryptionKey: Key Vault Secret Url and vault id of the disk encryption key</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20240302DiskStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>
    /// KeyEncryptionKey: Key Vault Key Url and vault id of the key encryption key. KeyEncryptionKey is optional and when
    /// provided is used to unwrap the disk encryption key.
    /// </summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20240302DiskStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>
/// EncryptionSettingsCollection: Encryption settings collection used for Azure Disk Encryption, can contain multiple
/// encryption settings per disk or snapshot.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskStatusEncryptionSettingsCollection
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
    public IList<V1api20240302DiskStatusEncryptionSettingsCollectionEncryptionSettings>? EncryptionSettings { get; set; }

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
public partial class V1api20240302DiskStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PropertyUpdatesInProgress: Properties of the disk for which update is pending.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskStatusPropertyUpdatesInProgress
{
    /// <summary>TargetTier: The target performance tier of the disk if a tier change operation is in progress.</summary>
    [JsonPropertyName("targetTier")]
    public string? TargetTier { get; set; }
}

/// <summary>
/// PurchasePlan: Purchase plan information for the the image from which the OS disk was created. E.g. - {name:
/// 2019-Datacenter, publisher: MicrosoftWindowsServer, product: WindowsServer}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskStatusPurchasePlan
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

/// <summary>SecurityProfile: Contains the security related information for the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskStatusSecurityProfile
{
    /// <summary>
    /// SecureVMDiskEncryptionSetId: ResourceId of the disk encryption set associated to Confidential VM supported disk
    /// encrypted with customer managed key
    /// </summary>
    [JsonPropertyName("secureVMDiskEncryptionSetId")]
    public string? SecureVMDiskEncryptionSetId { get; set; }

    /// <summary>SecurityType: Specifies the SecurityType of the VM. Applicable for OS disks only.</summary>
    [JsonPropertyName("securityType")]
    public string? SecurityType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskStatusShareInfo
{
    /// <summary>VmUri: A relative URI containing the ID of the VM that has the disk attached.</summary>
    [JsonPropertyName("vmUri")]
    public string? VmUri { get; set; }
}

/// <summary>
/// Sku: The disks sku name. Can be Standard_LRS, Premium_LRS, StandardSSD_LRS, UltraSSD_LRS, Premium_ZRS, StandardSSD_ZRS,
/// or PremiumV2_LRS.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskStatusSku
{
    /// <summary>Name: The sku name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: The sku tier.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>SupportedCapabilities: List of supported capabilities for the image from which the OS disk was created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskStatusSupportedCapabilities
{
    /// <summary>AcceleratedNetwork: True if the image from which the OS disk is created supports accelerated networking.</summary>
    [JsonPropertyName("acceleratedNetwork")]
    public bool? AcceleratedNetwork { get; set; }

    /// <summary>Architecture: CPU architecture supported by an OS disk.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>DiskControllerTypes: The disk controllers that an OS disk supports. If set it can be SCSI or SCSI, NVME or NVME, SCSI.</summary>
    [JsonPropertyName("diskControllerTypes")]
    public string? DiskControllerTypes { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskStatusSystemData
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

/// <summary>Disk resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20240302DiskStatus
{
    /// <summary>
    /// LastOwnershipUpdateTime: The UTC time when the ownership state of the disk was last changed i.e., the time the disk was
    /// last attached or detached from a VM or the time when the VM to which the disk was attached was deallocated or started.
    /// </summary>
    [JsonPropertyName("LastOwnershipUpdateTime")]
    public string? LastOwnershipUpdateTime { get; set; }

    /// <summary>
    /// BurstingEnabled: Set to true to enable bursting beyond the provisioned performance target of the disk. Bursting is
    /// disabled by default. Does not apply to Ultra disks.
    /// </summary>
    [JsonPropertyName("burstingEnabled")]
    public bool? BurstingEnabled { get; set; }

    /// <summary>BurstingEnabledTime: Latest time when bursting was last enabled on a disk.</summary>
    [JsonPropertyName("burstingEnabledTime")]
    public string? BurstingEnabledTime { get; set; }

    /// <summary>CompletionPercent: Percentage complete for the background copy when a resource is created via the CopyStart operation.</summary>
    [JsonPropertyName("completionPercent")]
    public double? CompletionPercent { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20240302DiskStatusConditions>? Conditions { get; set; }

    /// <summary>CreationData: Disk source information. CreationData information cannot be changed after the disk has been created.</summary>
    [JsonPropertyName("creationData")]
    public V1api20240302DiskStatusCreationData? CreationData { get; set; }

    /// <summary>DataAccessAuthMode: Additional authentication requirements when exporting or uploading to a disk or snapshot.</summary>
    [JsonPropertyName("dataAccessAuthMode")]
    public string? DataAccessAuthMode { get; set; }

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
    public V1api20240302DiskStatusEncryption? Encryption { get; set; }

    /// <summary>
    /// EncryptionSettingsCollection: Encryption settings collection used for Azure Disk Encryption, can contain multiple
    /// encryption settings per disk or snapshot.
    /// </summary>
    [JsonPropertyName("encryptionSettingsCollection")]
    public V1api20240302DiskStatusEncryptionSettingsCollection? EncryptionSettingsCollection { get; set; }

    /// <summary>ExtendedLocation: The extended location where the disk will be created. Extended location cannot be changed.</summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20240302DiskStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>HyperVGeneration: The hypervisor generation of the Virtual Machine. Applicable to OS disks only.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
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

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NetworkAccessPolicy: Policy for accessing the disk via network.</summary>
    [JsonPropertyName("networkAccessPolicy")]
    public string? NetworkAccessPolicy { get; set; }

    /// <summary>
    /// OptimizedForFrequentAttach: Setting this property to true improves reliability and performance of data disks that are
    /// frequently (more than 5 times a day) by detached from one virtual machine and attached to another. This property should
    /// not be set for disks that are not detached and attached frequently as it causes the disks to not align with the fault
    /// domain of the virtual machine.
    /// </summary>
    [JsonPropertyName("optimizedForFrequentAttach")]
    public bool? OptimizedForFrequentAttach { get; set; }

    /// <summary>OsType: The Operating System type.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>PropertyUpdatesInProgress: Properties of the disk for which update is pending.</summary>
    [JsonPropertyName("propertyUpdatesInProgress")]
    public V1api20240302DiskStatusPropertyUpdatesInProgress? PropertyUpdatesInProgress { get; set; }

    /// <summary>ProvisioningState: The disk provisioning state.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>PublicNetworkAccess: Policy for controlling export on the disk.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>
    /// PurchasePlan: Purchase plan information for the the image from which the OS disk was created. E.g. - {name:
    /// 2019-Datacenter, publisher: MicrosoftWindowsServer, product: WindowsServer}
    /// </summary>
    [JsonPropertyName("purchasePlan")]
    public V1api20240302DiskStatusPurchasePlan? PurchasePlan { get; set; }

    /// <summary>SecurityProfile: Contains the security related information for the resource.</summary>
    [JsonPropertyName("securityProfile")]
    public V1api20240302DiskStatusSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// ShareInfo: Details of the list of all VMs that have the disk attached. maxShares should be set to a value greater than
    /// one for disks to allow attaching them to multiple VMs.
    /// </summary>
    [JsonPropertyName("shareInfo")]
    public IList<V1api20240302DiskStatusShareInfo>? ShareInfo { get; set; }

    /// <summary>
    /// Sku: The disks sku name. Can be Standard_LRS, Premium_LRS, StandardSSD_LRS, UltraSSD_LRS, Premium_ZRS, StandardSSD_ZRS,
    /// or PremiumV2_LRS.
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20240302DiskStatusSku? Sku { get; set; }

    /// <summary>SupportedCapabilities: List of supported capabilities for the image from which the OS disk was created.</summary>
    [JsonPropertyName("supportedCapabilities")]
    public V1api20240302DiskStatusSupportedCapabilities? SupportedCapabilities { get; set; }

    /// <summary>SupportsHibernation: Indicates the OS on a disk supports hibernation.</summary>
    [JsonPropertyName("supportsHibernation")]
    public bool? SupportsHibernation { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20240302DiskStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
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

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
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
/// - Generated from: /compute/resource-manager/Microsoft.Compute/DiskRP/stable/2024-03-02/DiskRP.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/disks/{diskName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20240302Disk : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20240302DiskSpec?>, IStatus<V1api20240302DiskStatus?>
{
    public const string KubeApiVersion = "v1api20240302";
    public const string KubeKind = "Disk";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "disks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20240302";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Disk";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20240302DiskSpec? Spec { get; set; }

    /// <summary>Disk resource.</summary>
    [JsonPropertyName("status")]
    public V1api20240302DiskStatus? Status { get; set; }
}