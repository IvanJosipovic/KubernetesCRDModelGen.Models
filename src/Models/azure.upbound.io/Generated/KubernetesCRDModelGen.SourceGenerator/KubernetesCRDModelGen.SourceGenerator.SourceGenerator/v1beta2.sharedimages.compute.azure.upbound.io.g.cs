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
/// <summary>SharedImage is the Schema for the SharedImages API. Manages a Shared Image within a Shared Image Gallery.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SharedImageList : IKubernetesObject<V1ListMeta>, IItems<V1beta2SharedImage>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SharedImageList";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "sharedimages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SharedImageList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2SharedImage objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2SharedImage> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SharedImageSpecDeletionPolicyEnum>))]
public enum V1beta2SharedImageSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SharedImageSpecForProviderGalleryNameRefPolicyResolutionEnum>))]
public enum V1beta2SharedImageSpecForProviderGalleryNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SharedImageSpecForProviderGalleryNameRefPolicyResolveEnum>))]
public enum V1beta2SharedImageSpecForProviderGalleryNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageSpecForProviderGalleryNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SharedImageSpecForProviderGalleryNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SharedImageSpecForProviderGalleryNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a SharedImageGallery in compute to populate galleryName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageSpecForProviderGalleryNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SharedImageSpecForProviderGalleryNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SharedImageSpecForProviderGalleryNameSelectorPolicyResolutionEnum>))]
public enum V1beta2SharedImageSpecForProviderGalleryNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SharedImageSpecForProviderGalleryNameSelectorPolicyResolveEnum>))]
public enum V1beta2SharedImageSpecForProviderGalleryNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageSpecForProviderGalleryNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SharedImageSpecForProviderGalleryNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SharedImageSpecForProviderGalleryNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a SharedImageGallery in compute to populate galleryName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageSpecForProviderGalleryNameSelector
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
    public V1beta2SharedImageSpecForProviderGalleryNameSelectorPolicy? Policy { get; set; }
}

/// <summary>An identifier block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageSpecForProviderIdentifier
{
    /// <summary>The Offer Name for this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>The Publisher Name for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>The Name of the SKU for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }
}

