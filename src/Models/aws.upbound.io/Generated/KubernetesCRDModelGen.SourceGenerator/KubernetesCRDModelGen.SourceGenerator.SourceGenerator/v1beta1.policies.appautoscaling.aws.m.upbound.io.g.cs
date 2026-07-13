#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appautoscaling.aws.m.upbound.io;
/// <summary>Policy is the Schema for the Policys API. Provides an Application AutoScaling Policy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Policy>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PolicyList";
    public const string KubeGroup = "appautoscaling.aws.m.upbound.io";
    public const string KubePluralName = "policies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appautoscaling.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Policy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Policy> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetricDimension
{
    /// <summary>Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQuery
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized capacity metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetricDimension
{
    /// <summary>Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized load metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetricDimension
{
    /// <summary>Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQuery
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized scaling metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

/// <summary>Predefined load metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Reserved for future use if the predefined_metric_type is not ALBRequestCountPerTarget. If the predefined_metric_type is ALBRequestCountPerTarget, you must specify this argument. Documentation can be found at: AWS Predefined Scaling Metric Specification. Must be less than or equal to 1023 characters in length.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Predefined metric pair specification that determines the appropriate scaling metric and load metric to use. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Reserved for future use if the predefined_metric_type is not ALBRequestCountPerTarget. If the predefined_metric_type is ALBRequestCountPerTarget, you must specify this argument. Documentation can be found at: AWS Predefined Scaling Metric Specification. Must be less than or equal to 1023 characters in length.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Predefined scaling metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Reserved for future use if the predefined_metric_type is not ALBRequestCountPerTarget. If the predefined_metric_type is ALBRequestCountPerTarget, you must specify this argument. Documentation can be found at: AWS Predefined Scaling Metric Specification. Must be less than or equal to 1023 characters in length.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecification
{
    /// <summary>Customized capacity metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedCapacityMetricSpecification")]
    public V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification? CustomizedCapacityMetricSpecification { get; set; }

    /// <summary>Customized load metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Customized scaling metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Predefined load metric specification. See supported fields below.</summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>Predefined metric pair specification that determines the appropriate scaling metric and load metric to use. See supported fields below.</summary>
    [JsonPropertyName("predefinedMetricPairSpecification")]
    public V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification { get; set; }

    /// <summary>Predefined scaling metric specification. See supported fields below.</summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public string? TargetValue { get; set; }
}

/// <summary>Predictive scaling policy configuration, requires policy_type = &quot;PredictiveScaling&quot;. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderPredictiveScalingPolicyConfiguration
{
    /// <summary>The behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity. Valid values are HonorMaxCapacity and IncreaseMaxCapacity.</summary>
    [JsonPropertyName("maxCapacityBreachBehavior")]
    public string? MaxCapacityBreachBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity. The value is specified as a percentage relative to the forecast capacity. Required if the max_capacity_breach_behavior argument is set to IncreaseMaxCapacity, and cannot be used otherwise.</summary>
    [JsonPropertyName("maxCapacityBuffer")]
    public double? MaxCapacityBuffer { get; set; }

    /// <summary>Metrics and target utilization to use for predictive scaling. See supported fields below.</summary>
    [JsonPropertyName("metricSpecification")]
    public IList<V1beta1PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecification>? MetricSpecification { get; set; }

    /// <summary>Predictive scaling mode. Valid values are ForecastOnly and ForecastAndScale.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Amount of time, in seconds, that the start time can be advanced.</summary>
    [JsonPropertyName("schedulingBufferTime")]
    public double? SchedulingBufferTime { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecForProviderResourceIdRefPolicyResolutionEnum>))]
public enum V1beta1PolicySpecForProviderResourceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecForProviderResourceIdRefPolicyResolveEnum>))]
public enum V1beta1PolicySpecForProviderResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderResourceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PolicySpecForProviderResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PolicySpecForProviderResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Target in appautoscaling to populate resourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PolicySpecForProviderResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecForProviderResourceIdSelectorPolicyResolutionEnum>))]
public enum V1beta1PolicySpecForProviderResourceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecForProviderResourceIdSelectorPolicyResolveEnum>))]
public enum V1beta1PolicySpecForProviderResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderResourceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PolicySpecForProviderResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PolicySpecForProviderResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Target in appautoscaling to populate resourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderResourceIdSelector
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
    public V1beta1PolicySpecForProviderResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecForProviderScalableDimensionRefPolicyResolutionEnum>))]
