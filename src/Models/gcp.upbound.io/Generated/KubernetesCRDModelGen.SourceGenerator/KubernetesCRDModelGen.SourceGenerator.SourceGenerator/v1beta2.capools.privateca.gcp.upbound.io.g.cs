#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.privateca.gcp.upbound.io;
/// <summary>CAPool is the Schema for the CAPools API. A CaPool represents a group of CertificateAuthorities that form a trust anchor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2CAPoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta2CAPool>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "CAPoolList";
    public const string KubeGroup = "privateca.gcp.upbound.io";
    public const string KubePluralName = "capools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "privateca.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CAPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2CAPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2CAPool> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CAPoolSpecDeletionPolicyEnum>))]
public enum V1beta2CAPoolSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// IssuanceModes specifies the allowed ways in which Certificates may be requested from this CaPool.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderIssuancePolicyAllowedIssuanceModes
{
    /// <summary>When true, allows callers to create Certificates by specifying a CertificateConfig.</summary>
    [JsonPropertyName("allowConfigBasedIssuance")]
    public bool? AllowConfigBasedIssuance { get; set; }

    /// <summary>When true, allows callers to create Certificates by specifying a CSR.</summary>
    [JsonPropertyName("allowCsrBasedIssuance")]
    public bool? AllowCsrBasedIssuance { get; set; }
}

