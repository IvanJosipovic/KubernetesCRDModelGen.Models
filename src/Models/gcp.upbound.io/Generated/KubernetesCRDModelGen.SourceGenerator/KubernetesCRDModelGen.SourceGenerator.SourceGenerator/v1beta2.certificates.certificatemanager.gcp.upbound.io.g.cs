#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.certificatemanager.gcp.upbound.io;
/// <summary>Certificate is the Schema for the Certificates API. Certificate represents a HTTP-reachable backend for a Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2CertificateList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Certificate>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "CertificateList";
    public const string KubeGroup = "certificatemanager.gcp.upbound.io";
    public const string KubePluralName = "certificates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "certificatemanager.gcp.upbound.io/v1beta2";

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderManagedDnsAuthorizationsRefsPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecForProviderManagedDnsAuthorizationsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderManagedDnsAuthorizationsRefsPolicyResolveEnum>))]
public enum V1beta2CertificateSpecForProviderManagedDnsAuthorizationsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderManagedDnsAuthorizationsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecForProviderManagedDnsAuthorizationsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecForProviderManagedDnsAuthorizationsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderManagedDnsAuthorizationsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CertificateSpecForProviderManagedDnsAuthorizationsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderManagedDnsAuthorizationsSelectorPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecForProviderManagedDnsAuthorizationsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderManagedDnsAuthorizationsSelectorPolicyResolveEnum>))]
public enum V1beta2CertificateSpecForProviderManagedDnsAuthorizationsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderManagedDnsAuthorizationsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecForProviderManagedDnsAuthorizationsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecForProviderManagedDnsAuthorizationsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of DNSAuthorization in certificatemanager to populate dnsAuthorizations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderManagedDnsAuthorizationsSelector
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
    public V1beta2CertificateSpecForProviderManagedDnsAuthorizationsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderManagedDomainsRefsPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecForProviderManagedDomainsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderManagedDomainsRefsPolicyResolveEnum>))]
public enum V1beta2CertificateSpecForProviderManagedDomainsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderManagedDomainsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecForProviderManagedDomainsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecForProviderManagedDomainsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderManagedDomainsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CertificateSpecForProviderManagedDomainsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderManagedDomainsSelectorPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecForProviderManagedDomainsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecForProviderManagedDomainsSelectorPolicyResolveEnum>))]
public enum V1beta2CertificateSpecForProviderManagedDomainsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderManagedDomainsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecForProviderManagedDomainsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecForProviderManagedDomainsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of DNSAuthorization in certificatemanager to populate domains.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderManagedDomainsSelector
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
    public V1beta2CertificateSpecForProviderManagedDomainsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Configuration and state of a Managed Certificate.
/// Certificate Manager provisions and renews Managed Certificates
/// automatically, for as long as it&apos;s authorized to do so.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderManaged
{
    /// <summary>Authorizations that will be used for performing domain authorization. Either issuanceConfig or dnsAuthorizations should be specificed, but not both.</summary>
    [JsonPropertyName("dnsAuthorizations")]
    public IList<string>? DnsAuthorizations { get; set; }

    /// <summary>References to DNSAuthorization in certificatemanager to populate dnsAuthorizations.</summary>
    [JsonPropertyName("dnsAuthorizationsRefs")]
    public IList<V1beta2CertificateSpecForProviderManagedDnsAuthorizationsRefs>? DnsAuthorizationsRefs { get; set; }

    /// <summary>Selector for a list of DNSAuthorization in certificatemanager to populate dnsAuthorizations.</summary>
    [JsonPropertyName("dnsAuthorizationsSelector")]
    public V1beta2CertificateSpecForProviderManagedDnsAuthorizationsSelector? DnsAuthorizationsSelector { get; set; }

    /// <summary>
    /// The domains for which a managed SSL certificate will be generated.
    /// Wildcard domains are only supported with DNS challenge resolution
    /// </summary>
    [JsonPropertyName("domains")]
    public IList<string>? Domains { get; set; }

    /// <summary>References to DNSAuthorization in certificatemanager to populate domains.</summary>
    [JsonPropertyName("domainsRefs")]
    public IList<V1beta2CertificateSpecForProviderManagedDomainsRefs>? DomainsRefs { get; set; }

    /// <summary>Selector for a list of DNSAuthorization in certificatemanager to populate domains.</summary>
    [JsonPropertyName("domainsSelector")]
    public V1beta2CertificateSpecForProviderManagedDomainsSelector? DomainsSelector { get; set; }

    /// <summary>
    /// The resource name for a CertificateIssuanceConfig used to configure private PKI certificates in the format projects//locations//certificateIssuanceConfigs/*.
    /// If this field is not set, the certificates will instead be publicly signed as documented at https://cloud.google.com/load-balancing/docs/ssl-certificates/google-managed-certs#caa.
    /// Either issuanceConfig or dnsAuthorizations should be specificed, but not both.
    /// </summary>
    [JsonPropertyName("issuanceConfig")]
    public string? IssuanceConfig { get; set; }
}

