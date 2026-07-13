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
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/image.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220301ImageList : IKubernetesObject<V1ListMeta>, IItems<V20220301Image>
{
    public const string KubeApiVersion = "v20220301";
    public const string KubeKind = "ImageList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "images";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v20220301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ImageList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20220301Image objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20220301Image> Items { get; set; }
}

/// <summary>Type: The type of the extended location.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301ImageSpecExtendedLocationTypeEnum>))]
public enum V20220301ImageSpecExtendedLocationTypeEnum
{
    [EnumMember(Value = "EdgeZone"), JsonStringEnumMemberName("EdgeZone")]
    EdgeZone
}

/// <summary>ExtendedLocation: The extended location of the Image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public V20220301ImageSpecExtendedLocationTypeEnum? Type { get; set; }
}

/// <summary>
/// HyperVGeneration: Specifies the HyperVGenerationType of the VirtualMachine created from the image. From API Version
/// 2019-03-01 if the image source is a blob, then we need the user to specify the value, if the source is managed resource
/// like disk or snapshot, we may require the user to specify the property if we cannot deduce it from the source managed
/// resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301ImageSpecHyperVGenerationEnum>))]
public enum V20220301ImageSpecHyperVGenerationEnum
{
    [EnumMember(Value = "V1"), JsonStringEnumMemberName("V1")]
    V1,
    [EnumMember(Value = "V2"), JsonStringEnumMemberName("V2")]
    V2
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecOperatorSpecConfigMapExpressions
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
public partial class V20220301ImageSpecOperatorSpecSecretExpressions
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
public partial class V20220301ImageSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20220301ImageSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20220301ImageSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecSourceVirtualMachineReference
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

/// <summary>SourceVirtualMachine: The source virtual machine from which Image is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecSourceVirtualMachine
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301ImageSpecSourceVirtualMachineReference? Reference { get; set; }
}

/// <summary>
/// Caching: Specifies the caching requirements.
/// Possible values are:
/// None
/// ReadOnly
/// ReadWrite
/// Default: None for Standard storage. ReadOnly for Premium storage
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301ImageSpecStorageProfileDataDisksCachingEnum>))]
public enum V20220301ImageSpecStorageProfileDataDisksCachingEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "ReadOnly"), JsonStringEnumMemberName("ReadOnly")]
    ReadOnly,
    [EnumMember(Value = "ReadWrite"), JsonStringEnumMemberName("ReadWrite")]
    ReadWrite
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecStorageProfileDataDisksDiskEncryptionSetReference
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

/// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed image disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecStorageProfileDataDisksDiskEncryptionSet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301ImageSpecStorageProfileDataDisksDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecStorageProfileDataDisksManagedDiskReference
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

/// <summary>ManagedDisk: The managedDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecStorageProfileDataDisksManagedDisk
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301ImageSpecStorageProfileDataDisksManagedDiskReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecStorageProfileDataDisksSnapshotReference
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

/// <summary>Snapshot: The snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecStorageProfileDataDisksSnapshot
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301ImageSpecStorageProfileDataDisksSnapshotReference? Reference { get; set; }
}

/// <summary>
/// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
/// data disks, it cannot be used with OS Disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301ImageSpecStorageProfileDataDisksStorageAccountTypeEnum>))]
public enum V20220301ImageSpecStorageProfileDataDisksStorageAccountTypeEnum
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

/// <summary>Describes a data disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecStorageProfileDataDisks
{
    /// <summary>BlobUri: The Virtual Hard Disk.</summary>
    [JsonPropertyName("blobUri")]
    public string? BlobUri { get; set; }

    /// <summary>
    /// Caching: Specifies the caching requirements.
    /// Possible values are:
    /// None
    /// ReadOnly
    /// ReadWrite
    /// Default: None for Standard storage. ReadOnly for Premium storage
    /// </summary>
    [JsonPropertyName("caching")]
    public V20220301ImageSpecStorageProfileDataDisksCachingEnum? Caching { get; set; }

    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed image disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20220301ImageSpecStorageProfileDataDisksDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>
    /// DiskSizeGB: Specifies the size of empty data disks in gigabytes. This element can be used to overwrite the name of the
    /// disk in a virtual machine image.
    /// This value cannot be larger than 1023 GB
    /// </summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>
    /// Lun: Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and
    /// therefore must be unique for each data disk attached to a VM.
    /// </summary>
    [JsonPropertyName("lun")]
    public required int Lun { get; set; }

    /// <summary>ManagedDisk: The managedDisk.</summary>
    [JsonPropertyName("managedDisk")]
    public V20220301ImageSpecStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

    /// <summary>Snapshot: The snapshot.</summary>
    [JsonPropertyName("snapshot")]
    public V20220301ImageSpecStorageProfileDataDisksSnapshot? Snapshot { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
    /// data disks, it cannot be used with OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public V20220301ImageSpecStorageProfileDataDisksStorageAccountTypeEnum? StorageAccountType { get; set; }
}

/// <summary>
/// Caching: Specifies the caching requirements.
/// Possible values are:
/// None
/// ReadOnly
/// ReadWrite
/// Default: None for Standard storage. ReadOnly for Premium storage
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301ImageSpecStorageProfileOsDiskCachingEnum>))]
public enum V20220301ImageSpecStorageProfileOsDiskCachingEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "ReadOnly"), JsonStringEnumMemberName("ReadOnly")]
    ReadOnly,
    [EnumMember(Value = "ReadWrite"), JsonStringEnumMemberName("ReadWrite")]
    ReadWrite
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecStorageProfileOsDiskDiskEncryptionSetReference
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

/// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed image disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecStorageProfileOsDiskDiskEncryptionSet
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301ImageSpecStorageProfileOsDiskDiskEncryptionSetReference? Reference { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecStorageProfileOsDiskManagedDiskReference
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

/// <summary>ManagedDisk: The managedDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecStorageProfileOsDiskManagedDisk
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301ImageSpecStorageProfileOsDiskManagedDiskReference? Reference { get; set; }
}

/// <summary>OsState: The OS State. For managed images, use Generalized.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301ImageSpecStorageProfileOsDiskOsStateEnum>))]
public enum V20220301ImageSpecStorageProfileOsDiskOsStateEnum
{
    [EnumMember(Value = "Generalized"), JsonStringEnumMemberName("Generalized")]
    Generalized,
    [EnumMember(Value = "Specialized"), JsonStringEnumMemberName("Specialized")]
    Specialized
}

/// <summary>
/// OsType: This property allows you to specify the type of the OS that is included in the disk if creating a VM from a
/// custom image.
/// Possible values are:
/// Windows
/// Linux
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301ImageSpecStorageProfileOsDiskOsTypeEnum>))]
public enum V20220301ImageSpecStorageProfileOsDiskOsTypeEnum
{
    [EnumMember(Value = "Linux"), JsonStringEnumMemberName("Linux")]
    Linux,
    [EnumMember(Value = "Windows"), JsonStringEnumMemberName("Windows")]
    Windows
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecStorageProfileOsDiskSnapshotReference
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

/// <summary>Snapshot: The snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecStorageProfileOsDiskSnapshot
{
    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V20220301ImageSpecStorageProfileOsDiskSnapshotReference? Reference { get; set; }
}

/// <summary>
/// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
/// data disks, it cannot be used with OS Disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20220301ImageSpecStorageProfileOsDiskStorageAccountTypeEnum>))]
public enum V20220301ImageSpecStorageProfileOsDiskStorageAccountTypeEnum
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
/// OsDisk: Specifies information about the operating system disk used by the virtual machine.
/// For more information about disks, see [About disks and VHDs for Azure virtual
/// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecStorageProfileOsDisk
{
    /// <summary>BlobUri: The Virtual Hard Disk.</summary>
    [JsonPropertyName("blobUri")]
    public string? BlobUri { get; set; }

    /// <summary>
    /// Caching: Specifies the caching requirements.
    /// Possible values are:
    /// None
    /// ReadOnly
    /// ReadWrite
    /// Default: None for Standard storage. ReadOnly for Premium storage
    /// </summary>
    [JsonPropertyName("caching")]
    public V20220301ImageSpecStorageProfileOsDiskCachingEnum? Caching { get; set; }

    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed image disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20220301ImageSpecStorageProfileOsDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>
    /// DiskSizeGB: Specifies the size of empty data disks in gigabytes. This element can be used to overwrite the name of the
    /// disk in a virtual machine image.
    /// This value cannot be larger than 1023 GB
    /// </summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>ManagedDisk: The managedDisk.</summary>
    [JsonPropertyName("managedDisk")]
    public V20220301ImageSpecStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

    /// <summary>OsState: The OS State. For managed images, use Generalized.</summary>
    [JsonPropertyName("osState")]
    public required V20220301ImageSpecStorageProfileOsDiskOsStateEnum OsState { get; set; }

    /// <summary>
    /// OsType: This property allows you to specify the type of the OS that is included in the disk if creating a VM from a
    /// custom image.
    /// Possible values are:
    /// Windows
    /// Linux
    /// </summary>
    [JsonPropertyName("osType")]
    public required V20220301ImageSpecStorageProfileOsDiskOsTypeEnum OsType { get; set; }

    /// <summary>Snapshot: The snapshot.</summary>
    [JsonPropertyName("snapshot")]
    public V20220301ImageSpecStorageProfileOsDiskSnapshot? Snapshot { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
    /// data disks, it cannot be used with OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public V20220301ImageSpecStorageProfileOsDiskStorageAccountTypeEnum? StorageAccountType { get; set; }
}

/// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpecStorageProfile
{
    /// <summary>
    /// DataDisks: Specifies the parameters that are used to add a data disk to a virtual machine.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
    /// </summary>
    [JsonPropertyName("dataDisks")]
    public IList<V20220301ImageSpecStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>
    /// OsDisk: Specifies information about the operating system disk used by the virtual machine.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
    /// </summary>
    [JsonPropertyName("osDisk")]
    public V20220301ImageSpecStorageProfileOsDisk? OsDisk { get; set; }

    /// <summary>
    /// ZoneResilient: Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be
    /// created only in regions that provide Zone Redundant Storage (ZRS).
    /// </summary>
    [JsonPropertyName("zoneResilient")]
    public bool? ZoneResilient { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>ExtendedLocation: The extended location of the Image.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20220301ImageSpecExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// HyperVGeneration: Specifies the HyperVGenerationType of the VirtualMachine created from the image. From API Version
    /// 2019-03-01 if the image source is a blob, then we need the user to specify the value, if the source is managed resource
    /// like disk or snapshot, we may require the user to specify the property if we cannot deduce it from the source managed
    /// resource.
    /// </summary>
    [JsonPropertyName("hyperVGeneration")]
    public V20220301ImageSpecHyperVGenerationEnum? HyperVGeneration { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20220301ImageSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20220301ImageSpecOwner Owner { get; set; }

    /// <summary>SourceVirtualMachine: The source virtual machine from which Image is created.</summary>
    [JsonPropertyName("sourceVirtualMachine")]
    public V20220301ImageSpecSourceVirtualMachine? SourceVirtualMachine { get; set; }

    /// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
    [JsonPropertyName("storageProfile")]
    public V20220301ImageSpecStorageProfile? StorageProfile { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageStatusConditions
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

/// <summary>ExtendedLocation: The extended location of the Image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageStatusExtendedLocation
{
    /// <summary>Name: The name of the extended location.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type: The type of the extended location.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>SourceVirtualMachine: The source virtual machine from which Image is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageStatusSourceVirtualMachine
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed image disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageStatusStorageProfileDataDisksDiskEncryptionSet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ManagedDisk: The managedDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageStatusStorageProfileDataDisksManagedDisk
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Snapshot: The snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageStatusStorageProfileDataDisksSnapshot
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Describes a data disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageStatusStorageProfileDataDisks
{
    /// <summary>BlobUri: The Virtual Hard Disk.</summary>
    [JsonPropertyName("blobUri")]
    public string? BlobUri { get; set; }

    /// <summary>
    /// Caching: Specifies the caching requirements.
    /// Possible values are:
    /// None
    /// ReadOnly
    /// ReadWrite
    /// Default: None for Standard storage. ReadOnly for Premium storage
    /// </summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed image disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20220301ImageStatusStorageProfileDataDisksDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>
    /// DiskSizeGB: Specifies the size of empty data disks in gigabytes. This element can be used to overwrite the name of the
    /// disk in a virtual machine image.
    /// This value cannot be larger than 1023 GB
    /// </summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>
    /// Lun: Specifies the logical unit number of the data disk. This value is used to identify data disks within the VM and
    /// therefore must be unique for each data disk attached to a VM.
    /// </summary>
    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>ManagedDisk: The managedDisk.</summary>
    [JsonPropertyName("managedDisk")]
    public V20220301ImageStatusStorageProfileDataDisksManagedDisk? ManagedDisk { get; set; }

    /// <summary>Snapshot: The snapshot.</summary>
    [JsonPropertyName("snapshot")]
    public V20220301ImageStatusStorageProfileDataDisksSnapshot? Snapshot { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
    /// data disks, it cannot be used with OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed image disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageStatusStorageProfileOsDiskDiskEncryptionSet
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>ManagedDisk: The managedDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageStatusStorageProfileOsDiskManagedDisk
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>Snapshot: The snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageStatusStorageProfileOsDiskSnapshot
{
    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

/// <summary>
/// OsDisk: Specifies information about the operating system disk used by the virtual machine.
/// For more information about disks, see [About disks and VHDs for Azure virtual
/// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageStatusStorageProfileOsDisk
{
    /// <summary>BlobUri: The Virtual Hard Disk.</summary>
    [JsonPropertyName("blobUri")]
    public string? BlobUri { get; set; }

    /// <summary>
    /// Caching: Specifies the caching requirements.
    /// Possible values are:
    /// None
    /// ReadOnly
    /// ReadWrite
    /// Default: None for Standard storage. ReadOnly for Premium storage
    /// </summary>
    [JsonPropertyName("caching")]
    public string? Caching { get; set; }

    /// <summary>DiskEncryptionSet: Specifies the customer managed disk encryption set resource id for the managed image disk.</summary>
    [JsonPropertyName("diskEncryptionSet")]
    public V20220301ImageStatusStorageProfileOsDiskDiskEncryptionSet? DiskEncryptionSet { get; set; }

    /// <summary>
    /// DiskSizeGB: Specifies the size of empty data disks in gigabytes. This element can be used to overwrite the name of the
    /// disk in a virtual machine image.
    /// This value cannot be larger than 1023 GB
    /// </summary>
    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>ManagedDisk: The managedDisk.</summary>
    [JsonPropertyName("managedDisk")]
    public V20220301ImageStatusStorageProfileOsDiskManagedDisk? ManagedDisk { get; set; }

    /// <summary>OsState: The OS State. For managed images, use Generalized.</summary>
    [JsonPropertyName("osState")]
    public string? OsState { get; set; }

    /// <summary>
    /// OsType: This property allows you to specify the type of the OS that is included in the disk if creating a VM from a
    /// custom image.
    /// Possible values are:
    /// Windows
    /// Linux
    /// </summary>
    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>Snapshot: The snapshot.</summary>
    [JsonPropertyName("snapshot")]
    public V20220301ImageStatusStorageProfileOsDiskSnapshot? Snapshot { get; set; }

    /// <summary>
    /// StorageAccountType: Specifies the storage account type for the managed disk. NOTE: UltraSSD_LRS can only be used with
    /// data disks, it cannot be used with OS Disk.
    /// </summary>
    [JsonPropertyName("storageAccountType")]
    public string? StorageAccountType { get; set; }
}

/// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageStatusStorageProfile
{
    /// <summary>
    /// DataDisks: Specifies the parameters that are used to add a data disk to a virtual machine.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
    /// </summary>
    [JsonPropertyName("dataDisks")]
    public IList<V20220301ImageStatusStorageProfileDataDisks>? DataDisks { get; set; }

    /// <summary>
    /// OsDisk: Specifies information about the operating system disk used by the virtual machine.
    /// For more information about disks, see [About disks and VHDs for Azure virtual
    /// machines](https://docs.microsoft.com/azure/virtual-machines/managed-disks-overview).
    /// </summary>
    [JsonPropertyName("osDisk")]
    public V20220301ImageStatusStorageProfileOsDisk? OsDisk { get; set; }

    /// <summary>
    /// ZoneResilient: Specifies whether an image is zone resilient or not. Default is false. Zone resilient images can be
    /// created only in regions that provide Zone Redundant Storage (ZRS).
    /// </summary>
    [JsonPropertyName("zoneResilient")]
    public bool? ZoneResilient { get; set; }
}

/// <summary>
/// The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the virtual
/// machine. If SourceImage is provided, the destination virtual hard drive must not exist.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20220301ImageStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20220301ImageStatusConditions>? Conditions { get; set; }

    /// <summary>ExtendedLocation: The extended location of the Image.</summary>
    [JsonPropertyName("extendedLocation")]
    public V20220301ImageStatusExtendedLocation? ExtendedLocation { get; set; }

    /// <summary>
    /// HyperVGeneration: Specifies the HyperVGenerationType of the VirtualMachine created from the image. From API Version
    /// 2019-03-01 if the image source is a blob, then we need the user to specify the value, if the source is managed resource
    /// like disk or snapshot, we may require the user to specify the property if we cannot deduce it from the source managed
    /// resource.
    /// </summary>
    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    /// <summary>Id: Resource Id</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Location: Resource location</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: Resource name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProvisioningState: The provisioning state.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>SourceVirtualMachine: The source virtual machine from which Image is created.</summary>
    [JsonPropertyName("sourceVirtualMachine")]
    public V20220301ImageStatusSourceVirtualMachine? SourceVirtualMachine { get; set; }

    /// <summary>StorageProfile: Specifies the storage settings for the virtual machine disks.</summary>
    [JsonPropertyName("storageProfile")]
    public V20220301ImageStatusStorageProfile? StorageProfile { get; set; }

    /// <summary>Tags: Resource tags</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: Resource type</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/ComputeRP/stable/2022-03-01/image.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20220301Image : IKubernetesObject<V1ObjectMeta>, ISpec<V20220301ImageSpec?>, IStatus<V20220301ImageStatus?>
{
    public const string KubeApiVersion = "v20220301";
    public const string KubeKind = "Image";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "images";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v20220301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Image";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20220301ImageSpec? Spec { get; set; }

    /// <summary>
    /// The source user image virtual hard disk. The virtual hard disk will be copied before being attached to the virtual
    /// machine. If SourceImage is provided, the destination virtual hard drive must not exist.
    /// </summary>
    [JsonPropertyName("status")]
    public V20220301ImageStatus? Status { get; set; }
}