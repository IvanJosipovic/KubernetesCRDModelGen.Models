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
/// Storage version of v1api20200930.Snapshot
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/DiskRP/stable/2020-09-30/disk.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/snapshots/{snapshotName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20200930storageSnapshotList : IKubernetesObject<V1ListMeta>, IItems<V1api20200930storageSnapshot>
{
    public const string KubeApiVersion = "v1api20200930storage";
    public const string KubeKind = "SnapshotList";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "snapshots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20200930storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SnapshotList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20200930storageSnapshot objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20200930storageSnapshot> Items { get; set; }
}

/// <summary>Reference: A relative uri containing either a Platform Image Repository or user image reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecCreationDataGalleryImageReferenceReference
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
/// Storage version of v1api20200930.ImageDiskReference
/// The source image used for creating the disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecCreationDataGalleryImageReference
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>Reference: A relative uri containing either a Platform Image Repository or user image reference.</summary>
    [JsonPropertyName("reference")]
    public required V1api20200930storageSnapshotSpecCreationDataGalleryImageReferenceReference Reference { get; set; }
}

/// <summary>Reference: A relative uri containing either a Platform Image Repository or user image reference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecCreationDataImageReferenceReference
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
/// Storage version of v1api20200930.ImageDiskReference
/// The source image used for creating the disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecCreationDataImageReference
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("lun")]
    public int? Lun { get; set; }

    /// <summary>Reference: A relative uri containing either a Platform Image Repository or user image reference.</summary>
    [JsonPropertyName("reference")]
    public required V1api20200930storageSnapshotSpecCreationDataImageReferenceReference Reference { get; set; }
}

/// <summary>SourceResourceReference: If createOption is Copy, this is the ARM id of the source snapshot or disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecCreationDataSourceResourceReference
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
/// Storage version of v1api20200930.CreationData
/// Data used when creating a disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecCreationData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.ImageDiskReference
    /// The source image used for creating the disk.
    /// </summary>
    [JsonPropertyName("galleryImageReference")]
    public V1api20200930storageSnapshotSpecCreationDataGalleryImageReference? GalleryImageReference { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.ImageDiskReference
    /// The source image used for creating the disk.
    /// </summary>
    [JsonPropertyName("imageReference")]
    public V1api20200930storageSnapshotSpecCreationDataImageReference? ImageReference { get; set; }

    [JsonPropertyName("logicalSectorSize")]
    public int? LogicalSectorSize { get; set; }

    /// <summary>SourceResourceReference: If createOption is Copy, this is the ARM id of the source snapshot or disk.</summary>
    [JsonPropertyName("sourceResourceReference")]
    public V1api20200930storageSnapshotSpecCreationDataSourceResourceReference? SourceResourceReference { get; set; }

    [JsonPropertyName("sourceUri")]
    public string? SourceUri { get; set; }

    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    [JsonPropertyName("uploadSizeBytes")]
    public int? UploadSizeBytes { get; set; }
}

