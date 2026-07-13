#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.certmanager.io;
/// <summary>
/// A Certificate resource should be created to ensure an up to date and signed
/// X.509 certificate is stored in the Kubernetes Secret resource named in `spec.secretName`.
/// 
/// The stored certificate will be renewed before it expires (as configured by `spec.renewBefore`).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1CertificateList : IKubernetesObject<V1ListMeta>, IItems<V1Certificate>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "CertificateList";
    public const string KubeGroup = "cert-manager.io";
    public const string KubePluralName = "certificates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cert-manager.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CertificateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1Certificate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1Certificate> Items { get; set; }
}

/// <summary>
/// Type is the name of the format type that should be written to the
/// Certificate&apos;s target Secret.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CertificateSpecAdditionalOutputFormatsTypeEnum>))]
public enum V1CertificateSpecAdditionalOutputFormatsTypeEnum
{
    [EnumMember(Value = "DER"), JsonStringEnumMemberName("DER")]
    DER,
    [EnumMember(Value = "CombinedPEM"), JsonStringEnumMemberName("CombinedPEM")]
    CombinedPEM
}

/// <summary>
/// CertificateAdditionalOutputFormat defines an additional output format of a
/// Certificate resource. These contain supplementary data formats of the signed
/// certificate chain and paired private key.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecAdditionalOutputFormats
{
    /// <summary>
    /// Type is the name of the format type that should be written to the
    /// Certificate&apos;s target Secret.
    /// </summary>
    [JsonPropertyName("type")]
    public required V1CertificateSpecAdditionalOutputFormatsTypeEnum Type { get; set; }
}

