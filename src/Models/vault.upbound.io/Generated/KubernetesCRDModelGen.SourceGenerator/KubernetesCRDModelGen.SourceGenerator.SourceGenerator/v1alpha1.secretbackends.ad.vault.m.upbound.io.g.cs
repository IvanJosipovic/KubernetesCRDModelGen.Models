#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ad.vault.m.upbound.io;
/// <summary>SecretBackend is the Schema for the SecretBackends API. Creates an Active Directory secret backend for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecretBackend>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendList";
    public const string KubeGroup = "ad.vault.m.upbound.io";
    public const string KubePluralName = "secretbackends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ad.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SecretBackend objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SecretBackend> Items { get; set; }
}

/// <summary>
/// Password to use along with binddn when performing user search.
/// LDAP password for searching for the user DN.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpecForProviderBindpassSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Client certificate to provide to the LDAP server, must be x509 PEM encoded.
/// Client certificate to provide to the LDAP server, must be x509 PEM encoded.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpecForProviderClientTlsCertSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Client certificate key to provide to the LDAP server, must be x509 PEM encoded.
/// Client certificate key to provide to the LDAP server, must be x509 PEM encoded.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpecForProviderClientTlsKeySecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpecForProvider
{
    /// <summary>
    /// Use anonymous binds when performing LDAP group searches
    /// (if true the initial credentials will still be used for the initial connection test).
    /// Use anonymous binds when performing LDAP group searches (if true the initial credentials will still be used for the initial connection test).
    /// </summary>
    [JsonPropertyName("anonymousGroupSearch")]
    public bool? AnonymousGroupSearch { get; set; }

    /// <summary>
    /// The unique path this backend should be mounted at. Must
    /// not begin or end with a /. Defaults to ad.
    /// The mount path for a backend, for example, the path given in &quot;$ vault auth enable -path=my-ad ad&quot;.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>
    /// Distinguished name of object to bind when performing user and group search.
    /// Distinguished name of object to bind when performing user and group search.
    /// </summary>
    [JsonPropertyName("binddn")]
    public string? Binddn { get; set; }

    /// <summary>
    /// Password to use along with binddn when performing user search.
    /// LDAP password for searching for the user DN.
    /// </summary>
    [JsonPropertyName("bindpassSecretRef")]
    public V1alpha1SecretBackendSpecForProviderBindpassSecretRef? BindpassSecretRef { get; set; }

    /// <summary>
    /// If set, user and group names assigned to policies within the
    /// backend will be case sensitive. Otherwise, names will be normalized to lower case.
    /// If true, case sensitivity will be used when comparing usernames and groups for matching policies.
    /// </summary>
    [JsonPropertyName("caseSensitiveNames")]
    public bool? CaseSensitiveNames { get; set; }

    /// <summary>
    /// CA certificate to use when verifying LDAP server certificate, must be
    /// x509 PEM encoded.
    /// CA certificate to use when verifying LDAP server certificate, must be x509 PEM encoded.
    /// </summary>
    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    /// <summary>
    /// Client certificate to provide to the LDAP server, must be x509 PEM encoded.
    /// Client certificate to provide to the LDAP server, must be x509 PEM encoded.
    /// </summary>
    [JsonPropertyName("clientTlsCertSecretRef")]
    public V1alpha1SecretBackendSpecForProviderClientTlsCertSecretRef? ClientTlsCertSecretRef { get; set; }

    /// <summary>
    /// Client certificate key to provide to the LDAP server, must be x509 PEM encoded.
    /// Client certificate key to provide to the LDAP server, must be x509 PEM encoded.
    /// </summary>
    [JsonPropertyName("clientTlsKeySecretRef")]
    public V1alpha1SecretBackendSpecForProviderClientTlsKeySecretRef? ClientTlsKeySecretRef { get; set; }

    /// <summary>
    /// Default lease duration for secrets in seconds.
    /// Default lease duration for secrets in seconds
    /// </summary>
    [JsonPropertyName("defaultLeaseTtlSeconds")]
    public double? DefaultLeaseTtlSeconds { get; set; }

    /// <summary>
    /// Denies an unauthenticated LDAP bind request if the user&apos;s password is empty;
    /// defaults to true.
    /// Denies an unauthenticated LDAP bind request if the user&apos;s password is empty; defaults to true
    /// </summary>
    [JsonPropertyName("denyNullBind")]
    public bool? DenyNullBind { get; set; }

    /// <summary>
    /// Human-friendly description of the mount for the Active Directory backend.
    /// Human-friendly description of the mount for the backend.
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
    /// Use anonymous bind to discover the bind Distinguished Name of a user.
    /// Use anonymous bind to discover the bind DN of a user.
    /// </summary>
    [JsonPropertyName("discoverdn")]
    public bool? Discoverdn { get; set; }

    /// <summary>
    /// LDAP attribute to follow on objects returned by  in order to enumerate
    /// user group membership. Examples: cn or memberOf, etc. Defaults to cn.
    /// LDAP attribute to follow on objects returned by &lt;groupfilter&gt; in order to enumerate user group membership. Examples: &quot;cn&quot; or &quot;memberOf&quot;, etc. Default: cn
    /// </summary>
    [JsonPropertyName("groupattr")]
    public string? Groupattr { get; set; }

    /// <summary>
    /// LDAP search base to use for group membership search (eg: ou=Groups,dc=example,dc=org).
    /// LDAP search base to use for group membership search (eg: ou=Groups,dc=example,dc=org)
    /// </summary>
    [JsonPropertyName("groupdn")]
    public string? Groupdn { get; set; }

    /// <summary>
    /// Go template for querying group membership of user  The template can access
    /// the following context variables: UserDN, Username. Defaults to (|(memberUid={{.Username}})(member={{.UserDN}})(uniqueMember={{.UserDN}}))
    /// Go template for querying group membership of user. The template can access the following context variables: UserDN, Username Example: (&amp;(objectClass=group)(member:1.2.840.113556.1.4.1941:={{.UserDN}})) Default: (|(memberUid={{.Username}})(member={{.UserDN}})(uniqueMember={{.UserDN}}))
    /// </summary>
    [JsonPropertyName("groupfilter")]
    public string? Groupfilter { get; set; }

    /// <summary>
    /// Skip LDAP server SSL Certificate verification. This is not recommended for production.
    /// Defaults to false.
    /// Skip LDAP server SSL Certificate verification - insecure and not recommended for production use.
    /// </summary>
    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>
    /// The number of seconds after a Vault rotation where, if Active Directory
    /// shows a later rotation, it should be considered out-of-band
    /// The number of seconds after a Vault rotation where, if Active Directory shows a later rotation, it should be considered out-of-band.
    /// </summary>
    [JsonPropertyName("lastRotationTolerance")]
    public double? LastRotationTolerance { get; set; }

    /// <summary>
    /// Mark the secrets engine as local-only. Local engines are not replicated or removed by
    /// replication.Tolerance duration to use when checking the last rotation time.
    /// Mark the secrets engine as local-only. Local engines are not replicated or removed by replication.Tolerance duration to use when checking the last rotation time.
    /// </summary>
    [JsonPropertyName("local")]
    public bool? Local { get; set; }

    /// <summary>
    /// Maximum possible lease duration for secrets in seconds.
    /// Maximum possible lease duration for secrets in seconds.
    /// </summary>
    [JsonPropertyName("maxLeaseTtlSeconds")]
    public double? MaxLeaseTtlSeconds { get; set; }

    /// <summary>
    /// In seconds, the maximum password time-to-live.
    /// In seconds, the maximum password time-to-live.
    /// </summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

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
    /// Name of the password policy to use to generate passwords.
    /// Name of the password policy to use to generate passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// Timeout, in seconds, for the connection when making requests against the server
    /// before returning back an error.
    /// Timeout, in seconds, for the connection when making requests against the server before returning back an error.
    /// </summary>
    [JsonPropertyName("requestTimeout")]
    public double? RequestTimeout { get; set; }

    /// <summary>
    /// Issue a StartTLS command after establishing unencrypted connection.
    /// Issue a StartTLS command after establishing unencrypted connection.
    /// </summary>
    [JsonPropertyName("starttls")]
    public bool? Starttls { get; set; }

    /// <summary>
    /// Maximum TLS version to use. Accepted values are tls10, tls11,
    /// tls12 or tls13. Defaults to tls12.
    /// Maximum TLS version to use. Accepted values are &apos;tls10&apos;, &apos;tls11&apos;, &apos;tls12&apos; or &apos;tls13&apos;. Defaults to &apos;tls12&apos;
    /// </summary>
    [JsonPropertyName("tlsMaxVersion")]
    public string? TlsMaxVersion { get; set; }

    /// <summary>
    /// Minimum TLS version to use. Accepted values are tls10, tls11,
    /// tls12 or tls13. Defaults to tls12.
    /// Minimum TLS version to use. Accepted values are &apos;tls10&apos;, &apos;tls11&apos;, &apos;tls12&apos; or &apos;tls13&apos;. Defaults to &apos;tls12&apos;
    /// </summary>
    [JsonPropertyName("tlsMinVersion")]
    public string? TlsMinVersion { get; set; }

    /// <summary>
    /// In seconds, the default password time-to-live.
    /// In seconds, the default password time-to-live.
    /// </summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>
    /// Enables userPrincipalDomain login with [username]@UPNDomain.
    /// Enables userPrincipalDomain login with [username]@UPNDomain.
    /// </summary>
    [JsonPropertyName("upndomain")]
    public string? Upndomain { get; set; }

    /// <summary>
    /// LDAP URL to connect to. Multiple URLs can be specified by concatenating
    /// them with commas; they will be tried in-order. Defaults to ldap://127.0.0.1.
    /// LDAP URL to connect to (default: ldap://127.0.0.1). Multiple URLs can be specified by concatenating them with commas; they will be tried in-order.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// In Vault 1.1.1 a fix for handling group CN values of
    /// different cases unfortunately introduced a regression that could cause previously defined groups
    /// to not be found due to a change in the resulting name. If set true, the pre-1.1.1 behavior for
    /// matching group CNs will be used. This is only needed in some upgrade scenarios for backwards
    /// compatibility. It is enabled by default if the config is upgraded but disabled by default on
    /// new configurations.
    /// In Vault 1.1.1 a fix for handling group CN values of different cases unfortunately introduced a regression that could cause previously defined groups to not be found due to a change in the resulting name. If set true, the pre-1.1.1 behavior for matching group CNs will be used. This is only needed in some upgrade scenarios for backwards compatibility. It is enabled by default if the config is upgraded but disabled by default on new configurations.
    /// </summary>
    [JsonPropertyName("usePre111GroupCnBehavior")]
    public bool? UsePre111GroupCnBehavior { get; set; }

    /// <summary>
    /// If true, use the Active Directory tokenGroups constructed attribute of the
    /// user to find the group memberships. This will find all security groups including nested ones.
    /// If true, use the Active Directory tokenGroups constructed attribute of the user to find the group memberships. This will find all security groups including nested ones.
    /// </summary>
    [JsonPropertyName("useTokenGroups")]
    public bool? UseTokenGroups { get; set; }

    /// <summary>
    /// Attribute used when searching users. Defaults to cn.
    /// Attribute used for users (default: cn)
    /// </summary>
    [JsonPropertyName("userattr")]
    public string? Userattr { get; set; }

    /// <summary>
    /// LDAP domain to use for users (eg: ou=People,dc=example,dc=org)`.
    /// LDAP domain to use for users (eg: ou=People,dc=example,dc=org)
    /// </summary>
    [JsonPropertyName("userdn")]
    public string? Userdn { get; set; }
}

