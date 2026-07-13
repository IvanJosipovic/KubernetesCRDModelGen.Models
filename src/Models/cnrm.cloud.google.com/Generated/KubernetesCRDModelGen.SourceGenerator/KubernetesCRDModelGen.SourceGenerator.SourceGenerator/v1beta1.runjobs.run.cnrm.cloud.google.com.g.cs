#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.run.cnrm.cloud.google.com;
/// <summary>RunJob is the Schema for the RunJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RunJobList : IKubernetesObject<V1ListMeta>, IItems<V1beta1RunJob>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RunJobList";
    public const string KubeGroup = "run.cnrm.cloud.google.com";
    public const string KubePluralName = "runjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "run.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RunJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1RunJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1RunJob> Items { get; set; }
}

/// <summary>Optional. Settings for Binary Authorization feature.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecBinaryAuthorization
{
    /// <summary>Optional. If present, indicates to use Breakglass using this justification. If use_default is False, then it must be empty. For more information on breakglass, see https://cloud.google.com/binary-authorization/docs/using-breakglass</summary>
    [JsonPropertyName("breakglassJustification")]
    public string? BreakglassJustification { get; set; }

    /// <summary>Optional. If True, indicates to use the default project&apos;s binary authorization policy. If False, binary authorization will be disabled.</summary>
    [JsonPropertyName("useDefault")]
    public bool? UseDefault { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. The name of the secret in Cloud Secret  Manager. Format: {secret} if the secret is in the same project. projects/{project}/secrets/{secret}</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRef
{
    /// <summary>A reference to an externally managed SecretManagerSecret resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secrets/{{secretID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The Cloud Secret Manager secret version. Can be &apos;latest&apos; for the latest version, an integer for a specific version, or a version alias.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersEnvValueSourceSecretKeyRefVersionRef
{
    /// <summary>A reference to an externally managed SecretManagerSecretVersion resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secretversions/{{secretversionID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecretVersion resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecretVersion resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Selects a secret and a specific version from Cloud Secret Manager.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersEnvValueSourceSecretKeyRef
{
    /// <summary>Required. The name of the secret in Cloud Secret  Manager. Format: {secret} if the secret is in the same project. projects/{project}/secrets/{secret}</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1RunJobSpecTemplateTemplateContainersEnvValueSourceSecretKeyRefSecretRef? SecretRef { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be &apos;latest&apos; for the latest version, an integer for a specific version, or a version alias.</summary>
    [JsonPropertyName("versionRef")]
    public V1beta1RunJobSpecTemplateTemplateContainersEnvValueSourceSecretKeyRefVersionRef? VersionRef { get; set; }
}

/// <summary>Source for the environment variable&apos;s value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersEnvValueSource
{
    /// <summary>Selects a secret and a specific version from Cloud Secret Manager.</summary>
    [JsonPropertyName("secretKeyRef")]
    public V1beta1RunJobSpecTemplateTemplateContainersEnvValueSourceSecretKeyRef? SecretKeyRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersEnv
{
    /// <summary>Required. Name of the environment variable. Must not exceed 32768 characters.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Literal value of the environment variable. Defaults to &quot; &quot;, and the maximum length is 32768 bytes. Variable references are not supported in Cloud Run.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>Source for the environment variable&apos;s value.</summary>
    [JsonPropertyName("valueSource")]
    public V1beta1RunJobSpecTemplateTemplateContainersEnvValueSource? ValueSource { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersLivenessProbeHttpGetHttpHeaders
{
    /// <summary>Required. The header field name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. The header field value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Optional. HTTPGet specifies the http request to perform. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersLivenessProbeHttpGet
{
    /// <summary>Optional. Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1RunJobSpecTemplateTemplateContainersLivenessProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Optional. Path to access on the HTTP server. Defaults to &apos;/&apos;.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Optional. Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>Optional. TCPSocket specifies an action involving a TCP port. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersLivenessProbeTcpSocket
{
    /// <summary>Optional. Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersLivenessProbe
{
    /// <summary>Optional. Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>Optional. HTTPGet specifies the http request to perform. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
    [JsonPropertyName("httpGet")]
    public V1beta1RunJobSpecTemplateTemplateContainersLivenessProbeHttpGet? HttpGet { get; set; }

    /// <summary>Optional. Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>Optional. How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeout_seconds.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Optional. TCPSocket specifies an action involving a TCP port. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1beta1RunJobSpecTemplateTemplateContainersLivenessProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Optional. Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than period_seconds.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersPorts
{
    /// <summary>Port number the container listens on. This must be a valid TCP port number, 0 &lt; container_port &lt; 65536.</summary>
    [JsonPropertyName("containerPort")]
    public int? ContainerPort { get; set; }

    /// <summary>If specified, used to specify which protocol to use. Allowed values are &quot;http1&quot; and &quot;h2c&quot;.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Compute Resource requirements by this container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersResources
{
    /// <summary>
    /// Only `memory` and `cpu` keys in the map are supported.
    /// 
    ///  &lt;p&gt;Notes:
    ///   * The only supported values for CPU are &apos;1&apos;, &apos;2&apos;, &apos;4&apos;, and &apos;8&apos;. Setting 4
    ///  CPU requires at least 2Gi of memory. For more information, go to
    ///  https://cloud.google.com/run/docs/configuring/cpu.
    ///    * For supported &apos;memory&apos; values and syntax, go to
    ///   https://cloud.google.com/run/docs/configuring/memory-limits
    /// </summary>
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersStartupProbeHttpGetHttpHeaders
{
    /// <summary>Required. The header field name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Optional. The header field value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Optional. HTTPGet specifies the http request to perform. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersStartupProbeHttpGet
{
    /// <summary>Optional. Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V1beta1RunJobSpecTemplateTemplateContainersStartupProbeHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Optional. Path to access on the HTTP server. Defaults to &apos;/&apos;.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Optional. Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>Optional. TCPSocket specifies an action involving a TCP port. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersStartupProbeTcpSocket
{
    /// <summary>Optional. Port number to access on the container. Must be in the range 1 to 65535. If not specified, defaults to the exposed port of the container, which is the value of container.ports[0].containerPort.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>Startup probe of application within the container. All other probes are disabled if a startup probe is provided, until it succeeds. Container will not be added to service endpoints if the probe fails.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersStartupProbe
{
    /// <summary>Optional. Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to 3. Minimum value is 1.</summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>Optional. HTTPGet specifies the http request to perform. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
    [JsonPropertyName("httpGet")]
    public V1beta1RunJobSpecTemplateTemplateContainersStartupProbeHttpGet? HttpGet { get; set; }

    /// <summary>Optional. Number of seconds after the container has started before the probe is initiated. Defaults to 0 seconds. Minimum value is 0. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240.</summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>Optional. How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value for liveness probe is 3600. Maximum value for startup probe is 240. Must be greater or equal than timeout_seconds.</summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>Optional. TCPSocket specifies an action involving a TCP port. Exactly one of httpGet, tcpSocket, or grpc must be specified.</summary>
    [JsonPropertyName("tcpSocket")]
    public V1beta1RunJobSpecTemplateTemplateContainersStartupProbeTcpSocket? TcpSocket { get; set; }

    /// <summary>Optional. Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum value is 3600. Must be smaller than period_seconds.</summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainersVolumeMounts
{
    /// <summary>Required. Path within the container at which the volume should be mounted. Must not contain &apos;:&apos;. For Cloud SQL volumes, it can be left empty, or must otherwise be `/cloudsql`. All instances defined in the Volume will be available as `/cloudsql/[instance]`. For more information on Cloud SQL volumes, visit https://cloud.google.com/sql/docs/mysql/connect-run</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Required. This must match the Name of a Volume.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateContainers
{
    /// <summary>Arguments to the entrypoint. The docker image&apos;s CMD is used if this is not provided.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint array. Not executed within a shell. The docker image&apos;s ENTRYPOINT is used if this is not provided.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Names of the containers that must start before this container.</summary>
    [JsonPropertyName("dependsOn")]
    public IList<string>? DependsOn { get; set; }

    /// <summary>List of environment variables to set in the container.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1RunJobSpecTemplateTemplateContainersEnv>? Env { get; set; }

    /// <summary>Required. Name of the container image in Dockerhub, Google Artifact Registry, or Google Container Registry. If the host is not provided, Dockerhub is assumed.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Periodic probe of container liveness. Container will be restarted if the probe fails.</summary>
    [JsonPropertyName("livenessProbe")]
    public V1beta1RunJobSpecTemplateTemplateContainersLivenessProbe? LivenessProbe { get; set; }

    /// <summary>Name of the container specified as a DNS_LABEL (RFC 1123).</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// List of ports to expose from the container. Only a single port can be
    ///  specified. The specified ports must be listening on all interfaces
    ///  (0.0.0.0) within the container to be accessible.
    /// 
    ///  If omitted, a port number will be chosen and passed to the container
    ///  through the PORT environment variable for the container to listen on.
    /// </summary>
    [JsonPropertyName("ports")]
    public IList<V1beta1RunJobSpecTemplateTemplateContainersPorts>? Ports { get; set; }

    /// <summary>Compute Resource requirements by this container.</summary>
    [JsonPropertyName("resources")]
    public V1beta1RunJobSpecTemplateTemplateContainersResources? Resources { get; set; }

    /// <summary>Startup probe of application within the container. All other probes are disabled if a startup probe is provided, until it succeeds. Container will not be added to service endpoints if the probe fails.</summary>
    [JsonPropertyName("startupProbe")]
    public V1beta1RunJobSpecTemplateTemplateContainersStartupProbe? StartupProbe { get; set; }

    /// <summary>Volume to mount into the container&apos;s filesystem.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1RunJobSpecTemplateTemplateContainersVolumeMounts>? VolumeMounts { get; set; }

    /// <summary>Container&apos;s working directory. If not specified, the container runtime&apos;s default will be used, which might be configured in the container image.</summary>
    [JsonPropertyName("workingDir")]
    public string? WorkingDir { get; set; }
}

/// <summary>A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more information, go to https://cloud.google.com/run/docs/securing/using-cmek</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateEncryptionKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. Email address of the IAM service account associated with the Task of a Job. The service account represents the identity of the running task, and determines what permissions the task has. If not provided, the task will use the project&apos;s default service account.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateServiceAccountRef
{
    /// <summary>The `email` field of an `IAMServiceAccount` resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>Name of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Namespace of the referent. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces/</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumesCloudSqlInstanceInstanceRefs
{
    /// <summary>The SQLInstance selfLink, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `SQLInstance` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>For Cloud SQL volumes, contains the specific instances that should be mounted. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumesCloudSqlInstance
{
    /// <summary>The Cloud SQL instance connection names, as can be found in https://console.cloud.google.com/sql/instances. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run. Format: {project}:{location}:{instance}</summary>
    [JsonPropertyName("instanceRefs")]
    public IList<V1beta1RunJobSpecTemplateTemplateVolumesCloudSqlInstanceInstanceRefs>? InstanceRefs { get; set; }
}

/// <summary>Ephemeral storage used as a shared volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumesEmptyDir
{
    /// <summary>The medium on which the data is stored. Acceptable values today is only MEMORY or none. When none, the default will currently be backed by memory but could change over time. +optional</summary>
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }

    /// <summary>Limit on the storage usable by this EmptyDir volume. The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers. The default is nil which means that the limit is undefined. More info: https://cloud.google.com/run/docs/configuring/in-memory-volumes#configure-volume. Info in Kubernetes: https://kubernetes.io/docs/concepts/storage/volumes/#emptydir</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>Cloud Storage Bucket name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumesGcsBucketRef
{
    /// <summary>A reference to an externally-managed StorageBucket resource.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a StorageBucket resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a StorageBucket resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Persistent storage backed by a Google Cloud Storage bucket.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumesGcs
{
    /// <summary>Cloud Storage Bucket name.</summary>
    [JsonPropertyName("bucketRef")]
    public V1beta1RunJobSpecTemplateTemplateVolumesGcsBucketRef? BucketRef { get; set; }

    /// <summary>A list of additional flags to pass to the gcsfuse CLI. Options should be specified without the leading &quot;--&quot;.</summary>
    [JsonPropertyName("mountOptions")]
    public IList<string>? MountOptions { get; set; }

    /// <summary>If true, the volume will be mounted as read only for all mounts.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

/// <summary>For Nfs Volumes, contains the path to the nfs Volume</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumesNfs
{
    /// <summary>Path that is exported by the NFS server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>If true, the volume will be mounted as read only for all mounts.</summary>
    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>Hostname or IP address of the NFS server</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }
}

/// <summary>The Cloud Secret Manager secret version. Can be &apos;latest&apos; for the latest value, or an integer or a secret alias for a specific version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumesSecretItemsVersionRef
{
    /// <summary>A reference to an externally managed SecretManagerSecretVersion resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secretversions/{{secretversionID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecretVersion resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecretVersion resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumesSecretItems
{
    /// <summary>
    /// Integer octal mode bits to use on this file, must be a value between
    ///  01 and 0777 (octal). If 0 or not set, the Volume&apos;s default mode will be
    ///  used.
    /// 
    ///  Notes
    /// 
    ///  * Internally, a umask of 0222 will be applied to any non-zero value.
    ///  * This is an integer representation of the mode bits. So, the octal
    ///  integer value should look exactly as the chmod numeric notation with a
    ///  leading zero. Some examples: for chmod 640 (u=rw,g=r), set to 0640 (octal)
    ///  or 416 (base-10). For chmod 755 (u=rwx,g=rx,o=rx), set to 0755 (octal) or
    ///  493 (base-10).
    ///  * This might be in conflict with other options that affect the
    ///  file mode, like fsGroup, and the result can be other mode bits set.
    /// </summary>
    [JsonPropertyName("mode")]
    public int? Mode { get; set; }

    /// <summary>Required. The relative path of the secret in the container.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>The Cloud Secret Manager secret version. Can be &apos;latest&apos; for the latest value, or an integer or a secret alias for a specific version.</summary>
    [JsonPropertyName("versionRef")]
    public V1beta1RunJobSpecTemplateTemplateVolumesSecretItemsVersionRef? VersionRef { get; set; }
}

/// <summary>Required. The name of the secret in Cloud Secret Manager. Format: {secret} if the secret is in the same project. projects/{project}/secrets/{secret} if the secret is in a different project.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumesSecretSecretRef
{
    /// <summary>A reference to an externally managed SecretManagerSecret resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/secrets/{{secretID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a SecretManagerSecret resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Secret represents a secret that should populate this volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumesSecret
{
    /// <summary>
    /// Integer representation of mode bits to use on created files by default.
    ///  Must be a value between 0000 and 0777 (octal), defaulting to 0444.
    ///  Directories within the path are not affected by  this setting.
    /// 
    ///  Notes
    /// 
    ///  * Internally, a umask of 0222 will be applied to any non-zero value.
    ///  * This is an integer representation of the mode bits. So, the octal
    ///  integer value should look exactly as the chmod numeric notation with a
    ///  leading zero. Some examples: for chmod 640 (u=rw,g=r), set to 0640 (octal)
    ///  or 416 (base-10). For chmod 755 (u=rwx,g=rx,o=rx), set to 0755 (octal) or
    ///  493 (base-10).
    ///  * This might be in conflict with other options that affect the
    ///  file mode, like fsGroup, and the result can be other mode bits set.
    /// 
    ///  This might be in conflict with other options that affect the
    ///  file mode, like fsGroup, and as a result, other mode bits could be set.
    /// </summary>
    [JsonPropertyName("defaultMode")]
    public int? DefaultMode { get; set; }

    /// <summary>If unspecified, the volume will expose a file whose name is the secret, relative to VolumeMount.mount_path. If specified, the key will be used as the version to fetch from Cloud Secret Manager and the path will be the name of the file exposed in the volume. When items are defined, they must specify a path and a version.</summary>
    [JsonPropertyName("items")]
    public IList<V1beta1RunJobSpecTemplateTemplateVolumesSecretItems>? Items { get; set; }

    /// <summary>Required. The name of the secret in Cloud Secret Manager. Format: {secret} if the secret is in the same project. projects/{project}/secrets/{secret} if the secret is in a different project.</summary>
    [JsonPropertyName("secretRef")]
    public V1beta1RunJobSpecTemplateTemplateVolumesSecretSecretRef? SecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVolumes
{
    /// <summary>For Cloud SQL volumes, contains the specific instances that should be mounted. Visit https://cloud.google.com/sql/docs/mysql/connect-run for more information on how to connect Cloud SQL and Cloud Run.</summary>
    [JsonPropertyName("cloudSqlInstance")]
    public V1beta1RunJobSpecTemplateTemplateVolumesCloudSqlInstance? CloudSqlInstance { get; set; }

    /// <summary>Ephemeral storage used as a shared volume.</summary>
    [JsonPropertyName("emptyDir")]
    public V1beta1RunJobSpecTemplateTemplateVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>Persistent storage backed by a Google Cloud Storage bucket.</summary>
    [JsonPropertyName("gcs")]
    public V1beta1RunJobSpecTemplateTemplateVolumesGcs? Gcs { get; set; }

    /// <summary>Required. Volume&apos;s name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>For Nfs Volumes, contains the path to the nfs Volume</summary>
    [JsonPropertyName("nfs")]
    public V1beta1RunJobSpecTemplateTemplateVolumesNfs? Nfs { get; set; }

    /// <summary>Secret represents a secret that should populate this volume.</summary>
    [JsonPropertyName("secret")]
    public V1beta1RunJobSpecTemplateTemplateVolumesSecret? Secret { get; set; }
}

/// <summary>VPC Access connector name. Format: `projects/{project}/locations/{location}/connectors/{connector}`, where `{project}` can be project id or number. For more information on sending traffic to a VPC network via a connector, visit https://cloud.google.com/run/docs/configuring/vpc-connectors.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVpcAccessConnectorRef
{
    /// <summary>A reference to an externally managed VPCAccessConnector resource. Should be in the format `projects/{project_id}/locations/{location}/connectors/{connector_id}`</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a VPCAccessConnector resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a VPCAccessConnector resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The VPC network that the Cloud Run resource will be able to send traffic to. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If network is not specified, it will be looked up from the subnetwork.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVpcAccessNetworkInterfacesNetworkRef
{
    /// <summary>The value of an externally managed ComputeNetwork resource. Should be in the format &quot;https://www.googleapis.com/compute/{{version}}/projects/{{projectId}}/global/networks/{{networkId}}&quot; or &quot;projects/{{projectId}}/global/networks/{{networkId}}&quot;</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a ComputeNetwork resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a ComputeNetwork resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Optional. The VPC subnetwork that the Cloud Run resource will get IPs from. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If subnetwork is not specified, the subnetwork with the same name with the network will be used.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVpcAccessNetworkInterfacesSubnetworkRef
{
    /// <summary>The ComputeSubnetwork selflink of form &quot;projects/{{project}}/regions/{{region}}/subnetworks/{{name}}&quot;, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `ComputeSubnetwork` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVpcAccessNetworkInterfaces
{
    /// <summary>Optional. The VPC network that the Cloud Run resource will be able to send traffic to. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If network is not specified, it will be looked up from the subnetwork.</summary>
    [JsonPropertyName("networkRef")]
    public V1beta1RunJobSpecTemplateTemplateVpcAccessNetworkInterfacesNetworkRef? NetworkRef { get; set; }

    /// <summary>Optional. The VPC subnetwork that the Cloud Run resource will get IPs from. At least one of network or subnetwork must be specified. If both network and subnetwork are specified, the given VPC subnetwork must belong to the given VPC network. If subnetwork is not specified, the subnetwork with the same name with the network will be used.</summary>
    [JsonPropertyName("subnetworkRef")]
    public V1beta1RunJobSpecTemplateTemplateVpcAccessNetworkInterfacesSubnetworkRef? SubnetworkRef { get; set; }

    /// <summary>Optional. Network tags applied to this Cloud Run resource.</summary>
    [JsonPropertyName("tags")]
    public IList<string>? Tags { get; set; }
}

/// <summary>Optional. VPC Access configuration to use for this Task. For more information, visit https://cloud.google.com/run/docs/configuring/connecting-vpc.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplateVpcAccess
{
    /// <summary>VPC Access connector name. Format: `projects/{project}/locations/{location}/connectors/{connector}`, where `{project}` can be project id or number. For more information on sending traffic to a VPC network via a connector, visit https://cloud.google.com/run/docs/configuring/vpc-connectors.</summary>
    [JsonPropertyName("connectorRef")]
    public V1beta1RunJobSpecTemplateTemplateVpcAccessConnectorRef? ConnectorRef { get; set; }

    /// <summary>Optional. Traffic VPC egress settings. If not provided, it defaults to PRIVATE_RANGES_ONLY.</summary>
    [JsonPropertyName("egress")]
    public string? Egress { get; set; }

    /// <summary>Optional. Direct VPC egress settings. Currently only single network interface is supported.</summary>
    [JsonPropertyName("networkInterfaces")]
    public IList<V1beta1RunJobSpecTemplateTemplateVpcAccessNetworkInterfaces>? NetworkInterfaces { get; set; }
}

/// <summary>Required. Describes the task(s) that will be created when executing an execution.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplateTemplate
{
    /// <summary>Holds the single container that defines the unit of execution for this task.</summary>
    [JsonPropertyName("containers")]
    public IList<V1beta1RunJobSpecTemplateTemplateContainers>? Containers { get; set; }

    /// <summary>A reference to a customer managed encryption key (CMEK) to use to encrypt this container image. For more information, go to https://cloud.google.com/run/docs/securing/using-cmek</summary>
    [JsonPropertyName("encryptionKeyRef")]
    public V1beta1RunJobSpecTemplateTemplateEncryptionKeyRef? EncryptionKeyRef { get; set; }

    /// <summary>Optional. The execution environment being used to host this Task.</summary>
    [JsonPropertyName("executionEnvironment")]
    public string? ExecutionEnvironment { get; set; }

    /// <summary>Number of retries allowed per Task, before marking this Task failed. Defaults to 3.</summary>
    [JsonPropertyName("maxRetries")]
    public int? MaxRetries { get; set; }

    /// <summary>Optional. Email address of the IAM service account associated with the Task of a Job. The service account represents the identity of the running task, and determines what permissions the task has. If not provided, the task will use the project&apos;s default service account.</summary>
    [JsonPropertyName("serviceAccountRef")]
    public V1beta1RunJobSpecTemplateTemplateServiceAccountRef? ServiceAccountRef { get; set; }

    /// <summary>Optional. Max allowed time duration the Task may be active before the system will actively try to mark it failed and kill associated containers. This applies per attempt of a task, meaning each retry can run for the full timeout. Defaults to 600 seconds.</summary>
    [JsonPropertyName("timeout")]
    public string? Timeout { get; set; }

    /// <summary>Optional. A list of Volumes to make available to containers.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta1RunJobSpecTemplateTemplateVolumes>? Volumes { get; set; }

    /// <summary>Optional. VPC Access configuration to use for this Task. For more information, visit https://cloud.google.com/run/docs/configuring/connecting-vpc.</summary>
    [JsonPropertyName("vpcAccess")]
    public V1beta1RunJobSpecTemplateTemplateVpcAccess? VpcAccess { get; set; }
}

/// <summary>Required. The template used to create executions for this Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpecTemplate
{
    /// <summary>
    /// Unstructured key value map that may be set by external tools to store and
    ///  arbitrary metadata. They are not queryable and should be preserved
    ///  when modifying objects.
    /// 
    ///  &lt;p&gt;Cloud Run API v2 does not support annotations with `run.googleapis.com`,
    ///  `cloud.googleapis.com`, `serving.knative.dev`, or `autoscaling.knative.dev`
    ///  namespaces, and they will be rejected. All system annotations in v1 now
    ///  have a corresponding field in v2 ExecutionTemplate.
    /// 
    ///  &lt;p&gt;This field follows Kubernetes annotations&apos; namespacing, limits, and
    ///  rules.
    /// </summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Optional. Specifies the maximum desired number of tasks the execution should run at given time. When the job is run, if this field is 0 or unset, the maximum possible value will be used for that execution. The actual number of tasks running in steady state will be less than this number when there are fewer tasks waiting to be completed remaining, i.e. when the work left to do is less than max parallelism.</summary>
    [JsonPropertyName("parallelism")]
    public int? Parallelism { get; set; }

    /// <summary>Specifies the desired number of tasks the execution should run. Setting to 1 means that parallelism is limited to 1 and the success of that task signals the success of the execution. Defaults to 1.</summary>
    [JsonPropertyName("taskCount")]
    public int? TaskCount { get; set; }

    /// <summary>Required. Describes the task(s) that will be created when executing an execution.</summary>
    [JsonPropertyName("template")]
    public V1beta1RunJobSpecTemplateTemplate? Template { get; set; }
}

/// <summary>RunJobSpec defines the desired state of RunJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobSpec
{
    /// <summary>Optional. User-provided annotations, which are stored in GCP.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>Optional. Settings for Binary Authorization feature.</summary>
    [JsonPropertyName("binaryAuthorization")]
    public V1beta1RunJobSpecBinaryAuthorization? BinaryAuthorization { get; set; }

    /// <summary>Optional. Arbitrary identifier for the API client.</summary>
    [JsonPropertyName("client")]
    public string? Client { get; set; }

    /// <summary>Optional. Arbitrary version identifier for the API client.</summary>
    [JsonPropertyName("clientVersion")]
    public string? ClientVersion { get; set; }

    /// <summary>Optional. The launch stage of the job. Possible values are `LAUNCH_STAGE_UNSPECIFIED`, `UNIMPLEMENTED`, `PRELAUNCH`, `EARLY_ACCESS`, `ALPHA`, `BETA`, `GA`, `DEPRECATED`.</summary>
    [JsonPropertyName("launchStage")]
    public string? LaunchStage { get; set; }

    /// <summary>The location of the cloud run job</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public V1beta1RunJobSpecProjectRef? ProjectRef { get; set; }

    /// <summary>The RunJob name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. The template used to create executions for this Job.</summary>
    [JsonPropertyName("template")]
    public required V1beta1RunJobSpecTemplate Template { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobStatusLatestCreatedExecution
{
    /// <summary>Status for the execution completion.</summary>
    [JsonPropertyName("completionStatus")]
    public string? CompletionStatus { get; set; }

    /// <summary>Creation timestamp of the execution.</summary>
    [JsonPropertyName("completionTime")]
    public string? CompletionTime { get; set; }

    /// <summary>Creation timestamp of the execution.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>The deletion time of the execution. It is only populated as a response to a Delete request.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Name of the execution.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobStatusTerminalCondition
{
    /// <summary>A reason for the execution condition.</summary>
    [JsonPropertyName("executionReason")]
    public string? ExecutionReason { get; set; }

    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human readable message indicating details about the current status.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>A common (service-level) reason for this condition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>A reason for the revision condition.</summary>
    [JsonPropertyName("revisionReason")]
    public string? RevisionReason { get; set; }

    /// <summary>How to interpret failures of this condition, one of Error, Warning, Info</summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>State of the condition.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>type is used to communicate the status of the reconciliation process. See also: https://github.com/knative/serving/blob/main/docs/spec/errors.md#error-conditions-and-reporting Types common to all resources include: * &quot;Ready&quot;: True when the Resource is ready.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>RunJobStatus defines the config connector machine state of RunJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1RunJobStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1RunJobStatusConditions>? Conditions { get; set; }

    /// <summary>Output only. The creation time.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Email address of the authenticated creator.</summary>
    [JsonPropertyName("creator")]
    public string? Creator { get; set; }

    /// <summary>Output only. The deletion time. It is only populated as a response to a Delete request.</summary>
    [JsonPropertyName("deleteTime")]
    public string? DeleteTime { get; set; }

    /// <summary>Output only. A system-generated fingerprint for this version of the resource. May be used to detect modification conflict during updates.</summary>
    [JsonPropertyName("etag")]
    public string? Etag { get; set; }

    /// <summary>Output only. Number of executions created for this job.</summary>
    [JsonPropertyName("executionCount")]
    public int? ExecutionCount { get; set; }

    /// <summary>Output only. For a deleted resource, the time after which it will be permanently deleted.</summary>
    [JsonPropertyName("expireTime")]
    public string? ExpireTime { get; set; }

    /// <summary>A unique specifier for the RunJob resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>LastModifiedCookie contains hashes of the last applied spec and the last observed GCP state. The format is &quot; &lt;spec-hash&gt;/&lt;gcp-hash&gt; &quot;. This is used by the controller to detect if the user&apos;s desired state has changed or if the GCP resource has drifted.</summary>
    [JsonPropertyName("lastModifiedCookie")]
    public string? LastModifiedCookie { get; set; }

    /// <summary>Output only. Email address of the last authenticated modifier.</summary>
    [JsonPropertyName("lastModifier")]
    public string? LastModifier { get; set; }

    /// <summary>Output only. Name of the last created execution.</summary>
    [JsonPropertyName("latestCreatedExecution")]
    public IList<V1beta1RunJobStatusLatestCreatedExecution>? LatestCreatedExecution { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Output only. Returns true if the Job is currently being acted upon by the
    /// system to bring it into the desired state.
    /// 
    /// When a new Job is created, or an existing one is updated, Cloud Run
    /// will asynchronously perform all necessary steps to bring the Job to the
    /// desired state. This process is called reconciliation.
    /// While reconciliation is in process, `observed_generation` and
    /// `latest_succeeded_execution`, will have transient values that might
    /// mismatch the intended state: Once reconciliation is over (and this field is
    /// false), there are two possible outcomes: reconciliation succeeded and the
    /// state matches the Job, or there was an error,  and reconciliation failed.
    /// This state can be found in `terminal_condition.state`.
    /// 
    /// If reconciliation succeeded, the following fields will match:
    /// `observed_generation` and `generation`, `latest_succeeded_execution` and
    /// `latest_created_execution`.
    /// 
    /// If reconciliation failed, `observed_generation` and
    /// `latest_succeeded_execution` will have the state of the last succeeded
    /// execution or empty for newly created Job. Additional information on the
    /// failure can be found in `terminal_condition` and `conditions`.
    /// </summary>
    [JsonPropertyName("reconciling")]
    public bool? Reconciling { get; set; }

    /// <summary>Output only. The Condition of this Job, containing its readiness status, and detailed error information in case it did not reach the desired state.</summary>
    [JsonPropertyName("terminalCondition")]
    public IList<V1beta1RunJobStatusTerminalCondition>? TerminalCondition { get; set; }

    /// <summary>Output only. Server assigned unique identifier for the Execution. The value is a UUID4 string and guaranteed to remain unchanged until the resource is deleted.</summary>
    [JsonPropertyName("uid")]
    public string? Uid { get; set; }

    /// <summary>Output only. The last-modified time.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>RunJob is the Schema for the RunJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1RunJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1RunJobSpec>, IStatus<V1beta1RunJobStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "RunJob";
    public const string KubeGroup = "run.cnrm.cloud.google.com";
    public const string KubePluralName = "runjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "run.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RunJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RunJobSpec defines the desired state of RunJob</summary>
    [JsonPropertyName("spec")]
    public required V1beta1RunJobSpec Spec { get; set; }

    /// <summary>RunJobStatus defines the config connector machine state of RunJob</summary>
    [JsonPropertyName("status")]
    public V1beta1RunJobStatus? Status { get; set; }
}