/// <summary>
/// Represents an allowed Elliptic Curve key type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderIssuancePolicyAllowedKeyTypesEllipticCurve
{
    /// <summary>
    /// The algorithm used.
    /// Possible values are: ECDSA_P256, ECDSA_P384, EDDSA_25519.
    /// </summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

/// <summary>
/// Describes an RSA key that may be used in a Certificate issued from a CaPool.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderIssuancePolicyAllowedKeyTypesRsa
{
    /// <summary>
    /// The maximum allowed RSA modulus size, in bits. If this is not set, or if set to zero, the
    /// service will not enforce an explicit upper bound on RSA modulus sizes.
    /// </summary>
    [JsonPropertyName("maxModulusSize")]
    public string? MaxModulusSize { get; set; }

    /// <summary>
    /// The minimum allowed RSA modulus size, in bits. If this is not set, or if set to zero, the
    /// service-level min RSA modulus size will continue to apply.
    /// </summary>
    [JsonPropertyName("minModulusSize")]
    public string? MinModulusSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderIssuancePolicyAllowedKeyTypes
{
    /// <summary>
    /// Represents an allowed Elliptic Curve key type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ellipticCurve")]
    public V1beta2CAPoolSpecForProviderIssuancePolicyAllowedKeyTypesEllipticCurve? EllipticCurve { get; set; }

    /// <summary>
    /// Describes an RSA key that may be used in a Certificate issued from a CaPool.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rsa")]
    public V1beta2CAPoolSpecForProviderIssuancePolicyAllowedKeyTypesRsa? Rsa { get; set; }
}

/// <summary>
/// Describes values that are relevant in a CA certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesAdditionalExtensionsObjectId
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesAdditionalExtensions
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>
    /// Describes values that are relevant in a CA certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objectId")]
    public V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesAdditionalExtensionsObjectId? ObjectId { get; set; }

    /// <summary>The value of this X.509 extension. A base64-encoded string.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Describes values that are relevant in a CA certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesCaOptions
{
    /// <summary>When true, the &quot;CA&quot; in Basic Constraints extension will be set to true.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>
    /// Refers to the &quot;path length constraint&quot; in Basic Constraints extension. For a CA certificate, this value describes the depth of
    /// subordinate CA certificates that are allowed. If this value is less than 0, the request will fail.
    /// </summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public double? MaxIssuerPathLength { get; set; }

    /// <summary>
    /// When true, the &quot;CA&quot; in Basic Constraints extension will be set to false.
    /// If both is_ca and non_ca are unset, the extension will be omitted from the CA certificate.
    /// </summary>
    [JsonPropertyName("nonCa")]
    public bool? NonCa { get; set; }

    /// <summary>
    /// When true, the &quot;path length constraint&quot; in Basic Constraints extension will be set to 0.
    /// if both max_issuer_path_length and zero_max_issuer_path_length are unset,
    /// the max path length will be omitted from the CA certificate.
    /// </summary>
    [JsonPropertyName("zeroMaxIssuerPathLength")]
    public bool? ZeroMaxIssuerPathLength { get; set; }
}

/// <summary>
/// Describes high-level ways in which a key may be used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesKeyUsageBaseKeyUsage
{
    /// <summary>The key may be used to sign certificates.</summary>
    [JsonPropertyName("certSign")]
    public bool? CertSign { get; set; }

    /// <summary>The key may be used for cryptographic commitments. Note that this may also be referred to as &quot;non-repudiation&quot;.</summary>
    [JsonPropertyName("contentCommitment")]
    public bool? ContentCommitment { get; set; }

    /// <summary>The key may be used sign certificate revocation lists.</summary>
    [JsonPropertyName("crlSign")]
    public bool? CrlSign { get; set; }

    /// <summary>The key may be used to encipher data.</summary>
    [JsonPropertyName("dataEncipherment")]
    public bool? DataEncipherment { get; set; }

    /// <summary>The key may be used to decipher only.</summary>
    [JsonPropertyName("decipherOnly")]
    public bool? DecipherOnly { get; set; }

    /// <summary>The key may be used for digital signatures.</summary>
    [JsonPropertyName("digitalSignature")]
    public bool? DigitalSignature { get; set; }

    /// <summary>The key may be used to encipher only.</summary>
    [JsonPropertyName("encipherOnly")]
    public bool? EncipherOnly { get; set; }

    /// <summary>The key may be used in a key agreement protocol.</summary>
    [JsonPropertyName("keyAgreement")]
    public bool? KeyAgreement { get; set; }

    /// <summary>The key may be used to encipher other keys.</summary>
    [JsonPropertyName("keyEncipherment")]
    public bool? KeyEncipherment { get; set; }
}

/// <summary>
/// Describes high-level ways in which a key may be used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesKeyUsageExtendedKeyUsage
{
    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.2. Officially described as &quot;TLS WWW client authentication&quot;, though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("clientAuth")]
    public bool? ClientAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.3. Officially described as &quot;Signing of downloadable executable code client authentication&quot;.</summary>
    [JsonPropertyName("codeSigning")]
    public bool? CodeSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.4. Officially described as &quot;Email protection&quot;.</summary>
    [JsonPropertyName("emailProtection")]
    public bool? EmailProtection { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.9. Officially described as &quot;Signing OCSP responses&quot;.</summary>
    [JsonPropertyName("ocspSigning")]
    public bool? OcspSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.1. Officially described as &quot;TLS WWW server authentication&quot;, though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("serverAuth")]
    public bool? ServerAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.8. Officially described as &quot;Binding the hash of an object to a time&quot;.</summary>
    [JsonPropertyName("timeStamping")]
    public bool? TimeStamping { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// Indicates the intended use for keys that correspond to a certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesKeyUsage
{
    /// <summary>
    /// Describes high-level ways in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baseKeyUsage")]
    public V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesKeyUsageBaseKeyUsage? BaseKeyUsage { get; set; }

    /// <summary>
    /// Describes high-level ways in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("extendedKeyUsage")]
    public V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesKeyUsageExtendedKeyUsage? ExtendedKeyUsage { get; set; }

    /// <summary>
    /// An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

/// <summary>
/// Describes the X.509 name constraints extension.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesNameConstraints
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>
    /// Contains excluded DNS names. Any DNS name that can be
    /// constructed by simply adding zero or more labels to
    /// the left-hand side of the name satisfies the name constraint.
    /// For example, example.com, www.example.com, www.sub.example.com
    /// would satisfy example.com while example1.com does not.
    /// </summary>
    [JsonPropertyName("excludedDnsNames")]
    public IList<string>? ExcludedDnsNames { get; set; }

    /// <summary>
    /// Contains the excluded email addresses. The value can be a particular
    /// email address, a hostname to indicate all email addresses on that host or
    /// a domain with a leading period (e.g. .example.com) to indicate
    /// all email addresses in that domain.
    /// </summary>
    [JsonPropertyName("excludedEmailAddresses")]
    public IList<string>? ExcludedEmailAddresses { get; set; }

    /// <summary>
    /// Contains the excluded IP ranges. For IPv4 addresses, the ranges
    /// are expressed using CIDR notation as specified in RFC 4632.
    /// For IPv6 addresses, the ranges are expressed in similar encoding as IPv4
    /// addresses.
    /// </summary>
    [JsonPropertyName("excludedIpRanges")]
    public IList<string>? ExcludedIpRanges { get; set; }

    /// <summary>
    /// Contains the excluded URIs that apply to the host part of the name.
    /// The value can be a hostname or a domain with a
    /// leading period (like .example.com)
    /// </summary>
    [JsonPropertyName("excludedUris")]
    public IList<string>? ExcludedUris { get; set; }

    /// <summary>
    /// Contains permitted DNS names. Any DNS name that can be
    /// constructed by simply adding zero or more labels to
    /// the left-hand side of the name satisfies the name constraint.
    /// For example, example.com, www.example.com, www.sub.example.com
    /// would satisfy example.com while example1.com does not.
    /// </summary>
    [JsonPropertyName("permittedDnsNames")]
    public IList<string>? PermittedDnsNames { get; set; }

    /// <summary>
    /// Contains the permitted email addresses. The value can be a particular
    /// email address, a hostname to indicate all email addresses on that host or
    /// a domain with a leading period (e.g. .example.com) to indicate
    /// all email addresses in that domain.
    /// </summary>
    [JsonPropertyName("permittedEmailAddresses")]
    public IList<string>? PermittedEmailAddresses { get; set; }

    /// <summary>
    /// Contains the permitted IP ranges. For IPv4 addresses, the ranges
    /// are expressed using CIDR notation as specified in RFC 4632.
    /// For IPv6 addresses, the ranges are expressed in similar encoding as IPv4
    /// addresses.
    /// </summary>
    [JsonPropertyName("permittedIpRanges")]
    public IList<string>? PermittedIpRanges { get; set; }

    /// <summary>
    /// Contains the permitted URIs that apply to the host part of the name.
    /// The value can be a hostname or a domain with a
    /// leading period (like .example.com)
    /// </summary>
    [JsonPropertyName("permittedUris")]
    public IList<string>? PermittedUris { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesPolicyIds
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// A set of X.509 values that will be applied to all certificates issued through this CaPool. If a certificate request
/// includes conflicting values for the same properties, they will be overwritten by the values defined here. If a certificate
/// request uses a CertificateTemplate that defines conflicting predefinedValues for the same properties, the certificate
/// issuance request will fail.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValues
{
    /// <summary>
    /// Specifies an X.509 extension, which may be used in different parts of X.509 objects like certificates, CSRs, and CRLs.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>
    /// Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the
    /// &quot;Authority Information Access&quot; extension in the certificate.
    /// </summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>
    /// Describes values that are relevant in a CA certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("caOptions")]
    public V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesCaOptions? CaOptions { get; set; }

    /// <summary>
    /// Indicates the intended use for keys that correspond to a certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesKeyUsage? KeyUsage { get; set; }

    /// <summary>
    /// Describes the X.509 name constraints extension.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nameConstraints")]
    public V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesNameConstraints? NameConstraints { get; set; }

    /// <summary>
    /// Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValuesPolicyIds>? PolicyIds { get; set; }
}

/// <summary>
/// A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a
/// certificate is signed. To see the full allowed syntax and some examples,
/// see https://cloud.google.com/certificate-authority-service/docs/cel-guide
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderIssuancePolicyIdentityConstraintsCelExpression
{
    /// <summary>Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>
    /// Location of the CaPool. A full list of valid locations can be found by
    /// running gcloud privateca locations list.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Describes constraints on identities that may appear in Certificates issued through this CaPool.
/// If this is omitted, then this CaPool will not add restrictions on a certificate&apos;s identity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderIssuancePolicyIdentityConstraints
{
    /// <summary>
    /// If this is set, the SubjectAltNames extension may be copied from a certificate request into the signed certificate.
    /// Otherwise, the requested SubjectAltNames will be discarded.
    /// </summary>
    [JsonPropertyName("allowSubjectAltNamesPassthrough")]
    public bool? AllowSubjectAltNamesPassthrough { get; set; }

    /// <summary>
    /// If this is set, the Subject field may be copied from a certificate request into the signed certificate.
    /// Otherwise, the requested Subject will be discarded.
    /// </summary>
    [JsonPropertyName("allowSubjectPassthrough")]
    public bool? AllowSubjectPassthrough { get; set; }

    /// <summary>
    /// A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a
    /// certificate is signed. To see the full allowed syntax and some examples,
    /// see https://cloud.google.com/certificate-authority-service/docs/cel-guide
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("celExpression")]
    public V1beta2CAPoolSpecForProviderIssuancePolicyIdentityConstraintsCelExpression? CelExpression { get; set; }
}

/// <summary>
/// The IssuancePolicy to control how Certificates will be issued from this CaPool.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderIssuancePolicy
{
    /// <summary>
    /// IssuanceModes specifies the allowed ways in which Certificates may be requested from this CaPool.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("allowedIssuanceModes")]
    public V1beta2CAPoolSpecForProviderIssuancePolicyAllowedIssuanceModes? AllowedIssuanceModes { get; set; }

    /// <summary>
    /// If any AllowedKeyType is specified, then the certificate request&apos;s public key must match one of the key types listed here.
    /// Otherwise, any key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("allowedKeyTypes")]
    public IList<V1beta2CAPoolSpecForProviderIssuancePolicyAllowedKeyTypes>? AllowedKeyTypes { get; set; }

    /// <summary>
    /// The duration to backdate all certificates issued from this CaPool. If not set, the
    /// certificates will be issued with a not_before_time of the issuance time (i.e. the current
    /// time). If set, the certificates will be issued with a not_before_time of the issuance
    /// time minus the backdate_duration. The not_after_time will be adjusted to preserve the
    /// requested lifetime. The backdate_duration must be less than or equal to 48 hours.
    /// </summary>
    [JsonPropertyName("backdateDuration")]
    public string? BackdateDuration { get; set; }

    /// <summary>
    /// A set of X.509 values that will be applied to all certificates issued through this CaPool. If a certificate request
    /// includes conflicting values for the same properties, they will be overwritten by the values defined here. If a certificate
    /// request uses a CertificateTemplate that defines conflicting predefinedValues for the same properties, the certificate
    /// issuance request will fail.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baselineValues")]
    public V1beta2CAPoolSpecForProviderIssuancePolicyBaselineValues? BaselineValues { get; set; }

    /// <summary>
    /// Describes constraints on identities that may appear in Certificates issued through this CaPool.
    /// If this is omitted, then this CaPool will not add restrictions on a certificate&apos;s identity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("identityConstraints")]
    public V1beta2CAPoolSpecForProviderIssuancePolicyIdentityConstraints? IdentityConstraints { get; set; }

    /// <summary>
    /// The maximum lifetime allowed for issued Certificates. Note that if the issuing CertificateAuthority
    /// expires before a Certificate&apos;s requested maximumLifetime, the effective lifetime will be explicitly truncated to match it.
    /// </summary>
    [JsonPropertyName("maximumLifetime")]
    public string? MaximumLifetime { get; set; }
}

/// <summary>
/// The PublishingOptions to follow when issuing Certificates from any CertificateAuthority in this CaPool.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProviderPublishingOptions
{
    /// <summary>
    /// Specifies the encoding format of each CertificateAuthority&apos;s CA
    /// certificate and CRLs. If this is omitted, CA certificates and CRLs
    /// will be published in PEM.
    /// Possible values are: PEM, DER.
    /// </summary>
    [JsonPropertyName("encodingFormat")]
    public string? EncodingFormat { get; set; }

    /// <summary>
    /// When true, publishes each CertificateAuthority&apos;s CA certificate and includes its URL in the &quot;Authority Information Access&quot;
    /// X.509 extension in all issued Certificates. If this is false, the CA certificate will not be published and the corresponding
    /// X.509 extension will not be written in issued certificates.
    /// </summary>
    [JsonPropertyName("publishCaCert")]
    public bool? PublishCaCert { get; set; }

    /// <summary>
    /// When true, publishes each CertificateAuthority&apos;s CRL and includes its URL in the &quot;CRL Distribution Points&quot; X.509 extension
    /// in all issued Certificates. If this is false, CRLs will not be published and the corresponding X.509 extension will not
    /// be written in issued certificates. CRLs will expire 7 days from their creation. However, we will rebuild daily. CRLs are
    /// also rebuilt shortly after a certificate is revoked.
    /// </summary>
    [JsonPropertyName("publishCrl")]
    public bool? PublishCrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecForProvider
{
    /// <summary>
    /// The IssuancePolicy to control how Certificates will be issued from this CaPool.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("issuancePolicy")]
    public V1beta2CAPoolSpecForProviderIssuancePolicy? IssuancePolicy { get; set; }

    /// <summary>
    /// Labels with user-defined metadata.
    /// An object containing a list of &quot;key&quot;: value pairs. Example: { &quot;name&quot;: &quot;wrench&quot;, &quot;mass&quot;:
    /// &quot;1.3kg&quot;, &quot;count&quot;: &quot;3&quot; }.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Location of the CaPool. A full list of valid locations can be found by
    /// running gcloud privateca locations list.
    /// </summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The PublishingOptions to follow when issuing Certificates from any CertificateAuthority in this CaPool.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publishingOptions")]
    public V1beta2CAPoolSpecForProviderPublishingOptions? PublishingOptions { get; set; }

    /// <summary>
    /// The Tier of this CaPool.
    /// Possible values are: ENTERPRISE, DEVOPS.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// IssuanceModes specifies the allowed ways in which Certificates may be requested from this CaPool.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderIssuancePolicyAllowedIssuanceModes
{
    /// <summary>When true, allows callers to create Certificates by specifying a CertificateConfig.</summary>
    [JsonPropertyName("allowConfigBasedIssuance")]
    public bool? AllowConfigBasedIssuance { get; set; }

    /// <summary>When true, allows callers to create Certificates by specifying a CSR.</summary>
    [JsonPropertyName("allowCsrBasedIssuance")]
    public bool? AllowCsrBasedIssuance { get; set; }
}

/// <summary>
/// Represents an allowed Elliptic Curve key type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderIssuancePolicyAllowedKeyTypesEllipticCurve
{
    /// <summary>
    /// The algorithm used.
    /// Possible values are: ECDSA_P256, ECDSA_P384, EDDSA_25519.
    /// </summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

/// <summary>
/// Describes an RSA key that may be used in a Certificate issued from a CaPool.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderIssuancePolicyAllowedKeyTypesRsa
{
    /// <summary>
    /// The maximum allowed RSA modulus size, in bits. If this is not set, or if set to zero, the
    /// service will not enforce an explicit upper bound on RSA modulus sizes.
    /// </summary>
    [JsonPropertyName("maxModulusSize")]
    public string? MaxModulusSize { get; set; }

    /// <summary>
    /// The minimum allowed RSA modulus size, in bits. If this is not set, or if set to zero, the
    /// service-level min RSA modulus size will continue to apply.
    /// </summary>
    [JsonPropertyName("minModulusSize")]
    public string? MinModulusSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderIssuancePolicyAllowedKeyTypes
{
    /// <summary>
    /// Represents an allowed Elliptic Curve key type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ellipticCurve")]
    public V1beta2CAPoolSpecInitProviderIssuancePolicyAllowedKeyTypesEllipticCurve? EllipticCurve { get; set; }

    /// <summary>
    /// Describes an RSA key that may be used in a Certificate issued from a CaPool.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rsa")]
    public V1beta2CAPoolSpecInitProviderIssuancePolicyAllowedKeyTypesRsa? Rsa { get; set; }
}

/// <summary>
/// Describes values that are relevant in a CA certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesAdditionalExtensionsObjectId
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesAdditionalExtensions
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>
    /// Describes values that are relevant in a CA certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objectId")]
    public V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesAdditionalExtensionsObjectId? ObjectId { get; set; }

    /// <summary>The value of this X.509 extension. A base64-encoded string.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Describes values that are relevant in a CA certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesCaOptions
{
    /// <summary>When true, the &quot;CA&quot; in Basic Constraints extension will be set to true.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>
    /// Refers to the &quot;path length constraint&quot; in Basic Constraints extension. For a CA certificate, this value describes the depth of
    /// subordinate CA certificates that are allowed. If this value is less than 0, the request will fail.
    /// </summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public double? MaxIssuerPathLength { get; set; }

    /// <summary>
    /// When true, the &quot;CA&quot; in Basic Constraints extension will be set to false.
    /// If both is_ca and non_ca are unset, the extension will be omitted from the CA certificate.
    /// </summary>
    [JsonPropertyName("nonCa")]
    public bool? NonCa { get; set; }

    /// <summary>
    /// When true, the &quot;path length constraint&quot; in Basic Constraints extension will be set to 0.
    /// if both max_issuer_path_length and zero_max_issuer_path_length are unset,
    /// the max path length will be omitted from the CA certificate.
    /// </summary>
    [JsonPropertyName("zeroMaxIssuerPathLength")]
    public bool? ZeroMaxIssuerPathLength { get; set; }
}

/// <summary>
/// Describes high-level ways in which a key may be used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesKeyUsageBaseKeyUsage
{
    /// <summary>The key may be used to sign certificates.</summary>
    [JsonPropertyName("certSign")]
    public bool? CertSign { get; set; }

    /// <summary>The key may be used for cryptographic commitments. Note that this may also be referred to as &quot;non-repudiation&quot;.</summary>
    [JsonPropertyName("contentCommitment")]
    public bool? ContentCommitment { get; set; }

    /// <summary>The key may be used sign certificate revocation lists.</summary>
    [JsonPropertyName("crlSign")]
    public bool? CrlSign { get; set; }

    /// <summary>The key may be used to encipher data.</summary>
    [JsonPropertyName("dataEncipherment")]
    public bool? DataEncipherment { get; set; }

    /// <summary>The key may be used to decipher only.</summary>
    [JsonPropertyName("decipherOnly")]
    public bool? DecipherOnly { get; set; }

    /// <summary>The key may be used for digital signatures.</summary>
    [JsonPropertyName("digitalSignature")]
    public bool? DigitalSignature { get; set; }

    /// <summary>The key may be used to encipher only.</summary>
    [JsonPropertyName("encipherOnly")]
    public bool? EncipherOnly { get; set; }

    /// <summary>The key may be used in a key agreement protocol.</summary>
    [JsonPropertyName("keyAgreement")]
    public bool? KeyAgreement { get; set; }

    /// <summary>The key may be used to encipher other keys.</summary>
    [JsonPropertyName("keyEncipherment")]
    public bool? KeyEncipherment { get; set; }
}

/// <summary>
/// Describes high-level ways in which a key may be used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesKeyUsageExtendedKeyUsage
{
    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.2. Officially described as &quot;TLS WWW client authentication&quot;, though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("clientAuth")]
    public bool? ClientAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.3. Officially described as &quot;Signing of downloadable executable code client authentication&quot;.</summary>
    [JsonPropertyName("codeSigning")]
    public bool? CodeSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.4. Officially described as &quot;Email protection&quot;.</summary>
    [JsonPropertyName("emailProtection")]
    public bool? EmailProtection { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.9. Officially described as &quot;Signing OCSP responses&quot;.</summary>
    [JsonPropertyName("ocspSigning")]
    public bool? OcspSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.1. Officially described as &quot;TLS WWW server authentication&quot;, though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("serverAuth")]
    public bool? ServerAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.8. Officially described as &quot;Binding the hash of an object to a time&quot;.</summary>
    [JsonPropertyName("timeStamping")]
    public bool? TimeStamping { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// Indicates the intended use for keys that correspond to a certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesKeyUsage
{
    /// <summary>
    /// Describes high-level ways in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baseKeyUsage")]
    public V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesKeyUsageBaseKeyUsage? BaseKeyUsage { get; set; }

    /// <summary>
    /// Describes high-level ways in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("extendedKeyUsage")]
    public V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesKeyUsageExtendedKeyUsage? ExtendedKeyUsage { get; set; }

    /// <summary>
    /// An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

/// <summary>
/// Describes the X.509 name constraints extension.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesNameConstraints
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>
    /// Contains excluded DNS names. Any DNS name that can be
    /// constructed by simply adding zero or more labels to
    /// the left-hand side of the name satisfies the name constraint.
    /// For example, example.com, www.example.com, www.sub.example.com
    /// would satisfy example.com while example1.com does not.
    /// </summary>
    [JsonPropertyName("excludedDnsNames")]
    public IList<string>? ExcludedDnsNames { get; set; }

    /// <summary>
    /// Contains the excluded email addresses. The value can be a particular
    /// email address, a hostname to indicate all email addresses on that host or
    /// a domain with a leading period (e.g. .example.com) to indicate
    /// all email addresses in that domain.
    /// </summary>
    [JsonPropertyName("excludedEmailAddresses")]
    public IList<string>? ExcludedEmailAddresses { get; set; }

    /// <summary>
    /// Contains the excluded IP ranges. For IPv4 addresses, the ranges
    /// are expressed using CIDR notation as specified in RFC 4632.
    /// For IPv6 addresses, the ranges are expressed in similar encoding as IPv4
    /// addresses.
    /// </summary>
    [JsonPropertyName("excludedIpRanges")]
    public IList<string>? ExcludedIpRanges { get; set; }

    /// <summary>
    /// Contains the excluded URIs that apply to the host part of the name.
    /// The value can be a hostname or a domain with a
    /// leading period (like .example.com)
    /// </summary>
    [JsonPropertyName("excludedUris")]
    public IList<string>? ExcludedUris { get; set; }

    /// <summary>
    /// Contains permitted DNS names. Any DNS name that can be
    /// constructed by simply adding zero or more labels to
    /// the left-hand side of the name satisfies the name constraint.
    /// For example, example.com, www.example.com, www.sub.example.com
    /// would satisfy example.com while example1.com does not.
    /// </summary>
    [JsonPropertyName("permittedDnsNames")]
    public IList<string>? PermittedDnsNames { get; set; }

    /// <summary>
    /// Contains the permitted email addresses. The value can be a particular
    /// email address, a hostname to indicate all email addresses on that host or
    /// a domain with a leading period (e.g. .example.com) to indicate
    /// all email addresses in that domain.
    /// </summary>
    [JsonPropertyName("permittedEmailAddresses")]
    public IList<string>? PermittedEmailAddresses { get; set; }

    /// <summary>
    /// Contains the permitted IP ranges. For IPv4 addresses, the ranges
    /// are expressed using CIDR notation as specified in RFC 4632.
    /// For IPv6 addresses, the ranges are expressed in similar encoding as IPv4
    /// addresses.
    /// </summary>
    [JsonPropertyName("permittedIpRanges")]
    public IList<string>? PermittedIpRanges { get; set; }

    /// <summary>
    /// Contains the permitted URIs that apply to the host part of the name.
    /// The value can be a hostname or a domain with a
    /// leading period (like .example.com)
    /// </summary>
    [JsonPropertyName("permittedUris")]
    public IList<string>? PermittedUris { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesPolicyIds
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// A set of X.509 values that will be applied to all certificates issued through this CaPool. If a certificate request
/// includes conflicting values for the same properties, they will be overwritten by the values defined here. If a certificate
/// request uses a CertificateTemplate that defines conflicting predefinedValues for the same properties, the certificate
/// issuance request will fail.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValues
{
    /// <summary>
    /// Specifies an X.509 extension, which may be used in different parts of X.509 objects like certificates, CSRs, and CRLs.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>
    /// Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the
    /// &quot;Authority Information Access&quot; extension in the certificate.
    /// </summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>
    /// Describes values that are relevant in a CA certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("caOptions")]
    public V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesCaOptions? CaOptions { get; set; }

    /// <summary>
    /// Indicates the intended use for keys that correspond to a certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesKeyUsage? KeyUsage { get; set; }

    /// <summary>
    /// Describes the X.509 name constraints extension.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nameConstraints")]
    public V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesNameConstraints? NameConstraints { get; set; }

    /// <summary>
    /// Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValuesPolicyIds>? PolicyIds { get; set; }
}

/// <summary>
/// A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a
/// certificate is signed. To see the full allowed syntax and some examples,
/// see https://cloud.google.com/certificate-authority-service/docs/cel-guide
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderIssuancePolicyIdentityConstraintsCelExpression
{
    /// <summary>Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Describes constraints on identities that may appear in Certificates issued through this CaPool.
/// If this is omitted, then this CaPool will not add restrictions on a certificate&apos;s identity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderIssuancePolicyIdentityConstraints
{
    /// <summary>
    /// If this is set, the SubjectAltNames extension may be copied from a certificate request into the signed certificate.
    /// Otherwise, the requested SubjectAltNames will be discarded.
    /// </summary>
    [JsonPropertyName("allowSubjectAltNamesPassthrough")]
    public bool? AllowSubjectAltNamesPassthrough { get; set; }

    /// <summary>
    /// If this is set, the Subject field may be copied from a certificate request into the signed certificate.
    /// Otherwise, the requested Subject will be discarded.
    /// </summary>
    [JsonPropertyName("allowSubjectPassthrough")]
    public bool? AllowSubjectPassthrough { get; set; }

    /// <summary>
    /// A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a
    /// certificate is signed. To see the full allowed syntax and some examples,
    /// see https://cloud.google.com/certificate-authority-service/docs/cel-guide
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("celExpression")]
    public V1beta2CAPoolSpecInitProviderIssuancePolicyIdentityConstraintsCelExpression? CelExpression { get; set; }
}

/// <summary>
/// The IssuancePolicy to control how Certificates will be issued from this CaPool.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderIssuancePolicy
{
    /// <summary>
    /// IssuanceModes specifies the allowed ways in which Certificates may be requested from this CaPool.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("allowedIssuanceModes")]
    public V1beta2CAPoolSpecInitProviderIssuancePolicyAllowedIssuanceModes? AllowedIssuanceModes { get; set; }

    /// <summary>
    /// If any AllowedKeyType is specified, then the certificate request&apos;s public key must match one of the key types listed here.
    /// Otherwise, any key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("allowedKeyTypes")]
    public IList<V1beta2CAPoolSpecInitProviderIssuancePolicyAllowedKeyTypes>? AllowedKeyTypes { get; set; }

    /// <summary>
    /// The duration to backdate all certificates issued from this CaPool. If not set, the
    /// certificates will be issued with a not_before_time of the issuance time (i.e. the current
    /// time). If set, the certificates will be issued with a not_before_time of the issuance
    /// time minus the backdate_duration. The not_after_time will be adjusted to preserve the
    /// requested lifetime. The backdate_duration must be less than or equal to 48 hours.
    /// </summary>
    [JsonPropertyName("backdateDuration")]
    public string? BackdateDuration { get; set; }

    /// <summary>
    /// A set of X.509 values that will be applied to all certificates issued through this CaPool. If a certificate request
    /// includes conflicting values for the same properties, they will be overwritten by the values defined here. If a certificate
    /// request uses a CertificateTemplate that defines conflicting predefinedValues for the same properties, the certificate
    /// issuance request will fail.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baselineValues")]
    public V1beta2CAPoolSpecInitProviderIssuancePolicyBaselineValues? BaselineValues { get; set; }

    /// <summary>
    /// Describes constraints on identities that may appear in Certificates issued through this CaPool.
    /// If this is omitted, then this CaPool will not add restrictions on a certificate&apos;s identity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("identityConstraints")]
    public V1beta2CAPoolSpecInitProviderIssuancePolicyIdentityConstraints? IdentityConstraints { get; set; }

    /// <summary>
    /// The maximum lifetime allowed for issued Certificates. Note that if the issuing CertificateAuthority
    /// expires before a Certificate&apos;s requested maximumLifetime, the effective lifetime will be explicitly truncated to match it.
    /// </summary>
    [JsonPropertyName("maximumLifetime")]
    public string? MaximumLifetime { get; set; }
}

/// <summary>
/// The PublishingOptions to follow when issuing Certificates from any CertificateAuthority in this CaPool.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecInitProviderPublishingOptions
{
    /// <summary>
    /// Specifies the encoding format of each CertificateAuthority&apos;s CA
    /// certificate and CRLs. If this is omitted, CA certificates and CRLs
    /// will be published in PEM.
    /// Possible values are: PEM, DER.
    /// </summary>
    [JsonPropertyName("encodingFormat")]
    public string? EncodingFormat { get; set; }

    /// <summary>
    /// When true, publishes each CertificateAuthority&apos;s CA certificate and includes its URL in the &quot;Authority Information Access&quot;
    /// X.509 extension in all issued Certificates. If this is false, the CA certificate will not be published and the corresponding
    /// X.509 extension will not be written in issued certificates.
    /// </summary>
    [JsonPropertyName("publishCaCert")]
    public bool? PublishCaCert { get; set; }

    /// <summary>
    /// When true, publishes each CertificateAuthority&apos;s CRL and includes its URL in the &quot;CRL Distribution Points&quot; X.509 extension
    /// in all issued Certificates. If this is false, CRLs will not be published and the corresponding X.509 extension will not
    /// be written in issued certificates. CRLs will expire 7 days from their creation. However, we will rebuild daily. CRLs are
    /// also rebuilt shortly after a certificate is revoked.
    /// </summary>
    [JsonPropertyName("publishCrl")]
    public bool? PublishCrl { get; set; }
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
public partial class V1beta2CAPoolSpecInitProvider
{
    /// <summary>
    /// The IssuancePolicy to control how Certificates will be issued from this CaPool.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("issuancePolicy")]
    public V1beta2CAPoolSpecInitProviderIssuancePolicy? IssuancePolicy { get; set; }

    /// <summary>
    /// Labels with user-defined metadata.
    /// An object containing a list of &quot;key&quot;: value pairs. Example: { &quot;name&quot;: &quot;wrench&quot;, &quot;mass&quot;:
    /// &quot;1.3kg&quot;, &quot;count&quot;: &quot;3&quot; }.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The PublishingOptions to follow when issuing Certificates from any CertificateAuthority in this CaPool.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publishingOptions")]
    public V1beta2CAPoolSpecInitProviderPublishingOptions? PublishingOptions { get; set; }

    /// <summary>
    /// The Tier of this CaPool.
    /// Possible values are: ENTERPRISE, DEVOPS.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CAPoolSpecManagementPoliciesEnum>))]
public enum V1beta2CAPoolSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CAPoolSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2CAPoolSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CAPoolSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2CAPoolSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CAPoolSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CAPoolSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CAPoolSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>CAPoolSpec defines the desired state of CAPool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolSpec
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
    public V1beta2CAPoolSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2CAPoolSpecForProvider ForProvider { get; set; }

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
    public V1beta2CAPoolSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2CAPoolSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2CAPoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2CAPoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// IssuanceModes specifies the allowed ways in which Certificates may be requested from this CaPool.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderIssuancePolicyAllowedIssuanceModes
{
    /// <summary>When true, allows callers to create Certificates by specifying a CertificateConfig.</summary>
    [JsonPropertyName("allowConfigBasedIssuance")]
    public bool? AllowConfigBasedIssuance { get; set; }

    /// <summary>When true, allows callers to create Certificates by specifying a CSR.</summary>
    [JsonPropertyName("allowCsrBasedIssuance")]
    public bool? AllowCsrBasedIssuance { get; set; }
}

/// <summary>
/// Represents an allowed Elliptic Curve key type.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderIssuancePolicyAllowedKeyTypesEllipticCurve
{
    /// <summary>
    /// The algorithm used.
    /// Possible values are: ECDSA_P256, ECDSA_P384, EDDSA_25519.
    /// </summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

/// <summary>
/// Describes an RSA key that may be used in a Certificate issued from a CaPool.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderIssuancePolicyAllowedKeyTypesRsa
{
    /// <summary>
    /// The maximum allowed RSA modulus size, in bits. If this is not set, or if set to zero, the
    /// service will not enforce an explicit upper bound on RSA modulus sizes.
    /// </summary>
    [JsonPropertyName("maxModulusSize")]
    public string? MaxModulusSize { get; set; }

    /// <summary>
    /// The minimum allowed RSA modulus size, in bits. If this is not set, or if set to zero, the
    /// service-level min RSA modulus size will continue to apply.
    /// </summary>
    [JsonPropertyName("minModulusSize")]
    public string? MinModulusSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderIssuancePolicyAllowedKeyTypes
{
    /// <summary>
    /// Represents an allowed Elliptic Curve key type.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("ellipticCurve")]
    public V1beta2CAPoolStatusAtProviderIssuancePolicyAllowedKeyTypesEllipticCurve? EllipticCurve { get; set; }

    /// <summary>
    /// Describes an RSA key that may be used in a Certificate issued from a CaPool.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rsa")]
    public V1beta2CAPoolStatusAtProviderIssuancePolicyAllowedKeyTypesRsa? Rsa { get; set; }
}

/// <summary>
/// Describes values that are relevant in a CA certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesAdditionalExtensionsObjectId
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesAdditionalExtensions
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>
    /// Describes values that are relevant in a CA certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objectId")]
    public V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesAdditionalExtensionsObjectId? ObjectId { get; set; }

    /// <summary>The value of this X.509 extension. A base64-encoded string.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Describes values that are relevant in a CA certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesCaOptions
{
    /// <summary>When true, the &quot;CA&quot; in Basic Constraints extension will be set to true.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>
    /// Refers to the &quot;path length constraint&quot; in Basic Constraints extension. For a CA certificate, this value describes the depth of
    /// subordinate CA certificates that are allowed. If this value is less than 0, the request will fail.
    /// </summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public double? MaxIssuerPathLength { get; set; }

    /// <summary>
    /// When true, the &quot;CA&quot; in Basic Constraints extension will be set to false.
    /// If both is_ca and non_ca are unset, the extension will be omitted from the CA certificate.
    /// </summary>
    [JsonPropertyName("nonCa")]
    public bool? NonCa { get; set; }

    /// <summary>
    /// When true, the &quot;path length constraint&quot; in Basic Constraints extension will be set to 0.
    /// if both max_issuer_path_length and zero_max_issuer_path_length are unset,
    /// the max path length will be omitted from the CA certificate.
    /// </summary>
    [JsonPropertyName("zeroMaxIssuerPathLength")]
    public bool? ZeroMaxIssuerPathLength { get; set; }
}

/// <summary>
/// Describes high-level ways in which a key may be used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesKeyUsageBaseKeyUsage
{
    /// <summary>The key may be used to sign certificates.</summary>
    [JsonPropertyName("certSign")]
    public bool? CertSign { get; set; }

    /// <summary>The key may be used for cryptographic commitments. Note that this may also be referred to as &quot;non-repudiation&quot;.</summary>
    [JsonPropertyName("contentCommitment")]
    public bool? ContentCommitment { get; set; }

    /// <summary>The key may be used sign certificate revocation lists.</summary>
    [JsonPropertyName("crlSign")]
    public bool? CrlSign { get; set; }

    /// <summary>The key may be used to encipher data.</summary>
    [JsonPropertyName("dataEncipherment")]
    public bool? DataEncipherment { get; set; }

    /// <summary>The key may be used to decipher only.</summary>
    [JsonPropertyName("decipherOnly")]
    public bool? DecipherOnly { get; set; }

    /// <summary>The key may be used for digital signatures.</summary>
    [JsonPropertyName("digitalSignature")]
    public bool? DigitalSignature { get; set; }

    /// <summary>The key may be used to encipher only.</summary>
    [JsonPropertyName("encipherOnly")]
    public bool? EncipherOnly { get; set; }

    /// <summary>The key may be used in a key agreement protocol.</summary>
    [JsonPropertyName("keyAgreement")]
    public bool? KeyAgreement { get; set; }

    /// <summary>The key may be used to encipher other keys.</summary>
    [JsonPropertyName("keyEncipherment")]
    public bool? KeyEncipherment { get; set; }
}

/// <summary>
/// Describes high-level ways in which a key may be used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesKeyUsageExtendedKeyUsage
{
    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.2. Officially described as &quot;TLS WWW client authentication&quot;, though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("clientAuth")]
    public bool? ClientAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.3. Officially described as &quot;Signing of downloadable executable code client authentication&quot;.</summary>
    [JsonPropertyName("codeSigning")]
    public bool? CodeSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.4. Officially described as &quot;Email protection&quot;.</summary>
    [JsonPropertyName("emailProtection")]
    public bool? EmailProtection { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.9. Officially described as &quot;Signing OCSP responses&quot;.</summary>
    [JsonPropertyName("ocspSigning")]
    public bool? OcspSigning { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.1. Officially described as &quot;TLS WWW server authentication&quot;, though regularly used for non-WWW TLS.</summary>
    [JsonPropertyName("serverAuth")]
    public bool? ServerAuth { get; set; }

    /// <summary>Corresponds to OID 1.3.6.1.5.5.7.3.8. Officially described as &quot;Binding the hash of an object to a time&quot;.</summary>
    [JsonPropertyName("timeStamping")]
    public bool? TimeStamping { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// Indicates the intended use for keys that correspond to a certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesKeyUsage
{
    /// <summary>
    /// Describes high-level ways in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baseKeyUsage")]
    public V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesKeyUsageBaseKeyUsage? BaseKeyUsage { get; set; }

    /// <summary>
    /// Describes high-level ways in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("extendedKeyUsage")]
    public V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesKeyUsageExtendedKeyUsage? ExtendedKeyUsage { get; set; }

    /// <summary>
    /// An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

/// <summary>
/// Describes the X.509 name constraints extension.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesNameConstraints
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>
    /// Contains excluded DNS names. Any DNS name that can be
    /// constructed by simply adding zero or more labels to
    /// the left-hand side of the name satisfies the name constraint.
    /// For example, example.com, www.example.com, www.sub.example.com
    /// would satisfy example.com while example1.com does not.
    /// </summary>
    [JsonPropertyName("excludedDnsNames")]
    public IList<string>? ExcludedDnsNames { get; set; }

    /// <summary>
    /// Contains the excluded email addresses. The value can be a particular
    /// email address, a hostname to indicate all email addresses on that host or
    /// a domain with a leading period (e.g. .example.com) to indicate
    /// all email addresses in that domain.
    /// </summary>
    [JsonPropertyName("excludedEmailAddresses")]
    public IList<string>? ExcludedEmailAddresses { get; set; }

    /// <summary>
    /// Contains the excluded IP ranges. For IPv4 addresses, the ranges
    /// are expressed using CIDR notation as specified in RFC 4632.
    /// For IPv6 addresses, the ranges are expressed in similar encoding as IPv4
    /// addresses.
    /// </summary>
    [JsonPropertyName("excludedIpRanges")]
    public IList<string>? ExcludedIpRanges { get; set; }

    /// <summary>
    /// Contains the excluded URIs that apply to the host part of the name.
    /// The value can be a hostname or a domain with a
    /// leading period (like .example.com)
    /// </summary>
    [JsonPropertyName("excludedUris")]
    public IList<string>? ExcludedUris { get; set; }

    /// <summary>
    /// Contains permitted DNS names. Any DNS name that can be
    /// constructed by simply adding zero or more labels to
    /// the left-hand side of the name satisfies the name constraint.
    /// For example, example.com, www.example.com, www.sub.example.com
    /// would satisfy example.com while example1.com does not.
    /// </summary>
    [JsonPropertyName("permittedDnsNames")]
    public IList<string>? PermittedDnsNames { get; set; }

    /// <summary>
    /// Contains the permitted email addresses. The value can be a particular
    /// email address, a hostname to indicate all email addresses on that host or
    /// a domain with a leading period (e.g. .example.com) to indicate
    /// all email addresses in that domain.
    /// </summary>
    [JsonPropertyName("permittedEmailAddresses")]
    public IList<string>? PermittedEmailAddresses { get; set; }

    /// <summary>
    /// Contains the permitted IP ranges. For IPv4 addresses, the ranges
    /// are expressed using CIDR notation as specified in RFC 4632.
    /// For IPv6 addresses, the ranges are expressed in similar encoding as IPv4
    /// addresses.
    /// </summary>
    [JsonPropertyName("permittedIpRanges")]
    public IList<string>? PermittedIpRanges { get; set; }

    /// <summary>
    /// Contains the permitted URIs that apply to the host part of the name.
    /// The value can be a hostname or a domain with a
    /// leading period (like .example.com)
    /// </summary>
    [JsonPropertyName("permittedUris")]
    public IList<string>? PermittedUris { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesPolicyIds
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// A set of X.509 values that will be applied to all certificates issued through this CaPool. If a certificate request
/// includes conflicting values for the same properties, they will be overwritten by the values defined here. If a certificate
/// request uses a CertificateTemplate that defines conflicting predefinedValues for the same properties, the certificate
/// issuance request will fail.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValues
{
    /// <summary>
    /// Specifies an X.509 extension, which may be used in different parts of X.509 objects like certificates, CSRs, and CRLs.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>
    /// Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the
    /// &quot;Authority Information Access&quot; extension in the certificate.
    /// </summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>
    /// Describes values that are relevant in a CA certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("caOptions")]
    public V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesCaOptions? CaOptions { get; set; }

    /// <summary>
    /// Indicates the intended use for keys that correspond to a certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesKeyUsage? KeyUsage { get; set; }

    /// <summary>
    /// Describes the X.509 name constraints extension.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nameConstraints")]
    public V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesNameConstraints? NameConstraints { get; set; }

    /// <summary>
    /// Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValuesPolicyIds>? PolicyIds { get; set; }
}

/// <summary>
/// A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a
/// certificate is signed. To see the full allowed syntax and some examples,
/// see https://cloud.google.com/certificate-authority-service/docs/cel-guide
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderIssuancePolicyIdentityConstraintsCelExpression
{
    /// <summary>Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>
    /// Location of the CaPool. A full list of valid locations can be found by
    /// running gcloud privateca locations list.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Describes constraints on identities that may appear in Certificates issued through this CaPool.
/// If this is omitted, then this CaPool will not add restrictions on a certificate&apos;s identity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderIssuancePolicyIdentityConstraints
{
    /// <summary>
    /// If this is set, the SubjectAltNames extension may be copied from a certificate request into the signed certificate.
    /// Otherwise, the requested SubjectAltNames will be discarded.
    /// </summary>
    [JsonPropertyName("allowSubjectAltNamesPassthrough")]
    public bool? AllowSubjectAltNamesPassthrough { get; set; }

    /// <summary>
    /// If this is set, the Subject field may be copied from a certificate request into the signed certificate.
    /// Otherwise, the requested Subject will be discarded.
    /// </summary>
    [JsonPropertyName("allowSubjectPassthrough")]
    public bool? AllowSubjectPassthrough { get; set; }

    /// <summary>
    /// A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a
    /// certificate is signed. To see the full allowed syntax and some examples,
    /// see https://cloud.google.com/certificate-authority-service/docs/cel-guide
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("celExpression")]
    public V1beta2CAPoolStatusAtProviderIssuancePolicyIdentityConstraintsCelExpression? CelExpression { get; set; }
}

/// <summary>
/// The IssuancePolicy to control how Certificates will be issued from this CaPool.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderIssuancePolicy
{
    /// <summary>
    /// IssuanceModes specifies the allowed ways in which Certificates may be requested from this CaPool.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("allowedIssuanceModes")]
    public V1beta2CAPoolStatusAtProviderIssuancePolicyAllowedIssuanceModes? AllowedIssuanceModes { get; set; }

    /// <summary>
    /// If any AllowedKeyType is specified, then the certificate request&apos;s public key must match one of the key types listed here.
    /// Otherwise, any key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("allowedKeyTypes")]
    public IList<V1beta2CAPoolStatusAtProviderIssuancePolicyAllowedKeyTypes>? AllowedKeyTypes { get; set; }

    /// <summary>
    /// The duration to backdate all certificates issued from this CaPool. If not set, the
    /// certificates will be issued with a not_before_time of the issuance time (i.e. the current
    /// time). If set, the certificates will be issued with a not_before_time of the issuance
    /// time minus the backdate_duration. The not_after_time will be adjusted to preserve the
    /// requested lifetime. The backdate_duration must be less than or equal to 48 hours.
    /// </summary>
    [JsonPropertyName("backdateDuration")]
    public string? BackdateDuration { get; set; }

    /// <summary>
    /// A set of X.509 values that will be applied to all certificates issued through this CaPool. If a certificate request
    /// includes conflicting values for the same properties, they will be overwritten by the values defined here. If a certificate
    /// request uses a CertificateTemplate that defines conflicting predefinedValues for the same properties, the certificate
    /// issuance request will fail.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baselineValues")]
    public V1beta2CAPoolStatusAtProviderIssuancePolicyBaselineValues? BaselineValues { get; set; }

    /// <summary>
    /// Describes constraints on identities that may appear in Certificates issued through this CaPool.
    /// If this is omitted, then this CaPool will not add restrictions on a certificate&apos;s identity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("identityConstraints")]
    public V1beta2CAPoolStatusAtProviderIssuancePolicyIdentityConstraints? IdentityConstraints { get; set; }

    /// <summary>
    /// The maximum lifetime allowed for issued Certificates. Note that if the issuing CertificateAuthority
    /// expires before a Certificate&apos;s requested maximumLifetime, the effective lifetime will be explicitly truncated to match it.
    /// </summary>
    [JsonPropertyName("maximumLifetime")]
    public string? MaximumLifetime { get; set; }
}

/// <summary>
/// The PublishingOptions to follow when issuing Certificates from any CertificateAuthority in this CaPool.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProviderPublishingOptions
{
    /// <summary>
    /// Specifies the encoding format of each CertificateAuthority&apos;s CA
    /// certificate and CRLs. If this is omitted, CA certificates and CRLs
    /// will be published in PEM.
    /// Possible values are: PEM, DER.
    /// </summary>
    [JsonPropertyName("encodingFormat")]
    public string? EncodingFormat { get; set; }

    /// <summary>
    /// When true, publishes each CertificateAuthority&apos;s CA certificate and includes its URL in the &quot;Authority Information Access&quot;
    /// X.509 extension in all issued Certificates. If this is false, the CA certificate will not be published and the corresponding
    /// X.509 extension will not be written in issued certificates.
    /// </summary>
    [JsonPropertyName("publishCaCert")]
    public bool? PublishCaCert { get; set; }

    /// <summary>
    /// When true, publishes each CertificateAuthority&apos;s CRL and includes its URL in the &quot;CRL Distribution Points&quot; X.509 extension
    /// in all issued Certificates. If this is false, CRLs will not be published and the corresponding X.509 extension will not
    /// be written in issued certificates. CRLs will expire 7 days from their creation. However, we will rebuild daily. CRLs are
    /// also rebuilt shortly after a certificate is revoked.
    /// </summary>
    [JsonPropertyName("publishCrl")]
    public bool? PublishCrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusAtProvider
{
    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/caPools/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The IssuancePolicy to control how Certificates will be issued from this CaPool.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("issuancePolicy")]
    public V1beta2CAPoolStatusAtProviderIssuancePolicy? IssuancePolicy { get; set; }

    /// <summary>
    /// Labels with user-defined metadata.
    /// An object containing a list of &quot;key&quot;: value pairs. Example: { &quot;name&quot;: &quot;wrench&quot;, &quot;mass&quot;:
    /// &quot;1.3kg&quot;, &quot;count&quot;: &quot;3&quot; }.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Location of the CaPool. A full list of valid locations can be found by
    /// running gcloud privateca locations list.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The PublishingOptions to follow when issuing Certificates from any CertificateAuthority in this CaPool.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publishingOptions")]
    public V1beta2CAPoolStatusAtProviderPublishingOptions? PublishingOptions { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>
    /// The Tier of this CaPool.
    /// Possible values are: ENTERPRISE, DEVOPS.
    /// </summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatusConditions
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

/// <summary>CAPoolStatus defines the observed state of CAPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CAPoolStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2CAPoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2CAPoolStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CAPool is the Schema for the CAPools API. A CaPool represents a group of CertificateAuthorities that form a trust anchor.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2CAPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2CAPoolSpec>, IStatus<V1beta2CAPoolStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "CAPool";
    public const string KubeGroup = "privateca.gcp.upbound.io";
    public const string KubePluralName = "capools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "privateca.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CAPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CAPoolSpec defines the desired state of CAPool</summary>
    [JsonPropertyName("spec")]
    public required V1beta2CAPoolSpec Spec { get; set; }

    /// <summary>CAPoolStatus defines the observed state of CAPool.</summary>
    [JsonPropertyName("status")]
    public V1beta2CAPoolStatus? Status { get; set; }
}