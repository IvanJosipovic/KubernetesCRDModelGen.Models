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
/// <summary>APIPortalAuth defines the authentication configuration for an APIPortal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIPortalAuthList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1APIPortalAuth>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIPortalAuthList";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiportalauths";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIPortalAuthList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1APIPortalAuth objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1APIPortalAuth> Items { get; set; }
}

/// <summary>Attributes configures LDAP attribute mappings for user attributes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalAuthSpecLdapAttributes
{
    /// <summary>Company is the LDAP attribute for user company.</summary>
    [JsonPropertyName("company")]
    public string? Company { get; set; }

    /// <summary>Email is the LDAP attribute for user email.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Firstname is the LDAP attribute for user first name.</summary>
    [JsonPropertyName("firstname")]
    public string? Firstname { get; set; }

    /// <summary>Lastname is the LDAP attribute for user last name.</summary>
    [JsonPropertyName("lastname")]
    public string? Lastname { get; set; }

    /// <summary>UserID is the LDAP attribute for user ID mapping.</summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }
}

/// <summary>Groups configures group extraction.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalAuthSpecLdapGroups
{
    /// <summary>MemberOfAttribute is the LDAP attribute containing group memberships (e.g., &quot;memberOf&quot;).</summary>
    [JsonPropertyName("memberOfAttribute")]
    public string? MemberOfAttribute { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1APIPortalAuthSpecLdapSyncedAttributesEnum>))]
public enum V1alpha1APIPortalAuthSpecLdapSyncedAttributesEnum
{
    [EnumMember(Value = "groups"), JsonStringEnumMemberName("groups")]
    Groups,
    [EnumMember(Value = "userId"), JsonStringEnumMemberName("userId")]
    UserId,
    [EnumMember(Value = "firstname"), JsonStringEnumMemberName("firstname")]
    Firstname,
    [EnumMember(Value = "lastname"), JsonStringEnumMemberName("lastname")]
    Lastname,
    [EnumMember(Value = "email"), JsonStringEnumMemberName("email")]
    Email,
    [EnumMember(Value = "company"), JsonStringEnumMemberName("company")]
    Company
}

/// <summary>LDAP configures the LDAP authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalAuthSpecLdap
{
    /// <summary>
    /// Attribute is the LDAP object attribute used to form a bind DN when sending bind queries.
    /// The bind DN is formed as &lt;Attribute&gt;=&lt;Username&gt;,&lt;BaseDN&gt;.
    /// </summary>
    [JsonPropertyName("attribute")]
    public string? Attribute { get; set; }

    /// <summary>Attributes configures LDAP attribute mappings for user attributes.</summary>
    [JsonPropertyName("attributes")]
    public V1alpha1APIPortalAuthSpecLdapAttributes? Attributes { get; set; }

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

    /// <summary>Groups configures group extraction.</summary>
    [JsonPropertyName("groups")]
    public V1alpha1APIPortalAuthSpecLdapGroups? Groups { get; set; }

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

    /// <summary>SyncedAttributes are the user attributes to synchronize with Hub platform.</summary>
    [JsonPropertyName("syncedAttributes")]
    public IList<V1alpha1APIPortalAuthSpecLdapSyncedAttributesEnum>? SyncedAttributes { get; set; }

    /// <summary>URL is the URL of the LDAP server, including the protocol (ldap or ldaps) and the port.</summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }
}

/// <summary>Claims configures JWT claim mappings for user attributes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalAuthSpecOidcClaims
{
    /// <summary>Company is the JWT claim for user company.</summary>
    [JsonPropertyName("company")]
    public string? Company { get; set; }

    /// <summary>Email is the JWT claim for user email.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Firstname is the JWT claim for user first name.</summary>
    [JsonPropertyName("firstname")]
    public string? Firstname { get; set; }

    /// <summary>Groups is the JWT claim for user groups. This field is required for authorization.</summary>
    [JsonPropertyName("groups")]
    public required string Groups { get; set; }

    /// <summary>Lastname is the JWT claim for user last name.</summary>
    [JsonPropertyName("lastname")]
    public string? Lastname { get; set; }

    /// <summary>UserID is the JWT claim for user ID mapping.</summary>
    [JsonPropertyName("userId")]
    public string? UserId { get; set; }
}

/// <summary>TLS configures TLS for the HTTP client.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalAuthSpecOidcClientConfigTls
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