/// <summary>A purchase_plan block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageSpecForProviderPurchasePlan
{
    /// <summary>The Purchase Plan Name for this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Purchase Plan Product for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>The Purchase Plan Publisher for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SharedImageSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2SharedImageSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SharedImageSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta2SharedImageSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SharedImageSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SharedImageSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SharedImageSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SharedImageSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2SharedImageSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SharedImageSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2SharedImageSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SharedImageSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SharedImageSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageSpecForProviderResourceGroupNameSelector
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
    public V1beta2SharedImageSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageSpecForProvider
{
    /// <summary>Specifies if the Shared Image supports Accelerated Network. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("acceleratedNetworkSupportEnabled")]
    public bool? AcceleratedNetworkSupportEnabled { get; set; }

    /// <summary>CPU architecture supported by an OS. Possible values are x64 and Arm64. Defaults to x64. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>Specifies if Confidential Virtual Machines enabled. It will enable all the features of trusted, with higher confidentiality features for isolate machines or encrypted data. Available for Gen2 machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("confidentialVmEnabled")]
    public bool? ConfidentialVmEnabled { get; set; }

    /// <summary>Specifies if supports creation of both Confidential virtual machines and Gen2 virtual machines with standard security from a compatible Gen2 OS disk VHD or Gen2 Managed image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("confidentialVmSupported")]
    public bool? ConfidentialVmSupported { get; set; }

    /// <summary>A description of this Shared Image.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies if the Shared Image supports NVMe disks. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskControllerTypeNvmeEnabled")]
    public bool? DiskControllerTypeNvmeEnabled { get; set; }

    /// <summary>One or more Disk Types not allowed for the Image. Possible values include Standard_LRS and Premium_LRS.</summary>
    [JsonPropertyName("diskTypesNotAllowed")]
    public IList<string>? DiskTypesNotAllowed { get; set; }

    /// <summary>The end of life date in RFC3339 format of the Image.</summary>
    [JsonPropertyName("endOfLifeDate")]
    public string? EndOfLifeDate { get; set; }

    /// <summary>The End User Licence Agreement for the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eula")]
    public string? Eula { get; set; }

    /// <summary>Specifies the name of the Shared Image Gallery in which this Shared Image should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("galleryName")]
    public string? GalleryName { get; set; }

    /// <summary>Reference to a SharedImageGallery in compute to populate galleryName.</summary>
    [JsonPropertyName("galleryNameRef")]
    public V1beta2SharedImageSpecForProviderGalleryNameRef? GalleryNameRef { get; set; }

    /// <summary>Selector for a SharedImageGallery in compute to populate galleryName.</summary>
    [JsonPropertyName("galleryNameSelector")]
    public V1beta2SharedImageSpecForProviderGalleryNameSelector? GalleryNameSelector { get; set; }

    /// <summary>Specifies if the Shared Image supports hibernation. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hibernationEnabled")]
    public bool? HibernationEnabled { get; set; }

    /// <summary>The generation of HyperV that the Virtual Machine used to create the Shared Image is based on. Possible values are V1 and V2. Defaults to V1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>An identifier block as defined below.</summary>
    [JsonPropertyName("identifier")]
    public V1beta2SharedImageSpecForProviderIdentifier? Identifier { get; set; }

    /// <summary>Specifies the supported Azure location where the Shared Image Gallery exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Maximum memory in GB recommended for the Image.</summary>
    [JsonPropertyName("maxRecommendedMemoryInGb")]
    public double? MaxRecommendedMemoryInGb { get; set; }

    /// <summary>Maximum count of vCPUs recommended for the Image.</summary>
    [JsonPropertyName("maxRecommendedVcpuCount")]
    public double? MaxRecommendedVcpuCount { get; set; }

    /// <summary>Minimum memory in GB recommended for the Image.</summary>
    [JsonPropertyName("minRecommendedMemoryInGb")]
    public double? MinRecommendedMemoryInGb { get; set; }

    /// <summary>Minimum count of vCPUs recommended for the Image.</summary>
    [JsonPropertyName("minRecommendedVcpuCount")]
    public double? MinRecommendedVcpuCount { get; set; }

    /// <summary>The type of Operating System present in this Shared Image. Possible values are Linux and Windows. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>The URI containing the Privacy Statement associated with this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privacyStatementUri")]
    public string? PrivacyStatementUri { get; set; }

    /// <summary>A purchase_plan block as defined below.</summary>
    [JsonPropertyName("purchasePlan")]
    public V1beta2SharedImageSpecForProviderPurchasePlan? PurchasePlan { get; set; }

    /// <summary>The URI containing the Release Notes associated with this Shared Image.</summary>
    [JsonPropertyName("releaseNoteUri")]
    public string? ReleaseNoteUri { get; set; }

    /// <summary>The name of the resource group in which the Shared Image Gallery exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta2SharedImageSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta2SharedImageSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>Specifies that the Operating System used inside this Image has not been Generalized (for example, sysprep on Windows has not been run). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("specialized")]
    public bool? Specialized { get; set; }

    /// <summary>A mapping of tags to assign to the Shared Image.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies if Trusted Launch has to be enabled for the Virtual Machine created from the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("trustedLaunchEnabled")]
    public bool? TrustedLaunchEnabled { get; set; }

    /// <summary>Specifies if supports creation of both Trusted Launch virtual machines and Gen2 virtual machines with standard security created from the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("trustedLaunchSupported")]
    public bool? TrustedLaunchSupported { get; set; }
}

/// <summary>An identifier block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageSpecInitProviderIdentifier
{
    /// <summary>The Offer Name for this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>The Publisher Name for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>The Name of the SKU for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }
}

/// <summary>A purchase_plan block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageSpecInitProviderPurchasePlan
{
    /// <summary>The Purchase Plan Name for this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Purchase Plan Product for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>The Purchase Plan Publisher for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
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
public partial class V1beta2SharedImageSpecInitProvider
{
    /// <summary>Specifies if the Shared Image supports Accelerated Network. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("acceleratedNetworkSupportEnabled")]
    public bool? AcceleratedNetworkSupportEnabled { get; set; }

    /// <summary>CPU architecture supported by an OS. Possible values are x64 and Arm64. Defaults to x64. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>Specifies if Confidential Virtual Machines enabled. It will enable all the features of trusted, with higher confidentiality features for isolate machines or encrypted data. Available for Gen2 machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("confidentialVmEnabled")]
    public bool? ConfidentialVmEnabled { get; set; }

    /// <summary>Specifies if supports creation of both Confidential virtual machines and Gen2 virtual machines with standard security from a compatible Gen2 OS disk VHD or Gen2 Managed image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("confidentialVmSupported")]
    public bool? ConfidentialVmSupported { get; set; }

    /// <summary>A description of this Shared Image.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies if the Shared Image supports NVMe disks. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskControllerTypeNvmeEnabled")]
    public bool? DiskControllerTypeNvmeEnabled { get; set; }

    /// <summary>One or more Disk Types not allowed for the Image. Possible values include Standard_LRS and Premium_LRS.</summary>
    [JsonPropertyName("diskTypesNotAllowed")]
    public IList<string>? DiskTypesNotAllowed { get; set; }

    /// <summary>The end of life date in RFC3339 format of the Image.</summary>
    [JsonPropertyName("endOfLifeDate")]
    public string? EndOfLifeDate { get; set; }

    /// <summary>The End User Licence Agreement for the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eula")]
    public string? Eula { get; set; }

    /// <summary>Specifies if the Shared Image supports hibernation. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hibernationEnabled")]
    public bool? HibernationEnabled { get; set; }

    /// <summary>The generation of HyperV that the Virtual Machine used to create the Shared Image is based on. Possible values are V1 and V2. Defaults to V1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>An identifier block as defined below.</summary>
    [JsonPropertyName("identifier")]
    public V1beta2SharedImageSpecInitProviderIdentifier? Identifier { get; set; }

    /// <summary>Specifies the supported Azure location where the Shared Image Gallery exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Maximum memory in GB recommended for the Image.</summary>
    [JsonPropertyName("maxRecommendedMemoryInGb")]
    public double? MaxRecommendedMemoryInGb { get; set; }

    /// <summary>Maximum count of vCPUs recommended for the Image.</summary>
    [JsonPropertyName("maxRecommendedVcpuCount")]
    public double? MaxRecommendedVcpuCount { get; set; }

    /// <summary>Minimum memory in GB recommended for the Image.</summary>
    [JsonPropertyName("minRecommendedMemoryInGb")]
    public double? MinRecommendedMemoryInGb { get; set; }

    /// <summary>Minimum count of vCPUs recommended for the Image.</summary>
    [JsonPropertyName("minRecommendedVcpuCount")]
    public double? MinRecommendedVcpuCount { get; set; }

    /// <summary>The type of Operating System present in this Shared Image. Possible values are Linux and Windows. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>The URI containing the Privacy Statement associated with this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privacyStatementUri")]
    public string? PrivacyStatementUri { get; set; }

    /// <summary>A purchase_plan block as defined below.</summary>
    [JsonPropertyName("purchasePlan")]
    public V1beta2SharedImageSpecInitProviderPurchasePlan? PurchasePlan { get; set; }

    /// <summary>The URI containing the Release Notes associated with this Shared Image.</summary>
    [JsonPropertyName("releaseNoteUri")]
    public string? ReleaseNoteUri { get; set; }

    /// <summary>Specifies that the Operating System used inside this Image has not been Generalized (for example, sysprep on Windows has not been run). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("specialized")]
    public bool? Specialized { get; set; }

    /// <summary>A mapping of tags to assign to the Shared Image.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies if Trusted Launch has to be enabled for the Virtual Machine created from the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("trustedLaunchEnabled")]
    public bool? TrustedLaunchEnabled { get; set; }

    /// <summary>Specifies if supports creation of both Trusted Launch virtual machines and Gen2 virtual machines with standard security created from the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("trustedLaunchSupported")]
    public bool? TrustedLaunchSupported { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SharedImageSpecManagementPoliciesEnum>))]
public enum V1beta2SharedImageSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SharedImageSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2SharedImageSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SharedImageSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2SharedImageSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SharedImageSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SharedImageSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SharedImageSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SharedImageSpec defines the desired state of SharedImage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageSpec
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
    public V1beta2SharedImageSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2SharedImageSpecForProvider ForProvider { get; set; }

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
    public V1beta2SharedImageSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2SharedImageSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2SharedImageSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2SharedImageSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An identifier block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageStatusAtProviderIdentifier
{
    /// <summary>The Offer Name for this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("offer")]
    public string? Offer { get; set; }

    /// <summary>The Publisher Name for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }

    /// <summary>The Name of the SKU for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("sku")]
    public string? Sku { get; set; }
}

/// <summary>A purchase_plan block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageStatusAtProviderPurchasePlan
{
    /// <summary>The Purchase Plan Name for this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The Purchase Plan Product for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("product")]
    public string? Product { get; set; }

    /// <summary>The Purchase Plan Publisher for this Gallery Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageStatusAtProvider
{
    /// <summary>Specifies if the Shared Image supports Accelerated Network. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("acceleratedNetworkSupportEnabled")]
    public bool? AcceleratedNetworkSupportEnabled { get; set; }

    /// <summary>CPU architecture supported by an OS. Possible values are x64 and Arm64. Defaults to x64. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>Specifies if Confidential Virtual Machines enabled. It will enable all the features of trusted, with higher confidentiality features for isolate machines or encrypted data. Available for Gen2 machines. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("confidentialVmEnabled")]
    public bool? ConfidentialVmEnabled { get; set; }

    /// <summary>Specifies if supports creation of both Confidential virtual machines and Gen2 virtual machines with standard security from a compatible Gen2 OS disk VHD or Gen2 Managed image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("confidentialVmSupported")]
    public bool? ConfidentialVmSupported { get; set; }

    /// <summary>A description of this Shared Image.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Specifies if the Shared Image supports NVMe disks. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("diskControllerTypeNvmeEnabled")]
    public bool? DiskControllerTypeNvmeEnabled { get; set; }

    /// <summary>One or more Disk Types not allowed for the Image. Possible values include Standard_LRS and Premium_LRS.</summary>
    [JsonPropertyName("diskTypesNotAllowed")]
    public IList<string>? DiskTypesNotAllowed { get; set; }

    /// <summary>The end of life date in RFC3339 format of the Image.</summary>
    [JsonPropertyName("endOfLifeDate")]
    public string? EndOfLifeDate { get; set; }

    /// <summary>The End User Licence Agreement for the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eula")]
    public string? Eula { get; set; }

    /// <summary>Specifies the name of the Shared Image Gallery in which this Shared Image should exist. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("galleryName")]
    public string? GalleryName { get; set; }

    /// <summary>Specifies if the Shared Image supports hibernation. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hibernationEnabled")]
    public bool? HibernationEnabled { get; set; }

    /// <summary>The generation of HyperV that the Virtual Machine used to create the Shared Image is based on. Possible values are V1 and V2. Defaults to V1. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>The ID of the Shared Image.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>An identifier block as defined below.</summary>
    [JsonPropertyName("identifier")]
    public V1beta2SharedImageStatusAtProviderIdentifier? Identifier { get; set; }

    /// <summary>Specifies the supported Azure location where the Shared Image Gallery exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Maximum memory in GB recommended for the Image.</summary>
    [JsonPropertyName("maxRecommendedMemoryInGb")]
    public double? MaxRecommendedMemoryInGb { get; set; }

    /// <summary>Maximum count of vCPUs recommended for the Image.</summary>
    [JsonPropertyName("maxRecommendedVcpuCount")]
    public double? MaxRecommendedVcpuCount { get; set; }

    /// <summary>Minimum memory in GB recommended for the Image.</summary>
    [JsonPropertyName("minRecommendedMemoryInGb")]
    public double? MinRecommendedMemoryInGb { get; set; }

    /// <summary>Minimum count of vCPUs recommended for the Image.</summary>
    [JsonPropertyName("minRecommendedVcpuCount")]
    public double? MinRecommendedVcpuCount { get; set; }

    /// <summary>The type of Operating System present in this Shared Image. Possible values are Linux and Windows. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>The URI containing the Privacy Statement associated with this Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("privacyStatementUri")]
    public string? PrivacyStatementUri { get; set; }

    /// <summary>A purchase_plan block as defined below.</summary>
    [JsonPropertyName("purchasePlan")]
    public V1beta2SharedImageStatusAtProviderPurchasePlan? PurchasePlan { get; set; }

    /// <summary>The URI containing the Release Notes associated with this Shared Image.</summary>
    [JsonPropertyName("releaseNoteUri")]
    public string? ReleaseNoteUri { get; set; }

    /// <summary>The name of the resource group in which the Shared Image Gallery exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Specifies that the Operating System used inside this Image has not been Generalized (for example, sysprep on Windows has not been run). Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("specialized")]
    public bool? Specialized { get; set; }

    /// <summary>A mapping of tags to assign to the Shared Image.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies if Trusted Launch has to be enabled for the Virtual Machine created from the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("trustedLaunchEnabled")]
    public bool? TrustedLaunchEnabled { get; set; }

    /// <summary>Specifies if supports creation of both Trusted Launch virtual machines and Gen2 virtual machines with standard security created from the Shared Image. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("trustedLaunchSupported")]
    public bool? TrustedLaunchSupported { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageStatusConditions
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

/// <summary>SharedImageStatus defines the observed state of SharedImage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SharedImageStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2SharedImageStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2SharedImageStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SharedImage is the Schema for the SharedImages API. Manages a Shared Image within a Shared Image Gallery.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SharedImage : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2SharedImageSpec>, IStatus<V1beta2SharedImageStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SharedImage";
    public const string KubeGroup = "compute.azure.upbound.io";
    public const string KubePluralName = "sharedimages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SharedImage";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SharedImageSpec defines the desired state of SharedImage</summary>
    [JsonPropertyName("spec")]
    public required V1beta2SharedImageSpec Spec { get; set; }

    /// <summary>SharedImageStatus defines the observed state of SharedImage.</summary>
    [JsonPropertyName("status")]
    public V1beta2SharedImageStatus? Status { get; set; }
}