/// <summary>
/// Password to use along with binddn when performing user search.
/// LDAP password for searching for the user DN.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpecInitProviderBindpassSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Client certificate to provide to the LDAP server, must be x509 PEM encoded.
/// Client certificate to provide to the LDAP server, must be x509 PEM encoded.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpecInitProviderClientTlsCertSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Client certificate key to provide to the LDAP server, must be x509 PEM encoded.
/// Client certificate key to provide to the LDAP server, must be x509 PEM encoded.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpecInitProviderClientTlsKeySecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
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
public partial class V1alpha1SecretBackendSpecInitProvider
{
    /// <summary>
    /// Use anonymous binds when performing LDAP group searches
    /// (if true the initial credentials will still be used for the initial connection test).
    /// Use anonymous binds when performing LDAP group searches (if true the initial credentials will still be used for the initial connection test).
    /// </summary>
    [JsonPropertyName("anonymousGroupSearch")]
    public bool? AnonymousGroupSearch { get; set; }

    /// <summary>
    /// The unique path this backend should be mounted at. Must
    /// not begin or end with a /. Defaults to ad.
    /// The mount path for a backend, for example, the path given in &quot;$ vault auth enable -path=my-ad ad&quot;.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>
    /// Distinguished name of object to bind when performing user and group search.
    /// Distinguished name of object to bind when performing user and group search.
    /// </summary>
    [JsonPropertyName("binddn")]
    public string? Binddn { get; set; }

