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
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/snapshots/{snapshotName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240302SnapshotList : IKubernetesObject<V1ListMeta>, IItems<V20240302Snapshot>
{
    public const string KubeApiVersion = "v20240302";
    public const string KubeKind = "SnapshotList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "snapshots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v20240302";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SnapshotList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20240302Snapshot objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20240302Snapshot> Items { get; set; }
}

/// <summary>ErrorCode: Indicates the error code if the background copy of a resource created via the CopyStart operation fails.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240302SnapshotSpecCopyCompletionErrorErrorCodeEnum>))]
public enum V20240302SnapshotSpecCopyCompletionErrorErrorCodeEnum
{
    [EnumMember(Value = "CopySourceNotFound"), JsonStringEnumMemberName("CopySourceNotFound")]
    CopySourceNotFound
}

/// <summary>
/// CopyCompletionError: Indicates the error details if the background copy of a resource created via the CopyStart
/// operation fails.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotSpecCopyCompletionError
{
    /// <summary>ErrorCode: Indicates the error code if the background copy of a resource created via the CopyStart operation fails.</summary>
    [JsonPropertyName("errorCode")]
    public required V20240302SnapshotSpecCopyCompletionErrorErrorCodeEnum ErrorCode { get; set; }

    /// <summary>ErrorMessage: Indicates the error message if the background copy of a resource created via the CopyStart operation fails.</summary>
    [JsonPropertyName("errorMessage")]
    public required string ErrorMessage { get; set; }
}

/// <summary>CreateOption: This enumerates the possible sources of a disk&apos;s creation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240302SnapshotSpecCreationDataCreateOptionEnum>))]
public enum V20240302SnapshotSpecCreationDataCreateOptionEnum
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
public partial class V20240302SnapshotSpecCreationDataElasticSanResourceReference
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
public partial class V20240302SnapshotSpecCreationDataGalleryImageReferenceReference
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
public partial class V20240302SnapshotSpecCreationDataGalleryImageReference
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
    public V20240302SnapshotSpecCreationDataGalleryImageReferenceReference? Reference { get; set; }

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
public partial class V20240302SnapshotSpecCreationDataImageReferenceReference
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
public partial class V20240302SnapshotSpecCreationDataImageReference
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
    public V20240302SnapshotSpecCreationDataImageReferenceReference? Reference { get; set; }

    /// <summary>SharedGalleryImageId: A relative uri containing a direct shared Azure Compute Gallery image reference.</summary>
    [JsonPropertyName("sharedGalleryImageId")]
    public string? SharedGalleryImageId { get; set; }
}

/// <summary>
/// ProvisionedBandwidthCopySpeed: If this field is set on a snapshot and createOption is CopyStart, the snapshot will be
/// copied at a quicker speed.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240302SnapshotSpecCreationDataProvisionedBandwidthCopySpeedEnum>))]
public enum V20240302SnapshotSpecCreationDataProvisionedBandwidthCopySpeedEnum
{
    [EnumMember(Value = "Enhanced"), JsonStringEnumMemberName("Enhanced")]
    Enhanced,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>SourceResourceReference: If createOption is Copy, this is the ARM id of the source snapshot or disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotSpecCreationDataSourceResourceReference
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
public partial class V20240302SnapshotSpecCreationData
{
    /// <summary>CreateOption: This enumerates the possible sources of a disk&apos;s creation.</summary>
    [JsonPropertyName("createOption")]
    public required V20240302SnapshotSpecCreationDataCreateOptionEnum CreateOption { get; set; }

    /// <summary>
    /// ElasticSanResourceReference: Required if createOption is CopyFromSanSnapshot. This is the ARM id of the source elastic
    /// san volume snapshot.
    /// </summary>
    [JsonPropertyName("elasticSanResourceReference")]
    public V20240302SnapshotSpecCreationDataElasticSanResourceReference? ElasticSanResourceReference { get; set; }

