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
/// Storage version of v20250101.Job
/// Generator information:
/// - Generated from: /app/resource-manager/Microsoft.App/ContainerApps/stable/2025-01-01/Jobs.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250101storageJobList : IKubernetesObject<V1ListMeta>, IItems<V20250101storageJob>
{
    public const string KubeApiVersion = "v20250101storage";
    public const string KubeKind = "JobList";
    public const string KubeGroup = "app.azure.com";
    public const string KubePluralName = "jobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "app.azure.com/v20250101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "JobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20250101storageJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20250101storageJob> Items { get; set; }
}

/// <summary>
/// Storage version of v20250101.ScaleRuleAuth
/// Auth Secrets for Scale Rule
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecConfigurationEventTriggerConfigScaleRulesAuth
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary>
/// IdentityReference: The resource ID of a user-assigned managed identity that is assigned to the Container App, or
/// &apos;system&apos; for system-assigned identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecConfigurationEventTriggerConfigScaleRulesIdentityReference
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

/// <summary>
/// Storage version of v20250101.JobScaleRule
/// Scaling rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecConfigurationEventTriggerConfigScaleRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("auth")]
    public IList<V20250101storageJobSpecConfigurationEventTriggerConfigScaleRulesAuth>? Auth { get; set; }

    /// <summary>
    /// IdentityReference: The resource ID of a user-assigned managed identity that is assigned to the Container App, or
    /// &apos;system&apos; for system-assigned identity.
    /// </summary>
    [JsonPropertyName("identityReference")]
    public V20250101storageJobSpecConfigurationEventTriggerConfigScaleRulesIdentityReference? IdentityReference { get; set; }

    [JsonPropertyName("metadata")]
    public IDictionary<string, JsonNode>? Metadata { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20250101.JobScale
/// Scaling configurations for event driven jobs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecConfigurationEventTriggerConfigScale
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("maxExecutions")]
    public int? MaxExecutions { get; set; }

    [JsonPropertyName("minExecutions")]
    public int? MinExecutions { get; set; }

    [JsonPropertyName("pollingInterval")]
    public int? PollingInterval { get; set; }

    [JsonPropertyName("rules")]
    public IList<V20250101storageJobSpecConfigurationEventTriggerConfigScaleRules>? Rules { get; set; }
}

/// <summary>Storage version of v20250101.JobConfiguration_EventTriggerConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecConfigurationEventTriggerConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("parallelism")]
    public int? Parallelism { get; set; }

    [JsonPropertyName("replicaCompletionCount")]
    public int? ReplicaCompletionCount { get; set; }

    /// <summary>
    /// Storage version of v20250101.JobScale
    /// Scaling configurations for event driven jobs.
    /// </summary>
    [JsonPropertyName("scale")]
    public V20250101storageJobSpecConfigurationEventTriggerConfigScale? Scale { get; set; }
}

/// <summary>
/// IdentityReference: The resource ID of a user-assigned managed identity that is assigned to the Container App, or
/// &apos;system&apos; for system-assigned identity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecConfigurationIdentitySettingsIdentityReference
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

/// <summary>
/// Storage version of v20250101.IdentitySettings
/// Optional settings for a Managed Identity that is assigned to the Container App.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecConfigurationIdentitySettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// IdentityReference: The resource ID of a user-assigned managed identity that is assigned to the Container App, or
    /// &apos;system&apos; for system-assigned identity.
    /// </summary>
    [JsonPropertyName("identityReference")]
    public required V20250101storageJobSpecConfigurationIdentitySettingsIdentityReference IdentityReference { get; set; }

    [JsonPropertyName("lifecycle")]
    public string? Lifecycle { get; set; }
}

/// <summary>Storage version of v20250101.JobConfiguration_ManualTriggerConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecConfigurationManualTriggerConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

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
public partial class V20250101storageJobSpecConfigurationRegistriesIdentityReference
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

