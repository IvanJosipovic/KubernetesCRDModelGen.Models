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
public partial class V1KafkaBridgeList : IKubernetesObject<V1ListMeta>, IItems<V1KafkaBridge>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KafkaBridgeList";
    public const string KubeGroup = "kafka.strimzi.io";
    public const string KubePluralName = "kafkabridges";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.strimzi.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KafkaBridgeList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1KafkaBridge objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1KafkaBridge> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTlsTrustedCertificates
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

/// <summary>TLS configuration for connecting HTTP Bridge to the cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTls
{
    /// <summary>Trusted certificates for TLS connection.</summary>
    [JsonPropertyName("trustedCertificates")]
    public IList<V1KafkaBridgeSpecTlsTrustedCertificates>? TrustedCertificates { get; set; }
}

/// <summary>Reference to the `Secret` which holds the certificate and private key pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecAuthenticationCertificateAndKey
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
public partial class V1KafkaBridgeSpecAuthenticationPasswordSecret
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
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaBridgeSpecAuthenticationTypeEnum>))]
public enum V1KafkaBridgeSpecAuthenticationTypeEnum
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
public partial class V1KafkaBridgeSpecAuthentication
{
    /// <summary>Reference to the `Secret` which holds the certificate and private key pair.</summary>
    [JsonPropertyName("certificateAndKey")]
    public V1KafkaBridgeSpecAuthenticationCertificateAndKey? CertificateAndKey { get; set; }

    /// <summary>Configuration for the custom authentication mechanism. Only properties with the `sasl.` and `ssl.keystore.` prefixes are allowed. Specify other options in the regular configuration section of the custom resource.</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>Reference to the `Secret` which holds the password.</summary>
    [JsonPropertyName("passwordSecret")]
    public V1KafkaBridgeSpecAuthenticationPasswordSecret? PasswordSecret { get; set; }

    /// <summary>Enable or disable SASL on this authentication mechanism.</summary>
    [JsonPropertyName("sasl")]
    public bool? Sasl { get; set; }

    /// <summary>Specifies the authentication type. Supported types are `tls`, `scram-sha-256`, `scram-sha-512`, `plain`, and `custom`. `tls` uses TLS client authentication and is supported only over TLS connections. `scram-sha-256` and `scram-sha-512` use SASL SCRAM-SHA-256 and SASL SCRAM-SHA-512 authentication, respectively. `plain` uses SASL PLAIN authentication. `custom` allows you to configure a custom authentication mechanism.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaBridgeSpecAuthenticationTypeEnum Type { get; set; }

