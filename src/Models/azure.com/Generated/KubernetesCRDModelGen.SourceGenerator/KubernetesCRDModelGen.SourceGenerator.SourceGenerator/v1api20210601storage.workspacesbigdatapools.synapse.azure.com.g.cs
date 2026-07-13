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
/// Storage version of v1api20210601.WorkspacesBigDataPool
/// Generator information:
/// - Generated from: /synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/bigDataPool.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/bigDataPools/{bigDataPoolName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210601storageWorkspacesBigDataPoolList : IKubernetesObject<V1ListMeta>, IItems<V1api20210601storageWorkspacesBigDataPool>
{
    public const string KubeApiVersion = "v1api20210601storage";
    public const string KubeKind = "WorkspacesBigDataPoolList";
    public const string KubeGroup = "synapse.azure.com";
    public const string KubePluralName = "workspacesbigdatapools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "synapse.azure.com/v1api20210601storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspacesBigDataPoolList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20210601storageWorkspacesBigDataPool objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20210601storageWorkspacesBigDataPool> Items { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.AutoPauseProperties
/// Auto-pausing properties of a Big Data pool powered by Apache Spark
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecAutoPause
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("delayInMinutes")]
    public int? DelayInMinutes { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.AutoScaleProperties
/// Auto-scaling properties of a Big Data pool powered by Apache Spark
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecAutoScale
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("maxNodeCount")]
    public int? MaxNodeCount { get; set; }

    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.LibraryInfo
/// Library/package information of a Big Data pool powered by Apache Spark
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecCustomLibraries
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.DynamicExecutorAllocation
/// Dynamic Executor Allocation Properties
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecDynamicExecutorAllocation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("maxExecutors")]
    public int? MaxExecutors { get; set; }

    [JsonPropertyName("minExecutors")]
    public int? MinExecutors { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.LibraryRequirements
/// Library requirements for a Big Data pool powered by Apache Spark
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecLibraryRequirements
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("content")]
    public string? Content { get; set; }

    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20210601storageWorkspacesBigDataPoolSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20210601.WorkspacesBigDataPoolOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20210601storageWorkspacesBigDataPoolSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20210601storageWorkspacesBigDataPoolSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a synapse.azure.com/Workspace resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.SparkConfigProperties
/// SparkConfig Properties for a Big Data pool powered by Apache Spark
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpecSparkConfigProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configurationType")]
    public string? ConfigurationType { get; set; }

    [JsonPropertyName("content")]
    public string? Content { get; set; }

    [JsonPropertyName("filename")]
    public string? Filename { get; set; }
}