    /// <summary>
    /// Password to use along with binddn when performing user search.
    /// LDAP password for searching for the user DN.
    /// </summary>
    [JsonPropertyName("bindpassSecretRef")]
    public required V1alpha1SecretBackendSpecInitProviderBindpassSecretRef BindpassSecretRef { get; set; }

    /// <summary>
    /// If set, user and group names assigned to policies within the
    /// backend will be case sensitive. Otherwise, names will be normalized to lower case.
    /// If true, case sensitivity will be used when comparing usernames and groups for matching policies.
    /// </summary>
    [JsonPropertyName("caseSensitiveNames")]
    public bool? CaseSensitiveNames { get; set; }

    /// <summary>
    /// CA certificate to use when verifying LDAP server certificate, must be
    /// x509 PEM encoded.
    /// CA certificate to use when verifying LDAP server certificate, must be x509 PEM encoded.
    /// </summary>
    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    /// <summary>
    /// Client certificate to provide to the LDAP server, must be x509 PEM encoded.
    /// Client certificate to provide to the LDAP server, must be x509 PEM encoded.
    /// </summary>
    [JsonPropertyName("clientTlsCertSecretRef")]
    public V1alpha1SecretBackendSpecInitProviderClientTlsCertSecretRef? ClientTlsCertSecretRef { get; set; }