/// <summary>
/// Storage version of v20250101.RegistryCredentials
/// Container App Private Registry
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecConfigurationRegistries
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// IdentityReference: A Managed Identity to use to authenticate with Azure Container Registry. For user-assigned
    /// identities, use the full user-assigned identity Resource ID. For system-assigned identities, use &apos;system&apos;
    /// </summary>
    [JsonPropertyName("identityReference")]
    public V20250101storageJobSpecConfigurationRegistriesIdentityReference? IdentityReference { get; set; }

    [JsonPropertyName("passwordSecretRef")]
    public string? PasswordSecretRef { get; set; }

    [JsonPropertyName("server")]
    public string? Server { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Storage version of v20250101.JobConfiguration_ScheduleTriggerConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecConfigurationScheduleTriggerConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("cronExpression")]
    public string? CronExpression { get; set; }

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
public partial class V20250101storageJobSpecConfigurationSecretsIdentityReference
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

/// <summary>
/// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
/// the resource it is on.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecConfigurationSecretsValue
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

/// <summary>
/// Storage version of v20250101.Secret
/// Secret definition.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecConfigurationSecrets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// IdentityReference: Resource ID of a managed identity to authenticate with Azure Key Vault, or System to use a
    /// system-assigned identity.
    /// </summary>
    [JsonPropertyName("identityReference")]
    public V20250101storageJobSpecConfigurationSecretsIdentityReference? IdentityReference { get; set; }

    [JsonPropertyName("keyVaultUrl")]
    public string? KeyVaultUrl { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// SecretReference is a reference to a Kubernetes secret and key in the same namespace as
    /// the resource it is on.
    /// </summary>
    [JsonPropertyName("value")]
    public V20250101storageJobSpecConfigurationSecretsValue? Value { get; set; }
}

/// <summary>
/// Storage version of v20250101.JobConfiguration
/// Non versioned Container Apps Job configuration properties
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250101.JobConfiguration_EventTriggerConfig</summary>
    [JsonPropertyName("eventTriggerConfig")]
    public V20250101storageJobSpecConfigurationEventTriggerConfig? EventTriggerConfig { get; set; }

    [JsonPropertyName("identitySettings")]
    public IList<V20250101storageJobSpecConfigurationIdentitySettings>? IdentitySettings { get; set; }

    /// <summary>Storage version of v20250101.JobConfiguration_ManualTriggerConfig</summary>
    [JsonPropertyName("manualTriggerConfig")]
    public V20250101storageJobSpecConfigurationManualTriggerConfig? ManualTriggerConfig { get; set; }

    [JsonPropertyName("registries")]
    public IList<V20250101storageJobSpecConfigurationRegistries>? Registries { get; set; }

    [JsonPropertyName("replicaRetryLimit")]
    public int? ReplicaRetryLimit { get; set; }

    [JsonPropertyName("replicaTimeout")]
    public int? ReplicaTimeout { get; set; }

    /// <summary>Storage version of v20250101.JobConfiguration_ScheduleTriggerConfig</summary>
    [JsonPropertyName("scheduleTriggerConfig")]
    public V20250101storageJobSpecConfigurationScheduleTriggerConfig? ScheduleTriggerConfig { get; set; }

    [JsonPropertyName("secrets")]
    public IList<V20250101storageJobSpecConfigurationSecrets>? Secrets { get; set; }

    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
}

/// <summary>EnvironmentReference: Resource ID of environment.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecEnvironmentReference
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

/// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecIdentityUserAssignedIdentitiesReference
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

/// <summary>
/// Storage version of v20250101.UserAssignedIdentityDetails
/// Information about the user assigned identity for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>ResourceReference represents a resource reference, either to a Kubernetes resource or directly to an Azure resource via ARMID</summary>
    [JsonPropertyName("reference")]
    public V20250101storageJobSpecIdentityUserAssignedIdentitiesReference? Reference { get; set; }
}

