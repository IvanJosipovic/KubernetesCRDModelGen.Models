#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sql.databricks.m.crossplane.io;
/// <summary>AlertV2 is the Schema for the AlertV2s API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AlertV2List : IKubernetesObject<V1ListMeta>, IItems<V1beta1AlertV2>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AlertV2List";
    public const string KubeGroup = "sql.databricks.m.crossplane.io";
    public const string KubePluralName = "alertv2s";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AlertV2List";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1AlertV2 objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1AlertV2> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecForProviderEvaluationNotificationSubscriptions
{
    /// <summary>(string, optional)</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("userEmail")]
    public string? UserEmail { get; set; }
}

/// <summary>User or Notification Destination to notify when alert is triggered</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecForProviderEvaluationNotification
{
    /// <summary>Whether to notify alert subscribers when alert returns back to normal</summary>
    [JsonPropertyName("notifyOnOk")]
    public bool? NotifyOnOk { get; set; }

    /// <summary>
    /// Number of seconds an alert waits after being triggered before it is allowed to send another notification.
    /// If set to 0 or omitted, the alert will not send any further notifications after the first trigger
    /// Setting this value to 1 allows the alert to send a notification on every evaluation where the condition is met, effectively making it always retrigger for notification purposes
    /// </summary>
    [JsonPropertyName("retriggerSeconds")]
    public double? RetriggerSeconds { get; set; }

    /// <summary>(list of AlertV2Subscription, optional)</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1beta1AlertV2SpecForProviderEvaluationNotificationSubscriptions>? Subscriptions { get; set; }
}

