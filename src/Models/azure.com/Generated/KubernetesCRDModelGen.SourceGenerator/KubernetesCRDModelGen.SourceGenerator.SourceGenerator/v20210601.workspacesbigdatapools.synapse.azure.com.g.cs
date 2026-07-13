#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.synapse.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/bigDataPool.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/bigDataPools/{bigDataPoolName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20210601WorkspacesBigDataPoolList : IKubernetesObject<V1ListMeta>, IItems<V20210601WorkspacesBigDataPool>
{
    public const string KubeApiVersion = "v20210601";
    public const string KubeKind = "WorkspacesBigDataPoolList";
    public const string KubeGroup = "synapse.azure.com";
    public const string KubePluralName = "workspacesbigdatapools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "synapse.azure.com/v20210601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspacesBigDataPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20210601WorkspacesBigDataPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20210601WorkspacesBigDataPool> Items { get; set; }
}

/// <summary>AutoPause: Auto-pausing properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolSpecAutoPause
{
    /// <summary>DelayInMinutes: Number of minutes of idle time before the Big Data pool is automatically paused.</summary>
    [JsonPropertyName("delayInMinutes")]
    public int? DelayInMinutes { get; set; }

    /// <summary>Enabled: Whether auto-pausing is enabled for the Big Data pool.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>AutoScale: Auto-scaling properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolSpecAutoScale
{
    /// <summary>Enabled: Whether automatic scaling is enabled for the Big Data pool.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>MaxNodeCount: The maximum number of nodes the Big Data pool can support.</summary>
    [JsonPropertyName("maxNodeCount")]
    public int? MaxNodeCount { get; set; }

    /// <summary>MinNodeCount: The minimum number of nodes the Big Data pool can support.</summary>
    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }
}

/// <summary>Library/package information of a Big Data pool powered by Apache Spark</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolSpecCustomLibraries
{
    /// <summary>ContainerName: Storage blob container name.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Name: Name of the library.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path: Storage blob path of library.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>Type: Type of the library.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>DynamicExecutorAllocation: Dynamic Executor Allocation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolSpecDynamicExecutorAllocation
{
    /// <summary>Enabled: Indicates whether Dynamic Executor Allocation is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>MaxExecutors: The maximum number of executors alloted</summary>
    [JsonPropertyName("maxExecutors")]
    public int? MaxExecutors { get; set; }

    /// <summary>MinExecutors: The minimum number of executors alloted</summary>
    [JsonPropertyName("minExecutors")]
    public int? MinExecutors { get; set; }
}

/// <summary>LibraryRequirements: Library version requirements</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolSpecLibraryRequirements
{
    /// <summary>Content: The library requirements.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Filename: The filename of the library requirements file.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}

/// <summary>NodeSize: The level of compute power that each node in the Big Data pool has.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20210601WorkspacesBigDataPoolSpecNodeSizeEnum>))]
public enum V20210601WorkspacesBigDataPoolSpecNodeSizeEnum
{
    [EnumMember(Value = "Large"), JsonStringEnumMemberName("Large")]
    Large,
    [EnumMember(Value = "Medium"), JsonStringEnumMemberName("Medium")]
    Medium,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None,
    [EnumMember(Value = "Small"), JsonStringEnumMemberName("Small")]
    Small,
    [EnumMember(Value = "XLarge"), JsonStringEnumMemberName("XLarge")]
    XLarge,
    [EnumMember(Value = "XXLarge"), JsonStringEnumMemberName("XXLarge")]
    XXLarge,
    [EnumMember(Value = "XXXLarge"), JsonStringEnumMemberName("XXXLarge")]
    XXXLarge
}

/// <summary>NodeSizeFamily: The kind of nodes that the Big Data pool provides.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20210601WorkspacesBigDataPoolSpecNodeSizeFamilyEnum>))]
public enum V20210601WorkspacesBigDataPoolSpecNodeSizeFamilyEnum
{
    [EnumMember(Value = "HardwareAcceleratedFPGA"), JsonStringEnumMemberName("HardwareAcceleratedFPGA")]
    HardwareAcceleratedFPGA,
    [EnumMember(Value = "HardwareAcceleratedGPU"), JsonStringEnumMemberName("HardwareAcceleratedGPU")]
    HardwareAcceleratedGPU,
    [EnumMember(Value = "MemoryOptimized"), JsonStringEnumMemberName("MemoryOptimized")]
    MemoryOptimized,
    [EnumMember(Value = "None"), JsonStringEnumMemberName("None")]
    None
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolSpecOperatorSpecConfigMapExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolSpecOperatorSpecSecretExpressions
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20210601WorkspacesBigDataPoolSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20210601WorkspacesBigDataPoolSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a synapse.azure.com/Workspace resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>ConfigurationType: The type of the spark config properties file.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20210601WorkspacesBigDataPoolSpecSparkConfigPropertiesConfigurationTypeEnum>))]
public enum V20210601WorkspacesBigDataPoolSpecSparkConfigPropertiesConfigurationTypeEnum
{
    [EnumMember(Value = "Artifact"), JsonStringEnumMemberName("Artifact")]
    Artifact,
    [EnumMember(Value = "File"), JsonStringEnumMemberName("File")]
    File
}

