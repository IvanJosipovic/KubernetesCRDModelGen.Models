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
/// <summary>EngineFrontend is where Longhorn stores engine frontend object for v2 data engine initiator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2EngineFrontendList : IKubernetesObject<V1ListMeta>, IItems<V1beta2EngineFrontend>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "EngineFrontendList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "enginefrontends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EngineFrontendList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2EngineFrontend objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2EngineFrontend> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EngineFrontendSpecDataEngineEnum>))]
public enum V1beta2EngineFrontendSpecDataEngineEnum
{
    [EnumMember(Value = "v1"), JsonStringEnumMemberName("v1")]
    V1,
    [EnumMember(Value = "v2"), JsonStringEnumMemberName("v2")]
    V2
}

/// <summary>EngineFrontendSpec defines the desired state of the Longhorn engine frontend (v2 initiator)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EngineFrontendSpec
{
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    [JsonPropertyName("dataEngine")]
    public V1beta2EngineFrontendSpecDataEngineEnum? DataEngine { get; set; }

    [JsonPropertyName("desireState")]
    public string? DesireState { get; set; }

    [JsonPropertyName("disableFrontend")]
    public bool? DisableFrontend { get; set; }

    /// <summary>EngineName is the name of the v2 engine target (required for EngineFrontend instance creation)</summary>
    [JsonPropertyName("engineName")]
    public string? EngineName { get; set; }

    [JsonPropertyName("frontend")]
    public string? Frontend { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("logRequested")]
    public bool? LogRequested { get; set; }

    [JsonPropertyName("nodeID")]
    public string? NodeID { get; set; }

    [JsonPropertyName("salvageRequested")]
    public bool? SalvageRequested { get; set; }

    /// <summary>
    /// Size is the desired size of the frontend device in bytes, as requested
    /// by the volume owner. The EngineFrontend controller drives the frontend
    /// device toward this size independently of the engine&apos;s target size.
    /// </summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>TargetIP is the IP address of the v2 engine target</summary>
    [JsonPropertyName("targetIP")]
    public string? TargetIP { get; set; }

    /// <summary>TargetPort is the port of the v2 engine target</summary>
    [JsonPropertyName("targetPort")]
    public int? TargetPort { get; set; }

    /// <summary>ublkNumberOfQueue controls the number of queues for ublk frontend.</summary>
    [JsonPropertyName("ublkNumberOfQueue")]
    public int? UblkNumberOfQueue { get; set; }

    /// <summary>ublkQueueDepth controls the depth of each queue for ublk frontend.</summary>
    [JsonPropertyName("ublkQueueDepth")]
    public int? UblkQueueDepth { get; set; }

    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }

    [JsonPropertyName("volumeSize")]
    public string? VolumeSize { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EngineFrontendStatusConditions
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

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EngineFrontendStatusPaths
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

/// <summary>EngineFrontendStatus defines the observed state of the Longhorn engine frontend</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EngineFrontendStatus
{
    /// <summary>ActivePath is the currently active frontend path address.</summary>
    [JsonPropertyName("activePath")]
    public string? ActivePath { get; set; }

    [JsonPropertyName("conditions")]
    public IList<V1beta2EngineFrontendStatusConditions>? Conditions { get; set; }

    [JsonPropertyName("currentImage")]
    public string? CurrentImage { get; set; }

    /// <summary>
    /// CurrentSize is the current size of the frontend device in bytes, as
    /// observed from the data plane. It is 0 while the engine frontend is not
    /// running.
    /// </summary>
    [JsonPropertyName("currentSize")]
    public string? CurrentSize { get; set; }

    [JsonPropertyName("currentState")]
    public string? CurrentState { get; set; }

    /// <summary>Endpoint is the initiator endpoint (e.g., /dev/longhorn/vol-name)</summary>
    [JsonPropertyName("endpoint")]
    public string? Endpoint { get; set; }

    [JsonPropertyName("instanceManagerName")]
    public string? InstanceManagerName { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    [JsonPropertyName("logFetched")]
    public bool? LogFetched { get; set; }

    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>Paths describes the currently known frontend multipath state.</summary>
    [JsonPropertyName("paths")]
    public IList<V1beta2EngineFrontendStatusPaths>? Paths { get; set; }

    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>PreferredPath is the preferred frontend path address.</summary>
    [JsonPropertyName("preferredPath")]
    public string? PreferredPath { get; set; }

    [JsonPropertyName("salvageExecuted")]
    public bool? SalvageExecuted { get; set; }

    [JsonPropertyName("started")]
    public bool? Started { get; set; }

    [JsonPropertyName("starting")]
    public bool? Starting { get; set; }

    [JsonPropertyName("storageIP")]
    public string? StorageIP { get; set; }

    /// <summary>SwitchoverPhase is the last completed switchover phase reported by the data plane.</summary>
    [JsonPropertyName("switchoverPhase")]
    public string? SwitchoverPhase { get; set; }

    /// <summary>TargetIP is the currently connected IP address of the v2 engine target</summary>
    [JsonPropertyName("targetIP")]
    public string? TargetIP { get; set; }

    /// <summary>TargetPort is the currently connected port of the v2 engine target</summary>
    [JsonPropertyName("targetPort")]
    public int? TargetPort { get; set; }

    [JsonPropertyName("ublkID")]
    public int? UblkID { get; set; }

    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

/// <summary>EngineFrontend is where Longhorn stores engine frontend object for v2 data engine initiator.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2EngineFrontend : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2EngineFrontendSpec?>, IStatus<V1beta2EngineFrontendStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "EngineFrontend";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "enginefrontends";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EngineFrontend";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EngineFrontendSpec defines the desired state of the Longhorn engine frontend (v2 initiator)</summary>
    [JsonPropertyName("spec")]
    public V1beta2EngineFrontendSpec? Spec { get; set; }

    /// <summary>EngineFrontendStatus defines the observed state of the Longhorn engine frontend</summary>
    [JsonPropertyName("status")]
    public V1beta2EngineFrontendStatus? Status { get; set; }
}