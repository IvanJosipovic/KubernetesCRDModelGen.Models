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
/// <summary>RegionDisk is the Schema for the RegionDisks API. Persistent disks are durable storage devices that function similarly to the physical disks in a desktop or a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RegionDiskList : IKubernetesObject<V1ListMeta>, IItems<V1beta2RegionDisk>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RegionDiskList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regiondisks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegionDiskList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2RegionDisk objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2RegionDisk> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecDeletionPolicyEnum>))]
public enum V1beta2RegionDiskSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskRefPolicyResolutionEnum>))]
public enum V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskRefPolicyResolveEnum>))]
public enum V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionDisk in compute to populate disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskSelectorPolicyResolveEnum>))]
public enum V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionDisk in compute to populate disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskSelector
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
    public V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecForProviderAsyncPrimaryDisk
{
    /// <summary>Primary disk for asynchronous disk replication.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>Reference to a RegionDisk in compute to populate disk.</summary>
    [JsonPropertyName("diskRef")]
    public V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskRef? DiskRef { get; set; }

    /// <summary>Selector for a RegionDisk in compute to populate disk.</summary>
    [JsonPropertyName("diskSelector")]
    public V1beta2RegionDiskSpecForProviderAsyncPrimaryDiskDiskSelector? DiskSelector { get; set; }
}

/// <summary>
/// Specifies a 256-bit customer-supplied encryption key, encoded in
/// RFC 4648 base64 to either encrypt or decrypt this resource.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecForProviderDiskEncryptionKeyRawKeySecretRef
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
public partial class V1beta2RegionDiskSpecForProviderDiskEncryptionKeyRsaEncryptedKeySecretRef
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
/// Encrypts the disk using a customer-supplied encryption key.
/// After you encrypt a disk with a customer-supplied key, you must
/// provide the same key if you use the disk later (e.g. to create a disk
/// snapshot or an image, or to attach the disk to a virtual machine).
/// Customer-supplied encryption keys do not protect access to metadata of
/// the disk.
/// If you do not provide an encryption key when creating the disk, then
/// the disk will be encrypted using an automatically generated key and
/// you do not need to provide a key to use the disk later.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecForProviderDiskEncryptionKey
{
    /// <summary>The name of the encryption key that is stored in Google Cloud KMS.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta2RegionDiskSpecForProviderDiskEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
    /// customer-supplied encryption key to either encrypt or decrypt
    /// this resource. You can provide either the rawKey or the rsaEncryptedKey.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta2RegionDiskSpecForProviderDiskEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecForProviderGuestOsFeatures
{
    /// <summary>
    /// The type of supported feature. Read Enabling guest operating system features to see a list of available options.
    /// Possible values are: MULTI_IP_SUBNET, SECURE_BOOT, SEV_CAPABLE, UEFI_COMPATIBLE, VIRTIO_SCSI_MULTIQUEUE, WINDOWS, GVNIC, SEV_LIVE_MIGRATABLE, SEV_SNP_CAPABLE, SUSPEND_RESUME_COMPATIBLE, TDX_CAPABLE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecForProviderSnapshotRefPolicyResolutionEnum>))]
public enum V1beta2RegionDiskSpecForProviderSnapshotRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecForProviderSnapshotRefPolicyResolveEnum>))]
public enum V1beta2RegionDiskSpecForProviderSnapshotRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecForProviderSnapshotRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionDiskSpecForProviderSnapshotRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionDiskSpecForProviderSnapshotRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Snapshot in compute to populate snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecForProviderSnapshotRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionDiskSpecForProviderSnapshotRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecForProviderSnapshotSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionDiskSpecForProviderSnapshotSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecForProviderSnapshotSelectorPolicyResolveEnum>))]
public enum V1beta2RegionDiskSpecForProviderSnapshotSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecForProviderSnapshotSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionDiskSpecForProviderSnapshotSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionDiskSpecForProviderSnapshotSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Snapshot in compute to populate snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecForProviderSnapshotSelector
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
    public V1beta2RegionDiskSpecForProviderSnapshotSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The customer-supplied encryption key of the source snapshot. Required
