#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerapp.azure.m.upbound.io;
/// <summary>ContainerJob is the Schema for the ContainerJobs API. Manages a Container App Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ContainerJobList : IKubernetesObject<V1ListMeta>, IItems<V1beta1ContainerJob>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ContainerJobList";
    public const string KubeGroup = "containerapp.azure.m.upbound.io";
    public const string KubePluralName = "containerjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerapp.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ContainerJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1ContainerJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1ContainerJob> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdRefPolicyResolutionEnum>))]
public enum V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdRefPolicyResolveEnum>))]
public enum V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Environment in containerapp to populate containerAppEnvironmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdSelectorPolicyResolveEnum>))]
public enum V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Environment in containerapp to populate containerAppEnvironmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderEventTriggerConfigScaleRulesAuthentication
{
    /// <summary>Name of the Container App secret from which to pull the environment variable value.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Trigger Parameter that uses the secret.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderEventTriggerConfigScaleRules
{
    /// <summary>A authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ContainerJobSpecForProviderEventTriggerConfigScaleRulesAuthentication>? Authentication { get; set; }

    /// <summary>Type of the scale rule. Possible values are activemq, artemis-queue, kafka, pulsar, aws-cloudwatch, aws-dynamodb, aws-dynamodb-streams, aws-kinesis-stream, aws-sqs-queue, azure-app-insights, azure-blob, azure-data-explorer, azure-eventhub, azure-log-analytics, azure-monitor, azure-pipelines, azure-servicebus, azure-queue, cassandra, cpu, cron, datadog, elasticsearch, external, external-push, gcp-stackdriver, gcp-storage, gcp-pubsub, graphite, http, huawei-cloudeye, ibmmq, influxdb, kubernetes-workload, liiklus, memory, metrics-api, mongodb, mssql, mysql, nats-jetstream, stan, tcp, new-relic, openstack-metric, openstack-swift, postgresql, predictkube, prometheus, rabbitmq, redis, redis-cluster, redis-sentinel, redis-streams, redis-cluster-streams, redis-sentinel-streams, selenium-grid, solace-event-queue and github-runner.</summary>
    [JsonPropertyName("customRuleType")]
    public string? CustomRuleType { get; set; }

    /// <summary>Metadata properties to describe the scale rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the volume to mount. This must match the name of a volume defined in the volume block.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderEventTriggerConfigScale
{
    /// <summary>Maximum number of job executions that are created for a trigger.</summary>
    [JsonPropertyName("maxExecutions")]
    public double? MaxExecutions { get; set; }

    /// <summary>Minimum number of job executions that are created for a trigger.</summary>
    [JsonPropertyName("minExecutions")]
    public double? MinExecutions { get; set; }

    /// <summary>Interval to check each event source in seconds.</summary>
    [JsonPropertyName("pollingIntervalInSeconds")]
    public double? PollingIntervalInSeconds { get; set; }

    /// <summary>A rules block as defined below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1ContainerJobSpecForProviderEventTriggerConfigScaleRules>? Rules { get; set; }
}

/// <summary>A event_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderEventTriggerConfig
{
    /// <summary>Number of parallel replicas of a job that can run at a given time.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>Minimum number of successful replica completions before overall job completion.</summary>
    [JsonPropertyName("replicaCompletionCount")]
    public double? ReplicaCompletionCount { get; set; }

    /// <summary>A scale block as defined below.</summary>
    [JsonPropertyName("scale")]
    public IList<V1beta1ContainerJobSpecForProviderEventTriggerConfigScale>? Scale { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecForProviderIdentityIdentityIdsRefsPolicyResolutionEnum>))]
public enum V1beta1ContainerJobSpecForProviderIdentityIdentityIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecForProviderIdentityIdentityIdsRefsPolicyResolveEnum>))]
public enum V1beta1ContainerJobSpecForProviderIdentityIdentityIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderIdentityIdentityIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ContainerJobSpecForProviderIdentityIdentityIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ContainerJobSpecForProviderIdentityIdentityIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderIdentityIdentityIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerJobSpecForProviderIdentityIdentityIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecForProviderIdentityIdentityIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1ContainerJobSpecForProviderIdentityIdentityIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecForProviderIdentityIdentityIdsSelectorPolicyResolveEnum>))]
public enum V1beta1ContainerJobSpecForProviderIdentityIdentityIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderIdentityIdentityIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ContainerJobSpecForProviderIdentityIdentityIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ContainerJobSpecForProviderIdentityIdentityIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderIdentityIdentityIdsSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerJobSpecForProviderIdentityIdentityIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>A identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderIdentity
{
    /// <summary>A list of Managed Identity IDs to assign to the Container App Job.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>References to UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsRefs")]
    public IList<V1beta1ContainerJobSpecForProviderIdentityIdentityIdsRefs>? IdentityIdsRefs { get; set; }

    /// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsSelector")]
    public V1beta1ContainerJobSpecForProviderIdentityIdentityIdsSelector? IdentityIdsSelector { get; set; }

    /// <summary>The type of identity used for the Container App Job. Possible values are SystemAssigned, UserAssigned and None.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A manual_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderManualTriggerConfig
{
    /// <summary>Number of parallel replicas of a job that can run at a given time.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>Minimum number of successful replica completions before overall job completion.</summary>
    [JsonPropertyName("replicaCompletionCount")]
    public double? ReplicaCompletionCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderRegistry
{
    /// <summary>
    /// A Managed Identity to use to authenticate with Azure Container Registry.
    /// ID of the System or User Managed Identity used to pull images from the Container Registry
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>
    /// The name of the Secret that contains the registry login password.
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    [JsonPropertyName("passwordSecretName")]
    public string? PasswordSecretName { get; set; }

    /// <summary>
    /// The URL of the Azure Container Registry server.
    /// The hostname for the Container Registry.
    /// </summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>
    /// The username to use to authenticate with Azure Container Registry.
    /// The username to use for this Container Registry.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecForProviderResourceGroupNameRefPolicyResolutionEnum>))]
public enum V1beta1ContainerJobSpecForProviderResourceGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecForProviderResourceGroupNameRefPolicyResolveEnum>))]
public enum V1beta1ContainerJobSpecForProviderResourceGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderResourceGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ContainerJobSpecForProviderResourceGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ContainerJobSpecForProviderResourceGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderResourceGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerJobSpecForProviderResourceGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta1ContainerJobSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecForProviderResourceGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta1ContainerJobSpecForProviderResourceGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderResourceGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ContainerJobSpecForProviderResourceGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ContainerJobSpecForProviderResourceGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderResourceGroupNameSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerJobSpecForProviderResourceGroupNameSelectorPolicy? Policy { get; set; }
}

