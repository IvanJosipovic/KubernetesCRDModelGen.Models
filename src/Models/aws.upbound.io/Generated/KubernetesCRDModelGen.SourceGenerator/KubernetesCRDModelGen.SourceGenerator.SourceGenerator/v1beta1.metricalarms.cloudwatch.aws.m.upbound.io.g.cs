#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudwatch.aws.m.upbound.io;
/// <summary>MetricAlarm is the Schema for the MetricAlarms API. Provides a CloudWatch Metric Alarm resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MetricAlarmList : IKubernetesObject<V1ListMeta>, IItems<V1beta1MetricAlarm>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MetricAlarmList";
    public const string KubeGroup = "cloudwatch.aws.m.upbound.io";
    public const string KubePluralName = "metricalarms";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudwatch.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetricAlarmList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1MetricAlarm objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1MetricAlarm> Items { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetricAlarmSpecForProviderAlarmActionsRefsPolicyResolutionEnum>))]
public enum V1beta1MetricAlarmSpecForProviderAlarmActionsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetricAlarmSpecForProviderAlarmActionsRefsPolicyResolveEnum>))]
public enum V1beta1MetricAlarmSpecForProviderAlarmActionsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecForProviderAlarmActionsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MetricAlarmSpecForProviderAlarmActionsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MetricAlarmSpecForProviderAlarmActionsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecForProviderAlarmActionsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetricAlarmSpecForProviderAlarmActionsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetricAlarmSpecForProviderAlarmActionsSelectorPolicyResolutionEnum>))]
public enum V1beta1MetricAlarmSpecForProviderAlarmActionsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetricAlarmSpecForProviderAlarmActionsSelectorPolicyResolveEnum>))]
public enum V1beta1MetricAlarmSpecForProviderAlarmActionsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecForProviderAlarmActionsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MetricAlarmSpecForProviderAlarmActionsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MetricAlarmSpecForProviderAlarmActionsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Policy in autoscaling to populate alarmActions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecForProviderAlarmActionsSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetricAlarmSpecForProviderAlarmActionsSelectorPolicy? Policy { get; set; }
}

/// <summary>The metric to be returned, along with statistics, period, and units. Use this parameter only if this object is retrieving a metric and not performing a math expression on returned data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecForProviderMetricQueryMetric
{
    /// <summary>The dimensions for this metric.  For the list of available dimensions see the AWS documentation here.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>
    /// The name for this metric.
    /// See docs for supported metrics.
    /// </summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>
    /// The namespace for this metric. See docs for the list of namespaces.
    /// See docs for supported metrics.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Granularity in seconds of returned data points.
    /// For metrics with regular resolution, valid values are any multiple of 60.
    /// For high-resolution metrics, valid values are 1, 5, 10, 20, 30, or any multiple of 60.
    /// </summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>
    /// The statistic to apply to this metric.
    /// See docs for supported statistics.
    /// </summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>The unit for this metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecForProviderMetricQuery
{
    /// <summary>The ID of the account where the metrics are located, if this is a cross-account alarm.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>
    /// A Metrics Insights query or a metric math expression to be evaluated on the returned data.
    /// For details about Metrics Insights queries, see Metrics Insights query components and syntax in the AWS documentation.
    /// For details about metric math expressions, see Metric Math Syntax and Functions in the AWS documentation.
    /// </summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>A short name used to tie this object to the results in the response. If you are performing math expressions on this set of data, this name represents that data and can serve as a variable in the mathematical expression. The valid characters are letters, numbers, and underscore. The first character must be a lowercase letter.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A human-readable label for this metric or expression. This is especially useful if this is an expression, so that you know what the value represents.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The metric to be returned, along with statistics, period, and units. Use this parameter only if this object is retrieving a metric and not performing a math expression on returned data.</summary>
    [JsonPropertyName("metric")]
    public V1beta1MetricAlarmSpecForProviderMetricQueryMetric? Metric { get; set; }

    /// <summary>
    /// Granularity in seconds of returned data points.
    /// For metrics with regular resolution, valid values are any multiple of 60.
    /// For high-resolution metrics, valid values are 1, 5, 10, 20, 30, or any multiple of 60.
    /// </summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Specify exactly one metric_query to be true to use that metric_query result as the alarm.</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetricAlarmSpecForProviderOkActionsRefsPolicyResolutionEnum>))]
public enum V1beta1MetricAlarmSpecForProviderOkActionsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetricAlarmSpecForProviderOkActionsRefsPolicyResolveEnum>))]
public enum V1beta1MetricAlarmSpecForProviderOkActionsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecForProviderOkActionsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MetricAlarmSpecForProviderOkActionsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MetricAlarmSpecForProviderOkActionsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecForProviderOkActionsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetricAlarmSpecForProviderOkActionsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetricAlarmSpecForProviderOkActionsSelectorPolicyResolutionEnum>))]
public enum V1beta1MetricAlarmSpecForProviderOkActionsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetricAlarmSpecForProviderOkActionsSelectorPolicyResolveEnum>))]
public enum V1beta1MetricAlarmSpecForProviderOkActionsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecForProviderOkActionsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MetricAlarmSpecForProviderOkActionsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MetricAlarmSpecForProviderOkActionsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Topic in sns to populate okActions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecForProviderOkActionsSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetricAlarmSpecForProviderOkActionsSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecForProvider
{
    /// <summary>Indicates whether or not actions should be executed during any changes to the alarm&apos;s state. Defaults to true.</summary>
    [JsonPropertyName("actionsEnabled")]
    public bool? ActionsEnabled { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an ALARM state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("alarmActions")]
    public IList<string>? AlarmActions { get; set; }

