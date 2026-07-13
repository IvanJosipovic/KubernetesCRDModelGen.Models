#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pki.vault.m.upbound.io;
/// <summary>SecretBackendCrlConfig is the Schema for the SecretBackendCrlConfigs API. Sets the CRL config on an PKI Secret Backend for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendCrlConfigList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecretBackendCrlConfig>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendCrlConfigList";
    public const string KubeGroup = "pki.vault.m.upbound.io";
    public const string KubePluralName = "secretbackendcrlconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pki.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendCrlConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SecretBackendCrlConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SecretBackendCrlConfig> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCrlConfigSpecForProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendCrlConfigSpecForProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCrlConfigSpecForProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendCrlConfigSpecForProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCrlConfigSpecForProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendCrlConfigSpecForProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendCrlConfigSpecForProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCrlConfigSpecForProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendCrlConfigSpecForProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCrlConfigSpecForProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendCrlConfigSpecForProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCrlConfigSpecForProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendCrlConfigSpecForProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCrlConfigSpecForProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendCrlConfigSpecForProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendCrlConfigSpecForProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCrlConfigSpecForProviderBackendSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendCrlConfigSpecForProviderBackendSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCrlConfigSpecForProvider
{
    /// <summary>
    /// Enables periodic rebuilding of the CRL upon expiry. Vault 1.12+
    /// Enables or disables periodic rebuilding of the CRL upon expiry.
    /// </summary>
    [JsonPropertyName("autoRebuild")]
    public bool? AutoRebuild { get; set; }

    /// <summary>
    /// Grace period before CRL expiry to attempt rebuild of CRL. Vault 1.12+
    /// Grace period before CRL expiry to attempt rebuild of CRL.
    /// </summary>
    [JsonPropertyName("autoRebuildGracePeriod")]
    public string? AutoRebuildGracePeriod { get; set; }

    /// <summary>
    /// The path the PKI secret backend is mounted at, with no leading or trailing /s.
    /// The path of the PKI secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendCrlConfigSpecForProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendCrlConfigSpecForProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// Enable cross-cluster revocation request queues. Vault 1.13+
    /// Enable cross-cluster revocation request queues.
    /// </summary>
    [JsonPropertyName("crossClusterRevocation")]
    public bool? CrossClusterRevocation { get; set; }

    /// <summary>
    /// Interval to check for new revocations on, to regenerate the delta CRL.
    /// Interval to check for new revocations on, to regenerate the delta CRL.
    /// </summary>
    [JsonPropertyName("deltaRebuildInterval")]
    public string? DeltaRebuildInterval { get; set; }

    /// <summary>
    /// Disables or enables CRL building.
    /// Disables or enables CRL building
    /// </summary>
    [JsonPropertyName("disable")]
    public bool? Disable { get; set; }

    /// <summary>
    /// Enables building of delta CRLs with up-to-date revocation information,
    /// augmenting the last complete CRL.  Vault 1.12+
    /// Enables or disables building of delta CRLs with up-to-date revocation information, augmenting the last complete CRL.
    /// </summary>
    [JsonPropertyName("enableDelta")]
    public bool? EnableDelta { get; set; }

    /// <summary>
    /// Specifies the time until expiration.
    /// Specifies the time until expiration.
    /// </summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>
    /// The maximum number of entries a CRL can contain. This option exists to prevent
    /// accidental runaway issuance/revocation from overloading Vault. If set to -1, the limit is disabled. Vault 1.19
    /// The maximum number of entries a CRL can contain. This option exists to prevent accidental runaway issuance/revocation from overloading Vault. If set to -1, the limit is disabled.
    /// </summary>
    [JsonPropertyName("maxCrlEntries")]
    public double? MaxCrlEntries { get; set; }

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
    /// Disables the OCSP responder in Vault. Vault 1.12+
    /// Disables or enables the OCSP responder in Vault.
    /// </summary>
    [JsonPropertyName("ocspDisable")]
    public bool? OcspDisable { get; set; }

    /// <summary>
    /// The amount of time an OCSP response can be cached for, useful for OCSP stapling
    /// refresh durations. Vault 1.12+
    /// The amount of time an OCSP response can be cached for, useful for OCSP stapling refresh durations.
    /// </summary>
    [JsonPropertyName("ocspExpiry")]
    public string? OcspExpiry { get; set; }

    /// <summary>
    /// Enables unified CRL and OCSP building. Vault 1.13+
    /// Enables unified CRL and OCSP building.
    /// </summary>
    [JsonPropertyName("unifiedCrl")]
    public bool? UnifiedCrl { get; set; }

    /// <summary>
    /// Enables serving the unified CRL and OCSP on the existing, previously
    /// cluster-local paths. Vault 1.13+
    /// Enables serving the unified CRL and OCSP on the existing, previously cluster-local paths.
    /// </summary>
    [JsonPropertyName("unifiedCrlOnExistingPaths")]
    public bool? UnifiedCrlOnExistingPaths { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCrlConfigSpecInitProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendCrlConfigSpecInitProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCrlConfigSpecInitProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendCrlConfigSpecInitProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCrlConfigSpecInitProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendCrlConfigSpecInitProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendCrlConfigSpecInitProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCrlConfigSpecInitProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendCrlConfigSpecInitProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCrlConfigSpecInitProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendCrlConfigSpecInitProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCrlConfigSpecInitProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendCrlConfigSpecInitProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCrlConfigSpecInitProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendCrlConfigSpecInitProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendCrlConfigSpecInitProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCrlConfigSpecInitProviderBackendSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendCrlConfigSpecInitProviderBackendSelectorPolicy? Policy { get; set; }
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
public partial class V1alpha1SecretBackendCrlConfigSpecInitProvider
{
    /// <summary>
    /// Enables periodic rebuilding of the CRL upon expiry. Vault 1.12+
    /// Enables or disables periodic rebuilding of the CRL upon expiry.
    /// </summary>
    [JsonPropertyName("autoRebuild")]
    public bool? AutoRebuild { get; set; }

    /// <summary>
    /// Grace period before CRL expiry to attempt rebuild of CRL. Vault 1.12+
    /// Grace period before CRL expiry to attempt rebuild of CRL.
    /// </summary>
    [JsonPropertyName("autoRebuildGracePeriod")]
    public string? AutoRebuildGracePeriod { get; set; }

    /// <summary>
    /// The path the PKI secret backend is mounted at, with no leading or trailing /s.
    /// The path of the PKI secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendCrlConfigSpecInitProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendCrlConfigSpecInitProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// Enable cross-cluster revocation request queues. Vault 1.13+
    /// Enable cross-cluster revocation request queues.
    /// </summary>
    [JsonPropertyName("crossClusterRevocation")]
    public bool? CrossClusterRevocation { get; set; }

    /// <summary>
    /// Interval to check for new revocations on, to regenerate the delta CRL.
    /// Interval to check for new revocations on, to regenerate the delta CRL.
    /// </summary>
    [JsonPropertyName("deltaRebuildInterval")]
    public string? DeltaRebuildInterval { get; set; }

    /// <summary>
    /// Disables or enables CRL building.
    /// Disables or enables CRL building
    /// </summary>
    [JsonPropertyName("disable")]
    public bool? Disable { get; set; }

    /// <summary>
    /// Enables building of delta CRLs with up-to-date revocation information,
    /// augmenting the last complete CRL.  Vault 1.12+
    /// Enables or disables building of delta CRLs with up-to-date revocation information, augmenting the last complete CRL.
    /// </summary>
    [JsonPropertyName("enableDelta")]
    public bool? EnableDelta { get; set; }

    /// <summary>
    /// Specifies the time until expiration.
    /// Specifies the time until expiration.
    /// </summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>
    /// The maximum number of entries a CRL can contain. This option exists to prevent
    /// accidental runaway issuance/revocation from overloading Vault. If set to -1, the limit is disabled. Vault 1.19
    /// The maximum number of entries a CRL can contain. This option exists to prevent accidental runaway issuance/revocation from overloading Vault. If set to -1, the limit is disabled.
    /// </summary>
    [JsonPropertyName("maxCrlEntries")]
    public double? MaxCrlEntries { get; set; }

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
    /// Disables the OCSP responder in Vault. Vault 1.12+
    /// Disables or enables the OCSP responder in Vault.
    /// </summary>
    [JsonPropertyName("ocspDisable")]
    public bool? OcspDisable { get; set; }

    /// <summary>
    /// The amount of time an OCSP response can be cached for, useful for OCSP stapling
    /// refresh durations. Vault 1.12+
    /// The amount of time an OCSP response can be cached for, useful for OCSP stapling refresh durations.
    /// </summary>
    [JsonPropertyName("ocspExpiry")]
    public string? OcspExpiry { get; set; }

    /// <summary>
    /// Enables unified CRL and OCSP building. Vault 1.13+
    /// Enables unified CRL and OCSP building.
    /// </summary>
    [JsonPropertyName("unifiedCrl")]
    public bool? UnifiedCrl { get; set; }

    /// <summary>
    /// Enables serving the unified CRL and OCSP on the existing, previously
    /// cluster-local paths. Vault 1.13+
    /// Enables serving the unified CRL and OCSP on the existing, previously cluster-local paths.
    /// </summary>
    [JsonPropertyName("unifiedCrlOnExistingPaths")]
    public bool? UnifiedCrlOnExistingPaths { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendCrlConfigSpecManagementPoliciesEnum>))]
public enum V1alpha1SecretBackendCrlConfigSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCrlConfigSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCrlConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>SecretBackendCrlConfigSpec defines the desired state of SecretBackendCrlConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCrlConfigSpec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1SecretBackendCrlConfigSpecForProvider ForProvider { get; set; }

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
    public V1alpha1SecretBackendCrlConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1SecretBackendCrlConfigSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SecretBackendCrlConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SecretBackendCrlConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCrlConfigStatusAtProvider
{
    /// <summary>
    /// Enables periodic rebuilding of the CRL upon expiry. Vault 1.12+
    /// Enables or disables periodic rebuilding of the CRL upon expiry.
    /// </summary>
    [JsonPropertyName("autoRebuild")]
    public bool? AutoRebuild { get; set; }

    /// <summary>
    /// Grace period before CRL expiry to attempt rebuild of CRL. Vault 1.12+
    /// Grace period before CRL expiry to attempt rebuild of CRL.
    /// </summary>
    [JsonPropertyName("autoRebuildGracePeriod")]
    public string? AutoRebuildGracePeriod { get; set; }

    /// <summary>
    /// The path the PKI secret backend is mounted at, with no leading or trailing /s.
    /// The path of the PKI secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>
    /// Enable cross-cluster revocation request queues. Vault 1.13+
    /// Enable cross-cluster revocation request queues.
    /// </summary>
    [JsonPropertyName("crossClusterRevocation")]
    public bool? CrossClusterRevocation { get; set; }

    /// <summary>
    /// Interval to check for new revocations on, to regenerate the delta CRL.
    /// Interval to check for new revocations on, to regenerate the delta CRL.
    /// </summary>
    [JsonPropertyName("deltaRebuildInterval")]
    public string? DeltaRebuildInterval { get; set; }

    /// <summary>
    /// Disables or enables CRL building.
    /// Disables or enables CRL building
    /// </summary>
    [JsonPropertyName("disable")]
    public bool? Disable { get; set; }

    /// <summary>
    /// Enables building of delta CRLs with up-to-date revocation information,
    /// augmenting the last complete CRL.  Vault 1.12+
    /// Enables or disables building of delta CRLs with up-to-date revocation information, augmenting the last complete CRL.
    /// </summary>
    [JsonPropertyName("enableDelta")]
    public bool? EnableDelta { get; set; }

    /// <summary>
    /// Specifies the time until expiration.
    /// Specifies the time until expiration.
    /// </summary>
    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The maximum number of entries a CRL can contain. This option exists to prevent
    /// accidental runaway issuance/revocation from overloading Vault. If set to -1, the limit is disabled. Vault 1.19
    /// The maximum number of entries a CRL can contain. This option exists to prevent accidental runaway issuance/revocation from overloading Vault. If set to -1, the limit is disabled.
    /// </summary>
    [JsonPropertyName("maxCrlEntries")]
    public double? MaxCrlEntries { get; set; }

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
    /// Disables the OCSP responder in Vault. Vault 1.12+
    /// Disables or enables the OCSP responder in Vault.
    /// </summary>
    [JsonPropertyName("ocspDisable")]
    public bool? OcspDisable { get; set; }

    /// <summary>
    /// The amount of time an OCSP response can be cached for, useful for OCSP stapling
    /// refresh durations. Vault 1.12+
    /// The amount of time an OCSP response can be cached for, useful for OCSP stapling refresh durations.
    /// </summary>
    [JsonPropertyName("ocspExpiry")]
    public string? OcspExpiry { get; set; }

    /// <summary>
    /// Enables unified CRL and OCSP building. Vault 1.13+
    /// Enables unified CRL and OCSP building.
    /// </summary>
    [JsonPropertyName("unifiedCrl")]
    public bool? UnifiedCrl { get; set; }

    /// <summary>
    /// Enables serving the unified CRL and OCSP on the existing, previously
    /// cluster-local paths. Vault 1.13+
    /// Enables serving the unified CRL and OCSP on the existing, previously cluster-local paths.
    /// </summary>
    [JsonPropertyName("unifiedCrlOnExistingPaths")]
    public bool? UnifiedCrlOnExistingPaths { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCrlConfigStatusConditions
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

/// <summary>SecretBackendCrlConfigStatus defines the observed state of SecretBackendCrlConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendCrlConfigStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1SecretBackendCrlConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecretBackendCrlConfigStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SecretBackendCrlConfig is the Schema for the SecretBackendCrlConfigs API. Sets the CRL config on an PKI Secret Backend for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendCrlConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretBackendCrlConfigSpec>, IStatus<V1alpha1SecretBackendCrlConfigStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendCrlConfig";
    public const string KubeGroup = "pki.vault.m.upbound.io";
    public const string KubePluralName = "secretbackendcrlconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pki.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendCrlConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretBackendCrlConfigSpec defines the desired state of SecretBackendCrlConfig</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SecretBackendCrlConfigSpec Spec { get; set; }

    /// <summary>SecretBackendCrlConfigStatus defines the observed state of SecretBackendCrlConfig.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecretBackendCrlConfigStatus? Status { get; set; }
}