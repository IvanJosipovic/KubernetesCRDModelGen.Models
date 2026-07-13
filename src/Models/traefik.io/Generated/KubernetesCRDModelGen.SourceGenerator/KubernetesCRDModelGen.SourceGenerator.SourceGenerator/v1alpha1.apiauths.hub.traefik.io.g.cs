#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.hub.traefik.io;
/// <summary>APIAuth defines the authentication configuration for APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIAuthList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APIAuth>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIAuthList";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiauths";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIAuthList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1APIAuth objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1APIAuth> Items { get; set; }
}

/// <summary>
/// KeySource defines where to extract the API key from requests.
/// When not specified, defaults to &quot;Authorization&quot; header with &quot;Bearer&quot; scheme and &quot;api_key&quot; query parameter.
/// When specified, it completely overrides defaults - fields left empty will disable that extraction method.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIAuthSpecApiKeyKeySource
{
    /// <summary>Header is the name of the header containing the API key.</summary>
    [JsonPropertyName("header")]
    public string? Header { get; set; }

    /// <summary>
    /// HeaderAuthScheme is the authentication scheme prefix in the header value.
    /// The scheme is used to parse headers in the format &quot; &lt;scheme&gt; &lt;token&gt; &quot;.
    /// Only applies when header is &quot;Authorization&quot;.
    /// </summary>
    [JsonPropertyName("headerAuthScheme")]
    public string? HeaderAuthScheme { get; set; }

    /// <summary>Query is the name of the query parameter containing the API key.</summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }
}

/// <summary>APIKey configures API key authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIAuthSpecApiKey
{
    /// <summary>
    /// KeySource defines where to extract the API key from requests.
    /// When not specified, defaults to &quot;Authorization&quot; header with &quot;Bearer&quot; scheme and &quot;api_key&quot; query parameter.
    /// When specified, it completely overrides defaults - fields left empty will disable that extraction method.
    /// </summary>
    [JsonPropertyName("keySource")]
    public V1alpha1APIAuthSpecApiKeyKeySource? KeySource { get; set; }
}

/// <summary>TLS configures TLS for the HTTP client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIAuthSpecJwtClientConfigTls
{
    /// <summary>CA sets the CA bundle used to verify the server certificate.</summary>
    [JsonPropertyName("ca")]
    public string? Ca { get; set; }

    /// <summary>
    /// InsecureSkipVerify skips the server certificate validation.
    /// For testing purposes only, do not use in production.
    /// </summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }
}

/// <summary>ClientConfig configures the HTTP client used to fetch the JWKS from the JWKS URL or the trusted issuers.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIAuthSpecJwtClientConfig
{
    /// <summary>MaxRetries defines the maximum number of retry attempts for failed requests.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }

    /// <summary>TimeoutSeconds configures the maximum amount of seconds to wait before giving up on requests.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>TLS configures TLS for the HTTP client.</summary>
    [JsonPropertyName("tls")]
    public V1alpha1APIAuthSpecJwtClientConfigTls? Tls { get; set; }
}

/// <summary>TrustedIssuer represents a trusted JWT issuer with its associated JWKS endpoint for token verification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIAuthSpecJwtTrustedIssuers
{
    /// <summary>
    /// Issuer is the expected value of the &quot;iss&quot; claim.
    /// If specified, tokens must have this exact issuer to be validated against this JWKS.
    /// The issuer value must match exactly, including trailing slashes and URL encoding.
    /// If omitted, this JWKS acts as a fallback for any issuer.
    /// </summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>JWKSURL is the URL to fetch the JWKS from.</summary>
    [JsonPropertyName("jwksUrl")]
    public required string JwksUrl { get; set; }
}

/// <summary>JWT configures JWT authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIAuthSpecJwt
{
    /// <summary>
    /// AppIDClaim is the name of the claim holding the identifier of the application.
    /// This field is sometimes named `client_id`.
    /// </summary>
    [JsonPropertyName("appIdClaim")]
    public required string AppIdClaim { get; set; }

    /// <summary>ClientConfig configures the HTTP client used to fetch the JWKS from the JWKS URL or the trusted issuers.</summary>
    [JsonPropertyName("clientConfig")]
    public V1alpha1APIAuthSpecJwtClientConfig? ClientConfig { get; set; }

    /// <summary>ForwardHeaders specifies additional headers to forward with the request.</summary>
    [JsonPropertyName("forwardHeaders")]
    public IDictionary<string, string>? ForwardHeaders { get; set; }

    /// <summary>
    /// JWKSFile contains the JWKS file content for JWT verification.
    /// Mutually exclusive with SigningSecretName, PublicKey, JWKSURL, and TrustedIssuers.
    /// </summary>
    [JsonPropertyName("jwksFile")]
    public string? JwksFile { get; set; }

    /// <summary>
    /// JWKSURL is the URL to fetch the JWKS for JWT verification.
    /// Mutually exclusive with SigningSecretName, PublicKey, JWKSFile, and TrustedIssuers.
    /// 
    /// Deprecated: Use TrustedIssuers instead for more flexible JWKS configuration with issuer validation.
    /// </summary>
    [JsonPropertyName("jwksUrl")]
    public string? JwksUrl { get; set; }

    /// <summary>
    /// PublicKey is the PEM-encoded public key for JWT verification.
    /// Mutually exclusive with SigningSecretName, JWKSFile, JWKSURL, and TrustedIssuers.
    /// </summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>
    /// SigningSecretName is the name of the Kubernetes Secret containing the signing secret.
    /// The secret must be of type Opaque and contain a key named &apos;value&apos;.
    /// Mutually exclusive with PublicKey, JWKSFile, JWKSURL, and TrustedIssuers.
    /// </summary>
    [JsonPropertyName("signingSecretName")]
    public string? SigningSecretName { get; set; }

    /// <summary>StripAuthorizationHeader determines whether to strip the Authorization header before forwarding the request.</summary>
    [JsonPropertyName("stripAuthorizationHeader")]
    public bool? StripAuthorizationHeader { get; set; }

    /// <summary>
    /// TokenNameClaim is the name of the claim holding the name of the token.
    /// This name, if provided, will be used in the metrics.
    /// </summary>
    [JsonPropertyName("tokenNameClaim")]
    public string? TokenNameClaim { get; set; }

    /// <summary>TokenQueryKey specifies the query parameter name for the JWT token.</summary>
    [JsonPropertyName("tokenQueryKey")]
    public string? TokenQueryKey { get; set; }

    /// <summary>
    /// TrustedIssuers defines multiple JWKS providers with optional issuer validation.
    /// Mutually exclusive with SigningSecretName, PublicKey, JWKSFile, and JWKSURL.
    /// </summary>
    [JsonPropertyName("trustedIssuers")]
    public IList<V1alpha1APIAuthSpecJwtTrustedIssuers>? TrustedIssuers { get; set; }
}

