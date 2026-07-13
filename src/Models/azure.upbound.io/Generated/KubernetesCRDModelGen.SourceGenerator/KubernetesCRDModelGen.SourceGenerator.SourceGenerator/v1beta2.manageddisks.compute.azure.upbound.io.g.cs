#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.azure.upbound.io;
/// <summary>ManagedDisk is the Schema for the ManagedDisks API. Manages a Managed Disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ManagedDiskList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ManagedDisk>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ManagedDiskList";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "manageddisks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedDiskList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ManagedDisk objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ManagedDisk> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedDiskSpecDeletionPolicyEnum>))]
public enum V1beta2ManagedDiskSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A disk_encryption_key block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecForProviderEncryptionSettingsDiskEncryptionKey
{
    /// <summary>The URL to the Key Vault Secret used as the Disk Encryption Key. This can be found as id on the azurerm_key_vault_secret resource.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault. This can be found as id on the azurerm_key_vault resource.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>A key_encryption_key block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecForProviderEncryptionSettingsKeyEncryptionKey
{
    /// <summary>The URL to the Key Vault Key used as the Key Encryption Key. This can be found as id on the azurerm_key_vault_key resource.</summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>The ID of the source Key Vault. This can be found as id on the azurerm_key_vault resource.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>A encryption_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecForProviderEncryptionSettings
{
    /// <summary>A disk_encryption_key block as defined above.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta2ManagedDiskSpecForProviderEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>A key_encryption_key block as defined below.</summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1beta2ManagedDiskSpecForProviderEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedDiskSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2ManagedDiskSpecForProviderResourceGroupNameRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedDiskSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2ManagedDiskSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedDiskSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedDiskSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedDiskSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedDiskSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagedDiskSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedDiskSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2ManagedDiskSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedDiskSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedDiskSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecForProviderResourceGroupNameSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedDiskSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedDiskSpecForProviderSourceResourceIdRefPolicyResolutionEnum>))]
public enum V1beta2ManagedDiskSpecForProviderSourceResourceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedDiskSpecForProviderSourceResourceIdRefPolicyResolveEnum>))]
public enum V1beta2ManagedDiskSpecForProviderSourceResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecForProviderSourceResourceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedDiskSpecForProviderSourceResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedDiskSpecForProviderSourceResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagedDisk in compute to populate sourceResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecForProviderSourceResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedDiskSpecForProviderSourceResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedDiskSpecForProviderSourceResourceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagedDiskSpecForProviderSourceResourceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedDiskSpecForProviderSourceResourceIdSelectorPolicyResolveEnum>))]
public enum V1beta2ManagedDiskSpecForProviderSourceResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecForProviderSourceResourceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedDiskSpecForProviderSourceResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedDiskSpecForProviderSourceResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagedDisk in compute to populate sourceResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecForProviderSourceResourceIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedDiskSpecForProviderSourceResourceIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecForProvider
{
    /// <summary>The method to use when creating the managed disk. Changing this forces a new resource to be created. Possible values include: * Import - Import a VHD file in to the managed disk (VHD specified with source_uri). * ImportSecure - Securely import a VHD file in to the managed disk (VHD specified with source_uri). * Empty - Create an empty managed disk. * Copy - Copy an existing managed disk or snapshot (specified with source_resource_id). * FromImage - Copy a Platform Image (specified with image_reference_id) * Restore - Set by Azure Backup or Site Recovery on a restored disk (specified with source_resource_id). * Upload - Upload a VHD disk with the help of SAS URL (to be used with upload_size_bytes).</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The ID of the disk access resource for using private endpoints on disks.</summary>
    [JsonPropertyName("diskAccessId")]
    public string? DiskAccessId { get; set; }

    /// <summary>The ID of a Disk Encryption Set which should be used to encrypt this Managed Disk. Conflicts with secure_vm_disk_encryption_set_id.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The number of IOPS allowed across all VMs mounting the shared disk as read-only; only settable for UltraSSD disks and PremiumV2 disks with shared disk enabled. One operation can transfer between 4k and 256k bytes.</summary>
    [JsonPropertyName("diskIopsReadOnly")]
    public double? DiskIopsReadOnly { get; set; }