/// <summary>A schedule_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderScheduleTriggerConfig
{
    /// <summary>Cron formatted repeating schedule of a Cron Job.</summary>
    [JsonPropertyName("cronExpression")]
    public string? CronExpression { get; set; }

    /// <summary>Number of parallel replicas of a job that can run at a given time.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>Minimum number of successful replica completions before overall job completion.</summary>
    [JsonPropertyName("replicaCompletionCount")]
    public double? ReplicaCompletionCount { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdRefPolicyResolveEnum>))]
public enum V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in keyvault to populate keyVaultSecretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in keyvault to populate keyVaultSecretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The value for this secret.
/// The value for this secret.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderSecretValueSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderSecret
{
    /// <summary>
    /// The identity to use for accessing the Key Vault secret reference. This can either be the Resource ID of a User Assigned Identity, or System for the System Assigned Identity.
    /// The identity to use for accessing key vault reference.
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>
    /// The ID of a Key Vault secret. This can be a versioned or version-less ID.
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>Reference to a Secret in keyvault to populate keyVaultSecretId.</summary>
    [JsonPropertyName("keyVaultSecretIdRef")]
    public V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdRef? KeyVaultSecretIdRef { get; set; }

    /// <summary>Selector for a Secret in keyvault to populate keyVaultSecretId.</summary>
    [JsonPropertyName("keyVaultSecretIdSelector")]
    public V1beta1ContainerJobSpecForProviderSecretKeyVaultSecretIdSelector? KeyVaultSecretIdSelector { get; set; }

    /// <summary>
    /// The secret name.
    /// The secret name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The value for this secret.
    /// </summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ContainerJobSpecForProviderSecretValueSecretRef? ValueSecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderTemplateContainerEnv
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the environment variable for the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Name of the Container App secret from which to pull the environment variable value.
    /// The name of the secret that contains the value for this environment variable.
    /// </summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderTemplateContainerLivenessProbeHeader
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderTemplateContainerLivenessProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 10. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerJobSpecForProviderTemplateContainerLivenessProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `1` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path within the container at which the volume should be mounted. Must not contain :.
    /// The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderTemplateContainerReadinessProbeHeader
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderTemplateContainerReadinessProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 10. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerJobSpecForProviderTemplateContainerReadinessProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path within the container at which the volume should be mounted. Must not contain :.
    /// The URI to use for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The number of consecutive successful responses required to consider this probe as successful. Possible values are between 1 and 10. Defaults to 3.
    /// The number of consecutive successful responses required to consider this probe as successful. Possible values are between `1` and `10`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("successCountThreshold")]
    public double? SuccessCountThreshold { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderTemplateContainerStartupProbeHeader
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderTemplateContainerStartupProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 10. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerJobSpecForProviderTemplateContainerStartupProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path within the container at which the volume should be mounted. Must not contain :.
    /// The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderTemplateContainerVolumeMounts
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the Volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The path within the container at which the volume should be mounted. Must not contain :.
    /// The path in the container at which to mount this volume.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The sub path of the volume to be mounted in the container.
    /// The sub path of the volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderTemplateContainer
{
    /// <summary>
    /// A list of extra arguments to pass to the container.
    /// A list of args to pass to the container.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// </summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>
    /// The amount of vCPU to allocate to the container.
    /// The amount of vCPU to allocate to the container.
    /// </summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ContainerJobSpecForProviderTemplateContainerEnv>? Env { get; set; }

    /// <summary>
    /// The image to use to create the container.
    /// The image to use to create the container.
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>A liveness_probe block as detailed below.</summary>
    [JsonPropertyName("livenessProbe")]
    public IList<V1beta1ContainerJobSpecForProviderTemplateContainerLivenessProbe>? LivenessProbe { get; set; }

    /// <summary>
    /// The amount of memory to allocate to the container.
    /// The amount of memory to allocate to the container.
    /// </summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A readiness_probe block as detailed below.</summary>
    [JsonPropertyName("readinessProbe")]
    public IList<V1beta1ContainerJobSpecForProviderTemplateContainerReadinessProbe>? ReadinessProbe { get; set; }

    /// <summary>A startup_probe block as detailed below.</summary>
    [JsonPropertyName("startupProbe")]
    public IList<V1beta1ContainerJobSpecForProviderTemplateContainerStartupProbe>? StartupProbe { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1ContainerJobSpecForProviderTemplateContainerVolumeMounts>? VolumeMounts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderTemplateInitContainerEnv
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the environment variable for the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Name of the Container App secret from which to pull the environment variable value.
    /// The name of the secret that contains the value for this environment variable.
    /// </summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderTemplateInitContainerVolumeMounts
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the Volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The path within the container at which the volume should be mounted. Must not contain :.
    /// The path in the container at which to mount this volume.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The sub path of the volume to be mounted in the container.
    /// The sub path of the volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderTemplateInitContainer
{
    /// <summary>
    /// A list of extra arguments to pass to the container.
    /// A list of args to pass to the container.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// </summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>
    /// The amount of vCPU to allocate to the container.
    /// The amount of vCPU to allocate to the container.
    /// </summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ContainerJobSpecForProviderTemplateInitContainerEnv>? Env { get; set; }

    /// <summary>
    /// The image to use to create the container.
    /// The image to use to create the container.
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// The amount of memory to allocate to the container.
    /// The amount of memory to allocate to the container.
    /// </summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1ContainerJobSpecForProviderTemplateInitContainerVolumeMounts>? VolumeMounts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderTemplateVolume
{
    /// <summary>
    /// Mount options used while mounting the AzureFile. Must be a comma-separated string e.g. dir_mode=0751,file_mode=0751.
    /// Mount options used while mounting the AzureFile. Must be a comma-separated string.
    /// </summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the volume.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the storage to use for the volume.
    /// The name of the `AzureFile` storage. Required when `storage_type` is `AzureFile`
    /// </summary>
    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }

    /// <summary>
    /// The type of storage to use for the volume. Possible values are AzureFile, EmptyDir, NfsAzureFile and Secret. Defaults to EmptyDir.
    /// The type of storage volume. Possible values include `AzureFile` and `EmptyDir`. Defaults to `EmptyDir`.
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary>A template block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProviderTemplate
{
    /// <summary>A container block as defined below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta1ContainerJobSpecForProviderTemplateContainer>? Container { get; set; }

    /// <summary>A init_container block as defined below.</summary>
    [JsonPropertyName("initContainer")]
    public IList<V1beta1ContainerJobSpecForProviderTemplateInitContainer>? InitContainer { get; set; }

    /// <summary>A volume block as defined below.</summary>
    [JsonPropertyName("volume")]
    public IList<V1beta1ContainerJobSpecForProviderTemplateVolume>? Volume { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecForProvider
{
    /// <summary>The ID of the Container App Environment in which to create the Container App Job. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerAppEnvironmentId")]
    public string? ContainerAppEnvironmentId { get; set; }

    /// <summary>Reference to a Environment in containerapp to populate containerAppEnvironmentId.</summary>
    [JsonPropertyName("containerAppEnvironmentIdRef")]
    public V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdRef? ContainerAppEnvironmentIdRef { get; set; }

    /// <summary>Selector for a Environment in containerapp to populate containerAppEnvironmentId.</summary>
    [JsonPropertyName("containerAppEnvironmentIdSelector")]
    public V1beta1ContainerJobSpecForProviderContainerAppEnvironmentIdSelector? ContainerAppEnvironmentIdSelector { get; set; }

    /// <summary>A event_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventTriggerConfig")]
    public V1beta1ContainerJobSpecForProviderEventTriggerConfig? EventTriggerConfig { get; set; }

    /// <summary>A identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ContainerJobSpecForProviderIdentity? Identity { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A manual_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("manualTriggerConfig")]
    public V1beta1ContainerJobSpecForProviderManualTriggerConfig? ManualTriggerConfig { get; set; }

    /// <summary>One or more registry blocks as defined below.</summary>
    [JsonPropertyName("registry")]
    public IList<V1beta1ContainerJobSpecForProviderRegistry>? Registry { get; set; }

    /// <summary>The maximum number of times a replica is allowed to retry.</summary>
    [JsonPropertyName("replicaRetryLimit")]
    public double? ReplicaRetryLimit { get; set; }

    /// <summary>The maximum number of seconds a replica is allowed to run.</summary>
    [JsonPropertyName("replicaTimeoutInSeconds")]
    public double? ReplicaTimeoutInSeconds { get; set; }

    /// <summary>The name of the resource group in which to create the Container App Job. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>Reference to a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameRef")]
    public V1beta1ContainerJobSpecForProviderResourceGroupNameRef? ResourceGroupNameRef { get; set; }

    /// <summary>Selector for a ResourceGroup in azure to populate resourceGroupName.</summary>
    [JsonPropertyName("resourceGroupNameSelector")]
    public V1beta1ContainerJobSpecForProviderResourceGroupNameSelector? ResourceGroupNameSelector { get; set; }

    /// <summary>A schedule_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scheduleTriggerConfig")]
    public V1beta1ContainerJobSpecForProviderScheduleTriggerConfig? ScheduleTriggerConfig { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1ContainerJobSpecForProviderSecret>? Secret { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A template block as defined below.</summary>
    [JsonPropertyName("template")]
    public V1beta1ContainerJobSpecForProviderTemplate? Template { get; set; }

    /// <summary>The name of the workload profile to use for the Container App Job.</summary>
    [JsonPropertyName("workloadProfileName")]
    public string? WorkloadProfileName { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdRefPolicyResolutionEnum>))]
public enum V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdRefPolicyResolveEnum>))]
public enum V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Environment in containerapp to populate containerAppEnvironmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdSelectorPolicyResolveEnum>))]
public enum V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Environment in containerapp to populate containerAppEnvironmentId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderEventTriggerConfigScaleRulesAuthentication
{
    /// <summary>Name of the Container App secret from which to pull the environment variable value.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Trigger Parameter that uses the secret.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderEventTriggerConfigScaleRules
{
    /// <summary>A authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ContainerJobSpecInitProviderEventTriggerConfigScaleRulesAuthentication>? Authentication { get; set; }

    /// <summary>Type of the scale rule. Possible values are activemq, artemis-queue, kafka, pulsar, aws-cloudwatch, aws-dynamodb, aws-dynamodb-streams, aws-kinesis-stream, aws-sqs-queue, azure-app-insights, azure-blob, azure-data-explorer, azure-eventhub, azure-log-analytics, azure-monitor, azure-pipelines, azure-servicebus, azure-queue, cassandra, cpu, cron, datadog, elasticsearch, external, external-push, gcp-stackdriver, gcp-storage, gcp-pubsub, graphite, http, huawei-cloudeye, ibmmq, influxdb, kubernetes-workload, liiklus, memory, metrics-api, mongodb, mssql, mysql, nats-jetstream, stan, tcp, new-relic, openstack-metric, openstack-swift, postgresql, predictkube, prometheus, rabbitmq, redis, redis-cluster, redis-sentinel, redis-streams, redis-cluster-streams, redis-sentinel-streams, selenium-grid, solace-event-queue and github-runner.</summary>
    [JsonPropertyName("customRuleType")]
    public string? CustomRuleType { get; set; }

    /// <summary>Metadata properties to describe the scale rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the volume to mount. This must match the name of a volume defined in the volume block.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderEventTriggerConfigScale
{
    /// <summary>Maximum number of job executions that are created for a trigger.</summary>
    [JsonPropertyName("maxExecutions")]
    public double? MaxExecutions { get; set; }

    /// <summary>Minimum number of job executions that are created for a trigger.</summary>
    [JsonPropertyName("minExecutions")]
    public double? MinExecutions { get; set; }

    /// <summary>Interval to check each event source in seconds.</summary>
    [JsonPropertyName("pollingIntervalInSeconds")]
    public double? PollingIntervalInSeconds { get; set; }

    /// <summary>A rules block as defined below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1ContainerJobSpecInitProviderEventTriggerConfigScaleRules>? Rules { get; set; }
}

/// <summary>A event_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderEventTriggerConfig
{
    /// <summary>Number of parallel replicas of a job that can run at a given time.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>Minimum number of successful replica completions before overall job completion.</summary>
    [JsonPropertyName("replicaCompletionCount")]
    public double? ReplicaCompletionCount { get; set; }

    /// <summary>A scale block as defined below.</summary>
    [JsonPropertyName("scale")]
    public IList<V1beta1ContainerJobSpecInitProviderEventTriggerConfigScale>? Scale { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsRefsPolicyResolutionEnum>))]
public enum V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsRefsPolicyResolveEnum>))]
public enum V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsSelectorPolicyResolutionEnum>))]
public enum V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsSelectorPolicyResolveEnum>))]
public enum V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsSelectorPolicy? Policy { get; set; }
}

