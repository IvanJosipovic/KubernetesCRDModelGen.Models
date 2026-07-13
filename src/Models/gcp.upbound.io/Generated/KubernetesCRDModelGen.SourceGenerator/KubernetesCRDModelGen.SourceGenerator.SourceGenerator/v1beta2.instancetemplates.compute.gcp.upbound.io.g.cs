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
/// <summary>InstanceTemplate is the Schema for the InstanceTemplates API. Manages a VM instance template resource within GCE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InstanceTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1beta2InstanceTemplate>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InstanceTemplateList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "instancetemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceTemplateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2InstanceTemplate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2InstanceTemplate> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecDeletionPolicyEnum>))]
public enum V1beta2InstanceTemplateSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderAdvancedMachineFeatures
{
    /// <summary>Defines whether the instance should have nested virtualization enabled. Defaults to false.</summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary>Whether to enable UEFI networking for instance creation.</summary>
    [JsonPropertyName("enableUefiNetworking")]
    public bool? EnableUefiNetworking { get; set; }

    /// <summary>The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are STANDARD, ENHANCED, and ARCHITECTURAL.</summary>
    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    /// <summary>The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }

    /// <summary>Turbo frequency mode to use for the instance. Supported modes are currently either ALL_CORE_MAX or unset (default).</summary>
    [JsonPropertyName("turboMode")]
    public string? TurboMode { get; set; }

    /// <summary>The number of physical cores to expose to an instance. visible cores info (VC).</summary>
    [JsonPropertyName("visibleCoreCount")]
    public double? VisibleCoreCount { get; set; }
}

/// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderConfidentialInstanceConfig
{
    /// <summary>Defines the confidential computing technology the instance uses. SEV is an AMD feature. TDX is an Intel feature. One of the following values is required: SEV, SEV_SNP, TDX. on_host_maintenance can be set to MIGRATE if confidential_instance_type is set to SEV and min_cpu_platform is set to &quot;AMD Milan&quot;. Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM. If SEV_SNP, currently min_cpu_platform has to be set to &quot;AMD Milan&quot; or this will fail to create the VM.</summary>
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Defines whether the instance should have confidential compute enabled with AMD SEV. If enabled, on_host_maintenance can be set to MIGRATE if min_cpu_platform is set to &quot;AMD Milan&quot;. Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }
}

/// <summary>Encrypts or decrypts a disk using a customer-supplied encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderDiskDiskEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key that is
    /// stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
    /// may be set.
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the
    /// encryption request for the given KMS key. If absent, the Compute Engine
    /// default service account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesRefsPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesRefsPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of ResourcePolicy in compute to populate resourcePolicies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesSelector
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
    public V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A 256-bit [customer-supplied encryption key]
/// (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption),
/// encoded in RFC 4648 base64
/// to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
/// may be set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderDiskSourceImageEncryptionKeyRawKeySecretRef
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
/// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key]
/// (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
/// may be set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderDiskSourceImageEncryptionKeyRsaEncryptedKeySecretRef
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
/// The customer-supplied encryption
/// key of the source image. Required if the source image is protected by a
/// customer-supplied encryption key.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderDiskSourceImageEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key that is
    /// stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
    /// may be set.
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the
    /// encryption request for the given KMS key. If absent, the Compute Engine
    /// default service account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// A 256-bit [customer-supplied encryption key]
    /// (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption),
    /// encoded in RFC 4648 base64
    /// to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
    /// may be set.
    /// </summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta2InstanceTemplateSpecForProviderDiskSourceImageEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key]
    /// (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
    /// may be set.
    /// </summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta2InstanceTemplateSpecForProviderDiskSourceImageEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderDiskSourceRefPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderDiskSourceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderDiskSourceRefPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderDiskSourceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderDiskSourceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecForProviderDiskSourceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecForProviderDiskSourceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Disk in compute to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderDiskSourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceTemplateSpecForProviderDiskSourceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderDiskSourceSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderDiskSourceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderDiskSourceSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderDiskSourceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderDiskSourceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecForProviderDiskSourceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecForProviderDiskSourceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Disk in compute to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderDiskSourceSelector
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
    public V1beta2InstanceTemplateSpecForProviderDiskSourceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A 256-bit [customer-supplied encryption key]
