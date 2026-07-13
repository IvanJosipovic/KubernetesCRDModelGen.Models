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
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/fleets.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateRuns/{updateRunName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250301FleetsUpdateRunList : IKubernetesObject<V1ListMeta>, IItems<V1api20250301FleetsUpdateRun>
{
    public const string KubeApiVersion = "v1api20250301";
    public const string KubeKind = "FleetsUpdateRunList";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "fleetsupdateruns";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v1api20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FleetsUpdateRunList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1api20250301FleetsUpdateRun objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1api20250301FleetsUpdateRun> Items { get; set; }
}

/// <summary>Type: The node image upgrade type.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250301FleetsUpdateRunSpecManagedClusterUpdateNodeImageSelectionTypeEnum>))]
public enum V1api20250301FleetsUpdateRunSpecManagedClusterUpdateNodeImageSelectionTypeEnum
{
    [EnumMember(Value = "Consistent"), JsonStringEnumMemberName("Consistent")]
    Consistent,
    [EnumMember(Value = "Custom"), JsonStringEnumMemberName("Custom")]
    Custom,
    [EnumMember(Value = "Latest"), JsonStringEnumMemberName("Latest")]
    Latest
}

/// <summary>NodeImageSelection: The node image upgrade to be applied to the target nodes in update run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunSpecManagedClusterUpdateNodeImageSelection
{
    /// <summary>Type: The node image upgrade type.</summary>
    [JsonPropertyName("type")]
    public required V1api20250301FleetsUpdateRunSpecManagedClusterUpdateNodeImageSelectionTypeEnum Type { get; set; }
}

/// <summary>Type: ManagedClusterUpgradeType is the type of upgrade to be applied.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1api20250301FleetsUpdateRunSpecManagedClusterUpdateUpgradeTypeEnum>))]
public enum V1api20250301FleetsUpdateRunSpecManagedClusterUpdateUpgradeTypeEnum
{
    [EnumMember(Value = "ControlPlaneOnly"), JsonStringEnumMemberName("ControlPlaneOnly")]
    ControlPlaneOnly,
    [EnumMember(Value = "Full"), JsonStringEnumMemberName("Full")]
    Full,
    [EnumMember(Value = "NodeImageOnly"), JsonStringEnumMemberName("NodeImageOnly")]
    NodeImageOnly
}

/// <summary>Upgrade: The upgrade to apply to the ManagedClusters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunSpecManagedClusterUpdateUpgrade
{
    /// <summary>KubernetesVersion: The Kubernetes version to upgrade the member clusters to.</summary>
    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary>Type: ManagedClusterUpgradeType is the type of upgrade to be applied.</summary>
    [JsonPropertyName("type")]
    public required V1api20250301FleetsUpdateRunSpecManagedClusterUpdateUpgradeTypeEnum Type { get; set; }
}

/// <summary>
/// ManagedClusterUpdate: The update to be applied to all clusters in the UpdateRun. The managedClusterUpdate can be
/// modified until the run is started.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunSpecManagedClusterUpdate
{
    /// <summary>NodeImageSelection: The node image upgrade to be applied to the target nodes in update run.</summary>
    [JsonPropertyName("nodeImageSelection")]
    public V1api20250301FleetsUpdateRunSpecManagedClusterUpdateNodeImageSelection? NodeImageSelection { get; set; }

    /// <summary>Upgrade: The upgrade to apply to the ManagedClusters.</summary>
    [JsonPropertyName("upgrade")]
    public required V1api20250301FleetsUpdateRunSpecManagedClusterUpdateUpgrade Upgrade { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunSpecOperatorSpecConfigMapExpressions
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
public partial class V1api20250301FleetsUpdateRunSpecOperatorSpecSecretExpressions
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
public partial class V1api20250301FleetsUpdateRunSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V1api20250301FleetsUpdateRunSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V1api20250301FleetsUpdateRunSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a containerservice.azure.com/Fleet resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>A group to be updated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunSpecStrategyStagesGroups
{
    /// <summary>
    /// Name: Name of the group.
    /// It must match a group name of an existing fleet member.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Defines a stage which contains the groups to update and the steps to take (e.g., wait for a time period) before starting
/// the next stage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunSpecStrategyStages
{
    /// <summary>
    /// AfterStageWaitInSeconds: The time in seconds to wait at the end of this stage before starting the next one. Defaults to
    /// 0 seconds if unspecified.
    /// </summary>
    [JsonPropertyName("afterStageWaitInSeconds")]
    public int? AfterStageWaitInSeconds { get; set; }

    /// <summary>Groups: Defines the groups to be executed in parallel in this stage. Duplicate groups are not allowed. Min size: 1.</summary>
    [JsonPropertyName("groups")]
    public IList<V1api20250301FleetsUpdateRunSpecStrategyStagesGroups>? Groups { get; set; }

    /// <summary>Name: The name of the stage. Must be unique within the UpdateRun.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// Strategy: The strategy defines the order in which the clusters will be updated.
/// If not set, all members will be updated sequentially. The UpdateRun status will show a single UpdateStage and a single
/// UpdateGroup targeting all members.
/// The strategy of the UpdateRun can be modified until the run is started.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunSpecStrategy
{
    /// <summary>Stages: The list of stages that compose this update run. Min size: 1.</summary>
    [JsonPropertyName("stages")]
    public required IList<V1api20250301FleetsUpdateRunSpecStrategyStages> Stages { get; set; }
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
public partial class V1api20250301FleetsUpdateRunSpecUpdateStrategyReference
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>
    /// ManagedClusterUpdate: The update to be applied to all clusters in the UpdateRun. The managedClusterUpdate can be
    /// modified until the run is started.
    /// </summary>
    [JsonPropertyName("managedClusterUpdate")]
    public required V1api20250301FleetsUpdateRunSpecManagedClusterUpdate ManagedClusterUpdate { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V1api20250301FleetsUpdateRunSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a containerservice.azure.com/Fleet resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V1api20250301FleetsUpdateRunSpecOwner Owner { get; set; }

    /// <summary>
    /// Strategy: The strategy defines the order in which the clusters will be updated.
    /// If not set, all members will be updated sequentially. The UpdateRun status will show a single UpdateStage and a single
    /// UpdateGroup targeting all members.
    /// The strategy of the UpdateRun can be modified until the run is started.
    /// </summary>
    [JsonPropertyName("strategy")]
    public V1api20250301FleetsUpdateRunSpecStrategy? Strategy { get; set; }

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
    public V1api20250301FleetsUpdateRunSpecUpdateStrategyReference? UpdateStrategyReference { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusConditions
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

/// <summary>The node upgrade image version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusManagedClusterUpdateNodeImageSelectionCustomNodeImageVersions
{
    /// <summary>Version: The image version to upgrade the nodes to (e.g., &apos;AKSUbuntu-1804gen2containerd-2022.12.13&apos;).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>NodeImageSelection: The node image upgrade to be applied to the target nodes in update run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusManagedClusterUpdateNodeImageSelection
{
    /// <summary>
    /// CustomNodeImageVersions: Custom node image versions to upgrade the nodes to. This field is required if node image
    /// selection type is Custom. Otherwise, it must be empty. For each node image family (e.g.,
    /// &apos;AKSUbuntu-1804gen2containerd&apos;), this field can contain at most one version (e.g., only one of
    /// &apos;AKSUbuntu-1804gen2containerd-2023.01.12&apos; or &apos;AKSUbuntu-1804gen2containerd-2023.02.12&apos;, not both). If the nodes belong
    /// to a family without a matching image version in this field, they are not upgraded.
    /// </summary>
    [JsonPropertyName("customNodeImageVersions")]
    public IList<V1api20250301FleetsUpdateRunStatusManagedClusterUpdateNodeImageSelectionCustomNodeImageVersions>? CustomNodeImageVersions { get; set; }

    /// <summary>Type: The node image upgrade type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Upgrade: The upgrade to apply to the ManagedClusters.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusManagedClusterUpdateUpgrade
{
    /// <summary>KubernetesVersion: The Kubernetes version to upgrade the member clusters to.</summary>
    [JsonPropertyName("kubernetesVersion")]
    public string? KubernetesVersion { get; set; }

    /// <summary>Type: ManagedClusterUpgradeType is the type of upgrade to be applied.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// ManagedClusterUpdate: The update to be applied to all clusters in the UpdateRun. The managedClusterUpdate can be
/// modified until the run is started.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusManagedClusterUpdate
{
    /// <summary>NodeImageSelection: The node image upgrade to be applied to the target nodes in update run.</summary>
    [JsonPropertyName("nodeImageSelection")]
    public V1api20250301FleetsUpdateRunStatusManagedClusterUpdateNodeImageSelection? NodeImageSelection { get; set; }

    /// <summary>Upgrade: The upgrade to apply to the ManagedClusters.</summary>
    [JsonPropertyName("upgrade")]
    public V1api20250301FleetsUpdateRunStatusManagedClusterUpdateUpgrade? Upgrade { get; set; }
}

/// <summary>The node upgrade image version.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusNodeImageSelectionSelectedNodeImageVersions
{
    /// <summary>Version: The image version to upgrade the nodes to (e.g., &apos;AKSUbuntu-1804gen2containerd-2022.12.13&apos;).</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>
/// NodeImageSelection: The node image upgrade specs for the update run. It is only set in update run when
/// `NodeImageSelection.type` is `Consistent`.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusNodeImageSelection
{
    /// <summary>SelectedNodeImageVersions: The image versions to upgrade the nodes to.</summary>
    [JsonPropertyName("selectedNodeImageVersions")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusNodeImageSelectionSelectedNodeImageVersions>? SelectedNodeImageVersions { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: The error details when a failure is encountered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Status: The status of the wait duration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatus
{
    /// <summary>CompletedTime: The time the operation or group was completed.</summary>
    [JsonPropertyName("completedTime")]
    public string? CompletedTime { get; set; }

    /// <summary>Error: The error details when a failure is encountered.</summary>
    [JsonPropertyName("error")]
    public V1api20250301FleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatusError? Error { get; set; }

    /// <summary>StartTime: The time the operation or group was started.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>State: The State of the operation or group.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>AfterStageWaitStatus: The status of the wait period configured on the UpdateStage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesAfterStageWaitStatus
{
    /// <summary>Status: The status of the wait duration.</summary>
    [JsonPropertyName("status")]
    public V1api20250301FleetsUpdateRunStatusStatusStagesAfterStageWaitStatusStatus? Status { get; set; }

    /// <summary>WaitDurationInSeconds: The wait duration configured in seconds.</summary>
    [JsonPropertyName("waitDurationInSeconds")]
    public int? WaitDurationInSeconds { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: The error details when a failure is encountered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesGroupsMembersStatusError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStagesGroupsMembersStatusErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Status: The status of the MemberUpdate operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesGroupsMembersStatus
{
    /// <summary>CompletedTime: The time the operation or group was completed.</summary>
    [JsonPropertyName("completedTime")]
    public string? CompletedTime { get; set; }

    /// <summary>Error: The error details when a failure is encountered.</summary>
    [JsonPropertyName("error")]
    public V1api20250301FleetsUpdateRunStatusStatusStagesGroupsMembersStatusError? Error { get; set; }

    /// <summary>StartTime: The time the operation or group was started.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>State: The State of the operation or group.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>The status of a member update operation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesGroupsMembers
{
    /// <summary>ClusterResourceId: The Azure resource id of the target Kubernetes cluster.</summary>
    [JsonPropertyName("clusterResourceId")]
    public string? ClusterResourceId { get; set; }

    /// <summary>Message: The status message after processing the member update operation.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Name: The name of the FleetMember.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>OperationId: The operation resource id of the latest attempt to perform the operation.</summary>
    [JsonPropertyName("operationId")]
    public string? OperationId { get; set; }

    /// <summary>Status: The status of the MemberUpdate operation.</summary>
    [JsonPropertyName("status")]
    public V1api20250301FleetsUpdateRunStatusStatusStagesGroupsMembersStatus? Status { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesGroupsStatusErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesGroupsStatusErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesGroupsStatusErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStagesGroupsStatusErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: The error details when a failure is encountered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesGroupsStatusError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStagesGroupsStatusErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStagesGroupsStatusErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Status: The status of the UpdateGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesGroupsStatus
{
    /// <summary>CompletedTime: The time the operation or group was completed.</summary>
    [JsonPropertyName("completedTime")]
    public string? CompletedTime { get; set; }

    /// <summary>Error: The error details when a failure is encountered.</summary>
    [JsonPropertyName("error")]
    public V1api20250301FleetsUpdateRunStatusStatusStagesGroupsStatusError? Error { get; set; }

    /// <summary>StartTime: The time the operation or group was started.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>State: The State of the operation or group.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>The status of a UpdateGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesGroups
{
    /// <summary>Members: The list of member this UpdateGroup updates.</summary>
    [JsonPropertyName("members")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStagesGroupsMembers>? Members { get; set; }

    /// <summary>Name: The name of the UpdateGroup.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Status: The status of the UpdateGroup.</summary>
    [JsonPropertyName("status")]
    public V1api20250301FleetsUpdateRunStatusStatusStagesGroupsStatus? Status { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesStatusErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesStatusErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesStatusErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStagesStatusErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: The error details when a failure is encountered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesStatusError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStagesStatusErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStagesStatusErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Status: The status of the UpdateStage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStagesStatus
{
    /// <summary>CompletedTime: The time the operation or group was completed.</summary>
    [JsonPropertyName("completedTime")]
    public string? CompletedTime { get; set; }

    /// <summary>Error: The error details when a failure is encountered.</summary>
    [JsonPropertyName("error")]
    public V1api20250301FleetsUpdateRunStatusStatusStagesStatusError? Error { get; set; }

    /// <summary>StartTime: The time the operation or group was started.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>State: The State of the operation or group.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>The status of a UpdateStage.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStages
{
    /// <summary>AfterStageWaitStatus: The status of the wait period configured on the UpdateStage.</summary>
    [JsonPropertyName("afterStageWaitStatus")]
    public V1api20250301FleetsUpdateRunStatusStatusStagesAfterStageWaitStatus? AfterStageWaitStatus { get; set; }

    /// <summary>Groups: The list of groups to be updated as part of this UpdateStage.</summary>
    [JsonPropertyName("groups")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStagesGroups>? Groups { get; set; }

    /// <summary>Name: The name of the UpdateStage.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Status: The status of the UpdateStage.</summary>
    [JsonPropertyName("status")]
    public V1api20250301FleetsUpdateRunStatusStatusStagesStatus? Status { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStatusErrorAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The resource management error additional info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStatusErrorDetailsAdditionalInfo
{
    /// <summary>Info: The additional info.</summary>
    [JsonPropertyName("info")]
    public IDictionary<string, JsonNode>? Info { get; set; }

    /// <summary>Type: The additional info type.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStatusErrorDetails
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStatusErrorDetailsAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Error: The error details when a failure is encountered.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStatusError
{
    /// <summary>AdditionalInfo: The error additional info.</summary>
    [JsonPropertyName("additionalInfo")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStatusErrorAdditionalInfo>? AdditionalInfo { get; set; }

    /// <summary>Code: The error code.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Details: The error details.</summary>
    [JsonPropertyName("details")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStatusErrorDetails>? Details { get; set; }

    /// <summary>Message: The error message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Target: The error target.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>Status: The status of the UpdateRun.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatusStatus
{
    /// <summary>CompletedTime: The time the operation or group was completed.</summary>
    [JsonPropertyName("completedTime")]
    public string? CompletedTime { get; set; }

    /// <summary>Error: The error details when a failure is encountered.</summary>
    [JsonPropertyName("error")]
    public V1api20250301FleetsUpdateRunStatusStatusStatusError? Error { get; set; }

    /// <summary>StartTime: The time the operation or group was started.</summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>State: The State of the operation or group.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>Status: The status of the UpdateRun.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStatus
{
    /// <summary>
    /// NodeImageSelection: The node image upgrade specs for the update run. It is only set in update run when
    /// `NodeImageSelection.type` is `Consistent`.
    /// </summary>
    [JsonPropertyName("nodeImageSelection")]
    public V1api20250301FleetsUpdateRunStatusStatusNodeImageSelection? NodeImageSelection { get; set; }

    /// <summary>Stages: The stages composing an update run. Stages are run sequentially withing an UpdateRun.</summary>
    [JsonPropertyName("stages")]
    public IList<V1api20250301FleetsUpdateRunStatusStatusStages>? Stages { get; set; }

    /// <summary>Status: The status of the UpdateRun.</summary>
    [JsonPropertyName("status")]
    public V1api20250301FleetsUpdateRunStatusStatusStatus? Status { get; set; }
}

/// <summary>A group to be updated.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStrategyStagesGroups
{
    /// <summary>
    /// Name: Name of the group.
    /// It must match a group name of an existing fleet member.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Defines a stage which contains the groups to update and the steps to take (e.g., wait for a time period) before starting
/// the next stage.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStrategyStages
{
    /// <summary>
    /// AfterStageWaitInSeconds: The time in seconds to wait at the end of this stage before starting the next one. Defaults to
    /// 0 seconds if unspecified.
    /// </summary>
    [JsonPropertyName("afterStageWaitInSeconds")]
    public int? AfterStageWaitInSeconds { get; set; }

    /// <summary>Groups: Defines the groups to be executed in parallel in this stage. Duplicate groups are not allowed. Min size: 1.</summary>
    [JsonPropertyName("groups")]
    public IList<V1api20250301FleetsUpdateRunStatusStrategyStagesGroups>? Groups { get; set; }

    /// <summary>Name: The name of the stage. Must be unique within the UpdateRun.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Strategy: The strategy defines the order in which the clusters will be updated.
/// If not set, all members will be updated sequentially. The UpdateRun status will show a single UpdateStage and a single
/// UpdateGroup targeting all members.
/// The strategy of the UpdateRun can be modified until the run is started.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusStrategy
{
    /// <summary>Stages: The list of stages that compose this update run. Min size: 1.</summary>
    [JsonPropertyName("stages")]
    public IList<V1api20250301FleetsUpdateRunStatusStrategyStages>? Stages { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatusSystemData
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1api20250301FleetsUpdateRunStatus
{
    /// <summary>AutoUpgradeProfileId: AutoUpgradeProfileId is the id of an auto upgrade profile resource.</summary>
    [JsonPropertyName("autoUpgradeProfileId")]
    public string? AutoUpgradeProfileId { get; set; }

    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V1api20250301FleetsUpdateRunStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ETag: If eTag is provided in the response body, it may also be provided as a header per the normal etag convention.
    /// Entity tags are used for comparing two or more entities from the same requested resource. HTTP/1.1 uses entity tags in
    /// the etag (section 14.19), If-Match (section 14.24), If-None-Match (section 14.26), and If-Range (section 14.27) header
    /// fields.
    /// </summary>
    [JsonPropertyName("eTag")]
    public string? ETag { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// ManagedClusterUpdate: The update to be applied to all clusters in the UpdateRun. The managedClusterUpdate can be
    /// modified until the run is started.
    /// </summary>
    [JsonPropertyName("managedClusterUpdate")]
    public V1api20250301FleetsUpdateRunStatusManagedClusterUpdate? ManagedClusterUpdate { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>ProvisioningState: The provisioning state of the UpdateRun resource.</summary>
    [JsonPropertyName("provisioningState")]
    public string? ProvisioningState { get; set; }

    /// <summary>Status: The status of the UpdateRun.</summary>
    [JsonPropertyName("status")]
    public V1api20250301FleetsUpdateRunStatusStatus? Status { get; set; }

    /// <summary>
    /// Strategy: The strategy defines the order in which the clusters will be updated.
    /// If not set, all members will be updated sequentially. The UpdateRun status will show a single UpdateStage and a single
    /// UpdateGroup targeting all members.
    /// The strategy of the UpdateRun can be modified until the run is started.
    /// </summary>
    [JsonPropertyName("strategy")]
    public V1api20250301FleetsUpdateRunStatusStrategy? Strategy { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V1api20250301FleetsUpdateRunStatusSystemData? SystemData { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// UpdateStrategyId: The resource id of the FleetUpdateStrategy resource to reference.
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
    [JsonPropertyName("updateStrategyId")]
    public string? UpdateStrategyId { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/fleet/stable/2025-03-01/fleets.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/fleets/{fleetName}/updateRuns/{updateRunName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1api20250301FleetsUpdateRun : IKubernetesObject<V1ObjectMeta>, ISpec<V1api20250301FleetsUpdateRunSpec?>, IStatus<V1api20250301FleetsUpdateRunStatus?>
{
    public const string KubeApiVersion = "v1api20250301";
    public const string KubeKind = "FleetsUpdateRun";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "fleetsupdateruns";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v1api20250301";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FleetsUpdateRun";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V1api20250301FleetsUpdateRunSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1api20250301FleetsUpdateRunStatus? Status { get; set; }
}