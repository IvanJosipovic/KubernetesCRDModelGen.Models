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
/// <summary>Snapshot is the Schema for the snapshots API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2SnapshotList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Snapshot>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "SnapshotList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "snapshots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "SnapshotList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Snapshot objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Snapshot> Items { get; set; }
}

/// <summary>SnapshotSpec defines the desired state of Longhorn Snapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SnapshotSpec
{
    /// <summary>require creating a new snapshot</summary>
    [JsonPropertyName("createSnapshot")]
    public bool? CreateSnapshot { get; set; }

    /// <summary>The labels of snapshot</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// the volume that this snapshot belongs to.
    /// This field is immutable after creation.
    /// </summary>
    [JsonPropertyName("volume")]
    public required string Volume { get; set; }
}

/// <summary>SnapshotStatus defines the observed state of Longhorn Snapshot</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2SnapshotStatus
{
    [JsonPropertyName("checksum")]
    public string? Checksum { get; set; }

    /// <summary>
    /// ChecksumCalculatedAt is the RFC3339 timestamp indicating when the checksum
    /// for this snapshot was last calculated or updated.
    /// </summary>
    [JsonPropertyName("checksumCalculatedAt")]
    public string? ChecksumCalculatedAt { get; set; }

    [JsonPropertyName("children")]
    public IDictionary<string, bool>? Children { get; set; }

    [JsonPropertyName("creationTime")]
    public string? CreationTime { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    [JsonPropertyName("markRemoved")]
    public bool? MarkRemoved { get; set; }

    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    [JsonPropertyName("parent")]
    public string? Parent { get; set; }

    [JsonPropertyName("readyToUse")]
    public bool? ReadyToUse { get; set; }

    [JsonPropertyName("requestedTime")]
    public string? RequestedTime { get; set; }

    [JsonPropertyName("restoreSize")]
    public long? RestoreSize { get; set; }

    [JsonPropertyName("size")]
    public long? Size { get; set; }

    [JsonPropertyName("userCreated")]
    public bool? UserCreated { get; set; }
}

/// <summary>Snapshot is the Schema for the snapshots API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Snapshot : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2SnapshotSpec?>, IStatus<V1beta2SnapshotStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Snapshot";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "snapshots";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Snapshot";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>SnapshotSpec defines the desired state of Longhorn Snapshot</summary>
    [JsonPropertyName("spec")]
    public V1beta2SnapshotSpec? Spec { get; set; }

    /// <summary>SnapshotStatus defines the observed state of Longhorn Snapshot</summary>
    [JsonPropertyName("status")]
    public V1beta2SnapshotStatus? Status { get; set; }
}