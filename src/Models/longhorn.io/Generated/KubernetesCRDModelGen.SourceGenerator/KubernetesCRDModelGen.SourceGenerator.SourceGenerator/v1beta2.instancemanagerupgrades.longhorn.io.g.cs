#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.longhorn.io;
/// <summary>
/// InstanceManagerUpgrade is the Longhorn CR that tracks the live upgrade of a
/// v2 instance manager.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InstanceManagerUpgradeList : IKubernetesObject<V1ListMeta>, IItems<V1beta2InstanceManagerUpgrade>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InstanceManagerUpgradeList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "instancemanagerupgrades";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceManagerUpgradeList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2InstanceManagerUpgrade objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2InstanceManagerUpgrade> Items { get; set; }
}

/// <summary>InstanceManagerUpgradeSpec defines the desired state of the InstanceManagerUpgrade.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerUpgradeSpec
{
    /// <summary>NodeID is the node where the source instance manager is running.</summary>
    [JsonPropertyName("nodeID")]
    public required string NodeID { get; set; }

    /// <summary>TargetImage is the desired instance manager image after upgrade.</summary>
    [JsonPropertyName("targetImage")]
    public required string TargetImage { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerUpgradeStatusConditions
{
    /// <summary>Last time we probed the condition.</summary>
    [JsonPropertyName("lastProbeTime")]
    public string? LastProbeTime { get; set; }

    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>
    /// Status is the status of the condition.
    /// Can be True, False, Unknown.
    /// </summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// EngineRelocation records the relocation metadata of an engine during an
/// instance manager upgrade.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerUpgradeStatusEngines
{
    /// <summary>OriginalNodeID is the node where the engine was originally running.</summary>
    [JsonPropertyName("originalNodeID")]
    public required string OriginalNodeID { get; set; }

    /// <summary>
    /// TemporaryNodeID is the node the engine is temporarily relocated to while
    /// the source instance manager is being upgraded.
    /// </summary>
    [JsonPropertyName("temporaryNodeID")]
    public string? TemporaryNodeID { get; set; }
}

/// <summary>
/// PlannedDetachedReplica records a backend that should be temporarily detached
/// from an engine during an instance manager upgrade.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerUpgradeStatusPlannedDetachedReplicas
{
    /// <summary>
    /// Address is the raw replica backend address recorded when the detach plan
    /// is created.
    /// </summary>
    [JsonPropertyName("address")]
    public required string Address { get; set; }

    /// <summary>Name is the replica name.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>InstanceManagerUpgradeStatus defines the observed state of the InstanceManagerUpgrade.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerUpgradeStatus
{
    /// <summary>AbortReason explains why AbortRequested was set.</summary>
    [JsonPropertyName("abortReason")]
    public string? AbortReason { get; set; }

    /// <summary>AbortRequested is set by the controller when an abort condition is detected.</summary>
    [JsonPropertyName("abortRequested")]
    public bool? AbortRequested { get; set; }

    /// <summary>Conditions records the current conditions of the upgrade.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2InstanceManagerUpgradeStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Engines records the relocation plan for each engine managed by the source
    /// instance manager. The map key is the volume name.
    /// </summary>
    [JsonPropertyName("engines")]
    public IDictionary<string, V1beta2InstanceManagerUpgradeStatusEngines>? Engines { get; set; }

    /// <summary>ErrorMsg records the terminal error encountered during the upgrade, if any.</summary>
    [JsonPropertyName("errorMsg")]
    public string? ErrorMsg { get; set; }

    /// <summary>OwnerID is the owner node ID of this InstanceManagerUpgrade.</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>
    /// PlannedDetachedReplicas records the replicas that should be temporarily
    /// detached from engines during the instance manager upgrade. The map key is
    /// the volume name.
    /// </summary>
    [JsonPropertyName("plannedDetachedReplicas")]
    public IDictionary<string, IList<V1beta2InstanceManagerUpgradeStatusPlannedDetachedReplicas>>? PlannedDetachedReplicas { get; set; }

    /// <summary>StartedAt records when the timed or active portion of the upgrade began.</summary>
    [JsonPropertyName("startedAt")]
    public string? StartedAt { get; set; }

    /// <summary>State indicates the overall progress of the instance manager upgrade.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>
/// InstanceManagerUpgrade is the Longhorn CR that tracks the live upgrade of a
/// v2 instance manager.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InstanceManagerUpgrade : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2InstanceManagerUpgradeSpec?>, IStatus<V1beta2InstanceManagerUpgradeStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InstanceManagerUpgrade";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "instancemanagerupgrades";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceManagerUpgrade";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceManagerUpgradeSpec defines the desired state of the InstanceManagerUpgrade.</summary>
    [JsonPropertyName("spec")]
    public V1beta2InstanceManagerUpgradeSpec? Spec { get; set; }

    /// <summary>InstanceManagerUpgradeStatus defines the observed state of the InstanceManagerUpgrade.</summary>
    [JsonPropertyName("status")]
    public V1beta2InstanceManagerUpgradeStatus? Status { get; set; }
}