/// <summary>A identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderIdentity
{
    /// <summary>A list of Managed Identity IDs to assign to the Container App Job.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>References to UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsRefs")]
    public IList<V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsRefs>? IdentityIdsRefs { get; set; }

    /// <summary>Selector for a list of UserAssignedIdentity in managedidentity to populate identityIds.</summary>
    [JsonPropertyName("identityIdsSelector")]
    public V1beta1ContainerJobSpecInitProviderIdentityIdentityIdsSelector? IdentityIdsSelector { get; set; }

    /// <summary>The type of identity used for the Container App Job. Possible values are SystemAssigned, UserAssigned and None.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A manual_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderManualTriggerConfig
{
    /// <summary>Number of parallel replicas of a job that can run at a given time.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>Minimum number of successful replica completions before overall job completion.</summary>
    [JsonPropertyName("replicaCompletionCount")]
    public double? ReplicaCompletionCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderRegistry
{
    /// <summary>
    /// A Managed Identity to use to authenticate with Azure Container Registry.
    /// ID of the System or User Managed Identity used to pull images from the Container Registry
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>
    /// The name of the Secret that contains the registry login password.
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    [JsonPropertyName("passwordSecretName")]
    public string? PasswordSecretName { get; set; }

    /// <summary>
    /// The URL of the Azure Container Registry server.
    /// The hostname for the Container Registry.
    /// </summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>
    /// The username to use to authenticate with Azure Container Registry.
    /// The username to use for this Container Registry.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A schedule_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderScheduleTriggerConfig
{
    /// <summary>Cron formatted repeating schedule of a Cron Job.</summary>
    [JsonPropertyName("cronExpression")]
    public string? CronExpression { get; set; }

    /// <summary>Number of parallel replicas of a job that can run at a given time.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>Minimum number of successful replica completions before overall job completion.</summary>
    [JsonPropertyName("replicaCompletionCount")]
    public double? ReplicaCompletionCount { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdRefPolicyResolutionEnum>))]
public enum V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdRefPolicyResolveEnum>))]
public enum V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Secret in keyvault to populate keyVaultSecretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdSelectorPolicyResolutionEnum>))]
public enum V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdSelectorPolicyResolveEnum>))]
public enum V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Secret in keyvault to populate keyVaultSecretId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdSelector
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

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// The value for this secret.
/// The value for this secret.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderSecretValueSecretRef
{
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderSecret
{
    /// <summary>
    /// The identity to use for accessing the Key Vault secret reference. This can either be the Resource ID of a User Assigned Identity, or System for the System Assigned Identity.
    /// The identity to use for accessing key vault reference.
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>
    /// The ID of a Key Vault secret. This can be a versioned or version-less ID.
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>Reference to a Secret in keyvault to populate keyVaultSecretId.</summary>
    [JsonPropertyName("keyVaultSecretIdRef")]
    public V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdRef? KeyVaultSecretIdRef { get; set; }

    /// <summary>Selector for a Secret in keyvault to populate keyVaultSecretId.</summary>
    [JsonPropertyName("keyVaultSecretIdSelector")]
    public V1beta1ContainerJobSpecInitProviderSecretKeyVaultSecretIdSelector? KeyVaultSecretIdSelector { get; set; }

    /// <summary>
    /// The secret name.
    /// The secret name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The value for this secret.
    /// </summary>
    [JsonPropertyName("valueSecretRef")]
    public V1beta1ContainerJobSpecInitProviderSecretValueSecretRef? ValueSecretRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderTemplateContainerEnv
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the environment variable for the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Name of the Container App secret from which to pull the environment variable value.
    /// The name of the secret that contains the value for this environment variable.
    /// </summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderTemplateContainerLivenessProbeHeader
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderTemplateContainerLivenessProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 10. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerJobSpecInitProviderTemplateContainerLivenessProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `1` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path within the container at which the volume should be mounted. Must not contain :.
    /// The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderTemplateContainerReadinessProbeHeader
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderTemplateContainerReadinessProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 10. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerJobSpecInitProviderTemplateContainerReadinessProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path within the container at which the volume should be mounted. Must not contain :.
    /// The URI to use for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The number of consecutive successful responses required to consider this probe as successful. Possible values are between 1 and 10. Defaults to 3.
    /// The number of consecutive successful responses required to consider this probe as successful. Possible values are between `1` and `10`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("successCountThreshold")]
    public double? SuccessCountThreshold { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderTemplateContainerStartupProbeHeader
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderTemplateContainerStartupProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 10. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerJobSpecInitProviderTemplateContainerStartupProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path within the container at which the volume should be mounted. Must not contain :.
    /// The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderTemplateContainerVolumeMounts
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the Volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The path within the container at which the volume should be mounted. Must not contain :.
    /// The path in the container at which to mount this volume.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The sub path of the volume to be mounted in the container.
    /// The sub path of the volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderTemplateContainer
{
    /// <summary>
    /// A list of extra arguments to pass to the container.
    /// A list of args to pass to the container.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// </summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>
    /// The amount of vCPU to allocate to the container.
    /// The amount of vCPU to allocate to the container.
    /// </summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ContainerJobSpecInitProviderTemplateContainerEnv>? Env { get; set; }

    /// <summary>
    /// The image to use to create the container.
    /// The image to use to create the container.
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>A liveness_probe block as detailed below.</summary>
    [JsonPropertyName("livenessProbe")]
    public IList<V1beta1ContainerJobSpecInitProviderTemplateContainerLivenessProbe>? LivenessProbe { get; set; }

    /// <summary>
    /// The amount of memory to allocate to the container.
    /// The amount of memory to allocate to the container.
    /// </summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A readiness_probe block as detailed below.</summary>
    [JsonPropertyName("readinessProbe")]
    public IList<V1beta1ContainerJobSpecInitProviderTemplateContainerReadinessProbe>? ReadinessProbe { get; set; }

    /// <summary>A startup_probe block as detailed below.</summary>
    [JsonPropertyName("startupProbe")]
    public IList<V1beta1ContainerJobSpecInitProviderTemplateContainerStartupProbe>? StartupProbe { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1ContainerJobSpecInitProviderTemplateContainerVolumeMounts>? VolumeMounts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderTemplateInitContainerEnv
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the environment variable for the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Name of the Container App secret from which to pull the environment variable value.
    /// The name of the secret that contains the value for this environment variable.
    /// </summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderTemplateInitContainerVolumeMounts
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the Volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The path within the container at which the volume should be mounted. Must not contain :.
    /// The path in the container at which to mount this volume.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The sub path of the volume to be mounted in the container.
    /// The sub path of the volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderTemplateInitContainer
{
    /// <summary>
    /// A list of extra arguments to pass to the container.
    /// A list of args to pass to the container.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// </summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>
    /// The amount of vCPU to allocate to the container.
    /// The amount of vCPU to allocate to the container.
    /// </summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ContainerJobSpecInitProviderTemplateInitContainerEnv>? Env { get; set; }

    /// <summary>
    /// The image to use to create the container.
    /// The image to use to create the container.
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// The amount of memory to allocate to the container.
    /// The amount of memory to allocate to the container.
    /// </summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1ContainerJobSpecInitProviderTemplateInitContainerVolumeMounts>? VolumeMounts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderTemplateVolume
{
    /// <summary>
    /// Mount options used while mounting the AzureFile. Must be a comma-separated string e.g. dir_mode=0751,file_mode=0751.
    /// Mount options used while mounting the AzureFile. Must be a comma-separated string.
    /// </summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the volume.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the storage to use for the volume.
    /// The name of the `AzureFile` storage. Required when `storage_type` is `AzureFile`
    /// </summary>
    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }

    /// <summary>
    /// The type of storage to use for the volume. Possible values are AzureFile, EmptyDir, NfsAzureFile and Secret. Defaults to EmptyDir.
    /// The type of storage volume. Possible values include `AzureFile` and `EmptyDir`. Defaults to `EmptyDir`.
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary>A template block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecInitProviderTemplate
{
    /// <summary>A container block as defined below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta1ContainerJobSpecInitProviderTemplateContainer>? Container { get; set; }

    /// <summary>A init_container block as defined below.</summary>
    [JsonPropertyName("initContainer")]
    public IList<V1beta1ContainerJobSpecInitProviderTemplateInitContainer>? InitContainer { get; set; }

    /// <summary>A volume block as defined below.</summary>
    [JsonPropertyName("volume")]
    public IList<V1beta1ContainerJobSpecInitProviderTemplateVolume>? Volume { get; set; }
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
public partial class V1beta1ContainerJobSpecInitProvider
{
    /// <summary>The ID of the Container App Environment in which to create the Container App Job. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerAppEnvironmentId")]
    public string? ContainerAppEnvironmentId { get; set; }

    /// <summary>Reference to a Environment in containerapp to populate containerAppEnvironmentId.</summary>
    [JsonPropertyName("containerAppEnvironmentIdRef")]
    public V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdRef? ContainerAppEnvironmentIdRef { get; set; }

    /// <summary>Selector for a Environment in containerapp to populate containerAppEnvironmentId.</summary>
    [JsonPropertyName("containerAppEnvironmentIdSelector")]
    public V1beta1ContainerJobSpecInitProviderContainerAppEnvironmentIdSelector? ContainerAppEnvironmentIdSelector { get; set; }

    /// <summary>A event_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventTriggerConfig")]
    public V1beta1ContainerJobSpecInitProviderEventTriggerConfig? EventTriggerConfig { get; set; }

    /// <summary>A identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ContainerJobSpecInitProviderIdentity? Identity { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A manual_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("manualTriggerConfig")]
    public V1beta1ContainerJobSpecInitProviderManualTriggerConfig? ManualTriggerConfig { get; set; }

    /// <summary>One or more registry blocks as defined below.</summary>
    [JsonPropertyName("registry")]
    public IList<V1beta1ContainerJobSpecInitProviderRegistry>? Registry { get; set; }

    /// <summary>The maximum number of times a replica is allowed to retry.</summary>
    [JsonPropertyName("replicaRetryLimit")]
    public double? ReplicaRetryLimit { get; set; }

    /// <summary>The maximum number of seconds a replica is allowed to run.</summary>
    [JsonPropertyName("replicaTimeoutInSeconds")]
    public double? ReplicaTimeoutInSeconds { get; set; }

    /// <summary>A schedule_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scheduleTriggerConfig")]
    public V1beta1ContainerJobSpecInitProviderScheduleTriggerConfig? ScheduleTriggerConfig { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1ContainerJobSpecInitProviderSecret>? Secret { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A template block as defined below.</summary>
    [JsonPropertyName("template")]
    public V1beta1ContainerJobSpecInitProviderTemplate? Template { get; set; }

    /// <summary>The name of the workload profile to use for the Container App Job.</summary>
    [JsonPropertyName("workloadProfileName")]
    public string? WorkloadProfileName { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ContainerJobSpecManagementPoliciesEnum>))]
public enum V1beta1ContainerJobSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecProviderConfigRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ContainerJobSpec defines the desired state of ContainerJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1ContainerJobSpecForProvider ForProvider { get; set; }

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
    public V1beta1ContainerJobSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ContainerJobSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ContainerJobSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ContainerJobSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderEventTriggerConfigScaleRulesAuthentication
{
    /// <summary>Name of the Container App secret from which to pull the environment variable value.</summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>Trigger Parameter that uses the secret.</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderEventTriggerConfigScaleRules
{
    /// <summary>A authentication block as defined below.</summary>
    [JsonPropertyName("authentication")]
    public IList<V1beta1ContainerJobStatusAtProviderEventTriggerConfigScaleRulesAuthentication>? Authentication { get; set; }

    /// <summary>Type of the scale rule. Possible values are activemq, artemis-queue, kafka, pulsar, aws-cloudwatch, aws-dynamodb, aws-dynamodb-streams, aws-kinesis-stream, aws-sqs-queue, azure-app-insights, azure-blob, azure-data-explorer, azure-eventhub, azure-log-analytics, azure-monitor, azure-pipelines, azure-servicebus, azure-queue, cassandra, cpu, cron, datadog, elasticsearch, external, external-push, gcp-stackdriver, gcp-storage, gcp-pubsub, graphite, http, huawei-cloudeye, ibmmq, influxdb, kubernetes-workload, liiklus, memory, metrics-api, mongodb, mssql, mysql, nats-jetstream, stan, tcp, new-relic, openstack-metric, openstack-swift, postgresql, predictkube, prometheus, rabbitmq, redis, redis-cluster, redis-sentinel, redis-streams, redis-cluster-streams, redis-sentinel-streams, selenium-grid, solace-event-queue and github-runner.</summary>
    [JsonPropertyName("customRuleType")]
    public string? CustomRuleType { get; set; }

    /// <summary>Metadata properties to describe the scale rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, string>? Metadata { get; set; }

    /// <summary>The name of the volume to mount. This must match the name of a volume defined in the volume block.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderEventTriggerConfigScale
{
    /// <summary>Maximum number of job executions that are created for a trigger.</summary>
    [JsonPropertyName("maxExecutions")]
    public double? MaxExecutions { get; set; }

    /// <summary>Minimum number of job executions that are created for a trigger.</summary>
    [JsonPropertyName("minExecutions")]
    public double? MinExecutions { get; set; }

    /// <summary>Interval to check each event source in seconds.</summary>
    [JsonPropertyName("pollingIntervalInSeconds")]
    public double? PollingIntervalInSeconds { get; set; }

    /// <summary>A rules block as defined below.</summary>
    [JsonPropertyName("rules")]
    public IList<V1beta1ContainerJobStatusAtProviderEventTriggerConfigScaleRules>? Rules { get; set; }
}

/// <summary>A event_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderEventTriggerConfig
{
    /// <summary>Number of parallel replicas of a job that can run at a given time.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>Minimum number of successful replica completions before overall job completion.</summary>
    [JsonPropertyName("replicaCompletionCount")]
    public double? ReplicaCompletionCount { get; set; }

    /// <summary>A scale block as defined below.</summary>
    [JsonPropertyName("scale")]
    public IList<V1beta1ContainerJobStatusAtProviderEventTriggerConfigScale>? Scale { get; set; }
}

/// <summary>A identity block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderIdentity
{
    /// <summary>A list of Managed Identity IDs to assign to the Container App Job.</summary>
    [JsonPropertyName("identityIds")]
    public IList<string>? IdentityIds { get; set; }

    /// <summary>The Principal ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>The Tenant ID associated with this Managed Service Identity.</summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>The type of identity used for the Container App Job. Possible values are SystemAssigned, UserAssigned and None.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>A manual_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderManualTriggerConfig
{
    /// <summary>Number of parallel replicas of a job that can run at a given time.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>Minimum number of successful replica completions before overall job completion.</summary>
    [JsonPropertyName("replicaCompletionCount")]
    public double? ReplicaCompletionCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderRegistry
{
    /// <summary>
    /// A Managed Identity to use to authenticate with Azure Container Registry.
    /// ID of the System or User Managed Identity used to pull images from the Container Registry
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>
    /// The name of the Secret that contains the registry login password.
    /// The name of the Secret Reference containing the password value for this user on the Container Registry.
    /// </summary>
    [JsonPropertyName("passwordSecretName")]
    public string? PasswordSecretName { get; set; }

    /// <summary>
    /// The URL of the Azure Container Registry server.
    /// The hostname for the Container Registry.
    /// </summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>
    /// The username to use to authenticate with Azure Container Registry.
    /// The username to use for this Container Registry.
    /// </summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>A schedule_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderScheduleTriggerConfig
{
    /// <summary>Cron formatted repeating schedule of a Cron Job.</summary>
    [JsonPropertyName("cronExpression")]
    public string? CronExpression { get; set; }

    /// <summary>Number of parallel replicas of a job that can run at a given time.</summary>
    [JsonPropertyName("parallelism")]
    public double? Parallelism { get; set; }

    /// <summary>Minimum number of successful replica completions before overall job completion.</summary>
    [JsonPropertyName("replicaCompletionCount")]
    public double? ReplicaCompletionCount { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderSecret
{
    /// <summary>
    /// The identity to use for accessing the Key Vault secret reference. This can either be the Resource ID of a User Assigned Identity, or System for the System Assigned Identity.
    /// The identity to use for accessing key vault reference.
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>
    /// The ID of a Key Vault secret. This can be a versioned or version-less ID.
    /// The Key Vault Secret ID. Could be either one of `id` or `versionless_id`.
    /// </summary>
    [JsonPropertyName("keyVaultSecretId")]
    public string? KeyVaultSecretId { get; set; }

    /// <summary>
    /// The secret name.
    /// The secret name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderTemplateContainerEnv
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the environment variable for the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Name of the Container App secret from which to pull the environment variable value.
    /// The name of the secret that contains the value for this environment variable.
    /// </summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderTemplateContainerLivenessProbeHeader
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderTemplateContainerLivenessProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 10. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerJobStatusAtProviderTemplateContainerLivenessProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `1` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path within the container at which the volume should be mounted. Must not contain :.
    /// The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The time in seconds after the container is sent the termination signal before the process if forcibly killed.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public double? TerminationGracePeriodSeconds { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderTemplateContainerReadinessProbeHeader
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderTemplateContainerReadinessProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 10. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerJobStatusAtProviderTemplateContainerReadinessProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path within the container at which the volume should be mounted. Must not contain :.
    /// The URI to use for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>
    /// The number of consecutive successful responses required to consider this probe as successful. Possible values are between 1 and 10. Defaults to 3.
    /// The number of consecutive successful responses required to consider this probe as successful. Possible values are between `1` and `10`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("successCountThreshold")]
    public double? SuccessCountThreshold { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderTemplateContainerStartupProbeHeader
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The HTTP Header Name.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The HTTP Header value.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderTemplateContainerStartupProbe
{
    /// <summary>
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between 1 and 10. Defaults to 3.
    /// The number of consecutive failures required to consider this probe as failed. Possible values are between `1` and `30`. Defaults to `3`.
    /// </summary>
    [JsonPropertyName("failureCountThreshold")]
    public double? FailureCountThreshold { get; set; }

    /// <summary>A header block as detailed below.</summary>
    [JsonPropertyName("header")]
    public IList<V1beta1ContainerJobStatusAtProviderTemplateContainerStartupProbeHeader>? Header { get; set; }

    /// <summary>
    /// The value for the host header which should be sent with this probe. If unspecified, the IP Address of the Pod is used as the host header. Setting a value for Host in headers can be used to override this for HTTP and HTTPS type probes.
    /// The probe hostname. Defaults to the pod IP address. Setting a value for `Host` in `headers` can be used to override this for `http` and `https` type probes.
    /// </summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between 0 and 60. Defaults to 0 seconds.
    /// The number of seconds elapsed after the container has started before the probe is initiated. Possible values are between `0` and `60`. Defaults to `0` seconds.
    /// </summary>
    [JsonPropertyName("initialDelay")]
    public double? InitialDelay { get; set; }

    /// <summary>
    /// How often, in seconds, the probe should run. Possible values are between 1 and 240. Defaults to 10
    /// How often, in seconds, the probe should run. Possible values are between `1` and `240`. Defaults to `10`
    /// </summary>
    [JsonPropertyName("intervalSeconds")]
    public double? IntervalSeconds { get; set; }

    /// <summary>
    /// The path within the container at which the volume should be mounted. Must not contain :.
    /// The URI to use with the `host` for http type probes. Not valid for `TCP` type probes. Defaults to `/`.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The port number on which to connect. Possible values are between 1 and 65535.
    /// The port number on which to connect. Possible values are between `1` and `65535`.
    /// </summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>The time in seconds after the container is sent the termination signal before the process if forcibly killed.</summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public double? TerminationGracePeriodSeconds { get; set; }

    /// <summary>
    /// Time in seconds after which the probe times out. Possible values are in the range 1 - 240. Defaults to 1.
    /// Time in seconds after which the probe times out. Possible values are between `1` an `240`. Defaults to `1`.
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Type of probe. Possible values are TCP, HTTP, and HTTPS.
    /// Type of probe. Possible values are `TCP`, `HTTP`, and `HTTPS`.
    /// </summary>
    [JsonPropertyName("transport")]
    public string? Transport { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderTemplateContainerVolumeMounts
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the Volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The path within the container at which the volume should be mounted. Must not contain :.
    /// The path in the container at which to mount this volume.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The sub path of the volume to be mounted in the container.
    /// The sub path of the volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderTemplateContainer
{
    /// <summary>
    /// A list of extra arguments to pass to the container.
    /// A list of args to pass to the container.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// </summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>
    /// The amount of vCPU to allocate to the container.
    /// The amount of vCPU to allocate to the container.
    /// </summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ContainerJobStatusAtProviderTemplateContainerEnv>? Env { get; set; }

    /// <summary>
    /// The amount of ephemeral storage available to the Container App.
    /// The amount of ephemeral storage available to the Container App.
    /// </summary>
    [JsonPropertyName("ephemeralStorage")]
    public string? EphemeralStorage { get; set; }

    /// <summary>
    /// The image to use to create the container.
    /// The image to use to create the container.
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>A liveness_probe block as detailed below.</summary>
    [JsonPropertyName("livenessProbe")]
    public IList<V1beta1ContainerJobStatusAtProviderTemplateContainerLivenessProbe>? LivenessProbe { get; set; }

    /// <summary>
    /// The amount of memory to allocate to the container.
    /// The amount of memory to allocate to the container.
    /// </summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A readiness_probe block as detailed below.</summary>
    [JsonPropertyName("readinessProbe")]
    public IList<V1beta1ContainerJobStatusAtProviderTemplateContainerReadinessProbe>? ReadinessProbe { get; set; }

    /// <summary>A startup_probe block as detailed below.</summary>
    [JsonPropertyName("startupProbe")]
    public IList<V1beta1ContainerJobStatusAtProviderTemplateContainerStartupProbe>? StartupProbe { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1ContainerJobStatusAtProviderTemplateContainerVolumeMounts>? VolumeMounts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderTemplateInitContainerEnv
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the environment variable for the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Name of the Container App secret from which to pull the environment variable value.
    /// The name of the secret that contains the value for this environment variable.
    /// </summary>
    [JsonPropertyName("secretName")]
    public string? SecretName { get; set; }

    /// <summary>
    /// The value for this secret.
    /// The value for this environment variable. **NOTE:** This value is ignored if `secret_name` is used
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderTemplateInitContainerVolumeMounts
{
    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the Volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The path within the container at which the volume should be mounted. Must not contain :.
    /// The path in the container at which to mount this volume.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The sub path of the volume to be mounted in the container.
    /// The sub path of the volume to be mounted in the container.
    /// </summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderTemplateInitContainer
{
    /// <summary>
    /// A list of extra arguments to pass to the container.
    /// A list of args to pass to the container.
    /// </summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// A command to pass to the container to override the default. This is provided as a list of command line elements without spaces.
    /// </summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>
    /// The amount of vCPU to allocate to the container.
    /// The amount of vCPU to allocate to the container.
    /// </summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>One or more env blocks as detailed below.</summary>
    [JsonPropertyName("env")]
    public IList<V1beta1ContainerJobStatusAtProviderTemplateInitContainerEnv>? Env { get; set; }

    /// <summary>
    /// The amount of ephemeral storage available to the Container App.
    /// The amount of ephemeral storage available to the Container App.
    /// </summary>
    [JsonPropertyName("ephemeralStorage")]
    public string? EphemeralStorage { get; set; }

    /// <summary>
    /// The image to use to create the container.
    /// The image to use to create the container.
    /// </summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// The amount of memory to allocate to the container.
    /// The amount of memory to allocate to the container.
    /// </summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }

    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the container.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>A volume_mounts block as detailed below.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V1beta1ContainerJobStatusAtProviderTemplateInitContainerVolumeMounts>? VolumeMounts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderTemplateVolume
{
    /// <summary>
    /// Mount options used while mounting the AzureFile. Must be a comma-separated string e.g. dir_mode=0751,file_mode=0751.
    /// Mount options used while mounting the AzureFile. Must be a comma-separated string.
    /// </summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>
    /// The name of the volume to mount. This must match the name of a volume defined in the volume block.
    /// The name of the volume.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The name of the storage to use for the volume.
    /// The name of the `AzureFile` storage. Required when `storage_type` is `AzureFile`
    /// </summary>
    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }

    /// <summary>
    /// The type of storage to use for the volume. Possible values are AzureFile, EmptyDir, NfsAzureFile and Secret. Defaults to EmptyDir.
    /// The type of storage volume. Possible values include `AzureFile` and `EmptyDir`. Defaults to `EmptyDir`.
    /// </summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary>A template block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProviderTemplate
{
    /// <summary>A container block as defined below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta1ContainerJobStatusAtProviderTemplateContainer>? Container { get; set; }

    /// <summary>A init_container block as defined below.</summary>
    [JsonPropertyName("initContainer")]
    public IList<V1beta1ContainerJobStatusAtProviderTemplateInitContainer>? InitContainer { get; set; }

    /// <summary>A volume block as defined below.</summary>
    [JsonPropertyName("volume")]
    public IList<V1beta1ContainerJobStatusAtProviderTemplateVolume>? Volume { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusAtProvider
{
    /// <summary>The ID of the Container App Environment in which to create the Container App Job. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("containerAppEnvironmentId")]
    public string? ContainerAppEnvironmentId { get; set; }

    /// <summary>The endpoint for the Container App Job event stream.</summary>
    [JsonPropertyName("eventStreamEndpoint")]
    public string? EventStreamEndpoint { get; set; }

    /// <summary>A event_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("eventTriggerConfig")]
    public V1beta1ContainerJobStatusAtProviderEventTriggerConfig? EventTriggerConfig { get; set; }

    /// <summary>The ID of the Container App Job.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A identity block as defined below.</summary>
    [JsonPropertyName("identity")]
    public V1beta1ContainerJobStatusAtProviderIdentity? Identity { get; set; }

    /// <summary>Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>A manual_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("manualTriggerConfig")]
    public V1beta1ContainerJobStatusAtProviderManualTriggerConfig? ManualTriggerConfig { get; set; }

    /// <summary>A list of the Public IP Addresses which the Container App uses for outbound network access.</summary>
    [JsonPropertyName("outboundIpAddresses")]
    public IList<string>? OutboundIpAddresses { get; set; }

    /// <summary>One or more registry blocks as defined below.</summary>
    [JsonPropertyName("registry")]
    public IList<V1beta1ContainerJobStatusAtProviderRegistry>? Registry { get; set; }

    /// <summary>The maximum number of times a replica is allowed to retry.</summary>
    [JsonPropertyName("replicaRetryLimit")]
    public double? ReplicaRetryLimit { get; set; }

    /// <summary>The maximum number of seconds a replica is allowed to run.</summary>
    [JsonPropertyName("replicaTimeoutInSeconds")]
    public double? ReplicaTimeoutInSeconds { get; set; }

    /// <summary>The name of the resource group in which to create the Container App Job. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("resourceGroupName")]
    public string? ResourceGroupName { get; set; }

    /// <summary>A schedule_trigger_config block as defined below. Changing this forces a new resource to be created.</summary>
    [JsonPropertyName("scheduleTriggerConfig")]
    public V1beta1ContainerJobStatusAtProviderScheduleTriggerConfig? ScheduleTriggerConfig { get; set; }

    /// <summary>One or more secret blocks as defined below.</summary>
    [JsonPropertyName("secret")]
    public IList<V1beta1ContainerJobStatusAtProviderSecret>? Secret { get; set; }

    /// <summary>A mapping of tags to assign to the resource.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A template block as defined below.</summary>
    [JsonPropertyName("template")]
    public V1beta1ContainerJobStatusAtProviderTemplate? Template { get; set; }

    /// <summary>The name of the workload profile to use for the Container App Job.</summary>
    [JsonPropertyName("workloadProfileName")]
    public string? WorkloadProfileName { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatusConditions
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

/// <summary>ContainerJobStatus defines the observed state of ContainerJob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ContainerJobStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ContainerJobStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ContainerJobStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ContainerJob is the Schema for the ContainerJobs API. Manages a Container App Job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ContainerJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ContainerJobSpec>, IStatus<V1beta1ContainerJobStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ContainerJob";
    public const string KubeGroup = "containerapp.azure.m.upbound.io";
    public const string KubePluralName = "containerjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerapp.azure.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ContainerJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ContainerJobSpec defines the desired state of ContainerJob</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ContainerJobSpec Spec { get; set; }

    /// <summary>ContainerJobStatus defines the observed state of ContainerJob.</summary>
    [JsonPropertyName("status")]
    public V1beta1ContainerJobStatus? Status { get; set; }
}