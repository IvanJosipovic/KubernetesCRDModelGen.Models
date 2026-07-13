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
/// <summary>BackingImageDataSource is where Longhorn stores backing image data source object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackingImageDataSourceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2BackingImageDataSource>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackingImageDataSourceList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "backingimagedatasources";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackingImageDataSourceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2BackingImageDataSource objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2BackingImageDataSource> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackingImageDataSourceSpecSourceTypeEnum>))]
public enum V1beta2BackingImageDataSourceSpecSourceTypeEnum
{
    [EnumMember(Value = "download"), JsonStringEnumMemberName("download")]
    Download,
    [EnumMember(Value = "upload"), JsonStringEnumMemberName("upload")]
    Upload,
    [EnumMember(Value = "export-from-volume"), JsonStringEnumMemberName("export-from-volume")]
    ExportFromVolume,
    [EnumMember(Value = "restore"), JsonStringEnumMemberName("restore")]
    Restore,
    [EnumMember(Value = "clone"), JsonStringEnumMemberName("clone")]
    Clone
}

/// <summary>BackingImageDataSourceSpec defines the desired state of the Longhorn backing image data source</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackingImageDataSourceSpec
{
    [JsonPropertyName("checksum")]
    public string? Checksum { get; set; }

    [JsonPropertyName("diskPath")]
    public string? DiskPath { get; set; }

    [JsonPropertyName("diskUUID")]
    public string? DiskUUID { get; set; }

    [JsonPropertyName("fileTransferred")]
    public bool? FileTransferred { get; set; }

    [JsonPropertyName("nodeID")]
    public string? NodeID { get; set; }

    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    [JsonPropertyName("sourceType")]
    public V1beta2BackingImageDataSourceSpecSourceTypeEnum? SourceType { get; set; }

    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }
}

/// <summary>BackingImageDataSourceStatus defines the observed state of the Longhorn backing image data source</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackingImageDataSourceStatus
{
    [JsonPropertyName("checksum")]
    public string? Checksum { get; set; }

    [JsonPropertyName("currentState")]
    public string? CurrentState { get; set; }

    [JsonPropertyName("ip")]
    public string? Ip { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    [JsonPropertyName("progress")]
    public int? Progress { get; set; }

    [JsonPropertyName("runningParameters")]
    public IDictionary<string, string>? RunningParameters { get; set; }

    [JsonPropertyName("size")]
    public long? Size { get; set; }

    [JsonPropertyName("storageIP")]
    public string? StorageIP { get; set; }
}

/// <summary>BackingImageDataSource is where Longhorn stores backing image data source object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackingImageDataSource : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2BackingImageDataSourceSpec?>, IStatus<V1beta2BackingImageDataSourceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackingImageDataSource";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "backingimagedatasources";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackingImageDataSource";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackingImageDataSourceSpec defines the desired state of the Longhorn backing image data source</summary>
    [JsonPropertyName("spec")]
    public V1beta2BackingImageDataSourceSpec? Spec { get; set; }

    /// <summary>BackingImageDataSourceStatus defines the observed state of the Longhorn backing image data source</summary>
    [JsonPropertyName("status")]
    public V1beta2BackingImageDataSourceStatus? Status { get; set; }
}