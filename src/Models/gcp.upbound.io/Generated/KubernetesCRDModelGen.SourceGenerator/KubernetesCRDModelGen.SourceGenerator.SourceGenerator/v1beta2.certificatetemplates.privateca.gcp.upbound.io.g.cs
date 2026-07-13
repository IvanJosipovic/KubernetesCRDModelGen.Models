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
/// <summary>CertificateTemplate is the Schema for the CertificateTemplates API. Certificate Authority Service provides reusable and parameterized templates that you can use for common certificate issuance scenarios.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2CertificateTemplateList : IKubernetesObject<V1ListMeta>, IItems<V1beta2CertificateTemplate>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "CertificateTemplateList";
    public const string KubeGroup = "privateca.gcp.upbound.io";
    public const string KubePluralName = "certificatetemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "privateca.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CertificateTemplateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2CertificateTemplate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2CertificateTemplate> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateTemplateSpecDeletionPolicyEnum>))]
public enum V1beta2CertificateTemplateSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Optional. A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a certificate is signed. To see the full allowed syntax and some examples, see https://cloud.google.com/certificate-authority-service/docs/using-cel
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecForProviderIdentityConstraintsCelExpression
{
    /// <summary>Optional. A human-readable description of scenarios this template is intended for.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Optional. Describes constraints on identities that may be appear in Certificates issued using this template. If this is omitted, then this template will not add restrictions on a certificate&apos;s identity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecForProviderIdentityConstraints
{
    /// <summary>Required. If this is true, the SubjectAltNames extension may be copied from a certificate request into the signed certificate. Otherwise, the requested SubjectAltNames will be discarded.</summary>
    [JsonPropertyName("allowSubjectAltNamesPassthrough")]
    public bool? AllowSubjectAltNamesPassthrough { get; set; }

    /// <summary>Required. If this is true, the Subject field may be copied from a certificate request into the signed certificate. Otherwise, the requested Subject will be discarded.</summary>
    [JsonPropertyName("allowSubjectPassthrough")]
    public bool? AllowSubjectPassthrough { get; set; }

    /// <summary>
    /// Optional. A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a certificate is signed. To see the full allowed syntax and some examples, see https://cloud.google.com/certificate-authority-service/docs/using-cel
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("celExpression")]
    public V1beta2CertificateTemplateSpecForProviderIdentityConstraintsCelExpression? CelExpression { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecForProviderPassthroughExtensionsAdditionalExtensions
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// Optional. Describes the set of X.509 extensions that may appear in a Certificate issued using this CertificateTemplate. If a certificate request sets extensions that don&apos;t appear in the passthrough_extensions, those extensions will be dropped. If the issuing CaPool&apos;s IssuancePolicy defines baseline_values that don&apos;t appear here, the certificate issuance request will fail. If this is omitted, then this template will not add restrictions on a certificate&apos;s X.509 extensions. These constraints do not apply to X.509 extensions set in this CertificateTemplate&apos;s predefined_values.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecForProviderPassthroughExtensions
{
    /// <summary>
    /// Optional. A set of ObjectIds identifying custom X.509 extensions. Will be combined with known_extensions to determine the full set of X.509 extensions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta2CertificateTemplateSpecForProviderPassthroughExtensionsAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Optional. A set of named X.509 extensions. Will be combined with additional_extensions to determine the full set of X.509 extensions.</summary>
    [JsonPropertyName("knownExtensions")]
    public IList<string>? KnownExtensions { get; set; }
}

/// <summary>
/// Required. The OID for this X.509 extension.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecForProviderPredefinedValuesAdditionalExtensionsObjectId
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecForProviderPredefinedValuesAdditionalExtensions
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>
    /// Required. The OID for this X.509 extension.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objectId")]
    public V1beta2CertificateTemplateSpecForProviderPredefinedValuesAdditionalExtensionsObjectId? ObjectId { get; set; }

    /// <summary>Required. The value of this X.509 extension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Optional. Describes options in this X509Parameters that are relevant in a CA certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecForProviderPredefinedValuesCaOptions
{
    /// <summary>Optional. Refers to the &quot;CA&quot; X.509 extension, which is a boolean value. When this value is true, the &quot;CA&quot; in Basic Constraints extension will be set to true.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>
    /// Optional. Refers to the &quot;path length constraint&quot; in Basic Constraints extension. For a CA certificate, this value describes the depth of
    /// subordinate CA certificates that are allowed. If this value is less than 0, the request will fail.
    /// </summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public double? MaxIssuerPathLength { get; set; }

    /// <summary>
    /// Optional. When true, the &quot;CA&quot; in Basic Constraints extension will be set to null and omitted from the CA certificate.
    /// If both is_ca and null_ca are unset, the &quot;CA&quot; in Basic Constraints extension will be set to false.
    /// Note that the behavior when is_ca = false for this resource is different from the behavior in the Certificate Authority, Certificate and CaPool resources.
    /// </summary>
    [JsonPropertyName("nullCa")]
    public bool? NullCa { get; set; }

    /// <summary>
    /// Optional. When true, the &quot;path length constraint&quot; in Basic Constraints extension will be set to 0.
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
public partial class V1beta2CertificateTemplateSpecForProviderPredefinedValuesKeyUsageBaseKeyUsage
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
/// Detailed scenarios in which a key may be used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecForProviderPredefinedValuesKeyUsageExtendedKeyUsage
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
public partial class V1beta2CertificateTemplateSpecForProviderPredefinedValuesKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// Optional. Indicates the intended use for keys that correspond to a certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecForProviderPredefinedValuesKeyUsage
{
    /// <summary>
    /// Describes high-level ways in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baseKeyUsage")]
    public V1beta2CertificateTemplateSpecForProviderPredefinedValuesKeyUsageBaseKeyUsage? BaseKeyUsage { get; set; }

    /// <summary>
    /// Detailed scenarios in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("extendedKeyUsage")]
    public V1beta2CertificateTemplateSpecForProviderPredefinedValuesKeyUsageExtendedKeyUsage? ExtendedKeyUsage { get; set; }

    /// <summary>
    /// Used to describe extended key usages that are not listed in the KeyUsage.ExtendedKeyUsageOptions message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta2CertificateTemplateSpecForProviderPredefinedValuesKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

/// <summary>
/// Describes the X.509 name constraints extension.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecForProviderPredefinedValuesNameConstraints
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
public partial class V1beta2CertificateTemplateSpecForProviderPredefinedValuesPolicyIds
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// Optional. A set of X.509 values that will be applied to all issued certificates that use this template. If the certificate request includes conflicting values for the same properties, they will be overwritten by the values defined here. If the issuing CaPool&apos;s IssuancePolicy defines conflicting baseline_values for the same properties, the certificate issuance request will fail.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecForProviderPredefinedValues
{
    /// <summary>
    /// Optional. Describes custom X.509 extensions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta2CertificateTemplateSpecForProviderPredefinedValuesAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Optional. Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the &quot;Authority Information Access&quot; extension in the certificate.</summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>
    /// Optional. Describes options in this X509Parameters that are relevant in a CA certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("caOptions")]
    public V1beta2CertificateTemplateSpecForProviderPredefinedValuesCaOptions? CaOptions { get; set; }

    /// <summary>
    /// Optional. Indicates the intended use for keys that correspond to a certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public V1beta2CertificateTemplateSpecForProviderPredefinedValuesKeyUsage? KeyUsage { get; set; }

    /// <summary>
    /// Describes the X.509 name constraints extension.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nameConstraints")]
    public V1beta2CertificateTemplateSpecForProviderPredefinedValuesNameConstraints? NameConstraints { get; set; }

    /// <summary>
    /// Optional. Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta2CertificateTemplateSpecForProviderPredefinedValuesPolicyIds>? PolicyIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecForProvider
{
    /// <summary>Optional. A human-readable description of scenarios this template is intended for.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Optional. Describes constraints on identities that may be appear in Certificates issued using this template. If this is omitted, then this template will not add restrictions on a certificate&apos;s identity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("identityConstraints")]
    public V1beta2CertificateTemplateSpecForProviderIdentityConstraints? IdentityConstraints { get; set; }

    /// <summary>
    /// Optional. Labels with user-defined metadata.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Optional. The maximum lifetime allowed for all issued certificates that use this template. If the issuing CaPool&apos;s IssuancePolicy specifies a maximum lifetime the minimum of the two durations will be the maximum lifetime for issued. Note that if the issuing CertificateAuthority expires before a Certificate&apos;s requested maximum_lifetime, the effective lifetime will be explicitly truncated to match it.</summary>
    [JsonPropertyName("maximumLifetime")]
    public string? MaximumLifetime { get; set; }

    /// <summary>
    /// Optional. Describes the set of X.509 extensions that may appear in a Certificate issued using this CertificateTemplate. If a certificate request sets extensions that don&apos;t appear in the passthrough_extensions, those extensions will be dropped. If the issuing CaPool&apos;s IssuancePolicy defines baseline_values that don&apos;t appear here, the certificate issuance request will fail. If this is omitted, then this template will not add restrictions on a certificate&apos;s X.509 extensions. These constraints do not apply to X.509 extensions set in this CertificateTemplate&apos;s predefined_values.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("passthroughExtensions")]
    public V1beta2CertificateTemplateSpecForProviderPassthroughExtensions? PassthroughExtensions { get; set; }

    /// <summary>
    /// Optional. A set of X.509 values that will be applied to all issued certificates that use this template. If the certificate request includes conflicting values for the same properties, they will be overwritten by the values defined here. If the issuing CaPool&apos;s IssuancePolicy defines conflicting baseline_values for the same properties, the certificate issuance request will fail.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("predefinedValues")]
    public V1beta2CertificateTemplateSpecForProviderPredefinedValues? PredefinedValues { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>
/// Optional. A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a certificate is signed. To see the full allowed syntax and some examples, see https://cloud.google.com/certificate-authority-service/docs/using-cel
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecInitProviderIdentityConstraintsCelExpression
{
    /// <summary>Optional. A human-readable description of scenarios this template is intended for.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Optional. Describes constraints on identities that may be appear in Certificates issued using this template. If this is omitted, then this template will not add restrictions on a certificate&apos;s identity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecInitProviderIdentityConstraints
{
    /// <summary>Required. If this is true, the SubjectAltNames extension may be copied from a certificate request into the signed certificate. Otherwise, the requested SubjectAltNames will be discarded.</summary>
    [JsonPropertyName("allowSubjectAltNamesPassthrough")]
    public bool? AllowSubjectAltNamesPassthrough { get; set; }

    /// <summary>Required. If this is true, the Subject field may be copied from a certificate request into the signed certificate. Otherwise, the requested Subject will be discarded.</summary>
    [JsonPropertyName("allowSubjectPassthrough")]
    public bool? AllowSubjectPassthrough { get; set; }

    /// <summary>
    /// Optional. A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a certificate is signed. To see the full allowed syntax and some examples, see https://cloud.google.com/certificate-authority-service/docs/using-cel
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("celExpression")]
    public V1beta2CertificateTemplateSpecInitProviderIdentityConstraintsCelExpression? CelExpression { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecInitProviderPassthroughExtensionsAdditionalExtensions
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// Optional. Describes the set of X.509 extensions that may appear in a Certificate issued using this CertificateTemplate. If a certificate request sets extensions that don&apos;t appear in the passthrough_extensions, those extensions will be dropped. If the issuing CaPool&apos;s IssuancePolicy defines baseline_values that don&apos;t appear here, the certificate issuance request will fail. If this is omitted, then this template will not add restrictions on a certificate&apos;s X.509 extensions. These constraints do not apply to X.509 extensions set in this CertificateTemplate&apos;s predefined_values.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecInitProviderPassthroughExtensions
{
    /// <summary>
    /// Optional. A set of ObjectIds identifying custom X.509 extensions. Will be combined with known_extensions to determine the full set of X.509 extensions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta2CertificateTemplateSpecInitProviderPassthroughExtensionsAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Optional. A set of named X.509 extensions. Will be combined with additional_extensions to determine the full set of X.509 extensions.</summary>
    [JsonPropertyName("knownExtensions")]
    public IList<string>? KnownExtensions { get; set; }
}

/// <summary>
/// Required. The OID for this X.509 extension.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecInitProviderPredefinedValuesAdditionalExtensionsObjectId
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecInitProviderPredefinedValuesAdditionalExtensions
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>
    /// Required. The OID for this X.509 extension.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objectId")]
    public V1beta2CertificateTemplateSpecInitProviderPredefinedValuesAdditionalExtensionsObjectId? ObjectId { get; set; }

    /// <summary>Required. The value of this X.509 extension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Optional. Describes options in this X509Parameters that are relevant in a CA certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecInitProviderPredefinedValuesCaOptions
{
    /// <summary>Optional. Refers to the &quot;CA&quot; X.509 extension, which is a boolean value. When this value is true, the &quot;CA&quot; in Basic Constraints extension will be set to true.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>
    /// Optional. Refers to the &quot;path length constraint&quot; in Basic Constraints extension. For a CA certificate, this value describes the depth of
    /// subordinate CA certificates that are allowed. If this value is less than 0, the request will fail.
    /// </summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public double? MaxIssuerPathLength { get; set; }

    /// <summary>
    /// Optional. When true, the &quot;CA&quot; in Basic Constraints extension will be set to null and omitted from the CA certificate.
    /// If both is_ca and null_ca are unset, the &quot;CA&quot; in Basic Constraints extension will be set to false.
    /// Note that the behavior when is_ca = false for this resource is different from the behavior in the Certificate Authority, Certificate and CaPool resources.
    /// </summary>
    [JsonPropertyName("nullCa")]
    public bool? NullCa { get; set; }

    /// <summary>
    /// Optional. When true, the &quot;path length constraint&quot; in Basic Constraints extension will be set to 0.
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
public partial class V1beta2CertificateTemplateSpecInitProviderPredefinedValuesKeyUsageBaseKeyUsage
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
/// Detailed scenarios in which a key may be used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecInitProviderPredefinedValuesKeyUsageExtendedKeyUsage
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
public partial class V1beta2CertificateTemplateSpecInitProviderPredefinedValuesKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// Optional. Indicates the intended use for keys that correspond to a certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecInitProviderPredefinedValuesKeyUsage
{
    /// <summary>
    /// Describes high-level ways in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baseKeyUsage")]
    public V1beta2CertificateTemplateSpecInitProviderPredefinedValuesKeyUsageBaseKeyUsage? BaseKeyUsage { get; set; }

    /// <summary>
    /// Detailed scenarios in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("extendedKeyUsage")]
    public V1beta2CertificateTemplateSpecInitProviderPredefinedValuesKeyUsageExtendedKeyUsage? ExtendedKeyUsage { get; set; }

    /// <summary>
    /// Used to describe extended key usages that are not listed in the KeyUsage.ExtendedKeyUsageOptions message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta2CertificateTemplateSpecInitProviderPredefinedValuesKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

/// <summary>
/// Describes the X.509 name constraints extension.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecInitProviderPredefinedValuesNameConstraints
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
public partial class V1beta2CertificateTemplateSpecInitProviderPredefinedValuesPolicyIds
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// Optional. A set of X.509 values that will be applied to all issued certificates that use this template. If the certificate request includes conflicting values for the same properties, they will be overwritten by the values defined here. If the issuing CaPool&apos;s IssuancePolicy defines conflicting baseline_values for the same properties, the certificate issuance request will fail.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecInitProviderPredefinedValues
{
    /// <summary>
    /// Optional. Describes custom X.509 extensions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta2CertificateTemplateSpecInitProviderPredefinedValuesAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Optional. Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the &quot;Authority Information Access&quot; extension in the certificate.</summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>
    /// Optional. Describes options in this X509Parameters that are relevant in a CA certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("caOptions")]
    public V1beta2CertificateTemplateSpecInitProviderPredefinedValuesCaOptions? CaOptions { get; set; }

    /// <summary>
    /// Optional. Indicates the intended use for keys that correspond to a certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public V1beta2CertificateTemplateSpecInitProviderPredefinedValuesKeyUsage? KeyUsage { get; set; }

    /// <summary>
    /// Describes the X.509 name constraints extension.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nameConstraints")]
    public V1beta2CertificateTemplateSpecInitProviderPredefinedValuesNameConstraints? NameConstraints { get; set; }

    /// <summary>
    /// Optional. Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta2CertificateTemplateSpecInitProviderPredefinedValuesPolicyIds>? PolicyIds { get; set; }
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
public partial class V1beta2CertificateTemplateSpecInitProvider
{
    /// <summary>Optional. A human-readable description of scenarios this template is intended for.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Optional. Describes constraints on identities that may be appear in Certificates issued using this template. If this is omitted, then this template will not add restrictions on a certificate&apos;s identity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("identityConstraints")]
    public V1beta2CertificateTemplateSpecInitProviderIdentityConstraints? IdentityConstraints { get; set; }

    /// <summary>
    /// Optional. Labels with user-defined metadata.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Optional. The maximum lifetime allowed for all issued certificates that use this template. If the issuing CaPool&apos;s IssuancePolicy specifies a maximum lifetime the minimum of the two durations will be the maximum lifetime for issued. Note that if the issuing CertificateAuthority expires before a Certificate&apos;s requested maximum_lifetime, the effective lifetime will be explicitly truncated to match it.</summary>
    [JsonPropertyName("maximumLifetime")]
    public string? MaximumLifetime { get; set; }

    /// <summary>
    /// Optional. Describes the set of X.509 extensions that may appear in a Certificate issued using this CertificateTemplate. If a certificate request sets extensions that don&apos;t appear in the passthrough_extensions, those extensions will be dropped. If the issuing CaPool&apos;s IssuancePolicy defines baseline_values that don&apos;t appear here, the certificate issuance request will fail. If this is omitted, then this template will not add restrictions on a certificate&apos;s X.509 extensions. These constraints do not apply to X.509 extensions set in this CertificateTemplate&apos;s predefined_values.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("passthroughExtensions")]
    public V1beta2CertificateTemplateSpecInitProviderPassthroughExtensions? PassthroughExtensions { get; set; }

    /// <summary>
    /// Optional. A set of X.509 values that will be applied to all issued certificates that use this template. If the certificate request includes conflicting values for the same properties, they will be overwritten by the values defined here. If the issuing CaPool&apos;s IssuancePolicy defines conflicting baseline_values for the same properties, the certificate issuance request will fail.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("predefinedValues")]
    public V1beta2CertificateTemplateSpecInitProviderPredefinedValues? PredefinedValues { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateTemplateSpecManagementPoliciesEnum>))]
public enum V1beta2CertificateTemplateSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateTemplateSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2CertificateTemplateSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateTemplateSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2CertificateTemplateSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateTemplateSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateTemplateSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CertificateTemplateSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>CertificateTemplateSpec defines the desired state of CertificateTemplate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateSpec
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
    public V1beta2CertificateTemplateSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2CertificateTemplateSpecForProvider ForProvider { get; set; }

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
    public V1beta2CertificateTemplateSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2CertificateTemplateSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2CertificateTemplateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2CertificateTemplateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Optional. A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a certificate is signed. To see the full allowed syntax and some examples, see https://cloud.google.com/certificate-authority-service/docs/using-cel
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateStatusAtProviderIdentityConstraintsCelExpression
{
    /// <summary>Optional. A human-readable description of scenarios this template is intended for.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs which allow to enter the expression.</summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Optional. Describes constraints on identities that may be appear in Certificates issued using this template. If this is omitted, then this template will not add restrictions on a certificate&apos;s identity.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateStatusAtProviderIdentityConstraints
{
    /// <summary>Required. If this is true, the SubjectAltNames extension may be copied from a certificate request into the signed certificate. Otherwise, the requested SubjectAltNames will be discarded.</summary>
    [JsonPropertyName("allowSubjectAltNamesPassthrough")]
    public bool? AllowSubjectAltNamesPassthrough { get; set; }

    /// <summary>Required. If this is true, the Subject field may be copied from a certificate request into the signed certificate. Otherwise, the requested Subject will be discarded.</summary>
    [JsonPropertyName("allowSubjectPassthrough")]
    public bool? AllowSubjectPassthrough { get; set; }

    /// <summary>
    /// Optional. A CEL expression that may be used to validate the resolved X.509 Subject and/or Subject Alternative Name before a certificate is signed. To see the full allowed syntax and some examples, see https://cloud.google.com/certificate-authority-service/docs/using-cel
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("celExpression")]
    public V1beta2CertificateTemplateStatusAtProviderIdentityConstraintsCelExpression? CelExpression { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateStatusAtProviderPassthroughExtensionsAdditionalExtensions
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// Optional. Describes the set of X.509 extensions that may appear in a Certificate issued using this CertificateTemplate. If a certificate request sets extensions that don&apos;t appear in the passthrough_extensions, those extensions will be dropped. If the issuing CaPool&apos;s IssuancePolicy defines baseline_values that don&apos;t appear here, the certificate issuance request will fail. If this is omitted, then this template will not add restrictions on a certificate&apos;s X.509 extensions. These constraints do not apply to X.509 extensions set in this CertificateTemplate&apos;s predefined_values.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateStatusAtProviderPassthroughExtensions
{
    /// <summary>
    /// Optional. A set of ObjectIds identifying custom X.509 extensions. Will be combined with known_extensions to determine the full set of X.509 extensions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta2CertificateTemplateStatusAtProviderPassthroughExtensionsAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Optional. A set of named X.509 extensions. Will be combined with additional_extensions to determine the full set of X.509 extensions.</summary>
    [JsonPropertyName("knownExtensions")]
    public IList<string>? KnownExtensions { get; set; }
}

/// <summary>
/// Required. The OID for this X.509 extension.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateStatusAtProviderPredefinedValuesAdditionalExtensionsObjectId
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateStatusAtProviderPredefinedValuesAdditionalExtensions
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>
    /// Required. The OID for this X.509 extension.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objectId")]
    public V1beta2CertificateTemplateStatusAtProviderPredefinedValuesAdditionalExtensionsObjectId? ObjectId { get; set; }

    /// <summary>Required. The value of this X.509 extension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Optional. Describes options in this X509Parameters that are relevant in a CA certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateStatusAtProviderPredefinedValuesCaOptions
{
    /// <summary>Optional. Refers to the &quot;CA&quot; X.509 extension, which is a boolean value. When this value is true, the &quot;CA&quot; in Basic Constraints extension will be set to true.</summary>
    [JsonPropertyName("isCa")]
    public bool? IsCa { get; set; }

    /// <summary>
    /// Optional. Refers to the &quot;path length constraint&quot; in Basic Constraints extension. For a CA certificate, this value describes the depth of
    /// subordinate CA certificates that are allowed. If this value is less than 0, the request will fail.
    /// </summary>
    [JsonPropertyName("maxIssuerPathLength")]
    public double? MaxIssuerPathLength { get; set; }

    /// <summary>
    /// Optional. When true, the &quot;CA&quot; in Basic Constraints extension will be set to null and omitted from the CA certificate.
    /// If both is_ca and null_ca are unset, the &quot;CA&quot; in Basic Constraints extension will be set to false.
    /// Note that the behavior when is_ca = false for this resource is different from the behavior in the Certificate Authority, Certificate and CaPool resources.
    /// </summary>
    [JsonPropertyName("nullCa")]
    public bool? NullCa { get; set; }

    /// <summary>
    /// Optional. When true, the &quot;path length constraint&quot; in Basic Constraints extension will be set to 0.
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
public partial class V1beta2CertificateTemplateStatusAtProviderPredefinedValuesKeyUsageBaseKeyUsage
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
/// Detailed scenarios in which a key may be used.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateStatusAtProviderPredefinedValuesKeyUsageExtendedKeyUsage
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
public partial class V1beta2CertificateTemplateStatusAtProviderPredefinedValuesKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// Optional. Indicates the intended use for keys that correspond to a certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateStatusAtProviderPredefinedValuesKeyUsage
{
    /// <summary>
    /// Describes high-level ways in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baseKeyUsage")]
    public V1beta2CertificateTemplateStatusAtProviderPredefinedValuesKeyUsageBaseKeyUsage? BaseKeyUsage { get; set; }

    /// <summary>
    /// Detailed scenarios in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("extendedKeyUsage")]
    public V1beta2CertificateTemplateStatusAtProviderPredefinedValuesKeyUsageExtendedKeyUsage? ExtendedKeyUsage { get; set; }

    /// <summary>
    /// Used to describe extended key usages that are not listed in the KeyUsage.ExtendedKeyUsageOptions message.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta2CertificateTemplateStatusAtProviderPredefinedValuesKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

/// <summary>
/// Describes the X.509 name constraints extension.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateStatusAtProviderPredefinedValuesNameConstraints
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
public partial class V1beta2CertificateTemplateStatusAtProviderPredefinedValuesPolicyIds
{
    /// <summary>Required. The parts of an OID path. The most significant parts of the path come first.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// Optional. A set of X.509 values that will be applied to all issued certificates that use this template. If the certificate request includes conflicting values for the same properties, they will be overwritten by the values defined here. If the issuing CaPool&apos;s IssuancePolicy defines conflicting baseline_values for the same properties, the certificate issuance request will fail.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateStatusAtProviderPredefinedValues
{
    /// <summary>
    /// Optional. Describes custom X.509 extensions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta2CertificateTemplateStatusAtProviderPredefinedValuesAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>Optional. Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the &quot;Authority Information Access&quot; extension in the certificate.</summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>
    /// Optional. Describes options in this X509Parameters that are relevant in a CA certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("caOptions")]
    public V1beta2CertificateTemplateStatusAtProviderPredefinedValuesCaOptions? CaOptions { get; set; }

    /// <summary>
    /// Optional. Indicates the intended use for keys that correspond to a certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public V1beta2CertificateTemplateStatusAtProviderPredefinedValuesKeyUsage? KeyUsage { get; set; }

    /// <summary>
    /// Describes the X.509 name constraints extension.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nameConstraints")]
    public V1beta2CertificateTemplateStatusAtProviderPredefinedValuesNameConstraints? NameConstraints { get; set; }

    /// <summary>
    /// Optional. Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta2CertificateTemplateStatusAtProviderPredefinedValuesPolicyIds>? PolicyIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateStatusAtProvider
{
    /// <summary>Output only. The time at which this CertificateTemplate was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Optional. A human-readable description of scenarios this template is intended for.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/certificateTemplates/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Optional. Describes constraints on identities that may be appear in Certificates issued using this template. If this is omitted, then this template will not add restrictions on a certificate&apos;s identity.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("identityConstraints")]
    public V1beta2CertificateTemplateStatusAtProviderIdentityConstraints? IdentityConstraints { get; set; }

    /// <summary>
    /// Optional. Labels with user-defined metadata.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location for the resource</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Optional. The maximum lifetime allowed for all issued certificates that use this template. If the issuing CaPool&apos;s IssuancePolicy specifies a maximum lifetime the minimum of the two durations will be the maximum lifetime for issued. Note that if the issuing CertificateAuthority expires before a Certificate&apos;s requested maximum_lifetime, the effective lifetime will be explicitly truncated to match it.</summary>
    [JsonPropertyName("maximumLifetime")]
    public string? MaximumLifetime { get; set; }

    /// <summary>
    /// Optional. Describes the set of X.509 extensions that may appear in a Certificate issued using this CertificateTemplate. If a certificate request sets extensions that don&apos;t appear in the passthrough_extensions, those extensions will be dropped. If the issuing CaPool&apos;s IssuancePolicy defines baseline_values that don&apos;t appear here, the certificate issuance request will fail. If this is omitted, then this template will not add restrictions on a certificate&apos;s X.509 extensions. These constraints do not apply to X.509 extensions set in this CertificateTemplate&apos;s predefined_values.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("passthroughExtensions")]
    public V1beta2CertificateTemplateStatusAtProviderPassthroughExtensions? PassthroughExtensions { get; set; }

    /// <summary>
    /// Optional. A set of X.509 values that will be applied to all issued certificates that use this template. If the certificate request includes conflicting values for the same properties, they will be overwritten by the values defined here. If the issuing CaPool&apos;s IssuancePolicy defines conflicting baseline_values for the same properties, the certificate issuance request will fail.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("predefinedValues")]
    public V1beta2CertificateTemplateStatusAtProviderPredefinedValues? PredefinedValues { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>Output only. The time at which this CertificateTemplate was updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateStatusConditions
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

/// <summary>CertificateTemplateStatus defines the observed state of CertificateTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateTemplateStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2CertificateTemplateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2CertificateTemplateStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CertificateTemplate is the Schema for the CertificateTemplates API. Certificate Authority Service provides reusable and parameterized templates that you can use for common certificate issuance scenarios.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2CertificateTemplate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2CertificateTemplateSpec>, IStatus<V1beta2CertificateTemplateStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "CertificateTemplate";
    public const string KubeGroup = "privateca.gcp.upbound.io";
    public const string KubePluralName = "certificatetemplates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "privateca.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CertificateTemplate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CertificateTemplateSpec defines the desired state of CertificateTemplate</summary>
    [JsonPropertyName("spec")]
    public required V1beta2CertificateTemplateSpec Spec { get; set; }

    /// <summary>CertificateTemplateStatus defines the observed state of CertificateTemplate.</summary>
    [JsonPropertyName("status")]
    public V1beta2CertificateTemplateStatus? Status { get; set; }
}