    /// <summary>Username used for the authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Reference to the `Secret` which holds the certificate and private key pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecHttpTlsCertificateAndKey
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

/// <summary>TLS configuration for clients connections to the HTTP Bridge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecHttpTls
{
    /// <summary>Reference to the `Secret` which holds the certificate and private key pair.</summary>
    [JsonPropertyName("certificateAndKey")]
    public required V1KafkaBridgeSpecHttpTlsCertificateAndKey CertificateAndKey { get; set; }

    /// <summary>Additional configuration for the HTTP server TLS. Properties with the following prefixes cannot be set: ssl. (with the exception of: ssl.enabled.cipher.suites, ssl.enabled.protocols).</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }
}

/// <summary>CORS configuration for the HTTP Bridge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecHttpCors
{
    /// <summary>List of allowed origins. Java regular expressions can be used.</summary>
    [JsonPropertyName("allowedOrigins")]
    public required IList<string> AllowedOrigins { get; set; }

    /// <summary>List of allowed HTTP methods.</summary>
    [JsonPropertyName("allowedMethods")]
    public required IList<string> AllowedMethods { get; set; }
}

/// <summary>The HTTP related configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecHttp
{
    /// <summary>Port the server listens on.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>TLS configuration for clients connections to the HTTP Bridge.</summary>
    [JsonPropertyName("tls")]
    public V1KafkaBridgeSpecHttpTls? Tls { get; set; }

    /// <summary>CORS configuration for the HTTP Bridge.</summary>
    [JsonPropertyName("cors")]
    public V1KafkaBridgeSpecHttpCors? Cors { get; set; }
}

/// <summary>Kafka AdminClient related configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecAdminClient
{
    /// <summary>The Kafka AdminClient configuration used for AdminClient instances created by the bridge.</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }
}

/// <summary>Kafka consumer related configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecConsumer
{
    /// <summary>Whether the HTTP consumer should be enabled or disabled. The default is enabled (`true`).</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The timeout in seconds for deleting inactive consumers, default is -1 (disabled).</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>The Kafka consumer configuration used for consumer instances created by the bridge. Properties with the following prefixes cannot be set: ssl., bootstrap.servers, group.id, sasl., security. (with the exception of: ssl.endpoint.identification.algorithm, ssl.cipher.suites, ssl.protocol, ssl.enabled.protocols).</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }
}

/// <summary>Kafka producer related configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecProducer
{
    /// <summary>Whether the HTTP producer should be enabled or disabled. The default is enabled (`true`).</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The Kafka producer configuration used for producer instances created by the bridge. Properties with the following prefixes cannot be set: ssl., bootstrap.servers, sasl., security. (with the exception of: ssl.endpoint.identification.algorithm, ssl.cipher.suites, ssl.protocol, ssl.enabled.protocols).</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecResourcesClaims
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

/// <summary>CPU and memory resources to reserve.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecResources
{
    [JsonPropertyName("claims")]
    public IList<V1KafkaBridgeSpecResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecJvmOptionsJavaSystemProperties
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
public partial class V1KafkaBridgeSpecJvmOptions
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
    public IList<V1KafkaBridgeSpecJvmOptionsJavaSystemProperties>? JavaSystemProperties { get; set; }
}

/// <summary>Logging type, must be either &apos;inline&apos; or &apos;external&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaBridgeSpecLoggingTypeEnum>))]
public enum V1KafkaBridgeSpecLoggingTypeEnum
{
    [EnumMember(Value = "inline"), JsonStringEnumMemberName("inline")]
    Inline,
    [EnumMember(Value = "external"), JsonStringEnumMemberName("external")]
    External
}

/// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecLoggingValueFromConfigMapKeyRef
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
public partial class V1KafkaBridgeSpecLoggingValueFrom
{
    /// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaBridgeSpecLoggingValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

/// <summary>Logging configuration for HTTP Bridge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecLogging
{
    /// <summary>A Map from logger name to logger level.</summary>
    [JsonPropertyName("loggers")]
    public IDictionary<string, string>? Loggers { get; set; }

    /// <summary>Logging type, must be either &apos;inline&apos; or &apos;external&apos;.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaBridgeSpecLoggingTypeEnum Type { get; set; }

    /// <summary>`ConfigMap` entry where the logging configuration is stored. </summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaBridgeSpecLoggingValueFrom? ValueFrom { get; set; }
}

/// <summary>Specifies the rack awareness type. Supported types are `topology-label` and `environment-variable`. `topology-label` uses a Kubernetes worker node label to set the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect and MirrorMaker 2. `environment-variable` uses an environment variable to set the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect and MirrorMaker 2. When not specified, `topology-label` type is used by default.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaBridgeSpecRackTypeEnum>))]
public enum V1KafkaBridgeSpecRackTypeEnum
{
    [EnumMember(Value = "topology-label"), JsonStringEnumMemberName("topology-label")]
    TopologyLabel,
    [EnumMember(Value = "environment-variable"), JsonStringEnumMemberName("environment-variable")]
    EnvironmentVariable
}

/// <summary>Configuration of the node label which will be used as the client.rack consumer configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecRack
{
    /// <summary>The name of the environment variable that defines the rack ID. Its value sets the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect or MirrorMaker 2.</summary>
    [JsonPropertyName("envVarName")]
    public string? EnvVarName { get; set; }

    /// <summary>A key that matches labels assigned to the Kubernetes cluster nodes. The value of the label is used to set a broker&apos;s `broker.rack` config, and the `client.rack` config for Kafka Connect or MirrorMaker 2.</summary>
    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }

    /// <summary>Specifies the rack awareness type. Supported types are `topology-label` and `environment-variable`. `topology-label` uses a Kubernetes worker node label to set the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect and MirrorMaker 2. `environment-variable` uses an environment variable to set the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect and MirrorMaker 2. When not specified, `topology-label` type is used by default.</summary>
    [JsonPropertyName("type")]
    public V1KafkaBridgeSpecRackTypeEnum? Type { get; set; }
}

/// <summary>Metrics type. The supported types are `jmxPrometheusExporter` and `strimziMetricsReporter`. Type `jmxPrometheusExporter` uses the Prometheus JMX Exporter to expose Kafka JMX metrics in Prometheus format through an HTTP endpoint. Type `strimziMetricsReporter` uses the Strimzi Metrics Reporter to directly expose Kafka metrics in Prometheus format through an HTTP endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaBridgeSpecMetricsConfigTypeEnum>))]
public enum V1KafkaBridgeSpecMetricsConfigTypeEnum
{
    [EnumMember(Value = "jmxPrometheusExporter"), JsonStringEnumMemberName("jmxPrometheusExporter")]
    JmxPrometheusExporter,
    [EnumMember(Value = "strimziMetricsReporter"), JsonStringEnumMemberName("strimziMetricsReporter")]
    StrimziMetricsReporter
}

/// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecMetricsConfigValueFromConfigMapKeyRef
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
public partial class V1KafkaBridgeSpecMetricsConfigValueFrom
{
    /// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaBridgeSpecMetricsConfigValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

/// <summary>Configuration values for the Strimzi Metrics Reporter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecMetricsConfigValues
{
    /// <summary>A list of regex patterns to filter the metrics to collect. Should contain at least one element.</summary>
    [JsonPropertyName("allowList")]
    public IList<string>? AllowList { get; set; }
}

/// <summary>Metrics configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecMetricsConfig
{
    /// <summary>Metrics type. The supported types are `jmxPrometheusExporter` and `strimziMetricsReporter`. Type `jmxPrometheusExporter` uses the Prometheus JMX Exporter to expose Kafka JMX metrics in Prometheus format through an HTTP endpoint. Type `strimziMetricsReporter` uses the Strimzi Metrics Reporter to directly expose Kafka metrics in Prometheus format through an HTTP endpoint.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaBridgeSpecMetricsConfigTypeEnum Type { get; set; }

    /// <summary>ConfigMap entry where the Prometheus JMX Exporter configuration is stored.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaBridgeSpecMetricsConfigValueFrom? ValueFrom { get; set; }

    /// <summary>Configuration values for the Strimzi Metrics Reporter.</summary>
    [JsonPropertyName("values")]
    public V1KafkaBridgeSpecMetricsConfigValues? Values { get; set; }
}

/// <summary>Pod liveness checking.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecLivenessProbe
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
public partial class V1KafkaBridgeSpecReadinessProbe
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

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateDeploymentMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Pod replacement strategy for deployment configuration changes. Valid values are `RollingUpdate` and `Recreate`. Defaults to `RollingUpdate`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaBridgeSpecTemplateDeploymentDeploymentStrategyEnum>))]
public enum V1KafkaBridgeSpecTemplateDeploymentDeploymentStrategyEnum
{
    [EnumMember(Value = "RollingUpdate"), JsonStringEnumMemberName("RollingUpdate")]
    RollingUpdate,
    [EnumMember(Value = "Recreate"), JsonStringEnumMemberName("Recreate")]
    Recreate
}

