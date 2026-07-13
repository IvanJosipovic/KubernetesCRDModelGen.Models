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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KafkaConnectList : IKubernetesObject<V1ListMeta>, IItems<V1KafkaConnect>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KafkaConnectList";
    public const string KubeGroup = "kafka.strimzi.io";
    public const string KubePluralName = "kafkaconnects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.strimzi.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KafkaConnectList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1KafkaConnect objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1KafkaConnect> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTlsTrustedCertificates
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

/// <summary>TLS configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTls
{
    /// <summary>Trusted certificates for TLS connection.</summary>
    [JsonPropertyName("trustedCertificates")]
    public IList<V1KafkaConnectSpecTlsTrustedCertificates>? TrustedCertificates { get; set; }
}

/// <summary>Reference to the `Secret` which holds the certificate and private key pair.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecAuthenticationCertificateAndKey
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecAuthenticationPasswordSecret
{
    /// <summary>The name of the Secret containing the password.</summary>
    [JsonPropertyName("secretName")]
    public required string SecretName { get; set; }

    /// <summary>The name of the key in the Secret under which the password is stored.</summary>
    [JsonPropertyName("password")]
    public required string Password { get; set; }
}

/// <summary>Specifies the authentication type. Supported types are `tls`, `scram-sha-256`, `scram-sha-512`, `plain`, and `custom`. `tls` uses TLS client authentication and is supported only over TLS connections. `scram-sha-256` and `scram-sha-512` use SASL SCRAM-SHA-256 and SASL SCRAM-SHA-512 authentication, respectively. `plain` uses SASL PLAIN authentication. `custom` allows you to configure a custom authentication mechanism.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecAuthenticationTypeEnum>))]
public enum V1KafkaConnectSpecAuthenticationTypeEnum
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

