#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.snapshot.storage.k8s.io;
/// <summary>
/// VolumeSnapshotClass specifies parameters that a underlying storage system uses when
/// creating a volume snapshot. A specific VolumeSnapshotClass is used by specifying its
/// name in a VolumeSnapshot object.
/// VolumeSnapshotClasses are non-namespaced
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1VolumeSnapshotClassList : IKubernetesObject<V1ListMeta>, IItems<V1VolumeSnapshotClass>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "VolumeSnapshotClassList";
    public const string KubeGroup = "snapshot.storage.k8s.io";
    public const string KubePluralName = "volumesnapshotclasses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "snapshot.storage.k8s.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VolumeSnapshotClassList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1VolumeSnapshotClass objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1VolumeSnapshotClass> Items { get; set; }
}

/// <summary>
/// A topology selector requirement is a selector that matches given label.
/// This is an alpha feature and may change in the future.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VolumeSnapshotClassAllowedTopologiesMatchLabelExpressions
{
    /// <summary>The label key that the selector applies to.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// An array of string values. One value must match the label to be selected.
    /// Each entry in Values is ORed.
    /// </summary>
    [JsonPropertyName("values")]
    public required IList<string> Values { get; set; }
}

/// <summary>
/// A topology selector term represents the result of label queries. A null
/// or empty topology selector term matches no objects. The requirements of
/// them are ANDed. It provides a subset of functionality as NodeSelectorTerm.
/// This is an alpha feature and may change in the future.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1VolumeSnapshotClassAllowedTopologies
{
    /// <summary>A list of topology selector requirements by labels.</summary>
    [JsonPropertyName("matchLabelExpressions")]
    public IList<V1VolumeSnapshotClassAllowedTopologiesMatchLabelExpressions>? MatchLabelExpressions { get; set; }
}

/// <summary>
/// deletionPolicy determines whether a VolumeSnapshotContent created through
/// the VolumeSnapshotClass should be deleted when its bound VolumeSnapshot is deleted.
/// Supported values are &quot;Retain&quot; and &quot;Delete&quot;.
/// &quot;Retain&quot; means that the VolumeSnapshotContent and its physical snapshot on underlying storage system are kept.
/// &quot;Delete&quot; means that the VolumeSnapshotContent and its physical snapshot on underlying storage system are deleted.
/// Required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1VolumeSnapshotClassDeletionPolicyEnum>))]
public enum V1VolumeSnapshotClassDeletionPolicyEnum
{
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Retain"), JsonStringEnumMemberName("Retain")]
    Retain
}

/// <summary>
/// VolumeSnapshotClass specifies parameters that a underlying storage system uses when
/// creating a volume snapshot. A specific VolumeSnapshotClass is used by specifying its
/// name in a VolumeSnapshot object.
/// VolumeSnapshotClasses are non-namespaced
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1VolumeSnapshotClass : IKubernetesObject<V1ObjectMeta>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "VolumeSnapshotClass";
    public const string KubeGroup = "snapshot.storage.k8s.io";
    public const string KubePluralName = "volumesnapshotclasses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "snapshot.storage.k8s.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VolumeSnapshotClass";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// allowedTopologies restricts the node topologies where snapshots created
    /// using this class are usable from. A snapshot is usable from a location
    /// if volumes created from that snapshot are guaranteed to be accessible
    /// from that location. Each volume plugin defines its own supported
    /// topology specifications. An empty list means there is no topology
    /// restriction. This is passed to the CSI driver as
    /// AccessibilityRequirements in the CreateSnapshotRequest.
    /// This is an alpha field tied to the VolumeSnapshotTopology feature gate
    /// (KEP-5943).
    /// </summary>
    [JsonPropertyName("allowedTopologies")]
    public IList<V1VolumeSnapshotClassAllowedTopologies>? AllowedTopologies { get; set; }

    /// <summary>
    /// deletionPolicy determines whether a VolumeSnapshotContent created through
    /// the VolumeSnapshotClass should be deleted when its bound VolumeSnapshot is deleted.
    /// Supported values are &quot;Retain&quot; and &quot;Delete&quot;.
    /// &quot;Retain&quot; means that the VolumeSnapshotContent and its physical snapshot on underlying storage system are kept.
    /// &quot;Delete&quot; means that the VolumeSnapshotContent and its physical snapshot on underlying storage system are deleted.
    /// Required.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public required V1VolumeSnapshotClassDeletionPolicyEnum DeletionPolicy { get; set; }

    /// <summary>
    /// driver is the name of the storage driver that handles this VolumeSnapshotClass.
    /// Required.
    /// </summary>
    [JsonPropertyName("driver")]
    public required string Driver { get; set; }

    /// <summary>
    /// parameters is a key-value map with storage driver specific parameters for creating snapshots.
    /// These values are opaque to Kubernetes.
    /// </summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}