/// <summary>Storage version of v1api20210601.WorkspacesBigDataPool_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.AutoPauseProperties
    /// Auto-pausing properties of a Big Data pool powered by Apache Spark
    /// </summary>
    [JsonPropertyName("autoPause")]
    public V1api20210601storageWorkspacesBigDataPoolSpecAutoPause? AutoPause { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.AutoScaleProperties
    /// Auto-scaling properties of a Big Data pool powered by Apache Spark
    /// </summary>
    [JsonPropertyName("autoScale")]
    public V1api20210601storageWorkspacesBigDataPoolSpecAutoScale? AutoScale { get; set; }

    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    [JsonPropertyName("cacheSize")]
    public int? CacheSize { get; set; }

    [JsonPropertyName("customLibraries")]
    public IList<V1api20210601storageWorkspacesBigDataPoolSpecCustomLibraries>? CustomLibraries { get; set; }

    [JsonPropertyName("defaultSparkLogFolder")]
    public string? DefaultSparkLogFolder { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.DynamicExecutorAllocation
    /// Dynamic Executor Allocation Properties
    /// </summary>
    [JsonPropertyName("dynamicExecutorAllocation")]
    public V1api20210601storageWorkspacesBigDataPoolSpecDynamicExecutorAllocation? DynamicExecutorAllocation { get; set; }

    [JsonPropertyName("isAutotuneEnabled")]
    public bool? IsAutotuneEnabled { get; set; }

    [JsonPropertyName("isComputeIsolationEnabled")]
    public bool? IsComputeIsolationEnabled { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.LibraryRequirements
    /// Library requirements for a Big Data pool powered by Apache Spark
    /// </summary>
    [JsonPropertyName("libraryRequirements")]
    public V1api20210601storageWorkspacesBigDataPoolSpecLibraryRequirements? LibraryRequirements { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("nodeCount")]
    public int? NodeCount { get; set; }

    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    [JsonPropertyName("nodeSizeFamily")]
    public string? NodeSizeFamily { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.WorkspacesBigDataPoolOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20210601storageWorkspacesBigDataPoolSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a synapse.azure.com/Workspace resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20210601storageWorkspacesBigDataPoolSpecOwner Owner { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("sessionLevelPackagesEnabled")]
    public bool? SessionLevelPackagesEnabled { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.SparkConfigProperties
    /// SparkConfig Properties for a Big Data pool powered by Apache Spark
    /// </summary>
    [JsonPropertyName("sparkConfigProperties")]
    public V1api20210601storageWorkspacesBigDataPoolSpecSparkConfigProperties? SparkConfigProperties { get; set; }

    [JsonPropertyName("sparkEventsFolder")]
    public string? SparkEventsFolder { get; set; }

    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.AutoPauseProperties_STATUS
/// Auto-pausing properties of a Big Data pool powered by Apache Spark
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolStatusAutoPause
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("delayInMinutes")]
    public int? DelayInMinutes { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.AutoScaleProperties_STATUS
/// Auto-scaling properties of a Big Data pool powered by Apache Spark
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolStatusAutoScale
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("maxNodeCount")]
    public int? MaxNodeCount { get; set; }

    [JsonPropertyName("minNodeCount")]
    public int? MinNodeCount { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolStatusConditions
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
/// Storage version of v1api20210601.LibraryInfo_STATUS
/// Library/package information of a Big Data pool powered by Apache Spark
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolStatusCustomLibraries
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    [JsonPropertyName("creatorId")]
    public string? CreatorId { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("provisioningStatus")]
    public string? ProvisioningStatus { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("uploadedTimestamp")]
    public string? UploadedTimestamp { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.DynamicExecutorAllocation_STATUS
/// Dynamic Executor Allocation Properties
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolStatusDynamicExecutorAllocation
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    [JsonPropertyName("maxExecutors")]
    public int? MaxExecutors { get; set; }

    [JsonPropertyName("minExecutors")]
    public int? MinExecutors { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.LibraryRequirements_STATUS
/// Library requirements for a Big Data pool powered by Apache Spark
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolStatusLibraryRequirements
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("content")]
    public string? Content { get; set; }

    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.SparkConfigProperties_STATUS
/// SparkConfig Properties for a Big Data pool powered by Apache Spark
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolStatusSparkConfigProperties
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configurationType")]
    public string? ConfigurationType { get; set; }

    [JsonPropertyName("content")]
    public string? Content { get; set; }

    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

    [JsonPropertyName("time")]
    public string? Time { get; set; }
}

/// <summary>Storage version of v1api20210601.WorkspacesBigDataPool_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20210601storageWorkspacesBigDataPoolStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.AutoPauseProperties_STATUS
    /// Auto-pausing properties of a Big Data pool powered by Apache Spark
    /// </summary>
    [JsonPropertyName("autoPause")]
    public V1api20210601storageWorkspacesBigDataPoolStatusAutoPause? AutoPause { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.AutoScaleProperties_STATUS
    /// Auto-scaling properties of a Big Data pool powered by Apache Spark
    /// </summary>
    [JsonPropertyName("autoScale")]
    public V1api20210601storageWorkspacesBigDataPoolStatusAutoScale? AutoScale { get; set; }

    [JsonPropertyName("cacheSize")]
    public int? CacheSize { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20210601storageWorkspacesBigDataPoolStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("creationDate")]
    public string? CreationDate { get; set; }

    [JsonPropertyName("customLibraries")]
    public IList<V1api20210601storageWorkspacesBigDataPoolStatusCustomLibraries>? CustomLibraries { get; set; }

    [JsonPropertyName("defaultSparkLogFolder")]
    public string? DefaultSparkLogFolder { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.DynamicExecutorAllocation_STATUS
    /// Dynamic Executor Allocation Properties
    /// </summary>
    [JsonPropertyName("dynamicExecutorAllocation")]
    public V1api20210601storageWorkspacesBigDataPoolStatusDynamicExecutorAllocation? DynamicExecutorAllocation { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("isAutotuneEnabled")]
    public bool? IsAutotuneEnabled { get; set; }

    [JsonPropertyName("isComputeIsolationEnabled")]
    public bool? IsComputeIsolationEnabled { get; set; }

    [JsonPropertyName("lastSucceededTimestamp")]
    public string? LastSucceededTimestamp { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.LibraryRequirements_STATUS
    /// Library requirements for a Big Data pool powered by Apache Spark
    /// </summary>
    [JsonPropertyName("libraryRequirements")]
    public V1api20210601storageWorkspacesBigDataPoolStatusLibraryRequirements? LibraryRequirements { get; set; }

    [JsonPropertyName("location")]
    public string? Location { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("nodeCount")]
    public int? NodeCount { get; set; }

    [JsonPropertyName("nodeSize")]
    public string? NodeSize { get; set; }

    [JsonPropertyName("nodeSizeFamily")]
    public string? NodeSizeFamily { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    [JsonPropertyName("sessionLevelPackagesEnabled")]
    public bool? SessionLevelPackagesEnabled { get; set; }

    /// <summary>
    /// Storage version of v1api20210601.SparkConfigProperties_STATUS
    /// SparkConfig Properties for a Big Data pool powered by Apache Spark
    /// </summary>
    [JsonPropertyName("sparkConfigProperties")]
    public V1api20210601storageWorkspacesBigDataPoolStatusSparkConfigProperties? SparkConfigProperties { get; set; }

    [JsonPropertyName("sparkEventsFolder")]
    public string? SparkEventsFolder { get; set; }

    [JsonPropertyName("sparkVersion")]
    public string? SparkVersion { get; set; }

    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20210601.WorkspacesBigDataPool
/// Generator information:
/// - Generated from: /synapse/resource-manager/Microsoft.Synapse/stable/2021-06-01/bigDataPool.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/bigDataPools/{bigDataPoolName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20210601storageWorkspacesBigDataPool : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20210601storageWorkspacesBigDataPoolSpec?>, IStatus<V1api20210601storageWorkspacesBigDataPoolStatus?>
{
    public const string KubeApiVersion = "v1api20210601storage";
    public const string KubeKind = "WorkspacesBigDataPool";
    public const string KubeGroup = "synapse.azure.com";
    public const string KubePluralName = "workspacesbigdatapools";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "synapse.azure.com/v1api20210601storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "WorkspacesBigDataPool";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20210601.WorkspacesBigDataPool_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20210601storageWorkspacesBigDataPoolSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20210601.WorkspacesBigDataPool_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20210601storageWorkspacesBigDataPoolStatus? Status { get; set; }
}