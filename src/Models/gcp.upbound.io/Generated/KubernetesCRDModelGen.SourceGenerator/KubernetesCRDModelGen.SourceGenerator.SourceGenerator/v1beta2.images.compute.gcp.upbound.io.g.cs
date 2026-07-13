#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
/// <summary>Image is the Schema for the Images API. Represents an Image resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ImageList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Image>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ImageList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "images";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

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
public partial class V1beta2ImageSpecForProviderGuestOsFeatures
{
    /// <summary>
    /// The type of supported feature. Read Enabling guest operating system features to see a list of available options.
    /// Possible values are: MULTI_IP_SUBNET, SECURE_BOOT, SEV_CAPABLE, UEFI_COMPATIBLE, VIRTIO_SCSI_MULTIQUEUE, WINDOWS, GVNIC, IDPF, SEV_LIVE_MIGRATABLE, SEV_SNP_CAPABLE, SUSPEND_RESUME_COMPATIBLE, TDX_CAPABLE, SEV_LIVE_MIGRATABLE_V2.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Specifies a 256-bit customer-supplied encryption key, encoded in
/// RFC 4648 base64 to either encrypt or decrypt this resource.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderImageEncryptionKeyRawKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Specifies a 256-bit customer-supplied encryption key, encoded in
/// RFC 4648 base64 to either encrypt or decrypt this resource.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderImageEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Encrypts the image using a customer-supplied encryption key.
/// After you encrypt an image with a customer-supplied key, you must
/// provide the same key if you use the image later (e.g. to create a
/// disk from the image)
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderImageEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key that is stored in Google Cloud
    /// KMS.
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta2ImageSpecForProviderImageEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta2ImageSpecForProviderImageEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary>
/// The parameters of the raw disk image.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderRawDisk
{
    /// <summary>
    /// The format used to encode and transmit the block device, which
    /// should be TAR. This is just a container and transmission format
    /// and not a runtime format. Provided by the client when the disk
    /// image is created.
    /// Default value is TAR.
    /// Possible values are: TAR.
    /// </summary>
    [JsonPropertyName("containerType")]
    public string? ContainerType { get; set; }

    /// <summary>
    /// An optional SHA1 checksum of the disk image before unpackaging.
    /// This is provided by the client when the disk image is created.
    /// </summary>
    [JsonPropertyName("sha1")]
    public string? Sha1 { get; set; }

    /// <summary>
    /// The full Google Cloud Storage URL where disk storage is stored
    /// You must provide either this property or the sourceDisk property
    /// but not both.
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderShieldedInstanceInitialStateDbs
{
    /// <summary>
    /// The raw content in the secure keys file.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderShieldedInstanceInitialStateDbxs
{
    /// <summary>
    /// The raw content in the secure keys file.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderShieldedInstanceInitialStateKeks
{
    /// <summary>
    /// The raw content in the secure keys file.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary>
/// The Platform Key (PK).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderShieldedInstanceInitialStatePk
{
    /// <summary>
    /// The raw content in the secure keys file.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary>
/// Set the secure boot keys of shielded instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderShieldedInstanceInitialState
{
    /// <summary>
    /// The Key Database (db).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dbs")]
    public IList<V1beta2ImageSpecForProviderShieldedInstanceInitialStateDbs>? Dbs { get; set; }

    /// <summary>
    /// The forbidden key database (dbx).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dbxs")]
    public IList<V1beta2ImageSpecForProviderShieldedInstanceInitialStateDbxs>? Dbxs { get; set; }

    /// <summary>
    /// The Key Exchange Key (KEK).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("keks")]
    public IList<V1beta2ImageSpecForProviderShieldedInstanceInitialStateKeks>? Keks { get; set; }

    /// <summary>
    /// The Platform Key (PK).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pk")]
    public V1beta2ImageSpecForProviderShieldedInstanceInitialStatePk? Pk { get; set; }
}

/// <summary>
/// Specifies a 256-bit customer-supplied encryption key, encoded in
/// RFC 4648 base64 to either encrypt or decrypt this resource.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderSourceDiskEncryptionKeyRawKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
/// customer-supplied encryption key to either encrypt or decrypt
/// this resource. You can provide either the rawKey or the rsaEncryptedKey.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderSourceDiskEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// The customer-supplied encryption key of the source disk. Required if
/// the source disk is protected by a customer-supplied encryption key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderSourceDiskEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&apos;s Compute Engine System service account
    /// (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have
    /// roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta2ImageSpecForProviderSourceDiskEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
    /// customer-supplied encryption key to either encrypt or decrypt
    /// this resource. You can provide either the rawKey or the rsaEncryptedKey.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta2ImageSpecForProviderSourceDiskEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageSpecForProviderSourceDiskRefPolicyResolutionEnum>))]
public enum V1beta2ImageSpecForProviderSourceDiskRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageSpecForProviderSourceDiskRefPolicyResolveEnum>))]
public enum V1beta2ImageSpecForProviderSourceDiskRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderSourceDiskRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImageSpecForProviderSourceDiskRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImageSpecForProviderSourceDiskRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Disk in compute to populate sourceDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderSourceDiskRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ImageSpecForProviderSourceDiskRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageSpecForProviderSourceDiskSelectorPolicyResolutionEnum>))]
public enum V1beta2ImageSpecForProviderSourceDiskSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageSpecForProviderSourceDiskSelectorPolicyResolveEnum>))]
public enum V1beta2ImageSpecForProviderSourceDiskSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderSourceDiskSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImageSpecForProviderSourceDiskSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImageSpecForProviderSourceDiskSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Disk in compute to populate sourceDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderSourceDiskSelector
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
    public V1beta2ImageSpecForProviderSourceDiskSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specifies a 256-bit customer-supplied encryption key, encoded in