/// <summary>
/// The certificate chain in PEM-encoded form.
/// Leaf certificate comes first, followed by intermediate ones if any.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderSelfManagedCertificatePemSecretRef
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
/// The private key of the leaf certificate in PEM-encoded form.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderSelfManagedPemPrivateKeySecretRef
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
/// The private key of the leaf certificate in PEM-encoded form.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderSelfManagedPrivateKeyPemSecretRef
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
/// Certificate data for a SelfManaged Certificate.
/// SelfManaged Certificates are uploaded by the user. Updating such
/// certificates before they expire remains the user&apos;s responsibility.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProviderSelfManaged
{
    /// <summary>
    /// The certificate chain in PEM-encoded form.
    /// Leaf certificate comes first, followed by intermediate ones if any.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("certificatePemSecretRef")]
    public V1beta2CertificateSpecForProviderSelfManagedCertificatePemSecretRef? CertificatePemSecretRef { get; set; }

    /// <summary>
    /// The certificate chain in PEM-encoded form.
    /// Leaf certificate comes first, followed by intermediate ones if any.
    /// </summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }

    /// <summary>
    /// The private key of the leaf certificate in PEM-encoded form.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("pemPrivateKeySecretRef")]
    public V1beta2CertificateSpecForProviderSelfManagedPemPrivateKeySecretRef? PemPrivateKeySecretRef { get; set; }

    /// <summary>
    /// The private key of the leaf certificate in PEM-encoded form.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("privateKeyPemSecretRef")]
    public V1beta2CertificateSpecForProviderSelfManagedPrivateKeyPemSecretRef? PrivateKeyPemSecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecForProvider
{
    /// <summary>A human-readable description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Set of label tags associated with the Certificate resource.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The Certificate Manager location. If not specified, &quot;global&quot; is used.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Configuration and state of a Managed Certificate.
    /// Certificate Manager provisions and renews Managed Certificates
    /// automatically, for as long as it&apos;s authorized to do so.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("managed")]
    public V1beta2CertificateSpecForProviderManaged? Managed { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The scope of the certificate.
    /// DEFAULT: Certificates with default scope are served from core Google data centers.
    /// If unsure, choose this option.
    /// EDGE_CACHE: Certificates with scope EDGE_CACHE are special-purposed certificates, served from Edge Points of Presence.
    /// See https://cloud.google.com/vpc/docs/edge-locations.
    /// ALL_REGIONS: Certificates with ALL_REGIONS scope are served from all GCP regions (You can only use ALL_REGIONS with global certs).
    /// See https://cloud.google.com/compute/docs/regions-zones.
    /// CLIENT_AUTH: Certificates with CLIENT_AUTH scope are used by a load balancer (TLS client) to be presented to the backend (TLS server) when backend mTLS is configured.
    /// See https://cloud.google.com/load-balancing/docs/backend-authenticated-tls-backend-mtls#client-certificate.
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>
    /// Certificate data for a SelfManaged Certificate.
    /// SelfManaged Certificates are uploaded by the user. Updating such
    /// certificates before they expire remains the user&apos;s responsibility.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("selfManaged")]
    public V1beta2CertificateSpecForProviderSelfManaged? SelfManaged { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsRefsPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsRefsPolicyResolveEnum>))]
public enum V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsSelectorPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsSelectorPolicyResolveEnum>))]
public enum V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of DNSAuthorization in certificatemanager to populate dnsAuthorizations.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsSelector
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
    public V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecInitProviderManagedDomainsRefsPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecInitProviderManagedDomainsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecInitProviderManagedDomainsRefsPolicyResolveEnum>))]
