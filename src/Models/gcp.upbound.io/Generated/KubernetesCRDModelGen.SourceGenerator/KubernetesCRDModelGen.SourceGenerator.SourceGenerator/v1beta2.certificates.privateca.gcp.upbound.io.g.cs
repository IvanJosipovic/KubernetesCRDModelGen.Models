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
/// <summary>Certificate is the Schema for the Certificates API. A Certificate corresponds to a signed X.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2CertificateList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Certificate>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "CertificateList";
    public const string KubeGroup = "privateca.gcp.upbound.io";
    public const string KubePluralName = "certificates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "privateca.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CertificateList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Certificate objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Certificate> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecDeletionPolicyEnum>))]
public enum V1beta2CertificateSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderCertificateAuthorityRefPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecForProviderCertificateAuthorityRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderCertificateAuthorityRefPolicyResolveEnum>))]
public enum V1beta2CertificateSpecForProviderCertificateAuthorityRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderCertificateAuthorityRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecForProviderCertificateAuthorityRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecForProviderCertificateAuthorityRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CertificateAuthority in privateca to populate certificateAuthority.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderCertificateAuthorityRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CertificateSpecForProviderCertificateAuthorityRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderCertificateAuthoritySelectorPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecForProviderCertificateAuthoritySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderCertificateAuthoritySelectorPolicyResolveEnum>))]
public enum V1beta2CertificateSpecForProviderCertificateAuthoritySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderCertificateAuthoritySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecForProviderCertificateAuthoritySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecForProviderCertificateAuthoritySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CertificateAuthority in privateca to populate certificateAuthority.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderCertificateAuthoritySelector
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
    public V1beta2CertificateSpecForProviderCertificateAuthoritySelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderCertificateTemplateRefPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecForProviderCertificateTemplateRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderCertificateTemplateRefPolicyResolveEnum>))]
public enum V1beta2CertificateSpecForProviderCertificateTemplateRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderCertificateTemplateRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecForProviderCertificateTemplateRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecForProviderCertificateTemplateRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CertificateTemplate in privateca to populate certificateTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderCertificateTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CertificateSpecForProviderCertificateTemplateRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderCertificateTemplateSelectorPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecForProviderCertificateTemplateSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderCertificateTemplateSelectorPolicyResolveEnum>))]
public enum V1beta2CertificateSpecForProviderCertificateTemplateSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderCertificateTemplateSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecForProviderCertificateTemplateSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecForProviderCertificateTemplateSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CertificateTemplate in privateca to populate certificateTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderCertificateTemplateSelector
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
    public V1beta2CertificateSpecForProviderCertificateTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary>Required. A public key. When this is specified in a request, the padding and encoding can be any of the options described by the respective &apos;KeyType&apos; value. When this is generated by the service, it will always be an RFC 5280 SubjectPublicKeyInfo structure containing an algorithm identifier and a key. A base64-encoded string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderConfigPublicKeyKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// A PublicKey describes a public key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderConfigPublicKey
{
    /// <summary>
    /// The format of the public key. Currently, only PEM format is supported.
    /// Possible values are: KEY_TYPE_UNSPECIFIED, PEM.
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Required. A public key. When this is specified in a request, the padding and encoding can be any of the options described by the respective &apos;KeyType&apos; value. When this is generated by the service, it will always be an RFC 5280 SubjectPublicKeyInfo structure containing an algorithm identifier and a key. A base64-encoded string.</summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta2CertificateSpecForProviderConfigPublicKeyKeySecretRef? KeySecretRef { get; set; }
}

/// <summary>
/// (Output)
/// Contains distinguished name fields such as the location and organization.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderConfigSubjectConfigSubject
{
    /// <summary>The common name of the distinguished name.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>The country code of the subject.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The locality or city of the subject.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>The organization of the subject.</summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>The organizational unit of the subject.</summary>
    [JsonPropertyName("organizationalUnit")]
    public string? OrganizationalUnit { get; set; }

    /// <summary>The postal code of the subject.</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>The province, territory, or regional state of the subject.</summary>
    [JsonPropertyName("province")]
    public string? Province { get; set; }

    /// <summary>The street address of the subject.</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }
}

