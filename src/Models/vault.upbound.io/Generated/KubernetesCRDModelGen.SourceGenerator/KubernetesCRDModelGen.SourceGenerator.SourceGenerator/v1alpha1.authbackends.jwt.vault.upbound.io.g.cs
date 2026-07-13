#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.jwt.vault.upbound.io;
/// <summary>AuthBackend is the Schema for the AuthBackends API. Managing JWT/OIDC auth backends in Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AuthBackendList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1AuthBackend>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AuthBackendList";
    public const string KubeGroup = "jwt.vault.upbound.io";
    public const string KubePluralName = "authbackends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "jwt.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AuthBackendList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1AuthBackend objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1AuthBackend> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendSpecDeletionPolicyEnum>))]
public enum V1alpha1AuthBackendSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Client Secret used for OIDC backends. Note: This field is stored in state. For enhanced security, use oidc_client_secret_wo instead.
/// Client Secret used for OIDC
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecForProviderOidcClientSecretSecretRef
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
/// Write-only Client Secret used for OIDC backends. Mutually exclusive with oidc_client_secret. Must be used with oidc_client_secret_wo_version. To rotate the secret, update the value and increment oidc_client_secret_wo_version.
/// Write-only Client Secret used for OIDC. This field is recommended over oidc_client_secret for enhanced security.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecForProviderOidcClientSecretWoSecretRef
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
public partial class V1alpha1AuthBackendSpecForProviderTune
{
    /// <summary>
    /// List of headers to whitelist and allowing
    /// a plugin to include them in the response.
    /// </summary>
    [JsonPropertyName("allowedResponseHeaders")]
    public IList<string>? AllowedResponseHeaders { get; set; }

    /// <summary>
    /// Specifies the list of keys that will
    /// not be HMAC&apos;d by audit devices in the request data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacRequestKeys")]
    public IList<string>? AuditNonHmacRequestKeys { get; set; }

    /// <summary>
    /// Specifies the list of keys that will
    /// not be HMAC&apos;d by audit devices in the response data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacResponseKeys")]
    public IList<string>? AuditNonHmacResponseKeys { get; set; }

    /// <summary>
    /// Specifies the default time-to-live.
    /// If set, this overrides the global default.
    /// Must be a valid duration string
    /// </summary>
    [JsonPropertyName("defaultLeaseTtl")]
    public string? DefaultLeaseTtl { get; set; }

    /// <summary>
    /// Specifies whether to show this mount in
    /// the UI-specific listing endpoint. Valid values are &quot;unauth&quot; or &quot;hidden&quot;.
    /// </summary>
    [JsonPropertyName("listingVisibility")]
    public string? ListingVisibility { get; set; }

    /// <summary>
    /// Specifies the maximum time-to-live.
    /// If set, this overrides the global default.
    /// Must be a valid duration string
    /// </summary>
    [JsonPropertyName("maxLeaseTtl")]
    public string? MaxLeaseTtl { get; set; }

    /// <summary>
    /// List of headers to whitelist and
    /// pass from the request to the backend.
    /// </summary>
    [JsonPropertyName("passthroughRequestHeaders")]
    public IList<string>? PassthroughRequestHeaders { get; set; }

