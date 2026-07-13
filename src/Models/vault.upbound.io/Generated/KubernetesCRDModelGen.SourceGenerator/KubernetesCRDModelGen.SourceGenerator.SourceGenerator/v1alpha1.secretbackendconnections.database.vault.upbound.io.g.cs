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
/// <summary>SecretBackendConnection is the Schema for the SecretBackendConnections API. Configures a database secret backend connection for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendConnectionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1SecretBackendConnection>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendConnectionList";
    public const string KubeGroup = "database.vault.upbound.io";
    public const string KubePluralName = "secretbackendconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "database.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendConnectionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1SecretBackendConnection objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1SecretBackendConnection> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendConnectionSpecDeletionPolicyEnum>))]
public enum V1alpha1SecretBackendConnectionSpecDeletionPolicyEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendConnectionSpecForProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendConnectionSpecForProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendConnectionSpecForProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendConnectionSpecForProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendConnectionSpecForProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendConnectionSpecForProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendConnectionSpecForProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendConnectionSpecForProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendConnectionSpecForProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendConnectionSpecForProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendConnectionSpecForProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendConnectionSpecForProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendConnectionSpecForProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderBackendSelector
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
    public V1alpha1SecretBackendConnectionSpecForProviderBackendSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The password to use when authenticating with Cassandra.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderCassandraPasswordSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderCassandraPemBundleSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderCassandraPemJsonSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderCassandra
{
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
    /// The password to authenticate with.
    /// The password to use when authenticating with Cassandra.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderCassandraPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// Concatenated PEM blocks configuring the certificate
    /// chain.
    /// Concatenated PEM blocks containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
    /// </summary>
    [JsonPropertyName("pemBundleSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderCassandraPemBundleSecretRef? PemBundleSecretRef { get; set; }

    /// <summary>
    /// A JSON structure configuring the certificate chain.
    /// Specifies JSON containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
    /// </summary>
    [JsonPropertyName("pemJsonSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderCassandraPemJsonSecretRef? PemJsonSecretRef { get; set; }

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
    /// Skip permissions checks when a connection to Cassandra is first created.
    /// These checks ensure that Vault is able to create roles, but can be resource intensive in clusters with many roles.
    /// Skip permissions checks when a connection to Cassandra is first created. These checks ensure that Vault is able to create roles, but can be resource intensive in clusters with many roles.
    /// </summary>
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
}

/// <summary>
/// Required if tls is true. Specifies the certificate authority of the Couchbase server, as a PEM certificate that has been base64 encoded.
/// Required if `tls` is `true`. Specifies the certificate authority of the Couchbase server, as a PEM certificate that has been base64 encoded.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderCouchbaseBase64PemSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderCouchbasePasswordSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderCouchbase
{
    /// <summary>
    /// Required if tls is true. Specifies the certificate authority of the Couchbase server, as a PEM certificate that has been base64 encoded.
    /// Required if `tls` is `true`. Specifies the certificate authority of the Couchbase server, as a PEM certificate that has been base64 encoded.
    /// </summary>
    [JsonPropertyName("base64PemSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderCouchbaseBase64PemSecretRef? Base64PemSecretRef { get; set; }

    /// <summary>
    /// Required for Couchbase versions prior to 6.5.0. This is only used to verify vault&apos;s connection to the server.
    /// Required for Couchbase versions prior to 6.5.0. This is only used to verify vault&apos;s connection to the server.
    /// </summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

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
    /// The password to authenticate with.
    /// Specifies the password corresponding to the given username.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderCouchbasePasswordSecretRef? PasswordSecretRef { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The password to be used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderElasticsearchPasswordSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderElasticsearch
{
    /// <summary>
    /// The contents of a PEM-encoded CA cert file to use to verify the Redis server&apos;s identity.
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
    /// Whether to disable certificate verification.
    /// Whether to disable certificate verification
    /// </summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The password to be used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderElasticsearchPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// Specifies the name to use as the SNI host when connecting to the Cassandra server via TLS.
    /// This, if set, is used to set the SNI host when connecting via TLS
    /// </summary>
    [JsonPropertyName("tlsServerName")]
    public string? TlsServerName { get; set; }

    /// <summary>
    /// The url to connect to including the port; e.g. master.my-cluster.xxxxxx.use1.cache.amazonaws.com:6379.
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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderHanaPasswordSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderHana
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderHanaPasswordSecretRef? PasswordSecretRef { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// Specifies the password corresponding to the given username.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderInfluxdbPasswordSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderInfluxdbPemBundleSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderInfluxdbPemJsonSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderInfluxdb
{
    /// <summary>
    /// The number of seconds to use as a connection
    /// timeout.
    /// The number of seconds to use as a connection timeout.
    /// </summary>
    [JsonPropertyName("connectTimeout")]
    public double? ConnectTimeout { get; set; }

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
    /// The password to authenticate with.
    /// Specifies the password corresponding to the given username.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderInfluxdbPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// Concatenated PEM blocks configuring the certificate
    /// chain.
    /// Concatenated PEM blocks containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
    /// </summary>
    [JsonPropertyName("pemBundleSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderInfluxdbPemBundleSecretRef? PemBundleSecretRef { get; set; }

    /// <summary>
    /// A JSON structure configuring the certificate chain.
    /// Specifies JSON containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
    /// </summary>
    [JsonPropertyName("pemJsonSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderInfluxdbPemJsonSecretRef? PemJsonSecretRef { get; set; }

    /// <summary>
    /// The default port to connect to if no port is specified as
    /// part of the host.
    /// The transport port to use to connect to Influxdb.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderMongodbPasswordSecretRef
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
/// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
/// The x509 certificate and private key bundle for connecting to the database. Must be PEM encoded.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderMongodbTlsCertificateKeySecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderMongodb
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderMongodbPasswordSecretRef? PasswordSecretRef { get; set; }

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
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
    /// The x509 CA file for validating the certificate presented by the MongoDB server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
    /// The x509 certificate and private key bundle for connecting to the database. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderMongodbTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

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
    /// A JSON string specifying the MongoDB write concern. For example: {&quot;wmode&quot;: &quot;majority&quot;, &quot;wtimeout&quot;: 5000}.
    /// Specifies the MongoDB write concern for Vault management operations.
    /// </summary>
    [JsonPropertyName("writeConcern")]
    public string? WriteConcern { get; set; }
}

/// <summary>
/// The Private Programmatic API Key used to connect with MongoDB Atlas API.
/// The Private Programmatic API Key used to connect with MongoDB Atlas API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderMongodbatlasPrivateKeySecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderMongodbatlas
{
    /// <summary>
    /// The Private Programmatic API Key used to connect with MongoDB Atlas API.
    /// The Private Programmatic API Key used to connect with MongoDB Atlas API.
    /// </summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderMongodbatlasPrivateKeySecretRef? PrivateKeySecretRef { get; set; }

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
    /// Template describing how dynamic usernames are generated.
    /// Template describing how dynamic usernames are generated.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderMssqlPasswordSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderMssql
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// For Vault v1.9+. Set to true when the target is a
    /// Contained Database, e.g. AzureSQL.
    /// See the Vault
    /// docs
    /// Set to true when the target is a Contained Database, e.g. AzureSQL.
    /// </summary>
    [JsonPropertyName("containedDb")]
    public bool? ContainedDb { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderMssqlPasswordSecretRef? PasswordSecretRef { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderMysqlPasswordSecretRef
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
/// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
/// A JSON encoded credential for use with IAM authorization
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderMysqlServiceAccountJsonSecretRef
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
/// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderMysqlTlsCertificateKeySecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderMysql
{
    /// <summary>
    /// Enable IAM authentication to a Google Cloud instance when set to gcp_iam
    /// Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)
    /// </summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderMysqlPasswordSecretRef? PasswordSecretRef { get; set; }

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
    /// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
    /// A JSON encoded credential for use with IAM authorization
    /// </summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderMysqlServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderMysqlTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderMysqlAuroraPasswordSecretRef
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
/// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
/// A JSON encoded credential for use with IAM authorization
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderMysqlAuroraServiceAccountJsonSecretRef
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
/// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderMysqlAuroraTlsCertificateKeySecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderMysqlAurora
{
    /// <summary>
    /// Enable IAM authentication to a Google Cloud instance when set to gcp_iam
    /// Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)
    /// </summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderMysqlAuroraPasswordSecretRef? PasswordSecretRef { get; set; }

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
    /// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
    /// A JSON encoded credential for use with IAM authorization
    /// </summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderMysqlAuroraServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderMysqlAuroraTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderMysqlLegacyPasswordSecretRef
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
/// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
/// A JSON encoded credential for use with IAM authorization
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderMysqlLegacyServiceAccountJsonSecretRef
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
/// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderMysqlLegacyTlsCertificateKeySecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderMysqlLegacy
{
    /// <summary>
    /// Enable IAM authentication to a Google Cloud instance when set to gcp_iam
    /// Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)
    /// </summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderMysqlLegacyPasswordSecretRef? PasswordSecretRef { get; set; }

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
    /// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
    /// A JSON encoded credential for use with IAM authorization
    /// </summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderMysqlLegacyServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderMysqlLegacyTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderMysqlRdsPasswordSecretRef
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
/// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
/// A JSON encoded credential for use with IAM authorization
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderMysqlRdsServiceAccountJsonSecretRef
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
/// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderMysqlRdsTlsCertificateKeySecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderMysqlRds
{
    /// <summary>
    /// Enable IAM authentication to a Google Cloud instance when set to gcp_iam
    /// Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)
    /// </summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderMysqlRdsPasswordSecretRef? PasswordSecretRef { get; set; }

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
    /// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
    /// A JSON encoded credential for use with IAM authorization
    /// </summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderMysqlRdsServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderMysqlRdsTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderOraclePasswordSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderOracle
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// Enable the built-in session disconnect mechanism.
    /// Set to true to disconnect any open sessions prior to running the revocation statements.
    /// </summary>
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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderOraclePasswordSecretRef? PasswordSecretRef { get; set; }

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
    /// If set, allows onboarding static roles with a rootless
    /// connection configuration. Mutually exclusive with username and password.
    /// If set, will force verify_connection to be false. Requires Vault 1.18+ Enterprise.
    /// If set, allows onboarding static roles with a rootless connection configuration.
    /// </summary>
    [JsonPropertyName("selfManaged")]
    public bool? SelfManaged { get; set; }

    /// <summary>
    /// Enable spliting statements after semi-colons.
    /// Set to true in order to split statements after semi-colons.
    /// </summary>
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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderPostgresqlPasswordSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderPostgresqlPrivateKeySecretRef
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
/// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
/// A JSON encoded credential for use with IAM authorization
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderPostgresqlServiceAccountJsonSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderPostgresql
{
    /// <summary>
    /// Enable IAM authentication to a Google Cloud instance when set to gcp_iam
    /// Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)
    /// </summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// When set to scram-sha-256, passwords will be
    /// hashed by Vault before being sent to PostgreSQL. See the Vault docs
    /// for an example. Requires Vault 1.14+.
    /// When set to `scram-sha-256`, passwords will be hashed by Vault before being sent to PostgreSQL.
    /// </summary>
    [JsonPropertyName("passwordAuthentication")]
    public string? PasswordAuthentication { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderPostgresqlPasswordSecretRef? PasswordSecretRef { get; set; }

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
    /// The Private Programmatic API Key used to connect with MongoDB Atlas API.
    /// The secret key used for the x509 client certificate. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderPostgresqlPrivateKeySecretRef? PrivateKeySecretRef { get; set; }

    /// <summary>
    /// If set, allows onboarding static roles with a rootless
    /// connection configuration. Mutually exclusive with username and password.
    /// If set, will force verify_connection to be false. Requires Vault 1.18+ Enterprise.
    /// If set, allows onboarding static roles with a rootless connection configuration.
    /// </summary>
    [JsonPropertyName("selfManaged")]
    public bool? SelfManaged { get; set; }

    /// <summary>
    /// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
    /// A JSON encoded credential for use with IAM authorization
    /// </summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderPostgresqlServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
    /// The x509 CA file for validating the certificate presented by the PostgreSQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The x509 client certificate for connecting to
    /// the database. Must be PEM encoded.
    /// The x509 client certificate for connecting to the database. Must be PEM encoded.
    /// </summary>
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
}

/// <summary>
/// The password to authenticate with.
/// Specifies the password corresponding to the given username.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderRedisPasswordSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderRedis
{
    /// <summary>
    /// The contents of a PEM-encoded CA cert file to use to verify the Redis server&apos;s identity.
    /// The contents of a PEM-encoded CA cert file to use to verify the Redis server&apos;s identity.
    /// </summary>
    [JsonPropertyName("caCert")]
    public string? CaCert { get; set; }

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
    /// The password to authenticate with.
    /// Specifies the password corresponding to the given username.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderRedisPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The default port to connect to if no port is specified as
    /// part of the host.
    /// The transport port to use to connect to Redis.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The AWS secret key id to use to talk to ElastiCache. If omitted the credentials chain provider is used instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderRedisElasticachePasswordSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderRedisElasticacheUsernameSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderRedisElasticache
{
    /// <summary>
    /// The password to authenticate with.
    /// The AWS secret key id to use to talk to ElastiCache. If omitted the credentials chain provider is used instead.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderRedisElasticachePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The region where the ElastiCache cluster is hosted. If omitted Vault tries to infer from the environment instead.
    /// The AWS region where the ElastiCache cluster is hosted. If omitted the plugin tries to infer the region from the environment.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// The url to connect to including the port; e.g. master.my-cluster.xxxxxx.use1.cache.amazonaws.com:6379.
    /// The configuration endpoint for the ElastiCache cluster to connect to.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The AWS access key id to use to talk to ElastiCache. If omitted the credentials chain provider is used instead.
    /// </summary>
    [JsonPropertyName("usernameSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderRedisElasticacheUsernameSecretRef? UsernameSecretRef { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderRedshiftPasswordSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderRedshift
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderRedshiftPasswordSecretRef? PasswordSecretRef { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderSnowflakePasswordSecretRef
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
/// The private key associated with the Snowflake user.
/// Note: This property is write-only and will not be read from the API.
/// The private key configured for the admin user in Snowflake.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProviderSnowflakePrivateKeyWoSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecForProviderSnowflake
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderSnowflakePasswordSecretRef? PasswordSecretRef { get; set; }

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
    /// The private key associated with the Snowflake user.
    /// Note: This property is write-only and will not be read from the API.
    /// The private key configured for the admin user in Snowflake.
    /// </summary>
    [JsonPropertyName("privateKeyWoSecretRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderSnowflakePrivateKeyWoSecretRef? PrivateKeyWoSecretRef { get; set; }

    /// <summary>
    /// The version of the private_key_wo. For more info see updating write-only attributes.
    /// Version counter for the private key key-pair credentials write-only field
    /// </summary>
    [JsonPropertyName("privateKeyWoVersion")]
    public double? PrivateKeyWoVersion { get; set; }

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
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecForProvider
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// The unique name of the Vault mount to configure.
    /// Unique name of the Vault mount to configure.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendConnectionSpecForProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendConnectionSpecForProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Cassandra connections.
    /// Connection parameters for the cassandra-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("cassandra")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderCassandra>? Cassandra { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Couchbase connections.
    /// Connection parameters for the couchbase-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("couchbase")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderCouchbase>? Couchbase { get; set; }

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
    /// A nested block containing configuration options for Elasticsearch connections.
    /// Connection parameters for the elasticsearch-database-plugin.
    /// </summary>
    [JsonPropertyName("elasticsearch")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderElasticsearch>? Elasticsearch { get; set; }

    /// <summary>
    /// A nested block containing configuration options for SAP HanaDB connections.
    /// Connection parameters for the hana-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("hana")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderHana>? Hana { get; set; }

    /// <summary>
    /// A nested block containing configuration options for InfluxDB connections.
    /// Connection parameters for the influxdb-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("influxdb")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderInfluxdb>? Influxdb { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MongoDB connections.
    /// Connection parameters for the mongodb-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mongodb")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderMongodb>? Mongodb { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MongoDB Atlas connections.
    /// Connection parameters for the mongodbatlas-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mongodbatlas")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderMongodbatlas>? Mongodbatlas { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MSSQL connections.
    /// Connection parameters for the mssql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mssql")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderMssql>? Mssql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MySQL connections.
    /// Connection parameters for the mysql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysql")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderMysql>? Mysql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Aurora MySQL connections.
    /// Connection parameters for the mysql-aurora-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlAurora")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderMysqlAurora>? MysqlAurora { get; set; }

    /// <summary>
    /// A nested block containing configuration options for legacy MySQL connections.
    /// Connection parameters for the mysql-legacy-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlLegacy")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderMysqlLegacy>? MysqlLegacy { get; set; }

    /// <summary>
    /// A nested block containing configuration options for RDS MySQL connections.
    /// Connection parameters for the mysql-rds-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlRds")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderMysqlRds>? MysqlRds { get; set; }

    /// <summary>
    /// A unique name to give the database connection.
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
    /// A nested block containing configuration options for Oracle connections.
    /// Connection parameters for the oracle-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("oracle")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderOracle>? Oracle { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
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
    /// Specifies the semantic version of the plugin to use for this connection
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A nested block containing configuration options for PostgreSQL connections.
    /// Connection parameters for the postgresql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("postgresql")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderPostgresql>? Postgresql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Redis connections.
    /// Connection parameters for the redis-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("redis")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderRedis>? Redis { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Redis ElastiCache connections.
    /// Connection parameters for the redis-elasticache-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("redisElasticache")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderRedisElasticache>? RedisElasticache { get; set; }

    /// <summary>Connection parameters for the redshift-database-plugin plugin.</summary>
    [JsonPropertyName("redshift")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderRedshift>? Redshift { get; set; }

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
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This is can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Snowflake connections.
    /// Connection parameters for the snowflake-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("snowflake")]
    public IList<V1alpha1SecretBackendConnectionSpecForProviderSnowflake>? Snowflake { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendConnectionSpecInitProviderBackendRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendConnectionSpecInitProviderBackendRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendConnectionSpecInitProviderBackendRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendConnectionSpecInitProviderBackendRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderBackendRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendConnectionSpecInitProviderBackendRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendConnectionSpecInitProviderBackendRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderBackendRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendConnectionSpecInitProviderBackendRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendConnectionSpecInitProviderBackendSelectorPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendConnectionSpecInitProviderBackendSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendConnectionSpecInitProviderBackendSelectorPolicyResolveEnum>))]
public enum V1alpha1SecretBackendConnectionSpecInitProviderBackendSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderBackendSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendConnectionSpecInitProviderBackendSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendConnectionSpecInitProviderBackendSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Mount in vault to populate backend.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderBackendSelector
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
    public V1alpha1SecretBackendConnectionSpecInitProviderBackendSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The password to use when authenticating with Cassandra.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderCassandraPasswordSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderCassandraPemBundleSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderCassandraPemJsonSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderCassandra
{
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
    /// The password to authenticate with.
    /// The password to use when authenticating with Cassandra.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderCassandraPasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// Concatenated PEM blocks configuring the certificate
    /// chain.
    /// Concatenated PEM blocks containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
    /// </summary>
    [JsonPropertyName("pemBundleSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderCassandraPemBundleSecretRef? PemBundleSecretRef { get; set; }

    /// <summary>
    /// A JSON structure configuring the certificate chain.
    /// Specifies JSON containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
    /// </summary>
    [JsonPropertyName("pemJsonSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderCassandraPemJsonSecretRef? PemJsonSecretRef { get; set; }

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
    /// Skip permissions checks when a connection to Cassandra is first created.
    /// These checks ensure that Vault is able to create roles, but can be resource intensive in clusters with many roles.
    /// Skip permissions checks when a connection to Cassandra is first created. These checks ensure that Vault is able to create roles, but can be resource intensive in clusters with many roles.
    /// </summary>
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
}

/// <summary>
/// Required if tls is true. Specifies the certificate authority of the Couchbase server, as a PEM certificate that has been base64 encoded.
/// Required if `tls` is `true`. Specifies the certificate authority of the Couchbase server, as a PEM certificate that has been base64 encoded.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderCouchbaseBase64PemSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderCouchbasePasswordSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderCouchbase
{
    /// <summary>
    /// Required if tls is true. Specifies the certificate authority of the Couchbase server, as a PEM certificate that has been base64 encoded.
    /// Required if `tls` is `true`. Specifies the certificate authority of the Couchbase server, as a PEM certificate that has been base64 encoded.
    /// </summary>
    [JsonPropertyName("base64PemSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderCouchbaseBase64PemSecretRef? Base64PemSecretRef { get; set; }

    /// <summary>
    /// Required for Couchbase versions prior to 6.5.0. This is only used to verify vault&apos;s connection to the server.
    /// Required for Couchbase versions prior to 6.5.0. This is only used to verify vault&apos;s connection to the server.
    /// </summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

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
    /// The password to authenticate with.
    /// Specifies the password corresponding to the given username.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1alpha1SecretBackendConnectionSpecInitProviderCouchbasePasswordSecretRef PasswordSecretRef { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The password to be used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderElasticsearchPasswordSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderElasticsearch
{
    /// <summary>
    /// The contents of a PEM-encoded CA cert file to use to verify the Redis server&apos;s identity.
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
    /// Whether to disable certificate verification.
    /// Whether to disable certificate verification
    /// </summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The password to be used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1alpha1SecretBackendConnectionSpecInitProviderElasticsearchPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>
    /// Specifies the name to use as the SNI host when connecting to the Cassandra server via TLS.
    /// This, if set, is used to set the SNI host when connecting via TLS
    /// </summary>
    [JsonPropertyName("tlsServerName")]
    public string? TlsServerName { get; set; }

    /// <summary>
    /// The url to connect to including the port; e.g. master.my-cluster.xxxxxx.use1.cache.amazonaws.com:6379.
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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderHanaPasswordSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderHana
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderHanaPasswordSecretRef? PasswordSecretRef { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// Specifies the password corresponding to the given username.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderInfluxdbPasswordSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderInfluxdbPemBundleSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderInfluxdbPemJsonSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderInfluxdb
{
    /// <summary>
    /// The number of seconds to use as a connection
    /// timeout.
    /// The number of seconds to use as a connection timeout.
    /// </summary>
    [JsonPropertyName("connectTimeout")]
    public double? ConnectTimeout { get; set; }

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
    /// The password to authenticate with.
    /// Specifies the password corresponding to the given username.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1alpha1SecretBackendConnectionSpecInitProviderInfluxdbPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>
    /// Concatenated PEM blocks configuring the certificate
    /// chain.
    /// Concatenated PEM blocks containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
    /// </summary>
    [JsonPropertyName("pemBundleSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderInfluxdbPemBundleSecretRef? PemBundleSecretRef { get; set; }

    /// <summary>
    /// A JSON structure configuring the certificate chain.
    /// Specifies JSON containing a certificate and private key; a certificate, private key, and issuing CA certificate; or just a CA certificate.
    /// </summary>
    [JsonPropertyName("pemJsonSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderInfluxdbPemJsonSecretRef? PemJsonSecretRef { get; set; }

    /// <summary>
    /// The default port to connect to if no port is specified as
    /// part of the host.
    /// The transport port to use to connect to Influxdb.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMongodbPasswordSecretRef
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
/// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
/// The x509 certificate and private key bundle for connecting to the database. Must be PEM encoded.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMongodbTlsCertificateKeySecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMongodb
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderMongodbPasswordSecretRef? PasswordSecretRef { get; set; }

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
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
    /// The x509 CA file for validating the certificate presented by the MongoDB server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
    /// The x509 certificate and private key bundle for connecting to the database. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderMongodbTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

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
    /// A JSON string specifying the MongoDB write concern. For example: {&quot;wmode&quot;: &quot;majority&quot;, &quot;wtimeout&quot;: 5000}.
    /// Specifies the MongoDB write concern for Vault management operations.
    /// </summary>
    [JsonPropertyName("writeConcern")]
    public string? WriteConcern { get; set; }
}

/// <summary>
/// The Private Programmatic API Key used to connect with MongoDB Atlas API.
/// The Private Programmatic API Key used to connect with MongoDB Atlas API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMongodbatlasPrivateKeySecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMongodbatlas
{
    /// <summary>
    /// The Private Programmatic API Key used to connect with MongoDB Atlas API.
    /// The Private Programmatic API Key used to connect with MongoDB Atlas API.
    /// </summary>
    [JsonPropertyName("privateKeySecretRef")]
    public required V1alpha1SecretBackendConnectionSpecInitProviderMongodbatlasPrivateKeySecretRef PrivateKeySecretRef { get; set; }

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
    /// Template describing how dynamic usernames are generated.
    /// Template describing how dynamic usernames are generated.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMssqlPasswordSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMssql
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// For Vault v1.9+. Set to true when the target is a
    /// Contained Database, e.g. AzureSQL.
    /// See the Vault
    /// docs
    /// Set to true when the target is a Contained Database, e.g. AzureSQL.
    /// </summary>
    [JsonPropertyName("containedDb")]
    public bool? ContainedDb { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderMssqlPasswordSecretRef? PasswordSecretRef { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMysqlPasswordSecretRef
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
/// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
/// A JSON encoded credential for use with IAM authorization
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMysqlServiceAccountJsonSecretRef
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
/// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMysqlTlsCertificateKeySecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMysql
{
    /// <summary>
    /// Enable IAM authentication to a Google Cloud instance when set to gcp_iam
    /// Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)
    /// </summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderMysqlPasswordSecretRef? PasswordSecretRef { get; set; }

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
    /// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
    /// A JSON encoded credential for use with IAM authorization
    /// </summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderMysqlServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderMysqlTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMysqlAuroraPasswordSecretRef
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
/// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
/// A JSON encoded credential for use with IAM authorization
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMysqlAuroraServiceAccountJsonSecretRef
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
/// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMysqlAuroraTlsCertificateKeySecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMysqlAurora
{
    /// <summary>
    /// Enable IAM authentication to a Google Cloud instance when set to gcp_iam
    /// Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)
    /// </summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderMysqlAuroraPasswordSecretRef? PasswordSecretRef { get; set; }

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
    /// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
    /// A JSON encoded credential for use with IAM authorization
    /// </summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderMysqlAuroraServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderMysqlAuroraTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMysqlLegacyPasswordSecretRef
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
/// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
/// A JSON encoded credential for use with IAM authorization
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMysqlLegacyServiceAccountJsonSecretRef
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
/// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMysqlLegacyTlsCertificateKeySecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMysqlLegacy
{
    /// <summary>
    /// Enable IAM authentication to a Google Cloud instance when set to gcp_iam
    /// Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)
    /// </summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderMysqlLegacyPasswordSecretRef? PasswordSecretRef { get; set; }

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
    /// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
    /// A JSON encoded credential for use with IAM authorization
    /// </summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderMysqlLegacyServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderMysqlLegacyTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMysqlRdsPasswordSecretRef
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
/// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
/// A JSON encoded credential for use with IAM authorization
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMysqlRdsServiceAccountJsonSecretRef
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
/// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
/// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMysqlRdsTlsCertificateKeySecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderMysqlRds
{
    /// <summary>
    /// Enable IAM authentication to a Google Cloud instance when set to gcp_iam
    /// Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)
    /// </summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderMysqlRdsPasswordSecretRef? PasswordSecretRef { get; set; }

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
    /// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
    /// A JSON encoded credential for use with IAM authorization
    /// </summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderMysqlRdsServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
    /// x509 CA file for validating the certificate presented by the MySQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The client certificate and private key (concatenated in PEM format) to use for TLS authentication with MongoDB. This is a sensitive field that will not be returned in API responses.
    /// x509 certificate for connecting to the database. This must be a PEM encoded version of the private key and the certificate combined.
    /// </summary>
    [JsonPropertyName("tlsCertificateKeySecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderMysqlRdsTlsCertificateKeySecretRef? TlsCertificateKeySecretRef { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderOraclePasswordSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderOracle
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// Enable the built-in session disconnect mechanism.
    /// Set to true to disconnect any open sessions prior to running the revocation statements.
    /// </summary>
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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderOraclePasswordSecretRef? PasswordSecretRef { get; set; }

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
    /// If set, allows onboarding static roles with a rootless
    /// connection configuration. Mutually exclusive with username and password.
    /// If set, will force verify_connection to be false. Requires Vault 1.18+ Enterprise.
    /// If set, allows onboarding static roles with a rootless connection configuration.
    /// </summary>
    [JsonPropertyName("selfManaged")]
    public bool? SelfManaged { get; set; }

    /// <summary>
    /// Enable spliting statements after semi-colons.
    /// Set to true in order to split statements after semi-colons.
    /// </summary>
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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderPostgresqlPasswordSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderPostgresqlPrivateKeySecretRef
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
/// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
/// A JSON encoded credential for use with IAM authorization
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderPostgresqlServiceAccountJsonSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderPostgresql
{
    /// <summary>
    /// Enable IAM authentication to a Google Cloud instance when set to gcp_iam
    /// Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)
    /// </summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// When set to scram-sha-256, passwords will be
    /// hashed by Vault before being sent to PostgreSQL. See the Vault docs
    /// for an example. Requires Vault 1.14+.
    /// When set to `scram-sha-256`, passwords will be hashed by Vault before being sent to PostgreSQL.
    /// </summary>
    [JsonPropertyName("passwordAuthentication")]
    public string? PasswordAuthentication { get; set; }

    /// <summary>
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderPostgresqlPasswordSecretRef? PasswordSecretRef { get; set; }

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
    /// The Private Programmatic API Key used to connect with MongoDB Atlas API.
    /// The secret key used for the x509 client certificate. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("privateKeySecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderPostgresqlPrivateKeySecretRef? PrivateKeySecretRef { get; set; }

    /// <summary>
    /// If set, allows onboarding static roles with a rootless
    /// connection configuration. Mutually exclusive with username and password.
    /// If set, will force verify_connection to be false. Requires Vault 1.18+ Enterprise.
    /// If set, allows onboarding static roles with a rootless connection configuration.
    /// </summary>
    [JsonPropertyName("selfManaged")]
    public bool? SelfManaged { get; set; }

    /// <summary>
    /// JSON encoding of an IAM access key. Requires auth_type to be gcp_iam.
    /// A JSON encoded credential for use with IAM authorization
    /// </summary>
    [JsonPropertyName("serviceAccountJsonSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderPostgresqlServiceAccountJsonSecretRef? ServiceAccountJsonSecretRef { get; set; }

    /// <summary>
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
    /// The x509 CA file for validating the certificate presented by the PostgreSQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The x509 client certificate for connecting to
    /// the database. Must be PEM encoded.
    /// The x509 client certificate for connecting to the database. Must be PEM encoded.
    /// </summary>
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
}

/// <summary>
/// The password to authenticate with.
/// Specifies the password corresponding to the given username.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderRedisPasswordSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderRedis
{
    /// <summary>
    /// The contents of a PEM-encoded CA cert file to use to verify the Redis server&apos;s identity.
    /// The contents of a PEM-encoded CA cert file to use to verify the Redis server&apos;s identity.
    /// </summary>
    [JsonPropertyName("caCert")]
    public string? CaCert { get; set; }

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
    /// The password to authenticate with.
    /// Specifies the password corresponding to the given username.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public required V1alpha1SecretBackendConnectionSpecInitProviderRedisPasswordSecretRef PasswordSecretRef { get; set; }

    /// <summary>
    /// The default port to connect to if no port is specified as
    /// part of the host.
    /// The transport port to use to connect to Redis.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The AWS secret key id to use to talk to ElastiCache. If omitted the credentials chain provider is used instead.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderRedisElasticachePasswordSecretRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderRedisElasticacheUsernameSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderRedisElasticache
{
    /// <summary>
    /// The password to authenticate with.
    /// The AWS secret key id to use to talk to ElastiCache. If omitted the credentials chain provider is used instead.
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderRedisElasticachePasswordSecretRef? PasswordSecretRef { get; set; }

    /// <summary>
    /// The region where the ElastiCache cluster is hosted. If omitted Vault tries to infer from the environment instead.
    /// The AWS region where the ElastiCache cluster is hosted. If omitted the plugin tries to infer the region from the environment.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// The url to connect to including the port; e.g. master.my-cluster.xxxxxx.use1.cache.amazonaws.com:6379.
    /// The configuration endpoint for the ElastiCache cluster to connect to.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// The username to authenticate with.
    /// The AWS access key id to use to talk to ElastiCache. If omitted the credentials chain provider is used instead.
    /// </summary>
    [JsonPropertyName("usernameSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderRedisElasticacheUsernameSecretRef? UsernameSecretRef { get; set; }
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderRedshiftPasswordSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderRedshift
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderRedshiftPasswordSecretRef? PasswordSecretRef { get; set; }

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
}

/// <summary>
/// The password to authenticate with.
/// The root credential password used in the connection URL
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderSnowflakePasswordSecretRef
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
/// The private key associated with the Snowflake user.
/// Note: This property is write-only and will not be read from the API.
/// The private key configured for the admin user in Snowflake.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecInitProviderSnowflakePrivateKeyWoSecretRef
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
public partial class V1alpha1SecretBackendConnectionSpecInitProviderSnowflake
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The password to authenticate with.
    /// The root credential password used in the connection URL
    /// </summary>
    [JsonPropertyName("passwordSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderSnowflakePasswordSecretRef? PasswordSecretRef { get; set; }

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
    /// The private key associated with the Snowflake user.
    /// Note: This property is write-only and will not be read from the API.
    /// The private key configured for the admin user in Snowflake.
    /// </summary>
    [JsonPropertyName("privateKeyWoSecretRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderSnowflakePrivateKeyWoSecretRef? PrivateKeyWoSecretRef { get; set; }

    /// <summary>
    /// The version of the private_key_wo. For more info see updating write-only attributes.
    /// Version counter for the private key key-pair credentials write-only field
    /// </summary>
    [JsonPropertyName("privateKeyWoVersion")]
    public double? PrivateKeyWoVersion { get; set; }

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
public partial class V1alpha1SecretBackendConnectionSpecInitProvider
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// The unique name of the Vault mount to configure.
    /// Unique name of the Vault mount to configure.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>Reference to a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendRef")]
    public V1alpha1SecretBackendConnectionSpecInitProviderBackendRef? BackendRef { get; set; }

    /// <summary>Selector for a Mount in vault to populate backend.</summary>
    [JsonPropertyName("backendSelector")]
    public V1alpha1SecretBackendConnectionSpecInitProviderBackendSelector? BackendSelector { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Cassandra connections.
    /// Connection parameters for the cassandra-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("cassandra")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderCassandra>? Cassandra { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Couchbase connections.
    /// Connection parameters for the couchbase-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("couchbase")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderCouchbase>? Couchbase { get; set; }

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
    /// A nested block containing configuration options for Elasticsearch connections.
    /// Connection parameters for the elasticsearch-database-plugin.
    /// </summary>
    [JsonPropertyName("elasticsearch")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderElasticsearch>? Elasticsearch { get; set; }

    /// <summary>
    /// A nested block containing configuration options for SAP HanaDB connections.
    /// Connection parameters for the hana-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("hana")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderHana>? Hana { get; set; }

    /// <summary>
    /// A nested block containing configuration options for InfluxDB connections.
    /// Connection parameters for the influxdb-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("influxdb")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderInfluxdb>? Influxdb { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MongoDB connections.
    /// Connection parameters for the mongodb-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mongodb")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderMongodb>? Mongodb { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MongoDB Atlas connections.
    /// Connection parameters for the mongodbatlas-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mongodbatlas")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderMongodbatlas>? Mongodbatlas { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MSSQL connections.
    /// Connection parameters for the mssql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mssql")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderMssql>? Mssql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MySQL connections.
    /// Connection parameters for the mysql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysql")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderMysql>? Mysql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Aurora MySQL connections.
    /// Connection parameters for the mysql-aurora-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlAurora")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderMysqlAurora>? MysqlAurora { get; set; }

    /// <summary>
    /// A nested block containing configuration options for legacy MySQL connections.
    /// Connection parameters for the mysql-legacy-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlLegacy")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderMysqlLegacy>? MysqlLegacy { get; set; }

    /// <summary>
    /// A nested block containing configuration options for RDS MySQL connections.
    /// Connection parameters for the mysql-rds-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlRds")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderMysqlRds>? MysqlRds { get; set; }

    /// <summary>
    /// A unique name to give the database connection.
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
    /// A nested block containing configuration options for Oracle connections.
    /// Connection parameters for the oracle-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("oracle")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderOracle>? Oracle { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
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
    /// Specifies the semantic version of the plugin to use for this connection
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A nested block containing configuration options for PostgreSQL connections.
    /// Connection parameters for the postgresql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("postgresql")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderPostgresql>? Postgresql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Redis connections.
    /// Connection parameters for the redis-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("redis")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderRedis>? Redis { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Redis ElastiCache connections.
    /// Connection parameters for the redis-elasticache-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("redisElasticache")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderRedisElasticache>? RedisElasticache { get; set; }

    /// <summary>Connection parameters for the redshift-database-plugin plugin.</summary>
    [JsonPropertyName("redshift")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderRedshift>? Redshift { get; set; }

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
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This is can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Snowflake connections.
    /// Connection parameters for the snowflake-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("snowflake")]
    public IList<V1alpha1SecretBackendConnectionSpecInitProviderSnowflake>? Snowflake { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendConnectionSpecManagementPoliciesEnum>))]
public enum V1alpha1SecretBackendConnectionSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendConnectionSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1alpha1SecretBackendConnectionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1alpha1SecretBackendConnectionSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1alpha1SecretBackendConnectionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1alpha1SecretBackendConnectionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1alpha1SecretBackendConnectionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1alpha1SecretBackendConnectionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SecretBackendConnectionSpec defines the desired state of SecretBackendConnection</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionSpec
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
    public V1alpha1SecretBackendConnectionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1alpha1SecretBackendConnectionSpecForProvider ForProvider { get; set; }

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
    public V1alpha1SecretBackendConnectionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1alpha1SecretBackendConnectionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1alpha1SecretBackendConnectionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1alpha1SecretBackendConnectionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderCassandra
{
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
    /// Skip permissions checks when a connection to Cassandra is first created.
    /// These checks ensure that Vault is able to create roles, but can be resource intensive in clusters with many roles.
    /// Skip permissions checks when a connection to Cassandra is first created. These checks ensure that Vault is able to create roles, but can be resource intensive in clusters with many roles.
    /// </summary>
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
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderCouchbase
{
    /// <summary>
    /// Required for Couchbase versions prior to 6.5.0. This is only used to verify vault&apos;s connection to the server.
    /// Required for Couchbase versions prior to 6.5.0. This is only used to verify vault&apos;s connection to the server.
    /// </summary>
    [JsonPropertyName("bucketName")]
    public string? BucketName { get; set; }

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
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderElasticsearch
{
    /// <summary>
    /// The contents of a PEM-encoded CA cert file to use to verify the Redis server&apos;s identity.
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
    /// Whether to disable certificate verification.
    /// Whether to disable certificate verification
    /// </summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>
    /// Specifies the name to use as the SNI host when connecting to the Cassandra server via TLS.
    /// This, if set, is used to set the SNI host when connecting via TLS
    /// </summary>
    [JsonPropertyName("tlsServerName")]
    public string? TlsServerName { get; set; }

    /// <summary>
    /// The url to connect to including the port; e.g. master.my-cluster.xxxxxx.use1.cache.amazonaws.com:6379.
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
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderHana
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderInfluxdb
{
    /// <summary>
    /// The number of seconds to use as a connection
    /// timeout.
    /// The number of seconds to use as a connection timeout.
    /// </summary>
    [JsonPropertyName("connectTimeout")]
    public double? ConnectTimeout { get; set; }

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
    /// The default port to connect to if no port is specified as
    /// part of the host.
    /// The transport port to use to connect to Influxdb.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

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
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderMongodb
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
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
    /// A JSON string specifying the MongoDB write concern. For example: {&quot;wmode&quot;: &quot;majority&quot;, &quot;wtimeout&quot;: 5000}.
    /// Specifies the MongoDB write concern for Vault management operations.
    /// </summary>
    [JsonPropertyName("writeConcern")]
    public string? WriteConcern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderMongodbatlas
{
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
    /// Template describing how dynamic usernames are generated.
    /// Template describing how dynamic usernames are generated.
    /// </summary>
    [JsonPropertyName("usernameTemplate")]
    public string? UsernameTemplate { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderMssql
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// For Vault v1.9+. Set to true when the target is a
    /// Contained Database, e.g. AzureSQL.
    /// See the Vault
    /// docs
    /// Set to true when the target is a Contained Database, e.g. AzureSQL.
    /// </summary>
    [JsonPropertyName("containedDb")]
    public bool? ContainedDb { get; set; }

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
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderMysql
{
    /// <summary>
    /// Enable IAM authentication to a Google Cloud instance when set to gcp_iam
    /// Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)
    /// </summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
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
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderMysqlAurora
{
    /// <summary>
    /// Enable IAM authentication to a Google Cloud instance when set to gcp_iam
    /// Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)
    /// </summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
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
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderMysqlLegacy
{
    /// <summary>
    /// Enable IAM authentication to a Google Cloud instance when set to gcp_iam
    /// Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)
    /// </summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
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
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderMysqlRds
{
    /// <summary>
    /// Enable IAM authentication to a Google Cloud instance when set to gcp_iam
    /// Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)
    /// </summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
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
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderOracle
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

    /// <summary>
    /// Enable the built-in session disconnect mechanism.
    /// Set to true to disconnect any open sessions prior to running the revocation statements.
    /// </summary>
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
    /// If set, allows onboarding static roles with a rootless
    /// connection configuration. Mutually exclusive with username and password.
    /// If set, will force verify_connection to be false. Requires Vault 1.18+ Enterprise.
    /// If set, allows onboarding static roles with a rootless connection configuration.
    /// </summary>
    [JsonPropertyName("selfManaged")]
    public bool? SelfManaged { get; set; }

    /// <summary>
    /// Enable spliting statements after semi-colons.
    /// Set to true in order to split statements after semi-colons.
    /// </summary>
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
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderPostgresql
{
    /// <summary>
    /// Enable IAM authentication to a Google Cloud instance when set to gcp_iam
    /// Specify alternative authorization type. (Only &apos;gcp_iam&apos; is valid currently)
    /// </summary>
    [JsonPropertyName("authType")]
    public string? AuthType { get; set; }

    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// When set to scram-sha-256, passwords will be
    /// hashed by Vault before being sent to PostgreSQL. See the Vault docs
    /// for an example. Requires Vault 1.14+.
    /// When set to `scram-sha-256`, passwords will be hashed by Vault before being sent to PostgreSQL.
    /// </summary>
    [JsonPropertyName("passwordAuthentication")]
    public string? PasswordAuthentication { get; set; }

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
    /// If set, allows onboarding static roles with a rootless
    /// connection configuration. Mutually exclusive with username and password.
    /// If set, will force verify_connection to be false. Requires Vault 1.18+ Enterprise.
    /// If set, allows onboarding static roles with a rootless connection configuration.
    /// </summary>
    [JsonPropertyName("selfManaged")]
    public bool? SelfManaged { get; set; }

    /// <summary>
    /// The CA certificate to use when verifying the MongoDB server&apos;s TLS certificate.
    /// The x509 CA file for validating the certificate presented by the PostgreSQL server. Must be PEM encoded.
    /// </summary>
    [JsonPropertyName("tlsCa")]
    public string? TlsCa { get; set; }

    /// <summary>
    /// The x509 client certificate for connecting to
    /// the database. Must be PEM encoded.
    /// The x509 client certificate for connecting to the database. Must be PEM encoded.
    /// </summary>
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
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderRedis
{
    /// <summary>
    /// The contents of a PEM-encoded CA cert file to use to verify the Redis server&apos;s identity.
    /// The contents of a PEM-encoded CA cert file to use to verify the Redis server&apos;s identity.
    /// </summary>
    [JsonPropertyName("caCert")]
    public string? CaCert { get; set; }

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
    /// The default port to connect to if no port is specified as
    /// part of the host.
    /// The transport port to use to connect to Redis.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

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
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderRedisElasticache
{
    /// <summary>
    /// The region where the ElastiCache cluster is hosted. If omitted Vault tries to infer from the environment instead.
    /// The AWS region where the ElastiCache cluster is hosted. If omitted the plugin tries to infer the region from the environment.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// The url to connect to including the port; e.g. master.my-cluster.xxxxxx.use1.cache.amazonaws.com:6379.
    /// The configuration endpoint for the ElastiCache cluster to connect to.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderRedshift
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProviderSnowflake
{
    /// <summary>
    /// A URL containing connection information. See
    /// the Vault
    /// docs
    /// for an example.
    /// Connection string to use to connect to the database.
    /// </summary>
    [JsonPropertyName("connectionUrl")]
    public string? ConnectionUrl { get; set; }

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
    /// The version of the private_key_wo. For more info see updating write-only attributes.
    /// Version counter for the private key key-pair credentials write-only field
    /// </summary>
    [JsonPropertyName("privateKeyWoVersion")]
    public double? PrivateKeyWoVersion { get; set; }

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
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusAtProvider
{
    /// <summary>
    /// A list of roles that are allowed to use this
    /// connection.
    /// A list of roles that are allowed to use this connection.
    /// </summary>
    [JsonPropertyName("allowedRoles")]
    public IList<string>? AllowedRoles { get; set; }

    /// <summary>
    /// The unique name of the Vault mount to configure.
    /// Unique name of the Vault mount to configure.
    /// </summary>
    [JsonPropertyName("backend")]
    public string? Backend { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Cassandra connections.
    /// Connection parameters for the cassandra-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("cassandra")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderCassandra>? Cassandra { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Couchbase connections.
    /// Connection parameters for the couchbase-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("couchbase")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderCouchbase>? Couchbase { get; set; }

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
    /// A nested block containing configuration options for Elasticsearch connections.
    /// Connection parameters for the elasticsearch-database-plugin.
    /// </summary>
    [JsonPropertyName("elasticsearch")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderElasticsearch>? Elasticsearch { get; set; }

    /// <summary>
    /// A nested block containing configuration options for SAP HanaDB connections.
    /// Connection parameters for the hana-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("hana")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderHana>? Hana { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// A nested block containing configuration options for InfluxDB connections.
    /// Connection parameters for the influxdb-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("influxdb")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderInfluxdb>? Influxdb { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MongoDB connections.
    /// Connection parameters for the mongodb-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mongodb")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderMongodb>? Mongodb { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MongoDB Atlas connections.
    /// Connection parameters for the mongodbatlas-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mongodbatlas")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderMongodbatlas>? Mongodbatlas { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MSSQL connections.
    /// Connection parameters for the mssql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mssql")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderMssql>? Mssql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for MySQL connections.
    /// Connection parameters for the mysql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysql")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderMysql>? Mysql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Aurora MySQL connections.
    /// Connection parameters for the mysql-aurora-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlAurora")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderMysqlAurora>? MysqlAurora { get; set; }

    /// <summary>
    /// A nested block containing configuration options for legacy MySQL connections.
    /// Connection parameters for the mysql-legacy-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlLegacy")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderMysqlLegacy>? MysqlLegacy { get; set; }

    /// <summary>
    /// A nested block containing configuration options for RDS MySQL connections.
    /// Connection parameters for the mysql-rds-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("mysqlRds")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderMysqlRds>? MysqlRds { get; set; }

    /// <summary>
    /// A unique name to give the database connection.
    /// Name of the database connection.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
    /// A nested block containing configuration options for Oracle connections.
    /// Connection parameters for the oracle-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("oracle")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderOracle>? Oracle { get; set; }

    /// <summary>
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
    /// The name of the password policy to use when generating passwords for this database. If not specified, this will use a default policy defined as: 20 characters with at least 1 uppercase, 1 lowercase, 1 number, and 1 dash character.
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
    /// Specifies the semantic version of the plugin to use for this connection
    /// </summary>
    [JsonPropertyName("pluginVersion")]
    public string? PluginVersion { get; set; }

    /// <summary>
    /// A nested block containing configuration options for PostgreSQL connections.
    /// Connection parameters for the postgresql-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("postgresql")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderPostgresql>? Postgresql { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Redis connections.
    /// Connection parameters for the redis-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("redis")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderRedis>? Redis { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Redis ElastiCache connections.
    /// Connection parameters for the redis-elasticache-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("redisElasticache")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderRedisElasticache>? RedisElasticache { get; set; }

    /// <summary>Connection parameters for the redshift-database-plugin plugin.</summary>
    [JsonPropertyName("redshift")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderRedshift>? Redshift { get; set; }

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
    /// Specifies if a given static account&apos;s password should be rotated on creation of the static roles associated with this database config. This is can be overridden at the role-level by the static role&apos;s skip_import_rotation field. The default is false
    /// </summary>
    [JsonPropertyName("skipStaticRoleImportRotation")]
    public bool? SkipStaticRoleImportRotation { get; set; }

    /// <summary>
    /// A nested block containing configuration options for Snowflake connections.
    /// Connection parameters for the snowflake-database-plugin plugin.
    /// </summary>
    [JsonPropertyName("snowflake")]
    public IList<V1alpha1SecretBackendConnectionStatusAtProviderSnowflake>? Snowflake { get; set; }

    /// <summary>
    /// Whether the connection should be verified on
    /// initial configuration or not.
    /// Specifies if the connection is verified during initial configuration.
    /// </summary>
    [JsonPropertyName("verifyConnection")]
    public bool? VerifyConnection { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatusConditions
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

/// <summary>SecretBackendConnectionStatus defines the observed state of SecretBackendConnection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1SecretBackendConnectionStatus
{
    [JsonPropertyName("atProvider")]
    public V1alpha1SecretBackendConnectionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1SecretBackendConnectionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SecretBackendConnection is the Schema for the SecretBackendConnections API. Configures a database secret backend connection for Vault.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1SecretBackendConnection : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1SecretBackendConnectionSpec>, IStatus<V1alpha1SecretBackendConnectionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "SecretBackendConnection";
    public const string KubeGroup = "database.vault.upbound.io";
    public const string KubePluralName = "secretbackendconnections";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "database.vault.upbound.io/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SecretBackendConnection";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SecretBackendConnectionSpec defines the desired state of SecretBackendConnection</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1SecretBackendConnectionSpec Spec { get; set; }

    /// <summary>SecretBackendConnectionStatus defines the observed state of SecretBackendConnection.</summary>
    [JsonPropertyName("status")]
    public V1alpha1SecretBackendConnectionStatus? Status { get; set; }
}