    /// <summary>
    /// GalleryImageReference: Required if creating from a Gallery Image. The id/sharedGalleryImageId/communityGalleryImageId of
    /// the ImageDiskReference will be the ARM id of the shared galley image version from which to create a disk.
    /// </summary>
    [JsonPropertyName("galleryImageReference")]
    public V20240302SnapshotSpecCreationDataGalleryImageReference? GalleryImageReference { get; set; }

    /// <summary>ImageReference: Disk source information for PIR or user images.</summary>
    [JsonPropertyName("imageReference")]
    public V20240302SnapshotSpecCreationDataImageReference? ImageReference { get; set; }

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
    public V20240302SnapshotSpecCreationDataProvisionedBandwidthCopySpeedEnum? ProvisionedBandwidthCopySpeed { get; set; }

    /// <summary>SecurityDataUri: If createOption is ImportSecure, this is the URI of a blob to be imported into VM guest state.</summary>
    [JsonPropertyName("securityDataUri")]
    public string? SecurityDataUri { get; set; }

    /// <summary>SourceResourceReference: If createOption is Copy, this is the ARM id of the source snapshot or disk.</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V20240302SnapshotSpecCreationDataSourceResourceReference? SourceResourceReference { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V20240302SnapshotSpecDataAccessAuthModeEnum>))]
public enum V20240302SnapshotSpecDataAccessAuthModeEnum
{
    [EnumMember(Value = "AzureActiveDirectory"), JsonStringEnumMemberName("AzureActiveDirectory")]
    AzureActiveDirectory,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>DiskAccessReference: ARM id of the DiskAccess resource for using private endpoints on disks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotSpecDiskAccessReference
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
public partial class V20240302SnapshotSpecEncryptionDiskEncryptionSetReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V20240302SnapshotSpecEncryptionTypeEnum>))]
public enum V20240302SnapshotSpecEncryptionTypeEnum
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
public partial class V20240302SnapshotSpecEncryption
{
    /// <summary>DiskEncryptionSetReference: ResourceId of the disk encryption set to use for enabling encryption at rest.</summary>
    [JsonPropertyName("diskEncryptionSetReference")]
    public V20240302SnapshotSpecEncryptionDiskEncryptionSetReference? DiskEncryptionSetReference { get; set; }

    /// <summary>Type: The type of key used to encrypt the data of the disk.</summary>
    [JsonPropertyName("type")]
    public V20240302SnapshotSpecEncryptionTypeEnum? Type { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVaultReference
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
public partial class V20240302SnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20240302SnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVaultReference? Reference { get; set; }
}

/// <summary>DiskEncryptionKey: Key Vault Secret Url and vault id of the disk encryption key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey
{
    /// <summary>SecretUrl: Url pointing to a key or secret in KeyVault</summary>
    [JsonPropertyName("secretUrl")]
    public required string SecretUrl { get; set; }

    /// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
    [JsonPropertyName("sourceVault")]
    public required V20240302SnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault SourceVault { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVaultReference
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
public partial class V20240302SnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20240302SnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVaultReference? Reference { get; set; }
}

/// <summary>
/// KeyEncryptionKey: Key Vault Key Url and vault id of the key encryption key. KeyEncryptionKey is optional and when
/// provided is used to unwrap the disk encryption key.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey
{
    /// <summary>KeyUrl: Url pointing to a key or secret in KeyVault</summary>
    [JsonPropertyName("keyUrl")]
    public required string KeyUrl { get; set; }

    /// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
    [JsonPropertyName("sourceVault")]
    public required V20240302SnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault SourceVault { get; set; }
}

/// <summary>Encryption settings for one disk volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotSpecEncryptionSettingsCollectionEncryptionSettings
{
    /// <summary>DiskEncryptionKey: Key Vault Secret Url and vault id of the disk encryption key</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V20240302SnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>
    /// KeyEncryptionKey: Key Vault Key Url and vault id of the key encryption key. KeyEncryptionKey is optional and when
    /// provided is used to unwrap the disk encryption key.
    /// </summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V20240302SnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>
/// EncryptionSettingsCollection: Encryption settings collection used be Azure Disk Encryption, can contain multiple
/// encryption settings per disk or snapshot.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotSpecEncryptionSettingsCollection
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
    public IList<V20240302SnapshotSpecEncryptionSettingsCollectionEncryptionSettings>? EncryptionSettings { get; set; }

    /// <summary>
    /// EncryptionSettingsVersion: Describes what type of encryption is used for the disks. Once this field is set, it cannot be
    /// overwritten. &apos;1.0&apos; corresponds to Azure Disk Encryption with AAD app.&apos;1.1&apos; corresponds to Azure Disk Encryption.
    /// </summary>
    [JsonPropertyName("encryptionSettingsVersion")]
    public string? EncryptionSettingsVersion { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240302SnapshotSpecExtendedLocationTypeEnum>))]
public enum V20240302SnapshotSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location where the snapshot will be created. Extended location cannot be changed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V20240302SnapshotSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>HyperVGeneration: The hypervisor generation of the Virtual Machine. Applicable to OS disks only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240302SnapshotSpecHyperVGenerationEnum>))]
public enum V20240302SnapshotSpecHyperVGenerationEnum
{
    [EnumMember(Value = "V1"), JsonStringEnumMemberName("V1")]
    V1,
    [EnumMember(Value = "V2"), JsonStringEnumMemberName("V2")]
    V2
}