/// if the source snapshot is protected by a customer-supplied encryption
/// key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecForProviderSourceSnapshotEncryptionKey
{
    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [JsonPropertyName("rawKey")]
    public string? RawKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecForProvider
{
    /// <summary>
    /// The access mode of the disk.
    /// For example:
    /// </summary>
    [JsonPropertyName("accessMode")]
    public string? AccessMode { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("asyncPrimaryDisk")]
    public V1beta2RegionDiskSpecForProviderAsyncPrimaryDisk? AsyncPrimaryDisk { get; set; }

    /// <summary>
    /// If set to true, a snapshot of the disk will be created before it is destroyed.
    /// If your disk is encrypted with customer managed encryption keys these will be reused for the snapshot creation.
    /// The name of the snapshot by default will be {{disk-name}}-YYYYMMDD-HHmm
    /// </summary>
    [JsonPropertyName("createSnapshotBeforeDestroy")]
    public bool? CreateSnapshotBeforeDestroy { get; set; }

    /// <summary>This will set a custom name prefix for the snapshot that&apos;s created when the disk is deleted.</summary>
    [JsonPropertyName("createSnapshotBeforeDestroyPrefix")]
    public string? CreateSnapshotBeforeDestroyPrefix { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Encrypts the disk using a customer-supplied encryption key.
    /// After you encrypt a disk with a customer-supplied key, you must
    /// provide the same key if you use the disk later (e.g. to create a disk
    /// snapshot or an image, or to attach the disk to a virtual machine).
    /// Customer-supplied encryption keys do not protect access to metadata of
    /// the disk.
    /// If you do not provide an encryption key when creating the disk, then
    /// the disk will be encrypted using an automatically generated key and
    /// you do not need to provide a key to use the disk later.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta2RegionDiskSpecForProviderDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>
    /// A list of features to enable on the guest operating system.
    /// Applicable only for bootable disks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<V1beta2RegionDiskSpecForProviderGuestOsFeatures>? GuestOsFeatures { get; set; }

    /// <summary>Labels to apply to this disk.  A list of key-&gt;value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Any applicable license URI.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>
    /// Physical block size of the persistent disk, in bytes. If not present
    /// in a request, a default value is used. Currently supported sizes
    /// are 4096 and 16384, other sizes may be added in the future.
    /// If an unsupported value is requested, the error message will list
    /// the supported values for the caller&apos;s project.
    /// </summary>
    [JsonPropertyName("physicalBlockSizeBytes")]
    public double? PhysicalBlockSizeBytes { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second
    /// that the disk can handle. Values must be between 10,000 and 120,000.
    /// For more details, see the Extreme persistent disk documentation.
    /// </summary>
    [JsonPropertyName("provisionedIops")]
    public double? ProvisionedIops { get; set; }

    /// <summary>
    /// Indicates how much throughput to provision for the disk. This sets the number of throughput
    /// mb per second that the disk can handle. Values must be greater than or equal to 1.
    /// </summary>
    [JsonPropertyName("provisionedThroughput")]
    public double? ProvisionedThroughput { get; set; }

    /// <summary>A reference to the region where the disk resides.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>URLs of the zones where the disk should be replicated to.</summary>
    [JsonPropertyName("replicaZones")]
    public IList<string>? ReplicaZones { get; set; }

    /// <summary>
    /// Size of the persistent disk, specified in GB. You can specify this
    /// field when creating a persistent disk using the sourceImage or
    /// sourceSnapshot parameter, or specify it alone to create an empty
    /// persistent disk.
    /// If you specify this field along with sourceImage or sourceSnapshot,
    /// the value of sizeGb must not be less than the size of the sourceImage
    /// or the size of the snapshot.
    /// </summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>
    /// The source snapshot used to create this disk. You can provide this as
    /// a partial or full URL to the resource. For example, the following are
    /// valid values:
    /// </summary>
    [JsonPropertyName("snapshot")]
    public string? Snapshot { get; set; }

    /// <summary>Reference to a Snapshot in compute to populate snapshot.</summary>
    [JsonPropertyName("snapshotRef")]
    public V1beta2RegionDiskSpecForProviderSnapshotRef? SnapshotRef { get; set; }

    /// <summary>Selector for a Snapshot in compute to populate snapshot.</summary>
    [JsonPropertyName("snapshotSelector")]
    public V1beta2RegionDiskSpecForProviderSnapshotSelector? SnapshotSelector { get; set; }

    /// <summary>
    /// The source disk used to create this disk. You can provide this as a partial or full URL to the resource.
    /// For example, the following are valid values:
    /// </summary>
    [JsonPropertyName("sourceDisk")]
    public string? SourceDisk { get; set; }

    /// <summary>
    /// The customer-supplied encryption key of the source snapshot. Required
    /// if the source snapshot is protected by a customer-supplied encryption
    /// key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta2RegionDiskSpecForProviderSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>
    /// URL of the disk type resource describing which disk type to use to
    /// create the disk. Provide this when creating the disk.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskRefPolicyResolutionEnum>))]
public enum V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskRefPolicyResolveEnum>))]
public enum V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionDisk in compute to populate disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskSelectorPolicyResolveEnum>))]
public enum V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionDisk in compute to populate disk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskSelector
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
    public V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecInitProviderAsyncPrimaryDisk
{
    /// <summary>Primary disk for asynchronous disk replication.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }

    /// <summary>Reference to a RegionDisk in compute to populate disk.</summary>
    [JsonPropertyName("diskRef")]
    public V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskRef? DiskRef { get; set; }

    /// <summary>Selector for a RegionDisk in compute to populate disk.</summary>
    [JsonPropertyName("diskSelector")]
    public V1beta2RegionDiskSpecInitProviderAsyncPrimaryDiskDiskSelector? DiskSelector { get; set; }
}