/// <summary>ClientConfig configures the HTTP client used to communicate with the OIDC provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalAuthSpecOidcClientConfig
{
    /// <summary>MaxRetries defines the maximum number of retry attempts for failed requests.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }

    /// <summary>TimeoutSeconds configures the maximum amount of seconds to wait before giving up on requests.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>TLS configures TLS for the HTTP client.</summary>
    [JsonPropertyName("tls")]
    public V1alpha1APIPortalAuthSpecOidcClientConfigTls? Tls { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1APIPortalAuthSpecOidcSyncedAttributesEnum>))]
public enum V1alpha1APIPortalAuthSpecOidcSyncedAttributesEnum
{
    [EnumMember(Value = "groups"), JsonStringEnumMemberName("groups")]
    Groups,
    [EnumMember(Value = "userId"), JsonStringEnumMemberName("userId")]
    UserId,
    [EnumMember(Value = "firstname"), JsonStringEnumMemberName("firstname")]
    Firstname,
    [EnumMember(Value = "lastname"), JsonStringEnumMemberName("lastname")]
    Lastname,
    [EnumMember(Value = "email"), JsonStringEnumMemberName("email")]
    Email,
    [EnumMember(Value = "company"), JsonStringEnumMemberName("company")]
    Company
}

/// <summary>OIDC configures the OIDC authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalAuthSpecOidc
{
    /// <summary>Claims configures JWT claim mappings for user attributes.</summary>
    [JsonPropertyName("claims")]
    public required V1alpha1APIPortalAuthSpecOidcClaims Claims { get; set; }

    /// <summary>ClientConfig configures the HTTP client used to communicate with the OIDC provider.</summary>
    [JsonPropertyName("clientConfig")]
    public V1alpha1APIPortalAuthSpecOidcClientConfig? ClientConfig { get; set; }

    /// <summary>IssuerURL is the OIDC provider issuer URL.</summary>
    [JsonPropertyName("issuerUrl")]
    public required string IssuerUrl { get; set; }

    /// <summary>Scopes is a list of OAuth2 scopes.</summary>
    [JsonPropertyName("scopes")]
    public IList<string>? Scopes { get; set; }

    /// <summary>SecretName is the name of the Kubernetes Secret containing clientId and clientSecret keys.</summary>
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }

    /// <summary>SyncedAttributes are the user attributes to synchronize with Hub platform.</summary>
    [JsonPropertyName("syncedAttributes")]
    public IList<V1alpha1APIPortalAuthSpecOidcSyncedAttributesEnum>? SyncedAttributes { get; set; }
}

/// <summary>The desired behavior of this APIPortalAuth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalAuthSpec
{
    /// <summary>LDAP configures the LDAP authentication.</summary>
    [JsonPropertyName("ldap")]
    public V1alpha1APIPortalAuthSpecLdap? Ldap { get; set; }

    /// <summary>OIDC configures the OIDC authentication.</summary>
    [JsonPropertyName("oidc")]
    public V1alpha1APIPortalAuthSpecOidc? Oidc { get; set; }
}

/// <summary>status of the condition, one of True, False, Unknown.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1APIPortalAuthStatusConditionsStatusEnum>))]
public enum V1alpha1APIPortalAuthStatusConditionsStatusEnum
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
public partial class V1alpha1APIPortalAuthStatusConditions
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
    public required V1alpha1APIPortalAuthStatusConditionsStatusEnum Status { get; set; }

    /// <summary>type of condition in CamelCase or in foo.example.com/CamelCase.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>The current status of this APIPortalAuth.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1APIPortalAuthStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1alpha1APIPortalAuthStatusConditions>? Conditions { get; set; }

    /// <summary>Hash is a hash representing the APIPortalAuth.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    [JsonPropertyName("syncedAt")]
    public DateTime? SyncedAt { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>APIPortalAuth defines the authentication configuration for an APIPortal.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1APIPortalAuth : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1APIPortalAuthSpec?>, IStatus<V1alpha1APIPortalAuthStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "APIPortalAuth";
    public const string KubeGroup = "hub.traefik.io";
    public const string KubePluralName = "apiportalauths";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "hub.traefik.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "APIPortalAuth";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The desired behavior of this APIPortalAuth.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1APIPortalAuthSpec? Spec { get; set; }

    /// <summary>The current status of this APIPortalAuth.</summary>
    [JsonPropertyName("status")]
    public V1alpha1APIPortalAuthStatus? Status { get; set; }
}