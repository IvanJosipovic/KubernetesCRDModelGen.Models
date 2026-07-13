#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.backupdr.cnrm.cloud.google.com;
/// <summary>BackupDRBackupPlan is the Schema for the BackupDRBackupPlan API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackupDRBackupPlanList : IKubernetesObject<V1ListMeta>, IItems<V1beta1BackupDRBackupPlan>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackupDRBackupPlanList";
    public const string KubeGroup = "backupdr.cnrm.cloud.google.com";
    public const string KubePluralName = "backupdrbackupplans";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "backupdr.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupDRBackupPlanList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1BackupDRBackupPlan objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1BackupDRBackupPlan> Items { get; set; }
}

/// <summary>
/// Required. A BackupWindow defines the window of day during which backup jobs
///  will run. Jobs are queued at the beginning of the window and will be marked
///  as `NOT_RUN` if they do not start by the end of the window.
/// 
///  Note: running jobs will not be cancelled at the end of the window.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanSpecBackupRulesStandardScheduleBackupWindow
{
    /// <summary>
    /// Required. The hour of day (1-24) when the window end for e.g. if value of
    ///  end hour of day is 10 that mean backup window end time is 10:00.
    /// 
    ///  End hour of day should be greater than start hour of day.
    ///  0 &lt;= start_hour_of_day &lt; end_hour_of_day &lt;= 24
    /// 
    ///  End hour of day is not include in backup window that mean if
    ///  end_hour_of_day= 10 jobs should start before 10:00.
    /// </summary>
    [JsonPropertyName("endHourOfDay")]
    public int? EndHourOfDay { get; set; }

    /// <summary>Required. The hour of day (0-23) when the window starts for e.g. if value of start hour of day is 6 that mean backup window start at 6:00.</summary>
    [JsonPropertyName("startHourOfDay")]
    public int? StartHourOfDay { get; set; }
}

/// <summary>
/// Optional. Specifies a week day of the month like, FIRST SUNDAY or LAST
///  MONDAY, on which jobs will run. This will be specified by two fields in
///  `WeekDayOfMonth`, one for the day, e.g. `MONDAY`, and one for the week,
///  e.g. `LAST`.
/// 
///  This field is only applicable for `recurrence_type`, `MONTHLY` and
///  `YEARLY`. A validation error will occur if other values are supplied.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanSpecBackupRulesStandardScheduleWeekDayOfMonth
{
    /// <summary>Required. Specifies the day of the week.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>Required. Specifies the week of the month.</summary>
    [JsonPropertyName("weekOfMonth")]
    public string? WeekOfMonth { get; set; }
}

