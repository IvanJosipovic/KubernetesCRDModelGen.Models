#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.acm.services.k8s.aws;
/// <summary>Certificate is the Schema for the Certificates API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1CertificateList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Certificate>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "CertificateList";
    public const string KubeGroup = "acm.services.k8s.aws";
    public const string KubePluralName = "certificates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "acm.services.k8s.aws/v1alpha1";

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
/// The Certificate to import into AWS Certificate Manager (ACM) to use with services that are integrated with ACM.
/// This field is only valid when importing an existing certificate into ACM.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecCertificate
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
public partial class V1alpha1CertificateSpecCertificateChain
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
/// Contains information about the domain names that you want ACM to use to send
/// you emails that enable you to validate domain ownership.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecDomainValidationOptions
{
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    [JsonPropertyName("validationDomain")]
    public string? ValidationDomain { get; set; }
}

/// <summary>
/// SecretKeyReference combines a k8s corev1.SecretReference with a
/// specific key within the referred-to Secret
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecExportTo
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
/// Currently, you can use this parameter to specify whether to add the certificate
/// to a certificate transparency log. Certificate transparency makes it possible
/// to detect SSL/TLS certificates that have been mistakenly or maliciously issued.
/// Certificates that have not been logged typically produce an error message
/// in a browser. For more information, see Opting Out of Certificate Transparency
/// Logging (https://docs.aws.amazon.com/acm/latest/userguide/acm-bestpractices.html#best-practices-transparency).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecOptions
{
    [JsonPropertyName("certificateTransparencyLoggingPreference")]
    public string? CertificateTransparencyLoggingPreference { get; set; }
}

/// <summary>
/// The private key that matches the public key in the certificate. This field is only valid when importing
/// an existing certificate into ACM.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecPrivateKey
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