/// <summary>DiskAccessReference: ARM id of the DiskAccess resource for using private endpoints on disks.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecDiskAccessReference
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecEncryptionDiskEncryptionSetReference
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
/// Storage version of v1api20200930.Encryption
/// Encryption at rest settings for disk or snapshot
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecEncryption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>DiskEncryptionSetReference: ResourceId of the disk encryption set to use for enabling encryption at rest.</summary>
    [JsonPropertyName("diskEncryptionSetReference")]
    public V1api20200930storageSnapshotSpecEncryptionDiskEncryptionSetReference? DiskEncryptionSetReference { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVaultReference
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
/// Storage version of v1api20200930.SourceVault
/// The vault id is an Azure Resource Manager Resource id in the form
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20200930storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVaultReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20200930.KeyVaultAndSecretReference
/// Key Vault Secret Url and vault id of the encryption key
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.SourceVault
    /// The vault id is an Azure Resource Manager Resource id in the form
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
    /// </summary>
    [JsonPropertyName("sourceVault")]
    public V1api20200930storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>Reference: Resource Id</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVaultReference
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
/// Storage version of v1api20200930.SourceVault
/// The vault id is an Azure Resource Manager Resource id in the form
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Reference: Resource Id</summary>
    [JsonPropertyName("reference")]
    public V1api20200930storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVaultReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v1api20200930.KeyVaultAndKeyReference
/// Key Vault Key Url and vault id of KeK, KeK is optional and when provided is used to unwrap the encryptionKey
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.SourceVault
    /// The vault id is an Azure Resource Manager Resource id in the form
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
    /// </summary>
    [JsonPropertyName("sourceVault")]
    public V1api20200930storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>
/// Storage version of v1api20200930.EncryptionSettingsElement
/// Encryption settings for one disk volume.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.KeyVaultAndSecretReference
    /// Key Vault Secret Url and vault id of the encryption key
    /// </summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20200930storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.KeyVaultAndKeyReference
    /// Key Vault Key Url and vault id of KeK, KeK is optional and when provided is used to unwrap the encryptionKey
    /// </summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20200930storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>
/// Storage version of v1api20200930.EncryptionSettingsCollection
/// Encryption settings for disk or snapshot
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecEncryptionSettingsCollection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("encryptionSettings")]
    public IList<V1api20200930storageSnapshotSpecEncryptionSettingsCollectionEncryptionSettings>? EncryptionSettings { get; set; }

    [JsonPropertyName("encryptionSettingsVersion")]
    public string? EncryptionSettingsVersion { get; set; }
}

/// <summary>
/// Storage version of v1api20200930.ExtendedLocation
/// The complex type of the extended location.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecExtendedLocation
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
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20200930.SnapshotOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20200930storageSnapshotSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20200930storageSnapshotSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20200930.PurchasePlan
/// Used for establishing the purchase context of any 3rd Party artifact through MarketPlace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecPurchasePlan
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("product")]
    public string? Product { get; set; }

    [JsonPropertyName("promotionCode")]
    public string? PromotionCode { get; set; }

    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>
