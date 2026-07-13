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
/// <summary>CertificateAuthority is the Schema for the CertificateAuthorities API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CertificateAuthorityList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1CertificateAuthority>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CertificateAuthorityList";
    public const string KubeGroup = "acmpca.services.k8s.aws";
    public const string KubePluralName = "certificateauthorities";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "acmpca.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CertificateAuthorityList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1CertificateAuthority objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1CertificateAuthority> Items { get; set; }
}

/// <summary>
/// Defines one or more purposes for which the key contained in the certificate
/// can be used. Default value for each option is false.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensionsKeyUsage
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensionsSubjectInformationAccessAccessLocationDirectoryNameCustomAttributes
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensionsSubjectInformationAccessAccessLocationDirectoryName
{
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("customAttributes")]
    public IList<V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensionsSubjectInformationAccessAccessLocationDirectoryNameCustomAttributes>? CustomAttributes { get; set; }

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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensionsSubjectInformationAccessAccessLocationEdiPartyName
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensionsSubjectInformationAccessAccessLocationOtherName
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensionsSubjectInformationAccessAccessLocation
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
    public V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensionsSubjectInformationAccessAccessLocationDirectoryName? DirectoryName { get; set; }

    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>
    /// Describes an Electronic Data Interchange (EDI) entity as described in as
    /// defined in Subject Alternative Name (https://datatracker.ietf.org/doc/html/rfc5280)
    /// in RFC 5280.
    /// </summary>
    [JsonPropertyName("ediPartyName")]
    public V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensionsSubjectInformationAccessAccessLocationEdiPartyName? EdiPartyName { get; set; }

    [JsonPropertyName("ipAddress")]
    public string? IpAddress { get; set; }

    /// <summary>
    /// Defines a custom ASN.1 X.400 GeneralName using an object identifier (OID)
    /// and value. The OID must satisfy the regular expression shown below. For more
    /// information, see NIST&apos;s definition of Object Identifier (OID) (https://csrc.nist.gov/glossary/term/Object_Identifier).
    /// </summary>
    [JsonPropertyName("otherName")]
    public V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensionsSubjectInformationAccessAccessLocationOtherName? OtherName { get; set; }

    [JsonPropertyName("registeredID")]
    public string? RegisteredID { get; set; }

    [JsonPropertyName("rfc822Name")]
    public string? Rfc822Name { get; set; }

    [JsonPropertyName("uniformResourceIdentifier")]
    public string? UniformResourceIdentifier { get; set; }
}

/// <summary>
/// Describes the type and format of extension access. Only one of CustomObjectIdentifier
/// or AccessMethodType may be provided. Providing both results in InvalidArgsException.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensionsSubjectInformationAccessAccessMethod
{
    [JsonPropertyName("accessMethodType")]
    public string? AccessMethodType { get; set; }

    [JsonPropertyName("customObjectIdentifier")]
    public string? CustomObjectIdentifier { get; set; }
}

/// <summary>
/// Provides access information used by the authorityInfoAccess and subjectInfoAccess
/// extensions described in RFC 5280 (https://datatracker.ietf.org/doc/html/rfc5280).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensionsSubjectInformationAccess
{
    /// <summary>
    /// Describes an ASN.1 X.400 GeneralName as defined in RFC 5280 (https://datatracker.ietf.org/doc/html/rfc5280).
    /// Only one of the following naming options should be provided. Providing more
    /// than one option results in an InvalidArgsException error.
    /// </summary>
    [JsonPropertyName("accessLocation")]
    public V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensionsSubjectInformationAccessAccessLocation? AccessLocation { get; set; }

    /// <summary>
    /// Describes the type and format of extension access. Only one of CustomObjectIdentifier
    /// or AccessMethodType may be provided. Providing both results in InvalidArgsException.
    /// </summary>
    [JsonPropertyName("accessMethod")]
    public V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensionsSubjectInformationAccessAccessMethod? AccessMethod { get; set; }
}