    /// <summary>
    /// Client certificate key to provide to the LDAP server, must be x509 PEM encoded.
    /// Client certificate key to provide to the LDAP server, must be x509 PEM encoded.
    /// </summary>
    [JsonPropertyName("clientTlsKeySecretRef")]
    public V1alpha1SecretBackendSpecInitProviderClientTlsKeySecretRef? ClientTlsKeySecretRef { get; set; }

    /// <summary>
    /// Default lease duration for secrets in seconds.
    /// Default lease duration for secrets in seconds
    /// </summary>
    [JsonPropertyName("defaultLeaseTtlSeconds")]
    public double? DefaultLeaseTtlSeconds { get; set; }

    /// <summary>
    /// Denies an unauthenticated LDAP bind request if the user&apos;s password is empty;
    /// defaults to true.
    /// Denies an unauthenticated LDAP bind request if the user&apos;s password is empty; defaults to true
    /// </summary>
    [JsonPropertyName("denyNullBind")]
    public bool? DenyNullBind { get; set; }

    /// <summary>
    /// Human-friendly description of the mount for the Active Directory backend.
    /// Human-friendly description of the mount for the backend.
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
    /// Use anonymous bind to discover the bind Distinguished Name of a user.
    /// Use anonymous bind to discover the bind DN of a user.
    /// </summary>
    [JsonPropertyName("discoverdn")]
    public bool? Discoverdn { get; set; }

    /// <summary>
    /// LDAP attribute to follow on objects returned by  in order to enumerate
    /// user group membership. Examples: cn or memberOf, etc. Defaults to cn.
    /// LDAP attribute to follow on objects returned by &lt;groupfilter&gt; in order to enumerate user group membership. Examples: &quot;cn&quot; or &quot;memberOf&quot;, etc. Default: cn
    /// </summary>
    [JsonPropertyName("groupattr")]
    public string? Groupattr { get; set; }

    /// <summary>
    /// LDAP search base to use for group membership search (eg: ou=Groups,dc=example,dc=org).
    /// LDAP search base to use for group membership search (eg: ou=Groups,dc=example,dc=org)
    /// </summary>
    [JsonPropertyName("groupdn")]
    public string? Groupdn { get; set; }