/// RFC 4648 base64 to either encrypt or decrypt this resource.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderSourceImageEncryptionKeyRawKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
/// customer-supplied encryption key to either encrypt or decrypt
/// this resource. You can provide either the rawKey or the rsaEncryptedKey.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderSourceImageEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// The customer-supplied encryption key of the source image. Required if
/// the source image is protected by a customer-supplied encryption key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderSourceImageEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&apos;s Compute Engine System service account
    /// (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have
    /// roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta2ImageSpecForProviderSourceImageEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
    /// customer-supplied encryption key to either encrypt or decrypt
    /// this resource. You can provide either the rawKey or the rsaEncryptedKey.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta2ImageSpecForProviderSourceImageEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary>
/// Specifies a 256-bit customer-supplied encryption key, encoded in
/// RFC 4648 base64 to either encrypt or decrypt this resource.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderSourceSnapshotEncryptionKeyRawKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
/// customer-supplied encryption key to either encrypt or decrypt
/// this resource. You can provide either the rawKey or the rsaEncryptedKey.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// The customer-supplied encryption key of the source snapshot. Required if
/// the source snapshot is protected by a customer-supplied encryption key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProviderSourceSnapshotEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&apos;s Compute Engine System service account
    /// (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have
    /// roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta2ImageSpecForProviderSourceSnapshotEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
    /// customer-supplied encryption key to either encrypt or decrypt
    /// this resource. You can provide either the rawKey or the rsaEncryptedKey.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta2ImageSpecForProviderSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecForProvider
{
    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Size of the image when restored onto a persistent disk (in GB).</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>
    /// The name of the image family to which this image belongs. You can
    /// create disks by specifying an image family instead of a specific
    /// image name. The image family always returns its latest image that is
    /// not deprecated. The name of the image family must comply with
    /// RFC1035.
    /// </summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>
    /// A list of features to enable on the guest operating system.
    /// Applicable only for bootable images.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<V1beta2ImageSpecForProviderGuestOsFeatures>? GuestOsFeatures { get; set; }

    /// <summary>
    /// Encrypts the image using a customer-supplied encryption key.
    /// After you encrypt an image with a customer-supplied key, you must
    /// provide the same key if you use the image later (e.g. to create a
    /// disk from the image)
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("imageEncryptionKey")]
    public V1beta2ImageSpecForProviderImageEncryptionKey? ImageEncryptionKey { get; set; }

    /// <summary>
    /// Labels to apply to this Image.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Any applicable license URI.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The parameters of the raw disk image.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rawDisk")]
    public V1beta2ImageSpecForProviderRawDisk? RawDisk { get; set; }

    /// <summary>
    /// Set the secure boot keys of shielded instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("shieldedInstanceInitialState")]
    public V1beta2ImageSpecForProviderShieldedInstanceInitialState? ShieldedInstanceInitialState { get; set; }

    /// <summary>
    /// The source disk to create this image based on.
    /// You must provide either this property or the
    /// rawDisk.source property but not both to create an image.
    /// </summary>
    [JsonPropertyName("sourceDisk")]
    public string? SourceDisk { get; set; }

    /// <summary>
    /// The customer-supplied encryption key of the source disk. Required if
    /// the source disk is protected by a customer-supplied encryption key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceDiskEncryptionKey")]
    public V1beta2ImageSpecForProviderSourceDiskEncryptionKey? SourceDiskEncryptionKey { get; set; }

    /// <summary>Reference to a Disk in compute to populate sourceDisk.</summary>
    [JsonPropertyName("sourceDiskRef")]
    public V1beta2ImageSpecForProviderSourceDiskRef? SourceDiskRef { get; set; }

    /// <summary>Selector for a Disk in compute to populate sourceDisk.</summary>
    [JsonPropertyName("sourceDiskSelector")]
    public V1beta2ImageSpecForProviderSourceDiskSelector? SourceDiskSelector { get; set; }

    /// <summary>
    /// URL of the source image used to create this image. In order to create an image, you must provide the full or partial
    /// URL of one of the following:
    /// </summary>
    [JsonPropertyName("sourceImage")]
    public string? SourceImage { get; set; }

    /// <summary>
    /// The customer-supplied encryption key of the source image. Required if
    /// the source image is protected by a customer-supplied encryption key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceImageEncryptionKey")]
    public V1beta2ImageSpecForProviderSourceImageEncryptionKey? SourceImageEncryptionKey { get; set; }

    /// <summary>
    /// URL of the source snapshot used to create this image.
    /// In order to create an image, you must provide the full or partial URL of one of the following:
    /// </summary>
    [JsonPropertyName("sourceSnapshot")]
    public string? SourceSnapshot { get; set; }

    /// <summary>
    /// The customer-supplied encryption key of the source snapshot. Required if
    /// the source snapshot is protected by a customer-supplied encryption key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta2ImageSpecForProviderSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>
    /// Cloud Storage bucket storage location of the image
    /// (regional or multi-regional).
    /// Reference link: https://cloud.google.com/compute/docs/reference/rest/v1/images
    /// </summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderGuestOsFeatures
{
    /// <summary>
    /// The type of supported feature. Read Enabling guest operating system features to see a list of available options.
    /// Possible values are: MULTI_IP_SUBNET, SECURE_BOOT, SEV_CAPABLE, UEFI_COMPATIBLE, VIRTIO_SCSI_MULTIQUEUE, WINDOWS, GVNIC, IDPF, SEV_LIVE_MIGRATABLE, SEV_SNP_CAPABLE, SUSPEND_RESUME_COMPATIBLE, TDX_CAPABLE, SEV_LIVE_MIGRATABLE_V2.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Specifies a 256-bit customer-supplied encryption key, encoded in
/// RFC 4648 base64 to either encrypt or decrypt this resource.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderImageEncryptionKeyRawKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Specifies a 256-bit customer-supplied encryption key, encoded in
/// RFC 4648 base64 to either encrypt or decrypt this resource.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderImageEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Encrypts the image using a customer-supplied encryption key.
/// After you encrypt an image with a customer-supplied key, you must
/// provide the same key if you use the image later (e.g. to create a
/// disk from the image)
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderImageEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key that is stored in Google Cloud
    /// KMS.
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta2ImageSpecInitProviderImageEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta2ImageSpecInitProviderImageEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary>
/// The parameters of the raw disk image.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderRawDisk
{
    /// <summary>
    /// The format used to encode and transmit the block device, which
    /// should be TAR. This is just a container and transmission format
    /// and not a runtime format. Provided by the client when the disk
    /// image is created.
    /// Default value is TAR.
    /// Possible values are: TAR.
    /// </summary>
    [JsonPropertyName("containerType")]
    public string? ContainerType { get; set; }

    /// <summary>
    /// An optional SHA1 checksum of the disk image before unpackaging.
    /// This is provided by the client when the disk image is created.
    /// </summary>
    [JsonPropertyName("sha1")]
    public string? Sha1 { get; set; }

    /// <summary>
    /// The full Google Cloud Storage URL where disk storage is stored
    /// You must provide either this property or the sourceDisk property
    /// but not both.
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderShieldedInstanceInitialStateDbs
{
    /// <summary>
    /// The raw content in the secure keys file.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderShieldedInstanceInitialStateDbxs
{
    /// <summary>
    /// The raw content in the secure keys file.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderShieldedInstanceInitialStateKeks
{
    /// <summary>
    /// The raw content in the secure keys file.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary>
/// The Platform Key (PK).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderShieldedInstanceInitialStatePk
{
    /// <summary>
    /// The raw content in the secure keys file.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary>
/// Set the secure boot keys of shielded instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderShieldedInstanceInitialState
{
    /// <summary>
    /// The Key Database (db).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dbs")]
    public IList<V1beta2ImageSpecInitProviderShieldedInstanceInitialStateDbs>? Dbs { get; set; }

    /// <summary>
    /// The forbidden key database (dbx).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dbxs")]
    public IList<V1beta2ImageSpecInitProviderShieldedInstanceInitialStateDbxs>? Dbxs { get; set; }

    /// <summary>
    /// The Key Exchange Key (KEK).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("keks")]
    public IList<V1beta2ImageSpecInitProviderShieldedInstanceInitialStateKeks>? Keks { get; set; }

    /// <summary>
    /// The Platform Key (PK).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pk")]
    public V1beta2ImageSpecInitProviderShieldedInstanceInitialStatePk? Pk { get; set; }
}

/// <summary>
/// Specifies a 256-bit customer-supplied encryption key, encoded in
/// RFC 4648 base64 to either encrypt or decrypt this resource.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderSourceDiskEncryptionKeyRawKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
/// customer-supplied encryption key to either encrypt or decrypt
/// this resource. You can provide either the rawKey or the rsaEncryptedKey.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderSourceDiskEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// The customer-supplied encryption key of the source disk. Required if
/// the source disk is protected by a customer-supplied encryption key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderSourceDiskEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&apos;s Compute Engine System service account
    /// (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have
    /// roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta2ImageSpecInitProviderSourceDiskEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
    /// customer-supplied encryption key to either encrypt or decrypt
    /// this resource. You can provide either the rawKey or the rsaEncryptedKey.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta2ImageSpecInitProviderSourceDiskEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageSpecInitProviderSourceDiskRefPolicyResolutionEnum>))]
public enum V1beta2ImageSpecInitProviderSourceDiskRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageSpecInitProviderSourceDiskRefPolicyResolveEnum>))]
public enum V1beta2ImageSpecInitProviderSourceDiskRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderSourceDiskRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImageSpecInitProviderSourceDiskRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImageSpecInitProviderSourceDiskRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Disk in compute to populate sourceDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderSourceDiskRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ImageSpecInitProviderSourceDiskRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageSpecInitProviderSourceDiskSelectorPolicyResolutionEnum>))]
public enum V1beta2ImageSpecInitProviderSourceDiskSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImageSpecInitProviderSourceDiskSelectorPolicyResolveEnum>))]
public enum V1beta2ImageSpecInitProviderSourceDiskSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderSourceDiskSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImageSpecInitProviderSourceDiskSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImageSpecInitProviderSourceDiskSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Disk in compute to populate sourceDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderSourceDiskSelector
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
    public V1beta2ImageSpecInitProviderSourceDiskSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Specifies a 256-bit customer-supplied encryption key, encoded in