/// <summary>
/// Storage version of v20250101.ManagedServiceIdentity
/// Managed service identity (system assigned and/or user assigned identities)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IList<V20250101storageJobSpecIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecOperatorSpecConfigMapExpressions
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
public partial class V20250101storageJobSpecOperatorSpecSecretExpressions
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
/// Storage version of v20250101.JobOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V20250101storageJobSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V20250101storageJobSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a resources.azure.com/ResourceGroup resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20250101.EnvironmentVar
/// Container App container environment variable.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecTemplateContainersEnv
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250101.ContainerAppProbe_HttpGet_HttpHeaders</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecTemplateContainersProbesHttpGetHttpHeaders
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250101.ContainerAppProbe_HttpGet</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecTemplateContainersProbesHttpGet
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V20250101storageJobSpecTemplateContainersProbesHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>Storage version of v20250101.ContainerAppProbe_TcpSocket</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecTemplateContainersProbesTcpSocket
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>
/// Storage version of v20250101.ContainerAppProbe
/// Probe describes a health check to be performed against a container to determine whether it is alive or ready to receive
/// traffic.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecTemplateContainersProbes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>Storage version of v20250101.ContainerAppProbe_HttpGet</summary>
    [JsonPropertyName("httpGet")]
    public V20250101storageJobSpecTemplateContainersProbesHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Storage version of v20250101.ContainerAppProbe_TcpSocket</summary>
    [JsonPropertyName("tcpSocket")]
    public V20250101storageJobSpecTemplateContainersProbesTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20250101.ContainerResources
/// Container App container resource requirements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecTemplateContainersResources
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>
/// Storage version of v20250101.VolumeMount
/// Volume mount for the Container App.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecTemplateContainersVolumeMounts
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>
/// Storage version of v20250101.Container
/// Container App container definition
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecTemplateContainers
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V20250101storageJobSpecTemplateContainersEnv>? Env { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("probes")]
    public IList<V20250101storageJobSpecTemplateContainersProbes>? Probes { get; set; }

    /// <summary>
    /// Storage version of v20250101.ContainerResources
    /// Container App container resource requirements.
    /// </summary>
    [JsonPropertyName("resources")]
    public V20250101storageJobSpecTemplateContainersResources? Resources { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V20250101storageJobSpecTemplateContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>
/// Storage version of v20250101.EnvironmentVar
/// Container App container environment variable.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecTemplateInitContainersEnv
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v20250101.ContainerResources
/// Container App container resource requirements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecTemplateInitContainersResources
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>
/// Storage version of v20250101.VolumeMount
/// Volume mount for the Container App.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecTemplateInitContainersVolumeMounts
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>
/// Storage version of v20250101.BaseContainer
/// Container App base container definition.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecTemplateInitContainers
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V20250101storageJobSpecTemplateInitContainersEnv>? Env { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v20250101.ContainerResources
    /// Container App container resource requirements.
    /// </summary>
    [JsonPropertyName("resources")]
    public V20250101storageJobSpecTemplateInitContainersResources? Resources { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V20250101storageJobSpecTemplateInitContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>
/// Storage version of v20250101.SecretVolumeItem
/// Secret to be added to volume.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecTemplateVolumesSecrets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }
}

/// <summary>
/// Storage version of v20250101.Volume
/// Volume definitions for the Container App.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecTemplateVolumes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("secrets")]
    public IList<V20250101storageJobSpecTemplateVolumesSecrets>? Secrets { get; set; }

    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }

    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary>
/// Storage version of v20250101.JobTemplate
/// Container Apps Job versioned application definition. Defines the desired state of an immutable revision. Any changes to
/// this section Will result in a new revision being created
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpecTemplate
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("containers")]
    public IList<V20250101storageJobSpecTemplateContainers>? Containers { get; set; }

    [JsonPropertyName("initContainers")]
    public IList<V20250101storageJobSpecTemplateInitContainers>? InitContainers { get; set; }

    [JsonPropertyName("volumes")]
    public IList<V20250101storageJobSpecTemplateVolumes>? Volumes { get; set; }
}