/// <summary>LDAP configures LDAP authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIAuthSpecLdap
{
    /// <summary>
    /// Attribute is the LDAP object attribute used to form a bind DN when sending bind queries.
    /// The bind DN is formed as &lt;Attribute&gt;=&lt;Username&gt;,&lt;BaseDN&gt;.
    /// </summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }

    /// <summary>BaseDN is the base domain name that should be used for bind and search queries.</summary>
    [JsonPropertyName("baseDn")]
    public required string BaseDn { get; set; }

    /// <summary>
    /// BindDN is the domain name to bind to in order to authenticate to the LDAP server when running in search mode.
    /// If empty, an anonymous bind will be done.
    /// </summary>
    [JsonPropertyName("bindDn")]
    public string? BindDn { get; set; }

    /// <summary>
    /// BindPasswordSecretName is the name of the Kubernetes Secret containing the password for the bind DN.
    /// The secret must contain a key named &apos;password&apos;.
    /// </summary>
    [JsonPropertyName("bindPasswordSecretName")]
    public string? BindPasswordSecretName { get; set; }

    /// <summary>
    /// CertificateAuthority is a PEM-encoded certificate to use to establish a connection with the LDAP server if the
    /// connection uses TLS but that the certificate was signed by a custom Certificate Authority.
    /// </summary>
    [JsonPropertyName("certificateAuthority")]
    public string? CertificateAuthority { get; set; }

    /// <summary>InsecureSkipVerify controls whether the server&apos;s certificate chain and host name is verified.</summary>
    [JsonPropertyName("insecureSkipVerify")]
    public bool? InsecureSkipVerify { get; set; }

    /// <summary>
    /// SearchFilter is used to filter LDAP search queries.
    /// Example: (&amp;(objectClass=inetOrgPerson)(gidNumber=500)(uid=%s))
    /// %s can be used as a placeholder for the username.
    /// </summary>
    [JsonPropertyName("searchFilter")]
    public string? SearchFilter { get; set; }

    /// <summary>StartTLS instructs the middleware to issue a StartTLS request when initializing the connection with the LDAP server.</summary>
    [JsonPropertyName("startTls")]
    public bool? StartTls { get; set; }

    /// <summary>URL is the URL of the LDAP server, including the protocol (ldap or ldaps) and the port.</summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>The desired behavior of this APIAuth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIAuthSpec
{
    /// <summary>APIKey configures API key authentication.</summary>
    [JsonPropertyName("apiKey")]
    public V1alpha1APIAuthSpecApiKey? ApiKey { get; set; }

    /// <summary>
    /// IsDefault specifies if this APIAuth should be used as the default API authentication method for the namespace.
    /// Only one APIAuth per namespace should have isDefault set to true.
    /// </summary>
    [JsonPropertyName("isDefault")]
    public required bool IsDefault { get; set; }

    /// <summary>JWT configures JWT authentication.</summary>
    [JsonPropertyName("jwt")]
    public V1alpha1APIAuthSpecJwt? Jwt { get; set; }

    /// <summary>LDAP configures LDAP authentication.</summary>
    [JsonPropertyName("ldap")]
    public V1alpha1APIAuthSpecLdap? Ldap { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1APIAuthStatusConditionsStatusEnum>))]
public enum V1alpha1APIAuthStatusConditionsStatusEnum
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
public partial class V1alpha1APIAuthStatusConditions
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
    public required V1alpha1APIAuthStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>The current status of this APIAuth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIAuthStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1alpha1APIAuthStatusConditions>? Conditions { get; set; }

    /// <summary>Hash is a hash representing the APIAuth.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    [JsonPropertyName("syncedAt")]
    public DateTime? SyncedAt { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>APIAuth defines the authentication configuration for APIs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIAuth : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIAuthSpec?>, IStatus<V1alpha1APIAuthStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIAuth";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiauths";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIAuth";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this APIAuth.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1APIAuthSpec? Spec { get; set; }

    /// <summary>The current status of this APIAuth.</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIAuthStatus? Status { get; set; }
}