#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.synapse.azure.upbound.io;
/// <summary>SparkPool is the Schema for the SparkPools API. Manages a Synapse Spark Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SparkPoolList : IKubernetesObject<V1ListMeta>, IItems<V1beta2SparkPool>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SparkPoolList";
    public const string KubeGroup = "synapse.azure.upbound.io";
    public const string KubePluralName = "sparkpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "synapse.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SparkPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2SparkPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2SparkPool> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SparkPoolSpecDeletionPolicyEnum>))]
public enum V1beta2SparkPoolSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>An auto_pause block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolSpecForProviderAutoPause
{
    /// <summary>Number of minutes of idle time before the Spark Pool is automatically paused. Must be between 5 and 10080.</summary>
    [JsonPropertyName("delayInMinutes")]
    public double? DelayInMinutes { get; set; }
}

/// <summary>An auto_scale block as defined below. Exactly one of node_count or auto_scale must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolSpecForProviderAutoScale
{
    /// <summary>The maximum number of nodes the Spark Pool can support. Must be between 3 and 200.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>The minimum number of nodes the Spark Pool can support. Must be between 3 and 200.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}

/// <summary>A library_requirement block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolSpecForProviderLibraryRequirement
{
    /// <summary>The content of library requirements.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The name of the library requirements file.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}

/// <summary>A spark_config block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolSpecForProviderSparkConfig
{
    /// <summary>The contents of a spark configuration.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The name of the file where the spark configuration content will be stored.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdRefPolicyResolutionEnum>))]
public enum V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdRefPolicyResolveEnum>))]
public enum V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Workspace in synapse to populate synapseWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdSelectorPolicyResolveEnum>))]
public enum V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Workspace in synapse to populate synapseWorkspaceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdSelector
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
    public V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolSpecForProvider
{
    /// <summary>An auto_pause block as defined below.</summary>
    [JsonPropertyName("autoPause")]
    public V1beta2SparkPoolSpecForProviderAutoPause? AutoPause { get; set; }

    /// <summary>An auto_scale block as defined below. Exactly one of node_count or auto_scale must be specified.</summary>
    [JsonPropertyName("autoScale")]
    public V1beta2SparkPoolSpecForProviderAutoScale? AutoScale { get; set; }

    /// <summary>The cache size in the Spark Pool.</summary>
    [JsonPropertyName("cacheSize")]
    public double? CacheSize { get; set; }

    /// <summary>Indicates whether compute isolation is enabled or not. Defaults to false.</summary>
    [JsonPropertyName("computeIsolationEnabled")]
    public bool? ComputeIsolationEnabled { get; set; }

    /// <summary>Indicates whether Dynamic Executor Allocation is enabled or not. Defaults to false.</summary>
    [JsonPropertyName("dynamicExecutorAllocationEnabled")]
    public bool? DynamicExecutorAllocationEnabled { get; set; }

    /// <summary>A library_requirement block as defined below.</summary>
    [JsonPropertyName("libraryRequirement")]
    public V1beta2SparkPoolSpecForProviderLibraryRequirement? LibraryRequirement { get; set; }

    /// <summary>The maximum number of executors allocated only when dynamic_executor_allocation_enabled set to true.</summary>
    [JsonPropertyName("maxExecutors")]
    public double? MaxExecutors { get; set; }

    /// <summary>The minimum number of executors allocated only when dynamic_executor_allocation_enabled set to true.</summary>
    [JsonPropertyName("minExecutors")]
    public double? MinExecutors { get; set; }

    /// <summary>The number of nodes in the Spark Pool. Exactly one of node_count or auto_scale must be specified.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The level of node in the Spark Pool. Possible values are Small, Medium, Large, None, XLarge, XXLarge and XXXLarge.</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>The kind of nodes that the Spark Pool provides. Possible values are HardwareAcceleratedFPGA, HardwareAcceleratedGPU, MemoryOptimized, and None.</summary>
    [JsonPropertyName("nodeSizeFamily")]
    public string? NodeSizeFamily { get; set; }

    /// <summary>Indicates whether session level packages are enabled or not. Defaults to false.</summary>
    [JsonPropertyName("sessionLevelPackagesEnabled")]
    public bool? SessionLevelPackagesEnabled { get; set; }

    /// <summary>A spark_config block as defined below.</summary>
    [JsonPropertyName("sparkConfig")]
    public V1beta2SparkPoolSpecForProviderSparkConfig? SparkConfig { get; set; }

    /// <summary>The Spark events folder. Defaults to /events.</summary>
    [JsonPropertyName("sparkEventsFolder")]
    public string? SparkEventsFolder { get; set; }

    /// <summary>The default folder where Spark logs will be written. Defaults to /logs.</summary>
    [JsonPropertyName("sparkLogFolder")]
    public string? SparkLogFolder { get; set; }

    /// <summary>The Apache Spark version. Possible values are 3.4 and 3.5.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary>The ID of the Synapse Workspace where the Synapse Spark Pool should exist. Changing this forces a new Synapse Spark Pool to be created.</summary>
    [JsonPropertyName("synapseWorkspaceId")]
    public string? SynapseWorkspaceId { get; set; }

    /// <summary>Reference to a Workspace in synapse to populate synapseWorkspaceId.</summary>
    [JsonPropertyName("synapseWorkspaceIdRef")]
    public V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdRef? SynapseWorkspaceIdRef { get; set; }

    /// <summary>Selector for a Workspace in synapse to populate synapseWorkspaceId.</summary>
    [JsonPropertyName("synapseWorkspaceIdSelector")]
    public V1beta2SparkPoolSpecForProviderSynapseWorkspaceIdSelector? SynapseWorkspaceIdSelector { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Synapse Spark Pool.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>An auto_pause block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolSpecInitProviderAutoPause
{
    /// <summary>Number of minutes of idle time before the Spark Pool is automatically paused. Must be between 5 and 10080.</summary>
    [JsonPropertyName("delayInMinutes")]
    public double? DelayInMinutes { get; set; }
}

/// <summary>An auto_scale block as defined below. Exactly one of node_count or auto_scale must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolSpecInitProviderAutoScale
{
    /// <summary>The maximum number of nodes the Spark Pool can support. Must be between 3 and 200.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>The minimum number of nodes the Spark Pool can support. Must be between 3 and 200.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}

/// <summary>A library_requirement block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolSpecInitProviderLibraryRequirement
{
    /// <summary>The content of library requirements.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The name of the library requirements file.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}

/// <summary>A spark_config block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolSpecInitProviderSparkConfig
{
    /// <summary>The contents of a spark configuration.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The name of the file where the spark configuration content will be stored.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
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
public partial class V1beta2SparkPoolSpecInitProvider
{
    /// <summary>An auto_pause block as defined below.</summary>
    [JsonPropertyName("autoPause")]
    public V1beta2SparkPoolSpecInitProviderAutoPause? AutoPause { get; set; }

    /// <summary>An auto_scale block as defined below. Exactly one of node_count or auto_scale must be specified.</summary>
    [JsonPropertyName("autoScale")]
    public V1beta2SparkPoolSpecInitProviderAutoScale? AutoScale { get; set; }

    /// <summary>The cache size in the Spark Pool.</summary>
    [JsonPropertyName("cacheSize")]
    public double? CacheSize { get; set; }

    /// <summary>Indicates whether compute isolation is enabled or not. Defaults to false.</summary>
    [JsonPropertyName("computeIsolationEnabled")]
    public bool? ComputeIsolationEnabled { get; set; }

    /// <summary>Indicates whether Dynamic Executor Allocation is enabled or not. Defaults to false.</summary>
    [JsonPropertyName("dynamicExecutorAllocationEnabled")]
    public bool? DynamicExecutorAllocationEnabled { get; set; }

    /// <summary>A library_requirement block as defined below.</summary>
    [JsonPropertyName("libraryRequirement")]
    public V1beta2SparkPoolSpecInitProviderLibraryRequirement? LibraryRequirement { get; set; }

    /// <summary>The maximum number of executors allocated only when dynamic_executor_allocation_enabled set to true.</summary>
    [JsonPropertyName("maxExecutors")]
    public double? MaxExecutors { get; set; }

    /// <summary>The minimum number of executors allocated only when dynamic_executor_allocation_enabled set to true.</summary>
    [JsonPropertyName("minExecutors")]
    public double? MinExecutors { get; set; }

    /// <summary>The number of nodes in the Spark Pool. Exactly one of node_count or auto_scale must be specified.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The level of node in the Spark Pool. Possible values are Small, Medium, Large, None, XLarge, XXLarge and XXXLarge.</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>The kind of nodes that the Spark Pool provides. Possible values are HardwareAcceleratedFPGA, HardwareAcceleratedGPU, MemoryOptimized, and None.</summary>
    [JsonPropertyName("nodeSizeFamily")]
    public string? NodeSizeFamily { get; set; }

    /// <summary>Indicates whether session level packages are enabled or not. Defaults to false.</summary>
    [JsonPropertyName("sessionLevelPackagesEnabled")]
    public bool? SessionLevelPackagesEnabled { get; set; }

    /// <summary>A spark_config block as defined below.</summary>
    [JsonPropertyName("sparkConfig")]
    public V1beta2SparkPoolSpecInitProviderSparkConfig? SparkConfig { get; set; }

    /// <summary>The Spark events folder. Defaults to /events.</summary>
    [JsonPropertyName("sparkEventsFolder")]
    public string? SparkEventsFolder { get; set; }

    /// <summary>The default folder where Spark logs will be written. Defaults to /logs.</summary>
    [JsonPropertyName("sparkLogFolder")]
    public string? SparkLogFolder { get; set; }

    /// <summary>The Apache Spark version. Possible values are 3.4 and 3.5.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Synapse Spark Pool.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SparkPoolSpecManagementPoliciesEnum>))]
public enum V1beta2SparkPoolSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SparkPoolSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2SparkPoolSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2SparkPoolSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2SparkPoolSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2SparkPoolSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2SparkPoolSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2SparkPoolSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>SparkPoolSpec defines the desired state of SparkPool</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolSpec
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
    public V1beta2SparkPoolSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2SparkPoolSpecForProvider ForProvider { get; set; }

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
    public V1beta2SparkPoolSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2SparkPoolSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2SparkPoolSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2SparkPoolSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>An auto_pause block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolStatusAtProviderAutoPause
{
    /// <summary>Number of minutes of idle time before the Spark Pool is automatically paused. Must be between 5 and 10080.</summary>
    [JsonPropertyName("delayInMinutes")]
    public double? DelayInMinutes { get; set; }
}

/// <summary>An auto_scale block as defined below. Exactly one of node_count or auto_scale must be specified.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolStatusAtProviderAutoScale
{
    /// <summary>The maximum number of nodes the Spark Pool can support. Must be between 3 and 200.</summary>
    [JsonPropertyName("maxNodeCount")]
    public double? MaxNodeCount { get; set; }

    /// <summary>The minimum number of nodes the Spark Pool can support. Must be between 3 and 200.</summary>
    [JsonPropertyName("minNodeCount")]
    public double? MinNodeCount { get; set; }
}

/// <summary>A library_requirement block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolStatusAtProviderLibraryRequirement
{
    /// <summary>The content of library requirements.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The name of the library requirements file.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}

/// <summary>A spark_config block as defined below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolStatusAtProviderSparkConfig
{
    /// <summary>The contents of a spark configuration.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>The name of the file where the spark configuration content will be stored.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolStatusAtProvider
{
    /// <summary>An auto_pause block as defined below.</summary>
    [JsonPropertyName("autoPause")]
    public V1beta2SparkPoolStatusAtProviderAutoPause? AutoPause { get; set; }

    /// <summary>An auto_scale block as defined below. Exactly one of node_count or auto_scale must be specified.</summary>
    [JsonPropertyName("autoScale")]
    public V1beta2SparkPoolStatusAtProviderAutoScale? AutoScale { get; set; }

    /// <summary>The cache size in the Spark Pool.</summary>
    [JsonPropertyName("cacheSize")]
    public double? CacheSize { get; set; }

    /// <summary>Indicates whether compute isolation is enabled or not. Defaults to false.</summary>
    [JsonPropertyName("computeIsolationEnabled")]
    public bool? ComputeIsolationEnabled { get; set; }

    /// <summary>Indicates whether Dynamic Executor Allocation is enabled or not. Defaults to false.</summary>
    [JsonPropertyName("dynamicExecutorAllocationEnabled")]
    public bool? DynamicExecutorAllocationEnabled { get; set; }

    /// <summary>The ID of the Synapse Spark Pool.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A library_requirement block as defined below.</summary>
    [JsonPropertyName("libraryRequirement")]
    public V1beta2SparkPoolStatusAtProviderLibraryRequirement? LibraryRequirement { get; set; }

    /// <summary>The maximum number of executors allocated only when dynamic_executor_allocation_enabled set to true.</summary>
    [JsonPropertyName("maxExecutors")]
    public double? MaxExecutors { get; set; }

    /// <summary>The minimum number of executors allocated only when dynamic_executor_allocation_enabled set to true.</summary>
    [JsonPropertyName("minExecutors")]
    public double? MinExecutors { get; set; }

    /// <summary>The number of nodes in the Spark Pool. Exactly one of node_count or auto_scale must be specified.</summary>
    [JsonPropertyName("nodeCount")]
    public double? NodeCount { get; set; }

    /// <summary>The level of node in the Spark Pool. Possible values are Small, Medium, Large, None, XLarge, XXLarge and XXXLarge.</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>The kind of nodes that the Spark Pool provides. Possible values are HardwareAcceleratedFPGA, HardwareAcceleratedGPU, MemoryOptimized, and None.</summary>
    [JsonPropertyName("nodeSizeFamily")]
    public string? NodeSizeFamily { get; set; }

    /// <summary>Indicates whether session level packages are enabled or not. Defaults to false.</summary>
    [JsonPropertyName("sessionLevelPackagesEnabled")]
    public bool? SessionLevelPackagesEnabled { get; set; }

    /// <summary>A spark_config block as defined below.</summary>
    [JsonPropertyName("sparkConfig")]
    public V1beta2SparkPoolStatusAtProviderSparkConfig? SparkConfig { get; set; }

    /// <summary>The Spark events folder. Defaults to /events.</summary>
    [JsonPropertyName("sparkEventsFolder")]
    public string? SparkEventsFolder { get; set; }

    /// <summary>The default folder where Spark logs will be written. Defaults to /logs.</summary>
    [JsonPropertyName("sparkLogFolder")]
    public string? SparkLogFolder { get; set; }

    /// <summary>The Apache Spark version. Possible values are 3.4 and 3.5.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary>The ID of the Synapse Workspace where the Synapse Spark Pool should exist. Changing this forces a new Synapse Spark Pool to be created.</summary>
    [JsonPropertyName("synapseWorkspaceId")]
    public string? SynapseWorkspaceId { get; set; }

    /// <summary>A mapping of tags which should be assigned to the Synapse Spark Pool.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolStatusConditions
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

/// <summary>SparkPoolStatus defines the observed state of SparkPool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SparkPoolStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2SparkPoolStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2SparkPoolStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>SparkPool is the Schema for the SparkPools API. Manages a Synapse Spark Pool.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SparkPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2SparkPoolSpec>, IStatus<V1beta2SparkPoolStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SparkPool";
    public const string KubeGroup = "synapse.azure.upbound.io";
    public const string KubePluralName = "sparkpools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "synapse.azure.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SparkPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SparkPoolSpec defines the desired state of SparkPool</summary>
    [JsonPropertyName("spec")]
    public required V1beta2SparkPoolSpec Spec { get; set; }

    /// <summary>SparkPoolStatus defines the observed state of SparkPool.</summary>
    [JsonPropertyName("status")]
    public V1beta2SparkPoolStatus? Status { get; set; }
}