/// <summary>Storage version of v20250101.Job_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// Storage version of v20250101.JobConfiguration
    /// Non versioned Container Apps Job configuration properties
    /// </summary>
    [JsonPropertyName("configuration")]
    public V20250101storageJobSpecConfiguration? Configuration { get; set; }

    /// <summary>EnvironmentReference: Resource ID of environment.</summary>
    [JsonPropertyName("environmentReference")]
    public V20250101storageJobSpecEnvironmentReference? EnvironmentReference { get; set; }

    /// <summary>
    /// Storage version of v20250101.ManagedServiceIdentity
    /// Managed service identity (system assigned and/or user assigned identities)
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250101storageJobSpecIdentity? Identity { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>
    /// Storage version of v20250101.JobOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20250101storageJobSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a resources.azure.com/ResourceGroup resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20250101storageJobSpecOwner Owner { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// Storage version of v20250101.JobTemplate
    /// Container Apps Job versioned application definition. Defines the desired state of an immutable revision. Any changes to
    /// this section Will result in a new revision being created
    /// </summary>
    [JsonPropertyName("template")]
    public V20250101storageJobSpecTemplate? Template { get; set; }

    [JsonPropertyName("workloadProfileName")]
    public string? WorkloadProfileName { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusConditions
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

/// <summary>
/// Storage version of v20250101.ScaleRuleAuth_STATUS
/// Auth Secrets for Scale Rule
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusConfigurationEventTriggerConfigScaleRulesAuth
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    [JsonPropertyName("triggerParameter")]
    public string? TriggerParameter { get; set; }
}

/// <summary>
/// Storage version of v20250101.JobScaleRule_STATUS
/// Scaling rule.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusConfigurationEventTriggerConfigScaleRules
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("auth")]
    public IList<V20250101storageJobStatusConfigurationEventTriggerConfigScaleRulesAuth>? Auth { get; set; }

    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    [JsonPropertyName("metadata")]
    public IDictionary<string, JsonNode>? Metadata { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20250101.JobScale_STATUS
/// Scaling configurations for event driven jobs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusConfigurationEventTriggerConfigScale
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("maxExecutions")]
    public int? MaxExecutions { get; set; }

    [JsonPropertyName("minExecutions")]
    public int? MinExecutions { get; set; }

    [JsonPropertyName("pollingInterval")]
    public int? PollingInterval { get; set; }

    [JsonPropertyName("rules")]
    public IList<V20250101storageJobStatusConfigurationEventTriggerConfigScaleRules>? Rules { get; set; }
}

/// <summary>Storage version of v20250101.JobConfiguration_EventTriggerConfig_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusConfigurationEventTriggerConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("parallelism")]
    public int? Parallelism { get; set; }

    [JsonPropertyName("replicaCompletionCount")]
    public int? ReplicaCompletionCount { get; set; }

    /// <summary>
    /// Storage version of v20250101.JobScale_STATUS
    /// Scaling configurations for event driven jobs.
    /// </summary>
    [JsonPropertyName("scale")]
    public V20250101storageJobStatusConfigurationEventTriggerConfigScale? Scale { get; set; }
}

/// <summary>
/// Storage version of v20250101.IdentitySettings_STATUS
/// Optional settings for a Managed Identity that is assigned to the Container App.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusConfigurationIdentitySettings
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    [JsonPropertyName("lifecycle")]
    public string? Lifecycle { get; set; }
}

/// <summary>Storage version of v20250101.JobConfiguration_ManualTriggerConfig_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusConfigurationManualTriggerConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("parallelism")]
    public int? Parallelism { get; set; }

    [JsonPropertyName("replicaCompletionCount")]
    public int? ReplicaCompletionCount { get; set; }
}

