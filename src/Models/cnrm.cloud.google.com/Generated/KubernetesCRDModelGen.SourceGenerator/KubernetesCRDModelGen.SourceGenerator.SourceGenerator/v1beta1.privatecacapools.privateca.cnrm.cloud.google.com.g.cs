#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.privateca.cnrm.cloud.google.com;
/// <summary>PrivateCACAPool is the Schema for the PrivateCACAPool API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivateCACAPoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta1PrivateCACAPool>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateCACAPoolList";
    public const string KubeGroup = "privateca.cnrm.cloud.google.com";
    public const string KubePluralName = "privatecacapools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "privateca.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PrivateCACAPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1PrivateCACAPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1PrivateCACAPool> Items { get; set; }
}

/// <summary>Optional. If specified, then only methods allowed in the [IssuanceModes][google.cloud.security.privateca.v1.CaPool.IssuancePolicy.IssuanceModes] may be used to issue [Certificates][google.cloud.security.privateca.v1.Certificate].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicyAllowedIssuanceModes
{
    /// <summary>Optional. When true, allows callers to create [Certificates][google.cloud.security.privateca.v1.Certificate] by specifying a [CertificateConfig][google.cloud.security.privateca.v1.CertificateConfig].</summary>
    [JsonPropertyName("allowConfigBasedIssuance")]
    public bool? AllowConfigBasedIssuance { get; set; }

    /// <summary>Optional. When true, allows callers to create [Certificates][google.cloud.security.privateca.v1.Certificate] by specifying a CSR.</summary>
    [JsonPropertyName("allowCsrBasedIssuance")]
    public bool? AllowCsrBasedIssuance { get; set; }
}

/// <summary>Represents an allowed Elliptic Curve key type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicyAllowedKeyTypesEllipticCurve
{
    /// <summary>Optional. A signature algorithm that must be used. If this is omitted, any EC-based signature algorithm will be allowed.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }
}

/// <summary>Represents an allowed RSA key type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicyAllowedKeyTypesRsa
{
    /// <summary>Optional. The maximum allowed RSA modulus size (inclusive), in bits. If this is not set, or if set to zero, the service will not enforce an explicit upper bound on RSA modulus sizes.</summary>
    [JsonPropertyName("maxModulusSize")]
    public long? MaxModulusSize { get; set; }

    /// <summary>Optional. The minimum allowed RSA modulus size (inclusive), in bits. If this is not set, or if set to zero, the service-level min RSA modulus size will continue to apply.</summary>
    [JsonPropertyName("minModulusSize")]
    public long? MinModulusSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicyAllowedKeyTypes
{
    /// <summary>Represents an allowed Elliptic Curve key type.</summary>
    [JsonPropertyName("ellipticCurve")]
    public V1beta1PrivateCACAPoolSpecIssuancePolicyAllowedKeyTypesEllipticCurve? EllipticCurve { get; set; }

    /// <summary>Represents an allowed RSA key type.</summary>
    [JsonPropertyName("rsa")]
    public V1beta1PrivateCACAPoolSpecIssuancePolicyAllowedKeyTypesRsa? Rsa { get; set; }
}

/// <summary>Required. The OID for this X.509 extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValuesAdditionalExtensionsObjectId
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<int>? ObjectIdPath { get; set; }
}

/// <summary>X509Extension</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValuesAdditionalExtensions
{
    /// <summary>Optional. Indicates whether or not this extension is critical (i.e., if the client does not know how to handle this extension, the client should consider this to be an error).</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>Required. The OID for this X.509 extension.</summary>
    [JsonPropertyName("objectId")]
    public V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValuesAdditionalExtensionsObjectId? ObjectId { get; set; }

    /// <summary>Required. The value of this X.509 extension.</summary>
    [JsonPropertyName("value")]
    public byte[]? Value { get; set; }
}

/// <summary>Optional. Describes options in this [X509Parameters][google.cloud.security.privateca.v1.X509Parameters] that are relevant in a CA certificate. If not specified, a default basic constraints extension with `is_ca=false` will be added for leaf certificates.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValuesCaOptions
{
    /// <summary>Optional. Refers to the &quot;CA&quot; boolean field in the X.509 extension. When this value is missing, the basic constraints extension will be omitted from the certificate.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>Optional. Refers to the path length constraint field in the X.509 extension. For a CA certificate, this value describes the depth of subordinate CA certificates that are allowed. If this value is less than 0, the request will fail. If this value is missing, the max path length will be omitted from the certificate.</summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public int? MaxIssuerPathLength { get; set; }

    /// <summary>Optional. When true, the &quot;path length constraint&quot; in Basic Constraints extension will be set to 0. if both max_issuer_path_length and zero_max_issuer_path_length are unset, the max path length will be omitted from the CA certificate.</summary>
    [JsonPropertyName("zeroMaxIssuerPathLength")]
    public bool? ZeroMaxIssuerPathLength { get; set; }
}