/// <summary>NetworkAccessPolicy: Policy for accessing the disk via network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240302SnapshotSpecNetworkAccessPolicyEnum>))]
public enum V20240302SnapshotSpecNetworkAccessPolicyEnum
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
public partial class V20240302SnapshotSpecOperatorSpecConfigMapExpressions
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
public partial class V20240302SnapshotSpecOperatorSpecSecretExpressions
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
public partial class V20240302SnapshotSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20240302SnapshotSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20240302SnapshotSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>OsType: The Operating System type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240302SnapshotSpecOsTypeEnum>))]
public enum V20240302SnapshotSpecOsTypeEnum
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
public partial class V20240302SnapshotSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>PublicNetworkAccess: Policy for controlling export on the disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240302SnapshotSpecPublicNetworkAccessEnum>))]
public enum V20240302SnapshotSpecPublicNetworkAccessEnum
{
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled,
    [EnumMember(Value = "Enabled"), JsonStringEnumMemberName("Enabled")]
    Enabled
}

/// <summary>PurchasePlan: Purchase plan information for the image from which the source disk for the snapshot was originally created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotSpecPurchasePlan
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
public partial class V20240302SnapshotSpecSecurityProfileSecureVMDiskEncryptionSetReference
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
[JsonConverter(typeof(JsonStringEnumConverter<V20240302SnapshotSpecSecurityProfileSecurityTypeEnum>))]
public enum V20240302SnapshotSpecSecurityProfileSecurityTypeEnum
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
public partial class V20240302SnapshotSpecSecurityProfile
{
    /// <summary>
    /// SecureVMDiskEncryptionSetReference: ResourceId of the disk encryption set associated to Confidential VM supported disk
    /// encrypted with customer managed key
    /// </summary>
    [JsonPropertyName("secureVMDiskEncryptionSetReference")]
    public V20240302SnapshotSpecSecurityProfileSecureVMDiskEncryptionSetReference? SecureVMDiskEncryptionSetReference { get; set; }

    /// <summary>SecurityType: Specifies the SecurityType of the VM. Applicable for OS disks only.</summary>
    [JsonPropertyName("securityType")]
    public V20240302SnapshotSpecSecurityProfileSecurityTypeEnum? SecurityType { get; set; }
}

/// <summary>Name: The sku name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240302SnapshotSpecSkuNameEnum>))]
public enum V20240302SnapshotSpecSkuNameEnum
{
    [EnumMember(Value = "Premium_LRS"), JsonStringEnumMemberName("Premium_LRS")]
    PremiumLRS,
    [EnumMember(Value = "Standard_LRS"), JsonStringEnumMemberName("Standard_LRS")]
    StandardLRS,
    [EnumMember(Value = "Standard_ZRS"), JsonStringEnumMemberName("Standard_ZRS")]
    StandardZRS
}

