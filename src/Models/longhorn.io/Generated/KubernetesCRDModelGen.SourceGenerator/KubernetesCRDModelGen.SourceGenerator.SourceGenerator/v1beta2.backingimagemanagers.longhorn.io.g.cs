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
/// <summary>BackingImageManager is where Longhorn stores backing image manager object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackingImageManagerList : IKubernetesObject<V1ListMeta>, IItems<V1beta2BackingImageManager>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackingImageManagerList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "backingimagemanagers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackingImageManagerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2BackingImageManager objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2BackingImageManager> Items { get; set; }
}

/// <summary>BackingImageManagerSpec defines the desired state of the Longhorn backing image manager</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackingImageManagerSpec
{
    [JsonPropertyName("backingImages")]
    public IDictionary<string, string>? BackingImages { get; set; }

    [JsonPropertyName("diskPath")]
    public string? DiskPath { get; set; }

    [JsonPropertyName("diskUUID")]
    public string? DiskUUID { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("nodeID")]
    public string? NodeID { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackingImageManagerStatusBackingImageFileMap
{
    [JsonPropertyName("currentChecksum")]
    public string? CurrentChecksum { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("progress")]
    public int? Progress { get; set; }

    [JsonPropertyName("realSize")]
    public long? RealSize { get; set; }

    [JsonPropertyName("senderManagerAddress")]
    public string? SenderManagerAddress { get; set; }

    [JsonPropertyName("sendingReference")]
    public int? SendingReference { get; set; }

    [JsonPropertyName("size")]
    public long? Size { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    [JsonPropertyName("virtualSize")]
    public long? VirtualSize { get; set; }
}

/// <summary>BackingImageManagerStatus defines the observed state of the Longhorn backing image manager</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackingImageManagerStatus
{
    [JsonPropertyName("apiMinVersion")]
    public int? ApiMinVersion { get; set; }

    [JsonPropertyName("apiVersion")]
    public int? ApiVersion { get; set; }

    [JsonPropertyName("backingImageFileMap")]
    public IDictionary<string, V1beta2BackingImageManagerStatusBackingImageFileMap>? BackingImageFileMap { get; set; }

    [JsonPropertyName("currentState")]
    public string? CurrentState { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    [JsonPropertyName("storageIP")]
    public string? StorageIP { get; set; }
}

/// <summary>BackingImageManager is where Longhorn stores backing image manager object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackingImageManager : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2BackingImageManagerSpec?>, IStatus<V1beta2BackingImageManagerStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackingImageManager";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "backingimagemanagers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackingImageManager";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackingImageManagerSpec defines the desired state of the Longhorn backing image manager</summary>
    [JsonPropertyName("spec")]
    public V1beta2BackingImageManagerSpec? Spec { get; set; }

    /// <summary>BackingImageManagerStatus defines the observed state of the Longhorn backing image manager</summary>
    [JsonPropertyName("status")]
    public V1beta2BackingImageManagerStatus? Status { get; set; }
}