/// <summary>Source column from result to use to evaluate alert</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecForProviderEvaluationSource
{
    /// <summary>If not set, the behavior is equivalent to using First row in the UI. Possible values are: AVG, COUNT, COUNT_DISTINCT, MAX, MEDIAN, MIN, STDDEV, SUM</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("display")]
    public string? Display { get; set; }

    /// <summary>(string, required)</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>(AlertV2OperandColumn, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecForProviderEvaluationThresholdColumn
{
    /// <summary>If not set, the behavior is equivalent to using First row in the UI. Possible values are: AVG, COUNT, COUNT_DISTINCT, MAX, MEDIAN, MIN, STDDEV, SUM</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("display")]
    public string? Display { get; set; }

    /// <summary>(string, required)</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>(AlertV2OperandValue, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecForProviderEvaluationThresholdValue
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>(number, optional)</summary>
    [JsonPropertyName("doubleValue")]
    public double? DoubleValue { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>Threshold to user for alert evaluation, can be a column or a value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecForProviderEvaluationThreshold
{
    /// <summary>(AlertV2OperandColumn, optional)</summary>
    [JsonPropertyName("column")]
    public V1beta1AlertV2SpecForProviderEvaluationThresholdColumn? Column { get; set; }

    /// <summary>(AlertV2OperandValue, optional)</summary>
    [JsonPropertyName("value")]
    public V1beta1AlertV2SpecForProviderEvaluationThresholdValue? Value { get; set; }
}

/// <summary>(AlertV2Evaluation, required)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecForProviderEvaluation
{
    /// <summary>Operator used for comparison in alert evaluation. Possible values are: EQUAL, GREATER_THAN, GREATER_THAN_OR_EQUAL, IS_NOT_NULL, IS_NULL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>Alert state if result is empty. Please avoid setting this field to be UNKNOWN because UNKNOWN state is planned to be deprecated. Possible values are: ERROR, OK, TRIGGERED, UNKNOWN</summary>
    [JsonPropertyName("emptyResultState")]
    public string? EmptyResultState { get; set; }

    /// <summary>User or Notification Destination to notify when alert is triggered</summary>
    [JsonPropertyName("notification")]
    public V1beta1AlertV2SpecForProviderEvaluationNotification? Notification { get; set; }

    /// <summary>Source column from result to use to evaluate alert</summary>
    [JsonPropertyName("source")]
    public V1beta1AlertV2SpecForProviderEvaluationSource? Source { get; set; }

    /// <summary>Threshold to user for alert evaluation, can be a column or a value</summary>
    [JsonPropertyName("threshold")]
    public V1beta1AlertV2SpecForProviderEvaluationThreshold? Threshold { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecForProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>
/// Specifies the identity that will be used to run the alert.
/// This field allows you to configure alerts to run as a specific user or service principal.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecForProviderRunAs
{
    /// <summary>
    /// to the application ID. Requires the servicePrincipal/user role.
    /// If not specified, the alert will run as the request user
    /// </summary>
    [JsonPropertyName("servicePrincipalName")]
    public string? ServicePrincipalName { get; set; }

    /// <summary>to the email of an active workspace user. Users can only set this to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>(CronSchedule, required)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecForProviderSchedule
{
    /// <summary>Indicate whether this schedule is paused or not. Possible values are: PAUSED, UNPAUSED</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }

    /// <summary>
    /// A cron expression using quartz syntax that specifies the schedule for this pipeline.
    /// Should use the quartz format described here: http://www.quartz-scheduler.org/documentation/quartz-2.1.7/tutorials/tutorial-lesson-06.html
    /// </summary>
    [JsonPropertyName("quartzCronSchedule")]
    public string? QuartzCronSchedule { get; set; }

    /// <summary>
    /// A Java timezone id. The schedule will be resolved using this timezone.
    /// This will be combined with the quartz_cron_schedule to determine the schedule.
    /// See https://docs.databricks.com/sql/language-manual/sql-ref-syntax-aux-conf-mgmt-set-timezone.html for details
    /// </summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecForProvider
{
    /// <summary>Custom description for the alert. support mustache template</summary>
    [JsonPropertyName("customDescription")]
    public string? CustomDescription { get; set; }

    /// <summary>Custom summary for the alert. support mustache template</summary>
    [JsonPropertyName("customSummary")]
    public string? CustomSummary { get; set; }

    /// <summary>The display name of the alert</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>(AlertV2Evaluation, required)</summary>
    [JsonPropertyName("evaluation")]
    public V1beta1AlertV2SpecForProviderEvaluation? Evaluation { get; set; }

    /// <summary>The workspace path of the folder containing the alert. Can only be set on create, and cannot be updated</summary>
    [JsonPropertyName("parentPath")]
    public string? ParentPath { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1AlertV2SpecForProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Whether to permanently delete the alert. If not set, the alert will only be soft deleted</summary>
    [JsonPropertyName("purgeOnDelete")]
    public bool? PurgeOnDelete { get; set; }

    /// <summary>Text of the query to be run</summary>
    [JsonPropertyName("queryText")]
    public string? QueryText { get; set; }

    /// <summary>
    /// Specifies the identity that will be used to run the alert.
    /// This field allows you to configure alerts to run as a specific user or service principal.
    /// </summary>
    [JsonPropertyName("runAs")]
    public V1beta1AlertV2SpecForProviderRunAs? RunAs { get; set; }

    /// <summary>
    /// The run as username or application ID of service principal.
    /// On Create and Update, this field can be set to application ID of an active service principal. Setting this field requires the servicePrincipal/user role.
    /// Deprecated: Use run_as field instead. This field will be removed in a future release
    /// </summary>
    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }

    /// <summary>(CronSchedule, required)</summary>
    [JsonPropertyName("schedule")]
    public V1beta1AlertV2SpecForProviderSchedule? Schedule { get; set; }

    /// <summary>ID of the SQL warehouse attached to the alert</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecInitProviderEvaluationNotificationSubscriptions
{
    /// <summary>(string, optional)</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("userEmail")]
    public string? UserEmail { get; set; }
}

/// <summary>User or Notification Destination to notify when alert is triggered</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecInitProviderEvaluationNotification
{
    /// <summary>Whether to notify alert subscribers when alert returns back to normal</summary>
    [JsonPropertyName("notifyOnOk")]
    public bool? NotifyOnOk { get; set; }

    /// <summary>
    /// Number of seconds an alert waits after being triggered before it is allowed to send another notification.
    /// If set to 0 or omitted, the alert will not send any further notifications after the first trigger
    /// Setting this value to 1 allows the alert to send a notification on every evaluation where the condition is met, effectively making it always retrigger for notification purposes
    /// </summary>
    [JsonPropertyName("retriggerSeconds")]
    public double? RetriggerSeconds { get; set; }

    /// <summary>(list of AlertV2Subscription, optional)</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1beta1AlertV2SpecInitProviderEvaluationNotificationSubscriptions>? Subscriptions { get; set; }
}

/// <summary>Source column from result to use to evaluate alert</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecInitProviderEvaluationSource
{
    /// <summary>If not set, the behavior is equivalent to using First row in the UI. Possible values are: AVG, COUNT, COUNT_DISTINCT, MAX, MEDIAN, MIN, STDDEV, SUM</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("display")]
    public string? Display { get; set; }

    /// <summary>(string, required)</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>(AlertV2OperandColumn, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecInitProviderEvaluationThresholdColumn
{
    /// <summary>If not set, the behavior is equivalent to using First row in the UI. Possible values are: AVG, COUNT, COUNT_DISTINCT, MAX, MEDIAN, MIN, STDDEV, SUM</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("display")]
    public string? Display { get; set; }

    /// <summary>(string, required)</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>(AlertV2OperandValue, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecInitProviderEvaluationThresholdValue
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>(number, optional)</summary>
    [JsonPropertyName("doubleValue")]
    public double? DoubleValue { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>Threshold to user for alert evaluation, can be a column or a value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecInitProviderEvaluationThreshold
{
    /// <summary>(AlertV2OperandColumn, optional)</summary>
    [JsonPropertyName("column")]
    public V1beta1AlertV2SpecInitProviderEvaluationThresholdColumn? Column { get; set; }

    /// <summary>(AlertV2OperandValue, optional)</summary>
    [JsonPropertyName("value")]
    public V1beta1AlertV2SpecInitProviderEvaluationThresholdValue? Value { get; set; }
}

/// <summary>(AlertV2Evaluation, required)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecInitProviderEvaluation
{
    /// <summary>Operator used for comparison in alert evaluation. Possible values are: EQUAL, GREATER_THAN, GREATER_THAN_OR_EQUAL, IS_NOT_NULL, IS_NULL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>Alert state if result is empty. Please avoid setting this field to be UNKNOWN because UNKNOWN state is planned to be deprecated. Possible values are: ERROR, OK, TRIGGERED, UNKNOWN</summary>
    [JsonPropertyName("emptyResultState")]
    public string? EmptyResultState { get; set; }

    /// <summary>User or Notification Destination to notify when alert is triggered</summary>
    [JsonPropertyName("notification")]
    public V1beta1AlertV2SpecInitProviderEvaluationNotification? Notification { get; set; }

    /// <summary>Source column from result to use to evaluate alert</summary>
    [JsonPropertyName("source")]
    public V1beta1AlertV2SpecInitProviderEvaluationSource? Source { get; set; }

    /// <summary>Threshold to user for alert evaluation, can be a column or a value</summary>
    [JsonPropertyName("threshold")]
    public V1beta1AlertV2SpecInitProviderEvaluationThreshold? Threshold { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecInitProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>
/// Specifies the identity that will be used to run the alert.
/// This field allows you to configure alerts to run as a specific user or service principal.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecInitProviderRunAs
{
    /// <summary>
    /// to the application ID. Requires the servicePrincipal/user role.
    /// If not specified, the alert will run as the request user
    /// </summary>
    [JsonPropertyName("servicePrincipalName")]
    public string? ServicePrincipalName { get; set; }

    /// <summary>to the email of an active workspace user. Users can only set this to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>(CronSchedule, required)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecInitProviderSchedule
{
    /// <summary>Indicate whether this schedule is paused or not. Possible values are: PAUSED, UNPAUSED</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }

    /// <summary>
    /// A cron expression using quartz syntax that specifies the schedule for this pipeline.
    /// Should use the quartz format described here: http://www.quartz-scheduler.org/documentation/quartz-2.1.7/tutorials/tutorial-lesson-06.html
    /// </summary>
    [JsonPropertyName("quartzCronSchedule")]
    public string? QuartzCronSchedule { get; set; }

    /// <summary>
    /// A Java timezone id. The schedule will be resolved using this timezone.
    /// This will be combined with the quartz_cron_schedule to determine the schedule.
    /// See https://docs.databricks.com/sql/language-manual/sql-ref-syntax-aux-conf-mgmt-set-timezone.html for details
    /// </summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecInitProvider
{
    /// <summary>Custom description for the alert. support mustache template</summary>
    [JsonPropertyName("customDescription")]
    public string? CustomDescription { get; set; }

    /// <summary>Custom summary for the alert. support mustache template</summary>
    [JsonPropertyName("customSummary")]
    public string? CustomSummary { get; set; }

    /// <summary>The display name of the alert</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>(AlertV2Evaluation, required)</summary>
    [JsonPropertyName("evaluation")]
    public V1beta1AlertV2SpecInitProviderEvaluation? Evaluation { get; set; }

    /// <summary>The workspace path of the folder containing the alert. Can only be set on create, and cannot be updated</summary>
    [JsonPropertyName("parentPath")]
    public string? ParentPath { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1AlertV2SpecInitProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Whether to permanently delete the alert. If not set, the alert will only be soft deleted</summary>
    [JsonPropertyName("purgeOnDelete")]
    public bool? PurgeOnDelete { get; set; }

    /// <summary>Text of the query to be run</summary>
    [JsonPropertyName("queryText")]
    public string? QueryText { get; set; }

    /// <summary>
    /// Specifies the identity that will be used to run the alert.
    /// This field allows you to configure alerts to run as a specific user or service principal.
    /// </summary>
    [JsonPropertyName("runAs")]
    public V1beta1AlertV2SpecInitProviderRunAs? RunAs { get; set; }

    /// <summary>
    /// The run as username or application ID of service principal.
    /// On Create and Update, this field can be set to application ID of an active service principal. Setting this field requires the servicePrincipal/user role.
    /// Deprecated: Use run_as field instead. This field will be removed in a future release
    /// </summary>
    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }

    /// <summary>(CronSchedule, required)</summary>
    [JsonPropertyName("schedule")]
    public V1beta1AlertV2SpecInitProviderSchedule? Schedule { get; set; }

    /// <summary>ID of the SQL warehouse attached to the alert</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1AlertV2SpecManagementPoliciesEnum>))]
public enum V1beta1AlertV2SpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2SpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>AlertV2Spec defines the desired state of AlertV2</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2Spec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1AlertV2SpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta1AlertV2SpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1AlertV2SpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1AlertV2SpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1AlertV2SpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// The actual identity that will be used to execute the alert.
/// This is an output-only field that shows the resolved run-as identity after applying
/// permissions and defaults
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2StatusAtProviderEffectiveRunAs
{
    /// <summary>
    /// to the application ID. Requires the servicePrincipal/user role.
    /// If not specified, the alert will run as the request user
    /// </summary>
    [JsonPropertyName("servicePrincipalName")]
    public string? ServicePrincipalName { get; set; }

    /// <summary>to the email of an active workspace user. Users can only set this to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2StatusAtProviderEvaluationNotificationSubscriptions
{
    /// <summary>(string, optional)</summary>
    [JsonPropertyName("destinationId")]
    public string? DestinationId { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("userEmail")]
    public string? UserEmail { get; set; }
}

/// <summary>User or Notification Destination to notify when alert is triggered</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2StatusAtProviderEvaluationNotification
{
    /// <summary>Whether to notify alert subscribers when alert returns back to normal</summary>
    [JsonPropertyName("effectiveNotifyOnOk")]
    public bool? EffectiveNotifyOnOk { get; set; }

    /// <summary>
    /// Number of seconds an alert waits after being triggered before it is allowed to send another notification.
    /// If set to 0 or omitted, the alert will not send any further notifications after the first trigger
    /// Setting this value to 1 allows the alert to send a notification on every evaluation where the condition is met, effectively making it always retrigger for notification purposes
    /// </summary>
    [JsonPropertyName("effectiveRetriggerSeconds")]
    public double? EffectiveRetriggerSeconds { get; set; }

    /// <summary>Whether to notify alert subscribers when alert returns back to normal</summary>
    [JsonPropertyName("notifyOnOk")]
    public bool? NotifyOnOk { get; set; }

    /// <summary>
    /// Number of seconds an alert waits after being triggered before it is allowed to send another notification.
    /// If set to 0 or omitted, the alert will not send any further notifications after the first trigger
    /// Setting this value to 1 allows the alert to send a notification on every evaluation where the condition is met, effectively making it always retrigger for notification purposes
    /// </summary>
    [JsonPropertyName("retriggerSeconds")]
    public double? RetriggerSeconds { get; set; }

    /// <summary>(list of AlertV2Subscription, optional)</summary>
    [JsonPropertyName("subscriptions")]
    public IList<V1beta1AlertV2StatusAtProviderEvaluationNotificationSubscriptions>? Subscriptions { get; set; }
}

/// <summary>Source column from result to use to evaluate alert</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2StatusAtProviderEvaluationSource
{
    /// <summary>If not set, the behavior is equivalent to using First row in the UI. Possible values are: AVG, COUNT, COUNT_DISTINCT, MAX, MEDIAN, MIN, STDDEV, SUM</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("display")]
    public string? Display { get; set; }

    /// <summary>(string, required)</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>(AlertV2OperandColumn, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2StatusAtProviderEvaluationThresholdColumn
{
    /// <summary>If not set, the behavior is equivalent to using First row in the UI. Possible values are: AVG, COUNT, COUNT_DISTINCT, MAX, MEDIAN, MIN, STDDEV, SUM</summary>
    [JsonPropertyName("aggregation")]
    public string? Aggregation { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("display")]
    public string? Display { get; set; }

    /// <summary>(string, required)</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>(AlertV2OperandValue, optional)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2StatusAtProviderEvaluationThresholdValue
{
    /// <summary>(boolean, optional)</summary>
    [JsonPropertyName("boolValue")]
    public bool? BoolValue { get; set; }

    /// <summary>(number, optional)</summary>
    [JsonPropertyName("doubleValue")]
    public double? DoubleValue { get; set; }

    /// <summary>(string, optional)</summary>
    [JsonPropertyName("stringValue")]
    public string? StringValue { get; set; }
}

/// <summary>Threshold to user for alert evaluation, can be a column or a value</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2StatusAtProviderEvaluationThreshold
{
    /// <summary>(AlertV2OperandColumn, optional)</summary>
    [JsonPropertyName("column")]
    public V1beta1AlertV2StatusAtProviderEvaluationThresholdColumn? Column { get; set; }

    /// <summary>(AlertV2OperandValue, optional)</summary>
    [JsonPropertyName("value")]
    public V1beta1AlertV2StatusAtProviderEvaluationThresholdValue? Value { get; set; }
}

/// <summary>(AlertV2Evaluation, required)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2StatusAtProviderEvaluation
{
    /// <summary>Operator used for comparison in alert evaluation. Possible values are: EQUAL, GREATER_THAN, GREATER_THAN_OR_EQUAL, IS_NOT_NULL, IS_NULL, LESS_THAN, LESS_THAN_OR_EQUAL, NOT_EQUAL</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>Alert state if result is empty. Please avoid setting this field to be UNKNOWN because UNKNOWN state is planned to be deprecated. Possible values are: ERROR, OK, TRIGGERED, UNKNOWN</summary>
    [JsonPropertyName("emptyResultState")]
    public string? EmptyResultState { get; set; }

    /// <summary>Timestamp of the last evaluation</summary>
    [JsonPropertyName("lastEvaluatedAt")]
    public string? LastEvaluatedAt { get; set; }

    /// <summary>User or Notification Destination to notify when alert is triggered</summary>
    [JsonPropertyName("notification")]
    public V1beta1AlertV2StatusAtProviderEvaluationNotification? Notification { get; set; }

    /// <summary>Source column from result to use to evaluate alert</summary>
    [JsonPropertyName("source")]
    public V1beta1AlertV2StatusAtProviderEvaluationSource? Source { get; set; }

    /// <summary>Latest state of alert evaluation. Possible values are: ERROR, OK, TRIGGERED, UNKNOWN</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Threshold to user for alert evaluation, can be a column or a value</summary>
    [JsonPropertyName("threshold")]
    public V1beta1AlertV2StatusAtProviderEvaluationThreshold? Threshold { get; set; }
}

/// <summary>Configure the provider for management through account provider.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2StatusAtProviderProviderConfig
{
    /// <summary>Workspace ID which the resource belongs to. This workspace must be part of the account which the provider is configured with.</summary>
    [JsonPropertyName("workspaceId")]
    public string? WorkspaceId { get; set; }
}

/// <summary>
/// Specifies the identity that will be used to run the alert.
/// This field allows you to configure alerts to run as a specific user or service principal.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2StatusAtProviderRunAs
{
    /// <summary>
    /// to the application ID. Requires the servicePrincipal/user role.
    /// If not specified, the alert will run as the request user
    /// </summary>
    [JsonPropertyName("servicePrincipalName")]
    public string? ServicePrincipalName { get; set; }

    /// <summary>to the email of an active workspace user. Users can only set this to their own email.</summary>
    [JsonPropertyName("userName")]
    public string? UserName { get; set; }
}

/// <summary>(CronSchedule, required)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2StatusAtProviderSchedule
{
    /// <summary>Indicate whether this schedule is paused or not. Possible values are: PAUSED, UNPAUSED</summary>
    [JsonPropertyName("pauseStatus")]
    public string? PauseStatus { get; set; }

    /// <summary>
    /// A cron expression using quartz syntax that specifies the schedule for this pipeline.
    /// Should use the quartz format described here: http://www.quartz-scheduler.org/documentation/quartz-2.1.7/tutorials/tutorial-lesson-06.html
    /// </summary>
    [JsonPropertyName("quartzCronSchedule")]
    public string? QuartzCronSchedule { get; set; }

    /// <summary>
    /// A Java timezone id. The schedule will be resolved using this timezone.
    /// This will be combined with the quartz_cron_schedule to determine the schedule.
    /// See https://docs.databricks.com/sql/language-manual/sql-ref-syntax-aux-conf-mgmt-set-timezone.html for details
    /// </summary>
    [JsonPropertyName("timezoneId")]
    public string? TimezoneId { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2StatusAtProvider
{
    /// <summary>The timestamp indicating when the alert was created</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Custom description for the alert. support mustache template</summary>
    [JsonPropertyName("customDescription")]
    public string? CustomDescription { get; set; }

    /// <summary>Custom summary for the alert. support mustache template</summary>
    [JsonPropertyName("customSummary")]
    public string? CustomSummary { get; set; }

    /// <summary>The display name of the alert</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// The actual identity that will be used to execute the alert.
    /// This is an output-only field that shows the resolved run-as identity after applying
    /// permissions and defaults
    /// </summary>
    [JsonPropertyName("effectiveRunAs")]
    public V1beta1AlertV2StatusAtProviderEffectiveRunAs? EffectiveRunAs { get; set; }

    /// <summary>(AlertV2Evaluation, required)</summary>
    [JsonPropertyName("evaluation")]
    public V1beta1AlertV2StatusAtProviderEvaluation? Evaluation { get; set; }

    /// <summary>UUID identifying the alert</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Indicates whether the query is trashed. Possible values are: ACTIVE, DELETED</summary>
    [JsonPropertyName("lifecycleState")]
    public string? LifecycleState { get; set; }

    /// <summary>The owner&apos;s username. This field is set to &quot;Unavailable&quot; if the user has been deleted</summary>
    [JsonPropertyName("ownerUserName")]
    public string? OwnerUserName { get; set; }

    /// <summary>The workspace path of the folder containing the alert. Can only be set on create, and cannot be updated</summary>
    [JsonPropertyName("parentPath")]
    public string? ParentPath { get; set; }

    /// <summary>Configure the provider for management through account provider.</summary>
    [JsonPropertyName("providerConfig")]
    public V1beta1AlertV2StatusAtProviderProviderConfig? ProviderConfig { get; set; }

    /// <summary>Whether to permanently delete the alert. If not set, the alert will only be soft deleted</summary>
    [JsonPropertyName("purgeOnDelete")]
    public bool? PurgeOnDelete { get; set; }

    /// <summary>Text of the query to be run</summary>
    [JsonPropertyName("queryText")]
    public string? QueryText { get; set; }

    /// <summary>
    /// Specifies the identity that will be used to run the alert.
    /// This field allows you to configure alerts to run as a specific user or service principal.
    /// </summary>
    [JsonPropertyName("runAs")]
    public V1beta1AlertV2StatusAtProviderRunAs? RunAs { get; set; }

    /// <summary>
    /// The run as username or application ID of service principal.
    /// On Create and Update, this field can be set to application ID of an active service principal. Setting this field requires the servicePrincipal/user role.
    /// Deprecated: Use run_as field instead. This field will be removed in a future release
    /// </summary>
    [JsonPropertyName("runAsUserName")]
    public string? RunAsUserName { get; set; }

    /// <summary>(CronSchedule, required)</summary>
    [JsonPropertyName("schedule")]
    public V1beta1AlertV2StatusAtProviderSchedule? Schedule { get; set; }

    /// <summary>The timestamp indicating when the alert was updated</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }

    /// <summary>ID of the SQL warehouse attached to the alert</summary>
    [JsonPropertyName("warehouseId")]
    public string? WarehouseId { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2StatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>AlertV2Status defines the observed state of AlertV2.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1AlertV2Status
{
    [JsonPropertyName("atProvider")]
    public V1beta1AlertV2StatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1AlertV2StatusConditions>? Conditions { get; set; }

    /// <summary>
    /// LastHandledReconcileAt holds the value of the most recent
    /// reconcile-requested-at annotation token that the controller has
    /// processed. Users can compare this to the annotation to determine
    /// whether a reconcile request has been handled.
    /// </summary>
    [JsonPropertyName("lastHandledReconcileAt")]
    public string? LastHandledReconcileAt { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AlertV2 is the Schema for the AlertV2s API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1AlertV2 : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1AlertV2Spec>, IStatus<V1beta1AlertV2Status?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "AlertV2";
    public const string KubeGroup = "sql.databricks.m.crossplane.io";
    public const string KubePluralName = "alertv2s";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sql.databricks.m.crossplane.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AlertV2";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AlertV2Spec defines the desired state of AlertV2</summary>
    [JsonPropertyName("spec")]
    public required V1beta1AlertV2Spec Spec { get; set; }

    /// <summary>AlertV2Status defines the observed state of AlertV2.</summary>
    [JsonPropertyName("status")]
    public V1beta1AlertV2Status? Status { get; set; }
}