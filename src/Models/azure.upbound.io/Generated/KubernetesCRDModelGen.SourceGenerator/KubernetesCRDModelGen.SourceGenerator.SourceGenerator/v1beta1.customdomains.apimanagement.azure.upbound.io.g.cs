#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.apimanagement.azure.upbound.io;
/// <summary>CustomDomain is the Schema for the CustomDomains API. Manages an API Management Custom Domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CustomDomainList : IKubernetesObject<V1ListMeta>, IItems<V1beta1CustomDomain>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CustomDomainList";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "customdomains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CustomDomainList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1CustomDomain objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1CustomDomain> Items { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecDeletionPolicyEnum>))]
public enum V1beta1CustomDomainSpecDeletionPolicyEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderApiManagementIdRefPolicyResolutionEnum>))]
public enum V1beta1CustomDomainSpecForProviderApiManagementIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderApiManagementIdRefPolicyResolveEnum>))]
public enum V1beta1CustomDomainSpecForProviderApiManagementIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderApiManagementIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CustomDomainSpecForProviderApiManagementIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CustomDomainSpecForProviderApiManagementIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Management in apimanagement to populate apiManagementId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderApiManagementIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecForProviderApiManagementIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderApiManagementIdSelectorPolicyResolutionEnum>))]
public enum V1beta1CustomDomainSpecForProviderApiManagementIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderApiManagementIdSelectorPolicyResolveEnum>))]
public enum V1beta1CustomDomainSpecForProviderApiManagementIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderApiManagementIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CustomDomainSpecForProviderApiManagementIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CustomDomainSpecForProviderApiManagementIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Management in apimanagement to populate apiManagementId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderApiManagementIdSelector
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
    public V1beta1CustomDomainSpecForProviderApiManagementIdSelectorPolicy? Policy { get; set; }
}

/// <summary>The password associated with the certificate provided above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderDeveloperPortalCertificatePasswordSecretRef
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

/// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderDeveloperPortalCertificateSecretRef
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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdRefPolicyResolutionEnum>))]
public enum V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdRefPolicyResolveEnum>))]
public enum V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Certificate in keyvault to populate keyVaultCertificateId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdSelectorPolicyResolutionEnum>))]
public enum V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdSelectorPolicyResolveEnum>))]
public enum V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Certificate in keyvault to populate keyVaultCertificateId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdSelector
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
    public V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderDeveloperPortal
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>The Hostname to use for the corresponding endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>Reference to a Certificate in keyvault to populate keyVaultCertificateId.</summary>
    [JsonPropertyName("keyVaultCertificateIdRef")]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdRef? KeyVaultCertificateIdRef { get; set; }

    /// <summary>Selector for a Certificate in keyvault to populate keyVaultCertificateId.</summary>
    [JsonPropertyName("keyVaultCertificateIdSelector")]
    public V1beta1CustomDomainSpecForProviderDeveloperPortalKeyVaultCertificateIdSelector? KeyVaultCertificateIdSelector { get; set; }

    /// <summary>The ID of the API Management Custom Domain.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the key vault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

/// <summary>The password associated with the certificate provided above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderGatewayCertificatePasswordSecretRef
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

/// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderGatewayCertificateSecretRef
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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdRefPolicyResolutionEnum>))]
public enum V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdRefPolicyResolveEnum>))]
public enum V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Certificate in keyvault to populate keyVaultCertificateId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdSelectorPolicyResolutionEnum>))]
public enum V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdSelectorPolicyResolveEnum>))]
public enum V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Certificate in keyvault to populate keyVaultCertificateId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdSelector
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
    public V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderGateway
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecForProviderGatewayCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecForProviderGatewayCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>Is the certificate associated with this Hostname the Default SSL Certificate? This is used when an SNI header isn&apos;t specified by a client. Defaults to false.</summary>
    [JsonPropertyName("defaultSslBinding")]
    public bool? DefaultSslBinding { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>Reference to a Certificate in keyvault to populate keyVaultCertificateId.</summary>
    [JsonPropertyName("keyVaultCertificateIdRef")]
    public V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdRef? KeyVaultCertificateIdRef { get; set; }

    /// <summary>Selector for a Certificate in keyvault to populate keyVaultCertificateId.</summary>
    [JsonPropertyName("keyVaultCertificateIdSelector")]
    public V1beta1CustomDomainSpecForProviderGatewayKeyVaultCertificateIdSelector? KeyVaultCertificateIdSelector { get; set; }

    /// <summary>The ID of the API Management Custom Domain.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the key vault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

/// <summary>The password associated with the certificate provided above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderManagementCertificatePasswordSecretRef
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

/// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderManagementCertificateSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderManagement
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecForProviderManagementCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecForProviderManagementCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Custom Domain.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the key vault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

/// <summary>The password associated with the certificate provided above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderPortalCertificatePasswordSecretRef
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

/// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderPortalCertificateSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderPortal
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecForProviderPortalCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecForProviderPortalCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Custom Domain.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the key vault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

/// <summary>The password associated with the certificate provided above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderScmCertificatePasswordSecretRef
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

/// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderScmCertificateSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProviderScm
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecForProviderScmCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecForProviderScmCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Custom Domain.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the key vault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecForProvider
{
    /// <summary>The ID of the API Management service for which to configure Custom Domains. Changing this forces a new API Management Custom Domain resource to be created.</summary>
    [JsonPropertyName("apiManagementId")]
    public string? ApiManagementId { get; set; }

    /// <summary>Reference to a Management in apimanagement to populate apiManagementId.</summary>
    [JsonPropertyName("apiManagementIdRef")]
    public V1beta1CustomDomainSpecForProviderApiManagementIdRef? ApiManagementIdRef { get; set; }

    /// <summary>Selector for a Management in apimanagement to populate apiManagementId.</summary>
    [JsonPropertyName("apiManagementIdSelector")]
    public V1beta1CustomDomainSpecForProviderApiManagementIdSelector? ApiManagementIdSelector { get; set; }

    /// <summary>One or more developer_portal blocks as defined below.</summary>
    [JsonPropertyName("developerPortal")]
    public IList<V1beta1CustomDomainSpecForProviderDeveloperPortal>? DeveloperPortal { get; set; }

    /// <summary>One or more gateway blocks as defined below.</summary>
    [JsonPropertyName("gateway")]
    public IList<V1beta1CustomDomainSpecForProviderGateway>? Gateway { get; set; }

    /// <summary>One or more management blocks as defined below.</summary>
    [JsonPropertyName("management")]
    public IList<V1beta1CustomDomainSpecForProviderManagement>? Management { get; set; }

    /// <summary>One or more portal blocks as defined below.</summary>
    [JsonPropertyName("portal")]
    public IList<V1beta1CustomDomainSpecForProviderPortal>? Portal { get; set; }

    /// <summary>One or more scm blocks as defined below.</summary>
    [JsonPropertyName("scm")]
    public IList<V1beta1CustomDomainSpecForProviderScm>? Scm { get; set; }
}

/// <summary>The password associated with the certificate provided above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderDeveloperPortalCertificatePasswordSecretRef
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

/// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderDeveloperPortalCertificateSecretRef
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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdRefPolicyResolutionEnum>))]
public enum V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdRefPolicyResolveEnum>))]
public enum V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Certificate in keyvault to populate keyVaultCertificateId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdSelectorPolicyResolutionEnum>))]
public enum V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdSelectorPolicyResolveEnum>))]
public enum V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Certificate in keyvault to populate keyVaultCertificateId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdSelector
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
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderDeveloperPortal
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>The Hostname to use for the corresponding endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>Reference to a Certificate in keyvault to populate keyVaultCertificateId.</summary>
    [JsonPropertyName("keyVaultCertificateIdRef")]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdRef? KeyVaultCertificateIdRef { get; set; }

    /// <summary>Selector for a Certificate in keyvault to populate keyVaultCertificateId.</summary>
    [JsonPropertyName("keyVaultCertificateIdSelector")]
    public V1beta1CustomDomainSpecInitProviderDeveloperPortalKeyVaultCertificateIdSelector? KeyVaultCertificateIdSelector { get; set; }

    /// <summary>The ID of the API Management Custom Domain.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the key vault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

/// <summary>The password associated with the certificate provided above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderGatewayCertificatePasswordSecretRef
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

/// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderGatewayCertificateSecretRef
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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdRefPolicyResolutionEnum>))]
public enum V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdRefPolicyResolveEnum>))]
public enum V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Certificate in keyvault to populate keyVaultCertificateId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdSelectorPolicyResolutionEnum>))]
public enum V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdSelectorPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdSelectorPolicyResolveEnum>))]
public enum V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Certificate in keyvault to populate keyVaultCertificateId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdSelector
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
    public V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderGateway
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecInitProviderGatewayCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecInitProviderGatewayCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>Is the certificate associated with this Hostname the Default SSL Certificate? This is used when an SNI header isn&apos;t specified by a client. Defaults to false.</summary>
    [JsonPropertyName("defaultSslBinding")]
    public bool? DefaultSslBinding { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>Reference to a Certificate in keyvault to populate keyVaultCertificateId.</summary>
    [JsonPropertyName("keyVaultCertificateIdRef")]
    public V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdRef? KeyVaultCertificateIdRef { get; set; }

    /// <summary>Selector for a Certificate in keyvault to populate keyVaultCertificateId.</summary>
    [JsonPropertyName("keyVaultCertificateIdSelector")]
    public V1beta1CustomDomainSpecInitProviderGatewayKeyVaultCertificateIdSelector? KeyVaultCertificateIdSelector { get; set; }

    /// <summary>The ID of the API Management Custom Domain.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the key vault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

/// <summary>The password associated with the certificate provided above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderManagementCertificatePasswordSecretRef
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

/// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderManagementCertificateSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderManagement
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecInitProviderManagementCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecInitProviderManagementCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Custom Domain.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the key vault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

/// <summary>The password associated with the certificate provided above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderPortalCertificatePasswordSecretRef
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

/// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderPortalCertificateSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderPortal
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecInitProviderPortalCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecInitProviderPortalCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Custom Domain.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the key vault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
}

/// <summary>The password associated with the certificate provided above.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderScmCertificatePasswordSecretRef
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

/// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderScmCertificateSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProviderScm
{
    /// <summary>The password associated with the certificate provided above.</summary>
    [JsonPropertyName("certificatePasswordSecretRef")]
    public V1beta1CustomDomainSpecInitProviderScmCertificatePasswordSecretRef? CertificatePasswordSecretRef { get; set; }

    /// <summary>The Base64 Encoded Certificate. (Mutually exclusive with key_vault_certificate_id.)</summary>
    [JsonPropertyName("certificateSecretRef")]
    public V1beta1CustomDomainSpecInitProviderScmCertificateSecretRef? CertificateSecretRef { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Custom Domain.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the key vault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecInitProvider
{
    /// <summary>One or more developer_portal blocks as defined below.</summary>
    [JsonPropertyName("developerPortal")]
    public IList<V1beta1CustomDomainSpecInitProviderDeveloperPortal>? DeveloperPortal { get; set; }

    /// <summary>One or more gateway blocks as defined below.</summary>
    [JsonPropertyName("gateway")]
    public IList<V1beta1CustomDomainSpecInitProviderGateway>? Gateway { get; set; }

    /// <summary>One or more management blocks as defined below.</summary>
    [JsonPropertyName("management")]
    public IList<V1beta1CustomDomainSpecInitProviderManagement>? Management { get; set; }

    /// <summary>One or more portal blocks as defined below.</summary>
    [JsonPropertyName("portal")]
    public IList<V1beta1CustomDomainSpecInitProviderPortal>? Portal { get; set; }

    /// <summary>One or more scm blocks as defined below.</summary>
    [JsonPropertyName("scm")]
    public IList<V1beta1CustomDomainSpecInitProviderScm>? Scm { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecManagementPoliciesEnum>))]
public enum V1beta1CustomDomainSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta1CustomDomainSpecProviderConfigRefPolicyResolutionEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1CustomDomainSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta1CustomDomainSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1CustomDomainSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1CustomDomainSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1CustomDomainSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>CustomDomainSpec defines the desired state of CustomDomain</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainSpec
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
    public V1beta1CustomDomainSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta1CustomDomainSpecForProvider ForProvider { get; set; }

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
    public V1beta1CustomDomainSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta1CustomDomainSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1CustomDomainSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1CustomDomainSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainStatusAtProviderDeveloperPortal
{
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the corresponding endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Custom Domain.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the key vault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainStatusAtProviderGateway
{
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    /// <summary>Is the certificate associated with this Hostname the Default SSL Certificate? This is used when an SNI header isn&apos;t specified by a client. Defaults to false.</summary>
    [JsonPropertyName("defaultSslBinding")]
    public bool? DefaultSslBinding { get; set; }

    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Custom Domain.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the key vault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainStatusAtProviderManagement
{
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Custom Domain.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the key vault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainStatusAtProviderPortal
{
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Custom Domain.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the key vault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainStatusAtProviderScm
{
    [JsonPropertyName("certificateSource")]
    public string? CertificateSource { get; set; }

    [JsonPropertyName("certificateStatus")]
    public string? CertificateStatus { get; set; }

    [JsonPropertyName("expiry")]
    public string? Expiry { get; set; }

    /// <summary>The Hostname to use for the API Proxy Endpoint.</summary>
    [JsonPropertyName("hostName")]
    public string? HostName { get; set; }

    /// <summary>The ID of the Key Vault Secret containing the SSL Certificate, which must be of the type application/x-pkcs12.</summary>
    [JsonPropertyName("keyVaultCertificateId")]
    public string? KeyVaultCertificateId { get; set; }

    /// <summary>The ID of the API Management Custom Domain.</summary>
    [JsonPropertyName("keyVaultId")]
    public string? KeyVaultId { get; set; }

    /// <summary>Should Client Certificate Negotiation be enabled for this Hostname? Defaults to false.</summary>
    [JsonPropertyName("negotiateClientCertificate")]
    public bool? NegotiateClientCertificate { get; set; }

    /// <summary>System or User Assigned Managed identity clientId as generated by Azure AD, which has GET access to the key vault containing the SSL certificate.</summary>
    [JsonPropertyName("sslKeyvaultIdentityClientId")]
    public string? SslKeyvaultIdentityClientId { get; set; }

    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    [JsonPropertyName("thumbprint")]
    public string? Thumbprint { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainStatusAtProvider
{
    /// <summary>The ID of the API Management service for which to configure Custom Domains. Changing this forces a new API Management Custom Domain resource to be created.</summary>
    [JsonPropertyName("apiManagementId")]
    public string? ApiManagementId { get; set; }

    /// <summary>One or more developer_portal blocks as defined below.</summary>
    [JsonPropertyName("developerPortal")]
    public IList<V1beta1CustomDomainStatusAtProviderDeveloperPortal>? DeveloperPortal { get; set; }

    /// <summary>One or more gateway blocks as defined below.</summary>
    [JsonPropertyName("gateway")]
    public IList<V1beta1CustomDomainStatusAtProviderGateway>? Gateway { get; set; }

    /// <summary>The ID of the API Management Custom Domain.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>One or more management blocks as defined below.</summary>
    [JsonPropertyName("management")]
    public IList<V1beta1CustomDomainStatusAtProviderManagement>? Management { get; set; }

    /// <summary>One or more portal blocks as defined below.</summary>
    [JsonPropertyName("portal")]
    public IList<V1beta1CustomDomainStatusAtProviderPortal>? Portal { get; set; }

    /// <summary>One or more scm blocks as defined below.</summary>
    [JsonPropertyName("scm")]
    public IList<V1beta1CustomDomainStatusAtProviderScm>? Scm { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainStatusConditions
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

/// <summary>CustomDomainStatus defines the observed state of CustomDomain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1CustomDomainStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1CustomDomainStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1CustomDomainStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>CustomDomain is the Schema for the CustomDomains API. Manages an API Management Custom Domain.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1CustomDomain : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1CustomDomainSpec>, IStatus<V1beta1CustomDomainStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "CustomDomain";
    public const string KubeGroup = "apimanagement.azure.upbound.io";
    public const string KubePluralName = "customdomains";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "apimanagement.azure.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "CustomDomain";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>CustomDomainSpec defines the desired state of CustomDomain</summary>
    [JsonPropertyName("spec")]
    public required V1beta1CustomDomainSpec Spec { get; set; }

    /// <summary>CustomDomainStatus defines the observed state of CustomDomain.</summary>
    [JsonPropertyName("status")]
    public V1beta1CustomDomainStatus? Status { get; set; }
}