/// <summary>Optional. Defines a schedule that runs within the confines of a defined window of time.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanSpecBackupRulesStandardSchedule
{
    /// <summary>
    /// Required. A BackupWindow defines the window of day during which backup jobs
    ///  will run. Jobs are queued at the beginning of the window and will be marked
    ///  as `NOT_RUN` if they do not start by the end of the window.
    /// 
    ///  Note: running jobs will not be cancelled at the end of the window.
    /// </summary>
    [JsonPropertyName("backupWindow")]
    public V1beta1BackupDRBackupPlanSpecBackupRulesStandardScheduleBackupWindow? BackupWindow { get; set; }

    /// <summary>
    /// Optional. Specifies days of months like 1, 5, or 14 on which jobs will run.
    /// 
    ///  Values for `days_of_month` are only applicable for `recurrence_type`,
    ///  `MONTHLY` and `YEARLY`. A validation error will occur if other values are
    ///  supplied.
    /// </summary>
    [JsonPropertyName("daysOfMonth")]
    public IList<int>? DaysOfMonth { get; set; }

    /// <summary>
    /// Optional. Specifies days of week like, MONDAY or TUESDAY, on which jobs
    ///  will run.
    /// 
    ///  This is required for `recurrence_type`, `WEEKLY` and is not applicable
    ///  otherwise. A validation error will occur if a value is supplied and
    ///  `recurrence_type` is not `WEEKLY`.
    /// </summary>
    [JsonPropertyName("daysOfWeek")]
    public IList<string>? DaysOfWeek { get; set; }

    /// <summary>
    /// Optional. Specifies frequency for hourly backups. A hourly frequency of 2
    ///  means jobs will run every 2 hours from start time till end time defined.
    /// 
    ///  This is required for `recurrence_type`, `HOURLY` and is not applicable
    ///  otherwise. A validation error will occur if a value is supplied and
    ///  `recurrence_type` is not `HOURLY`.
    /// 
    ///  Value of hourly frequency should be between 4 and 23.
    /// 
    ///  Reason for limit : We found that there is bandwidth limitation of 3GB/S for
    ///  GMI while taking a backup and 5GB/S while doing a restore. Given the amount
    ///  of parallel backups and restore we are targeting, this will potentially
    ///  take the backup time to mins and hours (in worst case scenario).
    /// </summary>
    [JsonPropertyName("hourlyFrequency")]
    public int? HourlyFrequency { get; set; }

    /// <summary>
    /// Optional. Specifies the months of year, like `FEBRUARY` and/or `MAY`, on
    ///  which jobs will run.
    /// 
    ///  This field is only applicable when `recurrence_type` is `YEARLY`. A
    ///  validation error will occur if other values are supplied.
    /// </summary>
    [JsonPropertyName("months")]
    public IList<string>? Months { get; set; }

    /// <summary>Required. Specifies the `RecurrenceType` for the schedule.</summary>
    [JsonPropertyName("recurrenceType")]
    public string? RecurrenceType { get; set; }

    /// <summary>Required. The time zone to be used when interpreting the schedule. The value of this field must be a time zone name from the IANA tz database. See https://en.wikipedia.org/wiki/List_of_tz_database_time_zones for the list of valid timezone names. For e.g., Europe/Paris.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }

    /// <summary>
    /// Optional. Specifies a week day of the month like, FIRST SUNDAY or LAST
    ///  MONDAY, on which jobs will run. This will be specified by two fields in
    ///  `WeekDayOfMonth`, one for the day, e.g. `MONDAY`, and one for the week,
    ///  e.g. `LAST`.
    /// 
    ///  This field is only applicable for `recurrence_type`, `MONTHLY` and
    ///  `YEARLY`. A validation error will occur if other values are supplied.
    /// </summary>
    [JsonPropertyName("weekDayOfMonth")]
    public V1beta1BackupDRBackupPlanSpecBackupRulesStandardScheduleWeekDayOfMonth? WeekDayOfMonth { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanSpecBackupRules
{
    /// <summary>
    /// Required. Configures the duration for which backup data will be kept. It is
    ///  defined in “days”. The value should be greater than or equal to minimum
    ///  enforced retention of the backup vault.
    /// 
    ///  Minimum value is 1 and maximum value is 36159 for custom retention
    ///  on-demand backup.
    ///  Minimum and maximum values are workload specific for all other rules.
    /// </summary>
    [JsonPropertyName("backupRetentionDays")]
    public int? BackupRetentionDays { get; set; }

    /// <summary>Required. Immutable. The unique id of this `BackupRule`. The `rule_id` is unique per `BackupPlan`.The `rule_id` must start with a lowercase letter followed by up to 62 lowercase letters, numbers, or hyphens. Pattern, /[a-z][a-z0-9-]{,62}/.</summary>
    [JsonPropertyName("ruleID")]
    public string? RuleID { get; set; }

    /// <summary>Optional. Defines a schedule that runs within the confines of a defined window of time.</summary>
    [JsonPropertyName("standardSchedule")]
    public V1beta1BackupDRBackupPlanSpecBackupRulesStandardSchedule? StandardSchedule { get; set; }
}

/// <summary>Required. Resource name of backup vault which will be used as storage location for backups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanSpecBackupVaultRef
{
    /// <summary>A reference to an externally managed BackupDRBackupVault resource. Should be in the format &quot;projects/{{projectID}}/locations/{{location}}/backupVaults/{{backupvaultID}}&quot;.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The name of a BackupDRBackupVault resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The namespace of a BackupDRBackupVault resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>The Project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>BackupDRBackupPlanSpec defines the desired state of BackupDRBackupPlan</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanSpec
{
    /// <summary>Required. The backup rules for this `BackupPlan`. There must be at least one `BackupRule` message.</summary>
    [JsonPropertyName("backupRules")]
    public IList<V1beta1BackupDRBackupPlanSpecBackupRules>? BackupRules { get; set; }

    /// <summary>Required. Resource name of backup vault which will be used as storage location for backups.</summary>
    [JsonPropertyName("backupVaultRef")]
    public required V1beta1BackupDRBackupPlanSpecBackupVaultRef BackupVaultRef { get; set; }

    /// <summary>
    /// Optional. The description of the `BackupPlan` resource.
    /// 
    ///  The description allows for additional details about `BackupPlan` and its
    ///  use cases to be provided. An example description is the following:  &quot;This
    ///  is a backup plan that performs a daily backup at 6pm and retains data for 3
    ///  months&quot;. The description must be at most 2048 characters.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Immutable.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The Project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1beta1BackupDRBackupPlanSpecProjectRef ProjectRef { get; set; }

    /// <summary>The BackupDRBackupPlan name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>Required. The resource type to which the `BackupPlan` will be applied. Examples include, &quot;compute.googleapis.com/Instance&quot;, &quot;sqladmin.googleapis.com/Instance&quot;, or &quot;alloydb.googleapis.com/Cluster&quot;.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanStatusConditions
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
public partial class V1beta1BackupDRBackupPlanStatusObservedState
{
    /// <summary>Output only. The Google Cloud Platform Service Account to be used by the BackupVault for taking backups. Specify the email address of the Backup Vault Service Account.</summary>
    [JsonPropertyName("backupVaultServiceAccount")]
    public string? BackupVaultServiceAccount { get; set; }

    /// <summary>Output only. When the `BackupPlan` was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. The `State` for the `BackupPlan`.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. When the `BackupPlan` was last updated.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>BackupDRBackupPlanStatus defines the config connector machine state of BackupDRBackupPlan</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1BackupDRBackupPlanStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1BackupDRBackupPlanStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the BackupDRBackupPlan resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1beta1BackupDRBackupPlanStatusObservedState? ObservedState { get; set; }
}

/// <summary>BackupDRBackupPlan is the Schema for the BackupDRBackupPlan API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1BackupDRBackupPlan : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1BackupDRBackupPlanSpec>, IStatus<V1beta1BackupDRBackupPlanStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "BackupDRBackupPlan";
    public const string KubeGroup = "backupdr.cnrm.cloud.google.com";
    public const string KubePluralName = "backupdrbackupplans";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "backupdr.cnrm.cloud.google.com/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "BackupDRBackupPlan";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>BackupDRBackupPlanSpec defines the desired state of BackupDRBackupPlan</summary>
    [JsonPropertyName("spec")]
    public required V1beta1BackupDRBackupPlanSpec Spec { get; set; }

    /// <summary>BackupDRBackupPlanStatus defines the config connector machine state of BackupDRBackupPlan</summary>
    [JsonPropertyName("status")]
    public V1beta1BackupDRBackupPlanStatus? Status { get; set; }
}