/// <summary>SparkConfigProperties: Spark configuration file to specify additional properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolSpecSparkConfigProperties
{
    /// <summary>ConfigurationType: The type of the spark config properties file.</summary>
    [JsonPropertyName("configurationType")]
    public V20210601WorkspacesBigDataPoolSpecSparkConfigPropertiesConfigurationTypeEnum? ConfigurationType { get; set; }

    /// <summary>Content: The spark config properties.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Filename: The filename of the spark config properties file.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolSpec
{
    /// <summary>AutoPause: Auto-pausing properties</summary>
    [JsonPropertyName("autoPause")]
    public V20210601WorkspacesBigDataPoolSpecAutoPause? AutoPause { get; set; }

    /// <summary>AutoScale: Auto-scaling properties</summary>
    [JsonPropertyName("autoScale")]
    public V20210601WorkspacesBigDataPoolSpecAutoScale? AutoScale { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>CacheSize: The cache size</summary>
    [JsonPropertyName("cacheSize")]
    public int? CacheSize { get; set; }

    /// <summary>CustomLibraries: List of custom libraries/packages associated with the spark pool.</summary>
    [JsonPropertyName("customLibraries")]
    public IList<V20210601WorkspacesBigDataPoolSpecCustomLibraries>? CustomLibraries { get; set; }

    /// <summary>DefaultSparkLogFolder: The default folder where Spark logs will be written.</summary>
    [JsonPropertyName("defaultSparkLogFolder")]
    public string? DefaultSparkLogFolder { get; set; }

    /// <summary>DynamicExecutorAllocation: Dynamic Executor Allocation</summary>
    [JsonPropertyName("dynamicExecutorAllocation")]
    public V20210601WorkspacesBigDataPoolSpecDynamicExecutorAllocation? DynamicExecutorAllocation { get; set; }

    /// <summary>IsAutotuneEnabled: Whether autotune is required or not.</summary>
    [JsonPropertyName("isAutotuneEnabled")]
    public bool? IsAutotuneEnabled { get; set; }

    /// <summary>IsComputeIsolationEnabled: Whether compute isolation is required or not.</summary>
    [JsonPropertyName("isComputeIsolationEnabled")]
    public bool? IsComputeIsolationEnabled { get; set; }

    /// <summary>LibraryRequirements: Library version requirements</summary>
    [JsonPropertyName("libraryRequirements")]
    public V20210601WorkspacesBigDataPoolSpecLibraryRequirements? LibraryRequirements { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>NodeCount: The number of nodes in the Big Data pool.</summary>
    [JsonPropertyName("nodeCount")]
    public int? NodeCount { get; set; }

    /// <summary>NodeSize: The level of compute power that each node in the Big Data pool has.</summary>
    [JsonPropertyName("nodeSize")]
    public V20210601WorkspacesBigDataPoolSpecNodeSizeEnum? NodeSize { get; set; }

    /// <summary>NodeSizeFamily: The kind of nodes that the Big Data pool provides.</summary>
    [JsonPropertyName("nodeSizeFamily")]
    public V20210601WorkspacesBigDataPoolSpecNodeSizeFamilyEnum? NodeSizeFamily { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20210601WorkspacesBigDataPoolSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a synapse.azure.com/Workspace resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20210601WorkspacesBigDataPoolSpecOwner Owner { get; set; }

    /// <summary>ProvisioningState: The state of the Big Data pool.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>SessionLevelPackagesEnabled: Whether session level packages enabled.</summary>
    [JsonPropertyName("sessionLevelPackagesEnabled")]
    public bool? SessionLevelPackagesEnabled { get; set; }

    /// <summary>SparkConfigProperties: Spark configuration file to specify additional properties</summary>
    [JsonPropertyName("sparkConfigProperties")]
    public V20210601WorkspacesBigDataPoolSpecSparkConfigProperties? SparkConfigProperties { get; set; }

    /// <summary>SparkEventsFolder: The Spark events folder</summary>
    [JsonPropertyName("sparkEventsFolder")]
    public string? SparkEventsFolder { get; set; }

    /// <summary>SparkVersion: The Apache Spark version.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>AutoPause: Auto-pausing properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolStatusAutoPause
{
    /// <summary>DelayInMinutes: Number of minutes of idle time before the Big Data pool is automatically paused.</summary>
    [JsonPropertyName("delayInMinutes")]
    public int? DelayInMinutes { get; set; }

    /// <summary>Enabled: Whether auto-pausing is enabled for the Big Data pool.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>AutoScale: Auto-scaling properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolStatusAutoScale
{
    /// <summary>Enabled: Whether automatic scaling is enabled for the Big Data pool.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>MaxNodeCount: The maximum number of nodes the Big Data pool can support.</summary>
    [JsonPropertyName("maxNodeCount")]
    public int? MaxNodeCount { get; set; }

    /// <summary>MinNodeCount: The minimum number of nodes the Big Data pool can support.</summary>
    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolStatusConditions
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

/// <summary>Library/package information of a Big Data pool powered by Apache Spark</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolStatusCustomLibraries
{
    /// <summary>ContainerName: Storage blob container name.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>CreatorId: Creator Id of the library/package.</summary>
    [JsonPropertyName("creatorId")]
    public string? CreatorId { get; set; }

    /// <summary>Name: Name of the library.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Path: Storage blob path of library.</summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>ProvisioningStatus: Provisioning status of the library/package.</summary>
    [JsonPropertyName("provisioningStatus")]
    public string? ProvisioningStatus { get; set; }

    /// <summary>Type: Type of the library.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>UploadedTimestamp: The last update time of the library.</summary>
    [JsonPropertyName("uploadedTimestamp")]
    public string? UploadedTimestamp { get; set; }
}

/// <summary>DynamicExecutorAllocation: Dynamic Executor Allocation</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolStatusDynamicExecutorAllocation
{
    /// <summary>Enabled: Indicates whether Dynamic Executor Allocation is enabled or not.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>MaxExecutors: The maximum number of executors alloted</summary>
    [JsonPropertyName("maxExecutors")]
    public int? MaxExecutors { get; set; }

    /// <summary>MinExecutors: The minimum number of executors alloted</summary>
    [JsonPropertyName("minExecutors")]
    public int? MinExecutors { get; set; }
}

/// <summary>LibraryRequirements: Library version requirements</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolStatusLibraryRequirements
{
    /// <summary>Content: The library requirements.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Filename: The filename of the library requirements file.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>Time: The last update time of the library requirements file.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>SparkConfigProperties: Spark configuration file to specify additional properties</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolStatusSparkConfigProperties
{
    /// <summary>ConfigurationType: The type of the spark config properties file.</summary>
    [JsonPropertyName("configurationType")]
    public string? ConfigurationType { get; set; }

    /// <summary>Content: The spark config properties.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Filename: The filename of the spark config properties file.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    /// <summary>Time: The last update time of the spark config properties file.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20210601WorkspacesBigDataPoolStatus
{
    /// <summary>AutoPause: Auto-pausing properties</summary>
    [JsonPropertyName("autoPause")]
    public V20210601WorkspacesBigDataPoolStatusAutoPause? AutoPause { get; set; }

    /// <summary>AutoScale: Auto-scaling properties</summary>
    [JsonPropertyName("autoScale")]
    public V20210601WorkspacesBigDataPoolStatusAutoScale? AutoScale { get; set; }

    /// <summary>CacheSize: The cache size</summary>
    [JsonPropertyName("cacheSize")]
    public int? CacheSize { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20210601WorkspacesBigDataPoolStatusConditions>? Conditions { get; set; }

    /// <summary>CreationDate: The time when the Big Data pool was created.</summary>
    [JsonPropertyName("creationDate")]
    public string? CreationDate { get; set; }

    /// <summary>CustomLibraries: List of custom libraries/packages associated with the spark pool.</summary>
    [JsonPropertyName("customLibraries")]
    public IList<V20210601WorkspacesBigDataPoolStatusCustomLibraries>? CustomLibraries { get; set; }

    /// <summary>DefaultSparkLogFolder: The default folder where Spark logs will be written.</summary>
    [JsonPropertyName("defaultSparkLogFolder")]
    public string? DefaultSparkLogFolder { get; set; }

    /// <summary>DynamicExecutorAllocation: Dynamic Executor Allocation</summary>
    [JsonPropertyName("dynamicExecutorAllocation")]
    public V20210601WorkspacesBigDataPoolStatusDynamicExecutorAllocation? DynamicExecutorAllocation { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. Ex -
    /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>IsAutotuneEnabled: Whether autotune is required or not.</summary>
    [JsonPropertyName("isAutotuneEnabled")]
    public bool? IsAutotuneEnabled { get; set; }

    /// <summary>IsComputeIsolationEnabled: Whether compute isolation is required or not.</summary>
    [JsonPropertyName("isComputeIsolationEnabled")]
    public bool? IsComputeIsolationEnabled { get; set; }

    /// <summary>LastSucceededTimestamp: The time when the Big Data pool was updated successfully.</summary>
    [JsonPropertyName("lastSucceededTimestamp")]
    public string? LastSucceededTimestamp { get; set; }

    /// <summary>LibraryRequirements: Library version requirements</summary>
    [JsonPropertyName("libraryRequirements")]
    public V20210601WorkspacesBigDataPoolStatusLibraryRequirements? LibraryRequirements { get; set; }

    /// <summary>Location: The geo-location where the resource lives</summary>
    [JsonPropertyName("location")]
    public string? Location { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NodeCount: The number of nodes in the Big Data pool.</summary>
    [JsonPropertyName("nodeCount")]
    public int? NodeCount { get; set; }

    /// <summary>NodeSize: The level of compute power that each node in the Big Data pool has.</summary>
    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    /// <summary>NodeSizeFamily: The kind of nodes that the Big Data pool provides.</summary>
    [JsonPropertyName("nodeSizeFamily")]
    public string? NodeSizeFamily { get; set; }

    /// <summary>ProvisioningState: The state of the Big Data pool.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>SessionLevelPackagesEnabled: Whether session level packages enabled.</summary>
    [JsonPropertyName("sessionLevelPackagesEnabled")]
    public bool? SessionLevelPackagesEnabled { get; set; }

    /// <summary>SparkConfigProperties: Spark configuration file to specify additional properties</summary>
    [JsonPropertyName("sparkConfigProperties")]
    public V20210601WorkspacesBigDataPoolStatusSparkConfigProperties? SparkConfigProperties { get; set; }

    /// <summary>SparkEventsFolder: The Spark events folder</summary>
    [JsonPropertyName("sparkEventsFolder")]
    public string? SparkEventsFolder { get; set; }

    /// <summary>SparkVersion: The Apache Spark version.</summary>
    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    /// <summary>Tags: Resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/bigDataPool.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/bigDataPools/{bigDataPoolName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20210601WorkspacesBigDataPool : IKubernetesObject<V1ObjectMeta>, ISpec<V20210601WorkspacesBigDataPoolSpec?>, IStatus<V20210601WorkspacesBigDataPoolStatus?>
{
    public const string KubeApiVersion = "v20210601";
    public const string KubeKind = "WorkspacesBigDataPool";
    public const string KubeGroup = "synapse.azure.com";
    public const string KubePluralName = "workspacesbigdatapools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "synapse.azure.com/v20210601";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspacesBigDataPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20210601WorkspacesBigDataPoolSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20210601WorkspacesBigDataPoolStatus? Status { get; set; }
}