/// <summary>
/// (Output)
/// The subject alternative name fields.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderConfigSubjectConfigSubjectAltName
{
    /// <summary>Contains only valid, fully-qualified host names.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string>? DnsNames { get; set; }

    /// <summary>Contains only valid RFC 2822 E-mail addresses.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>Contains only valid 32-bit IPv4 addresses or RFC 4291 IPv6 addresses.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>Contains only valid RFC 3986 URIs.</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary>
/// Specifies some of the values in a certificate that are related to the subject.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderConfigSubjectConfig
{
    /// <summary>
    /// (Output)
    /// Contains distinguished name fields such as the location and organization.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subject")]
    public V1beta2CertificateSpecForProviderConfigSubjectConfigSubject? Subject { get; set; }

    /// <summary>
    /// (Output)
    /// The subject alternative name fields.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subjectAltName")]
    public V1beta2CertificateSpecForProviderConfigSubjectConfigSubjectAltName? SubjectAltName { get; set; }
}

/// <summary>
/// When specified this provides a custom SKI to be used in the certificate. This should only be used to maintain a SKI of an existing CA originally created outside CA service, which was not generated using method (1) described in RFC 5280 section 4.2.1.2..
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderConfigSubjectKeyId
{
    /// <summary>The value of the KeyId in lowercase hexadecimal.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

/// <summary>
/// Describes values that are relevant in a CA certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderConfigX509ConfigAdditionalExtensionsObjectId
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderConfigX509ConfigAdditionalExtensions
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>
    /// Describes values that are relevant in a CA certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objectId")]
    public V1beta2CertificateSpecForProviderConfigX509ConfigAdditionalExtensionsObjectId? ObjectId { get; set; }

    /// <summary>
    /// (Output)
    /// The value of this X.509 extension.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// (Output)
/// Describes values that are relevant in a CA certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderConfigX509ConfigCaOptions
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
public partial class V1beta2CertificateSpecForProviderConfigX509ConfigKeyUsageBaseKeyUsage
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
public partial class V1beta2CertificateSpecForProviderConfigX509ConfigKeyUsageExtendedKeyUsage
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
public partial class V1beta2CertificateSpecForProviderConfigX509ConfigKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// (Output)
/// Indicates the intended use for keys that correspond to a certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderConfigX509ConfigKeyUsage
{
    /// <summary>
    /// Describes high-level ways in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baseKeyUsage")]
    public V1beta2CertificateSpecForProviderConfigX509ConfigKeyUsageBaseKeyUsage? BaseKeyUsage { get; set; }

    /// <summary>
    /// Describes high-level ways in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("extendedKeyUsage")]
    public V1beta2CertificateSpecForProviderConfigX509ConfigKeyUsageExtendedKeyUsage? ExtendedKeyUsage { get; set; }

    /// <summary>
    /// An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta2CertificateSpecForProviderConfigX509ConfigKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

/// <summary>
/// (Output)
/// Describes the X.509 name constraints extension.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderConfigX509ConfigNameConstraints
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
public partial class V1beta2CertificateSpecForProviderConfigX509ConfigPolicyIds
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// Describes how some of the technical X.509 fields in a certificate should be populated.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderConfigX509Config
{
    /// <summary>
    /// (Output)
    /// Describes custom X.509 extensions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta2CertificateSpecForProviderConfigX509ConfigAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>
    /// (Output)
    /// Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the
    /// &quot;Authority Information Access&quot; extension in the certificate.
    /// </summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>
    /// (Output)
    /// Describes values that are relevant in a CA certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("caOptions")]
    public V1beta2CertificateSpecForProviderConfigX509ConfigCaOptions? CaOptions { get; set; }

    /// <summary>
    /// (Output)
    /// Indicates the intended use for keys that correspond to a certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public V1beta2CertificateSpecForProviderConfigX509ConfigKeyUsage? KeyUsage { get; set; }

    /// <summary>
    /// (Output)
    /// Describes the X.509 name constraints extension.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nameConstraints")]
    public V1beta2CertificateSpecForProviderConfigX509ConfigNameConstraints? NameConstraints { get; set; }

    /// <summary>
    /// (Output)
    /// Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta2CertificateSpecForProviderConfigX509ConfigPolicyIds>? PolicyIds { get; set; }
}

/// <summary>
/// The config used to create a self-signed X.509 certificate or CSR.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderConfig
{
    /// <summary>
    /// A PublicKey describes a public key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicKey")]
    public V1beta2CertificateSpecForProviderConfigPublicKey? PublicKey { get; set; }

    /// <summary>
    /// Specifies some of the values in a certificate that are related to the subject.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subjectConfig")]
    public V1beta2CertificateSpecForProviderConfigSubjectConfig? SubjectConfig { get; set; }

    /// <summary>
    /// When specified this provides a custom SKI to be used in the certificate. This should only be used to maintain a SKI of an existing CA originally created outside CA service, which was not generated using method (1) described in RFC 5280 section 4.2.1.2..
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subjectKeyId")]
    public V1beta2CertificateSpecForProviderConfigSubjectKeyId? SubjectKeyId { get; set; }

    /// <summary>
    /// Describes how some of the technical X.509 fields in a certificate should be populated.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("x509Config")]
    public V1beta2CertificateSpecForProviderConfigX509Config? X509Config { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderPoolRefPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecForProviderPoolRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderPoolRefPolicyResolveEnum>))]
public enum V1beta2CertificateSpecForProviderPoolRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderPoolRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecForProviderPoolRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecForProviderPoolRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CAPool in privateca to populate pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderPoolRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CertificateSpecForProviderPoolRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderPoolSelectorPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecForProviderPoolSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderPoolSelectorPolicyResolveEnum>))]
public enum V1beta2CertificateSpecForProviderPoolSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderPoolSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecForProviderPoolSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecForProviderPoolSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CAPool in privateca to populate pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderPoolSelector
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
    public V1beta2CertificateSpecForProviderPoolSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProvider
{
    /// <summary>
    /// The Certificate Authority ID that should issue the certificate. For example, to issue a Certificate from
    /// a Certificate Authority with resource name projects/my-project/locations/us-central1/caPools/my-pool/certificateAuthorities/my-ca,
    /// argument pool should be set to projects/my-project/locations/us-central1/caPools/my-pool, argument certificate_authority
    /// should be set to my-ca.
    /// </summary>
    [JsonPropertyName("certificateAuthority")]
    public string? CertificateAuthority { get; set; }

    /// <summary>Reference to a CertificateAuthority in privateca to populate certificateAuthority.</summary>
    [JsonPropertyName("certificateAuthorityRef")]
    public V1beta2CertificateSpecForProviderCertificateAuthorityRef? CertificateAuthorityRef { get; set; }

    /// <summary>Selector for a CertificateAuthority in privateca to populate certificateAuthority.</summary>
    [JsonPropertyName("certificateAuthoritySelector")]
    public V1beta2CertificateSpecForProviderCertificateAuthoritySelector? CertificateAuthoritySelector { get; set; }

    /// <summary>
    /// The resource name for a CertificateTemplate used to issue this certificate,
    /// in the format projects/*/locations/*/certificateTemplates/*. If this is specified,
    /// the caller must have the necessary permission to use this template. If this is
    /// omitted, no template will be used. This template must be in the same location
    /// as the Certificate.
    /// </summary>
    [JsonPropertyName("certificateTemplate")]
    public string? CertificateTemplate { get; set; }

    /// <summary>Reference to a CertificateTemplate in privateca to populate certificateTemplate.</summary>
    [JsonPropertyName("certificateTemplateRef")]
    public V1beta2CertificateSpecForProviderCertificateTemplateRef? CertificateTemplateRef { get; set; }

    /// <summary>Selector for a CertificateTemplate in privateca to populate certificateTemplate.</summary>
    [JsonPropertyName("certificateTemplateSelector")]
    public V1beta2CertificateSpecForProviderCertificateTemplateSelector? CertificateTemplateSelector { get; set; }

    /// <summary>
    /// The config used to create a self-signed X.509 certificate or CSR.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("config")]
    public V1beta2CertificateSpecForProviderConfig? Config { get; set; }

    /// <summary>Labels with user-defined metadata to apply to this resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The desired lifetime of the CA certificate. Used to create the &quot;notBeforeTime&quot; and
    /// &quot;notAfterTime&quot; fields inside an X.509 certificate. A duration in seconds with up to nine
    /// fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("lifetime")]
    public string? Lifetime { get; set; }

    /// <summary>
    /// Location of the Certificate. A full list of valid locations can be found by
    /// running gcloud privateca locations list.
    /// </summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>Immutable. A pem-encoded X.509 certificate signing request (CSR).</summary>
    [JsonPropertyName("pemCsr")]
    public string? PemCsr { get; set; }

    /// <summary>The name of the CaPool this Certificate belongs to.</summary>
    [JsonPropertyName("pool")]
    public string? Pool { get; set; }

    /// <summary>Reference to a CAPool in privateca to populate pool.</summary>
    [JsonPropertyName("poolRef")]
    public V1beta2CertificateSpecForProviderPoolRef? PoolRef { get; set; }

    /// <summary>Selector for a CAPool in privateca to populate pool.</summary>
    [JsonPropertyName("poolSelector")]
    public V1beta2CertificateSpecForProviderPoolSelector? PoolSelector { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecInitProviderCertificateAuthorityRefPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecInitProviderCertificateAuthorityRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecInitProviderCertificateAuthorityRefPolicyResolveEnum>))]