/// <summary>A key-value pair that identifies or specifies metadata about an ACM resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>CertificateSpec defines the desired state of Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateSpec
{
    /// <summary>
    /// The Certificate to import into AWS Certificate Manager (ACM) to use with services that are integrated with ACM.
    /// This field is only valid when importing an existing certificate into ACM.
    /// </summary>
    [JsonPropertyName("certificate")]
    public V1alpha1CertificateSpecCertificate? Certificate { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of an imported certificate to replace. This field is only valid when importing
    /// an existing certificate into ACM.
    /// </summary>
    [JsonPropertyName("certificateARN")]
    public string? CertificateARN { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the private certificate authority (CA)
    /// that will be used to issue the certificate. If you do not provide an ARN
    /// and you are trying to request a private certificate, ACM will attempt to
    /// issue a public certificate. For more information about private CAs, see the
    /// Amazon Web Services Private Certificate Authority (https://docs.aws.amazon.com/privateca/latest/userguide/PcaWelcome.html)
    /// user guide. The ARN must have the following form:
    /// 
    /// arn:aws:acm-pca:region:account:certificate-authority/12345678-1234-1234-1234-123456789012
    /// 
    /// Regex Pattern: `^arn:[\w+=/,.@-]+:acm-pca:[\w+=/,.@-]*:[0-9]+:[\w+=,.@-]+(/[\w+=,.@-]+)*$`
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
    [JsonPropertyName("certificateChain")]
    public V1alpha1CertificateSpecCertificateChain? CertificateChain { get; set; }

    /// <summary>
    /// Fully qualified domain name (FQDN), such as www.example.com, that you want
    /// to secure with an ACM certificate. Use an asterisk (*) to create a wildcard
    /// certificate that protects several sites in the same domain. For example,
    /// *.example.com protects www.example.com, site.example.com, and images.example.com.
    /// 
    /// In compliance with RFC 5280 (https://datatracker.ietf.org/doc/html/rfc5280),
    /// the length of the domain name (technically, the Common Name) that you provide
    /// cannot exceed 64 octets (characters), including periods. To add a longer
    /// domain name, specify it in the Subject Alternative Name field, which supports
    /// names up to 253 octets in length.
    /// 
    /// Regex Pattern: `^(\*\.)?(((?!-)[A-Za-z0-9-]{0,62}[A-Za-z0-9])\.)+((?!-)[A-Za-z0-9-]{1,62}[A-Za-z0-9])$`
    /// </summary>
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>
    /// The domain name that you want ACM to use to send you emails so that you can
    /// validate domain ownership.
    /// </summary>
    [JsonPropertyName("domainValidationOptions")]
    public IList<V1alpha1CertificateSpecDomainValidationOptions>? DomainValidationOptions { get; set; }

    /// <summary>
    /// SecretKeyReference combines a k8s corev1.SecretReference with a
    /// specific key within the referred-to Secret
    /// </summary>
    [JsonPropertyName("exportTo")]
    public V1alpha1CertificateSpecExportTo? ExportTo { get; set; }

    /// <summary>
    /// Specifies the algorithm of the public and private key pair that your certificate
    /// uses to encrypt data. RSA is the default key algorithm for ACM certificates.
    /// Elliptic Curve Digital Signature Algorithm (ECDSA) keys are smaller, offering
    /// security comparable to RSA keys but with greater computing efficiency. However,
    /// ECDSA is not supported by all network clients. Some Amazon Web Services services
    /// may require RSA keys, or only support ECDSA keys of a particular size, while
    /// others allow the use of either RSA and ECDSA keys to ensure that compatibility
    /// is not broken. Check the requirements for the Amazon Web Services service
    /// where you plan to deploy your certificate. For more information about selecting
    /// an algorithm, see Key algorithms (https://docs.aws.amazon.com/acm/latest/userguide/acm-certificate.html#algorithms).
    /// 
    /// Algorithms supported for an ACM certificate request include:
    /// 
    ///   - RSA_2048
    /// 
    ///   - EC_prime256v1
    /// 
    ///   - EC_secp384r1
    /// 
    /// Other listed algorithms are for imported certificates only.
    /// 
    /// When you request a private PKI certificate signed by a CA from Amazon Web
    /// Services Private CA, the specified signing algorithm family (RSA or ECDSA)
    /// must match the algorithm family of the CA&apos;s secret key.
    /// 
    /// Default: RSA_2048
    /// </summary>
    [JsonPropertyName("keyAlgorithm")]
    public string? KeyAlgorithm { get; set; }

    /// <summary>
    /// Currently, you can use this parameter to specify whether to add the certificate
    /// to a certificate transparency log. Certificate transparency makes it possible
    /// to detect SSL/TLS certificates that have been mistakenly or maliciously issued.
    /// Certificates that have not been logged typically produce an error message
    /// in a browser. For more information, see Opting Out of Certificate Transparency
    /// Logging (https://docs.aws.amazon.com/acm/latest/userguide/acm-bestpractices.html#best-practices-transparency).
    /// </summary>
    [JsonPropertyName("options")]
    public V1alpha1CertificateSpecOptions? Options { get; set; }

    /// <summary>
    /// The private key that matches the public key in the certificate. This field is only valid when importing
    /// an existing certificate into ACM.
    /// </summary>
    [JsonPropertyName("privateKey")]
    public V1alpha1CertificateSpecPrivateKey? PrivateKey { get; set; }

    /// <summary>
    /// Additional FQDNs to be included in the Subject Alternative Name extension
    /// of the ACM certificate. For example, add the name www.example.net to a certificate
    /// for which the DomainName field is www.example.com if users can reach your
    /// site by using either name. The maximum number of domain names that you can
    /// add to an ACM certificate is 100. However, the initial quota is 10 domain
    /// names. If you need more than 10 names, you must request a quota increase.
    /// For more information, see Quotas (https://docs.aws.amazon.com/acm/latest/userguide/acm-limits.html).
    /// 
    /// The maximum length of a SAN DNS name is 253 octets. The name is made up of
    /// multiple labels separated by periods. No label can be longer than 63 octets.
    /// Consider the following examples:
    /// 
    ///   - (63 octets).(63 octets).(63 octets).(61 octets) is legal because the
    ///     total length is 253 octets (63+1+63+1+63+1+61) and no label exceeds 63
    ///     octets.
    /// 
    ///   - (64 octets).(63 octets).(63 octets).(61 octets) is not legal because
    ///     the total length exceeds 253 octets (64+1+63+1+63+1+61) and the first
    ///     label exceeds 63 octets.
    /// 
    ///   - (63 octets).(63 octets).(63 octets).(62 octets) is not legal because
    ///     the total length of the DNS name (63+1+63+1+63+1+62) exceeds 253 octets.
    /// </summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public IList<string>? SubjectAlternativeNames { get; set; }

    /// <summary>One or more resource tags to associate with the certificate.</summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1CertificateSpecTags>? Tags { get; set; }
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

/// <summary>
/// Contains a DNS record value that you can use to validate ownership or control
/// of a domain. This is used by the DescribeCertificate action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateStatusDomainValidationsResourceRecord
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Contains information about the validation of each domain name in the certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateStatusDomainValidations
{
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>
    /// Contains a DNS record value that you can use to validate ownership or control
    /// of a domain. This is used by the DescribeCertificate action.
    /// </summary>
    [JsonPropertyName("resourceRecord")]
    public V1alpha1CertificateStatusDomainValidationsResourceRecord? ResourceRecord { get; set; }

    [JsonPropertyName("validationDomain")]
    public string? ValidationDomain { get; set; }

    [JsonPropertyName("validationEmails")]
    public IList<string>? ValidationEmails { get; set; }

    [JsonPropertyName("validationMethod")]
    public string? ValidationMethod { get; set; }

    [JsonPropertyName("validationStatus")]
    public string? ValidationStatus { get; set; }
}

/// <summary>
/// The Extended Key Usage X.509 v3 extension defines one or more purposes for
/// which the public key can be used. This is in addition to or in place of the
/// basic purposes specified by the Key Usage extension.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateStatusExtendedKeyUsages
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("oid")]
    public string? Oid { get; set; }
}

/// <summary>
/// The Key Usage X.509 v3 extension defines the purpose of the public key contained
/// in the certificate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateStatusKeyUsages
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Contains a DNS record value that you can use to validate ownership or control
/// of a domain. This is used by the DescribeCertificate action.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateStatusRenewalSummaryDomainValidationOptionsResourceRecord
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Contains information about the validation of each domain name in the certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateStatusRenewalSummaryDomainValidationOptions
{
    [JsonPropertyName("domainName")]
    public string? DomainName { get; set; }

    /// <summary>
    /// Contains a DNS record value that you can use to validate ownership or control
    /// of a domain. This is used by the DescribeCertificate action.
    /// </summary>
    [JsonPropertyName("resourceRecord")]
    public V1alpha1CertificateStatusRenewalSummaryDomainValidationOptionsResourceRecord? ResourceRecord { get; set; }

    [JsonPropertyName("validationDomain")]
    public string? ValidationDomain { get; set; }

    [JsonPropertyName("validationEmails")]
    public IList<string>? ValidationEmails { get; set; }

    [JsonPropertyName("validationMethod")]
    public string? ValidationMethod { get; set; }

    [JsonPropertyName("validationStatus")]
    public string? ValidationStatus { get; set; }
}

/// <summary>
/// Contains information about the status of ACM&apos;s managed renewal (https://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html)
/// for the certificate. This field exists only when the certificate type is
/// AMAZON_ISSUED.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1CertificateStatusRenewalSummary
{
    [JsonPropertyName("domainValidationOptions")]
    public IList<V1alpha1CertificateStatusRenewalSummaryDomainValidationOptions>? DomainValidationOptions { get; set; }

    [JsonPropertyName("renewalStatus")]
    public string? RenewalStatus { get; set; }

    [JsonPropertyName("renewalStatusReason")]
    public string? RenewalStatusReason { get; set; }

    [JsonPropertyName("updatedAt")]
    public DateTime? UpdatedAt { get; set; }
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

    /// <summary>The time at which the certificate was requested.</summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Contains information about the initial validation of each domain name that
    /// occurs as a result of the RequestCertificate request. This field exists only
    /// when the certificate type is AMAZON_ISSUED.
    /// </summary>
    [JsonPropertyName("domainValidations")]
    public IList<V1alpha1CertificateStatusDomainValidations>? DomainValidations { get; set; }

    /// <summary>
    /// Contains a list of Extended Key Usage X.509 v3 extension objects. Each object
    /// specifies a purpose for which the certificate public key can be used and
    /// consists of a name and an object identifier (OID).
    /// </summary>
    [JsonPropertyName("extendedKeyUsages")]
    public IList<V1alpha1CertificateStatusExtendedKeyUsages>? ExtendedKeyUsages { get; set; }

    /// <summary>
    /// The reason the certificate request failed. This value exists only when the
    /// certificate status is FAILED. For more information, see Certificate Request
    /// Failed (https://docs.aws.amazon.com/acm/latest/userguide/troubleshooting.html#troubleshooting-failed)
    /// in the Certificate Manager User Guide.
    /// </summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>
    /// The date and time when the certificate was imported. This value exists only
    /// when the certificate type is IMPORTED.
    /// </summary>
    [JsonPropertyName("importedAt")]
    public DateTime? ImportedAt { get; set; }

    /// <summary>
    /// A list of ARNs for the Amazon Web Services resources that are using the certificate.
    /// A certificate can be used by multiple Amazon Web Services resources.
    /// </summary>
    [JsonPropertyName("inUseBy")]
    public IList<string>? InUseBy { get; set; }

    /// <summary>
    /// The time at which the certificate was issued. This value exists only when
    /// the certificate type is AMAZON_ISSUED.
    /// </summary>
    [JsonPropertyName("issuedAt")]
    public DateTime? IssuedAt { get; set; }

    /// <summary>The name of the certificate authority that issued and signed the certificate.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>
    /// A list of Key Usage X.509 v3 extension objects. Each object is a string value
    /// that identifies the purpose of the public key contained in the certificate.
    /// Possible extension values include DIGITAL_SIGNATURE, KEY_ENCHIPHERMENT, NON_REPUDIATION,
    /// and more.
    /// </summary>
    [JsonPropertyName("keyUsages")]
    public IList<V1alpha1CertificateStatusKeyUsages>? KeyUsages { get; set; }

    /// <summary>The time after which the certificate is not valid.</summary>
    [JsonPropertyName("notAfter")]
    public DateTime? NotAfter { get; set; }

    /// <summary>The time before which the certificate is not valid.</summary>
    [JsonPropertyName("notBefore")]
    public DateTime? NotBefore { get; set; }

    /// <summary>
    /// Specifies whether the certificate is eligible for renewal. At this time,
    /// only exported private certificates can be renewed with the RenewCertificate
    /// command.
    /// </summary>
    [JsonPropertyName("renewalEligibility")]
    public string? RenewalEligibility { get; set; }

    /// <summary>
    /// Contains information about the status of ACM&apos;s managed renewal (https://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html)
    /// for the certificate. This field exists only when the certificate type is
    /// AMAZON_ISSUED.
    /// </summary>
    [JsonPropertyName("renewalSummary")]
    public V1alpha1CertificateStatusRenewalSummary? RenewalSummary { get; set; }

    /// <summary>
    /// The reason the certificate was revoked. This value exists only when the certificate
    /// status is REVOKED.
    /// </summary>
    [JsonPropertyName("revocationReason")]
    public string? RevocationReason { get; set; }

    /// <summary>
    /// The time at which the certificate was revoked. This value exists only when
    /// the certificate status is REVOKED.
    /// </summary>
    [JsonPropertyName("revokedAt")]
    public DateTime? RevokedAt { get; set; }

    /// <summary>The serial number of the certificate.</summary>
    [JsonPropertyName("serial")]
    public string? Serial { get; set; }

    /// <summary>The algorithm that was used to sign the certificate.</summary>
    [JsonPropertyName("signatureAlgorithm")]
    public string? SignatureAlgorithm { get; set; }

    /// <summary>
    /// The status of the certificate.
    /// 
    /// A certificate enters status PENDING_VALIDATION upon being requested, unless
    /// it fails for any of the reasons given in the troubleshooting topic Certificate
    /// request fails (https://docs.aws.amazon.com/acm/latest/userguide/troubleshooting-failed.html).
    /// ACM makes repeated attempts to validate a certificate for 72 hours and then
    /// times out. If a certificate shows status FAILED or VALIDATION_TIMED_OUT,
    /// delete the request, correct the issue with DNS validation (https://docs.aws.amazon.com/acm/latest/userguide/dns-validation.html)
    /// or Email validation (https://docs.aws.amazon.com/acm/latest/userguide/email-validation.html),
    /// and try again. If validation succeeds, the certificate enters status ISSUED.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>
    /// The name of the entity that is associated with the public key contained in
    /// the certificate.
    /// </summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>
    /// The source of the certificate. For certificates provided by ACM, this value
    /// is AMAZON_ISSUED. For certificates that you imported with ImportCertificate,
    /// this value is IMPORTED. ACM does not provide managed renewal (https://docs.aws.amazon.com/acm/latest/userguide/acm-renewal.html)
    /// for imported certificates. For more information about the differences between
    /// certificates that you import and those that ACM provides, see Importing Certificates
    /// (https://docs.aws.amazon.com/acm/latest/userguide/import-certificate.html)
    /// in the Certificate Manager User Guide.
    /// </summary>
    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>Certificate is the Schema for the Certificates API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Certificate : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1CertificateSpec?>, IStatus<V1alpha1CertificateStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Certificate";
    public const string KubeGroup = "acm.services.k8s.aws";
    public const string KubePluralName = "certificates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "acm.services.k8s.aws/v1alpha1";

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