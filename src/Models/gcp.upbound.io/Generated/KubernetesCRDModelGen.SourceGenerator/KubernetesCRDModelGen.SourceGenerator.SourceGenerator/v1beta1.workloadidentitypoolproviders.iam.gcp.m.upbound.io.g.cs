#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.iam.gcp.m.upbound.io;
/// <summary>WorkloadIdentityPoolProvider is the Schema for the WorkloadIdentityPoolProviders API. A configuration for an external identity provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WorkloadIdentityPoolProviderList : IKubernetesObject<V1ListMeta>, IItems<V1beta1WorkloadIdentityPoolProvider>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WorkloadIdentityPoolProviderList";
    public const string KubeGroup = "iam.gcp.m.upbound.io";
    public const string KubePluralName = "workloadidentitypoolproviders";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkloadIdentityPoolProviderList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1WorkloadIdentityPoolProvider objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1WorkloadIdentityPoolProvider> Items { get; set; }
}

/// <summary>
/// An Amazon Web Services identity provider. Not compatible with the property oidc or saml.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecForProviderAws
{
    /// <summary>The AWS account ID.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }
}

/// <summary>
/// An OpenId Connect 1.0 identity provider. Not compatible with the property aws or saml.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecForProviderOidc
{
    /// <summary>
    /// Acceptable values for the aud field (audience) in the OIDC token. Token exchange
    /// requests are rejected if the token audience does not match one of the configured
    /// values. Each audience may be at most 256 characters. A maximum of 10 audiences may
    /// be configured.
    /// If this list is empty, the OIDC token audience must be equal to the full canonical
    /// resource name of the WorkloadIdentityPoolProvider, with or without the HTTPS prefix.
    /// For example:
    /// </summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OIDC issuer URL.</summary>
    [JsonPropertyName("issuerUri")]
    public string? IssuerUri { get; set; }

    /// <summary>
    /// OIDC JWKs in JSON String format. For details on definition of a
    /// JWK, see https:tools.ietf.org/html/rfc7517. If not set, then we
    /// use the jwks_uri from the discovery document fetched from the
    /// .well-known path for the issuer_uri. Currently, RSA and EC asymmetric
    /// keys are supported. The JWK must use following format and include only
    /// the following fields:
    /// </summary>
    [JsonPropertyName("jwksJson")]
    public string? JwksJson { get; set; }
}

/// <summary>
/// An SAML 2.0 identity provider. Not compatible with the property oidc or aws.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecForProviderSaml
{
    /// <summary>SAML Identity provider configuration metadata xml doc.</summary>
    [JsonPropertyName("idpMetadataXml")]
    public string? IdpMetadataXml { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdRefPolicyResolutionEnum>))]
public enum V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdRefPolicyResolveEnum>))]
public enum V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a WorkloadIdentityPool in iam to populate workloadIdentityPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdSelectorPolicyResolutionEnum>))]
public enum V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdSelectorPolicyResolveEnum>))]
public enum V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a WorkloadIdentityPool in iam to populate workloadIdentityPoolId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdSelector
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
    public V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecForProviderX509TrustStoreIntermediateCas
{
    /// <summary>
    /// PEM certificate of the PKI used for validation. Must only contain one
    /// ca certificate(either root or intermediate cert).
    /// </summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecForProviderX509TrustStoreTrustAnchors
{
    /// <summary>
    /// PEM certificate of the PKI used for validation. Must only contain one
    /// ca certificate(either root or intermediate cert).
    /// </summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }
}

/// <summary>
/// A Trust store, use this trust store as a wrapper to config the trust
/// anchor and optional intermediate cas to help build the trust chain for
/// the incoming end entity certificate. Follow the x509 guidelines to
/// define those PEM encoded certs. Only 1 trust store is currently
/// supported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecForProviderX509TrustStore
{
    /// <summary>
    /// Set of intermediate CA certificates used for building the trust chain to
    /// trust anchor.
    /// IMPORTANT: Intermediate CAs are only supported when configuring x509 federation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("intermediateCas")]
    public IList<V1beta1WorkloadIdentityPoolProviderSpecForProviderX509TrustStoreIntermediateCas>? IntermediateCas { get; set; }

    /// <summary>
    /// List of Trust Anchors to be used while performing validation
    /// against a given TrustStore. The incoming end entity&apos;s certificate
    /// must be chained up to one of the trust anchors here.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trustAnchors")]
    public IList<V1beta1WorkloadIdentityPoolProviderSpecForProviderX509TrustStoreTrustAnchors>? TrustAnchors { get; set; }
}

/// <summary>
/// An X.509-type identity provider represents a CA. It is trusted to assert a
/// client identity if the client has a certificate that chains up to this CA.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecForProviderX509
{
    /// <summary>
    /// A Trust store, use this trust store as a wrapper to config the trust
    /// anchor and optional intermediate cas to help build the trust chain for
    /// the incoming end entity certificate. Follow the x509 guidelines to
    /// define those PEM encoded certs. Only 1 trust store is currently
    /// supported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trustStore")]
    public V1beta1WorkloadIdentityPoolProviderSpecForProviderX509TrustStore? TrustStore { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecForProvider
{
    /// <summary>
    /// A Common Expression Language expression, in
    /// plain text, to restrict what otherwise valid authentication credentials issued by the
    /// provider should not be accepted.
    /// The expression must output a boolean representing whether to allow the federation.
    /// The following keywords may be referenced in the expressions:
    /// </summary>
    [JsonPropertyName("attributeCondition")]
    public string? AttributeCondition { get; set; }

    /// <summary>
    /// Maps attributes from authentication credentials issued by an external identity provider
    /// to Google Cloud attributes, such as subject and segment.
    /// Each key must be a string specifying the Google Cloud IAM attribute to map to.
    /// The following keys are supported:
    /// </summary>
    [JsonPropertyName("attributeMapping")]
    public IDictionary<string, string>? AttributeMapping { get; set; }

    /// <summary>
    /// An Amazon Web Services identity provider. Not compatible with the property oidc or saml.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aws")]
    public V1beta1WorkloadIdentityPoolProviderSpecForProviderAws? Aws { get; set; }

    /// <summary>A description for the provider. Cannot exceed 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Whether the provider is disabled. You cannot use a disabled provider to exchange tokens.
    /// However, existing tokens still grant access.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>A display name for the provider. Cannot exceed 32 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// An OpenId Connect 1.0 identity provider. Not compatible with the property aws or saml.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oidc")]
    public V1beta1WorkloadIdentityPoolProviderSpecForProviderOidc? Oidc { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// An SAML 2.0 identity provider. Not compatible with the property oidc or aws.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("saml")]
    public V1beta1WorkloadIdentityPoolProviderSpecForProviderSaml? Saml { get; set; }

    /// <summary>
    /// The ID used for the pool, which is the final component of the pool resource name. This
    /// value should be 4-32 characters, and may contain the characters [a-z0-9-]. The prefix
    /// gcp- is reserved for use by Google, and may not be specified.
    /// </summary>
    [JsonPropertyName("workloadIdentityPoolId")]
    public string? WorkloadIdentityPoolId { get; set; }

    /// <summary>Reference to a WorkloadIdentityPool in iam to populate workloadIdentityPoolId.</summary>
    [JsonPropertyName("workloadIdentityPoolIdRef")]
    public V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdRef? WorkloadIdentityPoolIdRef { get; set; }

    /// <summary>Selector for a WorkloadIdentityPool in iam to populate workloadIdentityPoolId.</summary>
    [JsonPropertyName("workloadIdentityPoolIdSelector")]
    public V1beta1WorkloadIdentityPoolProviderSpecForProviderWorkloadIdentityPoolIdSelector? WorkloadIdentityPoolIdSelector { get; set; }

    /// <summary>
    /// An X.509-type identity provider represents a CA. It is trusted to assert a
    /// client identity if the client has a certificate that chains up to this CA.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("x509")]
    public V1beta1WorkloadIdentityPoolProviderSpecForProviderX509? X509 { get; set; }
}

/// <summary>
/// An Amazon Web Services identity provider. Not compatible with the property oidc or saml.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecInitProviderAws
{
    /// <summary>The AWS account ID.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }
}

/// <summary>
/// An OpenId Connect 1.0 identity provider. Not compatible with the property aws or saml.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecInitProviderOidc
{
    /// <summary>
    /// Acceptable values for the aud field (audience) in the OIDC token. Token exchange
    /// requests are rejected if the token audience does not match one of the configured
    /// values. Each audience may be at most 256 characters. A maximum of 10 audiences may
    /// be configured.
    /// If this list is empty, the OIDC token audience must be equal to the full canonical
    /// resource name of the WorkloadIdentityPoolProvider, with or without the HTTPS prefix.
    /// For example:
    /// </summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OIDC issuer URL.</summary>
    [JsonPropertyName("issuerUri")]
    public string? IssuerUri { get; set; }

    /// <summary>
    /// OIDC JWKs in JSON String format. For details on definition of a
    /// JWK, see https:tools.ietf.org/html/rfc7517. If not set, then we
    /// use the jwks_uri from the discovery document fetched from the
    /// .well-known path for the issuer_uri. Currently, RSA and EC asymmetric
    /// keys are supported. The JWK must use following format and include only
    /// the following fields:
    /// </summary>
    [JsonPropertyName("jwksJson")]
    public string? JwksJson { get; set; }
}

/// <summary>
/// An SAML 2.0 identity provider. Not compatible with the property oidc or aws.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecInitProviderSaml
{
    /// <summary>SAML Identity provider configuration metadata xml doc.</summary>
    [JsonPropertyName("idpMetadataXml")]
    public string? IdpMetadataXml { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecInitProviderX509TrustStoreIntermediateCas
{
    /// <summary>
    /// PEM certificate of the PKI used for validation. Must only contain one
    /// ca certificate(either root or intermediate cert).
    /// </summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecInitProviderX509TrustStoreTrustAnchors
{
    /// <summary>
    /// PEM certificate of the PKI used for validation. Must only contain one
    /// ca certificate(either root or intermediate cert).
    /// </summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }
}

/// <summary>
/// A Trust store, use this trust store as a wrapper to config the trust
/// anchor and optional intermediate cas to help build the trust chain for
/// the incoming end entity certificate. Follow the x509 guidelines to
/// define those PEM encoded certs. Only 1 trust store is currently
/// supported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecInitProviderX509TrustStore
{
    /// <summary>
    /// Set of intermediate CA certificates used for building the trust chain to
    /// trust anchor.
    /// IMPORTANT: Intermediate CAs are only supported when configuring x509 federation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("intermediateCas")]
    public IList<V1beta1WorkloadIdentityPoolProviderSpecInitProviderX509TrustStoreIntermediateCas>? IntermediateCas { get; set; }

    /// <summary>
    /// List of Trust Anchors to be used while performing validation
    /// against a given TrustStore. The incoming end entity&apos;s certificate
    /// must be chained up to one of the trust anchors here.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trustAnchors")]
    public IList<V1beta1WorkloadIdentityPoolProviderSpecInitProviderX509TrustStoreTrustAnchors>? TrustAnchors { get; set; }
}

/// <summary>
/// An X.509-type identity provider represents a CA. It is trusted to assert a
/// client identity if the client has a certificate that chains up to this CA.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpecInitProviderX509
{
    /// <summary>
    /// A Trust store, use this trust store as a wrapper to config the trust
    /// anchor and optional intermediate cas to help build the trust chain for
    /// the incoming end entity certificate. Follow the x509 guidelines to
    /// define those PEM encoded certs. Only 1 trust store is currently
    /// supported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trustStore")]
    public V1beta1WorkloadIdentityPoolProviderSpecInitProviderX509TrustStore? TrustStore { get; set; }
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
public partial class V1beta1WorkloadIdentityPoolProviderSpecInitProvider
{
    /// <summary>
    /// A Common Expression Language expression, in
    /// plain text, to restrict what otherwise valid authentication credentials issued by the
    /// provider should not be accepted.
    /// The expression must output a boolean representing whether to allow the federation.
    /// The following keywords may be referenced in the expressions:
    /// </summary>
    [JsonPropertyName("attributeCondition")]
    public string? AttributeCondition { get; set; }

    /// <summary>
    /// Maps attributes from authentication credentials issued by an external identity provider
    /// to Google Cloud attributes, such as subject and segment.
    /// Each key must be a string specifying the Google Cloud IAM attribute to map to.
    /// The following keys are supported:
    /// </summary>
    [JsonPropertyName("attributeMapping")]
    public IDictionary<string, string>? AttributeMapping { get; set; }

    /// <summary>
    /// An Amazon Web Services identity provider. Not compatible with the property oidc or saml.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aws")]
    public V1beta1WorkloadIdentityPoolProviderSpecInitProviderAws? Aws { get; set; }

    /// <summary>A description for the provider. Cannot exceed 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Whether the provider is disabled. You cannot use a disabled provider to exchange tokens.
    /// However, existing tokens still grant access.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>A display name for the provider. Cannot exceed 32 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// An OpenId Connect 1.0 identity provider. Not compatible with the property aws or saml.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oidc")]
    public V1beta1WorkloadIdentityPoolProviderSpecInitProviderOidc? Oidc { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// An SAML 2.0 identity provider. Not compatible with the property oidc or aws.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("saml")]
    public V1beta1WorkloadIdentityPoolProviderSpecInitProviderSaml? Saml { get; set; }

    /// <summary>
    /// An X.509-type identity provider represents a CA. It is trusted to assert a
    /// client identity if the client has a certificate that chains up to this CA.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("x509")]
    public V1beta1WorkloadIdentityPoolProviderSpecInitProviderX509? X509 { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1WorkloadIdentityPoolProviderSpecManagementPoliciesEnum>))]
public enum V1beta1WorkloadIdentityPoolProviderSpecManagementPoliciesEnum
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
public partial class V1beta1WorkloadIdentityPoolProviderSpecProviderConfigRef
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
public partial class V1beta1WorkloadIdentityPoolProviderSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>WorkloadIdentityPoolProviderSpec defines the desired state of WorkloadIdentityPoolProvider</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1WorkloadIdentityPoolProviderSpecForProvider ForProvider { get; set; }

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
    public V1beta1WorkloadIdentityPoolProviderSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1WorkloadIdentityPoolProviderSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1WorkloadIdentityPoolProviderSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1WorkloadIdentityPoolProviderSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// An Amazon Web Services identity provider. Not compatible with the property oidc or saml.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderStatusAtProviderAws
{
    /// <summary>The AWS account ID.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }
}

/// <summary>
/// An OpenId Connect 1.0 identity provider. Not compatible with the property aws or saml.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderStatusAtProviderOidc
{
    /// <summary>
    /// Acceptable values for the aud field (audience) in the OIDC token. Token exchange
    /// requests are rejected if the token audience does not match one of the configured
    /// values. Each audience may be at most 256 characters. A maximum of 10 audiences may
    /// be configured.
    /// If this list is empty, the OIDC token audience must be equal to the full canonical
    /// resource name of the WorkloadIdentityPoolProvider, with or without the HTTPS prefix.
    /// For example:
    /// </summary>
    [JsonPropertyName("allowedAudiences")]
    public IList<string>? AllowedAudiences { get; set; }

    /// <summary>The OIDC issuer URL.</summary>
    [JsonPropertyName("issuerUri")]
    public string? IssuerUri { get; set; }

    /// <summary>
    /// OIDC JWKs in JSON String format. For details on definition of a
    /// JWK, see https:tools.ietf.org/html/rfc7517. If not set, then we
    /// use the jwks_uri from the discovery document fetched from the
    /// .well-known path for the issuer_uri. Currently, RSA and EC asymmetric
    /// keys are supported. The JWK must use following format and include only
    /// the following fields:
    /// </summary>
    [JsonPropertyName("jwksJson")]
    public string? JwksJson { get; set; }
}

/// <summary>
/// An SAML 2.0 identity provider. Not compatible with the property oidc or aws.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderStatusAtProviderSaml
{
    /// <summary>SAML Identity provider configuration metadata xml doc.</summary>
    [JsonPropertyName("idpMetadataXml")]
    public string? IdpMetadataXml { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderStatusAtProviderX509TrustStoreIntermediateCas
{
    /// <summary>
    /// PEM certificate of the PKI used for validation. Must only contain one
    /// ca certificate(either root or intermediate cert).
    /// </summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderStatusAtProviderX509TrustStoreTrustAnchors
{
    /// <summary>
    /// PEM certificate of the PKI used for validation. Must only contain one
    /// ca certificate(either root or intermediate cert).
    /// </summary>
    [JsonPropertyName("pemCertificate")]
    public string? PemCertificate { get; set; }
}

/// <summary>
/// A Trust store, use this trust store as a wrapper to config the trust
/// anchor and optional intermediate cas to help build the trust chain for
/// the incoming end entity certificate. Follow the x509 guidelines to
/// define those PEM encoded certs. Only 1 trust store is currently
/// supported.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderStatusAtProviderX509TrustStore
{
    /// <summary>
    /// Set of intermediate CA certificates used for building the trust chain to
    /// trust anchor.
    /// IMPORTANT: Intermediate CAs are only supported when configuring x509 federation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("intermediateCas")]
    public IList<V1beta1WorkloadIdentityPoolProviderStatusAtProviderX509TrustStoreIntermediateCas>? IntermediateCas { get; set; }

    /// <summary>
    /// List of Trust Anchors to be used while performing validation
    /// against a given TrustStore. The incoming end entity&apos;s certificate
    /// must be chained up to one of the trust anchors here.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trustAnchors")]
    public IList<V1beta1WorkloadIdentityPoolProviderStatusAtProviderX509TrustStoreTrustAnchors>? TrustAnchors { get; set; }
}

/// <summary>
/// An X.509-type identity provider represents a CA. It is trusted to assert a
/// client identity if the client has a certificate that chains up to this CA.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderStatusAtProviderX509
{
    /// <summary>
    /// A Trust store, use this trust store as a wrapper to config the trust
    /// anchor and optional intermediate cas to help build the trust chain for
    /// the incoming end entity certificate. Follow the x509 guidelines to
    /// define those PEM encoded certs. Only 1 trust store is currently
    /// supported.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trustStore")]
    public V1beta1WorkloadIdentityPoolProviderStatusAtProviderX509TrustStore? TrustStore { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderStatusAtProvider
{
    /// <summary>
    /// A Common Expression Language expression, in
    /// plain text, to restrict what otherwise valid authentication credentials issued by the
    /// provider should not be accepted.
    /// The expression must output a boolean representing whether to allow the federation.
    /// The following keywords may be referenced in the expressions:
    /// </summary>
    [JsonPropertyName("attributeCondition")]
    public string? AttributeCondition { get; set; }

    /// <summary>
    /// Maps attributes from authentication credentials issued by an external identity provider
    /// to Google Cloud attributes, such as subject and segment.
    /// Each key must be a string specifying the Google Cloud IAM attribute to map to.
    /// The following keys are supported:
    /// </summary>
    [JsonPropertyName("attributeMapping")]
    public IDictionary<string, string>? AttributeMapping { get; set; }

    /// <summary>
    /// An Amazon Web Services identity provider. Not compatible with the property oidc or saml.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aws")]
    public V1beta1WorkloadIdentityPoolProviderStatusAtProviderAws? Aws { get; set; }

    /// <summary>A description for the provider. Cannot exceed 256 characters.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Whether the provider is disabled. You cannot use a disabled provider to exchange tokens.
    /// However, existing tokens still grant access.
    /// </summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>A display name for the provider. Cannot exceed 32 characters.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/locations/global/workloadIdentityPools/{{workload_identity_pool_id}}/providers/{{workload_identity_pool_provider_id}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The resource name of the provider as
    /// projects/{project_number}/locations/global/workloadIdentityPools/{workload_identity_pool_id}/providers/{workload_identity_pool_provider_id}.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// An OpenId Connect 1.0 identity provider. Not compatible with the property aws or saml.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("oidc")]
    public V1beta1WorkloadIdentityPoolProviderStatusAtProviderOidc? Oidc { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// An SAML 2.0 identity provider. Not compatible with the property oidc or aws.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("saml")]
    public V1beta1WorkloadIdentityPoolProviderStatusAtProviderSaml? Saml { get; set; }

    /// <summary>The state of the provider.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>
    /// The ID used for the pool, which is the final component of the pool resource name. This
    /// value should be 4-32 characters, and may contain the characters [a-z0-9-]. The prefix
    /// gcp- is reserved for use by Google, and may not be specified.
    /// </summary>
    [JsonPropertyName("workloadIdentityPoolId")]
    public string? WorkloadIdentityPoolId { get; set; }

    /// <summary>
    /// An X.509-type identity provider represents a CA. It is trusted to assert a
    /// client identity if the client has a certificate that chains up to this CA.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("x509")]
    public V1beta1WorkloadIdentityPoolProviderStatusAtProviderX509? X509 { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderStatusConditions
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

/// <summary>WorkloadIdentityPoolProviderStatus defines the observed state of WorkloadIdentityPoolProvider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1WorkloadIdentityPoolProviderStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1WorkloadIdentityPoolProviderStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1WorkloadIdentityPoolProviderStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>WorkloadIdentityPoolProvider is the Schema for the WorkloadIdentityPoolProviders API. A configuration for an external identity provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1WorkloadIdentityPoolProvider : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1WorkloadIdentityPoolProviderSpec>, IStatus<V1beta1WorkloadIdentityPoolProviderStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "WorkloadIdentityPoolProvider";
    public const string KubeGroup = "iam.gcp.m.upbound.io";
    public const string KubePluralName = "workloadidentitypoolproviders";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "iam.gcp.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkloadIdentityPoolProvider";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>WorkloadIdentityPoolProviderSpec defines the desired state of WorkloadIdentityPoolProvider</summary>
    [JsonPropertyName("spec")]
    public required V1beta1WorkloadIdentityPoolProviderSpec Spec { get; set; }

    /// <summary>WorkloadIdentityPoolProviderStatus defines the observed state of WorkloadIdentityPoolProvider.</summary>
    [JsonPropertyName("status")]
    public V1beta1WorkloadIdentityPoolProviderStatus? Status { get; set; }
}