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
/// A CertificateRequest is used to request a signed certificate from one of the
/// configured issuers.
/// 
/// All fields within the CertificateRequest&apos;s `spec` are immutable after creation.
/// A CertificateRequest will either succeed or fail, as denoted by its `Ready` status
/// condition and its `status.failureTime` field.
/// 
/// A CertificateRequest is a one-shot resource, meaning it represents a single
/// point in time request for a certificate and cannot be re-used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1CertificateRequestList : IKubernetesObject<V1ListMeta>, IItems<V1CertificateRequest>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "CertificateRequestList";
    public const string KubeGroup = "cert-manager.io";
    public const string KubePluralName = "certificaterequests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cert-manager.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CertificateRequestList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1CertificateRequest objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1CertificateRequest> Items { get; set; }
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
public partial class V1CertificateRequestSpecIssuerRef
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
[JsonConverter(typeof(JsonStringEnumConverter<V1CertificateRequestSpecUsagesEnum>))]
public enum V1CertificateRequestSpecUsagesEnum
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
/// Specification of the desired state of the CertificateRequest resource.
/// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateRequestSpec
{
    /// <summary>
    /// Requested &apos;duration&apos; (i.e. lifetime) of the Certificate. Note that the
    /// issuer may choose to ignore the requested duration, just like any other
    /// requested attribute.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// Extra contains extra attributes of the user that created the CertificateRequest.
    /// Populated by the cert-manager webhook on creation and immutable.
    /// </summary>
    [JsonPropertyName("extra")]
    public IDictionary<string, IList<string>>? Extra { get; set; }

    /// <summary>
    /// Groups contains group membership of the user that created the CertificateRequest.
    /// Populated by the cert-manager webhook on creation and immutable.
    /// </summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>
    /// Requested basic constraints isCA value. Note that the issuer may choose
    /// to ignore the requested isCA value, just like any other requested attribute.
    /// 
    /// NOTE: If the CSR in the `Request` field has a BasicConstraints extension,
    /// it must have the same isCA value as specified here.
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
    public required V1CertificateRequestSpecIssuerRef IssuerRef { get; set; }

    /// <summary>
    /// The PEM-encoded X.509 certificate signing request to be submitted to the
    /// issuer for signing.
    /// 
    /// If the CSR has a BasicConstraints extension, its isCA attribute must
    /// match the `isCA` value of this CertificateRequest.
    /// If the CSR has a KeyUsage extension, its key usages must match the
    /// key usages in the `usages` field of this CertificateRequest.
    /// If the CSR has a ExtKeyUsage extension, its extended key usages
    /// must match the extended key usages in the `usages` field of this
    /// CertificateRequest.
    /// </summary>
    [JsonPropertyName("request")]
    public required byte[] Request { get; set; }

    /// <summary>
    /// UID contains the uid of the user that created the CertificateRequest.
    /// Populated by the cert-manager webhook on creation and immutable.
    /// </summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>
    /// Requested key usages and extended key usages.
    /// 
    /// NOTE: If the CSR in the `Request` field has uses the KeyUsage or
    /// ExtKeyUsage extension, these extensions must have the same values
    /// as specified here without any additional values.
    /// 
    /// If unset, defaults to `digital signature` and `key encipherment`.
    /// </summary>
    [JsonPropertyName("usages")]
    public IList<V1CertificateRequestSpecUsagesEnum>? Usages { get; set; }

    /// <summary>
    /// Username contains the name of the user that created the CertificateRequest.
    /// Populated by the cert-manager webhook on creation and immutable.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Status of the condition, one of (`True`, `False`, `Unknown`).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1CertificateRequestStatusConditionsStatusEnum>))]
public enum V1CertificateRequestStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>CertificateRequestCondition contains condition information for a CertificateRequest.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateRequestStatusConditions
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
    /// Reason is a brief machine readable explanation for the condition&apos;s last
    /// transition.
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of (`True`, `False`, `Unknown`).</summary>
    [JsonPropertyName("status")]
    public required V1CertificateRequestStatusConditionsStatusEnum Status { get; set; }

    /// <summary>
    /// Type of the condition, known values are (`Ready`, `InvalidRequest`,
    /// `Approved`, `Denied`).
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>
/// Status of the CertificateRequest.
/// This is set and managed automatically.
/// Read-only.
/// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1CertificateRequestStatus
{
    /// <summary>
    /// The PEM encoded X.509 certificate of the signer, also known as the CA
    /// (Certificate Authority).
    /// This is set on a best-effort basis by different issuers.
    /// If not set, the CA is assumed to be unknown/not available.
    /// </summary>
    [JsonPropertyName("ca")]
    public byte[]? Ca { get; set; }

    /// <summary>
    /// The PEM encoded X.509 certificate resulting from the certificate
    /// signing request.
    /// If not set, the CertificateRequest has either not been completed or has
    /// failed. More information on failure can be found by checking the
    /// `conditions` field.
    /// </summary>
    [JsonPropertyName("certificate")]
    public byte[]? Certificate { get; set; }

    /// <summary>
    /// List of status conditions to indicate the status of a CertificateRequest.
    /// Known condition types are `Ready`, `InvalidRequest`, `Approved` and `Denied`.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1CertificateRequestStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// FailureTime stores the time that this CertificateRequest failed. This is
    /// used to influence garbage collection and back-off.
    /// </summary>
    [JsonPropertyName("failureTime")]
    public DateTime? FailureTime { get; set; }
}

/// <summary>
/// A CertificateRequest is used to request a signed certificate from one of the
/// configured issuers.
/// 
/// All fields within the CertificateRequest&apos;s `spec` are immutable after creation.
/// A CertificateRequest will either succeed or fail, as denoted by its `Ready` status
/// condition and its `status.failureTime` field.
/// 
/// A CertificateRequest is a one-shot resource, meaning it represents a single
/// point in time request for a certificate and cannot be re-used.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1CertificateRequest : IKubernetesObject<V1ObjectMeta>, ISpec<V1CertificateRequestSpec?>, IStatus<V1CertificateRequestStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "CertificateRequest";
    public const string KubeGroup = "cert-manager.io";
    public const string KubePluralName = "certificaterequests";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cert-manager.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CertificateRequest";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// Specification of the desired state of the CertificateRequest resource.
    /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
    /// </summary>
    [JsonPropertyName("spec")]
    public V1CertificateRequestSpec? Spec { get; set; }

    /// <summary>
    /// Status of the CertificateRequest.
    /// This is set and managed automatically.
    /// Read-only.
    /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
    /// </summary>
    [JsonPropertyName("status")]
    public V1CertificateRequestStatus? Status { get; set; }
}