public enum V1beta2CertificateSpecInitProviderManagedDomainsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderManagedDomainsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecInitProviderManagedDomainsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecInitProviderManagedDomainsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderManagedDomainsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2CertificateSpecInitProviderManagedDomainsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecInitProviderManagedDomainsSelectorPolicyResolutionEnum>))]
public enum V1beta2CertificateSpecInitProviderManagedDomainsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2CertificateSpecInitProviderManagedDomainsSelectorPolicyResolveEnum>))]
public enum V1beta2CertificateSpecInitProviderManagedDomainsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderManagedDomainsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2CertificateSpecInitProviderManagedDomainsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2CertificateSpecInitProviderManagedDomainsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of DNSAuthorization in certificatemanager to populate domains.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderManagedDomainsSelector
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
    public V1beta2CertificateSpecInitProviderManagedDomainsSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Configuration and state of a Managed Certificate.
/// Certificate Manager provisions and renews Managed Certificates
/// automatically, for as long as it&apos;s authorized to do so.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderManaged
{
    /// <summary>Authorizations that will be used for performing domain authorization. Either issuanceConfig or dnsAuthorizations should be specificed, but not both.</summary>
    [JsonPropertyName("dnsAuthorizations")]
    public IList<string>? DnsAuthorizations { get; set; }

    /// <summary>References to DNSAuthorization in certificatemanager to populate dnsAuthorizations.</summary>
    [JsonPropertyName("dnsAuthorizationsRefs")]
    public IList<V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsRefs>? DnsAuthorizationsRefs { get; set; }

    /// <summary>Selector for a list of DNSAuthorization in certificatemanager to populate dnsAuthorizations.</summary>
    [JsonPropertyName("dnsAuthorizationsSelector")]
    public V1beta2CertificateSpecInitProviderManagedDnsAuthorizationsSelector? DnsAuthorizationsSelector { get; set; }

    /// <summary>
    /// The domains for which a managed SSL certificate will be generated.
    /// Wildcard domains are only supported with DNS challenge resolution
    /// </summary>
    [JsonPropertyName("domains")]
    public IList<string>? Domains { get; set; }

    /// <summary>References to DNSAuthorization in certificatemanager to populate domains.</summary>
    [JsonPropertyName("domainsRefs")]
    public IList<V1beta2CertificateSpecInitProviderManagedDomainsRefs>? DomainsRefs { get; set; }

    /// <summary>Selector for a list of DNSAuthorization in certificatemanager to populate domains.</summary>
    [JsonPropertyName("domainsSelector")]
    public V1beta2CertificateSpecInitProviderManagedDomainsSelector? DomainsSelector { get; set; }

    /// <summary>
    /// The resource name for a CertificateIssuanceConfig used to configure private PKI certificates in the format projects//locations//certificateIssuanceConfigs/*.
    /// If this field is not set, the certificates will instead be publicly signed as documented at https://cloud.google.com/load-balancing/docs/ssl-certificates/google-managed-certs#caa.
    /// Either issuanceConfig or dnsAuthorizations should be specificed, but not both.
    /// </summary>
    [JsonPropertyName("issuanceConfig")]
    public string? IssuanceConfig { get; set; }
}