    /// <summary>References to Policy in autoscaling to populate alarmActions.</summary>
    [JsonPropertyName("alarmActionsRefs")]
    public IList<V1beta1MetricAlarmSpecForProviderAlarmActionsRefs>? AlarmActionsRefs { get; set; }

    /// <summary>Selector for a list of Policy in autoscaling to populate alarmActions.</summary>
    [JsonPropertyName("alarmActionsSelector")]
    public V1beta1MetricAlarmSpecForProviderAlarmActionsSelector? AlarmActionsSelector { get; set; }

    /// <summary>The description for the alarm.</summary>
    [JsonPropertyName("alarmDescription")]
    public string? AlarmDescription { get; set; }

    /// <summary>The arithmetic operation to use when comparing the specified Statistic and Threshold. The specified Statistic value is used as the first operand. Either of the following is supported: GreaterThanOrEqualToThreshold, GreaterThanThreshold, LessThanThreshold, LessThanOrEqualToThreshold. Additionally, the values  LessThanLowerOrGreaterThanUpperThreshold, LessThanLowerThreshold, and GreaterThanUpperThreshold are used only for alarms based on anomaly detection models.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>The number of data points that must be breaching to trigger the alarm.</summary>
    [JsonPropertyName("datapointsToAlarm")]
    public double? DatapointsToAlarm { get; set; }

    /// <summary>The dimensions for the alarm&apos;s associated metric.  For the list of available dimensions see the AWS documentation here.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>
    /// Used only for alarms based on percentiles.
    /// If you specify ignore, the alarm state will not change during periods with too few data points to be statistically significant.
    /// If you specify evaluate or omit this parameter, the alarm will always be evaluated and possibly change state no matter how many data points are available.
    /// The following values are supported: ignore, and evaluate.
    /// </summary>
    [JsonPropertyName("evaluateLowSampleCountPercentiles")]
    public string? EvaluateLowSampleCountPercentiles { get; set; }

    /// <summary>The number of periods over which data is compared to the specified threshold.</summary>
    [JsonPropertyName("evaluationPeriods")]
    public double? EvaluationPeriods { get; set; }