/// <summary>
/// Specifies a 256-bit customer-supplied encryption key, encoded in
/// RFC 4648 base64 to either encrypt or decrypt this resource.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecInitProviderDiskEncryptionKeyRawKeySecretRef
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
public partial class V1beta2RegionDiskSpecInitProviderDiskEncryptionKeyRsaEncryptedKeySecretRef
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
/// Encrypts the disk using a customer-supplied encryption key.
/// After you encrypt a disk with a customer-supplied key, you must
/// provide the same key if you use the disk later (e.g. to create a disk
/// snapshot or an image, or to attach the disk to a virtual machine).
/// Customer-supplied encryption keys do not protect access to metadata of
/// the disk.
/// If you do not provide an encryption key when creating the disk, then
/// the disk will be encrypted using an automatically generated key and
/// you do not need to provide a key to use the disk later.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecInitProviderDiskEncryptionKey
{
    /// <summary>The name of the encryption key that is stored in Google Cloud KMS.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta2RegionDiskSpecInitProviderDiskEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit
    /// customer-supplied encryption key to either encrypt or decrypt
    /// this resource. You can provide either the rawKey or the rsaEncryptedKey.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta2RegionDiskSpecInitProviderDiskEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecInitProviderGuestOsFeatures
{
    /// <summary>
    /// The type of supported feature. Read Enabling guest operating system features to see a list of available options.
    /// Possible values are: MULTI_IP_SUBNET, SECURE_BOOT, SEV_CAPABLE, UEFI_COMPATIBLE, VIRTIO_SCSI_MULTIQUEUE, WINDOWS, GVNIC, SEV_LIVE_MIGRATABLE, SEV_SNP_CAPABLE, SUSPEND_RESUME_COMPATIBLE, TDX_CAPABLE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecInitProviderSnapshotRefPolicyResolutionEnum>))]
public enum V1beta2RegionDiskSpecInitProviderSnapshotRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecInitProviderSnapshotRefPolicyResolveEnum>))]
public enum V1beta2RegionDiskSpecInitProviderSnapshotRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecInitProviderSnapshotRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionDiskSpecInitProviderSnapshotRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionDiskSpecInitProviderSnapshotRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Snapshot in compute to populate snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecInitProviderSnapshotRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionDiskSpecInitProviderSnapshotRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecInitProviderSnapshotSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionDiskSpecInitProviderSnapshotSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecInitProviderSnapshotSelectorPolicyResolveEnum>))]
public enum V1beta2RegionDiskSpecInitProviderSnapshotSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecInitProviderSnapshotSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionDiskSpecInitProviderSnapshotSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionDiskSpecInitProviderSnapshotSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Snapshot in compute to populate snapshot.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecInitProviderSnapshotSelector
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
    public V1beta2RegionDiskSpecInitProviderSnapshotSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The customer-supplied encryption key of the source snapshot. Required