/// (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption),
/// encoded in RFC 4648 base64
/// to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
/// may be set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderDiskSourceSnapshotEncryptionKeyRawKeySecretRef
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
/// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key]
/// (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
/// may be set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderDiskSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef
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
/// The customer-supplied encryption
/// key of the source snapshot. Structure
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderDiskSourceSnapshotEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key that is
    /// stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
    /// may be set.
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the
    /// encryption request for the given KMS key. If absent, the Compute Engine
    /// default service account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// A 256-bit [customer-supplied encryption key]
    /// (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption),
    /// encoded in RFC 4648 base64
    /// to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
    /// may be set.
    /// </summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta2InstanceTemplateSpecForProviderDiskSourceSnapshotEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key]
    /// (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
    /// may be set.
    /// </summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta2InstanceTemplateSpecForProviderDiskSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderDisk
{
    /// <summary>The architecture of the attached disk. Valid values are ARM64 or x86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>
    /// Whether or not the disk should be auto-deleted.
    /// This defaults to true.
    /// </summary>
    [JsonPropertyName("autoDelete")]
    public bool? AutoDelete { get; set; }

    /// <summary>Indicates that this is a boot disk.</summary>
    [JsonPropertyName("boot")]
    public bool? Boot { get; set; }

    /// <summary>
    /// A unique device name that is reflected into the
    /// /dev/  tree of a Linux operating system running within the instance. If not
    /// specified, the server chooses a default device name to apply to this disk.
    /// </summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Encrypts or decrypts a disk using a customer-supplied encryption key.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta2InstanceTemplateSpecForProviderDiskDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>
    /// Name of the disk. When not provided, this defaults
    /// to the name of the instance.
    /// </summary>
    [JsonPropertyName("diskName")]
    public string? DiskName { get; set; }

    /// <summary>
    /// The size of the image in gigabytes. If not
    /// specified, it will inherit the size of its base image. For SCRATCH disks,
    /// the size must be exactly 375GB.
    /// </summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>
    /// The GCE disk type. Such as &quot;pd-ssd&quot;, &quot;local-ssd&quot;,
    /// &quot;pd-balanced&quot; or &quot;pd-standard&quot;, &quot;hyperdisk-balanced&quot;, &quot;hyperdisk-throughput&quot; or &quot;hyperdisk-extreme&quot;.
    /// </summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>A list of features to enable on the guest operating system. Applicable only for bootable images. Read Enabling guest operating system features to see a list of available options.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<string>? GuestOsFeatures { get; set; }

    /// <summary>
    /// Specifies the disk interface to use for attaching this disk,
    /// which is either SCSI or NVME. The default is SCSI. Persistent disks must always use SCSI
    /// and the request will fail if you attempt to attach a persistent disk in any other format
    /// than SCSI. Local SSDs can use either NVME or SCSI.
    /// </summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>
    /// A set of ket/value label pairs to assign to disk created from
    /// this template
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The mode in which to attach this disk, either READ_WRITE
    /// or READ_ONLY. If you are attaching or creating a boot disk, this must
    /// read-write mode.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Indicates how many IOPS to provision for the disk. This
    /// sets the number of I/O operations per second that the disk can handle.
    /// Values must be between 10,000 and 120,000. For more details, see the
    /// Extreme persistent disk documentation.
    /// </summary>
    [JsonPropertyName("provisionedIops")]
    public double? ProvisionedIops { get; set; }

    [JsonPropertyName("provisionedThroughput")]
    public double? ProvisionedThroughput { get; set; }

    /// <summary>A set of key/value resource manager tag pairs to bind to this disk. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>- A list (short name or id) of resource policies to attach to this disk for automatic snapshot creations. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>References to ResourcePolicy in compute to populate resourcePolicies.</summary>
    [JsonPropertyName("resourcePoliciesRefs")]
    public IList<V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesRefs>? ResourcePoliciesRefs { get; set; }

    /// <summary>Selector for a list of ResourcePolicy in compute to populate resourcePolicies.</summary>
    [JsonPropertyName("resourcePoliciesSelector")]
    public V1beta2InstanceTemplateSpecForProviderDiskResourcePoliciesSelector? ResourcePoliciesSelector { get; set; }

    /// <summary>
    /// The name (not self_link)
    /// of the disk (such as those managed by google_compute_disk) to attach.
    /// ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>
    /// The image from which to
    /// initialize this disk. This can be one of: the image&apos;s self_link,
    /// projects/{project}/global/images/{image},
    /// projects/{project}/global/images/family/{family}, global/images/{image},
    /// global/images/family/{family}, family/{family}, {project}/{family},
    /// {project}/{image}, {family}, or {image}.
    /// ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.
    /// </summary>
    [JsonPropertyName("sourceImage")]
    public string? SourceImage { get; set; }

    /// <summary>
    /// The customer-supplied encryption
    /// key of the source image. Required if the source image is protected by a
    /// customer-supplied encryption key.
    /// </summary>
    [JsonPropertyName("sourceImageEncryptionKey")]
    public V1beta2InstanceTemplateSpecForProviderDiskSourceImageEncryptionKey? SourceImageEncryptionKey { get; set; }

    /// <summary>Reference to a Disk in compute to populate source.</summary>
    [JsonPropertyName("sourceRef")]
    public V1beta2InstanceTemplateSpecForProviderDiskSourceRef? SourceRef { get; set; }

    /// <summary>Selector for a Disk in compute to populate source.</summary>
    [JsonPropertyName("sourceSelector")]
    public V1beta2InstanceTemplateSpecForProviderDiskSourceSelector? SourceSelector { get; set; }

    /// <summary>
    /// The source snapshot to create this disk.
    /// ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.
    /// </summary>
    [JsonPropertyName("sourceSnapshot")]
    public string? SourceSnapshot { get; set; }

    /// <summary>
    /// The customer-supplied encryption
    /// key of the source snapshot. Structure
    /// documented below.
    /// </summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta2InstanceTemplateSpecForProviderDiskSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>
    /// The type of GCE disk, can be either &quot;SCRATCH&quot; or
    /// &quot;PERSISTENT&quot;.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderGuestAccelerator
{
    /// <summary>The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderNetworkInterfaceAccessConfig
{
    /// <summary>
    /// The IP address that will be 1:1 mapped to the instance&apos;s
    /// network ip. If not given, one will be generated.
    /// </summary>
    [JsonPropertyName("natIp")]
    public string? NatIp { get; set; }

    /// <summary>
    /// The service-level to be provided for IPv6 traffic when the
    /// subnet has an external subnet. Only PREMIUM and STANDARD tier is valid for IPv6.
    /// </summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderNetworkInterfaceAliasIpRange
{
    /// <summary>
    /// The IP CIDR range represented by this alias IP range. This IP CIDR range
    /// must belong to the specified subnetwork and cannot contain IP addresses reserved by
    /// system or used by other network interfaces. At the time of writing only a
    /// netmask (e.g. /24) may be supplied, with a CIDR format resulting in an API
    /// error.
    /// </summary>
    [JsonPropertyName("ipCidrRange")]
    public string? IpCidrRange { get; set; }

    /// <summary>
    /// The subnetwork secondary range name specifying
    /// the secondary range from which to allocate the IP CIDR range for this alias IP
    /// range. If left unspecified, the primary range of the subnetwork will be used.
    /// </summary>
    [JsonPropertyName("subnetworkRangeName")]
    public string? SubnetworkRangeName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderNetworkInterfaceIpv6AccessConfig
{
    /// <summary>
    /// The service-level to be provided for IPv6 traffic when the
    /// subnet has an external subnet. Only PREMIUM and STANDARD tier is valid for IPv6.
    /// </summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkRefPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkRefPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkSelector
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
    public V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkRefPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkRefPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkSelector
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
    public V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderNetworkInterface
{
    /// <summary>
    /// Access configurations, i.e. IPs via which this
    /// instance can be accessed via the Internet.g. via tunnel or because it is running on another cloud instance
    /// on that network). This block can be specified once per network_interface. Structure documented below.
    /// </summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta2InstanceTemplateSpecForProviderNetworkInterfaceAccessConfig>? AccessConfig { get; set; }

    /// <summary>
    /// An
    /// array of alias IP ranges for this network interface. Can only be specified for network
    /// interfaces on subnet-mode networks. Structure documented below.
    /// </summary>
    [JsonPropertyName("aliasIpRange")]
    public IList<V1beta2InstanceTemplateSpecForProviderNetworkInterfaceAliasIpRange>? AliasIpRange { get; set; }

    [JsonPropertyName("internalIpv6PrefixLength")]
    public double? InternalIpv6PrefixLength { get; set; }

    /// <summary>
    /// An array of IPv6 access configurations for this interface.
    /// Currently, only one IPv6 access config, DIRECT_IPV6, is supported. If there is no ipv6AccessConfig
    /// specified, then this instance will have no external IPv6 Internet access. Structure documented below.
    /// </summary>
    [JsonPropertyName("ipv6AccessConfig")]
    public IList<V1beta2InstanceTemplateSpecForProviderNetworkInterfaceIpv6AccessConfig>? Ipv6AccessConfig { get; set; }

    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>
    /// The name or self_link of the network to attach this interface to.
    /// Use network attribute for Legacy or Auto subnetted networks and
    /// subnetwork for custom subnetted networks.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// The private IP address to assign to the instance. If
    /// empty, the address will be automatically assigned.
    /// </summary>
    [JsonPropertyName("networkIp")]
    public string? NetworkIp { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta2InstanceTemplateSpecForProviderNetworkInterfaceNetworkSelector? NetworkSelector { get; set; }

    /// <summary>The type of vNIC to be used on this interface. Possible values: GVNIC, VIRTIO_NET, MRDMA, IRDMA.</summary>
    [JsonPropertyName("nicType")]
    public string? NicType { get; set; }

    /// <summary>The networking queue count that&apos;s specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.</summary>
    [JsonPropertyName("queueCount")]
    public double? QueueCount { get; set; }

    /// <summary>The stack type for this network interface to identify whether the IPv6 feature is enabled or not. Values are IPV4_IPV6, IPV6_ONLY or IPV4_ONLY. If not specified, IPV4_ONLY will be used.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }

    /// <summary>
    /// the name of the subnetwork to attach this interface
    /// to. The subnetwork must exist in the same region this instance will be
    /// created in. Either network or subnetwork must be provided.
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>
    /// The ID of the project in which the subnetwork belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("subnetworkProject")]
    public string? SubnetworkProject { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta2InstanceTemplateSpecForProviderNetworkInterfaceSubnetworkSelector? SubnetworkSelector { get; set; }
}

/// <summary>
/// os-features, and network_interface.0.nic-type must be GVNIC
/// in order for this setting to take effect.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderNetworkPerformanceConfig
{
    /// <summary>The egress bandwidth tier to enable. Possible values: TIER_1, DEFAULT</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

/// <summary>
/// Specifies the label selector for the reservation to use..
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderReservationAffinitySpecificReservation
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Specifies the reservations that this instance can consume from.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderReservationAffinity
{
    /// <summary>
    /// Specifies the label selector for the reservation to use..
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("specificReservation")]
    public V1beta2InstanceTemplateSpecForProviderReservationAffinitySpecificReservation? SpecificReservation { get; set; }

    /// <summary>The type of reservation from which this instance can consume resources.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderSchedulingLocalSsdRecoveryTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented with a 0
    /// seconds field and a positive nanos field. Must be from 0 to
    /// 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// The value must be between 1 and 3600, which is 3,600 seconds (one hour).`
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderSchedulingMaxRunDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented with a 0
    /// seconds field and a positive nanos field. Must be from 0 to
    /// 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// The value must be between 1 and 3600, which is 3,600 seconds (one hour).`
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderSchedulingNodeAffinities
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// The operator. Can be IN for node-affinities
    /// or NOT_IN for anti-affinities.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderSchedulingOnInstanceStopAction
{
    /// <summary>Whether to discard local SSDs attached to the VM while terminating using max_run_duration. Only supports true at this point.</summary>
    [JsonPropertyName("discardLocalSsd")]
    public bool? DiscardLocalSsd { get; set; }
}

/// <summary>
/// The scheduling strategy to use. More details about
/// this configuration option are detailed below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderScheduling
{
    /// <summary>
    /// Specifies whether the instance should be
    /// automatically restarted if it is terminated by Compute Engine (not
    /// terminated by a user). This defaults to true.
    /// </summary>
    [JsonPropertyName("automaticRestart")]
    public bool? AutomaticRestart { get; set; }

    /// <summary>Specifies the availability domain to place the instance in. The value must be a number between 1 and the number of availability domains specified in the spread placement policy attached to the instance.</summary>
    [JsonPropertyName("availabilityDomain")]
    public double? AvailabilityDomain { get; set; }

    /// <summary>Describe the type of termination action for SPOT VM. Can be STOP or DELETE.  Read more on here</summary>
    [JsonPropertyName("instanceTerminationAction")]
    public string? InstanceTerminationAction { get; set; }

    /// <summary>io/docs/providers/google/guides/provider_versions.html) Specifies the maximum amount of time a Local Ssd Vm should wait while recovery of the Local Ssd state is attempted. Its value should be in between 0 and 168 hours with hour granularity and the default value being 1 hour. Structure is documented below.</summary>
    [JsonPropertyName("localSsdRecoveryTimeout")]
    public IList<V1beta2InstanceTemplateSpecForProviderSchedulingLocalSsdRecoveryTimeout>? LocalSsdRecoveryTimeout { get; set; }

    /// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
    [JsonPropertyName("maxRunDuration")]
    public V1beta2InstanceTemplateSpecForProviderSchedulingMaxRunDuration? MaxRunDuration { get; set; }

    [JsonPropertyName("minNodeCpus")]
    public double? MinNodeCpus { get; set; }

    /// <summary>
    /// Specifies node affinities or anti-affinities
    /// to determine which sole-tenant nodes your instances and managed instance
    /// groups will use as host systems. Read more on sole-tenant node creation
    /// here.
    /// Structure documented below.
    /// </summary>
    [JsonPropertyName("nodeAffinities")]
    public IList<V1beta2InstanceTemplateSpecForProviderSchedulingNodeAffinities>? NodeAffinities { get; set; }

    /// <summary>
    /// Defines the maintenance behavior for this
    /// instance.
    /// </summary>
    [JsonPropertyName("onHostMaintenance")]
    public string? OnHostMaintenance { get; set; }

    /// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
    [JsonPropertyName("onInstanceStopAction")]
    public V1beta2InstanceTemplateSpecForProviderSchedulingOnInstanceStopAction? OnInstanceStopAction { get; set; }

    /// <summary>
    /// Allows instance to be preempted. This defaults to
    /// false. Read more on this
    /// here.
    /// </summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>
    /// Describe the type of preemptible VM. This field accepts the value STANDARD or SPOT. If the value is STANDARD, there will be no discount. If this   is set to SPOT,
    /// preemptible should be true and automatic_restart should be
    /// false. For more info about
    /// SPOT, read here
    /// </summary>
    [JsonPropertyName("provisioningModel")]
    public string? ProvisioningModel { get; set; }

    /// <summary>Specifies the timestamp, when the instance will be terminated, in RFC3339 text format. If specified, the instance termination action will be performed at the termination time.</summary>
    [JsonPropertyName("terminationTime")]
    public string? TerminationTime { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderServiceAccountEmailRefPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderServiceAccountEmailRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderServiceAccountEmailRefPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderServiceAccountEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderServiceAccountEmailRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecForProviderServiceAccountEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecForProviderServiceAccountEmailRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate email.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceTemplateSpecForProviderServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderServiceAccountEmailSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderServiceAccountEmailSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecForProviderServiceAccountEmailSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecForProviderServiceAccountEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderServiceAccountEmailSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecForProviderServiceAccountEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecForProviderServiceAccountEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate email.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderServiceAccountEmailSelector
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
    public V1beta2InstanceTemplateSpecForProviderServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>Service account to attach to the instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderServiceAccount
{
    /// <summary>
    /// The service account e-mail address. If not given, the
    /// default Google Compute Engine service account is used.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate email.</summary>
    [JsonPropertyName("emailRef")]
    public V1beta2InstanceTemplateSpecForProviderServiceAccountEmailRef? EmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate email.</summary>
    [JsonPropertyName("emailSelector")]
    public V1beta2InstanceTemplateSpecForProviderServiceAccountEmailSelector? EmailSelector { get; set; }

    /// <summary>
    /// A list of service scopes. Both OAuth2 URLs and gcloud
    /// short names are supported. To allow full access to all Cloud APIs, use the
    /// cloud-platform scope. See a complete list of scopes here.
    /// </summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>
/// Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below.
/// Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProviderShieldedInstanceConfig
{
    /// <summary>- Compare the most recent boot measurements to the integrity policy baseline and return a pair of pass/fail results depending on whether they match or not. Defaults to true.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>- Verify the digital signature of all boot components, and halt the boot process if signature verification fails. Defaults to false.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>- Use a virtualized trusted platform module, which is a specialized computer chip you can use to encrypt objects like keys and certificates. Defaults to true.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecForProvider
{
    /// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading on this VM. Structure is documented below</summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta2InstanceTemplateSpecForProviderAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary>
    /// Whether to allow sending and receiving of
    /// packets with non-matching source or destination IPs. This defaults to false.
    /// </summary>
    [JsonPropertyName("canIpForward")]
    public bool? CanIpForward { get; set; }

    /// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public V1beta2InstanceTemplateSpecForProviderConfidentialInstanceConfig? ConfidentialInstanceConfig { get; set; }

    /// <summary>A brief description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Disks to attach to instances created from this template.
    /// This can be specified multiple times for multiple disks. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("disk")]
    public IList<V1beta2InstanceTemplateSpecForProviderDisk>? Disk { get; set; }

    /// <summary>List of the type and count of accelerator cards attached to the instance. Structure documented below.</summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta2InstanceTemplateSpecForProviderGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary>
    /// A brief description to use for instances
    /// created from this template.
    /// </summary>
    [JsonPropertyName("instanceDescription")]
    public string? InstanceDescription { get; set; }

    /// <summary>Action to be taken when a customer&apos;s encryption key is revoked. Supports STOP and NONE, with NONE being the default.</summary>
    [JsonPropertyName("keyRevocationActionType")]
    public string? KeyRevocationActionType { get; set; }

    /// <summary>
    /// A set of key/value label pairs to assign to instances
    /// created from this template.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The machine type to create.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// Metadata key/value pairs to make available from
    /// within instances created from this template.
    /// </summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// An alternative to using the
    /// startup-script metadata key, mostly to match the compute_instance resource.
    /// This replaces the startup-script metadata key on the created instance and
    /// thus the two mechanisms are not allowed to be used simultaneously.
    /// </summary>
    [JsonPropertyName("metadataStartupScript")]
    public string? MetadataStartupScript { get; set; }

    /// <summary>
    /// Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as
    /// Intel Haswell or Intel Skylake. See the complete list here.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The name of the instance template.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Creates a unique name beginning with the specified
    /// prefix. Conflicts with name. Max length is 54 characters.
    /// Prefixes with lengths longer than 37 characters will use a shortened
    /// UUID that will be more prone to collisions.
    /// </summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>
    /// Networks to attach to instances created from
    /// this template. This can be specified multiple times for multiple networks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta2InstanceTemplateSpecForProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>
    /// os-features, and network_interface.0.nic-type must be GVNIC
    /// in order for this setting to take effect.
    /// </summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta2InstanceTemplateSpecForProviderNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// An instance template is a global resource that is not
    /// bound to a zone or a region. However, you can still specify some regional
    /// resources in an instance template, which restricts the template to the
    /// region where that resource resides. For example, a custom subnetwork
    /// resource is tied to a specific region. Defaults to the region of the
    /// Provider if no value is given.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Specifies the reservations that this instance can consume from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta2InstanceTemplateSpecForProviderReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>A set of key/value resource manager tag pairs to bind to the instances. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>- A list of self_links of resource policies to attach to the instance. Modifying this list will cause the instance to recreate. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>
    /// The scheduling strategy to use. More details about
    /// this configuration option are detailed below.
    /// </summary>
    [JsonPropertyName("scheduling")]
    public V1beta2InstanceTemplateSpecForProviderScheduling? Scheduling { get; set; }

    /// <summary>Service account to attach to the instance. Structure is documented below.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1beta2InstanceTemplateSpecForProviderServiceAccount? ServiceAccount { get; set; }

    /// <summary>
    /// Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below.
    /// Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here.
    /// </summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta2InstanceTemplateSpecForProviderShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Tags to attach to the instance.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderAdvancedMachineFeatures
{
    /// <summary>Defines whether the instance should have nested virtualization enabled. Defaults to false.</summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary>Whether to enable UEFI networking for instance creation.</summary>
    [JsonPropertyName("enableUefiNetworking")]
    public bool? EnableUefiNetworking { get; set; }

    /// <summary>The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are STANDARD, ENHANCED, and ARCHITECTURAL.</summary>
    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    /// <summary>The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }

    /// <summary>Turbo frequency mode to use for the instance. Supported modes are currently either ALL_CORE_MAX or unset (default).</summary>
    [JsonPropertyName("turboMode")]
    public string? TurboMode { get; set; }

    /// <summary>The number of physical cores to expose to an instance. visible cores info (VC).</summary>
    [JsonPropertyName("visibleCoreCount")]
    public double? VisibleCoreCount { get; set; }
}

/// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderConfidentialInstanceConfig
{
    /// <summary>Defines the confidential computing technology the instance uses. SEV is an AMD feature. TDX is an Intel feature. One of the following values is required: SEV, SEV_SNP, TDX. on_host_maintenance can be set to MIGRATE if confidential_instance_type is set to SEV and min_cpu_platform is set to &quot;AMD Milan&quot;. Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM. If SEV_SNP, currently min_cpu_platform has to be set to &quot;AMD Milan&quot; or this will fail to create the VM.</summary>
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Defines whether the instance should have confidential compute enabled with AMD SEV. If enabled, on_host_maintenance can be set to MIGRATE if min_cpu_platform is set to &quot;AMD Milan&quot;. Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }
}

/// <summary>Encrypts or decrypts a disk using a customer-supplied encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderDiskDiskEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key that is
    /// stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
    /// may be set.
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the
    /// encryption request for the given KMS key. If absent, the Compute Engine
    /// default service account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesRefsPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesRefsPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of ResourcePolicy in compute to populate resourcePolicies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesSelector
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
    public V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A 256-bit [customer-supplied encryption key]
/// (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption),
/// encoded in RFC 4648 base64
/// to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
/// may be set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderDiskSourceImageEncryptionKeyRawKeySecretRef
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
/// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key]
/// (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
/// may be set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderDiskSourceImageEncryptionKeyRsaEncryptedKeySecretRef
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
/// The customer-supplied encryption
/// key of the source image. Required if the source image is protected by a
/// customer-supplied encryption key.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderDiskSourceImageEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key that is
    /// stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
    /// may be set.
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the
    /// encryption request for the given KMS key. If absent, the Compute Engine
    /// default service account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// A 256-bit [customer-supplied encryption key]
    /// (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption),
    /// encoded in RFC 4648 base64
    /// to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
    /// may be set.
    /// </summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta2InstanceTemplateSpecInitProviderDiskSourceImageEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key]
    /// (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
    /// may be set.
    /// </summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta2InstanceTemplateSpecInitProviderDiskSourceImageEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderDiskSourceRefPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderDiskSourceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderDiskSourceRefPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderDiskSourceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderDiskSourceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecInitProviderDiskSourceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecInitProviderDiskSourceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Disk in compute to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderDiskSourceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceTemplateSpecInitProviderDiskSourceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderDiskSourceSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderDiskSourceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderDiskSourceSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderDiskSourceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderDiskSourceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecInitProviderDiskSourceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecInitProviderDiskSourceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Disk in compute to populate source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderDiskSourceSelector
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
    public V1beta2InstanceTemplateSpecInitProviderDiskSourceSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// A 256-bit [customer-supplied encryption key]
/// (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption),
/// encoded in RFC 4648 base64
/// to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
/// may be set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderDiskSourceSnapshotEncryptionKeyRawKeySecretRef
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
/// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key]
/// (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
/// may be set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderDiskSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef
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
/// The customer-supplied encryption
/// key of the source snapshot. Structure
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderDiskSourceSnapshotEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key that is
    /// stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
    /// may be set.
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the
    /// encryption request for the given KMS key. If absent, the Compute Engine
    /// default service account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }

    /// <summary>
    /// A 256-bit [customer-supplied encryption key]
    /// (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption),
    /// encoded in RFC 4648 base64
    /// to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
    /// may be set.
    /// </summary>
    [JsonPropertyName("rawKeySecretRef")]
    public V1beta2InstanceTemplateSpecInitProviderDiskSourceSnapshotEncryptionKeyRawKeySecretRef? RawKeySecretRef { get; set; }

    /// <summary>
    /// Specifies an RFC 4648 base64 encoded, RSA-wrapped 2048-bit [customer-supplied encryption key]
    /// (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption) to decrypt this snapshot. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
    /// may be set.
    /// </summary>
    [JsonPropertyName("rsaEncryptedKeySecretRef")]
    public V1beta2InstanceTemplateSpecInitProviderDiskSourceSnapshotEncryptionKeyRsaEncryptedKeySecretRef? RsaEncryptedKeySecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderDisk
{
    /// <summary>The architecture of the attached disk. Valid values are ARM64 or x86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>
    /// Whether or not the disk should be auto-deleted.
    /// This defaults to true.
    /// </summary>
    [JsonPropertyName("autoDelete")]
    public bool? AutoDelete { get; set; }

    /// <summary>Indicates that this is a boot disk.</summary>
    [JsonPropertyName("boot")]
    public bool? Boot { get; set; }

    /// <summary>
    /// A unique device name that is reflected into the
    /// /dev/  tree of a Linux operating system running within the instance. If not
    /// specified, the server chooses a default device name to apply to this disk.
    /// </summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Encrypts or decrypts a disk using a customer-supplied encryption key.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta2InstanceTemplateSpecInitProviderDiskDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>
    /// Name of the disk. When not provided, this defaults
    /// to the name of the instance.
    /// </summary>
    [JsonPropertyName("diskName")]
    public string? DiskName { get; set; }

    /// <summary>
    /// The size of the image in gigabytes. If not
    /// specified, it will inherit the size of its base image. For SCRATCH disks,
    /// the size must be exactly 375GB.
    /// </summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>
    /// The GCE disk type. Such as &quot;pd-ssd&quot;, &quot;local-ssd&quot;,
    /// &quot;pd-balanced&quot; or &quot;pd-standard&quot;, &quot;hyperdisk-balanced&quot;, &quot;hyperdisk-throughput&quot; or &quot;hyperdisk-extreme&quot;.
    /// </summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>A list of features to enable on the guest operating system. Applicable only for bootable images. Read Enabling guest operating system features to see a list of available options.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<string>? GuestOsFeatures { get; set; }

    /// <summary>
    /// Specifies the disk interface to use for attaching this disk,
    /// which is either SCSI or NVME. The default is SCSI. Persistent disks must always use SCSI
    /// and the request will fail if you attempt to attach a persistent disk in any other format
    /// than SCSI. Local SSDs can use either NVME or SCSI.
    /// </summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>
    /// A set of ket/value label pairs to assign to disk created from
    /// this template
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The mode in which to attach this disk, either READ_WRITE
    /// or READ_ONLY. If you are attaching or creating a boot disk, this must
    /// read-write mode.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Indicates how many IOPS to provision for the disk. This
    /// sets the number of I/O operations per second that the disk can handle.
    /// Values must be between 10,000 and 120,000. For more details, see the
    /// Extreme persistent disk documentation.
    /// </summary>
    [JsonPropertyName("provisionedIops")]
    public double? ProvisionedIops { get; set; }

    [JsonPropertyName("provisionedThroughput")]
    public double? ProvisionedThroughput { get; set; }

    /// <summary>A set of key/value resource manager tag pairs to bind to this disk. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>- A list (short name or id) of resource policies to attach to this disk for automatic snapshot creations. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>References to ResourcePolicy in compute to populate resourcePolicies.</summary>
    [JsonPropertyName("resourcePoliciesRefs")]
    public IList<V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesRefs>? ResourcePoliciesRefs { get; set; }

    /// <summary>Selector for a list of ResourcePolicy in compute to populate resourcePolicies.</summary>
    [JsonPropertyName("resourcePoliciesSelector")]
    public V1beta2InstanceTemplateSpecInitProviderDiskResourcePoliciesSelector? ResourcePoliciesSelector { get; set; }

    /// <summary>
    /// The name (not self_link)
    /// of the disk (such as those managed by google_compute_disk) to attach.
    /// ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>
    /// The image from which to
    /// initialize this disk. This can be one of: the image&apos;s self_link,
    /// projects/{project}/global/images/{image},
    /// projects/{project}/global/images/family/{family}, global/images/{image},
    /// global/images/family/{family}, family/{family}, {project}/{family},
    /// {project}/{image}, {family}, or {image}.
    /// ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.
    /// </summary>
    [JsonPropertyName("sourceImage")]
    public string? SourceImage { get; set; }

    /// <summary>
    /// The customer-supplied encryption
    /// key of the source image. Required if the source image is protected by a
    /// customer-supplied encryption key.
    /// </summary>
    [JsonPropertyName("sourceImageEncryptionKey")]
    public V1beta2InstanceTemplateSpecInitProviderDiskSourceImageEncryptionKey? SourceImageEncryptionKey { get; set; }

    /// <summary>Reference to a Disk in compute to populate source.</summary>
    [JsonPropertyName("sourceRef")]
    public V1beta2InstanceTemplateSpecInitProviderDiskSourceRef? SourceRef { get; set; }

    /// <summary>Selector for a Disk in compute to populate source.</summary>
    [JsonPropertyName("sourceSelector")]
    public V1beta2InstanceTemplateSpecInitProviderDiskSourceSelector? SourceSelector { get; set; }

    /// <summary>
    /// The source snapshot to create this disk.
    /// ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.
    /// </summary>
    [JsonPropertyName("sourceSnapshot")]
    public string? SourceSnapshot { get; set; }

    /// <summary>
    /// The customer-supplied encryption
    /// key of the source snapshot. Structure
    /// documented below.
    /// </summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta2InstanceTemplateSpecInitProviderDiskSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>
    /// The type of GCE disk, can be either &quot;SCRATCH&quot; or
    /// &quot;PERSISTENT&quot;.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderGuestAccelerator
{
    /// <summary>The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceAccessConfig
{
    /// <summary>
    /// The IP address that will be 1:1 mapped to the instance&apos;s
    /// network ip. If not given, one will be generated.
    /// </summary>
    [JsonPropertyName("natIp")]
    public string? NatIp { get; set; }

    /// <summary>
    /// The service-level to be provided for IPv6 traffic when the
    /// subnet has an external subnet. Only PREMIUM and STANDARD tier is valid for IPv6.
    /// </summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceAliasIpRange
{
    /// <summary>
    /// The IP CIDR range represented by this alias IP range. This IP CIDR range
    /// must belong to the specified subnetwork and cannot contain IP addresses reserved by
    /// system or used by other network interfaces. At the time of writing only a
    /// netmask (e.g. /24) may be supplied, with a CIDR format resulting in an API
    /// error.
    /// </summary>
    [JsonPropertyName("ipCidrRange")]
    public string? IpCidrRange { get; set; }

    /// <summary>
    /// The subnetwork secondary range name specifying
    /// the secondary range from which to allocate the IP CIDR range for this alias IP
    /// range. If left unspecified, the primary range of the subnetwork will be used.
    /// </summary>
    [JsonPropertyName("subnetworkRangeName")]
    public string? SubnetworkRangeName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceIpv6AccessConfig
{
    /// <summary>
    /// The service-level to be provided for IPv6 traffic when the
    /// subnet has an external subnet. Only PREMIUM and STANDARD tier is valid for IPv6.
    /// </summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkRefPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkRefPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Network in compute to populate network.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkSelector
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
    public V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkRefPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkRefPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkSelector
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
    public V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderNetworkInterface
{
    /// <summary>
    /// Access configurations, i.e. IPs via which this
    /// instance can be accessed via the Internet.g. via tunnel or because it is running on another cloud instance
    /// on that network). This block can be specified once per network_interface. Structure documented below.
    /// </summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceAccessConfig>? AccessConfig { get; set; }

    /// <summary>
    /// An
    /// array of alias IP ranges for this network interface. Can only be specified for network
    /// interfaces on subnet-mode networks. Structure documented below.
    /// </summary>
    [JsonPropertyName("aliasIpRange")]
    public IList<V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceAliasIpRange>? AliasIpRange { get; set; }

    [JsonPropertyName("internalIpv6PrefixLength")]
    public double? InternalIpv6PrefixLength { get; set; }

    /// <summary>
    /// An array of IPv6 access configurations for this interface.
    /// Currently, only one IPv6 access config, DIRECT_IPV6, is supported. If there is no ipv6AccessConfig
    /// specified, then this instance will have no external IPv6 Internet access. Structure documented below.
    /// </summary>
    [JsonPropertyName("ipv6AccessConfig")]
    public IList<V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceIpv6AccessConfig>? Ipv6AccessConfig { get; set; }

    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>
    /// The name or self_link of the network to attach this interface to.
    /// Use network attribute for Legacy or Auto subnetted networks and
    /// subnetwork for custom subnetted networks.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// The private IP address to assign to the instance. If
    /// empty, the address will be automatically assigned.
    /// </summary>
    [JsonPropertyName("networkIp")]
    public string? NetworkIp { get; set; }

    /// <summary>Reference to a Network in compute to populate network.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkRef? NetworkRef { get; set; }

    /// <summary>Selector for a Network in compute to populate network.</summary>
    [JsonPropertyName("networkSelector")]
    public V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceNetworkSelector? NetworkSelector { get; set; }

    /// <summary>The type of vNIC to be used on this interface. Possible values: GVNIC, VIRTIO_NET, MRDMA, IRDMA.</summary>
    [JsonPropertyName("nicType")]
    public string? NicType { get; set; }

    /// <summary>The networking queue count that&apos;s specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.</summary>
    [JsonPropertyName("queueCount")]
    public double? QueueCount { get; set; }

    /// <summary>The stack type for this network interface to identify whether the IPv6 feature is enabled or not. Values are IPV4_IPV6, IPV6_ONLY or IPV4_ONLY. If not specified, IPV4_ONLY will be used.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }

    /// <summary>
    /// the name of the subnetwork to attach this interface
    /// to. The subnetwork must exist in the same region this instance will be
    /// created in. Either network or subnetwork must be provided.
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>
    /// The ID of the project in which the subnetwork belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("subnetworkProject")]
    public string? SubnetworkProject { get; set; }

    /// <summary>Reference to a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Selector for a Subnetwork in compute to populate subnetwork.</summary>
    [JsonPropertyName("subnetworkSelector")]
    public V1beta2InstanceTemplateSpecInitProviderNetworkInterfaceSubnetworkSelector? SubnetworkSelector { get; set; }
}

/// <summary>
/// os-features, and network_interface.0.nic-type must be GVNIC
/// in order for this setting to take effect.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderNetworkPerformanceConfig
{
    /// <summary>The egress bandwidth tier to enable. Possible values: TIER_1, DEFAULT</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

/// <summary>
/// Specifies the label selector for the reservation to use..
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderReservationAffinitySpecificReservation
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Specifies the reservations that this instance can consume from.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderReservationAffinity
{
    /// <summary>
    /// Specifies the label selector for the reservation to use..
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("specificReservation")]
    public V1beta2InstanceTemplateSpecInitProviderReservationAffinitySpecificReservation? SpecificReservation { get; set; }

    /// <summary>The type of reservation from which this instance can consume resources.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderSchedulingLocalSsdRecoveryTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented with a 0
    /// seconds field and a positive nanos field. Must be from 0 to
    /// 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// The value must be between 1 and 3600, which is 3,600 seconds (one hour).`
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderSchedulingMaxRunDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented with a 0
    /// seconds field and a positive nanos field. Must be from 0 to
    /// 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// The value must be between 1 and 3600, which is 3,600 seconds (one hour).`
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderSchedulingNodeAffinities
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// The operator. Can be IN for node-affinities
    /// or NOT_IN for anti-affinities.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderSchedulingOnInstanceStopAction
{
    /// <summary>Whether to discard local SSDs attached to the VM while terminating using max_run_duration. Only supports true at this point.</summary>
    [JsonPropertyName("discardLocalSsd")]
    public bool? DiscardLocalSsd { get; set; }
}

/// <summary>
/// The scheduling strategy to use. More details about
/// this configuration option are detailed below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderScheduling
{
    /// <summary>
    /// Specifies whether the instance should be
    /// automatically restarted if it is terminated by Compute Engine (not
    /// terminated by a user). This defaults to true.
    /// </summary>
    [JsonPropertyName("automaticRestart")]
    public bool? AutomaticRestart { get; set; }

    /// <summary>Specifies the availability domain to place the instance in. The value must be a number between 1 and the number of availability domains specified in the spread placement policy attached to the instance.</summary>
    [JsonPropertyName("availabilityDomain")]
    public double? AvailabilityDomain { get; set; }

    /// <summary>Describe the type of termination action for SPOT VM. Can be STOP or DELETE.  Read more on here</summary>
    [JsonPropertyName("instanceTerminationAction")]
    public string? InstanceTerminationAction { get; set; }

    /// <summary>io/docs/providers/google/guides/provider_versions.html) Specifies the maximum amount of time a Local Ssd Vm should wait while recovery of the Local Ssd state is attempted. Its value should be in between 0 and 168 hours with hour granularity and the default value being 1 hour. Structure is documented below.</summary>
    [JsonPropertyName("localSsdRecoveryTimeout")]
    public IList<V1beta2InstanceTemplateSpecInitProviderSchedulingLocalSsdRecoveryTimeout>? LocalSsdRecoveryTimeout { get; set; }

    /// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
    [JsonPropertyName("maxRunDuration")]
    public V1beta2InstanceTemplateSpecInitProviderSchedulingMaxRunDuration? MaxRunDuration { get; set; }

    [JsonPropertyName("minNodeCpus")]
    public double? MinNodeCpus { get; set; }

    /// <summary>
    /// Specifies node affinities or anti-affinities
    /// to determine which sole-tenant nodes your instances and managed instance
    /// groups will use as host systems. Read more on sole-tenant node creation
    /// here.
    /// Structure documented below.
    /// </summary>
    [JsonPropertyName("nodeAffinities")]
    public IList<V1beta2InstanceTemplateSpecInitProviderSchedulingNodeAffinities>? NodeAffinities { get; set; }

    /// <summary>
    /// Defines the maintenance behavior for this
    /// instance.
    /// </summary>
    [JsonPropertyName("onHostMaintenance")]
    public string? OnHostMaintenance { get; set; }

    /// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
    [JsonPropertyName("onInstanceStopAction")]
    public V1beta2InstanceTemplateSpecInitProviderSchedulingOnInstanceStopAction? OnInstanceStopAction { get; set; }

    /// <summary>
    /// Allows instance to be preempted. This defaults to
    /// false. Read more on this
    /// here.
    /// </summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>
    /// Describe the type of preemptible VM. This field accepts the value STANDARD or SPOT. If the value is STANDARD, there will be no discount. If this   is set to SPOT,
    /// preemptible should be true and automatic_restart should be
    /// false. For more info about
    /// SPOT, read here
    /// </summary>
    [JsonPropertyName("provisioningModel")]
    public string? ProvisioningModel { get; set; }

    /// <summary>Specifies the timestamp, when the instance will be terminated, in RFC3339 text format. If specified, the instance termination action will be performed at the termination time.</summary>
    [JsonPropertyName("terminationTime")]
    public string? TerminationTime { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailRefPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailRefPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ServiceAccount in cloudplatform to populate email.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailSelectorPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailSelectorPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ServiceAccount in cloudplatform to populate email.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailSelector
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
    public V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailSelectorPolicy? Policy { get; set; }
}

/// <summary>Service account to attach to the instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderServiceAccount
{
    /// <summary>
    /// The service account e-mail address. If not given, the
    /// default Google Compute Engine service account is used.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Reference to a ServiceAccount in cloudplatform to populate email.</summary>
    [JsonPropertyName("emailRef")]
    public V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailRef? EmailRef { get; set; }

    /// <summary>Selector for a ServiceAccount in cloudplatform to populate email.</summary>
    [JsonPropertyName("emailSelector")]
    public V1beta2InstanceTemplateSpecInitProviderServiceAccountEmailSelector? EmailSelector { get; set; }

    /// <summary>
    /// A list of service scopes. Both OAuth2 URLs and gcloud
    /// short names are supported. To allow full access to all Cloud APIs, use the
    /// cloud-platform scope. See a complete list of scopes here.
    /// </summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>
/// Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below.
/// Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecInitProviderShieldedInstanceConfig
{
    /// <summary>- Compare the most recent boot measurements to the integrity policy baseline and return a pair of pass/fail results depending on whether they match or not. Defaults to true.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>- Verify the digital signature of all boot components, and halt the boot process if signature verification fails. Defaults to false.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>- Use a virtualized trusted platform module, which is a specialized computer chip you can use to encrypt objects like keys and certificates. Defaults to true.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
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
public partial class V1beta2InstanceTemplateSpecInitProvider
{
    /// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading on this VM. Structure is documented below</summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta2InstanceTemplateSpecInitProviderAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary>
    /// Whether to allow sending and receiving of
    /// packets with non-matching source or destination IPs. This defaults to false.
    /// </summary>
    [JsonPropertyName("canIpForward")]
    public bool? CanIpForward { get; set; }

    /// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public V1beta2InstanceTemplateSpecInitProviderConfidentialInstanceConfig? ConfidentialInstanceConfig { get; set; }

    /// <summary>A brief description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Disks to attach to instances created from this template.
    /// This can be specified multiple times for multiple disks. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("disk")]
    public IList<V1beta2InstanceTemplateSpecInitProviderDisk>? Disk { get; set; }

    /// <summary>List of the type and count of accelerator cards attached to the instance. Structure documented below.</summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta2InstanceTemplateSpecInitProviderGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary>
    /// A brief description to use for instances
    /// created from this template.
    /// </summary>
    [JsonPropertyName("instanceDescription")]
    public string? InstanceDescription { get; set; }

    /// <summary>Action to be taken when a customer&apos;s encryption key is revoked. Supports STOP and NONE, with NONE being the default.</summary>
    [JsonPropertyName("keyRevocationActionType")]
    public string? KeyRevocationActionType { get; set; }

    /// <summary>
    /// A set of key/value label pairs to assign to instances
    /// created from this template.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The machine type to create.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// Metadata key/value pairs to make available from
    /// within instances created from this template.
    /// </summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>
    /// An alternative to using the
    /// startup-script metadata key, mostly to match the compute_instance resource.
    /// This replaces the startup-script metadata key on the created instance and
    /// thus the two mechanisms are not allowed to be used simultaneously.
    /// </summary>
    [JsonPropertyName("metadataStartupScript")]
    public string? MetadataStartupScript { get; set; }

    /// <summary>
    /// Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as
    /// Intel Haswell or Intel Skylake. See the complete list here.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The name of the instance template.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Creates a unique name beginning with the specified
    /// prefix. Conflicts with name. Max length is 54 characters.
    /// Prefixes with lengths longer than 37 characters will use a shortened
    /// UUID that will be more prone to collisions.
    /// </summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>
    /// Networks to attach to instances created from
    /// this template. This can be specified multiple times for multiple networks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta2InstanceTemplateSpecInitProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>
    /// os-features, and network_interface.0.nic-type must be GVNIC
    /// in order for this setting to take effect.
    /// </summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta2InstanceTemplateSpecInitProviderNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// An instance template is a global resource that is not
    /// bound to a zone or a region. However, you can still specify some regional
    /// resources in an instance template, which restricts the template to the
    /// region where that resource resides. For example, a custom subnetwork
    /// resource is tied to a specific region. Defaults to the region of the
    /// Provider if no value is given.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Specifies the reservations that this instance can consume from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta2InstanceTemplateSpecInitProviderReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>A set of key/value resource manager tag pairs to bind to the instances. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>- A list of self_links of resource policies to attach to the instance. Modifying this list will cause the instance to recreate. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>
    /// The scheduling strategy to use. More details about
    /// this configuration option are detailed below.
    /// </summary>
    [JsonPropertyName("scheduling")]
    public V1beta2InstanceTemplateSpecInitProviderScheduling? Scheduling { get; set; }

    /// <summary>Service account to attach to the instance. Structure is documented below.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1beta2InstanceTemplateSpecInitProviderServiceAccount? ServiceAccount { get; set; }

    /// <summary>
    /// Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below.
    /// Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here.
    /// </summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta2InstanceTemplateSpecInitProviderShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Tags to attach to the instance.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecManagementPoliciesEnum>))]
public enum V1beta2InstanceTemplateSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2InstanceTemplateSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceTemplateSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2InstanceTemplateSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2InstanceTemplateSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2InstanceTemplateSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2InstanceTemplateSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>InstanceTemplateSpec defines the desired state of InstanceTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateSpec
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
    public V1beta2InstanceTemplateSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2InstanceTemplateSpecForProvider ForProvider { get; set; }

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
    public V1beta2InstanceTemplateSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2InstanceTemplateSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2InstanceTemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2InstanceTemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderAdvancedMachineFeatures
{
    /// <summary>Defines whether the instance should have nested virtualization enabled. Defaults to false.</summary>
    [JsonPropertyName("enableNestedVirtualization")]
    public bool? EnableNestedVirtualization { get; set; }

    /// <summary>Whether to enable UEFI networking for instance creation.</summary>
    [JsonPropertyName("enableUefiNetworking")]
    public bool? EnableUefiNetworking { get; set; }

    /// <summary>The PMU is a hardware component within the CPU core that monitors how the processor runs code. Valid values for the level of PMU are STANDARD, ENHANCED, and ARCHITECTURAL.</summary>
    [JsonPropertyName("performanceMonitoringUnit")]
    public string? PerformanceMonitoringUnit { get; set; }

    /// <summary>The number of threads per physical core. To disable simultaneous multithreading (SMT) set this to 1.</summary>
    [JsonPropertyName("threadsPerCore")]
    public double? ThreadsPerCore { get; set; }

    /// <summary>Turbo frequency mode to use for the instance. Supported modes are currently either ALL_CORE_MAX or unset (default).</summary>
    [JsonPropertyName("turboMode")]
    public string? TurboMode { get; set; }

    /// <summary>The number of physical cores to expose to an instance. visible cores info (VC).</summary>
    [JsonPropertyName("visibleCoreCount")]
    public double? VisibleCoreCount { get; set; }
}

/// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderConfidentialInstanceConfig
{
    /// <summary>Defines the confidential computing technology the instance uses. SEV is an AMD feature. TDX is an Intel feature. One of the following values is required: SEV, SEV_SNP, TDX. on_host_maintenance can be set to MIGRATE if confidential_instance_type is set to SEV and min_cpu_platform is set to &quot;AMD Milan&quot;. Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM. If SEV_SNP, currently min_cpu_platform has to be set to &quot;AMD Milan&quot; or this will fail to create the VM.</summary>
    [JsonPropertyName("confidentialInstanceType")]
    public string? ConfidentialInstanceType { get; set; }

    /// <summary>Defines whether the instance should have confidential compute enabled with AMD SEV. If enabled, on_host_maintenance can be set to MIGRATE if min_cpu_platform is set to &quot;AMD Milan&quot;. Otherwise, on_host_maintenance has to be set to TERMINATE or this will fail to create the VM.</summary>
    [JsonPropertyName("enableConfidentialCompute")]
    public bool? EnableConfidentialCompute { get; set; }
}

/// <summary>Encrypts or decrypts a disk using a customer-supplied encryption key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderDiskDiskEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key that is
    /// stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
    /// may be set.
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the
    /// encryption request for the given KMS key. If absent, the Compute Engine
    /// default service account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

/// <summary>
/// The customer-supplied encryption
/// key of the source image. Required if the source image is protected by a
/// customer-supplied encryption key.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderDiskSourceImageEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key that is
    /// stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
    /// may be set.
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the
    /// encryption request for the given KMS key. If absent, the Compute Engine
    /// default service account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

/// <summary>
/// The customer-supplied encryption
/// key of the source snapshot. Structure
/// documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderDiskSourceSnapshotEncryptionKey
{
    /// <summary>
    /// The self link of the encryption key that is
    /// stored in Google Cloud KMS. Only one of kms_key_self_link, rsa_encrypted_key and raw_key
    /// may be set.
    /// </summary>
    [JsonPropertyName("kmsKeySelfLink")]
    public string? KmsKeySelfLink { get; set; }

    /// <summary>
    /// The service account being used for the
    /// encryption request for the given KMS key. If absent, the Compute Engine
    /// default service account is used.
    /// </summary>
    [JsonPropertyName("kmsKeyServiceAccount")]
    public string? KmsKeyServiceAccount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderDisk
{
    /// <summary>The architecture of the attached disk. Valid values are ARM64 or x86_64.</summary>
    [JsonPropertyName("architecture")]
    public string? Architecture { get; set; }

    /// <summary>
    /// Whether or not the disk should be auto-deleted.
    /// This defaults to true.
    /// </summary>
    [JsonPropertyName("autoDelete")]
    public bool? AutoDelete { get; set; }

    /// <summary>Indicates that this is a boot disk.</summary>
    [JsonPropertyName("boot")]
    public bool? Boot { get; set; }

    /// <summary>
    /// A unique device name that is reflected into the
    /// /dev/  tree of a Linux operating system running within the instance. If not
    /// specified, the server chooses a default device name to apply to this disk.
    /// </summary>
    [JsonPropertyName("deviceName")]
    public string? DeviceName { get; set; }

    /// <summary>Encrypts or decrypts a disk using a customer-supplied encryption key.</summary>
    [JsonPropertyName("diskEncryptionKey")]
    public V1beta2InstanceTemplateStatusAtProviderDiskDiskEncryptionKey? DiskEncryptionKey { get; set; }

    /// <summary>
    /// Name of the disk. When not provided, this defaults
    /// to the name of the instance.
    /// </summary>
    [JsonPropertyName("diskName")]
    public string? DiskName { get; set; }

    /// <summary>
    /// The size of the image in gigabytes. If not
    /// specified, it will inherit the size of its base image. For SCRATCH disks,
    /// the size must be exactly 375GB.
    /// </summary>
    [JsonPropertyName("diskSizeGb")]
    public double? DiskSizeGb { get; set; }

    /// <summary>
    /// The GCE disk type. Such as &quot;pd-ssd&quot;, &quot;local-ssd&quot;,
    /// &quot;pd-balanced&quot; or &quot;pd-standard&quot;, &quot;hyperdisk-balanced&quot;, &quot;hyperdisk-throughput&quot; or &quot;hyperdisk-extreme&quot;.
    /// </summary>
    [JsonPropertyName("diskType")]
    public string? DiskType { get; set; }

    /// <summary>A list of features to enable on the guest operating system. Applicable only for bootable images. Read Enabling guest operating system features to see a list of available options.</summary>
    [JsonPropertyName("guestOsFeatures")]
    public IList<string>? GuestOsFeatures { get; set; }

    /// <summary>
    /// Specifies the disk interface to use for attaching this disk,
    /// which is either SCSI or NVME. The default is SCSI. Persistent disks must always use SCSI
    /// and the request will fail if you attempt to attach a persistent disk in any other format
    /// than SCSI. Local SSDs can use either NVME or SCSI.
    /// </summary>
    [JsonPropertyName("interface")]
    public string? Interface { get; set; }

    /// <summary>
    /// A set of ket/value label pairs to assign to disk created from
    /// this template
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The mode in which to attach this disk, either READ_WRITE
    /// or READ_ONLY. If you are attaching or creating a boot disk, this must
    /// read-write mode.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Indicates how many IOPS to provision for the disk. This
    /// sets the number of I/O operations per second that the disk can handle.
    /// Values must be between 10,000 and 120,000. For more details, see the
    /// Extreme persistent disk documentation.
    /// </summary>
    [JsonPropertyName("provisionedIops")]
    public double? ProvisionedIops { get; set; }

    [JsonPropertyName("provisionedThroughput")]
    public double? ProvisionedThroughput { get; set; }

    /// <summary>A set of key/value resource manager tag pairs to bind to this disk. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>- A list (short name or id) of resource policies to attach to this disk for automatic snapshot creations. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>
    /// The name (not self_link)
    /// of the disk (such as those managed by google_compute_disk) to attach.
    /// ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>
    /// The image from which to
    /// initialize this disk. This can be one of: the image&apos;s self_link,
    /// projects/{project}/global/images/{image},
    /// projects/{project}/global/images/family/{family}, global/images/{image},
    /// global/images/family/{family}, family/{family}, {project}/{family},
    /// {project}/{image}, {family}, or {image}.
    /// ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.
    /// </summary>
    [JsonPropertyName("sourceImage")]
    public string? SourceImage { get; set; }

    /// <summary>
    /// The customer-supplied encryption
    /// key of the source image. Required if the source image is protected by a
    /// customer-supplied encryption key.
    /// </summary>
    [JsonPropertyName("sourceImageEncryptionKey")]
    public V1beta2InstanceTemplateStatusAtProviderDiskSourceImageEncryptionKey? SourceImageEncryptionKey { get; set; }

    /// <summary>
    /// The source snapshot to create this disk.
    /// ~&gt; Note: Either source, source_image, or source_snapshot is required in a disk block unless the disk type is local-ssd. Check the API docs for details.
    /// </summary>
    [JsonPropertyName("sourceSnapshot")]
    public string? SourceSnapshot { get; set; }

    /// <summary>
    /// The customer-supplied encryption
    /// key of the source snapshot. Structure
    /// documented below.
    /// </summary>
    [JsonPropertyName("sourceSnapshotEncryptionKey")]
    public V1beta2InstanceTemplateStatusAtProviderDiskSourceSnapshotEncryptionKey? SourceSnapshotEncryptionKey { get; set; }

    /// <summary>
    /// The type of GCE disk, can be either &quot;SCRATCH&quot; or
    /// &quot;PERSISTENT&quot;.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderGuestAccelerator
{
    /// <summary>The number of the guest accelerator cards exposed to this instance.</summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>The accelerator type resource to expose to this instance. E.g. nvidia-tesla-k80.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderNetworkInterfaceAccessConfig
{
    /// <summary>
    /// The IP address that will be 1:1 mapped to the instance&apos;s
    /// network ip. If not given, one will be generated.
    /// </summary>
    [JsonPropertyName("natIp")]
    public string? NatIp { get; set; }

    /// <summary>
    /// The service-level to be provided for IPv6 traffic when the
    /// subnet has an external subnet. Only PREMIUM and STANDARD tier is valid for IPv6.
    /// </summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }

    /// <summary>The name of the instance template.</summary>
    [JsonPropertyName("publicPtrDomainName")]
    public string? PublicPtrDomainName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderNetworkInterfaceAliasIpRange
{
    /// <summary>
    /// The IP CIDR range represented by this alias IP range. This IP CIDR range
    /// must belong to the specified subnetwork and cannot contain IP addresses reserved by
    /// system or used by other network interfaces. At the time of writing only a
    /// netmask (e.g. /24) may be supplied, with a CIDR format resulting in an API
    /// error.
    /// </summary>
    [JsonPropertyName("ipCidrRange")]
    public string? IpCidrRange { get; set; }

    /// <summary>
    /// The subnetwork secondary range name specifying
    /// the secondary range from which to allocate the IP CIDR range for this alias IP
    /// range. If left unspecified, the primary range of the subnetwork will be used.
    /// </summary>
    [JsonPropertyName("subnetworkRangeName")]
    public string? SubnetworkRangeName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderNetworkInterfaceIpv6AccessConfig
{
    [JsonPropertyName("externalIpv6")]
    public string? ExternalIpv6 { get; set; }

    [JsonPropertyName("externalIpv6PrefixLength")]
    public string? ExternalIpv6PrefixLength { get; set; }

    /// <summary>The name of the instance template.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The service-level to be provided for IPv6 traffic when the
    /// subnet has an external subnet. Only PREMIUM and STANDARD tier is valid for IPv6.
    /// </summary>
    [JsonPropertyName("networkTier")]
    public string? NetworkTier { get; set; }

    /// <summary>The name of the instance template.</summary>
    [JsonPropertyName("publicPtrDomainName")]
    public string? PublicPtrDomainName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderNetworkInterface
{
    /// <summary>
    /// Access configurations, i.e. IPs via which this
    /// instance can be accessed via the Internet.g. via tunnel or because it is running on another cloud instance
    /// on that network). This block can be specified once per network_interface. Structure documented below.
    /// </summary>
    [JsonPropertyName("accessConfig")]
    public IList<V1beta2InstanceTemplateStatusAtProviderNetworkInterfaceAccessConfig>? AccessConfig { get; set; }

    /// <summary>
    /// An
    /// array of alias IP ranges for this network interface. Can only be specified for network
    /// interfaces on subnet-mode networks. Structure documented below.
    /// </summary>
    [JsonPropertyName("aliasIpRange")]
    public IList<V1beta2InstanceTemplateStatusAtProviderNetworkInterfaceAliasIpRange>? AliasIpRange { get; set; }

    [JsonPropertyName("internalIpv6PrefixLength")]
    public double? InternalIpv6PrefixLength { get; set; }

    /// <summary>
    /// An array of IPv6 access configurations for this interface.
    /// Currently, only one IPv6 access config, DIRECT_IPV6, is supported. If there is no ipv6AccessConfig
    /// specified, then this instance will have no external IPv6 Internet access. Structure documented below.
    /// </summary>
    [JsonPropertyName("ipv6AccessConfig")]
    public IList<V1beta2InstanceTemplateStatusAtProviderNetworkInterfaceIpv6AccessConfig>? Ipv6AccessConfig { get; set; }

    [JsonPropertyName("ipv6AccessType")]
    public string? Ipv6AccessType { get; set; }

    [JsonPropertyName("ipv6Address")]
    public string? Ipv6Address { get; set; }

    /// <summary>The name of the instance template.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name or self_link of the network to attach this interface to.
    /// Use network attribute for Legacy or Auto subnetted networks and
    /// subnetwork for custom subnetted networks.
    /// </summary>
    [JsonPropertyName("network")]
    public string? Network { get; set; }

    /// <summary>
    /// The private IP address to assign to the instance. If
    /// empty, the address will be automatically assigned.
    /// </summary>
    [JsonPropertyName("networkIp")]
    public string? NetworkIp { get; set; }

    /// <summary>The type of vNIC to be used on this interface. Possible values: GVNIC, VIRTIO_NET, MRDMA, IRDMA.</summary>
    [JsonPropertyName("nicType")]
    public string? NicType { get; set; }

    /// <summary>The networking queue count that&apos;s specified by users for the network interface. Both Rx and Tx queues will be set to this number. It will be empty if not specified.</summary>
    [JsonPropertyName("queueCount")]
    public double? QueueCount { get; set; }

    /// <summary>The stack type for this network interface to identify whether the IPv6 feature is enabled or not. Values are IPV4_IPV6, IPV6_ONLY or IPV4_ONLY. If not specified, IPV4_ONLY will be used.</summary>
    [JsonPropertyName("stackType")]
    public string? StackType { get; set; }

    /// <summary>
    /// the name of the subnetwork to attach this interface
    /// to. The subnetwork must exist in the same region this instance will be
    /// created in. Either network or subnetwork must be provided.
    /// </summary>
    [JsonPropertyName("subnetwork")]
    public string? Subnetwork { get; set; }

    /// <summary>
    /// The ID of the project in which the subnetwork belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("subnetworkProject")]
    public string? SubnetworkProject { get; set; }
}

/// <summary>
/// os-features, and network_interface.0.nic-type must be GVNIC
/// in order for this setting to take effect.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderNetworkPerformanceConfig
{
    /// <summary>The egress bandwidth tier to enable. Possible values: TIER_1, DEFAULT</summary>
    [JsonPropertyName("totalEgressBandwidthTier")]
    public string? TotalEgressBandwidthTier { get; set; }
}

/// <summary>
/// Specifies the label selector for the reservation to use..
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderReservationAffinitySpecificReservation
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// Specifies the reservations that this instance can consume from.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderReservationAffinity
{
    /// <summary>
    /// Specifies the label selector for the reservation to use..
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("specificReservation")]
    public V1beta2InstanceTemplateStatusAtProviderReservationAffinitySpecificReservation? SpecificReservation { get; set; }

    /// <summary>The type of reservation from which this instance can consume resources.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderSchedulingLocalSsdRecoveryTimeout
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented with a 0
    /// seconds field and a positive nanos field. Must be from 0 to
    /// 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// The value must be between 1 and 3600, which is 3,600 seconds (one hour).`
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderSchedulingMaxRunDuration
{
    /// <summary>
    /// Span of time that&apos;s a fraction of a second at nanosecond
    /// resolution. Durations less than one second are represented with a 0
    /// seconds field and a positive nanos field. Must be from 0 to
    /// 999,999,999 inclusive.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Span of time at a resolution of a second.
    /// The value must be between 1 and 3600, which is 3,600 seconds (one hour).`
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderSchedulingNodeAffinities
{
    /// <summary>Corresponds to the label key of a reservation resource. To target a SPECIFIC_RESERVATION by name, specify compute.googleapis.com/reservation-name as the key and specify the name of your reservation as the only value.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// The operator. Can be IN for node-affinities
    /// or NOT_IN for anti-affinities.
    /// </summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Corresponds to the label values of a reservation resource.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderSchedulingOnInstanceStopAction
{
    /// <summary>Whether to discard local SSDs attached to the VM while terminating using max_run_duration. Only supports true at this point.</summary>
    [JsonPropertyName("discardLocalSsd")]
    public bool? DiscardLocalSsd { get; set; }
}

/// <summary>
/// The scheduling strategy to use. More details about
/// this configuration option are detailed below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderScheduling
{
    /// <summary>
    /// Specifies whether the instance should be
    /// automatically restarted if it is terminated by Compute Engine (not
    /// terminated by a user). This defaults to true.
    /// </summary>
    [JsonPropertyName("automaticRestart")]
    public bool? AutomaticRestart { get; set; }

    /// <summary>Specifies the availability domain to place the instance in. The value must be a number between 1 and the number of availability domains specified in the spread placement policy attached to the instance.</summary>
    [JsonPropertyName("availabilityDomain")]
    public double? AvailabilityDomain { get; set; }

    /// <summary>Describe the type of termination action for SPOT VM. Can be STOP or DELETE.  Read more on here</summary>
    [JsonPropertyName("instanceTerminationAction")]
    public string? InstanceTerminationAction { get; set; }

    /// <summary>io/docs/providers/google/guides/provider_versions.html) Specifies the maximum amount of time a Local Ssd Vm should wait while recovery of the Local Ssd state is attempted. Its value should be in between 0 and 168 hours with hour granularity and the default value being 1 hour. Structure is documented below.</summary>
    [JsonPropertyName("localSsdRecoveryTimeout")]
    public IList<V1beta2InstanceTemplateStatusAtProviderSchedulingLocalSsdRecoveryTimeout>? LocalSsdRecoveryTimeout { get; set; }

    /// <summary>The duration of the instance. Instance will run and be terminated after then, the termination action could be defined in instance_termination_action. Structure is documented below.</summary>
    [JsonPropertyName("maxRunDuration")]
    public V1beta2InstanceTemplateStatusAtProviderSchedulingMaxRunDuration? MaxRunDuration { get; set; }

    [JsonPropertyName("minNodeCpus")]
    public double? MinNodeCpus { get; set; }

    /// <summary>
    /// Specifies node affinities or anti-affinities
    /// to determine which sole-tenant nodes your instances and managed instance
    /// groups will use as host systems. Read more on sole-tenant node creation
    /// here.
    /// Structure documented below.
    /// </summary>
    [JsonPropertyName("nodeAffinities")]
    public IList<V1beta2InstanceTemplateStatusAtProviderSchedulingNodeAffinities>? NodeAffinities { get; set; }

    /// <summary>
    /// Defines the maintenance behavior for this
    /// instance.
    /// </summary>
    [JsonPropertyName("onHostMaintenance")]
    public string? OnHostMaintenance { get; set; }

    /// <summary>Specifies the action to be performed when the instance is terminated using max_run_duration and STOP instance_termination_action. Only support true discard_local_ssd at this point. Structure is documented below.</summary>
    [JsonPropertyName("onInstanceStopAction")]
    public V1beta2InstanceTemplateStatusAtProviderSchedulingOnInstanceStopAction? OnInstanceStopAction { get; set; }

    /// <summary>
    /// Allows instance to be preempted. This defaults to
    /// false. Read more on this
    /// here.
    /// </summary>
    [JsonPropertyName("preemptible")]
    public bool? Preemptible { get; set; }

    /// <summary>
    /// Describe the type of preemptible VM. This field accepts the value STANDARD or SPOT. If the value is STANDARD, there will be no discount. If this   is set to SPOT,
    /// preemptible should be true and automatic_restart should be
    /// false. For more info about
    /// SPOT, read here
    /// </summary>
    [JsonPropertyName("provisioningModel")]
    public string? ProvisioningModel { get; set; }

    /// <summary>Specifies the timestamp, when the instance will be terminated, in RFC3339 text format. If specified, the instance termination action will be performed at the termination time.</summary>
    [JsonPropertyName("terminationTime")]
    public string? TerminationTime { get; set; }
}

/// <summary>Service account to attach to the instance. Structure is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderServiceAccount
{
    /// <summary>
    /// The service account e-mail address. If not given, the
    /// default Google Compute Engine service account is used.
    /// </summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>
    /// A list of service scopes. Both OAuth2 URLs and gcloud
    /// short names are supported. To allow full access to all Cloud APIs, use the
    /// cloud-platform scope. See a complete list of scopes here.
    /// </summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }
}

/// <summary>
/// Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below.
/// Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProviderShieldedInstanceConfig
{
    /// <summary>- Compare the most recent boot measurements to the integrity policy baseline and return a pair of pass/fail results depending on whether they match or not. Defaults to true.</summary>
    [JsonPropertyName("enableIntegrityMonitoring")]
    public bool? EnableIntegrityMonitoring { get; set; }

    /// <summary>- Verify the digital signature of all boot components, and halt the boot process if signature verification fails. Defaults to false.</summary>
    [JsonPropertyName("enableSecureBoot")]
    public bool? EnableSecureBoot { get; set; }

    /// <summary>- Use a virtualized trusted platform module, which is a specialized computer chip you can use to encrypt objects like keys and certificates. Defaults to true.</summary>
    [JsonPropertyName("enableVtpm")]
    public bool? EnableVtpm { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusAtProvider
{
    /// <summary>Configure Nested Virtualisation and Simultaneous Hyper Threading on this VM. Structure is documented below</summary>
    [JsonPropertyName("advancedMachineFeatures")]
    public V1beta2InstanceTemplateStatusAtProviderAdvancedMachineFeatures? AdvancedMachineFeatures { get; set; }

    /// <summary>
    /// Whether to allow sending and receiving of
    /// packets with non-matching source or destination IPs. This defaults to false.
    /// </summary>
    [JsonPropertyName("canIpForward")]
    public bool? CanIpForward { get; set; }

    /// <summary>Enable Confidential Mode on this VM. Structure is documented below</summary>
    [JsonPropertyName("confidentialInstanceConfig")]
    public V1beta2InstanceTemplateStatusAtProviderConfidentialInstanceConfig? ConfidentialInstanceConfig { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>A brief description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Disks to attach to instances created from this template.
    /// This can be specified multiple times for multiple disks. Structure is
    /// documented below.
    /// </summary>
    [JsonPropertyName("disk")]
    public IList<V1beta2InstanceTemplateStatusAtProviderDisk>? Disk { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>List of the type and count of accelerator cards attached to the instance. Structure documented below.</summary>
    [JsonPropertyName("guestAccelerator")]
    public IList<V1beta2InstanceTemplateStatusAtProviderGuestAccelerator>? GuestAccelerator { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/global/instanceTemplates/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// A brief description to use for instances
    /// created from this template.
    /// </summary>
    [JsonPropertyName("instanceDescription")]
    public string? InstanceDescription { get; set; }

    /// <summary>Action to be taken when a customer&apos;s encryption key is revoked. Supports STOP and NONE, with NONE being the default.</summary>
    [JsonPropertyName("keyRevocationActionType")]
    public string? KeyRevocationActionType { get; set; }

    /// <summary>
    /// A set of key/value label pairs to assign to instances
    /// created from this template.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The machine type to create.</summary>
    [JsonPropertyName("machineType")]
    public string? MachineType { get; set; }

    /// <summary>
    /// Metadata key/value pairs to make available from
    /// within instances created from this template.
    /// </summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The unique fingerprint of the metadata.</summary>
    [JsonPropertyName("metadataFingerprint")]
    public string? MetadataFingerprint { get; set; }

    /// <summary>
    /// An alternative to using the
    /// startup-script metadata key, mostly to match the compute_instance resource.
    /// This replaces the startup-script metadata key on the created instance and
    /// thus the two mechanisms are not allowed to be used simultaneously.
    /// </summary>
    [JsonPropertyName("metadataStartupScript")]
    public string? MetadataStartupScript { get; set; }

    /// <summary>
    /// Specifies a minimum CPU platform. Applicable values are the friendly names of CPU platforms, such as
    /// Intel Haswell or Intel Skylake. See the complete list here.
    /// </summary>
    [JsonPropertyName("minCpuPlatform")]
    public string? MinCpuPlatform { get; set; }

    /// <summary>The name of the instance template.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Creates a unique name beginning with the specified
    /// prefix. Conflicts with name. Max length is 54 characters.
    /// Prefixes with lengths longer than 37 characters will use a shortened
    /// UUID that will be more prone to collisions.
    /// </summary>
    [JsonPropertyName("namePrefix")]
    public string? NamePrefix { get; set; }

    /// <summary>
    /// Networks to attach to instances created from
    /// this template. This can be specified multiple times for multiple networks.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("networkInterface")]
    public IList<V1beta2InstanceTemplateStatusAtProviderNetworkInterface>? NetworkInterface { get; set; }

    /// <summary>
    /// os-features, and network_interface.0.nic-type must be GVNIC
    /// in order for this setting to take effect.
    /// </summary>
    [JsonPropertyName("networkPerformanceConfig")]
    public V1beta2InstanceTemplateStatusAtProviderNetworkPerformanceConfig? NetworkPerformanceConfig { get; set; }

    /// <summary>numeric identifier of the resource.</summary>
    [JsonPropertyName("numericId")]
    public string? NumericId { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs. If it
    /// is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// An instance template is a global resource that is not
    /// bound to a zone or a region. However, you can still specify some regional
    /// resources in an instance template, which restricts the template to the
    /// region where that resource resides. For example, a custom subnetwork
    /// resource is tied to a specific region. Defaults to the region of the
    /// Provider if no value is given.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Specifies the reservations that this instance can consume from.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("reservationAffinity")]
    public V1beta2InstanceTemplateStatusAtProviderReservationAffinity? ReservationAffinity { get; set; }

    /// <summary>A set of key/value resource manager tag pairs to bind to the instances. Keys must be in the format tagKeys/{tag_key_id}, and values are in the format tagValues/456.</summary>
    [JsonPropertyName("resourceManagerTags")]
    public IDictionary<string, string>? ResourceManagerTags { get; set; }

    /// <summary>- A list of self_links of resource policies to attach to the instance. Modifying this list will cause the instance to recreate. Currently a max of 1 resource policy is supported.</summary>
    [JsonPropertyName("resourcePolicies")]
    public IList<string>? ResourcePolicies { get; set; }

    /// <summary>
    /// The scheduling strategy to use. More details about
    /// this configuration option are detailed below.
    /// </summary>
    [JsonPropertyName("scheduling")]
    public V1beta2InstanceTemplateStatusAtProviderScheduling? Scheduling { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>
    /// A special URI of the created resource that uniquely identifies this instance template with the following format: projects/{{project}}/global/instanceTemplates/{{name}}?uniqueId={{uniqueId}}
    /// Referencing an instance template via this attribute prevents Time of Check to Time of Use attacks when the instance template resides in a shared/untrusted environment.
    /// </summary>
    [JsonPropertyName("selfLinkUnique")]
    public string? SelfLinkUnique { get; set; }

    /// <summary>Service account to attach to the instance. Structure is documented below.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1beta2InstanceTemplateStatusAtProviderServiceAccount? ServiceAccount { get; set; }

    /// <summary>
    /// Enable Shielded VM on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below.
    /// Note: shielded_instance_config can only be used with boot images with shielded vm support. See the complete list here.
    /// </summary>
    [JsonPropertyName("shieldedInstanceConfig")]
    public V1beta2InstanceTemplateStatusAtProviderShieldedInstanceConfig? ShieldedInstanceConfig { get; set; }

    /// <summary>Tags to attach to the instance.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }

    /// <summary>The unique fingerprint of the tags.</summary>
    [JsonPropertyName("tagsFingerprint")]
    public string? TagsFingerprint { get; set; }

    /// <summary>The combination of labels configured directly on the resource and default labels configured on the provider.</summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatusConditions
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

/// <summary>InstanceTemplateStatus defines the observed state of InstanceTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceTemplateStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2InstanceTemplateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2InstanceTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>InstanceTemplate is the Schema for the InstanceTemplates API. Manages a VM instance template resource within GCE.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InstanceTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2InstanceTemplateSpec>, IStatus<V1beta2InstanceTemplateStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InstanceTemplate";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "instancetemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceTemplate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceTemplateSpec defines the desired state of InstanceTemplate</summary>
    [JsonPropertyName("spec")]
    public required V1beta2InstanceTemplateSpec Spec { get; set; }

    /// <summary>InstanceTemplateStatus defines the observed state of InstanceTemplate.</summary>
    [JsonPropertyName("status")]
    public V1beta2InstanceTemplateStatus? Status { get; set; }
}