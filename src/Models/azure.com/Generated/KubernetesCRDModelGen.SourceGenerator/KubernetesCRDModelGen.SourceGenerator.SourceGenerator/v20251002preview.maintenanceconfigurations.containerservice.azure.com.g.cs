#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.containerservice.azure.com;
/// <summary>
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/preview/2025-10-02-preview/managedClusters.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/maintenanceConfigurations/{configName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20251002previewMaintenanceConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V20251002previewMaintenanceConfiguration>
{
    public const string KubeApiVersion = "v20251002preview";
    public const string KubeKind = "MaintenanceConfigurationList";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "maintenanceconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v20251002preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MaintenanceConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V20251002previewMaintenanceConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V20251002previewMaintenanceConfiguration> Items { get; set; }
}

/// <summary>A date range. For example, between &apos;2022-12-23&apos; and &apos;2023-01-05&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationSpecMaintenanceWindowNotAllowedDates
{
    /// <summary>End: The end date of the date span.</summary>
    [JsonPropertyName("end")]
    public required string End { get; set; }

    /// <summary>Start: The start date of the date span.</summary>
    [JsonPropertyName("start")]
    public required string Start { get; set; }
}

/// <summary>AbsoluteMonthly: For schedules like: &apos;recur every month on the 15th&apos; or &apos;recur every 3 months on the 20th&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationSpecMaintenanceWindowScheduleAbsoluteMonthly
{
    /// <summary>DayOfMonth: The date of the month.</summary>
    [JsonPropertyName("dayOfMonth")]
    public required int DayOfMonth { get; set; }

    /// <summary>IntervalMonths: Specifies the number of months between each set of occurrences.</summary>
    [JsonPropertyName("intervalMonths")]
    public required int IntervalMonths { get; set; }
}

/// <summary>Daily: For schedules like: &apos;recur every day&apos; or &apos;recur every 3 days&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationSpecMaintenanceWindowScheduleDaily
{
    /// <summary>IntervalDays: Specifies the number of days between each set of occurrences.</summary>
    [JsonPropertyName("intervalDays")]
    public required int IntervalDays { get; set; }
}

/// <summary>DayOfWeek: Specifies on which day of the week the maintenance occurs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewMaintenanceConfigurationSpecMaintenanceWindowScheduleRelativeMonthlyDayOfWeekEnum>))]
public enum V20251002previewMaintenanceConfigurationSpecMaintenanceWindowScheduleRelativeMonthlyDayOfWeekEnum
{
    [EnumMember(Value = "Friday"), JsonStringEnumMemberName("Friday")]
    Friday,
    [EnumMember(Value = "Monday"), JsonStringEnumMemberName("Monday")]
    Monday,
    [EnumMember(Value = "Saturday"), JsonStringEnumMemberName("Saturday")]
    Saturday,
    [EnumMember(Value = "Sunday"), JsonStringEnumMemberName("Sunday")]
    Sunday,
    [EnumMember(Value = "Thursday"), JsonStringEnumMemberName("Thursday")]
    Thursday,
    [EnumMember(Value = "Tuesday"), JsonStringEnumMemberName("Tuesday")]
    Tuesday,
    [EnumMember(Value = "Wednesday"), JsonStringEnumMemberName("Wednesday")]
    Wednesday
}

/// <summary>WeekIndex: The week index. Specifies on which week of the month the dayOfWeek applies.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewMaintenanceConfigurationSpecMaintenanceWindowScheduleRelativeMonthlyWeekIndexEnum>))]
public enum V20251002previewMaintenanceConfigurationSpecMaintenanceWindowScheduleRelativeMonthlyWeekIndexEnum
{
    [EnumMember(Value = "First"), JsonStringEnumMemberName("First")]
    First,
    [EnumMember(Value = "Fourth"), JsonStringEnumMemberName("Fourth")]
    Fourth,
    [EnumMember(Value = "Last"), JsonStringEnumMemberName("Last")]
    Last,
    [EnumMember(Value = "Second"), JsonStringEnumMemberName("Second")]
    Second,
    [EnumMember(Value = "Third"), JsonStringEnumMemberName("Third")]
    Third
}

/// <summary>RelativeMonthly: For schedules like: &apos;recur every month on the first Monday&apos; or &apos;recur every 3 months on last Friday&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationSpecMaintenanceWindowScheduleRelativeMonthly
{
    /// <summary>DayOfWeek: Specifies on which day of the week the maintenance occurs.</summary>
    [JsonPropertyName("dayOfWeek")]
    public required V20251002previewMaintenanceConfigurationSpecMaintenanceWindowScheduleRelativeMonthlyDayOfWeekEnum DayOfWeek { get; set; }

    /// <summary>IntervalMonths: Specifies the number of months between each set of occurrences.</summary>
    [JsonPropertyName("intervalMonths")]
    public required int IntervalMonths { get; set; }

    /// <summary>WeekIndex: The week index. Specifies on which week of the month the dayOfWeek applies.</summary>
    [JsonPropertyName("weekIndex")]
    public required V20251002previewMaintenanceConfigurationSpecMaintenanceWindowScheduleRelativeMonthlyWeekIndexEnum WeekIndex { get; set; }
}

/// <summary>DayOfWeek: Specifies on which day of the week the maintenance occurs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewMaintenanceConfigurationSpecMaintenanceWindowScheduleWeeklyDayOfWeekEnum>))]
public enum V20251002previewMaintenanceConfigurationSpecMaintenanceWindowScheduleWeeklyDayOfWeekEnum
{
    [EnumMember(Value = "Friday"), JsonStringEnumMemberName("Friday")]
    Friday,
    [EnumMember(Value = "Monday"), JsonStringEnumMemberName("Monday")]
    Monday,
    [EnumMember(Value = "Saturday"), JsonStringEnumMemberName("Saturday")]
    Saturday,
    [EnumMember(Value = "Sunday"), JsonStringEnumMemberName("Sunday")]
    Sunday,
    [EnumMember(Value = "Thursday"), JsonStringEnumMemberName("Thursday")]
    Thursday,
    [EnumMember(Value = "Tuesday"), JsonStringEnumMemberName("Tuesday")]
    Tuesday,
    [EnumMember(Value = "Wednesday"), JsonStringEnumMemberName("Wednesday")]
    Wednesday
}

/// <summary>Weekly: For schedules like: &apos;recur every Monday&apos; or &apos;recur every 3 weeks on Wednesday&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationSpecMaintenanceWindowScheduleWeekly
{
    /// <summary>DayOfWeek: Specifies on which day of the week the maintenance occurs.</summary>
    [JsonPropertyName("dayOfWeek")]
    public required V20251002previewMaintenanceConfigurationSpecMaintenanceWindowScheduleWeeklyDayOfWeekEnum DayOfWeek { get; set; }

    /// <summary>IntervalWeeks: Specifies the number of weeks between each set of occurrences.</summary>
    [JsonPropertyName("intervalWeeks")]
    public required int IntervalWeeks { get; set; }
}

/// <summary>Schedule: Recurrence schedule for the maintenance window.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationSpecMaintenanceWindowSchedule
{
    /// <summary>AbsoluteMonthly: For schedules like: &apos;recur every month on the 15th&apos; or &apos;recur every 3 months on the 20th&apos;.</summary>
    [JsonPropertyName("absoluteMonthly")]
    public V20251002previewMaintenanceConfigurationSpecMaintenanceWindowScheduleAbsoluteMonthly? AbsoluteMonthly { get; set; }

    /// <summary>Daily: For schedules like: &apos;recur every day&apos; or &apos;recur every 3 days&apos;.</summary>
    [JsonPropertyName("daily")]
    public V20251002previewMaintenanceConfigurationSpecMaintenanceWindowScheduleDaily? Daily { get; set; }

    /// <summary>RelativeMonthly: For schedules like: &apos;recur every month on the first Monday&apos; or &apos;recur every 3 months on last Friday&apos;.</summary>
    [JsonPropertyName("relativeMonthly")]
    public V20251002previewMaintenanceConfigurationSpecMaintenanceWindowScheduleRelativeMonthly? RelativeMonthly { get; set; }

    /// <summary>Weekly: For schedules like: &apos;recur every Monday&apos; or &apos;recur every 3 weeks on Wednesday&apos;.</summary>
    [JsonPropertyName("weekly")]
    public V20251002previewMaintenanceConfigurationSpecMaintenanceWindowScheduleWeekly? Weekly { get; set; }
}

/// <summary>MaintenanceWindow: Maintenance window for the maintenance configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationSpecMaintenanceWindow
{
    /// <summary>DurationHours: Length of maintenance window range from 4 to 24 hours.</summary>
    [JsonPropertyName("durationHours")]
    public required int DurationHours { get; set; }

    /// <summary>
    /// NotAllowedDates: Date ranges on which upgrade is not allowed. &apos;utcOffset&apos; applies to this field. For example, with
    /// &apos;utcOffset: +02:00&apos; and &apos;dateSpan&apos; being &apos;2022-12-23&apos; to &apos;2023-01-03&apos;, maintenance will be blocked from &apos;2022-12-22
    /// 22:00&apos; to &apos;2023-01-03 22:00&apos; in UTC time.
    /// </summary>
    [JsonPropertyName("notAllowedDates")]
    public IList<V20251002previewMaintenanceConfigurationSpecMaintenanceWindowNotAllowedDates>? NotAllowedDates { get; set; }

    /// <summary>Schedule: Recurrence schedule for the maintenance window.</summary>
    [JsonPropertyName("schedule")]
    public required V20251002previewMaintenanceConfigurationSpecMaintenanceWindowSchedule Schedule { get; set; }

    /// <summary>
    /// StartDate: The date the maintenance window activates. If the current date is before this date, the maintenance window is
    /// inactive and will not be used for upgrades. If not specified, the maintenance window will be active right away.
    /// </summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>
    /// StartTime: The start time of the maintenance window. Accepted values are from &apos;00:00&apos; to &apos;23:59&apos;. &apos;utcOffset&apos; applies to
    /// this field. For example: &apos;02:00&apos; with &apos;utcOffset: +02:00&apos; means UTC time &apos;00:00&apos;.
    /// </summary>
    [JsonPropertyName("startTime")]
    public required string StartTime { get; set; }

    /// <summary>
    /// UtcOffset: The UTC offset in format +/-HH:mm. For example, &apos;+05:30&apos; for IST and &apos;-07:00&apos; for PST. If not specified, the
    /// default is &apos;+00:00&apos;.
    /// </summary>
    [JsonPropertyName("utcOffset")]
    public string? UtcOffset { get; set; }
}

/// <summary>A time range. For example, between 2021-05-25T13:00:00Z and 2021-05-25T14:00:00Z.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationSpecNotAllowedTime
{
    /// <summary>End: The end of a time span</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>Start: The start of a time span</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationSpecOperatorSpecConfigMapExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// DestinationExpression is a CEL expression and a destination to store the result in. The destination may
/// be a secret or a configmap. The value of the expression is stored at the specified location in
/// the destination.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationSpecOperatorSpecSecretExpressions
{
    /// <summary>Annotations is an optional set of annotations to apply to the destination resource.</summary>
    [JsonPropertyName("annotations")]
    public IDictionary<string, string>? Annotations { get; set; }

    /// <summary>
    /// Key is the key in the ConfigMap or Secret being written to. If the CEL expression in Value returns a string
    /// this is required to identify what key to write to. If the CEL expression in Value returns a map[string]string
    /// Key must not be set, instead the keys written will be determined dynamically based on the keys of the resulting
    /// map[string]string.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Labels is an optional set of labels to apply to the destination resource.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// Name is the name of the Kubernetes configmap or secret to write to.
    /// The configmap or secret will be created in the same namespace as the resource.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Value is a CEL expression. The CEL expression may return a string or a map[string]string. For more information
    /// on CEL in ASO see https://azure.github.io/azure-service-operator/guide/expressions/
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }
}

/// <summary>
/// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
/// passed directly to Azure
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationSpecOperatorSpec
{
    /// <summary>ConfigMapExpressions: configures where to place operator written dynamic ConfigMaps (created with CEL expressions).</summary>
    [JsonPropertyName("configMapExpressions")]
    public IList<V20251002previewMaintenanceConfigurationSpecOperatorSpecConfigMapExpressions>? ConfigMapExpressions { get; set; }

    /// <summary>SecretExpressions: configures where to place operator written dynamic secrets (created with CEL expressions).</summary>
    [JsonPropertyName("secretExpressions")]
    public IList<V20251002previewMaintenanceConfigurationSpecOperatorSpecSecretExpressions>? SecretExpressions { get; set; }
}

/// <summary>
/// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
/// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
/// reference to a containerservice.azure.com/ManagedCluster resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationSpecOwner
{
    [JsonPropertyName("armId")]
    public string? ArmId { get; set; }

    /// <summary>This is the name of the Kubernetes resource to reference.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Day: The day of the week.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V20251002previewMaintenanceConfigurationSpecTimeInWeekDayEnum>))]
public enum V20251002previewMaintenanceConfigurationSpecTimeInWeekDayEnum
{
    [EnumMember(Value = "Friday"), JsonStringEnumMemberName("Friday")]
    Friday,
    [EnumMember(Value = "Monday"), JsonStringEnumMemberName("Monday")]
    Monday,
    [EnumMember(Value = "Saturday"), JsonStringEnumMemberName("Saturday")]
    Saturday,
    [EnumMember(Value = "Sunday"), JsonStringEnumMemberName("Sunday")]
    Sunday,
    [EnumMember(Value = "Thursday"), JsonStringEnumMemberName("Thursday")]
    Thursday,
    [EnumMember(Value = "Tuesday"), JsonStringEnumMemberName("Tuesday")]
    Tuesday,
    [EnumMember(Value = "Wednesday"), JsonStringEnumMemberName("Wednesday")]
    Wednesday
}

/// <summary>Time in a week.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationSpecTimeInWeek
{
    /// <summary>Day: The day of the week.</summary>
    [JsonPropertyName("day")]
    public V20251002previewMaintenanceConfigurationSpecTimeInWeekDayEnum? Day { get; set; }

    /// <summary>
    /// HourSlots: A list of hours in the day used to identify a time range. Each integer hour represents a time range beginning
    /// at 0m after the hour ending at the next hour (non-inclusive). 0 corresponds to 00:00 UTC, 23 corresponds to 23:00 UTC.
    /// Specifying [0, 1] means the 00:00 - 02:00 UTC time range.
    /// </summary>
    [JsonPropertyName("hourSlots")]
    public IList<int>? HourSlots { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationSpec
{
    /// <summary>
    /// AzureName: The name of the resource in Azure. This is often the same as the name of the resource in Kubernetes but it
    /// doesn&apos;t have to be.
    /// </summary>
    [JsonPropertyName("azureName")]
    public string? AzureName { get; set; }

    /// <summary>MaintenanceWindow: Maintenance window for the maintenance configuration.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V20251002previewMaintenanceConfigurationSpecMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>NotAllowedTime: Time slots on which upgrade is not allowed.</summary>
    [JsonPropertyName("notAllowedTime")]
    public IList<V20251002previewMaintenanceConfigurationSpecNotAllowedTime>? NotAllowedTime { get; set; }

    /// <summary>
    /// OperatorSpec: The specification for configuring operator behavior. This field is interpreted by the operator and not
    /// passed directly to Azure
    /// </summary>
    [JsonPropertyName("operatorSpec")]
    public V20251002previewMaintenanceConfigurationSpecOperatorSpec? OperatorSpec { get; set; }

    /// <summary>
    /// Owner: The owner of the resource. The owner controls where the resource goes when it is deployed. The owner also
    /// controls the resources lifecycle. When the owner is deleted the resource will also be deleted. Owner is expected to be a
    /// reference to a containerservice.azure.com/ManagedCluster resource
    /// </summary>
    [JsonPropertyName("owner")]
    public required V20251002previewMaintenanceConfigurationSpecOwner Owner { get; set; }

    /// <summary>
    /// TimeInWeek: Time slots during the week when planned maintenance is allowed to proceed. If two array entries specify the
    /// same day of the week, the applied configuration is the union of times in both entries.
    /// </summary>
    [JsonPropertyName("timeInWeek")]
    public IList<V20251002previewMaintenanceConfigurationSpecTimeInWeek>? TimeInWeek { get; set; }
}

/// <summary>Condition defines an extension to status (an observation) of a resource</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationStatusConditions
{
    /// <summary>LastTransitionTime is the last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>Message is a human readable message indicating details about the transition. This field may be empty.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration is the .metadata.generation that the condition was set based upon. For instance, if
    /// .metadata.generation is currently 12, but the .status.condition[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>
    /// Reason for the condition&apos;s last transition.
    /// Reasons are upper CamelCase (PascalCase) with no spaces. A reason is always provided, this field will not be empty.
    /// </summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>
    /// Severity with which to treat failures of this type of condition.
    /// For conditions which have positive polarity (Status == True is their normal/healthy state), this will be omitted when Status == True
    /// For conditions which have negative polarity (Status == False is their normal/healthy state), this will be omitted when Status == False.
    /// This is omitted in all cases when Status == Unknown
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>Status of the condition, one of True, False, or Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type of condition.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>A date range. For example, between &apos;2022-12-23&apos; and &apos;2023-01-05&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationStatusMaintenanceWindowNotAllowedDates
{
    /// <summary>End: The end date of the date span.</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>Start: The start date of the date span.</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>AbsoluteMonthly: For schedules like: &apos;recur every month on the 15th&apos; or &apos;recur every 3 months on the 20th&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationStatusMaintenanceWindowScheduleAbsoluteMonthly
{
    /// <summary>DayOfMonth: The date of the month.</summary>
    [JsonPropertyName("dayOfMonth")]
    public int? DayOfMonth { get; set; }

    /// <summary>IntervalMonths: Specifies the number of months between each set of occurrences.</summary>
    [JsonPropertyName("intervalMonths")]
    public int? IntervalMonths { get; set; }
}

/// <summary>Daily: For schedules like: &apos;recur every day&apos; or &apos;recur every 3 days&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationStatusMaintenanceWindowScheduleDaily
{
    /// <summary>IntervalDays: Specifies the number of days between each set of occurrences.</summary>
    [JsonPropertyName("intervalDays")]
    public int? IntervalDays { get; set; }
}

/// <summary>RelativeMonthly: For schedules like: &apos;recur every month on the first Monday&apos; or &apos;recur every 3 months on last Friday&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationStatusMaintenanceWindowScheduleRelativeMonthly
{
    /// <summary>DayOfWeek: Specifies on which day of the week the maintenance occurs.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>IntervalMonths: Specifies the number of months between each set of occurrences.</summary>
    [JsonPropertyName("intervalMonths")]
    public int? IntervalMonths { get; set; }

    /// <summary>WeekIndex: The week index. Specifies on which week of the month the dayOfWeek applies.</summary>
    [JsonPropertyName("weekIndex")]
    public string? WeekIndex { get; set; }
}

/// <summary>Weekly: For schedules like: &apos;recur every Monday&apos; or &apos;recur every 3 weeks on Wednesday&apos;.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationStatusMaintenanceWindowScheduleWeekly
{
    /// <summary>DayOfWeek: Specifies on which day of the week the maintenance occurs.</summary>
    [JsonPropertyName("dayOfWeek")]
    public string? DayOfWeek { get; set; }

    /// <summary>IntervalWeeks: Specifies the number of weeks between each set of occurrences.</summary>
    [JsonPropertyName("intervalWeeks")]
    public int? IntervalWeeks { get; set; }
}

/// <summary>Schedule: Recurrence schedule for the maintenance window.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationStatusMaintenanceWindowSchedule
{
    /// <summary>AbsoluteMonthly: For schedules like: &apos;recur every month on the 15th&apos; or &apos;recur every 3 months on the 20th&apos;.</summary>
    [JsonPropertyName("absoluteMonthly")]
    public V20251002previewMaintenanceConfigurationStatusMaintenanceWindowScheduleAbsoluteMonthly? AbsoluteMonthly { get; set; }

    /// <summary>Daily: For schedules like: &apos;recur every day&apos; or &apos;recur every 3 days&apos;.</summary>
    [JsonPropertyName("daily")]
    public V20251002previewMaintenanceConfigurationStatusMaintenanceWindowScheduleDaily? Daily { get; set; }

    /// <summary>RelativeMonthly: For schedules like: &apos;recur every month on the first Monday&apos; or &apos;recur every 3 months on last Friday&apos;.</summary>
    [JsonPropertyName("relativeMonthly")]
    public V20251002previewMaintenanceConfigurationStatusMaintenanceWindowScheduleRelativeMonthly? RelativeMonthly { get; set; }

    /// <summary>Weekly: For schedules like: &apos;recur every Monday&apos; or &apos;recur every 3 weeks on Wednesday&apos;.</summary>
    [JsonPropertyName("weekly")]
    public V20251002previewMaintenanceConfigurationStatusMaintenanceWindowScheduleWeekly? Weekly { get; set; }
}

/// <summary>MaintenanceWindow: Maintenance window for the maintenance configuration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationStatusMaintenanceWindow
{
    /// <summary>DurationHours: Length of maintenance window range from 4 to 24 hours.</summary>
    [JsonPropertyName("durationHours")]
    public int? DurationHours { get; set; }

    /// <summary>
    /// NotAllowedDates: Date ranges on which upgrade is not allowed. &apos;utcOffset&apos; applies to this field. For example, with
    /// &apos;utcOffset: +02:00&apos; and &apos;dateSpan&apos; being &apos;2022-12-23&apos; to &apos;2023-01-03&apos;, maintenance will be blocked from &apos;2022-12-22
    /// 22:00&apos; to &apos;2023-01-03 22:00&apos; in UTC time.
    /// </summary>
    [JsonPropertyName("notAllowedDates")]
    public IList<V20251002previewMaintenanceConfigurationStatusMaintenanceWindowNotAllowedDates>? NotAllowedDates { get; set; }

    /// <summary>Schedule: Recurrence schedule for the maintenance window.</summary>
    [JsonPropertyName("schedule")]
    public V20251002previewMaintenanceConfigurationStatusMaintenanceWindowSchedule? Schedule { get; set; }

    /// <summary>
    /// StartDate: The date the maintenance window activates. If the current date is before this date, the maintenance window is
    /// inactive and will not be used for upgrades. If not specified, the maintenance window will be active right away.
    /// </summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>
    /// StartTime: The start time of the maintenance window. Accepted values are from &apos;00:00&apos; to &apos;23:59&apos;. &apos;utcOffset&apos; applies to
    /// this field. For example: &apos;02:00&apos; with &apos;utcOffset: +02:00&apos; means UTC time &apos;00:00&apos;.
    /// </summary>
    [JsonPropertyName("startTime")]
    public string? StartTime { get; set; }

    /// <summary>
    /// UtcOffset: The UTC offset in format +/-HH:mm. For example, &apos;+05:30&apos; for IST and &apos;-07:00&apos; for PST. If not specified, the
    /// default is &apos;+00:00&apos;.
    /// </summary>
    [JsonPropertyName("utcOffset")]
    public string? UtcOffset { get; set; }
}

/// <summary>A time range. For example, between 2021-05-25T13:00:00Z and 2021-05-25T14:00:00Z.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationStatusNotAllowedTime
{
    /// <summary>End: The end of a time span</summary>
    [JsonPropertyName("end")]
    public string? End { get; set; }

    /// <summary>Start: The start of a time span</summary>
    [JsonPropertyName("start")]
    public string? Start { get; set; }
}

/// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationStatusSystemData
{
    /// <summary>CreatedAt: The timestamp of resource creation (UTC).</summary>
    [JsonPropertyName("createdAt")]
    public string? CreatedAt { get; set; }

    /// <summary>CreatedBy: The identity that created the resource.</summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>CreatedByType: The type of identity that created the resource.</summary>
    [JsonPropertyName("createdByType")]
    public string? CreatedByType { get; set; }

    /// <summary>LastModifiedAt: The timestamp of resource last modification (UTC)</summary>
    [JsonPropertyName("lastModifiedAt")]
    public string? LastModifiedAt { get; set; }

    /// <summary>LastModifiedBy: The identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedBy")]
    public string? LastModifiedBy { get; set; }

    /// <summary>LastModifiedByType: The type of identity that last modified the resource.</summary>
    [JsonPropertyName("lastModifiedByType")]
    public string? LastModifiedByType { get; set; }
}

/// <summary>Time in a week.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationStatusTimeInWeek
{
    /// <summary>Day: The day of the week.</summary>
    [JsonPropertyName("day")]
    public string? Day { get; set; }

    /// <summary>
    /// HourSlots: A list of hours in the day used to identify a time range. Each integer hour represents a time range beginning
    /// at 0m after the hour ending at the next hour (non-inclusive). 0 corresponds to 00:00 UTC, 23 corresponds to 23:00 UTC.
    /// Specifying [0, 1] means the 00:00 - 02:00 UTC time range.
    /// </summary>
    [JsonPropertyName("hourSlots")]
    public IList<int>? HourSlots { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V20251002previewMaintenanceConfigurationStatus
{
    /// <summary>Conditions: The observed state of the resource</summary>
    [JsonPropertyName("conditions")]
    public IList<V20251002previewMaintenanceConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// Id: Fully qualified resource ID for the resource. E.g.
    /// &quot;/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}&quot;
    /// </summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>MaintenanceWindow: Maintenance window for the maintenance configuration.</summary>
    [JsonPropertyName("maintenanceWindow")]
    public V20251002previewMaintenanceConfigurationStatusMaintenanceWindow? MaintenanceWindow { get; set; }

    /// <summary>Name: The name of the resource</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>NotAllowedTime: Time slots on which upgrade is not allowed.</summary>
    [JsonPropertyName("notAllowedTime")]
    public IList<V20251002previewMaintenanceConfigurationStatusNotAllowedTime>? NotAllowedTime { get; set; }

    /// <summary>SystemData: Azure Resource Manager metadata containing createdBy and modifiedBy information.</summary>
    [JsonPropertyName("systemData")]
    public V20251002previewMaintenanceConfigurationStatusSystemData? SystemData { get; set; }

    /// <summary>
    /// TimeInWeek: Time slots during the week when planned maintenance is allowed to proceed. If two array entries specify the
    /// same day of the week, the applied configuration is the union of times in both entries.
    /// </summary>
    [JsonPropertyName("timeInWeek")]
    public IList<V20251002previewMaintenanceConfigurationStatusTimeInWeek>? TimeInWeek { get; set; }

    /// <summary>Type: The type of the resource. E.g. &quot;Microsoft.Compute/virtualMachines&quot; or &quot;Microsoft.Storage/storageAccounts&quot;</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Generator information:
/// - Generated from: /containerservice/resource-manager/Microsoft.ContainerService/aks/preview/2025-10-02-preview/managedClusters.json
/// - ARM URI: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ContainerService/managedClusters/{resourceName}/maintenanceConfigurations/{configName}
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V20251002previewMaintenanceConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V20251002previewMaintenanceConfigurationSpec?>, IStatus<V20251002previewMaintenanceConfigurationStatus?>
{
    public const string KubeApiVersion = "v20251002preview";
    public const string KubeKind = "MaintenanceConfiguration";
    public const string KubeGroup = "containerservice.azure.com";
    public const string KubePluralName = "maintenanceconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "containerservice.azure.com/v20251002preview";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MaintenanceConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    [JsonPropertyName("spec")]
    public V20251002previewMaintenanceConfigurationSpec? Spec { get; set; }

    [JsonPropertyName("status")]
    public V20251002previewMaintenanceConfigurationStatus? Status { get; set; }
}