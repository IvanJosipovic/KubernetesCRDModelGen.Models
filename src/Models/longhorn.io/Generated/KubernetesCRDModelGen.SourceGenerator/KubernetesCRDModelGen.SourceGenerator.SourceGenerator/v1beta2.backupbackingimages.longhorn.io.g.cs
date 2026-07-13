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
/// <summary>BackupBackingImage is where Longhorn stores backing image backup object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackupBackingImageList : IKubernetesObject<V1ListMeta>, IItems<V1beta2BackupBackingImage>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackupBackingImageList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "backupbackingimages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupBackingImageList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2BackupBackingImage objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2BackupBackingImage> Items { get; set; }
}

/// <summary>BackupBackingImageSpec defines the desired state of the Longhorn backing image backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupBackingImageSpec
{
    /// <summary>The backing image name.</summary>
    [JsonPropertyName("backingImage")]
    public required string BackingImage { get; set; }

    /// <summary>The backup target name.</summary>
    [JsonPropertyName("backupTargetName")]
    public string? BackupTargetName { get; set; }

    /// <summary>The labels of backing image backup.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The time to request run sync the remote backing image backup.</summary>
    [JsonPropertyName("syncRequestedAt")]
    public DateTime? SyncRequestedAt { get; set; }

    /// <summary>Is this CR created by user through API or UI.</summary>
    [JsonPropertyName("userCreated")]
    public required bool UserCreated { get; set; }
}

/// <summary>BackupBackingImageStatus defines the observed state of the Longhorn backing image backup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2BackupBackingImageStatus
{
    /// <summary>The backing image name.</summary>
    [JsonPropertyName("backingImage")]
    public string? BackingImage { get; set; }

    /// <summary>The backing image backup upload finished time.</summary>
    [JsonPropertyName("backupCreatedAt")]
    public string? BackupCreatedAt { get; set; }

    /// <summary>The checksum of the backing image.</summary>
    [JsonPropertyName("checksum")]
    public string? Checksum { get; set; }

    /// <summary>Compression method</summary>
    [JsonPropertyName("compressionMethod")]
    public string? CompressionMethod { get; set; }

    /// <summary>The error message when taking the backing image backup.</summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary>The labels of backing image backup.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The last time that the backing image backup was synced with the remote backup target.</summary>
    [JsonPropertyName("lastSyncedAt")]
    public DateTime? LastSyncedAt { get; set; }

    /// <summary>The address of the backing image manager that runs backing image backup.</summary>
    [JsonPropertyName("managerAddress")]
    public string? ManagerAddress { get; set; }

    /// <summary>The error messages when listing or inspecting backing image backup.</summary>
    [JsonPropertyName("messages")]
    public IDictionary<string, string>? Messages { get; set; }

    /// <summary>The node ID on which the controller is responsible to reconcile this CR.</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }

    /// <summary>The backing image backup progress.</summary>
    [JsonPropertyName("progress")]
    public int? Progress { get; set; }

    /// <summary>Record the secret if this backup backing image is encrypted</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Record the secret namespace if this backup backing image is encrypted</summary>
    [JsonPropertyName("secretNamespace")]
    public string? SecretNamespace { get; set; }

    /// <summary>The backing image size.</summary>
    [JsonPropertyName("size")]
    public long? Size { get; set; }

    /// <summary>
    /// The backing image backup creation state.
    /// Can be &quot; &quot;, &quot;InProgress&quot;, &quot;Completed&quot;, &quot;Error&quot;, &quot;Unknown&quot;.
    /// </summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>The backing image backup URL.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>BackupBackingImage is where Longhorn stores backing image backup object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2BackupBackingImage : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2BackupBackingImageSpec?>, IStatus<V1beta2BackupBackingImageStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "BackupBackingImage";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "backupbackingimages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupBackingImage";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupBackingImageSpec defines the desired state of the Longhorn backing image backup</summary>
    [JsonPropertyName("spec")]
    public V1beta2BackupBackingImageSpec? Spec { get; set; }

    /// <summary>BackupBackingImageStatus defines the observed state of the Longhorn backing image backup</summary>
    [JsonPropertyName("status")]
    public V1beta2BackupBackingImageStatus? Status { get; set; }
}