    /// <summary>The number of IOPS allowed for this disk; only settable for UltraSSD disks and PremiumV2 disks. One operation can transfer between 4k and 256k bytes.</summary>
    [JsonPropertyName("diskIopsReadWrite")]
    public double? DiskIopsReadWrite { get; set; }

    /// <summary>The bandwidth allowed across all VMs mounting the shared disk as read-only; only settable for UltraSSD disks and PremiumV2 disks with shared disk enabled. MBps means millions of bytes per second.</summary>
    [JsonPropertyName("diskMbpsReadOnly")]
    public double? DiskMbpsReadOnly { get; set; }

    /// <summary>The bandwidth allowed for this disk; only settable for UltraSSD disks and PremiumV2 disks. MBps means millions of bytes per second.</summary>
    [JsonPropertyName("diskMbpsReadWrite")]
    public double? DiskMbpsReadWrite { get; set; }

    /// <summary>Specifies the size of the managed disk to create in gigabytes. If create_option is Copy or FromImage, then the value must be equal to or greater than the source&apos;s size. The size can only be increased.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Managed Disk should exist. Changing this forces a new Managed Disk to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>A encryption_settings block as defined below.</summary>
    [JsonPropertyName("encryptionSettings")]
    public V1beta2ManagedDiskSpecForProviderEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>ID of a Gallery Image Version to copy when create_option is FromImage. This field cannot be specified if image_reference_id is specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("galleryImageReferenceId")]
    public string? GalleryImageReferenceId { get; set; }

    /// <summary>The HyperV Generation of the Disk when the source of an Import or Copy operation targets a source that contains an operating system. Possible values are V1 and V2. For ImportSecure it must be set to V2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>ID of an existing platform/marketplace disk image to copy when create_option is FromImage. This field cannot be specified if gallery_image_reference_id is specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("imageReferenceId")]
    public string? ImageReferenceId { get; set; }

    /// <summary>Specified the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Logical Sector Size. Possible values are: 512 and 4096. Defaults to 4096. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("logicalSectorSize")]
    public double? LogicalSectorSize { get; set; }

    /// <summary>The maximum number of VMs that can attach to the disk at the same time. Value greater than one indicates a disk that can be mounted on multiple VMs at the same time.</summary>
    [JsonPropertyName("maxShares")]
    public double? MaxShares { get; set; }

    /// <summary>Policy for accessing the disk via network. Allowed values are AllowAll, AllowPrivate, and DenyAll. Defaults to AllowAll.</summary>
    [JsonPropertyName("networkAccessPolicy")]
    public string? NetworkAccessPolicy { get; set; }

    /// <summary>Specifies if On-Demand Bursting is enabled for the Managed Disk.</summary>
    [JsonPropertyName("onDemandBurstingEnabled")]
    public bool? OnDemandBurstingEnabled { get; set; }

    /// <summary>Specifies whether this Managed Disk should be optimized for frequent disk attachments (where a disk is attached/detached more than 5 times in a day). Defaults to false.</summary>
    [JsonPropertyName("optimizedFrequentAttachEnabled")]
    public bool? OptimizedFrequentAttachEnabled { get; set; }

    /// <summary>Specify a value when the source of an Import, ImportSecure or Copy operation targets a source that contains an operating system. Valid values are Linux or Windows.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>Specifies whether Performance Plus is enabled for this Managed Disk. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("performancePlusEnabled")]
    public bool? PerformancePlusEnabled { get; set; }

    /// <summary>Whether it is allowed to access the disk via public network. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the Resource Group where the Managed Disk should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2ManagedDiskSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2ManagedDiskSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to Encrypt this OS Disk when the Virtual Machine is a Confidential VM. Conflicts with disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureVmDiskEncryptionSetId")]
    public string? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>Security Type of the Managed Disk when it is used for a Confidential VM. Possible values are ConfidentialVM_VMGuestStateOnlyEncryptedWithPlatformKey, ConfidentialVM_DiskEncryptedWithPlatformKey and ConfidentialVM_DiskEncryptedWithCustomerKey. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityType")]
    public string? SecurityType { get; set; }

    /// <summary>The ID of an existing Managed Disk or Snapshot to copy when create_option is Copy or the recovery point to restore when create_option is Restore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }

    /// <summary>Reference to a ManagedDisk in compute to populate sourceResourceId.</summary>
    [JsonPropertyName("sourceResourceIdRef")]
    public V1beta2ManagedDiskSpecForProviderSourceResourceIdRef? SourceResourceIdRef { get; set; }

    /// <summary>Selector for a ManagedDisk in compute to populate sourceResourceId.</summary>
    [JsonPropertyName("sourceResourceIdSelector")]
    public V1beta2ManagedDiskSpecForProviderSourceResourceIdSelector? SourceResourceIdSelector { get; set; }

    /// <summary>URI to a valid VHD file to be used when create_option is Import or ImportSecure. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceUri")]
    public string? SourceUri { get; set; }

    /// <summary>The ID of the Storage Account where the source_uri is located. Required when create_option is set to Import or ImportSecure. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>The type of storage to use for the managed disk. Possible values are Standard_LRS, StandardSSD_ZRS, Premium_LRS, PremiumV2_LRS, Premium_ZRS, StandardSSD_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The disk performance tier to use. Possible values are documented here. This feature is currently supported only for premium SSDs.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>Specifies if Trusted Launch is enabled for the Managed Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("trustedLaunchEnabled")]
    public bool? TrustedLaunchEnabled { get; set; }

    /// <summary>Specifies the size of the managed disk to create in bytes. Required when create_option is Upload. The value must be equal to the source disk to be copied in bytes. Source disk size could be calculated with ls -l or wc -c. More information can be found at Copy a managed disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("uploadSizeBytes")]
    public double? UploadSizeBytes { get; set; }

    /// <summary>Specifies the Availability Zone in which this Managed Disk should be located. Changing this property forces a new resource to be created.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>A disk_encryption_key block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecInitProviderEncryptionSettingsDiskEncryptionKey
{
    /// <summary>The URL to the Key Vault Secret used as the Disk Encryption Key. This can be found as id on the azurerm_key_vault_secret resource.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault. This can be found as id on the azurerm_key_vault resource.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>A key_encryption_key block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecInitProviderEncryptionSettingsKeyEncryptionKey
{
    /// <summary>The URL to the Key Vault Key used as the Key Encryption Key. This can be found as id on the azurerm_key_vault_key resource.</summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>The ID of the source Key Vault. This can be found as id on the azurerm_key_vault resource.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>A encryption_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecInitProviderEncryptionSettings
{
    /// <summary>A disk_encryption_key block as defined above.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta2ManagedDiskSpecInitProviderEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>A key_encryption_key block as defined below.</summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1beta2ManagedDiskSpecInitProviderEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedDiskSpecInitProviderSourceResourceIdRefPolicyResolutionEnum>))]
public enum V1beta2ManagedDiskSpecInitProviderSourceResourceIdRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedDiskSpecInitProviderSourceResourceIdRefPolicyResolveEnum>))]
public enum V1beta2ManagedDiskSpecInitProviderSourceResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecInitProviderSourceResourceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedDiskSpecInitProviderSourceResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedDiskSpecInitProviderSourceResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ManagedDisk in compute to populate sourceResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecInitProviderSourceResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedDiskSpecInitProviderSourceResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedDiskSpecInitProviderSourceResourceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2ManagedDiskSpecInitProviderSourceResourceIdSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedDiskSpecInitProviderSourceResourceIdSelectorPolicyResolveEnum>))]
public enum V1beta2ManagedDiskSpecInitProviderSourceResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecInitProviderSourceResourceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedDiskSpecInitProviderSourceResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedDiskSpecInitProviderSourceResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ManagedDisk in compute to populate sourceResourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecInitProviderSourceResourceIdSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedDiskSpecInitProviderSourceResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecInitProvider
{
    /// <summary>The method to use when creating the managed disk. Changing this forces a new resource to be created. Possible values include: * Import - Import a VHD file in to the managed disk (VHD specified with source_uri). * ImportSecure - Securely import a VHD file in to the managed disk (VHD specified with source_uri). * Empty - Create an empty managed disk. * Copy - Copy an existing managed disk or snapshot (specified with source_resource_id). * FromImage - Copy a Platform Image (specified with image_reference_id) * Restore - Set by Azure Backup or Site Recovery on a restored disk (specified with source_resource_id). * Upload - Upload a VHD disk with the help of SAS URL (to be used with upload_size_bytes).</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The ID of the disk access resource for using private endpoints on disks.</summary>
    [JsonPropertyName("diskAccessId")]
    public string? DiskAccessId { get; set; }

