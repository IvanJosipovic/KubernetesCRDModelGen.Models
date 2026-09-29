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
/// InstanceManagerUpgradeControl is the singleton Longhorn CR that orchestrates
/// rolling live upgrades of v2 instance managers across all cluster nodes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InstanceManagerUpgradeControlList : IKubernetesObject<V1ListMeta>, IItems<V1beta2InstanceManagerUpgradeControl>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InstanceManagerUpgradeControlList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "instancemanagerupgradecontrols";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceManagerUpgradeControlList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2InstanceManagerUpgradeControl objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2InstanceManagerUpgradeControl> Items { get; set; }
}

/// <summary>
/// InstanceManagerUpgradeControlSpec defines the desired state of the
/// InstanceManagerUpgradeControl singleton.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerUpgradeControlSpec
{
    /// <summary>StartAt is the RFC3339 timestamp at which the upgrade cycle should begin.</summary>
    [JsonPropertyName("startAt")]
    public string? StartAt { get; set; }

    /// <summary>TargetImage is the desired instance manager image for all nodes.</summary>
    [JsonPropertyName("targetImage")]
    public string? TargetImage { get; set; }
}

/// <summary>NodeUpgradeInfo records the upgrade status for a single node.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerUpgradeControlStatusNodes
{
    /// <summary>CompletedAt is the RFC3339 timestamp when the upgrade finished on this node.</summary>
    [JsonPropertyName("completedAt")]
    public string? CompletedAt { get; set; }

    /// <summary>ErrorMsg records the last error encountered while upgrading this node.</summary>
    [JsonPropertyName("errorMsg")]
    public string? ErrorMsg { get; set; }

    /// <summary>IMUName is the name of the InstanceManagerUpgrade CR created for this node.</summary>
    [JsonPropertyName("imuName")]
    public string? ImuName { get; set; }

    /// <summary>RetryCount tracks how many times the upgrade has been attempted for this node.</summary>
    [JsonPropertyName("retryCount")]
    public int? RetryCount { get; set; }

    /// <summary>StartedAt is the RFC3339 timestamp when the upgrade began on this node.</summary>
    [JsonPropertyName("startedAt")]
    public string? StartedAt { get; set; }

    /// <summary>State is the current upgrade state for this node.</summary>
    [JsonPropertyName("state")]
    public required string State { get; set; }
}

/// <summary>
/// InstanceManagerUpgradeControlStatus defines the observed state of the
/// InstanceManagerUpgradeControl.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerUpgradeControlStatus
{
    /// <summary>CurrentNode is the name of the node that is actively being upgraded.</summary>
    [JsonPropertyName("currentNode")]
    public string? CurrentNode { get; set; }

    /// <summary>
    /// Nodes holds the upgrade status for nodes participating in the current or
    /// most recent upgrade cycle.
    /// </summary>
    [JsonPropertyName("nodes")]
    public IDictionary<string, V1beta2InstanceManagerUpgradeControlStatusNodes>? Nodes { get; set; }

    /// <summary>OwnerID is the ID of the Longhorn manager pod that currently owns this CR.</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }
}

/// <summary>
/// InstanceManagerUpgradeControl is the singleton Longhorn CR that orchestrates
/// rolling live upgrades of v2 instance managers across all cluster nodes.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InstanceManagerUpgradeControl : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2InstanceManagerUpgradeControlSpec?>, IStatus<V1beta2InstanceManagerUpgradeControlStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InstanceManagerUpgradeControl";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "instancemanagerupgradecontrols";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceManagerUpgradeControl";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// InstanceManagerUpgradeControlSpec defines the desired state of the
    /// InstanceManagerUpgradeControl singleton.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1beta2InstanceManagerUpgradeControlSpec? Spec { get; set; }

    /// <summary>
    /// InstanceManagerUpgradeControlStatus defines the observed state of the
    /// InstanceManagerUpgradeControl.
    /// </summary>
    [JsonPropertyName("status")]
    public V1beta2InstanceManagerUpgradeControlStatus? Status { get; set; }
}