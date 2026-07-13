#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.identityplatform.gcp.m.upbound.io;
/// <summary>TenantInboundSAMLConfig is the Schema for the TenantInboundSAMLConfigs API. Inbound SAML configuration for a Identity Toolkit tenant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TenantInboundSAMLConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta1TenantInboundSAMLConfig>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TenantInboundSAMLConfigList";
    public const string KubeGroup = "identityplatform.gcp.m.upbound.io";
    public const string KubePluralName = "tenantinboundsamlconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "identityplatform.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TenantInboundSAMLConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1TenantInboundSAMLConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1TenantInboundSAMLConfig> Items { get; set; }
}

/// <summary>
/// (Output)
/// The x509 certificate
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecForProviderIdpConfigIdpCertificatesX509CertificateSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecForProviderIdpConfigIdpCertificates
{
    /// <summary>
    /// (Output)
    /// The x509 certificate
    /// </summary>
    [JsonPropertyName("x509CertificateSecretRef")]
    public V1beta1TenantInboundSAMLConfigSpecForProviderIdpConfigIdpCertificatesX509CertificateSecretRef? X509CertificateSecretRef { get; set; }
}

/// <summary>
/// SAML IdP configuration when the project acts as the relying party
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecForProviderIdpConfig
{
    /// <summary>
    /// The IDP&apos;s certificate data to verify the signature in the SAMLResponse issued by the IDP.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("idpCertificates")]
    public IList<V1beta1TenantInboundSAMLConfigSpecForProviderIdpConfigIdpCertificates>? IdpCertificates { get; set; }

    /// <summary>Unique identifier for all SAML entities</summary>
    [JsonPropertyName("idpEntityId")]
    public string? IdpEntityId { get; set; }

    /// <summary>Indicates if outbounding SAMLRequest should be signed.</summary>
    [JsonPropertyName("signRequest")]
    public bool? SignRequest { get; set; }

    /// <summary>URL to send Authentication request to.</summary>
    [JsonPropertyName("ssoUrl")]
    public string? SsoUrl { get; set; }
}

/// <summary>
/// SAML SP (Service Provider) configuration when the project acts as the relying party to receive
/// and accept an authentication assertion issued by a SAML identity provider.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecForProviderSpConfig
{
    /// <summary>Callback URI where responses from IDP are handled. Must start with https://.</summary>
    [JsonPropertyName("callbackUri")]
    public string? CallbackUri { get; set; }

    /// <summary>Unique identifier for all SAML entities.</summary>
    [JsonPropertyName("spEntityId")]
    public string? SpEntityId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecForProviderTenantRefPolicyResolutionEnum>))]
public enum V1beta1TenantInboundSAMLConfigSpecForProviderTenantRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecForProviderTenantRefPolicyResolveEnum>))]
public enum V1beta1TenantInboundSAMLConfigSpecForProviderTenantRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecForProviderTenantRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TenantInboundSAMLConfigSpecForProviderTenantRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TenantInboundSAMLConfigSpecForProviderTenantRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Tenant in identityplatform to populate tenant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecForProviderTenantRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TenantInboundSAMLConfigSpecForProviderTenantRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelectorPolicyResolutionEnum>))]
public enum V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelectorPolicyResolveEnum>))]
public enum V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Tenant in identityplatform to populate tenant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecForProvider
{
    /// <summary>Human friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>If this config allows users to sign in with the provider.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// SAML IdP configuration when the project acts as the relying party
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("idpConfig")]
    public V1beta1TenantInboundSAMLConfigSpecForProviderIdpConfig? IdpConfig { get; set; }

    /// <summary>
    /// The name of the InboundSamlConfig resource. Must start with &apos;saml.&apos; and can only have alphanumeric characters,
    /// hyphens, underscores or periods. The part after &apos;saml.&apos; must also start with a lowercase letter, end with an
    /// alphanumeric character, and have at least 2 characters.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// SAML SP (Service Provider) configuration when the project acts as the relying party to receive
    /// and accept an authentication assertion issued by a SAML identity provider.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spConfig")]
    public V1beta1TenantInboundSAMLConfigSpecForProviderSpConfig? SpConfig { get; set; }

    /// <summary>The name of the tenant where this inbound SAML config resource exists</summary>
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }

    /// <summary>Reference to a Tenant in identityplatform to populate tenant.</summary>
    [JsonPropertyName("tenantRef")]
    public V1beta1TenantInboundSAMLConfigSpecForProviderTenantRef? TenantRef { get; set; }

    /// <summary>Selector for a Tenant in identityplatform to populate tenant.</summary>
    [JsonPropertyName("tenantSelector")]
    public V1beta1TenantInboundSAMLConfigSpecForProviderTenantSelector? TenantSelector { get; set; }
}