/// <summary>
/// Describes the certificate extensions to be added to the certificate signing
/// request (CSR).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensions
{
    /// <summary>
    /// Defines one or more purposes for which the key contained in the certificate
    /// can be used. Default value for each option is false.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensionsKeyUsage? KeyUsage { get; set; }

    [JsonPropertyName("subjectInformationAccess")]
    public IList<V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensionsSubjectInformationAccess>? SubjectInformationAccess { get; set; }
}

/// <summary>Defines the X.500 relative distinguished name (RDN).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationSubjectCustomAttributes
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationSubject
{
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    [JsonPropertyName("country")]
    public string? Country { get; set; }

    [JsonPropertyName("customAttributes")]
    public IList<V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationSubjectCustomAttributes>? CustomAttributes { get; set; }

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
/// Name and bit size of the private key algorithm, the name of the signing algorithm,
/// and X.500 certificate subject information.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthoritySpecCertificateAuthorityConfiguration
{
    /// <summary>
    /// Describes the certificate extensions to be added to the certificate signing
    /// request (CSR).
    /// </summary>
    [JsonPropertyName("csrExtensions")]
    public V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationCsrExtensions? CsrExtensions { get; set; }

    [JsonPropertyName("keyAlgorithm")]
    public string? KeyAlgorithm { get; set; }

    [JsonPropertyName("signingAlgorithm")]
    public string? SigningAlgorithm { get; set; }

    /// <summary>
    /// Contains information about the certificate subject. The Subject field in
    /// the certificate identifies the entity that owns or controls the public key
    /// in the certificate. The entity can be a user, computer, device, or service.
    /// The Subject must contain an X.500 distinguished name (DN). A DN is a sequence
    /// of relative distinguished names (RDNs). The RDNs are separated by commas
    /// in the certificate.
    /// </summary>
    [JsonPropertyName("subject")]
    public V1alpha1CertificateAuthoritySpecCertificateAuthorityConfigurationSubject? Subject { get; set; }
}

/// <summary>
/// Contains configuration information for a certificate revocation list (CRL).
/// Your private certificate authority (CA) creates base CRLs. Delta CRLs are
/// not supported. You can enable CRLs for your new or an existing private CA
/// by setting the Enabled parameter to true. Your private CA writes CRLs to
/// an S3 bucket that you specify in the S3BucketName parameter. You can hide
/// the name of your bucket by specifying a value for the CustomCname parameter.
/// Your private CA by default copies the CNAME or the S3 bucket name to the
/// CRL Distribution Points extension of each certificate it issues. If you want
/// to configure this default behavior to be something different, you can set
/// the CrlDistributionPointExtensionConfiguration parameter. Your S3 bucket
/// policy must give write permission to Amazon Web Services Private CA.
/// 
/// Amazon Web Services Private CA assets that are stored in Amazon S3 can be
/// protected with encryption. For more information, see Encrypting Your CRLs
/// (https://docs.aws.amazon.com/privateca/latest/userguide/crl-planning.html#crl-encryption).
/// 
/// Your private CA uses the value in the ExpirationInDays parameter to calculate
/// the nextUpdate field in the CRL. The CRL is refreshed prior to a certificate&apos;s
/// expiration date or when a certificate is revoked. When a certificate is revoked,
/// it appears in the CRL until the certificate expires, and then in one additional
/// CRL after expiration, and it always appears in the audit report.
/// 
/// A CRL is typically updated approximately 30 minutes after a certificate is
/// revoked. If for any reason a CRL update fails, Amazon Web Services Private
/// CA makes further attempts every 15 minutes.
/// 
/// CRLs contain the following fields:
/// 
///    * Version: The current version number defined in RFC 5280 is V2. The integer
///    value is 0x1.
/// 
///    * Signature Algorithm: The name of the algorithm used to sign the CRL.
/// 
///    * Issuer: The X.500 distinguished name of your private CA that issued
///    the CRL.
/// 
///    * Last Update: The issue date and time of this CRL.
/// 
///    * Next Update: The day and time by which the next CRL will be issued.
/// 
///    * Revoked Certificates: List of revoked certificates. Each list item contains
///    the following information. Serial Number: The serial number, in hexadecimal
///    format, of the revoked certificate. Revocation Date: Date and time the
///    certificate was revoked. CRL Entry Extensions: Optional extensions for
///    the CRL entry. X509v3 CRL Reason Code: Reason the certificate was revoked.
/// 
///    * CRL Extensions: Optional extensions for the CRL. X509v3 Authority Key
///    Identifier: Identifies the public key associated with the private key
///    used to sign the certificate. X509v3 CRL Number:: Decimal sequence number
///    for the CRL.
/// 
///    * Signature Algorithm: Algorithm used by your private CA to sign the CRL.
/// 
///    * Signature Value: Signature computed over the CRL.
/// 
/// Certificate revocation lists created by Amazon Web Services Private CA are
/// DER-encoded. You can use the following OpenSSL command to list a CRL.
/// 
/// openssl crl -inform DER -text -in crl_path -noout
/// 
/// For more information, see Planning a certificate revocation list (CRL) (https://docs.aws.amazon.com/privateca/latest/userguide/crl-planning.html)
/// in the Amazon Web Services Private Certificate Authority User Guide
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthoritySpecRevocationConfigurationCrlConfiguration
{
    [JsonPropertyName("customCNAME")]
    public string? CustomCNAME { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("expirationInDays")]
    public long? ExpirationInDays { get; set; }

    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    [JsonPropertyName("s3ObjectACL")]
    public string? S3ObjectACL { get; set; }
}

/// <summary>
/// Contains information to enable and configure Online Certificate Status Protocol
/// (OCSP) for validating certificate revocation status.
/// 
/// When you revoke a certificate, OCSP responses may take up to 60 minutes to
/// reflect the new status.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthoritySpecRevocationConfigurationOcspConfiguration
{
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("ocspCustomCNAME")]
    public string? OcspCustomCNAME { get; set; }
}