    /// <summary>The percentile statistic for the metric associated with the alarm. Specify a value between p0.0 and p100.</summary>
    [JsonPropertyName("extendedStatistic")]
    public string? ExtendedStatistic { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an INSUFFICIENT_DATA state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("insufficientDataActions")]
    public IList<string>? InsufficientDataActions { get; set; }

    /// <summary>
    /// The name for the alarm&apos;s associated metric.
    /// See docs for supported metrics.
    /// </summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Enables you to create an alarm based on a metric math expression. You may specify at most 20.</summary>
    [JsonPropertyName("metricQuery")]
    public IList<V1beta1MetricAlarmSpecForProviderMetricQuery>? MetricQuery { get; set; }

    /// <summary>
    /// The namespace for the alarm&apos;s associated metric. See docs for the list of namespaces.
    /// See docs for supported metrics.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an OK state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("okActions")]
    public IList<string>? OkActions { get; set; }

    /// <summary>References to Topic in sns to populate okActions.</summary>
    [JsonPropertyName("okActionsRefs")]
    public IList<V1beta1MetricAlarmSpecForProviderOkActionsRefs>? OkActionsRefs { get; set; }

    /// <summary>Selector for a list of Topic in sns to populate okActions.</summary>
    [JsonPropertyName("okActionsSelector")]
    public V1beta1MetricAlarmSpecForProviderOkActionsSelector? OkActionsSelector { get; set; }

    /// <summary>
    /// The period in seconds over which the specified statistic is applied.
    /// Valid values are 10, 20, 30, or any multiple of 60.
    /// </summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// The statistic to apply to the alarm&apos;s associated metric.
    /// Either of the following is supported: SampleCount, Average, Sum, Minimum, Maximum
    /// </summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The value against which the specified statistic is compared. This parameter is required for alarms based on static thresholds, but should not be used for alarms based on anomaly detection models.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>If this is an alarm based on an anomaly detection model, make this value match the ID of the ANOMALY_DETECTION_BAND function.</summary>
    [JsonPropertyName("thresholdMetricId")]
    public string? ThresholdMetricId { get; set; }

    /// <summary>Sets how this alarm is to handle missing data points. The following values are supported: missing, ignore, breaching and notBreaching. Defaults to missing.</summary>
    [JsonPropertyName("treatMissingData")]
    public string? TreatMissingData { get; set; }

    /// <summary>The unit for the alarm&apos;s associated metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetricAlarmSpecInitProviderAlarmActionsRefsPolicyResolutionEnum>))]
public enum V1beta1MetricAlarmSpecInitProviderAlarmActionsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetricAlarmSpecInitProviderAlarmActionsRefsPolicyResolveEnum>))]
public enum V1beta1MetricAlarmSpecInitProviderAlarmActionsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecInitProviderAlarmActionsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MetricAlarmSpecInitProviderAlarmActionsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MetricAlarmSpecInitProviderAlarmActionsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecInitProviderAlarmActionsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetricAlarmSpecInitProviderAlarmActionsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetricAlarmSpecInitProviderAlarmActionsSelectorPolicyResolutionEnum>))]
public enum V1beta1MetricAlarmSpecInitProviderAlarmActionsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetricAlarmSpecInitProviderAlarmActionsSelectorPolicyResolveEnum>))]
public enum V1beta1MetricAlarmSpecInitProviderAlarmActionsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecInitProviderAlarmActionsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MetricAlarmSpecInitProviderAlarmActionsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MetricAlarmSpecInitProviderAlarmActionsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Policy in autoscaling to populate alarmActions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecInitProviderAlarmActionsSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetricAlarmSpecInitProviderAlarmActionsSelectorPolicy? Policy { get; set; }
}