    /// <summary>
    /// Go template for querying group membership of user  The template can access
    /// the following context variables: UserDN, Username. Defaults to (|(memberUid={{.Username}})(member={{.UserDN}})(uniqueMember={{.UserDN}}))
    /// Go template for querying group membership of user. The template can access the following context variables: UserDN, Username Example: (&amp;(objectClass=group)(member:1.2.840.113556.1.4.1941:={{.UserDN}})) Default: (|(memberUid={{.Username}})(member={{.UserDN}})(uniqueMember={{.UserDN}}))
    /// </summary>
    [JsonPropertyName("groupfilter")]
    public string? Groupfilter { get; set; }

    /// <summary>
    /// Skip LDAP server SSL Certificate verification. This is not recommended for production.
    /// Defaults to false.
    /// Skip LDAP server SSL Certificate verification - insecure and not recommended for production use.
    /// </summary>
    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>
    /// The number of seconds after a Vault rotation where, if Active Directory
    /// shows a later rotation, it should be considered out-of-band
    /// The number of seconds after a Vault rotation where, if Active Directory shows a later rotation, it should be considered out-of-band.
    /// </summary>
    [JsonPropertyName("lastRotationTolerance")]
    public double? LastRotationTolerance { get; set; }

    /// <summary>
    /// Mark the secrets engine as local-only. Local engines are not replicated or removed by
    /// replication.Tolerance duration to use when checking the last rotation time.
    /// Mark the secrets engine as local-only. Local engines are not replicated or removed by replication.Tolerance duration to use when checking the last rotation time.
    /// </summary>
    [JsonPropertyName("local")]
    public bool? Local { get; set; }

    /// <summary>
    /// Maximum possible lease duration for secrets in seconds.
    /// Maximum possible lease duration for secrets in seconds.
    /// </summary>
    [JsonPropertyName("maxLeaseTtlSeconds")]
    public double? MaxLeaseTtlSeconds { get; set; }

    /// <summary>
    /// In seconds, the maximum password time-to-live.
    /// In seconds, the maximum password time-to-live.
    /// </summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

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
    /// Name of the password policy to use to generate passwords.
    /// Name of the password policy to use to generate passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// Timeout, in seconds, for the connection when making requests against the server
    /// before returning back an error.
    /// Timeout, in seconds, for the connection when making requests against the server before returning back an error.
    /// </summary>
    [JsonPropertyName("requestTimeout")]
    public double? RequestTimeout { get; set; }

    /// <summary>
    /// Issue a StartTLS command after establishing unencrypted connection.
    /// Issue a StartTLS command after establishing unencrypted connection.
    /// </summary>
    [JsonPropertyName("starttls")]
    public bool? Starttls { get; set; }

    /// <summary>
    /// Maximum TLS version to use. Accepted values are tls10, tls11,
    /// tls12 or tls13. Defaults to tls12.
    /// Maximum TLS version to use. Accepted values are &apos;tls10&apos;, &apos;tls11&apos;, &apos;tls12&apos; or &apos;tls13&apos;. Defaults to &apos;tls12&apos;
    /// </summary>
    [JsonPropertyName("tlsMaxVersion")]
    public string? TlsMaxVersion { get; set; }

    /// <summary>
    /// Minimum TLS version to use. Accepted values are tls10, tls11,
    /// tls12 or tls13. Defaults to tls12.
    /// Minimum TLS version to use. Accepted values are &apos;tls10&apos;, &apos;tls11&apos;, &apos;tls12&apos; or &apos;tls13&apos;. Defaults to &apos;tls12&apos;
    /// </summary>
    [JsonPropertyName("tlsMinVersion")]
    public string? TlsMinVersion { get; set; }

    /// <summary>
    /// In seconds, the default password time-to-live.
    /// In seconds, the default password time-to-live.
    /// </summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>
    /// Enables userPrincipalDomain login with [username]@UPNDomain.
    /// Enables userPrincipalDomain login with [username]@UPNDomain.
    /// </summary>
    [JsonPropertyName("upndomain")]
    public string? Upndomain { get; set; }

