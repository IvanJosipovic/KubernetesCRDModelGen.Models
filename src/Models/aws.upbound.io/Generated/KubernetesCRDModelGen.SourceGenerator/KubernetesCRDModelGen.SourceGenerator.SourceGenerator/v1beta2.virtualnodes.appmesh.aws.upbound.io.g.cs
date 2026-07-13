#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appmesh.aws.upbound.io;
/// <summary>VirtualNode is the Schema for the VirtualNodes API. Provides an AWS App Mesh virtual node resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2VirtualNodeList : IKubernetesObject<V1ListMeta>, IItems<V1beta2VirtualNode>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "VirtualNodeList";
    public const string KubeGroup = "appmesh.aws.upbound.io";
    public const string KubePluralName = "virtualnodes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appmesh.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNodeList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2VirtualNode objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2VirtualNode> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecDeletionPolicyEnum>))]
public enum V1beta2VirtualNodeSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecForProviderMeshNameRefPolicyResolutionEnum>))]
public enum V1beta2VirtualNodeSpecForProviderMeshNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecForProviderMeshNameRefPolicyResolveEnum>))]
public enum V1beta2VirtualNodeSpecForProviderMeshNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderMeshNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNodeSpecForProviderMeshNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNodeSpecForProviderMeshNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderMeshNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualNodeSpecForProviderMeshNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecForProviderMeshNameSelectorPolicyResolutionEnum>))]
public enum V1beta2VirtualNodeSpecForProviderMeshNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecForProviderMeshNameSelectorPolicyResolveEnum>))]
public enum V1beta2VirtualNodeSpecForProviderMeshNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderMeshNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNodeSpecForProviderMeshNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNodeSpecForProviderMeshNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderMeshNameSelector
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
    public V1beta2VirtualNodeSpecForProviderMeshNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsCertificateFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsCertificateSds? Sds { get; set; }
}

/// <summary>Criteria for determining a SAN&apos;s match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary>SANs for a TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN&apos;s match.</summary>
    [JsonPropertyName("match")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNamesMatch? Match { get; set; }
}

/// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>TLS validation context trust.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds? Sds { get; set; }
}

/// <summary>TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrust? Trust { get; set; }
}

/// <summary>Transport Layer Security (TLS) client policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTls
{
    /// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsCertificate? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTlsValidation? Validation { get; set; }
}

/// <summary>Client policy for the backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicyTls? Tls { get; set; }
}

/// <summary>Virtual service to use as a backend for a virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendVirtualService
{
    /// <summary>Client policy for the backend.</summary>
    [JsonPropertyName("clientPolicy")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendVirtualServiceClientPolicy? ClientPolicy { get; set; }

    /// <summary>Name of the virtual service that is acting as a virtual node backend. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackend
{
    /// <summary>Virtual service to use as a backend for a virtual node.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendVirtualService? VirtualService { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsCertificateFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsCertificateSds? Sds { get; set; }
}

/// <summary>Criteria for determining a SAN&apos;s match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary>SANs for a TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN&apos;s match.</summary>
    [JsonPropertyName("match")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch? Match { get; set; }
}

/// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>TLS validation context trust.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds? Sds { get; set; }
}

/// <summary>TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidationTrust? Trust { get; set; }
}

/// <summary>Transport Layer Security (TLS) client policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTls
{
    /// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsCertificate? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTlsValidation? Validation { get; set; }
}

/// <summary>Client policy for the backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicyTls? Tls { get; set; }
}

