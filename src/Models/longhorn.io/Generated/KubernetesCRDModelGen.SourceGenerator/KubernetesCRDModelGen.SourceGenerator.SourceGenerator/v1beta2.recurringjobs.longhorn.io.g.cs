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
/// <summary>RecurringJob is where Longhorn stores recurring job object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RecurringJobList : IKubernetesObject<V1ListMeta>, IItems<V1beta2RecurringJob>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RecurringJobList";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "recurringjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RecurringJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2RecurringJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2RecurringJob> Items { get; set; }
}

/// <summary>
/// The recurring job task.
/// Can be &quot;snapshot&quot;, &quot;snapshot-force-create&quot;, &quot;snapshot-cleanup&quot;, &quot;snapshot-delete&quot;, &quot;backup&quot;, &quot;backup-force-create&quot;, &quot;filesystem-trim&quot; or &quot;system-backup&quot;.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RecurringJobSpecTaskEnum>))]
public enum V1beta2RecurringJobSpecTaskEnum
{
    [EnumMember(Value = "snapshot"), JsonStringEnumMemberName("snapshot")]
    Snapshot,
    [EnumMember(Value = "snapshot-force-create"), JsonStringEnumMemberName("snapshot-force-create")]
    SnapshotForceCreate,
    [EnumMember(Value = "snapshot-cleanup"), JsonStringEnumMemberName("snapshot-cleanup")]
    SnapshotCleanup,
    [EnumMember(Value = "snapshot-delete"), JsonStringEnumMemberName("snapshot-delete")]
    SnapshotDelete,
    [EnumMember(Value = "backup"), JsonStringEnumMemberName("backup")]
    Backup,
    [EnumMember(Value = "backup-force-create"), JsonStringEnumMemberName("backup-force-create")]
    BackupForceCreate,
    [EnumMember(Value = "filesystem-trim"), JsonStringEnumMemberName("filesystem-trim")]
    FilesystemTrim,
    [EnumMember(Value = "system-backup"), JsonStringEnumMemberName("system-backup")]
    SystemBackup
}

/// <summary>RecurringJobSpec defines the desired state of the Longhorn recurring job</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecurringJobSpec
{
    /// <summary>The concurrency of taking the snapshot/backup.</summary>
    [JsonPropertyName("concurrency")]
    public int? Concurrency { get; set; }

    /// <summary>The cron setting.</summary>
    [JsonPropertyName("cron")]
    public string? Cron { get; set; }

    /// <summary>The recurring job group.</summary>
    [JsonPropertyName("groups")]
    public IList<string>? Groups { get; set; }

    /// <summary>The label of the snapshot/backup.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The recurring job name.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The parameters of the snapshot/backup.
    /// Support parameters: &quot;full-backup-interval&quot;, &quot;volume-backup-policy&quot;.
    /// </summary>
    [JsonPropertyName("parameters")]
    public IDictionary<string, string>? Parameters { get; set; }

    /// <summary>The retain count of the snapshot/backup.</summary>
    [JsonPropertyName("retain")]
    public int? Retain { get; set; }

    /// <summary>
    /// The recurring job task.
    /// Can be &quot;snapshot&quot;, &quot;snapshot-force-create&quot;, &quot;snapshot-cleanup&quot;, &quot;snapshot-delete&quot;, &quot;backup&quot;, &quot;backup-force-create&quot;, &quot;filesystem-trim&quot; or &quot;system-backup&quot;.
    /// </summary>
    [JsonPropertyName("task")]
    public V1beta2RecurringJobSpecTaskEnum? Task { get; set; }
}

/// <summary>RecurringJobStatus defines the observed state of the Longhorn recurring job</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RecurringJobStatus
{
    /// <summary>The number of jobs that have been triggered.</summary>
    [JsonPropertyName("executionCount")]
    public int? ExecutionCount { get; set; }

    /// <summary>The owner ID which is responsible to reconcile this recurring job CR.</summary>
    [JsonPropertyName("ownerID")]
    public string? OwnerID { get; set; }
}

/// <summary>RecurringJob is where Longhorn stores recurring job object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RecurringJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2RecurringJobSpec?>, IStatus<V1beta2RecurringJobStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RecurringJob";
    public const string KubeGroup = "longhorn.io";
    public const string KubePluralName = "recurringjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "longhorn.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RecurringJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RecurringJobSpec defines the desired state of the Longhorn recurring job</summary>
    [JsonPropertyName("spec")]
    public V1beta2RecurringJobSpec? Spec { get; set; }

    /// <summary>RecurringJobStatus defines the observed state of the Longhorn recurring job</summary>
    [JsonPropertyName("status")]
    public V1beta2RecurringJobStatus? Status { get; set; }
}