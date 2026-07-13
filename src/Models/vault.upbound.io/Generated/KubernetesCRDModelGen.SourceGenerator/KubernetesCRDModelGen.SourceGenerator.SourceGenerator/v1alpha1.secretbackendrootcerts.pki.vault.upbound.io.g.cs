#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.pki.vault.upbound.io;
/// <summary>SecretBackendRootCert is the Schema for the SecretBackendRootCerts API. Generate root.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendRootCertList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecretBackendRootCert>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendRootCertList";
    public const string KubeGroup = "pki.vault.upbound.io";
    public const string KubePluralName = "secretbackendrootcerts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pki.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendRootCertList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SecretBackendRootCert objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SecretBackendRootCert> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRootCertSpecDeletionPolicyEnum>))]
public enum V1alpha1SecretBackendRootCertSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRootCertSpecForProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendRootCertSpecForProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRootCertSpecForProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRootCertSpecForProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRootCertSpecForProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendRootCertSpecForProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendRootCertSpecForProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRootCertSpecForProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendRootCertSpecForProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRootCertSpecForProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendRootCertSpecForProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRootCertSpecForProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRootCertSpecForProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRootCertSpecForProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendRootCertSpecForProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendRootCertSpecForProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRootCertSpecForProviderBackendSelector
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
    public V1alpha1SecretBackendRootCertSpecForProviderBackendSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRootCertSpecForProvider
{
    /// <summary>
    /// List of alternative names
    /// List of alternative names.
    /// </summary>
    [JsonPropertyName("altNames")]
    public IList<string>? AltNames { get; set; }

    /// <summary>
    /// The PKI secret backend the resource belongs to.
    /// The PKI secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendRootCertSpecForProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendRootCertSpecForProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// CN of intermediate to create
    /// CN of root to create.
    /// </summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>
    /// The country
    /// The country.
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// Flag to exclude CN from SANs
    /// Flag to exclude CN from SANs.
    /// </summary>
    [JsonPropertyName("excludeCnFromSans")]
    public bool? ExcludeCnFromSans { get; set; }

    /// <summary>
    /// List of domains for which certificates are not allowed to be issued. Requires Vault version 1.19+.
    /// List of domains for which certificates are not allowed to be issued.
    /// </summary>
    [JsonPropertyName("excludedDnsDomains")]
    public IList<string>? ExcludedDnsDomains { get; set; }

    /// <summary>
    /// List of email addresses for which certificates are not allowed to be issued. Requires Vault version 1.19+.
    /// List of email addresses for which certificates are not allowed to be issued.
    /// </summary>
    [JsonPropertyName("excludedEmailAddresses")]
    public IList<string>? ExcludedEmailAddresses { get; set; }

    /// <summary>
    /// List of IP ranges for which certificates are not allowed to be issued. Requires Vault version 1.19+.
    /// List of IP ranges for which certificates are not allowed to be issued.
    /// </summary>
    [JsonPropertyName("excludedIpRanges")]
    public IList<string>? ExcludedIpRanges { get; set; }

    /// <summary>
    /// List of URI domains for which certificates are not allowed to be issued. Requires Vault version 1.19+.
    /// List of URI domains for which certificates are not allowed to be issued.
    /// </summary>
    [JsonPropertyName("excludedUriDomains")]
    public IList<string>? ExcludedUriDomains { get; set; }

    /// <summary>
    /// The format of data
    /// The format of data.
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>
    /// List of alternative IPs
    /// List of alternative IPs.
    /// </summary>
    [JsonPropertyName("ipSans")]
    public IList<string>? IpSans { get; set; }

    /// <summary>
    /// Provides a name to the specified issuer. The name must be unique
    /// across all issuers and not be the reserved value default
    /// Provides a name to the specified issuer. The name must be unique across all issuers and not be the reserved value &apos;default&apos;.
    /// </summary>
    [JsonPropertyName("issuerName")]
    public string? IssuerName { get; set; }

    /// <summary>
    /// The number of bits to use
    /// The number of bits to use.
    /// </summary>
    [JsonPropertyName("keyBits")]
    public double? KeyBits { get; set; }

    /// <summary>
    /// When a new key is created with this request, optionally specifies
    /// the name for this. The global ref default may not be used as a name.
    /// When a new key is created with this request, optionally specifies the name for this.
    /// </summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>
    /// Specifies the key (either default, by name, or by identifier) to use
    /// for generating this request. Only suitable for type=existing requests.
    /// Specifies the key to use for generating this request.
    /// </summary>
    [JsonPropertyName("keyRef")]
    public string? KeyRef { get; set; }

    /// <summary>
    /// The desired key type
    /// The desired key type.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// Specifies the allowed key usage constraints for the certificate. This list of key usages will be added to the existing set of key usages (CRLSign, CertSign) on the generated certificate. Defaults to [&quot;CRLSign&quot;, &quot;CertSign&quot;] for root CA certificates. Requires Vault 1.19.2+.
    /// Specify the allowed key usage constraint on issued certificates.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public IList<string>? KeyUsage { get; set; }

    /// <summary>
    /// The locality
    /// The locality.
    /// </summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>
    /// The ID of the previously configured managed key. This field is
    /// required if type is kms and it conflicts with managed_key_name
    /// The ID of the previously configured managed key.
    /// </summary>
    [JsonPropertyName("managedKeyId")]
    public string? ManagedKeyId { get; set; }

    /// <summary>
    /// The name of the previously configured managed key. This field is
    /// required if type is kms  and it conflicts with managed_key_id
    /// The name of the previously configured managed key.
    /// </summary>
    [JsonPropertyName("managedKeyName")]
    public string? ManagedKeyName { get; set; }

    /// <summary>
    /// The maximum path length to encode in the generated certificate
    /// The maximum path length to encode in the generated certificate.
    /// </summary>
    [JsonPropertyName("maxPathLength")]
    public double? MaxPathLength { get; set; }

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
    /// Set the Not After field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ. Supports the Y10K end date for IEEE 802.1AR-2018 standard devices, 9999-12-31T23:59:59Z.
    /// Set the Not After field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ. Supports the Y10K end date for IEEE 802.1AR-2018 standard devices, 9999-12-31T23:59:59Z.
    /// </summary>
    [JsonPropertyName("notAfter")]
    public string? NotAfter { get; set; }

    /// <summary>
    /// Specifies the duration by which to backdate the NotBefore property.
    /// Specifies the duration by which to backdate the NotBefore property.
    /// </summary>
    [JsonPropertyName("notBeforeDuration")]
    public string? NotBeforeDuration { get; set; }

    /// <summary>
    /// The organization
    /// The organization.
    /// </summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>
    /// List of other SANs
    /// List of other SANs.
    /// </summary>
    [JsonPropertyName("otherSans")]
    public IList<string>? OtherSans { get; set; }

    /// <summary>
    /// The organization unit
    /// The organization unit.
    /// </summary>
    [JsonPropertyName("ou")]
    public string? Ou { get; set; }

    /// <summary>
    /// List of domains for which certificates are allowed to be issued
    /// List of domains for which certificates are allowed to be issued.
    /// </summary>
    [JsonPropertyName("permittedDnsDomains")]
    public IList<string>? PermittedDnsDomains { get; set; }

    /// <summary>
    /// List of email addresses for which certificates are allowed to be issued. Requires Vault version 1.19+.
    /// List of email addresses for which certificates are allowed to be issued.
    /// </summary>
    [JsonPropertyName("permittedEmailAddresses")]
    public IList<string>? PermittedEmailAddresses { get; set; }

    /// <summary>
    /// List of IP ranges for which certificates are allowed to be issued. Requires Vault version 1.19+.
    /// List of IP ranges for which certificates are allowed to be issued.
    /// </summary>
    [JsonPropertyName("permittedIpRanges")]
    public IList<string>? PermittedIpRanges { get; set; }

    /// <summary>
    /// List of URI domains for which certificates are allowed to be issued. Requires Vault version 1.19+.
    /// List of URI domains for which certificates are allowed to be issued.
    /// </summary>
    [JsonPropertyName("permittedUriDomains")]
    public IList<string>? PermittedUriDomains { get; set; }

    /// <summary>
    /// The postal code
    /// The postal code.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// The private key format
    /// The private key format.
    /// </summary>
    [JsonPropertyName("privateKeyFormat")]
    public string? PrivateKeyFormat { get; set; }

    /// <summary>
    /// The province
    /// The province.
    /// </summary>
    [JsonPropertyName("province")]
    public string? Province { get; set; }

    /// <summary>
    /// The number of bits to use in the signature algorithm
    /// The number of bits to use in the signature algorithm.
    /// </summary>
    [JsonPropertyName("signatureBits")]
    public double? SignatureBits { get; set; }

    /// <summary>
    /// The street address
    /// The street address.
    /// </summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }

    /// <summary>
    /// Time to live
    /// Time to live.
    /// </summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    /// <summary>
    /// Type of intermediate to create. Must be either &quot;exported&quot;, &quot;internal&quot;
    /// or &quot;kms&quot;
    /// Type of root to create. Must be either &quot;existing&quot;, &quot;exported&quot;, &quot;internal&quot; or &quot;kms&quot;
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// List of alternative URIs
    /// List of alternative URIs.
    /// </summary>
    [JsonPropertyName("uriSans")]
    public IList<string>? UriSans { get; set; }

    /// <summary>
    /// When true, uses PSS (Probabilistic Signature Scheme) for RSA signatures instead of PKCS#1 v1.5. PSS provides enhanced security but may have compatibility issues with older systems. Only applicable to RSA keys; ignored for ECDSA/Ed25519 keys. Defaults to false. Requires Vault 1.18.0+.
    /// Whether to use PSS signatures when using a RSA key-type issuer.
    /// </summary>
    [JsonPropertyName("usePss")]
    public bool? UsePss { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRootCertSpecInitProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendRootCertSpecInitProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRootCertSpecInitProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRootCertSpecInitProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRootCertSpecInitProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendRootCertSpecInitProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendRootCertSpecInitProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRootCertSpecInitProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendRootCertSpecInitProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRootCertSpecInitProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendRootCertSpecInitProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRootCertSpecInitProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRootCertSpecInitProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRootCertSpecInitProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendRootCertSpecInitProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendRootCertSpecInitProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRootCertSpecInitProviderBackendSelector
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
    public V1alpha1SecretBackendRootCertSpecInitProviderBackendSelectorPolicy? Policy { get; set; }
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
public partial class V1alpha1SecretBackendRootCertSpecInitProvider
{
    /// <summary>
    /// List of alternative names
    /// List of alternative names.
    /// </summary>
    [JsonPropertyName("altNames")]
    public IList<string>? AltNames { get; set; }

    /// <summary>
    /// The PKI secret backend the resource belongs to.
    /// The PKI secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendRootCertSpecInitProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendRootCertSpecInitProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// CN of intermediate to create
    /// CN of root to create.
    /// </summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>
    /// The country
    /// The country.
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// Flag to exclude CN from SANs
    /// Flag to exclude CN from SANs.
    /// </summary>
    [JsonPropertyName("excludeCnFromSans")]
    public bool? ExcludeCnFromSans { get; set; }

    /// <summary>
    /// List of domains for which certificates are not allowed to be issued. Requires Vault version 1.19+.
    /// List of domains for which certificates are not allowed to be issued.
    /// </summary>
    [JsonPropertyName("excludedDnsDomains")]
    public IList<string>? ExcludedDnsDomains { get; set; }

    /// <summary>
    /// List of email addresses for which certificates are not allowed to be issued. Requires Vault version 1.19+.
    /// List of email addresses for which certificates are not allowed to be issued.
    /// </summary>
    [JsonPropertyName("excludedEmailAddresses")]
    public IList<string>? ExcludedEmailAddresses { get; set; }

    /// <summary>
    /// List of IP ranges for which certificates are not allowed to be issued. Requires Vault version 1.19+.
    /// List of IP ranges for which certificates are not allowed to be issued.
    /// </summary>
    [JsonPropertyName("excludedIpRanges")]
    public IList<string>? ExcludedIpRanges { get; set; }

    /// <summary>
    /// List of URI domains for which certificates are not allowed to be issued. Requires Vault version 1.19+.
    /// List of URI domains for which certificates are not allowed to be issued.
    /// </summary>
    [JsonPropertyName("excludedUriDomains")]
    public IList<string>? ExcludedUriDomains { get; set; }

    /// <summary>
    /// The format of data
    /// The format of data.
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>
    /// List of alternative IPs
    /// List of alternative IPs.
    /// </summary>
    [JsonPropertyName("ipSans")]
    public IList<string>? IpSans { get; set; }

    /// <summary>
    /// Provides a name to the specified issuer. The name must be unique
    /// across all issuers and not be the reserved value default
    /// Provides a name to the specified issuer. The name must be unique across all issuers and not be the reserved value &apos;default&apos;.
    /// </summary>
    [JsonPropertyName("issuerName")]
    public string? IssuerName { get; set; }

    /// <summary>
    /// The number of bits to use
    /// The number of bits to use.
    /// </summary>
    [JsonPropertyName("keyBits")]
    public double? KeyBits { get; set; }

    /// <summary>
    /// When a new key is created with this request, optionally specifies
    /// the name for this. The global ref default may not be used as a name.
    /// When a new key is created with this request, optionally specifies the name for this.
    /// </summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>
    /// Specifies the key (either default, by name, or by identifier) to use
    /// for generating this request. Only suitable for type=existing requests.
    /// Specifies the key to use for generating this request.
    /// </summary>
    [JsonPropertyName("keyRef")]
    public string? KeyRef { get; set; }

    /// <summary>
    /// The desired key type
    /// The desired key type.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// Specifies the allowed key usage constraints for the certificate. This list of key usages will be added to the existing set of key usages (CRLSign, CertSign) on the generated certificate. Defaults to [&quot;CRLSign&quot;, &quot;CertSign&quot;] for root CA certificates. Requires Vault 1.19.2+.
    /// Specify the allowed key usage constraint on issued certificates.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public IList<string>? KeyUsage { get; set; }

    /// <summary>
    /// The locality
    /// The locality.
    /// </summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>
    /// The ID of the previously configured managed key. This field is
    /// required if type is kms and it conflicts with managed_key_name
    /// The ID of the previously configured managed key.
    /// </summary>
    [JsonPropertyName("managedKeyId")]
    public string? ManagedKeyId { get; set; }

    /// <summary>
    /// The name of the previously configured managed key. This field is
    /// required if type is kms  and it conflicts with managed_key_id
    /// The name of the previously configured managed key.
    /// </summary>
    [JsonPropertyName("managedKeyName")]
    public string? ManagedKeyName { get; set; }

    /// <summary>
    /// The maximum path length to encode in the generated certificate
    /// The maximum path length to encode in the generated certificate.
    /// </summary>
    [JsonPropertyName("maxPathLength")]
    public double? MaxPathLength { get; set; }

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
    /// Set the Not After field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ. Supports the Y10K end date for IEEE 802.1AR-2018 standard devices, 9999-12-31T23:59:59Z.
    /// Set the Not After field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ. Supports the Y10K end date for IEEE 802.1AR-2018 standard devices, 9999-12-31T23:59:59Z.
    /// </summary>
    [JsonPropertyName("notAfter")]
    public string? NotAfter { get; set; }

    /// <summary>
    /// Specifies the duration by which to backdate the NotBefore property.
    /// Specifies the duration by which to backdate the NotBefore property.
    /// </summary>
    [JsonPropertyName("notBeforeDuration")]
    public string? NotBeforeDuration { get; set; }

    /// <summary>
    /// The organization
    /// The organization.
    /// </summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>
    /// List of other SANs
    /// List of other SANs.
    /// </summary>
    [JsonPropertyName("otherSans")]
    public IList<string>? OtherSans { get; set; }

    /// <summary>
    /// The organization unit
    /// The organization unit.
    /// </summary>
    [JsonPropertyName("ou")]
    public string? Ou { get; set; }

    /// <summary>
    /// List of domains for which certificates are allowed to be issued
    /// List of domains for which certificates are allowed to be issued.
    /// </summary>
    [JsonPropertyName("permittedDnsDomains")]
    public IList<string>? PermittedDnsDomains { get; set; }

    /// <summary>
    /// List of email addresses for which certificates are allowed to be issued. Requires Vault version 1.19+.
    /// List of email addresses for which certificates are allowed to be issued.
    /// </summary>
    [JsonPropertyName("permittedEmailAddresses")]
    public IList<string>? PermittedEmailAddresses { get; set; }

    /// <summary>
    /// List of IP ranges for which certificates are allowed to be issued. Requires Vault version 1.19+.
    /// List of IP ranges for which certificates are allowed to be issued.
    /// </summary>
    [JsonPropertyName("permittedIpRanges")]
    public IList<string>? PermittedIpRanges { get; set; }

    /// <summary>
    /// List of URI domains for which certificates are allowed to be issued. Requires Vault version 1.19+.
    /// List of URI domains for which certificates are allowed to be issued.
    /// </summary>
    [JsonPropertyName("permittedUriDomains")]
    public IList<string>? PermittedUriDomains { get; set; }

    /// <summary>
    /// The postal code
    /// The postal code.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// The private key format
    /// The private key format.
    /// </summary>
    [JsonPropertyName("privateKeyFormat")]
    public string? PrivateKeyFormat { get; set; }

    /// <summary>
    /// The province
    /// The province.
    /// </summary>
    [JsonPropertyName("province")]
    public string? Province { get; set; }

    /// <summary>
    /// The number of bits to use in the signature algorithm
    /// The number of bits to use in the signature algorithm.
    /// </summary>
    [JsonPropertyName("signatureBits")]
    public double? SignatureBits { get; set; }

    /// <summary>
    /// The street address
    /// The street address.
    /// </summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }

    /// <summary>
    /// Time to live
    /// Time to live.
    /// </summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    /// <summary>
    /// Type of intermediate to create. Must be either &quot;exported&quot;, &quot;internal&quot;
    /// or &quot;kms&quot;
    /// Type of root to create. Must be either &quot;existing&quot;, &quot;exported&quot;, &quot;internal&quot; or &quot;kms&quot;
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// List of alternative URIs
    /// List of alternative URIs.
    /// </summary>
    [JsonPropertyName("uriSans")]
    public IList<string>? UriSans { get; set; }

    /// <summary>
    /// When true, uses PSS (Probabilistic Signature Scheme) for RSA signatures instead of PKCS#1 v1.5. PSS provides enhanced security but may have compatibility issues with older systems. Only applicable to RSA keys; ignored for ECDSA/Ed25519 keys. Defaults to false. Requires Vault 1.18.0+.
    /// Whether to use PSS signatures when using a RSA key-type issuer.
    /// </summary>
    [JsonPropertyName("usePss")]
    public bool? UsePss { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRootCertSpecManagementPoliciesEnum>))]
public enum V1alpha1SecretBackendRootCertSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRootCertSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendRootCertSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRootCertSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRootCertSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRootCertSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendRootCertSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendRootCertSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRootCertSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendRootCertSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRootCertSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SecretBackendRootCertSpec defines the desired state of SecretBackendRootCert</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRootCertSpec
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
    public V1alpha1SecretBackendRootCertSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1SecretBackendRootCertSpecForProvider ForProvider { get; set; }

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
    public V1alpha1SecretBackendRootCertSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1SecretBackendRootCertSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SecretBackendRootCertSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SecretBackendRootCertSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRootCertStatusAtProvider
{
    /// <summary>
    /// List of alternative names
    /// List of alternative names.
    /// </summary>
    [JsonPropertyName("altNames")]
    public IList<string>? AltNames { get; set; }

    /// <summary>
    /// The PKI secret backend the resource belongs to.
    /// The PKI secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>
    /// The certificate.
    /// The certificate.
    /// </summary>
    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    /// <summary>
    /// CN of intermediate to create
    /// CN of root to create.
    /// </summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>
    /// The country
    /// The country.
    /// </summary>
    [JsonPropertyName("country")]
    public string? Country { get; set; }

    /// <summary>
    /// Flag to exclude CN from SANs
    /// Flag to exclude CN from SANs.
    /// </summary>
    [JsonPropertyName("excludeCnFromSans")]
    public bool? ExcludeCnFromSans { get; set; }

    /// <summary>
    /// List of domains for which certificates are not allowed to be issued. Requires Vault version 1.19+.
    /// List of domains for which certificates are not allowed to be issued.
    /// </summary>
    [JsonPropertyName("excludedDnsDomains")]
    public IList<string>? ExcludedDnsDomains { get; set; }

    /// <summary>
    /// List of email addresses for which certificates are not allowed to be issued. Requires Vault version 1.19+.
    /// List of email addresses for which certificates are not allowed to be issued.
    /// </summary>
    [JsonPropertyName("excludedEmailAddresses")]
    public IList<string>? ExcludedEmailAddresses { get; set; }

    /// <summary>
    /// List of IP ranges for which certificates are not allowed to be issued. Requires Vault version 1.19+.
    /// List of IP ranges for which certificates are not allowed to be issued.
    /// </summary>
    [JsonPropertyName("excludedIpRanges")]
    public IList<string>? ExcludedIpRanges { get; set; }

    /// <summary>
    /// List of URI domains for which certificates are not allowed to be issued. Requires Vault version 1.19+.
    /// List of URI domains for which certificates are not allowed to be issued.
    /// </summary>
    [JsonPropertyName("excludedUriDomains")]
    public IList<string>? ExcludedUriDomains { get; set; }

    /// <summary>
    /// The format of data
    /// The format of data.
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// List of alternative IPs
    /// List of alternative IPs.
    /// </summary>
    [JsonPropertyName("ipSans")]
    public IList<string>? IpSans { get; set; }

    /// <summary>
    /// The ID of the generated issuer.
    /// The ID of the generated issuer.
    /// </summary>
    [JsonPropertyName("issuerId")]
    public string? IssuerId { get; set; }

    /// <summary>
    /// Provides a name to the specified issuer. The name must be unique
    /// across all issuers and not be the reserved value default
    /// Provides a name to the specified issuer. The name must be unique across all issuers and not be the reserved value &apos;default&apos;.
    /// </summary>
    [JsonPropertyName("issuerName")]
    public string? IssuerName { get; set; }

    /// <summary>
    /// The issuing CA certificate.
    /// The issuing CA.
    /// </summary>
    [JsonPropertyName("issuingCa")]
    public string? IssuingCa { get; set; }

    /// <summary>
    /// The number of bits to use
    /// The number of bits to use.
    /// </summary>
    [JsonPropertyName("keyBits")]
    public double? KeyBits { get; set; }

    /// <summary>
    /// The ID of the generated key.
    /// The ID of the generated key.
    /// </summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }

    /// <summary>
    /// When a new key is created with this request, optionally specifies
    /// the name for this. The global ref default may not be used as a name.
    /// When a new key is created with this request, optionally specifies the name for this.
    /// </summary>
    [JsonPropertyName("keyName")]
    public string? KeyName { get; set; }

    /// <summary>
    /// Specifies the key (either default, by name, or by identifier) to use
    /// for generating this request. Only suitable for type=existing requests.
    /// Specifies the key to use for generating this request.
    /// </summary>
    [JsonPropertyName("keyRef")]
    public string? KeyRef { get; set; }

    /// <summary>
    /// The desired key type
    /// The desired key type.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// Specifies the allowed key usage constraints for the certificate. This list of key usages will be added to the existing set of key usages (CRLSign, CertSign) on the generated certificate. Defaults to [&quot;CRLSign&quot;, &quot;CertSign&quot;] for root CA certificates. Requires Vault 1.19.2+.
    /// Specify the allowed key usage constraint on issued certificates.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public IList<string>? KeyUsage { get; set; }

    /// <summary>
    /// The locality
    /// The locality.
    /// </summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>
    /// The ID of the previously configured managed key. This field is
    /// required if type is kms and it conflicts with managed_key_name
    /// The ID of the previously configured managed key.
    /// </summary>
    [JsonPropertyName("managedKeyId")]
    public string? ManagedKeyId { get; set; }

    /// <summary>
    /// The name of the previously configured managed key. This field is
    /// required if type is kms  and it conflicts with managed_key_id
    /// The name of the previously configured managed key.
    /// </summary>
    [JsonPropertyName("managedKeyName")]
    public string? ManagedKeyName { get; set; }

    /// <summary>
    /// The maximum path length to encode in the generated certificate
    /// The maximum path length to encode in the generated certificate.
    /// </summary>
    [JsonPropertyName("maxPathLength")]
    public double? MaxPathLength { get; set; }

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
    /// Set the Not After field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ. Supports the Y10K end date for IEEE 802.1AR-2018 standard devices, 9999-12-31T23:59:59Z.
    /// Set the Not After field of the certificate with specified date value. The value format should be given in UTC format YYYY-MM-ddTHH:MM:SSZ. Supports the Y10K end date for IEEE 802.1AR-2018 standard devices, 9999-12-31T23:59:59Z.
    /// </summary>
    [JsonPropertyName("notAfter")]
    public string? NotAfter { get; set; }

    /// <summary>
    /// Specifies the duration by which to backdate the NotBefore property.
    /// Specifies the duration by which to backdate the NotBefore property.
    /// </summary>
    [JsonPropertyName("notBeforeDuration")]
    public string? NotBeforeDuration { get; set; }

    /// <summary>
    /// The organization
    /// The organization.
    /// </summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>
    /// List of other SANs
    /// List of other SANs.
    /// </summary>
    [JsonPropertyName("otherSans")]
    public IList<string>? OtherSans { get; set; }

    /// <summary>
    /// The organization unit
    /// The organization unit.
    /// </summary>
    [JsonPropertyName("ou")]
    public string? Ou { get; set; }

    /// <summary>
    /// List of domains for which certificates are allowed to be issued
    /// List of domains for which certificates are allowed to be issued.
    /// </summary>
    [JsonPropertyName("permittedDnsDomains")]
    public IList<string>? PermittedDnsDomains { get; set; }

    /// <summary>
    /// List of email addresses for which certificates are allowed to be issued. Requires Vault version 1.19+.
    /// List of email addresses for which certificates are allowed to be issued.
    /// </summary>
    [JsonPropertyName("permittedEmailAddresses")]
    public IList<string>? PermittedEmailAddresses { get; set; }

    /// <summary>
    /// List of IP ranges for which certificates are allowed to be issued. Requires Vault version 1.19+.
    /// List of IP ranges for which certificates are allowed to be issued.
    /// </summary>
    [JsonPropertyName("permittedIpRanges")]
    public IList<string>? PermittedIpRanges { get; set; }

    /// <summary>
    /// List of URI domains for which certificates are allowed to be issued. Requires Vault version 1.19+.
    /// List of URI domains for which certificates are allowed to be issued.
    /// </summary>
    [JsonPropertyName("permittedUriDomains")]
    public IList<string>? PermittedUriDomains { get; set; }

    /// <summary>
    /// The postal code
    /// The postal code.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>
    /// The private key format
    /// The private key format.
    /// </summary>
    [JsonPropertyName("privateKeyFormat")]
    public string? PrivateKeyFormat { get; set; }

    /// <summary>
    /// The province
    /// The province.
    /// </summary>
    [JsonPropertyName("province")]
    public string? Province { get; set; }

    /// <summary>
    /// The certificate&apos;s serial number, hex formatted.
    /// The certificate&apos;s serial number, hex formatted.
    /// </summary>
    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    /// <summary>
    /// The number of bits to use in the signature algorithm
    /// The number of bits to use in the signature algorithm.
    /// </summary>
    [JsonPropertyName("signatureBits")]
    public double? SignatureBits { get; set; }

    /// <summary>
    /// The street address
    /// The street address.
    /// </summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }

    /// <summary>
    /// Time to live
    /// Time to live.
    /// </summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    /// <summary>
    /// Type of intermediate to create. Must be either &quot;exported&quot;, &quot;internal&quot;
    /// or &quot;kms&quot;
    /// Type of root to create. Must be either &quot;existing&quot;, &quot;exported&quot;, &quot;internal&quot; or &quot;kms&quot;
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// List of alternative URIs
    /// List of alternative URIs.
    /// </summary>
    [JsonPropertyName("uriSans")]
    public IList<string>? UriSans { get; set; }

    /// <summary>
    /// When true, uses PSS (Probabilistic Signature Scheme) for RSA signatures instead of PKCS#1 v1.5. PSS provides enhanced security but may have compatibility issues with older systems. Only applicable to RSA keys; ignored for ECDSA/Ed25519 keys. Defaults to false. Requires Vault 1.18.0+.
    /// Whether to use PSS signatures when using a RSA key-type issuer.
    /// </summary>
    [JsonPropertyName("usePss")]
    public bool? UsePss { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRootCertStatusConditions
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

/// <summary>SecretBackendRootCertStatus defines the observed state of SecretBackendRootCert.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRootCertStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1SecretBackendRootCertStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecretBackendRootCertStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SecretBackendRootCert is the Schema for the SecretBackendRootCerts API. Generate root.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendRootCert : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretBackendRootCertSpec>, IStatus<V1alpha1SecretBackendRootCertStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendRootCert";
    public const string KubeGroup = "pki.vault.upbound.io";
    public const string KubePluralName = "secretbackendrootcerts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pki.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendRootCert";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretBackendRootCertSpec defines the desired state of SecretBackendRootCert</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SecretBackendRootCertSpec Spec { get; set; }

    /// <summary>SecretBackendRootCertStatus defines the observed state of SecretBackendRootCert.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecretBackendRootCertStatus? Status { get; set; }
}