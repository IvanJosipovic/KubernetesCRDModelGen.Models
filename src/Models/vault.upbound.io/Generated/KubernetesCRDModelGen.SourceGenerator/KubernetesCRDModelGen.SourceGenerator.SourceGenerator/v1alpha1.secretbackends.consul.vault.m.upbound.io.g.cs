#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.consul.vault.m.upbound.io;
/// <summary>SecretBackend is the Schema for the SecretBackends API. Creates a Consul secret backend for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecretBackend>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendList";
    public const string KubeGroup = "consul.vault.m.upbound.io";
    public const string KubePluralName = "secretbackends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "consul.vault.m.upbound.io/v1alpha1";

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
/// Client certificate used for Consul&apos;s TLS communication, must be x509 PEM encoded and if
/// this is set you need to also set client_key.
/// Client certificate used for Consul&apos;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_key.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpecForProviderClientCertSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Client key used for Consul&apos;s TLS communication, must be x509 PEM encoded and if this is set
/// you need to also set client_cert. Mutually exclusive with client_key_wo. Consider using client_key_wo instead for enhanced security.
/// Client key used for Consul&apos;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_cert. Mutually exclusive with &apos;client_key_wo&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpecForProviderClientKeySecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Client key used for Consul&apos;s TLS communication, must be x509 PEM encoded, provided as a
/// write-only field. Mutually exclusive with client_key. Must be
/// used with client_key_wo_version.
/// Client key used for Consul&apos;s TLS communication, must be x509 PEM encoded. This field is write-only and will never be stored in state. Mutually exclusive with &apos;client_key&apos;. Requires &apos;client_key_wo_version&apos; to trigger updates.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpecForProviderClientKeyWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// The Consul management token this backend should use to issue new tokens. This field is required
/// when bootstrap is false. Mutually exclusive with token_wo.
/// Consider using token_wo instead for enhanced security.
/// Specifies the Consul token to use when managing or issuing new tokens. Mutually exclusive with &apos;token_wo&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpecForProviderTokenSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// The Consul management token this backend should use to issue new tokens, provided as a
/// write-only field. Mutually exclusive with token. Must be
/// used with token_wo_version.
/// Specifies the Consul token to use when managing or issuing new tokens. This field is write-only and will never be stored in state. Mutually exclusive with &apos;token&apos;. Requires &apos;token_wo_version&apos; to trigger updates.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpecForProviderTokenWoSecretRef
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
    /// Specifies the address of the Consul instance, provided as &quot;host:port&quot; like &quot;127.0.0.1:8500&quot;.
    /// Specifies the address of the Consul instance, provided as &quot;host:port&quot; like &quot;127.0.0.1:8500&quot;.
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// Set of managed key registry entry names that the mount in question is allowed to access
    /// List of managed key registry entry names that the mount in question is allowed to access
    /// </summary>
    [JsonPropertyName("allowedManagedKeys")]
    public IList<string>? AllowedManagedKeys { get; set; }

    /// <summary>
    /// List of headers to allow, allowing a plugin to include
    /// them in the response.
    /// List of headers to allow and pass from the request to the plugin
    /// </summary>
    [JsonPropertyName("allowedResponseHeaders")]
    public IList<string>? AllowedResponseHeaders { get; set; }

    /// <summary>
    /// Specifies the list of keys that will not be HMAC&apos;d by audit devices in the request data object.
    /// Specifies the list of keys that will not be HMAC&apos;d by audit devices in the request data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacRequestKeys")]
    public IList<string>? AuditNonHmacRequestKeys { get; set; }

    /// <summary>
    /// Specifies the list of keys that will not be HMAC&apos;d by audit devices in the response data object.
    /// Specifies the list of keys that will not be HMAC&apos;d by audit devices in the response data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacResponseKeys")]
    public IList<string>? AuditNonHmacResponseKeys { get; set; }

    /// <summary>
    /// Denotes that the resource is used to bootstrap the Consul ACL system.
    /// Denotes a backend resource that is used to bootstrap the Consul ACL system. Only one resource may be used to bootstrap.
    /// </summary>
    [JsonPropertyName("bootstrap")]
    public bool? Bootstrap { get; set; }

    /// <summary>
    /// CA certificate to use when verifying Consul server certificate, must be x509 PEM encoded.
    /// CA certificate to use when verifying Consul server certificate, must be x509 PEM encoded.
    /// </summary>
    [JsonPropertyName("caCert")]
    public string? CaCert { get; set; }

    /// <summary>
    /// Client certificate used for Consul&apos;s TLS communication, must be x509 PEM encoded and if
    /// this is set you need to also set client_key.
    /// Client certificate used for Consul&apos;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_key.
    /// </summary>
    [JsonPropertyName("clientCertSecretRef")]
    public V1alpha1SecretBackendSpecForProviderClientCertSecretRef? ClientCertSecretRef { get; set; }

    /// <summary>
    /// Client key used for Consul&apos;s TLS communication, must be x509 PEM encoded and if this is set
    /// you need to also set client_cert. Mutually exclusive with client_key_wo. Consider using client_key_wo instead for enhanced security.
    /// Client key used for Consul&apos;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_cert. Mutually exclusive with &apos;client_key_wo&apos;.
    /// </summary>
    [JsonPropertyName("clientKeySecretRef")]
    public V1alpha1SecretBackendSpecForProviderClientKeySecretRef? ClientKeySecretRef { get; set; }

    /// <summary>
    /// Client key used for Consul&apos;s TLS communication, must be x509 PEM encoded, provided as a
    /// write-only field. Mutually exclusive with client_key. Must be
    /// used with client_key_wo_version.
    /// Client key used for Consul&apos;s TLS communication, must be x509 PEM encoded. This field is write-only and will never be stored in state. Mutually exclusive with &apos;client_key&apos;. Requires &apos;client_key_wo_version&apos; to trigger updates.
    /// </summary>
    [JsonPropertyName("clientKeyWoSecretRef")]
    public V1alpha1SecretBackendSpecForProviderClientKeyWoSecretRef? ClientKeyWoSecretRef { get; set; }

    /// <summary>
    /// Version counter for the write-only client key. Increment this value to trigger
    /// an update of the client key in Vault. Required when using client_key_wo.
    /// Version counter for the write-only client key. Increment this value to trigger rotation of the client key. Required when using &apos;client_key_wo&apos;.
    /// </summary>
    [JsonPropertyName("clientKeyWoVersion")]
    public double? ClientKeyWoVersion { get; set; }

    /// <summary>
    /// Default lease duration for tokens and secrets in seconds
    /// Default lease duration for secrets in seconds
    /// </summary>
    [JsonPropertyName("defaultLeaseTtlSeconds")]
    public double? DefaultLeaseTtlSeconds { get; set; }

    /// <summary>
    /// List of allowed authentication mount accessors the
    /// backend can request delegated authentication for.
    /// List of headers to allow and pass from the request to the plugin
    /// </summary>
    [JsonPropertyName("delegatedAuthAccessors")]
    public IList<string>? DelegatedAuthAccessors { get; set; }

    /// <summary>
    /// A human-friendly description for this backend.
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
    /// Boolean flag that can be explicitly set to true to enable the secrets engine to access Vault&apos;s external entropy source
    /// Enable the secrets engine to access Vault&apos;s external entropy source
    /// </summary>
    [JsonPropertyName("externalEntropyAccess")]
    public bool? ExternalEntropyAccess { get; set; }

    /// <summary>If set to true, disables caching.</summary>
    [JsonPropertyName("forceNoCache")]
    public bool? ForceNoCache { get; set; }

    /// <summary>
    /// The key to use for signing plugin workload identity tokens. If
    /// not provided, this will default to Vault&apos;s OIDC default key. Requires Vault Enterprise 1.16+.
    /// The key to use for signing plugin workload identity tokens
    /// </summary>
    [JsonPropertyName("identityTokenKey")]
    public string? IdentityTokenKey { get; set; }

    /// <summary>
    /// Specifies whether to show this mount in the UI-specific
    /// listing endpoint. Valid values are unauth or hidden. If not set, behaves like hidden.
    /// Specifies whether to show this mount in the UI-specific listing endpoint
    /// </summary>
    [JsonPropertyName("listingVisibility")]
    public string? ListingVisibility { get; set; }

    /// <summary>
    /// Boolean flag that can be explicitly set to true to enforce local mount in HA environment
    /// Specifies if the secret backend is local only
    /// </summary>
    [JsonPropertyName("local")]
    public bool? Local { get; set; }

    /// <summary>
    /// Maximum possible lease duration for tokens and secrets in seconds
    /// Maximum possible lease duration for secrets in seconds
    /// </summary>
    [JsonPropertyName("maxLeaseTtlSeconds")]
    public double? MaxLeaseTtlSeconds { get; set; }

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
    /// Specifies mount type specific options that are passed to the backend
    /// Specifies mount type specific options that are passed to the backend
    /// </summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    /// <summary>
    /// List of headers to allow and pass from the request to
    /// the plugin.
    /// List of headers to allow and pass from the request to the plugin
    /// </summary>
    [JsonPropertyName("passthroughRequestHeaders")]
    public IList<string>? PassthroughRequestHeaders { get; set; }

    /// <summary>
    /// The unique location this backend should be mounted at. Must not begin or end with a /. Defaults
    /// to consul.
    /// Unique name of the Vault Consul mount to configure
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use, e.g. &quot;v1.0.0&quot;.
    /// If unspecified, the server will select any matching unversioned plugin that may have been
    /// registered, the latest versioned plugin registered, or a built-in plugin in that order of precedence.
    /// Specifies the semantic version of the plugin to use, e.g. &apos;v1.0.0&apos;
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// Specifies the URL scheme to use. Defaults to http.
    /// Specifies the URL scheme to use. Defaults to &quot;http&quot;.
    /// </summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>
    /// Boolean flag that can be explicitly set to true to enable seal wrapping for the mount, causing values stored by the mount to be wrapped by the seal&apos;s encryption capability
    /// Enable seal wrapping for the mount, causing values stored by the mount to be wrapped by the seal&apos;s encryption capability
    /// </summary>
    [JsonPropertyName("sealWrap")]
    public bool? SealWrap { get; set; }

    /// <summary>
    /// The Consul management token this backend should use to issue new tokens. This field is required
    /// when bootstrap is false. Mutually exclusive with token_wo.
    /// Consider using token_wo instead for enhanced security.
    /// Specifies the Consul token to use when managing or issuing new tokens. Mutually exclusive with &apos;token_wo&apos;.
    /// </summary>
    [JsonPropertyName("tokenSecretRef")]
    public V1alpha1SecretBackendSpecForProviderTokenSecretRef? TokenSecretRef { get; set; }

    /// <summary>
    /// The Consul management token this backend should use to issue new tokens, provided as a
    /// write-only field. Mutually exclusive with token. Must be
    /// used with token_wo_version.
    /// Specifies the Consul token to use when managing or issuing new tokens. This field is write-only and will never be stored in state. Mutually exclusive with &apos;token&apos;. Requires &apos;token_wo_version&apos; to trigger updates.
    /// </summary>
    [JsonPropertyName("tokenWoSecretRef")]
    public V1alpha1SecretBackendSpecForProviderTokenWoSecretRef? TokenWoSecretRef { get; set; }

    /// <summary>
    /// Version counter for the write-only token. Increment this value to trigger an update
    /// of the token in Vault. Required when using token_wo.
    /// Version counter for the write-only token. Increment this value to trigger rotation of the token. Required when using &apos;token_wo&apos;.
    /// </summary>
    [JsonPropertyName("tokenWoVersion")]
    public double? TokenWoVersion { get; set; }
}

