#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.database.vault.upbound.io;
/// <summary>SecretsMount is the Schema for the SecretsMounts API. Configures any number of database secrets engines under a single mount resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretsMountList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecretsMount>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretsMountList";
    public const string KubeGroup = "database.vault.upbound.io";
    public const string KubePluralName = "secretsmounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "database.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretsMountList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SecretsMount objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SecretsMount> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretsMountSpecDeletionPolicyEnum>))]
public enum V1alpha1SecretsMountSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// The password to authenticate with.
/// The password to use when authenticating with Cassandra.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderCassandraPasswordSecretRef
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
/// Concatenated PEM blocks configuring the certificate
/// chain.
/// Concatenated PEM blocks containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderCassandraPemBundleSecretRef
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
/// A JSON structure configuring the certificate chain.
/// Specifies JSON containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderCassandraPemJsonSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderCassandra
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// The number of seconds to use as a connection
    /// timeout.
    /// The number of seconds to use as a connection timeout.
    /// </summary>
    [JsonPropertyName("connectTimeout")]
    public double? ConnectTimeout { get; set; }

    /// <summary>
    /// Specifies the consistency option to use. See the gocql definition for valid options.
    /// Cassandra consistency level.
    /// </summary>
    [JsonPropertyName("consistency")]
    public string? Consistency { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The hosts to connect to.
    /// Cassandra hosts to connect to.
    /// </summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>
    /// Whether to skip verification of the server
    /// certificate when using TLS.
    /// Whether to skip verification of the server certificate when using TLS.
    /// </summary>
    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>
    /// If set, enables host selection policy which will prioritize and use hosts which are in the local datacenter before hosts in all other datacenters.
    /// Cassandra local datacenter name.
    /// </summary>
    [JsonPropertyName("localDatacenter")]
    public string? LocalDatacenter { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The password to use when authenticating with Cassandra.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecForProviderCassandraPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// Concatenated PEM blocks configuring the certificate
    /// chain.
    /// Concatenated PEM blocks containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
    /// </summary>
    [JsonPropertyName("pemBundleSecretRef")]
    public V1alpha1SecretsMountSpecForProviderCassandraPemBundleSecretRef? PemBundleSecretRef { get; set; }

    /// <summary>
    /// A JSON structure configuring the certificate chain.
    /// Specifies JSON containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
    /// </summary>
    [JsonPropertyName("pemJsonSecretRef")]
    public V1alpha1SecretsMountSpecForProviderCassandraPemJsonSecretRef? PemJsonSecretRef { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// The default port to connect to if no port is specified as
    /// part of the host.
    /// The transport port to use to connect to Cassandra.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The CQL protocol version to use.
    /// The CQL protocol version to use.
    /// </summary>
    [JsonPropertyName("protocolVersion")]
    public double? ProtocolVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>Skip permissions checks when a connection to Cassandra is first created. These checks ensure that Vault is able to create roles, but can be resource intensive in clusters with many roles.</summary>
    [JsonPropertyName("skipVerification")]
    public bool? SkipVerification { get; set; }

    /// <summary>
    /// The keep-alive period for an active network connection. If zero, keep-alives are not enabled.
    /// Enable TCP keepalive for Cassandra connections.
    /// </summary>
    [JsonPropertyName("socketKeepAlive")]
    public string? SocketKeepAlive { get; set; }

    /// <summary>
    /// Whether to use TLS when connecting to Cassandra.
    /// Whether to use TLS when connecting to Cassandra.
    /// </summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }

    /// <summary>
    /// Specifies the name to use as the SNI host when connecting to the Cassandra server via TLS.
    /// SNI host for TLS connections.
    /// </summary>
    [JsonPropertyName("tlsServerName")]
    public string? TlsServerName { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The username to use when authenticating with Cassandra.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Template for dynamic Cassandra usernames.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// Required if tls is true. Specifies the certificate authority of the Couchbase server, as a PEM certificate that has been base64 encoded.
/// Required if `tls` is `true`. Specifies the certificate authority of the Couchbase server, as a PEM certificate that has been base64 encoded.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderCouchbaseBase64PemSecretRef
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
/// The password to authenticate with.
/// Specifies the password corresponding to the given username.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderCouchbasePasswordSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderCouchbase
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// Required if tls is true. Specifies the certificate authority of the Couchbase server, as a PEM certificate that has been base64 encoded.
    /// Required if `tls` is `true`. Specifies the certificate authority of the Couchbase server, as a PEM certificate that has been base64 encoded.
    /// </summary>
    [JsonPropertyName("base64PemSecretRef")]
    public V1alpha1SecretsMountSpecForProviderCouchbaseBase64PemSecretRef? Base64PemSecretRef { get; set; }

    /// <summary>
    /// Required for Couchbase versions prior to 6.5.0. This is only used to verify vault&apos;s connection to the server.
    /// Required for Couchbase versions prior to 6.5.0. This is only used to verify vault&apos;s connection to the server.
    /// </summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The hosts to connect to.
    /// A set of Couchbase URIs to connect to. Must use `couchbases://` scheme if `tls` is `true`.
    /// </summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>
    /// Whether to skip verification of the server
    /// certificate when using TLS.
    /// Specifies whether to skip verification of the server certificate when using TLS.
    /// </summary>
    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// Specifies the password corresponding to the given username.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecForProviderCouchbasePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// Whether to use TLS when connecting to Cassandra.
    /// Specifies whether to use TLS when connecting to Couchbase.
    /// </summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// Specifies the username for Vault to use.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Template describing how dynamic usernames are generated.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The password to be used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderElasticsearchPasswordSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderElasticsearch
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// The path to a PEM-encoded CA cert file to use to verify the Elasticsearch server&apos;s identity.
    /// The path to a PEM-encoded CA cert file to use to verify the Elasticsearch server&apos;s identity
    /// </summary>
    [JsonPropertyName("caCert")]
    public string? CaCert { get; set; }

    /// <summary>
    /// The path to a directory of PEM-encoded CA cert files to use to verify the Elasticsearch server&apos;s identity.
    /// The path to a directory of PEM-encoded CA cert files to use to verify the Elasticsearch server&apos;s identity
    /// </summary>
    [JsonPropertyName("caPath")]
    public string? CaPath { get; set; }

    /// <summary>
    /// The path to the certificate for the Elasticsearch client to present for communication.
    /// The path to the certificate for the Elasticsearch client to present for communication
    /// </summary>
    [JsonPropertyName("clientCert")]
    public string? ClientCert { get; set; }

    /// <summary>
    /// The path to the key for the Elasticsearch client to use for communication.
    /// The path to the key for the Elasticsearch client to use for communication
    /// </summary>
    [JsonPropertyName("clientKey")]
    public string? ClientKey { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Whether to disable certificate verification.
    /// Whether to disable certificate verification
    /// </summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The password to be used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecForProviderElasticsearchPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// Specifies the name to use as the SNI host when connecting to the Cassandra server via TLS.
    /// This, if set, is used to set the SNI host when connecting via TLS
    /// </summary>
    [JsonPropertyName("tlsServerName")]
    public string? TlsServerName { get; set; }

    /// <summary>
    /// The URL for Elasticsearch&apos;s API. https requires certificate
    /// by trusted CA if used.
    /// The URL for Elasticsearch&apos;s API
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The username to be used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Template describing how dynamic usernames are generated.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderHanaPasswordSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderHana
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Disable special character escaping in username and password.
    /// Disable special character escaping in username and password
    /// </summary>
    [JsonPropertyName("disableEscaping")]
    public bool? DisableEscaping { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecForProviderHanaPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// Specifies the password corresponding to the given username.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderInfluxdbPasswordSecretRef
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
/// Concatenated PEM blocks configuring the certificate
/// chain.
/// Concatenated PEM blocks containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderInfluxdbPemBundleSecretRef
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
/// A JSON structure configuring the certificate chain.
/// Specifies JSON containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderInfluxdbPemJsonSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderInfluxdb
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// The number of seconds to use as a connection
    /// timeout.
    /// The number of seconds to use as a connection timeout.
    /// </summary>
    [JsonPropertyName("connectTimeout")]
    public double? ConnectTimeout { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The host to connect to.
    /// Influxdb host to connect to.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// Whether to skip verification of the server
    /// certificate when using TLS.
    /// Whether to skip verification of the server certificate when using TLS.
    /// </summary>
    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// Specifies the password corresponding to the given username.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecForProviderInfluxdbPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// Concatenated PEM blocks configuring the certificate
    /// chain.
    /// Concatenated PEM blocks containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
    /// </summary>
    [JsonPropertyName("pemBundleSecretRef")]
    public V1alpha1SecretsMountSpecForProviderInfluxdbPemBundleSecretRef? PemBundleSecretRef { get; set; }

    /// <summary>
    /// A JSON structure configuring the certificate chain.
    /// Specifies JSON containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
    /// </summary>
    [JsonPropertyName("pemJsonSecretRef")]
    public V1alpha1SecretsMountSpecForProviderInfluxdbPemJsonSecretRef? PemJsonSecretRef { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// The default port to connect to if no port is specified as
    /// part of the host.
    /// The transport port to use to connect to Influxdb.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// Whether to use TLS when connecting to Cassandra.
    /// Whether to use TLS when connecting to Influxdb.
    /// </summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// Specifies the username to use for superuser access.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Template describing how dynamic usernames are generated.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMongodbPasswordSecretRef
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
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// The x509 certificate and private key bundle for connecting to the database. Must be PEM encoded.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMongodbTlsCertificateKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMongodb
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecForProviderMongodbPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// The x509 CA file for validating the certificate presented by the MongoDB server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// The x509 certificate and private key bundle for connecting to the database. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretsMountSpecForProviderMongodbTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }

    /// <summary>Specifies the MongoDB write concern for Vault management operations.</summary>
    [JsonPropertyName("writeConcern")]
    public string? WriteConcern { get; set; }
}

/// <summary>
/// The Private Programmatic API Key used to connect with MongoDB Atlas API.
/// The Private Programmatic API Key used to connect with MongoDB Atlas API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMongodbatlasPrivateKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMongodbatlas
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// The Private Programmatic API Key used to connect with MongoDB Atlas API.
    /// The Private Programmatic API Key used to connect with MongoDB Atlas API.
    /// </summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1alpha1SecretsMountSpecForProviderMongodbatlasPrivateKeySecretRef? PrivateKeySecretRef { get; set; }

    /// <summary>
    /// The Project ID the Database User should be created within.
    /// The Project ID the Database User should be created within.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The Public Programmatic API Key used to authenticate with the MongoDB Atlas API.
    /// The Public Programmatic API Key used to authenticate with the MongoDB Atlas API.
    /// </summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Template describing how dynamic usernames are generated.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMssqlPasswordSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMssql
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// For Vault v1.9+. Set to true when the target is a
    /// Contained Database, e.g. AzureSQL.
    /// See Vault docs
    /// Set to true when the target is a Contained Database, e.g. AzureSQL.
    /// </summary>
    [JsonPropertyName("containedDb")]
    public bool? ContainedDb { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Disable special character escaping in username and password.
    /// Disable special character escaping in username and password
    /// </summary>
    [JsonPropertyName("disableEscaping")]
    public bool? DisableEscaping { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecForProviderMssqlPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMysqlPasswordSecretRef
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

/// <summary>A JSON encoded credential for use with IAM authorization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMysqlServiceAccountJsonSecretRef
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
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMysqlTlsCertificateKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMysql
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecForProviderMysqlPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>A JSON encoded credential for use with IAM authorization</summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretsMountSpecForProviderMysqlServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretsMountSpecForProviderMysqlTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMysqlAuroraPasswordSecretRef
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

/// <summary>A JSON encoded credential for use with IAM authorization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMysqlAuroraServiceAccountJsonSecretRef
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
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMysqlAuroraTlsCertificateKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMysqlAurora
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecForProviderMysqlAuroraPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>A JSON encoded credential for use with IAM authorization</summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretsMountSpecForProviderMysqlAuroraServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretsMountSpecForProviderMysqlAuroraTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMysqlLegacyPasswordSecretRef
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

/// <summary>A JSON encoded credential for use with IAM authorization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMysqlLegacyServiceAccountJsonSecretRef
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
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMysqlLegacyTlsCertificateKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMysqlLegacy
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecForProviderMysqlLegacyPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>A JSON encoded credential for use with IAM authorization</summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretsMountSpecForProviderMysqlLegacyServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretsMountSpecForProviderMysqlLegacyTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMysqlRdsPasswordSecretRef
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

/// <summary>A JSON encoded credential for use with IAM authorization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMysqlRdsServiceAccountJsonSecretRef
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
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMysqlRdsTlsCertificateKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderMysqlRds
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecForProviderMysqlRdsPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>A JSON encoded credential for use with IAM authorization</summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretsMountSpecForProviderMysqlRdsServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretsMountSpecForProviderMysqlRdsTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderOraclePasswordSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderOracle
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>Set to true to disconnect any open sessions prior to running the revocation statements.</summary>
    [JsonPropertyName("disconnectSessions")]
    public bool? DisconnectSessions { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecForProviderOraclePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>If set, allows onboarding static roles with a rootless connection configuration.</summary>
    [JsonPropertyName("selfManaged")]
    public bool? SelfManaged { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>Set to true in order to split statements after semi-colons.</summary>
    [JsonPropertyName("splitStatements")]
    public bool? SplitStatements { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderPostgresqlPasswordSecretRef
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
/// The Private Programmatic API Key used to connect with MongoDB Atlas API.
/// The secret key used for the x509 client certificate. Must be PEM encoded.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderPostgresqlPrivateKeySecretRef
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

/// <summary>A JSON encoded credential for use with IAM authorization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderPostgresqlServiceAccountJsonSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderPostgresql
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Disable special character escaping in username and password.
    /// Disable special character escaping in username and password
    /// </summary>
    [JsonPropertyName("disableEscaping")]
    public bool? DisableEscaping { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>When set to `scram-sha-256`, passwords will be hashed by Vault before being sent to PostgreSQL.</summary>
    [JsonPropertyName("passwordAuthentication")]
    public string? PasswordAuthentication { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecForProviderPostgresqlPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// The Private Programmatic API Key used to connect with MongoDB Atlas API.
    /// The secret key used for the x509 client certificate. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1alpha1SecretsMountSpecForProviderPostgresqlPrivateKeySecretRef? PrivateKeySecretRef { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>If set, allows onboarding static roles with a rootless connection configuration.</summary>
    [JsonPropertyName("selfManaged")]
    public bool? SelfManaged { get; set; }

    /// <summary>A JSON encoded credential for use with IAM authorization</summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretsMountSpecForProviderPostgresqlServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// The x509 CA file for validating the certificate presented by the PostgreSQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>The x509 client certificate for connecting to the database. Must be PEM encoded.</summary>
    [JsonPropertyName("tlsCertificate")]
    public string? TlsCertificate { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// Specifies the password corresponding to the given username.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderRedisPasswordSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderRedis
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// The path to a PEM-encoded CA cert file to use to verify the Elasticsearch server&apos;s identity.
    /// The contents of a PEM-encoded CA cert file to use to verify the Redis server&apos;s identity.
    /// </summary>
    [JsonPropertyName("caCert")]
    public string? CaCert { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The host to connect to.
    /// Specifies the host to connect to
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// Whether to skip verification of the server
    /// certificate when using TLS.
    /// Specifies whether to skip verification of the server certificate when using TLS.
    /// </summary>
    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// Specifies the password corresponding to the given username.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecForProviderRedisPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// The default port to connect to if no port is specified as
    /// part of the host.
    /// The transport port to use to connect to Redis.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// Whether to use TLS when connecting to Cassandra.
    /// Specifies whether to use TLS when connecting to Redis.
    /// </summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// Specifies the username for Vault to use.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The AWS secret key id to use to talk to ElastiCache. If omitted the credentials chain provider is used instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderRedisElasticachePasswordSecretRef
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
/// The username to authenticate with.
/// The AWS access key id to use to talk to ElastiCache. If omitted the credentials chain provider is used instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderRedisElasticacheUsernameSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderRedisElasticache
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The AWS secret key id to use to talk to ElastiCache. If omitted the credentials chain provider is used instead.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecForProviderRedisElasticachePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// The AWS region where the ElastiCache cluster is hosted.
    /// If omitted the plugin tries to infer the region from the environment.
    /// The AWS region where the ElastiCache cluster is hosted. If omitted the plugin tries to infer the region from the environment.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// The URL for Elasticsearch&apos;s API. https requires certificate
    /// by trusted CA if used.
    /// The configuration endpoint for the ElastiCache cluster to connect to.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The AWS access key id to use to talk to ElastiCache. If omitted the credentials chain provider is used instead.
    /// </summary>
    [JsonPropertyName("usernameSecretRef")]
    public V1alpha1SecretsMountSpecForProviderRedisElasticacheUsernameSecretRef? UsernameSecretRef { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderRedshiftPasswordSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderRedshift
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Disable special character escaping in username and password.
    /// Disable special character escaping in username and password
    /// </summary>
    [JsonPropertyName("disableEscaping")]
    public bool? DisableEscaping { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecForProviderRedshiftPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderSnowflakePasswordSecretRef
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

/// <summary>The private key configured for the admin user in Snowflake.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderSnowflakePrivateKeyWoSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProviderSnowflake
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecForProviderSnowflakePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>The private key configured for the admin user in Snowflake.</summary>
    [JsonPropertyName("privateKeyWoSecretRef")]
    public V1alpha1SecretsMountSpecForProviderSnowflakePrivateKeyWoSecretRef? PrivateKeyWoSecretRef { get; set; }

    /// <summary>Version counter for the private key key-pair credentials write-only field</summary>
    [JsonPropertyName("privateKeyWoVersion")]
    public double? PrivateKeyWoVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecForProvider
{
    /// <summary>
    /// Set of managed key registry entry names that the mount in question is allowed to access
    /// List of managed key registry entry names that the mount in question is allowed to access
    /// </summary>
    [JsonPropertyName("allowedManagedKeys")]
    public IList<string>? AllowedManagedKeys { get; set; }

    /// <summary>List of headers to allow and pass from the request to the plugin</summary>
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
    /// A nested block containing configuration options for Cassandra connections.
    /// See
    /// Connection parameters for the cassandra-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("cassandra")]
    public IList<V1alpha1SecretsMountSpecForProviderCassandra>? Cassandra { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Couchbase connections.
    /// See
    /// Connection parameters for the couchbase-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("couchbase")]
    public IList<V1alpha1SecretsMountSpecForProviderCouchbase>? Couchbase { get; set; }

    /// <summary>
    /// Default lease duration for tokens and secrets in seconds
    /// Default lease duration for tokens and secrets in seconds
    /// </summary>
    [JsonPropertyName("defaultLeaseTtlSeconds")]
    public double? DefaultLeaseTtlSeconds { get; set; }

    /// <summary>List of headers to allow and pass from the request to the plugin</summary>
    [JsonPropertyName("delegatedAuthAccessors")]
    public IList<string>? DelegatedAuthAccessors { get; set; }

    /// <summary>
    /// Human-friendly description of the mount
    /// Human-friendly description of the mount
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Elasticsearch connections.
    /// See
    /// Connection parameters for the elasticsearch-database-plugin.
    /// </summary>
    [JsonPropertyName("elasticsearch")]
    public IList<V1alpha1SecretsMountSpecForProviderElasticsearch>? Elasticsearch { get; set; }

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
    /// A nested block containing configuration options for SAP HanaDB connections.
    /// See
    /// Connection parameters for the hana-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("hana")]
    public IList<V1alpha1SecretsMountSpecForProviderHana>? Hana { get; set; }

    /// <summary>The key to use for signing plugin workload identity tokens</summary>
    [JsonPropertyName("identityTokenKey")]
    public string? IdentityTokenKey { get; set; }

    /// <summary>
    /// A nested block containing configuration options for InfluxDB connections.
    /// See
    /// Connection parameters for the influxdb-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("influxdb")]
    public IList<V1alpha1SecretsMountSpecForProviderInfluxdb>? Influxdb { get; set; }

    /// <summary>Specifies whether to show this mount in the UI-specific listing endpoint</summary>
    [JsonPropertyName("listingVisibility")]
    public string? ListingVisibility { get; set; }

    /// <summary>
    /// Boolean flag that can be explicitly set to true to enforce local mount in HA environment
    /// Local mount flag that can be explicitly set to true to enforce local mount in HA environment
    /// </summary>
    [JsonPropertyName("local")]
    public bool? Local { get; set; }

    /// <summary>
    /// Maximum possible lease duration for tokens and secrets in seconds
    /// Maximum possible lease duration for tokens and secrets in seconds
    /// </summary>
    [JsonPropertyName("maxLeaseTtlSeconds")]
    public double? MaxLeaseTtlSeconds { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MongoDB connections.
    /// See
    /// Connection parameters for the mongodb-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mongodb")]
    public IList<V1alpha1SecretsMountSpecForProviderMongodb>? Mongodb { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MongoDB Atlas connections.
    /// See
    /// Connection parameters for the mongodbatlas-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mongodbatlas")]
    public IList<V1alpha1SecretsMountSpecForProviderMongodbatlas>? Mongodbatlas { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MSSQL connections.
    /// See
    /// Connection parameters for the mssql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mssql")]
    public IList<V1alpha1SecretsMountSpecForProviderMssql>? Mssql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MySQL connections.
    /// See
    /// Connection parameters for the mysql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysql")]
    public IList<V1alpha1SecretsMountSpecForProviderMysql>? Mysql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Aurora MySQL connections.
    /// See
    /// Connection parameters for the mysql-aurora-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlAurora")]
    public IList<V1alpha1SecretsMountSpecForProviderMysqlAurora>? MysqlAurora { get; set; }

    /// <summary>
    /// A nested block containing configuration options for legacy MySQL connections.
    /// See
    /// Connection parameters for the mysql-legacy-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlLegacy")]
    public IList<V1alpha1SecretsMountSpecForProviderMysqlLegacy>? MysqlLegacy { get; set; }

    /// <summary>
    /// A nested block containing configuration options for RDS MySQL connections.
    /// See
    /// Connection parameters for the mysql-rds-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlRds")]
    public IList<V1alpha1SecretsMountSpecForProviderMysqlRds>? MysqlRds { get; set; }

    /// <summary>Target namespace. (requires Enterprise)</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Specifies mount type specific options that are passed to the backend
    /// Specifies mount type specific options that are passed to the backend
    /// </summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Oracle connections.
    /// See
    /// Connection parameters for the oracle-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("oracle")]
    public IList<V1alpha1SecretsMountSpecForProviderOracle>? Oracle { get; set; }

    /// <summary>List of headers to allow and pass from the request to the plugin</summary>
    [JsonPropertyName("passthroughRequestHeaders")]
    public IList<string>? PassthroughRequestHeaders { get; set; }

    /// <summary>
    /// Where the secret backend will be mounted
    /// Where the secret backend will be mounted
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Specifies the semantic version of the plugin to use, e.g. &apos;v1.0.0&apos;
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A nested block containing configuration options for PostgreSQL connections.
    /// See
    /// Connection parameters for the postgresql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("postgresql")]
    public IList<V1alpha1SecretsMountSpecForProviderPostgresql>? Postgresql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Redis connections.
    /// See
    /// Connection parameters for the redis-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("redis")]
    public IList<V1alpha1SecretsMountSpecForProviderRedis>? Redis { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Redis ElastiCache connections.
    /// See
    /// Connection parameters for the redis-elasticache-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("redisElasticache")]
    public IList<V1alpha1SecretsMountSpecForProviderRedisElasticache>? RedisElasticache { get; set; }

    /// <summary>
    /// A nested block containing configuration options for AWS Redshift connections.
    /// See
    /// Connection parameters for the redshift-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("redshift")]
    public IList<V1alpha1SecretsMountSpecForProviderRedshift>? Redshift { get; set; }

    /// <summary>
    /// Boolean flag that can be explicitly set to true to enable seal wrapping for the mount, causing values stored by the mount to be wrapped by the seal&apos;s encryption capability
    /// Enable seal wrapping for the mount, causing values stored by the mount to be wrapped by the seal&apos;s encryption capability
    /// </summary>
    [JsonPropertyName("sealWrap")]
    public bool? SealWrap { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Snowflake connections.
    /// See
    /// Connection parameters for the snowflake-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("snowflake")]
    public IList<V1alpha1SecretsMountSpecForProviderSnowflake>? Snowflake { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The password to use when authenticating with Cassandra.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderCassandraPasswordSecretRef
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
/// Concatenated PEM blocks configuring the certificate
/// chain.
/// Concatenated PEM blocks containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderCassandraPemBundleSecretRef
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
/// A JSON structure configuring the certificate chain.
/// Specifies JSON containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderCassandraPemJsonSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderCassandra
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// The number of seconds to use as a connection
    /// timeout.
    /// The number of seconds to use as a connection timeout.
    /// </summary>
    [JsonPropertyName("connectTimeout")]
    public double? ConnectTimeout { get; set; }

    /// <summary>
    /// Specifies the consistency option to use. See the gocql definition for valid options.
    /// Cassandra consistency level.
    /// </summary>
    [JsonPropertyName("consistency")]
    public string? Consistency { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The hosts to connect to.
    /// Cassandra hosts to connect to.
    /// </summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>
    /// Whether to skip verification of the server
    /// certificate when using TLS.
    /// Whether to skip verification of the server certificate when using TLS.
    /// </summary>
    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>
    /// If set, enables host selection policy which will prioritize and use hosts which are in the local datacenter before hosts in all other datacenters.
    /// Cassandra local datacenter name.
    /// </summary>
    [JsonPropertyName("localDatacenter")]
    public string? LocalDatacenter { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The password to use when authenticating with Cassandra.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderCassandraPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// Concatenated PEM blocks configuring the certificate
    /// chain.
    /// Concatenated PEM blocks containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
    /// </summary>
    [JsonPropertyName("pemBundleSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderCassandraPemBundleSecretRef? PemBundleSecretRef { get; set; }

    /// <summary>
    /// A JSON structure configuring the certificate chain.
    /// Specifies JSON containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
    /// </summary>
    [JsonPropertyName("pemJsonSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderCassandraPemJsonSecretRef? PemJsonSecretRef { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// The default port to connect to if no port is specified as
    /// part of the host.
    /// The transport port to use to connect to Cassandra.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The CQL protocol version to use.
    /// The CQL protocol version to use.
    /// </summary>
    [JsonPropertyName("protocolVersion")]
    public double? ProtocolVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>Skip permissions checks when a connection to Cassandra is first created. These checks ensure that Vault is able to create roles, but can be resource intensive in clusters with many roles.</summary>
    [JsonPropertyName("skipVerification")]
    public bool? SkipVerification { get; set; }

    /// <summary>
    /// The keep-alive period for an active network connection. If zero, keep-alives are not enabled.
    /// Enable TCP keepalive for Cassandra connections.
    /// </summary>
    [JsonPropertyName("socketKeepAlive")]
    public string? SocketKeepAlive { get; set; }

    /// <summary>
    /// Whether to use TLS when connecting to Cassandra.
    /// Whether to use TLS when connecting to Cassandra.
    /// </summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }

    /// <summary>
    /// Specifies the name to use as the SNI host when connecting to the Cassandra server via TLS.
    /// SNI host for TLS connections.
    /// </summary>
    [JsonPropertyName("tlsServerName")]
    public string? TlsServerName { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The username to use when authenticating with Cassandra.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Template for dynamic Cassandra usernames.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// Required if tls is true. Specifies the certificate authority of the Couchbase server, as a PEM certificate that has been base64 encoded.
/// Required if `tls` is `true`. Specifies the certificate authority of the Couchbase server, as a PEM certificate that has been base64 encoded.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderCouchbaseBase64PemSecretRef
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
/// The password to authenticate with.
/// Specifies the password corresponding to the given username.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderCouchbasePasswordSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderCouchbase
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// Required if tls is true. Specifies the certificate authority of the Couchbase server, as a PEM certificate that has been base64 encoded.
    /// Required if `tls` is `true`. Specifies the certificate authority of the Couchbase server, as a PEM certificate that has been base64 encoded.
    /// </summary>
    [JsonPropertyName("base64PemSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderCouchbaseBase64PemSecretRef? Base64PemSecretRef { get; set; }

    /// <summary>
    /// Required for Couchbase versions prior to 6.5.0. This is only used to verify vault&apos;s connection to the server.
    /// Required for Couchbase versions prior to 6.5.0. This is only used to verify vault&apos;s connection to the server.
    /// </summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The hosts to connect to.
    /// A set of Couchbase URIs to connect to. Must use `couchbases://` scheme if `tls` is `true`.
    /// </summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>
    /// Whether to skip verification of the server
    /// certificate when using TLS.
    /// Specifies whether to skip verification of the server certificate when using TLS.
    /// </summary>
    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// Specifies the password corresponding to the given username.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1alpha1SecretsMountSpecInitProviderCouchbasePasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// Whether to use TLS when connecting to Cassandra.
    /// Specifies whether to use TLS when connecting to Couchbase.
    /// </summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// Specifies the username for Vault to use.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Template describing how dynamic usernames are generated.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The password to be used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderElasticsearchPasswordSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderElasticsearch
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// The path to a PEM-encoded CA cert file to use to verify the Elasticsearch server&apos;s identity.
    /// The path to a PEM-encoded CA cert file to use to verify the Elasticsearch server&apos;s identity
    /// </summary>
    [JsonPropertyName("caCert")]
    public string? CaCert { get; set; }

    /// <summary>
    /// The path to a directory of PEM-encoded CA cert files to use to verify the Elasticsearch server&apos;s identity.
    /// The path to a directory of PEM-encoded CA cert files to use to verify the Elasticsearch server&apos;s identity
    /// </summary>
    [JsonPropertyName("caPath")]
    public string? CaPath { get; set; }

    /// <summary>
    /// The path to the certificate for the Elasticsearch client to present for communication.
    /// The path to the certificate for the Elasticsearch client to present for communication
    /// </summary>
    [JsonPropertyName("clientCert")]
    public string? ClientCert { get; set; }

    /// <summary>
    /// The path to the key for the Elasticsearch client to use for communication.
    /// The path to the key for the Elasticsearch client to use for communication
    /// </summary>
    [JsonPropertyName("clientKey")]
    public string? ClientKey { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Whether to disable certificate verification.
    /// Whether to disable certificate verification
    /// </summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The password to be used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1alpha1SecretsMountSpecInitProviderElasticsearchPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// Specifies the name to use as the SNI host when connecting to the Cassandra server via TLS.
    /// This, if set, is used to set the SNI host when connecting via TLS
    /// </summary>
    [JsonPropertyName("tlsServerName")]
    public string? TlsServerName { get; set; }

    /// <summary>
    /// The URL for Elasticsearch&apos;s API. https requires certificate
    /// by trusted CA if used.
    /// The URL for Elasticsearch&apos;s API
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The username to be used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Template describing how dynamic usernames are generated.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderHanaPasswordSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderHana
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Disable special character escaping in username and password.
    /// Disable special character escaping in username and password
    /// </summary>
    [JsonPropertyName("disableEscaping")]
    public bool? DisableEscaping { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderHanaPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// Specifies the password corresponding to the given username.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderInfluxdbPasswordSecretRef
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
/// Concatenated PEM blocks configuring the certificate
/// chain.
/// Concatenated PEM blocks containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderInfluxdbPemBundleSecretRef
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
/// A JSON structure configuring the certificate chain.
/// Specifies JSON containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderInfluxdbPemJsonSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderInfluxdb
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// The number of seconds to use as a connection
    /// timeout.
    /// The number of seconds to use as a connection timeout.
    /// </summary>
    [JsonPropertyName("connectTimeout")]
    public double? ConnectTimeout { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The host to connect to.
    /// Influxdb host to connect to.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// Whether to skip verification of the server
    /// certificate when using TLS.
    /// Whether to skip verification of the server certificate when using TLS.
    /// </summary>
    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// Specifies the password corresponding to the given username.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1alpha1SecretsMountSpecInitProviderInfluxdbPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>
    /// Concatenated PEM blocks configuring the certificate
    /// chain.
    /// Concatenated PEM blocks containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
    /// </summary>
    [JsonPropertyName("pemBundleSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderInfluxdbPemBundleSecretRef? PemBundleSecretRef { get; set; }

    /// <summary>
    /// A JSON structure configuring the certificate chain.
    /// Specifies JSON containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
    /// </summary>
    [JsonPropertyName("pemJsonSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderInfluxdbPemJsonSecretRef? PemJsonSecretRef { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// The default port to connect to if no port is specified as
    /// part of the host.
    /// The transport port to use to connect to Influxdb.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// Whether to use TLS when connecting to Cassandra.
    /// Whether to use TLS when connecting to Influxdb.
    /// </summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// Specifies the username to use for superuser access.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Template describing how dynamic usernames are generated.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMongodbPasswordSecretRef
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
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// The x509 certificate and private key bundle for connecting to the database. Must be PEM encoded.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMongodbTlsCertificateKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMongodb
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderMongodbPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// The x509 CA file for validating the certificate presented by the MongoDB server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// The x509 certificate and private key bundle for connecting to the database. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretsMountSpecInitProviderMongodbTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }

    /// <summary>Specifies the MongoDB write concern for Vault management operations.</summary>
    [JsonPropertyName("writeConcern")]
    public string? WriteConcern { get; set; }
}

/// <summary>
/// The Private Programmatic API Key used to connect with MongoDB Atlas API.
/// The Private Programmatic API Key used to connect with MongoDB Atlas API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMongodbatlasPrivateKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMongodbatlas
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// The Private Programmatic API Key used to connect with MongoDB Atlas API.
    /// The Private Programmatic API Key used to connect with MongoDB Atlas API.
    /// </summary>
    [JsonPropertyName("privateKeySecretRef")]
    public required V1alpha1SecretsMountSpecInitProviderMongodbatlasPrivateKeySecretRef PrivateKeySecretRef { get; set; }

    /// <summary>
    /// The Project ID the Database User should be created within.
    /// The Project ID the Database User should be created within.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The Public Programmatic API Key used to authenticate with the MongoDB Atlas API.
    /// The Public Programmatic API Key used to authenticate with the MongoDB Atlas API.
    /// </summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Template describing how dynamic usernames are generated.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMssqlPasswordSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMssql
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// For Vault v1.9+. Set to true when the target is a
    /// Contained Database, e.g. AzureSQL.
    /// See Vault docs
    /// Set to true when the target is a Contained Database, e.g. AzureSQL.
    /// </summary>
    [JsonPropertyName("containedDb")]
    public bool? ContainedDb { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Disable special character escaping in username and password.
    /// Disable special character escaping in username and password
    /// </summary>
    [JsonPropertyName("disableEscaping")]
    public bool? DisableEscaping { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderMssqlPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMysqlPasswordSecretRef
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

/// <summary>A JSON encoded credential for use with IAM authorization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMysqlServiceAccountJsonSecretRef
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
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMysqlTlsCertificateKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMysql
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderMysqlPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>A JSON encoded credential for use with IAM authorization</summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderMysqlServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretsMountSpecInitProviderMysqlTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMysqlAuroraPasswordSecretRef
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

/// <summary>A JSON encoded credential for use with IAM authorization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMysqlAuroraServiceAccountJsonSecretRef
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
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMysqlAuroraTlsCertificateKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMysqlAurora
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderMysqlAuroraPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>A JSON encoded credential for use with IAM authorization</summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderMysqlAuroraServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretsMountSpecInitProviderMysqlAuroraTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMysqlLegacyPasswordSecretRef
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

/// <summary>A JSON encoded credential for use with IAM authorization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMysqlLegacyServiceAccountJsonSecretRef
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
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMysqlLegacyTlsCertificateKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMysqlLegacy
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderMysqlLegacyPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>A JSON encoded credential for use with IAM authorization</summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderMysqlLegacyServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretsMountSpecInitProviderMysqlLegacyTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMysqlRdsPasswordSecretRef
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

/// <summary>A JSON encoded credential for use with IAM authorization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMysqlRdsServiceAccountJsonSecretRef
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
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMysqlRdsTlsCertificateKeySecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderMysqlRds
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderMysqlRdsPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>A JSON encoded credential for use with IAM authorization</summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderMysqlRdsServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretsMountSpecInitProviderMysqlRdsTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderOraclePasswordSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderOracle
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>Set to true to disconnect any open sessions prior to running the revocation statements.</summary>
    [JsonPropertyName("disconnectSessions")]
    public bool? DisconnectSessions { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderOraclePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>If set, allows onboarding static roles with a rootless connection configuration.</summary>
    [JsonPropertyName("selfManaged")]
    public bool? SelfManaged { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>Set to true in order to split statements after semi-colons.</summary>
    [JsonPropertyName("splitStatements")]
    public bool? SplitStatements { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderPostgresqlPasswordSecretRef
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
/// The Private Programmatic API Key used to connect with MongoDB Atlas API.
/// The secret key used for the x509 client certificate. Must be PEM encoded.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderPostgresqlPrivateKeySecretRef
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

/// <summary>A JSON encoded credential for use with IAM authorization</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderPostgresqlServiceAccountJsonSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderPostgresql
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Disable special character escaping in username and password.
    /// Disable special character escaping in username and password
    /// </summary>
    [JsonPropertyName("disableEscaping")]
    public bool? DisableEscaping { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>When set to `scram-sha-256`, passwords will be hashed by Vault before being sent to PostgreSQL.</summary>
    [JsonPropertyName("passwordAuthentication")]
    public string? PasswordAuthentication { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderPostgresqlPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// The Private Programmatic API Key used to connect with MongoDB Atlas API.
    /// The secret key used for the x509 client certificate. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1alpha1SecretsMountSpecInitProviderPostgresqlPrivateKeySecretRef? PrivateKeySecretRef { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>If set, allows onboarding static roles with a rootless connection configuration.</summary>
    [JsonPropertyName("selfManaged")]
    public bool? SelfManaged { get; set; }

    /// <summary>A JSON encoded credential for use with IAM authorization</summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderPostgresqlServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// The x509 CA file for validating the certificate presented by the PostgreSQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>The x509 client certificate for connecting to the database. Must be PEM encoded.</summary>
    [JsonPropertyName("tlsCertificate")]
    public string? TlsCertificate { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// Specifies the password corresponding to the given username.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderRedisPasswordSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderRedis
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// The path to a PEM-encoded CA cert file to use to verify the Elasticsearch server&apos;s identity.
    /// The contents of a PEM-encoded CA cert file to use to verify the Redis server&apos;s identity.
    /// </summary>
    [JsonPropertyName("caCert")]
    public string? CaCert { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The host to connect to.
    /// Specifies the host to connect to
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// Whether to skip verification of the server
    /// certificate when using TLS.
    /// Specifies whether to skip verification of the server certificate when using TLS.
    /// </summary>
    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// Specifies the password corresponding to the given username.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1alpha1SecretsMountSpecInitProviderRedisPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// The default port to connect to if no port is specified as
    /// part of the host.
    /// The transport port to use to connect to Redis.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// Whether to use TLS when connecting to Cassandra.
    /// Specifies whether to use TLS when connecting to Redis.
    /// </summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// Specifies the username for Vault to use.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The AWS secret key id to use to talk to ElastiCache. If omitted the credentials chain provider is used instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderRedisElasticachePasswordSecretRef
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
/// The username to authenticate with.
/// The AWS access key id to use to talk to ElastiCache. If omitted the credentials chain provider is used instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderRedisElasticacheUsernameSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderRedisElasticache
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The AWS secret key id to use to talk to ElastiCache. If omitted the credentials chain provider is used instead.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderRedisElasticachePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// The AWS region where the ElastiCache cluster is hosted.
    /// If omitted the plugin tries to infer the region from the environment.
    /// The AWS region where the ElastiCache cluster is hosted. If omitted the plugin tries to infer the region from the environment.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// The URL for Elasticsearch&apos;s API. https requires certificate
    /// by trusted CA if used.
    /// The configuration endpoint for the ElastiCache cluster to connect to.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The AWS access key id to use to talk to ElastiCache. If omitted the credentials chain provider is used instead.
    /// </summary>
    [JsonPropertyName("usernameSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderRedisElasticacheUsernameSecretRef? UsernameSecretRef { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderRedshiftPasswordSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderRedshift
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Disable special character escaping in username and password.
    /// Disable special character escaping in username and password
    /// </summary>
    [JsonPropertyName("disableEscaping")]
    public bool? DisableEscaping { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderRedshiftPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderSnowflakePasswordSecretRef
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

/// <summary>The private key configured for the admin user in Snowflake.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderSnowflakePrivateKeyWoSecretRef
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecInitProviderSnowflake
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderSnowflakePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>The private key configured for the admin user in Snowflake.</summary>
    [JsonPropertyName("privateKeyWoSecretRef")]
    public V1alpha1SecretsMountSpecInitProviderSnowflakePrivateKeyWoSecretRef? PrivateKeyWoSecretRef { get; set; }

    /// <summary>Version counter for the private key key-pair credentials write-only field</summary>
    [JsonPropertyName("privateKeyWoVersion")]
    public double? PrivateKeyWoVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
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
public partial class V1alpha1SecretsMountSpecInitProvider
{
    /// <summary>
    /// Set of managed key registry entry names that the mount in question is allowed to access
    /// List of managed key registry entry names that the mount in question is allowed to access
    /// </summary>
    [JsonPropertyName("allowedManagedKeys")]
    public IList<string>? AllowedManagedKeys { get; set; }

    /// <summary>List of headers to allow and pass from the request to the plugin</summary>
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
    /// A nested block containing configuration options for Cassandra connections.
    /// See
    /// Connection parameters for the cassandra-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("cassandra")]
    public IList<V1alpha1SecretsMountSpecInitProviderCassandra>? Cassandra { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Couchbase connections.
    /// See
    /// Connection parameters for the couchbase-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("couchbase")]
    public IList<V1alpha1SecretsMountSpecInitProviderCouchbase>? Couchbase { get; set; }

    /// <summary>
    /// Default lease duration for tokens and secrets in seconds
    /// Default lease duration for tokens and secrets in seconds
    /// </summary>
    [JsonPropertyName("defaultLeaseTtlSeconds")]
    public double? DefaultLeaseTtlSeconds { get; set; }

    /// <summary>List of headers to allow and pass from the request to the plugin</summary>
    [JsonPropertyName("delegatedAuthAccessors")]
    public IList<string>? DelegatedAuthAccessors { get; set; }

    /// <summary>
    /// Human-friendly description of the mount
    /// Human-friendly description of the mount
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Elasticsearch connections.
    /// See
    /// Connection parameters for the elasticsearch-database-plugin.
    /// </summary>
    [JsonPropertyName("elasticsearch")]
    public IList<V1alpha1SecretsMountSpecInitProviderElasticsearch>? Elasticsearch { get; set; }

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
    /// A nested block containing configuration options for SAP HanaDB connections.
    /// See
    /// Connection parameters for the hana-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("hana")]
    public IList<V1alpha1SecretsMountSpecInitProviderHana>? Hana { get; set; }

    /// <summary>The key to use for signing plugin workload identity tokens</summary>
    [JsonPropertyName("identityTokenKey")]
    public string? IdentityTokenKey { get; set; }

    /// <summary>
    /// A nested block containing configuration options for InfluxDB connections.
    /// See
    /// Connection parameters for the influxdb-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("influxdb")]
    public IList<V1alpha1SecretsMountSpecInitProviderInfluxdb>? Influxdb { get; set; }

    /// <summary>Specifies whether to show this mount in the UI-specific listing endpoint</summary>
    [JsonPropertyName("listingVisibility")]
    public string? ListingVisibility { get; set; }

    /// <summary>
    /// Boolean flag that can be explicitly set to true to enforce local mount in HA environment
    /// Local mount flag that can be explicitly set to true to enforce local mount in HA environment
    /// </summary>
    [JsonPropertyName("local")]
    public bool? Local { get; set; }

    /// <summary>
    /// Maximum possible lease duration for tokens and secrets in seconds
    /// Maximum possible lease duration for tokens and secrets in seconds
    /// </summary>
    [JsonPropertyName("maxLeaseTtlSeconds")]
    public double? MaxLeaseTtlSeconds { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MongoDB connections.
    /// See
    /// Connection parameters for the mongodb-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mongodb")]
    public IList<V1alpha1SecretsMountSpecInitProviderMongodb>? Mongodb { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MongoDB Atlas connections.
    /// See
    /// Connection parameters for the mongodbatlas-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mongodbatlas")]
    public IList<V1alpha1SecretsMountSpecInitProviderMongodbatlas>? Mongodbatlas { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MSSQL connections.
    /// See
    /// Connection parameters for the mssql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mssql")]
    public IList<V1alpha1SecretsMountSpecInitProviderMssql>? Mssql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MySQL connections.
    /// See
    /// Connection parameters for the mysql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysql")]
    public IList<V1alpha1SecretsMountSpecInitProviderMysql>? Mysql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Aurora MySQL connections.
    /// See
    /// Connection parameters for the mysql-aurora-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlAurora")]
    public IList<V1alpha1SecretsMountSpecInitProviderMysqlAurora>? MysqlAurora { get; set; }

    /// <summary>
    /// A nested block containing configuration options for legacy MySQL connections.
    /// See
    /// Connection parameters for the mysql-legacy-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlLegacy")]
    public IList<V1alpha1SecretsMountSpecInitProviderMysqlLegacy>? MysqlLegacy { get; set; }

    /// <summary>
    /// A nested block containing configuration options for RDS MySQL connections.
    /// See
    /// Connection parameters for the mysql-rds-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlRds")]
    public IList<V1alpha1SecretsMountSpecInitProviderMysqlRds>? MysqlRds { get; set; }

    /// <summary>Target namespace. (requires Enterprise)</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Specifies mount type specific options that are passed to the backend
    /// Specifies mount type specific options that are passed to the backend
    /// </summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Oracle connections.
    /// See
    /// Connection parameters for the oracle-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("oracle")]
    public IList<V1alpha1SecretsMountSpecInitProviderOracle>? Oracle { get; set; }

    /// <summary>List of headers to allow and pass from the request to the plugin</summary>
    [JsonPropertyName("passthroughRequestHeaders")]
    public IList<string>? PassthroughRequestHeaders { get; set; }

    /// <summary>
    /// Where the secret backend will be mounted
    /// Where the secret backend will be mounted
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Specifies the semantic version of the plugin to use, e.g. &apos;v1.0.0&apos;
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A nested block containing configuration options for PostgreSQL connections.
    /// See
    /// Connection parameters for the postgresql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("postgresql")]
    public IList<V1alpha1SecretsMountSpecInitProviderPostgresql>? Postgresql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Redis connections.
    /// See
    /// Connection parameters for the redis-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("redis")]
    public IList<V1alpha1SecretsMountSpecInitProviderRedis>? Redis { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Redis ElastiCache connections.
    /// See
    /// Connection parameters for the redis-elasticache-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("redisElasticache")]
    public IList<V1alpha1SecretsMountSpecInitProviderRedisElasticache>? RedisElasticache { get; set; }

    /// <summary>
    /// A nested block containing configuration options for AWS Redshift connections.
    /// See
    /// Connection parameters for the redshift-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("redshift")]
    public IList<V1alpha1SecretsMountSpecInitProviderRedshift>? Redshift { get; set; }

    /// <summary>
    /// Boolean flag that can be explicitly set to true to enable seal wrapping for the mount, causing values stored by the mount to be wrapped by the seal&apos;s encryption capability
    /// Enable seal wrapping for the mount, causing values stored by the mount to be wrapped by the seal&apos;s encryption capability
    /// </summary>
    [JsonPropertyName("sealWrap")]
    public bool? SealWrap { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Snowflake connections.
    /// See
    /// Connection parameters for the snowflake-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("snowflake")]
    public IList<V1alpha1SecretsMountSpecInitProviderSnowflake>? Snowflake { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretsMountSpecManagementPoliciesEnum>))]
public enum V1alpha1SecretsMountSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretsMountSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1SecretsMountSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretsMountSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1SecretsMountSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretsMountSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretsMountSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretsMountSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SecretsMountSpec defines the desired state of SecretsMount</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountSpec
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
    public V1alpha1SecretsMountSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1SecretsMountSpecForProvider ForProvider { get; set; }

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
    public V1alpha1SecretsMountSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1SecretsMountSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SecretsMountSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SecretsMountSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderCassandra
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// The number of seconds to use as a connection
    /// timeout.
    /// The number of seconds to use as a connection timeout.
    /// </summary>
    [JsonPropertyName("connectTimeout")]
    public double? ConnectTimeout { get; set; }

    /// <summary>
    /// Specifies the consistency option to use. See the gocql definition for valid options.
    /// Cassandra consistency level.
    /// </summary>
    [JsonPropertyName("consistency")]
    public string? Consistency { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The hosts to connect to.
    /// Cassandra hosts to connect to.
    /// </summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>
    /// Whether to skip verification of the server
    /// certificate when using TLS.
    /// Whether to skip verification of the server certificate when using TLS.
    /// </summary>
    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>
    /// If set, enables host selection policy which will prioritize and use hosts which are in the local datacenter before hosts in all other datacenters.
    /// Cassandra local datacenter name.
    /// </summary>
    [JsonPropertyName("localDatacenter")]
    public string? LocalDatacenter { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// The default port to connect to if no port is specified as
    /// part of the host.
    /// The transport port to use to connect to Cassandra.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The CQL protocol version to use.
    /// The CQL protocol version to use.
    /// </summary>
    [JsonPropertyName("protocolVersion")]
    public double? ProtocolVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>Skip permissions checks when a connection to Cassandra is first created. These checks ensure that Vault is able to create roles, but can be resource intensive in clusters with many roles.</summary>
    [JsonPropertyName("skipVerification")]
    public bool? SkipVerification { get; set; }

    /// <summary>
    /// The keep-alive period for an active network connection. If zero, keep-alives are not enabled.
    /// Enable TCP keepalive for Cassandra connections.
    /// </summary>
    [JsonPropertyName("socketKeepAlive")]
    public string? SocketKeepAlive { get; set; }

    /// <summary>
    /// Whether to use TLS when connecting to Cassandra.
    /// Whether to use TLS when connecting to Cassandra.
    /// </summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }

    /// <summary>
    /// Specifies the name to use as the SNI host when connecting to the Cassandra server via TLS.
    /// SNI host for TLS connections.
    /// </summary>
    [JsonPropertyName("tlsServerName")]
    public string? TlsServerName { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The username to use when authenticating with Cassandra.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Template for dynamic Cassandra usernames.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderCouchbase
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// Required for Couchbase versions prior to 6.5.0. This is only used to verify vault&apos;s connection to the server.
    /// Required for Couchbase versions prior to 6.5.0. This is only used to verify vault&apos;s connection to the server.
    /// </summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The hosts to connect to.
    /// A set of Couchbase URIs to connect to. Must use `couchbases://` scheme if `tls` is `true`.
    /// </summary>
    [JsonPropertyName("hosts")]
    public IList<string>? Hosts { get; set; }

    /// <summary>
    /// Whether to skip verification of the server
    /// certificate when using TLS.
    /// Specifies whether to skip verification of the server certificate when using TLS.
    /// </summary>
    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// Whether to use TLS when connecting to Cassandra.
    /// Specifies whether to use TLS when connecting to Couchbase.
    /// </summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// Specifies the username for Vault to use.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Template describing how dynamic usernames are generated.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderElasticsearch
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// The path to a PEM-encoded CA cert file to use to verify the Elasticsearch server&apos;s identity.
    /// The path to a PEM-encoded CA cert file to use to verify the Elasticsearch server&apos;s identity
    /// </summary>
    [JsonPropertyName("caCert")]
    public string? CaCert { get; set; }

    /// <summary>
    /// The path to a directory of PEM-encoded CA cert files to use to verify the Elasticsearch server&apos;s identity.
    /// The path to a directory of PEM-encoded CA cert files to use to verify the Elasticsearch server&apos;s identity
    /// </summary>
    [JsonPropertyName("caPath")]
    public string? CaPath { get; set; }

    /// <summary>
    /// The path to the certificate for the Elasticsearch client to present for communication.
    /// The path to the certificate for the Elasticsearch client to present for communication
    /// </summary>
    [JsonPropertyName("clientCert")]
    public string? ClientCert { get; set; }

    /// <summary>
    /// The path to the key for the Elasticsearch client to use for communication.
    /// The path to the key for the Elasticsearch client to use for communication
    /// </summary>
    [JsonPropertyName("clientKey")]
    public string? ClientKey { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Whether to disable certificate verification.
    /// Whether to disable certificate verification
    /// </summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// Specifies the name to use as the SNI host when connecting to the Cassandra server via TLS.
    /// This, if set, is used to set the SNI host when connecting via TLS
    /// </summary>
    [JsonPropertyName("tlsServerName")]
    public string? TlsServerName { get; set; }

    /// <summary>
    /// The URL for Elasticsearch&apos;s API. https requires certificate
    /// by trusted CA if used.
    /// The URL for Elasticsearch&apos;s API
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The username to be used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Template describing how dynamic usernames are generated.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderHana
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Disable special character escaping in username and password.
    /// Disable special character escaping in username and password
    /// </summary>
    [JsonPropertyName("disableEscaping")]
    public bool? DisableEscaping { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderInfluxdb
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// The number of seconds to use as a connection
    /// timeout.
    /// The number of seconds to use as a connection timeout.
    /// </summary>
    [JsonPropertyName("connectTimeout")]
    public double? ConnectTimeout { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The host to connect to.
    /// Influxdb host to connect to.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// Whether to skip verification of the server
    /// certificate when using TLS.
    /// Whether to skip verification of the server certificate when using TLS.
    /// </summary>
    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// The default port to connect to if no port is specified as
    /// part of the host.
    /// The transport port to use to connect to Influxdb.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// Whether to use TLS when connecting to Cassandra.
    /// Whether to use TLS when connecting to Influxdb.
    /// </summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// Specifies the username to use for superuser access.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Template describing how dynamic usernames are generated.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderMongodb
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// The x509 CA file for validating the certificate presented by the MongoDB server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }

    /// <summary>Specifies the MongoDB write concern for Vault management operations.</summary>
    [JsonPropertyName("writeConcern")]
    public string? WriteConcern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderMongodbatlas
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// The Project ID the Database User should be created within.
    /// The Project ID the Database User should be created within.
    /// </summary>
    [JsonPropertyName("projectId")]
    public string? ProjectId { get; set; }

    /// <summary>
    /// The Public Programmatic API Key used to authenticate with the MongoDB Atlas API.
    /// The Public Programmatic API Key used to authenticate with the MongoDB Atlas API.
    /// </summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Template describing how dynamic usernames are generated.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderMssql
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// For Vault v1.9+. Set to true when the target is a
    /// Contained Database, e.g. AzureSQL.
    /// See Vault docs
    /// Set to true when the target is a Contained Database, e.g. AzureSQL.
    /// </summary>
    [JsonPropertyName("containedDb")]
    public bool? ContainedDb { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Disable special character escaping in username and password.
    /// Disable special character escaping in username and password
    /// </summary>
    [JsonPropertyName("disableEscaping")]
    public bool? DisableEscaping { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderMysql
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderMysqlAurora
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderMysqlLegacy
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderMysqlRds
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderOracle
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>Set to true to disconnect any open sessions prior to running the revocation statements.</summary>
    [JsonPropertyName("disconnectSessions")]
    public bool? DisconnectSessions { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>If set, allows onboarding static roles with a rootless connection configuration.</summary>
    [JsonPropertyName("selfManaged")]
    public bool? SelfManaged { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>Set to true in order to split statements after semi-colons.</summary>
    [JsonPropertyName("splitStatements")]
    public bool? SplitStatements { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderPostgresql
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)</summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Disable special character escaping in username and password.
    /// Disable special character escaping in username and password
    /// </summary>
    [JsonPropertyName("disableEscaping")]
    public bool? DisableEscaping { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>When set to `scram-sha-256`, passwords will be hashed by Vault before being sent to PostgreSQL.</summary>
    [JsonPropertyName("passwordAuthentication")]
    public string? PasswordAuthentication { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>If set, allows onboarding static roles with a rootless connection configuration.</summary>
    [JsonPropertyName("selfManaged")]
    public bool? SelfManaged { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// The x509 CA file for validating the certificate presented by the PostgreSQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>The x509 client certificate for connecting to the database. Must be PEM encoded.</summary>
    [JsonPropertyName("tlsCertificate")]
    public string? TlsCertificate { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderRedis
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// The path to a PEM-encoded CA cert file to use to verify the Elasticsearch server&apos;s identity.
    /// The contents of a PEM-encoded CA cert file to use to verify the Redis server&apos;s identity.
    /// </summary>
    [JsonPropertyName("caCert")]
    public string? CaCert { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The host to connect to.
    /// Specifies the host to connect to
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// Whether to skip verification of the server
    /// certificate when using TLS.
    /// Specifies whether to skip verification of the server certificate when using TLS.
    /// </summary>
    [JsonPropertyName("insecureTls")]
    public bool? InsecureTls { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// The default port to connect to if no port is specified as
    /// part of the host.
    /// The transport port to use to connect to Redis.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// Whether to use TLS when connecting to Cassandra.
    /// Specifies whether to use TLS when connecting to Redis.
    /// </summary>
    [JsonPropertyName("tls")]
    public bool? Tls { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// Specifies the username for Vault to use.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderRedisElasticache
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// The AWS region where the ElastiCache cluster is hosted.
    /// If omitted the plugin tries to infer the region from the environment.
    /// The AWS region where the ElastiCache cluster is hosted. If omitted the plugin tries to infer the region from the environment.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// The URL for Elasticsearch&apos;s API. https requires certificate
    /// by trusted CA if used.
    /// The configuration endpoint for the ElastiCache cluster to connect to.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderRedshift
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// Disable special character escaping in username and password.
    /// Disable special character escaping in username and password
    /// </summary>
    [JsonPropertyName("disableEscaping")]
    public bool? DisableEscaping { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProviderSnowflake
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// A URL containing connection information.
    /// See Vault docs
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// A map of sensitive data to pass to the endpoint. Useful for templated connection strings.
    /// </summary>
    [JsonPropertyName("data")]
    public IDictionary<string, string>? Data { get; set; }

    /// <summary>
    /// Cancels all upcoming rotations of the root credential until unset. Requires Vault Enterprise 1.19+.
    /// Stops rotation of the root credential until set to false.
    /// </summary>
    [JsonPropertyName("disableAutomatedRotation")]
    public bool? DisableAutomatedRotation { get; set; }

    /// <summary>
    /// The maximum number of seconds to keep
    /// a connection alive for.
    /// Maximum number of seconds a connection may be reused.
    /// </summary>
    [JsonPropertyName("maxConnectionLifetime")]
    public double? MaxConnectionLifetime { get; set; }

    /// <summary>
    /// The maximum number of idle connections to
    /// maintain.
    /// Maximum number of idle connections to the database.
    /// </summary>
    [JsonPropertyName("maxIdleConnections")]
    public double? MaxIdleConnections { get; set; }

    /// <summary>
    /// The maximum number of open connections to
    /// use.
    /// Maximum number of open connections to the database.
    /// </summary>
    [JsonPropertyName("maxOpenConnections")]
    public double? MaxOpenConnections { get; set; }

    /// <summary>
    /// for any configured database engine is changed
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// Optional name of the password policy to use for generated passwords.
    /// </summary>
    [JsonPropertyName("passwordPolicy")]
    public string? PasswordPolicy { get; set; }

    /// <summary>
    /// The password for the user. Can be updated.
    /// Note: This property is write-only and will not be read from the API.
    /// Write-only field for the root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordWo")]
    public string? PasswordWo { get; set; }

    /// <summary>
    /// The version of the password_wo. For more info see updating write-only attributes.
    /// Version counter for root credential password write-only field
    /// </summary>
    [JsonPropertyName("passwordWoVersion")]
    public double? PasswordWoVersion { get; set; }

    /// <summary>
    /// Specifies the name of the plugin to use.
    /// Specifies the name of the plugin to use for this connection. Must be prefixed with the name of one of the supported database engine types.
    /// </summary>
    [JsonPropertyName("pluginName")]
    public string? PluginName { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Optional plugin version to use for this connection.
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>Version counter for the private key key-pair credentials write-only field</summary>
    [JsonPropertyName("privateKeyWoVersion")]
    public double? PrivateKeyWoVersion { get; set; }

    /// <summary>
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// A list of database statements to be executed to rotate the root user&apos;s credentials.
    /// </summary>
    [JsonPropertyName("rootRotationStatements")]
    public IList<string>? RootRotationStatements { get; set; }

    /// <summary>
    /// The amount of time in seconds Vault should wait before rotating the root credential.
    /// A zero value tells Vault not to rotate the root credential. The minimum rotation period is 10 seconds. Requires Vault Enterprise 1.19+.
    /// The period of time in seconds between each rotation of the root credential. Cannot be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationPeriod")]
    public double? RotationPeriod { get; set; }

    /// <summary>
    /// The schedule, in cron-style time format,
    /// defining the schedule on which Vault should rotate the root token. Requires Vault Enterprise 1.19+.
    /// The cron-style schedule for the root credential to be rotated on. Cannot be used with rotation_period.
    /// </summary>
    [JsonPropertyName("rotationSchedule")]
    public string? RotationSchedule { get; set; }

    /// <summary>
    /// The maximum amount of time in seconds allowed to complete
    /// a rotation when a scheduled token rotation occurs. The default rotation window is
    /// unbound and the minimum allowable window is 3600. Requires Vault Enterprise 1.19+.
    /// The maximum amount of time in seconds Vault is allowed to complete a rotation once a scheduled rotation is triggered. Can only be used with rotation_schedule.
    /// </summary>
    [JsonPropertyName("rotationWindow")]
    public double? RotationWindow { get; set; }

    /// <summary>
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false. Requires Vault Enterprise 1.19+.
    /// Skip rotation of static role credentials on import.
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The root credential username used in the connection URL
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>
    /// Template describing how dynamic usernames are generated.
    /// Username generation template.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusAtProvider
{
    /// <summary>Accessor of the mount</summary>
    [JsonPropertyName("accessor")]
    public string? Accessor { get; set; }

    /// <summary>
    /// Set of managed key registry entry names that the mount in question is allowed to access
    /// List of managed key registry entry names that the mount in question is allowed to access
    /// </summary>
    [JsonPropertyName("allowedManagedKeys")]
    public IList<string>? AllowedManagedKeys { get; set; }

    /// <summary>List of headers to allow and pass from the request to the plugin</summary>
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
    /// A nested block containing configuration options for Cassandra connections.
    /// See
    /// Connection parameters for the cassandra-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("cassandra")]
    public IList<V1alpha1SecretsMountStatusAtProviderCassandra>? Cassandra { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Couchbase connections.
    /// See
    /// Connection parameters for the couchbase-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("couchbase")]
    public IList<V1alpha1SecretsMountStatusAtProviderCouchbase>? Couchbase { get; set; }

    /// <summary>
    /// Default lease duration for tokens and secrets in seconds
    /// Default lease duration for tokens and secrets in seconds
    /// </summary>
    [JsonPropertyName("defaultLeaseTtlSeconds")]
    public double? DefaultLeaseTtlSeconds { get; set; }

    /// <summary>List of headers to allow and pass from the request to the plugin</summary>
    [JsonPropertyName("delegatedAuthAccessors")]
    public IList<string>? DelegatedAuthAccessors { get; set; }

    /// <summary>
    /// Human-friendly description of the mount
    /// Human-friendly description of the mount
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Elasticsearch connections.
    /// See
    /// Connection parameters for the elasticsearch-database-plugin.
    /// </summary>
    [JsonPropertyName("elasticsearch")]
    public IList<V1alpha1SecretsMountStatusAtProviderElasticsearch>? Elasticsearch { get; set; }

    /// <summary>
    /// The total number of database secrets engines configured.
    /// Total number of database secret engines configured under the mount.
    /// </summary>
    [JsonPropertyName("engineCount")]
    public double? EngineCount { get; set; }

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
    /// A nested block containing configuration options for SAP HanaDB connections.
    /// See
    /// Connection parameters for the hana-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("hana")]
    public IList<V1alpha1SecretsMountStatusAtProviderHana>? Hana { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The key to use for signing plugin workload identity tokens</summary>
    [JsonPropertyName("identityTokenKey")]
    public string? IdentityTokenKey { get; set; }

    /// <summary>
    /// A nested block containing configuration options for InfluxDB connections.
    /// See
    /// Connection parameters for the influxdb-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("influxdb")]
    public IList<V1alpha1SecretsMountStatusAtProviderInfluxdb>? Influxdb { get; set; }

    /// <summary>Specifies whether to show this mount in the UI-specific listing endpoint</summary>
    [JsonPropertyName("listingVisibility")]
    public string? ListingVisibility { get; set; }

    /// <summary>
    /// Boolean flag that can be explicitly set to true to enforce local mount in HA environment
    /// Local mount flag that can be explicitly set to true to enforce local mount in HA environment
    /// </summary>
    [JsonPropertyName("local")]
    public bool? Local { get; set; }

    /// <summary>
    /// Maximum possible lease duration for tokens and secrets in seconds
    /// Maximum possible lease duration for tokens and secrets in seconds
    /// </summary>
    [JsonPropertyName("maxLeaseTtlSeconds")]
    public double? MaxLeaseTtlSeconds { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MongoDB connections.
    /// See
    /// Connection parameters for the mongodb-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mongodb")]
    public IList<V1alpha1SecretsMountStatusAtProviderMongodb>? Mongodb { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MongoDB Atlas connections.
    /// See
    /// Connection parameters for the mongodbatlas-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mongodbatlas")]
    public IList<V1alpha1SecretsMountStatusAtProviderMongodbatlas>? Mongodbatlas { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MSSQL connections.
    /// See
    /// Connection parameters for the mssql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mssql")]
    public IList<V1alpha1SecretsMountStatusAtProviderMssql>? Mssql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MySQL connections.
    /// See
    /// Connection parameters for the mysql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysql")]
    public IList<V1alpha1SecretsMountStatusAtProviderMysql>? Mysql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Aurora MySQL connections.
    /// See
    /// Connection parameters for the mysql-aurora-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlAurora")]
    public IList<V1alpha1SecretsMountStatusAtProviderMysqlAurora>? MysqlAurora { get; set; }

    /// <summary>
    /// A nested block containing configuration options for legacy MySQL connections.
    /// See
    /// Connection parameters for the mysql-legacy-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlLegacy")]
    public IList<V1alpha1SecretsMountStatusAtProviderMysqlLegacy>? MysqlLegacy { get; set; }

    /// <summary>
    /// A nested block containing configuration options for RDS MySQL connections.
    /// See
    /// Connection parameters for the mysql-rds-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlRds")]
    public IList<V1alpha1SecretsMountStatusAtProviderMysqlRds>? MysqlRds { get; set; }

    /// <summary>Target namespace. (requires Enterprise)</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Specifies mount type specific options that are passed to the backend
    /// Specifies mount type specific options that are passed to the backend
    /// </summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Oracle connections.
    /// See
    /// Connection parameters for the oracle-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("oracle")]
    public IList<V1alpha1SecretsMountStatusAtProviderOracle>? Oracle { get; set; }

    /// <summary>List of headers to allow and pass from the request to the plugin</summary>
    [JsonPropertyName("passthroughRequestHeaders")]
    public IList<string>? PassthroughRequestHeaders { get; set; }

    /// <summary>
    /// Where the secret backend will be mounted
    /// Where the secret backend will be mounted
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Specifies the semantic version of the plugin to use for this connection.
    /// Specifies the semantic version of the plugin to use, e.g. &apos;v1.0.0&apos;
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A nested block containing configuration options for PostgreSQL connections.
    /// See
    /// Connection parameters for the postgresql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("postgresql")]
    public IList<V1alpha1SecretsMountStatusAtProviderPostgresql>? Postgresql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Redis connections.
    /// See
    /// Connection parameters for the redis-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("redis")]
    public IList<V1alpha1SecretsMountStatusAtProviderRedis>? Redis { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Redis ElastiCache connections.
    /// See
    /// Connection parameters for the redis-elasticache-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("redisElasticache")]
    public IList<V1alpha1SecretsMountStatusAtProviderRedisElasticache>? RedisElasticache { get; set; }

    /// <summary>
    /// A nested block containing configuration options for AWS Redshift connections.
    /// See
    /// Connection parameters for the redshift-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("redshift")]
    public IList<V1alpha1SecretsMountStatusAtProviderRedshift>? Redshift { get; set; }

    /// <summary>
    /// Boolean flag that can be explicitly set to true to enable seal wrapping for the mount, causing values stored by the mount to be wrapped by the seal&apos;s encryption capability
    /// Enable seal wrapping for the mount, causing values stored by the mount to be wrapped by the seal&apos;s encryption capability
    /// </summary>
    [JsonPropertyName("sealWrap")]
    public bool? SealWrap { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Snowflake connections.
    /// See
    /// Connection parameters for the snowflake-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("snowflake")]
    public IList<V1alpha1SecretsMountStatusAtProviderSnowflake>? Snowflake { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatusConditions
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

/// <summary>SecretsMountStatus defines the observed state of SecretsMount.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretsMountStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1SecretsMountStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecretsMountStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SecretsMount is the Schema for the SecretsMounts API. Configures any number of database secrets engines under a single mount resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretsMount : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretsMountSpec>, IStatus<V1alpha1SecretsMountStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretsMount";
    public const string KubeGroup = "database.vault.upbound.io";
    public const string KubePluralName = "secretsmounts";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "database.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretsMount";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretsMountSpec defines the desired state of SecretsMount</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SecretsMountSpec Spec { get; set; }

    /// <summary>SecretsMountStatus defines the observed state of SecretsMount.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecretsMountStatus? Status { get; set; }
}