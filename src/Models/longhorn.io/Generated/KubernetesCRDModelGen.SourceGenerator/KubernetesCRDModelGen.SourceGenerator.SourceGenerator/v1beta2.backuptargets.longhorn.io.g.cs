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
/// <summary>BackupTarget is where Longhorn stores backup target object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackupTargetList : IKubernetesObject<V1ListMeta>, IItems<V1beta2BackupTarget>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackupTargetList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "backuptargets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupTargetList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2BackupTarget objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2BackupTarget> Items { get; set; }
}

/// <summary>BackupTargetSpec defines the desired state of the Longhorn backup target</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupTargetSpec
{
    /// <summary>The backup target URL.</summary>
    [JsonPropertyName("backupTargetURL")]
    public string? BackupTargetURL { get; set; }

    /// <summary>The backup target credential secret.</summary>
    [JsonPropertyName("credentialSecret")]
    public string? CredentialSecret { get; set; }

    /// <summary>The interval that the cluster needs to run sync with the backup target.</summary>
    [JsonPropertyName("pollInterval")]
    public string? PollInterval { get; set; }

    /// <summary>The time to request run sync the remote backup target.</summary>
    [JsonPropertyName("syncRequestedAt")]
    public DateTime? SyncRequestedAt { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupTargetStatusConditions
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

/// <summary>BackupTargetStatus defines the observed state of the Longhorn backup target</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupTargetStatus
{
    /// <summary>Available indicates if the remote backup target is available or not.</summary>
    [JsonPropertyName("available")]
    public bool? Available { get; set; }

    /// <summary>Records the reason on why the backup target is unavailable.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2BackupTargetStatusConditions>? Conditions { get; set; }

    /// <summary>The last time that the controller synced with the remote backup target.</summary>
    [JsonPropertyName("lastSyncedAt")]
    public DateTime? LastSyncedAt { get; set; }

    /// <summary>The node ID on which the controller is responsible to reconcile this backup target CR.</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }
}

/// <summary>BackupTarget is where Longhorn stores backup target object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackupTarget : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2BackupTargetSpec?>, IStatus<V1beta2BackupTargetStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackupTarget";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "backuptargets";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupTarget";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupTargetSpec defines the desired state of the Longhorn backup target</summary>
    [JsonPropertyName("spec")]
    public V1beta2BackupTargetSpec? Spec { get; set; }

    /// <summary>BackupTargetStatus defines the observed state of the Longhorn backup target</summary>
    [JsonPropertyName("status")]
    public V1beta2BackupTargetStatus? Status { get; set; }
}