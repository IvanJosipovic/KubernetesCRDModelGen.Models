#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.transit.vault.upbound.io;
/// <summary>SecretBackendKey is the Schema for the SecretBackendKeys API. Create an Encryption Keyring on a Transit Secret Backend for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendKeyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecretBackendKey>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendKeyList";
    public const string KubeGroup = "transit.vault.upbound.io";
    public const string KubePluralName = "secretbackendkeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "transit.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendKeyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SecretBackendKey objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SecretBackendKey> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendKeySpecDeletionPolicyEnum>))]
public enum V1alpha1SecretBackendKeySpecDeletionPolicyEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendKeySpecForProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendKeySpecForProviderBackendRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendKeySpecForProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendKeySpecForProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendKeySpecForProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendKeySpecForProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendKeySpecForProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendKeySpecForProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendKeySpecForProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendKeySpecForProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendKeySpecForProviderBackendSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendKeySpecForProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendKeySpecForProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendKeySpecForProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendKeySpecForProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendKeySpecForProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendKeySpecForProviderBackendSelector
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
    public V1alpha1SecretBackendKeySpecForProviderBackendSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendKeySpecForProvider
{
    /// <summary>
    /// Enables taking backup of entire keyring in the plaintext format. Once set, this cannot be disabled.
    /// If set, enables taking backup of named key in the plaintext format. Once set, this cannot be disabled.
    /// </summary>
    [JsonPropertyName("allowPlaintextBackup")]
    public bool? AllowPlaintextBackup { get; set; }

    /// <summary>
    /// Amount of seconds the key should live before being automatically rotated.
    /// A value of 0 disables automatic rotation for the key.
    /// Amount of seconds the key should live before being automatically rotated. A value of 0 disables automatic rotation for the key.
    /// </summary>
    [JsonPropertyName("autoRotatePeriod")]
    public double? AutoRotatePeriod { get; set; }

    /// <summary>
    /// The path the transit secret backend is mounted at, with no leading or trailing /s.
    /// The Transit secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendKeySpecForProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendKeySpecForProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// Base64 encoded context for key derivation. Required if derived is set to true. This provides additional entropy for key derivation and should be consistent across operations that need to use the same derived key.
    /// Base64 encoded context for key derivation. Required if derived is set to true.
    /// </summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// Whether or not to support convergent encryption, where the same plaintext creates the same ciphertext. This requires derived to be set to true.
    /// Whether or not to support convergent encryption, where the same plaintext creates the same ciphertext. This requires derived to be set to true.
    /// </summary>
    [JsonPropertyName("convergentEncryption")]
    public bool? ConvergentEncryption { get; set; }

    /// <summary>
    /// Specifies if the keyring is allowed to be deleted.
    /// Specifies if the key is allowed to be deleted.
    /// </summary>
    [JsonPropertyName("deletionAllowed")]
    public bool? DeletionAllowed { get; set; }

    /// <summary>
    /// Specifies if key derivation is to be used. If enabled, all encrypt/decrypt requests to this key must provide a context which is used for key derivation.
    /// Specifies if key derivation is to be used. If enabled, all encrypt/decrypt requests to this key must provide a context which is used for key derivation.
    /// </summary>
    [JsonPropertyName("derived")]
    public bool? Derived { get; set; }

    /// <summary>
    /// Enables keys to be exportable. This allows for all valid private keys in the keyring to be exported. Once set, this cannot be disabled.
    /// Enables keys to be exportable. This allows for all the valid keys in the key ring to be exported. Once set, this cannot be disabled.
    /// </summary>
    [JsonPropertyName("exportable")]
    public bool? Exportable { get; set; }

    /// <summary>
    /// The elliptic curve algorithm to use for hybrid signatures.
    /// Supported key types are ecdsa-p256, ecdsa-p384, ecdsa-p521, and ed25519.
    /// The elliptic curve algorithm to use for hybrid signatures. Supported key types are `ecdsa-p256`, `ecdsa-p384`, `ecdsa-p521`, and `ed25519`.
    /// </summary>
    [JsonPropertyName("hybridKeyTypeEc")]
    public string? HybridKeyTypeEc { get; set; }

    /// <summary>
    /// The post-quantum algorithm to use for hybrid signatures.
    /// Currently, ML-DSA is the only supported key type.
    /// The post-quantum algorithm to use for hybrid signatures. Currently, ML-DSA is the only supported key type.
    /// </summary>
    [JsonPropertyName("hybridKeyTypePqc")]
    public string? HybridKeyTypePqc { get; set; }

    /// <summary>
    /// The key size in bytes for algorithms that allow variable key sizes. Currently only applicable to HMAC, where it must be between 32 and 512 bytes.
    /// The key size in bytes for algorithms that allow variable key sizes. Currently only applicable to HMAC; this value must be between 32 and 512.
    /// </summary>
    [JsonPropertyName("keySize")]
    public double? KeySize { get; set; }

    /// <summary>
    /// The UUID of the managed key to use when the key type is managed_key. This is the unique identifier of a previously configured managed key. When type is managed_key, either managed_key_name or managed_key_id must be specified.
    /// The UUID of the managed key to use when the key type is managed_key.
    /// </summary>
    [JsonPropertyName("managedKeyId")]
    public string? ManagedKeyId { get; set; }

    /// <summary>
    /// The name of the managed key to use when the key type is managed_key. This references a previously configured managed key in Vault (e.g., AWS KMS, Azure Key Vault, PKCS#11, etc.). When type is managed_key, either managed_key_name or managed_key_id must be specified.
    /// The name of the managed key to use when the key type is managed_key.
    /// </summary>
    [JsonPropertyName("managedKeyName")]
    public string? ManagedKeyName { get; set; }

    /// <summary>
    /// Minimum key version to use for decryption.
    /// Minimum key version to use for decryption.
    /// </summary>
    [JsonPropertyName("minDecryptionVersion")]
    public double? MinDecryptionVersion { get; set; }

    /// <summary>
    /// Minimum key version to use for encryption
    /// Minimum key version to use for encryption
    /// </summary>
    [JsonPropertyName("minEncryptionVersion")]
    public double? MinEncryptionVersion { get; set; }

    /// <summary>
    /// The name to identify this key within the backend. Must be unique within the backend.
    /// Name of the encryption key to create.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// The parameter set to use for ML-DSA or SLH-DSA. Required for
    /// ML-DSA, hybrid, and SLH-DSA keys.
    /// Valid values for ML-DSA are 44, 65, and 87.
    /// Valid values for SLH-DSA are slh-dsa-sha2-128s, slh-dsa-shake-128s, slh-dsa-sha2-128f, slh-dsa-shake-128, slh-dsa-sha2-192s,
    /// slh-dsa-shake-192s, slh-dsa-sha2-192f, slh-dsa-shake-192f, slh-dsa-sha2-256s, slh-dsa-shake-256s,
    /// slh-dsa-sha2-256f, and slh-dsa-shake-256f.
    /// The parameter set to use for ML-DSA. Required for ML-DSA and hybrid keys.  Valid values for ML-DSA are `44`, `65`, and `87`. Valid values for SLH-DSA are `slh-dsa-sha2-128s`, `slh-dsa-shake-128s`, `slh-dsa-sha2-128f`, `slh-dsa-shake-128`, `slh-dsa-sha2-192s`, `slh-dsa-shake-192s`, `slh-dsa-sha2-192f`, `slh-dsa-shake-192f`, `slh-dsa-sha2-256s`, `slh-dsa-shake-256s`, `slh-dsa-sha2-256f`, and `slh-dsa-shake-256f`.
    /// </summary>
    [JsonPropertyName("parameterSet")]
    public string? ParameterSet { get; set; }

    /// <summary>
    /// Specifies the type of key to create. The currently-supported types are: aes128-gcm96, aes256-gcm96 (default), chacha20-poly1305, ed25519, ecdsa-p256, ecdsa-p384, ecdsa-p521, hmac, rsa-2048, rsa-3072, rsa-4096, managed_key, aes128-cmac, aes192-cmac, aes256-cmac, ml-dsa, hybrid, and slh-dsa.
    /// Specifies the type of key to create. The currently-supported types are: `aes128-gcm96`, `aes256-gcm96` (default), `chacha20-poly1305`, `ed25519`, `ecdsa-p256`, `ecdsa-p384`, `ecdsa-p521`, `hmac`, `rsa-2048`, `rsa-3072`, `rsa-4096`, `managed_key`, `aes128-cmac`, `aes192-cmac`, `aes256-cmac`, `ml-dsa`, `hybrid`, and `slh-dsa`.
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendKeySpecInitProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendKeySpecInitProviderBackendRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendKeySpecInitProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendKeySpecInitProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendKeySpecInitProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendKeySpecInitProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendKeySpecInitProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendKeySpecInitProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendKeySpecInitProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendKeySpecInitProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendKeySpecInitProviderBackendSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendKeySpecInitProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendKeySpecInitProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendKeySpecInitProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendKeySpecInitProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendKeySpecInitProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendKeySpecInitProviderBackendSelector
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
    public V1alpha1SecretBackendKeySpecInitProviderBackendSelectorPolicy? Policy { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendKeySpecInitProvider
{
    /// <summary>
    /// Enables taking backup of entire keyring in the plaintext format. Once set, this cannot be disabled.
    /// If set, enables taking backup of named key in the plaintext format. Once set, this cannot be disabled.
    /// </summary>
    [JsonPropertyName("allowPlaintextBackup")]
    public bool? AllowPlaintextBackup { get; set; }

    /// <summary>
    /// Amount of seconds the key should live before being automatically rotated.
    /// A value of 0 disables automatic rotation for the key.
    /// Amount of seconds the key should live before being automatically rotated. A value of 0 disables automatic rotation for the key.
    /// </summary>
    [JsonPropertyName("autoRotatePeriod")]
    public double? AutoRotatePeriod { get; set; }

    /// <summary>
    /// The path the transit secret backend is mounted at, with no leading or trailing /s.
    /// The Transit secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendKeySpecInitProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendKeySpecInitProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// Base64 encoded context for key derivation. Required if derived is set to true. This provides additional entropy for key derivation and should be consistent across operations that need to use the same derived key.
    /// Base64 encoded context for key derivation. Required if derived is set to true.
    /// </summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// Whether or not to support convergent encryption, where the same plaintext creates the same ciphertext. This requires derived to be set to true.
    /// Whether or not to support convergent encryption, where the same plaintext creates the same ciphertext. This requires derived to be set to true.
    /// </summary>
    [JsonPropertyName("convergentEncryption")]
    public bool? ConvergentEncryption { get; set; }

    /// <summary>
    /// Specifies if the keyring is allowed to be deleted.
    /// Specifies if the key is allowed to be deleted.
    /// </summary>
    [JsonPropertyName("deletionAllowed")]
    public bool? DeletionAllowed { get; set; }

    /// <summary>
    /// Specifies if key derivation is to be used. If enabled, all encrypt/decrypt requests to this key must provide a context which is used for key derivation.
    /// Specifies if key derivation is to be used. If enabled, all encrypt/decrypt requests to this key must provide a context which is used for key derivation.
    /// </summary>
    [JsonPropertyName("derived")]
    public bool? Derived { get; set; }

    /// <summary>
    /// Enables keys to be exportable. This allows for all valid private keys in the keyring to be exported. Once set, this cannot be disabled.
    /// Enables keys to be exportable. This allows for all the valid keys in the key ring to be exported. Once set, this cannot be disabled.
    /// </summary>
    [JsonPropertyName("exportable")]
    public bool? Exportable { get; set; }

    /// <summary>
    /// The elliptic curve algorithm to use for hybrid signatures.
    /// Supported key types are ecdsa-p256, ecdsa-p384, ecdsa-p521, and ed25519.
    /// The elliptic curve algorithm to use for hybrid signatures. Supported key types are `ecdsa-p256`, `ecdsa-p384`, `ecdsa-p521`, and `ed25519`.
    /// </summary>
    [JsonPropertyName("hybridKeyTypeEc")]
    public string? HybridKeyTypeEc { get; set; }

    /// <summary>
    /// The post-quantum algorithm to use for hybrid signatures.
    /// Currently, ML-DSA is the only supported key type.
    /// The post-quantum algorithm to use for hybrid signatures. Currently, ML-DSA is the only supported key type.
    /// </summary>
    [JsonPropertyName("hybridKeyTypePqc")]
    public string? HybridKeyTypePqc { get; set; }

    /// <summary>
    /// The key size in bytes for algorithms that allow variable key sizes. Currently only applicable to HMAC, where it must be between 32 and 512 bytes.
    /// The key size in bytes for algorithms that allow variable key sizes. Currently only applicable to HMAC; this value must be between 32 and 512.
    /// </summary>
    [JsonPropertyName("keySize")]
    public double? KeySize { get; set; }

    /// <summary>
    /// The UUID of the managed key to use when the key type is managed_key. This is the unique identifier of a previously configured managed key. When type is managed_key, either managed_key_name or managed_key_id must be specified.
    /// The UUID of the managed key to use when the key type is managed_key.
    /// </summary>
    [JsonPropertyName("managedKeyId")]
    public string? ManagedKeyId { get; set; }

    /// <summary>
    /// The name of the managed key to use when the key type is managed_key. This references a previously configured managed key in Vault (e.g., AWS KMS, Azure Key Vault, PKCS#11, etc.). When type is managed_key, either managed_key_name or managed_key_id must be specified.
    /// The name of the managed key to use when the key type is managed_key.
    /// </summary>
    [JsonPropertyName("managedKeyName")]
    public string? ManagedKeyName { get; set; }

    /// <summary>
    /// Minimum key version to use for decryption.
    /// Minimum key version to use for decryption.
    /// </summary>
    [JsonPropertyName("minDecryptionVersion")]
    public double? MinDecryptionVersion { get; set; }

    /// <summary>
    /// Minimum key version to use for encryption
    /// Minimum key version to use for encryption
    /// </summary>
    [JsonPropertyName("minEncryptionVersion")]
    public double? MinEncryptionVersion { get; set; }

    /// <summary>
    /// The name to identify this key within the backend. Must be unique within the backend.
    /// Name of the encryption key to create.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// The parameter set to use for ML-DSA or SLH-DSA. Required for
    /// ML-DSA, hybrid, and SLH-DSA keys.
    /// Valid values for ML-DSA are 44, 65, and 87.
    /// Valid values for SLH-DSA are slh-dsa-sha2-128s, slh-dsa-shake-128s, slh-dsa-sha2-128f, slh-dsa-shake-128, slh-dsa-sha2-192s,
    /// slh-dsa-shake-192s, slh-dsa-sha2-192f, slh-dsa-shake-192f, slh-dsa-sha2-256s, slh-dsa-shake-256s,
    /// slh-dsa-sha2-256f, and slh-dsa-shake-256f.
    /// The parameter set to use for ML-DSA. Required for ML-DSA and hybrid keys.  Valid values for ML-DSA are `44`, `65`, and `87`. Valid values for SLH-DSA are `slh-dsa-sha2-128s`, `slh-dsa-shake-128s`, `slh-dsa-sha2-128f`, `slh-dsa-shake-128`, `slh-dsa-sha2-192s`, `slh-dsa-shake-192s`, `slh-dsa-sha2-192f`, `slh-dsa-shake-192f`, `slh-dsa-sha2-256s`, `slh-dsa-shake-256s`, `slh-dsa-sha2-256f`, and `slh-dsa-shake-256f`.
    /// </summary>
    [JsonPropertyName("parameterSet")]
    public string? ParameterSet { get; set; }

    /// <summary>
    /// Specifies the type of key to create. The currently-supported types are: aes128-gcm96, aes256-gcm96 (default), chacha20-poly1305, ed25519, ecdsa-p256, ecdsa-p384, ecdsa-p521, hmac, rsa-2048, rsa-3072, rsa-4096, managed_key, aes128-cmac, aes192-cmac, aes256-cmac, ml-dsa, hybrid, and slh-dsa.
    /// Specifies the type of key to create. The currently-supported types are: `aes128-gcm96`, `aes256-gcm96` (default), `chacha20-poly1305`, `ed25519`, `ecdsa-p256`, `ecdsa-p384`, `ecdsa-p521`, `hmac`, `rsa-2048`, `rsa-3072`, `rsa-4096`, `managed_key`, `aes128-cmac`, `aes192-cmac`, `aes256-cmac`, `ml-dsa`, `hybrid`, and `slh-dsa`.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendKeySpecManagementPoliciesEnum>))]
public enum V1alpha1SecretBackendKeySpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendKeySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendKeySpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendKeySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendKeySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendKeySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendKeySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendKeySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendKeySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendKeySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendKeySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SecretBackendKeySpec defines the desired state of SecretBackendKey</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendKeySpec
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
    public V1alpha1SecretBackendKeySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1SecretBackendKeySpecForProvider ForProvider { get; set; }

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
    public V1alpha1SecretBackendKeySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1SecretBackendKeySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SecretBackendKeySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SecretBackendKeySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendKeyStatusAtProvider
{
    /// <summary>
    /// Enables taking backup of entire keyring in the plaintext format. Once set, this cannot be disabled.
    /// If set, enables taking backup of named key in the plaintext format. Once set, this cannot be disabled.
    /// </summary>
    [JsonPropertyName("allowPlaintextBackup")]
    public bool? AllowPlaintextBackup { get; set; }

    /// <summary>
    /// Amount of seconds the key should live before being automatically rotated.
    /// A value of 0 disables automatic rotation for the key.
    /// Amount of seconds the key should live before being automatically rotated. A value of 0 disables automatic rotation for the key.
    /// </summary>
    [JsonPropertyName("autoRotatePeriod")]
    public double? AutoRotatePeriod { get; set; }

    /// <summary>
    /// The path the transit secret backend is mounted at, with no leading or trailing /s.
    /// The Transit secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>
    /// Base64 encoded context for key derivation. Required if derived is set to true. This provides additional entropy for key derivation and should be consistent across operations that need to use the same derived key.
    /// Base64 encoded context for key derivation. Required if derived is set to true.
    /// </summary>
    [JsonPropertyName("context")]
    public string? Context { get; set; }

    /// <summary>
    /// Whether or not to support convergent encryption, where the same plaintext creates the same ciphertext. This requires derived to be set to true.
    /// Whether or not to support convergent encryption, where the same plaintext creates the same ciphertext. This requires derived to be set to true.
    /// </summary>
    [JsonPropertyName("convergentEncryption")]
    public bool? ConvergentEncryption { get; set; }

    /// <summary>
    /// Specifies if the keyring is allowed to be deleted.
    /// Specifies if the key is allowed to be deleted.
    /// </summary>
    [JsonPropertyName("deletionAllowed")]
    public bool? DeletionAllowed { get; set; }

    /// <summary>
    /// Specifies if key derivation is to be used. If enabled, all encrypt/decrypt requests to this key must provide a context which is used for key derivation.
    /// Specifies if key derivation is to be used. If enabled, all encrypt/decrypt requests to this key must provide a context which is used for key derivation.
    /// </summary>
    [JsonPropertyName("derived")]
    public bool? Derived { get; set; }

    /// <summary>
    /// Enables keys to be exportable. This allows for all valid private keys in the keyring to be exported. Once set, this cannot be disabled.
    /// Enables keys to be exportable. This allows for all the valid keys in the key ring to be exported. Once set, this cannot be disabled.
    /// </summary>
    [JsonPropertyName("exportable")]
    public bool? Exportable { get; set; }

    /// <summary>
    /// The elliptic curve algorithm to use for hybrid signatures.
    /// Supported key types are ecdsa-p256, ecdsa-p384, ecdsa-p521, and ed25519.
    /// The elliptic curve algorithm to use for hybrid signatures. Supported key types are `ecdsa-p256`, `ecdsa-p384`, `ecdsa-p521`, and `ed25519`.
    /// </summary>
    [JsonPropertyName("hybridKeyTypeEc")]
    public string? HybridKeyTypeEc { get; set; }

    /// <summary>
    /// The post-quantum algorithm to use for hybrid signatures.
    /// Currently, ML-DSA is the only supported key type.
    /// The post-quantum algorithm to use for hybrid signatures. Currently, ML-DSA is the only supported key type.
    /// </summary>
    [JsonPropertyName("hybridKeyTypePqc")]
    public string? HybridKeyTypePqc { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The key size in bytes for algorithms that allow variable key sizes. Currently only applicable to HMAC, where it must be between 32 and 512 bytes.
    /// The key size in bytes for algorithms that allow variable key sizes. Currently only applicable to HMAC; this value must be between 32 and 512.
    /// </summary>
    [JsonPropertyName("keySize")]
    public double? KeySize { get; set; }

    /// <summary>
    /// List of key versions in the keyring. This attribute is zero-indexed and will contain a map of values depending on the type of the encryption key.
    /// List of key versions in the keyring.
    /// </summary>
    [JsonPropertyName("keys")]
    public IList<IDictionary<string, string>>? Keys { get; set; }

    /// <summary>
    /// Latest key version available. This value is 1-indexed, so if latest_version is 1, then the key&apos;s information can be referenced from keys by selecting element 0
    /// Latest key version in use in the keyring
    /// </summary>
    [JsonPropertyName("latestVersion")]
    public double? LatestVersion { get; set; }

    /// <summary>
    /// The UUID of the managed key to use when the key type is managed_key. This is the unique identifier of a previously configured managed key. When type is managed_key, either managed_key_name or managed_key_id must be specified.
    /// The UUID of the managed key to use when the key type is managed_key.
    /// </summary>
    [JsonPropertyName("managedKeyId")]
    public string? ManagedKeyId { get; set; }

    /// <summary>
    /// The name of the managed key to use when the key type is managed_key. This references a previously configured managed key in Vault (e.g., AWS KMS, Azure Key Vault, PKCS#11, etc.). When type is managed_key, either managed_key_name or managed_key_id must be specified.
    /// The name of the managed key to use when the key type is managed_key.
    /// </summary>
    [JsonPropertyName("managedKeyName")]
    public string? ManagedKeyName { get; set; }

    /// <summary>
    /// Minimum key version available for use. If keys have been archived by increasing min_decryption_version, this attribute will reflect that change.
    /// Minimum key version available for use.
    /// </summary>
    [JsonPropertyName("minAvailableVersion")]
    public double? MinAvailableVersion { get; set; }

    /// <summary>
    /// Minimum key version to use for decryption.
    /// Minimum key version to use for decryption.
    /// </summary>
    [JsonPropertyName("minDecryptionVersion")]
    public double? MinDecryptionVersion { get; set; }

    /// <summary>
    /// Minimum key version to use for encryption
    /// Minimum key version to use for encryption
    /// </summary>
    [JsonPropertyName("minEncryptionVersion")]
    public double? MinEncryptionVersion { get; set; }

    /// <summary>
    /// The name to identify this key within the backend. Must be unique within the backend.
    /// Name of the encryption key to create.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// The parameter set to use for ML-DSA or SLH-DSA. Required for
    /// ML-DSA, hybrid, and SLH-DSA keys.
    /// Valid values for ML-DSA are 44, 65, and 87.
    /// Valid values for SLH-DSA are slh-dsa-sha2-128s, slh-dsa-shake-128s, slh-dsa-sha2-128f, slh-dsa-shake-128, slh-dsa-sha2-192s,
    /// slh-dsa-shake-192s, slh-dsa-sha2-192f, slh-dsa-shake-192f, slh-dsa-sha2-256s, slh-dsa-shake-256s,
    /// slh-dsa-sha2-256f, and slh-dsa-shake-256f.
    /// The parameter set to use for ML-DSA. Required for ML-DSA and hybrid keys.  Valid values for ML-DSA are `44`, `65`, and `87`. Valid values for SLH-DSA are `slh-dsa-sha2-128s`, `slh-dsa-shake-128s`, `slh-dsa-sha2-128f`, `slh-dsa-shake-128`, `slh-dsa-sha2-192s`, `slh-dsa-shake-192s`, `slh-dsa-sha2-192f`, `slh-dsa-shake-192f`, `slh-dsa-sha2-256s`, `slh-dsa-shake-256s`, `slh-dsa-sha2-256f`, and `slh-dsa-shake-256f`.
    /// </summary>
    [JsonPropertyName("parameterSet")]
    public string? ParameterSet { get; set; }

    /// <summary>
    /// Whether or not the key supports decryption, based on key type.
    /// Whether or not the key supports decryption, based on key type.
    /// </summary>
    [JsonPropertyName("supportsDecryption")]
    public bool? SupportsDecryption { get; set; }

    /// <summary>
    /// Whether or not the key supports derivation, based on key type.
    /// Whether or not the key supports derivation, based on key type.
    /// </summary>
    [JsonPropertyName("supportsDerivation")]
    public bool? SupportsDerivation { get; set; }

    /// <summary>
    /// Whether or not the key supports encryption, based on key type.
    /// Whether or not the key supports encryption, based on key type.
    /// </summary>
    [JsonPropertyName("supportsEncryption")]
    public bool? SupportsEncryption { get; set; }

    /// <summary>
    /// Whether or not the key supports signing, based on key type.
    /// Whether or not the key supports signing, based on key type.
    /// </summary>
    [JsonPropertyName("supportsSigning")]
    public bool? SupportsSigning { get; set; }

    /// <summary>
    /// Specifies the type of key to create. The currently-supported types are: aes128-gcm96, aes256-gcm96 (default), chacha20-poly1305, ed25519, ecdsa-p256, ecdsa-p384, ecdsa-p521, hmac, rsa-2048, rsa-3072, rsa-4096, managed_key, aes128-cmac, aes192-cmac, aes256-cmac, ml-dsa, hybrid, and slh-dsa.
    /// Specifies the type of key to create. The currently-supported types are: `aes128-gcm96`, `aes256-gcm96` (default), `chacha20-poly1305`, `ed25519`, `ecdsa-p256`, `ecdsa-p384`, `ecdsa-p521`, `hmac`, `rsa-2048`, `rsa-3072`, `rsa-4096`, `managed_key`, `aes128-cmac`, `aes192-cmac`, `aes256-cmac`, `ml-dsa`, `hybrid`, and `slh-dsa`.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendKeyStatusConditions
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

/// <summary>SecretBackendKeyStatus defines the observed state of SecretBackendKey.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendKeyStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1SecretBackendKeyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecretBackendKeyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SecretBackendKey is the Schema for the SecretBackendKeys API. Create an Encryption Keyring on a Transit Secret Backend for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendKey : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretBackendKeySpec>, IStatus<V1alpha1SecretBackendKeyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendKey";
    public const string KubeGroup = "transit.vault.upbound.io";
    public const string KubePluralName = "secretbackendkeys";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "transit.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendKey";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretBackendKeySpec defines the desired state of SecretBackendKey</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SecretBackendKeySpec Spec { get; set; }

    /// <summary>SecretBackendKeyStatus defines the observed state of SecretBackendKey.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecretBackendKeyStatus? Status { get; set; }
}