#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.policies.kyverno.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NamespacedImageValidatingPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1NamespacedImageValidatingPolicy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NamespacedImageValidatingPolicyList";
    public const string KubeGroup = "policies.kyverno.io";
    public const string KubePluralName = "namespacedimagevalidatingpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "policies.kyverno.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NamespacedImageValidatingPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1NamespacedImageValidatingPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1NamespacedImageValidatingPolicy> Items { get; set; }
}

/// <summary>InToto defines the details of attestation attached using intoto format</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestationsIntoto
{
    /// <summary>Type defines the type of attestation contained within the statement.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Referrer defines the details of attestation attached using OCI 1.1 format</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestationsReferrer
{
    /// <summary>Type defines the type of attestation attached to the image.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Attestation defines the identification details of the  metadata that has to be verified</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestations
{
    /// <summary>InToto defines the details of attestation attached using intoto format</summary>
    [JsonPropertyName("intoto")]
    public V1beta1NamespacedImageValidatingPolicySpecAttestationsIntoto? Intoto { get; set; }

    /// <summary>Name is the name for this attestation. It is used to refer to the attestation in verification</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Referrer defines the details of attestation attached using OCI 1.1 format</summary>
    [JsonPropertyName("referrer")]
    public V1beta1NamespacedImageValidatingPolicySpecAttestationsReferrer? Referrer { get; set; }
}

/// <summary>Certificate is the to the public certificate for local signature verification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignCertificateCert
{
    /// <summary>Expression defines the a CEL expression input.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Value defines the raw string input.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// CertificateChain is the list of CA certificates in PEM format which will be needed
/// when building the certificate chain for the signing certificate. Must start with the
/// parent intermediate CA certificate of the signing certificate and end with the root certificate
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignCertificateCertChain
{
    /// <summary>Expression defines the a CEL expression input.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Value defines the raw string input.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Certificate defines the configuration for local signature verification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignCertificate
{
    /// <summary>Certificate is the to the public certificate for local signature verification.</summary>
    [JsonPropertyName("cert")]
    public V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignCertificateCert? Cert { get; set; }

    /// <summary>
    /// CertificateChain is the list of CA certificates in PEM format which will be needed
    /// when building the certificate chain for the signing certificate. Must start with the
    /// parent intermediate CA certificate of the signing certificate and end with the root certificate
    /// </summary>
    [JsonPropertyName("certChain")]
    public V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignCertificateCertChain? CertChain { get; set; }
}

/// <summary>CTLog sets the configuration to verify the authority against a Rekor instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignCtlog
{
    /// <summary>CTLogPubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("ctLogPubKey")]
    public string? CtLogPubKey { get; set; }

    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("insecureIgnoreSCT")]
    public bool? InsecureIgnoreSCT { get; set; }

    /// <summary>InsecureIgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("insecureIgnoreTlog")]
    public bool? InsecureIgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("rekorPubKey")]
    public string? RekorPubKey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }

    /// <summary>URL sets the url to the rekor instance (by default the public rekor.sigstore.dev)</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Key defines the type of key to validate the image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignKey
{
    /// <summary>Data contains the inline public key</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>Expression is a Expression expression that returns the public key.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>
    /// HashAlgorithm specifues signature algorithm for public keys. Supported values are
    /// sha224, sha256, sha384 and sha512. Defaults to sha256.
    /// </summary>
    [JsonPropertyName("hashAlgorithm")]
    public string? HashAlgorithm { get; set; }

    /// <summary>
    /// KMS contains the KMS url of the public key
    /// Supported formats differ based on the KMS system used.
    /// </summary>
    [JsonPropertyName("kms")]
    public string? Kms { get; set; }
}

/// <summary>
/// Identity may contain the issuer and/or the subject found in the transparency
/// log.
/// Issuer/Subject uses a strict match, while IssuerRegExp and SubjectRegExp
/// apply a regexp for matching.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignKeylessIdentities
{
    /// <summary>Issuer defines the issuer for this identity.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>IssuerRegExp specifies a regular expression to match the issuer for this identity.</summary>
    [JsonPropertyName("issuerRegExp")]
    public string? IssuerRegExp { get; set; }

    /// <summary>Subject defines the subject for this identity.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>SubjectRegExp specifies a regular expression to match the subject for this identity.</summary>
    [JsonPropertyName("subjectRegExp")]
    public string? SubjectRegExp { get; set; }
}

/// <summary>Keyless sets the configuration to verify the authority against a Fulcio instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignKeyless
{
    /// <summary>Identities sets a list of identities.</summary>
    [JsonPropertyName("identities")]
    public required IList<V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignKeylessIdentities> Identities { get; set; }

    /// <summary>
    /// Roots is an optional set of PEM encoded trusted root certificates.
    /// If not provided, the system roots are used.
    /// </summary>
    [JsonPropertyName("roots")]
    public string? Roots { get; set; }
}

/// <summary>
/// LocalObjectReference contains enough information to let you locate the
/// referenced object inside the same namespace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignSourcePullSecrets
{
    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Sources sets the configuration to specify the sources from where to consume the signature and attestations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignSource
{
    /// <summary>
    /// SignaturePullSecrets is an optional list of references to secrets in the
    /// same namespace as the deploying resource for pulling any of the signatures
    /// used by this Source.
    /// </summary>
    [JsonPropertyName("PullSecrets")]
    public IList<V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignSourcePullSecrets>? PullSecrets { get; set; }

    /// <summary>Repository defines the location from where to pull the signature / attestations.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>
    /// TagPrefix is an optional prefix that signature and attestations have.
    /// This is the &apos;tag based discovery&apos; and in the future once references are
    /// fully supported that should likely be the preferred way to handle these.
    /// </summary>
    [JsonPropertyName("tagPrefix")]
    public string? TagPrefix { get; set; }
}

/// <summary>Root defines the path or data of the trusted root</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignTufRoot
{
    /// <summary>Data is the base64 encoded TUF root</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>Path is the URL or File location of the TUF root</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>TUF defines the configuration to fetch sigstore root</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignTuf
{
    /// <summary>Mirror is the base URL of Sigstore TUF repository</summary>
    [JsonPropertyName("mirror")]
    public string? Mirror { get; set; }

    /// <summary>Root defines the path or data of the trusted root</summary>
    [JsonPropertyName("root")]
    public V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignTufRoot? Root { get; set; }
}

/// <summary>Cosign defines attestor configuration for Cosign based signatures</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestorsCosign
{
    /// <summary>
    /// Annotations are used for image verification.
    /// Every specified key-value pair must exist and match in the verified payload.
    /// The payload may contain other key-value pairs.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Certificate defines the configuration for local signature verification</summary>
    [JsonPropertyName("certificate")]
    public V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignCertificate? Certificate { get; set; }

    /// <summary>CTLog sets the configuration to verify the authority against a Rekor instance.</summary>
    [JsonPropertyName("ctlog")]
    public V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignCtlog? Ctlog { get; set; }

    /// <summary>Key defines the type of key to validate the image.</summary>
    [JsonPropertyName("key")]
    public V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignKey? Key { get; set; }

    /// <summary>Keyless sets the configuration to verify the authority against a Fulcio instance.</summary>
    [JsonPropertyName("keyless")]
    public V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignKeyless? Keyless { get; set; }

    /// <summary>Sources sets the configuration to specify the sources from where to consume the signature and attestations.</summary>
    [JsonPropertyName("source")]
    public V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignSource? Source { get; set; }

    /// <summary>TUF defines the configuration to fetch sigstore root</summary>
    [JsonPropertyName("tuf")]
    public V1beta1NamespacedImageValidatingPolicySpecAttestorsCosignTuf? Tuf { get; set; }
}

/// <summary>Certs define the cert chain for Notary signature verification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestorsNotaryCerts
{
    /// <summary>Expression defines the a CEL expression input.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Value defines the raw string input.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>TSACerts define the cert chain for verifying timestamps of notary signature</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestorsNotaryTsaCerts
{
    /// <summary>Expression defines the a CEL expression input.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Value defines the raw string input.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Notary defines attestor configuration for Notary based signatures</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestorsNotary
{
    /// <summary>Certs define the cert chain for Notary signature verification</summary>
    [JsonPropertyName("certs")]
    public V1beta1NamespacedImageValidatingPolicySpecAttestorsNotaryCerts? Certs { get; set; }

    /// <summary>TSACerts define the cert chain for verifying timestamps of notary signature</summary>
    [JsonPropertyName("tsaCerts")]
    public V1beta1NamespacedImageValidatingPolicySpecAttestorsNotaryTsaCerts? TsaCerts { get; set; }
}

/// <summary>Attestor is an identity that confirms or verifies the authenticity of an image or an attestation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAttestors
{
    /// <summary>Cosign defines attestor configuration for Cosign based signatures</summary>
    [JsonPropertyName("cosign")]
    public V1beta1NamespacedImageValidatingPolicySpecAttestorsCosign? Cosign { get; set; }

    /// <summary>Name is the name for this attestor. It is used to refer to the attestor in verification</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Notary defines attestor configuration for Notary based signatures</summary>
    [JsonPropertyName("notary")]
    public V1beta1NamespacedImageValidatingPolicySpecAttestorsNotary? Notary { get; set; }
}

/// <summary>AuditAnnotation describes how to produce an audit annotation for an API request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAuditAnnotations
{
    /// <summary>
    /// key specifies the audit annotation key. The audit annotation keys of
    /// a ValidatingAdmissionPolicy must be unique. The key must be a qualified
    /// name ([A-Za-z0-9][-A-Za-z0-9_.]*) no more than 63 bytes in length.
    /// 
    /// The key is combined with the resource name of the
    /// ValidatingAdmissionPolicy to construct an audit annotation key:
    /// &quot;{ValidatingAdmissionPolicy name}/{key}&quot;.
    /// 
    /// If an admission webhook uses the same resource name as this ValidatingAdmissionPolicy
    /// and the same audit annotation key, the annotation key will be identical.
    /// In this case, the first annotation written with the key will be included
    /// in the audit event and all subsequent annotations with the same key
    /// will be discarded.
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// valueExpression represents the expression which is evaluated by CEL to
    /// produce an audit annotation value. The expression must evaluate to either
    /// a string or null value. If the expression evaluates to a string, the
    /// audit annotation is included with the string value. If the expression
    /// evaluates to null or empty string the audit annotation will be omitted.
    /// The valueExpression may be no longer than 5kb in length.
    /// If the result of the valueExpression is more than 10kb in length, it
    /// will be truncated to 10kb.
    /// 
    /// If multiple ValidatingAdmissionPolicyBinding resources match an
    /// API request, then the valueExpression will be evaluated for
    /// each binding. All unique values produced by the valueExpressions
    /// will be joined together in a comma-separated list.
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("valueExpression")]
    public required string ValueExpression { get; set; }
}

/// <summary>PodControllers specifies whether to generate a pod controllers rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAutogenPodControllers
{
    [JsonPropertyName("controllers")]
    public IList<string>? Controllers { get; set; }
}

/// <summary>AutogenConfiguration defines the configuration for the generation controller.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecAutogen
{
    /// <summary>PodControllers specifies whether to generate a pod controllers rules.</summary>
    [JsonPropertyName("podControllers")]
    public V1beta1NamespacedImageValidatingPolicySpecAutogenPodControllers? PodControllers { get; set; }
}

/// <summary>CredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespacedImageValidatingPolicySpecCredentialsProvidersEnum>))]
public enum V1beta1NamespacedImageValidatingPolicySpecCredentialsProvidersEnum
{
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    Default,
    [EnumMember(Value = "amazon"), JsonStringEnumMemberName("amazon")]
    Amazon,
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "google"), JsonStringEnumMemberName("google")]
    Google,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github
}

/// <summary>Credentials provides credentials that will be used for authentication with registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V1beta1NamespacedImageValidatingPolicySpecCredentialsProvidersEnum>? Providers { get; set; }

    /// <summary>
    /// Secrets specifies a list of secrets that are provided for credentials.
    /// Secrets must live in the Kyverno namespace.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }
}

/// <summary>Admission controls policy evaluation during admission.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecEvaluationAdmission
{
    /// <summary>
    /// Enabled controls if rules are applied during admission.
    /// Optional. Default value is &quot;true&quot;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Background  controls policy evaluation during background scan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecEvaluationBackground
{
    /// <summary>
    /// Enabled controls if rules are applied to existing resources during a background scan.
    /// Optional. Default value is &quot;true&quot;. The value must be set to &quot;false&quot; if the policy rule
    /// uses variables that are only available in the admission review request (e.g. user name).
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>EvaluationConfiguration defines the configuration for the policy evaluation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecEvaluation
{
    /// <summary>Admission controls policy evaluation during admission.</summary>
    [JsonPropertyName("admission")]
    public V1beta1NamespacedImageValidatingPolicySpecEvaluationAdmission? Admission { get; set; }

    /// <summary>Background  controls policy evaluation during background scan.</summary>
    [JsonPropertyName("background")]
    public V1beta1NamespacedImageValidatingPolicySpecEvaluationBackground? Background { get; set; }

    /// <summary>
    /// Mode is the mode of policy evaluation.
    /// Allowed values are &quot;Kubernetes&quot; or &quot;JSON&quot;.
    /// Optional. Default value is &quot;Kubernetes&quot;.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// FailurePolicy defines how to handle failures for the admission policy. Failures can
/// occur from CEL expression parse errors, type check errors, runtime errors and invalid
/// or mis-configured policy definitions or bindings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespacedImageValidatingPolicySpecFailurePolicyEnum>))]
public enum V1beta1NamespacedImageValidatingPolicySpecFailurePolicyEnum
{
    [EnumMember(Value = "Ignore"), JsonStringEnumMemberName("Ignore")]
    Ignore,
    [EnumMember(Value = "Fail"), JsonStringEnumMemberName("Fail")]
    Fail
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecImages
{
    /// <summary>Expression defines CEL expression to extract images from the resource.</summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>Name is the name for this imageList. It is used to refer to the images in verification block as images.&lt;name&gt;</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>MatchCondition represents a condition which must by fulfilled for a request to be sent to a webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecMatchConditions
{
    /// <summary>
    /// Expression represents the expression which will be evaluated by CEL. Must evaluate to bool.
    /// CEL expressions have access to the contents of the AdmissionRequest and Authorizer, organized into CEL variables:
    /// 
    /// &apos;object&apos; - The object from the incoming request. The value is null for DELETE requests.
    /// &apos;oldObject&apos; - The existing object. The value is null for CREATE requests.
    /// &apos;request&apos; - Attributes of the admission request(/pkg/apis/admission/types.go#AdmissionRequest).
    /// &apos;authorizer&apos; - A CEL Authorizer. May be used to perform authorization checks for the principal (user or service account) of the request.
    ///   See https://pkg.go.dev/k8s.io/apiserver/pkg/cel/library#Authz
    /// &apos;authorizer.requestResource&apos; - A CEL ResourceCheck constructed from the &apos;authorizer&apos; and configured with the
    ///   request resource.
    /// Documentation on CEL: https://kubernetes.io/docs/reference/using-api/cel/
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Name is an identifier for this match condition, used for strategic merging of MatchConditions,
    /// as well as providing an identifier for logging purposes. A good name should be descriptive of
    /// the associated expression.
    /// Name must be a qualified name consisting of alphanumeric characters, &apos;-&apos;, &apos;_&apos; or &apos;.&apos;, and
    /// must start and end with an alphanumeric character (e.g. &apos;MyName&apos;,  or &apos;my.name&apos;,  or
    /// &apos;123-abc&apos;, regex used for validation is &apos;([A-Za-z0-9][-A-Za-z0-9_.]*)?[A-Za-z0-9]&apos;) with an
    /// optional DNS subdomain prefix and &apos;/&apos; (e.g. &apos;example.com/MyName&apos;)
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>NamedRuleWithOperations is a tuple of Operations and Resources with ResourceNames.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecMatchConstraintsExcludeResourceRules
{
    /// <summary>
    /// APIGroups is the API groups the resources belong to. &apos;*&apos; is all groups.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("apiGroups")]
    public IList<string>? ApiGroups { get; set; }

    /// <summary>
    /// APIVersions is the API versions the resources belong to. &apos;*&apos; is all versions.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>
    /// Operations is the operations the admission hook cares about - CREATE, UPDATE, DELETE, CONNECT or *
    /// for all of those operations and any future admission operations that are added.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<string>? Operations { get; set; }

    /// <summary>ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.</summary>
    [JsonPropertyName("resourceNames")]
    public IList<string>? ResourceNames { get; set; }

    /// <summary>
    /// Resources is a list of resources this rule applies to.
    /// 
    /// For example:
    /// &apos;pods&apos; means pods.
    /// &apos;pods/log&apos; means the log subresource of pods.
    /// &apos;*&apos; means all resources, but not subresources.
    /// &apos;pods/*&apos; means all subresources of pods.
    /// &apos;*/scale&apos; means all scale subresources.
    /// &apos;*/*&apos; means all resources and their subresources.
    /// 
    /// If wildcard is present, the validation rule will ensure resources do not
    /// overlap with each other.
    /// 
    /// Depending on the enclosing object, subresources might not be allowed.
    /// Required.
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// scope specifies the scope of this rule.
    /// Valid values are &quot;Cluster&quot;, &quot;Namespaced&quot;, and &quot;*&quot;
    /// &quot;Cluster&quot; means that only cluster-scoped resources will match this rule.
    /// Namespace API objects are cluster-scoped.
    /// &quot;Namespaced&quot; means that only namespaced resources will match this rule.
    /// &quot;*&quot; means that there are no scope restrictions.
    /// Subresources match the scope of their parent resource.
    /// Default is &quot;*&quot;.
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecMatchConstraintsNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// NamespaceSelector decides whether to run the admission control policy on an object based
/// on whether the namespace for that object matches the selector. If the
/// object itself is a namespace, the matching is performed on
/// object.metadata.labels. If the object is another cluster scoped resource,
/// it never skips the policy.
/// 
/// For example, to run the webhook on any objects whose namespace is not
/// associated with &quot;runlevel&quot; of &quot;0&quot; or &quot;1&quot;;  you will set the selector as
/// follows:
/// &quot;namespaceSelector&quot;: {
///   &quot;matchExpressions&quot;: [
///     {
///       &quot;key&quot;: &quot;runlevel&quot;,
///       &quot;operator&quot;: &quot;NotIn&quot;,
///       &quot;values&quot;: [
///         &quot;0&quot;,
///         &quot;1&quot;
///       ]
///     }
///   ]
/// }
/// 
/// If instead you want to only run the policy on any objects whose
/// namespace is associated with the &quot;environment&quot; of &quot;prod&quot; or &quot;staging&quot;;
/// you will set the selector as follows:
/// &quot;namespaceSelector&quot;: {
///   &quot;matchExpressions&quot;: [
///     {
///       &quot;key&quot;: &quot;environment&quot;,
///       &quot;operator&quot;: &quot;In&quot;,
///       &quot;values&quot;: [
///         &quot;prod&quot;,
///         &quot;staging&quot;
///       ]
///     }
///   ]
/// }
/// 
/// See
/// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/
/// for more examples of label selectors.
/// 
/// Default to the empty LabelSelector, which matches everything.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecMatchConstraintsNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1beta1NamespacedImageValidatingPolicySpecMatchConstraintsNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecMatchConstraintsObjectSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// ObjectSelector decides whether to run the validation based on if the
/// object has matching labels. objectSelector is evaluated against both
/// the oldObject and newObject that would be sent to the cel validation, and
/// is considered to match if either object matches the selector. A null
/// object (oldObject in the case of create, or newObject in the case of
/// delete) or an object that cannot have labels (like a
/// DeploymentRollback or a PodProxyOptions object) is not considered to
/// match.
/// Use the object selector only if the webhook is opt-in, because end
/// users may skip the admission webhook by setting the labels.
/// Default to the empty LabelSelector, which matches everything.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecMatchConstraintsObjectSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1beta1NamespacedImageValidatingPolicySpecMatchConstraintsObjectSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>NamedRuleWithOperations is a tuple of Operations and Resources with ResourceNames.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecMatchConstraintsResourceRules
{
    /// <summary>
    /// APIGroups is the API groups the resources belong to. &apos;*&apos; is all groups.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("apiGroups")]
    public IList<string>? ApiGroups { get; set; }

    /// <summary>
    /// APIVersions is the API versions the resources belong to. &apos;*&apos; is all versions.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>
    /// Operations is the operations the admission hook cares about - CREATE, UPDATE, DELETE, CONNECT or *
    /// for all of those operations and any future admission operations that are added.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<string>? Operations { get; set; }

    /// <summary>ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.</summary>
    [JsonPropertyName("resourceNames")]
    public IList<string>? ResourceNames { get; set; }

    /// <summary>
    /// Resources is a list of resources this rule applies to.
    /// 
    /// For example:
    /// &apos;pods&apos; means pods.
    /// &apos;pods/log&apos; means the log subresource of pods.
    /// &apos;*&apos; means all resources, but not subresources.
    /// &apos;pods/*&apos; means all subresources of pods.
    /// &apos;*/scale&apos; means all scale subresources.
    /// &apos;*/*&apos; means all resources and their subresources.
    /// 
    /// If wildcard is present, the validation rule will ensure resources do not
    /// overlap with each other.
    /// 
    /// Depending on the enclosing object, subresources might not be allowed.
    /// Required.
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// scope specifies the scope of this rule.
    /// Valid values are &quot;Cluster&quot;, &quot;Namespaced&quot;, and &quot;*&quot;
    /// &quot;Cluster&quot; means that only cluster-scoped resources will match this rule.
    /// Namespace API objects are cluster-scoped.
    /// &quot;Namespaced&quot; means that only namespaced resources will match this rule.
    /// &quot;*&quot; means that there are no scope restrictions.
    /// Subresources match the scope of their parent resource.
    /// Default is &quot;*&quot;.
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>MatchConstraints specifies what resources this policy is designed to validate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecMatchConstraints
{
    /// <summary>
    /// ExcludeResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy should not care about.
    /// The exclude rules take precedence over include rules (if a resource matches both, it is excluded)
    /// </summary>
    [JsonPropertyName("excludeResourceRules")]
    public IList<V1beta1NamespacedImageValidatingPolicySpecMatchConstraintsExcludeResourceRules>? ExcludeResourceRules { get; set; }

    /// <summary>
    /// matchPolicy defines how the &quot;MatchResources&quot; list is used to match incoming requests.
    /// Allowed values are &quot;Exact&quot; or &quot;Equivalent&quot;.
    /// 
    /// - Exact: match a request only if it exactly matches a specified rule.
    /// For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1,
    /// but &quot;rules&quot; only included `apiGroups:[&quot;apps&quot;], apiVersions:[&quot;v1&quot;], resources: [&quot;deployments&quot;]`,
    /// a request to apps/v1beta1 or extensions/v1beta1 would not be sent to the ValidatingAdmissionPolicy.
    /// 
    /// - Equivalent: match a request if modifies a resource listed in rules, even via another API group or version.
    /// For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1,
    /// and &quot;rules&quot; only included `apiGroups:[&quot;apps&quot;], apiVersions:[&quot;v1&quot;], resources: [&quot;deployments&quot;]`,
    /// a request to apps/v1beta1 or extensions/v1beta1 would be converted to apps/v1 and sent to the ValidatingAdmissionPolicy.
    /// 
    /// Defaults to &quot;Equivalent&quot;
    /// </summary>
    [JsonPropertyName("matchPolicy")]
    public string? MatchPolicy { get; set; }

    /// <summary>
    /// NamespaceSelector decides whether to run the admission control policy on an object based
    /// on whether the namespace for that object matches the selector. If the
    /// object itself is a namespace, the matching is performed on
    /// object.metadata.labels. If the object is another cluster scoped resource,
    /// it never skips the policy.
    /// 
    /// For example, to run the webhook on any objects whose namespace is not
    /// associated with &quot;runlevel&quot; of &quot;0&quot; or &quot;1&quot;;  you will set the selector as
    /// follows:
    /// &quot;namespaceSelector&quot;: {
    ///   &quot;matchExpressions&quot;: [
    ///     {
    ///       &quot;key&quot;: &quot;runlevel&quot;,
    ///       &quot;operator&quot;: &quot;NotIn&quot;,
    ///       &quot;values&quot;: [
    ///         &quot;0&quot;,
    ///         &quot;1&quot;
    ///       ]
    ///     }
    ///   ]
    /// }
    /// 
    /// If instead you want to only run the policy on any objects whose
    /// namespace is associated with the &quot;environment&quot; of &quot;prod&quot; or &quot;staging&quot;;
    /// you will set the selector as follows:
    /// &quot;namespaceSelector&quot;: {
    ///   &quot;matchExpressions&quot;: [
    ///     {
    ///       &quot;key&quot;: &quot;environment&quot;,
    ///       &quot;operator&quot;: &quot;In&quot;,
    ///       &quot;values&quot;: [
    ///         &quot;prod&quot;,
    ///         &quot;staging&quot;
    ///       ]
    ///     }
    ///   ]
    /// }
    /// 
    /// See
    /// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/
    /// for more examples of label selectors.
    /// 
    /// Default to the empty LabelSelector, which matches everything.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1beta1NamespacedImageValidatingPolicySpecMatchConstraintsNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// ObjectSelector decides whether to run the validation based on if the
    /// object has matching labels. objectSelector is evaluated against both
    /// the oldObject and newObject that would be sent to the cel validation, and
    /// is considered to match if either object matches the selector. A null
    /// object (oldObject in the case of create, or newObject in the case of
    /// delete) or an object that cannot have labels (like a
    /// DeploymentRollback or a PodProxyOptions object) is not considered to
    /// match.
    /// Use the object selector only if the webhook is opt-in, because end
    /// users may skip the admission webhook by setting the labels.
    /// Default to the empty LabelSelector, which matches everything.
    /// </summary>
    [JsonPropertyName("objectSelector")]
    public V1beta1NamespacedImageValidatingPolicySpecMatchConstraintsObjectSelector? ObjectSelector { get; set; }

    /// <summary>
    /// ResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy matches.
    /// The policy cares about an operation if it matches _any_ Rule.
    /// </summary>
    [JsonPropertyName("resourceRules")]
    public IList<V1beta1NamespacedImageValidatingPolicySpecMatchConstraintsResourceRules>? ResourceRules { get; set; }
}

/// <summary>MatchImageReference defines a Glob or a CEL expression for matching images</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecMatchImageReferences
{
    /// <summary>Expression defines CEL Expressions for matching images</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Glob defines a globbing pattern for matching images</summary>
    [JsonPropertyName("glob")]
    public string? Glob { get; set; }
}

/// <summary>ValidationAction specifies a policy enforcement action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespacedImageValidatingPolicySpecValidationActionsEnum>))]
public enum V1beta1NamespacedImageValidatingPolicySpecValidationActionsEnum
{
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny,
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit,
    [EnumMember(Value = "Warn"), JsonStringEnumMemberName("Warn")]
    Warn
}

/// <summary>ValidationConfigurations defines settings for mutating and verifying image digests, and enforcing image verification through signatures.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecValidationConfigurations
{
    /// <summary>
    /// MutateDigest enables replacement of image tags with digests.
    /// Defaults to true.
    /// </summary>
    [JsonPropertyName("mutateDigest")]
    public bool? MutateDigest { get; set; }

    /// <summary>Required validates that images are verified, i.e., have passed a signature or attestation check.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>VerifyDigest validates that images have a digest.</summary>
    [JsonPropertyName("verifyDigest")]
    public bool? VerifyDigest { get; set; }
}

/// <summary>Validation specifies the CEL expression which is used to apply the validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecValidations
{
    /// <summary>
    /// Expression represents the expression which will be evaluated by CEL.
    /// ref: https://github.com/google/cel-spec
    /// CEL expressions have access to the contents of the API request/response, organized into CEL variables as well as some other useful variables:
    /// 
    /// - &apos;object&apos; - The object from the incoming request. The value is null for DELETE requests.
    /// - &apos;oldObject&apos; - The existing object. The value is null for CREATE requests.
    /// - &apos;request&apos; - Attributes of the API request([ref](/pkg/apis/admission/types.go#AdmissionRequest)).
    /// - &apos;params&apos; - Parameter resource referred to by the policy binding being evaluated. Only populated if the policy has a ParamKind.
    /// - &apos;namespaceObject&apos; - The namespace object that the incoming object belongs to. The value is null for cluster-scoped resources.
    /// - &apos;variables&apos; - Map of composited variables, from its name to its lazily evaluated value.
    ///   For example, a variable named &apos;foo&apos; can be accessed as &apos;variables.foo&apos;.
    /// - &apos;authorizer&apos; - A CEL Authorizer. May be used to perform authorization checks for the principal (user or service account) of the request.
    ///   See https://pkg.go.dev/k8s.io/apiserver/pkg/cel/library#Authz
    /// - &apos;authorizer.requestResource&apos; - A CEL ResourceCheck constructed from the &apos;authorizer&apos; and configured with the
    ///   request resource.
    /// 
    /// The `apiVersion`, `kind`, `metadata.name` and `metadata.generateName` are always accessible from the root of the
    /// object. No other metadata properties are accessible.
    /// 
    /// Only property names of the form `[a-zA-Z_.-/][a-zA-Z0-9_.-/]*` are accessible.
    /// Accessible property names are escaped according to the following rules when accessed in the expression:
    /// - &apos;__&apos; escapes to &apos;__underscores__&apos;
    /// - &apos;.&apos; escapes to &apos;__dot__&apos;
    /// - &apos;-&apos; escapes to &apos;__dash__&apos;
    /// - &apos;/&apos; escapes to &apos;__slash__&apos;
    /// - Property names that exactly match a CEL RESERVED keyword escape to &apos;__{keyword}__&apos;. The keywords are:
    /// 	  &quot;true&quot;, &quot;false&quot;, &quot;null&quot;, &quot;in&quot;, &quot;as&quot;, &quot;break&quot;, &quot;const&quot;, &quot;continue&quot;, &quot;else&quot;, &quot;for&quot;, &quot;function&quot;, &quot;if&quot;,
    /// 	  &quot;import&quot;, &quot;let&quot;, &quot;loop&quot;, &quot;package&quot;, &quot;namespace&quot;, &quot;return&quot;.
    /// Examples:
    ///   - Expression accessing a property named &quot;namespace&quot;: {&quot;Expression&quot;: &quot;object.__namespace__ &gt; 0&quot;}
    ///   - Expression accessing a property named &quot;x-prop&quot;: {&quot;Expression&quot;: &quot;object.x__dash__prop &gt; 0&quot;}
    ///   - Expression accessing a property named &quot;redact__d&quot;: {&quot;Expression&quot;: &quot;object.redact__underscores__d &gt; 0&quot;}
    /// 
    /// Equality on arrays with list type of &apos;set&apos; or &apos;map&apos; ignores element order, i.e. [1, 2] == [2, 1].
    /// Concatenation on arrays with x-kubernetes-list-type use the semantics of the list type:
    ///   - &apos;set&apos;: `X + Y` performs a union where the array positions of all elements in `X` are preserved and
    ///     non-intersecting elements in `Y` are appended, retaining their partial order.
    ///   - &apos;map&apos;: `X + Y` performs a merge where the array positions of all keys in `X` are preserved but the values
    ///     are overwritten by values in `Y` when the key sets of `X` and `Y` intersect. Elements in `Y` with
    ///     non-intersecting keys are appended, retaining their partial order.
    /// Required.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Message represents the message displayed when validation fails. The message is required if the Expression contains
    /// line breaks. The message must not contain line breaks.
    /// If unset, the message is &quot;failed rule: {Rule}&quot;.
    /// e.g. &quot;must be a URL with the host matching spec.host&quot;
    /// If the Expression contains line breaks. Message is required.
    /// The message must not contain line breaks.
    /// If unset, the message is &quot;failed Expression: {Expression}&quot;.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// messageExpression declares a CEL expression that evaluates to the validation failure message that is returned when this rule fails.
    /// Since messageExpression is used as a failure message, it must evaluate to a string.
    /// If both message and messageExpression are present on a validation, then messageExpression will be used if validation fails.
    /// If messageExpression results in a runtime error, the runtime error is logged, and the validation failure message is produced
    /// as if the messageExpression field were unset. If messageExpression evaluates to an empty string, a string with only spaces, or a string
    /// that contains line breaks, then the validation failure message will also be produced as if the messageExpression field were unset, and
    /// the fact that messageExpression produced an empty string/string with only spaces/string with line breaks will be logged.
    /// messageExpression has access to all the same variables as the `expression` except for &apos;authorizer&apos; and &apos;authorizer.requestResource&apos;.
    /// Example:
    /// &quot;object.x must be less than max (&quot;+string(params.max)+&quot;)&quot;
    /// </summary>
    [JsonPropertyName("messageExpression")]
    public string? MessageExpression { get; set; }

    /// <summary>
    /// Reason represents a machine-readable description of why this validation failed.
    /// If this is the first validation in the list to fail, this reason, as well as the
    /// corresponding HTTP response code, are used in the
    /// HTTP response to the client.
    /// The currently supported reasons are: &quot;Unauthorized&quot;, &quot;Forbidden&quot;, &quot;Invalid&quot;, &quot;RequestEntityTooLarge&quot;.
    /// If not set, StatusReasonInvalid is used in the response to the client.
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary>Variable is the definition of a variable that is used for composition. A variable is defined as a named expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecVariables
{
    /// <summary>
    /// Expression is the expression that will be evaluated as the value of the variable.
    /// The CEL expression has access to the same identifiers as the CEL expressions in Validation.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Name is the name of the variable. The name must be a valid CEL identifier and unique among all variables.
    /// The variable can be accessed in other expressions through `variables`
    /// For example, if name is &quot;foo&quot;, the variable will be available as `variables.foo`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>WebhookConfiguration defines the configuration for the webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpecWebhookConfiguration
{
    /// <summary>
    /// TimeoutSeconds specifies the maximum time in seconds allowed to apply this policy.
    /// After the configured time expires, the admission request may fail, or may simply ignore the policy results,
    /// based on the failure policy. The default timeout is 10s, the value must be between 1 and 30 seconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>ImageValidatingPolicySpec is the specification of the desired behavior of the ImageValidatingPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicySpec
{
    /// <summary>Attestations provides a list of image metadata to verify</summary>
    [JsonPropertyName("attestations")]
    public IList<V1beta1NamespacedImageValidatingPolicySpecAttestations>? Attestations { get; set; }

    /// <summary>Attestors provides a list of trusted authorities.</summary>
    [JsonPropertyName("attestors")]
    public required IList<V1beta1NamespacedImageValidatingPolicySpecAttestors> Attestors { get; set; }

    /// <summary>
    /// auditAnnotations contains CEL expressions which are used to produce audit
    /// annotations for the audit event of the API request.
    /// validations and auditAnnotations may not both be empty; a least one of validations or auditAnnotations is
    /// required.
    /// </summary>
    [JsonPropertyName("auditAnnotations")]
    public IList<V1beta1NamespacedImageValidatingPolicySpecAuditAnnotations>? AuditAnnotations { get; set; }

    /// <summary>AutogenConfiguration defines the configuration for the generation controller.</summary>
    [JsonPropertyName("autogen")]
    public V1beta1NamespacedImageValidatingPolicySpecAutogen? Autogen { get; set; }

    /// <summary>Credentials provides credentials that will be used for authentication with registry.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1NamespacedImageValidatingPolicySpecCredentials? Credentials { get; set; }

    /// <summary>EvaluationConfiguration defines the configuration for the policy evaluation.</summary>
    [JsonPropertyName("evaluation")]
    public V1beta1NamespacedImageValidatingPolicySpecEvaluation? Evaluation { get; set; }

    /// <summary>
    /// FailurePolicy defines how to handle failures for the admission policy. Failures can
    /// occur from CEL expression parse errors, type check errors, runtime errors and invalid
    /// or mis-configured policy definitions or bindings.
    /// </summary>
    [JsonPropertyName("failurePolicy")]
    public V1beta1NamespacedImageValidatingPolicySpecFailurePolicyEnum? FailurePolicy { get; set; }

    /// <summary>ImageExtractors is a list of CEL expression to extract images from the resource</summary>
    [JsonPropertyName("images")]
    public IList<V1beta1NamespacedImageValidatingPolicySpecImages>? Images { get; set; }

    /// <summary>
    /// MatchConditions is a list of conditions that must be met for a request to be validated.
    /// Match conditions filter requests that have already been matched by the rules,
    /// namespaceSelector, and objectSelector. An empty list of matchConditions matches all requests.
    /// There are a maximum of 64 match conditions allowed.
    /// </summary>
    [JsonPropertyName("matchConditions")]
    public IList<V1beta1NamespacedImageValidatingPolicySpecMatchConditions>? MatchConditions { get; set; }

    /// <summary>MatchConstraints specifies what resources this policy is designed to validate.</summary>
    [JsonPropertyName("matchConstraints")]
    public V1beta1NamespacedImageValidatingPolicySpecMatchConstraints? MatchConstraints { get; set; }

    /// <summary>
    /// MatchImageReferences is a list of Glob and CELExpressions to match images.
    /// Any image that matches one of the rules is considered for validation
    /// Any image that does not match a rule is skipped, even when they are passed as arguments to
    /// image verification functions
    /// </summary>
    [JsonPropertyName("matchImageReferences")]
    public IList<V1beta1NamespacedImageValidatingPolicySpecMatchImageReferences>? MatchImageReferences { get; set; }

    /// <summary>
    /// ValidationAction specifies the action to be taken when the matched resource violates the policy.
    /// If a validation evaluates to false it is always enforced according to these actions.
    /// 
    /// Failures defined by the ValidatingAdmissionPolicy&apos;s FailurePolicy are enforced according
    /// to these actions only if the FailurePolicy is set to Fail, otherwise the failures are
    /// ignored. This includes compilation errors, runtime errors and misconfigurations of the policy.
    /// 
    /// validationActions is declared as a set of action values. Order does
    /// not matter. validationActions may not contain duplicates of the same action.
    /// 
    /// The supported actions values are:
    /// 
    /// &quot;Deny&quot; specifies that a validation failure results in a denied request.
    /// 
    /// &quot;Warn&quot; specifies that a validation failure is reported to the request client
    /// in HTTP Warning headers, with a warning code of 299. Warnings can be sent
    /// both for allowed or denied admission responses.
    /// 
    /// &quot;Audit&quot; specifies that a validation failure is recorded in the created reports.
    /// 
    /// Clients should expect to handle additional values by ignoring
    /// any values not recognized.
    /// 
    /// &quot;Deny&quot; and &quot;Warn&quot; may not be used together since this combination
    /// needlessly duplicates the validation failure both in the
    /// API response body and the HTTP warning headers.
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("validationActions")]
    public IList<V1beta1NamespacedImageValidatingPolicySpecValidationActionsEnum>? ValidationActions { get; set; }

    /// <summary>ValidationConfigurations defines settings for mutating and verifying image digests, and enforcing image verification through signatures.</summary>
    [JsonPropertyName("validationConfigurations")]
    public V1beta1NamespacedImageValidatingPolicySpecValidationConfigurations? ValidationConfigurations { get; set; }

    /// <summary>Validations contain CEL expressions which is used to apply the image validation checks.</summary>
    [JsonPropertyName("validations")]
    public required IList<V1beta1NamespacedImageValidatingPolicySpecValidations> Validations { get; set; }

    /// <summary>
    /// Variables contain definitions of variables that can be used in composition of other expressions.
    /// Each variable is defined as a named CEL expression.
    /// </summary>
    [JsonPropertyName("variables")]
    public IList<V1beta1NamespacedImageValidatingPolicySpecVariables>? Variables { get; set; }

    /// <summary>WebhookConfiguration defines the configuration for the webhook.</summary>
    [JsonPropertyName("webhookConfiguration")]
    public V1beta1NamespacedImageValidatingPolicySpecWebhookConfiguration? WebhookConfiguration { get; set; }
}

/// <summary>InToto defines the details of attestation attached using intoto format</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestationsIntoto
{
    /// <summary>Type defines the type of attestation contained within the statement.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Referrer defines the details of attestation attached using OCI 1.1 format</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestationsReferrer
{
    /// <summary>Type defines the type of attestation attached to the image.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Attestation defines the identification details of the  metadata that has to be verified</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestations
{
    /// <summary>InToto defines the details of attestation attached using intoto format</summary>
    [JsonPropertyName("intoto")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestationsIntoto? Intoto { get; set; }

    /// <summary>Name is the name for this attestation. It is used to refer to the attestation in verification</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Referrer defines the details of attestation attached using OCI 1.1 format</summary>
    [JsonPropertyName("referrer")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestationsReferrer? Referrer { get; set; }
}

/// <summary>Certificate is the to the public certificate for local signature verification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignCertificateCert
{
    /// <summary>Expression defines the a CEL expression input.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Value defines the raw string input.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// CertificateChain is the list of CA certificates in PEM format which will be needed
/// when building the certificate chain for the signing certificate. Must start with the
/// parent intermediate CA certificate of the signing certificate and end with the root certificate
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignCertificateCertChain
{
    /// <summary>Expression defines the a CEL expression input.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Value defines the raw string input.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Certificate defines the configuration for local signature verification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignCertificate
{
    /// <summary>Certificate is the to the public certificate for local signature verification.</summary>
    [JsonPropertyName("cert")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignCertificateCert? Cert { get; set; }

    /// <summary>
    /// CertificateChain is the list of CA certificates in PEM format which will be needed
    /// when building the certificate chain for the signing certificate. Must start with the
    /// parent intermediate CA certificate of the signing certificate and end with the root certificate
    /// </summary>
    [JsonPropertyName("certChain")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignCertificateCertChain? CertChain { get; set; }
}

/// <summary>CTLog sets the configuration to verify the authority against a Rekor instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignCtlog
{
    /// <summary>CTLogPubKey, if set, is used to validate SCTs against a custom source.</summary>
    [JsonPropertyName("ctLogPubKey")]
    public string? CtLogPubKey { get; set; }

    /// <summary>
    /// IgnoreSCT defines whether to use the Signed Certificate Timestamp (SCT) log to check for a certificate
    /// timestamp. Default is false. Set to true if this was opted out during signing.
    /// </summary>
    [JsonPropertyName("insecureIgnoreSCT")]
    public bool? InsecureIgnoreSCT { get; set; }

    /// <summary>InsecureIgnoreTlog skips transparency log verification.</summary>
    [JsonPropertyName("insecureIgnoreTlog")]
    public bool? InsecureIgnoreTlog { get; set; }

    /// <summary>
    /// RekorPubKey is an optional PEM-encoded public key to use for a custom Rekor.
    /// If set, this will be used to validate transparency log signatures from a custom Rekor.
    /// </summary>
    [JsonPropertyName("rekorPubKey")]
    public string? RekorPubKey { get; set; }

    /// <summary>
    /// TSACertChain, if set, is the PEM-encoded certificate chain file for the RFC3161 timestamp authority. Must
    /// contain the root CA certificate. Optionally may contain intermediate CA certificates, and
    /// may contain the leaf TSA certificate if not present in the timestamurce.
    /// </summary>
    [JsonPropertyName("tsaCertChain")]
    public string? TsaCertChain { get; set; }

    /// <summary>URL sets the url to the rekor instance (by default the public rekor.sigstore.dev)</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>Key defines the type of key to validate the image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignKey
{
    /// <summary>Data contains the inline public key</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>Expression is a Expression expression that returns the public key.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>
    /// HashAlgorithm specifues signature algorithm for public keys. Supported values are
    /// sha224, sha256, sha384 and sha512. Defaults to sha256.
    /// </summary>
    [JsonPropertyName("hashAlgorithm")]
    public string? HashAlgorithm { get; set; }

    /// <summary>
    /// KMS contains the KMS url of the public key
    /// Supported formats differ based on the KMS system used.
    /// </summary>
    [JsonPropertyName("kms")]
    public string? Kms { get; set; }
}

/// <summary>
/// Identity may contain the issuer and/or the subject found in the transparency
/// log.
/// Issuer/Subject uses a strict match, while IssuerRegExp and SubjectRegExp
/// apply a regexp for matching.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignKeylessIdentities
{
    /// <summary>Issuer defines the issuer for this identity.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>IssuerRegExp specifies a regular expression to match the issuer for this identity.</summary>
    [JsonPropertyName("issuerRegExp")]
    public string? IssuerRegExp { get; set; }

    /// <summary>Subject defines the subject for this identity.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>SubjectRegExp specifies a regular expression to match the subject for this identity.</summary>
    [JsonPropertyName("subjectRegExp")]
    public string? SubjectRegExp { get; set; }
}

/// <summary>Keyless sets the configuration to verify the authority against a Fulcio instance.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignKeyless
{
    /// <summary>Identities sets a list of identities.</summary>
    [JsonPropertyName("identities")]
    public required IList<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignKeylessIdentities> Identities { get; set; }

    /// <summary>
    /// Roots is an optional set of PEM encoded trusted root certificates.
    /// If not provided, the system roots are used.
    /// </summary>
    [JsonPropertyName("roots")]
    public string? Roots { get; set; }
}

/// <summary>
/// LocalObjectReference contains enough information to let you locate the
/// referenced object inside the same namespace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignSourcePullSecrets
{
    /// <summary>
    /// Name of the referent.
    /// This field is effectively required, but due to backwards compatibility is
    /// allowed to be empty. Instances of this type with an empty value here are
    /// almost certainly wrong.
    /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Sources sets the configuration to specify the sources from where to consume the signature and attestations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignSource
{
    /// <summary>
    /// SignaturePullSecrets is an optional list of references to secrets in the
    /// same namespace as the deploying resource for pulling any of the signatures
    /// used by this Source.
    /// </summary>
    [JsonPropertyName("PullSecrets")]
    public IList<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignSourcePullSecrets>? PullSecrets { get; set; }

    /// <summary>Repository defines the location from where to pull the signature / attestations.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>
    /// TagPrefix is an optional prefix that signature and attestations have.
    /// This is the &apos;tag based discovery&apos; and in the future once references are
    /// fully supported that should likely be the preferred way to handle these.
    /// </summary>
    [JsonPropertyName("tagPrefix")]
    public string? TagPrefix { get; set; }
}

/// <summary>Root defines the path or data of the trusted root</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignTufRoot
{
    /// <summary>Data is the base64 encoded TUF root</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>Path is the URL or File location of the TUF root</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>TUF defines the configuration to fetch sigstore root</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignTuf
{
    /// <summary>Mirror is the base URL of Sigstore TUF repository</summary>
    [JsonPropertyName("mirror")]
    public string? Mirror { get; set; }

    /// <summary>Root defines the path or data of the trusted root</summary>
    [JsonPropertyName("root")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignTufRoot? Root { get; set; }
}

/// <summary>Cosign defines attestor configuration for Cosign based signatures</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosign
{
    /// <summary>
    /// Annotations are used for image verification.
    /// Every specified key-value pair must exist and match in the verified payload.
    /// The payload may contain other key-value pairs.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Certificate defines the configuration for local signature verification</summary>
    [JsonPropertyName("certificate")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignCertificate? Certificate { get; set; }

    /// <summary>CTLog sets the configuration to verify the authority against a Rekor instance.</summary>
    [JsonPropertyName("ctlog")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignCtlog? Ctlog { get; set; }

    /// <summary>Key defines the type of key to validate the image.</summary>
    [JsonPropertyName("key")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignKey? Key { get; set; }

    /// <summary>Keyless sets the configuration to verify the authority against a Fulcio instance.</summary>
    [JsonPropertyName("keyless")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignKeyless? Keyless { get; set; }

    /// <summary>Sources sets the configuration to specify the sources from where to consume the signature and attestations.</summary>
    [JsonPropertyName("source")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignSource? Source { get; set; }

    /// <summary>TUF defines the configuration to fetch sigstore root</summary>
    [JsonPropertyName("tuf")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosignTuf? Tuf { get; set; }
}

/// <summary>Certs define the cert chain for Notary signature verification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsNotaryCerts
{
    /// <summary>Expression defines the a CEL expression input.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Value defines the raw string input.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>TSACerts define the cert chain for verifying timestamps of notary signature</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsNotaryTsaCerts
{
    /// <summary>Expression defines the a CEL expression input.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Value defines the raw string input.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Notary defines attestor configuration for Notary based signatures</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsNotary
{
    /// <summary>Certs define the cert chain for Notary signature verification</summary>
    [JsonPropertyName("certs")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsNotaryCerts? Certs { get; set; }

    /// <summary>TSACerts define the cert chain for verifying timestamps of notary signature</summary>
    [JsonPropertyName("tsaCerts")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsNotaryTsaCerts? TsaCerts { get; set; }
}

/// <summary>Attestor is an identity that confirms or verifies the authenticity of an image or an attestation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestors
{
    /// <summary>Cosign defines attestor configuration for Cosign based signatures</summary>
    [JsonPropertyName("cosign")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsCosign? Cosign { get; set; }

    /// <summary>Name is the name for this attestor. It is used to refer to the attestor in verification</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Notary defines attestor configuration for Notary based signatures</summary>
    [JsonPropertyName("notary")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestorsNotary? Notary { get; set; }
}

/// <summary>AuditAnnotation describes how to produce an audit annotation for an API request.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAuditAnnotations
{
    /// <summary>
    /// key specifies the audit annotation key. The audit annotation keys of
    /// a ValidatingAdmissionPolicy must be unique. The key must be a qualified
    /// name ([A-Za-z0-9][-A-Za-z0-9_.]*) no more than 63 bytes in length.
    /// 
    /// The key is combined with the resource name of the
    /// ValidatingAdmissionPolicy to construct an audit annotation key:
    /// &quot;{ValidatingAdmissionPolicy name}/{key}&quot;.
    /// 
    /// If an admission webhook uses the same resource name as this ValidatingAdmissionPolicy
    /// and the same audit annotation key, the annotation key will be identical.
    /// In this case, the first annotation written with the key will be included
    /// in the audit event and all subsequent annotations with the same key
    /// will be discarded.
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// valueExpression represents the expression which is evaluated by CEL to
    /// produce an audit annotation value. The expression must evaluate to either
    /// a string or null value. If the expression evaluates to a string, the
    /// audit annotation is included with the string value. If the expression
    /// evaluates to null or empty string the audit annotation will be omitted.
    /// The valueExpression may be no longer than 5kb in length.
    /// If the result of the valueExpression is more than 10kb in length, it
    /// will be truncated to 10kb.
    /// 
    /// If multiple ValidatingAdmissionPolicyBinding resources match an
    /// API request, then the valueExpression will be evaluated for
    /// each binding. All unique values produced by the valueExpressions
    /// will be joined together in a comma-separated list.
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("valueExpression")]
    public required string ValueExpression { get; set; }
}

/// <summary>PodControllers specifies whether to generate a pod controllers rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAutogenPodControllers
{
    [JsonPropertyName("controllers")]
    public IList<string>? Controllers { get; set; }
}

/// <summary>AutogenConfiguration defines the configuration for the generation controller.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAutogen
{
    /// <summary>PodControllers specifies whether to generate a pod controllers rules.</summary>
    [JsonPropertyName("podControllers")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAutogenPodControllers? PodControllers { get; set; }
}

/// <summary>CredentialsProvidersType provides the list of credential providers required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecCredentialsProvidersEnum>))]
public enum V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecCredentialsProvidersEnum
{
    [EnumMember(Value = "default"), JsonStringEnumMemberName("default")]
    Default,
    [EnumMember(Value = "amazon"), JsonStringEnumMemberName("amazon")]
    Amazon,
    [EnumMember(Value = "azure"), JsonStringEnumMemberName("azure")]
    Azure,
    [EnumMember(Value = "google"), JsonStringEnumMemberName("google")]
    Google,
    [EnumMember(Value = "github"), JsonStringEnumMemberName("github")]
    Github
}

/// <summary>Credentials provides credentials that will be used for authentication with registry.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecCredentials
{
    /// <summary>AllowInsecureRegistry allows insecure access to a registry.</summary>
    [JsonPropertyName("allowInsecureRegistry")]
    public bool? AllowInsecureRegistry { get; set; }

    /// <summary>
    /// Providers specifies a list of OCI Registry names, whose authentication providers are provided.
    /// It can be of one of these values: default,google,azure,amazon,github.
    /// </summary>
    [JsonPropertyName("providers")]
    public IList<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecCredentialsProvidersEnum>? Providers { get; set; }

    /// <summary>
    /// Secrets specifies a list of secrets that are provided for credentials.
    /// Secrets must live in the Kyverno namespace.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<string>? Secrets { get; set; }
}

/// <summary>Admission controls policy evaluation during admission.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecEvaluationAdmission
{
    /// <summary>
    /// Enabled controls if rules are applied during admission.
    /// Optional. Default value is &quot;true&quot;.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>Background  controls policy evaluation during background scan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecEvaluationBackground
{
    /// <summary>
    /// Enabled controls if rules are applied to existing resources during a background scan.
    /// Optional. Default value is &quot;true&quot;. The value must be set to &quot;false&quot; if the policy rule
    /// uses variables that are only available in the admission review request (e.g. user name).
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>EvaluationConfiguration defines the configuration for the policy evaluation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecEvaluation
{
    /// <summary>Admission controls policy evaluation during admission.</summary>
    [JsonPropertyName("admission")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecEvaluationAdmission? Admission { get; set; }

    /// <summary>Background  controls policy evaluation during background scan.</summary>
    [JsonPropertyName("background")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecEvaluationBackground? Background { get; set; }

    /// <summary>
    /// Mode is the mode of policy evaluation.
    /// Allowed values are &quot;Kubernetes&quot; or &quot;JSON&quot;.
    /// Optional. Default value is &quot;Kubernetes&quot;.
    /// </summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// FailurePolicy defines how to handle failures for the admission policy. Failures can
/// occur from CEL expression parse errors, type check errors, runtime errors and invalid
/// or mis-configured policy definitions or bindings.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecFailurePolicyEnum>))]
public enum V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecFailurePolicyEnum
{
    [EnumMember(Value = "Ignore"), JsonStringEnumMemberName("Ignore")]
    Ignore,
    [EnumMember(Value = "Fail"), JsonStringEnumMemberName("Fail")]
    Fail
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecImages
{
    /// <summary>Expression defines CEL expression to extract images from the resource.</summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>Name is the name for this imageList. It is used to refer to the images in verification block as images.&lt;name&gt;</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>MatchCondition represents a condition which must by fulfilled for a request to be sent to a webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchConditions
{
    /// <summary>
    /// Expression represents the expression which will be evaluated by CEL. Must evaluate to bool.
    /// CEL expressions have access to the contents of the AdmissionRequest and Authorizer, organized into CEL variables:
    /// 
    /// &apos;object&apos; - The object from the incoming request. The value is null for DELETE requests.
    /// &apos;oldObject&apos; - The existing object. The value is null for CREATE requests.
    /// &apos;request&apos; - Attributes of the admission request(/pkg/apis/admission/types.go#AdmissionRequest).
    /// &apos;authorizer&apos; - A CEL Authorizer. May be used to perform authorization checks for the principal (user or service account) of the request.
    ///   See https://pkg.go.dev/k8s.io/apiserver/pkg/cel/library#Authz
    /// &apos;authorizer.requestResource&apos; - A CEL ResourceCheck constructed from the &apos;authorizer&apos; and configured with the
    ///   request resource.
    /// Documentation on CEL: https://kubernetes.io/docs/reference/using-api/cel/
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Name is an identifier for this match condition, used for strategic merging of MatchConditions,
    /// as well as providing an identifier for logging purposes. A good name should be descriptive of
    /// the associated expression.
    /// Name must be a qualified name consisting of alphanumeric characters, &apos;-&apos;, &apos;_&apos; or &apos;.&apos;, and
    /// must start and end with an alphanumeric character (e.g. &apos;MyName&apos;,  or &apos;my.name&apos;,  or
    /// &apos;123-abc&apos;, regex used for validation is &apos;([A-Za-z0-9][-A-Za-z0-9_.]*)?[A-Za-z0-9]&apos;) with an
    /// optional DNS subdomain prefix and &apos;/&apos; (e.g. &apos;example.com/MyName&apos;)
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>NamedRuleWithOperations is a tuple of Operations and Resources with ResourceNames.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsExcludeResourceRules
{
    /// <summary>
    /// APIGroups is the API groups the resources belong to. &apos;*&apos; is all groups.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("apiGroups")]
    public IList<string>? ApiGroups { get; set; }

    /// <summary>
    /// APIVersions is the API versions the resources belong to. &apos;*&apos; is all versions.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>
    /// Operations is the operations the admission hook cares about - CREATE, UPDATE, DELETE, CONNECT or *
    /// for all of those operations and any future admission operations that are added.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<string>? Operations { get; set; }

    /// <summary>ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.</summary>
    [JsonPropertyName("resourceNames")]
    public IList<string>? ResourceNames { get; set; }

    /// <summary>
    /// Resources is a list of resources this rule applies to.
    /// 
    /// For example:
    /// &apos;pods&apos; means pods.
    /// &apos;pods/log&apos; means the log subresource of pods.
    /// &apos;*&apos; means all resources, but not subresources.
    /// &apos;pods/*&apos; means all subresources of pods.
    /// &apos;*/scale&apos; means all scale subresources.
    /// &apos;*/*&apos; means all resources and their subresources.
    /// 
    /// If wildcard is present, the validation rule will ensure resources do not
    /// overlap with each other.
    /// 
    /// Depending on the enclosing object, subresources might not be allowed.
    /// Required.
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// scope specifies the scope of this rule.
    /// Valid values are &quot;Cluster&quot;, &quot;Namespaced&quot;, and &quot;*&quot;
    /// &quot;Cluster&quot; means that only cluster-scoped resources will match this rule.
    /// Namespace API objects are cluster-scoped.
    /// &quot;Namespaced&quot; means that only namespaced resources will match this rule.
    /// &quot;*&quot; means that there are no scope restrictions.
    /// Subresources match the scope of their parent resource.
    /// Default is &quot;*&quot;.
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsNamespaceSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// NamespaceSelector decides whether to run the admission control policy on an object based
/// on whether the namespace for that object matches the selector. If the
/// object itself is a namespace, the matching is performed on
/// object.metadata.labels. If the object is another cluster scoped resource,
/// it never skips the policy.
/// 
/// For example, to run the webhook on any objects whose namespace is not
/// associated with &quot;runlevel&quot; of &quot;0&quot; or &quot;1&quot;;  you will set the selector as
/// follows:
/// &quot;namespaceSelector&quot;: {
///   &quot;matchExpressions&quot;: [
///     {
///       &quot;key&quot;: &quot;runlevel&quot;,
///       &quot;operator&quot;: &quot;NotIn&quot;,
///       &quot;values&quot;: [
///         &quot;0&quot;,
///         &quot;1&quot;
///       ]
///     }
///   ]
/// }
/// 
/// If instead you want to only run the policy on any objects whose
/// namespace is associated with the &quot;environment&quot; of &quot;prod&quot; or &quot;staging&quot;;
/// you will set the selector as follows:
/// &quot;namespaceSelector&quot;: {
///   &quot;matchExpressions&quot;: [
///     {
///       &quot;key&quot;: &quot;environment&quot;,
///       &quot;operator&quot;: &quot;In&quot;,
///       &quot;values&quot;: [
///         &quot;prod&quot;,
///         &quot;staging&quot;
///       ]
///     }
///   ]
/// }
/// 
/// See
/// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/
/// for more examples of label selectors.
/// 
/// Default to the empty LabelSelector, which matches everything.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsNamespaceSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>
/// A label selector requirement is a selector that contains values, a key, and an operator that
/// relates the key and values.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsObjectSelectorMatchExpressions
{
    /// <summary>key is the label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// operator represents a key&apos;s relationship to a set of values.
    /// Valid operators are In, NotIn, Exists and DoesNotExist.
    /// </summary>
    [JsonPropertyName("operator")]
    public required string Operator { get; set; }

    /// <summary>
    /// values is an array of string values. If the operator is In or NotIn,
    /// the values array must be non-empty. If the operator is Exists or DoesNotExist,
    /// the values array must be empty. This array is replaced during a strategic
    /// merge patch.
    /// </summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>
/// ObjectSelector decides whether to run the validation based on if the
/// object has matching labels. objectSelector is evaluated against both
/// the oldObject and newObject that would be sent to the cel validation, and
/// is considered to match if either object matches the selector. A null
/// object (oldObject in the case of create, or newObject in the case of
/// delete) or an object that cannot have labels (like a
/// DeploymentRollback or a PodProxyOptions object) is not considered to
/// match.
/// Use the object selector only if the webhook is opt-in, because end
/// users may skip the admission webhook by setting the labels.
/// Default to the empty LabelSelector, which matches everything.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsObjectSelector
{
    /// <summary>matchExpressions is a list of label selector requirements. The requirements are ANDed.</summary>
    [JsonPropertyName("matchExpressions")]
    public IList<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsObjectSelectorMatchExpressions>? MatchExpressions { get; set; }

    /// <summary>
    /// matchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels
    /// map is equivalent to an element of matchExpressions, whose key field is &quot;key&quot;, the
    /// operator is &quot;In&quot;, and the values array contains only &quot;value&quot;. The requirements are ANDed.
    /// </summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

/// <summary>NamedRuleWithOperations is a tuple of Operations and Resources with ResourceNames.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsResourceRules
{
    /// <summary>
    /// APIGroups is the API groups the resources belong to. &apos;*&apos; is all groups.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("apiGroups")]
    public IList<string>? ApiGroups { get; set; }

    /// <summary>
    /// APIVersions is the API versions the resources belong to. &apos;*&apos; is all versions.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("apiVersions")]
    public IList<string>? ApiVersions { get; set; }

    /// <summary>
    /// Operations is the operations the admission hook cares about - CREATE, UPDATE, DELETE, CONNECT or *
    /// for all of those operations and any future admission operations that are added.
    /// If &apos;*&apos; is present, the length of the slice must be one.
    /// Required.
    /// </summary>
    [JsonPropertyName("operations")]
    public IList<string>? Operations { get; set; }

    /// <summary>ResourceNames is an optional white list of names that the rule applies to.  An empty set means that everything is allowed.</summary>
    [JsonPropertyName("resourceNames")]
    public IList<string>? ResourceNames { get; set; }

    /// <summary>
    /// Resources is a list of resources this rule applies to.
    /// 
    /// For example:
    /// &apos;pods&apos; means pods.
    /// &apos;pods/log&apos; means the log subresource of pods.
    /// &apos;*&apos; means all resources, but not subresources.
    /// &apos;pods/*&apos; means all subresources of pods.
    /// &apos;*/scale&apos; means all scale subresources.
    /// &apos;*/*&apos; means all resources and their subresources.
    /// 
    /// If wildcard is present, the validation rule will ensure resources do not
    /// overlap with each other.
    /// 
    /// Depending on the enclosing object, subresources might not be allowed.
    /// Required.
    /// </summary>
    [JsonPropertyName("resources")]
    public IList<string>? Resources { get; set; }

    /// <summary>
    /// scope specifies the scope of this rule.
    /// Valid values are &quot;Cluster&quot;, &quot;Namespaced&quot;, and &quot;*&quot;
    /// &quot;Cluster&quot; means that only cluster-scoped resources will match this rule.
    /// Namespace API objects are cluster-scoped.
    /// &quot;Namespaced&quot; means that only namespaced resources will match this rule.
    /// &quot;*&quot; means that there are no scope restrictions.
    /// Subresources match the scope of their parent resource.
    /// Default is &quot;*&quot;.
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }
}

/// <summary>MatchConstraints specifies what resources this policy is designed to validate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchConstraints
{
    /// <summary>
    /// ExcludeResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy should not care about.
    /// The exclude rules take precedence over include rules (if a resource matches both, it is excluded)
    /// </summary>
    [JsonPropertyName("excludeResourceRules")]
    public IList<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsExcludeResourceRules>? ExcludeResourceRules { get; set; }

    /// <summary>
    /// matchPolicy defines how the &quot;MatchResources&quot; list is used to match incoming requests.
    /// Allowed values are &quot;Exact&quot; or &quot;Equivalent&quot;.
    /// 
    /// - Exact: match a request only if it exactly matches a specified rule.
    /// For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1,
    /// but &quot;rules&quot; only included `apiGroups:[&quot;apps&quot;], apiVersions:[&quot;v1&quot;], resources: [&quot;deployments&quot;]`,
    /// a request to apps/v1beta1 or extensions/v1beta1 would not be sent to the ValidatingAdmissionPolicy.
    /// 
    /// - Equivalent: match a request if modifies a resource listed in rules, even via another API group or version.
    /// For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1,
    /// and &quot;rules&quot; only included `apiGroups:[&quot;apps&quot;], apiVersions:[&quot;v1&quot;], resources: [&quot;deployments&quot;]`,
    /// a request to apps/v1beta1 or extensions/v1beta1 would be converted to apps/v1 and sent to the ValidatingAdmissionPolicy.
    /// 
    /// Defaults to &quot;Equivalent&quot;
    /// </summary>
    [JsonPropertyName("matchPolicy")]
    public string? MatchPolicy { get; set; }

    /// <summary>
    /// NamespaceSelector decides whether to run the admission control policy on an object based
    /// on whether the namespace for that object matches the selector. If the
    /// object itself is a namespace, the matching is performed on
    /// object.metadata.labels. If the object is another cluster scoped resource,
    /// it never skips the policy.
    /// 
    /// For example, to run the webhook on any objects whose namespace is not
    /// associated with &quot;runlevel&quot; of &quot;0&quot; or &quot;1&quot;;  you will set the selector as
    /// follows:
    /// &quot;namespaceSelector&quot;: {
    ///   &quot;matchExpressions&quot;: [
    ///     {
    ///       &quot;key&quot;: &quot;runlevel&quot;,
    ///       &quot;operator&quot;: &quot;NotIn&quot;,
    ///       &quot;values&quot;: [
    ///         &quot;0&quot;,
    ///         &quot;1&quot;
    ///       ]
    ///     }
    ///   ]
    /// }
    /// 
    /// If instead you want to only run the policy on any objects whose
    /// namespace is associated with the &quot;environment&quot; of &quot;prod&quot; or &quot;staging&quot;;
    /// you will set the selector as follows:
    /// &quot;namespaceSelector&quot;: {
    ///   &quot;matchExpressions&quot;: [
    ///     {
    ///       &quot;key&quot;: &quot;environment&quot;,
    ///       &quot;operator&quot;: &quot;In&quot;,
    ///       &quot;values&quot;: [
    ///         &quot;prod&quot;,
    ///         &quot;staging&quot;
    ///       ]
    ///     }
    ///   ]
    /// }
    /// 
    /// See
    /// https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/
    /// for more examples of label selectors.
    /// 
    /// Default to the empty LabelSelector, which matches everything.
    /// </summary>
    [JsonPropertyName("namespaceSelector")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsNamespaceSelector? NamespaceSelector { get; set; }

    /// <summary>
    /// ObjectSelector decides whether to run the validation based on if the
    /// object has matching labels. objectSelector is evaluated against both
    /// the oldObject and newObject that would be sent to the cel validation, and
    /// is considered to match if either object matches the selector. A null
    /// object (oldObject in the case of create, or newObject in the case of
    /// delete) or an object that cannot have labels (like a
    /// DeploymentRollback or a PodProxyOptions object) is not considered to
    /// match.
    /// Use the object selector only if the webhook is opt-in, because end
    /// users may skip the admission webhook by setting the labels.
    /// Default to the empty LabelSelector, which matches everything.
    /// </summary>
    [JsonPropertyName("objectSelector")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsObjectSelector? ObjectSelector { get; set; }

    /// <summary>
    /// ResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy matches.
    /// The policy cares about an operation if it matches _any_ Rule.
    /// </summary>
    [JsonPropertyName("resourceRules")]
    public IList<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchConstraintsResourceRules>? ResourceRules { get; set; }
}

/// <summary>MatchImageReference defines a Glob or a CEL expression for matching images</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchImageReferences
{
    /// <summary>Expression defines CEL Expressions for matching images</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Glob defines a globbing pattern for matching images</summary>
    [JsonPropertyName("glob")]
    public string? Glob { get; set; }
}

/// <summary>ValidationAction specifies a policy enforcement action.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecValidationActionsEnum>))]
public enum V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecValidationActionsEnum
{
    [EnumMember(Value = "Deny"), JsonStringEnumMemberName("Deny")]
    Deny,
    [EnumMember(Value = "Audit"), JsonStringEnumMemberName("Audit")]
    Audit,
    [EnumMember(Value = "Warn"), JsonStringEnumMemberName("Warn")]
    Warn
}

/// <summary>ValidationConfigurations defines settings for mutating and verifying image digests, and enforcing image verification through signatures.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecValidationConfigurations
{
    /// <summary>
    /// MutateDigest enables replacement of image tags with digests.
    /// Defaults to true.
    /// </summary>
    [JsonPropertyName("mutateDigest")]
    public bool? MutateDigest { get; set; }

    /// <summary>Required validates that images are verified, i.e., have passed a signature or attestation check.</summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    /// <summary>VerifyDigest validates that images have a digest.</summary>
    [JsonPropertyName("verifyDigest")]
    public bool? VerifyDigest { get; set; }
}

/// <summary>Validation specifies the CEL expression which is used to apply the validation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecValidations
{
    /// <summary>
    /// Expression represents the expression which will be evaluated by CEL.
    /// ref: https://github.com/google/cel-spec
    /// CEL expressions have access to the contents of the API request/response, organized into CEL variables as well as some other useful variables:
    /// 
    /// - &apos;object&apos; - The object from the incoming request. The value is null for DELETE requests.
    /// - &apos;oldObject&apos; - The existing object. The value is null for CREATE requests.
    /// - &apos;request&apos; - Attributes of the API request([ref](/pkg/apis/admission/types.go#AdmissionRequest)).
    /// - &apos;params&apos; - Parameter resource referred to by the policy binding being evaluated. Only populated if the policy has a ParamKind.
    /// - &apos;namespaceObject&apos; - The namespace object that the incoming object belongs to. The value is null for cluster-scoped resources.
    /// - &apos;variables&apos; - Map of composited variables, from its name to its lazily evaluated value.
    ///   For example, a variable named &apos;foo&apos; can be accessed as &apos;variables.foo&apos;.
    /// - &apos;authorizer&apos; - A CEL Authorizer. May be used to perform authorization checks for the principal (user or service account) of the request.
    ///   See https://pkg.go.dev/k8s.io/apiserver/pkg/cel/library#Authz
    /// - &apos;authorizer.requestResource&apos; - A CEL ResourceCheck constructed from the &apos;authorizer&apos; and configured with the
    ///   request resource.
    /// 
    /// The `apiVersion`, `kind`, `metadata.name` and `metadata.generateName` are always accessible from the root of the
    /// object. No other metadata properties are accessible.
    /// 
    /// Only property names of the form `[a-zA-Z_.-/][a-zA-Z0-9_.-/]*` are accessible.
    /// Accessible property names are escaped according to the following rules when accessed in the expression:
    /// - &apos;__&apos; escapes to &apos;__underscores__&apos;
    /// - &apos;.&apos; escapes to &apos;__dot__&apos;
    /// - &apos;-&apos; escapes to &apos;__dash__&apos;
    /// - &apos;/&apos; escapes to &apos;__slash__&apos;
    /// - Property names that exactly match a CEL RESERVED keyword escape to &apos;__{keyword}__&apos;. The keywords are:
    /// 	  &quot;true&quot;, &quot;false&quot;, &quot;null&quot;, &quot;in&quot;, &quot;as&quot;, &quot;break&quot;, &quot;const&quot;, &quot;continue&quot;, &quot;else&quot;, &quot;for&quot;, &quot;function&quot;, &quot;if&quot;,
    /// 	  &quot;import&quot;, &quot;let&quot;, &quot;loop&quot;, &quot;package&quot;, &quot;namespace&quot;, &quot;return&quot;.
    /// Examples:
    ///   - Expression accessing a property named &quot;namespace&quot;: {&quot;Expression&quot;: &quot;object.__namespace__ &gt; 0&quot;}
    ///   - Expression accessing a property named &quot;x-prop&quot;: {&quot;Expression&quot;: &quot;object.x__dash__prop &gt; 0&quot;}
    ///   - Expression accessing a property named &quot;redact__d&quot;: {&quot;Expression&quot;: &quot;object.redact__underscores__d &gt; 0&quot;}
    /// 
    /// Equality on arrays with list type of &apos;set&apos; or &apos;map&apos; ignores element order, i.e. [1, 2] == [2, 1].
    /// Concatenation on arrays with x-kubernetes-list-type use the semantics of the list type:
    ///   - &apos;set&apos;: `X + Y` performs a union where the array positions of all elements in `X` are preserved and
    ///     non-intersecting elements in `Y` are appended, retaining their partial order.
    ///   - &apos;map&apos;: `X + Y` performs a merge where the array positions of all keys in `X` are preserved but the values
    ///     are overwritten by values in `Y` when the key sets of `X` and `Y` intersect. Elements in `Y` with
    ///     non-intersecting keys are appended, retaining their partial order.
    /// Required.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Message represents the message displayed when validation fails. The message is required if the Expression contains
    /// line breaks. The message must not contain line breaks.
    /// If unset, the message is &quot;failed rule: {Rule}&quot;.
    /// e.g. &quot;must be a URL with the host matching spec.host&quot;
    /// If the Expression contains line breaks. Message is required.
    /// The message must not contain line breaks.
    /// If unset, the message is &quot;failed Expression: {Expression}&quot;.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// messageExpression declares a CEL expression that evaluates to the validation failure message that is returned when this rule fails.
    /// Since messageExpression is used as a failure message, it must evaluate to a string.
    /// If both message and messageExpression are present on a validation, then messageExpression will be used if validation fails.
    /// If messageExpression results in a runtime error, the runtime error is logged, and the validation failure message is produced
    /// as if the messageExpression field were unset. If messageExpression evaluates to an empty string, a string with only spaces, or a string
    /// that contains line breaks, then the validation failure message will also be produced as if the messageExpression field were unset, and
    /// the fact that messageExpression produced an empty string/string with only spaces/string with line breaks will be logged.
    /// messageExpression has access to all the same variables as the `expression` except for &apos;authorizer&apos; and &apos;authorizer.requestResource&apos;.
    /// Example:
    /// &quot;object.x must be less than max (&quot;+string(params.max)+&quot;)&quot;
    /// </summary>
    [JsonPropertyName("messageExpression")]
    public string? MessageExpression { get; set; }

    /// <summary>
    /// Reason represents a machine-readable description of why this validation failed.
    /// If this is the first validation in the list to fail, this reason, as well as the
    /// corresponding HTTP response code, are used in the
    /// HTTP response to the client.
    /// The currently supported reasons are: &quot;Unauthorized&quot;, &quot;Forbidden&quot;, &quot;Invalid&quot;, &quot;RequestEntityTooLarge&quot;.
    /// If not set, StatusReasonInvalid is used in the response to the client.
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary>Variable is the definition of a variable that is used for composition. A variable is defined as a named expression.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecVariables
{
    /// <summary>
    /// Expression is the expression that will be evaluated as the value of the variable.
    /// The CEL expression has access to the same identifiers as the CEL expressions in Validation.
    /// </summary>
    [JsonPropertyName("expression")]
    public required string Expression { get; set; }

    /// <summary>
    /// Name is the name of the variable. The name must be a valid CEL identifier and unique among all variables.
    /// The variable can be accessed in other expressions through `variables`
    /// For example, if name is &quot;foo&quot;, the variable will be available as `variables.foo`
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>WebhookConfiguration defines the configuration for the webhook.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecWebhookConfiguration
{
    /// <summary>
    /// TimeoutSeconds specifies the maximum time in seconds allowed to apply this policy.
    /// After the configured time expires, the admission request may fail, or may simply ignore the policy results,
    /// based on the failure policy. The default timeout is 10s, the value must be between 1 and 30 seconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

/// <summary>ImageValidatingPolicySpec is the specification of the desired behavior of the ImageValidatingPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpec
{
    /// <summary>Attestations provides a list of image metadata to verify</summary>
    [JsonPropertyName("attestations")]
    public IList<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestations>? Attestations { get; set; }

    /// <summary>Attestors provides a list of trusted authorities.</summary>
    [JsonPropertyName("attestors")]
    public required IList<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAttestors> Attestors { get; set; }

    /// <summary>
    /// auditAnnotations contains CEL expressions which are used to produce audit
    /// annotations for the audit event of the API request.
    /// validations and auditAnnotations may not both be empty; a least one of validations or auditAnnotations is
    /// required.
    /// </summary>
    [JsonPropertyName("auditAnnotations")]
    public IList<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAuditAnnotations>? AuditAnnotations { get; set; }

    /// <summary>AutogenConfiguration defines the configuration for the generation controller.</summary>
    [JsonPropertyName("autogen")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecAutogen? Autogen { get; set; }

    /// <summary>Credentials provides credentials that will be used for authentication with registry.</summary>
    [JsonPropertyName("credentials")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecCredentials? Credentials { get; set; }

    /// <summary>EvaluationConfiguration defines the configuration for the policy evaluation.</summary>
    [JsonPropertyName("evaluation")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecEvaluation? Evaluation { get; set; }

    /// <summary>
    /// FailurePolicy defines how to handle failures for the admission policy. Failures can
    /// occur from CEL expression parse errors, type check errors, runtime errors and invalid
    /// or mis-configured policy definitions or bindings.
    /// </summary>
    [JsonPropertyName("failurePolicy")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecFailurePolicyEnum? FailurePolicy { get; set; }

    /// <summary>ImageExtractors is a list of CEL expression to extract images from the resource</summary>
    [JsonPropertyName("images")]
    public IList<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecImages>? Images { get; set; }

    /// <summary>
    /// MatchConditions is a list of conditions that must be met for a request to be validated.
    /// Match conditions filter requests that have already been matched by the rules,
    /// namespaceSelector, and objectSelector. An empty list of matchConditions matches all requests.
    /// There are a maximum of 64 match conditions allowed.
    /// </summary>
    [JsonPropertyName("matchConditions")]
    public IList<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchConditions>? MatchConditions { get; set; }

    /// <summary>MatchConstraints specifies what resources this policy is designed to validate.</summary>
    [JsonPropertyName("matchConstraints")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchConstraints? MatchConstraints { get; set; }

    /// <summary>
    /// MatchImageReferences is a list of Glob and CELExpressions to match images.
    /// Any image that matches one of the rules is considered for validation
    /// Any image that does not match a rule is skipped, even when they are passed as arguments to
    /// image verification functions
    /// </summary>
    [JsonPropertyName("matchImageReferences")]
    public IList<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecMatchImageReferences>? MatchImageReferences { get; set; }

    /// <summary>
    /// ValidationAction specifies the action to be taken when the matched resource violates the policy.
    /// If a validation evaluates to false it is always enforced according to these actions.
    /// 
    /// Failures defined by the ValidatingAdmissionPolicy&apos;s FailurePolicy are enforced according
    /// to these actions only if the FailurePolicy is set to Fail, otherwise the failures are
    /// ignored. This includes compilation errors, runtime errors and misconfigurations of the policy.
    /// 
    /// validationActions is declared as a set of action values. Order does
    /// not matter. validationActions may not contain duplicates of the same action.
    /// 
    /// The supported actions values are:
    /// 
    /// &quot;Deny&quot; specifies that a validation failure results in a denied request.
    /// 
    /// &quot;Warn&quot; specifies that a validation failure is reported to the request client
    /// in HTTP Warning headers, with a warning code of 299. Warnings can be sent
    /// both for allowed or denied admission responses.
    /// 
    /// &quot;Audit&quot; specifies that a validation failure is recorded in the created reports.
    /// 
    /// Clients should expect to handle additional values by ignoring
    /// any values not recognized.
    /// 
    /// &quot;Deny&quot; and &quot;Warn&quot; may not be used together since this combination
    /// needlessly duplicates the validation failure both in the
    /// API response body and the HTTP warning headers.
    /// 
    /// Required.
    /// </summary>
    [JsonPropertyName("validationActions")]
    public IList<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecValidationActionsEnum>? ValidationActions { get; set; }

    /// <summary>ValidationConfigurations defines settings for mutating and verifying image digests, and enforcing image verification through signatures.</summary>
    [JsonPropertyName("validationConfigurations")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecValidationConfigurations? ValidationConfigurations { get; set; }

    /// <summary>Validations contain CEL expressions which is used to apply the image validation checks.</summary>
    [JsonPropertyName("validations")]
    public required IList<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecValidations> Validations { get; set; }

    /// <summary>
    /// Variables contain definitions of variables that can be used in composition of other expressions.
    /// Each variable is defined as a named CEL expression.
    /// </summary>
    [JsonPropertyName("variables")]
    public IList<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecVariables>? Variables { get; set; }

    /// <summary>WebhookConfiguration defines the configuration for the webhook.</summary>
    [JsonPropertyName("webhookConfiguration")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpecWebhookConfiguration? WebhookConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsTargets
{
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    [JsonPropertyName("resource")]
    public required string Resource { get; set; }

    [JsonPropertyName("version")]
    public required string Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigs
{
    /// <summary>ImageValidatingPolicySpec is the specification of the desired behavior of the ImageValidatingPolicy.</summary>
    [JsonPropertyName("spec")]
    public required V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsSpec Spec { get; set; }

    [JsonPropertyName("targets")]
    public required IList<V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigsTargets> Targets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusAutogen
{
    [JsonPropertyName("configs")]
    public IDictionary<string, V1beta1NamespacedImageValidatingPolicyStatusAutogenConfigs>? Configs { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1NamespacedImageValidatingPolicyStatusConditionStatusConditionsStatusEnum>))]
public enum V1beta1NamespacedImageValidatingPolicyStatusConditionStatusConditionsStatusEnum
{
    [EnumMember(Value = "True"), JsonStringEnumMemberName("True")]
    True,
    [EnumMember(Value = "False"), JsonStringEnumMemberName("False")]
    False,
    [EnumMember(Value = "Unknown"), JsonStringEnumMemberName("Unknown")]
    Unknown
}

/// <summary>Condition contains details for one aspect of the current state of this API Resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusConditionStatusConditions
{
    /// <summary>
    /// lastTransitionTime is the last time the condition transitioned from one status to another.
    /// This should be when the underlying condition changed.  If that is not known, then using the time when the API field changed is acceptable.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// message is a human readable message indicating details about the transition.
    /// This may be an empty string.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// observedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// reason contains a programmatic identifier indicating the reason for the condition&apos;s last transition.
    /// Producers of specific condition types may define expected values and meanings for this field,
    /// and whether the values are considered a guaranteed API.
    /// The value should be a CamelCase string.
    /// This field may not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required V1beta1NamespacedImageValidatingPolicyStatusConditionStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ConditionStatus is the shared status across all policy types</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatusConditionStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1beta1NamespacedImageValidatingPolicyStatusConditionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Message is a human readable message indicating details about the generation of ValidatingAdmissionPolicy/MutatingAdmissionPolicy
    /// It is an empty string when ValidatingAdmissionPolicy/MutatingAdmissionPolicy is successfully generated.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// The ready of a policy is a high-level summary of where the policy is in its lifecycle.
    /// The conditions array, the reason and message fields contain more detail about the policy&apos;s status.
    /// </summary>
    [JsonPropertyName("ready")]
    public bool? Ready { get; set; }
}

/// <summary>Status contains policy runtime data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1NamespacedImageValidatingPolicyStatus
{
    [JsonPropertyName("autogen")]
    public V1beta1NamespacedImageValidatingPolicyStatusAutogen? Autogen { get; set; }

    /// <summary>ConditionStatus is the shared status across all policy types</summary>
    [JsonPropertyName("conditionStatus")]
    public V1beta1NamespacedImageValidatingPolicyStatusConditionStatus? ConditionStatus { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1NamespacedImageValidatingPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1NamespacedImageValidatingPolicySpec>, IStatus<V1beta1NamespacedImageValidatingPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "NamespacedImageValidatingPolicy";
    public const string KubeGroup = "policies.kyverno.io";
    public const string KubePluralName = "namespacedimagevalidatingpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "policies.kyverno.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "NamespacedImageValidatingPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ImageValidatingPolicySpec is the specification of the desired behavior of the ImageValidatingPolicy.</summary>
    [JsonPropertyName("spec")]
    public required V1beta1NamespacedImageValidatingPolicySpec Spec { get; set; }

    /// <summary>Status contains policy runtime data.</summary>
    [JsonPropertyName("status")]
    public V1beta1NamespacedImageValidatingPolicyStatus? Status { get; set; }
}