#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.kafka.strimzi.io;
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KafkaMirrorMaker2List : IKubernetesObject<V1ListMeta>, IItems<V1KafkaMirrorMaker2>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KafkaMirrorMaker2List";
    public const string KubeGroup = "kafka.strimzi.io";
    public const string KubePluralName = "kafkamirrormaker2s";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.strimzi.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KafkaMirrorMaker2List";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1KafkaMirrorMaker2 objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1KafkaMirrorMaker2> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTargetTlsTrustedCertificates
{
    /// <summary>The name of the Secret containing the certificate.</summary>
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }

    /// <summary>The name of the file certificate in the secret.</summary>
    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    /// <summary>Pattern for the certificate files in the secret. Use the link:https://en.wikipedia.org/wiki/Glob_(programming)[_glob syntax_] for the pattern. All files in the secret that match the pattern are used.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>TLS configuration for connecting MirrorMaker 2 connectors to a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTargetTls
{
    /// <summary>Trusted certificates for TLS connection.</summary>
    [JsonPropertyName("trustedCertificates")]
    public IList<V1KafkaMirrorMaker2SpecTargetTlsTrustedCertificates>? TrustedCertificates { get; set; }
}

/// <summary>Reference to the `Secret` which holds the certificate and private key pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTargetAuthenticationCertificateAndKey
{
    /// <summary>The name of the Secret containing the certificate.</summary>
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }

    /// <summary>The name of the file certificate in the Secret.</summary>
    [JsonPropertyName("certificate")]
    public required string Certificate { get; set; }

    /// <summary>The name of the private key in the secret. The private key must be in unencrypted PKCS #8 format. For more information, see RFC 5208: https://datatracker.ietf.org/doc/html/rfc5208.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }
}

/// <summary>Reference to the `Secret` which holds the password.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTargetAuthenticationPasswordSecret
{
    /// <summary>The name of the Secret containing the password.</summary>
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }

    /// <summary>The name of the key in the Secret under which the password is stored.</summary>
    [JsonPropertyName("password")]
    public required string Password { get; set; }
}

/// <summary>Specifies the authentication type. Supported types are `tls`, `scram-sha-256`, `scram-sha-512`, `plain`, and `custom`. `tls` uses TLS client authentication and is supported only over TLS connections. `scram-sha-256` and `scram-sha-512` use SASL SCRAM-SHA-256 and SASL SCRAM-SHA-512 authentication, respectively. `plain` uses SASL PLAIN authentication. `custom` allows you to configure a custom authentication mechanism.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaMirrorMaker2SpecTargetAuthenticationTypeEnum>))]
public enum V1KafkaMirrorMaker2SpecTargetAuthenticationTypeEnum
{
    [EnumMember(Value = "tls"), JsonStringEnumMemberName("tls")]
    Tls,
    [EnumMember(Value = "scram-sha-256"), JsonStringEnumMemberName("scram-sha-256")]
    ScramSha256,
    [EnumMember(Value = "scram-sha-512"), JsonStringEnumMemberName("scram-sha-512")]
    ScramSha512,
    [EnumMember(Value = "plain"), JsonStringEnumMemberName("plain")]
    Plain,
    [EnumMember(Value = "custom"), JsonStringEnumMemberName("custom")]
    Custom
}

/// <summary>Authentication configuration for connecting to the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTargetAuthentication
{
    /// <summary>Reference to the `Secret` which holds the certificate and private key pair.</summary>
    [JsonPropertyName("certificateAndKey")]
    public V1KafkaMirrorMaker2SpecTargetAuthenticationCertificateAndKey? CertificateAndKey { get; set; }

    /// <summary>Configuration for the custom authentication mechanism. Only properties with the `sasl.` and `ssl.keystore.` prefixes are allowed. Specify other options in the regular configuration section of the custom resource.</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>Reference to the `Secret` which holds the password.</summary>
    [JsonPropertyName("passwordSecret")]
    public V1KafkaMirrorMaker2SpecTargetAuthenticationPasswordSecret? PasswordSecret { get; set; }

    /// <summary>Enable or disable SASL on this authentication mechanism.</summary>
    [JsonPropertyName("sasl")]
    public bool? Sasl { get; set; }

    /// <summary>Specifies the authentication type. Supported types are `tls`, `scram-sha-256`, `scram-sha-512`, `plain`, and `custom`. `tls` uses TLS client authentication and is supported only over TLS connections. `scram-sha-256` and `scram-sha-512` use SASL SCRAM-SHA-256 and SASL SCRAM-SHA-512 authentication, respectively. `plain` uses SASL PLAIN authentication. `custom` allows you to configure a custom authentication mechanism.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaMirrorMaker2SpecTargetAuthenticationTypeEnum Type { get; set; }

    /// <summary>Username used for the authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The target Apache Kafka cluster. The target Kafka cluster is used by the underlying Kafka Connect framework for its internal topics.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTarget
{
    /// <summary>Alias used to reference the Kafka cluster.</summary>
    [JsonPropertyName("alias")]
    public required string Alias { get; set; }

    /// <summary>A comma-separated list of `host:port` pairs for establishing the connection to the Kafka cluster.</summary>
    [JsonPropertyName("bootstrapServers")]
    public required string BootstrapServers { get; set; }

    /// <summary>A unique ID that identifies the Connect cluster group. Required.</summary>
    [JsonPropertyName("groupId")]
    public required string GroupId { get; set; }

    /// <summary>The name of the Kafka topic where connector configurations are stored. Required.</summary>
    [JsonPropertyName("configStorageTopic")]
    public required string ConfigStorageTopic { get; set; }

    /// <summary>The name of the Kafka topic where connector and task statuses are stored. Required.</summary>
    [JsonPropertyName("statusStorageTopic")]
    public required string StatusStorageTopic { get; set; }

    /// <summary>The name of the Kafka topic where source connector offsets are stored. Required.</summary>
    [JsonPropertyName("offsetStorageTopic")]
    public required string OffsetStorageTopic { get; set; }

    /// <summary>TLS configuration for connecting MirrorMaker 2 connectors to a cluster.</summary>
    [JsonPropertyName("tls")]
    public V1KafkaMirrorMaker2SpecTargetTls? Tls { get; set; }

    /// <summary>Authentication configuration for connecting to the cluster.</summary>
    [JsonPropertyName("authentication")]
    public V1KafkaMirrorMaker2SpecTargetAuthentication? Authentication { get; set; }

    /// <summary>The MirrorMaker 2 cluster config. Properties with the following prefixes cannot be set: group.id, config.storage.topic, offset.storage.topic, status.storage.topic, ssl., sasl., security., listeners, plugin.path, rest., bootstrap.servers, consumer.interceptor.classes, producer.interceptor.classes (with the exception of: ssl.endpoint.identification.algorithm, ssl.cipher.suites, ssl.protocol, ssl.enabled.protocols).</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsSourceTlsTrustedCertificates
{
    /// <summary>The name of the Secret containing the certificate.</summary>
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }

    /// <summary>The name of the file certificate in the secret.</summary>
    [JsonPropertyName("certificate")]
    public string? Certificate { get; set; }

    /// <summary>Pattern for the certificate files in the secret. Use the link:https://en.wikipedia.org/wiki/Glob_(programming)[_glob syntax_] for the pattern. All files in the secret that match the pattern are used.</summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }
}

/// <summary>TLS configuration for connecting MirrorMaker 2 connectors to a cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsSourceTls
{
    /// <summary>Trusted certificates for TLS connection.</summary>
    [JsonPropertyName("trustedCertificates")]
    public IList<V1KafkaMirrorMaker2SpecMirrorsSourceTlsTrustedCertificates>? TrustedCertificates { get; set; }
}

/// <summary>Reference to the `Secret` which holds the certificate and private key pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsSourceAuthenticationCertificateAndKey
{
    /// <summary>The name of the Secret containing the certificate.</summary>
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }

    /// <summary>The name of the file certificate in the Secret.</summary>
    [JsonPropertyName("certificate")]
    public required string Certificate { get; set; }

    /// <summary>The name of the private key in the secret. The private key must be in unencrypted PKCS #8 format. For more information, see RFC 5208: https://datatracker.ietf.org/doc/html/rfc5208.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }
}

/// <summary>Reference to the `Secret` which holds the password.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsSourceAuthenticationPasswordSecret
{
    /// <summary>The name of the Secret containing the password.</summary>
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }

    /// <summary>The name of the key in the Secret under which the password is stored.</summary>
    [JsonPropertyName("password")]
    public required string Password { get; set; }
}