/// RFC 4648 base64 to either encrypt or decrypt this resource.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderSourceImageEncryptionKeyRawKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
/// customer-supplied encryption key to either encrypt or decrypt
/// this resource. You can provide either the rawKey or the rsaEncryptedKey.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderSourceImageEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// The customer-supplied encryption key of the source image. Required if
/// the source image is protected by a customer-supplied encryption key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderSourceImageEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&apos;s Compute Engine System service account
    /// (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have
    /// roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta2ImageSpecInitProviderSourceImageEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
    /// customer-supplied encryption key to either encrypt or decrypt
    /// this resource. You can provide either the rawKey or the rsaEncryptedKey.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta2ImageSpecInitProviderSourceImageEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary>
/// Specifies a 256-bit customer-supplied encryption key, encoded in
/// RFC 4648 base64 to either encrypt or decrypt this resource.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderSourceSnapshotEncryptionKeyRawKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
/// customer-supplied encryption key to either encrypt or decrypt
/// this resource. You can provide either the rawKey or the rsaEncryptedKey.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// The customer-supplied encryption key of the source snapshot. Required if
/// the source snapshot is protected by a customer-supplied encryption key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageSpecInitProviderSourceSnapshotEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&apos;s Compute Engine System service account
    /// (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have
    /// roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta2ImageSpecInitProviderSourceSnapshotEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
    /// customer-supplied encryption key to either encrypt or decrypt
    /// this resource. You can provide either the rawKey or the rsaEncryptedKey.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta2ImageSpecInitProviderSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
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
    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Size of the image when restored onto a persistent disk (in GB).</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>
    /// The name of the image family to which this image belongs. You can
    /// create disks by specifying an image family instead of a specific
    /// image name. The image family always returns its latest image that is
    /// not deprecated. The name of the image family must comply with
    /// RFC1035.
    /// </summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>
    /// A list of features to enable on the guest operating system.
    /// Applicable only for bootable images.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<V1beta2ImageSpecInitProviderGuestOsFeatures>? GuestOsFeatures { get; set; }

    /// <summary>
    /// Encrypts the image using a customer-supplied encryption key.
    /// After you encrypt an image with a customer-supplied key, you must
    /// provide the same key if you use the image later (e.g. to create a
    /// disk from the image)
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("imageEncryptionKey")]
    public V1beta2ImageSpecInitProviderImageEncryptionKey? ImageEncryptionKey { get; set; }

    /// <summary>
    /// Labels to apply to this Image.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Any applicable license URI.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The parameters of the raw disk image.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rawDisk")]
    public V1beta2ImageSpecInitProviderRawDisk? RawDisk { get; set; }

    /// <summary>
    /// Set the secure boot keys of shielded instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("shieldedInstanceInitialState")]
    public V1beta2ImageSpecInitProviderShieldedInstanceInitialState? ShieldedInstanceInitialState { get; set; }

    /// <summary>
    /// The source disk to create this image based on.
    /// You must provide either this property or the
    /// rawDisk.source property but not both to create an image.
    /// </summary>
    [JsonPropertyName("sourceDisk")]
    public string? SourceDisk { get; set; }

    /// <summary>
    /// The customer-supplied encryption key of the source disk. Required if
    /// the source disk is protected by a customer-supplied encryption key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceDiskEncryptionKey")]
    public V1beta2ImageSpecInitProviderSourceDiskEncryptionKey? SourceDiskEncryptionKey { get; set; }

    /// <summary>Reference to a Disk in compute to populate sourceDisk.</summary>
    [JsonPropertyName("sourceDiskRef")]
    public V1beta2ImageSpecInitProviderSourceDiskRef? SourceDiskRef { get; set; }

    /// <summary>Selector for a Disk in compute to populate sourceDisk.</summary>
    [JsonPropertyName("sourceDiskSelector")]
    public V1beta2ImageSpecInitProviderSourceDiskSelector? SourceDiskSelector { get; set; }

    /// <summary>
    /// URL of the source image used to create this image. In order to create an image, you must provide the full or partial
    /// URL of one of the following:
    /// </summary>
    [JsonPropertyName("sourceImage")]
    public string? SourceImage { get; set; }

    /// <summary>
    /// The customer-supplied encryption key of the source image. Required if
    /// the source image is protected by a customer-supplied encryption key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceImageEncryptionKey")]
    public V1beta2ImageSpecInitProviderSourceImageEncryptionKey? SourceImageEncryptionKey { get; set; }

    /// <summary>
    /// URL of the source snapshot used to create this image.
    /// In order to create an image, you must provide the full or partial URL of one of the following:
    /// </summary>
    [JsonPropertyName("sourceSnapshot")]
    public string? SourceSnapshot { get; set; }

    /// <summary>
    /// The customer-supplied encryption key of the source snapshot. Required if
    /// the source snapshot is protected by a customer-supplied encryption key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta2ImageSpecInitProviderSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>
    /// Cloud Storage bucket storage location of the image
    /// (regional or multi-regional).
    /// Reference link: https://cloud.google.com/compute/docs/reference/rest/v1/images
    /// </summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }
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
public partial class V1beta2ImageStatusAtProviderGuestOsFeatures
{
    /// <summary>
    /// The type of supported feature. Read Enabling guest operating system features to see a list of available options.
    /// Possible values are: MULTI_IP_SUBNET, SECURE_BOOT, SEV_CAPABLE, UEFI_COMPATIBLE, VIRTIO_SCSI_MULTIQUEUE, WINDOWS, GVNIC, IDPF, SEV_LIVE_MIGRATABLE, SEV_SNP_CAPABLE, SUSPEND_RESUME_COMPATIBLE, TDX_CAPABLE, SEV_LIVE_MIGRATABLE_V2.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Encrypts the image using a customer-supplied encryption key.
/// After you encrypt an image with a customer-supplied key, you must
/// provide the same key if you use the image later (e.g. to create a
/// disk from the image)
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageStatusAtProviderImageEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key that is stored in Google Cloud
    /// KMS.
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

/// <summary>
/// The parameters of the raw disk image.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageStatusAtProviderRawDisk
{
    /// <summary>
    /// The format used to encode and transmit the block device, which
    /// should be TAR. This is just a container and transmission format
    /// and not a runtime format. Provided by the client when the disk
    /// image is created.
    /// Default value is TAR.
    /// Possible values are: TAR.
    /// </summary>
    [JsonPropertyName("containerType")]
    public string? ContainerType { get; set; }

    /// <summary>
    /// An optional SHA1 checksum of the disk image before unpackaging.
    /// This is provided by the client when the disk image is created.
    /// </summary>
    [JsonPropertyName("sha1")]
    public string? Sha1 { get; set; }

    /// <summary>
    /// The full Google Cloud Storage URL where disk storage is stored
    /// You must provide either this property or the sourceDisk property
    /// but not both.
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageStatusAtProviderShieldedInstanceInitialStateDbs
{
    /// <summary>
    /// The raw content in the secure keys file.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageStatusAtProviderShieldedInstanceInitialStateDbxs
{
    /// <summary>
    /// The raw content in the secure keys file.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageStatusAtProviderShieldedInstanceInitialStateKeks
{
    /// <summary>
    /// The raw content in the secure keys file.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary>
/// The Platform Key (PK).
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageStatusAtProviderShieldedInstanceInitialStatePk
{
    /// <summary>
    /// The raw content in the secure keys file.
    /// A base64-encoded string.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The file type of source file.</summary>
    [JsonPropertyName("fileType")]
    public string? FileType { get; set; }
}

/// <summary>
/// Set the secure boot keys of shielded instance.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageStatusAtProviderShieldedInstanceInitialState
{
    /// <summary>
    /// The Key Database (db).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dbs")]
    public IList<V1beta2ImageStatusAtProviderShieldedInstanceInitialStateDbs>? Dbs { get; set; }

    /// <summary>
    /// The forbidden key database (dbx).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("dbxs")]
    public IList<V1beta2ImageStatusAtProviderShieldedInstanceInitialStateDbxs>? Dbxs { get; set; }

    /// <summary>
    /// The Key Exchange Key (KEK).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("keks")]
    public IList<V1beta2ImageStatusAtProviderShieldedInstanceInitialStateKeks>? Keks { get; set; }

    /// <summary>
    /// The Platform Key (PK).
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("pk")]
    public V1beta2ImageStatusAtProviderShieldedInstanceInitialStatePk? Pk { get; set; }
}

/// <summary>
/// The customer-supplied encryption key of the source disk. Required if
/// the source disk is protected by a customer-supplied encryption key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageStatusAtProviderSourceDiskEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&apos;s Compute Engine System service account
    /// (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have
    /// roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

/// <summary>
/// The customer-supplied encryption key of the source image. Required if
/// the source image is protected by a customer-supplied encryption key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageStatusAtProviderSourceImageEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&apos;s Compute Engine System service account
    /// (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have
    /// roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

/// <summary>
/// The customer-supplied encryption key of the source snapshot. Required if
/// the source snapshot is protected by a customer-supplied encryption key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageStatusAtProviderSourceSnapshotEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key used to decrypt this resource. Also called KmsKeyName
    /// in the cloud console. Your project&apos;s Compute Engine System service account
    /// (service-{{PROJECT_NUMBER}}@compute-system.iam.gserviceaccount.com) must have
    /// roles/cloudkms.cryptoKeyEncrypterDecrypter to use this feature.
    /// See https://cloud.google.com/compute/docs/disks/customer-managed-encryption#encrypt_a_new_persistent_disk_with_your_own_keys
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the encryption request for the
    /// given KMS key. If absent, the Compute Engine default service
    /// account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImageStatusAtProvider
{
    /// <summary>
    /// Size of the image tar.gz archive stored in Google Cloud Storage (in
    /// bytes).
    /// </summary>
    [JsonPropertyName("archiveSizeBytes")]
    public double? ArchiveSizeBytes { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Size of the image when restored onto a persistent disk (in GB).</summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>
    /// The name of the image family to which this image belongs. You can
    /// create disks by specifying an image family instead of a specific
    /// image name. The image family always returns its latest image that is
    /// not deprecated. The name of the image family must comply with
    /// RFC1035.
    /// </summary>
    [JsonPropertyName("family")]
    public string? Family { get; set; }

    /// <summary>
    /// A list of features to enable on the guest operating system.
    /// Applicable only for bootable images.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<V1beta2ImageStatusAtProviderGuestOsFeatures>? GuestOsFeatures { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/global/images/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Encrypts the image using a customer-supplied encryption key.
    /// After you encrypt an image with a customer-supplied key, you must
    /// provide the same key if you use the image later (e.g. to create a
    /// disk from the image)
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("imageEncryptionKey")]
    public V1beta2ImageStatusAtProviderImageEncryptionKey? ImageEncryptionKey { get; set; }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource. Used
    /// internally during updates.
    /// </summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>
    /// Labels to apply to this Image.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Any applicable license URI.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The parameters of the raw disk image.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rawDisk")]
    public V1beta2ImageStatusAtProviderRawDisk? RawDisk { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>
    /// Set the secure boot keys of shielded instance.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("shieldedInstanceInitialState")]
    public V1beta2ImageStatusAtProviderShieldedInstanceInitialState? ShieldedInstanceInitialState { get; set; }

    /// <summary>
    /// The source disk to create this image based on.
    /// You must provide either this property or the
    /// rawDisk.source property but not both to create an image.
    /// </summary>
    [JsonPropertyName("sourceDisk")]
    public string? SourceDisk { get; set; }

    /// <summary>
    /// The customer-supplied encryption key of the source disk. Required if
    /// the source disk is protected by a customer-supplied encryption key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceDiskEncryptionKey")]
    public V1beta2ImageStatusAtProviderSourceDiskEncryptionKey? SourceDiskEncryptionKey { get; set; }

    /// <summary>
    /// URL of the source image used to create this image. In order to create an image, you must provide the full or partial
    /// URL of one of the following:
    /// </summary>
    [JsonPropertyName("sourceImage")]
    public string? SourceImage { get; set; }

    /// <summary>
    /// The customer-supplied encryption key of the source image. Required if
    /// the source image is protected by a customer-supplied encryption key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceImageEncryptionKey")]
    public V1beta2ImageStatusAtProviderSourceImageEncryptionKey? SourceImageEncryptionKey { get; set; }

    /// <summary>
    /// URL of the source snapshot used to create this image.
    /// In order to create an image, you must provide the full or partial URL of one of the following:
    /// </summary>
    [JsonPropertyName("sourceSnapshot")]
    public string? SourceSnapshot { get; set; }

    /// <summary>
    /// The customer-supplied encryption key of the source snapshot. Required if
    /// the source snapshot is protected by a customer-supplied encryption key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta2ImageStatusAtProviderSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>
    /// Cloud Storage bucket storage location of the image
    /// (regional or multi-regional).
    /// Reference link: https://cloud.google.com/compute/docs/reference/rest/v1/images
    /// </summary>
    [JsonPropertyName("storageLocations")]
    public IList<string>? StorageLocations { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }
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

/// <summary>Image is the Schema for the Images API. Represents an Image resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Image : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ImageSpec>, IStatus<V1beta2ImageStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Image";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "images";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

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