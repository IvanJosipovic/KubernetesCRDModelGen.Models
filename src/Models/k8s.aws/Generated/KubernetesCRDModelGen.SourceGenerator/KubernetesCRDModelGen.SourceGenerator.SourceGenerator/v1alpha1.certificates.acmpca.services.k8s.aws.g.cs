#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.acmpca.services.k8s.aws;
/// <summary>Certificate is the Schema for the Certificates API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CertificateList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Certificate>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CertificateList";
    public const string KubeGroup = "acmpca.services.k8s.aws";
    public const string KubePluralName = "certificates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "acmpca.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CertificateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Certificate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Certificate> Items { get; set; }
}

/// <summary>
/// Defines a PolicyInformation qualifier. Amazon Web Services Private CA supports
/// the certification practice statement (CPS) qualifier (https://datatracker.ietf.org/doc/html/rfc5280#section-4.2.1.4)
/// defined in RFC 5280.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecApiPassthroughExtensionsCertificatePoliciesPolicyQualifiersQualifier
{
    [JsonPropertyName("cpsURI")]
    public string? CpsURI { get; set; }
}

/// <summary>
/// Modifies the CertPolicyId of a PolicyInformation object with a qualifier.
/// Amazon Web Services Private CA supports the certification practice statement
/// (CPS) qualifier.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecApiPassthroughExtensionsCertificatePoliciesPolicyQualifiers
{
    [JsonPropertyName("policyQualifierID")]
    public string? PolicyQualifierID { get; set; }

    /// <summary>
    /// Defines a PolicyInformation qualifier. Amazon Web Services Private CA supports
    /// the certification practice statement (CPS) qualifier (https://datatracker.ietf.org/doc/html/rfc5280#section-4.2.1.4)
    /// defined in RFC 5280.
    /// </summary>
    [JsonPropertyName("qualifier")]
    public V1alpha1CertificateSpecApiPassthroughExtensionsCertificatePoliciesPolicyQualifiersQualifier? Qualifier { get; set; }
}

/// <summary>Defines the X.509 CertificatePolicies extension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecApiPassthroughExtensionsCertificatePolicies
{
    [JsonPropertyName("certPolicyID")]
    public string? CertPolicyID { get; set; }

    [JsonPropertyName("policyQualifiers")]
    public IList<V1alpha1CertificateSpecApiPassthroughExtensionsCertificatePoliciesPolicyQualifiers>? PolicyQualifiers { get; set; }
}