/// <summary>
/// Contains information to enable support for Online Certificate Status Protocol
/// (OCSP), certificate revocation list (CRL), both protocols, or neither. By
/// default, both certificate validation mechanisms are disabled.
/// 
/// The following requirements apply to revocation configurations.
/// 
///   - A configuration disabling CRLs or OCSP must contain only the Enabled=False
///     parameter, and will fail if other parameters such as CustomCname or ExpirationInDays
///     are included.
/// 
///   - In a CRL configuration, the S3BucketName parameter must conform to Amazon
///     S3 bucket naming rules (https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucketnamingrules.html).
/// 
///   - A configuration containing a custom Canonical Name (CNAME) parameter
///     for CRLs or OCSP must conform to RFC2396 (https://www.ietf.org/rfc/rfc2396.txt)
///     restrictions on the use of special characters in a CNAME.
/// 
///   - In a CRL or OCSP configuration, the value of a CNAME parameter must
///     not include a protocol prefix such as &quot;http://&quot; or &quot;https://&quot;.
/// 
/// For more information, see the OcspConfiguration (https://docs.aws.amazon.com/privateca/latest/APIReference/API_OcspConfiguration.html)
/// and CrlConfiguration (https://docs.aws.amazon.com/privateca/latest/APIReference/API_CrlConfiguration.html)
/// types.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthoritySpecRevocationConfiguration
{
    /// <summary>
    /// Contains configuration information for a certificate revocation list (CRL).
    /// Your private certificate authority (CA) creates base CRLs. Delta CRLs are
    /// not supported. You can enable CRLs for your new or an existing private CA
    /// by setting the Enabled parameter to true. Your private CA writes CRLs to
    /// an S3 bucket that you specify in the S3BucketName parameter. You can hide
    /// the name of your bucket by specifying a value for the CustomCname parameter.
    /// Your private CA by default copies the CNAME or the S3 bucket name to the
    /// CRL Distribution Points extension of each certificate it issues. If you want
    /// to configure this default behavior to be something different, you can set
    /// the CrlDistributionPointExtensionConfiguration parameter. Your S3 bucket
    /// policy must give write permission to Amazon Web Services Private CA.
    /// 
    /// Amazon Web Services Private CA assets that are stored in Amazon S3 can be
    /// protected with encryption. For more information, see Encrypting Your CRLs
    /// (https://docs.aws.amazon.com/privateca/latest/userguide/crl-planning.html#crl-encryption).
    /// 
    /// Your private CA uses the value in the ExpirationInDays parameter to calculate
    /// the nextUpdate field in the CRL. The CRL is refreshed prior to a certificate&apos;s
    /// expiration date or when a certificate is revoked. When a certificate is revoked,
    /// it appears in the CRL until the certificate expires, and then in one additional
    /// CRL after expiration, and it always appears in the audit report.
    /// 
    /// A CRL is typically updated approximately 30 minutes after a certificate is
    /// revoked. If for any reason a CRL update fails, Amazon Web Services Private
    /// CA makes further attempts every 15 minutes.
    /// 
    /// CRLs contain the following fields:
    /// 
    ///    * Version: The current version number defined in RFC 5280 is V2. The integer
    ///    value is 0x1.
    /// 
    ///    * Signature Algorithm: The name of the algorithm used to sign the CRL.
    /// 
    ///    * Issuer: The X.500 distinguished name of your private CA that issued
    ///    the CRL.
    /// 
    ///    * Last Update: The issue date and time of this CRL.
    /// 
    ///    * Next Update: The day and time by which the next CRL will be issued.
    /// 
    ///    * Revoked Certificates: List of revoked certificates. Each list item contains
    ///    the following information. Serial Number: The serial number, in hexadecimal
    ///    format, of the revoked certificate. Revocation Date: Date and time the
    ///    certificate was revoked. CRL Entry Extensions: Optional extensions for
    ///    the CRL entry. X509v3 CRL Reason Code: Reason the certificate was revoked.
    /// 
    ///    * CRL Extensions: Optional extensions for the CRL. X509v3 Authority Key
    ///    Identifier: Identifies the public key associated with the private key
    ///    used to sign the certificate. X509v3 CRL Number:: Decimal sequence number
    ///    for the CRL.
    /// 
    ///    * Signature Algorithm: Algorithm used by your private CA to sign the CRL.
    /// 
    ///    * Signature Value: Signature computed over the CRL.
    /// 
    /// Certificate revocation lists created by Amazon Web Services Private CA are
    /// DER-encoded. You can use the following OpenSSL command to list a CRL.
    /// 
    /// openssl crl -inform DER -text -in crl_path -noout
    /// 
    /// For more information, see Planning a certificate revocation list (CRL) (https://docs.aws.amazon.com/privateca/latest/userguide/crl-planning.html)
    /// in the Amazon Web Services Private Certificate Authority User Guide
    /// </summary>
    [JsonPropertyName("crlConfiguration")]
    public V1alpha1CertificateAuthoritySpecRevocationConfigurationCrlConfiguration? CrlConfiguration { get; set; }

    /// <summary>
    /// Contains information to enable and configure Online Certificate Status Protocol
    /// (OCSP) for validating certificate revocation status.
    /// 
    /// When you revoke a certificate, OCSP responses may take up to 60 minutes to
    /// reflect the new status.
    /// </summary>
    [JsonPropertyName("ocspConfiguration")]
    public V1alpha1CertificateAuthoritySpecRevocationConfigurationOcspConfiguration? OcspConfiguration { get; set; }
}