/// <summary>
/// Storage version of v20250101.RegistryCredentials_STATUS
/// Container App Private Registry
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusConfigurationRegistries
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    [JsonPropertyName("passwordSecretRef")]
    public string? PasswordSecretRef { get; set; }

    [JsonPropertyName("server")]
    public string? Server { get; set; }

    [JsonPropertyName("username")]
    public string? Username { get; set; }
}

/// <summary>Storage version of v20250101.JobConfiguration_ScheduleTriggerConfig_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusConfigurationScheduleTriggerConfig
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("cronExpression")]
    public string? CronExpression { get; set; }

    [JsonPropertyName("parallelism")]
    public int? Parallelism { get; set; }

    [JsonPropertyName("replicaCompletionCount")]
    public int? ReplicaCompletionCount { get; set; }
}

/// <summary>
/// Storage version of v20250101.Secret_STATUS
/// Secret definition.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusConfigurationSecrets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("identity")]
    public string? Identity { get; set; }

    [JsonPropertyName("keyVaultUrl")]
    public string? KeyVaultUrl { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v20250101.JobConfiguration_STATUS
/// Non versioned Container Apps Job configuration properties
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusConfiguration
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>Storage version of v20250101.JobConfiguration_EventTriggerConfig_STATUS</summary>
    [JsonPropertyName("eventTriggerConfig")]
    public V20250101storageJobStatusConfigurationEventTriggerConfig? EventTriggerConfig { get; set; }

    [JsonPropertyName("identitySettings")]
    public IList<V20250101storageJobStatusConfigurationIdentitySettings>? IdentitySettings { get; set; }

    /// <summary>Storage version of v20250101.JobConfiguration_ManualTriggerConfig_STATUS</summary>
    [JsonPropertyName("manualTriggerConfig")]
    public V20250101storageJobStatusConfigurationManualTriggerConfig? ManualTriggerConfig { get; set; }

    [JsonPropertyName("registries")]
    public IList<V20250101storageJobStatusConfigurationRegistries>? Registries { get; set; }

    [JsonPropertyName("replicaRetryLimit")]
    public int? ReplicaRetryLimit { get; set; }

    [JsonPropertyName("replicaTimeout")]
    public int? ReplicaTimeout { get; set; }

    /// <summary>Storage version of v20250101.JobConfiguration_ScheduleTriggerConfig_STATUS</summary>
    [JsonPropertyName("scheduleTriggerConfig")]
    public V20250101storageJobStatusConfigurationScheduleTriggerConfig? ScheduleTriggerConfig { get; set; }

    [JsonPropertyName("secrets")]
    public IList<V20250101storageJobStatusConfigurationSecrets>? Secrets { get; set; }

    [JsonPropertyName("triggerType")]
    public string? TriggerType { get; set; }
}

/// <summary>
/// Storage version of v20250101.UserAssignedIdentity_STATUS
/// User assigned identity properties
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusIdentityUserAssignedIdentities
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clientId")]
    public string? ClientId { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }
}

/// <summary>
/// Storage version of v20250101.ManagedServiceIdentity_STATUS
/// Managed service identity (system assigned and/or user assigned identities)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusIdentity
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("principalId")]
    public string? PrincipalId { get; set; }

    [JsonPropertyName("tenantId")]
    public string? TenantId { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("userAssignedIdentities")]
    public IDictionary<string, V20250101storageJobStatusIdentityUserAssignedIdentities>? UserAssignedIdentities { get; set; }
}

/// <summary>
/// Storage version of v20250101.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusSystemData
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>
/// Storage version of v20250101.EnvironmentVar_STATUS
/// Container App container environment variable.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusTemplateContainersEnv
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250101.ContainerAppProbe_HttpGet_HttpHeaders_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusTemplateContainersProbesHttpGetHttpHeaders
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Storage version of v20250101.ContainerAppProbe_HttpGet_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusTemplateContainersProbesHttpGet
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("httpHeaders")]
    public IList<V20250101storageJobStatusTemplateContainersProbesHttpGetHttpHeaders>? HttpHeaders { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }

    [JsonPropertyName("scheme")]
    public string? Scheme { get; set; }
}