public enum V1beta2CertificateSpecInitProviderCertificateAuthorityRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderCertificateAuthorityRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecInitProviderCertificateAuthorityRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecInitProviderCertificateAuthorityRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CertificateAuthority in privateca to populate certificateAuthority.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderCertificateAuthorityRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CertificateSpecInitProviderCertificateAuthorityRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecInitProviderCertificateAuthoritySelectorPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecInitProviderCertificateAuthoritySelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecInitProviderCertificateAuthoritySelectorPolicyResolveEnum>))]
public enum V1beta2CertificateSpecInitProviderCertificateAuthoritySelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderCertificateAuthoritySelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecInitProviderCertificateAuthoritySelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecInitProviderCertificateAuthoritySelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CertificateAuthority in privateca to populate certificateAuthority.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderCertificateAuthoritySelector
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
    public V1beta2CertificateSpecInitProviderCertificateAuthoritySelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecInitProviderCertificateTemplateRefPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecInitProviderCertificateTemplateRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecInitProviderCertificateTemplateRefPolicyResolveEnum>))]
public enum V1beta2CertificateSpecInitProviderCertificateTemplateRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderCertificateTemplateRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecInitProviderCertificateTemplateRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecInitProviderCertificateTemplateRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a CertificateTemplate in privateca to populate certificateTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderCertificateTemplateRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CertificateSpecInitProviderCertificateTemplateRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecInitProviderCertificateTemplateSelectorPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecInitProviderCertificateTemplateSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecInitProviderCertificateTemplateSelectorPolicyResolveEnum>))]
public enum V1beta2CertificateSpecInitProviderCertificateTemplateSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderCertificateTemplateSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecInitProviderCertificateTemplateSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecInitProviderCertificateTemplateSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a CertificateTemplate in privateca to populate certificateTemplate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderCertificateTemplateSelector
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
    public V1beta2CertificateSpecInitProviderCertificateTemplateSelectorPolicy? Policy { get; set; }
}

