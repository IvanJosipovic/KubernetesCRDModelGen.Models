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
/// <summary>SystemBackup is where Longhorn stores system backup object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SystemBackupList : IKubernetesObject<V1ListMeta>, IItems<V1beta2SystemBackup>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SystemBackupList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "systembackups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SystemBackupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2SystemBackup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2SystemBackup> Items { get; set; }
}

/// <summary>SystemBackupSpec defines the desired state of the Longhorn SystemBackup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SystemBackupSpec
{
    /// <summary>
    /// The create volume backup policy
    /// Can be &quot;if-not-present&quot;, &quot;always&quot; or &quot;disabled&quot;
    /// </summary>
    [JsonPropertyName("volumeBackupPolicy")]
    public string? VolumeBackupPolicy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SystemBackupStatusConditions
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

/// <summary>SystemBackupStatus defines the observed state of the Longhorn SystemBackup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SystemBackupStatus
{
    [JsonPropertyName("conditions")]
    public IList<V1beta2SystemBackupStatusConditions>? Conditions { get; set; }

    /// <summary>The system backup creation time.</summary>
    [JsonPropertyName("createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>The saved Longhorn manager git commit.</summary>
    [JsonPropertyName("gitCommit")]
    public string? GitCommit { get; set; }

    /// <summary>The last time that the system backup was synced into the cluster.</summary>
    [JsonPropertyName("lastSyncedAt")]
    public DateTime? LastSyncedAt { get; set; }

    /// <summary>The saved manager image.</summary>
    [JsonPropertyName("managerImage")]
    public string? ManagerImage { get; set; }

    /// <summary>The node ID of the responsible controller to reconcile this SystemBackup.</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>The system backup state.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The saved Longhorn version.</summary>
    [JsonPropertyName("version")]
    public string? Version { get; set; }
}

/// <summary>SystemBackup is where Longhorn stores system backup object</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SystemBackup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2SystemBackupSpec?>, IStatus<V1beta2SystemBackupStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SystemBackup";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "systembackups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SystemBackup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SystemBackupSpec defines the desired state of the Longhorn SystemBackup</summary>
    [JsonPropertyName("spec")]
    public V1beta2SystemBackupSpec? Spec { get; set; }

    /// <summary>SystemBackupStatus defines the observed state of the Longhorn SystemBackup</summary>
    [JsonPropertyName("status")]
    public V1beta2SystemBackupStatus? Status { get; set; }
}