    /// <summary>The ID of a Disk Encryption Set which should be used to encrypt this Managed Disk. Conflicts with secure_vm_disk_encryption_set_id.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The number of IOPS allowed across all VMs mounting the shared disk as read-only; only settable for UltraSSD disks and PremiumV2 disks with shared disk enabled. One operation can transfer between 4k and 256k bytes.</summary>
    [JsonPropertyName("diskIopsReadOnly")]
    public double? DiskIopsReadOnly { get; set; }

    /// <summary>The number of IOPS allowed for this disk; only settable for UltraSSD disks and PremiumV2 disks. One operation can transfer between 4k and 256k bytes.</summary>
    [JsonPropertyName("diskIopsReadWrite")]
    public double? DiskIopsReadWrite { get; set; }

    /// <summary>The bandwidth allowed across all VMs mounting the shared disk as read-only; only settable for UltraSSD disks and PremiumV2 disks with shared disk enabled. MBps means millions of bytes per second.</summary>
    [JsonPropertyName("diskMbpsReadOnly")]
    public double? DiskMbpsReadOnly { get; set; }

    /// <summary>The bandwidth allowed for this disk; only settable for UltraSSD disks and PremiumV2 disks. MBps means millions of bytes per second.</summary>
    [JsonPropertyName("diskMbpsReadWrite")]
    public double? DiskMbpsReadWrite { get; set; }

