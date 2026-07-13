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
/// <summary>Image is the Schema for the Images API. Manages a custom virtual machine image that can be used to create virtual machines.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ImageList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Image>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ImageList";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "images";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ImageList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Image objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Image> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageSpecDeletionPolicyEnum>))]
public enum V1beta2ImageSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderDataDisk
{
    /// <summary>Specifies the URI in Azure storage of the blob that you want to use to create the image.</summary>
    [JsonPropertyName("blobUri")]
    public string? BlobUri { get; set; }

    /// <summary>Specifies the caching mode as ReadWrite, ReadOnly, or None. Defaults to None.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>Specifies the logical unit number of the data disk.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>Specifies the ID of the managed disk resource that you want to use to create the image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedDiskId")]
    public string? ManagedDiskId { get; set; }

    /// <summary>Specifies the size of the image to be created. The target size can&apos;t be smaller than the source size.</summary>
    [JsonPropertyName("sizeGb")]
    public double? SizeGb { get; set; }

    /// <summary>
    /// The type of Storage Disk to use. Possible values are Premium_LRS, PremiumV2_LRS, Premium_ZRS, Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS and UltraSSD_LRS. Changing this forces a new resource to be created.
    /// The type of storage disk
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary>One or more os_disk blocks as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderOsDisk
{
    /// <summary>Specifies the URI in Azure storage of the blob that you want to use to create the image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("blobUri")]
    public string? BlobUri { get; set; }

    /// <summary>Specifies the caching mode as ReadWrite, ReadOnly, or None. The default is None.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>Specifies the ID of the managed disk resource that you want to use to create the image.</summary>
    [JsonPropertyName("managedDiskId")]
    public string? ManagedDiskId { get; set; }

    /// <summary>Specifies the state of the operating system contained in the blob. Currently, the only value is Generalized. Possible values are Generalized and Specialized.</summary>
    [JsonPropertyName("osState")]
    public string? OsState { get; set; }

    /// <summary>Specifies the type of operating system contained in the virtual machine image. Possible values are: Windows or Linux.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>Specifies the size of the image to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sizeGb")]
    public double? SizeGb { get; set; }

    /// <summary>
    /// The type of Storage Disk to use. Possible values are Premium_LRS, PremiumV2_LRS, Premium_ZRS, Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS and UltraSSD_LRS. Changing this forces a new resource to be created.
    /// The type of storage disk
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2ImageSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2ImageSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImageSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImageSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ImageSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2ImageSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2ImageSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImageSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImageSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderResourceGroupNameSelector
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
    public V1beta2ImageSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProvider
{
    /// <summary>One or more data_disk blocks as defined below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta2ImageSpecForProviderDataDisk>? DataDisk { get; set; }

    /// <summary>The Hyper-V Generation Type of the Virtual Machine created from the image as V1, V2. Defaults to V1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>Specified the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more os_disk blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osDisk")]
    public V1beta2ImageSpecForProviderOsDisk? OsDisk { get; set; }

    /// <summary>The name of the resource group in which to create the image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2ImageSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2ImageSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>The Virtual Machine ID from which to create the image.</summary>
    [JsonPropertyName("sourceVirtualMachineId")]
    public string? SourceVirtualMachineId { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Is zone resiliency enabled? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneResilient")]
    public bool? ZoneResilient { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderDataDisk
{
    /// <summary>Specifies the URI in Azure storage of the blob that you want to use to create the image.</summary>
    [JsonPropertyName("blobUri")]
    public string? BlobUri { get; set; }

    /// <summary>Specifies the caching mode as ReadWrite, ReadOnly, or None. Defaults to None.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>Specifies the logical unit number of the data disk.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>Specifies the ID of the managed disk resource that you want to use to create the image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedDiskId")]
    public string? ManagedDiskId { get; set; }

    /// <summary>Specifies the size of the image to be created. The target size can&apos;t be smaller than the source size.</summary>
    [JsonPropertyName("sizeGb")]
    public double? SizeGb { get; set; }

    /// <summary>
    /// The type of Storage Disk to use. Possible values are Premium_LRS, PremiumV2_LRS, Premium_ZRS, Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS and UltraSSD_LRS. Changing this forces a new resource to be created.
    /// The type of storage disk
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary>One or more os_disk blocks as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderOsDisk
{
    /// <summary>Specifies the URI in Azure storage of the blob that you want to use to create the image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("blobUri")]
    public string? BlobUri { get; set; }

    /// <summary>Specifies the caching mode as ReadWrite, ReadOnly, or None. The default is None.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>Specifies the ID of the managed disk resource that you want to use to create the image.</summary>
    [JsonPropertyName("managedDiskId")]
    public string? ManagedDiskId { get; set; }

    /// <summary>Specifies the state of the operating system contained in the blob. Currently, the only value is Generalized. Possible values are Generalized and Specialized.</summary>
    [JsonPropertyName("osState")]
    public string? OsState { get; set; }

    /// <summary>Specifies the type of operating system contained in the virtual machine image. Possible values are: Windows or Linux.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>Specifies the size of the image to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sizeGb")]
    public double? SizeGb { get; set; }

    /// <summary>
    /// The type of Storage Disk to use. Possible values are Premium_LRS, PremiumV2_LRS, Premium_ZRS, Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS and UltraSSD_LRS. Changing this forces a new resource to be created.
    /// The type of storage disk
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
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
public partial class V1beta2ImageSpecInitProvider
{
    /// <summary>One or more data_disk blocks as defined below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta2ImageSpecInitProviderDataDisk>? DataDisk { get; set; }

    /// <summary>The Hyper-V Generation Type of the Virtual Machine created from the image as V1, V2. Defaults to V1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>Specified the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more os_disk blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osDisk")]
    public V1beta2ImageSpecInitProviderOsDisk? OsDisk { get; set; }

    /// <summary>The Virtual Machine ID from which to create the image.</summary>
    [JsonPropertyName("sourceVirtualMachineId")]
    public string? SourceVirtualMachineId { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Is zone resiliency enabled? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneResilient")]
    public bool? ZoneResilient { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageSpecManagementPoliciesEnum>))]
public enum V1beta2ImageSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ImageSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ImageSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImageSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImageSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ImageSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ImageSpec defines the desired state of Image</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpec
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
    public V1beta2ImageSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ImageSpecForProvider ForProvider { get; set; }

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
    public V1beta2ImageSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ImageSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ImageSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ImageSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageStatusAtProviderDataDisk
{
    /// <summary>Specifies the URI in Azure storage of the blob that you want to use to create the image.</summary>
    [JsonPropertyName("blobUri")]
    public string? BlobUri { get; set; }

    /// <summary>Specifies the caching mode as ReadWrite, ReadOnly, or None. Defaults to None.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>Specifies the logical unit number of the data disk.</summary>
    [JsonPropertyName("lun")]
    public double? Lun { get; set; }

    /// <summary>Specifies the ID of the managed disk resource that you want to use to create the image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("managedDiskId")]
    public string? ManagedDiskId { get; set; }

    /// <summary>Specifies the size of the image to be created. The target size can&apos;t be smaller than the source size.</summary>
    [JsonPropertyName("sizeGb")]
    public double? SizeGb { get; set; }

    /// <summary>
    /// The type of Storage Disk to use. Possible values are Premium_LRS, PremiumV2_LRS, Premium_ZRS, Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS and UltraSSD_LRS. Changing this forces a new resource to be created.
    /// The type of storage disk
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary>One or more os_disk blocks as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageStatusAtProviderOsDisk
{
    /// <summary>Specifies the URI in Azure storage of the blob that you want to use to create the image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("blobUri")]
    public string? BlobUri { get; set; }

    /// <summary>Specifies the caching mode as ReadWrite, ReadOnly, or None. The default is None.</summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>The ID of the Disk Encryption Set which should be used to encrypt this disk. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    /// <summary>Specifies the ID of the managed disk resource that you want to use to create the image.</summary>
    [JsonPropertyName("managedDiskId")]
    public string? ManagedDiskId { get; set; }

    /// <summary>Specifies the state of the operating system contained in the blob. Currently, the only value is Generalized. Possible values are Generalized and Specialized.</summary>
    [JsonPropertyName("osState")]
    public string? OsState { get; set; }

    /// <summary>Specifies the type of operating system contained in the virtual machine image. Possible values are: Windows or Linux.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>Specifies the size of the image to be created. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sizeGb")]
    public double? SizeGb { get; set; }

    /// <summary>
    /// The type of Storage Disk to use. Possible values are Premium_LRS, PremiumV2_LRS, Premium_ZRS, Standard_LRS, StandardSSD_LRS, StandardSSD_ZRS and UltraSSD_LRS. Changing this forces a new resource to be created.
    /// The type of storage disk
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageStatusAtProvider
{
    /// <summary>One or more data_disk blocks as defined below.</summary>
    [JsonPropertyName("dataDisk")]
    public IList<V1beta2ImageStatusAtProviderDataDisk>? DataDisk { get; set; }

    /// <summary>The Hyper-V Generation Type of the Virtual Machine created from the image as V1, V2. Defaults to V1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>The ID of the Image.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specified the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>One or more os_disk blocks as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osDisk")]
    public V1beta2ImageStatusAtProviderOsDisk? OsDisk { get; set; }

    /// <summary>The name of the resource group in which to create the image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>The Virtual Machine ID from which to create the image.</summary>
    [JsonPropertyName("sourceVirtualMachineId")]
    public string? SourceVirtualMachineId { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Is zone resiliency enabled? Defaults to false. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("zoneResilient")]
    public bool? ZoneResilient { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageStatusConditions
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

/// <summary>ImageStatus defines the observed state of Image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ImageStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ImageStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Image is the Schema for the Images API. Manages a custom virtual machine image that can be used to create virtual machines.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Image : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ImageSpec>, IStatus<V1beta2ImageStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Image";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "images";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Image";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ImageSpec defines the desired state of Image</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ImageSpec Spec { get; set; }

    /// <summary>ImageStatus defines the observed state of Image.</summary>
    [JsonPropertyName("status")]
    public V1beta2ImageStatus? Status { get; set; }
}