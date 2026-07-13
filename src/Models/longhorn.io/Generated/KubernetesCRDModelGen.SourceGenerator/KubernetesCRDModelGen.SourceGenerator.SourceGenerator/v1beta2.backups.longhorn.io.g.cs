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
/// <summary>Backup is where Longhorn stores backup object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackupList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Backup>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackupList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "backups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Backup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Backup> Items { get; set; }
}

/// <summary>The backup block size. 0 means the legacy default size 2MiB, and -1 indicate the block size is invalid.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupSpecBackupBlockSizeEnum>))]
public enum V1beta2BackupSpecBackupBlockSizeEnum
{
    [EnumMember(Value = "-1"), JsonStringEnumMemberName("-1")]
    _1,
    [EnumMember(Value = "2097152"), JsonStringEnumMemberName("2097152")]
    _2097152,
    [EnumMember(Value = "16777216"), JsonStringEnumMemberName("16777216")]
    _16777216
}

/// <summary>
/// The backup mode of this backup.
/// Can be &quot;full&quot; or &quot;incremental&quot;
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackupSpecBackupModeEnum>))]
public enum V1beta2BackupSpecBackupModeEnum
{
    [EnumMember(Value = "full"), JsonStringEnumMemberName("full")]
    Full,
    [EnumMember(Value = "incremental"), JsonStringEnumMemberName("incremental")]
    Incremental
}

/// <summary>BackupSpec defines the desired state of the Longhorn backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupSpec
{
    /// <summary>The backup block size. 0 means the legacy default size 2MiB, and -1 indicate the block size is invalid.</summary>
    [JsonPropertyName("backupBlockSize")]
    public V1beta2BackupSpecBackupBlockSizeEnum? BackupBlockSize { get; set; }

    /// <summary>
    /// The backup mode of this backup.
    /// Can be &quot;full&quot; or &quot;incremental&quot;
    /// </summary>
    [JsonPropertyName("backupMode")]
    public V1beta2BackupSpecBackupModeEnum? BackupMode { get; set; }

    /// <summary>The labels of snapshot backup.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The snapshot name.</summary>
    [JsonPropertyName("snapshotName")]
    public string? SnapshotName { get; set; }

    /// <summary>The time to request run sync the remote backup.</summary>
    [JsonPropertyName("syncRequestedAt")]
    public DateTime? SyncRequestedAt { get; set; }
}

/// <summary>BackupStatus defines the observed state of the Longhorn backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupStatus
{
    /// <summary>The snapshot backup upload finished time.</summary>
    [JsonPropertyName("backupCreatedAt")]
    public string? BackupCreatedAt { get; set; }

    /// <summary>The backup target name.</summary>
    [JsonPropertyName("backupTargetName")]
    public string? BackupTargetName { get; set; }

    /// <summary>Compression method</summary>
    [JsonPropertyName("compressionMethod")]
    public string? CompressionMethod { get; set; }

    /// <summary>The error message when taking the snapshot backup.</summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary>The labels of snapshot backup.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The last time that the backup was synced with the remote backup target.</summary>
    [JsonPropertyName("lastSyncedAt")]
    public DateTime? LastSyncedAt { get; set; }

    /// <summary>The error messages when calling longhorn engine on listing or inspecting backups.</summary>
    [JsonPropertyName("messages")]
    public IDictionary<string, string>? Messages { get; set; }

    /// <summary>Size in bytes of newly uploaded data</summary>
    [JsonPropertyName("newlyUploadDataSize")]
    public string? NewlyUploadDataSize { get; set; }

    /// <summary>The node ID on which the controller is responsible to reconcile this backup CR.</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>The snapshot backup progress.</summary>
    [JsonPropertyName("progress")]
    public int? Progress { get; set; }

    /// <summary>Size in bytes of reuploaded data</summary>
    [JsonPropertyName("reUploadedDataSize")]
    public string? ReUploadedDataSize { get; set; }

    /// <summary>The address of the replica that runs snapshot backup.</summary>
    [JsonPropertyName("replicaAddress")]
    public string? ReplicaAddress { get; set; }

    /// <summary>The snapshot size.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>The snapshot creation time.</summary>
    [JsonPropertyName("snapshotCreatedAt")]
    public string? SnapshotCreatedAt { get; set; }

    /// <summary>The snapshot name.</summary>
    [JsonPropertyName("snapshotName")]
    public string? SnapshotName { get; set; }

    /// <summary>
    /// The backup creation state.
    /// Can be &quot; &quot;, &quot;InProgress&quot;, &quot;Completed&quot;, &quot;Error&quot;, &quot;Unknown&quot;.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The snapshot backup URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>The volume&apos;s backing image name.</summary>
    [JsonPropertyName("volumeBackingImageName")]
    public string? VolumeBackingImageName { get; set; }

    /// <summary>The volume creation time.</summary>
    [JsonPropertyName("volumeCreated")]
    public string? VolumeCreated { get; set; }

    /// <summary>The volume name.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }

    /// <summary>The volume size.</summary>
    [JsonPropertyName("volumeSize")]
    public string? VolumeSize { get; set; }
}

/// <summary>Backup is where Longhorn stores backup object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Backup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2BackupSpec?>, IStatus<V1beta2BackupStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Backup";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "backups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Backup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupSpec defines the desired state of the Longhorn backup</summary>
    [JsonPropertyName("spec")]
    public V1beta2BackupSpec? Spec { get; set; }

    /// <summary>BackupStatus defines the observed state of the Longhorn backup</summary>
    [JsonPropertyName("status")]
    public V1beta2BackupStatus? Status { get; set; }
}