/// <summary>Storage version of v20250101.ContainerAppProbe_TcpSocket_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusTemplateContainersProbesTcpSocket
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("host")]
    public string? Host { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }
}

/// <summary>
/// Storage version of v20250101.ContainerAppProbe_STATUS
/// Probe describes a health check to be performed against a container to determine whether it is alive or ready to receive
/// traffic.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusTemplateContainersProbes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("failureThreshold")]
    public int? FailureThreshold { get; set; }

    /// <summary>Storage version of v20250101.ContainerAppProbe_HttpGet_STATUS</summary>
    [JsonPropertyName("httpGet")]
    public V20250101storageJobStatusTemplateContainersProbesHttpGet? HttpGet { get; set; }

    [JsonPropertyName("initialDelaySeconds")]
    public int? InitialDelaySeconds { get; set; }

    [JsonPropertyName("periodSeconds")]
    public int? PeriodSeconds { get; set; }

    [JsonPropertyName("successThreshold")]
    public int? SuccessThreshold { get; set; }

    /// <summary>Storage version of v20250101.ContainerAppProbe_TcpSocket_STATUS</summary>
    [JsonPropertyName("tcpSocket")]
    public V20250101storageJobStatusTemplateContainersProbesTcpSocket? TcpSocket { get; set; }

    [JsonPropertyName("terminationGracePeriodSeconds")]
    public int? TerminationGracePeriodSeconds { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public int? TimeoutSeconds { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v20250101.ContainerResources_STATUS
/// Container App container resource requirements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusTemplateContainersResources
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    [JsonPropertyName("ephemeralStorage")]
    public string? EphemeralStorage { get; set; }

    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>
/// Storage version of v20250101.VolumeMount_STATUS
/// Volume mount for the Container App.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusTemplateContainersVolumeMounts
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>
/// Storage version of v20250101.Container_STATUS
/// Container App container definition
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusTemplateContainers
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V20250101storageJobStatusTemplateContainersEnv>? Env { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("probes")]
    public IList<V20250101storageJobStatusTemplateContainersProbes>? Probes { get; set; }

    /// <summary>
    /// Storage version of v20250101.ContainerResources_STATUS
    /// Container App container resource requirements.
    /// </summary>
    [JsonPropertyName("resources")]
    public V20250101storageJobStatusTemplateContainersResources? Resources { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V20250101storageJobStatusTemplateContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>
/// Storage version of v20250101.EnvironmentVar_STATUS
/// Container App container environment variable.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusTemplateInitContainersEnv
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Storage version of v20250101.ContainerResources_STATUS
/// Container App container resource requirements.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusTemplateInitContainersResources
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("cpu")]
    public double? Cpu { get; set; }

    [JsonPropertyName("ephemeralStorage")]
    public string? EphemeralStorage { get; set; }

    [JsonPropertyName("memory")]
    public string? Memory { get; set; }
}

/// <summary>
/// Storage version of v20250101.VolumeMount_STATUS
/// Volume mount for the Container App.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusTemplateInitContainersVolumeMounts
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mountPath")]
    public string? MountPath { get; set; }

    [JsonPropertyName("subPath")]
    public string? SubPath { get; set; }

    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>
/// Storage version of v20250101.BaseContainer_STATUS
/// Container App base container definition.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusTemplateInitContainers
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("args")]
    public IList<string>? Args { get; set; }

    [JsonPropertyName("command")]
    public IList<string>? Command { get; set; }

    [JsonPropertyName("env")]
    public IList<V20250101storageJobStatusTemplateInitContainersEnv>? Env { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v20250101.ContainerResources_STATUS
    /// Container App container resource requirements.
    /// </summary>
    [JsonPropertyName("resources")]
    public V20250101storageJobStatusTemplateInitContainersResources? Resources { get; set; }

    [JsonPropertyName("volumeMounts")]
    public IList<V20250101storageJobStatusTemplateInitContainersVolumeMounts>? VolumeMounts { get; set; }
}

