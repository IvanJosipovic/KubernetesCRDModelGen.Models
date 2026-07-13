#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.monitoring.gcp.upbound.io;
/// <summary>AlertPolicy is the Schema for the AlertPolicys API. A description of the conditions under which some aspect of your system is considered to be &quot;unhealthy&quot; and the ways to notify people or services about this state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AlertPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta2AlertPolicy>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AlertPolicyList";
    public const string KubeGroup = "monitoring.gcp.upbound.io";
    public const string KubePluralName = "alertpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "monitoring.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AlertPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2AlertPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2AlertPolicy> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AlertPolicySpecDeletionPolicyEnum>))]
public enum V1beta2AlertPolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderAlertStrategyNotificationChannelStrategy
{
    /// <summary>
    /// The notification channels that these settings apply to. Each of these
    /// correspond to the name field in one of the NotificationChannel objects
    /// referenced in the notification_channels field of this AlertPolicy. The format is
    /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
    /// </summary>
    [JsonPropertyName("notificationChannelNames")]
    public IList<string>? NotificationChannelNames { get; set; }

    /// <summary>The frequency at which to send reminder notifications for open incidents.</summary>
    [JsonPropertyName("renotifyInterval")]
    public string? RenotifyInterval { get; set; }
}

/// <summary>
/// Required for alert policies with a LogMatch condition.
/// This limit is not implemented for alert policies that are not log-based.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderAlertStrategyNotificationRateLimit
{
    /// <summary>
    /// Not more than one notification per period.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example &quot;60.5s&quot;.
    /// </summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
}