/// <summary>The metric to be returned, along with statistics, period, and units. Use this parameter only if this object is retrieving a metric and not performing a math expression on returned data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecInitProviderMetricQueryMetric
{
    /// <summary>The dimensions for this metric.  For the list of available dimensions see the AWS documentation here.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>
    /// The name for this metric.
    /// See docs for supported metrics.
    /// </summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>
    /// The namespace for this metric. See docs for the list of namespaces.
    /// See docs for supported metrics.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Granularity in seconds of returned data points.
    /// For metrics with regular resolution, valid values are any multiple of 60.
    /// For high-resolution metrics, valid values are 1, 5, 10, 20, 30, or any multiple of 60.
    /// </summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>
    /// The statistic to apply to this metric.
    /// See docs for supported statistics.
    /// </summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>The unit for this metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecInitProviderMetricQuery
{
    /// <summary>The ID of the account where the metrics are located, if this is a cross-account alarm.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>
    /// A Metrics Insights query or a metric math expression to be evaluated on the returned data.
    /// For details about Metrics Insights queries, see Metrics Insights query components and syntax in the AWS documentation.
    /// For details about metric math expressions, see Metric Math Syntax and Functions in the AWS documentation.
    /// </summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>A short name used to tie this object to the results in the response. If you are performing math expressions on this set of data, this name represents that data and can serve as a variable in the mathematical expression. The valid characters are letters, numbers, and underscore. The first character must be a lowercase letter.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A human-readable label for this metric or expression. This is especially useful if this is an expression, so that you know what the value represents.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The metric to be returned, along with statistics, period, and units. Use this parameter only if this object is retrieving a metric and not performing a math expression on returned data.</summary>
    [JsonPropertyName("metric")]
    public V1beta1MetricAlarmSpecInitProviderMetricQueryMetric? Metric { get; set; }

    /// <summary>
    /// Granularity in seconds of returned data points.
    /// For metrics with regular resolution, valid values are any multiple of 60.
    /// For high-resolution metrics, valid values are 1, 5, 10, 20, 30, or any multiple of 60.
    /// </summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Specify exactly one metric_query to be true to use that metric_query result as the alarm.</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetricAlarmSpecInitProviderOkActionsRefsPolicyResolutionEnum>))]
public enum V1beta1MetricAlarmSpecInitProviderOkActionsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetricAlarmSpecInitProviderOkActionsRefsPolicyResolveEnum>))]
public enum V1beta1MetricAlarmSpecInitProviderOkActionsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecInitProviderOkActionsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MetricAlarmSpecInitProviderOkActionsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MetricAlarmSpecInitProviderOkActionsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A NamespacedReference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecInitProviderOkActionsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetricAlarmSpecInitProviderOkActionsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetricAlarmSpecInitProviderOkActionsSelectorPolicyResolutionEnum>))]
public enum V1beta1MetricAlarmSpecInitProviderOkActionsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetricAlarmSpecInitProviderOkActionsSelectorPolicyResolveEnum>))]
public enum V1beta1MetricAlarmSpecInitProviderOkActionsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecInitProviderOkActionsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1MetricAlarmSpecInitProviderOkActionsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1MetricAlarmSpecInitProviderOkActionsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Topic in sns to populate okActions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecInitProviderOkActionsSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1MetricAlarmSpecInitProviderOkActionsSelectorPolicy? Policy { get; set; }
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
public partial class V1beta1MetricAlarmSpecInitProvider
{
    /// <summary>Indicates whether or not actions should be executed during any changes to the alarm&apos;s state. Defaults to true.</summary>
    [JsonPropertyName("actionsEnabled")]
    public bool? ActionsEnabled { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an ALARM state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("alarmActions")]
    public IList<string>? AlarmActions { get; set; }

    /// <summary>References to Policy in autoscaling to populate alarmActions.</summary>
    [JsonPropertyName("alarmActionsRefs")]
    public IList<V1beta1MetricAlarmSpecInitProviderAlarmActionsRefs>? AlarmActionsRefs { get; set; }

    /// <summary>Selector for a list of Policy in autoscaling to populate alarmActions.</summary>
    [JsonPropertyName("alarmActionsSelector")]
    public V1beta1MetricAlarmSpecInitProviderAlarmActionsSelector? AlarmActionsSelector { get; set; }