/// <summary>Defaults for backends.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecBackendDefaults
{
    /// <summary>Client policy for the backend.</summary>
    [JsonPropertyName("clientPolicy")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendDefaultsClientPolicy? ClientPolicy { get; set; }
}

/// <summary>Connection pool information for gRPC listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerConnectionPoolGrpc
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerConnectionPoolHttp
{
    /// <summary>Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>Number of overflowing requests after max_connections Envoy will queue to upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxPendingRequests")]
    public double? MaxPendingRequests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerConnectionPoolHttp2
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerConnectionPoolTcp
{
    /// <summary>Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }
}

/// <summary>Connection pool information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerConnectionPool
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerConnectionPoolGrpc? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public IList<V1beta2VirtualNodeSpecForProviderSpecListenerConnectionPoolHttp>? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public IList<V1beta2VirtualNodeSpecForProviderSpecListenerConnectionPoolHttp2>? Http2 { get; set; }

    /// <summary>Connection pool information for TCP listeners.</summary>
    [JsonPropertyName("tcp")]
    public IList<V1beta2VirtualNodeSpecForProviderSpecListenerConnectionPoolTcp>? Tcp { get; set; }
}

/// <summary>Health check information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerHealthCheck
{
    /// <summary>Number of consecutive successful health checks that must occur before declaring listener healthy.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Time period in milliseconds between each health check execution.</summary>
    [JsonPropertyName("intervalMillis")]
    public double? IntervalMillis { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Amount of time to wait when receiving a response from the health check, in milliseconds.</summary>
    [JsonPropertyName("timeoutMillis")]
    public double? TimeoutMillis { get; set; }

    /// <summary>Number of consecutive failed health checks that must occur before declaring a virtual node unhealthy.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary>Base amount of time for which a host is ejected.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerOutlierDetectionBaseEjectionDuration
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Time interval between ejection sweep analysis.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerOutlierDetectionInterval
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Outlier detection information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerOutlierDetection
{
    /// <summary>Base amount of time for which a host is ejected.</summary>
    [JsonPropertyName("baseEjectionDuration")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerOutlierDetectionBaseEjectionDuration? BaseEjectionDuration { get; set; }

    /// <summary>Time interval between ejection sweep analysis.</summary>
    [JsonPropertyName("interval")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerOutlierDetectionInterval? Interval { get; set; }

    /// <summary>
    /// Maximum percentage of hosts in load balancing pool for upstream service that can be ejected. Will eject at least one host regardless of the value.
    /// Minimum value of 0. Maximum value of 100.
    /// </summary>
    [JsonPropertyName("maxEjectionPercent")]
    public double? MaxEjectionPercent { get; set; }

    /// <summary>Number of consecutive 5xx errors required for ejection. Minimum value of 1.</summary>
    [JsonPropertyName("maxServerErrors")]
    public double? MaxServerErrors { get; set; }
}

/// <summary>Port mapping information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerPortMapping
{
    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutGrpcIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutGrpcPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Connection pool information for gRPC listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutGrpc
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutGrpcIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutGrpcPerRequest? PerRequest { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutHttpIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutHttpPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Connection pool information for HTTP listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutHttp
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutHttpIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutHttpPerRequest? PerRequest { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutHttp2Idle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutHttp2PerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Connection pool information for HTTP2 listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutHttp2
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutHttp2Idle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutHttp2PerRequest? PerRequest { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutTcpIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Connection pool information for TCP listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutTcp
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutTcpIdle? Idle { get; set; }
}

/// <summary>Timeouts for different protocols.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTimeout
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutGrpc? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutHttp? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutHttp2? Http2 { get; set; }

    /// <summary>Connection pool information for TCP listeners.</summary>
    [JsonPropertyName("tcp")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTimeoutTcp? Tcp { get; set; }
}

/// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTlsCertificateAcm
{
    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTlsCertificate
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTlsCertificateAcm? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTlsCertificateFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTlsCertificateSds? Sds { get; set; }
}

/// <summary>Criteria for determining a SAN&apos;s match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary>SANs for a TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN&apos;s match.</summary>
    [JsonPropertyName("match")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch? Match { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>TLS validation context trust.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTlsValidationTrust
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTlsValidationTrustFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTlsValidationTrustSds? Sds { get; set; }
}

/// <summary>TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTlsValidationSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTlsValidationTrust? Trust { get; set; }
}

/// <summary>Transport Layer Security (TLS) client policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListenerTls
{
    /// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTlsCertificate? Certificate { get; set; }

    /// <summary>Listener&apos;s TLS mode. Valid values: DISABLED, PERMISSIVE, STRICT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTlsValidation? Validation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecListener
{
    /// <summary>Connection pool information for the listener.</summary>
    [JsonPropertyName("connectionPool")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerConnectionPool? ConnectionPool { get; set; }

    /// <summary>Health check information for the listener.</summary>
    [JsonPropertyName("healthCheck")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerHealthCheck? HealthCheck { get; set; }

    /// <summary>Outlier detection information for the listener.</summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Port mapping information for the listener.</summary>
    [JsonPropertyName("portMapping")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerPortMapping? PortMapping { get; set; }

    /// <summary>Timeouts for different protocols.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTimeout? Timeout { get; set; }

    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public V1beta2VirtualNodeSpecForProviderSpecListenerTls? Tls { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecLoggingAccessLogFileFormatJson
{
    /// <summary>The specified key for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The specified format for the logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecLoggingAccessLogFileFormat
{
    /// <summary>The logging format for JSON.</summary>
    [JsonPropertyName("json")]
    public IList<V1beta2VirtualNodeSpecForProviderSpecLoggingAccessLogFileFormatJson>? Json { get; set; }

    /// <summary>The logging format for text. Must be between 1 and 1000 characters in length.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecLoggingAccessLogFile
{
    /// <summary>The specified format for the logs.</summary>
    [JsonPropertyName("format")]
    public V1beta2VirtualNodeSpecForProviderSpecLoggingAccessLogFileFormat? Format { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Access log configuration for a virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecLoggingAccessLog
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeSpecForProviderSpecLoggingAccessLogFile? File { get; set; }
}

/// <summary>Inbound and outbound access logging information for the virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecLogging
{
    /// <summary>Access log configuration for a virtual node.</summary>
    [JsonPropertyName("accessLog")]
    public V1beta2VirtualNodeSpecForProviderSpecLoggingAccessLog? AccessLog { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolutionEnum>))]
public enum V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolveEnum>))]
public enum V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a HTTPNamespace in servicediscovery to populate namespaceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolutionEnum>))]
public enum V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolveEnum>))]
public enum V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a HTTPNamespace in servicediscovery to populate namespaceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelector
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
    public V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Any AWS Cloud Map information for the virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMap
{
    /// <summary>String map that contains attributes with values that you can use to filter instances by any custom attribute that you specified when you registered the instance. Only instances that match all of the specified key/value pairs will be returned.</summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, string>? Attributes { get; set; }

    /// <summary>
    /// Name of the AWS Cloud Map namespace to use.
    /// Use the aws_service_discovery_http_namespace resource to configure a Cloud Map namespace. Must be between 1 and 1024 characters in length.
    /// </summary>
    [JsonPropertyName("namespaceName")]
    public string? NamespaceName { get; set; }

    /// <summary>Reference to a HTTPNamespace in servicediscovery to populate namespaceName.</summary>
    [JsonPropertyName("namespaceNameRef")]
    public V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRef? NamespaceNameRef { get; set; }

    /// <summary>Selector for a HTTPNamespace in servicediscovery to populate namespaceName.</summary>
    [JsonPropertyName("namespaceNameSelector")]
    public V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelector? NamespaceNameSelector { get; set; }

    /// <summary>attribute of the dns object to hostname.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>DNS service name for the virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryDns
{
    /// <summary>DNS host name for your virtual node.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>The preferred IP version that this virtual node uses. Valid values: IPv6_PREFERRED, IPv4_PREFERRED, IPv4_ONLY, IPv6_ONLY.</summary>
    [JsonPropertyName("ipPreference")]
    public string? IpPreference { get; set; }

    /// <summary>The DNS response type for the virtual node. Valid values: LOADBALANCER, ENDPOINTS.</summary>
    [JsonPropertyName("responseType")]
    public string? ResponseType { get; set; }
}

/// <summary>Service discovery information for the virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpecServiceDiscovery
{
    /// <summary>Any AWS Cloud Map information for the virtual node.</summary>
    [JsonPropertyName("awsCloudMap")]
    public V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryAwsCloudMap? AwsCloudMap { get; set; }

    /// <summary>DNS service name for the virtual node.</summary>
    [JsonPropertyName("dns")]
    public V1beta2VirtualNodeSpecForProviderSpecServiceDiscoveryDns? Dns { get; set; }
}

/// <summary>Virtual node specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProviderSpec
{
    /// <summary>Backends to which the virtual node is expected to send outbound traffic.</summary>
    [JsonPropertyName("backend")]
    public IList<V1beta2VirtualNodeSpecForProviderSpecBackend>? Backend { get; set; }

    /// <summary>Defaults for backends.</summary>
    [JsonPropertyName("backendDefaults")]
    public V1beta2VirtualNodeSpecForProviderSpecBackendDefaults? BackendDefaults { get; set; }

    /// <summary>Listeners from which the virtual node is expected to receive inbound traffic.</summary>
    [JsonPropertyName("listener")]
    public IList<V1beta2VirtualNodeSpecForProviderSpecListener>? Listener { get; set; }

    /// <summary>Inbound and outbound access logging information for the virtual node.</summary>
    [JsonPropertyName("logging")]
    public V1beta2VirtualNodeSpecForProviderSpecLogging? Logging { get; set; }

    /// <summary>Service discovery information for the virtual node.</summary>
    [JsonPropertyName("serviceDiscovery")]
    public V1beta2VirtualNodeSpecForProviderSpecServiceDiscovery? ServiceDiscovery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecForProvider
{
    /// <summary>Name of the service mesh in which to create the virtual node. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameRef")]
    public V1beta2VirtualNodeSpecForProviderMeshNameRef? MeshNameRef { get; set; }

    /// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameSelector")]
    public V1beta2VirtualNodeSpecForProviderMeshNameSelector? MeshNameSelector { get; set; }

    /// <summary>AWS account ID of the service mesh&apos;s owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the virtual node. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Virtual node specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta2VirtualNodeSpecForProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecInitProviderMeshNameRefPolicyResolutionEnum>))]
public enum V1beta2VirtualNodeSpecInitProviderMeshNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecInitProviderMeshNameRefPolicyResolveEnum>))]
public enum V1beta2VirtualNodeSpecInitProviderMeshNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderMeshNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNodeSpecInitProviderMeshNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNodeSpecInitProviderMeshNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderMeshNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualNodeSpecInitProviderMeshNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecInitProviderMeshNameSelectorPolicyResolutionEnum>))]
public enum V1beta2VirtualNodeSpecInitProviderMeshNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecInitProviderMeshNameSelectorPolicyResolveEnum>))]
public enum V1beta2VirtualNodeSpecInitProviderMeshNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderMeshNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNodeSpecInitProviderMeshNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNodeSpecInitProviderMeshNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderMeshNameSelector
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
    public V1beta2VirtualNodeSpecInitProviderMeshNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsCertificateFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsCertificateSds? Sds { get; set; }
}

