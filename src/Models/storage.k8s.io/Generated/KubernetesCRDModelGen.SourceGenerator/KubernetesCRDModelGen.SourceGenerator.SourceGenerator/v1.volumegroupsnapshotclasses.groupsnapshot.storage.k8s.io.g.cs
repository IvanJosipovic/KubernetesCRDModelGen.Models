#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.groupsnapshot.storage.k8s.io;
/// <summary>
/// VolumeGroupSnapshotClass specifies parameters that a underlying storage system
/// uses when creating a volume group snapshot. A specific VolumeGroupSnapshotClass
/// is used by specifying its name in a VolumeGroupSnapshot object.
/// VolumeGroupSnapshotClasses are non-namespaced.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1VolumeGroupSnapshotClassList : IKubernetesObject<V1ListMeta>, IItems<V1VolumeGroupSnapshotClass>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "VolumeGroupSnapshotClassList";
    public const string KubeGroup = "groupsnapshot.storage.k8s.io";
    public const string KubePluralName = "volumegroupsnapshotclasses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "groupsnapshot.storage.k8s.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VolumeGroupSnapshotClassList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1VolumeGroupSnapshotClass objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1VolumeGroupSnapshotClass> Items { get; set; }
}

/// <summary>
/// DeletionPolicy determines whether a VolumeGroupSnapshotContent created
/// through the VolumeGroupSnapshotClass should be deleted when its bound
/// VolumeGroupSnapshot is deleted.
/// Supported values are &quot;Retain&quot; and &quot;Delete&quot;.
/// &quot;Retain&quot; means that the VolumeGroupSnapshotContent and its physical group
/// snapshot on underlying storage system are kept.
/// &quot;Delete&quot; means that the VolumeGroupSnapshotContent and its physical group
/// snapshot on underlying storage system are deleted.
/// Required.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1VolumeGroupSnapshotClassDeletionPolicyEnum>))]
public enum V1VolumeGroupSnapshotClassDeletionPolicyEnum
{
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "Retain"), JsonStringEnumMemberName("Retain")]
    Retain
}

/// <summary>
/// VolumeGroupSnapshotClass specifies parameters that a underlying storage system
/// uses when creating a volume group snapshot. A specific VolumeGroupSnapshotClass
/// is used by specifying its name in a VolumeGroupSnapshot object.
/// VolumeGroupSnapshotClasses are non-namespaced.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1VolumeGroupSnapshotClass : IKubernetesObject<V1ObjectMeta>
{
    public const string KubeApiVersion = "v1";
    public const string KubeKind = "VolumeGroupSnapshotClass";
    public const string KubeGroup = "groupsnapshot.storage.k8s.io";
    public const string KubePluralName = "volumegroupsnapshotclasses";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "groupsnapshot.storage.k8s.io/v1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VolumeGroupSnapshotClass";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// DeletionPolicy determines whether a VolumeGroupSnapshotContent created
    /// through the VolumeGroupSnapshotClass should be deleted when its bound
    /// VolumeGroupSnapshot is deleted.
    /// Supported values are &quot;Retain&quot; and &quot;Delete&quot;.
    /// &quot;Retain&quot; means that the VolumeGroupSnapshotContent and its physical group
    /// snapshot on underlying storage system are kept.
    /// &quot;Delete&quot; means that the VolumeGroupSnapshotContent and its physical group
    /// snapshot on underlying storage system are deleted.
    /// Required.
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public required V1VolumeGroupSnapshotClassDeletionPolicyEnum DeletionPolicy { get; set; }

    /// <summary>
    /// Driver is the name of the storage driver expected to handle this VolumeGroupSnapshotClass.
    /// Required.
    /// </summary>
    [JsonPropertyName("driver")]
    public required string Driver { get; set; }

    /// <summary>
    /// Parameters is a key-value map with storage driver specific parameters for
    /// creating group snapshots.
    /// These values are opaque to Kubernetes and are passed directly to the driver.
    /// </summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }
}