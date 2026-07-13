#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.firestore.cnrm.cloud.google.com;
/// <summary>FirestoreBackupSchedule is the Schema for the FirestoreBackupSchedule API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FirestoreBackupScheduleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1FirestoreBackupSchedule>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FirestoreBackupScheduleList";
    public const string KubeGroup = "firestore.cnrm.cloud.google.com";
    public const string KubePluralName = "firestorebackupschedules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firestore.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirestoreBackupScheduleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1FirestoreBackupSchedule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1FirestoreBackupSchedule> Items { get; set; }
}

/// <summary>For a schedule that runs daily.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreBackupScheduleSpecDailyRecurrence
{
}

/// <summary>The database that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreBackupScheduleSpecDatabaseRef
{
    /// <summary>A reference to an externally managed Firestore database resource. Should be in the format &quot;projects/{{projectID}}/databases/{{databaseID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a FirestoreDatabase resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a FirestoreDatabase resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>For a schedule that runs weekly on a specific day.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreBackupScheduleSpecWeeklyRecurrence
{
    /// <summary>
    /// The day of week to run.
    /// 
    ///  DAY_OF_WEEK_UNSPECIFIED is not allowed.
    /// </summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }
}

/// <summary>FirestoreBackupScheduleSpec defines the desired state of FirestoreBackupSchedule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreBackupScheduleSpec
{
    /// <summary>For a schedule that runs daily.</summary>
    [JsonPropertyName("dailyRecurrence")]
    public V1alpha1FirestoreBackupScheduleSpecDailyRecurrence? DailyRecurrence { get; set; }

    /// <summary>The database that this resource belongs to.</summary>
    [JsonPropertyName("databaseRef")]
    public required V1alpha1FirestoreBackupScheduleSpecDatabaseRef DatabaseRef { get; set; }

    /// <summary>
    /// At what relative time in the future, compared to its creation time,
    ///  the backup should be deleted, e.g. keep backups for 7 days.
    /// 
    ///  The maximum supported retention period is 14 weeks.
    /// </summary>
    [JsonPropertyName("retention")]
    public string? Retention { get; set; }

    /// <summary>For a schedule that runs weekly on a specific day.</summary>
    [JsonPropertyName("weeklyRecurrence")]
    public V1alpha1FirestoreBackupScheduleSpecWeeklyRecurrence? WeeklyRecurrence { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreBackupScheduleStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreBackupScheduleStatusObservedState
{
    /// <summary>
    /// Output only. The timestamp at which this backup schedule was created and
    ///  effective since.
    /// 
    ///  No backups will be created for this schedule before this time.
    /// </summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>
    /// Output only. The unique backup schedule identifier across all locations and
    ///  databases for the given project.
    /// 
    ///  This will be auto-assigned.
    /// 
    ///  Format is
    ///  `projects/{project}/databases/{database}/backupSchedules/{backup_schedule}`
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. The timestamp at which this backup schedule was most recently updated. When a backup schedule is first created, this is the same as create_time.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>FirestoreBackupScheduleStatus defines the config connector machine state of FirestoreBackupSchedule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1FirestoreBackupScheduleStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1FirestoreBackupScheduleStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the FirestoreBackupSchedule resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1FirestoreBackupScheduleStatusObservedState? ObservedState { get; set; }
}

/// <summary>FirestoreBackupSchedule is the Schema for the FirestoreBackupSchedule API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1FirestoreBackupSchedule : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1FirestoreBackupScheduleSpec>, IStatus<V1alpha1FirestoreBackupScheduleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "FirestoreBackupSchedule";
    public const string KubeGroup = "firestore.cnrm.cloud.google.com";
    public const string KubePluralName = "firestorebackupschedules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "firestore.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "FirestoreBackupSchedule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>FirestoreBackupScheduleSpec defines the desired state of FirestoreBackupSchedule</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1FirestoreBackupScheduleSpec Spec { get; set; }

    /// <summary>FirestoreBackupScheduleStatus defines the config connector machine state of FirestoreBackupSchedule</summary>
    [JsonPropertyName("status")]
    public V1alpha1FirestoreBackupScheduleStatus? Status { get; set; }
}