/// <summary>Describes high-level ways in which a key may be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValuesKeyUsageBaseKeyUsage
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

/// <summary>Detailed scenarios in which a key may be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValuesKeyUsageExtendedKeyUsage
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
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValuesKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<int>? ObjectIdPath { get; set; }
}

/// <summary>Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValuesKeyUsage
{
    /// <summary>Describes high-level ways in which a key may be used.</summary>
    [JsonPropertyName("baseKeyUsage")]
    public V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValuesKeyUsageBaseKeyUsage? BaseKeyUsage { get; set; }

    /// <summary>Detailed scenarios in which a key may be used.</summary>
    [JsonPropertyName("extendedKeyUsage")]
    public V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValuesKeyUsageExtendedKeyUsage? ExtendedKeyUsage { get; set; }

    /// <summary>Used to describe extended key usages that are not listed in the [KeyUsage.ExtendedKeyUsageOptions][google.cloud.security.privateca.v1.KeyUsage.ExtendedKeyUsageOptions] message.</summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValuesKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValuesPolicyIds
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<int>? ObjectIdPath { get; set; }
}

/// <summary>Optional. A set of X.509 values that will be applied to all certificates issued through this [CaPool][google.cloud.security.privateca.v1.CaPool]. If a certificate request includes conflicting values for the same properties, they will be overwritten by the values defined here. If a certificate request uses a [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate] that defines conflicting [predefined_values][google.cloud.security.privateca.v1.CertificateTemplate.predefined_values] for the same properties, the certificate issuance request will fail.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValues
{
    /// <summary>Optional. Describes custom X.509 extensions.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValuesAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Optional. Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the &quot;Authority Information Access&quot; extension in the certificate.</summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>Optional. Describes options in this [X509Parameters][google.cloud.security.privateca.v1.X509Parameters] that are relevant in a CA certificate. If not specified, a default basic constraints extension with `is_ca=false` will be added for leaf certificates.</summary>
    [JsonPropertyName("caOptions")]
    public V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValuesCaOptions? CaOptions { get; set; }

    /// <summary>Optional. Indicates the intended use for keys that correspond to a certificate.</summary>
    [JsonPropertyName("keyUsage")]
    public V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValuesKeyUsage? KeyUsage { get; set; }

    /// <summary>Optional. Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4.</summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValuesPolicyIds>? PolicyIds { get; set; }
}