/// if the source snapshot is protected by a customer-supplied encryption
/// key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecInitProviderSourceSnapshotEncryptionKey
{
    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [JsonPropertyName("rawKey")]
    public string? RawKey { get; set; }
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
public partial class V1beta2RegionDiskSpecInitProvider
{
    /// <summary>
    /// The access mode of the disk.
    /// For example:
    /// </summary>
    [JsonPropertyName("accessMode")]
    public string? AccessMode { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("asyncPrimaryDisk")]
    public V1beta2RegionDiskSpecInitProviderAsyncPrimaryDisk? AsyncPrimaryDisk { get; set; }

    /// <summary>
    /// If set to true, a snapshot of the disk will be created before it is destroyed.
    /// If your disk is encrypted with customer managed encryption keys these will be reused for the snapshot creation.
    /// The name of the snapshot by default will be {{disk-name}}-YYYYMMDD-HHmm
    /// </summary>
    [JsonPropertyName("createSnapshotBeforeDestroy")]
    public bool? CreateSnapshotBeforeDestroy { get; set; }

    /// <summary>This will set a custom name prefix for the snapshot that&apos;s created when the disk is deleted.</summary>
    [JsonPropertyName("createSnapshotBeforeDestroyPrefix")]
    public string? CreateSnapshotBeforeDestroyPrefix { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Encrypts the disk using a customer-supplied encryption key.
    /// After you encrypt a disk with a customer-supplied key, you must
    /// provide the same key if you use the disk later (e.g. to create a disk
    /// snapshot or an image, or to attach the disk to a virtual machine).
    /// Customer-supplied encryption keys do not protect access to metadata of
    /// the disk.
    /// If you do not provide an encryption key when creating the disk, then
    /// the disk will be encrypted using an automatically generated key and
    /// you do not need to provide a key to use the disk later.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta2RegionDiskSpecInitProviderDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>
    /// A list of features to enable on the guest operating system.
    /// Applicable only for bootable disks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<V1beta2RegionDiskSpecInitProviderGuestOsFeatures>? GuestOsFeatures { get; set; }

    /// <summary>Labels to apply to this disk.  A list of key-&gt;value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Any applicable license URI.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>
    /// Physical block size of the persistent disk, in bytes. If not present
    /// in a request, a default value is used. Currently supported sizes
    /// are 4096 and 16384, other sizes may be added in the future.
    /// If an unsupported value is requested, the error message will list
    /// the supported values for the caller&apos;s project.
    /// </summary>
    [JsonPropertyName("physicalBlockSizeBytes")]
    public double? PhysicalBlockSizeBytes { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second
    /// that the disk can handle. Values must be between 10,000 and 120,000.
    /// For more details, see the Extreme persistent disk documentation.
    /// </summary>
    [JsonPropertyName("provisionedIops")]
    public double? ProvisionedIops { get; set; }

    /// <summary>
    /// Indicates how much throughput to provision for the disk. This sets the number of throughput
    /// mb per second that the disk can handle. Values must be greater than or equal to 1.
    /// </summary>
    [JsonPropertyName("provisionedThroughput")]
    public double? ProvisionedThroughput { get; set; }

    /// <summary>URLs of the zones where the disk should be replicated to.</summary>
    [JsonPropertyName("replicaZones")]
    public IList<string>? ReplicaZones { get; set; }

    /// <summary>
    /// Size of the persistent disk, specified in GB. You can specify this
    /// field when creating a persistent disk using the sourceImage or
    /// sourceSnapshot parameter, or specify it alone to create an empty
    /// persistent disk.
    /// If you specify this field along with sourceImage or sourceSnapshot,
    /// the value of sizeGb must not be less than the size of the sourceImage
    /// or the size of the snapshot.
    /// </summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>
    /// The source snapshot used to create this disk. You can provide this as
    /// a partial or full URL to the resource. For example, the following are
    /// valid values:
    /// </summary>
    [JsonPropertyName("snapshot")]
    public string? Snapshot { get; set; }

    /// <summary>Reference to a Snapshot in compute to populate snapshot.</summary>
    [JsonPropertyName("snapshotRef")]
    public V1beta2RegionDiskSpecInitProviderSnapshotRef? SnapshotRef { get; set; }

    /// <summary>Selector for a Snapshot in compute to populate snapshot.</summary>
    [JsonPropertyName("snapshotSelector")]
    public V1beta2RegionDiskSpecInitProviderSnapshotSelector? SnapshotSelector { get; set; }

    /// <summary>
    /// The source disk used to create this disk. You can provide this as a partial or full URL to the resource.
    /// For example, the following are valid values:
    /// </summary>
    [JsonPropertyName("sourceDisk")]
    public string? SourceDisk { get; set; }

    /// <summary>
    /// The customer-supplied encryption key of the source snapshot. Required
    /// if the source snapshot is protected by a customer-supplied encryption
    /// key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta2RegionDiskSpecInitProviderSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>
    /// URL of the disk type resource describing which disk type to use to
    /// create the disk. Provide this when creating the disk.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecManagementPoliciesEnum>))]
public enum V1beta2RegionDiskSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2RegionDiskSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionDiskSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2RegionDiskSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionDiskSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionDiskSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionDiskSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>RegionDiskSpec defines the desired state of RegionDisk</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskSpec
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
    public V1beta2RegionDiskSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2RegionDiskSpecForProvider ForProvider { get; set; }

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
    public V1beta2RegionDiskSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2RegionDiskSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2RegionDiskSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2RegionDiskSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskStatusAtProviderAsyncPrimaryDisk
{
    /// <summary>Primary disk for asynchronous disk replication.</summary>
    [JsonPropertyName("disk")]
    public string? Disk { get; set; }
}

/// <summary>
/// Encrypts the disk using a customer-supplied encryption key.
/// After you encrypt a disk with a customer-supplied key, you must
/// provide the same key if you use the disk later (e.g. to create a disk
/// snapshot or an image, or to attach the disk to a virtual machine).
/// Customer-supplied encryption keys do not protect access to metadata of
/// the disk.
/// If you do not provide an encryption key when creating the disk, then
/// the disk will be encrypted using an automatically generated key and
/// you do not need to provide a key to use the disk later.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskStatusAtProviderDiskEncryptionKey
{
    /// <summary>The name of the encryption key that is stored in Google Cloud KMS.</summary>
    [JsonPropertyName("kmsKeyName")]
    public string? KmsKeyName { get; set; }

    /// <summary>
    /// (Output)
    /// The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied
    /// encryption key that protects this resource.
    /// </summary>
    [JsonPropertyName("sha256")]
    public string? Sha256 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskStatusAtProviderGuestOsFeatures
{
    /// <summary>
    /// The type of supported feature. Read Enabling guest operating system features to see a list of available options.
    /// Possible values are: MULTI_IP_SUBNET, SECURE_BOOT, SEV_CAPABLE, UEFI_COMPATIBLE, VIRTIO_SCSI_MULTIQUEUE, WINDOWS, GVNIC, SEV_LIVE_MIGRATABLE, SEV_SNP_CAPABLE, SUSPEND_RESUME_COMPATIBLE, TDX_CAPABLE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// The customer-supplied encryption key of the source snapshot. Required
/// if the source snapshot is protected by a customer-supplied encryption
/// key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskStatusAtProviderSourceSnapshotEncryptionKey
{
    /// <summary>
    /// Specifies a 256-bit customer-supplied encryption key, encoded in
    /// RFC 4648 base64 to either encrypt or decrypt this resource.
    /// </summary>
    [JsonPropertyName("rawKey")]
    public string? RawKey { get; set; }

    /// <summary>
    /// (Output)
    /// The RFC 4648 base64 encoded SHA-256 hash of the customer-supplied
    /// encryption key that protects this resource.
    /// </summary>
    [JsonPropertyName("sha256")]
    public string? Sha256 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskStatusAtProvider
{
    /// <summary>
    /// The access mode of the disk.
    /// For example:
    /// </summary>
    [JsonPropertyName("accessMode")]
    public string? AccessMode { get; set; }

    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("asyncPrimaryDisk")]
    public V1beta2RegionDiskStatusAtProviderAsyncPrimaryDisk? AsyncPrimaryDisk { get; set; }

    /// <summary>
    /// If set to true, a snapshot of the disk will be created before it is destroyed.
    /// If your disk is encrypted with customer managed encryption keys these will be reused for the snapshot creation.
    /// The name of the snapshot by default will be {{disk-name}}-YYYYMMDD-HHmm
    /// </summary>
    [JsonPropertyName("createSnapshotBeforeDestroy")]
    public bool? CreateSnapshotBeforeDestroy { get; set; }

    /// <summary>This will set a custom name prefix for the snapshot that&apos;s created when the disk is deleted.</summary>
    [JsonPropertyName("createSnapshotBeforeDestroyPrefix")]
    public string? CreateSnapshotBeforeDestroyPrefix { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>
    /// An optional description of this resource. Provide this property when
    /// you create the resource.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Encrypts the disk using a customer-supplied encryption key.
    /// After you encrypt a disk with a customer-supplied key, you must
    /// provide the same key if you use the disk later (e.g. to create a disk
    /// snapshot or an image, or to attach the disk to a virtual machine).
    /// Customer-supplied encryption keys do not protect access to metadata of
    /// the disk.
    /// If you do not provide an encryption key when creating the disk, then
    /// the disk will be encrypted using an automatically generated key and
    /// you do not need to provide a key to use the disk later.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta2RegionDiskStatusAtProviderDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>The unique identifier for the resource. This identifier is defined by the server.</summary>
    [JsonPropertyName("diskId")]
    public string? DiskId { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>
    /// A list of features to enable on the guest operating system.
    /// Applicable only for bootable disks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<V1beta2RegionDiskStatusAtProviderGuestOsFeatures>? GuestOsFeatures { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/disks/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The fingerprint used for optimistic locking of this resource.  Used
    /// internally during updates.
    /// </summary>
    [JsonPropertyName("labelFingerprint")]
    public string? LabelFingerprint { get; set; }

    /// <summary>Labels to apply to this disk.  A list of key-&gt;value pairs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Last attach timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("lastAttachTimestamp")]
    public string? LastAttachTimestamp { get; set; }

    /// <summary>Last detach timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("lastDetachTimestamp")]
    public string? LastDetachTimestamp { get; set; }

    /// <summary>Any applicable license URI.</summary>
    [JsonPropertyName("licenses")]
    public IList<string>? Licenses { get; set; }

    /// <summary>
    /// Physical block size of the persistent disk, in bytes. If not present
    /// in a request, a default value is used. Currently supported sizes
    /// are 4096 and 16384, other sizes may be added in the future.
    /// If an unsupported value is requested, the error message will list
    /// the supported values for the caller&apos;s project.
    /// </summary>
    [JsonPropertyName("physicalBlockSizeBytes")]
    public double? PhysicalBlockSizeBytes { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Indicates how many IOPS to provision for the disk. This sets the number of I/O operations per second
    /// that the disk can handle. Values must be between 10,000 and 120,000.
    /// For more details, see the Extreme persistent disk documentation.
    /// </summary>
    [JsonPropertyName("provisionedIops")]
    public double? ProvisionedIops { get; set; }

    /// <summary>
    /// Indicates how much throughput to provision for the disk. This sets the number of throughput
    /// mb per second that the disk can handle. Values must be greater than or equal to 1.
    /// </summary>
    [JsonPropertyName("provisionedThroughput")]
    public double? ProvisionedThroughput { get; set; }

    /// <summary>A reference to the region where the disk resides.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>URLs of the zones where the disk should be replicated to.</summary>
    [JsonPropertyName("replicaZones")]
    public IList<string>? ReplicaZones { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>
    /// Size of the persistent disk, specified in GB. You can specify this
    /// field when creating a persistent disk using the sourceImage or
    /// sourceSnapshot parameter, or specify it alone to create an empty
    /// persistent disk.
    /// If you specify this field along with sourceImage or sourceSnapshot,
    /// the value of sizeGb must not be less than the size of the sourceImage
    /// or the size of the snapshot.
    /// </summary>
    [JsonPropertyName("size")]
    public double? Size { get; set; }

    /// <summary>
    /// The source snapshot used to create this disk. You can provide this as
    /// a partial or full URL to the resource. For example, the following are
    /// valid values:
    /// </summary>
    [JsonPropertyName("snapshot")]
    public string? Snapshot { get; set; }

    /// <summary>
    /// The source disk used to create this disk. You can provide this as a partial or full URL to the resource.
    /// For example, the following are valid values:
    /// </summary>
    [JsonPropertyName("sourceDisk")]
    public string? SourceDisk { get; set; }

    /// <summary>
    /// The ID value of the disk used to create this image. This value may
    /// be used to determine whether the image was taken from the current
    /// or a previous instance of a given disk name.
    /// </summary>
    [JsonPropertyName("sourceDiskId")]
    public string? SourceDiskId { get; set; }

    /// <summary>
    /// The customer-supplied encryption key of the source snapshot. Required
    /// if the source snapshot is protected by a customer-supplied encryption
    /// key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta2RegionDiskStatusAtProviderSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>
    /// The unique ID of the snapshot used to create this disk. This value
    /// identifies the exact snapshot that was used to create this persistent
    /// disk. For example, if you created the persistent disk from a snapshot
    /// that was later deleted and recreated under the same name, the source
    /// snapshot ID would identify the exact version of the snapshot that was
    /// used.
    /// </summary>
    [JsonPropertyName("sourceSnapshotId")]
    public string? SourceSnapshotId { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>
    /// URL of the disk type resource describing which disk type to use to
    /// create the disk. Provide this when creating the disk.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// Links to the users of the disk (attached instances) in form:
    /// project/zones/zone/instances/instance
    /// </summary>
    [JsonPropertyName("users")]
    public IList<string>? Users { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskStatusConditions
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

/// <summary>RegionDiskStatus defines the observed state of RegionDisk.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionDiskStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2RegionDiskStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2RegionDiskStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RegionDisk is the Schema for the RegionDisks API. Persistent disks are durable storage devices that function similarly to the physical disks in a desktop or a server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RegionDisk : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2RegionDiskSpec>, IStatus<V1beta2RegionDiskStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RegionDisk";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regiondisks";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegionDisk";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegionDiskSpec defines the desired state of RegionDisk</summary>
    [JsonPropertyName("spec")]
    public required V1beta2RegionDiskSpec Spec { get; set; }

    /// <summary>RegionDiskStatus defines the observed state of RegionDisk.</summary>
    [JsonPropertyName("status")]
    public V1beta2RegionDiskStatus? Status { get; set; }
}