    /// <summary>Specifies the size of the managed disk to create in gigabytes. If create_option is Copy or FromImage, then the value must be equal to or greater than the source&apos;s size. The size can only be increased.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Managed Disk should exist. Changing this forces a new Managed Disk to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>A encryption_settings block as defined below.</summary>
    [JsonPropertyName("encryptionSettings")]
    public V1beta2ManagedDiskSpecInitProviderEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>ID of a Gallery Image Version to copy when create_option is FromImage. This field cannot be specified if image_reference_id is specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("galleryImageReferenceId")]
    public string? GalleryImageReferenceId { get; set; }

    /// <summary>The HyperV Generation of the Disk when the source of an Import or Copy operation targets a source that contains an operating system. Possible values are V1 and V2. For ImportSecure it must be set to V2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>ID of an existing platform/marketplace disk image to copy when create_option is FromImage. This field cannot be specified if gallery_image_reference_id is specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("imageReferenceId")]
    public string? ImageReferenceId { get; set; }

    /// <summary>Specified the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Logical Sector Size. Possible values are: 512 and 4096. Defaults to 4096. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("logicalSectorSize")]
    public double? LogicalSectorSize { get; set; }

    /// <summary>The maximum number of VMs that can attach to the disk at the same time. Value greater than one indicates a disk that can be mounted on multiple VMs at the same time.</summary>
    [JsonPropertyName("maxShares")]
    public double? MaxShares { get; set; }

    /// <summary>Policy for accessing the disk via network. Allowed values are AllowAll, AllowPrivate, and DenyAll. Defaults to AllowAll.</summary>
    [JsonPropertyName("networkAccessPolicy")]
    public string? NetworkAccessPolicy { get; set; }

    /// <summary>Specifies if On-Demand Bursting is enabled for the Managed Disk.</summary>
    [JsonPropertyName("onDemandBurstingEnabled")]
    public bool? OnDemandBurstingEnabled { get; set; }

    /// <summary>Specifies whether this Managed Disk should be optimized for frequent disk attachments (where a disk is attached/detached more than 5 times in a day). Defaults to false.</summary>
    [JsonPropertyName("optimizedFrequentAttachEnabled")]
    public bool? OptimizedFrequentAttachEnabled { get; set; }

    /// <summary>Specify a value when the source of an Import, ImportSecure or Copy operation targets a source that contains an operating system. Valid values are Linux or Windows.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>Specifies whether Performance Plus is enabled for this Managed Disk. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("performancePlusEnabled")]
    public bool? PerformancePlusEnabled { get; set; }

    /// <summary>Whether it is allowed to access the disk via public network. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to Encrypt this OS Disk when the Virtual Machine is a Confidential VM. Conflicts with disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureVmDiskEncryptionSetId")]
    public string? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>Security Type of the Managed Disk when it is used for a Confidential VM. Possible values are ConfidentialVM_VMGuestStateOnlyEncryptedWithPlatformKey, ConfidentialVM_DiskEncryptedWithPlatformKey and ConfidentialVM_DiskEncryptedWithCustomerKey. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityType")]
    public string? SecurityType { get; set; }

    /// <summary>The ID of an existing Managed Disk or Snapshot to copy when create_option is Copy or the recovery point to restore when create_option is Restore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }

    /// <summary>Reference to a ManagedDisk in compute to populate sourceResourceId.</summary>
    [JsonPropertyName("sourceResourceIdRef")]
    public V1beta2ManagedDiskSpecInitProviderSourceResourceIdRef? SourceResourceIdRef { get; set; }

    /// <summary>Selector for a ManagedDisk in compute to populate sourceResourceId.</summary>
    [JsonPropertyName("sourceResourceIdSelector")]
    public V1beta2ManagedDiskSpecInitProviderSourceResourceIdSelector? SourceResourceIdSelector { get; set; }

    /// <summary>URI to a valid VHD file to be used when create_option is Import or ImportSecure. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceUri")]
    public string? SourceUri { get; set; }

    /// <summary>The ID of the Storage Account where the source_uri is located. Required when create_option is set to Import or ImportSecure. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>The type of storage to use for the managed disk. Possible values are Standard_LRS, StandardSSD_ZRS, Premium_LRS, PremiumV2_LRS, Premium_ZRS, StandardSSD_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The disk performance tier to use. Possible values are documented here. This feature is currently supported only for premium SSDs.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>Specifies if Trusted Launch is enabled for the Managed Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("trustedLaunchEnabled")]
    public bool? TrustedLaunchEnabled { get; set; }

    /// <summary>Specifies the size of the managed disk to create in bytes. Required when create_option is Upload. The value must be equal to the source disk to be copied in bytes. Source disk size could be calculated with ls -l or wc -c. More information can be found at Copy a managed disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("uploadSizeBytes")]
    public double? UploadSizeBytes { get; set; }

    /// <summary>Specifies the Availability Zone in which this Managed Disk should be located. Changing this property forces a new resource to be created.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedDiskSpecManagementPoliciesEnum>))]