/// <summary>
/// Reference to the issuer responsible for issuing the certificate.
/// If the issuer is namespace-scoped, it must be in the same namespace
/// as the Certificate. If the issuer is cluster-scoped, it can be used
/// from any namespace.
/// 
/// The `name` field of the reference must always be specified.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecIssuerRef
{
    /// <summary>
    /// Group of the issuer being referred to.
    /// Defaults to &apos;cert-manager.io&apos;.
    /// </summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>
    /// Kind of the issuer being referred to.
    /// Defaults to &apos;Issuer&apos;.
    /// </summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name of the issuer being referred to.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// PasswordSecretRef is a reference to a non-empty key in a Secret resource
/// containing the password used to encrypt the JKS keystore.
/// Mutually exclusive with password.
/// One of password or passwordSecretRef must provide a password with a non-zero length.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecKeystoresJksPasswordSecretRef
{
    /// <summary>
    /// The key of the entry in the Secret resource&apos;s `data` field to be used.
    /// Some instances of this field may be defaulted, in others it may be
    /// required.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// Name of the resource being referred to.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// JKS configures options for storing a JKS keystore in the
/// `spec.secretName` Secret resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecKeystoresJks
{
    /// <summary>
    /// Alias specifies the alias of the key in the keystore, required by the JKS format.
    /// If not provided, the default alias `certificate` will be used.
    /// </summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    /// <summary>
    /// Create enables JKS keystore creation for the Certificate.
    /// If true, a file named `keystore.jks` will be created in the target
    /// Secret resource, encrypted using the password stored in
    /// `passwordSecretRef` or `password`.
    /// The keystore file will be updated immediately.
    /// If the issuer provided a CA certificate, a file named `truststore.jks`
    /// will also be created in the target Secret resource, encrypted using the
    /// password stored in `passwordSecretRef`
    /// containing the issuing Certificate Authority
    /// </summary>
    [JsonPropertyName("create")]
    public required bool Create { get; set; }

    /// <summary>
    /// Password provides a literal password used to encrypt the JKS keystore.
    /// Mutually exclusive with passwordSecretRef.
    /// One of password or passwordSecretRef must provide a password with a non-zero length.
    /// </summary>
    [JsonPropertyName("password")]
    public string? Password { get; set; }

    /// <summary>
    /// PasswordSecretRef is a reference to a non-empty key in a Secret resource
    /// containing the password used to encrypt the JKS keystore.
    /// Mutually exclusive with password.
    /// One of password or passwordSecretRef must provide a password with a non-zero length.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1CertificateSpecKeystoresJksPasswordSecretRef? PasswordSecretRef { get; set; }
}

/// <summary>
/// PasswordSecretRef is a reference to a non-empty key in a Secret resource
/// containing the password used to encrypt the PKCS#12 keystore.
/// Mutually exclusive with password.
/// One of password or passwordSecretRef must provide a password with a non-zero length.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecKeystoresPkcs12PasswordSecretRef
{
    /// <summary>
    /// The key of the entry in the Secret resource&apos;s `data` field to be used.
    /// Some instances of this field may be defaulted, in others it may be
    /// required.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// Name of the resource being referred to.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Profile specifies the key and certificate encryption algorithms and the HMAC algorithm
/// used to create the PKCS12 keystore. Default value is `LegacyRC2` for backward compatibility.
/// 
/// If provided, allowed values are:
/// `LegacyRC2`: Deprecated. Not supported by default in OpenSSL 3 or Java 20.
/// `LegacyDES`: Less secure algorithm. Use this option for maximal compatibility.
/// `Modern2023`: Secure algorithm. Use this option in case you have to always use secure algorithms
/// (e.g., because of company policy). Please note that the security of the algorithm is not that important
/// in reality, because the unencrypted certificate and private key are also stored in the Secret.
/// `Modern2026`: Encodes PKCS#12 files using algorithms that are considered modern as of 2026.
/// Private keys and certificates are encrypted using PBES2 with PBKDF2-HMAC-SHA-256 and AES-256-CBC.
/// The MAC algorithm is PBMAC1 with PBKDF2-HMAC-SHA-256 and HMAC-SHA256.
/// Files produced with this profile can be read by OpenSSL 3.4.0 and higher, Java 26 and higher,
/// or with Java using compatible versions of Bouncy Castle. Meets FIPS 140-3 requirements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CertificateSpecKeystoresPkcs12ProfileEnum>))]
public enum V1CertificateSpecKeystoresPkcs12ProfileEnum
{
    [EnumMember(Value = "LegacyRC2"), JsonStringEnumMemberName("LegacyRC2")]
    LegacyRC2,
    [EnumMember(Value = "LegacyDES"), JsonStringEnumMemberName("LegacyDES")]
    LegacyDES,
    [EnumMember(Value = "Modern2023"), JsonStringEnumMemberName("Modern2023")]
    Modern2023,
    [EnumMember(Value = "Modern2026"), JsonStringEnumMemberName("Modern2026")]
    Modern2026
}

/// <summary>
/// PKCS12 configures options for storing a PKCS12 keystore in the
/// `spec.secretName` Secret resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecKeystoresPkcs12
{
    /// <summary>
    /// Create enables PKCS12 keystore creation for the Certificate.
    /// If true, a file named `keystore.p12` will be created in the target
    /// Secret resource, encrypted using the password stored in
    /// `passwordSecretRef` or in `password`.
    /// The keystore file will be updated immediately.
    /// If the issuer provided a CA certificate, a file named `truststore.p12` will
    /// also be created in the target Secret resource, encrypted using the
    /// password stored in `passwordSecretRef` containing the issuing Certificate
    /// Authority
    /// </summary>
    [JsonPropertyName("create")]
    public required bool Create { get; set; }

    /// <summary>
    /// Password provides a literal password used to encrypt the PKCS#12 keystore.
    /// Mutually exclusive with passwordSecretRef.
    /// One of password or passwordSecretRef must provide a password with a non-zero length.
    /// </summary>
    [JsonPropertyName("password")]
    public string? Password { get; set; }

    /// <summary>
    /// PasswordSecretRef is a reference to a non-empty key in a Secret resource
    /// containing the password used to encrypt the PKCS#12 keystore.
    /// Mutually exclusive with password.
    /// One of password or passwordSecretRef must provide a password with a non-zero length.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1CertificateSpecKeystoresPkcs12PasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// Profile specifies the key and certificate encryption algorithms and the HMAC algorithm
    /// used to create the PKCS12 keystore. Default value is `LegacyRC2` for backward compatibility.
    /// 
    /// If provided, allowed values are:
    /// `LegacyRC2`: Deprecated. Not supported by default in OpenSSL 3 or Java 20.
    /// `LegacyDES`: Less secure algorithm. Use this option for maximal compatibility.
    /// `Modern2023`: Secure algorithm. Use this option in case you have to always use secure algorithms
    /// (e.g., because of company policy). Please note that the security of the algorithm is not that important
    /// in reality, because the unencrypted certificate and private key are also stored in the Secret.
    /// `Modern2026`: Encodes PKCS#12 files using algorithms that are considered modern as of 2026.
    /// Private keys and certificates are encrypted using PBES2 with PBKDF2-HMAC-SHA-256 and AES-256-CBC.
    /// The MAC algorithm is PBMAC1 with PBKDF2-HMAC-SHA-256 and HMAC-SHA256.
    /// Files produced with this profile can be read by OpenSSL 3.4.0 and higher, Java 26 and higher,
    /// or with Java using compatible versions of Bouncy Castle. Meets FIPS 140-3 requirements.
    /// </summary>
    [JsonPropertyName("profile")]
    public V1CertificateSpecKeystoresPkcs12ProfileEnum? Profile { get; set; }
}

/// <summary>Additional keystore output formats to be stored in the Certificate&apos;s Secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecKeystores
{
    /// <summary>
    /// JKS configures options for storing a JKS keystore in the
    /// `spec.secretName` Secret resource.
    /// </summary>
    [JsonPropertyName("jks")]
    public V1CertificateSpecKeystoresJks? Jks { get; set; }

    /// <summary>
    /// PKCS12 configures options for storing a PKCS12 keystore in the
    /// `spec.secretName` Secret resource.
    /// </summary>
    [JsonPropertyName("pkcs12")]
    public V1CertificateSpecKeystoresPkcs12? Pkcs12 { get; set; }
}

/// <summary>
/// Excluded contains the constraints which must be disallowed. Any name matching a
/// restriction in the excluded field is invalid regardless
/// of information appearing in the permitted
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecNameConstraintsExcluded
{
    /// <summary>DNSDomains is a list of DNS domains that are permitted or excluded.</summary>
    [JsonPropertyName("dnsDomains")]
    public IList<string>? DnsDomains { get; set; }

    /// <summary>EmailAddresses is a list of Email Addresses that are permitted or excluded.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>
    /// IPRanges is a list of IP Ranges that are permitted or excluded.
    /// This should be a valid CIDR notation.
    /// </summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }

    /// <summary>URIDomains is a list of URI domains that are permitted or excluded.</summary>
    [JsonPropertyName("uriDomains")]
    public IList<string>? UriDomains { get; set; }
}

/// <summary>Permitted contains the constraints in which the names must be located.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecNameConstraintsPermitted
{
    /// <summary>DNSDomains is a list of DNS domains that are permitted or excluded.</summary>
    [JsonPropertyName("dnsDomains")]
    public IList<string>? DnsDomains { get; set; }

    /// <summary>EmailAddresses is a list of Email Addresses that are permitted or excluded.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>
    /// IPRanges is a list of IP Ranges that are permitted or excluded.
    /// This should be a valid CIDR notation.
    /// </summary>
    [JsonPropertyName("ipRanges")]
    public IList<string>? IpRanges { get; set; }

    /// <summary>URIDomains is a list of URI domains that are permitted or excluded.</summary>
    [JsonPropertyName("uriDomains")]
    public IList<string>? UriDomains { get; set; }
}

/// <summary>
/// x.509 certificate NameConstraint extension which MUST NOT be used in a non-CA certificate.
/// More Info: https://datatracker.ietf.org/doc/html/rfc5280#section-4.2.1.10
/// 
/// This is an Alpha Feature and is only enabled with the
/// `--feature-gates=NameConstraints=true` option set on both
/// the controller and webhook components.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecNameConstraints
{
    /// <summary>if true then the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>
    /// Excluded contains the constraints which must be disallowed. Any name matching a
    /// restriction in the excluded field is invalid regardless
    /// of information appearing in the permitted
    /// </summary>
    [JsonPropertyName("excluded")]
    public V1CertificateSpecNameConstraintsExcluded? Excluded { get; set; }

    /// <summary>Permitted contains the constraints in which the names must be located.</summary>
    [JsonPropertyName("permitted")]
    public V1CertificateSpecNameConstraintsPermitted? Permitted { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecOtherNames
{
    /// <summary>
    /// OID is the object identifier for the otherName SAN.
    /// The object identifier must be expressed as a dotted string, for
    /// example, &quot;1.2.840.113556.1.4.221&quot;.
    /// </summary>
    [JsonPropertyName("oid")]
    public string? Oid { get; set; }

    /// <summary>
    /// utf8Value is the string value of the otherName SAN.
    /// The utf8Value accepts any valid UTF8 string to set as value for the otherName SAN.
    /// </summary>
    [JsonPropertyName("utf8Value")]
    public string? Utf8Value { get; set; }
}

/// <summary>
/// Algorithm is the private key algorithm of the corresponding private key
/// for this certificate.
/// 
/// If provided, allowed values are either `RSA`, `ECDSA` or `Ed25519`.
/// If `algorithm` is specified and `size` is not provided,
/// key size of 2048 will be used for `RSA` key algorithm and
/// key size of 256 will be used for `ECDSA` key algorithm.
/// key size is ignored when using the `Ed25519` key algorithm.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CertificateSpecPrivateKeyAlgorithmEnum>))]
public enum V1CertificateSpecPrivateKeyAlgorithmEnum
{
    [EnumMember(Value = "RSA"), JsonStringEnumMemberName("RSA")]
    RSA,
    [EnumMember(Value = "ECDSA"), JsonStringEnumMemberName("ECDSA")]
    ECDSA,
    [EnumMember(Value = "Ed25519"), JsonStringEnumMemberName("Ed25519")]
    Ed25519
}

/// <summary>
/// The private key cryptography standards (PKCS) encoding for this
/// certificate&apos;s private key to be encoded in.
/// 
/// If provided, allowed values are `PKCS1` and `PKCS8` standing for PKCS#1
/// and PKCS#8, respectively.
/// Defaults to `PKCS1` if not specified.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CertificateSpecPrivateKeyEncodingEnum>))]
public enum V1CertificateSpecPrivateKeyEncodingEnum
{
    [EnumMember(Value = "PKCS1"), JsonStringEnumMemberName("PKCS1")]
    PKCS1,
    [EnumMember(Value = "PKCS8"), JsonStringEnumMemberName("PKCS8")]
    PKCS8
}

/// <summary>
/// RotationPolicy controls how private keys should be regenerated when a
/// re-issuance is being processed.
/// 
/// If set to `Never`, a private key will only be generated if one does not
/// already exist in the target `spec.secretName`. If one does exist but it
/// does not have the correct algorithm or size, a warning will be raised
/// to await user intervention.
/// If set to `Always`, a private key matching the specified requirements
/// will be generated whenever a re-issuance occurs.
/// Default is `Always`.
/// The default was changed from `Never` to `Always` in cert-manager &gt;=v1.18.0.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CertificateSpecPrivateKeyRotationPolicyEnum>))]
public enum V1CertificateSpecPrivateKeyRotationPolicyEnum
{
    [EnumMember(Value = "Never"), JsonStringEnumMemberName("Never")]
    Never,
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always
}

/// <summary>
/// Private key options. These include the key algorithm and size, the used
/// encoding and the rotation policy.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecPrivateKey
{
    /// <summary>
    /// Algorithm is the private key algorithm of the corresponding private key
    /// for this certificate.
    /// 
    /// If provided, allowed values are either `RSA`, `ECDSA` or `Ed25519`.
    /// If `algorithm` is specified and `size` is not provided,
    /// key size of 2048 will be used for `RSA` key algorithm and
    /// key size of 256 will be used for `ECDSA` key algorithm.
    /// key size is ignored when using the `Ed25519` key algorithm.
    /// </summary>
    [JsonPropertyName("algorithm")]
    public V1CertificateSpecPrivateKeyAlgorithmEnum? Algorithm { get; set; }

    /// <summary>
    /// The private key cryptography standards (PKCS) encoding for this
    /// certificate&apos;s private key to be encoded in.
    /// 
    /// If provided, allowed values are `PKCS1` and `PKCS8` standing for PKCS#1
    /// and PKCS#8, respectively.
    /// Defaults to `PKCS1` if not specified.
    /// </summary>
    [JsonPropertyName("encoding")]
    public V1CertificateSpecPrivateKeyEncodingEnum? Encoding { get; set; }

    /// <summary>
    /// RotationPolicy controls how private keys should be regenerated when a
    /// re-issuance is being processed.
    /// 
    /// If set to `Never`, a private key will only be generated if one does not
    /// already exist in the target `spec.secretName`. If one does exist but it
    /// does not have the correct algorithm or size, a warning will be raised
    /// to await user intervention.
    /// If set to `Always`, a private key matching the specified requirements
    /// will be generated whenever a re-issuance occurs.
    /// Default is `Always`.
    /// The default was changed from `Never` to `Always` in cert-manager &gt;=v1.18.0.
    /// </summary>
    [JsonPropertyName("rotationPolicy")]
    public V1CertificateSpecPrivateKeyRotationPolicyEnum? RotationPolicy { get; set; }

    /// <summary>
    /// Size is the key bit size of the corresponding private key for this certificate.
    /// 
    /// If `algorithm` is set to `RSA`, valid values are `2048`, `4096` or `8192`,
    /// and will default to `2048` if not specified.
    /// If `algorithm` is set to `ECDSA`, valid values are `256`, `384` or `521`,
    /// and will default to `256` if not specified.
    /// If `algorithm` is set to `Ed25519`, Size is ignored.
    /// No other values are allowed.
    /// </summary>
    [JsonPropertyName("size")]
    public int? Size { get; set; }
}

/// <summary>`policy` must be one of `Disabled`, `RenewBefore`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CertificateSpecRenewalPolicyEnum>))]
public enum V1CertificateSpecRenewalPolicyEnum
{
    [EnumMember(Value = "RenewBefore"), JsonStringEnumMemberName("RenewBefore")]
    RenewBefore,
    [EnumMember(Value = "Disabled"), JsonStringEnumMemberName("Disabled")]
    Disabled
}

/// <summary>CertificateRenewalWindows is the definition for renewal windows</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecRenewalWindows
{
    /// <summary>
    /// `cron` is a cron compliant string to allow when the renewal should be allowed. Format is as shown below:
    /// * * * * *
    /// | | | | |
    /// | | | | day of the week (0–6) (Sunday to Saturday;
    /// | | | month (1–12)             7 is also Sunday on some systems)
    /// | | day of the month (1–31)
    /// | hour (0–23)
    /// minute (0–59)
    /// </summary>
    [JsonPropertyName("cron")]
    public required string Cron { get; set; }

    /// <summary>
    /// `timezone` is IANA compliant timezone. For example America/Denver.
    /// If this field is not set, timezone is treated as UTC.
    /// </summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>
    /// `windowDuration` is how long the cron definition is active for.
    /// Value must be in units accepted by Go time.ParseDuration https://golang.org/pkg/time/#ParseDuration.
    /// </summary>
    [JsonPropertyName("windowDuration")]
    public required string WindowDuration { get; set; }
}

/// <summary>
/// `renewal` allows configuration of how your certificate is renewed. If the policy mentioned is
/// `RenewBefore` then the controller respects `renewBefore` and `renewBeforePercentage`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecRenewal
{
    /// <summary>`policy` must be one of `Disabled`, `RenewBefore`.</summary>
    [JsonPropertyName("policy")]
    public V1CertificateSpecRenewalPolicyEnum? Policy { get; set; }

    /// <summary>`windows` mentions the behavior of when the renewal must happen.</summary>
    [JsonPropertyName("windows")]
    public IList<V1CertificateSpecRenewalWindows>? Windows { get; set; }
}

/// <summary>
/// Defines annotations and labels to be copied to the Certificate&apos;s Secret.
/// Labels and annotations on the Secret will be changed as they appear on the
/// SecretTemplate when added or removed. SecretTemplate annotations are added
/// in conjunction with, and cannot overwrite, the base set of annotations
/// cert-manager sets on the Certificate&apos;s Secret.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecSecretTemplate
{
    /// <summary>Annotations is a key value map to be copied to the target Kubernetes Secret.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Labels is a key value map to be copied to the target Kubernetes Secret.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

/// <summary>
/// Signature algorithm to use.
/// Allowed values for RSA keys: SHA256WithRSA, SHA384WithRSA, SHA512WithRSA.
/// Allowed values for ECDSA keys: ECDSAWithSHA256, ECDSAWithSHA384, ECDSAWithSHA512.
/// Allowed values for Ed25519 keys: PureEd25519.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CertificateSpecSignatureAlgorithmEnum>))]
public enum V1CertificateSpecSignatureAlgorithmEnum
{
    [EnumMember(Value = "SHA256WithRSA"), JsonStringEnumMemberName("SHA256WithRSA")]
    SHA256WithRSA,
    [EnumMember(Value = "SHA384WithRSA"), JsonStringEnumMemberName("SHA384WithRSA")]
    SHA384WithRSA,
    [EnumMember(Value = "SHA512WithRSA"), JsonStringEnumMemberName("SHA512WithRSA")]
    SHA512WithRSA,
    [EnumMember(Value = "ECDSAWithSHA256"), JsonStringEnumMemberName("ECDSAWithSHA256")]
    ECDSAWithSHA256,
    [EnumMember(Value = "ECDSAWithSHA384"), JsonStringEnumMemberName("ECDSAWithSHA384")]
    ECDSAWithSHA384,
    [EnumMember(Value = "ECDSAWithSHA512"), JsonStringEnumMemberName("ECDSAWithSHA512")]
    ECDSAWithSHA512,
    [EnumMember(Value = "PureEd25519"), JsonStringEnumMemberName("PureEd25519")]
    PureEd25519
}

/// <summary>
/// Requested set of X509 certificate subject attributes.
/// More info: https://datatracker.ietf.org/doc/html/rfc5280#section-4.1.2.6
/// 
/// The common name attribute is specified separately in the `commonName` field.
/// Cannot be set if the `literalSubject` field is set.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpecSubject
{
    /// <summary>Countries to be used on the Certificate.</summary>
    [JsonPropertyName("countries")]
    public IList<string>? Countries { get; set; }

    /// <summary>Cities to be used on the Certificate.</summary>
    [JsonPropertyName("localities")]
    public IList<string>? Localities { get; set; }

    /// <summary>Organizational Units to be used on the Certificate.</summary>
    [JsonPropertyName("organizationalUnits")]
    public IList<string>? OrganizationalUnits { get; set; }

    /// <summary>Organizations to be used on the Certificate.</summary>
    [JsonPropertyName("organizations")]
    public IList<string>? Organizations { get; set; }

    /// <summary>Postal codes to be used on the Certificate.</summary>
    [JsonPropertyName("postalCodes")]
    public IList<string>? PostalCodes { get; set; }

    /// <summary>State/Provinces to be used on the Certificate.</summary>
    [JsonPropertyName("provinces")]
    public IList<string>? Provinces { get; set; }

    /// <summary>Serial number to be used on the Certificate.</summary>
    [JsonPropertyName("serialNumber")]
    public string? SerialNumber { get; set; }

    /// <summary>Street addresses to be used on the Certificate.</summary>
    [JsonPropertyName("streetAddresses")]
    public IList<string>? StreetAddresses { get; set; }
}

/// <summary>
/// KeyUsage specifies valid usage contexts for keys.
/// See:
/// https://tools.ietf.org/html/rfc5280#section-4.2.1.3
/// https://tools.ietf.org/html/rfc5280#section-4.2.1.12
/// 
/// Valid KeyUsage values are as follows:
/// &quot;signing&quot;,
/// &quot;digital signature&quot;,
/// &quot;content commitment&quot;,
/// &quot;key encipherment&quot;,
/// &quot;key agreement&quot;,
/// &quot;data encipherment&quot;,
/// &quot;cert sign&quot;,
/// &quot;crl sign&quot;,
/// &quot;encipher only&quot;,
/// &quot;decipher only&quot;,
/// &quot;any&quot;,
/// &quot;server auth&quot;,
/// &quot;client auth&quot;,
/// &quot;code signing&quot;,
/// &quot;email protection&quot;,
/// &quot;s/mime&quot;,
/// &quot;ipsec end system&quot;,
/// &quot;ipsec tunnel&quot;,
/// &quot;ipsec user&quot;,
/// &quot;timestamping&quot;,
/// &quot;ocsp signing&quot;,
/// &quot;microsoft sgc&quot;,
/// &quot;netscape sgc&quot;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CertificateSpecUsagesEnum>))]
public enum V1CertificateSpecUsagesEnum
{
    [EnumMember(Value = "signing"), JsonStringEnumMemberName("signing")]
    Signing,
    [EnumMember(Value = "digital signature"), JsonStringEnumMemberName("digital signature")]
    DigitalSignature,
    [EnumMember(Value = "content commitment"), JsonStringEnumMemberName("content commitment")]
    ContentCommitment,
    [EnumMember(Value = "key encipherment"), JsonStringEnumMemberName("key encipherment")]
    KeyEncipherment,
    [EnumMember(Value = "key agreement"), JsonStringEnumMemberName("key agreement")]
    KeyAgreement,
    [EnumMember(Value = "data encipherment"), JsonStringEnumMemberName("data encipherment")]
    DataEncipherment,
    [EnumMember(Value = "cert sign"), JsonStringEnumMemberName("cert sign")]
    CertSign,
    [EnumMember(Value = "crl sign"), JsonStringEnumMemberName("crl sign")]
    CrlSign,
    [EnumMember(Value = "encipher only"), JsonStringEnumMemberName("encipher only")]
    EncipherOnly,
    [EnumMember(Value = "decipher only"), JsonStringEnumMemberName("decipher only")]
    DecipherOnly,
    [EnumMember(Value = "any"), JsonStringEnumMemberName("any")]
    Any,
    [EnumMember(Value = "server auth"), JsonStringEnumMemberName("server auth")]
    ServerAuth,
    [EnumMember(Value = "client auth"), JsonStringEnumMemberName("client auth")]
    ClientAuth,
    [EnumMember(Value = "code signing"), JsonStringEnumMemberName("code signing")]
    CodeSigning,
    [EnumMember(Value = "email protection"), JsonStringEnumMemberName("email protection")]
    EmailProtection,
    [EnumMember(Value = "s/mime"), JsonStringEnumMemberName("s/mime")]
    SMime,
    [EnumMember(Value = "ipsec end system"), JsonStringEnumMemberName("ipsec end system")]
    IpsecEndSystem,
    [EnumMember(Value = "ipsec tunnel"), JsonStringEnumMemberName("ipsec tunnel")]
    IpsecTunnel,
    [EnumMember(Value = "ipsec user"), JsonStringEnumMemberName("ipsec user")]
    IpsecUser,
    [EnumMember(Value = "timestamping"), JsonStringEnumMemberName("timestamping")]
    Timestamping,
    [EnumMember(Value = "ocsp signing"), JsonStringEnumMemberName("ocsp signing")]
    OcspSigning,
    [EnumMember(Value = "microsoft sgc"), JsonStringEnumMemberName("microsoft sgc")]
    MicrosoftSgc,
    [EnumMember(Value = "netscape sgc"), JsonStringEnumMemberName("netscape sgc")]
    NetscapeSgc
}

/// <summary>
/// Specification of the desired state of the Certificate resource.
/// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateSpec
{
    /// <summary>
    /// Defines extra output formats of the private key and signed certificate chain
    /// to be written to this Certificate&apos;s target Secret.
    /// </summary>
    [JsonPropertyName("additionalOutputFormats")]
    public IList<V1CertificateSpecAdditionalOutputFormats>? AdditionalOutputFormats { get; set; }

    /// <summary>
    /// Requested common name X509 certificate subject attribute.
    /// More info: https://datatracker.ietf.org/doc/html/rfc5280#section-4.1.2.6
    /// NOTE: TLS clients will ignore this value when any subject alternative name is
    /// set (see https://tools.ietf.org/html/rfc6125#section-6.4.4).
    /// 
    /// Should have a length of 64 characters or fewer to avoid generating invalid CSRs.
    /// Cannot be set if the `literalSubject` field is set.
    /// </summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>Requested DNS subject alternative names.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string>? DnsNames { get; set; }

    /// <summary>
    /// Requested &apos;duration&apos; (i.e. lifetime) of the Certificate. Note that the
    /// issuer may choose to ignore the requested duration, just like any other
    /// requested attribute.
    /// 
    /// If unset, this defaults to 90 days.
    /// Minimum accepted duration is 1 hour.
    /// Value must be in units accepted by Go time.ParseDuration https://golang.org/pkg/time/#ParseDuration.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>Requested email subject alternative names.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>
    /// Whether the KeyUsage and ExtKeyUsage extensions should be set in the encoded CSR.
    /// 
    /// This option defaults to true, and should only be disabled if the target
    /// issuer does not support CSRs with these X509 KeyUsage/ ExtKeyUsage extensions.
    /// </summary>
    [JsonPropertyName("encodeUsagesInRequest")]
    public bool? EncodeUsagesInRequest { get; set; }

    /// <summary>Requested IP address subject alternative names.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>
    /// Requested basic constraints isCA value.
    /// The isCA value is used to set the `isCA` field on the created CertificateRequest
    /// resources. Note that the issuer may choose to ignore the requested isCA value, just
    /// like any other requested attribute.
    /// 
    /// If true, this will automatically add the `cert sign` usage to the list
    /// of requested `usages`.
    /// </summary>
    [JsonPropertyName("isCA")]
    public bool? IsCA { get; set; }

    /// <summary>
    /// Reference to the issuer responsible for issuing the certificate.
    /// If the issuer is namespace-scoped, it must be in the same namespace
    /// as the Certificate. If the issuer is cluster-scoped, it can be used
    /// from any namespace.
    /// 
    /// The `name` field of the reference must always be specified.
    /// </summary>
    [JsonPropertyName("issuerRef")]
    public required V1CertificateSpecIssuerRef IssuerRef { get; set; }

    /// <summary>Additional keystore output formats to be stored in the Certificate&apos;s Secret.</summary>
    [JsonPropertyName("keystores")]
    public V1CertificateSpecKeystores? Keystores { get; set; }

    /// <summary>
    /// Requested X.509 certificate subject, represented using the LDAP &quot;String
    /// Representation of a Distinguished Name&quot; [1].
    /// Important: the LDAP string format also specifies the order of the attributes
    /// in the subject, this is important when issuing certs for LDAP authentication.
    /// Example: `CN=foo,DC=corp,DC=example,DC=com`
    /// More info [1]: https://datatracker.ietf.org/doc/html/rfc4514
    /// More info: https://github.com/cert-manager/cert-manager/issues/3203
    /// More info: https://github.com/cert-manager/cert-manager/issues/4424
    /// 
    /// Cannot be set if the `subject` or `commonName` field is set.
    /// </summary>
    [JsonPropertyName("literalSubject")]
    public string? LiteralSubject { get; set; }

    /// <summary>
    /// x.509 certificate NameConstraint extension which MUST NOT be used in a non-CA certificate.
    /// More Info: https://datatracker.ietf.org/doc/html/rfc5280#section-4.2.1.10
    /// 
    /// This is an Alpha Feature and is only enabled with the
    /// `--feature-gates=NameConstraints=true` option set on both
    /// the controller and webhook components.
    /// </summary>
    [JsonPropertyName("nameConstraints")]
    public V1CertificateSpecNameConstraints? NameConstraints { get; set; }

    /// <summary>
    /// `otherNames` is an escape hatch for SAN that allows any type. We currently restrict the support to string like otherNames, cf RFC 5280 p 37
    /// Any UTF8 String valued otherName can be passed with by setting the keys oid: x.x.x.x and UTF8Value: somevalue for `otherName`.
    /// Most commonly this would be UPN set with oid: 1.3.6.1.4.1.311.20.2.3
    /// You should ensure that any OID passed is valid for the UTF8String type as we do not explicitly validate this.
    /// </summary>
    [JsonPropertyName("otherNames")]
    public IList<V1CertificateSpecOtherNames>? OtherNames { get; set; }

    /// <summary>
    /// Private key options. These include the key algorithm and size, the used
    /// encoding and the rotation policy.
    /// </summary>
    [JsonPropertyName("privateKey")]
    public V1CertificateSpecPrivateKey? PrivateKey { get; set; }

    /// <summary>
    /// How long before the currently issued certificate&apos;s expiry cert-manager should
    /// renew the certificate. For example, if a certificate is valid for 60 minutes,
    /// and `renewBefore=10m`, cert-manager will begin to attempt to renew the certificate
    /// 50 minutes after it was issued (i.e. when there are 10 minutes remaining until
    /// the certificate is no longer valid).
    /// 
    /// NOTE: The actual lifetime of the issued certificate is used to determine the
    /// renewal time. If an issuer returns a certificate with a different lifetime than
    /// the one requested, cert-manager will use the lifetime of the issued certificate.
    /// 
    /// If unset, this defaults to 1/3 of the issued certificate&apos;s lifetime.
    /// Minimum accepted value is 5 minutes.
    /// Value must be in units accepted by Go time.ParseDuration https://golang.org/pkg/time/#ParseDuration.
    /// Cannot be set if the `renewBeforePercentage` field is set.
    /// </summary>
    [JsonPropertyName("renewBefore")]
    public string? RenewBefore { get; set; }

    /// <summary>
    /// `renewBeforePercentage` is like `renewBefore`, except it is a relative percentage
    /// rather than an absolute duration. For example, if a certificate is valid for 60
    /// minutes, and  `renewBeforePercentage=25`, cert-manager will begin to attempt to
    /// renew the certificate 45 minutes after it was issued (i.e. when there are 15
    /// minutes (25%) remaining until the certificate is no longer valid).
    /// 
    /// NOTE: The actual lifetime of the issued certificate is used to determine the
    /// renewal time. If an issuer returns a certificate with a different lifetime than
    /// the one requested, cert-manager will use the lifetime of the issued certificate.
    /// 
    /// Value must be an integer in the range (0,100). The minimum effective
    /// `renewBefore` derived from the `renewBeforePercentage` and `duration` fields is 5
    /// minutes.
    /// Cannot be set if the `renewBefore` field is set.
    /// </summary>
    [JsonPropertyName("renewBeforePercentage")]
    public int? RenewBeforePercentage { get; set; }

    /// <summary>
    /// `renewal` allows configuration of how your certificate is renewed. If the policy mentioned is
    /// `RenewBefore` then the controller respects `renewBefore` and `renewBeforePercentage`.
    /// </summary>
    [JsonPropertyName("renewal")]
    public V1CertificateSpecRenewal? Renewal { get; set; }

    /// <summary>
    /// The maximum number of CertificateRequest revisions that are maintained in
    /// the Certificate&apos;s history. Each revision represents a single `CertificateRequest`
    /// created by this Certificate, either when it was created, renewed, or Spec
    /// was changed. Revisions will be removed by oldest first if the number of
    /// revisions exceeds this number.
    /// 
    /// If set, revisionHistoryLimit must be a value of `1` or greater.
    /// Default value is `1`.
    /// </summary>
    [JsonPropertyName("revisionHistoryLimit")]
    public int? RevisionHistoryLimit { get; set; }

    /// <summary>
    /// Name of the Secret resource that will be automatically created and
    /// managed by this Certificate resource. It will be populated with a
    /// private key and certificate, signed by the denoted issuer. The Secret
    /// resource lives in the same namespace as the Certificate resource.
    /// </summary>
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }

    /// <summary>
    /// Defines annotations and labels to be copied to the Certificate&apos;s Secret.
    /// Labels and annotations on the Secret will be changed as they appear on the
    /// SecretTemplate when added or removed. SecretTemplate annotations are added
    /// in conjunction with, and cannot overwrite, the base set of annotations
    /// cert-manager sets on the Certificate&apos;s Secret.
    /// </summary>
    [JsonPropertyName("secretTemplate")]
    public V1CertificateSpecSecretTemplate? SecretTemplate { get; set; }

    /// <summary>
    /// Signature algorithm to use.
    /// Allowed values for RSA keys: SHA256WithRSA, SHA384WithRSA, SHA512WithRSA.
    /// Allowed values for ECDSA keys: ECDSAWithSHA256, ECDSAWithSHA384, ECDSAWithSHA512.
    /// Allowed values for Ed25519 keys: PureEd25519.
    /// </summary>
    [JsonPropertyName("signatureAlgorithm")]
    public V1CertificateSpecSignatureAlgorithmEnum? SignatureAlgorithm { get; set; }

    /// <summary>
    /// Requested set of X509 certificate subject attributes.
    /// More info: https://datatracker.ietf.org/doc/html/rfc5280#section-4.1.2.6
    /// 
    /// The common name attribute is specified separately in the `commonName` field.
    /// Cannot be set if the `literalSubject` field is set.
    /// </summary>
    [JsonPropertyName("subject")]
    public V1CertificateSpecSubject? Subject { get; set; }

    /// <summary>Requested URI subject alternative names.</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }

    /// <summary>
    /// Requested key usages and extended key usages.
    /// These usages are used to set the `usages` field on the created CertificateRequest
    /// resources. If `encodeUsagesInRequest` is unset or set to `true`, the usages
    /// will additionally be encoded in the `request` field which contains the CSR blob.
    /// 
    /// If unset, defaults to `digital signature` and `key encipherment`.
    /// </summary>
    [JsonPropertyName("usages")]
    public IList<V1CertificateSpecUsagesEnum>? Usages { get; set; }
}

/// <summary>SuggestedWindow is the suggested renewal window as returned by the ACME server in accordance with RFC 9773.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateStatusAcmeAriSuggestedWindow
{
    /// <summary>End is the end of the suggested renewal window.</summary>
    [JsonPropertyName("end")]
    public required DateTime End { get; set; }

    /// <summary>Start is the start of the suggested renewal window.</summary>
    [JsonPropertyName("start")]
    public required DateTime Start { get; set; }
}

/// <summary>
/// ARI stores the ACME Renewal Information that is fetched from the ACME server
/// in accordance with RFC 9773. This is only populated if the ARI feature gate is enabled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateStatusAcmeAri
{
    /// <summary>
    /// ExplanationURL is a human-readable URL that may explain why the suggested window
    /// has its current value.
    /// </summary>
    [JsonPropertyName("explanationURL")]
    public string? ExplanationURL { get; set; }

    /// <summary>LastChecked is the time at which the ACME server was last checked for renewal information.</summary>
    [JsonPropertyName("lastChecked")]
    public DateTime? LastChecked { get; set; }

    /// <summary>LastError is the last error encountered when checking the ACME server for renewal information, if any.</summary>
    [JsonPropertyName("lastError")]
    public string? LastError { get; set; }

    /// <summary>NextCheck is the time at which the ACME server will next be checked for renewal information.</summary>
    [JsonPropertyName("nextCheck")]
    public DateTime? NextCheck { get; set; }

    /// <summary>SuggestedWindow is the suggested renewal window as returned by the ACME server in accordance with RFC 9773.</summary>
    [JsonPropertyName("suggestedWindow")]
    public V1CertificateStatusAcmeAriSuggestedWindow? SuggestedWindow { get; set; }
}

/// <summary>ACME stores information that is fetched from the ACME CA server.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateStatusAcme
{
    /// <summary>
    /// ARI stores the ACME Renewal Information that is fetched from the ACME server
    /// in accordance with RFC 9773. This is only populated if the ARI feature gate is enabled.
    /// </summary>
    [JsonPropertyName("ari")]
    public V1CertificateStatusAcmeAri? Ari { get; set; }
}

/// <summary>Status of the condition, one of (`True`, `False`, `Unknown`).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CertificateStatusConditionsStatusEnum>))]
public enum V1CertificateStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>CertificateCondition contains condition information for a Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the timestamp corresponding to the last status
    /// change of this condition.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>
    /// Message is a human readable description of the details of the last
    /// transition, complementing reason.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// If set, this represents the .metadata.generation that the condition was
    /// set based upon.
    /// For instance, if .metadata.generation is currently 12, but the
    /// .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the Certificate.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason is a brief machine readable explanation for the condition&apos;s last
    /// transition.
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of (`True`, `False`, `Unknown`).</summary>
    [JsonPropertyName("status")]
    public required V1CertificateStatusConditionsStatusEnum Status { get; set; }

    /// <summary>Type of the condition, known values are (`Ready`, `Issuing`).</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// Status of the Certificate.
/// This is set and managed automatically.
/// Read-only.
/// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateStatus
{
    /// <summary>ACME stores information that is fetched from the ACME CA server.</summary>
    [JsonPropertyName("acme")]
    public V1CertificateStatusAcme? Acme { get; set; }

    /// <summary>
    /// List of status conditions to indicate the status of certificates.
    /// Known condition types are `Ready` and `Issuing`.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1CertificateStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// The number of continuous failed issuance attempts up till now. This
    /// field gets removed (if set) on a successful issuance and gets set to
    /// 1 if unset and an issuance has failed. If an issuance has failed, the
    /// delay till the next issuance will be calculated using formula
    /// time.Hour * 2 ^ (failedIssuanceAttempts - 1).
    /// </summary>
    [JsonPropertyName("failedIssuanceAttempts")]
    public int? FailedIssuanceAttempts { get; set; }

    /// <summary>
    /// LastFailureTime is set only if the latest issuance for this
    /// Certificate failed and contains the time of the failure. If an
    /// issuance has failed, the delay till the next issuance will be
    /// calculated using formula time.Hour * 2 ^ (failedIssuanceAttempts -
    /// 1). If the latest issuance has succeeded this field will be unset.
    /// </summary>
    [JsonPropertyName("lastFailureTime")]
    public DateTime? LastFailureTime { get; set; }

    /// <summary>
    /// The name of the Secret resource containing the private key to be used
    /// for the next certificate iteration.
    /// The keymanager controller will automatically set this field if the
    /// `Issuing` condition is set to `True`.
    /// It will automatically unset this field when the Issuing condition is
    /// not set or False.
    /// </summary>
    [JsonPropertyName("nextPrivateKeySecretName")]
    public string? NextPrivateKeySecretName { get; set; }

    /// <summary>
    /// The expiration time of the certificate stored in the secret named
    /// by this resource in `spec.secretName`.
    /// </summary>
    [JsonPropertyName("notAfter")]
    public DateTime? NotAfter { get; set; }

    /// <summary>
    /// The time after which the certificate stored in the secret named
    /// by this resource in `spec.secretName` is valid.
    /// </summary>
    [JsonPropertyName("notBefore")]
    public DateTime? NotBefore { get; set; }

    /// <summary>
    /// RenewalTime is the time at which the certificate will be next
    /// renewed.
    /// If not set, no upcoming renewal is scheduled.
    /// </summary>
    [JsonPropertyName("renewalTime")]
    public DateTime? RenewalTime { get; set; }

    /// <summary>
    /// The current &apos;revision&apos; of the certificate as issued.
    /// 
    /// When a CertificateRequest resource is created, it will have the
    /// `cert-manager.io/certificate-revision` set to one greater than the
    /// current value of this field.
    /// 
    /// Upon issuance, this field will be set to the value of the annotation
    /// on the CertificateRequest resource used to issue the certificate.
    /// 
    /// Persisting the value on the CertificateRequest resource allows the
    /// certificates controller to know whether a request is part of an old
    /// issuance or if it is part of the ongoing revision&apos;s issuance by
    /// checking if the revision value in the annotation is greater than this
    /// field.
    /// </summary>
    [JsonPropertyName("revision")]
    public int? Revision { get; set; }
}

/// <summary>
/// A Certificate resource should be created to ensure an up to date and signed
/// X.509 certificate is stored in the Kubernetes Secret resource named in `spec.secretName`.
/// 
/// The stored certificate will be renewed before it expires (as configured by `spec.renewBefore`).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1Certificate : IKubernetesObject<V1ObjectMeta>, ISpec<V1CertificateSpec?>, IStatus<V1CertificateStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "Certificate";
    public const string KubeGroup = "cert-manager.io";
    public const string KubePluralName = "certificates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cert-manager.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Certificate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// Specification of the desired state of the Certificate resource.
    /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
    /// </summary>
    [JsonPropertyName("spec")]
    public V1CertificateSpec? Spec { get; set; }

    /// <summary>
    /// Status of the Certificate.
    /// This is set and managed automatically.
    /// Read-only.
    /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
    /// </summary>
    [JsonPropertyName("status")]
    public V1CertificateStatus? Status { get; set; }
}