/// <summary>
/// Storage version of v20250101.SecretVolumeItem_STATUS
/// Secret to be added to volume.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusTemplateVolumesSecrets
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("secretRef")]
    public string? SecretRef { get; set; }
}

/// <summary>
/// Storage version of v20250101.Volume_STATUS
/// Volume definitions for the Container App.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusTemplateVolumes
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("mountOptions")]
    public string? MountOptions { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("secrets")]
    public IList<V20250101storageJobStatusTemplateVolumesSecrets>? Secrets { get; set; }

    [JsonPropertyName("storageName")]
    public string? StorageName { get; set; }

    [JsonPropertyName("storageType")]
    public string? StorageType { get; set; }
}

/// <summary>
/// Storage version of v20250101.JobTemplate_STATUS
/// Container Apps Job versioned application definition. Defines the desired state of an immutable revision. Any changes to
/// this section Will result in a new revision being created
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatusTemplate
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("containers")]
    public IList<V20250101storageJobStatusTemplateContainers>? Containers { get; set; }

    [JsonPropertyName("initContainers")]
    public IList<V20250101storageJobStatusTemplateInitContainers>? InitContainers { get; set; }

    [JsonPropertyName("volumes")]
    public IList<V20250101storageJobStatusTemplateVolumes>? Volumes { get; set; }
}

/// <summary>
/// Storage version of v20250101.Job_STATUS
/// Container App Job
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20250101storageJobStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V20250101storageJobStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Storage version of v20250101.JobConfiguration_STATUS
    /// Non versioned Container Apps Job configuration properties
    /// </summary>
    [JsonPropertyName("configuration")]
    public V20250101storageJobStatusConfiguration? Configuration { get; set; }

    [JsonPropertyName("environmentId")]
    public string? EnvironmentId { get; set; }

    [JsonPropertyName("eventStreamEndpoint")]
    public string? EventStreamEndpoint { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v20250101.ManagedServiceIdentity_STATUS
    /// Managed service identity (system assigned and/or user assigned identities)
    /// </summary>
    [JsonPropertyName("identity")]
    public V20250101storageJobStatusIdentity? Identity { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("outboundIpAddresses")]
    public IList<string>? OutboundIpAddresses { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// Storage version of v20250101.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V20250101storageJobStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>
    /// Storage version of v20250101.JobTemplate_STATUS
    /// Container Apps Job versioned application definition. Defines the desired state of an immutable revision. Any changes to
    /// this section Will result in a new revision being created
    /// </summary>
    [JsonPropertyName("template")]
    public V20250101storageJobStatusTemplate? Template { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("workloadProfileName")]
    public string? WorkloadProfileName { get; set; }
}

/// <summary>
/// Storage version of v20250101.Job
/// Generator information:
/// - Generated from: /app/resource-manager/Microsoft.App/ContainerApps/stable/2025-01-01/Jobs.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/jobs/{jobName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20250101storageJob : IKubernetesObject<V1ObjectMeta>, ISpec<V20250101storageJobSpec?>, IStatus<V20250101storageJobStatus?>
{
    public const string KubeApiVersion = "v20250101storage";
    public const string KubeKind = "Job";
    public const string KubeGroup = "app.azure.com";
    public const string KubePluralName = "jobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "app.azure.com/v20250101storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Job";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v20250101.Job_Spec</summary>
    [JsonPropertyName("spec")]
    public V20250101storageJobSpec? Spec { get; set; }

    /// <summary>
    /// Storage version of v20250101.Job_STATUS
    /// Container App Job
    /// </summary>
    [JsonPropertyName("status")]
    public V20250101storageJobStatus? Status { get; set; }
}