public enum V1beta1PolicySpecForProviderScalableDimensionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecForProviderScalableDimensionRefPolicyResolveEnum>))]
public enum V1beta1PolicySpecForProviderScalableDimensionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderScalableDimensionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PolicySpecForProviderScalableDimensionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PolicySpecForProviderScalableDimensionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Target in appautoscaling to populate scalableDimension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderScalableDimensionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PolicySpecForProviderScalableDimensionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecForProviderScalableDimensionSelectorPolicyResolutionEnum>))]
public enum V1beta1PolicySpecForProviderScalableDimensionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecForProviderScalableDimensionSelectorPolicyResolveEnum>))]
public enum V1beta1PolicySpecForProviderScalableDimensionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderScalableDimensionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PolicySpecForProviderScalableDimensionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PolicySpecForProviderScalableDimensionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Target in appautoscaling to populate scalableDimension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderScalableDimensionSelector
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
    public V1beta1PolicySpecForProviderScalableDimensionSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecForProviderServiceNamespaceRefPolicyResolutionEnum>))]
public enum V1beta1PolicySpecForProviderServiceNamespaceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecForProviderServiceNamespaceRefPolicyResolveEnum>))]
public enum V1beta1PolicySpecForProviderServiceNamespaceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderServiceNamespaceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PolicySpecForProviderServiceNamespaceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PolicySpecForProviderServiceNamespaceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Target in appautoscaling to populate serviceNamespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderServiceNamespaceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PolicySpecForProviderServiceNamespaceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecForProviderServiceNamespaceSelectorPolicyResolutionEnum>))]
public enum V1beta1PolicySpecForProviderServiceNamespaceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecForProviderServiceNamespaceSelectorPolicyResolveEnum>))]
public enum V1beta1PolicySpecForProviderServiceNamespaceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderServiceNamespaceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PolicySpecForProviderServiceNamespaceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PolicySpecForProviderServiceNamespaceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Target in appautoscaling to populate serviceNamespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderServiceNamespaceSelector
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
    public V1beta1PolicySpecForProviderServiceNamespaceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderStepScalingPolicyConfigurationStepAdjustment
{
    /// <summary>Lower bound for the difference between the alarm threshold and the CloudWatch metric. Without a value, AWS will treat this bound as negative infinity.</summary>
    [JsonPropertyName("metricIntervalLowerBound")]
    public string? MetricIntervalLowerBound { get; set; }

    /// <summary>Upper bound for the difference between the alarm threshold and the CloudWatch metric. Without a value, AWS will treat this bound as infinity. The upper bound must be greater than the lower bound.</summary>
    [JsonPropertyName("metricIntervalUpperBound")]
    public string? MetricIntervalUpperBound { get; set; }

    /// <summary>Number of members by which to scale, when the adjustment bounds are breached. A positive value scales up. A negative value scales down.</summary>
    [JsonPropertyName("scalingAdjustment")]
    public double? ScalingAdjustment { get; set; }
}