    /// <summary>
    /// LDAP URL to connect to. Multiple URLs can be specified by concatenating
    /// them with commas; they will be tried in-order. Defaults to ldap://127.0.0.1.
    /// LDAP URL to connect to (default: ldap://127.0.0.1). Multiple URLs can be specified by concatenating them with commas; they will be tried in-order.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// In Vault 1.1.1 a fix for handling group CN values of
    /// different cases unfortunately introduced a regression that could cause previously defined groups
    /// to not be found due to a change in the resulting name. If set true, the pre-1.1.1 behavior for
    /// matching group CNs will be used. This is only needed in some upgrade scenarios for backwards
    /// compatibility. It is enabled by default if the config is upgraded but disabled by default on
    /// new configurations.
    /// In Vault 1.1.1 a fix for handling group CN values of different cases unfortunately introduced a regression that could cause previously defined groups to not be found due to a change in the resulting name. If set true, the pre-1.1.1 behavior for matching group CNs will be used. This is only needed in some upgrade scenarios for backwards compatibility. It is enabled by default if the config is upgraded but disabled by default on new configurations.
    /// </summary>
    [JsonPropertyName("usePre111GroupCnBehavior")]
    public bool? UsePre111GroupCnBehavior { get; set; }

    /// <summary>
    /// If true, use the Active Directory tokenGroups constructed attribute of the
    /// user to find the group memberships. This will find all security groups including nested ones.
    /// If true, use the Active Directory tokenGroups constructed attribute of the user to find the group memberships. This will find all security groups including nested ones.
    /// </summary>
    [JsonPropertyName("useTokenGroups")]
    public bool? UseTokenGroups { get; set; }

    /// <summary>
    /// Attribute used when searching users. Defaults to cn.
    /// Attribute used for users (default: cn)
    /// </summary>
    [JsonPropertyName("userattr")]
    public string? Userattr { get; set; }

    /// <summary>
    /// LDAP domain to use for users (eg: ou=People,dc=example,dc=org)`.
    /// LDAP domain to use for users (eg: ou=People,dc=example,dc=org)
    /// </summary>
    [JsonPropertyName("userdn")]
    public string? Userdn { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendSpecManagementPoliciesEnum>))]
public enum V1alpha1SecretBackendSpecManagementPoliciesEnum
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
public partial class V1alpha1SecretBackendSpecProviderConfigRef
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
public partial class V1alpha1SecretBackendSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>SecretBackendSpec defines the desired state of SecretBackend</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpec
{
    [JsonPropertyName("forProvider")]
    public required V1alpha1SecretBackendSpecForProvider ForProvider { get; set; }

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
    public V1alpha1SecretBackendSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1alpha1SecretBackendSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SecretBackendSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SecretBackendSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStatusAtProvider
{
    /// <summary>
    /// Use anonymous binds when performing LDAP group searches
    /// (if true the initial credentials will still be used for the initial connection test).
    /// Use anonymous binds when performing LDAP group searches (if true the initial credentials will still be used for the initial connection test).
    /// </summary>
    [JsonPropertyName("anonymousGroupSearch")]
    public bool? AnonymousGroupSearch { get; set; }

    /// <summary>
    /// The unique path this backend should be mounted at. Must
    /// not begin or end with a /. Defaults to ad.
    /// The mount path for a backend, for example, the path given in &quot;$ vault auth enable -path=my-ad ad&quot;.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>
    /// Distinguished name of object to bind when performing user and group search.
    /// Distinguished name of object to bind when performing user and group search.
    /// </summary>
    [JsonPropertyName("binddn")]
    public string? Binddn { get; set; }

    /// <summary>
    /// If set, user and group names assigned to policies within the
    /// backend will be case sensitive. Otherwise, names will be normalized to lower case.
    /// If true, case sensitivity will be used when comparing usernames and groups for matching policies.
    /// </summary>
    [JsonPropertyName("caseSensitiveNames")]
    public bool? CaseSensitiveNames { get; set; }

    /// <summary>
    /// CA certificate to use when verifying LDAP server certificate, must be
    /// x509 PEM encoded.
    /// CA certificate to use when verifying LDAP server certificate, must be x509 PEM encoded.
    /// </summary>
    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    /// <summary>
    /// Default lease duration for secrets in seconds.
    /// Default lease duration for secrets in seconds
    /// </summary>
    [JsonPropertyName("defaultLeaseTtlSeconds")]
    public double? DefaultLeaseTtlSeconds { get; set; }

    /// <summary>
    /// Denies an unauthenticated LDAP bind request if the user&apos;s password is empty;
    /// defaults to true.
    /// Denies an unauthenticated LDAP bind request if the user&apos;s password is empty; defaults to true
    /// </summary>
    [JsonPropertyName("denyNullBind")]
    public bool? DenyNullBind { get; set; }

    /// <summary>
    /// Human-friendly description of the mount for the Active Directory backend.
    /// Human-friendly description of the mount for the backend.
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
    /// Use anonymous bind to discover the bind Distinguished Name of a user.
    /// Use anonymous bind to discover the bind DN of a user.
    /// </summary>
    [JsonPropertyName("discoverdn")]
    public bool? Discoverdn { get; set; }

    /// <summary>
    /// LDAP attribute to follow on objects returned by  in order to enumerate
    /// user group membership. Examples: cn or memberOf, etc. Defaults to cn.
    /// LDAP attribute to follow on objects returned by &lt;groupfilter&gt; in order to enumerate user group membership. Examples: &quot;cn&quot; or &quot;memberOf&quot;, etc. Default: cn
    /// </summary>
    [JsonPropertyName("groupattr")]
    public string? Groupattr { get; set; }

    /// <summary>
    /// LDAP search base to use for group membership search (eg: ou=Groups,dc=example,dc=org).
    /// LDAP search base to use for group membership search (eg: ou=Groups,dc=example,dc=org)
    /// </summary>
    [JsonPropertyName("groupdn")]
    public string? Groupdn { get; set; }

    /// <summary>
    /// Go template for querying group membership of user  The template can access
    /// the following context variables: UserDN, Username. Defaults to (|(memberUid={{.Username}})(member={{.UserDN}})(uniqueMember={{.UserDN}}))
    /// Go template for querying group membership of user. The template can access the following context variables: UserDN, Username Example: (&amp;(objectClass=group)(member:1.2.840.113556.1.4.1941:={{.UserDN}})) Default: (|(memberUid={{.Username}})(member={{.UserDN}})(uniqueMember={{.UserDN}}))
    /// </summary>
    [JsonPropertyName("groupfilter")]
    public string? Groupfilter { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Skip LDAP server SSL Certificate verification. This is not recommended for production.
    /// Defaults to false.
    /// Skip LDAP server SSL Certificate verification - insecure and not recommended for production use.
    /// </summary>
    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>
    /// The number of seconds after a Vault rotation where, if Active Directory
    /// shows a later rotation, it should be considered out-of-band
    /// The number of seconds after a Vault rotation where, if Active Directory shows a later rotation, it should be considered out-of-band.
    /// </summary>
    [JsonPropertyName("lastRotationTolerance")]
    public double? LastRotationTolerance { get; set; }

    /// <summary>
    /// Mark the secrets engine as local-only. Local engines are not replicated or removed by
    /// replication.Tolerance duration to use when checking the last rotation time.
    /// Mark the secrets engine as local-only. Local engines are not replicated or removed by replication.Tolerance duration to use when checking the last rotation time.
    /// </summary>
    [JsonPropertyName("local")]
    public bool? Local { get; set; }

    /// <summary>
    /// Maximum possible lease duration for secrets in seconds.
    /// Maximum possible lease duration for secrets in seconds.
    /// </summary>
    [JsonPropertyName("maxLeaseTtlSeconds")]
    public double? MaxLeaseTtlSeconds { get; set; }

    /// <summary>
    /// In seconds, the maximum password time-to-live.
    /// In seconds, the maximum password time-to-live.
    /// </summary>
    [JsonPropertyName("maxTtl")]
    public double? MaxTtl { get; set; }

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
    /// Name of the password policy to use to generate passwords.
    /// Name of the password policy to use to generate passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// Timeout, in seconds, for the connection when making requests against the server
    /// before returning back an error.
    /// Timeout, in seconds, for the connection when making requests against the server before returning back an error.
    /// </summary>
    [JsonPropertyName("requestTimeout")]
    public double? RequestTimeout { get; set; }

    /// <summary>
    /// Issue a StartTLS command after establishing unencrypted connection.
    /// Issue a StartTLS command after establishing unencrypted connection.
    /// </summary>
    [JsonPropertyName("starttls")]
    public bool? Starttls { get; set; }

    /// <summary>
    /// Maximum TLS version to use. Accepted values are tls10, tls11,
    /// tls12 or tls13. Defaults to tls12.
    /// Maximum TLS version to use. Accepted values are &apos;tls10&apos;, &apos;tls11&apos;, &apos;tls12&apos; or &apos;tls13&apos;. Defaults to &apos;tls12&apos;
    /// </summary>
    [JsonPropertyName("tlsMaxVersion")]
    public string? TlsMaxVersion { get; set; }

    /// <summary>
    /// Minimum TLS version to use. Accepted values are tls10, tls11,
    /// tls12 or tls13. Defaults to tls12.
    /// Minimum TLS version to use. Accepted values are &apos;tls10&apos;, &apos;tls11&apos;, &apos;tls12&apos; or &apos;tls13&apos;. Defaults to &apos;tls12&apos;
    /// </summary>
    [JsonPropertyName("tlsMinVersion")]
    public string? TlsMinVersion { get; set; }

    /// <summary>
    /// In seconds, the default password time-to-live.
    /// In seconds, the default password time-to-live.
    /// </summary>
    [JsonPropertyName("ttl")]
    public double? Ttl { get; set; }

    /// <summary>
    /// Enables userPrincipalDomain login with [username]@UPNDomain.
    /// Enables userPrincipalDomain login with [username]@UPNDomain.
    /// </summary>
    [JsonPropertyName("upndomain")]
    public string? Upndomain { get; set; }

    /// <summary>
    /// LDAP URL to connect to. Multiple URLs can be specified by concatenating
    /// them with commas; they will be tried in-order. Defaults to ldap://127.0.0.1.
    /// LDAP URL to connect to (default: ldap://127.0.0.1). Multiple URLs can be specified by concatenating them with commas; they will be tried in-order.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// In Vault 1.1.1 a fix for handling group CN values of
    /// different cases unfortunately introduced a regression that could cause previously defined groups
    /// to not be found due to a change in the resulting name. If set true, the pre-1.1.1 behavior for
    /// matching group CNs will be used. This is only needed in some upgrade scenarios for backwards
    /// compatibility. It is enabled by default if the config is upgraded but disabled by default on
    /// new configurations.
    /// In Vault 1.1.1 a fix for handling group CN values of different cases unfortunately introduced a regression that could cause previously defined groups to not be found due to a change in the resulting name. If set true, the pre-1.1.1 behavior for matching group CNs will be used. This is only needed in some upgrade scenarios for backwards compatibility. It is enabled by default if the config is upgraded but disabled by default on new configurations.
    /// </summary>
    [JsonPropertyName("usePre111GroupCnBehavior")]
    public bool? UsePre111GroupCnBehavior { get; set; }

    /// <summary>
    /// If true, use the Active Directory tokenGroups constructed attribute of the
    /// user to find the group memberships. This will find all security groups including nested ones.
    /// If true, use the Active Directory tokenGroups constructed attribute of the user to find the group memberships. This will find all security groups including nested ones.
    /// </summary>
    [JsonPropertyName("useTokenGroups")]
    public bool? UseTokenGroups { get; set; }

    /// <summary>
    /// Attribute used when searching users. Defaults to cn.
    /// Attribute used for users (default: cn)
    /// </summary>
    [JsonPropertyName("userattr")]
    public string? Userattr { get; set; }

    /// <summary>
    /// LDAP domain to use for users (eg: ou=People,dc=example,dc=org)`.
    /// LDAP domain to use for users (eg: ou=People,dc=example,dc=org)
    /// </summary>
    [JsonPropertyName("userdn")]
    public string? Userdn { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStatusConditions
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

/// <summary>SecretBackendStatus defines the observed state of SecretBackend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1SecretBackendStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecretBackendStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SecretBackend is the Schema for the SecretBackends API. Creates an Active Directory secret backend for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackend : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretBackendSpec>, IStatus<V1alpha1SecretBackendStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackend";
    public const string KubeGroup = "ad.vault.m.upbound.io";
    public const string KubePluralName = "secretbackends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ad.vault.m.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackend";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretBackendSpec defines the desired state of SecretBackend</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SecretBackendSpec Spec { get; set; }

    /// <summary>SecretBackendStatus defines the observed state of SecretBackend.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecretBackendStatus? Status { get; set; }
}