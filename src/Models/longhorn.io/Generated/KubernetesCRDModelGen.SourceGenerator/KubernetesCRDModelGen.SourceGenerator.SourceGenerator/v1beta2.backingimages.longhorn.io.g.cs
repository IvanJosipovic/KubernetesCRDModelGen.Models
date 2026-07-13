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
/// <summary>BackingImage is where Longhorn stores backing image object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackingImageList : IKubernetesObject<V1ListMeta>, IItems<V1beta2BackingImage>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackingImageList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "backingimages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackingImageList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2BackingImage objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2BackingImage> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackingImageSpecDataEngineEnum>))]
public enum V1beta2BackingImageSpecDataEngineEnum
{
    [EnumMember(Value = "v1"), JsonStringEnumMemberName("v1")]
    V1,
    [EnumMember(Value = "v2"), JsonStringEnumMemberName("v2")]
    V2
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackingImageSpecDiskFileSpecMapDataEngineEnum>))]
public enum V1beta2BackingImageSpecDiskFileSpecMapDataEngineEnum
{
    [EnumMember(Value = "v1"), JsonStringEnumMemberName("v1")]
    V1,
    [EnumMember(Value = "v2"), JsonStringEnumMemberName("v2")]
    V2
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackingImageSpecDiskFileSpecMap
{
    [JsonPropertyName("dataEngine")]
    public V1beta2BackingImageSpecDiskFileSpecMapDataEngineEnum? DataEngine { get; set; }

    [JsonPropertyName("evictionRequested")]
    public bool? EvictionRequested { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackingImageSpecSourceTypeEnum>))]
public enum V1beta2BackingImageSpecSourceTypeEnum
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

/// <summary>BackingImageSpec defines the desired state of the Longhorn backing image</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackingImageSpec
{
    [JsonPropertyName("checksum")]
    public string? Checksum { get; set; }

    [JsonPropertyName("dataEngine")]
    public V1beta2BackingImageSpecDataEngineEnum? DataEngine { get; set; }

    [JsonPropertyName("diskFileSpecMap")]
    public IDictionary<string, V1beta2BackingImageSpecDiskFileSpecMap>? DiskFileSpecMap { get; set; }

    [JsonPropertyName("diskSelector")]
    public IList<string>? DiskSelector { get; set; }

    /// <summary>Deprecated. We are now using DiskFileSpecMap to assign different spec to the file on different disks.</summary>
    [JsonPropertyName("disks")]
    public IDictionary<string, string>? Disks { get; set; }

    [JsonPropertyName("minNumberOfCopies")]
    public int? MinNumberOfCopies { get; set; }

    [JsonPropertyName("nodeSelector")]
    public IList<string>? NodeSelector { get; set; }

    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    [JsonPropertyName("secretNamespace")]
    public string? SecretNamespace { get; set; }

    [JsonPropertyName("sourceParameters")]
    public IDictionary<string, string>? SourceParameters { get; set; }

    [JsonPropertyName("sourceType")]
    public V1beta2BackingImageSpecSourceTypeEnum? SourceType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2BackingImageStatusDiskFileStatusMapDataEngineEnum>))]
public enum V1beta2BackingImageStatusDiskFileStatusMapDataEngineEnum
{
    [EnumMember(Value = "v1"), JsonStringEnumMemberName("v1")]
    V1,
    [EnumMember(Value = "v2"), JsonStringEnumMemberName("v2")]
    V2
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackingImageStatusDiskFileStatusMap
{
    [JsonPropertyName("dataEngine")]
    public V1beta2BackingImageStatusDiskFileStatusMapDataEngineEnum? DataEngine { get; set; }

    [JsonPropertyName("lastStateTransitionTime")]
    public string? LastStateTransitionTime { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }

    [JsonPropertyName("progress")]
    public int? Progress { get; set; }

    [JsonPropertyName("state")]
    public string? State { get; set; }
}

/// <summary>BackingImageStatus defines the observed state of the Longhorn backing image status</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackingImageStatus
{
    [JsonPropertyName("checksum")]
    public string? Checksum { get; set; }

    [JsonPropertyName("diskFileStatusMap")]
    public IDictionary<string, V1beta2BackingImageStatusDiskFileStatusMap>? DiskFileStatusMap { get; set; }

    [JsonPropertyName("diskLastRefAtMap")]
    public IDictionary<string, string>? DiskLastRefAtMap { get; set; }

    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>Real size of image in bytes, which may be smaller than the size when the file is a sparse file. Will be zero until known (e.g. while a backing image is uploading)</summary>
    [JsonPropertyName("realSize")]
    public long? RealSize { get; set; }

    [JsonPropertyName("size")]
    public long? Size { get; set; }

    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    [JsonPropertyName("v2FirstCopyDisk")]
    public string? V2FirstCopyDisk { get; set; }

    /// <summary>It is pending -&gt; in-progress -&gt; ready/failed</summary>
    [JsonPropertyName("v2FirstCopyStatus")]
    public string? V2FirstCopyStatus { get; set; }

    /// <summary>Virtual size of image in bytes, which may be larger than physical size. Will be zero until known (e.g. while a backing image is uploading)</summary>
    [JsonPropertyName("virtualSize")]
    public long? VirtualSize { get; set; }
}

/// <summary>BackingImage is where Longhorn stores backing image object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackingImage : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2BackingImageSpec?>, IStatus<V1beta2BackingImageStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackingImage";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "backingimages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackingImage";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackingImageSpec defines the desired state of the Longhorn backing image</summary>
    [JsonPropertyName("spec")]
    public V1beta2BackingImageSpec? Spec { get; set; }

    /// <summary>BackingImageStatus defines the observed state of the Longhorn backing image status</summary>
    [JsonPropertyName("status")]
    public V1beta2BackingImageStatus? Status { get; set; }
}