/// <summary>Specifies the authentication type. Supported types are `tls`, `scram-sha-256`, `scram-sha-512`, `plain`, and `custom`. `tls` uses TLS client authentication and is supported only over TLS connections. `scram-sha-256` and `scram-sha-512` use SASL SCRAM-SHA-256 and SASL SCRAM-SHA-512 authentication, respectively. `plain` uses SASL PLAIN authentication. `custom` allows you to configure a custom authentication mechanism.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaMirrorMaker2SpecMirrorsSourceAuthenticationTypeEnum>))]
public enum V1KafkaMirrorMaker2SpecMirrorsSourceAuthenticationTypeEnum
{
    [EnumMember(Value = "tls"), JsonStringEnumMemberName("tls")]
    Tls,
    [EnumMember(Value = "scram-sha-256"), JsonStringEnumMemberName("scram-sha-256")]
    ScramSha256,
    [EnumMember(Value = "scram-sha-512"), JsonStringEnumMemberName("scram-sha-512")]
    ScramSha512,
    [EnumMember(Value = "plain"), JsonStringEnumMemberName("plain")]
    Plain,
    [EnumMember(Value = "custom"), JsonStringEnumMemberName("custom")]
    Custom
}

/// <summary>Authentication configuration for connecting to the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsSourceAuthentication
{
    /// <summary>Reference to the `Secret` which holds the certificate and private key pair.</summary>
    [JsonPropertyName("certificateAndKey")]
    public V1KafkaMirrorMaker2SpecMirrorsSourceAuthenticationCertificateAndKey? CertificateAndKey { get; set; }

    /// <summary>Configuration for the custom authentication mechanism. Only properties with the `sasl.` and `ssl.keystore.` prefixes are allowed. Specify other options in the regular configuration section of the custom resource.</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>Reference to the `Secret` which holds the password.</summary>
    [JsonPropertyName("passwordSecret")]
    public V1KafkaMirrorMaker2SpecMirrorsSourceAuthenticationPasswordSecret? PasswordSecret { get; set; }

    /// <summary>Enable or disable SASL on this authentication mechanism.</summary>
    [JsonPropertyName("sasl")]
    public bool? Sasl { get; set; }

    /// <summary>Specifies the authentication type. Supported types are `tls`, `scram-sha-256`, `scram-sha-512`, `plain`, and `custom`. `tls` uses TLS client authentication and is supported only over TLS connections. `scram-sha-256` and `scram-sha-512` use SASL SCRAM-SHA-256 and SASL SCRAM-SHA-512 authentication, respectively. `plain` uses SASL PLAIN authentication. `custom` allows you to configure a custom authentication mechanism.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaMirrorMaker2SpecMirrorsSourceAuthenticationTypeEnum Type { get; set; }

    /// <summary>Username used for the authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>The source Apache Kafka cluster. The source Kafka cluster is used by the Kafka MirrorMaker 2 connectors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsSource
{
    /// <summary>Alias used to reference the Kafka cluster.</summary>
    [JsonPropertyName("alias")]
    public required string Alias { get; set; }

    /// <summary>A comma-separated list of `host:port` pairs for establishing the connection to the Kafka cluster.</summary>
    [JsonPropertyName("bootstrapServers")]
    public required string BootstrapServers { get; set; }

    /// <summary>TLS configuration for connecting MirrorMaker 2 connectors to a cluster.</summary>
    [JsonPropertyName("tls")]
    public V1KafkaMirrorMaker2SpecMirrorsSourceTls? Tls { get; set; }

    /// <summary>Authentication configuration for connecting to the cluster.</summary>
    [JsonPropertyName("authentication")]
    public V1KafkaMirrorMaker2SpecMirrorsSourceAuthentication? Authentication { get; set; }

    /// <summary>The MirrorMaker 2 cluster config. Properties with the following prefixes cannot be set: group.id, config.storage.topic, offset.storage.topic, status.storage.topic, ssl., sasl., security., listeners, plugin.path, rest., bootstrap.servers, consumer.interceptor.classes, producer.interceptor.classes (with the exception of: ssl.endpoint.identification.algorithm, ssl.cipher.suites, ssl.protocol, ssl.enabled.protocols).</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }
}

/// <summary>The state the connector should be in. Defaults to running.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaMirrorMaker2SpecMirrorsSourceConnectorStateEnum>))]
public enum V1KafkaMirrorMaker2SpecMirrorsSourceConnectorStateEnum
{
    [EnumMember(Value = "paused"), JsonStringEnumMemberName("paused")]
    Paused,
    [EnumMember(Value = "stopped"), JsonStringEnumMemberName("stopped")]
    Stopped,
    [EnumMember(Value = "running"), JsonStringEnumMemberName("running")]
    Running
}

/// <summary>Automatic restart of connector and tasks configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsSourceConnectorAutoRestart
{
    /// <summary>Whether automatic restart for failed connectors and tasks should be enabled or disabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The maximum number of connector restarts that the operator will try. If the connector remains in a failed state after reaching this limit, it must be restarted manually by the user. Defaults to an unlimited number of restarts.</summary>
    [JsonPropertyName("maxRestarts")]
    public int? MaxRestarts { get; set; }
}

/// <summary>Reference to the ConfigMap where the list of offsets will be written to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsSourceConnectorListOffsetsToConfigMap
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configuration for listing offsets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsSourceConnectorListOffsets
{
    /// <summary>Reference to the ConfigMap where the list of offsets will be written to.</summary>
    [JsonPropertyName("toConfigMap")]
    public required V1KafkaMirrorMaker2SpecMirrorsSourceConnectorListOffsetsToConfigMap ToConfigMap { get; set; }
}

/// <summary>Reference to the ConfigMap where the new offsets are stored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsSourceConnectorAlterOffsetsFromConfigMap
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configuration for altering offsets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsSourceConnectorAlterOffsets
{
    /// <summary>Reference to the ConfigMap where the new offsets are stored.</summary>
    [JsonPropertyName("fromConfigMap")]
    public required V1KafkaMirrorMaker2SpecMirrorsSourceConnectorAlterOffsetsFromConfigMap FromConfigMap { get; set; }
}

/// <summary>The specification of the Kafka MirrorMaker 2 source connector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsSourceConnector
{
    /// <summary>The maximum number of tasks for the Kafka Connector.</summary>
    [JsonPropertyName("tasksMax")]
    public int? TasksMax { get; set; }

    /// <summary>Desired version or version range to respect when starting the Kafka Connector. This is only supported when using Kafka Connect version 4.1.0 and higher.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The Kafka Connector configuration. The following properties cannot be set: name, connector.class, tasks.max, connector.plugin.version.</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>The state the connector should be in. Defaults to running.</summary>
    [JsonPropertyName("state")]
    public V1KafkaMirrorMaker2SpecMirrorsSourceConnectorStateEnum? State { get; set; }

    /// <summary>Automatic restart of connector and tasks configuration.</summary>
    [JsonPropertyName("autoRestart")]
    public V1KafkaMirrorMaker2SpecMirrorsSourceConnectorAutoRestart? AutoRestart { get; set; }

    /// <summary>Configuration for listing offsets.</summary>
    [JsonPropertyName("listOffsets")]
    public V1KafkaMirrorMaker2SpecMirrorsSourceConnectorListOffsets? ListOffsets { get; set; }

    /// <summary>Configuration for altering offsets.</summary>
    [JsonPropertyName("alterOffsets")]
    public V1KafkaMirrorMaker2SpecMirrorsSourceConnectorAlterOffsets? AlterOffsets { get; set; }
}

/// <summary>The state the connector should be in. Defaults to running.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaMirrorMaker2SpecMirrorsCheckpointConnectorStateEnum>))]
public enum V1KafkaMirrorMaker2SpecMirrorsCheckpointConnectorStateEnum
{
    [EnumMember(Value = "paused"), JsonStringEnumMemberName("paused")]
    Paused,
    [EnumMember(Value = "stopped"), JsonStringEnumMemberName("stopped")]
    Stopped,
    [EnumMember(Value = "running"), JsonStringEnumMemberName("running")]
    Running
}

/// <summary>Automatic restart of connector and tasks configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsCheckpointConnectorAutoRestart
{
    /// <summary>Whether automatic restart for failed connectors and tasks should be enabled or disabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The maximum number of connector restarts that the operator will try. If the connector remains in a failed state after reaching this limit, it must be restarted manually by the user. Defaults to an unlimited number of restarts.</summary>
    [JsonPropertyName("maxRestarts")]
    public int? MaxRestarts { get; set; }
}

/// <summary>Reference to the ConfigMap where the list of offsets will be written to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsCheckpointConnectorListOffsetsToConfigMap
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configuration for listing offsets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsCheckpointConnectorListOffsets
{
    /// <summary>Reference to the ConfigMap where the list of offsets will be written to.</summary>
    [JsonPropertyName("toConfigMap")]
    public required V1KafkaMirrorMaker2SpecMirrorsCheckpointConnectorListOffsetsToConfigMap ToConfigMap { get; set; }
}

/// <summary>Reference to the ConfigMap where the new offsets are stored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsCheckpointConnectorAlterOffsetsFromConfigMap
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configuration for altering offsets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsCheckpointConnectorAlterOffsets
{
    /// <summary>Reference to the ConfigMap where the new offsets are stored.</summary>
    [JsonPropertyName("fromConfigMap")]
    public required V1KafkaMirrorMaker2SpecMirrorsCheckpointConnectorAlterOffsetsFromConfigMap FromConfigMap { get; set; }
}

/// <summary>The specification of the Kafka MirrorMaker 2 checkpoint connector.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrorsCheckpointConnector
{
    /// <summary>The maximum number of tasks for the Kafka Connector.</summary>
    [JsonPropertyName("tasksMax")]
    public int? TasksMax { get; set; }

    /// <summary>Desired version or version range to respect when starting the Kafka Connector. This is only supported when using Kafka Connect version 4.1.0 and higher.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The Kafka Connector configuration. The following properties cannot be set: name, connector.class, tasks.max, connector.plugin.version.</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>The state the connector should be in. Defaults to running.</summary>
    [JsonPropertyName("state")]
    public V1KafkaMirrorMaker2SpecMirrorsCheckpointConnectorStateEnum? State { get; set; }

    /// <summary>Automatic restart of connector and tasks configuration.</summary>
    [JsonPropertyName("autoRestart")]
    public V1KafkaMirrorMaker2SpecMirrorsCheckpointConnectorAutoRestart? AutoRestart { get; set; }

    /// <summary>Configuration for listing offsets.</summary>
    [JsonPropertyName("listOffsets")]
    public V1KafkaMirrorMaker2SpecMirrorsCheckpointConnectorListOffsets? ListOffsets { get; set; }

    /// <summary>Configuration for altering offsets.</summary>
    [JsonPropertyName("alterOffsets")]
    public V1KafkaMirrorMaker2SpecMirrorsCheckpointConnectorAlterOffsets? AlterOffsets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMirrors
{
    /// <summary>The source Apache Kafka cluster. The source Kafka cluster is used by the Kafka MirrorMaker 2 connectors.</summary>
    [JsonPropertyName("source")]
    public required V1KafkaMirrorMaker2SpecMirrorsSource Source { get; set; }

    /// <summary>The specification of the Kafka MirrorMaker 2 source connector.</summary>
    [JsonPropertyName("sourceConnector")]
    public V1KafkaMirrorMaker2SpecMirrorsSourceConnector? SourceConnector { get; set; }

    /// <summary>The specification of the Kafka MirrorMaker 2 checkpoint connector.</summary>
    [JsonPropertyName("checkpointConnector")]
    public V1KafkaMirrorMaker2SpecMirrorsCheckpointConnector? CheckpointConnector { get; set; }

    /// <summary>A regular expression matching the topics to be mirrored, for example, &quot;topic1\|topic2\|topic3&quot;. Comma-separated lists are also supported.</summary>
    [JsonPropertyName("topicsPattern")]
    public string? TopicsPattern { get; set; }

    /// <summary>A regular expression matching the topics to exclude from mirroring. Comma-separated lists are also supported.</summary>
    [JsonPropertyName("topicsExcludePattern")]
    public string? TopicsExcludePattern { get; set; }

    /// <summary>A regular expression matching the consumer groups to be mirrored. Comma-separated lists are also supported.</summary>
    [JsonPropertyName("groupsPattern")]
    public string? GroupsPattern { get; set; }

    /// <summary>A regular expression matching the consumer groups to exclude from mirroring. Comma-separated lists are also supported.</summary>
    [JsonPropertyName("groupsExcludePattern")]
    public string? GroupsExcludePattern { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecResourcesClaims
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

/// <summary>The maximum limits for CPU and memory resources and the requested initial resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecResources
{
    [JsonPropertyName("claims")]
    public IList<V1KafkaMirrorMaker2SpecResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

/// <summary>Pod liveness checking.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecLivenessProbe
{
    /// <summary>The initial delay before first the health is first checked. Default to 15 seconds. Minimum value is 0.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>The timeout for each attempted health check. Default to 5 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }
}

/// <summary>Pod readiness checking.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecReadinessProbe
{
    /// <summary>The initial delay before first the health is first checked. Default to 15 seconds. Minimum value is 0.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>The timeout for each attempted health check. Default to 5 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Minimum consecutive successes for the probe to be considered successful after having failed. Defaults to 1. Must be 1 for liveness. Minimum value is 1.</summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecJvmOptionsJavaSystemProperties
{
    /// <summary>The system property name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The system property value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>JVM Options for pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecJvmOptions
{
    /// <summary>A map of -XX options to the JVM.</summary>
    [JsonPropertyName("-XX")]
    public IDictionary<string, string>? XX { get; set; }

    /// <summary>-Xmx option to to the JVM.</summary>
    [JsonPropertyName("-Xmx")]
    public string? Xmx { get; set; }

    /// <summary>-Xms option to to the JVM.</summary>
    [JsonPropertyName("-Xms")]
    public string? Xms { get; set; }

    /// <summary>Specifies whether the Garbage Collection logging is enabled. The default is false.</summary>
    [JsonPropertyName("gcLoggingEnabled")]
    public bool? GcLoggingEnabled { get; set; }

    /// <summary>A map of additional system properties which will be passed using the `-D` option to the JVM.</summary>
    [JsonPropertyName("javaSystemProperties")]
    public IList<V1KafkaMirrorMaker2SpecJvmOptionsJavaSystemProperties>? JavaSystemProperties { get; set; }
}

/// <summary>Authentication type. Currently the only supported types are `password`.`password` type creates a username and protected port with no TLS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaMirrorMaker2SpecJmxOptionsAuthenticationTypeEnum>))]
public enum V1KafkaMirrorMaker2SpecJmxOptionsAuthenticationTypeEnum
{
    [EnumMember(Value = "password"), JsonStringEnumMemberName("password")]
    Password
}

/// <summary>Authentication configuration for connecting to the JMX port.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecJmxOptionsAuthentication
{
    /// <summary>Authentication type. Currently the only supported types are `password`.`password` type creates a username and protected port with no TLS.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaMirrorMaker2SpecJmxOptionsAuthenticationTypeEnum Type { get; set; }
}

/// <summary>JMX Options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecJmxOptions
{
    /// <summary>Authentication configuration for connecting to the JMX port.</summary>
    [JsonPropertyName("authentication")]
    public V1KafkaMirrorMaker2SpecJmxOptionsAuthentication? Authentication { get; set; }
}

/// <summary>Logging type, must be either &apos;inline&apos; or &apos;external&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaMirrorMaker2SpecLoggingTypeEnum>))]
public enum V1KafkaMirrorMaker2SpecLoggingTypeEnum
{
    [EnumMember(Value = "inline"), JsonStringEnumMemberName("inline")]
    Inline,
    [EnumMember(Value = "external"), JsonStringEnumMemberName("external")]
    External
}

/// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecLoggingValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>`ConfigMap` entry where the logging configuration is stored. </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecLoggingValueFrom
{
    /// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaMirrorMaker2SpecLoggingValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

/// <summary>Logging configuration for Kafka Connect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecLogging
{
    /// <summary>A Map from logger name to logger level.</summary>
    [JsonPropertyName("loggers")]
    public IDictionary<string, string>? Loggers { get; set; }

    /// <summary>Logging type, must be either &apos;inline&apos; or &apos;external&apos;.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaMirrorMaker2SpecLoggingTypeEnum Type { get; set; }

    /// <summary>`ConfigMap` entry where the logging configuration is stored. </summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaMirrorMaker2SpecLoggingValueFrom? ValueFrom { get; set; }
}

/// <summary>Specifies the rack awareness type. Supported types are `topology-label` and `environment-variable`. `topology-label` uses a Kubernetes worker node label to set the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect and MirrorMaker 2. `environment-variable` uses an environment variable to set the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect and MirrorMaker 2. When not specified, `topology-label` type is used by default.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaMirrorMaker2SpecRackTypeEnum>))]
public enum V1KafkaMirrorMaker2SpecRackTypeEnum
{
    [EnumMember(Value = "topology-label"), JsonStringEnumMemberName("topology-label")]
    TopologyLabel,
    [EnumMember(Value = "environment-variable"), JsonStringEnumMemberName("environment-variable")]
    EnvironmentVariable
}

/// <summary>Configuration of the node label which will be used as the `client.rack` consumer configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecRack
{
    /// <summary>The name of the environment variable that defines the rack ID. Its value sets the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect or MirrorMaker 2.</summary>
    [JsonPropertyName("envVarName")]
    public string? EnvVarName { get; set; }

    /// <summary>A key that matches labels assigned to the Kubernetes cluster nodes. The value of the label is used to set a broker&apos;s `broker.rack` config, and the `client.rack` config for Kafka Connect or MirrorMaker 2.</summary>
    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }

    /// <summary>Specifies the rack awareness type. Supported types are `topology-label` and `environment-variable`. `topology-label` uses a Kubernetes worker node label to set the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect and MirrorMaker 2. `environment-variable` uses an environment variable to set the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect and MirrorMaker 2. When not specified, `topology-label` type is used by default.</summary>
    [JsonPropertyName("type")]
    public V1KafkaMirrorMaker2SpecRackTypeEnum? Type { get; set; }
}

/// <summary>Metrics type. The supported types are `jmxPrometheusExporter` and `strimziMetricsReporter`. Type `jmxPrometheusExporter` uses the Prometheus JMX Exporter to expose Kafka JMX metrics in Prometheus format through an HTTP endpoint. Type `strimziMetricsReporter` uses the Strimzi Metrics Reporter to directly expose Kafka metrics in Prometheus format through an HTTP endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaMirrorMaker2SpecMetricsConfigTypeEnum>))]
public enum V1KafkaMirrorMaker2SpecMetricsConfigTypeEnum
{
    [EnumMember(Value = "jmxPrometheusExporter"), JsonStringEnumMemberName("jmxPrometheusExporter")]
    JmxPrometheusExporter,
    [EnumMember(Value = "strimziMetricsReporter"), JsonStringEnumMemberName("strimziMetricsReporter")]
    StrimziMetricsReporter
}

/// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMetricsConfigValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>ConfigMap entry where the Prometheus JMX Exporter configuration is stored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMetricsConfigValueFrom
{
    /// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaMirrorMaker2SpecMetricsConfigValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

/// <summary>Configuration values for the Strimzi Metrics Reporter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMetricsConfigValues
{
    /// <summary>A list of regex patterns to filter the metrics to collect. Should contain at least one element.</summary>
    [JsonPropertyName("allowList")]
    public IList<string>? AllowList { get; set; }
}

/// <summary>Metrics configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecMetricsConfig
{
    /// <summary>Metrics type. The supported types are `jmxPrometheusExporter` and `strimziMetricsReporter`. Type `jmxPrometheusExporter` uses the Prometheus JMX Exporter to expose Kafka JMX metrics in Prometheus format through an HTTP endpoint. Type `strimziMetricsReporter` uses the Strimzi Metrics Reporter to directly expose Kafka metrics in Prometheus format through an HTTP endpoint.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaMirrorMaker2SpecMetricsConfigTypeEnum Type { get; set; }

    /// <summary>ConfigMap entry where the Prometheus JMX Exporter configuration is stored.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaMirrorMaker2SpecMetricsConfigValueFrom? ValueFrom { get; set; }

    /// <summary>Configuration values for the Strimzi Metrics Reporter.</summary>
    [JsonPropertyName("values")]
    public V1KafkaMirrorMaker2SpecMetricsConfigValues? Values { get; set; }
}

/// <summary>Type of the tracing used. Currently the only supported type is `opentelemetry` for OpenTelemetry tracing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaMirrorMaker2SpecTracingTypeEnum>))]
public enum V1KafkaMirrorMaker2SpecTracingTypeEnum
{
    [EnumMember(Value = "opentelemetry"), JsonStringEnumMemberName("opentelemetry")]
    Opentelemetry
}

/// <summary>The configuration of tracing in Kafka Connect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTracing
{
    /// <summary>Type of the tracing used. Currently the only supported type is `opentelemetry` for OpenTelemetry tracing.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaMirrorMaker2SpecTracingTypeEnum Type { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodSetMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Kafka Connect `StrimziPodSet` resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodSet
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaMirrorMaker2SpecTemplatePodSetMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodImagePullSecrets
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodSecurityContextSysctls
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Configures pod-level security attributes and common container settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodSecurityContext
{
    [JsonPropertyName("appArmorProfile")]
    public V1KafkaMirrorMaker2SpecTemplatePodSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("fsGroup")]
    public int? FsGroup { get; set; }

    [JsonPropertyName("fsGroupChangePolicy")]
    public string? FsGroupChangePolicy { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxChangePolicy")]
    public string? SeLinuxChangePolicy { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaMirrorMaker2SpecTemplatePodSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaMirrorMaker2SpecTemplatePodSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("supplementalGroups")]
    public IList<int>? SupplementalGroups { get; set; }

    [JsonPropertyName("supplementalGroupsPolicy")]
    public string? SupplementalGroupsPolicy { get; set; }

    [JsonPropertyName("sysctls")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodSecurityContextSysctls>? Sysctls { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaMirrorMaker2SpecTemplatePodSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("preference")]
    public V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference? Preference { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms>? NodeSelectorTerms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>The pod&apos;s affinity rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodAffinity
{
    [JsonPropertyName("nodeAffinity")]
    public V1KafkaMirrorMaker2SpecTemplatePodAffinityNodeAffinity? NodeAffinity { get; set; }

    [JsonPropertyName("podAffinity")]
    public V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAffinity? PodAffinity { get; set; }

    [JsonPropertyName("podAntiAffinity")]
    public V1KafkaMirrorMaker2SpecTemplatePodAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodTolerations
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("tolerationSeconds")]
    public int? TolerationSeconds { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodTopologySpreadConstraintsLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodTopologySpreadConstraintsLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodTopologySpreadConstraints
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaMirrorMaker2SpecTemplatePodTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("maxSkew")]
    public int? MaxSkew { get; set; }

    [JsonPropertyName("minDomains")]
    public int? MinDomains { get; set; }

    [JsonPropertyName("nodeAffinityPolicy")]
    public string? NodeAffinityPolicy { get; set; }

    [JsonPropertyName("nodeTaintsPolicy")]
    public string? NodeTaintsPolicy { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }

    [JsonPropertyName("whenUnsatisfiable")]
    public string? WhenUnsatisfiable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodHostAliases
{
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
}

/// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaMirrorMaker2SpecTemplatePodDnsPolicyEnum>))]
public enum V1KafkaMirrorMaker2SpecTemplatePodDnsPolicyEnum
{
    [EnumMember(Value = "ClusterFirst"), JsonStringEnumMemberName("ClusterFirst")]
    ClusterFirst,
    [EnumMember(Value = "ClusterFirstWithHostNet"), JsonStringEnumMemberName("ClusterFirstWithHostNet")]
    ClusterFirstWithHostNet,
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodDnsConfigOptions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodDnsConfig
{
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    [JsonPropertyName("options")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodDnsConfigOptions>? Options { get; set; }

    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodVolumesSecretItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`Secret` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodVolumesSecret
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodVolumesSecretItems>? Items { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodVolumesConfigMapItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`ConfigMap` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodVolumesConfigMap
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodVolumesConfigMapItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaMirrorMaker2SpecTemplatePodVolumesEmptyDirMediumEnum>))]
public enum V1KafkaMirrorMaker2SpecTemplatePodVolumesEmptyDirMediumEnum
{
    [EnumMember(Value = "Memory"), JsonStringEnumMemberName("Memory")]
    Memory
}

/// <summary>`EmptyDir` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodVolumesEmptyDir
{
    /// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
    [JsonPropertyName("medium")]
    public V1KafkaMirrorMaker2SpecTemplatePodVolumesEmptyDirMediumEnum? Medium { get; set; }

    /// <summary>The total amount of local storage required for this EmptyDir volume (for example 1Gi).</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodVolumesPersistentVolumeClaim
{
    [JsonPropertyName("claimName")]
    public string? ClaimName { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodVolumesCsiNodePublishSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodVolumesCsi
{
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("nodePublishSecretRef")]
    public V1KafkaMirrorMaker2SpecTemplatePodVolumesCsiNodePublishSecretRef? NodePublishSecretRef { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

/// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodVolumesImage
{
    [JsonPropertyName("pullPolicy")]
    public string? PullPolicy { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodVolumes
{
    /// <summary>Name to use for the volume. Required.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>`Secret` to use to populate the volume.</summary>
    [JsonPropertyName("secret")]
    public V1KafkaMirrorMaker2SpecTemplatePodVolumesSecret? Secret { get; set; }

    /// <summary>`ConfigMap` to use to populate the volume.</summary>
    [JsonPropertyName("configMap")]
    public V1KafkaMirrorMaker2SpecTemplatePodVolumesConfigMap? ConfigMap { get; set; }

    /// <summary>`EmptyDir` to use to populate the volume.</summary>
    [JsonPropertyName("emptyDir")]
    public V1KafkaMirrorMaker2SpecTemplatePodVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
    [JsonPropertyName("persistentVolumeClaim")]
    public V1KafkaMirrorMaker2SpecTemplatePodVolumesPersistentVolumeClaim? PersistentVolumeClaim { get; set; }

    /// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("csi")]
    public V1KafkaMirrorMaker2SpecTemplatePodVolumesCsi? Csi { get; set; }

    /// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("image")]
    public V1KafkaMirrorMaker2SpecTemplatePodVolumesImage? Image { get; set; }
}

/// <summary>Template for Kafka Connect `Pods`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePod
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaMirrorMaker2SpecTemplatePodMetadata? Metadata { get; set; }

    /// <summary>List of references to secrets in the same namespace to use for pulling any of the images used by this Pod. When the `STRIMZI_IMAGE_PULL_SECRETS` environment variable in Cluster Operator and the `imagePullSecrets` option are specified, only the `imagePullSecrets` variable is used and the `STRIMZI_IMAGE_PULL_SECRETS` variable is ignored.</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>Configures pod-level security attributes and common container settings.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaMirrorMaker2SpecTemplatePodSecurityContext? SecurityContext { get; set; }

    /// <summary>The grace period is the duration in seconds after the processes running in the pod are sent a termination signal, and the time when the processes are forcibly halted with a kill signal. Set this value to longer than the expected cleanup time for your process. Value must be a non-negative integer. A zero value indicates delete immediately. You might need to increase the grace period for very large Kafka clusters, so that the Kafka brokers have enough time to transfer their work to another broker before they are terminated. Defaults to 30 seconds.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    /// <summary>The pod&apos;s affinity rules.</summary>
    [JsonPropertyName("affinity")]
    public V1KafkaMirrorMaker2SpecTemplatePodAffinity? Affinity { get; set; }

    /// <summary>The pod&apos;s tolerations.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodTolerations>? Tolerations { get; set; }

    /// <summary>The pod&apos;s topology spread constraints.</summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    /// <summary>The name of the priority class used to assign priority to the pods. </summary>
    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    /// <summary>The name of the scheduler used to dispatch this `Pod`. If not specified, the default scheduler will be used.</summary>
    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    /// <summary>The pod&apos;s HostAliases. HostAliases is an optional list of hosts and IPs that will be injected into the Pod&apos;s hosts file if specified.</summary>
    [JsonPropertyName("hostAliases")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodHostAliases>? HostAliases { get; set; }

    /// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
    [JsonPropertyName("dnsPolicy")]
    public V1KafkaMirrorMaker2SpecTemplatePodDnsPolicyEnum? DnsPolicy { get; set; }

    /// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1KafkaMirrorMaker2SpecTemplatePodDnsConfig? DnsConfig { get; set; }

    /// <summary>Indicates whether information about services should be injected into Pod&apos;s environment variables.</summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary>Defines the total amount of pod memory allocated for the temporary `EmptyDir` volume `/tmp`. Specify the allocation in memory units, for example, `100Mi` for 100 mebibytes. Default value is `5Mi`. The `/tmp` volume is backed by pod memory, not disk storage, so avoid setting a high value as it consumes pod memory resources.</summary>
    [JsonPropertyName("tmpDirSizeLimit")]
    public string? TmpDirSizeLimit { get; set; }

    /// <summary>Additional volumes that can be mounted to the pod.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1KafkaMirrorMaker2SpecTemplatePodVolumes>? Volumes { get; set; }

    /// <summary>Use the host user namespace. Optional. Defaults to `true`. When `true` or not set, the pod runs in the host user namespace. This is required when the pod needs features available only in the host namespace, such as loading kernel modules with `CAP_SYS_MODULE`.When set to `false`, the pod runs in a new user namespace. Setting `false` helps mitigate container breakout vulnerabilities and allows containers to run as `root` without granting `root` privileges on the host. This property is alpha-level in Kubernetes and is supported only by Kubernetes clusters that enable the `UserNamespacesSupport` feature.</summary>
    [JsonPropertyName("hostUsers")]
    public bool? HostUsers { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateApiServiceMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Specifies the IP Family Policy used by the service. Available options are `SingleStack`, `PreferDualStack` and `RequireDualStack`. `SingleStack` is for a single IP family. `PreferDualStack` is for two IP families on dual-stack configured clusters or a single IP family on single-stack clusters. `RequireDualStack` fails unless there are two IP families on dual-stack configured clusters. If unspecified, Kubernetes will choose the default value based on the service type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaMirrorMaker2SpecTemplateApiServiceIpFamilyPolicyEnum>))]
public enum V1KafkaMirrorMaker2SpecTemplateApiServiceIpFamilyPolicyEnum
{
    [EnumMember(Value = "SingleStack"), JsonStringEnumMemberName("SingleStack")]
    SingleStack,
    [EnumMember(Value = "PreferDualStack"), JsonStringEnumMemberName("PreferDualStack")]
    PreferDualStack,
    [EnumMember(Value = "RequireDualStack"), JsonStringEnumMemberName("RequireDualStack")]
    RequireDualStack
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaMirrorMaker2SpecTemplateApiServiceIpFamiliesEnum>))]
public enum V1KafkaMirrorMaker2SpecTemplateApiServiceIpFamiliesEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>Template for Kafka Connect API `Service`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateApiService
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaMirrorMaker2SpecTemplateApiServiceMetadata? Metadata { get; set; }

    /// <summary>Specifies the IP Family Policy used by the service. Available options are `SingleStack`, `PreferDualStack` and `RequireDualStack`. `SingleStack` is for a single IP family. `PreferDualStack` is for two IP families on dual-stack configured clusters or a single IP family on single-stack clusters. `RequireDualStack` fails unless there are two IP families on dual-stack configured clusters. If unspecified, Kubernetes will choose the default value based on the service type.</summary>
    [JsonPropertyName("ipFamilyPolicy")]
    public V1KafkaMirrorMaker2SpecTemplateApiServiceIpFamilyPolicyEnum? IpFamilyPolicy { get; set; }

    /// <summary>Specifies the IP Families used by the service. Available options are `IPv4` and `IPv6`. If unspecified, Kubernetes will choose the default value based on the `ipFamilyPolicy` setting.</summary>
    [JsonPropertyName("ipFamilies")]
    public IList<V1KafkaMirrorMaker2SpecTemplateApiServiceIpFamiliesEnum>? IpFamilies { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateHeadlessServiceMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Specifies the IP Family Policy used by the service. Available options are `SingleStack`, `PreferDualStack` and `RequireDualStack`. `SingleStack` is for a single IP family. `PreferDualStack` is for two IP families on dual-stack configured clusters or a single IP family on single-stack clusters. `RequireDualStack` fails unless there are two IP families on dual-stack configured clusters. If unspecified, Kubernetes will choose the default value based on the service type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaMirrorMaker2SpecTemplateHeadlessServiceIpFamilyPolicyEnum>))]
public enum V1KafkaMirrorMaker2SpecTemplateHeadlessServiceIpFamilyPolicyEnum
{
    [EnumMember(Value = "SingleStack"), JsonStringEnumMemberName("SingleStack")]
    SingleStack,
    [EnumMember(Value = "PreferDualStack"), JsonStringEnumMemberName("PreferDualStack")]
    PreferDualStack,
    [EnumMember(Value = "RequireDualStack"), JsonStringEnumMemberName("RequireDualStack")]
    RequireDualStack
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaMirrorMaker2SpecTemplateHeadlessServiceIpFamiliesEnum>))]
public enum V1KafkaMirrorMaker2SpecTemplateHeadlessServiceIpFamiliesEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>Template for Kafka Connect headless `Service`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateHeadlessService
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaMirrorMaker2SpecTemplateHeadlessServiceMetadata? Metadata { get; set; }

    /// <summary>Specifies the IP Family Policy used by the service. Available options are `SingleStack`, `PreferDualStack` and `RequireDualStack`. `SingleStack` is for a single IP family. `PreferDualStack` is for two IP families on dual-stack configured clusters or a single IP family on single-stack clusters. `RequireDualStack` fails unless there are two IP families on dual-stack configured clusters. If unspecified, Kubernetes will choose the default value based on the service type.</summary>
    [JsonPropertyName("ipFamilyPolicy")]
    public V1KafkaMirrorMaker2SpecTemplateHeadlessServiceIpFamilyPolicyEnum? IpFamilyPolicy { get; set; }

    /// <summary>Specifies the IP Families used by the service. Available options are `IPv4` and `IPv6`. If unspecified, Kubernetes will choose the default value based on the `ipFamilyPolicy` setting.</summary>
    [JsonPropertyName("ipFamilies")]
    public IList<V1KafkaMirrorMaker2SpecTemplateHeadlessServiceIpFamiliesEnum>? IpFamilies { get; set; }
}

/// <summary>Reference to a key in a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateConnectContainerEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to a key in a config map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateConnectContainerEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateConnectContainerEnvValueFrom
{
    /// <summary>Reference to a key in a secret.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1KafkaMirrorMaker2SpecTemplateConnectContainerEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary>Reference to a key in a config map.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaMirrorMaker2SpecTemplateConnectContainerEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateConnectContainerEnv
{
    /// <summary>The environment variable key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaMirrorMaker2SpecTemplateConnectContainerEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateConnectContainerSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateConnectContainerSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateConnectContainerSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateConnectContainerSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateConnectContainerSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Security context for the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateConnectContainerSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1KafkaMirrorMaker2SpecTemplateConnectContainerSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1KafkaMirrorMaker2SpecTemplateConnectContainerSecurityContextCapabilities? Capabilities { get; set; }

    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaMirrorMaker2SpecTemplateConnectContainerSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaMirrorMaker2SpecTemplateConnectContainerSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaMirrorMaker2SpecTemplateConnectContainerSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateConnectContainerVolumeMounts
{
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("recursiveReadOnly")]
    public string? RecursiveReadOnly { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

/// <summary>Template for the Kafka Connect container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateConnectContainer
{
    /// <summary>Environment variables which should be applied to the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1KafkaMirrorMaker2SpecTemplateConnectContainerEnv>? Env { get; set; }

    /// <summary>Security context for the container.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaMirrorMaker2SpecTemplateConnectContainerSecurityContext? SecurityContext { get; set; }

    /// <summary>Additional volume mounts which should be applied to the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1KafkaMirrorMaker2SpecTemplateConnectContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Reference to a key in a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateInitContainerEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to a key in a config map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateInitContainerEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateInitContainerEnvValueFrom
{
    /// <summary>Reference to a key in a secret.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1KafkaMirrorMaker2SpecTemplateInitContainerEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary>Reference to a key in a config map.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaMirrorMaker2SpecTemplateInitContainerEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateInitContainerEnv
{
    /// <summary>The environment variable key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaMirrorMaker2SpecTemplateInitContainerEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateInitContainerSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateInitContainerSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateInitContainerSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateInitContainerSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateInitContainerSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Security context for the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateInitContainerSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1KafkaMirrorMaker2SpecTemplateInitContainerSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1KafkaMirrorMaker2SpecTemplateInitContainerSecurityContextCapabilities? Capabilities { get; set; }

    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaMirrorMaker2SpecTemplateInitContainerSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaMirrorMaker2SpecTemplateInitContainerSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaMirrorMaker2SpecTemplateInitContainerSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateInitContainerVolumeMounts
{
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("recursiveReadOnly")]
    public string? RecursiveReadOnly { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

/// <summary>Template for the Kafka init container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateInitContainer
{
    /// <summary>Environment variables which should be applied to the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1KafkaMirrorMaker2SpecTemplateInitContainerEnv>? Env { get; set; }

    /// <summary>Security context for the container.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaMirrorMaker2SpecTemplateInitContainerSecurityContext? SecurityContext { get; set; }

    /// <summary>Additional volume mounts which should be applied to the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1KafkaMirrorMaker2SpecTemplateInitContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodDisruptionBudgetMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Kafka Connect `PodDisruptionBudget`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplatePodDisruptionBudget
{
    /// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaMirrorMaker2SpecTemplatePodDisruptionBudgetMetadata? Metadata { get; set; }

    /// <summary>Maximum number of unavailable pods to allow automatic Pod eviction. A Pod eviction is allowed when the `maxUnavailable` number of pods or fewer are unavailable after the eviction. Setting this value to 0 prevents all voluntary evictions, so the pods must be evicted manually. Defaults to 1.</summary>
    [JsonPropertyName("maxUnavailable")]
    public int? MaxUnavailable { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateServiceAccountMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Kafka Connect service account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateServiceAccount
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaMirrorMaker2SpecTemplateServiceAccountMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateClusterRoleBindingMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Kafka Connect ClusterRoleBinding.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateClusterRoleBinding
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaMirrorMaker2SpecTemplateClusterRoleBindingMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodImagePullSecrets
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodSecurityContextSysctls
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Configures pod-level security attributes and common container settings.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodSecurityContext
{
    [JsonPropertyName("appArmorProfile")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("fsGroup")]
    public int? FsGroup { get; set; }

    [JsonPropertyName("fsGroupChangePolicy")]
    public string? FsGroupChangePolicy { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxChangePolicy")]
    public string? SeLinuxChangePolicy { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("supplementalGroups")]
    public IList<int>? SupplementalGroups { get; set; }

    [JsonPropertyName("supplementalGroupsPolicy")]
    public string? SupplementalGroupsPolicy { get; set; }

    [JsonPropertyName("sysctls")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodSecurityContextSysctls>? Sysctls { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("preference")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference? Preference { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms>? NodeSelectorTerms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>The pod&apos;s affinity rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodAffinity
{
    [JsonPropertyName("nodeAffinity")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityNodeAffinity? NodeAffinity { get; set; }

    [JsonPropertyName("podAffinity")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAffinity? PodAffinity { get; set; }

    [JsonPropertyName("podAntiAffinity")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodTolerations
{
    [JsonPropertyName("effect")]
    public string? Effect { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("tolerationSeconds")]
    public int? TolerationSeconds { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodTopologySpreadConstraintsLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodTopologySpreadConstraintsLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodTopologySpreadConstraints
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("maxSkew")]
    public int? MaxSkew { get; set; }

    [JsonPropertyName("minDomains")]
    public int? MinDomains { get; set; }

    [JsonPropertyName("nodeAffinityPolicy")]
    public string? NodeAffinityPolicy { get; set; }

    [JsonPropertyName("nodeTaintsPolicy")]
    public string? NodeTaintsPolicy { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }

    [JsonPropertyName("whenUnsatisfiable")]
    public string? WhenUnsatisfiable { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodHostAliases
{
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
}

/// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaMirrorMaker2SpecTemplateBuildPodDnsPolicyEnum>))]
public enum V1KafkaMirrorMaker2SpecTemplateBuildPodDnsPolicyEnum
{
    [EnumMember(Value = "ClusterFirst"), JsonStringEnumMemberName("ClusterFirst")]
    ClusterFirst,
    [EnumMember(Value = "ClusterFirstWithHostNet"), JsonStringEnumMemberName("ClusterFirstWithHostNet")]
    ClusterFirstWithHostNet,
    [EnumMember(Value = "Default"), JsonStringEnumMemberName("Default")]
    Default,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodDnsConfigOptions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodDnsConfig
{
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    [JsonPropertyName("options")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodDnsConfigOptions>? Options { get; set; }

    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesSecretItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`Secret` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesSecret
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesSecretItems>? Items { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesConfigMapItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`ConfigMap` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesConfigMap
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesConfigMapItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesEmptyDirMediumEnum>))]
public enum V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesEmptyDirMediumEnum
{
    [EnumMember(Value = "Memory"), JsonStringEnumMemberName("Memory")]
    Memory
}

/// <summary>`EmptyDir` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesEmptyDir
{
    /// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
    [JsonPropertyName("medium")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesEmptyDirMediumEnum? Medium { get; set; }

    /// <summary>The total amount of local storage required for this EmptyDir volume (for example 1Gi).</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesPersistentVolumeClaim
{
    [JsonPropertyName("claimName")]
    public string? ClaimName { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesCsiNodePublishSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesCsi
{
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("nodePublishSecretRef")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesCsiNodePublishSecretRef? NodePublishSecretRef { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

/// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesImage
{
    [JsonPropertyName("pullPolicy")]
    public string? PullPolicy { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPodVolumes
{
    /// <summary>Name to use for the volume. Required.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>`Secret` to use to populate the volume.</summary>
    [JsonPropertyName("secret")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesSecret? Secret { get; set; }

    /// <summary>`ConfigMap` to use to populate the volume.</summary>
    [JsonPropertyName("configMap")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesConfigMap? ConfigMap { get; set; }

    /// <summary>`EmptyDir` to use to populate the volume.</summary>
    [JsonPropertyName("emptyDir")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
    [JsonPropertyName("persistentVolumeClaim")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesPersistentVolumeClaim? PersistentVolumeClaim { get; set; }

    /// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("csi")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesCsi? Csi { get; set; }

    /// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("image")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodVolumesImage? Image { get; set; }
}

/// <summary>Template for Kafka Connect Build `Pods`. The build pod is used only on Kubernetes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildPod
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodMetadata? Metadata { get; set; }

    /// <summary>List of references to secrets in the same namespace to use for pulling any of the images used by this Pod. When the `STRIMZI_IMAGE_PULL_SECRETS` environment variable in Cluster Operator and the `imagePullSecrets` option are specified, only the `imagePullSecrets` variable is used and the `STRIMZI_IMAGE_PULL_SECRETS` variable is ignored.</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>Configures pod-level security attributes and common container settings.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodSecurityContext? SecurityContext { get; set; }

    /// <summary>The grace period is the duration in seconds after the processes running in the pod are sent a termination signal, and the time when the processes are forcibly halted with a kill signal. Set this value to longer than the expected cleanup time for your process. Value must be a non-negative integer. A zero value indicates delete immediately. You might need to increase the grace period for very large Kafka clusters, so that the Kafka brokers have enough time to transfer their work to another broker before they are terminated. Defaults to 30 seconds.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    /// <summary>The pod&apos;s affinity rules.</summary>
    [JsonPropertyName("affinity")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodAffinity? Affinity { get; set; }

    /// <summary>The pod&apos;s tolerations.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodTolerations>? Tolerations { get; set; }

    /// <summary>The pod&apos;s topology spread constraints.</summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    /// <summary>The name of the priority class used to assign priority to the pods. </summary>
    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    /// <summary>The name of the scheduler used to dispatch this `Pod`. If not specified, the default scheduler will be used.</summary>
    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    /// <summary>The pod&apos;s HostAliases. HostAliases is an optional list of hosts and IPs that will be injected into the Pod&apos;s hosts file if specified.</summary>
    [JsonPropertyName("hostAliases")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodHostAliases>? HostAliases { get; set; }

    /// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
    [JsonPropertyName("dnsPolicy")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodDnsPolicyEnum? DnsPolicy { get; set; }

    /// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPodDnsConfig? DnsConfig { get; set; }

    /// <summary>Indicates whether information about services should be injected into Pod&apos;s environment variables.</summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary>Defines the total amount of pod memory allocated for the temporary `EmptyDir` volume `/tmp`. Specify the allocation in memory units, for example, `100Mi` for 100 mebibytes. Default value is `5Mi`. The `/tmp` volume is backed by pod memory, not disk storage, so avoid setting a high value as it consumes pod memory resources.</summary>
    [JsonPropertyName("tmpDirSizeLimit")]
    public string? TmpDirSizeLimit { get; set; }

    /// <summary>Additional volumes that can be mounted to the pod.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildPodVolumes>? Volumes { get; set; }

    /// <summary>Use the host user namespace. Optional. Defaults to `true`. When `true` or not set, the pod runs in the host user namespace. This is required when the pod needs features available only in the host namespace, such as loading kernel modules with `CAP_SYS_MODULE`.When set to `false`, the pod runs in a new user namespace. Setting `false` helps mitigate container breakout vulnerabilities and allows containers to run as `root` without granting `root` privileges on the host. This property is alpha-level in Kubernetes and is supported only by Kubernetes clusters that enable the `UserNamespacesSupport` feature.</summary>
    [JsonPropertyName("hostUsers")]
    public bool? HostUsers { get; set; }
}

/// <summary>Reference to a key in a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildContainerEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to a key in a config map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildContainerEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildContainerEnvValueFrom
{
    /// <summary>Reference to a key in a secret.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1KafkaMirrorMaker2SpecTemplateBuildContainerEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary>Reference to a key in a config map.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaMirrorMaker2SpecTemplateBuildContainerEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildContainerEnv
{
    /// <summary>The environment variable key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaMirrorMaker2SpecTemplateBuildContainerEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildContainerSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildContainerSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildContainerSecurityContextSeLinuxOptions
{
    [JsonPropertyName("level")]
    public string? Level { get; set; }

    [JsonPropertyName("role")]
    public string? Role { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("user")]
    public string? User { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildContainerSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildContainerSecurityContextWindowsOptions
{
    [JsonPropertyName("gmsaCredentialSpec")]
    public string? GmsaCredentialSpec { get; set; }

    [JsonPropertyName("gmsaCredentialSpecName")]
    public string? GmsaCredentialSpecName { get; set; }

    [JsonPropertyName("hostProcess")]
    public bool? HostProcess { get; set; }

    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }
}

/// <summary>Security context for the container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildContainerSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1KafkaMirrorMaker2SpecTemplateBuildContainerSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1KafkaMirrorMaker2SpecTemplateBuildContainerSecurityContextCapabilities? Capabilities { get; set; }

    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("procMount")]
    public string? ProcMount { get; set; }

    [JsonPropertyName("readOnlyRootFilesystem")]
    public bool? ReadOnlyRootFilesystem { get; set; }

    [JsonPropertyName("runAsGroup")]
    public int? RunAsGroup { get; set; }

    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    [JsonPropertyName("runAsUser")]
    public int? RunAsUser { get; set; }

    [JsonPropertyName("seLinuxOptions")]
    public V1KafkaMirrorMaker2SpecTemplateBuildContainerSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaMirrorMaker2SpecTemplateBuildContainerSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaMirrorMaker2SpecTemplateBuildContainerSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildContainerVolumeMounts
{
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("mountPropagation")]
    public string? MountPropagation { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("recursiveReadOnly")]
    public string? RecursiveReadOnly { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("subPathExpr")]
    public string? SubPathExpr { get; set; }
}

/// <summary>Template for the Kafka Connect Build container. The build container is used only on Kubernetes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildContainer
{
    /// <summary>Environment variables which should be applied to the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildContainerEnv>? Env { get; set; }

    /// <summary>Security context for the container.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaMirrorMaker2SpecTemplateBuildContainerSecurityContext? SecurityContext { get; set; }

    /// <summary>Additional volume mounts which should be applied to the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1KafkaMirrorMaker2SpecTemplateBuildContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildConfigMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Kafka Connect BuildConfig used to build new container images. The BuildConfig is used only on OpenShift.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildConfig
{
    /// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaMirrorMaker2SpecTemplateBuildConfigMetadata? Metadata { get; set; }

    /// <summary>Container Registry Secret with the credentials for pulling the base image.</summary>
    [JsonPropertyName("pullSecret")]
    public string? PullSecret { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildServiceAccountMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Kafka Connect Build service account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateBuildServiceAccount
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaMirrorMaker2SpecTemplateBuildServiceAccountMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateJmxSecretMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Secret of the Kafka Connect Cluster JMX authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplateJmxSecret
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaMirrorMaker2SpecTemplateJmxSecretMetadata? Metadata { get; set; }
}

/// <summary>Template for Kafka Connect and Kafka MirrorMaker 2 resources. The template allows users to specify how the `Pods`, `Service`, and other services are generated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2SpecTemplate
{
    /// <summary>Template for Kafka Connect `StrimziPodSet` resource.</summary>
    [JsonPropertyName("podSet")]
    public V1KafkaMirrorMaker2SpecTemplatePodSet? PodSet { get; set; }

    /// <summary>Template for Kafka Connect `Pods`.</summary>
    [JsonPropertyName("pod")]
    public V1KafkaMirrorMaker2SpecTemplatePod? Pod { get; set; }

    /// <summary>Template for Kafka Connect API `Service`.</summary>
    [JsonPropertyName("apiService")]
    public V1KafkaMirrorMaker2SpecTemplateApiService? ApiService { get; set; }

    /// <summary>Template for Kafka Connect headless `Service`.</summary>
    [JsonPropertyName("headlessService")]
    public V1KafkaMirrorMaker2SpecTemplateHeadlessService? HeadlessService { get; set; }

    /// <summary>Template for the Kafka Connect container.</summary>
    [JsonPropertyName("connectContainer")]
    public V1KafkaMirrorMaker2SpecTemplateConnectContainer? ConnectContainer { get; set; }

    /// <summary>Template for the Kafka init container.</summary>
    [JsonPropertyName("initContainer")]
    public V1KafkaMirrorMaker2SpecTemplateInitContainer? InitContainer { get; set; }

    /// <summary>Template for Kafka Connect `PodDisruptionBudget`.</summary>
    [JsonPropertyName("podDisruptionBudget")]
    public V1KafkaMirrorMaker2SpecTemplatePodDisruptionBudget? PodDisruptionBudget { get; set; }

    /// <summary>Template for the Kafka Connect service account.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1KafkaMirrorMaker2SpecTemplateServiceAccount? ServiceAccount { get; set; }

    /// <summary>Template for the Kafka Connect ClusterRoleBinding.</summary>
    [JsonPropertyName("clusterRoleBinding")]
    public V1KafkaMirrorMaker2SpecTemplateClusterRoleBinding? ClusterRoleBinding { get; set; }

    /// <summary>Template for Kafka Connect Build `Pods`. The build pod is used only on Kubernetes.</summary>
    [JsonPropertyName("buildPod")]
    public V1KafkaMirrorMaker2SpecTemplateBuildPod? BuildPod { get; set; }

    /// <summary>Template for the Kafka Connect Build container. The build container is used only on Kubernetes.</summary>
    [JsonPropertyName("buildContainer")]
    public V1KafkaMirrorMaker2SpecTemplateBuildContainer? BuildContainer { get; set; }

    /// <summary>Template for the Kafka Connect BuildConfig used to build new container images. The BuildConfig is used only on OpenShift.</summary>
    [JsonPropertyName("buildConfig")]
    public V1KafkaMirrorMaker2SpecTemplateBuildConfig? BuildConfig { get; set; }

    /// <summary>Template for the Kafka Connect Build service account.</summary>
    [JsonPropertyName("buildServiceAccount")]
    public V1KafkaMirrorMaker2SpecTemplateBuildServiceAccount? BuildServiceAccount { get; set; }

    /// <summary>Template for Secret of the Kafka Connect Cluster JMX authentication.</summary>
    [JsonPropertyName("jmxSecret")]
    public V1KafkaMirrorMaker2SpecTemplateJmxSecret? JmxSecret { get; set; }
}

/// <summary>The specification of the Kafka MirrorMaker 2 cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2Spec
{
    /// <summary>The Kafka Connect version. Defaults to the latest version. Consult the user documentation to understand the process required to upgrade or downgrade the version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }

    /// <summary>The number of pods in the Kafka Connect group. Required in the `v1` version of the Strimzi API.</summary>
    [JsonPropertyName("replicas")]
    public required int Replicas { get; set; }

    /// <summary>The container image used for Kafka Connect pods. If no image name is explicitly specified, it is determined based on the `spec.version` configuration. The image names are specifically mapped to corresponding versions in the Cluster Operator configuration.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>The target Apache Kafka cluster. The target Kafka cluster is used by the underlying Kafka Connect framework for its internal topics.</summary>
    [JsonPropertyName("target")]
    public required V1KafkaMirrorMaker2SpecTarget Target { get; set; }

    /// <summary>Configuration of the MirrorMaker 2 connectors.</summary>
    [JsonPropertyName("mirrors")]
    public required IList<V1KafkaMirrorMaker2SpecMirrors> Mirrors { get; set; }

    /// <summary>The maximum limits for CPU and memory resources and the requested initial resources.</summary>
    [JsonPropertyName("resources")]
    public V1KafkaMirrorMaker2SpecResources? Resources { get; set; }

    /// <summary>Pod liveness checking.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1KafkaMirrorMaker2SpecLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Pod readiness checking.</summary>
    [JsonPropertyName("readinessProbe")]
    public V1KafkaMirrorMaker2SpecReadinessProbe? ReadinessProbe { get; set; }

    /// <summary>JVM Options for pods.</summary>
    [JsonPropertyName("jvmOptions")]
    public V1KafkaMirrorMaker2SpecJvmOptions? JvmOptions { get; set; }

    /// <summary>JMX Options.</summary>
    [JsonPropertyName("jmxOptions")]
    public V1KafkaMirrorMaker2SpecJmxOptions? JmxOptions { get; set; }

    /// <summary>Logging configuration for Kafka Connect.</summary>
    [JsonPropertyName("logging")]
    public V1KafkaMirrorMaker2SpecLogging? Logging { get; set; }

    /// <summary>The image of the init container used for initializing the `client.rack`.</summary>
    [JsonPropertyName("clientRackInitImage")]
    public string? ClientRackInitImage { get; set; }

    /// <summary>Configuration of the node label which will be used as the `client.rack` consumer configuration.</summary>
    [JsonPropertyName("rack")]
    public V1KafkaMirrorMaker2SpecRack? Rack { get; set; }

    /// <summary>Metrics configuration.</summary>
    [JsonPropertyName("metricsConfig")]
    public V1KafkaMirrorMaker2SpecMetricsConfig? MetricsConfig { get; set; }

    /// <summary>The configuration of tracing in Kafka Connect.</summary>
    [JsonPropertyName("tracing")]
    public V1KafkaMirrorMaker2SpecTracing? Tracing { get; set; }

    /// <summary>Template for Kafka Connect and Kafka MirrorMaker 2 resources. The template allows users to specify how the `Pods`, `Service`, and other services are generated.</summary>
    [JsonPropertyName("template")]
    public V1KafkaMirrorMaker2SpecTemplate? Template { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2StatusConditions
{
    /// <summary>The unique identifier of a condition, used to distinguish between other conditions in the resource.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The status of the condition, either True, False or Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Last time the condition of a type changed from one status to another. The required format is &apos;yyyy-MM-ddTHH:mm:ssZ&apos;, in the UTC time zone.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>The reason for the condition&apos;s last transition (a single word in CamelCase).</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Human-readable message indicating details about the condition&apos;s last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2StatusAutoRestartStatuses
{
    /// <summary>The number of times the connector or task is restarted.</summary>
    [JsonPropertyName("count")]
    public int? Count { get; set; }

    /// <summary>The name of the connector being restarted.</summary>
    [JsonPropertyName("connectorName")]
    public string? ConnectorName { get; set; }

    /// <summary>The last time the automatic restart was attempted. The required format is &apos;yyyy-MM-ddTHH:mm:ssZ&apos; in the UTC time zone.</summary>
    [JsonPropertyName("lastRestartTimestamp")]
    public string? LastRestartTimestamp { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2StatusConnectorPlugins
{
    /// <summary>The class of the connector plugin.</summary>
    [JsonPropertyName("class")]
    public string? Class { get; set; }

    /// <summary>The type of the connector plugin. The available types are `sink` and `source`.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The version of the connector plugin.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>The status of the Kafka MirrorMaker 2 cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaMirrorMaker2Status
{
    /// <summary>List of status conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1KafkaMirrorMaker2StatusConditions>? Conditions { get; set; }

    /// <summary>The generation of the CRD that was last reconciled by the operator.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The URL of the REST API endpoint for managing and monitoring Kafka Connect connectors.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>List of MirrorMaker 2 connector statuses, as reported by the Kafka Connect REST API.</summary>
    [JsonPropertyName("connectors")]
    public IList<JsonNode>? Connectors { get; set; }

    /// <summary>List of MirrorMaker 2 connector auto restart statuses.</summary>
    [JsonPropertyName("autoRestartStatuses")]
    public IList<V1KafkaMirrorMaker2StatusAutoRestartStatuses>? AutoRestartStatuses { get; set; }

    /// <summary>The list of connector plugins available in this Kafka Connect deployment.</summary>
    [JsonPropertyName("connectorPlugins")]
    public IList<V1KafkaMirrorMaker2StatusConnectorPlugins>? ConnectorPlugins { get; set; }

    /// <summary>Label selector for pods providing this resource.</summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }

    /// <summary>The current number of pods being used to provide this resource.</summary>
    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KafkaMirrorMaker2 : IKubernetesObject<V1ObjectMeta>, ISpec<V1KafkaMirrorMaker2Spec>, IStatus<V1KafkaMirrorMaker2Status?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KafkaMirrorMaker2";
    public const string KubeGroup = "kafka.strimzi.io";
    public const string KubePluralName = "kafkamirrormaker2s";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.strimzi.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KafkaMirrorMaker2";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The specification of the Kafka MirrorMaker 2 cluster.</summary>
    [JsonPropertyName("spec")]
    public required V1KafkaMirrorMaker2Spec Spec { get; set; }

    /// <summary>The status of the Kafka MirrorMaker 2 cluster.</summary>
    [JsonPropertyName("status")]
    public V1KafkaMirrorMaker2Status? Status { get; set; }
}