/// <summary>Required. A public key. When this is specified in a request, the padding and encoding can be any of the options described by the respective &apos;KeyType&apos; value. When this is generated by the service, it will always be an RFC 5280 SubjectPublicKeyInfo structure containing an algorithm identifier and a key. A base64-encoded string.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderConfigPublicKeyKeySecretRef
{
    /// <summary>The key to select.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>
/// A PublicKey describes a public key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderConfigPublicKey
{
    /// <summary>
    /// The format of the public key. Currently, only PEM format is supported.
    /// Possible values are: KEY_TYPE_UNSPECIFIED, PEM.
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Required. A public key. When this is specified in a request, the padding and encoding can be any of the options described by the respective &apos;KeyType&apos; value. When this is generated by the service, it will always be an RFC 5280 SubjectPublicKeyInfo structure containing an algorithm identifier and a key. A base64-encoded string.</summary>
    [JsonPropertyName("keySecretRef")]
    public V1beta2CertificateSpecInitProviderConfigPublicKeyKeySecretRef? KeySecretRef { get; set; }
}

/// <summary>
/// (Output)
/// Contains distinguished name fields such as the location and organization.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderConfigSubjectConfigSubject
{
    /// <summary>The common name of the distinguished name.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>The country code of the subject.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The locality or city of the subject.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>The organization of the subject.</summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>The organizational unit of the subject.</summary>
    [JsonPropertyName("organizationalUnit")]
    public string? OrganizationalUnit { get; set; }

    /// <summary>The postal code of the subject.</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>The province, territory, or regional state of the subject.</summary>
    [JsonPropertyName("province")]
    public string? Province { get; set; }

    /// <summary>The street address of the subject.</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }
}

/// <summary>
/// (Output)
/// The subject alternative name fields.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderConfigSubjectConfigSubjectAltName
{
    /// <summary>Contains only valid, fully-qualified host names.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string>? DnsNames { get; set; }

    /// <summary>Contains only valid RFC 2822 E-mail addresses.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>Contains only valid 32-bit IPv4 addresses or RFC 4291 IPv6 addresses.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>Contains only valid RFC 3986 URIs.</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary>
/// Specifies some of the values in a certificate that are related to the subject.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderConfigSubjectConfig
{
    /// <summary>
    /// (Output)
    /// Contains distinguished name fields such as the location and organization.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subject")]
    public V1beta2CertificateSpecInitProviderConfigSubjectConfigSubject? Subject { get; set; }

    /// <summary>
    /// (Output)
    /// The subject alternative name fields.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subjectAltName")]
    public V1beta2CertificateSpecInitProviderConfigSubjectConfigSubjectAltName? SubjectAltName { get; set; }
}

/// <summary>
/// When specified this provides a custom SKI to be used in the certificate. This should only be used to maintain a SKI of an existing CA originally created outside CA service, which was not generated using method (1) described in RFC 5280 section 4.2.1.2..
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderConfigSubjectKeyId
{
    /// <summary>The value of the KeyId in lowercase hexadecimal.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

/// <summary>
/// Describes values that are relevant in a CA certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderConfigX509ConfigAdditionalExtensionsObjectId
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderConfigX509ConfigAdditionalExtensions
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>
    /// Describes values that are relevant in a CA certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objectId")]
    public V1beta2CertificateSpecInitProviderConfigX509ConfigAdditionalExtensionsObjectId? ObjectId { get; set; }

    /// <summary>
    /// (Output)
    /// The value of this X.509 extension.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// (Output)
/// Describes values that are relevant in a CA certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderConfigX509ConfigCaOptions
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
public partial class V1beta2CertificateSpecInitProviderConfigX509ConfigKeyUsageBaseKeyUsage
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
public partial class V1beta2CertificateSpecInitProviderConfigX509ConfigKeyUsageExtendedKeyUsage
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
public partial class V1beta2CertificateSpecInitProviderConfigX509ConfigKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// (Output)
/// Indicates the intended use for keys that correspond to a certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderConfigX509ConfigKeyUsage
{
    /// <summary>
    /// Describes high-level ways in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baseKeyUsage")]
    public V1beta2CertificateSpecInitProviderConfigX509ConfigKeyUsageBaseKeyUsage? BaseKeyUsage { get; set; }

    /// <summary>
    /// Describes high-level ways in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("extendedKeyUsage")]
    public V1beta2CertificateSpecInitProviderConfigX509ConfigKeyUsageExtendedKeyUsage? ExtendedKeyUsage { get; set; }

    /// <summary>
    /// An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta2CertificateSpecInitProviderConfigX509ConfigKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

/// <summary>
/// (Output)
/// Describes the X.509 name constraints extension.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderConfigX509ConfigNameConstraints
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
public partial class V1beta2CertificateSpecInitProviderConfigX509ConfigPolicyIds
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// Describes how some of the technical X.509 fields in a certificate should be populated.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderConfigX509Config
{
    /// <summary>
    /// (Output)
    /// Describes custom X.509 extensions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta2CertificateSpecInitProviderConfigX509ConfigAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>
    /// (Output)
    /// Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the
    /// &quot;Authority Information Access&quot; extension in the certificate.
    /// </summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>
    /// (Output)
    /// Describes values that are relevant in a CA certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("caOptions")]
    public V1beta2CertificateSpecInitProviderConfigX509ConfigCaOptions? CaOptions { get; set; }

    /// <summary>
    /// (Output)
    /// Indicates the intended use for keys that correspond to a certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public V1beta2CertificateSpecInitProviderConfigX509ConfigKeyUsage? KeyUsage { get; set; }

    /// <summary>
    /// (Output)
    /// Describes the X.509 name constraints extension.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nameConstraints")]
    public V1beta2CertificateSpecInitProviderConfigX509ConfigNameConstraints? NameConstraints { get; set; }

    /// <summary>
    /// (Output)
    /// Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta2CertificateSpecInitProviderConfigX509ConfigPolicyIds>? PolicyIds { get; set; }
}

/// <summary>
/// The config used to create a self-signed X.509 certificate or CSR.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderConfig
{
    /// <summary>
    /// A PublicKey describes a public key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicKey")]
    public V1beta2CertificateSpecInitProviderConfigPublicKey? PublicKey { get; set; }

    /// <summary>
    /// Specifies some of the values in a certificate that are related to the subject.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subjectConfig")]
    public V1beta2CertificateSpecInitProviderConfigSubjectConfig? SubjectConfig { get; set; }

    /// <summary>
    /// When specified this provides a custom SKI to be used in the certificate. This should only be used to maintain a SKI of an existing CA originally created outside CA service, which was not generated using method (1) described in RFC 5280 section 4.2.1.2..
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subjectKeyId")]
    public V1beta2CertificateSpecInitProviderConfigSubjectKeyId? SubjectKeyId { get; set; }

    /// <summary>
    /// Describes how some of the technical X.509 fields in a certificate should be populated.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("x509Config")]
    public V1beta2CertificateSpecInitProviderConfigX509Config? X509Config { get; set; }
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
public partial class V1beta2CertificateSpecInitProvider
{
    /// <summary>
    /// The Certificate Authority ID that should issue the certificate. For example, to issue a Certificate from
    /// a Certificate Authority with resource name projects/my-project/locations/us-central1/caPools/my-pool/certificateAuthorities/my-ca,
    /// argument pool should be set to projects/my-project/locations/us-central1/caPools/my-pool, argument certificate_authority
    /// should be set to my-ca.
    /// </summary>
    [JsonPropertyName("certificateAuthority")]
    public string? CertificateAuthority { get; set; }

    /// <summary>Reference to a CertificateAuthority in privateca to populate certificateAuthority.</summary>
    [JsonPropertyName("certificateAuthorityRef")]
    public V1beta2CertificateSpecInitProviderCertificateAuthorityRef? CertificateAuthorityRef { get; set; }

    /// <summary>Selector for a CertificateAuthority in privateca to populate certificateAuthority.</summary>
    [JsonPropertyName("certificateAuthoritySelector")]
    public V1beta2CertificateSpecInitProviderCertificateAuthoritySelector? CertificateAuthoritySelector { get; set; }

    /// <summary>
    /// The resource name for a CertificateTemplate used to issue this certificate,
    /// in the format projects/*/locations/*/certificateTemplates/*. If this is specified,
    /// the caller must have the necessary permission to use this template. If this is
    /// omitted, no template will be used. This template must be in the same location
    /// as the Certificate.
    /// </summary>
    [JsonPropertyName("certificateTemplate")]
    public string? CertificateTemplate { get; set; }

    /// <summary>Reference to a CertificateTemplate in privateca to populate certificateTemplate.</summary>
    [JsonPropertyName("certificateTemplateRef")]
    public V1beta2CertificateSpecInitProviderCertificateTemplateRef? CertificateTemplateRef { get; set; }

    /// <summary>Selector for a CertificateTemplate in privateca to populate certificateTemplate.</summary>
    [JsonPropertyName("certificateTemplateSelector")]
    public V1beta2CertificateSpecInitProviderCertificateTemplateSelector? CertificateTemplateSelector { get; set; }

    /// <summary>
    /// The config used to create a self-signed X.509 certificate or CSR.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("config")]
    public V1beta2CertificateSpecInitProviderConfig? Config { get; set; }

    /// <summary>Labels with user-defined metadata to apply to this resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The desired lifetime of the CA certificate. Used to create the &quot;notBeforeTime&quot; and
    /// &quot;notAfterTime&quot; fields inside an X.509 certificate. A duration in seconds with up to nine
    /// fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("lifetime")]
    public string? Lifetime { get; set; }

    /// <summary>Immutable. A pem-encoded X.509 certificate signing request (CSR).</summary>
    [JsonPropertyName("pemCsr")]
    public string? PemCsr { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecManagementPoliciesEnum>))]
public enum V1beta2CertificateSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2CertificateSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CertificateSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>CertificateSpec defines the desired state of Certificate</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpec
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
    public V1beta2CertificateSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2CertificateSpecForProvider ForProvider { get; set; }

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
    public V1beta2CertificateSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2CertificateSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2CertificateSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2CertificateSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionAuthorityKeyId
{
    /// <summary>The value of the KeyId in lowercase hexadecimal.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionCertFingerprint
{
    /// <summary>
    /// (Output)
    /// The SHA 256 hash, encoded in hexadecimal, of the DER x509 certificate.
    /// </summary>
    [JsonPropertyName("sha256Hash")]
    public string? Sha256Hash { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionPublicKey
{
    /// <summary>
    /// The format of the public key. Currently, only PEM format is supported.
    /// Possible values are: KEY_TYPE_UNSPECIFIED, PEM.
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Required. A public key. When this is specified in a request, the padding and encoding can be any of the options described by the respective &apos;KeyType&apos; value. When this is generated by the service, it will always be an RFC 5280 SubjectPublicKeyInfo structure containing an algorithm identifier and a key. A base64-encoded string.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionSubjectDescriptionSubject
{
    /// <summary>The common name of the distinguished name.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>The country code of the subject.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The locality or city of the subject.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>The organization of the subject.</summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>The organizational unit of the subject.</summary>
    [JsonPropertyName("organizationalUnit")]
    public string? OrganizationalUnit { get; set; }

    /// <summary>The postal code of the subject.</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>The province, territory, or regional state of the subject.</summary>
    [JsonPropertyName("province")]
    public string? Province { get; set; }

    /// <summary>The street address of the subject.</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionSubjectDescriptionSubjectAltNameCustomSansObectId
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionSubjectDescriptionSubjectAltNameCustomSans
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>
    /// (Output)
    /// Describes how some of the technical fields in a certificate should be populated.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("obectId")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionSubjectDescriptionSubjectAltNameCustomSansObectId>? ObectId { get; set; }

    /// <summary>
    /// (Output)
    /// The value of this X.509 extension.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionSubjectDescriptionSubjectAltName
{
    /// <summary>
    /// (Output)
    /// Contains additional subject alternative name values.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("customSans")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionSubjectDescriptionSubjectAltNameCustomSans>? CustomSans { get; set; }

    /// <summary>Contains only valid, fully-qualified host names.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string>? DnsNames { get; set; }

    /// <summary>Contains only valid RFC 2822 E-mail addresses.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>Contains only valid 32-bit IPv4 addresses or RFC 4291 IPv6 addresses.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>Contains only valid RFC 3986 URIs.</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionSubjectDescription
{
    /// <summary>
    /// (Output)
    /// The serial number encoded in lowercase hexadecimal.
    /// </summary>
    [JsonPropertyName("hexSerialNumber")]
    public string? HexSerialNumber { get; set; }

    /// <summary>
    /// (Output)
    /// For convenience, the actual lifetime of an issued certificate. Corresponds to &apos;notAfterTime&apos; - &apos;notBeforeTime&apos;.
    /// </summary>
    [JsonPropertyName("lifetime")]
    public string? Lifetime { get; set; }

    /// <summary>
    /// (Output)
    /// The time at which the certificate expires.
    /// </summary>
    [JsonPropertyName("notAfterTime")]
    public string? NotAfterTime { get; set; }

    /// <summary>
    /// (Output)
    /// The time at which the certificate becomes valid.
    /// </summary>
    [JsonPropertyName("notBeforeTime")]
    public string? NotBeforeTime { get; set; }

    /// <summary>
    /// (Output)
    /// Contains distinguished name fields such as the location and organization.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subject")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionSubjectDescriptionSubject>? Subject { get; set; }

    /// <summary>
    /// (Output)
    /// The subject alternative name fields.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subjectAltName")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionSubjectDescriptionSubjectAltName>? SubjectAltName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionSubjectKeyId
{
    /// <summary>The value of the KeyId in lowercase hexadecimal.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionAdditionalExtensionsObjectId
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionAdditionalExtensions
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>
    /// Describes values that are relevant in a CA certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objectId")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionAdditionalExtensionsObjectId>? ObjectId { get; set; }

    /// <summary>
    /// (Output)
    /// The value of this X.509 extension.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionCaOptions
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
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionKeyUsageBaseKeyUsage
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionKeyUsageExtendedKeyUsage
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
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionKeyUsage
{
    /// <summary>
    /// Describes high-level ways in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baseKeyUsage")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionKeyUsageBaseKeyUsage>? BaseKeyUsage { get; set; }

    /// <summary>
    /// Describes high-level ways in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("extendedKeyUsage")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionKeyUsageExtendedKeyUsage>? ExtendedKeyUsage { get; set; }

    /// <summary>
    /// An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionNameConstraints
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
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionPolicyIds
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescriptionX509Description
{
    /// <summary>
    /// (Output)
    /// Describes custom X.509 extensions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>
    /// (Output)
    /// Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the
    /// &quot;Authority Information Access&quot; extension in the certificate.
    /// </summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>
    /// (Output)
    /// Describes values that are relevant in a CA certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("caOptions")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionCaOptions>? CaOptions { get; set; }

    /// <summary>
    /// (Output)
    /// Indicates the intended use for keys that correspond to a certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionKeyUsage>? KeyUsage { get; set; }

    /// <summary>
    /// (Output)
    /// Describes the X.509 name constraints extension.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nameConstraints")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionNameConstraints>? NameConstraints { get; set; }

    /// <summary>
    /// (Output)
    /// Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionX509DescriptionPolicyIds>? PolicyIds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderCertificateDescription
{
    /// <summary>
    /// (Output)
    /// Describes lists of issuer CA certificate URLs that appear in the &quot;Authority Information Access&quot; extension in the certificate.
    /// </summary>
    [JsonPropertyName("aiaIssuingCertificateUrls")]
    public IList<string>? AiaIssuingCertificateUrls { get; set; }

    /// <summary>
    /// (Output)
    /// Identifies the subjectKeyId of the parent certificate, per https://tools.ietf.org/html/rfc5280#section-4.2.1.1
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorityKeyId")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionAuthorityKeyId>? AuthorityKeyId { get; set; }

    /// <summary>
    /// (Output)
    /// The hash of the x.509 certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("certFingerprint")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionCertFingerprint>? CertFingerprint { get; set; }

    /// <summary>
    /// (Output)
    /// Describes a list of locations to obtain CRL information, i.e. the DistributionPoint.fullName described by https://tools.ietf.org/html/rfc5280#section-4.2.1.13
    /// </summary>
    [JsonPropertyName("crlDistributionPoints")]
    public IList<string>? CrlDistributionPoints { get; set; }

    /// <summary>
    /// (Output)
    /// A PublicKey describes a public key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicKey")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionPublicKey>? PublicKey { get; set; }

    /// <summary>
    /// (Output)
    /// Describes some of the values in a certificate that are related to the subject and lifetime.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subjectDescription")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionSubjectDescription>? SubjectDescription { get; set; }

    /// <summary>
    /// (Output)
    /// Provides a means of identifiying certificates that contain a particular public key, per https://tools.ietf.org/html/rfc5280#section-4.2.1.2.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subjectKeyId")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionSubjectKeyId>? SubjectKeyId { get; set; }

    /// <summary>
    /// (Output)
    /// A structured description of the issued X.509 certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("x509Description")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescriptionX509Description>? X509Description { get; set; }
}

/// <summary>
/// A PublicKey describes a public key.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderConfigPublicKey
{
    /// <summary>
    /// The format of the public key. Currently, only PEM format is supported.
    /// Possible values are: KEY_TYPE_UNSPECIFIED, PEM.
    /// </summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }
}

/// <summary>
/// (Output)
/// Contains distinguished name fields such as the location and organization.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderConfigSubjectConfigSubject
{
    /// <summary>The common name of the distinguished name.</summary>
    [JsonPropertyName("commonName")]
    public string? CommonName { get; set; }

    /// <summary>The country code of the subject.</summary>
    [JsonPropertyName("countryCode")]
    public string? CountryCode { get; set; }

    /// <summary>The locality or city of the subject.</summary>
    [JsonPropertyName("locality")]
    public string? Locality { get; set; }

    /// <summary>The organization of the subject.</summary>
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }

    /// <summary>The organizational unit of the subject.</summary>
    [JsonPropertyName("organizationalUnit")]
    public string? OrganizationalUnit { get; set; }

    /// <summary>The postal code of the subject.</summary>
    [JsonPropertyName("postalCode")]
    public string? PostalCode { get; set; }

    /// <summary>The province, territory, or regional state of the subject.</summary>
    [JsonPropertyName("province")]
    public string? Province { get; set; }

    /// <summary>The street address of the subject.</summary>
    [JsonPropertyName("streetAddress")]
    public string? StreetAddress { get; set; }
}

/// <summary>
/// (Output)
/// The subject alternative name fields.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderConfigSubjectConfigSubjectAltName
{
    /// <summary>Contains only valid, fully-qualified host names.</summary>
    [JsonPropertyName("dnsNames")]
    public IList<string>? DnsNames { get; set; }

    /// <summary>Contains only valid RFC 2822 E-mail addresses.</summary>
    [JsonPropertyName("emailAddresses")]
    public IList<string>? EmailAddresses { get; set; }

    /// <summary>Contains only valid 32-bit IPv4 addresses or RFC 4291 IPv6 addresses.</summary>
    [JsonPropertyName("ipAddresses")]
    public IList<string>? IpAddresses { get; set; }

    /// <summary>Contains only valid RFC 3986 URIs.</summary>
    [JsonPropertyName("uris")]
    public IList<string>? Uris { get; set; }
}

/// <summary>
/// Specifies some of the values in a certificate that are related to the subject.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderConfigSubjectConfig
{
    /// <summary>
    /// (Output)
    /// Contains distinguished name fields such as the location and organization.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subject")]
    public V1beta2CertificateStatusAtProviderConfigSubjectConfigSubject? Subject { get; set; }

    /// <summary>
    /// (Output)
    /// The subject alternative name fields.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subjectAltName")]
    public V1beta2CertificateStatusAtProviderConfigSubjectConfigSubjectAltName? SubjectAltName { get; set; }
}

/// <summary>
/// When specified this provides a custom SKI to be used in the certificate. This should only be used to maintain a SKI of an existing CA originally created outside CA service, which was not generated using method (1) described in RFC 5280 section 4.2.1.2..
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderConfigSubjectKeyId
{
    /// <summary>The value of the KeyId in lowercase hexadecimal.</summary>
    [JsonPropertyName("keyId")]
    public string? KeyId { get; set; }
}

/// <summary>
/// Describes values that are relevant in a CA certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderConfigX509ConfigAdditionalExtensionsObjectId
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderConfigX509ConfigAdditionalExtensions
{
    /// <summary>Indicates whether or not the name constraints are marked critical.</summary>
    [JsonPropertyName("critical")]
    public bool? Critical { get; set; }

    /// <summary>
    /// Describes values that are relevant in a CA certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("objectId")]
    public V1beta2CertificateStatusAtProviderConfigX509ConfigAdditionalExtensionsObjectId? ObjectId { get; set; }

    /// <summary>
    /// (Output)
    /// The value of this X.509 extension.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// (Output)
/// Describes values that are relevant in a CA certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderConfigX509ConfigCaOptions
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
public partial class V1beta2CertificateStatusAtProviderConfigX509ConfigKeyUsageBaseKeyUsage
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
public partial class V1beta2CertificateStatusAtProviderConfigX509ConfigKeyUsageExtendedKeyUsage
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
public partial class V1beta2CertificateStatusAtProviderConfigX509ConfigKeyUsageUnknownExtendedKeyUsages
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// (Output)
/// Indicates the intended use for keys that correspond to a certificate.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderConfigX509ConfigKeyUsage
{
    /// <summary>
    /// Describes high-level ways in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("baseKeyUsage")]
    public V1beta2CertificateStatusAtProviderConfigX509ConfigKeyUsageBaseKeyUsage? BaseKeyUsage { get; set; }

    /// <summary>
    /// Describes high-level ways in which a key may be used.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("extendedKeyUsage")]
    public V1beta2CertificateStatusAtProviderConfigX509ConfigKeyUsageExtendedKeyUsage? ExtendedKeyUsage { get; set; }

    /// <summary>
    /// An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("unknownExtendedKeyUsages")]
    public IList<V1beta2CertificateStatusAtProviderConfigX509ConfigKeyUsageUnknownExtendedKeyUsages>? UnknownExtendedKeyUsages { get; set; }
}

/// <summary>
/// (Output)
/// Describes the X.509 name constraints extension.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderConfigX509ConfigNameConstraints
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
public partial class V1beta2CertificateStatusAtProviderConfigX509ConfigPolicyIds
{
    /// <summary>An ObjectId specifies an object identifier (OID). These provide context and describe types in ASN.1 messages.</summary>
    [JsonPropertyName("objectIdPath")]
    public IList<double>? ObjectIdPath { get; set; }
}

/// <summary>
/// Describes how some of the technical X.509 fields in a certificate should be populated.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderConfigX509Config
{
    /// <summary>
    /// (Output)
    /// Describes custom X.509 extensions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("additionalExtensions")]
    public IList<V1beta2CertificateStatusAtProviderConfigX509ConfigAdditionalExtensions>? AdditionalExtensions { get; set; }

    /// <summary>
    /// (Output)
    /// Describes Online Certificate Status Protocol (OCSP) endpoint addresses that appear in the
    /// &quot;Authority Information Access&quot; extension in the certificate.
    /// </summary>
    [JsonPropertyName("aiaOcspServers")]
    public IList<string>? AiaOcspServers { get; set; }

    /// <summary>
    /// (Output)
    /// Describes values that are relevant in a CA certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("caOptions")]
    public V1beta2CertificateStatusAtProviderConfigX509ConfigCaOptions? CaOptions { get; set; }

    /// <summary>
    /// (Output)
    /// Indicates the intended use for keys that correspond to a certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("keyUsage")]
    public V1beta2CertificateStatusAtProviderConfigX509ConfigKeyUsage? KeyUsage { get; set; }

    /// <summary>
    /// (Output)
    /// Describes the X.509 name constraints extension.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("nameConstraints")]
    public V1beta2CertificateStatusAtProviderConfigX509ConfigNameConstraints? NameConstraints { get; set; }

    /// <summary>
    /// (Output)
    /// Describes the X.509 certificate policy object identifiers, per https://tools.ietf.org/html/rfc5280#section-4.2.1.4.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("policyIds")]
    public IList<V1beta2CertificateStatusAtProviderConfigX509ConfigPolicyIds>? PolicyIds { get; set; }
}

/// <summary>
/// The config used to create a self-signed X.509 certificate or CSR.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderConfig
{
    /// <summary>
    /// A PublicKey describes a public key.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("publicKey")]
    public V1beta2CertificateStatusAtProviderConfigPublicKey? PublicKey { get; set; }

    /// <summary>
    /// Specifies some of the values in a certificate that are related to the subject.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subjectConfig")]
    public V1beta2CertificateStatusAtProviderConfigSubjectConfig? SubjectConfig { get; set; }

    /// <summary>
    /// When specified this provides a custom SKI to be used in the certificate. This should only be used to maintain a SKI of an existing CA originally created outside CA service, which was not generated using method (1) described in RFC 5280 section 4.2.1.2..
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("subjectKeyId")]
    public V1beta2CertificateStatusAtProviderConfigSubjectKeyId? SubjectKeyId { get; set; }

    /// <summary>
    /// Describes how some of the technical X.509 fields in a certificate should be populated.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("x509Config")]
    public V1beta2CertificateStatusAtProviderConfigX509Config? X509Config { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderRevocationDetails
{
    /// <summary>
    /// (Output)
    /// Indicates why a Certificate was revoked.
    /// </summary>
    [JsonPropertyName("revocationState")]
    public string? RevocationState { get; set; }

    /// <summary>
    /// (Output)
    /// The time at which this Certificate was revoked.
    /// </summary>
    [JsonPropertyName("revocationTime")]
    public string? RevocationTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProvider
{
    /// <summary>
    /// The Certificate Authority ID that should issue the certificate. For example, to issue a Certificate from
    /// a Certificate Authority with resource name projects/my-project/locations/us-central1/caPools/my-pool/certificateAuthorities/my-ca,
    /// argument pool should be set to projects/my-project/locations/us-central1/caPools/my-pool, argument certificate_authority
    /// should be set to my-ca.
    /// </summary>
    [JsonPropertyName("certificateAuthority")]
    public string? CertificateAuthority { get; set; }

    /// <summary>
    /// Output only. Details regarding the revocation of this Certificate. This Certificate is considered revoked if and only if this field is present.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("certificateDescription")]
    public IList<V1beta2CertificateStatusAtProviderCertificateDescription>? CertificateDescription { get; set; }

    /// <summary>
    /// The resource name for a CertificateTemplate used to issue this certificate,
    /// in the format projects/*/locations/*/certificateTemplates/*. If this is specified,
    /// the caller must have the necessary permission to use this template. If this is
    /// omitted, no template will be used. This template must be in the same location
    /// as the Certificate.
    /// </summary>
    [JsonPropertyName("certificateTemplate")]
    public string? CertificateTemplate { get; set; }

    /// <summary>
    /// The config used to create a self-signed X.509 certificate or CSR.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("config")]
    public V1beta2CertificateStatusAtProviderConfig? Config { get; set; }

    /// <summary>
    /// The time that this resource was created on the server.
    /// This is in RFC3339 text format.
    /// </summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>for all of the labels present on the resource.</summary>
    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/caPools/{{pool}}/certificates/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The resource name of the issuing CertificateAuthority in the format projects/*/locations/*/caPools/*/certificateAuthorities/*.</summary>
    [JsonPropertyName("issuerCertificateAuthority")]
    public string? IssuerCertificateAuthority { get; set; }

    /// <summary>Labels with user-defined metadata to apply to this resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The desired lifetime of the CA certificate. Used to create the &quot;notBeforeTime&quot; and
    /// &quot;notAfterTime&quot; fields inside an X.509 certificate. A duration in seconds with up to nine
    /// fractional digits, terminated by &apos;s&apos;. Example: &quot;3.5s&quot;.
    /// </summary>
    [JsonPropertyName("lifetime")]
    public string? Lifetime { get; set; }

    /// <summary>
    /// Location of the Certificate. A full list of valid locations can be found by
    /// running gcloud privateca locations list.
    /// </summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Output only. The pem-encoded, signed X.509 certificate.</summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }

    /// <summary>The chain that may be used to verify the X.509 certificate. Expected to be in issuer-to-root order according to RFC 5246.</summary>
    [JsonPropertyName("pemCertificateChain")]
    public IList<string>? PemCertificateChain { get; set; }

    /// <summary>Immutable. A pem-encoded X.509 certificate signing request (CSR).</summary>
    [JsonPropertyName("pemCsr")]
    public string? PemCsr { get; set; }

    /// <summary>The name of the CaPool this Certificate belongs to.</summary>
    [JsonPropertyName("pool")]
    public string? Pool { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// Output only. Details regarding the revocation of this Certificate. This Certificate is
    /// considered revoked if and only if this field is present.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("revocationDetails")]
    public IList<V1beta2CertificateStatusAtProviderRevocationDetails>? RevocationDetails { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }

    /// <summary>
    /// Output only. The time at which this CertificateAuthority was updated.
    /// This is in RFC3339 text format.
    /// </summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusConditions
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

/// <summary>CertificateStatus defines the observed state of Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2CertificateStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2CertificateStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Certificate is the Schema for the Certificates API. A Certificate corresponds to a signed X.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Certificate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2CertificateSpec>, IStatus<V1beta2CertificateStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Certificate";
    public const string KubeGroup = "privateca.gcp.upbound.io";
    public const string KubePluralName = "certificates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "privateca.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Certificate";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CertificateSpec defines the desired state of Certificate</summary>
    [JsonPropertyName("spec")]
    public required V1beta2CertificateSpec Spec { get; set; }

    /// <summary>CertificateStatus defines the observed state of Certificate.</summary>
    [JsonPropertyName("status")]
    public V1beta2CertificateStatus? Status { get; set; }
}