/// <summary>
/// Sku: The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. This is an optional parameter for
/// incremental snapshot and the default behavior is the SKU will be set to the same sku as the previous snapshot
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotSpecSku
{
    /// <summary>Name: The sku name.</summary>
    [JsonPropertyName("name")]
    public V20240302SnapshotSpecSkuNameEnum? Name { get; set; }
}

/// <summary>Architecture: CPU architecture supported by an OS disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240302SnapshotSpecSupportedCapabilitiesArchitectureEnum>))]
public enum V20240302SnapshotSpecSupportedCapabilitiesArchitectureEnum
{
    [EnumMember(Value = "Arm64"), JsonStringEnumMemberName("Arm64")]
    Arm64,
    [EnumMember(Value = "x64"), JsonStringEnumMemberName("x64")]
    X64
}

/// <summary>
/// SupportedCapabilities: List of supported capabilities for the image from which the source disk from the snapshot was
/// originally created.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotSpecSupportedCapabilities
{
    /// <summary>AcceleratedNetwork: True if the image from which the OS disk is created supports accelerated networking.</summary>
    [JsonPropertyName("acceleratedNetwork")]
    public bool? AcceleratedNetwork { get; set; }

    /// <summary>Architecture: CPU architecture supported by an OS disk.</summary>
    [JsonPropertyName("architecture")]
    public V20240302SnapshotSpecSupportedCapabilitiesArchitectureEnum? Architecture { get; set; }

    /// <summary>DiskControllerTypes: The disk controllers that an OS disk supports. If set it can be SCSI or SCSI, NVME or NVME, SCSI.</summary>
    [JsonPropertyName("diskControllerTypes")]
    public string? DiskControllerTypes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CompletionPercent: Percentage complete for the background copy when a resource is created via the CopyStart operation.</summary>
    [JsonPropertyName("completionPercent")]
    public double? CompletionPercent { get; set; }

    /// <summary>
    /// CopyCompletionError: Indicates the error details if the background copy of a resource created via the CopyStart
    /// operation fails.
    /// </summary>
    [JsonPropertyName("copyCompletionError")]
    public V20240302SnapshotSpecCopyCompletionError? CopyCompletionError { get; set; }

    /// <summary>CreationData: Disk source information. CreationData information cannot be changed after the disk has been created.</summary>
    [JsonPropertyName("creationData")]
    public required V20240302SnapshotSpecCreationData CreationData { get; set; }

    /// <summary>DataAccessAuthMode: Additional authentication requirements when exporting or uploading to a disk or snapshot.</summary>
    [JsonPropertyName("dataAccessAuthMode")]
    public V20240302SnapshotSpecDataAccessAuthModeEnum? DataAccessAuthMode { get; set; }

    /// <summary>DiskAccessReference: ARM id of the DiskAccess resource for using private endpoints on disks.</summary>
    [JsonPropertyName("diskAccessReference")]
    public V20240302SnapshotSpecDiskAccessReference? DiskAccessReference { get; set; }

    /// <summary>
    /// DiskSizeGB: If creationData.createOption is Empty, this field is mandatory and it indicates the size of the disk to
    /// create. If this field is present for updates or creation with other options, it indicates a resize. Resizes are only
    /// allowed if the disk is not attached to a running VM, and can only increase the disk&apos;s size.
    /// </summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>Encryption: Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys.</summary>
    [JsonPropertyName("encryption")]
    public V20240302SnapshotSpecEncryption? Encryption { get; set; }

    /// <summary>
    /// EncryptionSettingsCollection: Encryption settings collection used be Azure Disk Encryption, can contain multiple
    /// encryption settings per disk or snapshot.
    /// </summary>
    [JsonPropertyName("encryptionSettingsCollection")]
    public V20240302SnapshotSpecEncryptionSettingsCollection? EncryptionSettingsCollection { get; set; }

    /// <summary>ExtendedLocation: The extended location where the snapshot will be created. Extended location cannot be changed.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20240302SnapshotSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>HyperVGeneration: The hypervisor generation of the Virtual Machine. Applicable to OS disks only.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public V20240302SnapshotSpecHyperVGenerationEnum? HyperVGeneration { get; set; }

    /// <summary>
    /// Incremental: Whether a snapshot is incremental. Incremental snapshots on the same disk occupy less space than full
    /// snapshots and can be diffed.
    /// </summary>
    [JsonPropertyName("incremental")]
    public bool? Incremental { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>NetworkAccessPolicy: Policy for accessing the disk via network.</summary>
    [JsonPropertyName("networkAccessPolicy")]
    public V20240302SnapshotSpecNetworkAccessPolicyEnum? NetworkAccessPolicy { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20240302SnapshotSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>OsType: The Operating System type.</summary>
    [JsonPropertyName("osType")]
    public V20240302SnapshotSpecOsTypeEnum? OsType { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20240302SnapshotSpecOwner Owner { get; set; }

    /// <summary>PublicNetworkAccess: Policy for controlling export on the disk.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public V20240302SnapshotSpecPublicNetworkAccessEnum? PublicNetworkAccess { get; set; }

    /// <summary>PurchasePlan: Purchase plan information for the image from which the source disk for the snapshot was originally created.</summary>
    [JsonPropertyName("purchasePlan")]
    public V20240302SnapshotSpecPurchasePlan? PurchasePlan { get; set; }

    /// <summary>SecurityProfile: Contains the security related information for the resource.</summary>
    [JsonPropertyName("securityProfile")]
    public V20240302SnapshotSpecSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// Sku: The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. This is an optional parameter for
    /// incremental snapshot and the default behavior is the SKU will be set to the same sku as the previous snapshot
    /// </summary>
    [JsonPropertyName("sku")]
    public V20240302SnapshotSpecSku? Sku { get; set; }

    /// <summary>
    /// SupportedCapabilities: List of supported capabilities for the image from which the source disk from the snapshot was
    /// originally created.
    /// </summary>
    [JsonPropertyName("supportedCapabilities")]
    public V20240302SnapshotSpecSupportedCapabilities? SupportedCapabilities { get; set; }

    /// <summary>SupportsHibernation: Indicates the OS on a snapshot supports hibernation.</summary>
    [JsonPropertyName("supportsHibernation")]
    public bool? SupportsHibernation { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotStatusConditions
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
/// CopyCompletionError: Indicates the error details if the background copy of a resource created via the CopyStart
/// operation fails.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotStatusCopyCompletionError
{
    /// <summary>ErrorCode: Indicates the error code if the background copy of a resource created via the CopyStart operation fails.</summary>
    [JsonPropertyName("errorCode")]
    public string? ErrorCode { get; set; }

    /// <summary>ErrorMessage: Indicates the error message if the background copy of a resource created via the CopyStart operation fails.</summary>
    [JsonPropertyName("errorMessage")]
    public string? ErrorMessage { get; set; }
}

/// <summary>
/// GalleryImageReference: Required if creating from a Gallery Image. The id/sharedGalleryImageId/communityGalleryImageId of
/// the ImageDiskReference will be the ARM id of the shared galley image version from which to create a disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotStatusCreationDataGalleryImageReference
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
public partial class V20240302SnapshotStatusCreationDataImageReference
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
public partial class V20240302SnapshotStatusCreationData
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
    public V20240302SnapshotStatusCreationDataGalleryImageReference? GalleryImageReference { get; set; }

    /// <summary>ImageReference: Disk source information for PIR or user images.</summary>
    [JsonPropertyName("imageReference")]
    public V20240302SnapshotStatusCreationDataImageReference? ImageReference { get; set; }

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
public partial class V20240302SnapshotStatusEncryption
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
public partial class V20240302SnapshotStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>DiskEncryptionKey: Key Vault Secret Url and vault id of the disk encryption key</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey
{
    /// <summary>SecretUrl: Url pointing to a key or secret in KeyVault</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
    [JsonPropertyName("sourceVault")]
    public V20240302SnapshotStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault
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
public partial class V20240302SnapshotStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey
{
    /// <summary>KeyUrl: Url pointing to a key or secret in KeyVault</summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>SourceVault: Resource id of the KeyVault containing the key or secret</summary>
    [JsonPropertyName("sourceVault")]
    public V20240302SnapshotStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>Encryption settings for one disk volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotStatusEncryptionSettingsCollectionEncryptionSettings
{
    /// <summary>DiskEncryptionKey: Key Vault Secret Url and vault id of the disk encryption key</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V20240302SnapshotStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>
    /// KeyEncryptionKey: Key Vault Key Url and vault id of the key encryption key. KeyEncryptionKey is optional and when
    /// provided is used to unwrap the disk encryption key.
    /// </summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V20240302SnapshotStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>
/// EncryptionSettingsCollection: Encryption settings collection used be Azure Disk Encryption, can contain multiple
/// encryption settings per disk or snapshot.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotStatusEncryptionSettingsCollection
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
    public IList<V20240302SnapshotStatusEncryptionSettingsCollectionEncryptionSettings>? EncryptionSettings { get; set; }

    /// <summary>
    /// EncryptionSettingsVersion: Describes what type of encryption is used for the disks. Once this field is set, it cannot be
    /// overwritten. &apos;1.0&apos; corresponds to Azure Disk Encryption with AAD app.&apos;1.1&apos; corresponds to Azure Disk Encryption.
    /// </summary>
    [JsonPropertyName("encryptionSettingsVersion")]
    public string? EncryptionSettingsVersion { get; set; }
}

/// <summary>ExtendedLocation: The extended location where the snapshot will be created. Extended location cannot be changed.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PurchasePlan: Purchase plan information for the image from which the source disk for the snapshot was originally created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotStatusPurchasePlan
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
public partial class V20240302SnapshotStatusSecurityProfile
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

/// <summary>
/// Sku: The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. This is an optional parameter for
/// incremental snapshot and the default behavior is the SKU will be set to the same sku as the previous snapshot
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotStatusSku
{
    /// <summary>Name: The sku name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Tier: The sku tier.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// SupportedCapabilities: List of supported capabilities for the image from which the source disk from the snapshot was
/// originally created.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotStatusSupportedCapabilities
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
public partial class V20240302SnapshotStatusSystemData
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

/// <summary>Snapshot resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240302SnapshotStatus
{
    /// <summary>CompletionPercent: Percentage complete for the background copy when a resource is created via the CopyStart operation.</summary>
    [JsonPropertyName("completionPercent")]
    public double? CompletionPercent { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20240302SnapshotStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// CopyCompletionError: Indicates the error details if the background copy of a resource created via the CopyStart
    /// operation fails.
    /// </summary>
    [JsonPropertyName("copyCompletionError")]
    public V20240302SnapshotStatusCopyCompletionError? CopyCompletionError { get; set; }

    /// <summary>CreationData: Disk source information. CreationData information cannot be changed after the disk has been created.</summary>
    [JsonPropertyName("creationData")]
    public V20240302SnapshotStatusCreationData? CreationData { get; set; }

    /// <summary>DataAccessAuthMode: Additional authentication requirements when exporting or uploading to a disk or snapshot.</summary>
    [JsonPropertyName("dataAccessAuthMode")]
    public string? DataAccessAuthMode { get; set; }

    /// <summary>DiskAccessId: ARM id of the DiskAccess resource for using private endpoints on disks.</summary>
    [JsonPropertyName("diskAccessId")]
    public string? DiskAccessId { get; set; }

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

    /// <summary>DiskState: The state of the snapshot.</summary>
    [JsonPropertyName("diskState")]
    public string? DiskState { get; set; }

    /// <summary>Encryption: Encryption property can be used to encrypt data at rest with customer managed keys or platform managed keys.</summary>
    [JsonPropertyName("encryption")]
    public V20240302SnapshotStatusEncryption? Encryption { get; set; }

    /// <summary>
    /// EncryptionSettingsCollection: Encryption settings collection used be Azure Disk Encryption, can contain multiple
    /// encryption settings per disk or snapshot.
    /// </summary>
    [JsonPropertyName("encryptionSettingsCollection")]
    public V20240302SnapshotStatusEncryptionSettingsCollection? EncryptionSettingsCollection { get; set; }

    /// <summary>ExtendedLocation: The extended location where the snapshot will be created. Extended location cannot be changed.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20240302SnapshotStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>HyperVGeneration: The hypervisor generation of the Virtual Machine. Applicable to OS disks only.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Incremental: Whether a snapshot is incremental. Incremental snapshots on the same disk occupy less space than full
    /// snapshots and can be diffed.
    /// </summary>
    [JsonPropertyName("incremental")]
    public bool? Incremental { get; set; }

    /// <summary>
    /// IncrementalSnapshotFamilyId: Incremental snapshots for a disk share an incremental snapshot family id. The Get Page
    /// Range Diff API can only be called on incremental snapshots with the same family id.
    /// </summary>
    [JsonPropertyName("incrementalSnapshotFamilyId")]
    public string? IncrementalSnapshotFamilyId { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>ManagedBy: Unused. Always Null.</summary>
    [JsonPropertyName("managedBy")]
    public string? ManagedBy { get; set; }

    /// <summary>Name: The name of the resource</summary>
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

    /// <summary>PublicNetworkAccess: Policy for controlling export on the disk.</summary>
    [JsonPropertyName("publicNetworkAccess")]
    public string? PublicNetworkAccess { get; set; }

    /// <summary>PurchasePlan: Purchase plan information for the image from which the source disk for the snapshot was originally created.</summary>
    [JsonPropertyName("purchasePlan")]
    public V20240302SnapshotStatusPurchasePlan? PurchasePlan { get; set; }

    /// <summary>SecurityProfile: Contains the security related information for the resource.</summary>
    [JsonPropertyName("securityProfile")]
    public V20240302SnapshotStatusSecurityProfile? SecurityProfile { get; set; }

    /// <summary>
    /// Sku: The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. This is an optional parameter for
    /// incremental snapshot and the default behavior is the SKU will be set to the same sku as the previous snapshot
    /// </summary>
    [JsonPropertyName("sku")]
    public V20240302SnapshotStatusSku? Sku { get; set; }

    /// <summary>
    /// SupportedCapabilities: List of supported capabilities for the image from which the source disk from the snapshot was
    /// originally created.
    /// </summary>
    [JsonPropertyName("supportedCapabilities")]
    public V20240302SnapshotStatusSupportedCapabilities? SupportedCapabilities { get; set; }

    /// <summary>SupportsHibernation: Indicates the OS on a snapshot supports hibernation.</summary>
    [JsonPropertyName("supportsHibernation")]
    public bool? SupportsHibernation { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20240302SnapshotStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>TimeCreated: The time when the snapshot was created.</summary>
    [JsonPropertyName("timeCreated")]
    public string? TimeCreated { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UniqueId: Unique Guid identifying the resource.</summary>
    [JsonPropertyName("uniqueId")]
    public string? UniqueId { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/DiskRP/stable/2024-03-02/DiskRP.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/snapshots/{snapshotName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240302Snapshot : IKubernetesObject<V1ObjectMeta>, ISpec<V20240302SnapshotSpec?>, IStatus<V20240302SnapshotStatus?>
{
    public const string KubeApiVersion = "v20240302";
    public const string KubeKind = "Snapshot";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "snapshots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v20240302";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Snapshot";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20240302SnapshotSpec? Spec { get; set; }

    /// <summary>Snapshot resource.</summary>
    [JsonPropertyName("status")]
    public V20240302SnapshotStatus? Status { get; set; }
}