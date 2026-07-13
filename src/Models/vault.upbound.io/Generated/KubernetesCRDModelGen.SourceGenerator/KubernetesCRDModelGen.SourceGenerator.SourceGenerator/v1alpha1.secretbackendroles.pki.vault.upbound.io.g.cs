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
/// <summary>SecretBackendRole is the Schema for the SecretBackendRoles API. Create a role on an PKI Secret Backend for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendRoleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecretBackendRole>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendRoleList";
    public const string KubeGroup = "pki.vault.upbound.io";
    public const string KubePluralName = "secretbackendroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pki.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendRoleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SecretBackendRole objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SecretBackendRole> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecDeletionPolicyEnum>))]
public enum V1alpha1SecretBackendRoleSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecForProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendRoleSpecForProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecForProviderBackendSelector
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
    public V1alpha1SecretBackendRoleSpecForProviderBackendSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecForProviderPolicyIdentifier
{
    /// <summary>
    /// The URL of the CPS for the policy identifier
    /// Optional CPS URL
    /// </summary>
    [JsonPropertyName("cps")]
    public string? Cps { get; set; }

    /// <summary>
    /// A notice for the policy identifier
    /// Optional notice
    /// </summary>
    [JsonPropertyName("notice")]
    public string? Notice { get; set; }

    /// <summary>
    /// The OID for the policy identifier
    /// OID
    /// </summary>
    [JsonPropertyName("oid")]
    public string? Oid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecForProvider
{
    /// <summary>
    /// Flag to allow any name
    /// Flag to allow any name
    /// </summary>
    [JsonPropertyName("allowAnyName")]
    public bool? AllowAnyName { get; set; }

    /// <summary>
    /// Flag to allow certificates matching the actual domain
    /// Flag to allow certificates matching the actual domain.
    /// </summary>
    [JsonPropertyName("allowBareDomains")]
    public bool? AllowBareDomains { get; set; }

    /// <summary>
    /// Flag to allow names containing glob patterns.
    /// Flag to allow names containing glob patterns.
    /// </summary>
    [JsonPropertyName("allowGlobDomains")]
    public bool? AllowGlobDomains { get; set; }

    /// <summary>
    /// Flag to allow IP SANs
    /// Flag to allow IP SANs
    /// </summary>
    [JsonPropertyName("allowIpSans")]
    public bool? AllowIpSans { get; set; }

    /// <summary>
    /// Flag to allow certificates for localhost
    /// Flag to allow certificates for localhost.
    /// </summary>
    [JsonPropertyName("allowLocalhost")]
    public bool? AllowLocalhost { get; set; }

    /// <summary>
    /// Flag to allow certificates matching subdomains
    /// Flag to allow certificates matching subdomains.
    /// </summary>
    [JsonPropertyName("allowSubdomains")]
    public bool? AllowSubdomains { get; set; }

    /// <summary>
    /// Flag to allow wildcard certificates.
    /// Flag to allow wildcard certificates
    /// </summary>
    [JsonPropertyName("allowWildcardCertificates")]
    public bool? AllowWildcardCertificates { get; set; }

    /// <summary>
    /// List of allowed domains for certificates
    /// The domains of the role.
    /// </summary>
    [JsonPropertyName("allowedDomains")]
    public IList<string>? AllowedDomains { get; set; }

    /// <summary>
    /// Flag, if set, allowed_domains can be specified using identity template expressions such as {{identity.entity.aliases.&lt;mount accessor&gt;.name}}.
    /// Flag to indicate that `allowed_domains` specifies a template expression (e.g. {{identity.entity.aliases.&lt;mount accessor&gt;.name}})
    /// </summary>
    [JsonPropertyName("allowedDomainsTemplate")]
    public bool? AllowedDomainsTemplate { get; set; }

    /// <summary>
    /// Defines allowed custom SANs
    /// Defines allowed custom SANs
    /// </summary>
    [JsonPropertyName("allowedOtherSans")]
    public IList<string>? AllowedOtherSans { get; set; }

    /// <summary>
    /// An array of allowed serial numbers to put in Subject
    /// Defines allowed Subject serial numbers.
    /// </summary>
    [JsonPropertyName("allowedSerialNumbers")]
    public IList<string>? AllowedSerialNumbers { get; set; }

    /// <summary>
    /// Defines allowed URI SANs
    /// Defines allowed URI SANs
    /// </summary>
    [JsonPropertyName("allowedUriSans")]
    public IList<string>? AllowedUriSans { get; set; }

    /// <summary>
    /// Flag, if set, allowed_uri_sans can be specified using identity template expressions such as {{identity.entity.aliases.&lt;mount accessor&gt;.name}}.
    /// Flag to indicate that `allowed_uri_sans` specifies a template expression (e.g. {{identity.entity.aliases.&lt;mount accessor&gt;.name}})
    /// </summary>
    [JsonPropertyName("allowedUriSansTemplate")]
    public bool? AllowedUriSansTemplate { get; set; }

    /// <summary>
    /// Defines allowed User IDs
    /// The allowed User ID&apos;s.
    /// </summary>
    [JsonPropertyName("allowedUserIds")]
    public IList<string>? AllowedUserIds { get; set; }

    /// <summary>
    /// The path the PKI secret backend is mounted at, with no leading or trailing /s.
    /// The path of the PKI secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendRoleSpecForProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendRoleSpecForProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// Flag to mark basic constraints valid when issuing non-CA certificates
    /// Flag to mark basic constraints valid when issuing non-CA certificates.
    /// </summary>
    [JsonPropertyName("basicConstraintsValidForNonCa")]
    public bool? BasicConstraintsValidForNonCa { get; set; }

    /// <summary>
    /// Flag to specify certificates for client use
    /// Flag to specify certificates for client use.
    /// </summary>
    [JsonPropertyName("clientFlag")]
    public bool? ClientFlag { get; set; }

    /// <summary>
    /// Validations to run on the Common Name field of the certificate, choices: email, hostname, disabled
    /// Specify validations to run on the Common Name field of the certificate.
    /// </summary>
    [JsonPropertyName("cnValidations")]
    public IList<string>? CnValidations { get; set; }

    /// <summary>
    /// Flag to specify certificates for code signing use
    /// Flag to specify certificates for code signing use.
    /// </summary>
    [JsonPropertyName("codeSigningFlag")]
    public bool? CodeSigningFlag { get; set; }

    /// <summary>
    /// The country of generated certificates
    /// The country of generated certificates.
    /// </summary>
    [JsonPropertyName("country")]
    public IList<string>? Country { get; set; }

    /// <summary>
    /// Flag to specify certificates for email protection use
    /// Flag to specify certificates for email protection use.
    /// </summary>
    [JsonPropertyName("emailProtectionFlag")]
    public bool? EmailProtectionFlag { get; set; }

    /// <summary>
    /// Flag to allow only valid host names
    /// Flag to allow only valid host names
    /// </summary>
    [JsonPropertyName("enforceHostnames")]
    public bool? EnforceHostnames { get; set; }

    /// <summary>
    /// Specify the allowed extended key usage constraint on issued certificates
    /// Specify the allowed extended key usage constraint on issued certificates.
    /// </summary>
    [JsonPropertyName("extKeyUsage")]
    public IList<string>? ExtKeyUsage { get; set; }

    /// <summary>
    /// Specify the allowed extended key usage OIDs constraint on issued certificates
    /// A list of extended key usage OIDs.
    /// </summary>
    [JsonPropertyName("extKeyUsageOids")]
    public IList<string>? ExtKeyUsageOids { get; set; }

    /// <summary>
    /// Flag to generate leases with certificates
    /// Flag to generate leases with certificates.
    /// </summary>
    [JsonPropertyName("generateLease")]
    public bool? GenerateLease { get; set; }

    /// <summary>
    /// Specifies the default issuer of this request. May
    /// be the value default, a name, or an issuer ID. Use ACLs to prevent access to
    /// the /pki/issuer/:issuer_ref/{issue,sign}/:name paths to prevent users
    /// overriding the role&apos;s issuer_ref value.
    /// Specifies the default issuer of this request.
    /// </summary>
    [JsonPropertyName("issuerRef")]
    public string? IssuerRef { get; set; }

    /// <summary>
    /// The number of bits of generated keys
    /// The number of bits of generated keys.
    /// </summary>
    [JsonPropertyName("keyBits")]
    public double? KeyBits { get; set; }

    /// <summary>
    /// The generated key type, choices: rsa, ec, ed25519, any
    /// Defaults to rsa
    /// The generated key type.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// Specify the allowed key usage constraint on issued
    /// certificates. Defaults to [&quot;DigitalSignature&quot;, &quot;KeyAgreement&quot;, &quot;KeyEncipherment&quot;]).
    /// To specify no default key usage constraints, set this to an empty list [].
    /// Specify the allowed key usage constraint on issued certificates.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public IList<string>? KeyUsage { get; set; }

    /// <summary>
    /// The locality of generated certificates
    /// The locality of generated certificates.
    /// </summary>
    [JsonPropertyName("locality")]
    public IList<string>? Locality { get; set; }

    /// <summary>
    /// The maximum lease TTL, in seconds, for the role.
    /// The maximum TTL.
    /// </summary>
    [JsonPropertyName("maxTtl")]
    public string? MaxTtl { get; set; }

    /// <summary>
    /// The name to identify this role within the backend. Must be unique within the backend.
    /// Unique name for the role.
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
    /// Flag to not store certificates in the storage backend
    /// Flag to not store certificates in the storage backend.
    /// </summary>
    [JsonPropertyName("noStore")]
    public bool? NoStore { get; set; }

    /// <summary>
    /// Allows metadata to be stored keyed on the certificate&apos;s serial number. The field is independent of no_store, allowing metadata storage regardless of whether certificates are stored. If true, metadata is not stored and an error is returned if the metadata field is specified on issuance APIs
    /// Allows metadata to be stored keyed on the certificate&apos;s serial number. The field is independent of no_store, allowing metadata storage regardless of whether certificates are stored. If true, metadata is not stored and an error is returned if the metadata field is specified on issuance APIs
    /// </summary>
    [JsonPropertyName("noStoreMetadata")]
    public bool? NoStoreMetadata { get; set; }

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
    /// The organization of generated certificates
    /// The organization of generated certificates.
    /// </summary>
    [JsonPropertyName("organization")]
    public IList<string>? Organization { get; set; }

    /// <summary>
    /// The organization unit of generated certificates
    /// The organization unit of generated certificates.
    /// </summary>
    [JsonPropertyName("ou")]
    public IList<string>? Ou { get; set; }

    /// <summary>
    /// (Vault 1.11+ only) A block for specifying policy identifers. The policy_identifier block can be repeated, and supports the following arguments:
    /// Policy identifier block; can only be used with Vault 1.11+
    /// </summary>
    [JsonPropertyName("policyIdentifier")]
    public IList<V1alpha1SecretBackendRoleSpecForProviderPolicyIdentifier>? PolicyIdentifier { get; set; }

    /// <summary>
    /// Specify the list of allowed policies OIDs. Use with Vault 1.10 or before. For Vault 1.11+, use policy_identifier blocks instead
    /// Specify the list of allowed policies OIDs.
    /// </summary>
    [JsonPropertyName("policyIdentifiers")]
    public IList<string>? PolicyIdentifiers { get; set; }

    /// <summary>
    /// The postal code of generated certificates
    /// The postal code of generated certificates.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public IList<string>? PostalCode { get; set; }

    /// <summary>
    /// The province of generated certificates
    /// The province of generated certificates.
    /// </summary>
    [JsonPropertyName("province")]
    public IList<string>? Province { get; set; }

    /// <summary>
    /// Flag to force CN usage
    /// Flag to force CN usage.
    /// </summary>
    [JsonPropertyName("requireCn")]
    public bool? RequireCn { get; set; }

    /// <summary>
    /// Specifies the source of the subject serial number. Valid values are json-csr (default) or json. When set to json-csr, the subject serial number is taken from the serial_number parameter and falls back to the serial number in the CSR. When set to json, the subject serial number is taken from the serial_number parameter but will ignore any value in the CSR. For backwards compatibility an empty value for this field will default to the json-csr behavior.
    /// Specifies the source of the subject serial number. Valid values are json-csr (default) or json. When set to json-csr, the subject serial number is taken from the serial_number parameter and falls back to the serial number in the CSR. When set to json, the subject serial number is taken from the serial_number parameter but will ignore any value in the CSR. For backwards compatibility an empty value for this field will default to the json-csr behavior.
    /// </summary>
    [JsonPropertyName("serialNumberSource")]
    public string? SerialNumberSource { get; set; }

    /// <summary>
    /// Flag to specify certificates for server use
    /// Flag to specify certificates for server use.
    /// </summary>
    [JsonPropertyName("serverFlag")]
    public bool? ServerFlag { get; set; }

    /// <summary>
    /// The number of bits to use in the signature algorithm
    /// The number of bits to use in the signature algorithm.
    /// </summary>
    [JsonPropertyName("signatureBits")]
    public double? SignatureBits { get; set; }

    /// <summary>
    /// The street address of generated certificates
    /// The street address of generated certificates.
    /// </summary>
    [JsonPropertyName("streetAddress")]
    public IList<string>? StreetAddress { get; set; }

    /// <summary>
    /// The TTL, in seconds, for any certificate issued against this role.
    /// The TTL.
    /// </summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    /// <summary>
    /// Flag to use the CN in the CSR
    /// Flag to use the CN in the CSR.
    /// </summary>
    [JsonPropertyName("useCsrCommonName")]
    public bool? UseCsrCommonName { get; set; }

    /// <summary>
    /// Flag to use the SANs in the CSR
    /// Flag to use the SANs in the CSR.
    /// </summary>
    [JsonPropertyName("useCsrSans")]
    public bool? UseCsrSans { get; set; }

    /// <summary>
    /// Specifies whether or not to use PSS signatures over PKCS#1v1.5 signatures when a RSA-type issuer is used. Ignored for ECDSA/Ed25519 issuers.
    /// Specifies whether or not to use PSS signatures over PKCS#1v1.5 signatures when a RSA-type issuer is used. Ignored for ECDSA/Ed25519 issuers.
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecInitProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendRoleSpecInitProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecInitProviderBackendSelector
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
    public V1alpha1SecretBackendRoleSpecInitProviderBackendSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecInitProviderPolicyIdentifier
{
    /// <summary>
    /// The URL of the CPS for the policy identifier
    /// Optional CPS URL
    /// </summary>
    [JsonPropertyName("cps")]
    public string? Cps { get; set; }

    /// <summary>
    /// A notice for the policy identifier
    /// Optional notice
    /// </summary>
    [JsonPropertyName("notice")]
    public string? Notice { get; set; }

    /// <summary>
    /// The OID for the policy identifier
    /// OID
    /// </summary>
    [JsonPropertyName("oid")]
    public string? Oid { get; set; }
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
public partial class V1alpha1SecretBackendRoleSpecInitProvider
{
    /// <summary>
    /// Flag to allow any name
    /// Flag to allow any name
    /// </summary>
    [JsonPropertyName("allowAnyName")]
    public bool? AllowAnyName { get; set; }

    /// <summary>
    /// Flag to allow certificates matching the actual domain
    /// Flag to allow certificates matching the actual domain.
    /// </summary>
    [JsonPropertyName("allowBareDomains")]
    public bool? AllowBareDomains { get; set; }

    /// <summary>
    /// Flag to allow names containing glob patterns.
    /// Flag to allow names containing glob patterns.
    /// </summary>
    [JsonPropertyName("allowGlobDomains")]
    public bool? AllowGlobDomains { get; set; }

    /// <summary>
    /// Flag to allow IP SANs
    /// Flag to allow IP SANs
    /// </summary>
    [JsonPropertyName("allowIpSans")]
    public bool? AllowIpSans { get; set; }

    /// <summary>
    /// Flag to allow certificates for localhost
    /// Flag to allow certificates for localhost.
    /// </summary>
    [JsonPropertyName("allowLocalhost")]
    public bool? AllowLocalhost { get; set; }

    /// <summary>
    /// Flag to allow certificates matching subdomains
    /// Flag to allow certificates matching subdomains.
    /// </summary>
    [JsonPropertyName("allowSubdomains")]
    public bool? AllowSubdomains { get; set; }

    /// <summary>
    /// Flag to allow wildcard certificates.
    /// Flag to allow wildcard certificates
    /// </summary>
    [JsonPropertyName("allowWildcardCertificates")]
    public bool? AllowWildcardCertificates { get; set; }

    /// <summary>
    /// List of allowed domains for certificates
    /// The domains of the role.
    /// </summary>
    [JsonPropertyName("allowedDomains")]
    public IList<string>? AllowedDomains { get; set; }

    /// <summary>
    /// Flag, if set, allowed_domains can be specified using identity template expressions such as {{identity.entity.aliases.&lt;mount accessor&gt;.name}}.
    /// Flag to indicate that `allowed_domains` specifies a template expression (e.g. {{identity.entity.aliases.&lt;mount accessor&gt;.name}})
    /// </summary>
    [JsonPropertyName("allowedDomainsTemplate")]
    public bool? AllowedDomainsTemplate { get; set; }

    /// <summary>
    /// Defines allowed custom SANs
    /// Defines allowed custom SANs
    /// </summary>
    [JsonPropertyName("allowedOtherSans")]
    public IList<string>? AllowedOtherSans { get; set; }

    /// <summary>
    /// An array of allowed serial numbers to put in Subject
    /// Defines allowed Subject serial numbers.
    /// </summary>
    [JsonPropertyName("allowedSerialNumbers")]
    public IList<string>? AllowedSerialNumbers { get; set; }

    /// <summary>
    /// Defines allowed URI SANs
    /// Defines allowed URI SANs
    /// </summary>
    [JsonPropertyName("allowedUriSans")]
    public IList<string>? AllowedUriSans { get; set; }

    /// <summary>
    /// Flag, if set, allowed_uri_sans can be specified using identity template expressions such as {{identity.entity.aliases.&lt;mount accessor&gt;.name}}.
    /// Flag to indicate that `allowed_uri_sans` specifies a template expression (e.g. {{identity.entity.aliases.&lt;mount accessor&gt;.name}})
    /// </summary>
    [JsonPropertyName("allowedUriSansTemplate")]
    public bool? AllowedUriSansTemplate { get; set; }

    /// <summary>
    /// Defines allowed User IDs
    /// The allowed User ID&apos;s.
    /// </summary>
    [JsonPropertyName("allowedUserIds")]
    public IList<string>? AllowedUserIds { get; set; }

    /// <summary>
    /// The path the PKI secret backend is mounted at, with no leading or trailing /s.
    /// The path of the PKI secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendRoleSpecInitProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendRoleSpecInitProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// Flag to mark basic constraints valid when issuing non-CA certificates
    /// Flag to mark basic constraints valid when issuing non-CA certificates.
    /// </summary>
    [JsonPropertyName("basicConstraintsValidForNonCa")]
    public bool? BasicConstraintsValidForNonCa { get; set; }

    /// <summary>
    /// Flag to specify certificates for client use
    /// Flag to specify certificates for client use.
    /// </summary>
    [JsonPropertyName("clientFlag")]
    public bool? ClientFlag { get; set; }

    /// <summary>
    /// Validations to run on the Common Name field of the certificate, choices: email, hostname, disabled
    /// Specify validations to run on the Common Name field of the certificate.
    /// </summary>
    [JsonPropertyName("cnValidations")]
    public IList<string>? CnValidations { get; set; }

    /// <summary>
    /// Flag to specify certificates for code signing use
    /// Flag to specify certificates for code signing use.
    /// </summary>
    [JsonPropertyName("codeSigningFlag")]
    public bool? CodeSigningFlag { get; set; }

    /// <summary>
    /// The country of generated certificates
    /// The country of generated certificates.
    /// </summary>
    [JsonPropertyName("country")]
    public IList<string>? Country { get; set; }

    /// <summary>
    /// Flag to specify certificates for email protection use
    /// Flag to specify certificates for email protection use.
    /// </summary>
    [JsonPropertyName("emailProtectionFlag")]
    public bool? EmailProtectionFlag { get; set; }

    /// <summary>
    /// Flag to allow only valid host names
    /// Flag to allow only valid host names
    /// </summary>
    [JsonPropertyName("enforceHostnames")]
    public bool? EnforceHostnames { get; set; }

    /// <summary>
    /// Specify the allowed extended key usage constraint on issued certificates
    /// Specify the allowed extended key usage constraint on issued certificates.
    /// </summary>
    [JsonPropertyName("extKeyUsage")]
    public IList<string>? ExtKeyUsage { get; set; }

    /// <summary>
    /// Specify the allowed extended key usage OIDs constraint on issued certificates
    /// A list of extended key usage OIDs.
    /// </summary>
    [JsonPropertyName("extKeyUsageOids")]
    public IList<string>? ExtKeyUsageOids { get; set; }

    /// <summary>
    /// Flag to generate leases with certificates
    /// Flag to generate leases with certificates.
    /// </summary>
    [JsonPropertyName("generateLease")]
    public bool? GenerateLease { get; set; }

    /// <summary>
    /// Specifies the default issuer of this request. May
    /// be the value default, a name, or an issuer ID. Use ACLs to prevent access to
    /// the /pki/issuer/:issuer_ref/{issue,sign}/:name paths to prevent users
    /// overriding the role&apos;s issuer_ref value.
    /// Specifies the default issuer of this request.
    /// </summary>
    [JsonPropertyName("issuerRef")]
    public string? IssuerRef { get; set; }

    /// <summary>
    /// The number of bits of generated keys
    /// The number of bits of generated keys.
    /// </summary>
    [JsonPropertyName("keyBits")]
    public double? KeyBits { get; set; }

    /// <summary>
    /// The generated key type, choices: rsa, ec, ed25519, any
    /// Defaults to rsa
    /// The generated key type.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// Specify the allowed key usage constraint on issued
    /// certificates. Defaults to [&quot;DigitalSignature&quot;, &quot;KeyAgreement&quot;, &quot;KeyEncipherment&quot;]).
    /// To specify no default key usage constraints, set this to an empty list [].
    /// Specify the allowed key usage constraint on issued certificates.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public IList<string>? KeyUsage { get; set; }

    /// <summary>
    /// The locality of generated certificates
    /// The locality of generated certificates.
    /// </summary>
    [JsonPropertyName("locality")]
    public IList<string>? Locality { get; set; }

    /// <summary>
    /// The maximum lease TTL, in seconds, for the role.
    /// The maximum TTL.
    /// </summary>
    [JsonPropertyName("maxTtl")]
    public string? MaxTtl { get; set; }

    /// <summary>
    /// The name to identify this role within the backend. Must be unique within the backend.
    /// Unique name for the role.
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
    /// Flag to not store certificates in the storage backend
    /// Flag to not store certificates in the storage backend.
    /// </summary>
    [JsonPropertyName("noStore")]
    public bool? NoStore { get; set; }

    /// <summary>
    /// Allows metadata to be stored keyed on the certificate&apos;s serial number. The field is independent of no_store, allowing metadata storage regardless of whether certificates are stored. If true, metadata is not stored and an error is returned if the metadata field is specified on issuance APIs
    /// Allows metadata to be stored keyed on the certificate&apos;s serial number. The field is independent of no_store, allowing metadata storage regardless of whether certificates are stored. If true, metadata is not stored and an error is returned if the metadata field is specified on issuance APIs
    /// </summary>
    [JsonPropertyName("noStoreMetadata")]
    public bool? NoStoreMetadata { get; set; }

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
    /// The organization of generated certificates
    /// The organization of generated certificates.
    /// </summary>
    [JsonPropertyName("organization")]
    public IList<string>? Organization { get; set; }

    /// <summary>
    /// The organization unit of generated certificates
    /// The organization unit of generated certificates.
    /// </summary>
    [JsonPropertyName("ou")]
    public IList<string>? Ou { get; set; }

    /// <summary>
    /// (Vault 1.11+ only) A block for specifying policy identifers. The policy_identifier block can be repeated, and supports the following arguments:
    /// Policy identifier block; can only be used with Vault 1.11+
    /// </summary>
    [JsonPropertyName("policyIdentifier")]
    public IList<V1alpha1SecretBackendRoleSpecInitProviderPolicyIdentifier>? PolicyIdentifier { get; set; }

    /// <summary>
    /// Specify the list of allowed policies OIDs. Use with Vault 1.10 or before. For Vault 1.11+, use policy_identifier blocks instead
    /// Specify the list of allowed policies OIDs.
    /// </summary>
    [JsonPropertyName("policyIdentifiers")]
    public IList<string>? PolicyIdentifiers { get; set; }

    /// <summary>
    /// The postal code of generated certificates
    /// The postal code of generated certificates.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public IList<string>? PostalCode { get; set; }

    /// <summary>
    /// The province of generated certificates
    /// The province of generated certificates.
    /// </summary>
    [JsonPropertyName("province")]
    public IList<string>? Province { get; set; }

    /// <summary>
    /// Flag to force CN usage
    /// Flag to force CN usage.
    /// </summary>
    [JsonPropertyName("requireCn")]
    public bool? RequireCn { get; set; }

    /// <summary>
    /// Specifies the source of the subject serial number. Valid values are json-csr (default) or json. When set to json-csr, the subject serial number is taken from the serial_number parameter and falls back to the serial number in the CSR. When set to json, the subject serial number is taken from the serial_number parameter but will ignore any value in the CSR. For backwards compatibility an empty value for this field will default to the json-csr behavior.
    /// Specifies the source of the subject serial number. Valid values are json-csr (default) or json. When set to json-csr, the subject serial number is taken from the serial_number parameter and falls back to the serial number in the CSR. When set to json, the subject serial number is taken from the serial_number parameter but will ignore any value in the CSR. For backwards compatibility an empty value for this field will default to the json-csr behavior.
    /// </summary>
    [JsonPropertyName("serialNumberSource")]
    public string? SerialNumberSource { get; set; }

    /// <summary>
    /// Flag to specify certificates for server use
    /// Flag to specify certificates for server use.
    /// </summary>
    [JsonPropertyName("serverFlag")]
    public bool? ServerFlag { get; set; }

    /// <summary>
    /// The number of bits to use in the signature algorithm
    /// The number of bits to use in the signature algorithm.
    /// </summary>
    [JsonPropertyName("signatureBits")]
    public double? SignatureBits { get; set; }

    /// <summary>
    /// The street address of generated certificates
    /// The street address of generated certificates.
    /// </summary>
    [JsonPropertyName("streetAddress")]
    public IList<string>? StreetAddress { get; set; }

    /// <summary>
    /// The TTL, in seconds, for any certificate issued against this role.
    /// The TTL.
    /// </summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    /// <summary>
    /// Flag to use the CN in the CSR
    /// Flag to use the CN in the CSR.
    /// </summary>
    [JsonPropertyName("useCsrCommonName")]
    public bool? UseCsrCommonName { get; set; }

    /// <summary>
    /// Flag to use the SANs in the CSR
    /// Flag to use the SANs in the CSR.
    /// </summary>
    [JsonPropertyName("useCsrSans")]
    public bool? UseCsrSans { get; set; }

    /// <summary>
    /// Specifies whether or not to use PSS signatures over PKCS#1v1.5 signatures when a RSA-type issuer is used. Ignored for ECDSA/Ed25519 issuers.
    /// Specifies whether or not to use PSS signatures over PKCS#1v1.5 signatures when a RSA-type issuer is used. Ignored for ECDSA/Ed25519 issuers.
    /// </summary>
    [JsonPropertyName("usePss")]
    public bool? UsePss { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecManagementPoliciesEnum>))]
public enum V1alpha1SecretBackendRoleSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendRoleSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendRoleSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendRoleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendRoleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendRoleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendRoleSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SecretBackendRoleSpec defines the desired state of SecretBackendRole</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleSpec
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
    public V1alpha1SecretBackendRoleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1SecretBackendRoleSpecForProvider ForProvider { get; set; }

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
    public V1alpha1SecretBackendRoleSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1SecretBackendRoleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SecretBackendRoleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SecretBackendRoleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleStatusAtProviderPolicyIdentifier
{
    /// <summary>
    /// The URL of the CPS for the policy identifier
    /// Optional CPS URL
    /// </summary>
    [JsonPropertyName("cps")]
    public string? Cps { get; set; }

    /// <summary>
    /// A notice for the policy identifier
    /// Optional notice
    /// </summary>
    [JsonPropertyName("notice")]
    public string? Notice { get; set; }

    /// <summary>
    /// The OID for the policy identifier
    /// OID
    /// </summary>
    [JsonPropertyName("oid")]
    public string? Oid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleStatusAtProvider
{
    /// <summary>
    /// Flag to allow any name
    /// Flag to allow any name
    /// </summary>
    [JsonPropertyName("allowAnyName")]
    public bool? AllowAnyName { get; set; }

    /// <summary>
    /// Flag to allow certificates matching the actual domain
    /// Flag to allow certificates matching the actual domain.
    /// </summary>
    [JsonPropertyName("allowBareDomains")]
    public bool? AllowBareDomains { get; set; }

    /// <summary>
    /// Flag to allow names containing glob patterns.
    /// Flag to allow names containing glob patterns.
    /// </summary>
    [JsonPropertyName("allowGlobDomains")]
    public bool? AllowGlobDomains { get; set; }

    /// <summary>
    /// Flag to allow IP SANs
    /// Flag to allow IP SANs
    /// </summary>
    [JsonPropertyName("allowIpSans")]
    public bool? AllowIpSans { get; set; }

    /// <summary>
    /// Flag to allow certificates for localhost
    /// Flag to allow certificates for localhost.
    /// </summary>
    [JsonPropertyName("allowLocalhost")]
    public bool? AllowLocalhost { get; set; }

    /// <summary>
    /// Flag to allow certificates matching subdomains
    /// Flag to allow certificates matching subdomains.
    /// </summary>
    [JsonPropertyName("allowSubdomains")]
    public bool? AllowSubdomains { get; set; }

    /// <summary>
    /// Flag to allow wildcard certificates.
    /// Flag to allow wildcard certificates
    /// </summary>
    [JsonPropertyName("allowWildcardCertificates")]
    public bool? AllowWildcardCertificates { get; set; }

    /// <summary>
    /// List of allowed domains for certificates
    /// The domains of the role.
    /// </summary>
    [JsonPropertyName("allowedDomains")]
    public IList<string>? AllowedDomains { get; set; }

    /// <summary>
    /// Flag, if set, allowed_domains can be specified using identity template expressions such as {{identity.entity.aliases.&lt;mount accessor&gt;.name}}.
    /// Flag to indicate that `allowed_domains` specifies a template expression (e.g. {{identity.entity.aliases.&lt;mount accessor&gt;.name}})
    /// </summary>
    [JsonPropertyName("allowedDomainsTemplate")]
    public bool? AllowedDomainsTemplate { get; set; }

    /// <summary>
    /// Defines allowed custom SANs
    /// Defines allowed custom SANs
    /// </summary>
    [JsonPropertyName("allowedOtherSans")]
    public IList<string>? AllowedOtherSans { get; set; }

    /// <summary>
    /// An array of allowed serial numbers to put in Subject
    /// Defines allowed Subject serial numbers.
    /// </summary>
    [JsonPropertyName("allowedSerialNumbers")]
    public IList<string>? AllowedSerialNumbers { get; set; }

    /// <summary>
    /// Defines allowed URI SANs
    /// Defines allowed URI SANs
    /// </summary>
    [JsonPropertyName("allowedUriSans")]
    public IList<string>? AllowedUriSans { get; set; }

    /// <summary>
    /// Flag, if set, allowed_uri_sans can be specified using identity template expressions such as {{identity.entity.aliases.&lt;mount accessor&gt;.name}}.
    /// Flag to indicate that `allowed_uri_sans` specifies a template expression (e.g. {{identity.entity.aliases.&lt;mount accessor&gt;.name}})
    /// </summary>
    [JsonPropertyName("allowedUriSansTemplate")]
    public bool? AllowedUriSansTemplate { get; set; }

    /// <summary>
    /// Defines allowed User IDs
    /// The allowed User ID&apos;s.
    /// </summary>
    [JsonPropertyName("allowedUserIds")]
    public IList<string>? AllowedUserIds { get; set; }

    /// <summary>
    /// The path the PKI secret backend is mounted at, with no leading or trailing /s.
    /// The path of the PKI secret backend the resource belongs to.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>
    /// Flag to mark basic constraints valid when issuing non-CA certificates
    /// Flag to mark basic constraints valid when issuing non-CA certificates.
    /// </summary>
    [JsonPropertyName("basicConstraintsValidForNonCa")]
    public bool? BasicConstraintsValidForNonCa { get; set; }

    /// <summary>
    /// Flag to specify certificates for client use
    /// Flag to specify certificates for client use.
    /// </summary>
    [JsonPropertyName("clientFlag")]
    public bool? ClientFlag { get; set; }

    /// <summary>
    /// Validations to run on the Common Name field of the certificate, choices: email, hostname, disabled
    /// Specify validations to run on the Common Name field of the certificate.
    /// </summary>
    [JsonPropertyName("cnValidations")]
    public IList<string>? CnValidations { get; set; }

    /// <summary>
    /// Flag to specify certificates for code signing use
    /// Flag to specify certificates for code signing use.
    /// </summary>
    [JsonPropertyName("codeSigningFlag")]
    public bool? CodeSigningFlag { get; set; }

    /// <summary>
    /// The country of generated certificates
    /// The country of generated certificates.
    /// </summary>
    [JsonPropertyName("country")]
    public IList<string>? Country { get; set; }

    /// <summary>
    /// Flag to specify certificates for email protection use
    /// Flag to specify certificates for email protection use.
    /// </summary>
    [JsonPropertyName("emailProtectionFlag")]
    public bool? EmailProtectionFlag { get; set; }

    /// <summary>
    /// Flag to allow only valid host names
    /// Flag to allow only valid host names
    /// </summary>
    [JsonPropertyName("enforceHostnames")]
    public bool? EnforceHostnames { get; set; }

    /// <summary>
    /// Specify the allowed extended key usage constraint on issued certificates
    /// Specify the allowed extended key usage constraint on issued certificates.
    /// </summary>
    [JsonPropertyName("extKeyUsage")]
    public IList<string>? ExtKeyUsage { get; set; }

    /// <summary>
    /// Specify the allowed extended key usage OIDs constraint on issued certificates
    /// A list of extended key usage OIDs.
    /// </summary>
    [JsonPropertyName("extKeyUsageOids")]
    public IList<string>? ExtKeyUsageOids { get; set; }

    /// <summary>
    /// Flag to generate leases with certificates
    /// Flag to generate leases with certificates.
    /// </summary>
    [JsonPropertyName("generateLease")]
    public bool? GenerateLease { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Specifies the default issuer of this request. May
    /// be the value default, a name, or an issuer ID. Use ACLs to prevent access to
    /// the /pki/issuer/:issuer_ref/{issue,sign}/:name paths to prevent users
    /// overriding the role&apos;s issuer_ref value.
    /// Specifies the default issuer of this request.
    /// </summary>
    [JsonPropertyName("issuerRef")]
    public string? IssuerRef { get; set; }

    /// <summary>
    /// The number of bits of generated keys
    /// The number of bits of generated keys.
    /// </summary>
    [JsonPropertyName("keyBits")]
    public double? KeyBits { get; set; }

    /// <summary>
    /// The generated key type, choices: rsa, ec, ed25519, any
    /// Defaults to rsa
    /// The generated key type.
    /// </summary>
    [JsonPropertyName("keyType")]
    public string? KeyType { get; set; }

    /// <summary>
    /// Specify the allowed key usage constraint on issued
    /// certificates. Defaults to [&quot;DigitalSignature&quot;, &quot;KeyAgreement&quot;, &quot;KeyEncipherment&quot;]).
    /// To specify no default key usage constraints, set this to an empty list [].
    /// Specify the allowed key usage constraint on issued certificates.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public IList<string>? KeyUsage { get; set; }

    /// <summary>
    /// The locality of generated certificates
    /// The locality of generated certificates.
    /// </summary>
    [JsonPropertyName("locality")]
    public IList<string>? Locality { get; set; }

    /// <summary>
    /// The maximum lease TTL, in seconds, for the role.
    /// The maximum TTL.
    /// </summary>
    [JsonPropertyName("maxTtl")]
    public string? MaxTtl { get; set; }

    /// <summary>
    /// The name to identify this role within the backend. Must be unique within the backend.
    /// Unique name for the role.
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
    /// Flag to not store certificates in the storage backend
    /// Flag to not store certificates in the storage backend.
    /// </summary>
    [JsonPropertyName("noStore")]
    public bool? NoStore { get; set; }

    /// <summary>
    /// Allows metadata to be stored keyed on the certificate&apos;s serial number. The field is independent of no_store, allowing metadata storage regardless of whether certificates are stored. If true, metadata is not stored and an error is returned if the metadata field is specified on issuance APIs
    /// Allows metadata to be stored keyed on the certificate&apos;s serial number. The field is independent of no_store, allowing metadata storage regardless of whether certificates are stored. If true, metadata is not stored and an error is returned if the metadata field is specified on issuance APIs
    /// </summary>
    [JsonPropertyName("noStoreMetadata")]
    public bool? NoStoreMetadata { get; set; }

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
    /// The organization of generated certificates
    /// The organization of generated certificates.
    /// </summary>
    [JsonPropertyName("organization")]
    public IList<string>? Organization { get; set; }

    /// <summary>
    /// The organization unit of generated certificates
    /// The organization unit of generated certificates.
    /// </summary>
    [JsonPropertyName("ou")]
    public IList<string>? Ou { get; set; }

    /// <summary>
    /// (Vault 1.11+ only) A block for specifying policy identifers. The policy_identifier block can be repeated, and supports the following arguments:
    /// Policy identifier block; can only be used with Vault 1.11+
    /// </summary>
    [JsonPropertyName("policyIdentifier")]
    public IList<V1alpha1SecretBackendRoleStatusAtProviderPolicyIdentifier>? PolicyIdentifier { get; set; }

    /// <summary>
    /// Specify the list of allowed policies OIDs. Use with Vault 1.10 or before. For Vault 1.11+, use policy_identifier blocks instead
    /// Specify the list of allowed policies OIDs.
    /// </summary>
    [JsonPropertyName("policyIdentifiers")]
    public IList<string>? PolicyIdentifiers { get; set; }

    /// <summary>
    /// The postal code of generated certificates
    /// The postal code of generated certificates.
    /// </summary>
    [JsonPropertyName("postalCode")]
    public IList<string>? PostalCode { get; set; }

    /// <summary>
    /// The province of generated certificates
    /// The province of generated certificates.
    /// </summary>
    [JsonPropertyName("province")]
    public IList<string>? Province { get; set; }

    /// <summary>
    /// Flag to force CN usage
    /// Flag to force CN usage.
    /// </summary>
    [JsonPropertyName("requireCn")]
    public bool? RequireCn { get; set; }

    /// <summary>
    /// Specifies the source of the subject serial number. Valid values are json-csr (default) or json. When set to json-csr, the subject serial number is taken from the serial_number parameter and falls back to the serial number in the CSR. When set to json, the subject serial number is taken from the serial_number parameter but will ignore any value in the CSR. For backwards compatibility an empty value for this field will default to the json-csr behavior.
    /// Specifies the source of the subject serial number. Valid values are json-csr (default) or json. When set to json-csr, the subject serial number is taken from the serial_number parameter and falls back to the serial number in the CSR. When set to json, the subject serial number is taken from the serial_number parameter but will ignore any value in the CSR. For backwards compatibility an empty value for this field will default to the json-csr behavior.
    /// </summary>
    [JsonPropertyName("serialNumberSource")]
    public string? SerialNumberSource { get; set; }

    /// <summary>
    /// Flag to specify certificates for server use
    /// Flag to specify certificates for server use.
    /// </summary>
    [JsonPropertyName("serverFlag")]
    public bool? ServerFlag { get; set; }

    /// <summary>
    /// The number of bits to use in the signature algorithm
    /// The number of bits to use in the signature algorithm.
    /// </summary>
    [JsonPropertyName("signatureBits")]
    public double? SignatureBits { get; set; }

    /// <summary>
    /// The street address of generated certificates
    /// The street address of generated certificates.
    /// </summary>
    [JsonPropertyName("streetAddress")]
    public IList<string>? StreetAddress { get; set; }

    /// <summary>
    /// The TTL, in seconds, for any certificate issued against this role.
    /// The TTL.
    /// </summary>
    [JsonPropertyName("ttl")]
    public string? Ttl { get; set; }

    /// <summary>
    /// Flag to use the CN in the CSR
    /// Flag to use the CN in the CSR.
    /// </summary>
    [JsonPropertyName("useCsrCommonName")]
    public bool? UseCsrCommonName { get; set; }

    /// <summary>
    /// Flag to use the SANs in the CSR
    /// Flag to use the SANs in the CSR.
    /// </summary>
    [JsonPropertyName("useCsrSans")]
    public bool? UseCsrSans { get; set; }

    /// <summary>
    /// Specifies whether or not to use PSS signatures over PKCS#1v1.5 signatures when a RSA-type issuer is used. Ignored for ECDSA/Ed25519 issuers.
    /// Specifies whether or not to use PSS signatures over PKCS#1v1.5 signatures when a RSA-type issuer is used. Ignored for ECDSA/Ed25519 issuers.
    /// </summary>
    [JsonPropertyName("usePss")]
    public bool? UsePss { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleStatusConditions
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

/// <summary>SecretBackendRoleStatus defines the observed state of SecretBackendRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendRoleStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1SecretBackendRoleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecretBackendRoleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SecretBackendRole is the Schema for the SecretBackendRoles API. Create a role on an PKI Secret Backend for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendRole : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretBackendRoleSpec>, IStatus<V1alpha1SecretBackendRoleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendRole";
    public const string KubeGroup = "pki.vault.upbound.io";
    public const string KubePluralName = "secretbackendroles";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "pki.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendRole";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretBackendRoleSpec defines the desired state of SecretBackendRole</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SecretBackendRoleSpec Spec { get; set; }

    /// <summary>SecretBackendRoleStatus defines the observed state of SecretBackendRole.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecretBackendRoleStatus? Status { get; set; }
}