/// <summary>
/// Client certificate used for Consul&apos;s TLS communication, must be x509 PEM encoded and if
/// this is set you need to also set client_key.
/// Client certificate used for Consul&apos;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_key.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpecInitProviderClientCertSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Client key used for Consul&apos;s TLS communication, must be x509 PEM encoded and if this is set
/// you need to also set client_cert. Mutually exclusive with client_key_wo. Consider using client_key_wo instead for enhanced security.
/// Client key used for Consul&apos;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_cert. Mutually exclusive with &apos;client_key_wo&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpecInitProviderClientKeySecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Client key used for Consul&apos;s TLS communication, must be x509 PEM encoded, provided as a
/// write-only field. Mutually exclusive with client_key. Must be
/// used with client_key_wo_version.
/// Client key used for Consul&apos;s TLS communication, must be x509 PEM encoded. This field is write-only and will never be stored in state. Mutually exclusive with &apos;client_key&apos;. Requires &apos;client_key_wo_version&apos; to trigger updates.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpecInitProviderClientKeyWoSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// The Consul management token this backend should use to issue new tokens. This field is required
/// when bootstrap is false. Mutually exclusive with token_wo.
/// Consider using token_wo instead for enhanced security.
/// Specifies the Consul token to use when managing or issuing new tokens. Mutually exclusive with &apos;token_wo&apos;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpecInitProviderTokenSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// The Consul management token this backend should use to issue new tokens, provided as a
/// write-only field. Mutually exclusive with token. Must be
/// used with token_wo_version.
/// Specifies the Consul token to use when managing or issuing new tokens. This field is write-only and will never be stored in state. Mutually exclusive with &apos;token&apos;. Requires &apos;token_wo_version&apos; to trigger updates.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendSpecInitProviderTokenWoSecretRef
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
    /// Specifies the address of the Consul instance, provided as &quot;host:port&quot; like &quot;127.0.0.1:8500&quot;.
    /// Specifies the address of the Consul instance, provided as &quot;host:port&quot; like &quot;127.0.0.1:8500&quot;.
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// Set of managed key registry entry names that the mount in question is allowed to access
    /// List of managed key registry entry names that the mount in question is allowed to access
    /// </summary>
    [JsonPropertyName("allowedManagedKeys")]
    public IList<string>? AllowedManagedKeys { get; set; }

    /// <summary>
    /// List of headers to allow, allowing a plugin to include
    /// them in the response.
    /// List of headers to allow and pass from the request to the plugin
    /// </summary>
    [JsonPropertyName("allowedResponseHeaders")]
    public IList<string>? AllowedResponseHeaders { get; set; }

    /// <summary>
    /// Specifies the list of keys that will not be HMAC&apos;d by audit devices in the request data object.
    /// Specifies the list of keys that will not be HMAC&apos;d by audit devices in the request data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacRequestKeys")]
    public IList<string>? AuditNonHmacRequestKeys { get; set; }

    /// <summary>
    /// Specifies the list of keys that will not be HMAC&apos;d by audit devices in the response data object.
    /// Specifies the list of keys that will not be HMAC&apos;d by audit devices in the response data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacResponseKeys")]
    public IList<string>? AuditNonHmacResponseKeys { get; set; }

    /// <summary>
    /// Denotes that the resource is used to bootstrap the Consul ACL system.
    /// Denotes a backend resource that is used to bootstrap the Consul ACL system. Only one resource may be used to bootstrap.
    /// </summary>
    [JsonPropertyName("bootstrap")]
    public bool? Bootstrap { get; set; }

    /// <summary>
    /// CA certificate to use when verifying Consul server certificate, must be x509 PEM encoded.
    /// CA certificate to use when verifying Consul server certificate, must be x509 PEM encoded.
    /// </summary>
    [JsonPropertyName("caCert")]
    public string? CaCert { get; set; }

    /// <summary>
    /// Client certificate used for Consul&apos;s TLS communication, must be x509 PEM encoded and if
    /// this is set you need to also set client_key.
    /// Client certificate used for Consul&apos;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_key.
    /// </summary>
    [JsonPropertyName("clientCertSecretRef")]
    public V1alpha1SecretBackendSpecInitProviderClientCertSecretRef? ClientCertSecretRef { get; set; }

    /// <summary>
    /// Client key used for Consul&apos;s TLS communication, must be x509 PEM encoded and if this is set
    /// you need to also set client_cert. Mutually exclusive with client_key_wo. Consider using client_key_wo instead for enhanced security.
    /// Client key used for Consul&apos;s TLS communication, must be x509 PEM encoded and if this is set you need to also set client_cert. Mutually exclusive with &apos;client_key_wo&apos;.
    /// </summary>
    [JsonPropertyName("clientKeySecretRef")]
    public V1alpha1SecretBackendSpecInitProviderClientKeySecretRef? ClientKeySecretRef { get; set; }

    /// <summary>
    /// Client key used for Consul&apos;s TLS communication, must be x509 PEM encoded, provided as a
    /// write-only field. Mutually exclusive with client_key. Must be
    /// used with client_key_wo_version.
    /// Client key used for Consul&apos;s TLS communication, must be x509 PEM encoded. This field is write-only and will never be stored in state. Mutually exclusive with &apos;client_key&apos;. Requires &apos;client_key_wo_version&apos; to trigger updates.
    /// </summary>
    [JsonPropertyName("clientKeyWoSecretRef")]
    public V1alpha1SecretBackendSpecInitProviderClientKeyWoSecretRef? ClientKeyWoSecretRef { get; set; }

    /// <summary>
    /// Version counter for the write-only client key. Increment this value to trigger
    /// an update of the client key in Vault. Required when using client_key_wo.
    /// Version counter for the write-only client key. Increment this value to trigger rotation of the client key. Required when using &apos;client_key_wo&apos;.
    /// </summary>
    [JsonPropertyName("clientKeyWoVersion")]
    public double? ClientKeyWoVersion { get; set; }

    /// <summary>
    /// Default lease duration for tokens and secrets in seconds
    /// Default lease duration for secrets in seconds
    /// </summary>
    [JsonPropertyName("defaultLeaseTtlSeconds")]
    public double? DefaultLeaseTtlSeconds { get; set; }

    /// <summary>
    /// List of allowed authentication mount accessors the
    /// backend can request delegated authentication for.
    /// List of headers to allow and pass from the request to the plugin
    /// </summary>
    [JsonPropertyName("delegatedAuthAccessors")]
    public IList<string>? DelegatedAuthAccessors { get; set; }

    /// <summary>
    /// A human-friendly description for this backend.
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
    /// Boolean flag that can be explicitly set to true to enable the secrets engine to access Vault&apos;s external entropy source
    /// Enable the secrets engine to access Vault&apos;s external entropy source
    /// </summary>
    [JsonPropertyName("externalEntropyAccess")]
    public bool? ExternalEntropyAccess { get; set; }

    /// <summary>If set to true, disables caching.</summary>
    [JsonPropertyName("forceNoCache")]
    public bool? ForceNoCache { get; set; }

    /// <summary>
    /// The key to use for signing plugin workload identity tokens. If
    /// not provided, this will default to Vault&apos;s OIDC default key. Requires Vault Enterprise 1.16+.
    /// The key to use for signing plugin workload identity tokens
    /// </summary>
    [JsonPropertyName("identityTokenKey")]
    public string? IdentityTokenKey { get; set; }

    /// <summary>
    /// Specifies whether to show this mount in the UI-specific
    /// listing endpoint. Valid values are unauth or hidden. If not set, behaves like hidden.
    /// Specifies whether to show this mount in the UI-specific listing endpoint
    /// </summary>
    [JsonPropertyName("listingVisibility")]
    public string? ListingVisibility { get; set; }

    /// <summary>
    /// Boolean flag that can be explicitly set to true to enforce local mount in HA environment
    /// Specifies if the secret backend is local only
    /// </summary>
    [JsonPropertyName("local")]
    public bool? Local { get; set; }

    /// <summary>
    /// Maximum possible lease duration for tokens and secrets in seconds
    /// Maximum possible lease duration for secrets in seconds
    /// </summary>
    [JsonPropertyName("maxLeaseTtlSeconds")]
    public double? MaxLeaseTtlSeconds { get; set; }

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
    /// Specifies mount type specific options that are passed to the backend
    /// Specifies mount type specific options that are passed to the backend
    /// </summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    /// <summary>
    /// List of headers to allow and pass from the request to
    /// the plugin.
    /// List of headers to allow and pass from the request to the plugin
    /// </summary>
    [JsonPropertyName("passthroughRequestHeaders")]
    public IList<string>? PassthroughRequestHeaders { get; set; }

    /// <summary>
    /// The unique location this backend should be mounted at. Must not begin or end with a /. Defaults
    /// to consul.
    /// Unique name of the Vault Consul mount to configure
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use, e.g. &quot;v1.0.0&quot;.
    /// If unspecified, the server will select any matching unversioned plugin that may have been
    /// registered, the latest versioned plugin registered, or a built-in plugin in that order of precedence.
    /// Specifies the semantic version of the plugin to use, e.g. &apos;v1.0.0&apos;
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// Specifies the URL scheme to use. Defaults to http.
    /// Specifies the URL scheme to use. Defaults to &quot;http&quot;.
    /// </summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>
    /// Boolean flag that can be explicitly set to true to enable seal wrapping for the mount, causing values stored by the mount to be wrapped by the seal&apos;s encryption capability
    /// Enable seal wrapping for the mount, causing values stored by the mount to be wrapped by the seal&apos;s encryption capability
    /// </summary>
    [JsonPropertyName("sealWrap")]
    public bool? SealWrap { get; set; }

    /// <summary>
    /// The Consul management token this backend should use to issue new tokens. This field is required
    /// when bootstrap is false. Mutually exclusive with token_wo.
    /// Consider using token_wo instead for enhanced security.
    /// Specifies the Consul token to use when managing or issuing new tokens. Mutually exclusive with &apos;token_wo&apos;.
    /// </summary>
    [JsonPropertyName("tokenSecretRef")]
    public V1alpha1SecretBackendSpecInitProviderTokenSecretRef? TokenSecretRef { get; set; }

    /// <summary>
    /// The Consul management token this backend should use to issue new tokens, provided as a
    /// write-only field. Mutually exclusive with token. Must be
    /// used with token_wo_version.
    /// Specifies the Consul token to use when managing or issuing new tokens. This field is write-only and will never be stored in state. Mutually exclusive with &apos;token&apos;. Requires &apos;token_wo_version&apos; to trigger updates.
    /// </summary>
    [JsonPropertyName("tokenWoSecretRef")]
    public V1alpha1SecretBackendSpecInitProviderTokenWoSecretRef? TokenWoSecretRef { get; set; }

    /// <summary>
    /// Version counter for the write-only token. Increment this value to trigger an update
    /// of the token in Vault. Required when using token_wo.
    /// Version counter for the write-only token. Increment this value to trigger rotation of the token. Required when using &apos;token_wo&apos;.
    /// </summary>
    [JsonPropertyName("tokenWoVersion")]
    public double? TokenWoVersion { get; set; }
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
    /// <summary>Accessor of the mount</summary>
    [JsonPropertyName("accessor")]
    public string? Accessor { get; set; }

    /// <summary>
    /// Specifies the address of the Consul instance, provided as &quot;host:port&quot; like &quot;127.0.0.1:8500&quot;.
    /// Specifies the address of the Consul instance, provided as &quot;host:port&quot; like &quot;127.0.0.1:8500&quot;.
    /// </summary>
    [JsonPropertyName("address")]
    public string? Address { get; set; }

    /// <summary>
    /// Set of managed key registry entry names that the mount in question is allowed to access
    /// List of managed key registry entry names that the mount in question is allowed to access
    /// </summary>
    [JsonPropertyName("allowedManagedKeys")]
    public IList<string>? AllowedManagedKeys { get; set; }

    /// <summary>
    /// List of headers to allow, allowing a plugin to include
    /// them in the response.
    /// List of headers to allow and pass from the request to the plugin
    /// </summary>
    [JsonPropertyName("allowedResponseHeaders")]
    public IList<string>? AllowedResponseHeaders { get; set; }

    /// <summary>
    /// Specifies the list of keys that will not be HMAC&apos;d by audit devices in the request data object.
    /// Specifies the list of keys that will not be HMAC&apos;d by audit devices in the request data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacRequestKeys")]
    public IList<string>? AuditNonHmacRequestKeys { get; set; }

    /// <summary>
    /// Specifies the list of keys that will not be HMAC&apos;d by audit devices in the response data object.
    /// Specifies the list of keys that will not be HMAC&apos;d by audit devices in the response data object.
    /// </summary>
    [JsonPropertyName("auditNonHmacResponseKeys")]
    public IList<string>? AuditNonHmacResponseKeys { get; set; }

    /// <summary>
    /// Denotes that the resource is used to bootstrap the Consul ACL system.
    /// Denotes a backend resource that is used to bootstrap the Consul ACL system. Only one resource may be used to bootstrap.
    /// </summary>
    [JsonPropertyName("bootstrap")]
    public bool? Bootstrap { get; set; }

    /// <summary>
    /// CA certificate to use when verifying Consul server certificate, must be x509 PEM encoded.
    /// CA certificate to use when verifying Consul server certificate, must be x509 PEM encoded.
    /// </summary>
    [JsonPropertyName("caCert")]
    public string? CaCert { get; set; }

    /// <summary>
    /// Version counter for the write-only client key. Increment this value to trigger
    /// an update of the client key in Vault. Required when using client_key_wo.
    /// Version counter for the write-only client key. Increment this value to trigger rotation of the client key. Required when using &apos;client_key_wo&apos;.
    /// </summary>
    [JsonPropertyName("clientKeyWoVersion")]
    public double? ClientKeyWoVersion { get; set; }

    /// <summary>
    /// Default lease duration for tokens and secrets in seconds
    /// Default lease duration for secrets in seconds
    /// </summary>
    [JsonPropertyName("defaultLeaseTtlSeconds")]
    public double? DefaultLeaseTtlSeconds { get; set; }

    /// <summary>
    /// List of allowed authentication mount accessors the
    /// backend can request delegated authentication for.
    /// List of headers to allow and pass from the request to the plugin
    /// </summary>
    [JsonPropertyName("delegatedAuthAccessors")]
    public IList<string>? DelegatedAuthAccessors { get; set; }

    /// <summary>
    /// A human-friendly description for this backend.
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
    /// Boolean flag that can be explicitly set to true to enable the secrets engine to access Vault&apos;s external entropy source
    /// Enable the secrets engine to access Vault&apos;s external entropy source
    /// </summary>
    [JsonPropertyName("externalEntropyAccess")]
    public bool? ExternalEntropyAccess { get; set; }

    /// <summary>If set to true, disables caching.</summary>
    [JsonPropertyName("forceNoCache")]
    public bool? ForceNoCache { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The key to use for signing plugin workload identity tokens. If
    /// not provided, this will default to Vault&apos;s OIDC default key. Requires Vault Enterprise 1.16+.
    /// The key to use for signing plugin workload identity tokens
    /// </summary>
    [JsonPropertyName("identityTokenKey")]
    public string? IdentityTokenKey { get; set; }

    /// <summary>
    /// Specifies whether to show this mount in the UI-specific
    /// listing endpoint. Valid values are unauth or hidden. If not set, behaves like hidden.
    /// Specifies whether to show this mount in the UI-specific listing endpoint
    /// </summary>
    [JsonPropertyName("listingVisibility")]
    public string? ListingVisibility { get; set; }

    /// <summary>
    /// Boolean flag that can be explicitly set to true to enforce local mount in HA environment
    /// Specifies if the secret backend is local only
    /// </summary>
    [JsonPropertyName("local")]
    public bool? Local { get; set; }

    /// <summary>
    /// Maximum possible lease duration for tokens and secrets in seconds
    /// Maximum possible lease duration for secrets in seconds
    /// </summary>
    [JsonPropertyName("maxLeaseTtlSeconds")]
    public double? MaxLeaseTtlSeconds { get; set; }

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
    /// Specifies mount type specific options that are passed to the backend
    /// Specifies mount type specific options that are passed to the backend
    /// </summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    /// <summary>
    /// List of headers to allow and pass from the request to
    /// the plugin.
    /// List of headers to allow and pass from the request to the plugin
    /// </summary>
    [JsonPropertyName("passthroughRequestHeaders")]
    public IList<string>? PassthroughRequestHeaders { get; set; }

    /// <summary>
    /// The unique location this backend should be mounted at. Must not begin or end with a /. Defaults
    /// to consul.
    /// Unique name of the Vault Consul mount to configure
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use, e.g. &quot;v1.0.0&quot;.
    /// If unspecified, the server will select any matching unversioned plugin that may have been
    /// registered, the latest versioned plugin registered, or a built-in plugin in that order of precedence.
    /// Specifies the semantic version of the plugin to use, e.g. &apos;v1.0.0&apos;
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// Specifies the URL scheme to use. Defaults to http.
    /// Specifies the URL scheme to use. Defaults to &quot;http&quot;.
    /// </summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }

    /// <summary>
    /// Boolean flag that can be explicitly set to true to enable seal wrapping for the mount, causing values stored by the mount to be wrapped by the seal&apos;s encryption capability
    /// Enable seal wrapping for the mount, causing values stored by the mount to be wrapped by the seal&apos;s encryption capability
    /// </summary>
    [JsonPropertyName("sealWrap")]
    public bool? SealWrap { get; set; }

    /// <summary>
    /// Version counter for the write-only token. Increment this value to trigger an update
    /// of the token in Vault. Required when using token_wo.
    /// Version counter for the write-only token. Increment this value to trigger rotation of the token. Required when using &apos;token_wo&apos;.
    /// </summary>
    [JsonPropertyName("tokenWoVersion")]
    public double? TokenWoVersion { get; set; }
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

/// <summary>SecretBackend is the Schema for the SecretBackends API. Creates a Consul secret backend for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackend : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretBackendSpec>, IStatus<V1alpha1SecretBackendStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackend";
    public const string KubeGroup = "consul.vault.m.upbound.io";
    public const string KubePluralName = "secretbackends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "consul.vault.m.upbound.io/v1alpha1";

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