/// <summary>Step scaling policy configuration, requires policy_type = &quot;StepScaling&quot; (default). See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderStepScalingPolicyConfiguration
{
    /// <summary>Whether the adjustment is an absolute number or a percentage of the current capacity. Valid values are ChangeInCapacity, ExactCapacity, and PercentChangeInCapacity.</summary>
    [JsonPropertyName("adjustmentType")]
    public string? AdjustmentType { get; set; }

    /// <summary>Amount of time, in seconds, after a scaling activity completes and before the next scaling activity can start.</summary>
    [JsonPropertyName("cooldown")]
    public double? Cooldown { get; set; }

    /// <summary>Aggregation type for the policy&apos;s metrics. Valid values are &quot;Minimum&quot;, &quot;Maximum&quot;, and &quot;Average&quot;. Without a value, AWS will treat the aggregation type as &quot;Average&quot;.</summary>
    [JsonPropertyName("metricAggregationType")]
    public string? MetricAggregationType { get; set; }

    /// <summary>Minimum number to adjust your scalable dimension as a result of a scaling activity. If the adjustment type is PercentChangeInCapacity, the scaling policy changes the scalable dimension of the scalable target by this amount.</summary>
    [JsonPropertyName("minAdjustmentMagnitude")]
    public double? MinAdjustmentMagnitude { get; set; }

    /// <summary>Set of adjustments that manage scaling. These have the following structure:</summary>
    [JsonPropertyName("stepAdjustment")]
    public IList<V1beta1PolicySpecForProviderStepScalingPolicyConfigurationStepAdjustment>? StepAdjustment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions
{
    /// <summary>Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions
{
    /// <summary>Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric
{
    /// <summary>Configuration block(s) with the dimensions of the metric if the metric was published with dimensions. Detailed below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetrics
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Custom CloudWatch metric. Documentation can be found  at: AWS Customized Metric Specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification
{
    /// <summary>Configuration block(s) with the dimensions of the metric if the metric was published with dimensions. Detailed below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Metrics to include, as a metric data query.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta1PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetrics>? Metrics { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Statistic of the metric. Valid values: Average, Minimum, Maximum, SampleCount, and Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>Predefined metric. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Reserved for future use if the predefined_metric_type is not ALBRequestCountPerTarget. If the predefined_metric_type is ALBRequestCountPerTarget, you must specify this argument. Documentation can be found at: AWS Predefined Scaling Metric Specification. Must be less than or equal to 1023 characters in length.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Target tracking policy configuration, requires policy_type = &quot;TargetTrackingScaling&quot;. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProviderTargetTrackingScalingPolicyConfiguration
{
    /// <summary>Custom CloudWatch metric. Documentation can be found  at: AWS Customized Metric Specification. See supported fields below.</summary>
    [JsonPropertyName("customizedMetricSpecification")]
    public V1beta1PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification { get; set; }

    /// <summary>Whether scale in by the target tracking policy is disabled. If the value is true, scale in is disabled and the target tracking policy won&apos;t remove capacity from the scalable resource. Otherwise, scale in is enabled and the target tracking policy can remove capacity from the scalable resource. The default value is false.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>Predefined metric. See supported fields below.</summary>
    [JsonPropertyName("predefinedMetricSpecification")]
    public V1beta1PolicySpecForProviderTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification { get; set; }

    /// <summary>Amount of time, in seconds, after a scale in activity completes before another scale in activity can start.</summary>
    [JsonPropertyName("scaleInCooldown")]
    public double? ScaleInCooldown { get; set; }

    /// <summary>Amount of time, in seconds, after a scale out activity completes before another scale out activity can start.</summary>
    [JsonPropertyName("scaleOutCooldown")]
    public double? ScaleOutCooldown { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecForProvider
{
    /// <summary>Policy type. Valid values are StepScaling, TargetTrackingScaling, and PredictiveScaling. Defaults to StepScaling. Certain services only support only one policy type. For more information see the Target Tracking Scaling Policies, Step Scaling Policies, and Predictive Scaling documentation.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>Predictive scaling policy configuration, requires policy_type = &quot;PredictiveScaling&quot;. See supported fields below.</summary>
    [JsonPropertyName("predictiveScalingPolicyConfiguration")]
    public V1beta1PolicySpecForProviderPredictiveScalingPolicyConfiguration? PredictiveScalingPolicyConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Resource type and unique identifier string for the resource associated with the scaling policy. Documentation can be found in the ResourceId parameter at: AWS Application Auto Scaling API Reference</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Reference to a Target in appautoscaling to populate resourceId.</summary>
    [JsonPropertyName("resourceIdRef")]
    public V1beta1PolicySpecForProviderResourceIdRef? ResourceIdRef { get; set; }

    /// <summary>Selector for a Target in appautoscaling to populate resourceId.</summary>
    [JsonPropertyName("resourceIdSelector")]
    public V1beta1PolicySpecForProviderResourceIdSelector? ResourceIdSelector { get; set; }

    /// <summary>Scalable dimension of the scalable target. Documentation can be found in the ScalableDimension parameter at: AWS Application Auto Scaling API Reference</summary>
    [JsonPropertyName("scalableDimension")]
    public string? ScalableDimension { get; set; }

    /// <summary>Reference to a Target in appautoscaling to populate scalableDimension.</summary>
    [JsonPropertyName("scalableDimensionRef")]
    public V1beta1PolicySpecForProviderScalableDimensionRef? ScalableDimensionRef { get; set; }

    /// <summary>Selector for a Target in appautoscaling to populate scalableDimension.</summary>
    [JsonPropertyName("scalableDimensionSelector")]
    public V1beta1PolicySpecForProviderScalableDimensionSelector? ScalableDimensionSelector { get; set; }

    /// <summary>AWS service namespace of the scalable target. Documentation can be found in the ServiceNamespace parameter at: AWS Application Auto Scaling API Reference</summary>
    [JsonPropertyName("serviceNamespace")]
    public string? ServiceNamespace { get; set; }

    /// <summary>Reference to a Target in appautoscaling to populate serviceNamespace.</summary>
    [JsonPropertyName("serviceNamespaceRef")]
    public V1beta1PolicySpecForProviderServiceNamespaceRef? ServiceNamespaceRef { get; set; }

    /// <summary>Selector for a Target in appautoscaling to populate serviceNamespace.</summary>
    [JsonPropertyName("serviceNamespaceSelector")]
    public V1beta1PolicySpecForProviderServiceNamespaceSelector? ServiceNamespaceSelector { get; set; }

    /// <summary>Step scaling policy configuration, requires policy_type = &quot;StepScaling&quot; (default). See supported fields below.</summary>
    [JsonPropertyName("stepScalingPolicyConfiguration")]
    public V1beta1PolicySpecForProviderStepScalingPolicyConfiguration? StepScalingPolicyConfiguration { get; set; }

    /// <summary>Target tracking policy configuration, requires policy_type = &quot;TargetTrackingScaling&quot;. See supported fields below.</summary>
    [JsonPropertyName("targetTrackingScalingPolicyConfiguration")]
    public V1beta1PolicySpecForProviderTargetTrackingScalingPolicyConfiguration? TargetTrackingScalingPolicyConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetricDimension
{
    /// <summary>Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQuery
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized capacity metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetricDimension
{
    /// <summary>Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized load metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetricDimension
{
    /// <summary>Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQuery
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized scaling metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

/// <summary>Predefined load metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Reserved for future use if the predefined_metric_type is not ALBRequestCountPerTarget. If the predefined_metric_type is ALBRequestCountPerTarget, you must specify this argument. Documentation can be found at: AWS Predefined Scaling Metric Specification. Must be less than or equal to 1023 characters in length.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Predefined metric pair specification that determines the appropriate scaling metric and load metric to use. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Reserved for future use if the predefined_metric_type is not ALBRequestCountPerTarget. If the predefined_metric_type is ALBRequestCountPerTarget, you must specify this argument. Documentation can be found at: AWS Predefined Scaling Metric Specification. Must be less than or equal to 1023 characters in length.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Predefined scaling metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Reserved for future use if the predefined_metric_type is not ALBRequestCountPerTarget. If the predefined_metric_type is ALBRequestCountPerTarget, you must specify this argument. Documentation can be found at: AWS Predefined Scaling Metric Specification. Must be less than or equal to 1023 characters in length.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecification
{
    /// <summary>Customized capacity metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedCapacityMetricSpecification")]
    public V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification? CustomizedCapacityMetricSpecification { get; set; }

    /// <summary>Customized load metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Customized scaling metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Predefined load metric specification. See supported fields below.</summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>Predefined metric pair specification that determines the appropriate scaling metric and load metric to use. See supported fields below.</summary>
    [JsonPropertyName("predefinedMetricPairSpecification")]
    public V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification { get; set; }

    /// <summary>Predefined scaling metric specification. See supported fields below.</summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public string? TargetValue { get; set; }
}

/// <summary>Predictive scaling policy configuration, requires policy_type = &quot;PredictiveScaling&quot;. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfiguration
{
    /// <summary>The behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity. Valid values are HonorMaxCapacity and IncreaseMaxCapacity.</summary>
    [JsonPropertyName("maxCapacityBreachBehavior")]
    public string? MaxCapacityBreachBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity. The value is specified as a percentage relative to the forecast capacity. Required if the max_capacity_breach_behavior argument is set to IncreaseMaxCapacity, and cannot be used otherwise.</summary>
    [JsonPropertyName("maxCapacityBuffer")]
    public double? MaxCapacityBuffer { get; set; }

    /// <summary>Metrics and target utilization to use for predictive scaling. See supported fields below.</summary>
    [JsonPropertyName("metricSpecification")]
    public IList<V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecification>? MetricSpecification { get; set; }

    /// <summary>Predictive scaling mode. Valid values are ForecastOnly and ForecastAndScale.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Amount of time, in seconds, that the start time can be advanced.</summary>
    [JsonPropertyName("schedulingBufferTime")]
    public double? SchedulingBufferTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderStepScalingPolicyConfigurationStepAdjustment
{
    /// <summary>Lower bound for the difference between the alarm threshold and the CloudWatch metric. Without a value, AWS will treat this bound as negative infinity.</summary>
    [JsonPropertyName("metricIntervalLowerBound")]
    public string? MetricIntervalLowerBound { get; set; }

    /// <summary>Upper bound for the difference between the alarm threshold and the CloudWatch metric. Without a value, AWS will treat this bound as infinity. The upper bound must be greater than the lower bound.</summary>
    [JsonPropertyName("metricIntervalUpperBound")]
    public string? MetricIntervalUpperBound { get; set; }

    /// <summary>Number of members by which to scale, when the adjustment bounds are breached. A positive value scales up. A negative value scales down.</summary>
    [JsonPropertyName("scalingAdjustment")]
    public double? ScalingAdjustment { get; set; }
}

/// <summary>Step scaling policy configuration, requires policy_type = &quot;StepScaling&quot; (default). See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderStepScalingPolicyConfiguration
{
    /// <summary>Whether the adjustment is an absolute number or a percentage of the current capacity. Valid values are ChangeInCapacity, ExactCapacity, and PercentChangeInCapacity.</summary>
    [JsonPropertyName("adjustmentType")]
    public string? AdjustmentType { get; set; }

    /// <summary>Amount of time, in seconds, after a scaling activity completes and before the next scaling activity can start.</summary>
    [JsonPropertyName("cooldown")]
    public double? Cooldown { get; set; }

    /// <summary>Aggregation type for the policy&apos;s metrics. Valid values are &quot;Minimum&quot;, &quot;Maximum&quot;, and &quot;Average&quot;. Without a value, AWS will treat the aggregation type as &quot;Average&quot;.</summary>
    [JsonPropertyName("metricAggregationType")]
    public string? MetricAggregationType { get; set; }

    /// <summary>Minimum number to adjust your scalable dimension as a result of a scaling activity. If the adjustment type is PercentChangeInCapacity, the scaling policy changes the scalable dimension of the scalable target by this amount.</summary>
    [JsonPropertyName("minAdjustmentMagnitude")]
    public double? MinAdjustmentMagnitude { get; set; }

    /// <summary>Set of adjustments that manage scaling. These have the following structure:</summary>
    [JsonPropertyName("stepAdjustment")]
    public IList<V1beta1PolicySpecInitProviderStepScalingPolicyConfigurationStepAdjustment>? StepAdjustment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions
{
    /// <summary>Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions
{
    /// <summary>Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric
{
    /// <summary>Configuration block(s) with the dimensions of the metric if the metric was published with dimensions. Detailed below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetrics
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Custom CloudWatch metric. Documentation can be found  at: AWS Customized Metric Specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification
{
    /// <summary>Configuration block(s) with the dimensions of the metric if the metric was published with dimensions. Detailed below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Metrics to include, as a metric data query.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta1PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetrics>? Metrics { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Statistic of the metric. Valid values: Average, Minimum, Maximum, SampleCount, and Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>Predefined metric. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Reserved for future use if the predefined_metric_type is not ALBRequestCountPerTarget. If the predefined_metric_type is ALBRequestCountPerTarget, you must specify this argument. Documentation can be found at: AWS Predefined Scaling Metric Specification. Must be less than or equal to 1023 characters in length.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Target tracking policy configuration, requires policy_type = &quot;TargetTrackingScaling&quot;. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpecInitProviderTargetTrackingScalingPolicyConfiguration
{
    /// <summary>Custom CloudWatch metric. Documentation can be found  at: AWS Customized Metric Specification. See supported fields below.</summary>
    [JsonPropertyName("customizedMetricSpecification")]
    public V1beta1PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification { get; set; }

    /// <summary>Whether scale in by the target tracking policy is disabled. If the value is true, scale in is disabled and the target tracking policy won&apos;t remove capacity from the scalable resource. Otherwise, scale in is enabled and the target tracking policy can remove capacity from the scalable resource. The default value is false.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>Predefined metric. See supported fields below.</summary>
    [JsonPropertyName("predefinedMetricSpecification")]
    public V1beta1PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification { get; set; }

    /// <summary>Amount of time, in seconds, after a scale in activity completes before another scale in activity can start.</summary>
    [JsonPropertyName("scaleInCooldown")]
    public double? ScaleInCooldown { get; set; }

    /// <summary>Amount of time, in seconds, after a scale out activity completes before another scale out activity can start.</summary>
    [JsonPropertyName("scaleOutCooldown")]
    public double? ScaleOutCooldown { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
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
public partial class V1beta1PolicySpecInitProvider
{
    /// <summary>Policy type. Valid values are StepScaling, TargetTrackingScaling, and PredictiveScaling. Defaults to StepScaling. Certain services only support only one policy type. For more information see the Target Tracking Scaling Policies, Step Scaling Policies, and Predictive Scaling documentation.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>Predictive scaling policy configuration, requires policy_type = &quot;PredictiveScaling&quot;. See supported fields below.</summary>
    [JsonPropertyName("predictiveScalingPolicyConfiguration")]
    public V1beta1PolicySpecInitProviderPredictiveScalingPolicyConfiguration? PredictiveScalingPolicyConfiguration { get; set; }

    /// <summary>Step scaling policy configuration, requires policy_type = &quot;StepScaling&quot; (default). See supported fields below.</summary>
    [JsonPropertyName("stepScalingPolicyConfiguration")]
    public V1beta1PolicySpecInitProviderStepScalingPolicyConfiguration? StepScalingPolicyConfiguration { get; set; }

    /// <summary>Target tracking policy configuration, requires policy_type = &quot;TargetTrackingScaling&quot;. See supported fields below.</summary>
    [JsonPropertyName("targetTrackingScalingPolicyConfiguration")]
    public V1beta1PolicySpecInitProviderTargetTrackingScalingPolicyConfiguration? TargetTrackingScalingPolicyConfiguration { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PolicySpecManagementPoliciesEnum>))]
public enum V1beta1PolicySpecManagementPoliciesEnum
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
public partial class V1beta1PolicySpecProviderConfigRef
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
public partial class V1beta1PolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>PolicySpec defines the desired state of Policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicySpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1PolicySpecForProvider ForProvider { get; set; }

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
    public V1beta1PolicySpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetricDimension
{
    /// <summary>Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQuery
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized capacity metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetricDimension
{
    /// <summary>Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized load metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetricDimension
{
    /// <summary>Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQuery
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized scaling metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

/// <summary>Predefined load metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Reserved for future use if the predefined_metric_type is not ALBRequestCountPerTarget. If the predefined_metric_type is ALBRequestCountPerTarget, you must specify this argument. Documentation can be found at: AWS Predefined Scaling Metric Specification. Must be less than or equal to 1023 characters in length.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Predefined metric pair specification that determines the appropriate scaling metric and load metric to use. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Reserved for future use if the predefined_metric_type is not ALBRequestCountPerTarget. If the predefined_metric_type is ALBRequestCountPerTarget, you must specify this argument. Documentation can be found at: AWS Predefined Scaling Metric Specification. Must be less than or equal to 1023 characters in length.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Predefined scaling metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Reserved for future use if the predefined_metric_type is not ALBRequestCountPerTarget. If the predefined_metric_type is ALBRequestCountPerTarget, you must specify this argument. Documentation can be found at: AWS Predefined Scaling Metric Specification. Must be less than or equal to 1023 characters in length.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecification
{
    /// <summary>Customized capacity metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedCapacityMetricSpecification")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification? CustomizedCapacityMetricSpecification { get; set; }

    /// <summary>Customized load metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Customized scaling metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Predefined load metric specification. See supported fields below.</summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>Predefined metric pair specification that determines the appropriate scaling metric and load metric to use. See supported fields below.</summary>
    [JsonPropertyName("predefinedMetricPairSpecification")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification { get; set; }

    /// <summary>Predefined scaling metric specification. See supported fields below.</summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public string? TargetValue { get; set; }
}

/// <summary>Predictive scaling policy configuration, requires policy_type = &quot;PredictiveScaling&quot;. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfiguration
{
    /// <summary>The behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity. Valid values are HonorMaxCapacity and IncreaseMaxCapacity.</summary>
    [JsonPropertyName("maxCapacityBreachBehavior")]
    public string? MaxCapacityBreachBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity. The value is specified as a percentage relative to the forecast capacity. Required if the max_capacity_breach_behavior argument is set to IncreaseMaxCapacity, and cannot be used otherwise.</summary>
    [JsonPropertyName("maxCapacityBuffer")]
    public double? MaxCapacityBuffer { get; set; }

    /// <summary>Metrics and target utilization to use for predictive scaling. See supported fields below.</summary>
    [JsonPropertyName("metricSpecification")]
    public IList<V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecification>? MetricSpecification { get; set; }

    /// <summary>Predictive scaling mode. Valid values are ForecastOnly and ForecastAndScale.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Amount of time, in seconds, that the start time can be advanced.</summary>
    [JsonPropertyName("schedulingBufferTime")]
    public double? SchedulingBufferTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderStepScalingPolicyConfigurationStepAdjustment
{
    /// <summary>Lower bound for the difference between the alarm threshold and the CloudWatch metric. Without a value, AWS will treat this bound as negative infinity.</summary>
    [JsonPropertyName("metricIntervalLowerBound")]
    public string? MetricIntervalLowerBound { get; set; }

    /// <summary>Upper bound for the difference between the alarm threshold and the CloudWatch metric. Without a value, AWS will treat this bound as infinity. The upper bound must be greater than the lower bound.</summary>
    [JsonPropertyName("metricIntervalUpperBound")]
    public string? MetricIntervalUpperBound { get; set; }

    /// <summary>Number of members by which to scale, when the adjustment bounds are breached. A positive value scales up. A negative value scales down.</summary>
    [JsonPropertyName("scalingAdjustment")]
    public double? ScalingAdjustment { get; set; }
}

/// <summary>Step scaling policy configuration, requires policy_type = &quot;StepScaling&quot; (default). See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderStepScalingPolicyConfiguration
{
    /// <summary>Whether the adjustment is an absolute number or a percentage of the current capacity. Valid values are ChangeInCapacity, ExactCapacity, and PercentChangeInCapacity.</summary>
    [JsonPropertyName("adjustmentType")]
    public string? AdjustmentType { get; set; }

    /// <summary>Amount of time, in seconds, after a scaling activity completes and before the next scaling activity can start.</summary>
    [JsonPropertyName("cooldown")]
    public double? Cooldown { get; set; }

    /// <summary>Aggregation type for the policy&apos;s metrics. Valid values are &quot;Minimum&quot;, &quot;Maximum&quot;, and &quot;Average&quot;. Without a value, AWS will treat the aggregation type as &quot;Average&quot;.</summary>
    [JsonPropertyName("metricAggregationType")]
    public string? MetricAggregationType { get; set; }

    /// <summary>Minimum number to adjust your scalable dimension as a result of a scaling activity. If the adjustment type is PercentChangeInCapacity, the scaling policy changes the scalable dimension of the scalable target by this amount.</summary>
    [JsonPropertyName("minAdjustmentMagnitude")]
    public double? MinAdjustmentMagnitude { get; set; }

    /// <summary>Set of adjustments that manage scaling. These have the following structure:</summary>
    [JsonPropertyName("stepAdjustment")]
    public IList<V1beta1PolicyStatusAtProviderStepScalingPolicyConfigurationStepAdjustment>? StepAdjustment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions
{
    /// <summary>Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions
{
    /// <summary>Name of the dimension.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric
{
    /// <summary>Configuration block(s) with the dimensions of the metric if the metric was published with dimensions. Detailed below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta1PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetrics
{
    /// <summary>Math expression used on the returned metric. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Human-readable label for this metric or expression.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Structure that defines CloudWatch metric to be used in target tracking scaling policy. You must specify either expression or metric_stat, but not both.</summary>
    [JsonPropertyName("metricStat")]
    public V1beta1PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Custom CloudWatch metric. Documentation can be found  at: AWS Customized Metric Specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification
{
    /// <summary>Configuration block(s) with the dimensions of the metric if the metric was published with dimensions. Detailed below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta1PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Metrics to include, as a metric data query.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta1PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetrics>? Metrics { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Statistic of the metric. Valid values: Average, Minimum, Maximum, SampleCount, and Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>Predefined metric. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Reserved for future use if the predefined_metric_type is not ALBRequestCountPerTarget. If the predefined_metric_type is ALBRequestCountPerTarget, you must specify this argument. Documentation can be found at: AWS Predefined Scaling Metric Specification. Must be less than or equal to 1023 characters in length.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Target tracking policy configuration, requires policy_type = &quot;TargetTrackingScaling&quot;. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProviderTargetTrackingScalingPolicyConfiguration
{
    /// <summary>Custom CloudWatch metric. Documentation can be found  at: AWS Customized Metric Specification. See supported fields below.</summary>
    [JsonPropertyName("customizedMetricSpecification")]
    public V1beta1PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification { get; set; }

    /// <summary>Whether scale in by the target tracking policy is disabled. If the value is true, scale in is disabled and the target tracking policy won&apos;t remove capacity from the scalable resource. Otherwise, scale in is enabled and the target tracking policy can remove capacity from the scalable resource. The default value is false.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>Predefined metric. See supported fields below.</summary>
    [JsonPropertyName("predefinedMetricSpecification")]
    public V1beta1PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification { get; set; }

    /// <summary>Amount of time, in seconds, after a scale in activity completes before another scale in activity can start.</summary>
    [JsonPropertyName("scaleInCooldown")]
    public double? ScaleInCooldown { get; set; }

    /// <summary>Amount of time, in seconds, after a scale out activity completes before another scale out activity can start.</summary>
    [JsonPropertyName("scaleOutCooldown")]
    public double? ScaleOutCooldown { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusAtProvider
{
    /// <summary>List of CloudWatch alarm ARNs associated with the scaling policy.</summary>
    [JsonPropertyName("alarmArns")]
    public IList<string>? AlarmArns { get; set; }

    /// <summary>ARN assigned by AWS to the scaling policy.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Policy type. Valid values are StepScaling, TargetTrackingScaling, and PredictiveScaling. Defaults to StepScaling. Certain services only support only one policy type. For more information see the Target Tracking Scaling Policies, Step Scaling Policies, and Predictive Scaling documentation.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>Predictive scaling policy configuration, requires policy_type = &quot;PredictiveScaling&quot;. See supported fields below.</summary>
    [JsonPropertyName("predictiveScalingPolicyConfiguration")]
    public V1beta1PolicyStatusAtProviderPredictiveScalingPolicyConfiguration? PredictiveScalingPolicyConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Resource type and unique identifier string for the resource associated with the scaling policy. Documentation can be found in the ResourceId parameter at: AWS Application Auto Scaling API Reference</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Scalable dimension of the scalable target. Documentation can be found in the ScalableDimension parameter at: AWS Application Auto Scaling API Reference</summary>
    [JsonPropertyName("scalableDimension")]
    public string? ScalableDimension { get; set; }

    /// <summary>AWS service namespace of the scalable target. Documentation can be found in the ServiceNamespace parameter at: AWS Application Auto Scaling API Reference</summary>
    [JsonPropertyName("serviceNamespace")]
    public string? ServiceNamespace { get; set; }

    /// <summary>Step scaling policy configuration, requires policy_type = &quot;StepScaling&quot; (default). See supported fields below.</summary>
    [JsonPropertyName("stepScalingPolicyConfiguration")]
    public V1beta1PolicyStatusAtProviderStepScalingPolicyConfiguration? StepScalingPolicyConfiguration { get; set; }

    /// <summary>Target tracking policy configuration, requires policy_type = &quot;TargetTrackingScaling&quot;. See supported fields below.</summary>
    [JsonPropertyName("targetTrackingScalingPolicyConfiguration")]
    public V1beta1PolicyStatusAtProviderTargetTrackingScalingPolicyConfiguration? TargetTrackingScalingPolicyConfiguration { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatusConditions
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

/// <summary>PolicyStatus defines the observed state of Policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1PolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PolicyStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Policy is the Schema for the Policys API. Provides an Application AutoScaling Policy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Policy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PolicySpec>, IStatus<V1beta1PolicyStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Policy";
    public const string KubeGroup = "appautoscaling.aws.m.upbound.io";
    public const string KubePluralName = "policies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appautoscaling.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Policy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PolicySpec defines the desired state of Policy</summary>
    [JsonPropertyName("spec")]
    public required V1beta1PolicySpec Spec { get; set; }

    /// <summary>PolicyStatus defines the observed state of Policy.</summary>
    [JsonPropertyName("status")]
    public V1beta1PolicyStatus? Status { get; set; }
}