    /// <summary>The description for the alarm.</summary>
    [JsonPropertyName("alarmDescription")]
    public string? AlarmDescription { get; set; }

    /// <summary>The arithmetic operation to use when comparing the specified Statistic and Threshold. The specified Statistic value is used as the first operand. Either of the following is supported: GreaterThanOrEqualToThreshold, GreaterThanThreshold, LessThanThreshold, LessThanOrEqualToThreshold. Additionally, the values  LessThanLowerOrGreaterThanUpperThreshold, LessThanLowerThreshold, and GreaterThanUpperThreshold are used only for alarms based on anomaly detection models.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>The number of data points that must be breaching to trigger the alarm.</summary>
    [JsonPropertyName("datapointsToAlarm")]
    public double? DatapointsToAlarm { get; set; }

    /// <summary>The dimensions for the alarm&apos;s associated metric.  For the list of available dimensions see the AWS documentation here.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>
    /// Used only for alarms based on percentiles.
    /// If you specify ignore, the alarm state will not change during periods with too few data points to be statistically significant.
    /// If you specify evaluate or omit this parameter, the alarm will always be evaluated and possibly change state no matter how many data points are available.
    /// The following values are supported: ignore, and evaluate.
    /// </summary>
    [JsonPropertyName("evaluateLowSampleCountPercentiles")]
    public string? EvaluateLowSampleCountPercentiles { get; set; }

    /// <summary>The number of periods over which data is compared to the specified threshold.</summary>
    [JsonPropertyName("evaluationPeriods")]
    public double? EvaluationPeriods { get; set; }

    /// <summary>The percentile statistic for the metric associated with the alarm. Specify a value between p0.0 and p100.</summary>
    [JsonPropertyName("extendedStatistic")]
    public string? ExtendedStatistic { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an INSUFFICIENT_DATA state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("insufficientDataActions")]
    public IList<string>? InsufficientDataActions { get; set; }

    /// <summary>
    /// The name for the alarm&apos;s associated metric.
    /// See docs for supported metrics.
    /// </summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Enables you to create an alarm based on a metric math expression. You may specify at most 20.</summary>
    [JsonPropertyName("metricQuery")]
    public IList<V1beta1MetricAlarmSpecInitProviderMetricQuery>? MetricQuery { get; set; }

    /// <summary>
    /// The namespace for the alarm&apos;s associated metric. See docs for the list of namespaces.
    /// See docs for supported metrics.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an OK state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("okActions")]
    public IList<string>? OkActions { get; set; }

    /// <summary>References to Topic in sns to populate okActions.</summary>
    [JsonPropertyName("okActionsRefs")]
    public IList<V1beta1MetricAlarmSpecInitProviderOkActionsRefs>? OkActionsRefs { get; set; }

    /// <summary>Selector for a list of Topic in sns to populate okActions.</summary>
    [JsonPropertyName("okActionsSelector")]
    public V1beta1MetricAlarmSpecInitProviderOkActionsSelector? OkActionsSelector { get; set; }

    /// <summary>
    /// The period in seconds over which the specified statistic is applied.
    /// Valid values are 10, 20, 30, or any multiple of 60.
    /// </summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>
    /// The statistic to apply to the alarm&apos;s associated metric.
    /// Either of the following is supported: SampleCount, Average, Sum, Minimum, Maximum
    /// </summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The value against which the specified statistic is compared. This parameter is required for alarms based on static thresholds, but should not be used for alarms based on anomaly detection models.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>If this is an alarm based on an anomaly detection model, make this value match the ID of the ANOMALY_DETECTION_BAND function.</summary>
    [JsonPropertyName("thresholdMetricId")]
    public string? ThresholdMetricId { get; set; }

    /// <summary>Sets how this alarm is to handle missing data points. The following values are supported: missing, ignore, breaching and notBreaching. Defaults to missing.</summary>
    [JsonPropertyName("treatMissingData")]
    public string? TreatMissingData { get; set; }