/// <summary>
/// Control over how this alert policy&apos;s notification channels are notified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderAlertStrategy
{
    /// <summary>If an alert policy that was active has no data for this long, any open incidents will close.</summary>
    [JsonPropertyName("autoClose")]
    public string? AutoClose { get; set; }

    /// <summary>
    /// Control over how the notification channels in notification_channels
    /// are notified when this alert fires, on a per-channel basis.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("notificationChannelStrategy")]
    public IList<V1beta2AlertPolicySpecForProviderAlertStrategyNotificationChannelStrategy>? NotificationChannelStrategy { get; set; }

    /// <summary>
    /// Control when notifications will be sent out.
    /// Each value may be one of: NOTIFICATION_PROMPT_UNSPECIFIED, OPENED, CLOSED.
    /// </summary>
    [JsonPropertyName("notificationPrompts")]
    public IList<string>? NotificationPrompts { get; set; }

    /// <summary>
    /// Required for alert policies with a LogMatch condition.
    /// This limit is not implemented for alert policies that are not log-based.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("notificationRateLimit")]
    public V1beta2AlertPolicySpecForProviderAlertStrategyNotificationRateLimit? NotificationRateLimit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionAbsentAggregations
{
    /// <summary>
    /// The alignment period for per-time
    /// series alignment. If present,
    /// alignmentPeriod must be at least
    /// 60 seconds. After per-time series
    /// alignment, each time series will
    /// contain data points only on the
    /// period boundaries. If
    /// perSeriesAligner is not specified
    /// or equals ALIGN_NONE, then this
    /// field is ignored. If
    /// perSeriesAligner is specified and
    /// does not equal ALIGN_NONE, then
    /// this field must be defined;
    /// otherwise an error is returned.
    /// </summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>
    /// The approach to be used to combine
    /// time series. Not all reducer
    /// functions may be applied to all
    /// time series, depending on the
    /// metric type and the value type of
    /// the original time series.
    /// Reduction may change the metric
    /// type of value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.
    /// </summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>
    /// The set of fields to preserve when
    /// crossSeriesReducer is specified.
    /// The groupByFields determine how
    /// the time series are partitioned
    /// into subsets prior to applying the
    /// aggregation function. Each subset
    /// contains time series that have the
    /// same value for each of the
    /// grouping fields. Each individual
    /// time series is a member of exactly
    /// one subset. The crossSeriesReducer
    /// is applied to each subset of time
    /// series. It is not possible to
    /// reduce across different resource
    /// types, so this field implicitly
    /// contains resource.type. Fields not
    /// specified in groupByFields are
    /// aggregated away. If groupByFields
    /// is not specified and all the time
    /// series have the same resource
    /// type, then the time series are
    /// aggregated into a single output
    /// time series. If crossSeriesReducer
    /// is not defined, this field is
    /// ignored.
    /// </summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>
    /// The approach to be used to align
    /// individual time series. Not all
    /// alignment functions may be applied
    /// to all time series, depending on
    /// the metric type and value type of
    /// the original time series.
    /// Alignment may change the metric
    /// type or the value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.
    /// </summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary>
/// The number/percent of time series for which
/// the comparison must hold in order for the
/// condition to trigger. If unspecified, then
/// the condition will trigger if the comparison
/// is true for any of the time series that have
/// been identified by filter and aggregations,
/// or by the ratio, if denominator_filter and
/// denominator_aggregations are specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionAbsentTrigger
{
    /// <summary>
    /// The absolute number of time series
    /// that must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>
    /// The percentage of time series that
    /// must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>
/// A condition that checks that a time series
/// continues to receive new data points.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionAbsent
{
    /// <summary>
    /// Specifies the alignment of data points in
    /// individual time series as well as how to
    /// combine the retrieved time series together
    /// (such as when aggregating multiple streams
    /// on each resource to a single stream for each
    /// resource or when aggregating streams across
    /// all members of a group of resources).
    /// Multiple aggregations are applied in the
    /// order specified.This field is similar to the
    /// one in the MetricService.ListTimeSeries
    /// request. It is advisable to use the
    /// ListTimeSeries method when debugging this
    /// field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aggregations")]
    public IList<V1beta2AlertPolicySpecForProviderConditionsConditionAbsentAggregations>? Aggregations { get; set; }

    /// <summary>
    /// The amount of time that a time series must
    /// violate the threshold to be considered
    /// failing. Currently, only values that are a
    /// multiple of a minute--e.g., 0, 60, 120, or
    /// 300 seconds--are supported. If an invalid
    /// value is given, an error will be returned.
    /// When choosing a duration, it is useful to
    /// keep in mind the frequency of the underlying
    /// time series data (which may also be affected
    /// by any alignments specified in the
    /// aggregations field); a good duration is long
    /// enough so that a single outlier does not
    /// generate spurious alerts, but short enough
    /// that unhealthy states are detected and
    /// alerted on quickly.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// A filter that identifies which time series
    /// should be compared with the threshold.The
    /// filter is similar to the one that is
    /// specified in the
    /// MetricService.ListTimeSeries request (that
    /// call is useful to verify the time series
    /// that will be retrieved / processed) and must
    /// specify the metric type and optionally may
    /// contain restrictions on resource type,
    /// resource labels, and metric labels. This
    /// field may not exceed 2048 Unicode characters
    /// in length.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>
    /// The number/percent of time series for which
    /// the comparison must hold in order for the
    /// condition to trigger. If unspecified, then
    /// the condition will trigger if the comparison
    /// is true for any of the time series that have
    /// been identified by filter and aggregations,
    /// or by the ratio, if denominator_filter and
    /// denominator_aggregations are specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trigger")]
    public V1beta2AlertPolicySpecForProviderConditionsConditionAbsentTrigger? Trigger { get; set; }
}

/// <summary>
/// A condition that checks for log messages matching given constraints.
/// If set, no other conditions can be present.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionMatchedLog
{
    /// <summary>
    /// A filter that identifies which time series
    /// should be compared with the threshold.The
    /// filter is similar to the one that is
    /// specified in the
    /// MetricService.ListTimeSeries request (that
    /// call is useful to verify the time series
    /// that will be retrieved / processed) and must
    /// specify the metric type and optionally may
    /// contain restrictions on resource type,
    /// resource labels, and metric labels. This
    /// field may not exceed 2048 Unicode characters
    /// in length.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>
    /// A map from a label key to an extractor expression, which is used to
    /// extract the value for this label key. Each entry in this map is
    /// a specification for how data should be extracted from log entries that
    /// match filter. Each combination of extracted values is treated as
    /// a separate rule for the purposes of triggering notifications.
    /// Label keys and corresponding values can be used in notifications
    /// generated by this condition.
    /// </summary>
    [JsonPropertyName("labelExtractors")]
    public IDictionary<string, string>? LabelExtractors { get; set; }
}

/// <summary>
/// The number/percent of time series for which
/// the comparison must hold in order for the
/// condition to trigger. If unspecified, then
/// the condition will trigger if the comparison
/// is true for any of the time series that have
/// been identified by filter and aggregations,
/// or by the ratio, if denominator_filter and
/// denominator_aggregations are specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionMonitoringQueryLanguageTrigger
{
    /// <summary>
    /// The absolute number of time series
    /// that must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>
    /// The percentage of time series that
    /// must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>
/// A Monitoring Query Language query that outputs a boolean stream
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionMonitoringQueryLanguage
{
    /// <summary>
    /// The amount of time that a time series must
    /// violate the threshold to be considered
    /// failing. Currently, only values that are a
    /// multiple of a minute--e.g., 0, 60, 120, or
    /// 300 seconds--are supported. If an invalid
    /// value is given, an error will be returned.
    /// When choosing a duration, it is useful to
    /// keep in mind the frequency of the underlying
    /// time series data (which may also be affected
    /// by any alignments specified in the
    /// aggregations field); a good duration is long
    /// enough so that a single outlier does not
    /// generate spurious alerts, but short enough
    /// that unhealthy states are detected and
    /// alerted on quickly.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// A condition control that determines how
    /// metric-threshold conditions are evaluated when
    /// data stops arriving.
    /// Possible values are: EVALUATION_MISSING_DATA_INACTIVE, EVALUATION_MISSING_DATA_ACTIVE, EVALUATION_MISSING_DATA_NO_OP.
    /// </summary>
    [JsonPropertyName("evaluationMissingData")]
    public string? EvaluationMissingData { get; set; }

    /// <summary>
    /// The Log Analytics SQL query to run, as a string.  The query must
    /// conform to the required shape. Specifically, the query must not try to
    /// filter the input by time.  A filter will automatically be applied
    /// to filter the input so that the query receives all rows received
    /// since the last time the query was run.
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// The number/percent of time series for which
    /// the comparison must hold in order for the
    /// condition to trigger. If unspecified, then
    /// the condition will trigger if the comparison
    /// is true for any of the time series that have
    /// been identified by filter and aggregations,
    /// or by the ratio, if denominator_filter and
    /// denominator_aggregations are specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trigger")]
    public V1beta2AlertPolicySpecForProviderConditionsConditionMonitoringQueryLanguageTrigger? Trigger { get; set; }
}

/// <summary>
/// A condition type that allows alert policies to be defined using
/// Prometheus Query Language (PromQL).
/// The PrometheusQueryLanguageCondition message contains information
/// from a Prometheus alerting rule and its associated rule group.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionPrometheusQueryLanguage
{
    /// <summary>
    /// The alerting rule name of this alert in the corresponding Prometheus
    /// configuration file.
    /// Some external tools may require this field to be populated correctly
    /// in order to refer to the original Prometheus configuration file.
    /// The rule group name and the alert name are necessary to update the
    /// relevant AlertPolicies in case the definition of the rule group changes
    /// in the future.
    /// This field is optional. If this field is not empty, then it must be a
    /// valid Prometheus label name.
    /// </summary>
    [JsonPropertyName("alertRule")]
    public string? AlertRule { get; set; }

    /// <summary>
    /// Whether to disable metric existence validation for this condition.
    /// Users with the monitoring.alertPolicyViewer role are able to see the
    /// name of the non-existent metric in the alerting policy condition.
    /// </summary>
    [JsonPropertyName("disableMetricValidation")]
    public bool? DisableMetricValidation { get; set; }

    /// <summary>
    /// The amount of time that a time series must
    /// violate the threshold to be considered
    /// failing. Currently, only values that are a
    /// multiple of a minute--e.g., 0, 60, 120, or
    /// 300 seconds--are supported. If an invalid
    /// value is given, an error will be returned.
    /// When choosing a duration, it is useful to
    /// keep in mind the frequency of the underlying
    /// time series data (which may also be affected
    /// by any alignments specified in the
    /// aggregations field); a good duration is long
    /// enough so that a single outlier does not
    /// generate spurious alerts, but short enough
    /// that unhealthy states are detected and
    /// alerted on quickly.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// How often this rule should be evaluated. Must be a positive multiple
    /// of 30 seconds or missing. The default value is 30 seconds. If this
    /// PrometheusQueryLanguageCondition was generated from a Prometheus
    /// alerting rule, then this value should be taken from the enclosing
    /// rule group.
    /// </summary>
    [JsonPropertyName("evaluationInterval")]
    public string? EvaluationInterval { get; set; }

    /// <summary>
    /// Labels to add to or overwrite in the PromQL query result. Label names
    /// must be valid.
    /// Label values can be templatized by using variables. The only available
    /// variable names are the names of the labels in the PromQL result,
    /// although label names beginning with __ (two &quot;_&quot;) are reserved for
    /// internal use. &quot;labels&quot; may be empty. This field is intended to be used
    /// for organizing and identifying the AlertPolicy.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The Log Analytics SQL query to run, as a string.  The query must
    /// conform to the required shape. Specifically, the query must not try to
    /// filter the input by time.  A filter will automatically be applied
    /// to filter the input so that the query receives all rows received
    /// since the last time the query was run.
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// The rule group name of this alert in the corresponding Prometheus
    /// configuration file.
    /// Some external tools may require this field to be populated correctly
    /// in order to refer to the original Prometheus configuration file.
    /// The rule group name and the alert name are necessary to update the
    /// relevant AlertPolicies in case the definition of the rule group changes
    /// in the future. This field is optional.
    /// </summary>
    [JsonPropertyName("ruleGroup")]
    public string? RuleGroup { get; set; }
}

/// <summary>
/// A test that uses an alerting result in a boolean column produced by the SQL query.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionSqlBooleanTest
{
    /// <summary>
    /// The name of the column containing the boolean value. If the value in a row is
    /// NULL, that row is ignored.
    /// </summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }
}

/// <summary>
/// The time of day (in UTC) at which the query should run. If left
/// unspecified, the server picks an arbitrary time of day and runs
/// the query at the same time each day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionSqlDailyExecutionTime
{
    /// <summary>
    /// Hours of a day in 24 hour format. Must be greater than or equal
    /// to 0 and typically must be less than or equal to 23. An API may
    /// choose to allow the value &quot;24:00:00&quot; for scenarios like business
    /// closing time.
    /// </summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>
    /// Minutes of an hour. Must be greater than or equal to 0 and
    /// less than or equal to 59.
    /// </summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>
    /// Fractions of seconds, in nanoseconds. Must be greater than or
    /// equal to 0 and less than or equal to 999,999,999.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Seconds of a minute. Must be greater than or equal to 0 and
    /// typically must be less than or equal to 59. An API may allow the
    /// value 60 if it allows leap-seconds.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Used to schedule the query to run every so many days.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionSqlDaily
{
    /// <summary>
    /// The time of day (in UTC) at which the query should run. If left
    /// unspecified, the server picks an arbitrary time of day and runs
    /// the query at the same time each day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("executionTime")]
    public V1beta2AlertPolicySpecForProviderConditionsConditionSqlDailyExecutionTime? ExecutionTime { get; set; }

    /// <summary>
    /// Number of minutes between runs. The interval must be greater than or
    /// equal to 5 minutes and less than or equal to 1440 minutes.
    /// </summary>
    [JsonPropertyName("periodicity")]
    public double? Periodicity { get; set; }
}

/// <summary>
/// Used to schedule the query to run every so many hours.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionSqlHourly
{
    /// <summary>
    /// The number of minutes after the hour (in UTC) to run the query.
    /// Must be greater than or equal to 0 minutes and less than or equal to
    /// 59 minutes.  If left unspecified, then an arbitrary offset is used.
    /// </summary>
    [JsonPropertyName("minuteOffset")]
    public double? MinuteOffset { get; set; }

    /// <summary>
    /// Number of minutes between runs. The interval must be greater than or
    /// equal to 5 minutes and less than or equal to 1440 minutes.
    /// </summary>
    [JsonPropertyName("periodicity")]
    public double? Periodicity { get; set; }
}

/// <summary>
/// Minutes of an hour. Must be greater than or equal to 0 and
/// less than or equal to 59.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionSqlMinutes
{
    /// <summary>
    /// Number of minutes between runs. The interval must be greater than or
    /// equal to 5 minutes and less than or equal to 1440 minutes.
    /// </summary>
    [JsonPropertyName("periodicity")]
    public double? Periodicity { get; set; }
}

/// <summary>
/// A test that checks if the number of rows in the result set violates some threshold.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionSqlRowCountTest
{
    /// <summary>
    /// The comparison to apply between the time
    /// series (indicated by filter and aggregation)
    /// and the threshold (indicated by
    /// threshold_value). The comparison is applied
    /// on each time series, with the time series on
    /// the left-hand side and the threshold on the
    /// right-hand side. Only COMPARISON_LT and
    /// COMPARISON_GT are supported currently.
    /// Possible values are: COMPARISON_GT, COMPARISON_GE, COMPARISON_LT, COMPARISON_LE, COMPARISON_EQ, COMPARISON_NE.
    /// </summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The value against which to compare the row count.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

/// <summary>
/// A condition that allows alerting policies to be defined using GoogleSQL.
/// SQL conditions examine a sliding window of logs using GoogleSQL.
/// Alert policies with SQL conditions may incur additional billing.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionSql
{
    /// <summary>
    /// A test that uses an alerting result in a boolean column produced by the SQL query.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("booleanTest")]
    public V1beta2AlertPolicySpecForProviderConditionsConditionSqlBooleanTest? BooleanTest { get; set; }

    /// <summary>
    /// Used to schedule the query to run every so many days.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("daily")]
    public V1beta2AlertPolicySpecForProviderConditionsConditionSqlDaily? Daily { get; set; }

    /// <summary>
    /// Used to schedule the query to run every so many hours.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hourly")]
    public V1beta2AlertPolicySpecForProviderConditionsConditionSqlHourly? Hourly { get; set; }

    /// <summary>
    /// Minutes of an hour. Must be greater than or equal to 0 and
    /// less than or equal to 59.
    /// </summary>
    [JsonPropertyName("minutes")]
    public V1beta2AlertPolicySpecForProviderConditionsConditionSqlMinutes? Minutes { get; set; }

    /// <summary>
    /// The Log Analytics SQL query to run, as a string.  The query must
    /// conform to the required shape. Specifically, the query must not try to
    /// filter the input by time.  A filter will automatically be applied
    /// to filter the input so that the query receives all rows received
    /// since the last time the query was run.
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// A test that checks if the number of rows in the result set violates some threshold.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rowCountTest")]
    public V1beta2AlertPolicySpecForProviderConditionsConditionSqlRowCountTest? RowCountTest { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionThresholdAggregations
{
    /// <summary>
    /// The alignment period for per-time
    /// series alignment. If present,
    /// alignmentPeriod must be at least
    /// 60 seconds. After per-time series
    /// alignment, each time series will
    /// contain data points only on the
    /// period boundaries. If
    /// perSeriesAligner is not specified
    /// or equals ALIGN_NONE, then this
    /// field is ignored. If
    /// perSeriesAligner is specified and
    /// does not equal ALIGN_NONE, then
    /// this field must be defined;
    /// otherwise an error is returned.
    /// </summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>
    /// The approach to be used to combine
    /// time series. Not all reducer
    /// functions may be applied to all
    /// time series, depending on the
    /// metric type and the value type of
    /// the original time series.
    /// Reduction may change the metric
    /// type of value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.
    /// </summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>
    /// The set of fields to preserve when
    /// crossSeriesReducer is specified.
    /// The groupByFields determine how
    /// the time series are partitioned
    /// into subsets prior to applying the
    /// aggregation function. Each subset
    /// contains time series that have the
    /// same value for each of the
    /// grouping fields. Each individual
    /// time series is a member of exactly
    /// one subset. The crossSeriesReducer
    /// is applied to each subset of time
    /// series. It is not possible to
    /// reduce across different resource
    /// types, so this field implicitly
    /// contains resource.type. Fields not
    /// specified in groupByFields are
    /// aggregated away. If groupByFields
    /// is not specified and all the time
    /// series have the same resource
    /// type, then the time series are
    /// aggregated into a single output
    /// time series. If crossSeriesReducer
    /// is not defined, this field is
    /// ignored.
    /// </summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>
    /// The approach to be used to align
    /// individual time series. Not all
    /// alignment functions may be applied
    /// to all time series, depending on
    /// the metric type and value type of
    /// the original time series.
    /// Alignment may change the metric
    /// type or the value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.
    /// </summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionThresholdDenominatorAggregations
{
    /// <summary>
    /// The alignment period for per-time
    /// series alignment. If present,
    /// alignmentPeriod must be at least
    /// 60 seconds. After per-time series
    /// alignment, each time series will
    /// contain data points only on the
    /// period boundaries. If
    /// perSeriesAligner is not specified
    /// or equals ALIGN_NONE, then this
    /// field is ignored. If
    /// perSeriesAligner is specified and
    /// does not equal ALIGN_NONE, then
    /// this field must be defined;
    /// otherwise an error is returned.
    /// </summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>
    /// The approach to be used to combine
    /// time series. Not all reducer
    /// functions may be applied to all
    /// time series, depending on the
    /// metric type and the value type of
    /// the original time series.
    /// Reduction may change the metric
    /// type of value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.
    /// </summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>
    /// The set of fields to preserve when
    /// crossSeriesReducer is specified.
    /// The groupByFields determine how
    /// the time series are partitioned
    /// into subsets prior to applying the
    /// aggregation function. Each subset
    /// contains time series that have the
    /// same value for each of the
    /// grouping fields. Each individual
    /// time series is a member of exactly
    /// one subset. The crossSeriesReducer
    /// is applied to each subset of time
    /// series. It is not possible to
    /// reduce across different resource
    /// types, so this field implicitly
    /// contains resource.type. Fields not
    /// specified in groupByFields are
    /// aggregated away. If groupByFields
    /// is not specified and all the time
    /// series have the same resource
    /// type, then the time series are
    /// aggregated into a single output
    /// time series. If crossSeriesReducer
    /// is not defined, this field is
    /// ignored.
    /// </summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>
    /// The approach to be used to align
    /// individual time series. Not all
    /// alignment functions may be applied
    /// to all time series, depending on
    /// the metric type and value type of
    /// the original time series.
    /// Alignment may change the metric
    /// type or the value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.
    /// </summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary>
/// When this field is present, the MetricThreshold
/// condition forecasts whether the time series is
/// predicted to violate the threshold within the
/// forecastHorizon. When this field is not set, the
/// MetricThreshold tests the current value of the
/// timeseries against the threshold.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionThresholdForecastOptions
{
    /// <summary>
    /// The length of time into the future to forecast
    /// whether a timeseries will violate the threshold.
    /// If the predicted value is found to violate the
    /// threshold, and the violation is observed in all
    /// forecasts made for the Configured duration,
    /// then the timeseries is considered to be failing.
    /// </summary>
    [JsonPropertyName("forecastHorizon")]
    public string? ForecastHorizon { get; set; }
}

/// <summary>
/// The number/percent of time series for which
/// the comparison must hold in order for the
/// condition to trigger. If unspecified, then
/// the condition will trigger if the comparison
/// is true for any of the time series that have
/// been identified by filter and aggregations,
/// or by the ratio, if denominator_filter and
/// denominator_aggregations are specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionThresholdTrigger
{
    /// <summary>
    /// The absolute number of time series
    /// that must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>
    /// The percentage of time series that
    /// must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>
/// A condition that compares a time series against a
/// threshold.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditionsConditionThreshold
{
    /// <summary>
    /// Specifies the alignment of data points in
    /// individual time series as well as how to
    /// combine the retrieved time series together
    /// (such as when aggregating multiple streams
    /// on each resource to a single stream for each
    /// resource or when aggregating streams across
    /// all members of a group of resources).
    /// Multiple aggregations are applied in the
    /// order specified.This field is similar to the
    /// one in the MetricService.ListTimeSeries
    /// request. It is advisable to use the
    /// ListTimeSeries method when debugging this
    /// field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aggregations")]
    public IList<V1beta2AlertPolicySpecForProviderConditionsConditionThresholdAggregations>? Aggregations { get; set; }

    /// <summary>
    /// The comparison to apply between the time
    /// series (indicated by filter and aggregation)
    /// and the threshold (indicated by
    /// threshold_value). The comparison is applied
    /// on each time series, with the time series on
    /// the left-hand side and the threshold on the
    /// right-hand side. Only COMPARISON_LT and
    /// COMPARISON_GT are supported currently.
    /// Possible values are: COMPARISON_GT, COMPARISON_GE, COMPARISON_LT, COMPARISON_LE, COMPARISON_EQ, COMPARISON_NE.
    /// </summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>
    /// Specifies the alignment of data points in
    /// individual time series selected by
    /// denominatorFilter as well as how to combine
    /// the retrieved time series together (such as
    /// when aggregating multiple streams on each
    /// resource to a single stream for each
    /// resource or when aggregating streams across
    /// all members of a group of resources).When
    /// computing ratios, the aggregations and
    /// denominator_aggregations fields must use the
    /// same alignment period and produce time
    /// series that have the same periodicity and
    /// labels.This field is similar to the one in
    /// the MetricService.ListTimeSeries request. It
    /// is advisable to use the ListTimeSeries
    /// method when debugging this field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("denominatorAggregations")]
    public IList<V1beta2AlertPolicySpecForProviderConditionsConditionThresholdDenominatorAggregations>? DenominatorAggregations { get; set; }

    /// <summary>
    /// A filter that identifies a time series that
    /// should be used as the denominator of a ratio
    /// that will be compared with the threshold. If
    /// a denominator_filter is specified, the time
    /// series specified by the filter field will be
    /// used as the numerator.The filter is similar
    /// to the one that is specified in the
    /// MetricService.ListTimeSeries request (that
    /// call is useful to verify the time series
    /// that will be retrieved / processed) and must
    /// specify the metric type and optionally may
    /// contain restrictions on resource type,
    /// resource labels, and metric labels. This
    /// field may not exceed 2048 Unicode characters
    /// in length.
    /// </summary>
    [JsonPropertyName("denominatorFilter")]
    public string? DenominatorFilter { get; set; }

    /// <summary>
    /// The amount of time that a time series must
    /// violate the threshold to be considered
    /// failing. Currently, only values that are a
    /// multiple of a minute--e.g., 0, 60, 120, or
    /// 300 seconds--are supported. If an invalid
    /// value is given, an error will be returned.
    /// When choosing a duration, it is useful to
    /// keep in mind the frequency of the underlying
    /// time series data (which may also be affected
    /// by any alignments specified in the
    /// aggregations field); a good duration is long
    /// enough so that a single outlier does not
    /// generate spurious alerts, but short enough
    /// that unhealthy states are detected and
    /// alerted on quickly.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// A condition control that determines how
    /// metric-threshold conditions are evaluated when
    /// data stops arriving.
    /// Possible values are: EVALUATION_MISSING_DATA_INACTIVE, EVALUATION_MISSING_DATA_ACTIVE, EVALUATION_MISSING_DATA_NO_OP.
    /// </summary>
    [JsonPropertyName("evaluationMissingData")]
    public string? EvaluationMissingData { get; set; }

    /// <summary>
    /// A filter that identifies which time series
    /// should be compared with the threshold.The
    /// filter is similar to the one that is
    /// specified in the
    /// MetricService.ListTimeSeries request (that
    /// call is useful to verify the time series
    /// that will be retrieved / processed) and must
    /// specify the metric type and optionally may
    /// contain restrictions on resource type,
    /// resource labels, and metric labels. This
    /// field may not exceed 2048 Unicode characters
    /// in length.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>
    /// When this field is present, the MetricThreshold
    /// condition forecasts whether the time series is
    /// predicted to violate the threshold within the
    /// forecastHorizon. When this field is not set, the
    /// MetricThreshold tests the current value of the
    /// timeseries against the threshold.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("forecastOptions")]
    public V1beta2AlertPolicySpecForProviderConditionsConditionThresholdForecastOptions? ForecastOptions { get; set; }

    /// <summary>
    /// A value against which to compare the time
    /// series.
    /// </summary>
    [JsonPropertyName("thresholdValue")]
    public double? ThresholdValue { get; set; }

    /// <summary>
    /// The number/percent of time series for which
    /// the comparison must hold in order for the
    /// condition to trigger. If unspecified, then
    /// the condition will trigger if the comparison
    /// is true for any of the time series that have
    /// been identified by filter and aggregations,
    /// or by the ratio, if denominator_filter and
    /// denominator_aggregations are specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trigger")]
    public V1beta2AlertPolicySpecForProviderConditionsConditionThresholdTrigger? Trigger { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderConditions
{
    /// <summary>
    /// A condition that checks that a time series
    /// continues to receive new data points.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionAbsent")]
    public V1beta2AlertPolicySpecForProviderConditionsConditionAbsent? ConditionAbsent { get; set; }

    /// <summary>
    /// A condition that checks for log messages matching given constraints.
    /// If set, no other conditions can be present.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionMatchedLog")]
    public V1beta2AlertPolicySpecForProviderConditionsConditionMatchedLog? ConditionMatchedLog { get; set; }

    /// <summary>
    /// A Monitoring Query Language query that outputs a boolean stream
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionMonitoringQueryLanguage")]
    public V1beta2AlertPolicySpecForProviderConditionsConditionMonitoringQueryLanguage? ConditionMonitoringQueryLanguage { get; set; }

    /// <summary>
    /// A condition type that allows alert policies to be defined using
    /// Prometheus Query Language (PromQL).
    /// The PrometheusQueryLanguageCondition message contains information
    /// from a Prometheus alerting rule and its associated rule group.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionPrometheusQueryLanguage")]
    public V1beta2AlertPolicySpecForProviderConditionsConditionPrometheusQueryLanguage? ConditionPrometheusQueryLanguage { get; set; }

    /// <summary>
    /// A condition that allows alerting policies to be defined using GoogleSQL.
    /// SQL conditions examine a sliding window of logs using GoogleSQL.
    /// Alert policies with SQL conditions may incur additional billing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionSql")]
    public V1beta2AlertPolicySpecForProviderConditionsConditionSql? ConditionSql { get; set; }

    /// <summary>
    /// A condition that compares a time series against a
    /// threshold.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionThreshold")]
    public V1beta2AlertPolicySpecForProviderConditionsConditionThreshold? ConditionThreshold { get; set; }

    /// <summary>
    /// A short name or phrase used to identify the
    /// condition in dashboards, notifications, and
    /// incidents. To avoid confusion, don&apos;t use the same
    /// display name for multiple conditions in the same
    /// policy.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderDocumentationLinks
{
    /// <summary>A short display name for the link. The display name must not be empty or exceed 63 characters. Example: &quot;playbook&quot;.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The url of a webpage. A url can be templatized by using variables in the path or the query parameters. The total length of a URL should not exceed 2083 characters before and after variable expansion. Example: &quot;https://my_domain.com/playbook?name=${resource.name}&quot;.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Documentation that is included with notifications and incidents related
/// to this policy. Best practice is for the documentation to include information
/// to help responders understand, mitigate, escalate, and correct the underlying
/// problems detected by the alerting policy. Notification channels that have
/// limited capacity might not show this documentation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProviderDocumentation
{
    /// <summary>
    /// The text of the documentation, interpreted according to mimeType.
    /// The content may not exceed 8,192 Unicode characters and may not
    /// exceed more than 10,240 bytes when encoded in UTF-8 format,
    /// whichever is smaller.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// Links to content such as playbooks, repositories, and other resources. This field can contain up to 3 entries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("links")]
    public IList<V1beta2AlertPolicySpecForProviderDocumentationLinks>? Links { get; set; }

    /// <summary>
    /// The format of the content field. Presently, only the value
    /// &quot;text/markdown&quot; is supported.
    /// </summary>
    [JsonPropertyName("mimeType")]
    public string? MimeType { get; set; }

    /// <summary>
    /// The subject line of the notification. The subject line may not
    /// exceed 10,240 bytes. In notifications generated by this policy the contents
    /// of the subject line after variable expansion will be truncated to 255 bytes
    /// or shorter at the latest UTF-8 character boundary.
    /// </summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecForProvider
{
    /// <summary>
    /// Control over how this alert policy&apos;s notification channels are notified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("alertStrategy")]
    public V1beta2AlertPolicySpecForProviderAlertStrategy? AlertStrategy { get; set; }

    /// <summary>
    /// How to combine the results of multiple conditions to
    /// determine if an incident should be opened.
    /// Possible values are: AND, OR, AND_WITH_MATCHING_RESOURCE.
    /// </summary>
    [JsonPropertyName("combiner")]
    public string? Combiner { get; set; }

    /// <summary>
    /// A list of conditions for the policy. The conditions are combined by
    /// AND or OR according to the combiner field. If the combined conditions
    /// evaluate to true, then an incident is created. A policy can have from
    /// one to six conditions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AlertPolicySpecForProviderConditions>? Conditions { get; set; }

    /// <summary>
    /// A short name or phrase used to identify the policy in
    /// dashboards, notifications, and incidents. To avoid confusion, don&apos;t use
    /// the same display name for multiple policies in the same project. The
    /// name is limited to 512 Unicode characters.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Documentation that is included with notifications and incidents related
    /// to this policy. Best practice is for the documentation to include information
    /// to help responders understand, mitigate, escalate, and correct the underlying
    /// problems detected by the alerting policy. Notification channels that have
    /// limited capacity might not show this documentation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("documentation")]
    public V1beta2AlertPolicySpecForProviderDocumentation? Documentation { get; set; }

    /// <summary>Whether or not the policy is enabled. The default is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Identifies the notification channels to which notifications should be
    /// sent when incidents are opened or closed or when new violations occur
    /// on an already opened incident. Each element of this array corresponds
    /// to the name field in each of the NotificationChannel objects that are
    /// returned from the notificationChannels.list method. The syntax of the
    /// entries in this field is
    /// projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]
    /// </summary>
    [JsonPropertyName("notificationChannels")]
    public IList<string>? NotificationChannels { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The severity of an alert policy indicates how important incidents generated
    /// by that policy are. The severity level will be displayed on the Incident
    /// detail page and in notifications.
    /// Possible values are: CRITICAL, ERROR, WARNING.
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>
    /// This field is intended to be used for organizing and identifying the AlertPolicy
    /// objects.The field can contain up to 64 entries. Each key and value is limited
    /// to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values
    /// can contain only lowercase letters, numerals, underscores, and dashes. Keys
    /// must begin with a letter.
    /// </summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderAlertStrategyNotificationChannelStrategy
{
    /// <summary>
    /// The notification channels that these settings apply to. Each of these
    /// correspond to the name field in one of the NotificationChannel objects
    /// referenced in the notification_channels field of this AlertPolicy. The format is
    /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
    /// </summary>
    [JsonPropertyName("notificationChannelNames")]
    public IList<string>? NotificationChannelNames { get; set; }

    /// <summary>The frequency at which to send reminder notifications for open incidents.</summary>
    [JsonPropertyName("renotifyInterval")]
    public string? RenotifyInterval { get; set; }
}

/// <summary>
/// Required for alert policies with a LogMatch condition.
/// This limit is not implemented for alert policies that are not log-based.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderAlertStrategyNotificationRateLimit
{
    /// <summary>
    /// Not more than one notification per period.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example &quot;60.5s&quot;.
    /// </summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
}

/// <summary>
/// Control over how this alert policy&apos;s notification channels are notified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderAlertStrategy
{
    /// <summary>If an alert policy that was active has no data for this long, any open incidents will close.</summary>
    [JsonPropertyName("autoClose")]
    public string? AutoClose { get; set; }

    /// <summary>
    /// Control over how the notification channels in notification_channels
    /// are notified when this alert fires, on a per-channel basis.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("notificationChannelStrategy")]
    public IList<V1beta2AlertPolicySpecInitProviderAlertStrategyNotificationChannelStrategy>? NotificationChannelStrategy { get; set; }

    /// <summary>
    /// Control when notifications will be sent out.
    /// Each value may be one of: NOTIFICATION_PROMPT_UNSPECIFIED, OPENED, CLOSED.
    /// </summary>
    [JsonPropertyName("notificationPrompts")]
    public IList<string>? NotificationPrompts { get; set; }

    /// <summary>
    /// Required for alert policies with a LogMatch condition.
    /// This limit is not implemented for alert policies that are not log-based.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("notificationRateLimit")]
    public V1beta2AlertPolicySpecInitProviderAlertStrategyNotificationRateLimit? NotificationRateLimit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionAbsentAggregations
{
    /// <summary>
    /// The alignment period for per-time
    /// series alignment. If present,
    /// alignmentPeriod must be at least
    /// 60 seconds. After per-time series
    /// alignment, each time series will
    /// contain data points only on the
    /// period boundaries. If
    /// perSeriesAligner is not specified
    /// or equals ALIGN_NONE, then this
    /// field is ignored. If
    /// perSeriesAligner is specified and
    /// does not equal ALIGN_NONE, then
    /// this field must be defined;
    /// otherwise an error is returned.
    /// </summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>
    /// The approach to be used to combine
    /// time series. Not all reducer
    /// functions may be applied to all
    /// time series, depending on the
    /// metric type and the value type of
    /// the original time series.
    /// Reduction may change the metric
    /// type of value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.
    /// </summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>
    /// The set of fields to preserve when
    /// crossSeriesReducer is specified.
    /// The groupByFields determine how
    /// the time series are partitioned
    /// into subsets prior to applying the
    /// aggregation function. Each subset
    /// contains time series that have the
    /// same value for each of the
    /// grouping fields. Each individual
    /// time series is a member of exactly
    /// one subset. The crossSeriesReducer
    /// is applied to each subset of time
    /// series. It is not possible to
    /// reduce across different resource
    /// types, so this field implicitly
    /// contains resource.type. Fields not
    /// specified in groupByFields are
    /// aggregated away. If groupByFields
    /// is not specified and all the time
    /// series have the same resource
    /// type, then the time series are
    /// aggregated into a single output
    /// time series. If crossSeriesReducer
    /// is not defined, this field is
    /// ignored.
    /// </summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>
    /// The approach to be used to align
    /// individual time series. Not all
    /// alignment functions may be applied
    /// to all time series, depending on
    /// the metric type and value type of
    /// the original time series.
    /// Alignment may change the metric
    /// type or the value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.
    /// </summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary>
/// The number/percent of time series for which
/// the comparison must hold in order for the
/// condition to trigger. If unspecified, then
/// the condition will trigger if the comparison
/// is true for any of the time series that have
/// been identified by filter and aggregations,
/// or by the ratio, if denominator_filter and
/// denominator_aggregations are specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionAbsentTrigger
{
    /// <summary>
    /// The absolute number of time series
    /// that must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>
    /// The percentage of time series that
    /// must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>
/// A condition that checks that a time series
/// continues to receive new data points.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionAbsent
{
    /// <summary>
    /// Specifies the alignment of data points in
    /// individual time series as well as how to
    /// combine the retrieved time series together
    /// (such as when aggregating multiple streams
    /// on each resource to a single stream for each
    /// resource or when aggregating streams across
    /// all members of a group of resources).
    /// Multiple aggregations are applied in the
    /// order specified.This field is similar to the
    /// one in the MetricService.ListTimeSeries
    /// request. It is advisable to use the
    /// ListTimeSeries method when debugging this
    /// field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aggregations")]
    public IList<V1beta2AlertPolicySpecInitProviderConditionsConditionAbsentAggregations>? Aggregations { get; set; }

    /// <summary>
    /// The amount of time that a time series must
    /// violate the threshold to be considered
    /// failing. Currently, only values that are a
    /// multiple of a minute--e.g., 0, 60, 120, or
    /// 300 seconds--are supported. If an invalid
    /// value is given, an error will be returned.
    /// When choosing a duration, it is useful to
    /// keep in mind the frequency of the underlying
    /// time series data (which may also be affected
    /// by any alignments specified in the
    /// aggregations field); a good duration is long
    /// enough so that a single outlier does not
    /// generate spurious alerts, but short enough
    /// that unhealthy states are detected and
    /// alerted on quickly.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// A filter that identifies which time series
    /// should be compared with the threshold.The
    /// filter is similar to the one that is
    /// specified in the
    /// MetricService.ListTimeSeries request (that
    /// call is useful to verify the time series
    /// that will be retrieved / processed) and must
    /// specify the metric type and optionally may
    /// contain restrictions on resource type,
    /// resource labels, and metric labels. This
    /// field may not exceed 2048 Unicode characters
    /// in length.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>
    /// The number/percent of time series for which
    /// the comparison must hold in order for the
    /// condition to trigger. If unspecified, then
    /// the condition will trigger if the comparison
    /// is true for any of the time series that have
    /// been identified by filter and aggregations,
    /// or by the ratio, if denominator_filter and
    /// denominator_aggregations are specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trigger")]
    public V1beta2AlertPolicySpecInitProviderConditionsConditionAbsentTrigger? Trigger { get; set; }
}

/// <summary>
/// A condition that checks for log messages matching given constraints.
/// If set, no other conditions can be present.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionMatchedLog
{
    /// <summary>
    /// A filter that identifies which time series
    /// should be compared with the threshold.The
    /// filter is similar to the one that is
    /// specified in the
    /// MetricService.ListTimeSeries request (that
    /// call is useful to verify the time series
    /// that will be retrieved / processed) and must
    /// specify the metric type and optionally may
    /// contain restrictions on resource type,
    /// resource labels, and metric labels. This
    /// field may not exceed 2048 Unicode characters
    /// in length.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>
    /// A map from a label key to an extractor expression, which is used to
    /// extract the value for this label key. Each entry in this map is
    /// a specification for how data should be extracted from log entries that
    /// match filter. Each combination of extracted values is treated as
    /// a separate rule for the purposes of triggering notifications.
    /// Label keys and corresponding values can be used in notifications
    /// generated by this condition.
    /// </summary>
    [JsonPropertyName("labelExtractors")]
    public IDictionary<string, string>? LabelExtractors { get; set; }
}

/// <summary>
/// The number/percent of time series for which
/// the comparison must hold in order for the
/// condition to trigger. If unspecified, then
/// the condition will trigger if the comparison
/// is true for any of the time series that have
/// been identified by filter and aggregations,
/// or by the ratio, if denominator_filter and
/// denominator_aggregations are specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionMonitoringQueryLanguageTrigger
{
    /// <summary>
    /// The absolute number of time series
    /// that must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>
    /// The percentage of time series that
    /// must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>
/// A Monitoring Query Language query that outputs a boolean stream
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionMonitoringQueryLanguage
{
    /// <summary>
    /// The amount of time that a time series must
    /// violate the threshold to be considered
    /// failing. Currently, only values that are a
    /// multiple of a minute--e.g., 0, 60, 120, or
    /// 300 seconds--are supported. If an invalid
    /// value is given, an error will be returned.
    /// When choosing a duration, it is useful to
    /// keep in mind the frequency of the underlying
    /// time series data (which may also be affected
    /// by any alignments specified in the
    /// aggregations field); a good duration is long
    /// enough so that a single outlier does not
    /// generate spurious alerts, but short enough
    /// that unhealthy states are detected and
    /// alerted on quickly.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// A condition control that determines how
    /// metric-threshold conditions are evaluated when
    /// data stops arriving.
    /// Possible values are: EVALUATION_MISSING_DATA_INACTIVE, EVALUATION_MISSING_DATA_ACTIVE, EVALUATION_MISSING_DATA_NO_OP.
    /// </summary>
    [JsonPropertyName("evaluationMissingData")]
    public string? EvaluationMissingData { get; set; }

    /// <summary>
    /// The Log Analytics SQL query to run, as a string.  The query must
    /// conform to the required shape. Specifically, the query must not try to
    /// filter the input by time.  A filter will automatically be applied
    /// to filter the input so that the query receives all rows received
    /// since the last time the query was run.
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// The number/percent of time series for which
    /// the comparison must hold in order for the
    /// condition to trigger. If unspecified, then
    /// the condition will trigger if the comparison
    /// is true for any of the time series that have
    /// been identified by filter and aggregations,
    /// or by the ratio, if denominator_filter and
    /// denominator_aggregations are specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trigger")]
    public V1beta2AlertPolicySpecInitProviderConditionsConditionMonitoringQueryLanguageTrigger? Trigger { get; set; }
}

/// <summary>
/// A condition type that allows alert policies to be defined using
/// Prometheus Query Language (PromQL).
/// The PrometheusQueryLanguageCondition message contains information
/// from a Prometheus alerting rule and its associated rule group.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionPrometheusQueryLanguage
{
    /// <summary>
    /// The alerting rule name of this alert in the corresponding Prometheus
    /// configuration file.
    /// Some external tools may require this field to be populated correctly
    /// in order to refer to the original Prometheus configuration file.
    /// The rule group name and the alert name are necessary to update the
    /// relevant AlertPolicies in case the definition of the rule group changes
    /// in the future.
    /// This field is optional. If this field is not empty, then it must be a
    /// valid Prometheus label name.
    /// </summary>
    [JsonPropertyName("alertRule")]
    public string? AlertRule { get; set; }

    /// <summary>
    /// Whether to disable metric existence validation for this condition.
    /// Users with the monitoring.alertPolicyViewer role are able to see the
    /// name of the non-existent metric in the alerting policy condition.
    /// </summary>
    [JsonPropertyName("disableMetricValidation")]
    public bool? DisableMetricValidation { get; set; }

    /// <summary>
    /// The amount of time that a time series must
    /// violate the threshold to be considered
    /// failing. Currently, only values that are a
    /// multiple of a minute--e.g., 0, 60, 120, or
    /// 300 seconds--are supported. If an invalid
    /// value is given, an error will be returned.
    /// When choosing a duration, it is useful to
    /// keep in mind the frequency of the underlying
    /// time series data (which may also be affected
    /// by any alignments specified in the
    /// aggregations field); a good duration is long
    /// enough so that a single outlier does not
    /// generate spurious alerts, but short enough
    /// that unhealthy states are detected and
    /// alerted on quickly.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// How often this rule should be evaluated. Must be a positive multiple
    /// of 30 seconds or missing. The default value is 30 seconds. If this
    /// PrometheusQueryLanguageCondition was generated from a Prometheus
    /// alerting rule, then this value should be taken from the enclosing
    /// rule group.
    /// </summary>
    [JsonPropertyName("evaluationInterval")]
    public string? EvaluationInterval { get; set; }

    /// <summary>
    /// Labels to add to or overwrite in the PromQL query result. Label names
    /// must be valid.
    /// Label values can be templatized by using variables. The only available
    /// variable names are the names of the labels in the PromQL result,
    /// although label names beginning with __ (two &quot;_&quot;) are reserved for
    /// internal use. &quot;labels&quot; may be empty. This field is intended to be used
    /// for organizing and identifying the AlertPolicy.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The Log Analytics SQL query to run, as a string.  The query must
    /// conform to the required shape. Specifically, the query must not try to
    /// filter the input by time.  A filter will automatically be applied
    /// to filter the input so that the query receives all rows received
    /// since the last time the query was run.
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// The rule group name of this alert in the corresponding Prometheus
    /// configuration file.
    /// Some external tools may require this field to be populated correctly
    /// in order to refer to the original Prometheus configuration file.
    /// The rule group name and the alert name are necessary to update the
    /// relevant AlertPolicies in case the definition of the rule group changes
    /// in the future. This field is optional.
    /// </summary>
    [JsonPropertyName("ruleGroup")]
    public string? RuleGroup { get; set; }
}

/// <summary>
/// A test that uses an alerting result in a boolean column produced by the SQL query.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionSqlBooleanTest
{
    /// <summary>
    /// The name of the column containing the boolean value. If the value in a row is
    /// NULL, that row is ignored.
    /// </summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }
}

/// <summary>
/// The time of day (in UTC) at which the query should run. If left
/// unspecified, the server picks an arbitrary time of day and runs
/// the query at the same time each day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionSqlDailyExecutionTime
{
    /// <summary>
    /// Hours of a day in 24 hour format. Must be greater than or equal
    /// to 0 and typically must be less than or equal to 23. An API may
    /// choose to allow the value &quot;24:00:00&quot; for scenarios like business
    /// closing time.
    /// </summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>
    /// Minutes of an hour. Must be greater than or equal to 0 and
    /// less than or equal to 59.
    /// </summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>
    /// Fractions of seconds, in nanoseconds. Must be greater than or
    /// equal to 0 and less than or equal to 999,999,999.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Seconds of a minute. Must be greater than or equal to 0 and
    /// typically must be less than or equal to 59. An API may allow the
    /// value 60 if it allows leap-seconds.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Used to schedule the query to run every so many days.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionSqlDaily
{
    /// <summary>
    /// The time of day (in UTC) at which the query should run. If left
    /// unspecified, the server picks an arbitrary time of day and runs
    /// the query at the same time each day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("executionTime")]
    public V1beta2AlertPolicySpecInitProviderConditionsConditionSqlDailyExecutionTime? ExecutionTime { get; set; }

    /// <summary>
    /// Number of minutes between runs. The interval must be greater than or
    /// equal to 5 minutes and less than or equal to 1440 minutes.
    /// </summary>
    [JsonPropertyName("periodicity")]
    public double? Periodicity { get; set; }
}

/// <summary>
/// Used to schedule the query to run every so many hours.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionSqlHourly
{
    /// <summary>
    /// The number of minutes after the hour (in UTC) to run the query.
    /// Must be greater than or equal to 0 minutes and less than or equal to
    /// 59 minutes.  If left unspecified, then an arbitrary offset is used.
    /// </summary>
    [JsonPropertyName("minuteOffset")]
    public double? MinuteOffset { get; set; }

    /// <summary>
    /// Number of minutes between runs. The interval must be greater than or
    /// equal to 5 minutes and less than or equal to 1440 minutes.
    /// </summary>
    [JsonPropertyName("periodicity")]
    public double? Periodicity { get; set; }
}

/// <summary>
/// Minutes of an hour. Must be greater than or equal to 0 and
/// less than or equal to 59.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionSqlMinutes
{
    /// <summary>
    /// Number of minutes between runs. The interval must be greater than or
    /// equal to 5 minutes and less than or equal to 1440 minutes.
    /// </summary>
    [JsonPropertyName("periodicity")]
    public double? Periodicity { get; set; }
}

/// <summary>
/// A test that checks if the number of rows in the result set violates some threshold.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionSqlRowCountTest
{
    /// <summary>
    /// The comparison to apply between the time
    /// series (indicated by filter and aggregation)
    /// and the threshold (indicated by
    /// threshold_value). The comparison is applied
    /// on each time series, with the time series on
    /// the left-hand side and the threshold on the
    /// right-hand side. Only COMPARISON_LT and
    /// COMPARISON_GT are supported currently.
    /// Possible values are: COMPARISON_GT, COMPARISON_GE, COMPARISON_LT, COMPARISON_LE, COMPARISON_EQ, COMPARISON_NE.
    /// </summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The value against which to compare the row count.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

/// <summary>
/// A condition that allows alerting policies to be defined using GoogleSQL.
/// SQL conditions examine a sliding window of logs using GoogleSQL.
/// Alert policies with SQL conditions may incur additional billing.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionSql
{
    /// <summary>
    /// A test that uses an alerting result in a boolean column produced by the SQL query.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("booleanTest")]
    public V1beta2AlertPolicySpecInitProviderConditionsConditionSqlBooleanTest? BooleanTest { get; set; }

    /// <summary>
    /// Used to schedule the query to run every so many days.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("daily")]
    public V1beta2AlertPolicySpecInitProviderConditionsConditionSqlDaily? Daily { get; set; }

    /// <summary>
    /// Used to schedule the query to run every so many hours.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hourly")]
    public V1beta2AlertPolicySpecInitProviderConditionsConditionSqlHourly? Hourly { get; set; }

    /// <summary>
    /// Minutes of an hour. Must be greater than or equal to 0 and
    /// less than or equal to 59.
    /// </summary>
    [JsonPropertyName("minutes")]
    public V1beta2AlertPolicySpecInitProviderConditionsConditionSqlMinutes? Minutes { get; set; }

    /// <summary>
    /// The Log Analytics SQL query to run, as a string.  The query must
    /// conform to the required shape. Specifically, the query must not try to
    /// filter the input by time.  A filter will automatically be applied
    /// to filter the input so that the query receives all rows received
    /// since the last time the query was run.
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// A test that checks if the number of rows in the result set violates some threshold.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rowCountTest")]
    public V1beta2AlertPolicySpecInitProviderConditionsConditionSqlRowCountTest? RowCountTest { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionThresholdAggregations
{
    /// <summary>
    /// The alignment period for per-time
    /// series alignment. If present,
    /// alignmentPeriod must be at least
    /// 60 seconds. After per-time series
    /// alignment, each time series will
    /// contain data points only on the
    /// period boundaries. If
    /// perSeriesAligner is not specified
    /// or equals ALIGN_NONE, then this
    /// field is ignored. If
    /// perSeriesAligner is specified and
    /// does not equal ALIGN_NONE, then
    /// this field must be defined;
    /// otherwise an error is returned.
    /// </summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>
    /// The approach to be used to combine
    /// time series. Not all reducer
    /// functions may be applied to all
    /// time series, depending on the
    /// metric type and the value type of
    /// the original time series.
    /// Reduction may change the metric
    /// type of value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.
    /// </summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>
    /// The set of fields to preserve when
    /// crossSeriesReducer is specified.
    /// The groupByFields determine how
    /// the time series are partitioned
    /// into subsets prior to applying the
    /// aggregation function. Each subset
    /// contains time series that have the
    /// same value for each of the
    /// grouping fields. Each individual
    /// time series is a member of exactly
    /// one subset. The crossSeriesReducer
    /// is applied to each subset of time
    /// series. It is not possible to
    /// reduce across different resource
    /// types, so this field implicitly
    /// contains resource.type. Fields not
    /// specified in groupByFields are
    /// aggregated away. If groupByFields
    /// is not specified and all the time
    /// series have the same resource
    /// type, then the time series are
    /// aggregated into a single output
    /// time series. If crossSeriesReducer
    /// is not defined, this field is
    /// ignored.
    /// </summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>
    /// The approach to be used to align
    /// individual time series. Not all
    /// alignment functions may be applied
    /// to all time series, depending on
    /// the metric type and value type of
    /// the original time series.
    /// Alignment may change the metric
    /// type or the value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.
    /// </summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionThresholdDenominatorAggregations
{
    /// <summary>
    /// The alignment period for per-time
    /// series alignment. If present,
    /// alignmentPeriod must be at least
    /// 60 seconds. After per-time series
    /// alignment, each time series will
    /// contain data points only on the
    /// period boundaries. If
    /// perSeriesAligner is not specified
    /// or equals ALIGN_NONE, then this
    /// field is ignored. If
    /// perSeriesAligner is specified and
    /// does not equal ALIGN_NONE, then
    /// this field must be defined;
    /// otherwise an error is returned.
    /// </summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>
    /// The approach to be used to combine
    /// time series. Not all reducer
    /// functions may be applied to all
    /// time series, depending on the
    /// metric type and the value type of
    /// the original time series.
    /// Reduction may change the metric
    /// type of value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.
    /// </summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>
    /// The set of fields to preserve when
    /// crossSeriesReducer is specified.
    /// The groupByFields determine how
    /// the time series are partitioned
    /// into subsets prior to applying the
    /// aggregation function. Each subset
    /// contains time series that have the
    /// same value for each of the
    /// grouping fields. Each individual
    /// time series is a member of exactly
    /// one subset. The crossSeriesReducer
    /// is applied to each subset of time
    /// series. It is not possible to
    /// reduce across different resource
    /// types, so this field implicitly
    /// contains resource.type. Fields not
    /// specified in groupByFields are
    /// aggregated away. If groupByFields
    /// is not specified and all the time
    /// series have the same resource
    /// type, then the time series are
    /// aggregated into a single output
    /// time series. If crossSeriesReducer
    /// is not defined, this field is
    /// ignored.
    /// </summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>
    /// The approach to be used to align
    /// individual time series. Not all
    /// alignment functions may be applied
    /// to all time series, depending on
    /// the metric type and value type of
    /// the original time series.
    /// Alignment may change the metric
    /// type or the value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.
    /// </summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary>
/// When this field is present, the MetricThreshold
/// condition forecasts whether the time series is
/// predicted to violate the threshold within the
/// forecastHorizon. When this field is not set, the
/// MetricThreshold tests the current value of the
/// timeseries against the threshold.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionThresholdForecastOptions
{
    /// <summary>
    /// The length of time into the future to forecast
    /// whether a timeseries will violate the threshold.
    /// If the predicted value is found to violate the
    /// threshold, and the violation is observed in all
    /// forecasts made for the Configured duration,
    /// then the timeseries is considered to be failing.
    /// </summary>
    [JsonPropertyName("forecastHorizon")]
    public string? ForecastHorizon { get; set; }
}

/// <summary>
/// The number/percent of time series for which
/// the comparison must hold in order for the
/// condition to trigger. If unspecified, then
/// the condition will trigger if the comparison
/// is true for any of the time series that have
/// been identified by filter and aggregations,
/// or by the ratio, if denominator_filter and
/// denominator_aggregations are specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionThresholdTrigger
{
    /// <summary>
    /// The absolute number of time series
    /// that must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>
    /// The percentage of time series that
    /// must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>
/// A condition that compares a time series against a
/// threshold.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditionsConditionThreshold
{
    /// <summary>
    /// Specifies the alignment of data points in
    /// individual time series as well as how to
    /// combine the retrieved time series together
    /// (such as when aggregating multiple streams
    /// on each resource to a single stream for each
    /// resource or when aggregating streams across
    /// all members of a group of resources).
    /// Multiple aggregations are applied in the
    /// order specified.This field is similar to the
    /// one in the MetricService.ListTimeSeries
    /// request. It is advisable to use the
    /// ListTimeSeries method when debugging this
    /// field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aggregations")]
    public IList<V1beta2AlertPolicySpecInitProviderConditionsConditionThresholdAggregations>? Aggregations { get; set; }

    /// <summary>
    /// The comparison to apply between the time
    /// series (indicated by filter and aggregation)
    /// and the threshold (indicated by
    /// threshold_value). The comparison is applied
    /// on each time series, with the time series on
    /// the left-hand side and the threshold on the
    /// right-hand side. Only COMPARISON_LT and
    /// COMPARISON_GT are supported currently.
    /// Possible values are: COMPARISON_GT, COMPARISON_GE, COMPARISON_LT, COMPARISON_LE, COMPARISON_EQ, COMPARISON_NE.
    /// </summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>
    /// Specifies the alignment of data points in
    /// individual time series selected by
    /// denominatorFilter as well as how to combine
    /// the retrieved time series together (such as
    /// when aggregating multiple streams on each
    /// resource to a single stream for each
    /// resource or when aggregating streams across
    /// all members of a group of resources).When
    /// computing ratios, the aggregations and
    /// denominator_aggregations fields must use the
    /// same alignment period and produce time
    /// series that have the same periodicity and
    /// labels.This field is similar to the one in
    /// the MetricService.ListTimeSeries request. It
    /// is advisable to use the ListTimeSeries
    /// method when debugging this field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("denominatorAggregations")]
    public IList<V1beta2AlertPolicySpecInitProviderConditionsConditionThresholdDenominatorAggregations>? DenominatorAggregations { get; set; }

    /// <summary>
    /// A filter that identifies a time series that
    /// should be used as the denominator of a ratio
    /// that will be compared with the threshold. If
    /// a denominator_filter is specified, the time
    /// series specified by the filter field will be
    /// used as the numerator.The filter is similar
    /// to the one that is specified in the
    /// MetricService.ListTimeSeries request (that
    /// call is useful to verify the time series
    /// that will be retrieved / processed) and must
    /// specify the metric type and optionally may
    /// contain restrictions on resource type,
    /// resource labels, and metric labels. This
    /// field may not exceed 2048 Unicode characters
    /// in length.
    /// </summary>
    [JsonPropertyName("denominatorFilter")]
    public string? DenominatorFilter { get; set; }

    /// <summary>
    /// The amount of time that a time series must
    /// violate the threshold to be considered
    /// failing. Currently, only values that are a
    /// multiple of a minute--e.g., 0, 60, 120, or
    /// 300 seconds--are supported. If an invalid
    /// value is given, an error will be returned.
    /// When choosing a duration, it is useful to
    /// keep in mind the frequency of the underlying
    /// time series data (which may also be affected
    /// by any alignments specified in the
    /// aggregations field); a good duration is long
    /// enough so that a single outlier does not
    /// generate spurious alerts, but short enough
    /// that unhealthy states are detected and
    /// alerted on quickly.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// A condition control that determines how
    /// metric-threshold conditions are evaluated when
    /// data stops arriving.
    /// Possible values are: EVALUATION_MISSING_DATA_INACTIVE, EVALUATION_MISSING_DATA_ACTIVE, EVALUATION_MISSING_DATA_NO_OP.
    /// </summary>
    [JsonPropertyName("evaluationMissingData")]
    public string? EvaluationMissingData { get; set; }

    /// <summary>
    /// A filter that identifies which time series
    /// should be compared with the threshold.The
    /// filter is similar to the one that is
    /// specified in the
    /// MetricService.ListTimeSeries request (that
    /// call is useful to verify the time series
    /// that will be retrieved / processed) and must
    /// specify the metric type and optionally may
    /// contain restrictions on resource type,
    /// resource labels, and metric labels. This
    /// field may not exceed 2048 Unicode characters
    /// in length.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>
    /// When this field is present, the MetricThreshold
    /// condition forecasts whether the time series is
    /// predicted to violate the threshold within the
    /// forecastHorizon. When this field is not set, the
    /// MetricThreshold tests the current value of the
    /// timeseries against the threshold.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("forecastOptions")]
    public V1beta2AlertPolicySpecInitProviderConditionsConditionThresholdForecastOptions? ForecastOptions { get; set; }

    /// <summary>
    /// A value against which to compare the time
    /// series.
    /// </summary>
    [JsonPropertyName("thresholdValue")]
    public double? ThresholdValue { get; set; }

    /// <summary>
    /// The number/percent of time series for which
    /// the comparison must hold in order for the
    /// condition to trigger. If unspecified, then
    /// the condition will trigger if the comparison
    /// is true for any of the time series that have
    /// been identified by filter and aggregations,
    /// or by the ratio, if denominator_filter and
    /// denominator_aggregations are specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trigger")]
    public V1beta2AlertPolicySpecInitProviderConditionsConditionThresholdTrigger? Trigger { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderConditions
{
    /// <summary>
    /// A condition that checks that a time series
    /// continues to receive new data points.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionAbsent")]
    public V1beta2AlertPolicySpecInitProviderConditionsConditionAbsent? ConditionAbsent { get; set; }

    /// <summary>
    /// A condition that checks for log messages matching given constraints.
    /// If set, no other conditions can be present.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionMatchedLog")]
    public V1beta2AlertPolicySpecInitProviderConditionsConditionMatchedLog? ConditionMatchedLog { get; set; }

    /// <summary>
    /// A Monitoring Query Language query that outputs a boolean stream
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionMonitoringQueryLanguage")]
    public V1beta2AlertPolicySpecInitProviderConditionsConditionMonitoringQueryLanguage? ConditionMonitoringQueryLanguage { get; set; }

    /// <summary>
    /// A condition type that allows alert policies to be defined using
    /// Prometheus Query Language (PromQL).
    /// The PrometheusQueryLanguageCondition message contains information
    /// from a Prometheus alerting rule and its associated rule group.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionPrometheusQueryLanguage")]
    public V1beta2AlertPolicySpecInitProviderConditionsConditionPrometheusQueryLanguage? ConditionPrometheusQueryLanguage { get; set; }

    /// <summary>
    /// A condition that allows alerting policies to be defined using GoogleSQL.
    /// SQL conditions examine a sliding window of logs using GoogleSQL.
    /// Alert policies with SQL conditions may incur additional billing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionSql")]
    public V1beta2AlertPolicySpecInitProviderConditionsConditionSql? ConditionSql { get; set; }

    /// <summary>
    /// A condition that compares a time series against a
    /// threshold.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionThreshold")]
    public V1beta2AlertPolicySpecInitProviderConditionsConditionThreshold? ConditionThreshold { get; set; }

    /// <summary>
    /// A short name or phrase used to identify the
    /// condition in dashboards, notifications, and
    /// incidents. To avoid confusion, don&apos;t use the same
    /// display name for multiple conditions in the same
    /// policy.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderDocumentationLinks
{
    /// <summary>A short display name for the link. The display name must not be empty or exceed 63 characters. Example: &quot;playbook&quot;.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The url of a webpage. A url can be templatized by using variables in the path or the query parameters. The total length of a URL should not exceed 2083 characters before and after variable expansion. Example: &quot;https://my_domain.com/playbook?name=${resource.name}&quot;.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Documentation that is included with notifications and incidents related
/// to this policy. Best practice is for the documentation to include information
/// to help responders understand, mitigate, escalate, and correct the underlying
/// problems detected by the alerting policy. Notification channels that have
/// limited capacity might not show this documentation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProviderDocumentation
{
    /// <summary>
    /// The text of the documentation, interpreted according to mimeType.
    /// The content may not exceed 8,192 Unicode characters and may not
    /// exceed more than 10,240 bytes when encoded in UTF-8 format,
    /// whichever is smaller.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// Links to content such as playbooks, repositories, and other resources. This field can contain up to 3 entries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("links")]
    public IList<V1beta2AlertPolicySpecInitProviderDocumentationLinks>? Links { get; set; }

    /// <summary>
    /// The format of the content field. Presently, only the value
    /// &quot;text/markdown&quot; is supported.
    /// </summary>
    [JsonPropertyName("mimeType")]
    public string? MimeType { get; set; }

    /// <summary>
    /// The subject line of the notification. The subject line may not
    /// exceed 10,240 bytes. In notifications generated by this policy the contents
    /// of the subject line after variable expansion will be truncated to 255 bytes
    /// or shorter at the latest UTF-8 character boundary.
    /// </summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecInitProvider
{
    /// <summary>
    /// Control over how this alert policy&apos;s notification channels are notified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("alertStrategy")]
    public V1beta2AlertPolicySpecInitProviderAlertStrategy? AlertStrategy { get; set; }

    /// <summary>
    /// How to combine the results of multiple conditions to
    /// determine if an incident should be opened.
    /// Possible values are: AND, OR, AND_WITH_MATCHING_RESOURCE.
    /// </summary>
    [JsonPropertyName("combiner")]
    public string? Combiner { get; set; }

    /// <summary>
    /// A list of conditions for the policy. The conditions are combined by
    /// AND or OR according to the combiner field. If the combined conditions
    /// evaluate to true, then an incident is created. A policy can have from
    /// one to six conditions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AlertPolicySpecInitProviderConditions>? Conditions { get; set; }

    /// <summary>
    /// A short name or phrase used to identify the policy in
    /// dashboards, notifications, and incidents. To avoid confusion, don&apos;t use
    /// the same display name for multiple policies in the same project. The
    /// name is limited to 512 Unicode characters.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Documentation that is included with notifications and incidents related
    /// to this policy. Best practice is for the documentation to include information
    /// to help responders understand, mitigate, escalate, and correct the underlying
    /// problems detected by the alerting policy. Notification channels that have
    /// limited capacity might not show this documentation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("documentation")]
    public V1beta2AlertPolicySpecInitProviderDocumentation? Documentation { get; set; }

    /// <summary>Whether or not the policy is enabled. The default is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Identifies the notification channels to which notifications should be
    /// sent when incidents are opened or closed or when new violations occur
    /// on an already opened incident. Each element of this array corresponds
    /// to the name field in each of the NotificationChannel objects that are
    /// returned from the notificationChannels.list method. The syntax of the
    /// entries in this field is
    /// projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]
    /// </summary>
    [JsonPropertyName("notificationChannels")]
    public IList<string>? NotificationChannels { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The severity of an alert policy indicates how important incidents generated
    /// by that policy are. The severity level will be displayed on the Incident
    /// detail page and in notifications.
    /// Possible values are: CRITICAL, ERROR, WARNING.
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>
    /// This field is intended to be used for organizing and identifying the AlertPolicy
    /// objects.The field can contain up to 64 entries. Each key and value is limited
    /// to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values
    /// can contain only lowercase letters, numerals, underscores, and dashes. Keys
    /// must begin with a letter.
    /// </summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AlertPolicySpecManagementPoliciesEnum>))]
public enum V1beta2AlertPolicySpecManagementPoliciesEnum
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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AlertPolicySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2AlertPolicySpecProviderConfigRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2AlertPolicySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2AlertPolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2AlertPolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2AlertPolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2AlertPolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>AlertPolicySpec defines the desired state of AlertPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicySpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta2AlertPolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2AlertPolicySpecForProvider ForProvider { get; set; }

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
    public V1beta2AlertPolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta2AlertPolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2AlertPolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2AlertPolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderAlertStrategyNotificationChannelStrategy
{
    /// <summary>
    /// The notification channels that these settings apply to. Each of these
    /// correspond to the name field in one of the NotificationChannel objects
    /// referenced in the notification_channels field of this AlertPolicy. The format is
    /// projects/[PROJECT_ID_OR_NUMBER]/notificationChannels/[CHANNEL_ID]
    /// </summary>
    [JsonPropertyName("notificationChannelNames")]
    public IList<string>? NotificationChannelNames { get; set; }

    /// <summary>The frequency at which to send reminder notifications for open incidents.</summary>
    [JsonPropertyName("renotifyInterval")]
    public string? RenotifyInterval { get; set; }
}

/// <summary>
/// Required for alert policies with a LogMatch condition.
/// This limit is not implemented for alert policies that are not log-based.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderAlertStrategyNotificationRateLimit
{
    /// <summary>
    /// Not more than one notification per period.
    /// A duration in seconds with up to nine fractional digits, terminated by &apos;s&apos;. Example &quot;60.5s&quot;.
    /// </summary>
    [JsonPropertyName("period")]
    public string? Period { get; set; }
}

/// <summary>
/// Control over how this alert policy&apos;s notification channels are notified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderAlertStrategy
{
    /// <summary>If an alert policy that was active has no data for this long, any open incidents will close.</summary>
    [JsonPropertyName("autoClose")]
    public string? AutoClose { get; set; }

    /// <summary>
    /// Control over how the notification channels in notification_channels
    /// are notified when this alert fires, on a per-channel basis.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("notificationChannelStrategy")]
    public IList<V1beta2AlertPolicyStatusAtProviderAlertStrategyNotificationChannelStrategy>? NotificationChannelStrategy { get; set; }

    /// <summary>
    /// Control when notifications will be sent out.
    /// Each value may be one of: NOTIFICATION_PROMPT_UNSPECIFIED, OPENED, CLOSED.
    /// </summary>
    [JsonPropertyName("notificationPrompts")]
    public IList<string>? NotificationPrompts { get; set; }

    /// <summary>
    /// Required for alert policies with a LogMatch condition.
    /// This limit is not implemented for alert policies that are not log-based.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("notificationRateLimit")]
    public V1beta2AlertPolicyStatusAtProviderAlertStrategyNotificationRateLimit? NotificationRateLimit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionAbsentAggregations
{
    /// <summary>
    /// The alignment period for per-time
    /// series alignment. If present,
    /// alignmentPeriod must be at least
    /// 60 seconds. After per-time series
    /// alignment, each time series will
    /// contain data points only on the
    /// period boundaries. If
    /// perSeriesAligner is not specified
    /// or equals ALIGN_NONE, then this
    /// field is ignored. If
    /// perSeriesAligner is specified and
    /// does not equal ALIGN_NONE, then
    /// this field must be defined;
    /// otherwise an error is returned.
    /// </summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>
    /// The approach to be used to combine
    /// time series. Not all reducer
    /// functions may be applied to all
    /// time series, depending on the
    /// metric type and the value type of
    /// the original time series.
    /// Reduction may change the metric
    /// type of value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.
    /// </summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>
    /// The set of fields to preserve when
    /// crossSeriesReducer is specified.
    /// The groupByFields determine how
    /// the time series are partitioned
    /// into subsets prior to applying the
    /// aggregation function. Each subset
    /// contains time series that have the
    /// same value for each of the
    /// grouping fields. Each individual
    /// time series is a member of exactly
    /// one subset. The crossSeriesReducer
    /// is applied to each subset of time
    /// series. It is not possible to
    /// reduce across different resource
    /// types, so this field implicitly
    /// contains resource.type. Fields not
    /// specified in groupByFields are
    /// aggregated away. If groupByFields
    /// is not specified and all the time
    /// series have the same resource
    /// type, then the time series are
    /// aggregated into a single output
    /// time series. If crossSeriesReducer
    /// is not defined, this field is
    /// ignored.
    /// </summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>
    /// The approach to be used to align
    /// individual time series. Not all
    /// alignment functions may be applied
    /// to all time series, depending on
    /// the metric type and value type of
    /// the original time series.
    /// Alignment may change the metric
    /// type or the value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.
    /// </summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary>
/// The number/percent of time series for which
/// the comparison must hold in order for the
/// condition to trigger. If unspecified, then
/// the condition will trigger if the comparison
/// is true for any of the time series that have
/// been identified by filter and aggregations,
/// or by the ratio, if denominator_filter and
/// denominator_aggregations are specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionAbsentTrigger
{
    /// <summary>
    /// The absolute number of time series
    /// that must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>
    /// The percentage of time series that
    /// must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>
/// A condition that checks that a time series
/// continues to receive new data points.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionAbsent
{
    /// <summary>
    /// Specifies the alignment of data points in
    /// individual time series as well as how to
    /// combine the retrieved time series together
    /// (such as when aggregating multiple streams
    /// on each resource to a single stream for each
    /// resource or when aggregating streams across
    /// all members of a group of resources).
    /// Multiple aggregations are applied in the
    /// order specified.This field is similar to the
    /// one in the MetricService.ListTimeSeries
    /// request. It is advisable to use the
    /// ListTimeSeries method when debugging this
    /// field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aggregations")]
    public IList<V1beta2AlertPolicyStatusAtProviderConditionsConditionAbsentAggregations>? Aggregations { get; set; }

    /// <summary>
    /// The amount of time that a time series must
    /// violate the threshold to be considered
    /// failing. Currently, only values that are a
    /// multiple of a minute--e.g., 0, 60, 120, or
    /// 300 seconds--are supported. If an invalid
    /// value is given, an error will be returned.
    /// When choosing a duration, it is useful to
    /// keep in mind the frequency of the underlying
    /// time series data (which may also be affected
    /// by any alignments specified in the
    /// aggregations field); a good duration is long
    /// enough so that a single outlier does not
    /// generate spurious alerts, but short enough
    /// that unhealthy states are detected and
    /// alerted on quickly.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// A filter that identifies which time series
    /// should be compared with the threshold.The
    /// filter is similar to the one that is
    /// specified in the
    /// MetricService.ListTimeSeries request (that
    /// call is useful to verify the time series
    /// that will be retrieved / processed) and must
    /// specify the metric type and optionally may
    /// contain restrictions on resource type,
    /// resource labels, and metric labels. This
    /// field may not exceed 2048 Unicode characters
    /// in length.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>
    /// The number/percent of time series for which
    /// the comparison must hold in order for the
    /// condition to trigger. If unspecified, then
    /// the condition will trigger if the comparison
    /// is true for any of the time series that have
    /// been identified by filter and aggregations,
    /// or by the ratio, if denominator_filter and
    /// denominator_aggregations are specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trigger")]
    public V1beta2AlertPolicyStatusAtProviderConditionsConditionAbsentTrigger? Trigger { get; set; }
}

/// <summary>
/// A condition that checks for log messages matching given constraints.
/// If set, no other conditions can be present.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionMatchedLog
{
    /// <summary>
    /// A filter that identifies which time series
    /// should be compared with the threshold.The
    /// filter is similar to the one that is
    /// specified in the
    /// MetricService.ListTimeSeries request (that
    /// call is useful to verify the time series
    /// that will be retrieved / processed) and must
    /// specify the metric type and optionally may
    /// contain restrictions on resource type,
    /// resource labels, and metric labels. This
    /// field may not exceed 2048 Unicode characters
    /// in length.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>
    /// A map from a label key to an extractor expression, which is used to
    /// extract the value for this label key. Each entry in this map is
    /// a specification for how data should be extracted from log entries that
    /// match filter. Each combination of extracted values is treated as
    /// a separate rule for the purposes of triggering notifications.
    /// Label keys and corresponding values can be used in notifications
    /// generated by this condition.
    /// </summary>
    [JsonPropertyName("labelExtractors")]
    public IDictionary<string, string>? LabelExtractors { get; set; }
}

/// <summary>
/// The number/percent of time series for which
/// the comparison must hold in order for the
/// condition to trigger. If unspecified, then
/// the condition will trigger if the comparison
/// is true for any of the time series that have
/// been identified by filter and aggregations,
/// or by the ratio, if denominator_filter and
/// denominator_aggregations are specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionMonitoringQueryLanguageTrigger
{
    /// <summary>
    /// The absolute number of time series
    /// that must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>
    /// The percentage of time series that
    /// must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>
/// A Monitoring Query Language query that outputs a boolean stream
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionMonitoringQueryLanguage
{
    /// <summary>
    /// The amount of time that a time series must
    /// violate the threshold to be considered
    /// failing. Currently, only values that are a
    /// multiple of a minute--e.g., 0, 60, 120, or
    /// 300 seconds--are supported. If an invalid
    /// value is given, an error will be returned.
    /// When choosing a duration, it is useful to
    /// keep in mind the frequency of the underlying
    /// time series data (which may also be affected
    /// by any alignments specified in the
    /// aggregations field); a good duration is long
    /// enough so that a single outlier does not
    /// generate spurious alerts, but short enough
    /// that unhealthy states are detected and
    /// alerted on quickly.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// A condition control that determines how
    /// metric-threshold conditions are evaluated when
    /// data stops arriving.
    /// Possible values are: EVALUATION_MISSING_DATA_INACTIVE, EVALUATION_MISSING_DATA_ACTIVE, EVALUATION_MISSING_DATA_NO_OP.
    /// </summary>
    [JsonPropertyName("evaluationMissingData")]
    public string? EvaluationMissingData { get; set; }

    /// <summary>
    /// The Log Analytics SQL query to run, as a string.  The query must
    /// conform to the required shape. Specifically, the query must not try to
    /// filter the input by time.  A filter will automatically be applied
    /// to filter the input so that the query receives all rows received
    /// since the last time the query was run.
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// The number/percent of time series for which
    /// the comparison must hold in order for the
    /// condition to trigger. If unspecified, then
    /// the condition will trigger if the comparison
    /// is true for any of the time series that have
    /// been identified by filter and aggregations,
    /// or by the ratio, if denominator_filter and
    /// denominator_aggregations are specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trigger")]
    public V1beta2AlertPolicyStatusAtProviderConditionsConditionMonitoringQueryLanguageTrigger? Trigger { get; set; }
}

/// <summary>
/// A condition type that allows alert policies to be defined using
/// Prometheus Query Language (PromQL).
/// The PrometheusQueryLanguageCondition message contains information
/// from a Prometheus alerting rule and its associated rule group.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionPrometheusQueryLanguage
{
    /// <summary>
    /// The alerting rule name of this alert in the corresponding Prometheus
    /// configuration file.
    /// Some external tools may require this field to be populated correctly
    /// in order to refer to the original Prometheus configuration file.
    /// The rule group name and the alert name are necessary to update the
    /// relevant AlertPolicies in case the definition of the rule group changes
    /// in the future.
    /// This field is optional. If this field is not empty, then it must be a
    /// valid Prometheus label name.
    /// </summary>
    [JsonPropertyName("alertRule")]
    public string? AlertRule { get; set; }

    /// <summary>
    /// Whether to disable metric existence validation for this condition.
    /// Users with the monitoring.alertPolicyViewer role are able to see the
    /// name of the non-existent metric in the alerting policy condition.
    /// </summary>
    [JsonPropertyName("disableMetricValidation")]
    public bool? DisableMetricValidation { get; set; }

    /// <summary>
    /// The amount of time that a time series must
    /// violate the threshold to be considered
    /// failing. Currently, only values that are a
    /// multiple of a minute--e.g., 0, 60, 120, or
    /// 300 seconds--are supported. If an invalid
    /// value is given, an error will be returned.
    /// When choosing a duration, it is useful to
    /// keep in mind the frequency of the underlying
    /// time series data (which may also be affected
    /// by any alignments specified in the
    /// aggregations field); a good duration is long
    /// enough so that a single outlier does not
    /// generate spurious alerts, but short enough
    /// that unhealthy states are detected and
    /// alerted on quickly.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// How often this rule should be evaluated. Must be a positive multiple
    /// of 30 seconds or missing. The default value is 30 seconds. If this
    /// PrometheusQueryLanguageCondition was generated from a Prometheus
    /// alerting rule, then this value should be taken from the enclosing
    /// rule group.
    /// </summary>
    [JsonPropertyName("evaluationInterval")]
    public string? EvaluationInterval { get; set; }

    /// <summary>
    /// Labels to add to or overwrite in the PromQL query result. Label names
    /// must be valid.
    /// Label values can be templatized by using variables. The only available
    /// variable names are the names of the labels in the PromQL result,
    /// although label names beginning with __ (two &quot;_&quot;) are reserved for
    /// internal use. &quot;labels&quot; may be empty. This field is intended to be used
    /// for organizing and identifying the AlertPolicy.
    /// </summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>
    /// The Log Analytics SQL query to run, as a string.  The query must
    /// conform to the required shape. Specifically, the query must not try to
    /// filter the input by time.  A filter will automatically be applied
    /// to filter the input so that the query receives all rows received
    /// since the last time the query was run.
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// The rule group name of this alert in the corresponding Prometheus
    /// configuration file.
    /// Some external tools may require this field to be populated correctly
    /// in order to refer to the original Prometheus configuration file.
    /// The rule group name and the alert name are necessary to update the
    /// relevant AlertPolicies in case the definition of the rule group changes
    /// in the future. This field is optional.
    /// </summary>
    [JsonPropertyName("ruleGroup")]
    public string? RuleGroup { get; set; }
}

/// <summary>
/// A test that uses an alerting result in a boolean column produced by the SQL query.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionSqlBooleanTest
{
    /// <summary>
    /// The name of the column containing the boolean value. If the value in a row is
    /// NULL, that row is ignored.
    /// </summary>
    [JsonPropertyName("column")]
    public string? Column { get; set; }
}

/// <summary>
/// The time of day (in UTC) at which the query should run. If left
/// unspecified, the server picks an arbitrary time of day and runs
/// the query at the same time each day.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionSqlDailyExecutionTime
{
    /// <summary>
    /// Hours of a day in 24 hour format. Must be greater than or equal
    /// to 0 and typically must be less than or equal to 23. An API may
    /// choose to allow the value &quot;24:00:00&quot; for scenarios like business
    /// closing time.
    /// </summary>
    [JsonPropertyName("hours")]
    public double? Hours { get; set; }

    /// <summary>
    /// Minutes of an hour. Must be greater than or equal to 0 and
    /// less than or equal to 59.
    /// </summary>
    [JsonPropertyName("minutes")]
    public double? Minutes { get; set; }

    /// <summary>
    /// Fractions of seconds, in nanoseconds. Must be greater than or
    /// equal to 0 and less than or equal to 999,999,999.
    /// </summary>
    [JsonPropertyName("nanos")]
    public double? Nanos { get; set; }

    /// <summary>
    /// Seconds of a minute. Must be greater than or equal to 0 and
    /// typically must be less than or equal to 59. An API may allow the
    /// value 60 if it allows leap-seconds.
    /// </summary>
    [JsonPropertyName("seconds")]
    public double? Seconds { get; set; }
}

/// <summary>
/// Used to schedule the query to run every so many days.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionSqlDaily
{
    /// <summary>
    /// The time of day (in UTC) at which the query should run. If left
    /// unspecified, the server picks an arbitrary time of day and runs
    /// the query at the same time each day.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("executionTime")]
    public V1beta2AlertPolicyStatusAtProviderConditionsConditionSqlDailyExecutionTime? ExecutionTime { get; set; }

    /// <summary>
    /// Number of minutes between runs. The interval must be greater than or
    /// equal to 5 minutes and less than or equal to 1440 minutes.
    /// </summary>
    [JsonPropertyName("periodicity")]
    public double? Periodicity { get; set; }
}

/// <summary>
/// Used to schedule the query to run every so many hours.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionSqlHourly
{
    /// <summary>
    /// The number of minutes after the hour (in UTC) to run the query.
    /// Must be greater than or equal to 0 minutes and less than or equal to
    /// 59 minutes.  If left unspecified, then an arbitrary offset is used.
    /// </summary>
    [JsonPropertyName("minuteOffset")]
    public double? MinuteOffset { get; set; }

    /// <summary>
    /// Number of minutes between runs. The interval must be greater than or
    /// equal to 5 minutes and less than or equal to 1440 minutes.
    /// </summary>
    [JsonPropertyName("periodicity")]
    public double? Periodicity { get; set; }
}

/// <summary>
/// Minutes of an hour. Must be greater than or equal to 0 and
/// less than or equal to 59.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionSqlMinutes
{
    /// <summary>
    /// Number of minutes between runs. The interval must be greater than or
    /// equal to 5 minutes and less than or equal to 1440 minutes.
    /// </summary>
    [JsonPropertyName("periodicity")]
    public double? Periodicity { get; set; }
}

/// <summary>
/// A test that checks if the number of rows in the result set violates some threshold.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionSqlRowCountTest
{
    /// <summary>
    /// The comparison to apply between the time
    /// series (indicated by filter and aggregation)
    /// and the threshold (indicated by
    /// threshold_value). The comparison is applied
    /// on each time series, with the time series on
    /// the left-hand side and the threshold on the
    /// right-hand side. Only COMPARISON_LT and
    /// COMPARISON_GT are supported currently.
    /// Possible values are: COMPARISON_GT, COMPARISON_GE, COMPARISON_LT, COMPARISON_LE, COMPARISON_EQ, COMPARISON_NE.
    /// </summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>The value against which to compare the row count.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }
}

/// <summary>
/// A condition that allows alerting policies to be defined using GoogleSQL.
/// SQL conditions examine a sliding window of logs using GoogleSQL.
/// Alert policies with SQL conditions may incur additional billing.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionSql
{
    /// <summary>
    /// A test that uses an alerting result in a boolean column produced by the SQL query.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("booleanTest")]
    public V1beta2AlertPolicyStatusAtProviderConditionsConditionSqlBooleanTest? BooleanTest { get; set; }

    /// <summary>
    /// Used to schedule the query to run every so many days.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("daily")]
    public V1beta2AlertPolicyStatusAtProviderConditionsConditionSqlDaily? Daily { get; set; }

    /// <summary>
    /// Used to schedule the query to run every so many hours.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("hourly")]
    public V1beta2AlertPolicyStatusAtProviderConditionsConditionSqlHourly? Hourly { get; set; }

    /// <summary>
    /// Minutes of an hour. Must be greater than or equal to 0 and
    /// less than or equal to 59.
    /// </summary>
    [JsonPropertyName("minutes")]
    public V1beta2AlertPolicyStatusAtProviderConditionsConditionSqlMinutes? Minutes { get; set; }

    /// <summary>
    /// The Log Analytics SQL query to run, as a string.  The query must
    /// conform to the required shape. Specifically, the query must not try to
    /// filter the input by time.  A filter will automatically be applied
    /// to filter the input so that the query receives all rows received
    /// since the last time the query was run.
    /// </summary>
    [JsonPropertyName("query")]
    public string? Query { get; set; }

    /// <summary>
    /// A test that checks if the number of rows in the result set violates some threshold.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("rowCountTest")]
    public V1beta2AlertPolicyStatusAtProviderConditionsConditionSqlRowCountTest? RowCountTest { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionThresholdAggregations
{
    /// <summary>
    /// The alignment period for per-time
    /// series alignment. If present,
    /// alignmentPeriod must be at least
    /// 60 seconds. After per-time series
    /// alignment, each time series will
    /// contain data points only on the
    /// period boundaries. If
    /// perSeriesAligner is not specified
    /// or equals ALIGN_NONE, then this
    /// field is ignored. If
    /// perSeriesAligner is specified and
    /// does not equal ALIGN_NONE, then
    /// this field must be defined;
    /// otherwise an error is returned.
    /// </summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>
    /// The approach to be used to combine
    /// time series. Not all reducer
    /// functions may be applied to all
    /// time series, depending on the
    /// metric type and the value type of
    /// the original time series.
    /// Reduction may change the metric
    /// type of value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.
    /// </summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>
    /// The set of fields to preserve when
    /// crossSeriesReducer is specified.
    /// The groupByFields determine how
    /// the time series are partitioned
    /// into subsets prior to applying the
    /// aggregation function. Each subset
    /// contains time series that have the
    /// same value for each of the
    /// grouping fields. Each individual
    /// time series is a member of exactly
    /// one subset. The crossSeriesReducer
    /// is applied to each subset of time
    /// series. It is not possible to
    /// reduce across different resource
    /// types, so this field implicitly
    /// contains resource.type. Fields not
    /// specified in groupByFields are
    /// aggregated away. If groupByFields
    /// is not specified and all the time
    /// series have the same resource
    /// type, then the time series are
    /// aggregated into a single output
    /// time series. If crossSeriesReducer
    /// is not defined, this field is
    /// ignored.
    /// </summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>
    /// The approach to be used to align
    /// individual time series. Not all
    /// alignment functions may be applied
    /// to all time series, depending on
    /// the metric type and value type of
    /// the original time series.
    /// Alignment may change the metric
    /// type or the value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.
    /// </summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionThresholdDenominatorAggregations
{
    /// <summary>
    /// The alignment period for per-time
    /// series alignment. If present,
    /// alignmentPeriod must be at least
    /// 60 seconds. After per-time series
    /// alignment, each time series will
    /// contain data points only on the
    /// period boundaries. If
    /// perSeriesAligner is not specified
    /// or equals ALIGN_NONE, then this
    /// field is ignored. If
    /// perSeriesAligner is specified and
    /// does not equal ALIGN_NONE, then
    /// this field must be defined;
    /// otherwise an error is returned.
    /// </summary>
    [JsonPropertyName("alignmentPeriod")]
    public string? AlignmentPeriod { get; set; }

    /// <summary>
    /// The approach to be used to combine
    /// time series. Not all reducer
    /// functions may be applied to all
    /// time series, depending on the
    /// metric type and the value type of
    /// the original time series.
    /// Reduction may change the metric
    /// type of value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: REDUCE_NONE, REDUCE_MEAN, REDUCE_MIN, REDUCE_MAX, REDUCE_SUM, REDUCE_STDDEV, REDUCE_COUNT, REDUCE_COUNT_TRUE, REDUCE_COUNT_FALSE, REDUCE_FRACTION_TRUE, REDUCE_PERCENTILE_99, REDUCE_PERCENTILE_95, REDUCE_PERCENTILE_50, REDUCE_PERCENTILE_05.
    /// </summary>
    [JsonPropertyName("crossSeriesReducer")]
    public string? CrossSeriesReducer { get; set; }

    /// <summary>
    /// The set of fields to preserve when
    /// crossSeriesReducer is specified.
    /// The groupByFields determine how
    /// the time series are partitioned
    /// into subsets prior to applying the
    /// aggregation function. Each subset
    /// contains time series that have the
    /// same value for each of the
    /// grouping fields. Each individual
    /// time series is a member of exactly
    /// one subset. The crossSeriesReducer
    /// is applied to each subset of time
    /// series. It is not possible to
    /// reduce across different resource
    /// types, so this field implicitly
    /// contains resource.type. Fields not
    /// specified in groupByFields are
    /// aggregated away. If groupByFields
    /// is not specified and all the time
    /// series have the same resource
    /// type, then the time series are
    /// aggregated into a single output
    /// time series. If crossSeriesReducer
    /// is not defined, this field is
    /// ignored.
    /// </summary>
    [JsonPropertyName("groupByFields")]
    public IList<string>? GroupByFields { get; set; }

    /// <summary>
    /// The approach to be used to align
    /// individual time series. Not all
    /// alignment functions may be applied
    /// to all time series, depending on
    /// the metric type and value type of
    /// the original time series.
    /// Alignment may change the metric
    /// type or the value type of the time
    /// series.Time series data must be
    /// aligned in order to perform cross-
    /// time series reduction. If
    /// crossSeriesReducer is specified,
    /// then perSeriesAligner must be
    /// specified and not equal ALIGN_NONE
    /// and alignmentPeriod must be
    /// specified; otherwise, an error is
    /// returned.
    /// Possible values are: ALIGN_NONE, ALIGN_DELTA, ALIGN_RATE, ALIGN_INTERPOLATE, ALIGN_NEXT_OLDER, ALIGN_MIN, ALIGN_MAX, ALIGN_MEAN, ALIGN_COUNT, ALIGN_SUM, ALIGN_STDDEV, ALIGN_COUNT_TRUE, ALIGN_COUNT_FALSE, ALIGN_FRACTION_TRUE, ALIGN_PERCENTILE_99, ALIGN_PERCENTILE_95, ALIGN_PERCENTILE_50, ALIGN_PERCENTILE_05, ALIGN_PERCENT_CHANGE.
    /// </summary>
    [JsonPropertyName("perSeriesAligner")]
    public string? PerSeriesAligner { get; set; }
}

/// <summary>
/// When this field is present, the MetricThreshold
/// condition forecasts whether the time series is
/// predicted to violate the threshold within the
/// forecastHorizon. When this field is not set, the
/// MetricThreshold tests the current value of the
/// timeseries against the threshold.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionThresholdForecastOptions
{
    /// <summary>
    /// The length of time into the future to forecast
    /// whether a timeseries will violate the threshold.
    /// If the predicted value is found to violate the
    /// threshold, and the violation is observed in all
    /// forecasts made for the Configured duration,
    /// then the timeseries is considered to be failing.
    /// </summary>
    [JsonPropertyName("forecastHorizon")]
    public string? ForecastHorizon { get; set; }
}

/// <summary>
/// The number/percent of time series for which
/// the comparison must hold in order for the
/// condition to trigger. If unspecified, then
/// the condition will trigger if the comparison
/// is true for any of the time series that have
/// been identified by filter and aggregations,
/// or by the ratio, if denominator_filter and
/// denominator_aggregations are specified.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionThresholdTrigger
{
    /// <summary>
    /// The absolute number of time series
    /// that must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>
    /// The percentage of time series that
    /// must fail the predicate for the
    /// condition to be triggered.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>
/// A condition that compares a time series against a
/// threshold.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditionsConditionThreshold
{
    /// <summary>
    /// Specifies the alignment of data points in
    /// individual time series as well as how to
    /// combine the retrieved time series together
    /// (such as when aggregating multiple streams
    /// on each resource to a single stream for each
    /// resource or when aggregating streams across
    /// all members of a group of resources).
    /// Multiple aggregations are applied in the
    /// order specified.This field is similar to the
    /// one in the MetricService.ListTimeSeries
    /// request. It is advisable to use the
    /// ListTimeSeries method when debugging this
    /// field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("aggregations")]
    public IList<V1beta2AlertPolicyStatusAtProviderConditionsConditionThresholdAggregations>? Aggregations { get; set; }

    /// <summary>
    /// The comparison to apply between the time
    /// series (indicated by filter and aggregation)
    /// and the threshold (indicated by
    /// threshold_value). The comparison is applied
    /// on each time series, with the time series on
    /// the left-hand side and the threshold on the
    /// right-hand side. Only COMPARISON_LT and
    /// COMPARISON_GT are supported currently.
    /// Possible values are: COMPARISON_GT, COMPARISON_GE, COMPARISON_LT, COMPARISON_LE, COMPARISON_EQ, COMPARISON_NE.
    /// </summary>
    [JsonPropertyName("comparison")]
    public string? Comparison { get; set; }

    /// <summary>
    /// Specifies the alignment of data points in
    /// individual time series selected by
    /// denominatorFilter as well as how to combine
    /// the retrieved time series together (such as
    /// when aggregating multiple streams on each
    /// resource to a single stream for each
    /// resource or when aggregating streams across
    /// all members of a group of resources).When
    /// computing ratios, the aggregations and
    /// denominator_aggregations fields must use the
    /// same alignment period and produce time
    /// series that have the same periodicity and
    /// labels.This field is similar to the one in
    /// the MetricService.ListTimeSeries request. It
    /// is advisable to use the ListTimeSeries
    /// method when debugging this field.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("denominatorAggregations")]
    public IList<V1beta2AlertPolicyStatusAtProviderConditionsConditionThresholdDenominatorAggregations>? DenominatorAggregations { get; set; }

    /// <summary>
    /// A filter that identifies a time series that
    /// should be used as the denominator of a ratio
    /// that will be compared with the threshold. If
    /// a denominator_filter is specified, the time
    /// series specified by the filter field will be
    /// used as the numerator.The filter is similar
    /// to the one that is specified in the
    /// MetricService.ListTimeSeries request (that
    /// call is useful to verify the time series
    /// that will be retrieved / processed) and must
    /// specify the metric type and optionally may
    /// contain restrictions on resource type,
    /// resource labels, and metric labels. This
    /// field may not exceed 2048 Unicode characters
    /// in length.
    /// </summary>
    [JsonPropertyName("denominatorFilter")]
    public string? DenominatorFilter { get; set; }

    /// <summary>
    /// The amount of time that a time series must
    /// violate the threshold to be considered
    /// failing. Currently, only values that are a
    /// multiple of a minute--e.g., 0, 60, 120, or
    /// 300 seconds--are supported. If an invalid
    /// value is given, an error will be returned.
    /// When choosing a duration, it is useful to
    /// keep in mind the frequency of the underlying
    /// time series data (which may also be affected
    /// by any alignments specified in the
    /// aggregations field); a good duration is long
    /// enough so that a single outlier does not
    /// generate spurious alerts, but short enough
    /// that unhealthy states are detected and
    /// alerted on quickly.
    /// </summary>
    [JsonPropertyName("duration")]
    public string? Duration { get; set; }

    /// <summary>
    /// A condition control that determines how
    /// metric-threshold conditions are evaluated when
    /// data stops arriving.
    /// Possible values are: EVALUATION_MISSING_DATA_INACTIVE, EVALUATION_MISSING_DATA_ACTIVE, EVALUATION_MISSING_DATA_NO_OP.
    /// </summary>
    [JsonPropertyName("evaluationMissingData")]
    public string? EvaluationMissingData { get; set; }

    /// <summary>
    /// A filter that identifies which time series
    /// should be compared with the threshold.The
    /// filter is similar to the one that is
    /// specified in the
    /// MetricService.ListTimeSeries request (that
    /// call is useful to verify the time series
    /// that will be retrieved / processed) and must
    /// specify the metric type and optionally may
    /// contain restrictions on resource type,
    /// resource labels, and metric labels. This
    /// field may not exceed 2048 Unicode characters
    /// in length.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>
    /// When this field is present, the MetricThreshold
    /// condition forecasts whether the time series is
    /// predicted to violate the threshold within the
    /// forecastHorizon. When this field is not set, the
    /// MetricThreshold tests the current value of the
    /// timeseries against the threshold.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("forecastOptions")]
    public V1beta2AlertPolicyStatusAtProviderConditionsConditionThresholdForecastOptions? ForecastOptions { get; set; }

    /// <summary>
    /// A value against which to compare the time
    /// series.
    /// </summary>
    [JsonPropertyName("thresholdValue")]
    public double? ThresholdValue { get; set; }

    /// <summary>
    /// The number/percent of time series for which
    /// the comparison must hold in order for the
    /// condition to trigger. If unspecified, then
    /// the condition will trigger if the comparison
    /// is true for any of the time series that have
    /// been identified by filter and aggregations,
    /// or by the ratio, if denominator_filter and
    /// denominator_aggregations are specified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("trigger")]
    public V1beta2AlertPolicyStatusAtProviderConditionsConditionThresholdTrigger? Trigger { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderConditions
{
    /// <summary>
    /// A condition that checks that a time series
    /// continues to receive new data points.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionAbsent")]
    public V1beta2AlertPolicyStatusAtProviderConditionsConditionAbsent? ConditionAbsent { get; set; }

    /// <summary>
    /// A condition that checks for log messages matching given constraints.
    /// If set, no other conditions can be present.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionMatchedLog")]
    public V1beta2AlertPolicyStatusAtProviderConditionsConditionMatchedLog? ConditionMatchedLog { get; set; }

    /// <summary>
    /// A Monitoring Query Language query that outputs a boolean stream
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionMonitoringQueryLanguage")]
    public V1beta2AlertPolicyStatusAtProviderConditionsConditionMonitoringQueryLanguage? ConditionMonitoringQueryLanguage { get; set; }

    /// <summary>
    /// A condition type that allows alert policies to be defined using
    /// Prometheus Query Language (PromQL).
    /// The PrometheusQueryLanguageCondition message contains information
    /// from a Prometheus alerting rule and its associated rule group.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionPrometheusQueryLanguage")]
    public V1beta2AlertPolicyStatusAtProviderConditionsConditionPrometheusQueryLanguage? ConditionPrometheusQueryLanguage { get; set; }

    /// <summary>
    /// A condition that allows alerting policies to be defined using GoogleSQL.
    /// SQL conditions examine a sliding window of logs using GoogleSQL.
    /// Alert policies with SQL conditions may incur additional billing.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionSql")]
    public V1beta2AlertPolicyStatusAtProviderConditionsConditionSql? ConditionSql { get; set; }

    /// <summary>
    /// A condition that compares a time series against a
    /// threshold.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditionThreshold")]
    public V1beta2AlertPolicyStatusAtProviderConditionsConditionThreshold? ConditionThreshold { get; set; }

    /// <summary>
    /// A short name or phrase used to identify the
    /// condition in dashboards, notifications, and
    /// incidents. To avoid confusion, don&apos;t use the same
    /// display name for multiple conditions in the same
    /// policy.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// (Output)
    /// The unique resource name for this condition.
    /// Its syntax is:
    /// projects/[PROJECT_ID]/alertPolicies/[POLICY_ID]/conditions/[CONDITION_ID]
    /// [CONDITION_ID] is assigned by Stackdriver Monitoring when
    /// the condition is created as part of a new or updated alerting
    /// policy.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderCreationRecord
{
    /// <summary>
    /// (Output)
    /// When the change occurred.
    /// </summary>
    [JsonPropertyName("mutateTime")]
    public string? MutateTime { get; set; }

    /// <summary>
    /// (Output)
    /// The email address of the user making the change.
    /// </summary>
    [JsonPropertyName("mutatedBy")]
    public string? MutatedBy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderDocumentationLinks
{
    /// <summary>A short display name for the link. The display name must not be empty or exceed 63 characters. Example: &quot;playbook&quot;.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>The url of a webpage. A url can be templatized by using variables in the path or the query parameters. The total length of a URL should not exceed 2083 characters before and after variable expansion. Example: &quot;https://my_domain.com/playbook?name=${resource.name}&quot;.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}

/// <summary>
/// Documentation that is included with notifications and incidents related
/// to this policy. Best practice is for the documentation to include information
/// to help responders understand, mitigate, escalate, and correct the underlying
/// problems detected by the alerting policy. Notification channels that have
/// limited capacity might not show this documentation.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProviderDocumentation
{
    /// <summary>
    /// The text of the documentation, interpreted according to mimeType.
    /// The content may not exceed 8,192 Unicode characters and may not
    /// exceed more than 10,240 bytes when encoded in UTF-8 format,
    /// whichever is smaller.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// Links to content such as playbooks, repositories, and other resources. This field can contain up to 3 entries.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("links")]
    public IList<V1beta2AlertPolicyStatusAtProviderDocumentationLinks>? Links { get; set; }

    /// <summary>
    /// The format of the content field. Presently, only the value
    /// &quot;text/markdown&quot; is supported.
    /// </summary>
    [JsonPropertyName("mimeType")]
    public string? MimeType { get; set; }

    /// <summary>
    /// The subject line of the notification. The subject line may not
    /// exceed 10,240 bytes. In notifications generated by this policy the contents
    /// of the subject line after variable expansion will be truncated to 255 bytes
    /// or shorter at the latest UTF-8 character boundary.
    /// </summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusAtProvider
{
    /// <summary>
    /// Control over how this alert policy&apos;s notification channels are notified.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("alertStrategy")]
    public V1beta2AlertPolicyStatusAtProviderAlertStrategy? AlertStrategy { get; set; }

    /// <summary>
    /// How to combine the results of multiple conditions to
    /// determine if an incident should be opened.
    /// Possible values are: AND, OR, AND_WITH_MATCHING_RESOURCE.
    /// </summary>
    [JsonPropertyName("combiner")]
    public string? Combiner { get; set; }

    /// <summary>
    /// A list of conditions for the policy. The conditions are combined by
    /// AND or OR according to the combiner field. If the combined conditions
    /// evaluate to true, then an incident is created. A policy can have from
    /// one to six conditions.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AlertPolicyStatusAtProviderConditions>? Conditions { get; set; }

    /// <summary>
    /// A read-only record of the creation of the alerting policy.
    /// If provided in a call to create or update, this field will
    /// be ignored.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("creationRecord")]
    public IList<V1beta2AlertPolicyStatusAtProviderCreationRecord>? CreationRecord { get; set; }

    /// <summary>
    /// A short name or phrase used to identify the policy in
    /// dashboards, notifications, and incidents. To avoid confusion, don&apos;t use
    /// the same display name for multiple policies in the same project. The
    /// name is limited to 512 Unicode characters.
    /// </summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>
    /// Documentation that is included with notifications and incidents related
    /// to this policy. Best practice is for the documentation to include information
    /// to help responders understand, mitigate, escalate, and correct the underlying
    /// problems detected by the alerting policy. Notification channels that have
    /// limited capacity might not show this documentation.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("documentation")]
    public V1beta2AlertPolicyStatusAtProviderDocumentation? Documentation { get; set; }

    /// <summary>Whether or not the policy is enabled. The default is true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>an identifier for the resource with format {{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The unique resource name for this policy.
    /// Its syntax is: projects/[PROJECT_ID]/alertPolicies/[ALERT_POLICY_ID]
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Identifies the notification channels to which notifications should be
    /// sent when incidents are opened or closed or when new violations occur
    /// on an already opened incident. Each element of this array corresponds
    /// to the name field in each of the NotificationChannel objects that are
    /// returned from the notificationChannels.list method. The syntax of the
    /// entries in this field is
    /// projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]
    /// </summary>
    [JsonPropertyName("notificationChannels")]
    public IList<string>? NotificationChannels { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>
    /// The severity of an alert policy indicates how important incidents generated
    /// by that policy are. The severity level will be displayed on the Incident
    /// detail page and in notifications.
    /// Possible values are: CRITICAL, ERROR, WARNING.
    /// </summary>
    [JsonPropertyName("severity")]
    public string? Severity { get; set; }

    /// <summary>
    /// This field is intended to be used for organizing and identifying the AlertPolicy
    /// objects.The field can contain up to 64 entries. Each key and value is limited
    /// to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values
    /// can contain only lowercase letters, numerals, underscores, and dashes. Keys
    /// must begin with a letter.
    /// </summary>
    [JsonPropertyName("userLabels")]
    public IDictionary<string, string>? UserLabels { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatusConditions
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

/// <summary>AlertPolicyStatus defines the observed state of AlertPolicy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2AlertPolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2AlertPolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2AlertPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>AlertPolicy is the Schema for the AlertPolicys API. A description of the conditions under which some aspect of your system is considered to be &quot;unhealthy&quot; and the ways to notify people or services about this state.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2AlertPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2AlertPolicySpec>, IStatus<V1beta2AlertPolicyStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "AlertPolicy";
    public const string KubeGroup = "monitoring.gcp.upbound.io";
    public const string KubePluralName = "alertpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "monitoring.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "AlertPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>AlertPolicySpec defines the desired state of AlertPolicy</summary>
    [JsonPropertyName("spec")]
    public required V1beta2AlertPolicySpec Spec { get; set; }

    /// <summary>AlertPolicyStatus defines the observed state of AlertPolicy.</summary>
    [JsonPropertyName("status")]
    public V1beta2AlertPolicyStatus? Status { get; set; }
}