    /// <summary>
    /// Specifies the type of tokens that should be returned by
    /// the mount. Valid values are &quot;default-service&quot;, &quot;default-batch&quot;, &quot;service&quot;, &quot;batch&quot;.
    /// </summary>
    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecForProvider
{
    /// <summary>
    /// The value against which to match the iss claim in a JWT
    /// The value against which to match the iss claim in a JWT
    /// </summary>
    [JsonPropertyName("boundIssuer")]
    public string? BoundIssuer { get; set; }

    /// <summary>
    /// The default role to use if none is provided during login
    /// The default role to use if none is provided during login
    /// </summary>
    [JsonPropertyName("defaultRole")]
    public string? DefaultRole { get; set; }

    /// <summary>
    /// The description of the auth backend
    /// The description of the auth backend
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// If set, opts out of mount migration on path updates.
    /// See here for more info on Mount Migration
    /// If set, opts out of mount migration on path updates.
    /// </summary>
    [JsonPropertyName("disableRemount")]
    public bool? DisableRemount { get; set; }

    /// <summary>
    /// The CA certificate or chain of certificates, in PEM format, to use to validate connections to the JWKS URL. If not set, system certificates are used.
    /// The CA certificate or chain of certificates, in PEM format, to use to validate connections to the JWKS URL. If not set, system certificates are used.
    /// </summary>
    [JsonPropertyName("jwksCaPem")]
    public string? JwksCaPem { get; set; }

    /// <summary>
    /// List of JWKS URL and optional CA certificate pairs. Cannot be used with jwks_url or jwks_ca_pem. Requires Vault 1.16+.
    /// List of JWKS URL and optional CA certificate pairs. Cannot be used with &apos;jwks_url&apos; or &apos;jwks_ca_pem&apos;. Requires Vault 1.16+.
    /// </summary>
    [JsonPropertyName("jwksPairs")]
    public IList<IDictionary<string, string>>? JwksPairs { get; set; }

    /// <summary>
    /// JWKS URL to use to authenticate signatures. Cannot be used with &quot;oidc_discovery_url&quot; or &quot;jwt_validation_pubkeys&quot;.
    /// JWKS URL to use to authenticate signatures. Cannot be used with &apos;oidc_discovery_url&apos; or &apos;jwt_validation_pubkeys&apos;.
    /// </summary>
    [JsonPropertyName("jwksUrl")]
    public string? JwksUrl { get; set; }

    /// <summary>
    /// A list of supported signing algorithms. Vault 1.1.0 defaults to [RS256] but future or past versions of Vault may differ
    /// A list of supported signing algorithms. Defaults to [RS256]
    /// </summary>
    [JsonPropertyName("jwtSupportedAlgs")]
    public IList<string>? JwtSupportedAlgs { get; set; }

    /// <summary>
    /// A list of PEM-encoded public keys to use to authenticate signatures locally. Cannot be used in combination with oidc_discovery_url
    /// A list of PEM-encoded public keys to use to authenticate signatures locally. Cannot be used with &apos;jwks_url&apos; or &apos;oidc_discovery_url&apos;.
    /// </summary>
    [JsonPropertyName("jwtValidationPubkeys")]
    public IList<string>? JwtValidationPubkeys { get; set; }

    /// <summary>
    /// Specifies if the auth method is local only.
    /// Specifies if the auth method is local only
    /// </summary>
    [JsonPropertyName("local")]
    public bool? Local { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Pass namespace in the OIDC state parameter instead of as a separate query parameter. With this setting, the allowed redirect URL(s) in Vault and on the provider side should not contain a namespace query parameter. This means only one redirect URL entry needs to be maintained on the OIDC provider side for all vault namespaces that will be authenticating against it. Defaults to true for new configs
    /// Pass namespace in the OIDC state parameter instead of as a separate query parameter. With this setting, the allowed redirect URL(s) in Vault and on the provider side should not contain a namespace query parameter. This means only one redirect URL entry needs to be maintained on the OIDC provider side for all vault namespaces that will be authenticating against it. Defaults to true for new configs.
    /// </summary>
    [JsonPropertyName("namespaceInState")]
    public bool? NamespaceInState { get; set; }

    /// <summary>
    /// Client ID used for OIDC backends
    /// Client ID used for OIDC
    /// </summary>
    [JsonPropertyName("oidcClientId")]
    public string? OidcClientId { get; set; }

    /// <summary>
    /// Client Secret used for OIDC backends. Note: This field is stored in state. For enhanced security, use oidc_client_secret_wo instead.
    /// Client Secret used for OIDC
    /// </summary>
    [JsonPropertyName("oidcClientSecretSecretRef")]
    public V1alpha1AuthBackendSpecForProviderOidcClientSecretSecretRef? OidcClientSecretSecretRef { get; set; }

    /// <summary>
    /// Write-only Client Secret used for OIDC backends. Mutually exclusive with oidc_client_secret. Must be used with oidc_client_secret_wo_version. To rotate the secret, update the value and increment oidc_client_secret_wo_version.
    /// Write-only Client Secret used for OIDC. This field is recommended over oidc_client_secret for enhanced security.
    /// </summary>
    [JsonPropertyName("oidcClientSecretWoSecretRef")]
    public V1alpha1AuthBackendSpecForProviderOidcClientSecretWoSecretRef? OidcClientSecretWoSecretRef { get; set; }

    /// <summary>
    /// Version counter for the write-only oidc_client_secret_wo field. Increment this value to trigger an update of the client secret in Vault. Required when using oidc_client_secret_wo.
    /// Version counter for write-only oidc_client_secret field. Increment this value to force update of the secret.
    /// </summary>
    [JsonPropertyName("oidcClientSecretWoVersion")]
    public double? OidcClientSecretWoVersion { get; set; }

    /// <summary>
    /// The CA certificate or chain of certificates, in PEM format, to use to validate connections to the OIDC Discovery URL. If not set, system certificates are used
    /// The CA certificate or chain of certificates, in PEM format, to use to validate connections to the OIDC Discovery URL. If not set, system certificates are used
    /// </summary>
    [JsonPropertyName("oidcDiscoveryCaPem")]
    public string? OidcDiscoveryCaPem { get; set; }

    /// <summary>
    /// The OIDC Discovery URL, without any .well-known component (base path). Cannot be used in combination with jwt_validation_pubkeys
    /// The OIDC Discovery URL, without any .well-known component (base path). Cannot be used with &apos;jwks_url&apos; or &apos;jwt_validation_pubkeys&apos;.
    /// </summary>
    [JsonPropertyName("oidcDiscoveryUrl")]
    public string? OidcDiscoveryUrl { get; set; }

    /// <summary>
    /// The response mode to be used in the OAuth2 request. Allowed values are query and form_post. Defaults to query. If using Vault namespaces, and oidc_response_mode is form_post, then namespace_in_state should be set to false.
    /// The response mode to be used in the OAuth2 request. Allowed values are &apos;query&apos; and &apos;form_post&apos;. Defaults to &apos;query&apos;. If using Vault namespaces, and oidc_response_mode is &apos;form_post&apos;, then &apos;namespace_in_state&apos; should be set to false.
    /// </summary>
    [JsonPropertyName("oidcResponseMode")]
    public string? OidcResponseMode { get; set; }

    /// <summary>
    /// List of response types to request. Allowed values are &apos;code&apos; and &apos;id_token&apos;. Defaults to [&quot;code&quot;]. Note: id_token may only be used if oidc_response_mode is set to form_post.
    /// The response types to request. Allowed values are &apos;code&apos; and &apos;id_token&apos;. Defaults to &apos;code&apos;. Note: &apos;id_token&apos; may only be used if &apos;oidc_response_mode&apos; is set to &apos;form_post&apos;.
    /// </summary>
    [JsonPropertyName("oidcResponseTypes")]
    public IList<string>? OidcResponseTypes { get; set; }

    /// <summary>
    /// Path to mount the JWT/OIDC auth backend
    /// path to mount the backend
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Provider specific handling configuration. All values may be strings, and the provider will convert to the appropriate type when configuring Vault.
    /// Provider specific handling configuration
    /// </summary>
    [JsonPropertyName("providerConfig")]
    public IDictionary<string, string>? ProviderConfig { get; set; }

    [JsonPropertyName("tune")]
    public IList<V1alpha1AuthBackendSpecForProviderTune>? Tune { get; set; }

    /// <summary>
    /// Type of auth backend. Should be one of jwt or oidc. Default - jwt
    /// Type of backend. Can be either &apos;jwt&apos; or &apos;oidc&apos;
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Client Secret used for OIDC backends. Note: This field is stored in state. For enhanced security, use oidc_client_secret_wo instead.
/// Client Secret used for OIDC
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecInitProviderOidcClientSecretSecretRef
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
/// Write-only Client Secret used for OIDC backends. Mutually exclusive with oidc_client_secret. Must be used with oidc_client_secret_wo_version. To rotate the secret, update the value and increment oidc_client_secret_wo_version.
/// Write-only Client Secret used for OIDC. This field is recommended over oidc_client_secret for enhanced security.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecInitProviderOidcClientSecretWoSecretRef
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
public partial class V1alpha1AuthBackendSpecInitProviderTune
{
    /// <summary>
    /// List of headers to whitelist and allowing
    /// a plugin to include them in the response.
    /// </summary>
    [JsonPropertyName("allowedResponseHeaders")]
    public IList<string>? AllowedResponseHeaders { get; set; }

    /// <summary>
    /// Specifies the list of keys that will
    /// not be HMAC&apos;d by audit devices in the request data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacRequestKeys")]
    public IList<string>? AuditNonHmacRequestKeys { get; set; }

    /// <summary>
    /// Specifies the list of keys that will
    /// not be HMAC&apos;d by audit devices in the response data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacResponseKeys")]
    public IList<string>? AuditNonHmacResponseKeys { get; set; }

    /// <summary>
    /// Specifies the default time-to-live.
    /// If set, this overrides the global default.
    /// Must be a valid duration string
    /// </summary>
    [JsonPropertyName("defaultLeaseTtl")]
    public string? DefaultLeaseTtl { get; set; }

    /// <summary>
    /// Specifies whether to show this mount in
    /// the UI-specific listing endpoint. Valid values are &quot;unauth&quot; or &quot;hidden&quot;.
    /// </summary>
    [JsonPropertyName("listingVisibility")]
    public string? ListingVisibility { get; set; }

    /// <summary>
    /// Specifies the maximum time-to-live.
    /// If set, this overrides the global default.
    /// Must be a valid duration string
    /// </summary>
    [JsonPropertyName("maxLeaseTtl")]
    public string? MaxLeaseTtl { get; set; }

    /// <summary>
    /// List of headers to whitelist and
    /// pass from the request to the backend.
    /// </summary>
    [JsonPropertyName("passthroughRequestHeaders")]
    public IList<string>? PassthroughRequestHeaders { get; set; }

    /// <summary>
    /// Specifies the type of tokens that should be returned by
    /// the mount. Valid values are &quot;default-service&quot;, &quot;default-batch&quot;, &quot;service&quot;, &quot;batch&quot;.
    /// </summary>
    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }
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
public partial class V1alpha1AuthBackendSpecInitProvider
{
    /// <summary>
    /// The value against which to match the iss claim in a JWT
    /// The value against which to match the iss claim in a JWT
    /// </summary>
    [JsonPropertyName("boundIssuer")]
    public string? BoundIssuer { get; set; }

    /// <summary>
    /// The default role to use if none is provided during login
    /// The default role to use if none is provided during login
    /// </summary>
    [JsonPropertyName("defaultRole")]
    public string? DefaultRole { get; set; }

    /// <summary>
    /// The description of the auth backend
    /// The description of the auth backend
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// If set, opts out of mount migration on path updates.
    /// See here for more info on Mount Migration
    /// If set, opts out of mount migration on path updates.
    /// </summary>
    [JsonPropertyName("disableRemount")]
    public bool? DisableRemount { get; set; }

    /// <summary>
    /// The CA certificate or chain of certificates, in PEM format, to use to validate connections to the JWKS URL. If not set, system certificates are used.
    /// The CA certificate or chain of certificates, in PEM format, to use to validate connections to the JWKS URL. If not set, system certificates are used.
    /// </summary>
    [JsonPropertyName("jwksCaPem")]
    public string? JwksCaPem { get; set; }

    /// <summary>
    /// List of JWKS URL and optional CA certificate pairs. Cannot be used with jwks_url or jwks_ca_pem. Requires Vault 1.16+.
    /// List of JWKS URL and optional CA certificate pairs. Cannot be used with &apos;jwks_url&apos; or &apos;jwks_ca_pem&apos;. Requires Vault 1.16+.
    /// </summary>
    [JsonPropertyName("jwksPairs")]
    public IList<IDictionary<string, string>>? JwksPairs { get; set; }

    /// <summary>
    /// JWKS URL to use to authenticate signatures. Cannot be used with &quot;oidc_discovery_url&quot; or &quot;jwt_validation_pubkeys&quot;.
    /// JWKS URL to use to authenticate signatures. Cannot be used with &apos;oidc_discovery_url&apos; or &apos;jwt_validation_pubkeys&apos;.
    /// </summary>
    [JsonPropertyName("jwksUrl")]
    public string? JwksUrl { get; set; }

    /// <summary>
    /// A list of supported signing algorithms. Vault 1.1.0 defaults to [RS256] but future or past versions of Vault may differ
    /// A list of supported signing algorithms. Defaults to [RS256]
    /// </summary>
    [JsonPropertyName("jwtSupportedAlgs")]
    public IList<string>? JwtSupportedAlgs { get; set; }

    /// <summary>
    /// A list of PEM-encoded public keys to use to authenticate signatures locally. Cannot be used in combination with oidc_discovery_url
    /// A list of PEM-encoded public keys to use to authenticate signatures locally. Cannot be used with &apos;jwks_url&apos; or &apos;oidc_discovery_url&apos;.
    /// </summary>
    [JsonPropertyName("jwtValidationPubkeys")]
    public IList<string>? JwtValidationPubkeys { get; set; }

    /// <summary>
    /// Specifies if the auth method is local only.
    /// Specifies if the auth method is local only
    /// </summary>
    [JsonPropertyName("local")]
    public bool? Local { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Pass namespace in the OIDC state parameter instead of as a separate query parameter. With this setting, the allowed redirect URL(s) in Vault and on the provider side should not contain a namespace query parameter. This means only one redirect URL entry needs to be maintained on the OIDC provider side for all vault namespaces that will be authenticating against it. Defaults to true for new configs
    /// Pass namespace in the OIDC state parameter instead of as a separate query parameter. With this setting, the allowed redirect URL(s) in Vault and on the provider side should not contain a namespace query parameter. This means only one redirect URL entry needs to be maintained on the OIDC provider side for all vault namespaces that will be authenticating against it. Defaults to true for new configs.
    /// </summary>
    [JsonPropertyName("namespaceInState")]
    public bool? NamespaceInState { get; set; }

    /// <summary>
    /// Client ID used for OIDC backends
    /// Client ID used for OIDC
    /// </summary>
    [JsonPropertyName("oidcClientId")]
    public string? OidcClientId { get; set; }

    /// <summary>
    /// Client Secret used for OIDC backends. Note: This field is stored in state. For enhanced security, use oidc_client_secret_wo instead.
    /// Client Secret used for OIDC
    /// </summary>
    [JsonPropertyName("oidcClientSecretSecretRef")]
    public V1alpha1AuthBackendSpecInitProviderOidcClientSecretSecretRef? OidcClientSecretSecretRef { get; set; }

    /// <summary>
    /// Write-only Client Secret used for OIDC backends. Mutually exclusive with oidc_client_secret. Must be used with oidc_client_secret_wo_version. To rotate the secret, update the value and increment oidc_client_secret_wo_version.
    /// Write-only Client Secret used for OIDC. This field is recommended over oidc_client_secret for enhanced security.
    /// </summary>
    [JsonPropertyName("oidcClientSecretWoSecretRef")]
    public V1alpha1AuthBackendSpecInitProviderOidcClientSecretWoSecretRef? OidcClientSecretWoSecretRef { get; set; }

    /// <summary>
    /// Version counter for the write-only oidc_client_secret_wo field. Increment this value to trigger an update of the client secret in Vault. Required when using oidc_client_secret_wo.
    /// Version counter for write-only oidc_client_secret field. Increment this value to force update of the secret.
    /// </summary>
    [JsonPropertyName("oidcClientSecretWoVersion")]
    public double? OidcClientSecretWoVersion { get; set; }

    /// <summary>
    /// The CA certificate or chain of certificates, in PEM format, to use to validate connections to the OIDC Discovery URL. If not set, system certificates are used
    /// The CA certificate or chain of certificates, in PEM format, to use to validate connections to the OIDC Discovery URL. If not set, system certificates are used
    /// </summary>
    [JsonPropertyName("oidcDiscoveryCaPem")]
    public string? OidcDiscoveryCaPem { get; set; }

    /// <summary>
    /// The OIDC Discovery URL, without any .well-known component (base path). Cannot be used in combination with jwt_validation_pubkeys
    /// The OIDC Discovery URL, without any .well-known component (base path). Cannot be used with &apos;jwks_url&apos; or &apos;jwt_validation_pubkeys&apos;.
    /// </summary>
    [JsonPropertyName("oidcDiscoveryUrl")]
    public string? OidcDiscoveryUrl { get; set; }

    /// <summary>
    /// The response mode to be used in the OAuth2 request. Allowed values are query and form_post. Defaults to query. If using Vault namespaces, and oidc_response_mode is form_post, then namespace_in_state should be set to false.
    /// The response mode to be used in the OAuth2 request. Allowed values are &apos;query&apos; and &apos;form_post&apos;. Defaults to &apos;query&apos;. If using Vault namespaces, and oidc_response_mode is &apos;form_post&apos;, then &apos;namespace_in_state&apos; should be set to false.
    /// </summary>
    [JsonPropertyName("oidcResponseMode")]
    public string? OidcResponseMode { get; set; }

    /// <summary>
    /// List of response types to request. Allowed values are &apos;code&apos; and &apos;id_token&apos;. Defaults to [&quot;code&quot;]. Note: id_token may only be used if oidc_response_mode is set to form_post.
    /// The response types to request. Allowed values are &apos;code&apos; and &apos;id_token&apos;. Defaults to &apos;code&apos;. Note: &apos;id_token&apos; may only be used if &apos;oidc_response_mode&apos; is set to &apos;form_post&apos;.
    /// </summary>
    [JsonPropertyName("oidcResponseTypes")]
    public IList<string>? OidcResponseTypes { get; set; }

    /// <summary>
    /// Path to mount the JWT/OIDC auth backend
    /// path to mount the backend
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Provider specific handling configuration. All values may be strings, and the provider will convert to the appropriate type when configuring Vault.
    /// Provider specific handling configuration
    /// </summary>
    [JsonPropertyName("providerConfig")]
    public IDictionary<string, string>? ProviderConfig { get; set; }

    [JsonPropertyName("tune")]
    public IList<V1alpha1AuthBackendSpecInitProviderTune>? Tune { get; set; }

    /// <summary>
    /// Type of auth backend. Should be one of jwt or oidc. Default - jwt
    /// Type of backend. Can be either &apos;jwt&apos; or &apos;oidc&apos;
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendSpecManagementPoliciesEnum>))]
public enum V1alpha1AuthBackendSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1AuthBackendSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1AuthBackendSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1AuthBackendSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1AuthBackendSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1AuthBackendSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1AuthBackendSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AuthBackendSpec defines the desired state of AuthBackend</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendSpec
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
    public V1alpha1AuthBackendSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1AuthBackendSpecForProvider ForProvider { get; set; }

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
    public V1alpha1AuthBackendSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1AuthBackendSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1AuthBackendSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1AuthBackendSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendStatusAtProviderTune
{
    /// <summary>
    /// List of headers to whitelist and allowing
    /// a plugin to include them in the response.
    /// </summary>
    [JsonPropertyName("allowedResponseHeaders")]
    public IList<string>? AllowedResponseHeaders { get; set; }

    /// <summary>
    /// Specifies the list of keys that will
    /// not be HMAC&apos;d by audit devices in the request data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacRequestKeys")]
    public IList<string>? AuditNonHmacRequestKeys { get; set; }

    /// <summary>
    /// Specifies the list of keys that will
    /// not be HMAC&apos;d by audit devices in the response data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacResponseKeys")]
    public IList<string>? AuditNonHmacResponseKeys { get; set; }

    /// <summary>
    /// Specifies the default time-to-live.
    /// If set, this overrides the global default.
    /// Must be a valid duration string
    /// </summary>
    [JsonPropertyName("defaultLeaseTtl")]
    public string? DefaultLeaseTtl { get; set; }

    /// <summary>
    /// Specifies whether to show this mount in
    /// the UI-specific listing endpoint. Valid values are &quot;unauth&quot; or &quot;hidden&quot;.
    /// </summary>
    [JsonPropertyName("listingVisibility")]
    public string? ListingVisibility { get; set; }

    /// <summary>
    /// Specifies the maximum time-to-live.
    /// If set, this overrides the global default.
    /// Must be a valid duration string
    /// </summary>
    [JsonPropertyName("maxLeaseTtl")]
    public string? MaxLeaseTtl { get; set; }

    /// <summary>
    /// List of headers to whitelist and
    /// pass from the request to the backend.
    /// </summary>
    [JsonPropertyName("passthroughRequestHeaders")]
    public IList<string>? PassthroughRequestHeaders { get; set; }

    /// <summary>
    /// Specifies the type of tokens that should be returned by
    /// the mount. Valid values are &quot;default-service&quot;, &quot;default-batch&quot;, &quot;service&quot;, &quot;batch&quot;.
    /// </summary>
    [JsonPropertyName("tokenType")]
    public string? TokenType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendStatusAtProvider
{
    /// <summary>
    /// The accessor for this auth method
    /// The accessor of the JWT auth backend
    /// </summary>
    [JsonPropertyName("accessor")]
    public string? Accessor { get; set; }

    /// <summary>
    /// The value against which to match the iss claim in a JWT
    /// The value against which to match the iss claim in a JWT
    /// </summary>
    [JsonPropertyName("boundIssuer")]
    public string? BoundIssuer { get; set; }

    /// <summary>
    /// The default role to use if none is provided during login
    /// The default role to use if none is provided during login
    /// </summary>
    [JsonPropertyName("defaultRole")]
    public string? DefaultRole { get; set; }

    /// <summary>
    /// The description of the auth backend
    /// The description of the auth backend
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// If set, opts out of mount migration on path updates.
    /// See here for more info on Mount Migration
    /// If set, opts out of mount migration on path updates.
    /// </summary>
    [JsonPropertyName("disableRemount")]
    public bool? DisableRemount { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The CA certificate or chain of certificates, in PEM format, to use to validate connections to the JWKS URL. If not set, system certificates are used.
    /// The CA certificate or chain of certificates, in PEM format, to use to validate connections to the JWKS URL. If not set, system certificates are used.
    /// </summary>
    [JsonPropertyName("jwksCaPem")]
    public string? JwksCaPem { get; set; }

    /// <summary>
    /// List of JWKS URL and optional CA certificate pairs. Cannot be used with jwks_url or jwks_ca_pem. Requires Vault 1.16+.
    /// List of JWKS URL and optional CA certificate pairs. Cannot be used with &apos;jwks_url&apos; or &apos;jwks_ca_pem&apos;. Requires Vault 1.16+.
    /// </summary>
    [JsonPropertyName("jwksPairs")]
    public IList<IDictionary<string, string>>? JwksPairs { get; set; }

    /// <summary>
    /// JWKS URL to use to authenticate signatures. Cannot be used with &quot;oidc_discovery_url&quot; or &quot;jwt_validation_pubkeys&quot;.
    /// JWKS URL to use to authenticate signatures. Cannot be used with &apos;oidc_discovery_url&apos; or &apos;jwt_validation_pubkeys&apos;.
    /// </summary>
    [JsonPropertyName("jwksUrl")]
    public string? JwksUrl { get; set; }

    /// <summary>
    /// A list of supported signing algorithms. Vault 1.1.0 defaults to [RS256] but future or past versions of Vault may differ
    /// A list of supported signing algorithms. Defaults to [RS256]
    /// </summary>
    [JsonPropertyName("jwtSupportedAlgs")]
    public IList<string>? JwtSupportedAlgs { get; set; }

    /// <summary>
    /// A list of PEM-encoded public keys to use to authenticate signatures locally. Cannot be used in combination with oidc_discovery_url
    /// A list of PEM-encoded public keys to use to authenticate signatures locally. Cannot be used with &apos;jwks_url&apos; or &apos;oidc_discovery_url&apos;.
    /// </summary>
    [JsonPropertyName("jwtValidationPubkeys")]
    public IList<string>? JwtValidationPubkeys { get; set; }

    /// <summary>
    /// Specifies if the auth method is local only.
    /// Specifies if the auth method is local only
    /// </summary>
    [JsonPropertyName("local")]
    public bool? Local { get; set; }

    /// <summary>
    /// The namespace to provision the resource in.
    /// The value should not contain leading or trailing forward slashes.
    /// The namespace is always relative to the provider&apos;s configured namespace.
    /// Available only for Vault Enterprise.
    /// Target namespace. (requires Enterprise)
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Pass namespace in the OIDC state parameter instead of as a separate query parameter. With this setting, the allowed redirect URL(s) in Vault and on the provider side should not contain a namespace query parameter. This means only one redirect URL entry needs to be maintained on the OIDC provider side for all vault namespaces that will be authenticating against it. Defaults to true for new configs
    /// Pass namespace in the OIDC state parameter instead of as a separate query parameter. With this setting, the allowed redirect URL(s) in Vault and on the provider side should not contain a namespace query parameter. This means only one redirect URL entry needs to be maintained on the OIDC provider side for all vault namespaces that will be authenticating against it. Defaults to true for new configs.
    /// </summary>
    [JsonPropertyName("namespaceInState")]
    public bool? NamespaceInState { get; set; }

    /// <summary>
    /// Client ID used for OIDC backends
    /// Client ID used for OIDC
    /// </summary>
    [JsonPropertyName("oidcClientId")]
    public string? OidcClientId { get; set; }

    /// <summary>
    /// Version counter for the write-only oidc_client_secret_wo field. Increment this value to trigger an update of the client secret in Vault. Required when using oidc_client_secret_wo.
    /// Version counter for write-only oidc_client_secret field. Increment this value to force update of the secret.
    /// </summary>
    [JsonPropertyName("oidcClientSecretWoVersion")]
    public double? OidcClientSecretWoVersion { get; set; }

    /// <summary>
    /// The CA certificate or chain of certificates, in PEM format, to use to validate connections to the OIDC Discovery URL. If not set, system certificates are used
    /// The CA certificate or chain of certificates, in PEM format, to use to validate connections to the OIDC Discovery URL. If not set, system certificates are used
    /// </summary>
    [JsonPropertyName("oidcDiscoveryCaPem")]
    public string? OidcDiscoveryCaPem { get; set; }

    /// <summary>
    /// The OIDC Discovery URL, without any .well-known component (base path). Cannot be used in combination with jwt_validation_pubkeys
    /// The OIDC Discovery URL, without any .well-known component (base path). Cannot be used with &apos;jwks_url&apos; or &apos;jwt_validation_pubkeys&apos;.
    /// </summary>
    [JsonPropertyName("oidcDiscoveryUrl")]
    public string? OidcDiscoveryUrl { get; set; }

    /// <summary>
    /// The response mode to be used in the OAuth2 request. Allowed values are query and form_post. Defaults to query. If using Vault namespaces, and oidc_response_mode is form_post, then namespace_in_state should be set to false.
    /// The response mode to be used in the OAuth2 request. Allowed values are &apos;query&apos; and &apos;form_post&apos;. Defaults to &apos;query&apos;. If using Vault namespaces, and oidc_response_mode is &apos;form_post&apos;, then &apos;namespace_in_state&apos; should be set to false.
    /// </summary>
    [JsonPropertyName("oidcResponseMode")]
    public string? OidcResponseMode { get; set; }

    /// <summary>
    /// List of response types to request. Allowed values are &apos;code&apos; and &apos;id_token&apos;. Defaults to [&quot;code&quot;]. Note: id_token may only be used if oidc_response_mode is set to form_post.
    /// The response types to request. Allowed values are &apos;code&apos; and &apos;id_token&apos;. Defaults to &apos;code&apos;. Note: &apos;id_token&apos; may only be used if &apos;oidc_response_mode&apos; is set to &apos;form_post&apos;.
    /// </summary>
    [JsonPropertyName("oidcResponseTypes")]
    public IList<string>? OidcResponseTypes { get; set; }

    /// <summary>
    /// Path to mount the JWT/OIDC auth backend
    /// path to mount the backend
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Provider specific handling configuration. All values may be strings, and the provider will convert to the appropriate type when configuring Vault.
    /// Provider specific handling configuration
    /// </summary>
    [JsonPropertyName("providerConfig")]
    public IDictionary<string, string>? ProviderConfig { get; set; }

    [JsonPropertyName("tune")]
    public IList<V1alpha1AuthBackendStatusAtProviderTune>? Tune { get; set; }

    /// <summary>
    /// Type of auth backend. Should be one of jwt or oidc. Default - jwt
    /// Type of backend. Can be either &apos;jwt&apos; or &apos;oidc&apos;
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendStatusConditions
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

/// <summary>AuthBackendStatus defines the observed state of AuthBackend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1AuthBackendStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1AuthBackendStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1AuthBackendStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AuthBackend is the Schema for the AuthBackends API. Managing JWT/OIDC auth backends in Vault</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1AuthBackend : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1AuthBackendSpec>, IStatus<V1alpha1AuthBackendStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "AuthBackend";
    public const string KubeGroup = "jwt.vault.upbound.io";
    public const string KubePluralName = "authbackends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "jwt.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AuthBackend";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AuthBackendSpec defines the desired state of AuthBackend</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1AuthBackendSpec Spec { get; set; }

    /// <summary>AuthBackendStatus defines the observed state of AuthBackend.</summary>
    [JsonPropertyName("status")]
    public V1alpha1AuthBackendStatus? Status { get; set; }
}