/// <summary>Optional. A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a certificate is signed. To see the full allowed syntax and some examples, see https://cloud.google.com/certificate-authority-service/docs/using-cel</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicyIdentityConstraintsCelExpression
{
    /// <summary>Optional. Description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Optional. String indicating the location of the expression for error reporting, e.g. a file name and a position in the file.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>Optional. Describes constraints on identities that may appear in [Certificates][google.cloud.security.privateca.v1.Certificate] issued through this [CaPool][google.cloud.security.privateca.v1.CaPool]. If this is omitted, then this [CaPool][google.cloud.security.privateca.v1.CaPool] will not add restrictions on a certificate&apos;s identity.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicyIdentityConstraints
{
    /// <summary>Required. If this is true, the [SubjectAltNames][google.cloud.security.privateca.v1.SubjectAltNames] extension may be copied from a certificate request into the signed certificate. Otherwise, the requested [SubjectAltNames][google.cloud.security.privateca.v1.SubjectAltNames] will be discarded.</summary>
    [JsonPropertyName("allowSubjectAltNamesPassthrough")]
    public bool? AllowSubjectAltNamesPassthrough { get; set; }

    /// <summary>Required. If this is true, the [Subject][google.cloud.security.privateca.v1.Subject] field may be copied from a certificate request into the signed certificate. Otherwise, the requested [Subject][google.cloud.security.privateca.v1.Subject] will be discarded.</summary>
    [JsonPropertyName("allowSubjectPassthrough")]
    public bool? AllowSubjectPassthrough { get; set; }

    /// <summary>Optional. A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a certificate is signed. To see the full allowed syntax and some examples, see https://cloud.google.com/certificate-authority-service/docs/using-cel</summary>
    [JsonPropertyName("celExpression")]
    public V1beta1PrivateCACAPoolSpecIssuancePolicyIdentityConstraintsCelExpression? CelExpression { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicyPassthroughExtensionsAdditionalExtensions
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<int>? ObjectIdPath { get; set; }
}

/// <summary>Optional. Describes the set of X.509 extensions that may appear in a [Certificate][google.cloud.security.privateca.v1.Certificate] issued through this [CaPool][google.cloud.security.privateca.v1.CaPool]. If a certificate request sets extensions that don&apos;t appear in the [passthrough_extensions][google.cloud.security.privateca.v1.CaPool.IssuancePolicy.passthrough_extensions], those extensions will be dropped. If a certificate request uses a [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate] with [predefined_values][google.cloud.security.privateca.v1.CertificateTemplate.predefined_values] that don&apos;t appear here, the certificate issuance request will fail. If this is omitted, then this [CaPool][google.cloud.security.privateca.v1.CaPool] will not add restrictions on a certificate&apos;s X.509 extensions. These constraints do not apply to X.509 extensions set in this [CaPool][google.cloud.security.privateca.v1.CaPool]&apos;s [baseline_values][google.cloud.security.privateca.v1.CaPool.IssuancePolicy.baseline_values].</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicyPassthroughExtensions
{
    /// <summary>Optional. A set of [ObjectIds][google.cloud.security.privateca.v1.ObjectId] identifying custom X.509 extensions. Will be combined with [known_extensions][google.cloud.security.privateca.v1.CertificateExtensionConstraints.known_extensions] to determine the full set of X.509 extensions.</summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta1PrivateCACAPoolSpecIssuancePolicyPassthroughExtensionsAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Optional. A set of named X.509 extensions. Will be combined with [additional_extensions][google.cloud.security.privateca.v1.CertificateExtensionConstraints.additional_extensions] to determine the full set of X.509 extensions.</summary>
    [JsonPropertyName("knownExtensions")]
    public IList<string>? KnownExtensions { get; set; }
}

/// <summary>Optional. The IssuancePolicy to control how Certificates will be issued from this CaPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecIssuancePolicy
{
    /// <summary>Optional. If specified, then only methods allowed in the [IssuanceModes][google.cloud.security.privateca.v1.CaPool.IssuancePolicy.IssuanceModes] may be used to issue [Certificates][google.cloud.security.privateca.v1.Certificate].</summary>
    [JsonPropertyName("allowedIssuanceModes")]
    public V1beta1PrivateCACAPoolSpecIssuancePolicyAllowedIssuanceModes? AllowedIssuanceModes { get; set; }

    /// <summary>Optional. If any [AllowedKeyType][google.cloud.security.privateca.v1.CaPool.IssuancePolicy.AllowedKeyType] is specified, then the certificate request&apos;s public key must match one of the key types listed here. Otherwise, any key may be used.</summary>
    [JsonPropertyName("allowedKeyTypes")]
    public IList<V1beta1PrivateCACAPoolSpecIssuancePolicyAllowedKeyTypes>? AllowedKeyTypes { get; set; }

    /// <summary>Optional. A set of X.509 values that will be applied to all certificates issued through this [CaPool][google.cloud.security.privateca.v1.CaPool]. If a certificate request includes conflicting values for the same properties, they will be overwritten by the values defined here. If a certificate request uses a [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate] that defines conflicting [predefined_values][google.cloud.security.privateca.v1.CertificateTemplate.predefined_values] for the same properties, the certificate issuance request will fail.</summary>
    [JsonPropertyName("baselineValues")]
    public V1beta1PrivateCACAPoolSpecIssuancePolicyBaselineValues? BaselineValues { get; set; }

    /// <summary>Optional. Describes constraints on identities that may appear in [Certificates][google.cloud.security.privateca.v1.Certificate] issued through this [CaPool][google.cloud.security.privateca.v1.CaPool]. If this is omitted, then this [CaPool][google.cloud.security.privateca.v1.CaPool] will not add restrictions on a certificate&apos;s identity.</summary>
    [JsonPropertyName("identityConstraints")]
    public V1beta1PrivateCACAPoolSpecIssuancePolicyIdentityConstraints? IdentityConstraints { get; set; }

    /// <summary>Optional. The maximum lifetime allowed for issued [Certificates][google.cloud.security.privateca.v1.Certificate]. Note that if the issuing [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority] expires before a [Certificate][google.cloud.security.privateca.v1.Certificate] resource&apos;s requested maximum_lifetime, the effective lifetime will be explicitly truncated to match it.</summary>
    [JsonPropertyName("maximumLifetime")]
    public string? MaximumLifetime { get; set; }

    /// <summary>Optional. Describes the set of X.509 extensions that may appear in a [Certificate][google.cloud.security.privateca.v1.Certificate] issued through this [CaPool][google.cloud.security.privateca.v1.CaPool]. If a certificate request sets extensions that don&apos;t appear in the [passthrough_extensions][google.cloud.security.privateca.v1.CaPool.IssuancePolicy.passthrough_extensions], those extensions will be dropped. If a certificate request uses a [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate] with [predefined_values][google.cloud.security.privateca.v1.CertificateTemplate.predefined_values] that don&apos;t appear here, the certificate issuance request will fail. If this is omitted, then this [CaPool][google.cloud.security.privateca.v1.CaPool] will not add restrictions on a certificate&apos;s X.509 extensions. These constraints do not apply to X.509 extensions set in this [CaPool][google.cloud.security.privateca.v1.CaPool]&apos;s [baseline_values][google.cloud.security.privateca.v1.CaPool.IssuancePolicy.baseline_values].</summary>
    [JsonPropertyName("passthroughExtensions")]
    public V1beta1PrivateCACAPoolSpecIssuancePolicyPassthroughExtensions? PassthroughExtensions { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The PublishingOptions to follow when issuing Certificates from any CertificateAuthority in this CaPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpecPublishingOptions
{
    /// <summary>Optional. When true, publishes each [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]&apos;s CA certificate and includes its URL in the &quot;Authority Information Access&quot; X.509 extension in all issued [Certificates][google.cloud.security.privateca.v1.Certificate]. If this is false, the CA certificate will not be published and the corresponding X.509 extension will not be written in issued certificates.</summary>
    [JsonPropertyName("publishCaCert")]
    public bool? PublishCaCert { get; set; }

    /// <summary>Optional. When true, publishes each [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]&apos;s CRL and includes its URL in the &quot;CRL Distribution Points&quot; X.509 extension in all issued [Certificates][google.cloud.security.privateca.v1.Certificate]. If this is false, CRLs will not be published and the corresponding X.509 extension will not be written in issued certificates. CRLs will expire 7 days from their creation. However, we will rebuild daily. CRLs are also rebuilt shortly after a certificate is revoked.</summary>
    [JsonPropertyName("publishCrl")]
    public bool? PublishCrl { get; set; }
}

/// <summary>PrivateCACAPoolSpec defines the desired state of PrivateCACAPool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolSpec
{
    /// <summary>Optional. The IssuancePolicy to control how Certificates will be issued from this CaPool.</summary>
    [JsonPropertyName("issuancePolicy")]
    public V1beta1PrivateCACAPoolSpecIssuancePolicy? IssuancePolicy { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1beta1PrivateCACAPoolSpecProjectRef ProjectRef { get; set; }

    /// <summary>Optional. The PublishingOptions to follow when issuing Certificates from any CertificateAuthority in this CaPool.</summary>
    [JsonPropertyName("publishingOptions")]
    public V1beta1PrivateCACAPoolSpecPublishingOptions? PublishingOptions { get; set; }

    /// <summary>The PrivateCACAPool name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. Immutable. The Tier of this CaPool. Possible values: TIER_UNSPECIFIED, ENTERPRISE, DEVOPS</summary>
    [JsonPropertyName("tier")]
    public string? Tier { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>PrivateCACAPoolStatus defines the config connector machine state of PrivateCACAPool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PrivateCACAPoolStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PrivateCACAPoolStatusConditions>? Conditions { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>PrivateCACAPool is the Schema for the PrivateCACAPool API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PrivateCACAPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PrivateCACAPoolSpec>, IStatus<V1beta1PrivateCACAPoolStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PrivateCACAPool";
    public const string KubeGroup = "privateca.cnrm.cloud.google.com";
    public const string KubePluralName = "privatecacapools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "privateca.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PrivateCACAPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PrivateCACAPoolSpec defines the desired state of PrivateCACAPool</summary>
    [JsonPropertyName("spec")]
    public required V1beta1PrivateCACAPoolSpec Spec { get; set; }

    /// <summary>PrivateCACAPoolStatus defines the config connector machine state of PrivateCACAPool</summary>
    [JsonPropertyName("status")]
    public V1beta1PrivateCACAPoolStatus? Status { get; set; }
}