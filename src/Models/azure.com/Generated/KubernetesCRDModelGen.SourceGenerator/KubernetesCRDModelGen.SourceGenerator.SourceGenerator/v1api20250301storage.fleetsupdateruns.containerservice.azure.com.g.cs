#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerservice.azure.com;
/// <summary>
/// Storage version of v1api20250301.FleetsUpdateRun
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/fleets.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateRuns/{updateRunName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250301storageFleetsUpdateRunList : IKubernetesObject<V1ListMeta>, IItems<V1api20250301storageFleetsUpdateRun>
{
    public const string KubeApiVersion = "v1api20250301storage";
    public const string KubeKind = "FleetsUpdateRunList";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "fleetsupdateruns";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v1api20250301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FleetsUpdateRunList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20250301storageFleetsUpdateRun objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20250301storageFleetsUpdateRun> Items { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.NodeImageSelection
/// The node image upgrade to be applied to the target nodes in update run.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunSpecManagedClusterUpdateNodeImageSelection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ManagedClusterUpgradeSpec
/// The upgrade to apply to a ManagedCluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunSpecManagedClusterUpdateUpgrade
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ManagedClusterUpdate
/// The update to be applied to the ManagedClusters.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunSpecManagedClusterUpdate
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.NodeImageSelection
    /// The node image upgrade to be applied to the target nodes in update run.
    /// </summary>
    [JsonPropertyName("nodeImageSelection")]
    public V1api20250301storageFleetsUpdateRunSpecManagedClusterUpdateNodeImageSelection? NodeImageSelection { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.ManagedClusterUpgradeSpec
    /// The upgrade to apply to a ManagedCluster.
    /// </summary>
    [JsonPropertyName("upgrade")]
    public V1api20250301storageFleetsUpdateRunSpecManagedClusterUpdateUpgrade? Upgrade { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20250301storageFleetsUpdateRunSpecOperatorSpecSecretExpressions
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
/// Storage version of v1api20250301.FleetsUpdateRunOperatorSpec
/// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunSpecOperatorSpec
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20250301storageFleetsUpdateRunSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    [JsonPropertyName("secretExpressions")]
    public IList<V1api20250301storageFleetsUpdateRunSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a containerservice.azure.com/Fleet resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.UpdateGroup
/// A group to be updated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunSpecStrategyStagesGroups
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.UpdateStage
/// Defines a stage which contains the groups to update and the steps to take (e.g., wait for a time period) before starting
/// the next stage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunSpecStrategyStages
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("afterStageWaitInSeconds")]
    public int? AfterStageWaitInSeconds { get; set; }

    [JsonPropertyName("groups")]
    public IList<V1api20250301storageFleetsUpdateRunSpecStrategyStagesGroups>? Groups { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.UpdateRunStrategy
/// Defines the update sequence of the clusters via stages and groups.
/// Stages within a run are executed sequentially one
/// after another.
/// Groups within a stage are executed in parallel.
/// Member clusters within a group are updated sequentially
/// one after another.
/// A valid strategy contains no duplicate groups within or across stages.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunSpecStrategy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("stages")]
    public IList<V1api20250301storageFleetsUpdateRunSpecStrategyStages>? Stages { get; set; }
}

/// <summary>
/// UpdateStrategyReference: The resource id of the FleetUpdateStrategy resource to reference.
/// When creating a new run, there are three ways to define a strategy for the run:
/// 1. Define a new strategy in place: Set the &quot;strategy&quot; field.
/// 2. Use an existing strategy: Set the &quot;updateStrategyId&quot; field. (since 2023-08-15-preview)
/// 3. Use the default strategy to update all the members one by one: Leave both &quot;updateStrategyId&quot; and &quot;strategy&quot; unset.
/// (since 2023-08-15-preview)
/// Setting both &quot;updateStrategyId&quot; and &quot;strategy&quot; is invalid.
/// UpdateRuns created by &quot;updateStrategyId&quot; snapshot the referenced UpdateStrategy at the time of creation and store it in
/// the &quot;strategy&quot; field.
/// Subsequent changes to the referenced FleetUpdateStrategy resource do not propagate.
/// UpdateRunStrategy changes can be made directly on the &quot;strategy&quot; field before launching the UpdateRun.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunSpecUpdateStrategyReference
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

/// <summary>Storage version of v1api20250301.FleetsUpdateRun_Spec</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunSpec
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
    /// Storage version of v1api20250301.ManagedClusterUpdate
    /// The update to be applied to the ManagedClusters.
    /// </summary>
    [JsonPropertyName("managedClusterUpdate")]
    public V1api20250301storageFleetsUpdateRunSpecManagedClusterUpdate? ManagedClusterUpdate { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.FleetsUpdateRunOperatorSpec
    /// Details for configuring operator behavior. Fields in this struct are interpreted by the operator directly rather than being passed to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20250301storageFleetsUpdateRunSpecOperatorSpec? OperatorSpec { get; set; }

    [JsonPropertyName("originalVersion")]
    public string? OriginalVersion { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a containerservice.azure.com/Fleet resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20250301storageFleetsUpdateRunSpecOwner Owner { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.UpdateRunStrategy
    /// Defines the update sequence of the clusters via stages and groups.
    /// Stages within a run are executed sequentially one
    /// after another.
    /// Groups within a stage are executed in parallel.
    /// Member clusters within a group are updated sequentially
    /// one after another.
    /// A valid strategy contains no duplicate groups within or across stages.
    /// </summary>
    [JsonPropertyName("strategy")]
    public V1api20250301storageFleetsUpdateRunSpecStrategy? Strategy { get; set; }

    /// <summary>
    /// UpdateStrategyReference: The resource id of the FleetUpdateStrategy resource to reference.
    /// When creating a new run, there are three ways to define a strategy for the run:
    /// 1. Define a new strategy in place: Set the &quot;strategy&quot; field.
    /// 2. Use an existing strategy: Set the &quot;updateStrategyId&quot; field. (since 2023-08-15-preview)
    /// 3. Use the default strategy to update all the members one by one: Leave both &quot;updateStrategyId&quot; and &quot;strategy&quot; unset.
    /// (since 2023-08-15-preview)
    /// Setting both &quot;updateStrategyId&quot; and &quot;strategy&quot; is invalid.
    /// UpdateRuns created by &quot;updateStrategyId&quot; snapshot the referenced UpdateStrategy at the time of creation and store it in
    /// the &quot;strategy&quot; field.
    /// Subsequent changes to the referenced FleetUpdateStrategy resource do not propagate.
    /// UpdateRunStrategy changes can be made directly on the &quot;strategy&quot; field before launching the UpdateRun.
    /// </summary>
    [JsonPropertyName("updateStrategyReference")]
    public V1api20250301storageFleetsUpdateRunSpecUpdateStrategyReference? UpdateStrategyReference { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusConditions
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
/// Storage version of v1api20250301.NodeImageVersion_STATUS
/// The node upgrade image version.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusManagedClusterUpdateNodeImageSelectionCustomNodeImageVersions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.NodeImageSelection_STATUS
/// The node image upgrade to be applied to the target nodes in update run.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusManagedClusterUpdateNodeImageSelection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("customNodeImageVersions")]
    public IList<V1api20250301storageFleetsUpdateRunStatusManagedClusterUpdateNodeImageSelectionCustomNodeImageVersions>? CustomNodeImageVersions { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ManagedClusterUpgradeSpec_STATUS
/// The upgrade to apply to a ManagedCluster.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusManagedClusterUpdateUpgrade
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ManagedClusterUpdate_STATUS
/// The update to be applied to the ManagedClusters.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusManagedClusterUpdate
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.NodeImageSelection_STATUS
    /// The node image upgrade to be applied to the target nodes in update run.
    /// </summary>
    [JsonPropertyName("nodeImageSelection")]
    public V1api20250301storageFleetsUpdateRunStatusManagedClusterUpdateNodeImageSelection? NodeImageSelection { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.ManagedClusterUpgradeSpec_STATUS
    /// The upgrade to apply to a ManagedCluster.
    /// </summary>
    [JsonPropertyName("upgrade")]
    public V1api20250301storageFleetsUpdateRunStatusManagedClusterUpdateUpgrade? Upgrade { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.NodeImageVersion_STATUS
/// The node upgrade image version.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusNodeImageSelectionSelectedNodeImageVersions
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.NodeImageSelectionStatus_STATUS
/// The node image upgrade specs for the update run.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusNodeImageSelection
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("selectedNodeImageVersions")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusNodeImageSelectionSelectedNodeImageVersions>? SelectedNodeImageVersions { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ErrorAdditionalInfo_STATUS
/// The resource management error additional info.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorAdditionalInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ErrorAdditionalInfo_STATUS
/// The resource management error additional info.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorDetailsAdditionalInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20250301.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ErrorDetail_STATUS
/// The error detail.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorAdditionalInfo>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("details")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorDetails>? Details { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.UpdateStatus_STATUS
/// The status for an operation or group of operations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("completedTime")]
    public string? CompletedTime { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.ErrorDetail_STATUS
    /// The error detail.
    /// </summary>
    [JsonPropertyName("error")]
    public V1api20250301storageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusError? Error { get; set; }

    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.WaitStatus_STATUS
/// The status of the wait duration.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.UpdateStatus_STATUS
    /// The status for an operation or group of operations.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20250301storageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatus? Status { get; set; }

    [JsonPropertyName("waitDurationInSeconds")]
    public int? WaitDurationInSeconds { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ErrorAdditionalInfo_STATUS
/// The resource management error additional info.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorAdditionalInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ErrorAdditionalInfo_STATUS
/// The resource management error additional info.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorDetailsAdditionalInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20250301.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ErrorDetail_STATUS
/// The error detail.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsMembersStatusError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorAdditionalInfo>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("details")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorDetails>? Details { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.UpdateStatus_STATUS
/// The status for an operation or group of operations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsMembersStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("completedTime")]
    public string? CompletedTime { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.ErrorDetail_STATUS
    /// The error detail.
    /// </summary>
    [JsonPropertyName("error")]
    public V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsMembersStatusError? Error { get; set; }

    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.MemberUpdateStatus_STATUS
/// The status of a member update operation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsMembers
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("clusterResourceId")]
    public string? ClusterResourceId { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("operationId")]
    public string? OperationId { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.UpdateStatus_STATUS
    /// The status for an operation or group of operations.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsMembersStatus? Status { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ErrorAdditionalInfo_STATUS
/// The resource management error additional info.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsStatusErrorAdditionalInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ErrorAdditionalInfo_STATUS
/// The resource management error additional info.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsStatusErrorDetailsAdditionalInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20250301.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsStatusErrorDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsStatusErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ErrorDetail_STATUS
/// The error detail.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsStatusError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsStatusErrorAdditionalInfo>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("details")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsStatusErrorDetails>? Details { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.UpdateStatus_STATUS
/// The status for an operation or group of operations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("completedTime")]
    public string? CompletedTime { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.ErrorDetail_STATUS
    /// The error detail.
    /// </summary>
    [JsonPropertyName("error")]
    public V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsStatusError? Error { get; set; }

    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.UpdateGroupStatus_STATUS
/// The status of a UpdateGroup.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesGroups
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("members")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsMembers>? Members { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.UpdateStatus_STATUS
    /// The status for an operation or group of operations.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20250301storageFleetsUpdateRunStatusStatusStagesGroupsStatus? Status { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ErrorAdditionalInfo_STATUS
/// The resource management error additional info.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesStatusErrorAdditionalInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ErrorAdditionalInfo_STATUS
/// The resource management error additional info.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesStatusErrorDetailsAdditionalInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20250301.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesStatusErrorDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStagesStatusErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ErrorDetail_STATUS
/// The error detail.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesStatusError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStagesStatusErrorAdditionalInfo>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("details")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStagesStatusErrorDetails>? Details { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.UpdateStatus_STATUS
/// The status for an operation or group of operations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStagesStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("completedTime")]
    public string? CompletedTime { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.ErrorDetail_STATUS
    /// The error detail.
    /// </summary>
    [JsonPropertyName("error")]
    public V1api20250301storageFleetsUpdateRunStatusStatusStagesStatusError? Error { get; set; }

    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.UpdateStageStatus_STATUS
/// The status of a UpdateStage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStages
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.WaitStatus_STATUS
    /// The status of the wait duration.
    /// </summary>
    [JsonPropertyName("afterStageWaitStatus")]
    public V1api20250301storageFleetsUpdateRunStatusStatusStagesAfterStageWaitStatus? AfterStageWaitStatus { get; set; }

    [JsonPropertyName("groups")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStagesGroups>? Groups { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.UpdateStatus_STATUS
    /// The status for an operation or group of operations.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20250301storageFleetsUpdateRunStatusStatusStagesStatus? Status { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ErrorAdditionalInfo_STATUS
/// The resource management error additional info.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStatusErrorAdditionalInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ErrorAdditionalInfo_STATUS
/// The resource management error additional info.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStatusErrorDetailsAdditionalInfo
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Storage version of v1api20250301.ErrorDetail_STATUS_Unrolled</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStatusErrorDetails
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStatusErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.ErrorDetail_STATUS
/// The error detail.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStatusError
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStatusErrorAdditionalInfo>? AdditionalInfo { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("details")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStatusErrorDetails>? Details { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.UpdateStatus_STATUS
/// The status for an operation or group of operations.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatusStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("completedTime")]
    public string? CompletedTime { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.ErrorDetail_STATUS
    /// The error detail.
    /// </summary>
    [JsonPropertyName("error")]
    public V1api20250301storageFleetsUpdateRunStatusStatusStatusError? Error { get; set; }

    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.UpdateRunStatus_STATUS
/// The status of a UpdateRun.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.NodeImageSelectionStatus_STATUS
    /// The node image upgrade specs for the update run.
    /// </summary>
    [JsonPropertyName("nodeImageSelection")]
    public V1api20250301storageFleetsUpdateRunStatusStatusNodeImageSelection? NodeImageSelection { get; set; }

    [JsonPropertyName("stages")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStatusStages>? Stages { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.UpdateStatus_STATUS
    /// The status for an operation or group of operations.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20250301storageFleetsUpdateRunStatusStatusStatus? Status { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.UpdateGroup_STATUS
/// A group to be updated.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStrategyStagesGroups
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.UpdateStage_STATUS
/// Defines a stage which contains the groups to update and the steps to take (e.g., wait for a time period) before starting
/// the next stage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStrategyStages
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("afterStageWaitInSeconds")]
    public int? AfterStageWaitInSeconds { get; set; }

    [JsonPropertyName("groups")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStrategyStagesGroups>? Groups { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.UpdateRunStrategy_STATUS
/// Defines the update sequence of the clusters via stages and groups.
/// Stages within a run are executed sequentially one
/// after another.
/// Groups within a stage are executed in parallel.
/// Member clusters within a group are updated sequentially
/// one after another.
/// A valid strategy contains no duplicate groups within or across stages.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusStrategy
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("stages")]
    public IList<V1api20250301storageFleetsUpdateRunStatusStrategyStages>? Stages { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.SystemData_STATUS
/// Metadata pertaining to creation and last modification of the resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatusSystemData
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

/// <summary>Storage version of v1api20250301.FleetsUpdateRun_STATUS</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301storageFleetsUpdateRunStatus
{
    /// <summary>
    /// PropertyBag is an unordered set of stashed information that used for properties not directly supported by storage
    /// resources, allowing for full fidelity round trip conversions
    /// </summary>
    [JsonPropertyName("$propertyBag")]
    public IDictionary<string, string>? PropertyBag { get; set; }

    [JsonPropertyName("autoUpgradeProfileId")]
    public string? AutoUpgradeProfileId { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1api20250301storageFleetsUpdateRunStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.ManagedClusterUpdate_STATUS
    /// The update to be applied to the ManagedClusters.
    /// </summary>
    [JsonPropertyName("managedClusterUpdate")]
    public V1api20250301storageFleetsUpdateRunStatusManagedClusterUpdate? ManagedClusterUpdate { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.UpdateRunStatus_STATUS
    /// The status of a UpdateRun.
    /// </summary>
    [JsonPropertyName("status")]
    public V1api20250301storageFleetsUpdateRunStatusStatus? Status { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.UpdateRunStrategy_STATUS
    /// Defines the update sequence of the clusters via stages and groups.
    /// Stages within a run are executed sequentially one
    /// after another.
    /// Groups within a stage are executed in parallel.
    /// Member clusters within a group are updated sequentially
    /// one after another.
    /// A valid strategy contains no duplicate groups within or across stages.
    /// </summary>
    [JsonPropertyName("strategy")]
    public V1api20250301storageFleetsUpdateRunStatusStrategy? Strategy { get; set; }

    /// <summary>
    /// Storage version of v1api20250301.SystemData_STATUS
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    [JsonPropertyName("systemData")]
    public V1api20250301storageFleetsUpdateRunStatusSystemData? SystemData { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("updateStrategyId")]
    public string? UpdateStrategyId { get; set; }
}

/// <summary>
/// Storage version of v1api20250301.FleetsUpdateRun
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/fleets.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateRuns/{updateRunName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250301storageFleetsUpdateRun : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20250301storageFleetsUpdateRunSpec?>, IStatus<V1api20250301storageFleetsUpdateRunStatus?>
{
    public const string KubeApiVersion = "v1api20250301storage";
    public const string KubeKind = "FleetsUpdateRun";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "fleetsupdateruns";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v1api20250301storage";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FleetsUpdateRun";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>Storage version of v1api20250301.FleetsUpdateRun_Spec</summary>
    [JsonPropertyName("spec")]
    public V1api20250301storageFleetsUpdateRunSpec? Spec { get; set; }

    /// <summary>Storage version of v1api20250301.FleetsUpdateRun_STATUS</summary>
    [JsonPropertyName("status")]
    public V1api20250301storageFleetsUpdateRunStatus? Status { get; set; }
}