/// <summary>
/// Specifies the X.509 extension information for a certificate.
/// 
/// Extensions present in CustomExtensions follow the ApiPassthrough template
/// rules (https://docs.aws.amazon.com/privateca/latest/userguide/UsingTemplates.html#template-order-of-operations).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecApiPassthroughExtensionsCustomExtensions
{
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    [JsonPropertyName("objectIdentifier")]
    public string? ObjectIdentifier { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Specifies additional purposes for which the certified public key may be used
/// other than basic purposes indicated in the KeyUsage extension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecApiPassthroughExtensionsExtendedKeyUsage
{
    [JsonPropertyName("extendedKeyUsageObjectIdentifier")]
    public string? ExtendedKeyUsageObjectIdentifier { get; set; }

    [JsonPropertyName("extendedKeyUsageType")]
    public string? ExtendedKeyUsageType { get; set; }
}

/// <summary>
/// Defines one or more purposes for which the key contained in the certificate
/// can be used. Default value for each option is false.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecApiPassthroughExtensionsKeyUsage
{
    [JsonPropertyName("crlSign")]
    public bool? CrlSign { get; set; }

    [JsonPropertyName("dataEncipherment")]
    public bool? DataEncipherment { get; set; }

    [JsonPropertyName("decipherOnly")]
    public bool? DecipherOnly { get; set; }

    [JsonPropertyName("digitalSignature")]
    public bool? DigitalSignature { get; set; }

    [JsonPropertyName("encipherOnly")]
    public bool? EncipherOnly { get; set; }

    [JsonPropertyName("keyAgreement")]
    public bool? KeyAgreement { get; set; }

    [JsonPropertyName("keyCertSign")]
    public bool? KeyCertSign { get; set; }

    [JsonPropertyName("keyEncipherment")]
    public bool? KeyEncipherment { get; set; }

    [JsonPropertyName("nonRepudiation")]
    public bool? NonRepudiation { get; set; }
}

/// <summary>Defines the X.500 relative distinguished name (RDN).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecApiPassthroughExtensionsSubjectAlternativeNamesDirectoryNameCustomAttributes
{
    [JsonPropertyName("objectIdentifier")]
    public string? ObjectIdentifier { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Contains information about the certificate subject. The Subject field in
/// the certificate identifies the entity that owns or controls the public key
/// in the certificate. The entity can be a user, computer, device, or service.
/// The Subject must contain an X.500 distinguished name (DN). A DN is a sequence
/// of relative distinguished names (RDNs). The RDNs are separated by commas
/// in the certificate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecApiPassthroughExtensionsSubjectAlternativeNamesDirectoryName
{
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("customAttributes")]
    public IList<V1alpha1CertificateSpecApiPassthroughExtensionsSubjectAlternativeNamesDirectoryNameCustomAttributes>? CustomAttributes { get; set; }

    [JsonPropertyName("distinguishedNameQualifier")]
    public string? DistinguishedNameQualifier { get; set; }

    [JsonPropertyName("generationQualifier")]
    public string? GenerationQualifier { get; set; }

    [JsonPropertyName("givenName")]
    public string? GivenName { get; set; }

    [JsonPropertyName("initials")]
    public string? Initials { get; set; }

    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    [JsonPropertyName("organizationalUnit")]
    public string? OrganizationalUnit { get; set; }

    [JsonPropertyName("pseudonym")]
    public string? Pseudonym { get; set; }

    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("surname")]
    public string? Surname { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Describes an Electronic Data Interchange (EDI) entity as described in as
/// defined in Subject Alternative Name (https://datatracker.ietf.org/doc/html/rfc5280)
/// in RFC 5280.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecApiPassthroughExtensionsSubjectAlternativeNamesEdiPartyName
{
    [JsonPropertyName("nameAssigner")]
    public string? NameAssigner { get; set; }

    [JsonPropertyName("partyName")]
    public string? PartyName { get; set; }
}

/// <summary>
/// Defines a custom ASN.1 X.400 GeneralName using an object identifier (OID)
/// and value. The OID must satisfy the regular expression shown below. For more
/// information, see NIST&apos;s definition of Object Identifier (OID) (https://csrc.nist.gov/glossary/term/Object_Identifier).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecApiPassthroughExtensionsSubjectAlternativeNamesOtherName
{
    [JsonPropertyName("typeID")]
    public string? TypeID { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Describes an ASN.1 X.400 GeneralName as defined in RFC 5280 (https://datatracker.ietf.org/doc/html/rfc5280).
/// Only one of the following naming options should be provided. Providing more
/// than one option results in an InvalidArgsException error.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecApiPassthroughExtensionsSubjectAlternativeNames
{
    /// <summary>
    /// Contains information about the certificate subject. The Subject field in
    /// the certificate identifies the entity that owns or controls the public key
    /// in the certificate. The entity can be a user, computer, device, or service.
    /// The Subject must contain an X.500 distinguished name (DN). A DN is a sequence
    /// of relative distinguished names (RDNs). The RDNs are separated by commas
    /// in the certificate.
    /// </summary>
    [JsonPropertyName("directoryName")]
    public V1alpha1CertificateSpecApiPassthroughExtensionsSubjectAlternativeNamesDirectoryName? DirectoryName { get; set; }

    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>
    /// Describes an Electronic Data Interchange (EDI) entity as described in as
    /// defined in Subject Alternative Name (https://datatracker.ietf.org/doc/html/rfc5280)
    /// in RFC 5280.
    /// </summary>
    [JsonPropertyName("ediPartyName")]
    public V1alpha1CertificateSpecApiPassthroughExtensionsSubjectAlternativeNamesEdiPartyName? EdiPartyName { get; set; }

    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>
    /// Defines a custom ASN.1 X.400 GeneralName using an object identifier (OID)
    /// and value. The OID must satisfy the regular expression shown below. For more
    /// information, see NIST&apos;s definition of Object Identifier (OID) (https://csrc.nist.gov/glossary/term/Object_Identifier).
    /// </summary>
    [JsonPropertyName("otherName")]
    public V1alpha1CertificateSpecApiPassthroughExtensionsSubjectAlternativeNamesOtherName? OtherName { get; set; }

    [JsonPropertyName("registeredID")]
    public string? RegisteredID { get; set; }

    [JsonPropertyName("rfc822Name")]
    public string? Rfc822Name { get; set; }

    [JsonPropertyName("uniformResourceIdentifier")]
    public string? UniformResourceIdentifier { get; set; }
}

/// <summary>Contains X.509 extension information for a certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecApiPassthroughExtensions
{
    [JsonPropertyName("certificatePolicies")]
    public IList<V1alpha1CertificateSpecApiPassthroughExtensionsCertificatePolicies>? CertificatePolicies { get; set; }

    [JsonPropertyName("customExtensions")]
    public IList<V1alpha1CertificateSpecApiPassthroughExtensionsCustomExtensions>? CustomExtensions { get; set; }

    [JsonPropertyName("extendedKeyUsage")]
    public IList<V1alpha1CertificateSpecApiPassthroughExtensionsExtendedKeyUsage>? ExtendedKeyUsage { get; set; }

    /// <summary>
    /// Defines one or more purposes for which the key contained in the certificate
    /// can be used. Default value for each option is false.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public V1alpha1CertificateSpecApiPassthroughExtensionsKeyUsage? KeyUsage { get; set; }

    [JsonPropertyName("subjectAlternativeNames")]
    public IList<V1alpha1CertificateSpecApiPassthroughExtensionsSubjectAlternativeNames>? SubjectAlternativeNames { get; set; }
}

/// <summary>Defines the X.500 relative distinguished name (RDN).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecApiPassthroughSubjectCustomAttributes
{
    [JsonPropertyName("objectIdentifier")]
    public string? ObjectIdentifier { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Contains information about the certificate subject. The Subject field in
/// the certificate identifies the entity that owns or controls the public key
/// in the certificate. The entity can be a user, computer, device, or service.
/// The Subject must contain an X.500 distinguished name (DN). A DN is a sequence
/// of relative distinguished names (RDNs). The RDNs are separated by commas
/// in the certificate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecApiPassthroughSubject
{
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("customAttributes")]
    public IList<V1alpha1CertificateSpecApiPassthroughSubjectCustomAttributes>? CustomAttributes { get; set; }

    [JsonPropertyName("distinguishedNameQualifier")]
    public string? DistinguishedNameQualifier { get; set; }

    [JsonPropertyName("generationQualifier")]
    public string? GenerationQualifier { get; set; }

    [JsonPropertyName("givenName")]
    public string? GivenName { get; set; }

    [JsonPropertyName("initials")]
    public string? Initials { get; set; }

    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    [JsonPropertyName("organizationalUnit")]
    public string? OrganizationalUnit { get; set; }

    [JsonPropertyName("pseudonym")]
    public string? Pseudonym { get; set; }

    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("surname")]
    public string? Surname { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }
}

/// <summary>
/// Specifies X.509 certificate information to be included in the issued certificate.
/// An APIPassthrough or APICSRPassthrough template variant must be selected,
/// or else this parameter is ignored. For more information about using these
/// templates, see Understanding Certificate Templates (https://docs.aws.amazon.com/privateca/latest/userguide/UsingTemplates.html).
/// 
/// If conflicting or duplicate certificate information is supplied during certificate
/// issuance, Amazon Web Services Private CA applies order of operation rules
/// (https://docs.aws.amazon.com/privateca/latest/userguide/UsingTemplates.html#template-order-of-operations)
/// to determine what information is used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecApiPassthrough
{
    /// <summary>Contains X.509 extension information for a certificate.</summary>
    [JsonPropertyName("extensions")]
    public V1alpha1CertificateSpecApiPassthroughExtensions? Extensions { get; set; }

    /// <summary>
    /// Contains information about the certificate subject. The Subject field in
    /// the certificate identifies the entity that owns or controls the public key
    /// in the certificate. The entity can be a user, computer, device, or service.
    /// The Subject must contain an X.500 distinguished name (DN). A DN is a sequence
    /// of relative distinguished names (RDNs). The RDNs are separated by commas
    /// in the certificate.
    /// </summary>
    [JsonPropertyName("subject")]
    public V1alpha1CertificateSpecApiPassthroughSubject? Subject { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecCertificateAuthorityRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecCertificateAuthorityRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1CertificateSpecCertificateAuthorityRefFrom? From { get; set; }
}

/// <summary>
/// SecretKeyReference combines a k8s corev1.SecretReference with a
/// specific key within the referred-to Secret
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecCertificateOutput
{
    /// <summary>Key is the key within the secret</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>name is unique within a namespace to reference a secret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>namespace defines the space within which the secret name must be unique.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReference provides all the values necessary to reference another
/// k8s resource for finding the identifier(Id/ARN/Name)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecCertificateSigningRequestRefFrom
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
/// type to provide more user friendly syntax for references using &apos;from&apos; field
/// Ex:
/// APIIDRef:
/// 
/// 	from:
/// 	  name: my-api
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecCertificateSigningRequestRef
{
    /// <summary>
    /// AWSResourceReference provides all the values necessary to reference another
    /// k8s resource for finding the identifier(Id/ARN/Name)
    /// </summary>
    [JsonPropertyName("from")]
    public V1alpha1CertificateSpecCertificateSigningRequestRefFrom? From { get; set; }
}

/// <summary>
/// Information describing the end of the validity period of the certificate.
/// This parameter sets the “Not After” date for the certificate.
/// 
/// Certificate validity is the period of time during which a certificate is
/// valid. Validity can be expressed as an explicit date and time when the certificate
/// expires, or as a span of time after issuance, stated in days, months, or
/// years. For more information, see Validity (https://datatracker.ietf.org/doc/html/rfc5280#section-4.1.2.5)
/// in RFC 5280.
/// 
/// This value is unaffected when ValidityNotBefore is also specified. For example,
/// if Validity is set to 20 days in the future, the certificate will expire
/// 20 days from issuance time regardless of the ValidityNotBefore value.
/// 
/// The end of the validity period configured on a certificate must not exceed
/// the limit set on its parents in the CA hierarchy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecValidity
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public long? Value { get; set; }
}

/// <summary>
/// Information describing the start of the validity period of the certificate.
/// This parameter sets the “Not Before&quot; date for the certificate.
/// 
/// By default, when issuing a certificate, Amazon Web Services Private CA sets
/// the &quot;Not Before&quot; date to the issuance time minus 60 minutes. This compensates
/// for clock inconsistencies across computer systems. The ValidityNotBefore
/// parameter can be used to customize the “Not Before” value.
/// 
/// Unlike the Validity parameter, the ValidityNotBefore parameter is optional.
/// 
/// The ValidityNotBefore value is expressed as an explicit date and time, using
/// the Validity type value ABSOLUTE. For more information, see Validity (https://docs.aws.amazon.com/privateca/latest/APIReference/API_Validity.html)
/// in this API reference and Validity (https://datatracker.ietf.org/doc/html/rfc5280#section-4.1.2.5)
/// in RFC 5280.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecValidityNotBefore
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public long? Value { get; set; }
}

/// <summary>CertificateSpec defines the desired state of Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpec
{
    /// <summary>
    /// Specifies X.509 certificate information to be included in the issued certificate.
    /// An APIPassthrough or APICSRPassthrough template variant must be selected,
    /// or else this parameter is ignored. For more information about using these
    /// templates, see Understanding Certificate Templates (https://docs.aws.amazon.com/privateca/latest/userguide/UsingTemplates.html).
    /// 
    /// If conflicting or duplicate certificate information is supplied during certificate
    /// issuance, Amazon Web Services Private CA applies order of operation rules
    /// (https://docs.aws.amazon.com/privateca/latest/userguide/UsingTemplates.html#template-order-of-operations)
    /// to determine what information is used.
    /// </summary>
    [JsonPropertyName("apiPassthrough")]
    public V1alpha1CertificateSpecApiPassthrough? ApiPassthrough { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) that was returned when you called CreateCertificateAuthority
    /// (https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthority.html).
    /// This must be of the form:
    /// 
    /// arn:aws:acm-pca:region:account:certificate-authority/12345678-1234-1234-1234-123456789012
    /// 
    /// Regex Pattern: `^arn:[\w+=/,.@-]+:acm-pca:[\w+=/,.@-]*:[0-9]*:[\w+=,.@-]+(/[\w+=,.@-]+)*$`
    /// </summary>
    [JsonPropertyName("certificateAuthorityARN")]
    public string? CertificateAuthorityARN { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("certificateAuthorityRef")]
    public V1alpha1CertificateSpecCertificateAuthorityRef? CertificateAuthorityRef { get; set; }

    /// <summary>
    /// SecretKeyReference combines a k8s corev1.SecretReference with a
    /// specific key within the referred-to Secret
    /// </summary>
    [JsonPropertyName("certificateOutput")]
    public V1alpha1CertificateSpecCertificateOutput? CertificateOutput { get; set; }

    [JsonPropertyName("certificateSigningRequest")]
    public string? CertificateSigningRequest { get; set; }

    /// <summary>
    /// AWSResourceReferenceWrapper provides a wrapper around *AWSResourceReference
    /// type to provide more user friendly syntax for references using &apos;from&apos; field
    /// Ex:
    /// APIIDRef:
    /// 
    /// 	from:
    /// 	  name: my-api
    /// </summary>
    [JsonPropertyName("certificateSigningRequestRef")]
    public V1alpha1CertificateSpecCertificateSigningRequestRef? CertificateSigningRequestRef { get; set; }

    /// <summary>
    /// The name of the algorithm that will be used to sign the certificate to be
    /// issued.
    /// 
    /// This parameter should not be confused with the SigningAlgorithm parameter
    /// used to sign a CSR in the CreateCertificateAuthority action.
    /// 
    /// The specified signing algorithm family (RSA or ECDSA) must match the algorithm
    /// family of the CA&apos;s secret key.
    /// </summary>
    [JsonPropertyName("signingAlgorithm")]
    public required string SigningAlgorithm { get; set; }

    /// <summary>
    /// Specifies a custom configuration template to use when issuing a certificate.
    /// If this parameter is not provided, Amazon Web Services Private CA defaults
    /// to the EndEntityCertificate/V1 template. For CA certificates, you should
    /// choose the shortest path length that meets your needs. The path length is
    /// indicated by the PathLenN portion of the ARN, where N is the CA depth (https://docs.aws.amazon.com/privateca/latest/userguide/PcaTerms.html#terms-cadepth).
    /// 
    /// Note: The CA depth configured on a subordinate CA certificate must not exceed
    /// the limit set by its parents in the CA hierarchy.
    /// 
    /// For a list of TemplateArn values supported by Amazon Web Services Private
    /// CA, see Understanding Certificate Templates (https://docs.aws.amazon.com/privateca/latest/userguide/UsingTemplates.html).
    /// 
    /// Regex Pattern: `^arn:[\w+=/,.@-]+:acm-pca:[\w+=/,.@-]*:[0-9]*:[\w+=,.@-]+(/[\w+=,.@-]+)*$`
    /// </summary>
    [JsonPropertyName("templateARN")]
    public string? TemplateARN { get; set; }

    /// <summary>
    /// Information describing the end of the validity period of the certificate.
    /// This parameter sets the “Not After” date for the certificate.
    /// 
    /// Certificate validity is the period of time during which a certificate is
    /// valid. Validity can be expressed as an explicit date and time when the certificate
    /// expires, or as a span of time after issuance, stated in days, months, or
    /// years. For more information, see Validity (https://datatracker.ietf.org/doc/html/rfc5280#section-4.1.2.5)
    /// in RFC 5280.
    /// 
    /// This value is unaffected when ValidityNotBefore is also specified. For example,
    /// if Validity is set to 20 days in the future, the certificate will expire
    /// 20 days from issuance time regardless of the ValidityNotBefore value.
    /// 
    /// The end of the validity period configured on a certificate must not exceed
    /// the limit set on its parents in the CA hierarchy.
    /// </summary>
    [JsonPropertyName("validity")]
    public required V1alpha1CertificateSpecValidity Validity { get; set; }

    /// <summary>
    /// Information describing the start of the validity period of the certificate.
    /// This parameter sets the “Not Before&quot; date for the certificate.
    /// 
    /// By default, when issuing a certificate, Amazon Web Services Private CA sets
    /// the &quot;Not Before&quot; date to the issuance time minus 60 minutes. This compensates
    /// for clock inconsistencies across computer systems. The ValidityNotBefore
    /// parameter can be used to customize the “Not Before” value.
    /// 
    /// Unlike the Validity parameter, the ValidityNotBefore parameter is optional.
    /// 
    /// The ValidityNotBefore value is expressed as an explicit date and time, using
    /// the Validity type value ABSOLUTE. For more information, see Validity (https://docs.aws.amazon.com/privateca/latest/APIReference/API_Validity.html)
    /// in this API reference and Validity (https://datatracker.ietf.org/doc/html/rfc5280#section-4.1.2.5)
    /// in RFC 5280.
    /// </summary>
    [JsonPropertyName("validityNotBefore")]
    public V1alpha1CertificateSpecValidityNotBefore? ValidityNotBefore { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>CertificateStatus defines the observed state of Certificate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1CertificateStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CertificateStatusConditions>? Conditions { get; set; }
}

/// <summary>Certificate is the Schema for the Certificates API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Certificate : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CertificateSpec?>, IStatus<V1alpha1CertificateStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Certificate";
    public const string KubeGroup = "acmpca.services.k8s.aws";
    public const string KubePluralName = "certificates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "acmpca.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Certificate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CertificateSpec defines the desired state of Certificate.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1CertificateSpec? Spec { get; set; }

    /// <summary>CertificateStatus defines the observed state of Certificate</summary>
    [JsonPropertyName("status")]
    public V1alpha1CertificateStatus? Status { get; set; }
}