/// <summary>
/// The certificate chain in PEM-encoded form.
/// Leaf certificate comes first, followed by intermediate ones if any.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderSelfManagedCertificatePemSecretRef
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
/// The private key of the leaf certificate in PEM-encoded form.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderSelfManagedPemPrivateKeySecretRef
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
/// The private key of the leaf certificate in PEM-encoded form.
/// Note: This property is sensitive and will not be displayed in the plan.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderSelfManagedPrivateKeyPemSecretRef
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
/// Certificate data for a SelfManaged Certificate.
/// SelfManaged Certificates are uploaded by the user. Updating such
/// certificates before they expire remains the user&apos;s responsibility.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateSpecInitProviderSelfManaged
{
    /// <summary>
    /// The certificate chain in PEM-encoded form.
    /// Leaf certificate comes first, followed by intermediate ones if any.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("certificatePemSecretRef")]
    public V1beta2CertificateSpecInitProviderSelfManagedCertificatePemSecretRef? CertificatePemSecretRef { get; set; }

    /// <summary>
    /// The certificate chain in PEM-encoded form.
    /// Leaf certificate comes first, followed by intermediate ones if any.
    /// </summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }

    /// <summary>
    /// The private key of the leaf certificate in PEM-encoded form.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("pemPrivateKeySecretRef")]
    public V1beta2CertificateSpecInitProviderSelfManagedPemPrivateKeySecretRef? PemPrivateKeySecretRef { get; set; }

    /// <summary>
    /// The private key of the leaf certificate in PEM-encoded form.
    /// Note: This property is sensitive and will not be displayed in the plan.
    /// </summary>
    [JsonPropertyName("privateKeyPemSecretRef")]
    public V1beta2CertificateSpecInitProviderSelfManagedPrivateKeyPemSecretRef? PrivateKeyPemSecretRef { get; set; }
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
    /// <summary>A human-readable description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Set of label tags associated with the Certificate resource.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Configuration and state of a Managed Certificate.
    /// Certificate Manager provisions and renews Managed Certificates
    /// automatically, for as long as it&apos;s authorized to do so.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("managed")]
    public V1beta2CertificateSpecInitProviderManaged? Managed { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The scope of the certificate.
    /// DEFAULT: Certificates with default scope are served from core Google data centers.
    /// If unsure, choose this option.
    /// EDGE_CACHE: Certificates with scope EDGE_CACHE are special-purposed certificates, served from Edge Points of Presence.
    /// See https://cloud.google.com/vpc/docs/edge-locations.
    /// ALL_REGIONS: Certificates with ALL_REGIONS scope are served from all GCP regions (You can only use ALL_REGIONS with global certs).
    /// See https://cloud.google.com/compute/docs/regions-zones.
    /// CLIENT_AUTH: Certificates with CLIENT_AUTH scope are used by a load balancer (TLS client) to be presented to the backend (TLS server) when backend mTLS is configured.
    /// See https://cloud.google.com/load-balancing/docs/backend-authenticated-tls-backend-mtls#client-certificate.
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>
    /// Certificate data for a SelfManaged Certificate.
    /// SelfManaged Certificates are uploaded by the user. Updating such
    /// certificates before they expire remains the user&apos;s responsibility.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("selfManaged")]
    public V1beta2CertificateSpecInitProviderSelfManaged? SelfManaged { get; set; }
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
public partial class V1beta2CertificateStatusAtProviderManagedAuthorizationAttemptInfo
{
    /// <summary>
    /// (Output)
    /// Human readable explanation about the issue. Provided to help address
    /// the configuration issues.
    /// Not guaranteed to be stable. For programmatic access use reason field.
    /// </summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>
    /// (Output)
    /// Domain name of the authorization attempt.
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>
    /// (Output)
    /// Reason for failure of the authorization attempt for the domain.
    /// </summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>
    /// (Output)
    /// A state of this Managed Certificate.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderManagedProvisioningIssue
{
    /// <summary>
    /// (Output)
    /// Human readable explanation about the issue. Provided to help address
    /// the configuration issues.
    /// Not guaranteed to be stable. For programmatic access use reason field.
    /// </summary>
    [JsonPropertyName("details")]
    public string? Details { get; set; }

    /// <summary>
    /// (Output)
    /// Reason for provisioning failures.
    /// </summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }
}

/// <summary>
/// Configuration and state of a Managed Certificate.
/// Certificate Manager provisions and renews Managed Certificates
/// automatically, for as long as it&apos;s authorized to do so.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderManaged
{
    /// <summary>
    /// (Output)
    /// Detailed state of the latest authorization attempt for each domain
    /// specified for this Managed Certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("authorizationAttemptInfo")]
    public IList<V1beta2CertificateStatusAtProviderManagedAuthorizationAttemptInfo>? AuthorizationAttemptInfo { get; set; }

    /// <summary>Authorizations that will be used for performing domain authorization. Either issuanceConfig or dnsAuthorizations should be specificed, but not both.</summary>
    [JsonPropertyName("dnsAuthorizations")]
    public IList<string>? DnsAuthorizations { get; set; }

    /// <summary>
    /// The domains for which a managed SSL certificate will be generated.
    /// Wildcard domains are only supported with DNS challenge resolution
    /// </summary>
    [JsonPropertyName("domains")]
    public IList<string>? Domains { get; set; }

    /// <summary>
    /// The resource name for a CertificateIssuanceConfig used to configure private PKI certificates in the format projects//locations//certificateIssuanceConfigs/*.
    /// If this field is not set, the certificates will instead be publicly signed as documented at https://cloud.google.com/load-balancing/docs/ssl-certificates/google-managed-certs#caa.
    /// Either issuanceConfig or dnsAuthorizations should be specificed, but not both.
    /// </summary>
    [JsonPropertyName("issuanceConfig")]
    public string? IssuanceConfig { get; set; }

    /// <summary>
    /// (Output)
    /// Information about issues with provisioning this Managed Certificate.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("provisioningIssue")]
    public IList<V1beta2CertificateStatusAtProviderManagedProvisioningIssue>? ProvisioningIssue { get; set; }

    /// <summary>
    /// (Output)
    /// A state of this Managed Certificate.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Certificate data for a SelfManaged Certificate.
/// SelfManaged Certificates are uploaded by the user. Updating such
/// certificates before they expire remains the user&apos;s responsibility.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProviderSelfManaged
{
    /// <summary>
    /// The certificate chain in PEM-encoded form.
    /// Leaf certificate comes first, followed by intermediate ones if any.
    /// </summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2CertificateStatusAtProvider
{
    /// <summary>A human-readable description of the resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("effectiveLabels")]
    public IDictionary<string, string>? EffectiveLabels { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/{{location}}/certificates/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Set of label tags associated with the Certificate resource.
    /// Note: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field effective_labels for all of the labels present on the resource.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The Certificate Manager location. If not specified, &quot;global&quot; is used.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Configuration and state of a Managed Certificate.
    /// Certificate Manager provisions and renews Managed Certificates
    /// automatically, for as long as it&apos;s authorized to do so.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("managed")]
    public V1beta2CertificateStatusAtProviderManaged? Managed { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>The list of Subject Alternative Names of dnsName type defined in the certificate (see RFC 5280 4.2.1.6)</summary>
    [JsonPropertyName("sanDnsnames")]
    public IList<string>? SanDnsnames { get; set; }

    /// <summary>
    /// The scope of the certificate.
    /// DEFAULT: Certificates with default scope are served from core Google data centers.
    /// If unsure, choose this option.
    /// EDGE_CACHE: Certificates with scope EDGE_CACHE are special-purposed certificates, served from Edge Points of Presence.
    /// See https://cloud.google.com/vpc/docs/edge-locations.
    /// ALL_REGIONS: Certificates with ALL_REGIONS scope are served from all GCP regions (You can only use ALL_REGIONS with global certs).
    /// See https://cloud.google.com/compute/docs/regions-zones.
    /// CLIENT_AUTH: Certificates with CLIENT_AUTH scope are used by a load balancer (TLS client) to be presented to the backend (TLS server) when backend mTLS is configured.
    /// See https://cloud.google.com/load-balancing/docs/backend-authenticated-tls-backend-mtls#client-certificate.
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

    /// <summary>
    /// Certificate data for a SelfManaged Certificate.
    /// SelfManaged Certificates are uploaded by the user. Updating such
    /// certificates before they expire remains the user&apos;s responsibility.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("selfManaged")]
    public V1beta2CertificateStatusAtProviderSelfManaged? SelfManaged { get; set; }

    /// <summary>
    /// The combination of labels configured directly on the resource
    /// and default labels configured on the provider.
    /// </summary>
    [JsonPropertyName("terraformLabels")]
    public IDictionary<string, string>? TerraformLabels { get; set; }
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

/// <summary>Certificate is the Schema for the Certificates API. Certificate represents a HTTP-reachable backend for a Certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Certificate : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2CertificateSpec>, IStatus<V1beta2CertificateStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Certificate";
    public const string KubeGroup = "certificatemanager.gcp.upbound.io";
    public const string KubePluralName = "certificates";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "certificatemanager.gcp.upbound.io/v1beta2";

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