    /// <summary>The unit for the alarm&apos;s associated metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1MetricAlarmSpecManagementPoliciesEnum>))]
public enum V1beta1MetricAlarmSpecManagementPoliciesEnum
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecProviderConfigRef
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>MetricAlarmSpec defines the desired state of MetricAlarm</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1MetricAlarmSpecForProvider ForProvider { get; set; }

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
    public V1beta1MetricAlarmSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1MetricAlarmSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1MetricAlarmSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1MetricAlarmSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>The metric to be returned, along with statistics, period, and units. Use this parameter only if this object is retrieving a metric and not performing a math expression on returned data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmStatusAtProviderMetricQueryMetric
{
    /// <summary>The dimensions for this metric.  For the list of available dimensions see the AWS documentation here.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>
    /// The name for this metric.
    /// See docs for supported metrics.
    /// </summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>
    /// The namespace for this metric. See docs for the list of namespaces.
    /// See docs for supported metrics.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// Granularity in seconds of returned data points.
    /// For metrics with regular resolution, valid values are any multiple of 60.
    /// For high-resolution metrics, valid values are 1, 5, 10, 20, 30, or any multiple of 60.
    /// </summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>
    /// The statistic to apply to this metric.
    /// See docs for supported statistics.
    /// </summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>The unit for this metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmStatusAtProviderMetricQuery
{
    /// <summary>The ID of the account where the metrics are located, if this is a cross-account alarm.</summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>
    /// A Metrics Insights query or a metric math expression to be evaluated on the returned data.
    /// For details about Metrics Insights queries, see Metrics Insights query components and syntax in the AWS documentation.
    /// For details about metric math expressions, see Metric Math Syntax and Functions in the AWS documentation.
    /// </summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>A short name used to tie this object to the results in the response. If you are performing math expressions on this set of data, this name represents that data and can serve as a variable in the mathematical expression. The valid characters are letters, numbers, and underscore. The first character must be a lowercase letter.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A human-readable label for this metric or expression. This is especially useful if this is an expression, so that you know what the value represents.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>The metric to be returned, along with statistics, period, and units. Use this parameter only if this object is retrieving a metric and not performing a math expression on returned data.</summary>
    [JsonPropertyName("metric")]
    public V1beta1MetricAlarmStatusAtProviderMetricQueryMetric? Metric { get; set; }

    /// <summary>
    /// Granularity in seconds of returned data points.
    /// For metrics with regular resolution, valid values are any multiple of 60.
    /// For high-resolution metrics, valid values are 1, 5, 10, 20, 30, or any multiple of 60.
    /// </summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Specify exactly one metric_query to be true to use that metric_query result as the alarm.</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmStatusAtProvider
{
    /// <summary>Indicates whether or not actions should be executed during any changes to the alarm&apos;s state. Defaults to true.</summary>
    [JsonPropertyName("actionsEnabled")]
    public bool? ActionsEnabled { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an ALARM state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("alarmActions")]
    public IList<string>? AlarmActions { get; set; }

    /// <summary>The description for the alarm.</summary>
    [JsonPropertyName("alarmDescription")]
    public string? AlarmDescription { get; set; }

    /// <summary>The ARN of the CloudWatch Metric Alarm.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The arithmetic operation to use when comparing the specified Statistic and Threshold. The specified Statistic value is used as the first operand. Either of the following is supported: GreaterThanOrEqualToThreshold, GreaterThanThreshold, LessThanThreshold, LessThanOrEqualToThreshold. Additionally, the values  LessThanLowerOrGreaterThanUpperThreshold, LessThanLowerThreshold, and GreaterThanUpperThreshold are used only for alarms based on anomaly detection models.</summary>
    [JsonPropertyName("comparisonOperator")]
    public string? ComparisonOperator { get; set; }

    /// <summary>The number of data points that must be breaching to trigger the alarm.</summary>
    [JsonPropertyName("datapointsToAlarm")]
    public double? DatapointsToAlarm { get; set; }

    /// <summary>The dimensions for the alarm&apos;s associated metric.  For the list of available dimensions see the AWS documentation here.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>
    /// Used only for alarms based on percentiles.
    /// If you specify ignore, the alarm state will not change during periods with too few data points to be statistically significant.
    /// If you specify evaluate or omit this parameter, the alarm will always be evaluated and possibly change state no matter how many data points are available.
    /// The following values are supported: ignore, and evaluate.
    /// </summary>
    [JsonPropertyName("evaluateLowSampleCountPercentiles")]
    public string? EvaluateLowSampleCountPercentiles { get; set; }

    /// <summary>The number of periods over which data is compared to the specified threshold.</summary>
    [JsonPropertyName("evaluationPeriods")]
    public double? EvaluationPeriods { get; set; }

    /// <summary>The percentile statistic for the metric associated with the alarm. Specify a value between p0.0 and p100.</summary>
    [JsonPropertyName("extendedStatistic")]
    public string? ExtendedStatistic { get; set; }

    /// <summary>The ID of the health check.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an INSUFFICIENT_DATA state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("insufficientDataActions")]
    public IList<string>? InsufficientDataActions { get; set; }

    /// <summary>
    /// The name for the alarm&apos;s associated metric.
    /// See docs for supported metrics.
    /// </summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Enables you to create an alarm based on a metric math expression. You may specify at most 20.</summary>
    [JsonPropertyName("metricQuery")]
    public IList<V1beta1MetricAlarmStatusAtProviderMetricQuery>? MetricQuery { get; set; }

    /// <summary>
    /// The namespace for the alarm&apos;s associated metric. See docs for the list of namespaces.
    /// See docs for supported metrics.
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The list of actions to execute when this alarm transitions into an OK state from any other state. Each action is specified as an Amazon Resource Name (ARN).</summary>
    [JsonPropertyName("okActions")]
    public IList<string>? OkActions { get; set; }

    /// <summary>
    /// The period in seconds over which the specified statistic is applied.
    /// Valid values are 10, 20, 30, or any multiple of 60.
    /// </summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// The statistic to apply to the alarm&apos;s associated metric.
    /// Either of the following is supported: SampleCount, Average, Sum, Minimum, Maximum
    /// </summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>The value against which the specified statistic is compared. This parameter is required for alarms based on static thresholds, but should not be used for alarms based on anomaly detection models.</summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>If this is an alarm based on an anomaly detection model, make this value match the ID of the ANOMALY_DETECTION_BAND function.</summary>
    [JsonPropertyName("thresholdMetricId")]
    public string? ThresholdMetricId { get; set; }

    /// <summary>Sets how this alarm is to handle missing data points. The following values are supported: missing, ignore, breaching and notBreaching. Defaults to missing.</summary>
    [JsonPropertyName("treatMissingData")]
    public string? TreatMissingData { get; set; }

    /// <summary>The unit for the alarm&apos;s associated metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmStatusConditions
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

/// <summary>MetricAlarmStatus defines the observed state of MetricAlarm.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1MetricAlarmStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1MetricAlarmStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1MetricAlarmStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>MetricAlarm is the Schema for the MetricAlarms API. Provides a CloudWatch Metric Alarm resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1MetricAlarm : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1MetricAlarmSpec>, IStatus<V1beta1MetricAlarmStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "MetricAlarm";
    public const string KubeGroup = "cloudwatch.aws.m.upbound.io";
    public const string KubePluralName = "metricalarms";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudwatch.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetricAlarm";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>MetricAlarmSpec defines the desired state of MetricAlarm</summary>
    [JsonPropertyName("spec")]
    public required V1beta1MetricAlarmSpec Spec { get; set; }

    /// <summary>MetricAlarmStatus defines the observed state of MetricAlarm.</summary>
    [JsonPropertyName("status")]
    public V1beta1MetricAlarmStatus? Status { get; set; }
}