/// <summary>
/// Tags are labels that you can use to identify and organize your private CAs.
/// Each tag consists of a key and an optional value. You can associate up to
/// 50 tags with a private CA. To add one or more tags to a private CA, call
/// the TagCertificateAuthority (https://docs.aws.amazon.com/privateca/latest/APIReference/API_TagCertificateAuthority.html)
/// action. To remove a tag, call the UntagCertificateAuthority (https://docs.aws.amazon.com/privateca/latest/APIReference/API_UntagCertificateAuthority.html)
/// action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthoritySpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// CertificateAuthoritySpec defines the desired state of CertificateAuthority.
/// 
/// Contains information about your private certificate authority (CA). Your
/// private CA can issue and revoke X.509 digital certificates. Digital certificates
/// verify that the entity named in the certificate Subject field owns or controls
/// the public key contained in the Subject Public Key Info field. Call the CreateCertificateAuthority
/// (https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthority.html)
/// action to create your private CA. You must then call the GetCertificateAuthorityCertificate
/// (https://docs.aws.amazon.com/privateca/latest/APIReference/API_GetCertificateAuthorityCertificate.html)
/// action to retrieve a private CA certificate signing request (CSR). Sign the
/// CSR with your Amazon Web Services Private CA-hosted or on-premises root or
/// subordinate CA certificate. Call the ImportCertificateAuthorityCertificate
/// (https://docs.aws.amazon.com/privateca/latest/APIReference/API_ImportCertificateAuthorityCertificate.html)
/// action to import the signed certificate into Certificate Manager (ACM).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthoritySpec
{
    /// <summary>
    /// Name and bit size of the private key algorithm, the name of the signing algorithm,
    /// and X.500 certificate subject information.
    /// </summary>
    [JsonPropertyName("certificateAuthorityConfiguration")]
    public required V1alpha1CertificateAuthoritySpecCertificateAuthorityConfiguration CertificateAuthorityConfiguration { get; set; }

    /// <summary>
    /// Specifies a cryptographic key management compliance standard used for handling
    /// CA keys.
    /// 
    /// Default: FIPS_140_2_LEVEL_3_OR_HIGHER
    /// 
    /// Some Amazon Web Services Regions do not support the default. When creating
    /// a CA in these Regions, you must provide FIPS_140_2_LEVEL_2_OR_HIGHER as the
    /// argument for KeyStorageSecurityStandard. Failure to do this results in an
    /// InvalidArgsException with the message, &quot;A certificate authority cannot be
    /// created in this region with the specified security standard.&quot;
    /// 
    /// For information about security standard support in various Regions, see Storage
    /// and security compliance of Amazon Web Services Private CA private keys (https://docs.aws.amazon.com/privateca/latest/userguide/data-protection.html#private-keys).
    /// </summary>
    [JsonPropertyName("keyStorageSecurityStandard")]
    public string? KeyStorageSecurityStandard { get; set; }

    /// <summary>
    /// Contains information to enable support for Online Certificate Status Protocol
    /// (OCSP), certificate revocation list (CRL), both protocols, or neither. By
    /// default, both certificate validation mechanisms are disabled.
    /// 
    /// The following requirements apply to revocation configurations.
    /// 
    ///   - A configuration disabling CRLs or OCSP must contain only the Enabled=False
    ///     parameter, and will fail if other parameters such as CustomCname or ExpirationInDays
    ///     are included.
    /// 
    ///   - In a CRL configuration, the S3BucketName parameter must conform to Amazon
    ///     S3 bucket naming rules (https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucketnamingrules.html).
    /// 
    ///   - A configuration containing a custom Canonical Name (CNAME) parameter
    ///     for CRLs or OCSP must conform to RFC2396 (https://www.ietf.org/rfc/rfc2396.txt)
    ///     restrictions on the use of special characters in a CNAME.
    /// 
    ///   - In a CRL or OCSP configuration, the value of a CNAME parameter must
    ///     not include a protocol prefix such as &quot;http://&quot; or &quot;https://&quot;.
    /// 
    /// For more information, see the OcspConfiguration (https://docs.aws.amazon.com/privateca/latest/APIReference/API_OcspConfiguration.html)
    /// and CrlConfiguration (https://docs.aws.amazon.com/privateca/latest/APIReference/API_CrlConfiguration.html)
    /// types.
    /// </summary>
    [JsonPropertyName("revocationConfiguration")]
    public V1alpha1CertificateAuthoritySpecRevocationConfiguration? RevocationConfiguration { get; set; }

    /// <summary>
    /// Key-value pairs that will be attached to the new private CA. You can associate
    /// up to 50 tags with a private CA. For information using tags with IAM to manage
    /// permissions, see Controlling Access Using IAM Tags (https://docs.aws.amazon.com/IAM/latest/UserGuide/access_iam-tags.html).
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1CertificateAuthoritySpecTags>? Tags { get; set; }

    /// <summary>The type of the certificate authority.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// Specifies whether the CA issues general-purpose certificates that typically
    /// require a revocation mechanism, or short-lived certificates that may optionally
    /// omit revocation because they expire quickly. Short-lived certificate validity
    /// is limited to seven days.
    /// 
    /// The default value is GENERAL_PURPOSE.
    /// </summary>
    [JsonPropertyName("usageMode")]
    public string? UsageMode { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthorityStatusAckResourceMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthorityStatusConditions
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

/// <summary>CertificateAuthorityStatus defines the observed state of CertificateAuthority</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateAuthorityStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1CertificateAuthorityStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// The base64 PEM-encoded certificate signing request (CSR) for your private
    /// CA certificate.
    /// </summary>
    [JsonPropertyName("certificateSigningRequest")]
    public string? CertificateSigningRequest { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1CertificateAuthorityStatusConditions>? Conditions { get; set; }

    /// <summary>Date and time at which your private CA was created.</summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>Reason the request to create your private CA failed.</summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>Date and time at which your private CA was last updated.</summary>
    [JsonPropertyName("lastStateChangeAt")]
    public DateTime? LastStateChangeAt { get; set; }

    /// <summary>Date and time after which your private CA certificate is not valid.</summary>
    [JsonPropertyName("notAfter")]
    public DateTime? NotAfter { get; set; }

    /// <summary>Date and time before which your private CA certificate is not valid.</summary>
    [JsonPropertyName("notBefore")]
    public DateTime? NotBefore { get; set; }

    /// <summary>
    /// The Amazon Web Services account ID that owns the certificate authority.
    /// 
    /// Regex Pattern: `^[0-9]+$`
    /// </summary>
    [JsonPropertyName("ownerAccount")]
    public string? OwnerAccount { get; set; }

    /// <summary>
    /// The period during which a deleted CA can be restored. For more information,
    /// see the PermanentDeletionTimeInDays parameter of the DeleteCertificateAuthorityRequest
    /// (https://docs.aws.amazon.com/privateca/latest/APIReference/API_DeleteCertificateAuthorityRequest.html)
    /// action.
    /// </summary>
    [JsonPropertyName("restorableUntil")]
    public DateTime? RestorableUntil { get; set; }

    /// <summary>Serial number of your private CA.</summary>
    [JsonPropertyName("serial")]
    public string? Serial { get; set; }

    /// <summary>Status of your private CA.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>CertificateAuthority is the Schema for the CertificateAuthorities API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CertificateAuthority : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CertificateAuthoritySpec?>, IStatus<V1alpha1CertificateAuthorityStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CertificateAuthority";
    public const string KubeGroup = "acmpca.services.k8s.aws";
    public const string KubePluralName = "certificateauthorities";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "acmpca.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CertificateAuthority";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// CertificateAuthoritySpec defines the desired state of CertificateAuthority.
    /// 
    /// Contains information about your private certificate authority (CA). Your
    /// private CA can issue and revoke X.509 digital certificates. Digital certificates
    /// verify that the entity named in the certificate Subject field owns or controls
    /// the public key contained in the Subject Public Key Info field. Call the CreateCertificateAuthority
    /// (https://docs.aws.amazon.com/privateca/latest/APIReference/API_CreateCertificateAuthority.html)
    /// action to create your private CA. You must then call the GetCertificateAuthorityCertificate
    /// (https://docs.aws.amazon.com/privateca/latest/APIReference/API_GetCertificateAuthorityCertificate.html)
    /// action to retrieve a private CA certificate signing request (CSR). Sign the
    /// CSR with your Amazon Web Services Private CA-hosted or on-premises root or
    /// subordinate CA certificate. Call the ImportCertificateAuthorityCertificate
    /// (https://docs.aws.amazon.com/privateca/latest/APIReference/API_ImportCertificateAuthorityCertificate.html)
    /// action to import the signed certificate into Certificate Manager (ACM).
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1CertificateAuthoritySpec? Spec { get; set; }

    /// <summary>CertificateAuthorityStatus defines the observed state of CertificateAuthority</summary>
    [JsonPropertyName("status")]
    public V1alpha1CertificateAuthorityStatus? Status { get; set; }
}