/// <summary>
/// (Output)
/// The x509 certificate
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecInitProviderIdpConfigIdpCertificatesX509CertificateSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecInitProviderIdpConfigIdpCertificates
{
    /// <summary>
    /// (Output)
    /// The x509 certificate
    /// </summary>
    [JsonPropertyName("x509CertificateSecretRef")]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderIdpConfigIdpCertificatesX509CertificateSecretRef? X509CertificateSecretRef { get; set; }
}

/// <summary>
/// SAML IdP configuration when the project acts as the relying party
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecInitProviderIdpConfig
{
    /// <summary>
    /// The IDP&apos;s certificate data to verify the signature in the SAMLResponse issued by the IDP.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("idpCertificates")]
    public IList<V1beta1TenantInboundSAMLConfigSpecInitProviderIdpConfigIdpCertificates>? IdpCertificates { get; set; }

    /// <summary>Unique identifier for all SAML entities</summary>
    [JsonPropertyName("idpEntityId")]
    public string? IdpEntityId { get; set; }

    /// <summary>Indicates if outbounding SAMLRequest should be signed.</summary>
    [JsonPropertyName("signRequest")]
    public bool? SignRequest { get; set; }

    /// <summary>URL to send Authentication request to.</summary>
    [JsonPropertyName("ssoUrl")]
    public string? SsoUrl { get; set; }
}

/// <summary>
/// SAML SP (Service Provider) configuration when the project acts as the relying party to receive
/// and accept an authentication assertion issued by a SAML identity provider.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecInitProviderSpConfig
{
    /// <summary>Callback URI where responses from IDP are handled. Must start with https://.</summary>
    [JsonPropertyName("callbackUri")]
    public string? CallbackUri { get; set; }

    /// <summary>Unique identifier for all SAML entities.</summary>
    [JsonPropertyName("spEntityId")]
    public string? SpEntityId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRefPolicyResolutionEnum>))]
public enum V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRefPolicyResolveEnum>))]
public enum V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Tenant in identityplatform to populate tenant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelectorPolicyResolutionEnum>))]
public enum V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelectorPolicyResolveEnum>))]
public enum V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Tenant in identityplatform to populate tenant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1TenantInboundSAMLConfigSpecInitProvider
{
    /// <summary>Human friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>If this config allows users to sign in with the provider.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// SAML IdP configuration when the project acts as the relying party
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("idpConfig")]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderIdpConfig? IdpConfig { get; set; }

    /// <summary>
    /// The name of the InboundSamlConfig resource. Must start with &apos;saml.&apos; and can only have alphanumeric characters,
    /// hyphens, underscores or periods. The part after &apos;saml.&apos; must also start with a lowercase letter, end with an
    /// alphanumeric character, and have at least 2 characters.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// SAML SP (Service Provider) configuration when the project acts as the relying party to receive
    /// and accept an authentication assertion issued by a SAML identity provider.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spConfig")]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderSpConfig? SpConfig { get; set; }

    /// <summary>The name of the tenant where this inbound SAML config resource exists</summary>
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }

    /// <summary>Reference to a Tenant in identityplatform to populate tenant.</summary>
    [JsonPropertyName("tenantRef")]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderTenantRef? TenantRef { get; set; }

    /// <summary>Selector for a Tenant in identityplatform to populate tenant.</summary>
    [JsonPropertyName("tenantSelector")]
    public V1beta1TenantInboundSAMLConfigSpecInitProviderTenantSelector? TenantSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1TenantInboundSAMLConfigSpecManagementPoliciesEnum>))]
public enum V1beta1TenantInboundSAMLConfigSpecManagementPoliciesEnum
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
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>TenantInboundSAMLConfigSpec defines the desired state of TenantInboundSAMLConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1TenantInboundSAMLConfigSpecForProvider ForProvider { get; set; }

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
    public V1beta1TenantInboundSAMLConfigSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1TenantInboundSAMLConfigSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1TenantInboundSAMLConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1TenantInboundSAMLConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// (Output)