/// Storage version of v1api20200930.SnapshotSku
/// The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. This is an optional parameter for incremental
/// snapshot and the default behavior is the SKU will be set to the same sku as the previous snapshot
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpecSku
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Storage version of v1api20200930.Snapshot_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.CreationData
    /// Data used when creating a disk.
    /// </summary>
    [JsonPropertyName("creationData")]
    public V1api20200930storageSnapshotSpecCreationData? CreationData { get; set; }

    /// <summary>DiskAccessReference: ARM id of the DiskAccess resource for using private endpoints on disks.</summary>
    [JsonPropertyName("diskAccessReference")]
    public V1api20200930storageSnapshotSpecDiskAccessReference? DiskAccessReference { get; set; }

    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.Encryption
    /// Encryption at rest settings for disk or snapshot
    /// </summary>
    [JsonPropertyName("encryption")]
    public V1api20200930storageSnapshotSpecEncryption? Encryption { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.EncryptionSettingsCollection
    /// Encryption settings for disk or snapshot
    /// </summary>
    [JsonPropertyName("encryptionSettingsCollection")]
    public V1api20200930storageSnapshotSpecEncryptionSettingsCollection? EncryptionSettingsCollection { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.ExtendedLocation
    /// The complex type of the extended location.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20200930storageSnapshotSpecExtendedLocation? ExtendedLocation { get; set; }

    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    [JsonPropertyName("incremental")]
    public bool? Incremental { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("networkAccessPolicy")]
    public string? NetworkAccessPolicy { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.SnapshotOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20200930storageSnapshotSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20200930storageSnapshotSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.PurchasePlan
    /// Used for establishing the purchase context of any 3rd Party artifact through MarketPlace.
    /// </summary>
    [JsonPropertyName("purchasePlan")]
    public V1api20200930storageSnapshotSpecPurchasePlan? PurchasePlan { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.SnapshotSku
    /// The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. This is an optional parameter for incremental
    /// snapshot and the default behavior is the SKU will be set to the same sku as the previous snapshot
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20200930storageSnapshotSpecSku? Sku { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotStatusConditions
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
/// Storage version of v1api20200930.ImageDiskReference_STATUS
/// The source image used for creating the disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotStatusCreationDataGalleryImageReference
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("lun")]
    public int? Lun { get; set; }
}

/// <summary>
/// Storage version of v1api20200930.ImageDiskReference_STATUS
/// The source image used for creating the disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotStatusCreationDataImageReference
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("lun")]
    public int? Lun { get; set; }
}

/// <summary>
/// Storage version of v1api20200930.CreationData_STATUS
/// Data used when creating a disk.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotStatusCreationData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("createOption")]
    public string? CreateOption { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.ImageDiskReference_STATUS
    /// The source image used for creating the disk.
    /// </summary>
    [JsonPropertyName("galleryImageReference")]
    public V1api20200930storageSnapshotStatusCreationDataGalleryImageReference? GalleryImageReference { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.ImageDiskReference_STATUS
    /// The source image used for creating the disk.
    /// </summary>
    [JsonPropertyName("imageReference")]
    public V1api20200930storageSnapshotStatusCreationDataImageReference? ImageReference { get; set; }

    [JsonPropertyName("logicalSectorSize")]
    public int? LogicalSectorSize { get; set; }

    [JsonPropertyName("sourceResourceId")]
    public string? SourceResourceId { get; set; }

    [JsonPropertyName("sourceUniqueId")]
    public string? SourceUniqueId { get; set; }

    [JsonPropertyName("sourceUri")]
    public string? SourceUri { get; set; }

    [JsonPropertyName("storageAccountId")]
    public string? StorageAccountId { get; set; }

    [JsonPropertyName("uploadSizeBytes")]
    public int? UploadSizeBytes { get; set; }
}

/// <summary>
/// Storage version of v1api20200930.Encryption_STATUS
/// Encryption at rest settings for disk or snapshot
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotStatusEncryption
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("diskEncryptionSetId")]
    public string? DiskEncryptionSetId { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20200930.SourceVault_STATUS
/// The vault id is an Azure Resource Manager Resource id in the form
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault
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
/// Storage version of v1api20200930.KeyVaultAndSecretReference_STATUS
/// Key Vault Secret Url and vault id of the encryption key
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("secretUrl")]
    public string? SecretUrl { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.SourceVault_STATUS
    /// The vault id is an Azure Resource Manager Resource id in the form
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
    /// </summary>
    [JsonPropertyName("sourceVault")]
    public V1api20200930storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>
/// Storage version of v1api20200930.SourceVault_STATUS
/// The vault id is an Azure Resource Manager Resource id in the form
/// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault
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
/// Storage version of v1api20200930.KeyVaultAndKeyReference_STATUS
/// Key Vault Key Url and vault id of KeK, KeK is optional and when provided is used to unwrap the encryptionKey
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("keyUrl")]
    public string? KeyUrl { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.SourceVault_STATUS
    /// The vault id is an Azure Resource Manager Resource id in the form
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.KeyVault/vaults/{vaultName}
    /// </summary>
    [JsonPropertyName("sourceVault")]
    public V1api20200930storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKeySourceVault? SourceVault { get; set; }
}

/// <summary>
/// Storage version of v1api20200930.EncryptionSettingsElement_STATUS
/// Encryption settings for one disk volume.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.KeyVaultAndSecretReference_STATUS
    /// Key Vault Secret Url and vault id of the encryption key
    /// </summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1api20200930storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettingsDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.KeyVaultAndKeyReference_STATUS
    /// Key Vault Key Url and vault id of KeK, KeK is optional and when provided is used to unwrap the encryptionKey
    /// </summary>
    [JsonPropertyName("keyEncryptionKey")]
    public V1api20200930storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettingsKeyEncryptionKey? KeyEncryptionKey { get; set; }
}

/// <summary>
/// Storage version of v1api20200930.EncryptionSettingsCollection_STATUS
/// Encryption settings for disk or snapshot
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotStatusEncryptionSettingsCollection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("encryptionSettings")]
    public IList<V1api20200930storageSnapshotStatusEncryptionSettingsCollectionEncryptionSettings>? EncryptionSettings { get; set; }

    [JsonPropertyName("encryptionSettingsVersion")]
    public string? EncryptionSettingsVersion { get; set; }
}