/// <summary>Authentication configuration for Kafka Connect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecAuthentication
{
    /// <summary>Reference to the `Secret` which holds the certificate and private key pair.</summary>
    [JsonPropertyName("certificateAndKey")]
    public V1KafkaConnectSpecAuthenticationCertificateAndKey? CertificateAndKey { get; set; }

    /// <summary>Configuration for the custom authentication mechanism. Only properties with the `sasl.` and `ssl.keystore.` prefixes are allowed. Specify other options in the regular configuration section of the custom resource.</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>Reference to the `Secret` which holds the password.</summary>
    [JsonPropertyName("passwordSecret")]
    public V1KafkaConnectSpecAuthenticationPasswordSecret? PasswordSecret { get; set; }

    /// <summary>Enable or disable SASL on this authentication mechanism.</summary>
    [JsonPropertyName("sasl")]
    public bool? Sasl { get; set; }

    /// <summary>Specifies the authentication type. Supported types are `tls`, `scram-sha-256`, `scram-sha-512`, `plain`, and `custom`. `tls` uses TLS client authentication and is supported only over TLS connections. `scram-sha-256` and `scram-sha-512` use SASL SCRAM-SHA-256 and SASL SCRAM-SHA-512 authentication, respectively. `plain` uses SASL PLAIN authentication. `custom` allows you to configure a custom authentication mechanism.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaConnectSpecAuthenticationTypeEnum Type { get; set; }

    /// <summary>Username used for the authentication.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecResourcesClaims
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

/// <summary>The maximum limits for CPU and memory resources and the requested initial resources.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecResources
{
    [JsonPropertyName("claims")]
    public IList<V1KafkaConnectSpecResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

/// <summary>Pod liveness checking.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecLivenessProbe
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecReadinessProbe
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecJvmOptionsJavaSystemProperties
{
    /// <summary>The system property name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The system property value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>JVM Options for pods.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecJvmOptions
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
    public IList<V1KafkaConnectSpecJvmOptionsJavaSystemProperties>? JavaSystemProperties { get; set; }
}

/// <summary>Authentication type. Currently the only supported types are `password`.`password` type creates a username and protected port with no TLS.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecJmxOptionsAuthenticationTypeEnum>))]
public enum V1KafkaConnectSpecJmxOptionsAuthenticationTypeEnum
{
    [EnumMember(Value = "password"), JsonStringEnumMemberName("password")]
    Password
}

/// <summary>Authentication configuration for connecting to the JMX port.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecJmxOptionsAuthentication
{
    /// <summary>Authentication type. Currently the only supported types are `password`.`password` type creates a username and protected port with no TLS.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaConnectSpecJmxOptionsAuthenticationTypeEnum Type { get; set; }
}

/// <summary>JMX Options.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecJmxOptions
{
    /// <summary>Authentication configuration for connecting to the JMX port.</summary>
    [JsonPropertyName("authentication")]
    public V1KafkaConnectSpecJmxOptionsAuthentication? Authentication { get; set; }
}

/// <summary>Logging type, must be either &apos;inline&apos; or &apos;external&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecLoggingTypeEnum>))]
public enum V1KafkaConnectSpecLoggingTypeEnum
{
    [EnumMember(Value = "inline"), JsonStringEnumMemberName("inline")]
    Inline,
    [EnumMember(Value = "external"), JsonStringEnumMemberName("external")]
    External
}

/// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecLoggingValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>`ConfigMap` entry where the logging configuration is stored. </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecLoggingValueFrom
{
    /// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaConnectSpecLoggingValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

/// <summary>Logging configuration for Kafka Connect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecLogging
{
    /// <summary>A Map from logger name to logger level.</summary>
    [JsonPropertyName("loggers")]
    public IDictionary<string, string>? Loggers { get; set; }

    /// <summary>Logging type, must be either &apos;inline&apos; or &apos;external&apos;.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaConnectSpecLoggingTypeEnum Type { get; set; }

    /// <summary>`ConfigMap` entry where the logging configuration is stored. </summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaConnectSpecLoggingValueFrom? ValueFrom { get; set; }
}

/// <summary>Specifies the rack awareness type. Supported types are `topology-label` and `environment-variable`. `topology-label` uses a Kubernetes worker node label to set the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect and MirrorMaker 2. `environment-variable` uses an environment variable to set the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect and MirrorMaker 2. When not specified, `topology-label` type is used by default.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecRackTypeEnum>))]
public enum V1KafkaConnectSpecRackTypeEnum
{
    [EnumMember(Value = "topology-label"), JsonStringEnumMemberName("topology-label")]
    TopologyLabel,
    [EnumMember(Value = "environment-variable"), JsonStringEnumMemberName("environment-variable")]
    EnvironmentVariable
}

/// <summary>Configuration of the node label which will be used as the `client.rack` consumer configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecRack
{
    /// <summary>The name of the environment variable that defines the rack ID. Its value sets the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect or MirrorMaker 2.</summary>
    [JsonPropertyName("envVarName")]
    public string? EnvVarName { get; set; }

    /// <summary>A key that matches labels assigned to the Kubernetes cluster nodes. The value of the label is used to set a broker&apos;s `broker.rack` config, and the `client.rack` config for Kafka Connect or MirrorMaker 2.</summary>
    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }

    /// <summary>Specifies the rack awareness type. Supported types are `topology-label` and `environment-variable`. `topology-label` uses a Kubernetes worker node label to set the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect and MirrorMaker 2. `environment-variable` uses an environment variable to set the `broker.rack` configuration for Kafka brokers and the `client.rack` configuration for Kafka Connect and MirrorMaker 2. When not specified, `topology-label` type is used by default.</summary>
    [JsonPropertyName("type")]
    public V1KafkaConnectSpecRackTypeEnum? Type { get; set; }
}

/// <summary>Metrics type. The supported types are `jmxPrometheusExporter` and `strimziMetricsReporter`. Type `jmxPrometheusExporter` uses the Prometheus JMX Exporter to expose Kafka JMX metrics in Prometheus format through an HTTP endpoint. Type `strimziMetricsReporter` uses the Strimzi Metrics Reporter to directly expose Kafka metrics in Prometheus format through an HTTP endpoint.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecMetricsConfigTypeEnum>))]
public enum V1KafkaConnectSpecMetricsConfigTypeEnum
{
    [EnumMember(Value = "jmxPrometheusExporter"), JsonStringEnumMemberName("jmxPrometheusExporter")]
    JmxPrometheusExporter,
    [EnumMember(Value = "strimziMetricsReporter"), JsonStringEnumMemberName("strimziMetricsReporter")]
    StrimziMetricsReporter
}

/// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecMetricsConfigValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>ConfigMap entry where the Prometheus JMX Exporter configuration is stored.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecMetricsConfigValueFrom
{
    /// <summary>Reference to the key in the ConfigMap containing the configuration.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaConnectSpecMetricsConfigValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

/// <summary>Configuration values for the Strimzi Metrics Reporter.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecMetricsConfigValues
{
    /// <summary>A list of regex patterns to filter the metrics to collect. Should contain at least one element.</summary>
    [JsonPropertyName("allowList")]
    public IList<string>? AllowList { get; set; }
}

/// <summary>Metrics configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecMetricsConfig
{
    /// <summary>Metrics type. The supported types are `jmxPrometheusExporter` and `strimziMetricsReporter`. Type `jmxPrometheusExporter` uses the Prometheus JMX Exporter to expose Kafka JMX metrics in Prometheus format through an HTTP endpoint. Type `strimziMetricsReporter` uses the Strimzi Metrics Reporter to directly expose Kafka metrics in Prometheus format through an HTTP endpoint.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaConnectSpecMetricsConfigTypeEnum Type { get; set; }

    /// <summary>ConfigMap entry where the Prometheus JMX Exporter configuration is stored.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaConnectSpecMetricsConfigValueFrom? ValueFrom { get; set; }

    /// <summary>Configuration values for the Strimzi Metrics Reporter.</summary>
    [JsonPropertyName("values")]
    public V1KafkaConnectSpecMetricsConfigValues? Values { get; set; }
}

/// <summary>Type of the tracing used. Currently the only supported type is `opentelemetry` for OpenTelemetry tracing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecTracingTypeEnum>))]
public enum V1KafkaConnectSpecTracingTypeEnum
{
    [EnumMember(Value = "opentelemetry"), JsonStringEnumMemberName("opentelemetry")]
    Opentelemetry
}

/// <summary>The configuration of tracing in Kafka Connect.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTracing
{
    /// <summary>Type of the tracing used. Currently the only supported type is `opentelemetry` for OpenTelemetry tracing.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaConnectSpecTracingTypeEnum Type { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodSetMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Kafka Connect `StrimziPodSet` resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodSet
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaConnectSpecTemplatePodSetMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodImagePullSecrets
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodSecurityContextSeLinuxOptions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodSecurityContextSysctls
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodSecurityContextWindowsOptions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodSecurityContext
{
    [JsonPropertyName("appArmorProfile")]
    public V1KafkaConnectSpecTemplatePodSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

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
    public V1KafkaConnectSpecTemplatePodSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaConnectSpecTemplatePodSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("supplementalGroups")]
    public IList<int>? SupplementalGroups { get; set; }

    [JsonPropertyName("supplementalGroupsPolicy")]
    public string? SupplementalGroupsPolicy { get; set; }

    [JsonPropertyName("sysctls")]
    public IList<V1KafkaConnectSpecTemplatePodSecurityContextSysctls>? Sysctls { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaConnectSpecTemplatePodSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("preference")]
    public V1KafkaConnectSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference? Preference { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms>? NodeSelectorTerms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityNodeAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1KafkaConnectSpecTemplatePodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaConnectSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaConnectSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaConnectSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaConnectSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaConnectSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>The pod&apos;s affinity rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodAffinity
{
    [JsonPropertyName("nodeAffinity")]
    public V1KafkaConnectSpecTemplatePodAffinityNodeAffinity? NodeAffinity { get; set; }

    [JsonPropertyName("podAffinity")]
    public V1KafkaConnectSpecTemplatePodAffinityPodAffinity? PodAffinity { get; set; }

    [JsonPropertyName("podAntiAffinity")]
    public V1KafkaConnectSpecTemplatePodAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodTolerations
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodTopologySpreadConstraintsLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodTopologySpreadConstraintsLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplatePodTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodTopologySpreadConstraints
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaConnectSpecTemplatePodTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodHostAliases
{
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
}

/// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecTemplatePodDnsPolicyEnum>))]
public enum V1KafkaConnectSpecTemplatePodDnsPolicyEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodDnsConfigOptions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodDnsConfig
{
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    [JsonPropertyName("options")]
    public IList<V1KafkaConnectSpecTemplatePodDnsConfigOptions>? Options { get; set; }

    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodVolumesSecretItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`Secret` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodVolumesSecret
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaConnectSpecTemplatePodVolumesSecretItems>? Items { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodVolumesConfigMapItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`ConfigMap` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodVolumesConfigMap
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaConnectSpecTemplatePodVolumesConfigMapItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecTemplatePodVolumesEmptyDirMediumEnum>))]
public enum V1KafkaConnectSpecTemplatePodVolumesEmptyDirMediumEnum
{
    [EnumMember(Value = "Memory"), JsonStringEnumMemberName("Memory")]
    Memory
}

/// <summary>`EmptyDir` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodVolumesEmptyDir
{
    /// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
    [JsonPropertyName("medium")]
    public V1KafkaConnectSpecTemplatePodVolumesEmptyDirMediumEnum? Medium { get; set; }

    /// <summary>The total amount of local storage required for this EmptyDir volume (for example 1Gi).</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodVolumesPersistentVolumeClaim
{
    [JsonPropertyName("claimName")]
    public string? ClaimName { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodVolumesCsiNodePublishSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodVolumesCsi
{
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("nodePublishSecretRef")]
    public V1KafkaConnectSpecTemplatePodVolumesCsiNodePublishSecretRef? NodePublishSecretRef { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

/// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodVolumesImage
{
    [JsonPropertyName("pullPolicy")]
    public string? PullPolicy { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodVolumes
{
    /// <summary>Name to use for the volume. Required.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>`Secret` to use to populate the volume.</summary>
    [JsonPropertyName("secret")]
    public V1KafkaConnectSpecTemplatePodVolumesSecret? Secret { get; set; }

    /// <summary>`ConfigMap` to use to populate the volume.</summary>
    [JsonPropertyName("configMap")]
    public V1KafkaConnectSpecTemplatePodVolumesConfigMap? ConfigMap { get; set; }

    /// <summary>`EmptyDir` to use to populate the volume.</summary>
    [JsonPropertyName("emptyDir")]
    public V1KafkaConnectSpecTemplatePodVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
    [JsonPropertyName("persistentVolumeClaim")]
    public V1KafkaConnectSpecTemplatePodVolumesPersistentVolumeClaim? PersistentVolumeClaim { get; set; }

    /// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("csi")]
    public V1KafkaConnectSpecTemplatePodVolumesCsi? Csi { get; set; }

    /// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("image")]
    public V1KafkaConnectSpecTemplatePodVolumesImage? Image { get; set; }
}

/// <summary>Template for Kafka Connect `Pods`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePod
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaConnectSpecTemplatePodMetadata? Metadata { get; set; }

    /// <summary>List of references to secrets in the same namespace to use for pulling any of the images used by this Pod. When the `STRIMZI_IMAGE_PULL_SECRETS` environment variable in Cluster Operator and the `imagePullSecrets` option are specified, only the `imagePullSecrets` variable is used and the `STRIMZI_IMAGE_PULL_SECRETS` variable is ignored.</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1KafkaConnectSpecTemplatePodImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>Configures pod-level security attributes and common container settings.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaConnectSpecTemplatePodSecurityContext? SecurityContext { get; set; }

    /// <summary>The grace period is the duration in seconds after the processes running in the pod are sent a termination signal, and the time when the processes are forcibly halted with a kill signal. Set this value to longer than the expected cleanup time for your process. Value must be a non-negative integer. A zero value indicates delete immediately. You might need to increase the grace period for very large Kafka clusters, so that the Kafka brokers have enough time to transfer their work to another broker before they are terminated. Defaults to 30 seconds.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    /// <summary>The pod&apos;s affinity rules.</summary>
    [JsonPropertyName("affinity")]
    public V1KafkaConnectSpecTemplatePodAffinity? Affinity { get; set; }

    /// <summary>The pod&apos;s tolerations.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1KafkaConnectSpecTemplatePodTolerations>? Tolerations { get; set; }

    /// <summary>The pod&apos;s topology spread constraints.</summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1KafkaConnectSpecTemplatePodTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    /// <summary>The name of the priority class used to assign priority to the pods. </summary>
    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    /// <summary>The name of the scheduler used to dispatch this `Pod`. If not specified, the default scheduler will be used.</summary>
    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    /// <summary>The pod&apos;s HostAliases. HostAliases is an optional list of hosts and IPs that will be injected into the Pod&apos;s hosts file if specified.</summary>
    [JsonPropertyName("hostAliases")]
    public IList<V1KafkaConnectSpecTemplatePodHostAliases>? HostAliases { get; set; }

    /// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
    [JsonPropertyName("dnsPolicy")]
    public V1KafkaConnectSpecTemplatePodDnsPolicyEnum? DnsPolicy { get; set; }

    /// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1KafkaConnectSpecTemplatePodDnsConfig? DnsConfig { get; set; }

    /// <summary>Indicates whether information about services should be injected into Pod&apos;s environment variables.</summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary>Defines the total amount of pod memory allocated for the temporary `EmptyDir` volume `/tmp`. Specify the allocation in memory units, for example, `100Mi` for 100 mebibytes. Default value is `5Mi`. The `/tmp` volume is backed by pod memory, not disk storage, so avoid setting a high value as it consumes pod memory resources.</summary>
    [JsonPropertyName("tmpDirSizeLimit")]
    public string? TmpDirSizeLimit { get; set; }

    /// <summary>Additional volumes that can be mounted to the pod.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1KafkaConnectSpecTemplatePodVolumes>? Volumes { get; set; }

    /// <summary>Use the host user namespace. Optional. Defaults to `true`. When `true` or not set, the pod runs in the host user namespace. This is required when the pod needs features available only in the host namespace, such as loading kernel modules with `CAP_SYS_MODULE`.When set to `false`, the pod runs in a new user namespace. Setting `false` helps mitigate container breakout vulnerabilities and allows containers to run as `root` without granting `root` privileges on the host. This property is alpha-level in Kubernetes and is supported only by Kubernetes clusters that enable the `UserNamespacesSupport` feature.</summary>
    [JsonPropertyName("hostUsers")]
    public bool? HostUsers { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateApiServiceMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Specifies the IP Family Policy used by the service. Available options are `SingleStack`, `PreferDualStack` and `RequireDualStack`. `SingleStack` is for a single IP family. `PreferDualStack` is for two IP families on dual-stack configured clusters or a single IP family on single-stack clusters. `RequireDualStack` fails unless there are two IP families on dual-stack configured clusters. If unspecified, Kubernetes will choose the default value based on the service type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecTemplateApiServiceIpFamilyPolicyEnum>))]
public enum V1KafkaConnectSpecTemplateApiServiceIpFamilyPolicyEnum
{
    [EnumMember(Value = "SingleStack"), JsonStringEnumMemberName("SingleStack")]
    SingleStack,
    [EnumMember(Value = "PreferDualStack"), JsonStringEnumMemberName("PreferDualStack")]
    PreferDualStack,
    [EnumMember(Value = "RequireDualStack"), JsonStringEnumMemberName("RequireDualStack")]
    RequireDualStack
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecTemplateApiServiceIpFamiliesEnum>))]
public enum V1KafkaConnectSpecTemplateApiServiceIpFamiliesEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>Template for Kafka Connect API `Service`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateApiService
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaConnectSpecTemplateApiServiceMetadata? Metadata { get; set; }

    /// <summary>Specifies the IP Family Policy used by the service. Available options are `SingleStack`, `PreferDualStack` and `RequireDualStack`. `SingleStack` is for a single IP family. `PreferDualStack` is for two IP families on dual-stack configured clusters or a single IP family on single-stack clusters. `RequireDualStack` fails unless there are two IP families on dual-stack configured clusters. If unspecified, Kubernetes will choose the default value based on the service type.</summary>
    [JsonPropertyName("ipFamilyPolicy")]
    public V1KafkaConnectSpecTemplateApiServiceIpFamilyPolicyEnum? IpFamilyPolicy { get; set; }

    /// <summary>Specifies the IP Families used by the service. Available options are `IPv4` and `IPv6`. If unspecified, Kubernetes will choose the default value based on the `ipFamilyPolicy` setting.</summary>
    [JsonPropertyName("ipFamilies")]
    public IList<V1KafkaConnectSpecTemplateApiServiceIpFamiliesEnum>? IpFamilies { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateHeadlessServiceMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Specifies the IP Family Policy used by the service. Available options are `SingleStack`, `PreferDualStack` and `RequireDualStack`. `SingleStack` is for a single IP family. `PreferDualStack` is for two IP families on dual-stack configured clusters or a single IP family on single-stack clusters. `RequireDualStack` fails unless there are two IP families on dual-stack configured clusters. If unspecified, Kubernetes will choose the default value based on the service type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecTemplateHeadlessServiceIpFamilyPolicyEnum>))]
public enum V1KafkaConnectSpecTemplateHeadlessServiceIpFamilyPolicyEnum
{
    [EnumMember(Value = "SingleStack"), JsonStringEnumMemberName("SingleStack")]
    SingleStack,
    [EnumMember(Value = "PreferDualStack"), JsonStringEnumMemberName("PreferDualStack")]
    PreferDualStack,
    [EnumMember(Value = "RequireDualStack"), JsonStringEnumMemberName("RequireDualStack")]
    RequireDualStack
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecTemplateHeadlessServiceIpFamiliesEnum>))]
public enum V1KafkaConnectSpecTemplateHeadlessServiceIpFamiliesEnum
{
    [EnumMember(Value = "IPv4"), JsonStringEnumMemberName("IPv4")]
    IPv4,
    [EnumMember(Value = "IPv6"), JsonStringEnumMemberName("IPv6")]
    IPv6
}

/// <summary>Template for Kafka Connect headless `Service`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateHeadlessService
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaConnectSpecTemplateHeadlessServiceMetadata? Metadata { get; set; }

    /// <summary>Specifies the IP Family Policy used by the service. Available options are `SingleStack`, `PreferDualStack` and `RequireDualStack`. `SingleStack` is for a single IP family. `PreferDualStack` is for two IP families on dual-stack configured clusters or a single IP family on single-stack clusters. `RequireDualStack` fails unless there are two IP families on dual-stack configured clusters. If unspecified, Kubernetes will choose the default value based on the service type.</summary>
    [JsonPropertyName("ipFamilyPolicy")]
    public V1KafkaConnectSpecTemplateHeadlessServiceIpFamilyPolicyEnum? IpFamilyPolicy { get; set; }

    /// <summary>Specifies the IP Families used by the service. Available options are `IPv4` and `IPv6`. If unspecified, Kubernetes will choose the default value based on the `ipFamilyPolicy` setting.</summary>
    [JsonPropertyName("ipFamilies")]
    public IList<V1KafkaConnectSpecTemplateHeadlessServiceIpFamiliesEnum>? IpFamilies { get; set; }
}

/// <summary>Reference to a key in a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateConnectContainerEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to a key in a config map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateConnectContainerEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateConnectContainerEnvValueFrom
{
    /// <summary>Reference to a key in a secret.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1KafkaConnectSpecTemplateConnectContainerEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary>Reference to a key in a config map.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaConnectSpecTemplateConnectContainerEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateConnectContainerEnv
{
    /// <summary>The environment variable key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaConnectSpecTemplateConnectContainerEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateConnectContainerSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateConnectContainerSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateConnectContainerSecurityContextSeLinuxOptions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateConnectContainerSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateConnectContainerSecurityContextWindowsOptions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateConnectContainerSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1KafkaConnectSpecTemplateConnectContainerSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1KafkaConnectSpecTemplateConnectContainerSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1KafkaConnectSpecTemplateConnectContainerSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaConnectSpecTemplateConnectContainerSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaConnectSpecTemplateConnectContainerSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateConnectContainerVolumeMounts
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateConnectContainer
{
    /// <summary>Environment variables which should be applied to the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1KafkaConnectSpecTemplateConnectContainerEnv>? Env { get; set; }

    /// <summary>Security context for the container.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaConnectSpecTemplateConnectContainerSecurityContext? SecurityContext { get; set; }

    /// <summary>Additional volume mounts which should be applied to the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1KafkaConnectSpecTemplateConnectContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Reference to a key in a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateInitContainerEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to a key in a config map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateInitContainerEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateInitContainerEnvValueFrom
{
    /// <summary>Reference to a key in a secret.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1KafkaConnectSpecTemplateInitContainerEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary>Reference to a key in a config map.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaConnectSpecTemplateInitContainerEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateInitContainerEnv
{
    /// <summary>The environment variable key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaConnectSpecTemplateInitContainerEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateInitContainerSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateInitContainerSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateInitContainerSecurityContextSeLinuxOptions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateInitContainerSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateInitContainerSecurityContextWindowsOptions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateInitContainerSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1KafkaConnectSpecTemplateInitContainerSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1KafkaConnectSpecTemplateInitContainerSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1KafkaConnectSpecTemplateInitContainerSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaConnectSpecTemplateInitContainerSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaConnectSpecTemplateInitContainerSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateInitContainerVolumeMounts
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateInitContainer
{
    /// <summary>Environment variables which should be applied to the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1KafkaConnectSpecTemplateInitContainerEnv>? Env { get; set; }

    /// <summary>Security context for the container.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaConnectSpecTemplateInitContainerSecurityContext? SecurityContext { get; set; }

    /// <summary>Additional volume mounts which should be applied to the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1KafkaConnectSpecTemplateInitContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodDisruptionBudgetMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Kafka Connect `PodDisruptionBudget`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplatePodDisruptionBudget
{
    /// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaConnectSpecTemplatePodDisruptionBudgetMetadata? Metadata { get; set; }

    /// <summary>Maximum number of unavailable pods to allow automatic Pod eviction. A Pod eviction is allowed when the `maxUnavailable` number of pods or fewer are unavailable after the eviction. Setting this value to 0 prevents all voluntary evictions, so the pods must be evicted manually. Defaults to 1.</summary>
    [JsonPropertyName("maxUnavailable")]
    public int? MaxUnavailable { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateServiceAccountMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Kafka Connect service account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateServiceAccount
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaConnectSpecTemplateServiceAccountMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateClusterRoleBindingMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Kafka Connect ClusterRoleBinding.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateClusterRoleBinding
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaConnectSpecTemplateClusterRoleBindingMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodImagePullSecrets
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodSecurityContextSeLinuxOptions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodSecurityContextSysctls
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodSecurityContextWindowsOptions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodSecurityContext
{
    [JsonPropertyName("appArmorProfile")]
    public V1KafkaConnectSpecTemplateBuildPodSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

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
    public V1KafkaConnectSpecTemplateBuildPodSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaConnectSpecTemplateBuildPodSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("supplementalGroups")]
    public IList<int>? SupplementalGroups { get; set; }

    [JsonPropertyName("supplementalGroupsPolicy")]
    public string? SupplementalGroupsPolicy { get; set; }

    [JsonPropertyName("sysctls")]
    public IList<V1KafkaConnectSpecTemplateBuildPodSecurityContextSysctls>? Sysctls { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaConnectSpecTemplateBuildPodSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreferenceMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("preference")]
    public V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecutionPreference? Preference { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchFields")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTermsMatchFields>? MatchFields { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("nodeSelectorTerms")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecutionNodeSelectorTerms>? NodeSelectorTerms { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinityRequiredDuringSchedulingIgnoredDuringExecution? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTermNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("podAffinityTerm")]
    public V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecutionPodAffinityTerm? PodAffinityTerm { get; set; }

    [JsonPropertyName("weight")]
    public int? Weight { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionLabelSelector? LabelSelector { get; set; }

    [JsonPropertyName("matchLabelKeys")]
    public IList<string>? MatchLabelKeys { get; set; }

    [JsonPropertyName("mismatchLabelKeys")]
    public IList<string>? MismatchLabelKeys { get; set; }

    [JsonPropertyName("namespaceSelector")]
    public V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecutionNamespaceSelector? NamespaceSelector { get; set; }

    [JsonPropertyName("namespaces")]
    public IList<string>? Namespaces { get; set; }

    [JsonPropertyName("topologyKey")]
    public string? TopologyKey { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinity
{
    [JsonPropertyName("preferredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityPreferredDuringSchedulingIgnoredDuringExecution>? PreferredDuringSchedulingIgnoredDuringExecution { get; set; }

    [JsonPropertyName("requiredDuringSchedulingIgnoredDuringExecution")]
    public IList<V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinityRequiredDuringSchedulingIgnoredDuringExecution>? RequiredDuringSchedulingIgnoredDuringExecution { get; set; }
}

/// <summary>The pod&apos;s affinity rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodAffinity
{
    [JsonPropertyName("nodeAffinity")]
    public V1KafkaConnectSpecTemplateBuildPodAffinityNodeAffinity? NodeAffinity { get; set; }

    [JsonPropertyName("podAffinity")]
    public V1KafkaConnectSpecTemplateBuildPodAffinityPodAffinity? PodAffinity { get; set; }

    [JsonPropertyName("podAntiAffinity")]
    public V1KafkaConnectSpecTemplateBuildPodAffinityPodAntiAffinity? PodAntiAffinity { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodTolerations
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodTopologySpreadConstraintsLabelSelectorMatchExpressions
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodTopologySpreadConstraintsLabelSelector
{
    [JsonPropertyName("matchExpressions")]
    public IList<V1KafkaConnectSpecTemplateBuildPodTopologySpreadConstraintsLabelSelectorMatchExpressions>? MatchExpressions { get; set; }

    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodTopologySpreadConstraints
{
    [JsonPropertyName("labelSelector")]
    public V1KafkaConnectSpecTemplateBuildPodTopologySpreadConstraintsLabelSelector? LabelSelector { get; set; }

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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodHostAliases
{
    [JsonPropertyName("hostnames")]
    public IList<string>? Hostnames { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }
}

/// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecTemplateBuildPodDnsPolicyEnum>))]
public enum V1KafkaConnectSpecTemplateBuildPodDnsPolicyEnum
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodDnsConfigOptions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodDnsConfig
{
    [JsonPropertyName("nameservers")]
    public IList<string>? Nameservers { get; set; }

    [JsonPropertyName("options")]
    public IList<V1KafkaConnectSpecTemplateBuildPodDnsConfigOptions>? Options { get; set; }

    [JsonPropertyName("searches")]
    public IList<string>? Searches { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodVolumesSecretItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`Secret` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodVolumesSecret
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaConnectSpecTemplateBuildPodVolumesSecretItems>? Items { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodVolumesConfigMapItems
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

/// <summary>`ConfigMap` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodVolumesConfigMap
{
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    [JsonPropertyName("items")]
    public IList<V1KafkaConnectSpecTemplateBuildPodVolumesConfigMapItems>? Items { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecTemplateBuildPodVolumesEmptyDirMediumEnum>))]
public enum V1KafkaConnectSpecTemplateBuildPodVolumesEmptyDirMediumEnum
{
    [EnumMember(Value = "Memory"), JsonStringEnumMemberName("Memory")]
    Memory
}

/// <summary>`EmptyDir` to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodVolumesEmptyDir
{
    /// <summary>Medium represents the type of storage medium should back this volume. Valid values are unset or `Memory`. When not set, it will use the node&apos;s default medium.</summary>
    [JsonPropertyName("medium")]
    public V1KafkaConnectSpecTemplateBuildPodVolumesEmptyDirMediumEnum? Medium { get; set; }

    /// <summary>The total amount of local storage required for this EmptyDir volume (for example 1Gi).</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodVolumesPersistentVolumeClaim
{
    [JsonPropertyName("claimName")]
    public string? ClaimName { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodVolumesCsiNodePublishSecretRef
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodVolumesCsi
{
    [JsonPropertyName("driver")]
    public string? Driver { get; set; }

    [JsonPropertyName("fsType")]
    public string? FsType { get; set; }

    [JsonPropertyName("nodePublishSecretRef")]
    public V1KafkaConnectSpecTemplateBuildPodVolumesCsiNodePublishSecretRef? NodePublishSecretRef { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    [JsonPropertyName("volumeAttributes")]
    public IDictionary<string, string>? VolumeAttributes { get; set; }
}

/// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodVolumesImage
{
    [JsonPropertyName("pullPolicy")]
    public string? PullPolicy { get; set; }

    [JsonPropertyName("reference")]
    public string? Reference { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPodVolumes
{
    /// <summary>Name to use for the volume. Required.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>`Secret` to use to populate the volume.</summary>
    [JsonPropertyName("secret")]
    public V1KafkaConnectSpecTemplateBuildPodVolumesSecret? Secret { get; set; }

    /// <summary>`ConfigMap` to use to populate the volume.</summary>
    [JsonPropertyName("configMap")]
    public V1KafkaConnectSpecTemplateBuildPodVolumesConfigMap? ConfigMap { get; set; }

    /// <summary>`EmptyDir` to use to populate the volume.</summary>
    [JsonPropertyName("emptyDir")]
    public V1KafkaConnectSpecTemplateBuildPodVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>`PersistentVolumeClaim` object to use to populate the volume.</summary>
    [JsonPropertyName("persistentVolumeClaim")]
    public V1KafkaConnectSpecTemplateBuildPodVolumesPersistentVolumeClaim? PersistentVolumeClaim { get; set; }

    /// <summary>`CSIVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("csi")]
    public V1KafkaConnectSpecTemplateBuildPodVolumesCsi? Csi { get; set; }

    /// <summary>`ImageVolumeSource` object to use to populate the volume.</summary>
    [JsonPropertyName("image")]
    public V1KafkaConnectSpecTemplateBuildPodVolumesImage? Image { get; set; }
}

/// <summary>Template for Kafka Connect Build `Pods`. The build pod is used only on Kubernetes.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildPod
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaConnectSpecTemplateBuildPodMetadata? Metadata { get; set; }

    /// <summary>List of references to secrets in the same namespace to use for pulling any of the images used by this Pod. When the `STRIMZI_IMAGE_PULL_SECRETS` environment variable in Cluster Operator and the `imagePullSecrets` option are specified, only the `imagePullSecrets` variable is used and the `STRIMZI_IMAGE_PULL_SECRETS` variable is ignored.</summary>
    [JsonPropertyName("imagePullSecrets")]
    public IList<V1KafkaConnectSpecTemplateBuildPodImagePullSecrets>? ImagePullSecrets { get; set; }

    /// <summary>Configures pod-level security attributes and common container settings.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaConnectSpecTemplateBuildPodSecurityContext? SecurityContext { get; set; }

    /// <summary>The grace period is the duration in seconds after the processes running in the pod are sent a termination signal, and the time when the processes are forcibly halted with a kill signal. Set this value to longer than the expected cleanup time for your process. Value must be a non-negative integer. A zero value indicates delete immediately. You might need to increase the grace period for very large Kafka clusters, so that the Kafka brokers have enough time to transfer their work to another broker before they are terminated. Defaults to 30 seconds.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    /// <summary>The pod&apos;s affinity rules.</summary>
    [JsonPropertyName("affinity")]
    public V1KafkaConnectSpecTemplateBuildPodAffinity? Affinity { get; set; }

    /// <summary>The pod&apos;s tolerations.</summary>
    [JsonPropertyName("tolerations")]
    public IList<V1KafkaConnectSpecTemplateBuildPodTolerations>? Tolerations { get; set; }

    /// <summary>The pod&apos;s topology spread constraints.</summary>
    [JsonPropertyName("topologySpreadConstraints")]
    public IList<V1KafkaConnectSpecTemplateBuildPodTopologySpreadConstraints>? TopologySpreadConstraints { get; set; }

    /// <summary>The name of the priority class used to assign priority to the pods. </summary>
    [JsonPropertyName("priorityClassName")]
    public string? PriorityClassName { get; set; }

    /// <summary>The name of the scheduler used to dispatch this `Pod`. If not specified, the default scheduler will be used.</summary>
    [JsonPropertyName("schedulerName")]
    public string? SchedulerName { get; set; }

    /// <summary>The pod&apos;s HostAliases. HostAliases is an optional list of hosts and IPs that will be injected into the Pod&apos;s hosts file if specified.</summary>
    [JsonPropertyName("hostAliases")]
    public IList<V1KafkaConnectSpecTemplateBuildPodHostAliases>? HostAliases { get; set; }

    /// <summary>The pod&apos;s DNSPolicy. Defaults to `ClusterFirst`. Valid values are `ClusterFirstWithHostNet`, `ClusterFirst`, `Default` or `None`.</summary>
    [JsonPropertyName("dnsPolicy")]
    public V1KafkaConnectSpecTemplateBuildPodDnsPolicyEnum? DnsPolicy { get; set; }

    /// <summary>The pod&apos;s DNSConfig. If specified, it will be merged to the generated DNS configuration based on the DNSPolicy.</summary>
    [JsonPropertyName("dnsConfig")]
    public V1KafkaConnectSpecTemplateBuildPodDnsConfig? DnsConfig { get; set; }

    /// <summary>Indicates whether information about services should be injected into Pod&apos;s environment variables.</summary>
    [JsonPropertyName("enableServiceLinks")]
    public bool? EnableServiceLinks { get; set; }

    /// <summary>Defines the total amount of pod memory allocated for the temporary `EmptyDir` volume `/tmp`. Specify the allocation in memory units, for example, `100Mi` for 100 mebibytes. Default value is `5Mi`. The `/tmp` volume is backed by pod memory, not disk storage, so avoid setting a high value as it consumes pod memory resources.</summary>
    [JsonPropertyName("tmpDirSizeLimit")]
    public string? TmpDirSizeLimit { get; set; }

    /// <summary>Additional volumes that can be mounted to the pod.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1KafkaConnectSpecTemplateBuildPodVolumes>? Volumes { get; set; }

    /// <summary>Use the host user namespace. Optional. Defaults to `true`. When `true` or not set, the pod runs in the host user namespace. This is required when the pod needs features available only in the host namespace, such as loading kernel modules with `CAP_SYS_MODULE`.When set to `false`, the pod runs in a new user namespace. Setting `false` helps mitigate container breakout vulnerabilities and allows containers to run as `root` without granting `root` privileges on the host. This property is alpha-level in Kubernetes and is supported only by Kubernetes clusters that enable the `UserNamespacesSupport` feature.</summary>
    [JsonPropertyName("hostUsers")]
    public bool? HostUsers { get; set; }
}

/// <summary>Reference to a key in a secret.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildContainerEnvValueFromSecretKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to a key in a config map.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildContainerEnvValueFromConfigMapKeyRef
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }
}

/// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildContainerEnvValueFrom
{
    /// <summary>Reference to a key in a secret.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1KafkaConnectSpecTemplateBuildContainerEnvValueFromSecretKeyRef? SecretKeyRef { get; set; }

    /// <summary>Reference to a key in a config map.</summary>
    [JsonPropertyName("configMapKeyRef")]
    public V1KafkaConnectSpecTemplateBuildContainerEnvValueFromConfigMapKeyRef? ConfigMapKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildContainerEnv
{
    /// <summary>The environment variable key.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Reference to the secret or config map property to which the environment variable is set.</summary>
    [JsonPropertyName("valueFrom")]
    public V1KafkaConnectSpecTemplateBuildContainerEnvValueFrom? ValueFrom { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildContainerSecurityContextAppArmorProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildContainerSecurityContextCapabilities
{
    [JsonPropertyName("add")]
    public IList<string>? Add { get; set; }

    [JsonPropertyName("drop")]
    public IList<string>? Drop { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildContainerSecurityContextSeLinuxOptions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildContainerSecurityContextSeccompProfile
{
    [JsonPropertyName("localhostProfile")]
    public string? LocalhostProfile { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildContainerSecurityContextWindowsOptions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildContainerSecurityContext
{
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    [JsonPropertyName("appArmorProfile")]
    public V1KafkaConnectSpecTemplateBuildContainerSecurityContextAppArmorProfile? AppArmorProfile { get; set; }

    [JsonPropertyName("capabilities")]
    public V1KafkaConnectSpecTemplateBuildContainerSecurityContextCapabilities? Capabilities { get; set; }

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
    public V1KafkaConnectSpecTemplateBuildContainerSecurityContextSeLinuxOptions? SeLinuxOptions { get; set; }

    [JsonPropertyName("seccompProfile")]
    public V1KafkaConnectSpecTemplateBuildContainerSecurityContextSeccompProfile? SeccompProfile { get; set; }

    [JsonPropertyName("windowsOptions")]
    public V1KafkaConnectSpecTemplateBuildContainerSecurityContextWindowsOptions? WindowsOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildContainerVolumeMounts
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildContainer
{
    /// <summary>Environment variables which should be applied to the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1KafkaConnectSpecTemplateBuildContainerEnv>? Env { get; set; }

    /// <summary>Security context for the container.</summary>
    [JsonPropertyName("securityContext")]
    public V1KafkaConnectSpecTemplateBuildContainerSecurityContext? SecurityContext { get; set; }

    /// <summary>Additional volume mounts which should be applied to the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1KafkaConnectSpecTemplateBuildContainerVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildConfigMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Kafka Connect BuildConfig used to build new container images. The BuildConfig is used only on OpenShift.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildConfig
{
    /// <summary>Metadata to apply to the `PodDisruptionBudgetTemplate` resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaConnectSpecTemplateBuildConfigMetadata? Metadata { get; set; }

    /// <summary>Container Registry Secret with the credentials for pulling the base image.</summary>
    [JsonPropertyName("pullSecret")]
    public string? PullSecret { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildServiceAccountMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for the Kafka Connect Build service account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateBuildServiceAccount
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaConnectSpecTemplateBuildServiceAccountMetadata? Metadata { get; set; }
}

/// <summary>Metadata applied to the resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateJmxSecretMetadata
{
    /// <summary>Labels added to the Kubernetes resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>Annotations added to the Kubernetes resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }
}

/// <summary>Template for Secret of the Kafka Connect Cluster JMX authentication.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplateJmxSecret
{
    /// <summary>Metadata applied to the resource.</summary>
    [JsonPropertyName("metadata")]
    public V1KafkaConnectSpecTemplateJmxSecretMetadata? Metadata { get; set; }
}

/// <summary>Template for Kafka Connect and Kafka MirrorMaker 2 resources. The template allows users to specify how the `Pods`, `Service`, and other services are generated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecTemplate
{
    /// <summary>Template for Kafka Connect `StrimziPodSet` resource.</summary>
    [JsonPropertyName("podSet")]
    public V1KafkaConnectSpecTemplatePodSet? PodSet { get; set; }

    /// <summary>Template for Kafka Connect `Pods`.</summary>
    [JsonPropertyName("pod")]
    public V1KafkaConnectSpecTemplatePod? Pod { get; set; }

    /// <summary>Template for Kafka Connect API `Service`.</summary>
    [JsonPropertyName("apiService")]
    public V1KafkaConnectSpecTemplateApiService? ApiService { get; set; }

    /// <summary>Template for Kafka Connect headless `Service`.</summary>
    [JsonPropertyName("headlessService")]
    public V1KafkaConnectSpecTemplateHeadlessService? HeadlessService { get; set; }

    /// <summary>Template for the Kafka Connect container.</summary>
    [JsonPropertyName("connectContainer")]
    public V1KafkaConnectSpecTemplateConnectContainer? ConnectContainer { get; set; }

    /// <summary>Template for the Kafka init container.</summary>
    [JsonPropertyName("initContainer")]
    public V1KafkaConnectSpecTemplateInitContainer? InitContainer { get; set; }

    /// <summary>Template for Kafka Connect `PodDisruptionBudget`.</summary>
    [JsonPropertyName("podDisruptionBudget")]
    public V1KafkaConnectSpecTemplatePodDisruptionBudget? PodDisruptionBudget { get; set; }

    /// <summary>Template for the Kafka Connect service account.</summary>
    [JsonPropertyName("serviceAccount")]
    public V1KafkaConnectSpecTemplateServiceAccount? ServiceAccount { get; set; }

    /// <summary>Template for the Kafka Connect ClusterRoleBinding.</summary>
    [JsonPropertyName("clusterRoleBinding")]
    public V1KafkaConnectSpecTemplateClusterRoleBinding? ClusterRoleBinding { get; set; }

    /// <summary>Template for Kafka Connect Build `Pods`. The build pod is used only on Kubernetes.</summary>
    [JsonPropertyName("buildPod")]
    public V1KafkaConnectSpecTemplateBuildPod? BuildPod { get; set; }

    /// <summary>Template for the Kafka Connect Build container. The build container is used only on Kubernetes.</summary>
    [JsonPropertyName("buildContainer")]
    public V1KafkaConnectSpecTemplateBuildContainer? BuildContainer { get; set; }

    /// <summary>Template for the Kafka Connect BuildConfig used to build new container images. The BuildConfig is used only on OpenShift.</summary>
    [JsonPropertyName("buildConfig")]
    public V1KafkaConnectSpecTemplateBuildConfig? BuildConfig { get; set; }

    /// <summary>Template for the Kafka Connect Build service account.</summary>
    [JsonPropertyName("buildServiceAccount")]
    public V1KafkaConnectSpecTemplateBuildServiceAccount? BuildServiceAccount { get; set; }

    /// <summary>Template for Secret of the Kafka Connect Cluster JMX authentication.</summary>
    [JsonPropertyName("jmxSecret")]
    public V1KafkaConnectSpecTemplateJmxSecret? JmxSecret { get; set; }
}

/// <summary>Output type. Must be either `docker` for pushing the newly build image to Docker compatible registry or `imagestream` for pushing the image to OpenShift ImageStream. Required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecBuildOutputTypeEnum>))]
public enum V1KafkaConnectSpecBuildOutputTypeEnum
{
    [EnumMember(Value = "docker"), JsonStringEnumMemberName("docker")]
    Docker,
    [EnumMember(Value = "imagestream"), JsonStringEnumMemberName("imagestream")]
    Imagestream
}

/// <summary>Configures where should the newly built image be stored. Required.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecBuildOutput
{
    /// <summary>Configures additional options to pass to the `build` command of either Kaniko or Buildah (depending on the feature gate setting) when building a new Kafka Connect image. Allowed Kaniko options: --customPlatform, --custom-platform, --insecure, --insecure-pull, --insecure-registry, --log-format, --log-timestamp, --registry-mirror, --reproducible, --single-snapshot, --skip-tls-verify, --skip-tls-verify-pull, --skip-tls-verify-registry, --verbosity, --snapshotMode, --use-new-run, --registry-certificate, --registry-client-cert, --ignore-path. Allowed Buildah `build` options: --authfile, --cert-dir, --creds, --decryption-key, --retry, --retry-delay, --tls-verify. Those options are used only on Kubernetes, where Kaniko and Buildah are available. They are ignored on OpenShift. For more information, see the link:https://github.com/GoogleContainerTools/kaniko[Kaniko GitHub repository^] or the link:https://github.com/containers/buildah/blob/main/docs/buildah-build.1.md[Buildah build document^]. Changing this field does not trigger a rebuild of the Kafka Connect image.</summary>
    [JsonPropertyName("additionalBuildOptions")]
    public IList<string>? AdditionalBuildOptions { get; set; }

    /// <summary>Configures additional options to pass to the Buildah `push` command when pushing a new Connect image. Allowed options: --authfile, --cert-dir, --creds, --quiet, --retry, --retry-delay, --tls-verify. Those options are used only on Kubernetes, where Buildah is available. They are ignored on OpenShift. For more information, see the link:https://github.com/containers/buildah/blob/main/docs/buildah-push.1.md[Buildah push document^]. Changing this field does not trigger a rebuild of the Kafka Connect image.</summary>
    [JsonPropertyName("additionalPushOptions")]
    public IList<string>? AdditionalPushOptions { get; set; }

    /// <summary>The name of the image which will be built. Required.</summary>
    [JsonPropertyName("image")]
    public required string Image { get; set; }

    /// <summary>Container Registry Secret with the credentials for pushing the newly built image.</summary>
    [JsonPropertyName("pushSecret")]
    public string? PushSecret { get; set; }

    /// <summary>Output type. Must be either `docker` for pushing the newly build image to Docker compatible registry or `imagestream` for pushing the image to OpenShift ImageStream. Required.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaConnectSpecBuildOutputTypeEnum Type { get; set; }
}

/// <summary>Maven scope for including dependencies for the artifact. Valid values are `compile`, `provided`, `runtime`, `test`, and `system`. When not configured, no scope is set, and all dependencies are included. Applicable to the `maven` artifact type only.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecBuildPluginsArtifactsIncludeScopeEnum>))]
public enum V1KafkaConnectSpecBuildPluginsArtifactsIncludeScopeEnum
{
    [EnumMember(Value = "compile"), JsonStringEnumMemberName("compile")]
    Compile,
    [EnumMember(Value = "provided"), JsonStringEnumMemberName("provided")]
    Provided,
    [EnumMember(Value = "runtime"), JsonStringEnumMemberName("runtime")]
    Runtime,
    [EnumMember(Value = "test"), JsonStringEnumMemberName("test")]
    Test,
    [EnumMember(Value = "system"), JsonStringEnumMemberName("system")]
    System
}

/// <summary>Artifact type. Currently, the supported artifact types are `tgz`, `jar`, `zip`, `other` and `maven`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecBuildPluginsArtifactsTypeEnum>))]
public enum V1KafkaConnectSpecBuildPluginsArtifactsTypeEnum
{
    [EnumMember(Value = "jar"), JsonStringEnumMemberName("jar")]
    Jar,
    [EnumMember(Value = "tgz"), JsonStringEnumMemberName("tgz")]
    Tgz,
    [EnumMember(Value = "zip"), JsonStringEnumMemberName("zip")]
    Zip,
    [EnumMember(Value = "maven"), JsonStringEnumMemberName("maven")]
    Maven,
    [EnumMember(Value = "other"), JsonStringEnumMemberName("other")]
    Other
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecBuildPluginsArtifacts
{
    /// <summary>Maven artifact id. Applicable to the `maven` artifact type only.</summary>
    [JsonPropertyName("artifact")]
    public string? Artifact { get; set; }

    /// <summary>Name under which the artifact will be stored.</summary>
    [JsonPropertyName("fileName")]
    public string? FileName { get; set; }

    /// <summary>Maven group id. Applicable to the `maven` artifact type only.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Maven scope for including dependencies for the artifact. Valid values are `compile`, `provided`, `runtime`, `test`, and `system`. When not configured, no scope is set, and all dependencies are included. Applicable to the `maven` artifact type only.</summary>
    [JsonPropertyName("includeScope")]
    public V1KafkaConnectSpecBuildPluginsArtifactsIncludeScopeEnum? IncludeScope { get; set; }

    /// <summary>By default, connections using TLS are verified to check they are secure. The server certificate used must be valid, trusted, and contain the server name. By setting this option to `true`, all TLS verification is disabled and the artifact will be downloaded, even when the server is considered insecure.</summary>
    [JsonPropertyName("insecure")]
    public bool? Insecure { get; set; }

    /// <summary>Maven repository to download the artifact from. Applicable to the `maven` artifact type only.</summary>
    [JsonPropertyName("repository")]
    public string? Repository { get; set; }

    /// <summary>SHA512 checksum of the artifact. Optional. If specified, the checksum will be verified while building the new container. If not specified, the downloaded artifact will not be verified. Not applicable to the `maven` artifact type. </summary>
    [JsonPropertyName("sha512sum")]
    public string? Sha512sum { get; set; }

    /// <summary>Artifact type. Currently, the supported artifact types are `tgz`, `jar`, `zip`, `other` and `maven`.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaConnectSpecBuildPluginsArtifactsTypeEnum Type { get; set; }

    /// <summary>URL of the artifact which will be downloaded. Strimzi does not do any security scanning of the downloaded artifacts. For security reasons, you should first verify the artifacts manually and configure the checksum verification to make sure the same artifact is used in the automated build. Required for `jar`, `zip`, `tgz` and `other` artifacts. Not applicable to the `maven` artifact type.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Maven version number. Applicable to the `maven` artifact type only.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecBuildPlugins
{
    /// <summary>The unique name of the connector plugin. Will be used to generate the path where the connector artifacts will be stored. The name has to be unique within the KafkaConnect resource. The name has to follow the following pattern: `^[a-z][-_a-z0-9]*[a-z]$`. Required.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>List of artifacts which belong to this connector plugin. Required.</summary>
    [JsonPropertyName("artifacts")]
    public required IList<V1KafkaConnectSpecBuildPluginsArtifacts> Artifacts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecBuildResourcesClaims
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("request")]
    public string? Request { get; set; }
}

/// <summary>CPU and memory resources to reserve for the build.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecBuildResources
{
    [JsonPropertyName("claims")]
    public IList<V1KafkaConnectSpecBuildResourcesClaims>? Claims { get; set; }

    [JsonPropertyName("limits")]
    public IDictionary<string, IntOrString>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, IntOrString>? Requests { get; set; }
}

/// <summary>Configures how the Connect container image should be built. Optional.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecBuild
{
    /// <summary>Configures where should the newly built image be stored. Required.</summary>
    [JsonPropertyName("output")]
    public required V1KafkaConnectSpecBuildOutput Output { get; set; }

    /// <summary>List of connector plugins which should be added to the Kafka Connect. Required.</summary>
    [JsonPropertyName("plugins")]
    public required IList<V1KafkaConnectSpecBuildPlugins> Plugins { get; set; }

    /// <summary>CPU and memory resources to reserve for the build.</summary>
    [JsonPropertyName("resources")]
    public V1KafkaConnectSpecBuildResources? Resources { get; set; }
}

/// <summary>Artifact type. Currently, the only supported artifact type is `image`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1KafkaConnectSpecPluginsArtifactsTypeEnum>))]
public enum V1KafkaConnectSpecPluginsArtifactsTypeEnum
{
    [EnumMember(Value = "image"), JsonStringEnumMemberName("image")]
    Image
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecPluginsArtifacts
{
    /// <summary>
    /// Policy that determines when the container image (OCI artifact) is pulled.
    /// 
    /// Possible values are:
    /// 
    /// * `Always`: Always pull the image. If the pull fails, container creation fails.
    /// * `Never`: Never pull the image. Use only a locally available image. Container creation fails if the image isn’t present.
    /// * `IfNotPresent`: Pull the image only if it’s not already available locally. Container creation fails if the image isn’t present and the pull fails.
    /// 
    /// Defaults to `Always` if `:latest` tag is specified, or `IfNotPresent` otherwise.
    /// </summary>
    [JsonPropertyName("pullPolicy")]
    public string? PullPolicy { get; set; }

    /// <summary>Reference to the container image (OCI artifact) containing the Kafka Connect plugin. The image is mounted as a volume and provides the plugin binary. Required.</summary>
    [JsonPropertyName("reference")]
    public required string Reference { get; set; }

    /// <summary>Artifact type. Currently, the only supported artifact type is `image`.</summary>
    [JsonPropertyName("type")]
    public required V1KafkaConnectSpecPluginsArtifactsTypeEnum Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpecPlugins
{
    /// <summary>A unique name for the connector plugin. This name is used to generate the mount path for the connector artifacts. The name has to be unique within the KafkaConnect resource. The name must be unique within the `KafkaConnect` resource and match the pattern: `^[a-z][-_a-z0-9]*[a-z]$`. Required.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>List of artifacts associated with this connector plugin. Required.</summary>
    [JsonPropertyName("artifacts")]
    public required IList<V1KafkaConnectSpecPluginsArtifacts> Artifacts { get; set; }
}

/// <summary>The specification of the Kafka Connect cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectSpec
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

    /// <summary>Bootstrap servers to connect to. This should be given as a comma separated list of _&lt;hostname&gt;_:_&lt;port&gt;_ pairs.</summary>
    [JsonPropertyName("bootstrapServers")]
    public required string BootstrapServers { get; set; }

    /// <summary>A unique ID that identifies the Connect cluster group.</summary>
    [JsonPropertyName("groupId")]
    public required string GroupId { get; set; }

    /// <summary>The name of the Kafka topic where connector configurations are stored.</summary>
    [JsonPropertyName("configStorageTopic")]
    public required string ConfigStorageTopic { get; set; }

    /// <summary>The name of the Kafka topic where connector and task status are stored.</summary>
    [JsonPropertyName("statusStorageTopic")]
    public required string StatusStorageTopic { get; set; }

    /// <summary>The name of the Kafka topic where source connector offsets are stored.</summary>
    [JsonPropertyName("offsetStorageTopic")]
    public required string OffsetStorageTopic { get; set; }

    /// <summary>TLS configuration.</summary>
    [JsonPropertyName("tls")]
    public V1KafkaConnectSpecTls? Tls { get; set; }

    /// <summary>Authentication configuration for Kafka Connect.</summary>
    [JsonPropertyName("authentication")]
    public V1KafkaConnectSpecAuthentication? Authentication { get; set; }

    /// <summary>The Kafka Connect configuration. Properties with the following prefixes cannot be set: group.id, config.storage.topic, offset.storage.topic, status.storage.topic, ssl., sasl., security., listeners, plugin.path, rest., bootstrap.servers, consumer.interceptor.classes, producer.interceptor.classes, prometheus.metrics.reporter. (with the exception of: ssl.endpoint.identification.algorithm, ssl.cipher.suites, ssl.protocol, ssl.enabled.protocols).</summary>
    [JsonPropertyName("config")]
    public JsonNode? Config { get; set; }

    /// <summary>The maximum limits for CPU and memory resources and the requested initial resources.</summary>
    [JsonPropertyName("resources")]
    public V1KafkaConnectSpecResources? Resources { get; set; }

    /// <summary>Pod liveness checking.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1KafkaConnectSpecLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Pod readiness checking.</summary>
    [JsonPropertyName("readinessProbe")]
    public V1KafkaConnectSpecReadinessProbe? ReadinessProbe { get; set; }

    /// <summary>JVM Options for pods.</summary>
    [JsonPropertyName("jvmOptions")]
    public V1KafkaConnectSpecJvmOptions? JvmOptions { get; set; }

    /// <summary>JMX Options.</summary>
    [JsonPropertyName("jmxOptions")]
    public V1KafkaConnectSpecJmxOptions? JmxOptions { get; set; }

    /// <summary>Logging configuration for Kafka Connect.</summary>
    [JsonPropertyName("logging")]
    public V1KafkaConnectSpecLogging? Logging { get; set; }

    /// <summary>The image of the init container used for initializing the `client.rack`.</summary>
    [JsonPropertyName("clientRackInitImage")]
    public string? ClientRackInitImage { get; set; }

    /// <summary>Configuration of the node label which will be used as the `client.rack` consumer configuration.</summary>
    [JsonPropertyName("rack")]
    public V1KafkaConnectSpecRack? Rack { get; set; }

    /// <summary>Metrics configuration.</summary>
    [JsonPropertyName("metricsConfig")]
    public V1KafkaConnectSpecMetricsConfig? MetricsConfig { get; set; }

    /// <summary>The configuration of tracing in Kafka Connect.</summary>
    [JsonPropertyName("tracing")]
    public V1KafkaConnectSpecTracing? Tracing { get; set; }

    /// <summary>Template for Kafka Connect and Kafka MirrorMaker 2 resources. The template allows users to specify how the `Pods`, `Service`, and other services are generated.</summary>
    [JsonPropertyName("template")]
    public V1KafkaConnectSpecTemplate? Template { get; set; }

    /// <summary>Configures how the Connect container image should be built. Optional.</summary>
    [JsonPropertyName("build")]
    public V1KafkaConnectSpecBuild? Build { get; set; }

    /// <summary>List of connector plugins to mount into the `KafkaConnect` pod.</summary>
    [JsonPropertyName("plugins")]
    public IList<V1KafkaConnectSpecPlugins>? Plugins { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectStatusConnectorPlugins
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

/// <summary>The status of the Kafka Connect cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1KafkaConnectStatus
{
    /// <summary>List of status conditions.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1KafkaConnectStatusConditions>? Conditions { get; set; }

    /// <summary>The generation of the CRD that was last reconciled by the operator.</summary>
    [JsonPropertyName("observedGeneration")]
    public int? ObservedGeneration { get; set; }

    /// <summary>The URL of the REST API endpoint for managing and monitoring Kafka Connect connectors.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The list of connector plugins available in this Kafka Connect deployment.</summary>
    [JsonPropertyName("connectorPlugins")]
    public IList<V1KafkaConnectStatusConnectorPlugins>? ConnectorPlugins { get; set; }

    /// <summary>The current number of pods being used to provide this resource.</summary>
    [JsonPropertyName("replicas")]
    public int? Replicas { get; set; }

    /// <summary>Label selector for pods providing this resource.</summary>
    [JsonPropertyName("labelSelector")]
    public string? LabelSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1KafkaConnect : IKubernetesObject<V1ObjectMeta>, ISpec<V1KafkaConnectSpec>, IStatus<V1KafkaConnectStatus?>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "KafkaConnect";
    public const string KubeGroup = "kafka.strimzi.io";
    public const string KubePluralName = "kafkaconnects";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "kafka.strimzi.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "KafkaConnect";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>The specification of the Kafka Connect cluster.</summary>
    [JsonPropertyName("spec")]
    public required V1KafkaConnectSpec Spec { get; set; }

    /// <summary>The status of the Kafka Connect cluster.</summary>
    [JsonPropertyName("status")]
    public V1KafkaConnectStatus? Status { get; set; }
}