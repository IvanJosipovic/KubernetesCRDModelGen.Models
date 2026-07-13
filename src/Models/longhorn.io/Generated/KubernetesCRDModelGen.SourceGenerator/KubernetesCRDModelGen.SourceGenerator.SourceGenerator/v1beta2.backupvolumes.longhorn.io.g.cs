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
/// <summary>BackupVolume is where Longhorn stores backup volume object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackupVolumeList : IKubernetesObject<V1ListMeta>, IItems<V1beta2BackupVolume>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackupVolumeList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "backupvolumes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupVolumeList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2BackupVolume objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2BackupVolume> Items { get; set; }
}

/// <summary>BackupVolumeSpec defines the desired state of the Longhorn backup volume</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupVolumeSpec
{
    /// <summary>The backup target name that the backup volume was synced.</summary>
    [JsonPropertyName("backupTargetName")]
    public string? BackupTargetName { get; set; }

    /// <summary>The time to request run sync the remote backup volume.</summary>
    [JsonPropertyName("syncRequestedAt")]
    public DateTime? SyncRequestedAt { get; set; }

    /// <summary>The volume name that the backup volume was used to backup.</summary>
    [JsonPropertyName("volumeName")]
    public string? VolumeName { get; set; }
}

/// <summary>BackupVolumeStatus defines the observed state of the Longhorn backup volume</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupVolumeStatus
{
    /// <summary>the backing image checksum.</summary>
    [JsonPropertyName("backingImageChecksum")]
    public string? BackingImageChecksum { get; set; }

    /// <summary>The backing image name.</summary>
    [JsonPropertyName("backingImageName")]
    public string? BackingImageName { get; set; }

    /// <summary>The backup volume creation time.</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>The backup volume block count.</summary>
    [JsonPropertyName("dataStored")]
    public string? DataStored { get; set; }

    /// <summary>The backup volume labels.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The latest volume backup time.</summary>
    [JsonPropertyName("lastBackupAt")]
    public string? LastBackupAt { get; set; }

    /// <summary>The latest volume backup name.</summary>
    [JsonPropertyName("lastBackupName")]
    public string? LastBackupName { get; set; }

    /// <summary>The backup volume config last modification time.</summary>
    [JsonPropertyName("lastModificationTime")]
    public DateTime? LastModificationTime { get; set; }

    /// <summary>The last time that the backup volume was synced into the cluster.</summary>
    [JsonPropertyName("lastSyncedAt")]
    public DateTime? LastSyncedAt { get; set; }

    /// <summary>The error messages when call longhorn engine on list or inspect backup volumes.</summary>
    [JsonPropertyName("messages")]
    public IDictionary<string, string>? Messages { get; set; }

    /// <summary>The node ID on which the controller is responsible to reconcile this backup volume CR.</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>The backup volume size.</summary>
    [JsonPropertyName("size")]
    public string? Size { get; set; }

    /// <summary>the storage class name of pv/pvc binding with the volume.</summary>
    [JsonPropertyName("storageClassName")]
    public string? StorageClassName { get; set; }
}

/// <summary>BackupVolume is where Longhorn stores backup volume object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackupVolume : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2BackupVolumeSpec?>, IStatus<V1beta2BackupVolumeStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackupVolume";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "backupvolumes";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupVolume";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupVolumeSpec defines the desired state of the Longhorn backup volume</summary>
    [JsonPropertyName("spec")]
    public V1beta2BackupVolumeSpec? Spec { get; set; }

    /// <summary>BackupVolumeStatus defines the observed state of the Longhorn backup volume</summary>
    [JsonPropertyName("status")]
    public V1beta2BackupVolumeStatus? Status { get; set; }
}