/// <summary>
/// Storage version of v1api20200930.ExtendedLocation_STATUS
/// The complex type of the extended location.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotStatusExtendedLocation
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
/// Storage version of v1api20200930.PurchasePlan_STATUS
/// Used for establishing the purchase context of any 3rd Party artifact through MarketPlace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotStatusPurchasePlan
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("product")]
    public string? Product { get; set; }

    [JsonPropertyName("promotionCode")]
    public string? PromotionCode { get; set; }

    [JsonPropertyName("publisher")]
    public string? Publisher { get; set; }
}

/// <summary>
/// Storage version of v1api20200930.SnapshotSku_STATUS
/// The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. This is an optional parameter for incremental
/// snapshot and the default behavior is the SKU will be set to the same sku as the previous snapshot
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotStatusSku
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
/// Storage version of v1api20200930.Snapshot_STATUS
/// Snapshot resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20200930storageSnapshotStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20200930storageSnapshotStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.CreationData_STATUS
    /// Data used when creating a disk.
    /// </summary>
    [JsonPropertyName("creationData")]
    public V1api20200930storageSnapshotStatusCreationData? CreationData { get; set; }

    [JsonPropertyName("diskAccessId")]
    public string? DiskAccessId { get; set; }

    [JsonPropertyName("diskSizeBytes")]
    public int? DiskSizeBytes { get; set; }

    [JsonPropertyName("diskSizeGB")]
    public int? DiskSizeGB { get; set; }

    [JsonPropertyName("diskState")]
    public string? DiskState { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.Encryption_STATUS
    /// Encryption at rest settings for disk or snapshot
    /// </summary>
    [JsonPropertyName("encryption")]
    public V1api20200930storageSnapshotStatusEncryption? Encryption { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.EncryptionSettingsCollection_STATUS
    /// Encryption settings for disk or snapshot
    /// </summary>
    [JsonPropertyName("encryptionSettingsCollection")]
    public V1api20200930storageSnapshotStatusEncryptionSettingsCollection? EncryptionSettingsCollection { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.ExtendedLocation_STATUS
    /// The complex type of the extended location.
    /// </summary>
    [JsonPropertyName("extendedLocation")]
    public V1api20200930storageSnapshotStatusExtendedLocation? ExtendedLocation { get; set; }

    [JsonPropertyName("hyperVGeneration")]
    public string? HyperVGeneration { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("incremental")]
    public bool? Incremental { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("managedBy")]
    public string? ManagedBy { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("networkAccessPolicy")]
    public string? NetworkAccessPolicy { get; set; }

    [JsonPropertyName("osType")]
    public string? OsType { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.PurchasePlan_STATUS
    /// Used for establishing the purchase context of any 3rd Party artifact through MarketPlace.
    /// </summary>
    [JsonPropertyName("purchasePlan")]
    public V1api20200930storageSnapshotStatusPurchasePlan? PurchasePlan { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.SnapshotSku_STATUS
    /// The snapshots sku name. Can be Standard_LRS, Premium_LRS, or Standard_ZRS. This is an optional parameter for incremental
    /// snapshot and the default behavior is the SKU will be set to the same sku as the previous snapshot
    /// </summary>
    [JsonPropertyName("sku")]
    public V1api20200930storageSnapshotStatusSku? Sku { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("timeCreated")]
    public string? TimeCreated { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("uniqueId")]
    public string? UniqueId { get; set; }
}

/// <summary>
/// Storage version of v1api20200930.Snapshot
/// Generator information:
/// - Generated from: /compute/resource-manager/Microsoft.Compute/DiskRP/stable/2020-09-30/disk.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/snapshots/{snapshotName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20200930storageSnapshot : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20200930storageSnapshotSpec?>, IStatus<V1api20200930storageSnapshotStatus?>
{
    public const string KubeApiVersion = "v1api20200930storage";
    public const string KubeKind = "Snapshot";
    public const string KubeGroup = "compute.azure.com";
    public const string KubePluralName = "snapshots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.azure.com/v1api20200930storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Snapshot";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20200930.Snapshot_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20200930storageSnapshotSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v1api20200930.Snapshot_STATUS
    /// Snapshot resource.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20200930storageSnapshotStatus? Status { get; set; }
}