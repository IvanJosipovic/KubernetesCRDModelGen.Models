#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.app.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /app/resource-manager/Microsoft.App/ContainerApps/stable/2024-03-01/Jobs.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240301JobList : IKubernetesObject<V1ListMeta>, IItems<V20240301Job>
{
    public const string KubeApiVersion = "v20240301";
    public const string KubeKind = "JobList";
    public const string KubeGroup = "app.azure.com";
    public const string KubePluralName = "jobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "app.azure.com/v20240301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "JobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20240301Job objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20240301Job> Items { get; set; }
}

/// <summary>Auth Secrets for Scale Rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecConfigurationEventTriggerConfigScaleRulesAuth
{
    /// <summary>SecretRef: Name of the secret from which to pull the auth params.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>TriggerParameter: Trigger Parameter that uses the secret</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary>Scaling rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecConfigurationEventTriggerConfigScaleRules
{
    /// <summary>Auth: Authentication secrets for the scale rule.</summary>
    [JsonPropertyName("auth")]
    public IList<V20240301JobSpecConfigurationEventTriggerConfigScaleRulesAuth>? Auth { get; set; }

    /// <summary>Metadata: Metadata properties to describe the scale rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, JsonNode>? Metadata { get; set; }

    /// <summary>Name: Scale Rule Name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Type: Type of the scale rule
    /// eg: azure-servicebus, redis etc.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Scale: Scaling configurations for event driven jobs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecConfigurationEventTriggerConfigScale
{
    /// <summary>MaxExecutions: Maximum number of job executions that are created for a trigger, default 100.</summary>
    [JsonPropertyName("maxExecutions")]
    public int? MaxExecutions { get; set; }

    /// <summary>MinExecutions: Minimum number of job executions that are created for a trigger, default 0</summary>
    [JsonPropertyName("minExecutions")]
    public int? MinExecutions { get; set; }

    [JsonPropertyName("pollingInterval")]
    public int? PollingInterval { get; set; }

    /// <summary>Rules: Scaling rules.</summary>
    [JsonPropertyName("rules")]
    public IList<V20240301JobSpecConfigurationEventTriggerConfigScaleRules>? Rules { get; set; }
}

/// <summary>EventTriggerConfig: Trigger configuration of an event driven job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecConfigurationEventTriggerConfig
{
    [JsonPropertyName("parallelism")]
    public int? Parallelism { get; set; }

    [JsonPropertyName("replicaCompletionCount")]
    public int? ReplicaCompletionCount { get; set; }

    /// <summary>Scale: Scaling configurations for event driven jobs.</summary>
    [JsonPropertyName("scale")]
    public V20240301JobSpecConfigurationEventTriggerConfigScale? Scale { get; set; }
}

/// <summary>
/// ManualTriggerConfig: Manual trigger configuration for a single execution job. Properties replicaCompletionCount and
/// parallelism would be set to 1 by default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecConfigurationManualTriggerConfig
{
    [JsonPropertyName("parallelism")]
    public int? Parallelism { get; set; }

    [JsonPropertyName("replicaCompletionCount")]
    public int? ReplicaCompletionCount { get; set; }
}

/// <summary>
/// IdentityReference: A Managed Identity to use to authenticate with Azure Container Registry. For user-assigned
/// identities, use the full user-assigned identity Resource ID. For system-assigned identities, use &apos;system&apos;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecConfigurationRegistriesIdentityReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("wellKnownName")]
    public string? WellKnownName { get; set; }
}

/// <summary>Container App Private Registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecConfigurationRegistries
{
    /// <summary>
    /// IdentityReference: A Managed Identity to use to authenticate with Azure Container Registry. For user-assigned
    /// identities, use the full user-assigned identity Resource ID. For system-assigned identities, use &apos;system&apos;
    /// </summary>
    [JsonPropertyName("identityReference")]
    public V20240301JobSpecConfigurationRegistriesIdentityReference? IdentityReference { get; set; }

    /// <summary>PasswordSecretRef: The name of the Secret that contains the registry login password</summary>
    [JsonPropertyName("passwordSecretRef")]
    public string? PasswordSecretRef { get; set; }

    /// <summary>Server: Container Registry Server</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>Username: Container Registry Username</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// ScheduleTriggerConfig: Cron formatted repeating trigger schedule (&quot;* * * * *&quot;) for cronjobs. Properties completions and
/// parallelism would be set to 1 by default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecConfigurationScheduleTriggerConfig
{
    /// <summary>CronExpression: Cron formatted repeating schedule (&quot;* * * * *&quot;) of a Cron Job.</summary>
    [JsonPropertyName("cronExpression")]
    public required string CronExpression { get; set; }

    [JsonPropertyName("parallelism")]
    public int? Parallelism { get; set; }

    [JsonPropertyName("replicaCompletionCount")]
    public int? ReplicaCompletionCount { get; set; }
}

/// <summary>
/// IdentityReference: Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a
/// system-assigned identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecConfigurationSecretsIdentityReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("wellKnownName")]
    public string? WellKnownName { get; set; }
}

/// <summary>Value: Secret Value.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecConfigurationSecretsValue
{
    /// <summary>Key is the key in the Kubernetes secret being referenced</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes secret being referenced.
    /// The secret must be in the same namespace as the resource
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>Secret definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecConfigurationSecrets
{
    /// <summary>
    /// IdentityReference: Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a
    /// system-assigned identity.
    /// </summary>
    [JsonPropertyName("identityReference")]
    public V20240301JobSpecConfigurationSecretsIdentityReference? IdentityReference { get; set; }

    /// <summary>KeyVaultUrl: Azure Key Vault URL pointing to the secret referenced by the container app.</summary>
    [JsonPropertyName("keyVaultUrl")]
    public string? KeyVaultUrl { get; set; }

    /// <summary>Name: Secret Name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: Secret Value.</summary>
    [JsonPropertyName("value")]
    public V20240301JobSpecConfigurationSecretsValue? Value { get; set; }
}

/// <summary>TriggerType: Trigger type of the job</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301JobSpecConfigurationTriggerTypeEnum>))]
public enum V20240301JobSpecConfigurationTriggerTypeEnum
{
    [EnumMember(Value = "Event"), JsonStringEnumMemberName("Event")]
    Event,
    [EnumMember(Value = "Manual"), JsonStringEnumMemberName("Manual")]
    Manual,
    [EnumMember(Value = "Schedule"), JsonStringEnumMemberName("Schedule")]
    Schedule
}

/// <summary>Configuration: Container Apps Job configuration properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecConfiguration
{
    /// <summary>EventTriggerConfig: Trigger configuration of an event driven job.</summary>
    [JsonPropertyName("eventTriggerConfig")]
    public V20240301JobSpecConfigurationEventTriggerConfig? EventTriggerConfig { get; set; }

    /// <summary>
    /// ManualTriggerConfig: Manual trigger configuration for a single execution job. Properties replicaCompletionCount and
    /// parallelism would be set to 1 by default
    /// </summary>
    [JsonPropertyName("manualTriggerConfig")]
    public V20240301JobSpecConfigurationManualTriggerConfig? ManualTriggerConfig { get; set; }

    /// <summary>Registries: Collection of private container registry credentials used by a Container apps job</summary>
    [JsonPropertyName("registries")]
    public IList<V20240301JobSpecConfigurationRegistries>? Registries { get; set; }

    /// <summary>ReplicaRetryLimit: Maximum number of retries before failing the job.</summary>
    [JsonPropertyName("replicaRetryLimit")]
    public int? ReplicaRetryLimit { get; set; }

    /// <summary>ReplicaTimeout: Maximum number of seconds a replica is allowed to run.</summary>
    [JsonPropertyName("replicaTimeout")]
    public required int ReplicaTimeout { get; set; }

    /// <summary>
    /// ScheduleTriggerConfig: Cron formatted repeating trigger schedule (&quot;* * * * *&quot;) for cronjobs. Properties completions and
    /// parallelism would be set to 1 by default
    /// </summary>
    [JsonPropertyName("scheduleTriggerConfig")]
    public V20240301JobSpecConfigurationScheduleTriggerConfig? ScheduleTriggerConfig { get; set; }

    /// <summary>Secrets: Collection of secrets used by a Container Apps Job</summary>
    [JsonPropertyName("secrets")]
    public IList<V20240301JobSpecConfigurationSecrets>? Secrets { get; set; }

    /// <summary>TriggerType: Trigger type of the job</summary>
    [JsonPropertyName("triggerType")]
    public required V20240301JobSpecConfigurationTriggerTypeEnum TriggerType { get; set; }
}

/// <summary>EnvironmentReference: Resource ID of environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecEnvironmentReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301JobSpecIdentityTypeEnum>))]
public enum V20240301JobSpecIdentityTypeEnum
{
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "SystemAssigned"), JsonStringEnumMemberName("SystemAssigned")]
    SystemAssigned,
    [EnumMember(Value = "SystemAssigned,UserAssigned"), JsonStringEnumMemberName("SystemAssigned,UserAssigned")]
    SystemAssignedUserAssigned,
    [EnumMember(Value = "UserAssigned"), JsonStringEnumMemberName("UserAssigned")]
    UserAssigned
}

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecIdentityUserAssignedIdentitiesReference
{
    /// <summary>
    /// ARMID is a string of the form /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}.
    /// The /resourcegroups/{resourceGroupName} bit is optional as some resources are scoped at the subscription level
    /// ARMID is mutually exclusive with Group, Kind, Namespace and Name.
    /// </summary>
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>Group is the Kubernetes group of the resource.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Kind is the Kubernetes kind of the resource.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Name is the Kubernetes name of the resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Information about the user assigned identity for the resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecIdentityUserAssignedIdentities
{
    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20240301JobSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Identity: Managed identities needed by a container app job to interact with other Azure services to not maintain any
/// secrets or credentials in code.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecIdentity
{
    /// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
    [JsonPropertyName("type")]
    public required V20240301JobSpecIdentityTypeEnum Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20240301JobSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20240301JobSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20240301JobSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Container App container environment variable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecTemplateContainersEnv
{
    /// <summary>Name: Environment variable name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SecretRef: Name of the Container App secret from which to pull the environment variable value.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>Value: Non-secret environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecTemplateContainersProbesHttpGetHttpHeaders
{
    /// <summary>Name: The header field name</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Value: The header field value</summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>Scheme: Scheme to use for connecting to the host. Defaults to HTTP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301JobSpecTemplateContainersProbesHttpGetSchemeEnum>))]
public enum V20240301JobSpecTemplateContainersProbesHttpGetSchemeEnum
{
    [EnumMember(Value = "HTTP"), JsonStringEnumMemberName("HTTP")]
    HTTP,
    [EnumMember(Value = "HTTPS"), JsonStringEnumMemberName("HTTPS")]
    HTTPS
}

/// <summary>HttpGet: HTTPGet specifies the http request to perform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecTemplateContainersProbesHttpGet
{
    /// <summary>Host: Host name to connect to, defaults to the pod IP. You probably want to set &quot;Host&quot; in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>HttpHeaders: Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V20240301JobSpecTemplateContainersProbesHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path: Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Port: Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an
    /// IANA_SVC_NAME.
    /// </summary>
    [JsonPropertyName("port")]
    public required int Port { get; set; }

    /// <summary>Scheme: Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public V20240301JobSpecTemplateContainersProbesHttpGetSchemeEnum? Scheme { get; set; }
}

/// <summary>TcpSocket: TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecTemplateContainersProbesTcpSocket
{
    /// <summary>Host: Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// Port: Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an
    /// IANA_SVC_NAME.
    /// </summary>
    [JsonPropertyName("port")]
    public required int Port { get; set; }
}

/// <summary>Type: The type of probe.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301JobSpecTemplateContainersProbesTypeEnum>))]
public enum V20240301JobSpecTemplateContainersProbesTypeEnum
{
    [EnumMember(Value = "Liveness"), JsonStringEnumMemberName("Liveness")]
    Liveness,
    [EnumMember(Value = "Readiness"), JsonStringEnumMemberName("Readiness")]
    Readiness,
    [EnumMember(Value = "Startup"), JsonStringEnumMemberName("Startup")]
    Startup
}

/// <summary>
/// Probe describes a health check to be performed against a container to determine whether it is alive or ready to receive
/// traffic.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecTemplateContainersProbes
{
    /// <summary>
    /// FailureThreshold: Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to
    /// 3. Minimum value is 1. Maximum value is 10.
    /// </summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>HttpGet: HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V20240301JobSpecTemplateContainersProbesHttpGet? HttpGet { get; set; }

    /// <summary>
    /// InitialDelaySeconds: Number of seconds after the container has started before liveness probes are initiated. Minimum
    /// value is 1. Maximum value is 60.
    /// </summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>
    /// PeriodSeconds: How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value is
    /// 240.
    /// </summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>
    /// SuccessThreshold: Minimum consecutive successes for the probe to be considered successful after having failed. Defaults
    /// to 1. Must be 1 for liveness and startup. Minimum value is 1. Maximum value is 10.
    /// </summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TcpSocket: TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported.</summary>
    [JsonPropertyName("tcpSocket")]
    public V20240301JobSpecTemplateContainersProbesTcpSocket? TcpSocket { get; set; }

    /// <summary>
    /// TerminationGracePeriodSeconds: Optional duration in seconds the pod needs to terminate gracefully upon probe failure.
    /// The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the
    /// time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for
    /// your process. If this value is nil, the pod&apos;s terminationGracePeriodSeconds will be used. Otherwise, this value
    /// overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop
    /// immediately via the kill signal (no opportunity to shut down). This is an alpha field and requires enabling
    /// ProbeTerminationGracePeriod feature gate. Maximum value is 3600 seconds (1 hour)
    /// </summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    /// <summary>
    /// TimeoutSeconds: Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum
    /// value is 240.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>Type: The type of probe.</summary>
    [JsonPropertyName("type")]
    public V20240301JobSpecTemplateContainersProbesTypeEnum? Type { get; set; }
}

/// <summary>Resources: Container resource requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecTemplateContainersResources
{
    /// <summary>Cpu: Required CPU in cores, e.g. 0.5</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>Memory: Required memory, e.g. &quot;250Mb&quot;</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Volume mount for the Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecTemplateContainersVolumeMounts
{
    /// <summary>MountPath: Path within the container at which the volume should be mounted.Must not contain &apos;:&apos;.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>SubPath: Path within the volume from which the container&apos;s volume should be mounted. Defaults to &quot; &quot; (volume&apos;s root).</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    /// <summary>VolumeName: This must match the Name of a Volume.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>Container App container definition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecTemplateContainers
{
    /// <summary>Args: Container start command arguments.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Command: Container start command.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Env: Container environment variables.</summary>
    [JsonPropertyName("env")]
    public IList<V20240301JobSpecTemplateContainersEnv>? Env { get; set; }

    /// <summary>Image: Container image tag.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Name: Custom container name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Probes: List of probes for the container.</summary>
    [JsonPropertyName("probes")]
    public IList<V20240301JobSpecTemplateContainersProbes>? Probes { get; set; }

    /// <summary>Resources: Container resource requirements.</summary>
    [JsonPropertyName("resources")]
    public V20240301JobSpecTemplateContainersResources? Resources { get; set; }

    /// <summary>VolumeMounts: Container volume mounts.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V20240301JobSpecTemplateContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Container App container environment variable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecTemplateInitContainersEnv
{
    /// <summary>Name: Environment variable name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SecretRef: Name of the Container App secret from which to pull the environment variable value.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>Value: Non-secret environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Resources: Container resource requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecTemplateInitContainersResources
{
    /// <summary>Cpu: Required CPU in cores, e.g. 0.5</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>Memory: Required memory, e.g. &quot;250Mb&quot;</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Volume mount for the Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecTemplateInitContainersVolumeMounts
{
    /// <summary>MountPath: Path within the container at which the volume should be mounted.Must not contain &apos;:&apos;.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>SubPath: Path within the volume from which the container&apos;s volume should be mounted. Defaults to &quot; &quot; (volume&apos;s root).</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    /// <summary>VolumeName: This must match the Name of a Volume.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>Container App base container definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecTemplateInitContainers
{
    /// <summary>Args: Container start command arguments.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Command: Container start command.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Env: Container environment variables.</summary>
    [JsonPropertyName("env")]
    public IList<V20240301JobSpecTemplateInitContainersEnv>? Env { get; set; }

    /// <summary>Image: Container image tag.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Name: Custom container name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Resources: Container resource requirements.</summary>
    [JsonPropertyName("resources")]
    public V20240301JobSpecTemplateInitContainersResources? Resources { get; set; }

    /// <summary>VolumeMounts: Container volume mounts.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V20240301JobSpecTemplateInitContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Secret to be added to volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecTemplateVolumesSecrets
{
    /// <summary>Path: Path to project secret to. If no path is provided, path defaults to name of secret listed in secretRef.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>SecretRef: Name of the Container App secret from which to pull the secret value.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }
}

/// <summary>StorageType: Storage type for the volume. If not provided, use EmptyDir.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V20240301JobSpecTemplateVolumesStorageTypeEnum>))]
public enum V20240301JobSpecTemplateVolumesStorageTypeEnum
{
    [EnumMember(Value = "AzureFile"), JsonStringEnumMemberName("AzureFile")]
    AzureFile,
    [EnumMember(Value = "EmptyDir"), JsonStringEnumMemberName("EmptyDir")]
    EmptyDir,
    [EnumMember(Value = "Secret"), JsonStringEnumMemberName("Secret")]
    Secret
}

/// <summary>Volume definitions for the Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecTemplateVolumes
{
    /// <summary>MountOptions: Mount options used while mounting the AzureFile. Must be a comma-separated string.</summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>Name: Volume name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Secrets: List of secrets to be added in volume. If no secrets are provided, all secrets in collection will be added to
    /// volume.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<V20240301JobSpecTemplateVolumesSecrets>? Secrets { get; set; }

    /// <summary>StorageName: Name of storage resource. No need to provide for EmptyDir and Secret.</summary>
    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }

    /// <summary>StorageType: Storage type for the volume. If not provided, use EmptyDir.</summary>
    [JsonPropertyName("storageType")]
    public V20240301JobSpecTemplateVolumesStorageTypeEnum? StorageType { get; set; }
}

/// <summary>Template: Container Apps job definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpecTemplate
{
    /// <summary>Containers: List of container definitions for the Container App.</summary>
    [JsonPropertyName("containers")]
    public IList<V20240301JobSpecTemplateContainers>? Containers { get; set; }

    /// <summary>InitContainers: List of specialized containers that run before app containers.</summary>
    [JsonPropertyName("initContainers")]
    public IList<V20240301JobSpecTemplateInitContainers>? InitContainers { get; set; }

    /// <summary>Volumes: List of volume definitions for the Container App.</summary>
    [JsonPropertyName("volumes")]
    public IList<V20240301JobSpecTemplateVolumes>? Volumes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>Configuration: Container Apps Job configuration properties.</summary>
    [JsonPropertyName("configuration")]
    public V20240301JobSpecConfiguration? Configuration { get; set; }

    /// <summary>EnvironmentReference: Resource ID of environment.</summary>
    [JsonPropertyName("environmentReference")]
    public V20240301JobSpecEnvironmentReference? EnvironmentReference { get; set; }

    /// <summary>
    /// Identity: Managed identities needed by a container app job to interact with other Azure services to not maintain any
    /// secrets or credentials in code.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20240301JobSpecIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20240301JobSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20240301JobSpecOwner Owner { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Template: Container Apps job definition.</summary>
    [JsonPropertyName("template")]
    public V20240301JobSpecTemplate? Template { get; set; }

    /// <summary>WorkloadProfileName: Workload profile name to pin for container apps job execution.</summary>
    [JsonPropertyName("workloadProfileName")]
    public string? WorkloadProfileName { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>Auth Secrets for Scale Rule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusConfigurationEventTriggerConfigScaleRulesAuth
{
    /// <summary>SecretRef: Name of the secret from which to pull the auth params.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>TriggerParameter: Trigger Parameter that uses the secret</summary>
    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary>Scaling rule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusConfigurationEventTriggerConfigScaleRules
{
    /// <summary>Auth: Authentication secrets for the scale rule.</summary>
    [JsonPropertyName("auth")]
    public IList<V20240301JobStatusConfigurationEventTriggerConfigScaleRulesAuth>? Auth { get; set; }

    /// <summary>Metadata: Metadata properties to describe the scale rule.</summary>
    [JsonPropertyName("metadata")]
    public IDictionary<string, JsonNode>? Metadata { get; set; }

    /// <summary>Name: Scale Rule Name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Type: Type of the scale rule
    /// eg: azure-servicebus, redis etc.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Scale: Scaling configurations for event driven jobs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusConfigurationEventTriggerConfigScale
{
    /// <summary>MaxExecutions: Maximum number of job executions that are created for a trigger, default 100.</summary>
    [JsonPropertyName("maxExecutions")]
    public int? MaxExecutions { get; set; }

    /// <summary>MinExecutions: Minimum number of job executions that are created for a trigger, default 0</summary>
    [JsonPropertyName("minExecutions")]
    public int? MinExecutions { get; set; }

    [JsonPropertyName("pollingInterval")]
    public int? PollingInterval { get; set; }

    /// <summary>Rules: Scaling rules.</summary>
    [JsonPropertyName("rules")]
    public IList<V20240301JobStatusConfigurationEventTriggerConfigScaleRules>? Rules { get; set; }
}

/// <summary>EventTriggerConfig: Trigger configuration of an event driven job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusConfigurationEventTriggerConfig
{
    [JsonPropertyName("parallelism")]
    public int? Parallelism { get; set; }

    [JsonPropertyName("replicaCompletionCount")]
    public int? ReplicaCompletionCount { get; set; }

    /// <summary>Scale: Scaling configurations for event driven jobs.</summary>
    [JsonPropertyName("scale")]
    public V20240301JobStatusConfigurationEventTriggerConfigScale? Scale { get; set; }
}

/// <summary>
/// ManualTriggerConfig: Manual trigger configuration for a single execution job. Properties replicaCompletionCount and
/// parallelism would be set to 1 by default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusConfigurationManualTriggerConfig
{
    [JsonPropertyName("parallelism")]
    public int? Parallelism { get; set; }

    [JsonPropertyName("replicaCompletionCount")]
    public int? ReplicaCompletionCount { get; set; }
}

/// <summary>Container App Private Registry</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusConfigurationRegistries
{
    /// <summary>
    /// Identity: A Managed Identity to use to authenticate with Azure Container Registry. For user-assigned identities, use the
    /// full user-assigned identity Resource ID. For system-assigned identities, use &apos;system&apos;
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>PasswordSecretRef: The name of the Secret that contains the registry login password</summary>
    [JsonPropertyName("passwordSecretRef")]
    public string? PasswordSecretRef { get; set; }

    /// <summary>Server: Container Registry Server</summary>
    [JsonPropertyName("server")]
    public string? Server { get; set; }

    /// <summary>Username: Container Registry Username</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>
/// ScheduleTriggerConfig: Cron formatted repeating trigger schedule (&quot;* * * * *&quot;) for cronjobs. Properties completions and
/// parallelism would be set to 1 by default
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusConfigurationScheduleTriggerConfig
{
    /// <summary>CronExpression: Cron formatted repeating schedule (&quot;* * * * *&quot;) of a Cron Job.</summary>
    [JsonPropertyName("cronExpression")]
    public string? CronExpression { get; set; }

    [JsonPropertyName("parallelism")]
    public int? Parallelism { get; set; }

    [JsonPropertyName("replicaCompletionCount")]
    public int? ReplicaCompletionCount { get; set; }
}

/// <summary>Secret definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusConfigurationSecrets
{
    /// <summary>
    /// Identity: Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a system-assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    /// <summary>KeyVaultUrl: Azure Key Vault URL pointing to the secret referenced by the container app.</summary>
    [JsonPropertyName("keyVaultUrl")]
    public string? KeyVaultUrl { get; set; }

    /// <summary>Name: Secret Name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configuration: Container Apps Job configuration properties.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusConfiguration
{
    /// <summary>EventTriggerConfig: Trigger configuration of an event driven job.</summary>
    [JsonPropertyName("eventTriggerConfig")]
    public V20240301JobStatusConfigurationEventTriggerConfig? EventTriggerConfig { get; set; }

    /// <summary>
    /// ManualTriggerConfig: Manual trigger configuration for a single execution job. Properties replicaCompletionCount and
    /// parallelism would be set to 1 by default
    /// </summary>
    [JsonPropertyName("manualTriggerConfig")]
    public V20240301JobStatusConfigurationManualTriggerConfig? ManualTriggerConfig { get; set; }

    /// <summary>Registries: Collection of private container registry credentials used by a Container apps job</summary>
    [JsonPropertyName("registries")]
    public IList<V20240301JobStatusConfigurationRegistries>? Registries { get; set; }

    /// <summary>ReplicaRetryLimit: Maximum number of retries before failing the job.</summary>
    [JsonPropertyName("replicaRetryLimit")]
    public int? ReplicaRetryLimit { get; set; }

    /// <summary>ReplicaTimeout: Maximum number of seconds a replica is allowed to run.</summary>
    [JsonPropertyName("replicaTimeout")]
    public int? ReplicaTimeout { get; set; }

    /// <summary>
    /// ScheduleTriggerConfig: Cron formatted repeating trigger schedule (&quot;* * * * *&quot;) for cronjobs. Properties completions and
    /// parallelism would be set to 1 by default
    /// </summary>
    [JsonPropertyName("scheduleTriggerConfig")]
    public V20240301JobStatusConfigurationScheduleTriggerConfig? ScheduleTriggerConfig { get; set; }

    /// <summary>Secrets: Collection of secrets used by a Container Apps Job</summary>
    [JsonPropertyName("secrets")]
    public IList<V20240301JobStatusConfigurationSecrets>? Secrets { get; set; }

    /// <summary>TriggerType: Trigger type of the job</summary>
    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
}

/// <summary>User assigned identity properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusIdentityUserAssignedIdentities
{
    /// <summary>ClientId: The client ID of the assigned identity.</summary>
    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    /// <summary>PrincipalId: The principal ID of the assigned identity.</summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>
/// Identity: Managed identities needed by a container app job to interact with other Azure services to not maintain any
/// secrets or credentials in code.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusIdentity
{
    /// <summary>
    /// PrincipalId: The service principal ID of the system assigned identity. This property will only be provided for a system
    /// assigned identity.
    /// </summary>
    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    /// <summary>
    /// TenantId: The tenant ID of the system assigned identity. This property will only be provided for a system assigned
    /// identity.
    /// </summary>
    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    /// <summary>Type: Type of managed service identity (where both SystemAssigned and UserAssigned types are allowed).</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20240301JobStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Container App container environment variable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusTemplateContainersEnv
{
    /// <summary>Name: Environment variable name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SecretRef: Name of the Container App secret from which to pull the environment variable value.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>Value: Non-secret environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusTemplateContainersProbesHttpGetHttpHeaders
{
    /// <summary>Name: The header field name</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value: The header field value</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>HttpGet: HTTPGet specifies the http request to perform.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusTemplateContainersProbesHttpGet
{
    /// <summary>Host: Host name to connect to, defaults to the pod IP. You probably want to set &quot;Host&quot; in httpHeaders instead.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>HttpHeaders: Custom headers to set in the request. HTTP allows repeated headers.</summary>
    [JsonPropertyName("httpHeaders")]
    public IList<V20240301JobStatusTemplateContainersProbesHttpGetHttpHeaders>? HttpHeaders { get; set; }

    /// <summary>Path: Path to access on the HTTP server.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// Port: Name or number of the port to access on the container. Number must be in the range 1 to 65535. Name must be an
    /// IANA_SVC_NAME.
    /// </summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Scheme: Scheme to use for connecting to the host. Defaults to HTTP.</summary>
    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>TcpSocket: TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusTemplateContainersProbesTcpSocket
{
    /// <summary>Host: Optional: Host name to connect to, defaults to the pod IP.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>
    /// Port: Number or name of the port to access on the container. Number must be in the range 1 to 65535. Name must be an
    /// IANA_SVC_NAME.
    /// </summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>
/// Probe describes a health check to be performed against a container to determine whether it is alive or ready to receive
/// traffic.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusTemplateContainersProbes
{
    /// <summary>
    /// FailureThreshold: Minimum consecutive failures for the probe to be considered failed after having succeeded. Defaults to
    /// 3. Minimum value is 1. Maximum value is 10.
    /// </summary>
    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>HttpGet: HTTPGet specifies the http request to perform.</summary>
    [JsonPropertyName("httpGet")]
    public V20240301JobStatusTemplateContainersProbesHttpGet? HttpGet { get; set; }

    /// <summary>
    /// InitialDelaySeconds: Number of seconds after the container has started before liveness probes are initiated. Minimum
    /// value is 1. Maximum value is 60.
    /// </summary>
    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    /// <summary>
    /// PeriodSeconds: How often (in seconds) to perform the probe. Default to 10 seconds. Minimum value is 1. Maximum value is
    /// 240.
    /// </summary>
    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    /// <summary>
    /// SuccessThreshold: Minimum consecutive successes for the probe to be considered successful after having failed. Defaults
    /// to 1. Must be 1 for liveness and startup. Minimum value is 1. Maximum value is 10.
    /// </summary>
    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>TcpSocket: TCPSocket specifies an action involving a TCP port. TCP hooks not yet supported.</summary>
    [JsonPropertyName("tcpSocket")]
    public V20240301JobStatusTemplateContainersProbesTcpSocket? TcpSocket { get; set; }

    /// <summary>
    /// TerminationGracePeriodSeconds: Optional duration in seconds the pod needs to terminate gracefully upon probe failure.
    /// The grace period is the duration in seconds after the processes running in the pod are sent a termination signal and the
    /// time when the processes are forcibly halted with a kill signal. Set this value longer than the expected cleanup time for
    /// your process. If this value is nil, the pod&apos;s terminationGracePeriodSeconds will be used. Otherwise, this value
    /// overrides the value provided by the pod spec. Value must be non-negative integer. The value zero indicates stop
    /// immediately via the kill signal (no opportunity to shut down). This is an alpha field and requires enabling
    /// ProbeTerminationGracePeriod feature gate. Maximum value is 3600 seconds (1 hour)
    /// </summary>
    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    /// <summary>
    /// TimeoutSeconds: Number of seconds after which the probe times out. Defaults to 1 second. Minimum value is 1. Maximum
    /// value is 240.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    /// <summary>Type: The type of probe.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Resources: Container resource requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusTemplateContainersResources
{
    /// <summary>Cpu: Required CPU in cores, e.g. 0.5</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>EphemeralStorage: Ephemeral Storage, e.g. &quot;1Gi&quot;</summary>
    [JsonPropertyName("ephemeralStorage")]
    public string? EphemeralStorage { get; set; }

    /// <summary>Memory: Required memory, e.g. &quot;250Mb&quot;</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Volume mount for the Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusTemplateContainersVolumeMounts
{
    /// <summary>MountPath: Path within the container at which the volume should be mounted.Must not contain &apos;:&apos;.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>SubPath: Path within the volume from which the container&apos;s volume should be mounted. Defaults to &quot; &quot; (volume&apos;s root).</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    /// <summary>VolumeName: This must match the Name of a Volume.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>Container App container definition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusTemplateContainers
{
    /// <summary>Args: Container start command arguments.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Command: Container start command.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Env: Container environment variables.</summary>
    [JsonPropertyName("env")]
    public IList<V20240301JobStatusTemplateContainersEnv>? Env { get; set; }

    /// <summary>Image: Container image tag.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Name: Custom container name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Probes: List of probes for the container.</summary>
    [JsonPropertyName("probes")]
    public IList<V20240301JobStatusTemplateContainersProbes>? Probes { get; set; }

    /// <summary>Resources: Container resource requirements.</summary>
    [JsonPropertyName("resources")]
    public V20240301JobStatusTemplateContainersResources? Resources { get; set; }

    /// <summary>VolumeMounts: Container volume mounts.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V20240301JobStatusTemplateContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Container App container environment variable.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusTemplateInitContainersEnv
{
    /// <summary>Name: Environment variable name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>SecretRef: Name of the Container App secret from which to pull the environment variable value.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    /// <summary>Value: Non-secret environment variable value.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Resources: Container resource requirements.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusTemplateInitContainersResources
{
    /// <summary>Cpu: Required CPU in cores, e.g. 0.5</summary>
    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    /// <summary>EphemeralStorage: Ephemeral Storage, e.g. &quot;1Gi&quot;</summary>
    [JsonPropertyName("ephemeralStorage")]
    public string? EphemeralStorage { get; set; }

    /// <summary>Memory: Required memory, e.g. &quot;250Mb&quot;</summary>
    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>Volume mount for the Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusTemplateInitContainersVolumeMounts
{
    /// <summary>MountPath: Path within the container at which the volume should be mounted.Must not contain &apos;:&apos;.</summary>
    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    /// <summary>SubPath: Path within the volume from which the container&apos;s volume should be mounted. Defaults to &quot; &quot; (volume&apos;s root).</summary>
    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    /// <summary>VolumeName: This must match the Name of a Volume.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>Container App base container definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusTemplateInitContainers
{
    /// <summary>Args: Container start command arguments.</summary>
    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    /// <summary>Command: Container start command.</summary>
    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    /// <summary>Env: Container environment variables.</summary>
    [JsonPropertyName("env")]
    public IList<V20240301JobStatusTemplateInitContainersEnv>? Env { get; set; }

    /// <summary>Image: Container image tag.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Name: Custom container name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Resources: Container resource requirements.</summary>
    [JsonPropertyName("resources")]
    public V20240301JobStatusTemplateInitContainersResources? Resources { get; set; }

    /// <summary>VolumeMounts: Container volume mounts.</summary>
    [JsonPropertyName("volumeMounts")]
    public IList<V20240301JobStatusTemplateInitContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>Secret to be added to volume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusTemplateVolumesSecrets
{
    /// <summary>Path: Path to project secret to. If no path is provided, path defaults to name of secret listed in secretRef.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>SecretRef: Name of the Container App secret from which to pull the secret value.</summary>
    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }
}

/// <summary>Volume definitions for the Container App.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusTemplateVolumes
{
    /// <summary>MountOptions: Mount options used while mounting the AzureFile. Must be a comma-separated string.</summary>
    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    /// <summary>Name: Volume name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Secrets: List of secrets to be added in volume. If no secrets are provided, all secrets in collection will be added to
    /// volume.
    /// </summary>
    [JsonPropertyName("secrets")]
    public IList<V20240301JobStatusTemplateVolumesSecrets>? Secrets { get; set; }

    /// <summary>StorageName: Name of storage resource. No need to provide for EmptyDir and Secret.</summary>
    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }

    /// <summary>StorageType: Storage type for the volume. If not provided, use EmptyDir.</summary>
    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary>Template: Container Apps job definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatusTemplate
{
    /// <summary>Containers: List of container definitions for the Container App.</summary>
    [JsonPropertyName("containers")]
    public IList<V20240301JobStatusTemplateContainers>? Containers { get; set; }

    /// <summary>InitContainers: List of specialized containers that run before app containers.</summary>
    [JsonPropertyName("initContainers")]
    public IList<V20240301JobStatusTemplateInitContainers>? InitContainers { get; set; }

    /// <summary>Volumes: List of volume definitions for the Container App.</summary>
    [JsonPropertyName("volumes")]
    public IList<V20240301JobStatusTemplateVolumes>? Volumes { get; set; }
}

/// <summary>Container App Job</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20240301JobStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20240301JobStatusConditions>? Conditions { get; set; }

    /// <summary>Configuration: Container Apps Job configuration properties.</summary>
    [JsonPropertyName("configuration")]
    public V20240301JobStatusConfiguration? Configuration { get; set; }

    /// <summary>EnvironmentId: Resource ID of environment.</summary>
    [JsonPropertyName("environmentId")]
    public string? EnvironmentId { get; set; }

    /// <summary>EventStreamEndpoint: The endpoint of the eventstream of the container apps job.</summary>
    [JsonPropertyName("eventStreamEndpoint")]
    public string? EventStreamEndpoint { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Identity: Managed identities needed by a container app job to interact with other Azure services to not maintain any
    /// secrets or credentials in code.
    /// </summary>
    [JsonPropertyName("identity")]
    public V20240301JobStatusIdentity? Identity { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OutboundIpAddresses: Outbound IP Addresses of a container apps job.</summary>
    [JsonPropertyName("outboundIpAddresses")]
    public IList<string>? OutboundIpAddresses { get; set; }

    /// <summary>ProvisioningState: Provisioning state of the Container Apps Job.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20240301JobStatusSystemData? SystemData { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Template: Container Apps job definition.</summary>
    [JsonPropertyName("template")]
    public V20240301JobStatusTemplate? Template { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>WorkloadProfileName: Workload profile name to pin for container apps job execution.</summary>
    [JsonPropertyName("workloadProfileName")]
    public string? WorkloadProfileName { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /app/resource-manager/Microsoft.App/ContainerApps/stable/2024-03-01/Jobs.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20240301Job : IKubernetesObject<V1ObjectMeta>, ISpec<V20240301JobSpec?>, IStatus<V20240301JobStatus?>
{
    public const string KubeApiVersion = "v20240301";
    public const string KubeKind = "Job";
    public const string KubeGroup = "app.azure.com";
    public const string KubePluralName = "jobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "app.azure.com/v20240301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Job";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20240301JobSpec? Spec { get; set; }

    /// <summary>Container App Job</summary>
    [JsonPropertyName("status")]
    public V20240301JobStatus? Status { get; set; }
}