public enum V1beta2ManagedDiskSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedDiskSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ManagedDiskSpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ManagedDiskSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ManagedDiskSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ManagedDiskSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ManagedDiskSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ManagedDiskSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ManagedDiskSpec defines the desired state of ManagedDisk</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta2ManagedDiskSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ManagedDiskSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta2ManagedDiskSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta2ManagedDiskSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ManagedDiskSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ManagedDiskSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A disk_encryption_key block as defined above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskStatusAtProviderEncryptionSettingsDiskEncryptionKey
{
    /// <summary>The URL to the Key Vault Secret used as the Disk Encryption Key. This can be found as id on the azurerm_key_vault_secret resource.</summary>
    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>The ID of the source Key Vault. This can be found as id on the azurerm_key_vault resource.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>A key_encryption_key block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskStatusAtProviderEncryptionSettingsKeyEncryptionKey
{
    /// <summary>The URL to the Key Vault Key used as the Key Encryption Key. This can be found as id on the azurerm_key_vault_key resource.</summary>
    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>The ID of the source Key Vault. This can be found as id on the azurerm_key_vault resource.</summary>
    [JsonPropertyName("sourceVaultId")]
    public string? SourceVaultId { get; set; }
}

/// <summary>A encryption_settings block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskStatusAtProviderEncryptionSettings
{
    /// <summary>A disk_encryption_key block as defined above.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta2ManagedDiskStatusAtProviderEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>A key_encryption_key block as defined below.</summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1beta2ManagedDiskStatusAtProviderEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskStatusAtProvider
{
    /// <summary>The method to use when creating the managed disk. Changing this forces a new resource to be created. Possible values include: * Import - Import a VHD file in to the managed disk (VHD specified with source_uri). * ImportSecure - Securely import a VHD file in to the managed disk (VHD specified with source_uri). * Empty - Create an empty managed disk. * Copy - Copy an existing managed disk or snapshot (specified with source_resource_id). * FromImage - Copy a Platform Image (specified with image_reference_id) * Restore - Set by Azure Backup or Site Recovery on a restored disk (specified with source_resource_id). * Upload - Upload a VHD disk with the help of SAS URL (to be used with upload_size_bytes).</summary>
    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>The ID of the disk access resource for using private endpoints on disks.</summary>
    [JsonPropertyName("diskAccessId")]
    public string? DiskAccessId { get; set; }

    /// <summary>The ID of a Disk Encryption Set which should be used to encrypt this Managed Disk. Conflicts with secure_vm_disk_encryption_set_id.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>The number of IOPS allowed across all VMs mounting the shared disk as read-only; only settable for UltraSSD disks and PremiumV2 disks with shared disk enabled. One operation can transfer between 4k and 256k bytes.</summary>
    [JsonPropertyName("diskIopsReadOnly")]
    public double? DiskIopsReadOnly { get; set; }

    /// <summary>The number of IOPS allowed for this disk; only settable for UltraSSD disks and PremiumV2 disks. One operation can transfer between 4k and 256k bytes.</summary>
    [JsonPropertyName("diskIopsReadWrite")]
    public double? DiskIopsReadWrite { get; set; }

    /// <summary>The bandwidth allowed across all VMs mounting the shared disk as read-only; only settable for UltraSSD disks and PremiumV2 disks with shared disk enabled. MBps means millions of bytes per second.</summary>
    [JsonPropertyName("diskMbpsReadOnly")]
    public double? DiskMbpsReadOnly { get; set; }

    /// <summary>The bandwidth allowed for this disk; only settable for UltraSSD disks and PremiumV2 disks. MBps means millions of bytes per second.</summary>
    [JsonPropertyName("diskMbpsReadWrite")]
    public double? DiskMbpsReadWrite { get; set; }

    /// <summary>Specifies the size of the managed disk to create in gigabytes. If create_option is Copy or FromImage, then the value must be equal to or greater than the source&apos;s size. The size can only be increased.</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>Specifies the Edge Zone within the Azure Region where this Managed Disk should exist. Changing this forces a new Managed Disk to be created.</summary>
    [JsonPropertyName("edgeZone")]
    public string? EdgeZone { get; set; }

    /// <summary>A encryption_settings block as defined below.</summary>
    [JsonPropertyName("encryptionSettings")]
    public V1beta2ManagedDiskStatusAtProviderEncryptionSettings? EncryptionSettings { get; set; }

    /// <summary>ID of a Gallery Image Version to copy when create_option is FromImage. This field cannot be specified if image_reference_id is specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("galleryImageReferenceId")]
    public string? GalleryImageReferenceId { get; set; }

    /// <summary>The HyperV Generation of the Disk when the source of an Import or Copy operation targets a source that contains an operating system. Possible values are V1 and V2. For ImportSecure it must be set to V2. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>The ID of the Managed Disk.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ID of an existing platform/marketplace disk image to copy when create_option is FromImage. This field cannot be specified if gallery_image_reference_id is specified. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("imageReferenceId")]
    public string? ImageReferenceId { get; set; }

    /// <summary>Specified the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Logical Sector Size. Possible values are: 512 and 4096. Defaults to 4096. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("logicalSectorSize")]
    public double? LogicalSectorSize { get; set; }

    /// <summary>The maximum number of VMs that can attach to the disk at the same time. Value greater than one indicates a disk that can be mounted on multiple VMs at the same time.</summary>
    [JsonPropertyName("maxShares")]
    public double? MaxShares { get; set; }

    /// <summary>Policy for accessing the disk via network. Allowed values are AllowAll, AllowPrivate, and DenyAll. Defaults to AllowAll.</summary>
    [JsonPropertyName("networkAccessPolicy")]
    public string? NetworkAccessPolicy { get; set; }

    /// <summary>Specifies if On-Demand Bursting is enabled for the Managed Disk.</summary>
    [JsonPropertyName("onDemandBurstingEnabled")]
    public bool? OnDemandBurstingEnabled { get; set; }

    /// <summary>Specifies whether this Managed Disk should be optimized for frequent disk attachments (where a disk is attached/detached more than 5 times in a day). Defaults to false.</summary>
    [JsonPropertyName("optimizedFrequentAttachEnabled")]
    public bool? OptimizedFrequentAttachEnabled { get; set; }

    /// <summary>Specify a value when the source of an Import, ImportSecure or Copy operation targets a source that contains an operating system. Valid values are Linux or Windows.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>Specifies whether Performance Plus is enabled for this Managed Disk. Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("performancePlusEnabled")]
    public bool? PerformancePlusEnabled { get; set; }

    /// <summary>Whether it is allowed to access the disk via public network. Defaults to true.</summary>
    [JsonPropertyName("publicNetworkAccessEnabled")]
    public bool? PublicNetworkAccessEnabled { get; set; }

    /// <summary>The name of the Resource Group where the Managed Disk should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to Encrypt this OS Disk when the Virtual Machine is a Confidential VM. Conflicts with disk_encryption_set_id. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("secureVmDiskEncryptionSetId")]
    public string? SecureVmDiskEncryptionSetId { get; set; }

    /// <summary>Security Type of the Managed Disk when it is used for a Confidential VM. Possible values are ConfidentialVM_VMGuestStateOnlyEncryptedWithPlatformKey, ConfidentialVM_DiskEncryptedWithPlatformKey and ConfidentialVM_DiskEncryptedWithCustomerKey. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("securityType")]
    public string? SecurityType { get; set; }

    /// <summary>The ID of an existing Managed Disk or Snapshot to copy when create_option is Copy or the recovery point to restore when create_option is Restore. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }

    /// <summary>URI to a valid VHD file to be used when create_option is Import or ImportSecure. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sourceUri")]
    public string? SourceUri { get; set; }

    /// <summary>The ID of the Storage Account where the source_uri is located. Required when create_option is set to Import or ImportSecure. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    /// <summary>The type of storage to use for the managed disk. Possible values are Standard_LRS, StandardSSD_ZRS, Premium_LRS, PremiumV2_LRS, Premium_ZRS, StandardSSD_LRS or UltraSSD_LRS.</summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The disk performance tier to use. Possible values are documented here. This feature is currently supported only for premium SSDs.</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }

    /// <summary>Specifies if Trusted Launch is enabled for the Managed Disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("trustedLaunchEnabled")]
    public bool? TrustedLaunchEnabled { get; set; }

    /// <summary>Specifies the size of the managed disk to create in bytes. Required when create_option is Upload. The value must be equal to the source disk to be copied in bytes. Source disk size could be calculated with ls -l or wc -c. More information can be found at Copy a managed disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("uploadSizeBytes")]
    public double? UploadSizeBytes { get; set; }

    /// <summary>Specifies the Availability Zone in which this Managed Disk should be located. Changing this property forces a new resource to be created.</summary>
    [JsonPropertyName("zone")]
    public string? Zone { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ManagedDiskStatus defines the observed state of ManagedDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ManagedDiskStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ManagedDiskStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ManagedDiskStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ManagedDisk is the Schema for the ManagedDisks API. Manages a Managed Disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ManagedDisk : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ManagedDiskSpec>, IStatus<V1beta2ManagedDiskStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ManagedDisk";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "manageddisks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ManagedDisk";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ManagedDiskSpec defines the desired state of ManagedDisk</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ManagedDiskSpec Spec { get; set; }

    /// <summary>ManagedDiskStatus defines the observed state of ManagedDisk.</summary>
    [JsonPropertyName("status")]
    public V1beta2ManagedDiskStatus? Status { get; set; }
}