/// The x509 certificate
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigStatusAtProviderIdpConfigIdpCertificatesX509CertificateSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigStatusAtProviderIdpConfigIdpCertificates
{
    /// <summary>
    /// (Output)
    /// The x509 certificate
    /// </summary>
    [JsonPropertyName("x509CertificateSecretRef")]
    public V1beta1TenantInboundSAMLConfigStatusAtProviderIdpConfigIdpCertificatesX509CertificateSecretRef? X509CertificateSecretRef { get; set; }
}

/// <summary>
/// SAML IdP configuration when the project acts as the relying party
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigStatusAtProviderIdpConfig
{
    /// <summary>
    /// The IDP&apos;s certificate data to verify the signature in the SAMLResponse issued by the IDP.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("idpCertificates")]
    public IList<V1beta1TenantInboundSAMLConfigStatusAtProviderIdpConfigIdpCertificates>? IdpCertificates { get; set; }

    /// <summary>Unique identifier for all SAML entities</summary>
    [JsonPropertyName("idpEntityId")]
    public string? IdpEntityId { get; set; }

    /// <summary>Indicates if outbounding SAMLRequest should be signed.</summary>
    [JsonPropertyName("signRequest")]
    public bool? SignRequest { get; set; }

    /// <summary>URL to send Authentication request to.</summary>
    [JsonPropertyName("ssoUrl")]
    public string? SsoUrl { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigStatusAtProviderSpConfigSpCertificates
{
    /// <summary>
    /// (Output)
    /// The x509 certificate
    /// </summary>
    [JsonPropertyName("x509Certificate")]
    public string? X509Certificate { get; set; }
}

/// <summary>
/// SAML SP (Service Provider) configuration when the project acts as the relying party to receive
/// and accept an authentication assertion issued by a SAML identity provider.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigStatusAtProviderSpConfig
{
    /// <summary>Callback URI where responses from IDP are handled. Must start with https://.</summary>
    [JsonPropertyName("callbackUri")]
    public string? CallbackUri { get; set; }

    /// <summary>
    /// (Output)
    /// The IDP&apos;s certificate data to verify the signature in the SAMLResponse issued by the IDP.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spCertificates")]
    public IList<V1beta1TenantInboundSAMLConfigStatusAtProviderSpConfigSpCertificates>? SpCertificates { get; set; }

    /// <summary>Unique identifier for all SAML entities.</summary>
    [JsonPropertyName("spEntityId")]
    public string? SpEntityId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigStatusAtProvider
{
    /// <summary>Human friendly display name.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>If this config allows users to sign in with the provider.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/tenants/{{tenant}}/inboundSamlConfigs/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// SAML IdP configuration when the project acts as the relying party
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("idpConfig")]
    public V1beta1TenantInboundSAMLConfigStatusAtProviderIdpConfig? IdpConfig { get; set; }

    /// <summary>
    /// The name of the InboundSamlConfig resource. Must start with &apos;saml.&apos; and can only have alphanumeric characters,
    /// hyphens, underscores or periods. The part after &apos;saml.&apos; must also start with a lowercase letter, end with an
    /// alphanumeric character, and have at least 2 characters.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// SAML SP (Service Provider) configuration when the project acts as the relying party to receive
    /// and accept an authentication assertion issued by a SAML identity provider.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("spConfig")]
    public V1beta1TenantInboundSAMLConfigStatusAtProviderSpConfig? SpConfig { get; set; }

    /// <summary>The name of the tenant where this inbound SAML config resource exists</summary>
    [JsonPropertyName("tenant")]
    public string? Tenant { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigStatusConditions
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

/// <summary>TenantInboundSAMLConfigStatus defines the observed state of TenantInboundSAMLConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1TenantInboundSAMLConfigStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1TenantInboundSAMLConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1TenantInboundSAMLConfigStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>TenantInboundSAMLConfig is the Schema for the TenantInboundSAMLConfigs API. Inbound SAML configuration for a Identity Toolkit tenant.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1TenantInboundSAMLConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1TenantInboundSAMLConfigSpec>, IStatus<V1beta1TenantInboundSAMLConfigStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "TenantInboundSAMLConfig";
    public const string KubeGroup = "identityplatform.gcp.m.upbound.io";
    public const string KubePluralName = "tenantinboundsamlconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "identityplatform.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TenantInboundSAMLConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>TenantInboundSAMLConfigSpec defines the desired state of TenantInboundSAMLConfig</summary>
    [JsonPropertyName("spec")]
    public required V1beta1TenantInboundSAMLConfigSpec Spec { get; set; }

    /// <summary>TenantInboundSAMLConfigStatus defines the observed state of TenantInboundSAMLConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta1TenantInboundSAMLConfigStatus? Status { get; set; }
}