/// <summary>Criteria for determining a SAN&apos;s match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary>SANs for a TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN&apos;s match.</summary>
    [JsonPropertyName("match")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNamesMatch? Match { get; set; }
}

/// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>TLS validation context trust.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds? Sds { get; set; }
}

/// <summary>TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrust? Trust { get; set; }
}

/// <summary>Transport Layer Security (TLS) client policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTls
{
    /// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsCertificate? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTlsValidation? Validation { get; set; }
}

/// <summary>Client policy for the backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicyTls? Tls { get; set; }
}

/// <summary>Virtual service to use as a backend for a virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualService
{
    /// <summary>Client policy for the backend.</summary>
    [JsonPropertyName("clientPolicy")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualServiceClientPolicy? ClientPolicy { get; set; }

    /// <summary>Name of the virtual service that is acting as a virtual node backend. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackend
{
    /// <summary>Virtual service to use as a backend for a virtual node.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendVirtualService? VirtualService { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificateFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificateSds? Sds { get; set; }
}

/// <summary>Criteria for determining a SAN&apos;s match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary>SANs for a TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN&apos;s match.</summary>
    [JsonPropertyName("match")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch? Match { get; set; }
}

/// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>TLS validation context trust.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds? Sds { get; set; }
}

/// <summary>TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidationTrust? Trust { get; set; }
}

/// <summary>Transport Layer Security (TLS) client policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTls
{
    /// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsCertificate? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTlsValidation? Validation { get; set; }
}

/// <summary>Client policy for the backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicyTls? Tls { get; set; }
}

