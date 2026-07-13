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
/// <summary>InstanceManager is where Longhorn stores instance manager object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InstanceManagerList : IKubernetesObject<V1ListMeta>, IItems<V1beta2InstanceManager>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InstanceManagerList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "instancemanagers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceManagerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2InstanceManager objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2InstanceManager> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerSpecDataEngineSpecV2
{
    [JsonPropertyName("cpuMask")]
    public string? CpuMask { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerSpecDataEngineSpec
{
    [JsonPropertyName("v2")]
    public V1beta2InstanceManagerSpecDataEngineSpecV2? V2 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2InstanceManagerSpecTypeEnum>))]
public enum V1beta2InstanceManagerSpecTypeEnum
{
    [EnumMember(Value = "aio"), JsonStringEnumMemberName("aio")]
    Aio,
    [EnumMember(Value = "engine"), JsonStringEnumMemberName("engine")]
    Engine,
    [EnumMember(Value = "replica"), JsonStringEnumMemberName("replica")]
    Replica
}

/// <summary>InstanceManagerSpec defines the desired state of the Longhorn instance manager</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerSpec
{
    [JsonPropertyName("dataEngine")]
    public string? DataEngine { get; set; }

    [JsonPropertyName("dataEngineSpec")]
    public V1beta2InstanceManagerSpecDataEngineSpec? DataEngineSpec { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("nodeID")]
    public string? NodeID { get; set; }

    [JsonPropertyName("type")]
    public V1beta2InstanceManagerSpecTypeEnum? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerStatusBackingImages
{
    [JsonPropertyName("currentChecksum")]
    public string? CurrentChecksum { get; set; }

    [JsonPropertyName("diskUUID")]
    public string? DiskUUID { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("progress")]
    public int? Progress { get; set; }

    [JsonPropertyName("size")]
    public long? Size { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerStatusDataEngineStatusV2
{
    [JsonPropertyName("cpuMask")]
    public string? CpuMask { get; set; }

    /// <summary>
    /// InterruptModeEnabled indicates whether the V2 data engine is running in
    /// interrupt mode (true) or polling mode (false). Set by Longhorn manager;
    /// read-only to users.
    /// </summary>
    [JsonPropertyName("interruptModeEnabled")]
    public string? InterruptModeEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerStatusDataEngineStatus
{
    [JsonPropertyName("v2")]
    public V1beta2InstanceManagerStatusDataEngineStatusV2? V2 { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerStatusInstanceEngineFrontendsSpec
{
    [JsonPropertyName("dataEngine")]
    public string? DataEngine { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerStatusInstanceEngineFrontendsStatusPaths
{
    [JsonPropertyName("anaState")]
    public string? AnaState { get; set; }

    [JsonPropertyName("engineName")]
    public string? EngineName { get; set; }

    [JsonPropertyName("nguid")]
    public string? Nguid { get; set; }

    [JsonPropertyName("nqn")]
    public string? Nqn { get; set; }

    [JsonPropertyName("targetIP")]
    public string? TargetIP { get; set; }

    [JsonPropertyName("targetPort")]
    public int? TargetPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerStatusInstanceEngineFrontendsStatus
{
    [JsonPropertyName("activePath")]
    public string? ActivePath { get; set; }

    [JsonPropertyName("conditions")]
    public IDictionary<string, bool>? Conditions { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("errorMsg")]
    public string? ErrorMsg { get; set; }

    [JsonPropertyName("frontend")]
    public string? Frontend { get; set; }

    [JsonPropertyName("listen")]
    public string? Listen { get; set; }

    [JsonPropertyName("paths")]
    public IList<V1beta2InstanceManagerStatusInstanceEngineFrontendsStatusPaths>? Paths { get; set; }

    [JsonPropertyName("portEnd")]
    public int? PortEnd { get; set; }

    [JsonPropertyName("portStart")]
    public int? PortStart { get; set; }

    [JsonPropertyName("preferredPath")]
    public string? PreferredPath { get; set; }

    [JsonPropertyName("resourceVersion")]
    public long? ResourceVersion { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("targetPortEnd")]
    public int? TargetPortEnd { get; set; }

    [JsonPropertyName("targetPortStart")]
    public int? TargetPortStart { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("ublkID")]
    public int? UblkID { get; set; }

    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerStatusInstanceEngineFrontends
{
    [JsonPropertyName("spec")]
    public V1beta2InstanceManagerStatusInstanceEngineFrontendsSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta2InstanceManagerStatusInstanceEngineFrontendsStatus? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerStatusInstanceEnginesSpec
{
    [JsonPropertyName("dataEngine")]
    public string? DataEngine { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerStatusInstanceEnginesStatusPaths
{
    [JsonPropertyName("anaState")]
    public string? AnaState { get; set; }

    [JsonPropertyName("engineName")]
    public string? EngineName { get; set; }

    [JsonPropertyName("nguid")]
    public string? Nguid { get; set; }

    [JsonPropertyName("nqn")]
    public string? Nqn { get; set; }

    [JsonPropertyName("targetIP")]
    public string? TargetIP { get; set; }

    [JsonPropertyName("targetPort")]
    public int? TargetPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerStatusInstanceEnginesStatus
{
    [JsonPropertyName("activePath")]
    public string? ActivePath { get; set; }

    [JsonPropertyName("conditions")]
    public IDictionary<string, bool>? Conditions { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("errorMsg")]
    public string? ErrorMsg { get; set; }

    [JsonPropertyName("frontend")]
    public string? Frontend { get; set; }

    [JsonPropertyName("listen")]
    public string? Listen { get; set; }

    [JsonPropertyName("paths")]
    public IList<V1beta2InstanceManagerStatusInstanceEnginesStatusPaths>? Paths { get; set; }

    [JsonPropertyName("portEnd")]
    public int? PortEnd { get; set; }

    [JsonPropertyName("portStart")]
    public int? PortStart { get; set; }

    [JsonPropertyName("preferredPath")]
    public string? PreferredPath { get; set; }

    [JsonPropertyName("resourceVersion")]
    public long? ResourceVersion { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("targetPortEnd")]
    public int? TargetPortEnd { get; set; }

    [JsonPropertyName("targetPortStart")]
    public int? TargetPortStart { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("ublkID")]
    public int? UblkID { get; set; }

    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerStatusInstanceEngines
{
    [JsonPropertyName("spec")]
    public V1beta2InstanceManagerStatusInstanceEnginesSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta2InstanceManagerStatusInstanceEnginesStatus? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerStatusInstanceReplicasSpec
{
    [JsonPropertyName("dataEngine")]
    public string? DataEngine { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerStatusInstanceReplicasStatusPaths
{
    [JsonPropertyName("anaState")]
    public string? AnaState { get; set; }

    [JsonPropertyName("engineName")]
    public string? EngineName { get; set; }

    [JsonPropertyName("nguid")]
    public string? Nguid { get; set; }

    [JsonPropertyName("nqn")]
    public string? Nqn { get; set; }

    [JsonPropertyName("targetIP")]
    public string? TargetIP { get; set; }

    [JsonPropertyName("targetPort")]
    public int? TargetPort { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerStatusInstanceReplicasStatus
{
    [JsonPropertyName("activePath")]
    public string? ActivePath { get; set; }

    [JsonPropertyName("conditions")]
    public IDictionary<string, bool>? Conditions { get; set; }

    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("errorMsg")]
    public string? ErrorMsg { get; set; }

    [JsonPropertyName("frontend")]
    public string? Frontend { get; set; }

    [JsonPropertyName("listen")]
    public string? Listen { get; set; }

    [JsonPropertyName("paths")]
    public IList<V1beta2InstanceManagerStatusInstanceReplicasStatusPaths>? Paths { get; set; }

    [JsonPropertyName("portEnd")]
    public int? PortEnd { get; set; }

    [JsonPropertyName("portStart")]
    public int? PortStart { get; set; }

    [JsonPropertyName("preferredPath")]
    public string? PreferredPath { get; set; }

    [JsonPropertyName("resourceVersion")]
    public long? ResourceVersion { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("targetPortEnd")]
    public int? TargetPortEnd { get; set; }

    [JsonPropertyName("targetPortStart")]
    public int? TargetPortStart { get; set; }

    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("ublkID")]
    public int? UblkID { get; set; }

    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerStatusInstanceReplicas
{
    [JsonPropertyName("spec")]
    public V1beta2InstanceManagerStatusInstanceReplicasSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V1beta2InstanceManagerStatusInstanceReplicasStatus? Status { get; set; }
}

/// <summary>InstanceManagerStatus defines the observed state of the Longhorn instance manager</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2InstanceManagerStatus
{
    [JsonPropertyName("apiMinVersion")]
    public int? ApiMinVersion { get; set; }

    [JsonPropertyName("apiVersion")]
    public int? ApiVersion { get; set; }

    [JsonPropertyName("backingImages")]
    public IDictionary<string, V1beta2InstanceManagerStatusBackingImages>? BackingImages { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1beta2InstanceManagerStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("currentState")]
    public string? CurrentState { get; set; }

    [JsonPropertyName("dataEngineStatus")]
    public V1beta2InstanceManagerStatusDataEngineStatus? DataEngineStatus { get; set; }

    [JsonPropertyName("instanceEngineFrontends")]
    public IDictionary<string, V1beta2InstanceManagerStatusInstanceEngineFrontends>? InstanceEngineFrontends { get; set; }

    [JsonPropertyName("instanceEngines")]
    public IDictionary<string, V1beta2InstanceManagerStatusInstanceEngines>? InstanceEngines { get; set; }

    [JsonPropertyName("instanceReplicas")]
    public IDictionary<string, V1beta2InstanceManagerStatusInstanceReplicas>? InstanceReplicas { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    [JsonPropertyName("proxyApiMinVersion")]
    public int? ProxyApiMinVersion { get; set; }

    [JsonPropertyName("proxyApiVersion")]
    public int? ProxyApiVersion { get; set; }
}

/// <summary>InstanceManager is where Longhorn stores instance manager object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2InstanceManager : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2InstanceManagerSpec?>, IStatus<V1beta2InstanceManagerStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "InstanceManager";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "instancemanagers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "InstanceManager";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>InstanceManagerSpec defines the desired state of the Longhorn instance manager</summary>
    [JsonPropertyName("spec")]
    public V1beta2InstanceManagerSpec? Spec { get; set; }

    /// <summary>InstanceManagerStatus defines the observed state of the Longhorn instance manager</summary>
    [JsonPropertyName("status")]
    public V1beta2InstanceManagerStatus? Status { get; set; }
}