/// <summary>Template for HTTP Bridge `Deployment`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateDeployment
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaBridgeSpecTemplateDeploymentMetadata? Metadata { get; set; }

    /// <summary>Pod replacement strategy for deployment configuration changes. Valid values are `RollingUpdate` and `Recreate`. Defaults to `RollingUpdate`.</summary>
    [JsonPropertyName("deploymentStrategy")]
    public V1KafkaBridgeSpecTemplateDeploymentDeploymentStrategyEnum? DeploymentStrategy { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodMetadata
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
public partial class V1KafkaBridgeSpecTemplatePodImagePullSecrets
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodSecurityContextSeLinuxOptions
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
public partial class V1KafkaBridgeSpecTemplatePodSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodSecurityContextSysctls
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodSecurityContextWindowsOptions
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
public partial class V1KafkaBridgeSpecTemplatePodSecurityContext
{
    [JsonPropertyName("appArmorProfile")]
    public V1KafkaBridgeSpecTemplatePodSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

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
    public V1KafkaBridgeSpecTemplatePodSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaBridgeSpecTemplatePodSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("supplementalGroups")]
    public IList<int>? SupplementalGroups { get; set; }

    [JsonPropertyName("supplementalGroupsPolicy")]
    public string? SupplementalGroupsPolicy { get; set; }

    [JsonPropertyName("sysctls")]
    public IList<V1KafkaBridgeSpecTemplatePodSecurityContextSysctls>? Sysctls { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaBridgeSpecTemplatePodSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
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
public partial class V1KafkaBridgeSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
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
public partial class V1KafkaBridgeSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("preference")]
    public V1KafkaBridgeSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference? Preference { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
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
public partial class V1KafkaBridgeSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
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
public partial class V1KafkaBridgeSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms>? NodeSelectorTerms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityNodeAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1KafkaBridgeSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaBridgeSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaBridgeSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaBridgeSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaBridgeSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaBridgeSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
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
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
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
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
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
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
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
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>The pod&apos;s affinity rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodAffinity
{
    [JsonPropertyName("nodeAffinity")]
    public V1KafkaBridgeSpecTemplatePodAffinityNodeAffinity? NodeAffinity { get; set; }

    [JsonPropertyName("podAffinity")]
    public V1KafkaBridgeSpecTemplatePodAffinityPodAffinity? PodAffinity { get; set; }

    [JsonPropertyName("podAntiAffinity")]
    public V1KafkaBridgeSpecTemplatePodAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodTolerations
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
public partial class V1KafkaBridgeSpecTemplatePodTopologySpreadConstraintsLabelSelectorMatchExpressions
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
public partial class V1KafkaBridgeSpecTemplatePodTopologySpreadConstraintsLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaBridgeSpecTemplatePodTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodTopologySpreadConstraints
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaBridgeSpecTemplatePodTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

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
public partial class V1KafkaBridgeSpecTemplatePodHostAliases
{
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
}

/// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaBridgeSpecTemplatePodDnsPolicyEnum>))]
public enum V1KafkaBridgeSpecTemplatePodDnsPolicyEnum
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
public partial class V1KafkaBridgeSpecTemplatePodDnsConfigOptions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodDnsConfig
{
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    [JsonPropertyName("options")]
    public IList<V1KafkaBridgeSpecTemplatePodDnsConfigOptions>? Options { get; set; }

    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodVolumesSecretItems
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
public partial class V1KafkaBridgeSpecTemplatePodVolumesSecret
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaBridgeSpecTemplatePodVolumesSecretItems>? Items { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodVolumesConfigMapItems
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
public partial class V1KafkaBridgeSpecTemplatePodVolumesConfigMap
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaBridgeSpecTemplatePodVolumesConfigMapItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaBridgeSpecTemplatePodVolumesEmptyDirMediumEnum>))]
public enum V1KafkaBridgeSpecTemplatePodVolumesEmptyDirMediumEnum
{
    [EnumMember(Value = "Memory"), JsonStringEnumMemberName("Memory")]
    Memory
}

/// <summary>`EmptyDir` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodVolumesEmptyDir
{
    /// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
    [JsonPropertyName("medium")]
    public V1KafkaBridgeSpecTemplatePodVolumesEmptyDirMediumEnum? Medium { get; set; }

    /// <summary>The total amount of local storage required for this EmptyDir volume (for example 1Gi).</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodVolumesPersistentVolumeClaim
{
    [JsonPropertyName("claimName")]
    public string? ClaimName { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodVolumesCsiNodePublishSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodVolumesCsi
{
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("nodePublishSecretRef")]
    public V1KafkaBridgeSpecTemplatePodVolumesCsiNodePublishSecretRef? NodePublishSecretRef { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

/// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodVolumesImage
{
    [JsonPropertyName("pullPolicy")]
    public string? PullPolicy { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodVolumes
{
    /// <summary>Name to use for the volume. Required.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>`Secret` to use to populate the volume.</summary>
    [JsonPropertyName("secret")]
    public V1KafkaBridgeSpecTemplatePodVolumesSecret? Secret { get; set; }

    /// <summary>`ConfigMap` to use to populate the volume.</summary>
    [JsonPropertyName("configMap")]
    public V1KafkaBridgeSpecTemplatePodVolumesConfigMap? ConfigMap { get; set; }

    /// <summary>`EmptyDir` to use to populate the volume.</summary>
    [JsonPropertyName("emptyDir")]
    public V1KafkaBridgeSpecTemplatePodVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
    [JsonPropertyName("persistentVolumeClaim")]
    public V1KafkaBridgeSpecTemplatePodVolumesPersistentVolumeClaim? PersistentVolumeClaim { get; set; }

    /// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("csi")]
    public V1KafkaBridgeSpecTemplatePodVolumesCsi? Csi { get; set; }

    /// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("image")]
    public V1KafkaBridgeSpecTemplatePodVolumesImage? Image { get; set; }
}

/// <summary>Template for HTTP Bridge `Pods`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePod
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaBridgeSpecTemplatePodMetadata? Metadata { get; set; }

    /// <summary>List of references to secrets in the same namespace to use for pulling any of the images used by this Pod. When the `STRIMZI_IMAGE_PULL_SECRETS` environment variable in Cluster Operator and the `imagePullSecrets` option are specified, only the `imagePullSecrets` variable is used and the `STRIMZI_IMAGE_PULL_SECRETS` variable is ignored.</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1KafkaBridgeSpecTemplatePodImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>Configures pod-level security attributes and common container settings.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaBridgeSpecTemplatePodSecurityContext? SecurityContext { get; set; }

    /// <summary>The grace period is the duration in seconds after the processes running in the pod are sent a termination signal, and the time when the processes are forcibly halted with a kill signal. Set this value to longer than the expected cleanup time for your process. Value must be a non-negative integer. A zero value indicates delete immediately. You might need to increase the grace period for very large Kafka clusters, so that the Kafka brokers have enough time to transfer their work to another broker before they are terminated. Defaults to 30 seconds.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    /// <summary>The pod&apos;s affinity rules.</summary>
    [JsonPropertyName("affinity")]
    public V1KafkaBridgeSpecTemplatePodAffinity? Affinity { get; set; }

    /// <summary>The pod&apos;s tolerations.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1KafkaBridgeSpecTemplatePodTolerations>? Tolerations { get; set; }

    /// <summary>The pod&apos;s topology spread constraints.</summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1KafkaBridgeSpecTemplatePodTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    /// <summary>The name of the priority class used to assign priority to the pods. </summary>
    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    /// <summary>The name of the scheduler used to dispatch this `Pod`. If not specified, the default scheduler will be used.</summary>
    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    /// <summary>The pod&apos;s HostAliases. HostAliases is an optional list of hosts and IPs that will be injected into the Pod&apos;s hosts file if specified.</summary>
    [JsonPropertyName("hostAliases")]
    public IList<V1KafkaBridgeSpecTemplatePodHostAliases>? HostAliases { get; set; }

    /// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
    [JsonPropertyName("dnsPolicy")]
    public V1KafkaBridgeSpecTemplatePodDnsPolicyEnum? DnsPolicy { get; set; }

    /// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1KafkaBridgeSpecTemplatePodDnsConfig? DnsConfig { get; set; }

    /// <summary>Indicates whether information about services should be injected into Pod&apos;s environment variables.</summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary>Defines the total amount of pod memory allocated for the temporary `EmptyDir` volume `/tmp`. Specify the allocation in memory units, for example, `100Mi` for 100 mebibytes. Default value is `5Mi`. The `/tmp` volume is backed by pod memory, not disk storage, so avoid setting a high value as it consumes pod memory resources.</summary>
    [JsonPropertyName("tmpDirSizeLimit")]
    public string? TmpDirSizeLimit { get; set; }

    /// <summary>Additional volumes that can be mounted to the pod.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1KafkaBridgeSpecTemplatePodVolumes>? Volumes { get; set; }

    /// <summary>Use the host user namespace. Optional. Defaults to `true`. When `true` or not set, the pod runs in the host user namespace. This is required when the pod needs features available only in the host namespace, such as loading kernel modules with `CAP_SYS_MODULE`.When set to `false`, the pod runs in a new user namespace. Setting `false` helps mitigate container breakout vulnerabilities and allows containers to run as `root` without granting `root` privileges on the host. This property is alpha-level in Kubernetes and is supported only by Kubernetes clusters that enable the `UserNamespacesSupport` feature.</summary>
    [JsonPropertyName("hostUsers")]
    public bool? HostUsers { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateApiServiceMetadata
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
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaBridgeSpecTemplateApiServiceIpFamilyPolicyEnum>))]
public enum V1KafkaBridgeSpecTemplateApiServiceIpFamilyPolicyEnum
{
    [EnumMember(Value = "SingleStack"), JsonStringEnumMemberName("SingleStack")]
    SingleStack,
    [EnumMember(Value = "PreferDualStack"), JsonStringEnumMemberName("PreferDualStack")]
    PreferDualStack,
    [EnumMember(Value = "RequireDualStack"), JsonStringEnumMemberName("RequireDualStack")]
    RequireDualStack
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaBridgeSpecTemplateApiServiceIpFamiliesEnum>))]
public enum V1KafkaBridgeSpecTemplateApiServiceIpFamiliesEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>Template for HTTP Bridge API `Service`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateApiService
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaBridgeSpecTemplateApiServiceMetadata? Metadata { get; set; }

    /// <summary>Specifies the IP Family Policy used by the service. Available options are `SingleStack`, `PreferDualStack` and `RequireDualStack`. `SingleStack` is for a single IP family. `PreferDualStack` is for two IP families on dual-stack configured clusters or a single IP family on single-stack clusters. `RequireDualStack` fails unless there are two IP families on dual-stack configured clusters. If unspecified, Kubernetes will choose the default value based on the service type.</summary>
    [JsonPropertyName("ipFamilyPolicy")]
    public V1KafkaBridgeSpecTemplateApiServiceIpFamilyPolicyEnum? IpFamilyPolicy { get; set; }

    /// <summary>Specifies the IP Families used by the service. Available options are `IPv4` and `IPv6`. If unspecified, Kubernetes will choose the default value based on the `ipFamilyPolicy` setting.</summary>
    [JsonPropertyName("ipFamilies")]
    public IList<V1KafkaBridgeSpecTemplateApiServiceIpFamiliesEnum>? IpFamilies { get; set; }
}

/// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodDisruptionBudgetMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for HTTP Bridge `PodDisruptionBudget`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplatePodDisruptionBudget
{
    /// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaBridgeSpecTemplatePodDisruptionBudgetMetadata? Metadata { get; set; }

    /// <summary>Maximum number of unavailable pods to allow automatic Pod eviction. A Pod eviction is allowed when the `maxUnavailable` number of pods or fewer are unavailable after the eviction. Setting this value to 0 prevents all voluntary evictions, so the pods must be evicted manually. Defaults to 1.</summary>
    [JsonPropertyName("maxUnavailable")]
    public int? MaxUnavailable { get; set; }
}

/// <summary>Reference to a key in a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateBridgeContainerEnvValueFromSecretKeyRef
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
public partial class V1KafkaBridgeSpecTemplateBridgeContainerEnvValueFromConfigMapKeyRef
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
public partial class V1KafkaBridgeSpecTemplateBridgeContainerEnvValueFrom
{
    /// <summary>Reference to a key in a secret.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1KafkaBridgeSpecTemplateBridgeContainerEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary>Reference to a key in a config map.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaBridgeSpecTemplateBridgeContainerEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateBridgeContainerEnv
{
    /// <summary>The environment variable key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaBridgeSpecTemplateBridgeContainerEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateBridgeContainerSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateBridgeContainerSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateBridgeContainerSecurityContextSeLinuxOptions
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
public partial class V1KafkaBridgeSpecTemplateBridgeContainerSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateBridgeContainerSecurityContextWindowsOptions
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
public partial class V1KafkaBridgeSpecTemplateBridgeContainerSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1KafkaBridgeSpecTemplateBridgeContainerSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1KafkaBridgeSpecTemplateBridgeContainerSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1KafkaBridgeSpecTemplateBridgeContainerSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaBridgeSpecTemplateBridgeContainerSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaBridgeSpecTemplateBridgeContainerSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateBridgeContainerVolumeMounts
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

/// <summary>Template for the HTTP Bridge container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateBridgeContainer
{
    /// <summary>Environment variables which should be applied to the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1KafkaBridgeSpecTemplateBridgeContainerEnv>? Env { get; set; }

    /// <summary>Security context for the container.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaBridgeSpecTemplateBridgeContainerSecurityContext? SecurityContext { get; set; }

    /// <summary>Additional volume mounts which should be applied to the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1KafkaBridgeSpecTemplateBridgeContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateClusterRoleBindingMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the HTTP Bridge ClusterRoleBinding.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateClusterRoleBinding
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaBridgeSpecTemplateClusterRoleBindingMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateServiceAccountMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the HTTP Bridge service account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateServiceAccount
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaBridgeSpecTemplateServiceAccountMetadata? Metadata { get; set; }
}

/// <summary>Reference to a key in a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateInitContainerEnvValueFromSecretKeyRef
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
public partial class V1KafkaBridgeSpecTemplateInitContainerEnvValueFromConfigMapKeyRef
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
public partial class V1KafkaBridgeSpecTemplateInitContainerEnvValueFrom
{
    /// <summary>Reference to a key in a secret.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1KafkaBridgeSpecTemplateInitContainerEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary>Reference to a key in a config map.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaBridgeSpecTemplateInitContainerEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateInitContainerEnv
{
    /// <summary>The environment variable key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaBridgeSpecTemplateInitContainerEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateInitContainerSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateInitContainerSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateInitContainerSecurityContextSeLinuxOptions
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
public partial class V1KafkaBridgeSpecTemplateInitContainerSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateInitContainerSecurityContextWindowsOptions
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
public partial class V1KafkaBridgeSpecTemplateInitContainerSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1KafkaBridgeSpecTemplateInitContainerSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1KafkaBridgeSpecTemplateInitContainerSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1KafkaBridgeSpecTemplateInitContainerSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaBridgeSpecTemplateInitContainerSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaBridgeSpecTemplateInitContainerSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateInitContainerVolumeMounts
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

/// <summary>Template for the HTTP Bridge init container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplateInitContainer
{
    /// <summary>Environment variables which should be applied to the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1KafkaBridgeSpecTemplateInitContainerEnv>? Env { get; set; }

    /// <summary>Security context for the container.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaBridgeSpecTemplateInitContainerSecurityContext? SecurityContext { get; set; }

    /// <summary>Additional volume mounts which should be applied to the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1KafkaBridgeSpecTemplateInitContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Template for HTTP Bridge resources. The template allows users to specify how a `Deployment` and `Pod` is generated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTemplate
{
    /// <summary>Template for HTTP Bridge `Deployment`.</summary>
    [JsonPropertyName("deployment")]
    public V1KafkaBridgeSpecTemplateDeployment? Deployment { get; set; }

    /// <summary>Template for HTTP Bridge `Pods`.</summary>
    [JsonPropertyName("pod")]
    public V1KafkaBridgeSpecTemplatePod? Pod { get; set; }

    /// <summary>Template for HTTP Bridge API `Service`.</summary>
    [JsonPropertyName("apiService")]
    public V1KafkaBridgeSpecTemplateApiService? ApiService { get; set; }

    /// <summary>Template for HTTP Bridge `PodDisruptionBudget`.</summary>
    [JsonPropertyName("podDisruptionBudget")]
    public V1KafkaBridgeSpecTemplatePodDisruptionBudget? PodDisruptionBudget { get; set; }

    /// <summary>Template for the HTTP Bridge container.</summary>
    [JsonPropertyName("bridgeContainer")]
    public V1KafkaBridgeSpecTemplateBridgeContainer? BridgeContainer { get; set; }

    /// <summary>Template for the HTTP Bridge ClusterRoleBinding.</summary>
    [JsonPropertyName("clusterRoleBinding")]
    public V1KafkaBridgeSpecTemplateClusterRoleBinding? ClusterRoleBinding { get; set; }

    /// <summary>Template for the HTTP Bridge service account.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1KafkaBridgeSpecTemplateServiceAccount? ServiceAccount { get; set; }

    /// <summary>Template for the HTTP Bridge init container.</summary>
    [JsonPropertyName("initContainer")]
    public V1KafkaBridgeSpecTemplateInitContainer? InitContainer { get; set; }
}

/// <summary>Type of the tracing used. Currently the only supported type is `opentelemetry` for OpenTelemetry tracing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaBridgeSpecTracingTypeEnum>))]
public enum V1KafkaBridgeSpecTracingTypeEnum
{
    [EnumMember(Value = "opentelemetry"), JsonStringEnumMemberName("opentelemetry")]
    Opentelemetry
}

/// <summary>The configuration of tracing in HTTP Bridge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpecTracing
{
    /// <summary>Type of the tracing used. Currently the only supported type is `opentelemetry` for OpenTelemetry tracing.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaBridgeSpecTracingTypeEnum Type { get; set; }
}

/// <summary>The specification of the HTTP Bridge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeSpec
{
    /// <summary>The number of pods in the `Deployment`. Required in the `v1` version of the Strimzi API.</summary>
    [JsonPropertyName("replicas")]
    public required int Replicas { get; set; }

    /// <summary>The container image used for HTTP Bridge pods. If no image name is explicitly specified, the image name corresponds to the image specified in the Cluster Operator configuration. If an image name is not defined in the Cluster Operator configuration, a default value is used.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>A list of host:port pairs for establishing the initial connection to the Kafka cluster.</summary>
    [JsonPropertyName("bootstrapServers")]
    public required string BootstrapServers { get; set; }

    /// <summary>TLS configuration for connecting HTTP Bridge to the cluster.</summary>
    [JsonPropertyName("tls")]
    public V1KafkaBridgeSpecTls? Tls { get; set; }

    /// <summary>Authentication configuration for connecting to the cluster.</summary>
    [JsonPropertyName("authentication")]
    public V1KafkaBridgeSpecAuthentication? Authentication { get; set; }

    /// <summary>The HTTP related configuration.</summary>
    [JsonPropertyName("http")]
    public V1KafkaBridgeSpecHttp? Http { get; set; }

    /// <summary>Kafka AdminClient related configuration.</summary>
    [JsonPropertyName("adminClient")]
    public V1KafkaBridgeSpecAdminClient? AdminClient { get; set; }

    /// <summary>Kafka consumer related configuration.</summary>
    [JsonPropertyName("consumer")]
    public V1KafkaBridgeSpecConsumer? Consumer { get; set; }

    /// <summary>Kafka producer related configuration.</summary>
    [JsonPropertyName("producer")]
    public V1KafkaBridgeSpecProducer? Producer { get; set; }

    /// <summary>CPU and memory resources to reserve.</summary>
    [JsonPropertyName("resources")]
    public V1KafkaBridgeSpecResources? Resources { get; set; }

    /// <summary>JVM Options for pods.</summary>
    [JsonPropertyName("jvmOptions")]
    public V1KafkaBridgeSpecJvmOptions? JvmOptions { get; set; }

    /// <summary>Logging configuration for HTTP Bridge.</summary>
    [JsonPropertyName("logging")]
    public V1KafkaBridgeSpecLogging? Logging { get; set; }

    /// <summary>The image of the init container used for initializing the `client.rack`.</summary>
    [JsonPropertyName("clientRackInitImage")]
    public string? ClientRackInitImage { get; set; }

    /// <summary>Configuration of the node label which will be used as the client.rack consumer configuration.</summary>
    [JsonPropertyName("rack")]
    public V1KafkaBridgeSpecRack? Rack { get; set; }

    /// <summary>Metrics configuration.</summary>
    [JsonPropertyName("metricsConfig")]
    public V1KafkaBridgeSpecMetricsConfig? MetricsConfig { get; set; }

    /// <summary>Pod liveness checking.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1KafkaBridgeSpecLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Pod readiness checking.</summary>
    [JsonPropertyName("readinessProbe")]
    public V1KafkaBridgeSpecReadinessProbe? ReadinessProbe { get; set; }

    /// <summary>Template for HTTP Bridge resources. The template allows users to specify how a `Deployment` and `Pod` is generated.</summary>
    [JsonPropertyName("template")]
    public V1KafkaBridgeSpecTemplate? Template { get; set; }

    /// <summary>The configuration of tracing in HTTP Bridge.</summary>
    [JsonPropertyName("tracing")]
    public V1KafkaBridgeSpecTracing? Tracing { get; set; }

    /// <summary>Additional configuration for the HTTP bridge. The following prefixes cannot be set: kafka., http., bridge.metrics. The following options cannot be set: bridge.id, bridge.tracing, bridge.metrics.</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeStatusConditions
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

/// <summary>The status of the HTTP Bridge.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaBridgeStatus
{
    /// <summary>List of status conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1KafkaBridgeStatusConditions>? Conditions { get; set; }

    /// <summary>The generation of the CRD that was last reconciled by the operator.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The URL at which external client applications can access the HTTP Bridge.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The current number of pods being used to provide this resource.</summary>
    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }

    /// <summary>Label selector for pods providing this resource.</summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KafkaBridge : IKubernetesObject<V1ObjectMeta>, ISpec<V1KafkaBridgeSpec>, IStatus<V1KafkaBridgeStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KafkaBridge";
    public const string KubeGroup = "kafka.strimzi.io";
    public const string KubePluralName = "kafkabridges";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.strimzi.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KafkaBridge";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The specification of the HTTP Bridge.</summary>
    [JsonPropertyName("spec")]
    public required V1KafkaBridgeSpec Spec { get; set; }

    /// <summary>The status of the HTTP Bridge.</summary>
    [JsonPropertyName("status")]
    public V1KafkaBridgeStatus? Status { get; set; }
}