/// <summary>Defaults for backends.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecBackendDefaults
{
    /// <summary>Client policy for the backend.</summary>
    [JsonPropertyName("clientPolicy")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendDefaultsClientPolicy? ClientPolicy { get; set; }
}

/// <summary>Connection pool information for gRPC listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerConnectionPoolGrpc
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerConnectionPoolHttp
{
    /// <summary>Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>Number of overflowing requests after max_connections Envoy will queue to upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxPendingRequests")]
    public double? MaxPendingRequests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerConnectionPoolHttp2
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerConnectionPoolTcp
{
    /// <summary>Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }
}

/// <summary>Connection pool information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerConnectionPool
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerConnectionPoolGrpc? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public IList<V1beta2VirtualNodeSpecInitProviderSpecListenerConnectionPoolHttp>? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public IList<V1beta2VirtualNodeSpecInitProviderSpecListenerConnectionPoolHttp2>? Http2 { get; set; }

    /// <summary>Connection pool information for TCP listeners.</summary>
    [JsonPropertyName("tcp")]
    public IList<V1beta2VirtualNodeSpecInitProviderSpecListenerConnectionPoolTcp>? Tcp { get; set; }
}

/// <summary>Health check information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerHealthCheck
{
    /// <summary>Number of consecutive successful health checks that must occur before declaring listener healthy.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Time period in milliseconds between each health check execution.</summary>
    [JsonPropertyName("intervalMillis")]
    public double? IntervalMillis { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Amount of time to wait when receiving a response from the health check, in milliseconds.</summary>
    [JsonPropertyName("timeoutMillis")]
    public double? TimeoutMillis { get; set; }

    /// <summary>Number of consecutive failed health checks that must occur before declaring a virtual node unhealthy.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary>Base amount of time for which a host is ejected.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerOutlierDetectionBaseEjectionDuration
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Time interval between ejection sweep analysis.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerOutlierDetectionInterval
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Outlier detection information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerOutlierDetection
{
    /// <summary>Base amount of time for which a host is ejected.</summary>
    [JsonPropertyName("baseEjectionDuration")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerOutlierDetectionBaseEjectionDuration? BaseEjectionDuration { get; set; }

    /// <summary>Time interval between ejection sweep analysis.</summary>
    [JsonPropertyName("interval")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerOutlierDetectionInterval? Interval { get; set; }

    /// <summary>
    /// Maximum percentage of hosts in load balancing pool for upstream service that can be ejected. Will eject at least one host regardless of the value.
    /// Minimum value of 0. Maximum value of 100.
    /// </summary>
    [JsonPropertyName("maxEjectionPercent")]
    public double? MaxEjectionPercent { get; set; }

    /// <summary>Number of consecutive 5xx errors required for ejection. Minimum value of 1.</summary>
    [JsonPropertyName("maxServerErrors")]
    public double? MaxServerErrors { get; set; }
}

/// <summary>Port mapping information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerPortMapping
{
    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutGrpcIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutGrpcPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Connection pool information for gRPC listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutGrpc
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutGrpcIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutGrpcPerRequest? PerRequest { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutHttpIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutHttpPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Connection pool information for HTTP listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutHttp
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutHttpIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutHttpPerRequest? PerRequest { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutHttp2Idle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutHttp2PerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Connection pool information for HTTP2 listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutHttp2
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutHttp2Idle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutHttp2PerRequest? PerRequest { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutTcpIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Connection pool information for TCP listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutTcp
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutTcpIdle? Idle { get; set; }
}

/// <summary>Timeouts for different protocols.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTimeout
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutGrpc? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutHttp? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutHttp2? Http2 { get; set; }

    /// <summary>Connection pool information for TCP listeners.</summary>
    [JsonPropertyName("tcp")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTimeoutTcp? Tcp { get; set; }
}

/// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTlsCertificateAcm
{
    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTlsCertificate
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTlsCertificateAcm? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTlsCertificateFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTlsCertificateSds? Sds { get; set; }
}

/// <summary>Criteria for determining a SAN&apos;s match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary>SANs for a TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN&apos;s match.</summary>
    [JsonPropertyName("match")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch? Match { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>TLS validation context trust.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTlsValidationTrust
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTlsValidationTrustFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTlsValidationTrustSds? Sds { get; set; }
}

/// <summary>TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTlsValidationSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTlsValidationTrust? Trust { get; set; }
}

/// <summary>Transport Layer Security (TLS) client policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListenerTls
{
    /// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTlsCertificate? Certificate { get; set; }

    /// <summary>Listener&apos;s TLS mode. Valid values: DISABLED, PERMISSIVE, STRICT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTlsValidation? Validation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecListener
{
    /// <summary>Connection pool information for the listener.</summary>
    [JsonPropertyName("connectionPool")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerConnectionPool? ConnectionPool { get; set; }

    /// <summary>Health check information for the listener.</summary>
    [JsonPropertyName("healthCheck")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerHealthCheck? HealthCheck { get; set; }

    /// <summary>Outlier detection information for the listener.</summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Port mapping information for the listener.</summary>
    [JsonPropertyName("portMapping")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerPortMapping? PortMapping { get; set; }

    /// <summary>Timeouts for different protocols.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTimeout? Timeout { get; set; }

    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public V1beta2VirtualNodeSpecInitProviderSpecListenerTls? Tls { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecLoggingAccessLogFileFormatJson
{
    /// <summary>The specified key for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The specified format for the logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecLoggingAccessLogFileFormat
{
    /// <summary>The logging format for JSON.</summary>
    [JsonPropertyName("json")]
    public IList<V1beta2VirtualNodeSpecInitProviderSpecLoggingAccessLogFileFormatJson>? Json { get; set; }

    /// <summary>The logging format for text. Must be between 1 and 1000 characters in length.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecLoggingAccessLogFile
{
    /// <summary>The specified format for the logs.</summary>
    [JsonPropertyName("format")]
    public V1beta2VirtualNodeSpecInitProviderSpecLoggingAccessLogFileFormat? Format { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Access log configuration for a virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecLoggingAccessLog
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeSpecInitProviderSpecLoggingAccessLogFile? File { get; set; }
}

/// <summary>Inbound and outbound access logging information for the virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecLogging
{
    /// <summary>Access log configuration for a virtual node.</summary>
    [JsonPropertyName("accessLog")]
    public V1beta2VirtualNodeSpecInitProviderSpecLoggingAccessLog? AccessLog { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolutionEnum>))]
public enum V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolveEnum>))]
public enum V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a HTTPNamespace in servicediscovery to populate namespaceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolutionEnum>))]
public enum V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolveEnum>))]
public enum V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a HTTPNamespace in servicediscovery to populate namespaceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelector
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
    public V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Any AWS Cloud Map information for the virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMap
{
    /// <summary>String map that contains attributes with values that you can use to filter instances by any custom attribute that you specified when you registered the instance. Only instances that match all of the specified key/value pairs will be returned.</summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, string>? Attributes { get; set; }

    /// <summary>
    /// Name of the AWS Cloud Map namespace to use.
    /// Use the aws_service_discovery_http_namespace resource to configure a Cloud Map namespace. Must be between 1 and 1024 characters in length.
    /// </summary>
    [JsonPropertyName("namespaceName")]
    public string? NamespaceName { get; set; }

    /// <summary>Reference to a HTTPNamespace in servicediscovery to populate namespaceName.</summary>
    [JsonPropertyName("namespaceNameRef")]
    public V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameRef? NamespaceNameRef { get; set; }

    /// <summary>Selector for a HTTPNamespace in servicediscovery to populate namespaceName.</summary>
    [JsonPropertyName("namespaceNameSelector")]
    public V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMapNamespaceNameSelector? NamespaceNameSelector { get; set; }

    /// <summary>attribute of the dns object to hostname.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>DNS service name for the virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryDns
{
    /// <summary>DNS host name for your virtual node.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>The preferred IP version that this virtual node uses. Valid values: IPv6_PREFERRED, IPv4_PREFERRED, IPv4_ONLY, IPv6_ONLY.</summary>
    [JsonPropertyName("ipPreference")]
    public string? IpPreference { get; set; }

    /// <summary>The DNS response type for the virtual node. Valid values: LOADBALANCER, ENDPOINTS.</summary>
    [JsonPropertyName("responseType")]
    public string? ResponseType { get; set; }
}

/// <summary>Service discovery information for the virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpecServiceDiscovery
{
    /// <summary>Any AWS Cloud Map information for the virtual node.</summary>
    [JsonPropertyName("awsCloudMap")]
    public V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryAwsCloudMap? AwsCloudMap { get; set; }

    /// <summary>DNS service name for the virtual node.</summary>
    [JsonPropertyName("dns")]
    public V1beta2VirtualNodeSpecInitProviderSpecServiceDiscoveryDns? Dns { get; set; }
}

/// <summary>Virtual node specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecInitProviderSpec
{
    /// <summary>Backends to which the virtual node is expected to send outbound traffic.</summary>
    [JsonPropertyName("backend")]
    public IList<V1beta2VirtualNodeSpecInitProviderSpecBackend>? Backend { get; set; }

    /// <summary>Defaults for backends.</summary>
    [JsonPropertyName("backendDefaults")]
    public V1beta2VirtualNodeSpecInitProviderSpecBackendDefaults? BackendDefaults { get; set; }

    /// <summary>Listeners from which the virtual node is expected to receive inbound traffic.</summary>
    [JsonPropertyName("listener")]
    public IList<V1beta2VirtualNodeSpecInitProviderSpecListener>? Listener { get; set; }

    /// <summary>Inbound and outbound access logging information for the virtual node.</summary>
    [JsonPropertyName("logging")]
    public V1beta2VirtualNodeSpecInitProviderSpecLogging? Logging { get; set; }

    /// <summary>Service discovery information for the virtual node.</summary>
    [JsonPropertyName("serviceDiscovery")]
    public V1beta2VirtualNodeSpecInitProviderSpecServiceDiscovery? ServiceDiscovery { get; set; }
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
public partial class V1beta2VirtualNodeSpecInitProvider
{
    /// <summary>Name of the service mesh in which to create the virtual node. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>Reference to a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameRef")]
    public V1beta2VirtualNodeSpecInitProviderMeshNameRef? MeshNameRef { get; set; }

    /// <summary>Selector for a Mesh in appmesh to populate meshName.</summary>
    [JsonPropertyName("meshNameSelector")]
    public V1beta2VirtualNodeSpecInitProviderMeshNameSelector? MeshNameSelector { get; set; }

    /// <summary>AWS account ID of the service mesh&apos;s owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the virtual node. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Virtual node specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta2VirtualNodeSpecInitProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecManagementPoliciesEnum>))]
public enum V1beta2VirtualNodeSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2VirtualNodeSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2VirtualNodeSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2VirtualNodeSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2VirtualNodeSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2VirtualNodeSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2VirtualNodeSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>VirtualNodeSpec defines the desired state of VirtualNode</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeSpec
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
    public V1beta2VirtualNodeSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2VirtualNodeSpecForProvider ForProvider { get; set; }

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
    public V1beta2VirtualNodeSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2VirtualNodeSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2VirtualNodeSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2VirtualNodeSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsCertificateFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsCertificateSds? Sds { get; set; }
}

/// <summary>Criteria for determining a SAN&apos;s match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary>SANs for a TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN&apos;s match.</summary>
    [JsonPropertyName("match")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNamesMatch? Match { get; set; }
}

/// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>TLS validation context trust.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustAcm? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrustSds? Sds { get; set; }
}

/// <summary>TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidationTrust? Trust { get; set; }
}

/// <summary>Transport Layer Security (TLS) client policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTls
{
    /// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsCertificate? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTlsValidation? Validation { get; set; }
}

/// <summary>Client policy for the backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicyTls? Tls { get; set; }
}

/// <summary>Virtual service to use as a backend for a virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualService
{
    /// <summary>Client policy for the backend.</summary>
    [JsonPropertyName("clientPolicy")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualServiceClientPolicy? ClientPolicy { get; set; }

    /// <summary>Name of the virtual service that is acting as a virtual node backend. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("virtualServiceName")]
    public string? VirtualServiceName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackend
{
    /// <summary>Virtual service to use as a backend for a virtual node.</summary>
    [JsonPropertyName("virtualService")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendVirtualService? VirtualService { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificate
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificateFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificateSds? Sds { get; set; }
}

/// <summary>Criteria for determining a SAN&apos;s match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary>SANs for a TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN&apos;s match.</summary>
    [JsonPropertyName("match")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNamesMatch? Match { get; set; }
}

/// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm
{
    /// <summary>One or more ACM ARNs.</summary>
    [JsonPropertyName("certificateAuthorityArns")]
    public IList<string>? CertificateAuthorityArns { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>TLS validation context trust.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrust
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustAcm? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrustSds? Sds { get; set; }
}

/// <summary>TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidationTrust? Trust { get; set; }
}

/// <summary>Transport Layer Security (TLS) client policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTls
{
    /// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsCertificate? Certificate { get; set; }

    /// <summary>Whether the policy is enforced. Default is true.</summary>
    [JsonPropertyName("enforce")]
    public bool? Enforce { get; set; }

    /// <summary>One or more ports that the policy is enforced for.</summary>
    [JsonPropertyName("ports")]
    public IList<double>? Ports { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTlsValidation? Validation { get; set; }
}

/// <summary>Client policy for the backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicy
{
    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicyTls? Tls { get; set; }
}

/// <summary>Defaults for backends.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecBackendDefaults
{
    /// <summary>Client policy for the backend.</summary>
    [JsonPropertyName("clientPolicy")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendDefaultsClientPolicy? ClientPolicy { get; set; }
}

/// <summary>Connection pool information for gRPC listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerConnectionPoolGrpc
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerConnectionPoolHttp
{
    /// <summary>Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }

    /// <summary>Number of overflowing requests after max_connections Envoy will queue to upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxPendingRequests")]
    public double? MaxPendingRequests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerConnectionPoolHttp2
{
    /// <summary>Maximum number of inflight requests Envoy can concurrently support across hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxRequests")]
    public double? MaxRequests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerConnectionPoolTcp
{
    /// <summary>Maximum number of outbound TCP connections Envoy can establish concurrently with all hosts in upstream cluster. Minimum value of 1.</summary>
    [JsonPropertyName("maxConnections")]
    public double? MaxConnections { get; set; }
}

/// <summary>Connection pool information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerConnectionPool
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerConnectionPoolGrpc? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public IList<V1beta2VirtualNodeStatusAtProviderSpecListenerConnectionPoolHttp>? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public IList<V1beta2VirtualNodeStatusAtProviderSpecListenerConnectionPoolHttp2>? Http2 { get; set; }

    /// <summary>Connection pool information for TCP listeners.</summary>
    [JsonPropertyName("tcp")]
    public IList<V1beta2VirtualNodeStatusAtProviderSpecListenerConnectionPoolTcp>? Tcp { get; set; }
}

/// <summary>Health check information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerHealthCheck
{
    /// <summary>Number of consecutive successful health checks that must occur before declaring listener healthy.</summary>
    [JsonPropertyName("healthyThreshold")]
    public double? HealthyThreshold { get; set; }

    /// <summary>Time period in milliseconds between each health check execution.</summary>
    [JsonPropertyName("intervalMillis")]
    public double? IntervalMillis { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }

    /// <summary>Amount of time to wait when receiving a response from the health check, in milliseconds.</summary>
    [JsonPropertyName("timeoutMillis")]
    public double? TimeoutMillis { get; set; }

    /// <summary>Number of consecutive failed health checks that must occur before declaring a virtual node unhealthy.</summary>
    [JsonPropertyName("unhealthyThreshold")]
    public double? UnhealthyThreshold { get; set; }
}

/// <summary>Base amount of time for which a host is ejected.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerOutlierDetectionBaseEjectionDuration
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Time interval between ejection sweep analysis.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerOutlierDetectionInterval
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Outlier detection information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerOutlierDetection
{
    /// <summary>Base amount of time for which a host is ejected.</summary>
    [JsonPropertyName("baseEjectionDuration")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerOutlierDetectionBaseEjectionDuration? BaseEjectionDuration { get; set; }

    /// <summary>Time interval between ejection sweep analysis.</summary>
    [JsonPropertyName("interval")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerOutlierDetectionInterval? Interval { get; set; }

    /// <summary>
    /// Maximum percentage of hosts in load balancing pool for upstream service that can be ejected. Will eject at least one host regardless of the value.
    /// Minimum value of 0. Maximum value of 100.
    /// </summary>
    [JsonPropertyName("maxEjectionPercent")]
    public double? MaxEjectionPercent { get; set; }

    /// <summary>Number of consecutive 5xx errors required for ejection. Minimum value of 1.</summary>
    [JsonPropertyName("maxServerErrors")]
    public double? MaxServerErrors { get; set; }
}

/// <summary>Port mapping information for the listener.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerPortMapping
{
    /// <summary>Port used for the port mapping.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Protocol used for the port mapping. Valid values are http, http2, tcp and grpc.</summary>
    [JsonPropertyName("protocol")]
    public string? Protocol { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutGrpcIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutGrpcPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Connection pool information for gRPC listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutGrpc
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutGrpcIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutGrpcPerRequest? PerRequest { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutHttpIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutHttpPerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Connection pool information for HTTP listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutHttp
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutHttpIdle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutHttpPerRequest? PerRequest { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutHttp2Idle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Per request timeout.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutHttp2PerRequest
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Connection pool information for HTTP2 listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutHttp2
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutHttp2Idle? Idle { get; set; }

    /// <summary>Per request timeout.</summary>
    [JsonPropertyName("perRequest")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutHttp2PerRequest? PerRequest { get; set; }
}

/// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutTcpIdle
{
    /// <summary>Unit of time. Valid values: ms, s.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>Connection pool information for TCP listeners.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutTcp
{
    /// <summary>Idle timeout. An idle timeout bounds the amount of time that a connection may be idle.</summary>
    [JsonPropertyName("idle")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutTcpIdle? Idle { get; set; }
}

/// <summary>Timeouts for different protocols.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTimeout
{
    /// <summary>Connection pool information for gRPC listeners.</summary>
    [JsonPropertyName("grpc")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutGrpc? Grpc { get; set; }

    /// <summary>Connection pool information for HTTP listeners.</summary>
    [JsonPropertyName("http")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutHttp? Http { get; set; }

    /// <summary>Connection pool information for HTTP2 listeners.</summary>
    [JsonPropertyName("http2")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutHttp2? Http2 { get; set; }

    /// <summary>Connection pool information for TCP listeners.</summary>
    [JsonPropertyName("tcp")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTimeoutTcp? Tcp { get; set; }
}

/// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTlsCertificateAcm
{
    /// <summary>ARN for the certificate.</summary>
    [JsonPropertyName("certificateArn")]
    public string? CertificateArn { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTlsCertificateFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }

    /// <summary>Private key for a certificate stored on the file system of the mesh endpoint that the proxy is running on.</summary>
    [JsonPropertyName("privateKey")]
    public string? PrivateKey { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTlsCertificateSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTlsCertificate
{
    /// <summary>TLS validation context trust for an AWS Certificate Manager (ACM) certificate.</summary>
    [JsonPropertyName("acm")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTlsCertificateAcm? Acm { get; set; }

    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTlsCertificateFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTlsCertificateSds? Sds { get; set; }
}

/// <summary>Criteria for determining a SAN&apos;s match.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch
{
    /// <summary>Values sent must match the specified values exactly.</summary>
    [JsonPropertyName("exact")]
    public IList<string>? Exact { get; set; }
}

/// <summary>SANs for a TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTlsValidationSubjectAlternativeNames
{
    /// <summary>Criteria for determining a SAN&apos;s match.</summary>
    [JsonPropertyName("match")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTlsValidationSubjectAlternativeNamesMatch? Match { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTlsValidationTrustFile
{
    /// <summary>Certificate chain for the certificate.</summary>
    [JsonPropertyName("certificateChain")]
    public string? CertificateChain { get; set; }
}

/// <summary>A Secret Discovery Service certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTlsValidationTrustSds
{
    /// <summary>Name of the secret secret requested from the Secret Discovery Service provider representing Transport Layer Security (TLS) materials like a certificate or certificate chain.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

/// <summary>TLS validation context trust.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTlsValidationTrust
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTlsValidationTrustFile? File { get; set; }

    /// <summary>A Secret Discovery Service certificate.</summary>
    [JsonPropertyName("sds")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTlsValidationTrustSds? Sds { get; set; }
}

/// <summary>TLS validation context.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTlsValidation
{
    /// <summary>SANs for a TLS validation context.</summary>
    [JsonPropertyName("subjectAlternativeNames")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTlsValidationSubjectAlternativeNames? SubjectAlternativeNames { get; set; }

    /// <summary>TLS validation context trust.</summary>
    [JsonPropertyName("trust")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTlsValidationTrust? Trust { get; set; }
}

/// <summary>Transport Layer Security (TLS) client policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListenerTls
{
    /// <summary>Virtual node&apos;s client&apos;s Transport Layer Security (TLS) certificate.</summary>
    [JsonPropertyName("certificate")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTlsCertificate? Certificate { get; set; }

    /// <summary>Listener&apos;s TLS mode. Valid values: DISABLED, PERMISSIVE, STRICT.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>TLS validation context.</summary>
    [JsonPropertyName("validation")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTlsValidation? Validation { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecListener
{
    /// <summary>Connection pool information for the listener.</summary>
    [JsonPropertyName("connectionPool")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerConnectionPool? ConnectionPool { get; set; }

    /// <summary>Health check information for the listener.</summary>
    [JsonPropertyName("healthCheck")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerHealthCheck? HealthCheck { get; set; }

    /// <summary>Outlier detection information for the listener.</summary>
    [JsonPropertyName("outlierDetection")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerOutlierDetection? OutlierDetection { get; set; }

    /// <summary>Port mapping information for the listener.</summary>
    [JsonPropertyName("portMapping")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerPortMapping? PortMapping { get; set; }

    /// <summary>Timeouts for different protocols.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTimeout? Timeout { get; set; }

    /// <summary>Transport Layer Security (TLS) client policy.</summary>
    [JsonPropertyName("tls")]
    public V1beta2VirtualNodeStatusAtProviderSpecListenerTls? Tls { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecLoggingAccessLogFileFormatJson
{
    /// <summary>The specified key for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The specified value for the JSON. Must be between 1 and 100 characters in length.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The specified format for the logs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecLoggingAccessLogFileFormat
{
    /// <summary>The logging format for JSON.</summary>
    [JsonPropertyName("json")]
    public IList<V1beta2VirtualNodeStatusAtProviderSpecLoggingAccessLogFileFormatJson>? Json { get; set; }

    /// <summary>The logging format for text. Must be between 1 and 1000 characters in length.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }
}

/// <summary>Local file certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecLoggingAccessLogFile
{
    /// <summary>The specified format for the logs.</summary>
    [JsonPropertyName("format")]
    public V1beta2VirtualNodeStatusAtProviderSpecLoggingAccessLogFileFormat? Format { get; set; }

    /// <summary>File path to write access logs to. You can use /dev/stdout to send access logs to standard out. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>Access log configuration for a virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecLoggingAccessLog
{
    /// <summary>Local file certificate.</summary>
    [JsonPropertyName("file")]
    public V1beta2VirtualNodeStatusAtProviderSpecLoggingAccessLogFile? File { get; set; }
}

/// <summary>Inbound and outbound access logging information for the virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecLogging
{
    /// <summary>Access log configuration for a virtual node.</summary>
    [JsonPropertyName("accessLog")]
    public V1beta2VirtualNodeStatusAtProviderSpecLoggingAccessLog? AccessLog { get; set; }
}

/// <summary>Any AWS Cloud Map information for the virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecServiceDiscoveryAwsCloudMap
{
    /// <summary>String map that contains attributes with values that you can use to filter instances by any custom attribute that you specified when you registered the instance. Only instances that match all of the specified key/value pairs will be returned.</summary>
    [JsonPropertyName("attributes")]
    public IDictionary<string, string>? Attributes { get; set; }

    /// <summary>
    /// Name of the AWS Cloud Map namespace to use.
    /// Use the aws_service_discovery_http_namespace resource to configure a Cloud Map namespace. Must be between 1 and 1024 characters in length.
    /// </summary>
    [JsonPropertyName("namespaceName")]
    public string? NamespaceName { get; set; }

    /// <summary>attribute of the dns object to hostname.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

/// <summary>DNS service name for the virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecServiceDiscoveryDns
{
    /// <summary>DNS host name for your virtual node.</summary>
    [JsonPropertyName("hostname")]
    public string? Hostname { get; set; }

    /// <summary>The preferred IP version that this virtual node uses. Valid values: IPv6_PREFERRED, IPv4_PREFERRED, IPv4_ONLY, IPv6_ONLY.</summary>
    [JsonPropertyName("ipPreference")]
    public string? IpPreference { get; set; }

    /// <summary>The DNS response type for the virtual node. Valid values: LOADBALANCER, ENDPOINTS.</summary>
    [JsonPropertyName("responseType")]
    public string? ResponseType { get; set; }
}

/// <summary>Service discovery information for the virtual node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpecServiceDiscovery
{
    /// <summary>Any AWS Cloud Map information for the virtual node.</summary>
    [JsonPropertyName("awsCloudMap")]
    public V1beta2VirtualNodeStatusAtProviderSpecServiceDiscoveryAwsCloudMap? AwsCloudMap { get; set; }

    /// <summary>DNS service name for the virtual node.</summary>
    [JsonPropertyName("dns")]
    public V1beta2VirtualNodeStatusAtProviderSpecServiceDiscoveryDns? Dns { get; set; }
}

/// <summary>Virtual node specification to apply.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProviderSpec
{
    /// <summary>Backends to which the virtual node is expected to send outbound traffic.</summary>
    [JsonPropertyName("backend")]
    public IList<V1beta2VirtualNodeStatusAtProviderSpecBackend>? Backend { get; set; }

    /// <summary>Defaults for backends.</summary>
    [JsonPropertyName("backendDefaults")]
    public V1beta2VirtualNodeStatusAtProviderSpecBackendDefaults? BackendDefaults { get; set; }

    /// <summary>Listeners from which the virtual node is expected to receive inbound traffic.</summary>
    [JsonPropertyName("listener")]
    public IList<V1beta2VirtualNodeStatusAtProviderSpecListener>? Listener { get; set; }

    /// <summary>Inbound and outbound access logging information for the virtual node.</summary>
    [JsonPropertyName("logging")]
    public V1beta2VirtualNodeStatusAtProviderSpecLogging? Logging { get; set; }

    /// <summary>Service discovery information for the virtual node.</summary>
    [JsonPropertyName("serviceDiscovery")]
    public V1beta2VirtualNodeStatusAtProviderSpecServiceDiscovery? ServiceDiscovery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusAtProvider
{
    /// <summary>ARN of the virtual node.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Creation date of the virtual node.</summary>
    [JsonPropertyName("createdDate")]
    public string? CreatedDate { get; set; }

    /// <summary>ID of the virtual node.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Last update date of the virtual node.</summary>
    [JsonPropertyName("lastUpdatedDate")]
    public string? LastUpdatedDate { get; set; }

    /// <summary>Name of the service mesh in which to create the virtual node. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("meshName")]
    public string? MeshName { get; set; }

    /// <summary>AWS account ID of the service mesh&apos;s owner. Defaults to the account ID the AWS provider is currently connected to.</summary>
    [JsonPropertyName("meshOwner")]
    public string? MeshOwner { get; set; }

    /// <summary>Name to use for the virtual node. Must be between 1 and 255 characters in length.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Resource owner&apos;s AWS account ID.</summary>
    [JsonPropertyName("resourceOwner")]
    public string? ResourceOwner { get; set; }

    /// <summary>Virtual node specification to apply.</summary>
    [JsonPropertyName("spec")]
    public V1beta2VirtualNodeStatusAtProviderSpec? Spec { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatusConditions
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

/// <summary>VirtualNodeStatus defines the observed state of VirtualNode.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2VirtualNodeStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2VirtualNodeStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2VirtualNodeStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>VirtualNode is the Schema for the VirtualNodes API. Provides an AWS App Mesh virtual node resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2VirtualNode : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2VirtualNodeSpec>, IStatus<V1beta2VirtualNodeStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "VirtualNode";
    public const string KubeGroup = "appmesh.aws.upbound.io";
    public const string KubePluralName = "virtualnodes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appmesh.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VirtualNode";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VirtualNodeSpec defines the desired state of VirtualNode</summary>
    [JsonPropertyName("spec")]
    public required V1beta2VirtualNodeSpec Spec { get; set; }

    /// <summary>VirtualNodeStatus defines the observed state of VirtualNode.</summary>
    [JsonPropertyName("status")]
    public V1beta2VirtualNodeStatus? Status { get; set; }
}