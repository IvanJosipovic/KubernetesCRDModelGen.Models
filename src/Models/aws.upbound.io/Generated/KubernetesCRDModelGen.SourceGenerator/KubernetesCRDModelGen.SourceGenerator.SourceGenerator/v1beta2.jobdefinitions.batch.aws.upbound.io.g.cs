#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.batch.aws.upbound.io;
/// <summary>JobDefinition is the Schema for the JobDefinitions API. Provides a Batch Job Definition resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2JobDefinitionList : IKubernetesObject<V1ListMeta>, IItems<V1beta2JobDefinition>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "JobDefinitionList";
    public const string KubeGroup = "batch.aws.upbound.io";
    public const string KubePluralName = "jobdefinitions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "batch.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "JobDefinitionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2JobDefinition objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2JobDefinition> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobDefinitionSpecDeletionPolicyEnum>))]
public enum V1beta2JobDefinitionSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesContainersEnv
{
    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Type and amount of resources to assign to a container. The supported resources include memory, cpu, and nvidia.com/gpu.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesContainersResources
{
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, string>? Requests { get; set; }
}

/// <summary>Security context for a job. See security_context below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesContainersSecurityContext
{
    /// <summary>Whether or not a container or a Kubernetes pod is allowed to gain more privileges than its parent process. The default value is false.</summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary>When this parameter is true, the container is given elevated permissions on the host container instance. The level of permissions are similar to the root user permissions. The default value is false.</summary>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("readOnlyRootFileSystem")]
    public bool? ReadOnlyRootFileSystem { get; set; }

    /// <summary>When this parameter is specified, the container is run as the specified group ID (gid). If this parameter isn&apos;t specified, the default is the group that&apos;s specified in the image metadata.</summary>
    [JsonPropertyName("runAsGroup")]
    public double? RunAsGroup { get; set; }

    /// <summary>When this parameter is specified, the container is run as a user with a uid other than 0. If this parameter isn&apos;t specified, so such rule is enforced.</summary>
    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary>When this parameter is specified, the container is run as the specified user ID (uid). If this parameter isn&apos;t specified, the default is the user that&apos;s specified in the image metadata.</summary>
    [JsonPropertyName("runAsUser")]
    public double? RunAsUser { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesContainersVolumeMounts
{
    /// <summary>Path of the file or directory on the host to mount into containers on the pod.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesContainers
{
    /// <summary>Array of arguments to the entrypoint. If this isn&apos;t specified, the CMD of the container image is used. This corresponds to the args member in the Entrypoint portion of the Pod in Kubernetes. Environment variable references are expanded using the container&apos;s environment.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint for the container. This isn&apos;t run within a shell. If this isn&apos;t specified, the ENTRYPOINT of the container image is used. Environment variable references are expanded using the container&apos;s environment.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Environment variables to pass to a container. See EKS Environment below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesContainersEnv>? Env { get; set; }

    /// <summary>Docker image used to start the container.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Image pull policy for the container. Supported values are Always, IfNotPresent, and Never.</summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary>Name of the container. If the name isn&apos;t specified, the default name &quot;Default&quot; is used. Each container in a pod must have a unique name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type and amount of resources to assign to a container. The supported resources include memory, cpu, and nvidia.com/gpu.</summary>
    [JsonPropertyName("resources")]
    public V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesContainersResources? Resources { get; set; }

    /// <summary>Security context for a job. See security_context below.</summary>
    [JsonPropertyName("securityContext")]
    public V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesContainersSecurityContext? SecurityContext { get; set; }

    /// <summary>Volume mounts for the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesContainersVolumeMounts>? VolumeMounts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesImagePullSecret
{
    /// <summary>Unique identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesInitContainersEnv
{
    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Type and amount of resources to assign to a container. The supported resources include memory, cpu, and nvidia.com/gpu.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesInitContainersResources
{
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, string>? Requests { get; set; }
}

/// <summary>Security context for a job. See security_context below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesInitContainersSecurityContext
{
    /// <summary>Whether or not a container or a Kubernetes pod is allowed to gain more privileges than its parent process. The default value is false.</summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary>When this parameter is true, the container is given elevated permissions on the host container instance. The level of permissions are similar to the root user permissions. The default value is false.</summary>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("readOnlyRootFileSystem")]
    public bool? ReadOnlyRootFileSystem { get; set; }

    /// <summary>When this parameter is specified, the container is run as the specified group ID (gid). If this parameter isn&apos;t specified, the default is the group that&apos;s specified in the image metadata.</summary>
    [JsonPropertyName("runAsGroup")]
    public double? RunAsGroup { get; set; }

    /// <summary>When this parameter is specified, the container is run as a user with a uid other than 0. If this parameter isn&apos;t specified, so such rule is enforced.</summary>
    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary>When this parameter is specified, the container is run as the specified user ID (uid). If this parameter isn&apos;t specified, the default is the user that&apos;s specified in the image metadata.</summary>
    [JsonPropertyName("runAsUser")]
    public double? RunAsUser { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesInitContainersVolumeMounts
{
    /// <summary>Path of the file or directory on the host to mount into containers on the pod.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesInitContainers
{
    /// <summary>Array of arguments to the entrypoint. If this isn&apos;t specified, the CMD of the container image is used. This corresponds to the args member in the Entrypoint portion of the Pod in Kubernetes. Environment variable references are expanded using the container&apos;s environment.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint for the container. This isn&apos;t run within a shell. If this isn&apos;t specified, the ENTRYPOINT of the container image is used. Environment variable references are expanded using the container&apos;s environment.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Environment variables to pass to a container. See EKS Environment below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesInitContainersEnv>? Env { get; set; }

    /// <summary>Docker image used to start the container.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Image pull policy for the container. Supported values are Always, IfNotPresent, and Never.</summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type and amount of resources to assign to a container. The supported resources include memory, cpu, and nvidia.com/gpu.</summary>
    [JsonPropertyName("resources")]
    public V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesInitContainersResources? Resources { get; set; }

    /// <summary>Security context for a job. See security_context below.</summary>
    [JsonPropertyName("securityContext")]
    public V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesInitContainersSecurityContext? SecurityContext { get; set; }

    /// <summary>Volume mounts for the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesInitContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Metadata about the Kubernetes pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesMetadata
{
    /// <summary>Key-value pairs used to identify, sort, and organize kubernetes resources.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesVolumesEmptyDir
{
    /// <summary>Medium to store the volume. The default value is an empty string, which uses the storage of the node.</summary>
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }

    /// <summary>Maximum size of the volume. By default, there&apos;s no maximum size defined.</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>Path of the file or directory on the host to mount into containers on the pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesVolumesHostPath
{
    /// <summary>Path of the file or directory on the host to mount into containers on the pod.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesVolumesSecret
{
    /// <summary>Whether the secret or the secret&apos;s keys must be defined.</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    /// <summary>Name of the secret. The name must be allowed as a DNS subdomain name.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesVolumes
{
    [JsonPropertyName("emptyDir")]
    public V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>Path of the file or directory on the host to mount into containers on the pod.</summary>
    [JsonPropertyName("hostPath")]
    public V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesVolumesHostPath? HostPath { get; set; }

    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("secret")]
    public V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesVolumesSecret? Secret { get; set; }
}

/// <summary>Properties for the Kubernetes pod resources of a job. See pod_properties below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksPropertiesPodProperties
{
    /// <summary>Properties of the container that&apos;s used on the Amazon EKS pod. See containers below.</summary>
    [JsonPropertyName("containers")]
    public IList<V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesContainers>? Containers { get; set; }

    /// <summary>DNS policy for the pod. The default value is ClusterFirst. If the host_network argument is not specified, the default is ClusterFirstWithHostNet. ClusterFirst indicates that any DNS query that does not match the configured cluster domain suffix is forwarded to the upstream nameserver inherited from the node. For more information, see Pod&apos;s DNS policy in the Kubernetes documentation.</summary>
    [JsonPropertyName("dnsPolicy")]
    public string? DnsPolicy { get; set; }

    /// <summary>Whether the pod uses the hosts&apos; network IP address. The default value is true. Setting this to false enables the Kubernetes pod networking model. Most AWS Batch workloads are egress-only and don&apos;t require the overhead of IP allocation for each pod for incoming connections.</summary>
    [JsonPropertyName("hostNetwork")]
    public bool? HostNetwork { get; set; }

    /// <summary>List of Kubernetes secret resources. See image_pull_secret below.</summary>
    [JsonPropertyName("imagePullSecret")]
    public IList<V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesImagePullSecret>? ImagePullSecret { get; set; }

    /// <summary>Containers which run before application containers, always runs to completion, and must complete successfully before the next container starts. These containers are registered with the Amazon EKS Connector agent and persists the registration information in the Kubernetes backend data store. See containers below.</summary>
    [JsonPropertyName("initContainers")]
    public IList<V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesInitContainers>? InitContainers { get; set; }

    /// <summary>Metadata about the Kubernetes pod.</summary>
    [JsonPropertyName("metadata")]
    public V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesMetadata? Metadata { get; set; }

    /// <summary>Name of the service account that&apos;s used to run the pod.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>Indicates if the processes in a container are shared, or visible, to other containers in the same pod.</summary>
    [JsonPropertyName("shareProcessNamespace")]
    public bool? ShareProcessNamespace { get; set; }

    /// <summary>Volumes for a job definition that uses Amazon EKS resources. AWS Batch supports emptyDir, hostPath, and secret volume types.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta2JobDefinitionSpecForProviderEksPropertiesPodPropertiesVolumes>? Volumes { get; set; }
}

/// <summary>Valid eks properties. This parameter is only valid if the type parameter is container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderEksProperties
{
    /// <summary>Properties for the Kubernetes pod resources of a job. See pod_properties below.</summary>
    [JsonPropertyName("podProperties")]
    public V1beta2JobDefinitionSpecForProviderEksPropertiesPodProperties? PodProperties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderRetryStrategyEvaluateOnExit
{
    /// <summary>Action to take if all of the specified conditions are met. The values are not case sensitive. Valid values: retry, exit.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Glob pattern to match against the decimal representation of the exit code returned for a job.</summary>
    [JsonPropertyName("onExitCode")]
    public string? OnExitCode { get; set; }

    /// <summary>Glob pattern to match against the reason returned for a job.</summary>
    [JsonPropertyName("onReason")]
    public string? OnReason { get; set; }

    /// <summary>Glob pattern to match against the status reason returned for a job.</summary>
    [JsonPropertyName("onStatusReason")]
    public string? OnStatusReason { get; set; }
}

/// <summary>Retry strategy to use for failed jobs that are submitted with this job definition. Maximum number of retry_strategy is 1.  Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderRetryStrategy
{
    /// <summary>Number of times to move a job to the RUNNABLE status. You may specify between 1 and 10 attempts.</summary>
    [JsonPropertyName("attempts")]
    public double? Attempts { get; set; }

    /// <summary>Evaluate on exit conditions under which the job should be retried or failed. If this parameter is specified, then the attempts parameter must also be specified. You may specify up to 5 configuration blocks.</summary>
    [JsonPropertyName("evaluateOnExit")]
    public IList<V1beta2JobDefinitionSpecForProviderRetryStrategyEvaluateOnExit>? EvaluateOnExit { get; set; }
}

/// <summary>Timeout for jobs so that if a job runs longer, AWS Batch terminates the job. Maximum number of timeout is 1. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProviderTimeout
{
    /// <summary>Time duration in seconds after which AWS Batch terminates your jobs if they have not finished. The minimum value for the timeout is 60 seconds.</summary>
    [JsonPropertyName("attemptDurationSeconds")]
    public double? AttemptDurationSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecForProvider
{
    /// <summary>Valid container properties provided as a single valid JSON document. This parameter is only valid if the type parameter is container.</summary>
    [JsonPropertyName("containerProperties")]
    public string? ContainerProperties { get; set; }

    /// <summary>When updating a job definition a new revision is created. This parameter determines if the previous version is deregistered (INACTIVE) or left  ACTIVE. Defaults to true.</summary>
    [JsonPropertyName("deregisterOnNewRevision")]
    public bool? DeregisterOnNewRevision { get; set; }

    /// <summary>Valid ECS properties provided as a single valid JSON document. This parameter is only valid if the type parameter is container.</summary>
    [JsonPropertyName("ecsProperties")]
    public string? EcsProperties { get; set; }

    /// <summary>Valid eks properties. This parameter is only valid if the type parameter is container.</summary>
    [JsonPropertyName("eksProperties")]
    public V1beta2JobDefinitionSpecForProviderEksProperties? EksProperties { get; set; }

    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Valid node properties provided as a single valid JSON document. This parameter is required if the type parameter is multinode.</summary>
    [JsonPropertyName("nodeProperties")]
    public string? NodeProperties { get; set; }

    /// <summary>Parameter substitution placeholders to set in the job definition.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Platform capabilities required by the job definition. If no value is specified, it defaults to EC2. To run the job on Fargate resources, specify FARGATE.</summary>
    [JsonPropertyName("platformCapabilities")]
    public IList<string>? PlatformCapabilities { get; set; }

    /// <summary>Whether to propagate the tags from the job definition to the corresponding Amazon ECS task. Default is false.</summary>
    [JsonPropertyName("propagateTags")]
    public bool? PropagateTags { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Retry strategy to use for failed jobs that are submitted with this job definition. Maximum number of retry_strategy is 1.  Defined below.</summary>
    [JsonPropertyName("retryStrategy")]
    public V1beta2JobDefinitionSpecForProviderRetryStrategy? RetryStrategy { get; set; }

    /// <summary>Scheduling priority of the job definition. This only affects jobs in job queues with a fair share policy. Jobs with a higher scheduling priority are scheduled before jobs with a lower scheduling priority. Allowed values 0 through 9999.</summary>
    [JsonPropertyName("schedulingPriority")]
    public double? SchedulingPriority { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Timeout for jobs so that if a job runs longer, AWS Batch terminates the job. Maximum number of timeout is 1. Defined below.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2JobDefinitionSpecForProviderTimeout? Timeout { get; set; }

    /// <summary>Type of job definition. Must be container or multinode.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesContainersEnv
{
    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Type and amount of resources to assign to a container. The supported resources include memory, cpu, and nvidia.com/gpu.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesContainersResources
{
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, string>? Requests { get; set; }
}

/// <summary>Security context for a job. See security_context below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesContainersSecurityContext
{
    /// <summary>Whether or not a container or a Kubernetes pod is allowed to gain more privileges than its parent process. The default value is false.</summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary>When this parameter is true, the container is given elevated permissions on the host container instance. The level of permissions are similar to the root user permissions. The default value is false.</summary>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("readOnlyRootFileSystem")]
    public bool? ReadOnlyRootFileSystem { get; set; }

    /// <summary>When this parameter is specified, the container is run as the specified group ID (gid). If this parameter isn&apos;t specified, the default is the group that&apos;s specified in the image metadata.</summary>
    [JsonPropertyName("runAsGroup")]
    public double? RunAsGroup { get; set; }

    /// <summary>When this parameter is specified, the container is run as a user with a uid other than 0. If this parameter isn&apos;t specified, so such rule is enforced.</summary>
    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary>When this parameter is specified, the container is run as the specified user ID (uid). If this parameter isn&apos;t specified, the default is the user that&apos;s specified in the image metadata.</summary>
    [JsonPropertyName("runAsUser")]
    public double? RunAsUser { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesContainersVolumeMounts
{
    /// <summary>Path of the file or directory on the host to mount into containers on the pod.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesContainers
{
    /// <summary>Array of arguments to the entrypoint. If this isn&apos;t specified, the CMD of the container image is used. This corresponds to the args member in the Entrypoint portion of the Pod in Kubernetes. Environment variable references are expanded using the container&apos;s environment.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint for the container. This isn&apos;t run within a shell. If this isn&apos;t specified, the ENTRYPOINT of the container image is used. Environment variable references are expanded using the container&apos;s environment.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Environment variables to pass to a container. See EKS Environment below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesContainersEnv>? Env { get; set; }

    /// <summary>Docker image used to start the container.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Image pull policy for the container. Supported values are Always, IfNotPresent, and Never.</summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary>Name of the container. If the name isn&apos;t specified, the default name &quot;Default&quot; is used. Each container in a pod must have a unique name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type and amount of resources to assign to a container. The supported resources include memory, cpu, and nvidia.com/gpu.</summary>
    [JsonPropertyName("resources")]
    public V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesContainersResources? Resources { get; set; }

    /// <summary>Security context for a job. See security_context below.</summary>
    [JsonPropertyName("securityContext")]
    public V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesContainersSecurityContext? SecurityContext { get; set; }

    /// <summary>Volume mounts for the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesContainersVolumeMounts>? VolumeMounts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesImagePullSecret
{
    /// <summary>Unique identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesInitContainersEnv
{
    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Type and amount of resources to assign to a container. The supported resources include memory, cpu, and nvidia.com/gpu.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesInitContainersResources
{
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, string>? Requests { get; set; }
}

/// <summary>Security context for a job. See security_context below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesInitContainersSecurityContext
{
    /// <summary>Whether or not a container or a Kubernetes pod is allowed to gain more privileges than its parent process. The default value is false.</summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary>When this parameter is true, the container is given elevated permissions on the host container instance. The level of permissions are similar to the root user permissions. The default value is false.</summary>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("readOnlyRootFileSystem")]
    public bool? ReadOnlyRootFileSystem { get; set; }

    /// <summary>When this parameter is specified, the container is run as the specified group ID (gid). If this parameter isn&apos;t specified, the default is the group that&apos;s specified in the image metadata.</summary>
    [JsonPropertyName("runAsGroup")]
    public double? RunAsGroup { get; set; }

    /// <summary>When this parameter is specified, the container is run as a user with a uid other than 0. If this parameter isn&apos;t specified, so such rule is enforced.</summary>
    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary>When this parameter is specified, the container is run as the specified user ID (uid). If this parameter isn&apos;t specified, the default is the user that&apos;s specified in the image metadata.</summary>
    [JsonPropertyName("runAsUser")]
    public double? RunAsUser { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesInitContainersVolumeMounts
{
    /// <summary>Path of the file or directory on the host to mount into containers on the pod.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesInitContainers
{
    /// <summary>Array of arguments to the entrypoint. If this isn&apos;t specified, the CMD of the container image is used. This corresponds to the args member in the Entrypoint portion of the Pod in Kubernetes. Environment variable references are expanded using the container&apos;s environment.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint for the container. This isn&apos;t run within a shell. If this isn&apos;t specified, the ENTRYPOINT of the container image is used. Environment variable references are expanded using the container&apos;s environment.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Environment variables to pass to a container. See EKS Environment below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesInitContainersEnv>? Env { get; set; }

    /// <summary>Docker image used to start the container.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Image pull policy for the container. Supported values are Always, IfNotPresent, and Never.</summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type and amount of resources to assign to a container. The supported resources include memory, cpu, and nvidia.com/gpu.</summary>
    [JsonPropertyName("resources")]
    public V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesInitContainersResources? Resources { get; set; }

    /// <summary>Security context for a job. See security_context below.</summary>
    [JsonPropertyName("securityContext")]
    public V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesInitContainersSecurityContext? SecurityContext { get; set; }

    /// <summary>Volume mounts for the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesInitContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Metadata about the Kubernetes pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesMetadata
{
    /// <summary>Key-value pairs used to identify, sort, and organize kubernetes resources.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesVolumesEmptyDir
{
    /// <summary>Medium to store the volume. The default value is an empty string, which uses the storage of the node.</summary>
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }

    /// <summary>Maximum size of the volume. By default, there&apos;s no maximum size defined.</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>Path of the file or directory on the host to mount into containers on the pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesVolumesHostPath
{
    /// <summary>Path of the file or directory on the host to mount into containers on the pod.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesVolumesSecret
{
    /// <summary>Whether the secret or the secret&apos;s keys must be defined.</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    /// <summary>Name of the secret. The name must be allowed as a DNS subdomain name.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesVolumes
{
    [JsonPropertyName("emptyDir")]
    public V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>Path of the file or directory on the host to mount into containers on the pod.</summary>
    [JsonPropertyName("hostPath")]
    public V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesVolumesHostPath? HostPath { get; set; }

    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("secret")]
    public V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesVolumesSecret? Secret { get; set; }
}

/// <summary>Properties for the Kubernetes pod resources of a job. See pod_properties below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksPropertiesPodProperties
{
    /// <summary>Properties of the container that&apos;s used on the Amazon EKS pod. See containers below.</summary>
    [JsonPropertyName("containers")]
    public IList<V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesContainers>? Containers { get; set; }

    /// <summary>DNS policy for the pod. The default value is ClusterFirst. If the host_network argument is not specified, the default is ClusterFirstWithHostNet. ClusterFirst indicates that any DNS query that does not match the configured cluster domain suffix is forwarded to the upstream nameserver inherited from the node. For more information, see Pod&apos;s DNS policy in the Kubernetes documentation.</summary>
    [JsonPropertyName("dnsPolicy")]
    public string? DnsPolicy { get; set; }

    /// <summary>Whether the pod uses the hosts&apos; network IP address. The default value is true. Setting this to false enables the Kubernetes pod networking model. Most AWS Batch workloads are egress-only and don&apos;t require the overhead of IP allocation for each pod for incoming connections.</summary>
    [JsonPropertyName("hostNetwork")]
    public bool? HostNetwork { get; set; }

    /// <summary>List of Kubernetes secret resources. See image_pull_secret below.</summary>
    [JsonPropertyName("imagePullSecret")]
    public IList<V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesImagePullSecret>? ImagePullSecret { get; set; }

    /// <summary>Containers which run before application containers, always runs to completion, and must complete successfully before the next container starts. These containers are registered with the Amazon EKS Connector agent and persists the registration information in the Kubernetes backend data store. See containers below.</summary>
    [JsonPropertyName("initContainers")]
    public IList<V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesInitContainers>? InitContainers { get; set; }

    /// <summary>Metadata about the Kubernetes pod.</summary>
    [JsonPropertyName("metadata")]
    public V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesMetadata? Metadata { get; set; }

    /// <summary>Name of the service account that&apos;s used to run the pod.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>Indicates if the processes in a container are shared, or visible, to other containers in the same pod.</summary>
    [JsonPropertyName("shareProcessNamespace")]
    public bool? ShareProcessNamespace { get; set; }

    /// <summary>Volumes for a job definition that uses Amazon EKS resources. AWS Batch supports emptyDir, hostPath, and secret volume types.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta2JobDefinitionSpecInitProviderEksPropertiesPodPropertiesVolumes>? Volumes { get; set; }
}

/// <summary>Valid eks properties. This parameter is only valid if the type parameter is container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderEksProperties
{
    /// <summary>Properties for the Kubernetes pod resources of a job. See pod_properties below.</summary>
    [JsonPropertyName("podProperties")]
    public V1beta2JobDefinitionSpecInitProviderEksPropertiesPodProperties? PodProperties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderRetryStrategyEvaluateOnExit
{
    /// <summary>Action to take if all of the specified conditions are met. The values are not case sensitive. Valid values: retry, exit.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Glob pattern to match against the decimal representation of the exit code returned for a job.</summary>
    [JsonPropertyName("onExitCode")]
    public string? OnExitCode { get; set; }

    /// <summary>Glob pattern to match against the reason returned for a job.</summary>
    [JsonPropertyName("onReason")]
    public string? OnReason { get; set; }

    /// <summary>Glob pattern to match against the status reason returned for a job.</summary>
    [JsonPropertyName("onStatusReason")]
    public string? OnStatusReason { get; set; }
}

/// <summary>Retry strategy to use for failed jobs that are submitted with this job definition. Maximum number of retry_strategy is 1.  Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderRetryStrategy
{
    /// <summary>Number of times to move a job to the RUNNABLE status. You may specify between 1 and 10 attempts.</summary>
    [JsonPropertyName("attempts")]
    public double? Attempts { get; set; }

    /// <summary>Evaluate on exit conditions under which the job should be retried or failed. If this parameter is specified, then the attempts parameter must also be specified. You may specify up to 5 configuration blocks.</summary>
    [JsonPropertyName("evaluateOnExit")]
    public IList<V1beta2JobDefinitionSpecInitProviderRetryStrategyEvaluateOnExit>? EvaluateOnExit { get; set; }
}

/// <summary>Timeout for jobs so that if a job runs longer, AWS Batch terminates the job. Maximum number of timeout is 1. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecInitProviderTimeout
{
    /// <summary>Time duration in seconds after which AWS Batch terminates your jobs if they have not finished. The minimum value for the timeout is 60 seconds.</summary>
    [JsonPropertyName("attemptDurationSeconds")]
    public double? AttemptDurationSeconds { get; set; }
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
public partial class V1beta2JobDefinitionSpecInitProvider
{
    /// <summary>Valid container properties provided as a single valid JSON document. This parameter is only valid if the type parameter is container.</summary>
    [JsonPropertyName("containerProperties")]
    public string? ContainerProperties { get; set; }

    /// <summary>When updating a job definition a new revision is created. This parameter determines if the previous version is deregistered (INACTIVE) or left  ACTIVE. Defaults to true.</summary>
    [JsonPropertyName("deregisterOnNewRevision")]
    public bool? DeregisterOnNewRevision { get; set; }

    /// <summary>Valid ECS properties provided as a single valid JSON document. This parameter is only valid if the type parameter is container.</summary>
    [JsonPropertyName("ecsProperties")]
    public string? EcsProperties { get; set; }

    /// <summary>Valid eks properties. This parameter is only valid if the type parameter is container.</summary>
    [JsonPropertyName("eksProperties")]
    public V1beta2JobDefinitionSpecInitProviderEksProperties? EksProperties { get; set; }

    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Valid node properties provided as a single valid JSON document. This parameter is required if the type parameter is multinode.</summary>
    [JsonPropertyName("nodeProperties")]
    public string? NodeProperties { get; set; }

    /// <summary>Parameter substitution placeholders to set in the job definition.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Platform capabilities required by the job definition. If no value is specified, it defaults to EC2. To run the job on Fargate resources, specify FARGATE.</summary>
    [JsonPropertyName("platformCapabilities")]
    public IList<string>? PlatformCapabilities { get; set; }

    /// <summary>Whether to propagate the tags from the job definition to the corresponding Amazon ECS task. Default is false.</summary>
    [JsonPropertyName("propagateTags")]
    public bool? PropagateTags { get; set; }

    /// <summary>Retry strategy to use for failed jobs that are submitted with this job definition. Maximum number of retry_strategy is 1.  Defined below.</summary>
    [JsonPropertyName("retryStrategy")]
    public V1beta2JobDefinitionSpecInitProviderRetryStrategy? RetryStrategy { get; set; }

    /// <summary>Scheduling priority of the job definition. This only affects jobs in job queues with a fair share policy. Jobs with a higher scheduling priority are scheduled before jobs with a lower scheduling priority. Allowed values 0 through 9999.</summary>
    [JsonPropertyName("schedulingPriority")]
    public double? SchedulingPriority { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Timeout for jobs so that if a job runs longer, AWS Batch terminates the job. Maximum number of timeout is 1. Defined below.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2JobDefinitionSpecInitProviderTimeout? Timeout { get; set; }

    /// <summary>Type of job definition. Must be container or multinode.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobDefinitionSpecManagementPoliciesEnum>))]
public enum V1beta2JobDefinitionSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobDefinitionSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2JobDefinitionSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2JobDefinitionSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2JobDefinitionSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2JobDefinitionSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2JobDefinitionSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2JobDefinitionSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>JobDefinitionSpec defines the desired state of JobDefinition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionSpec
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
    public V1beta2JobDefinitionSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2JobDefinitionSpecForProvider ForProvider { get; set; }

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
    public V1beta2JobDefinitionSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2JobDefinitionSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2JobDefinitionSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2JobDefinitionSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesContainersEnv
{
    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Type and amount of resources to assign to a container. The supported resources include memory, cpu, and nvidia.com/gpu.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesContainersResources
{
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, string>? Requests { get; set; }
}

/// <summary>Security context for a job. See security_context below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesContainersSecurityContext
{
    /// <summary>Whether or not a container or a Kubernetes pod is allowed to gain more privileges than its parent process. The default value is false.</summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary>When this parameter is true, the container is given elevated permissions on the host container instance. The level of permissions are similar to the root user permissions. The default value is false.</summary>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("readOnlyRootFileSystem")]
    public bool? ReadOnlyRootFileSystem { get; set; }

    /// <summary>When this parameter is specified, the container is run as the specified group ID (gid). If this parameter isn&apos;t specified, the default is the group that&apos;s specified in the image metadata.</summary>
    [JsonPropertyName("runAsGroup")]
    public double? RunAsGroup { get; set; }

    /// <summary>When this parameter is specified, the container is run as a user with a uid other than 0. If this parameter isn&apos;t specified, so such rule is enforced.</summary>
    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary>When this parameter is specified, the container is run as the specified user ID (uid). If this parameter isn&apos;t specified, the default is the user that&apos;s specified in the image metadata.</summary>
    [JsonPropertyName("runAsUser")]
    public double? RunAsUser { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesContainersVolumeMounts
{
    /// <summary>Path of the file or directory on the host to mount into containers on the pod.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesContainers
{
    /// <summary>Array of arguments to the entrypoint. If this isn&apos;t specified, the CMD of the container image is used. This corresponds to the args member in the Entrypoint portion of the Pod in Kubernetes. Environment variable references are expanded using the container&apos;s environment.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint for the container. This isn&apos;t run within a shell. If this isn&apos;t specified, the ENTRYPOINT of the container image is used. Environment variable references are expanded using the container&apos;s environment.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Environment variables to pass to a container. See EKS Environment below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesContainersEnv>? Env { get; set; }

    /// <summary>Docker image used to start the container.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Image pull policy for the container. Supported values are Always, IfNotPresent, and Never.</summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary>Name of the container. If the name isn&apos;t specified, the default name &quot;Default&quot; is used. Each container in a pod must have a unique name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type and amount of resources to assign to a container. The supported resources include memory, cpu, and nvidia.com/gpu.</summary>
    [JsonPropertyName("resources")]
    public V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesContainersResources? Resources { get; set; }

    /// <summary>Security context for a job. See security_context below.</summary>
    [JsonPropertyName("securityContext")]
    public V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesContainersSecurityContext? SecurityContext { get; set; }

    /// <summary>Volume mounts for the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesContainersVolumeMounts>? VolumeMounts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesImagePullSecret
{
    /// <summary>Unique identifier.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesInitContainersEnv
{
    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the environment variable.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Type and amount of resources to assign to a container. The supported resources include memory, cpu, and nvidia.com/gpu.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesInitContainersResources
{
    [JsonPropertyName("limits")]
    public IDictionary<string, string>? Limits { get; set; }

    [JsonPropertyName("requests")]
    public IDictionary<string, string>? Requests { get; set; }
}

/// <summary>Security context for a job. See security_context below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesInitContainersSecurityContext
{
    /// <summary>Whether or not a container or a Kubernetes pod is allowed to gain more privileges than its parent process. The default value is false.</summary>
    [JsonPropertyName("allowPrivilegeEscalation")]
    public bool? AllowPrivilegeEscalation { get; set; }

    /// <summary>When this parameter is true, the container is given elevated permissions on the host container instance. The level of permissions are similar to the root user permissions. The default value is false.</summary>
    [JsonPropertyName("privileged")]
    public bool? Privileged { get; set; }

    [JsonPropertyName("readOnlyRootFileSystem")]
    public bool? ReadOnlyRootFileSystem { get; set; }

    /// <summary>When this parameter is specified, the container is run as the specified group ID (gid). If this parameter isn&apos;t specified, the default is the group that&apos;s specified in the image metadata.</summary>
    [JsonPropertyName("runAsGroup")]
    public double? RunAsGroup { get; set; }

    /// <summary>When this parameter is specified, the container is run as a user with a uid other than 0. If this parameter isn&apos;t specified, so such rule is enforced.</summary>
    [JsonPropertyName("runAsNonRoot")]
    public bool? RunAsNonRoot { get; set; }

    /// <summary>When this parameter is specified, the container is run as the specified user ID (uid). If this parameter isn&apos;t specified, the default is the user that&apos;s specified in the image metadata.</summary>
    [JsonPropertyName("runAsUser")]
    public double? RunAsUser { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesInitContainersVolumeMounts
{
    /// <summary>Path of the file or directory on the host to mount into containers on the pod.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("readOnly")]
    public bool? ReadOnly { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesInitContainers
{
    /// <summary>Array of arguments to the entrypoint. If this isn&apos;t specified, the CMD of the container image is used. This corresponds to the args member in the Entrypoint portion of the Pod in Kubernetes. Environment variable references are expanded using the container&apos;s environment.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Entrypoint for the container. This isn&apos;t run within a shell. If this isn&apos;t specified, the ENTRYPOINT of the container image is used. Environment variable references are expanded using the container&apos;s environment.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Environment variables to pass to a container. See EKS Environment below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesInitContainersEnv>? Env { get; set; }

    /// <summary>Docker image used to start the container.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Image pull policy for the container. Supported values are Always, IfNotPresent, and Never.</summary>
    [JsonPropertyName("imagePullPolicy")]
    public string? ImagePullPolicy { get; set; }

    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Type and amount of resources to assign to a container. The supported resources include memory, cpu, and nvidia.com/gpu.</summary>
    [JsonPropertyName("resources")]
    public V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesInitContainersResources? Resources { get; set; }

    /// <summary>Security context for a job. See security_context below.</summary>
    [JsonPropertyName("securityContext")]
    public V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesInitContainersSecurityContext? SecurityContext { get; set; }

    /// <summary>Volume mounts for the container.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesInitContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Metadata about the Kubernetes pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesMetadata
{
    /// <summary>Key-value pairs used to identify, sort, and organize kubernetes resources.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesVolumesEmptyDir
{
    /// <summary>Medium to store the volume. The default value is an empty string, which uses the storage of the node.</summary>
    [JsonPropertyName("medium")]
    public string? Medium { get; set; }

    /// <summary>Maximum size of the volume. By default, there&apos;s no maximum size defined.</summary>
    [JsonPropertyName("sizeLimit")]
    public string? SizeLimit { get; set; }
}

/// <summary>Path of the file or directory on the host to mount into containers on the pod.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesVolumesHostPath
{
    /// <summary>Path of the file or directory on the host to mount into containers on the pod.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesVolumesSecret
{
    /// <summary>Whether the secret or the secret&apos;s keys must be defined.</summary>
    [JsonPropertyName("optional")]
    public bool? Optional { get; set; }

    /// <summary>Name of the secret. The name must be allowed as a DNS subdomain name.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesVolumes
{
    [JsonPropertyName("emptyDir")]
    public V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesVolumesEmptyDir? EmptyDir { get; set; }

    /// <summary>Path of the file or directory on the host to mount into containers on the pod.</summary>
    [JsonPropertyName("hostPath")]
    public V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesVolumesHostPath? HostPath { get; set; }

    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("secret")]
    public V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesVolumesSecret? Secret { get; set; }
}

/// <summary>Properties for the Kubernetes pod resources of a job. See pod_properties below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksPropertiesPodProperties
{
    /// <summary>Properties of the container that&apos;s used on the Amazon EKS pod. See containers below.</summary>
    [JsonPropertyName("containers")]
    public IList<V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesContainers>? Containers { get; set; }

    /// <summary>DNS policy for the pod. The default value is ClusterFirst. If the host_network argument is not specified, the default is ClusterFirstWithHostNet. ClusterFirst indicates that any DNS query that does not match the configured cluster domain suffix is forwarded to the upstream nameserver inherited from the node. For more information, see Pod&apos;s DNS policy in the Kubernetes documentation.</summary>
    [JsonPropertyName("dnsPolicy")]
    public string? DnsPolicy { get; set; }

    /// <summary>Whether the pod uses the hosts&apos; network IP address. The default value is true. Setting this to false enables the Kubernetes pod networking model. Most AWS Batch workloads are egress-only and don&apos;t require the overhead of IP allocation for each pod for incoming connections.</summary>
    [JsonPropertyName("hostNetwork")]
    public bool? HostNetwork { get; set; }

    /// <summary>List of Kubernetes secret resources. See image_pull_secret below.</summary>
    [JsonPropertyName("imagePullSecret")]
    public IList<V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesImagePullSecret>? ImagePullSecret { get; set; }

    /// <summary>Containers which run before application containers, always runs to completion, and must complete successfully before the next container starts. These containers are registered with the Amazon EKS Connector agent and persists the registration information in the Kubernetes backend data store. See containers below.</summary>
    [JsonPropertyName("initContainers")]
    public IList<V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesInitContainers>? InitContainers { get; set; }

    /// <summary>Metadata about the Kubernetes pod.</summary>
    [JsonPropertyName("metadata")]
    public V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesMetadata? Metadata { get; set; }

    /// <summary>Name of the service account that&apos;s used to run the pod.</summary>
    [JsonPropertyName("serviceAccountName")]
    public string? ServiceAccountName { get; set; }

    /// <summary>Indicates if the processes in a container are shared, or visible, to other containers in the same pod.</summary>
    [JsonPropertyName("shareProcessNamespace")]
    public bool? ShareProcessNamespace { get; set; }

    /// <summary>Volumes for a job definition that uses Amazon EKS resources. AWS Batch supports emptyDir, hostPath, and secret volume types.</summary>
    [JsonPropertyName("volumes")]
    public IList<V1beta2JobDefinitionStatusAtProviderEksPropertiesPodPropertiesVolumes>? Volumes { get; set; }
}

/// <summary>Valid eks properties. This parameter is only valid if the type parameter is container.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderEksProperties
{
    /// <summary>Properties for the Kubernetes pod resources of a job. See pod_properties below.</summary>
    [JsonPropertyName("podProperties")]
    public V1beta2JobDefinitionStatusAtProviderEksPropertiesPodProperties? PodProperties { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderRetryStrategyEvaluateOnExit
{
    /// <summary>Action to take if all of the specified conditions are met. The values are not case sensitive. Valid values: retry, exit.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Glob pattern to match against the decimal representation of the exit code returned for a job.</summary>
    [JsonPropertyName("onExitCode")]
    public string? OnExitCode { get; set; }

    /// <summary>Glob pattern to match against the reason returned for a job.</summary>
    [JsonPropertyName("onReason")]
    public string? OnReason { get; set; }

    /// <summary>Glob pattern to match against the status reason returned for a job.</summary>
    [JsonPropertyName("onStatusReason")]
    public string? OnStatusReason { get; set; }
}

/// <summary>Retry strategy to use for failed jobs that are submitted with this job definition. Maximum number of retry_strategy is 1.  Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderRetryStrategy
{
    /// <summary>Number of times to move a job to the RUNNABLE status. You may specify between 1 and 10 attempts.</summary>
    [JsonPropertyName("attempts")]
    public double? Attempts { get; set; }

    /// <summary>Evaluate on exit conditions under which the job should be retried or failed. If this parameter is specified, then the attempts parameter must also be specified. You may specify up to 5 configuration blocks.</summary>
    [JsonPropertyName("evaluateOnExit")]
    public IList<V1beta2JobDefinitionStatusAtProviderRetryStrategyEvaluateOnExit>? EvaluateOnExit { get; set; }
}

/// <summary>Timeout for jobs so that if a job runs longer, AWS Batch terminates the job. Maximum number of timeout is 1. Defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProviderTimeout
{
    /// <summary>Time duration in seconds after which AWS Batch terminates your jobs if they have not finished. The minimum value for the timeout is 60 seconds.</summary>
    [JsonPropertyName("attemptDurationSeconds")]
    public double? AttemptDurationSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusAtProvider
{
    /// <summary>ARN of the job definition, includes revision (:#).</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ARN without the revision number.</summary>
    [JsonPropertyName("arnPrefix")]
    public string? ArnPrefix { get; set; }

    /// <summary>Valid container properties provided as a single valid JSON document. This parameter is only valid if the type parameter is container.</summary>
    [JsonPropertyName("containerProperties")]
    public string? ContainerProperties { get; set; }

    /// <summary>When updating a job definition a new revision is created. This parameter determines if the previous version is deregistered (INACTIVE) or left  ACTIVE. Defaults to true.</summary>
    [JsonPropertyName("deregisterOnNewRevision")]
    public bool? DeregisterOnNewRevision { get; set; }

    /// <summary>Valid ECS properties provided as a single valid JSON document. This parameter is only valid if the type parameter is container.</summary>
    [JsonPropertyName("ecsProperties")]
    public string? EcsProperties { get; set; }

    /// <summary>Valid eks properties. This parameter is only valid if the type parameter is container.</summary>
    [JsonPropertyName("eksProperties")]
    public V1beta2JobDefinitionStatusAtProviderEksProperties? EksProperties { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the job definition.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Valid node properties provided as a single valid JSON document. This parameter is required if the type parameter is multinode.</summary>
    [JsonPropertyName("nodeProperties")]
    public string? NodeProperties { get; set; }

    /// <summary>Parameter substitution placeholders to set in the job definition.</summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>Platform capabilities required by the job definition. If no value is specified, it defaults to EC2. To run the job on Fargate resources, specify FARGATE.</summary>
    [JsonPropertyName("platformCapabilities")]
    public IList<string>? PlatformCapabilities { get; set; }

    /// <summary>Whether to propagate the tags from the job definition to the corresponding Amazon ECS task. Default is false.</summary>
    [JsonPropertyName("propagateTags")]
    public bool? PropagateTags { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Retry strategy to use for failed jobs that are submitted with this job definition. Maximum number of retry_strategy is 1.  Defined below.</summary>
    [JsonPropertyName("retryStrategy")]
    public V1beta2JobDefinitionStatusAtProviderRetryStrategy? RetryStrategy { get; set; }

    /// <summary>Revision of the job definition.</summary>
    [JsonPropertyName("revision")]
    public double? Revision { get; set; }

    /// <summary>Scheduling priority of the job definition. This only affects jobs in job queues with a fair share policy. Jobs with a higher scheduling priority are scheduled before jobs with a lower scheduling priority. Allowed values 0 through 9999.</summary>
    [JsonPropertyName("schedulingPriority")]
    public double? SchedulingPriority { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Timeout for jobs so that if a job runs longer, AWS Batch terminates the job. Maximum number of timeout is 1. Defined below.</summary>
    [JsonPropertyName("timeout")]
    public V1beta2JobDefinitionStatusAtProviderTimeout? Timeout { get; set; }

    /// <summary>Type of job definition. Must be container or multinode.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatusConditions
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

/// <summary>JobDefinitionStatus defines the observed state of JobDefinition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2JobDefinitionStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2JobDefinitionStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2JobDefinitionStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>JobDefinition is the Schema for the JobDefinitions API. Provides a Batch Job Definition resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2JobDefinition : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2JobDefinitionSpec>, IStatus<V1beta2JobDefinitionStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "JobDefinition";
    public const string KubeGroup = "batch.aws.upbound.io";
    public const string KubePluralName = "jobdefinitions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "batch.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "JobDefinition";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>JobDefinitionSpec defines the desired state of JobDefinition</summary>
    [JsonPropertyName("spec")]
    public required V1beta2JobDefinitionSpec Spec { get; set; }

    /// <summary>JobDefinitionStatus defines the observed state of JobDefinition.</summary>
    [JsonPropertyName("status")]
    public V1beta2JobDefinitionStatus? Status { get; set; }
}