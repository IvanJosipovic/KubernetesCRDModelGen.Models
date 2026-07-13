#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.appautoscaling.aws.upbound.io;
/// <summary>Policy is the Schema for the Policys API. Provides an Application AutoScaling Policy resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2PolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Policy>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "PolicyList";
    public const string KubeGroup = "appautoscaling.aws.upbound.io";
    public const string KubePluralName = "policies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appautoscaling.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Policy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Policy> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecDeletionPolicyEnum>))]
public enum V1beta2PolicySpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetricDimension
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
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

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
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQuery
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
    public V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized capacity metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetricDimension
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
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

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
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery
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
    public V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized load metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetricDimension
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
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

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
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQuery
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
    public V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized scaling metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

/// <summary>Predefined load metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification
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
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification
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
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification
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
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecification
{
    /// <summary>Customized capacity metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedCapacityMetricSpecification")]
    public V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification? CustomizedCapacityMetricSpecification { get; set; }

    /// <summary>Customized load metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Customized scaling metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Predefined load metric specification. See supported fields below.</summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>Predefined metric pair specification that determines the appropriate scaling metric and load metric to use. See supported fields below.</summary>
    [JsonPropertyName("predefinedMetricPairSpecification")]
    public V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification { get; set; }

    /// <summary>Predefined scaling metric specification. See supported fields below.</summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public string? TargetValue { get; set; }
}

/// <summary>Predictive scaling policy configuration, requires policy_type = &quot;PredictiveScaling&quot;. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingPolicyConfiguration
{
    /// <summary>The behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity. Valid values are HonorMaxCapacity and IncreaseMaxCapacity.</summary>
    [JsonPropertyName("maxCapacityBreachBehavior")]
    public string? MaxCapacityBreachBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity. The value is specified as a percentage relative to the forecast capacity. Required if the max_capacity_breach_behavior argument is set to IncreaseMaxCapacity, and cannot be used otherwise.</summary>
    [JsonPropertyName("maxCapacityBuffer")]
    public double? MaxCapacityBuffer { get; set; }

    /// <summary>Metrics and target utilization to use for predictive scaling. See supported fields below.</summary>
    [JsonPropertyName("metricSpecification")]
    public IList<V1beta2PolicySpecForProviderPredictiveScalingPolicyConfigurationMetricSpecification>? MetricSpecification { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderResourceIdRefPolicyResolutionEnum>))]
public enum V1beta2PolicySpecForProviderResourceIdRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderResourceIdRefPolicyResolveEnum>))]
public enum V1beta2PolicySpecForProviderResourceIdRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderResourceIdRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecForProviderResourceIdRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecForProviderResourceIdRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Target in appautoscaling to populate resourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderResourceIdRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PolicySpecForProviderResourceIdRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderResourceIdSelectorPolicyResolutionEnum>))]
public enum V1beta2PolicySpecForProviderResourceIdSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderResourceIdSelectorPolicyResolveEnum>))]
public enum V1beta2PolicySpecForProviderResourceIdSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderResourceIdSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecForProviderResourceIdSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecForProviderResourceIdSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Target in appautoscaling to populate resourceId.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderResourceIdSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PolicySpecForProviderResourceIdSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderScalableDimensionRefPolicyResolutionEnum>))]
public enum V1beta2PolicySpecForProviderScalableDimensionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderScalableDimensionRefPolicyResolveEnum>))]
public enum V1beta2PolicySpecForProviderScalableDimensionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderScalableDimensionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecForProviderScalableDimensionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecForProviderScalableDimensionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Target in appautoscaling to populate scalableDimension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderScalableDimensionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PolicySpecForProviderScalableDimensionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderScalableDimensionSelectorPolicyResolutionEnum>))]
public enum V1beta2PolicySpecForProviderScalableDimensionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderScalableDimensionSelectorPolicyResolveEnum>))]
public enum V1beta2PolicySpecForProviderScalableDimensionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderScalableDimensionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecForProviderScalableDimensionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecForProviderScalableDimensionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Target in appautoscaling to populate scalableDimension.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderScalableDimensionSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PolicySpecForProviderScalableDimensionSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderServiceNamespaceRefPolicyResolutionEnum>))]
public enum V1beta2PolicySpecForProviderServiceNamespaceRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderServiceNamespaceRefPolicyResolveEnum>))]
public enum V1beta2PolicySpecForProviderServiceNamespaceRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderServiceNamespaceRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecForProviderServiceNamespaceRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecForProviderServiceNamespaceRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Target in appautoscaling to populate serviceNamespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderServiceNamespaceRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PolicySpecForProviderServiceNamespaceRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderServiceNamespaceSelectorPolicyResolutionEnum>))]
public enum V1beta2PolicySpecForProviderServiceNamespaceSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderServiceNamespaceSelectorPolicyResolveEnum>))]
public enum V1beta2PolicySpecForProviderServiceNamespaceSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderServiceNamespaceSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecForProviderServiceNamespaceSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecForProviderServiceNamespaceSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Target in appautoscaling to populate serviceNamespace.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderServiceNamespaceSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PolicySpecForProviderServiceNamespaceSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderStepScalingPolicyConfigurationStepAdjustment
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
public partial class V1beta2PolicySpecForProviderStepScalingPolicyConfiguration
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
    public IList<V1beta2PolicySpecForProviderStepScalingPolicyConfigurationStepAdjustment>? StepAdjustment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions
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
public partial class V1beta2PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions
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
public partial class V1beta2PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric
{
    /// <summary>Configuration block(s) with the dimensions of the metric if the metric was published with dimensions. Detailed below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions>? Dimensions { get; set; }

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
public partial class V1beta2PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetrics
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
    public V1beta2PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Custom CloudWatch metric. Documentation can be found  at: AWS Customized Metric Specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification
{
    /// <summary>Configuration block(s) with the dimensions of the metric if the metric was published with dimensions. Detailed below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Metrics to include, as a metric data query.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta2PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetrics>? Metrics { get; set; }

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
public partial class V1beta2PolicySpecForProviderTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification
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
public partial class V1beta2PolicySpecForProviderTargetTrackingScalingPolicyConfiguration
{
    /// <summary>Custom CloudWatch metric. Documentation can be found  at: AWS Customized Metric Specification. See supported fields below.</summary>
    [JsonPropertyName("customizedMetricSpecification")]
    public V1beta2PolicySpecForProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification { get; set; }

    /// <summary>Whether scale in by the target tracking policy is disabled. If the value is true, scale in is disabled and the target tracking policy won&apos;t remove capacity from the scalable resource. Otherwise, scale in is enabled and the target tracking policy can remove capacity from the scalable resource. The default value is false.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>Predefined metric. See supported fields below.</summary>
    [JsonPropertyName("predefinedMetricSpecification")]
    public V1beta2PolicySpecForProviderTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification { get; set; }

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
public partial class V1beta2PolicySpecForProvider
{
    /// <summary>Policy type. Valid values are StepScaling, TargetTrackingScaling, and PredictiveScaling. Defaults to StepScaling. Certain services only support only one policy type. For more information see the Target Tracking Scaling Policies, Step Scaling Policies, and Predictive Scaling documentation.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>Predictive scaling policy configuration, requires policy_type = &quot;PredictiveScaling&quot;. See supported fields below.</summary>
    [JsonPropertyName("predictiveScalingPolicyConfiguration")]
    public V1beta2PolicySpecForProviderPredictiveScalingPolicyConfiguration? PredictiveScalingPolicyConfiguration { get; set; }

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
    public V1beta2PolicySpecForProviderResourceIdRef? ResourceIdRef { get; set; }

    /// <summary>Selector for a Target in appautoscaling to populate resourceId.</summary>
    [JsonPropertyName("resourceIdSelector")]
    public V1beta2PolicySpecForProviderResourceIdSelector? ResourceIdSelector { get; set; }

    /// <summary>Scalable dimension of the scalable target. Documentation can be found in the ScalableDimension parameter at: AWS Application Auto Scaling API Reference</summary>
    [JsonPropertyName("scalableDimension")]
    public string? ScalableDimension { get; set; }

    /// <summary>Reference to a Target in appautoscaling to populate scalableDimension.</summary>
    [JsonPropertyName("scalableDimensionRef")]
    public V1beta2PolicySpecForProviderScalableDimensionRef? ScalableDimensionRef { get; set; }

    /// <summary>Selector for a Target in appautoscaling to populate scalableDimension.</summary>
    [JsonPropertyName("scalableDimensionSelector")]
    public V1beta2PolicySpecForProviderScalableDimensionSelector? ScalableDimensionSelector { get; set; }

    /// <summary>AWS service namespace of the scalable target. Documentation can be found in the ServiceNamespace parameter at: AWS Application Auto Scaling API Reference</summary>
    [JsonPropertyName("serviceNamespace")]
    public string? ServiceNamespace { get; set; }

    /// <summary>Reference to a Target in appautoscaling to populate serviceNamespace.</summary>
    [JsonPropertyName("serviceNamespaceRef")]
    public V1beta2PolicySpecForProviderServiceNamespaceRef? ServiceNamespaceRef { get; set; }

    /// <summary>Selector for a Target in appautoscaling to populate serviceNamespace.</summary>
    [JsonPropertyName("serviceNamespaceSelector")]
    public V1beta2PolicySpecForProviderServiceNamespaceSelector? ServiceNamespaceSelector { get; set; }

    /// <summary>Step scaling policy configuration, requires policy_type = &quot;StepScaling&quot; (default). See supported fields below.</summary>
    [JsonPropertyName("stepScalingPolicyConfiguration")]
    public V1beta2PolicySpecForProviderStepScalingPolicyConfiguration? StepScalingPolicyConfiguration { get; set; }

    /// <summary>Target tracking policy configuration, requires policy_type = &quot;TargetTrackingScaling&quot;. See supported fields below.</summary>
    [JsonPropertyName("targetTrackingScalingPolicyConfiguration")]
    public V1beta2PolicySpecForProviderTargetTrackingScalingPolicyConfiguration? TargetTrackingScalingPolicyConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetricDimension
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
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

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
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQuery
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
    public V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized capacity metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetricDimension
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
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

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
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery
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
    public V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized load metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetricDimension
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
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

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
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQuery
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
    public V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized scaling metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

/// <summary>Predefined load metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification
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
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification
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
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification
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
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecification
{
    /// <summary>Customized capacity metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedCapacityMetricSpecification")]
    public V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification? CustomizedCapacityMetricSpecification { get; set; }

    /// <summary>Customized load metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Customized scaling metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Predefined load metric specification. See supported fields below.</summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>Predefined metric pair specification that determines the appropriate scaling metric and load metric to use. See supported fields below.</summary>
    [JsonPropertyName("predefinedMetricPairSpecification")]
    public V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification { get; set; }

    /// <summary>Predefined scaling metric specification. See supported fields below.</summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public string? TargetValue { get; set; }
}

/// <summary>Predictive scaling policy configuration, requires policy_type = &quot;PredictiveScaling&quot;. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfiguration
{
    /// <summary>The behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity. Valid values are HonorMaxCapacity and IncreaseMaxCapacity.</summary>
    [JsonPropertyName("maxCapacityBreachBehavior")]
    public string? MaxCapacityBreachBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity. The value is specified as a percentage relative to the forecast capacity. Required if the max_capacity_breach_behavior argument is set to IncreaseMaxCapacity, and cannot be used otherwise.</summary>
    [JsonPropertyName("maxCapacityBuffer")]
    public double? MaxCapacityBuffer { get; set; }

    /// <summary>Metrics and target utilization to use for predictive scaling. See supported fields below.</summary>
    [JsonPropertyName("metricSpecification")]
    public IList<V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfigurationMetricSpecification>? MetricSpecification { get; set; }

    /// <summary>Predictive scaling mode. Valid values are ForecastOnly and ForecastAndScale.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Amount of time, in seconds, that the start time can be advanced.</summary>
    [JsonPropertyName("schedulingBufferTime")]
    public double? SchedulingBufferTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderStepScalingPolicyConfigurationStepAdjustment
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
public partial class V1beta2PolicySpecInitProviderStepScalingPolicyConfiguration
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
    public IList<V1beta2PolicySpecInitProviderStepScalingPolicyConfigurationStepAdjustment>? StepAdjustment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions
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
public partial class V1beta2PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions
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
public partial class V1beta2PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric
{
    /// <summary>Configuration block(s) with the dimensions of the metric if the metric was published with dimensions. Detailed below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions>? Dimensions { get; set; }

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
public partial class V1beta2PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetrics
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
    public V1beta2PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Custom CloudWatch metric. Documentation can be found  at: AWS Customized Metric Specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification
{
    /// <summary>Configuration block(s) with the dimensions of the metric if the metric was published with dimensions. Detailed below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Metrics to include, as a metric data query.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta2PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetrics>? Metrics { get; set; }

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
public partial class V1beta2PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification
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
public partial class V1beta2PolicySpecInitProviderTargetTrackingScalingPolicyConfiguration
{
    /// <summary>Custom CloudWatch metric. Documentation can be found  at: AWS Customized Metric Specification. See supported fields below.</summary>
    [JsonPropertyName("customizedMetricSpecification")]
    public V1beta2PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification { get; set; }

    /// <summary>Whether scale in by the target tracking policy is disabled. If the value is true, scale in is disabled and the target tracking policy won&apos;t remove capacity from the scalable resource. Otherwise, scale in is enabled and the target tracking policy can remove capacity from the scalable resource. The default value is false.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>Predefined metric. See supported fields below.</summary>
    [JsonPropertyName("predefinedMetricSpecification")]
    public V1beta2PolicySpecInitProviderTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification { get; set; }

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
public partial class V1beta2PolicySpecInitProvider
{
    /// <summary>Policy type. Valid values are StepScaling, TargetTrackingScaling, and PredictiveScaling. Defaults to StepScaling. Certain services only support only one policy type. For more information see the Target Tracking Scaling Policies, Step Scaling Policies, and Predictive Scaling documentation.</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>Predictive scaling policy configuration, requires policy_type = &quot;PredictiveScaling&quot;. See supported fields below.</summary>
    [JsonPropertyName("predictiveScalingPolicyConfiguration")]
    public V1beta2PolicySpecInitProviderPredictiveScalingPolicyConfiguration? PredictiveScalingPolicyConfiguration { get; set; }

    /// <summary>Step scaling policy configuration, requires policy_type = &quot;StepScaling&quot; (default). See supported fields below.</summary>
    [JsonPropertyName("stepScalingPolicyConfiguration")]
    public V1beta2PolicySpecInitProviderStepScalingPolicyConfiguration? StepScalingPolicyConfiguration { get; set; }

    /// <summary>Target tracking policy configuration, requires policy_type = &quot;TargetTrackingScaling&quot;. See supported fields below.</summary>
    [JsonPropertyName("targetTrackingScalingPolicyConfiguration")]
    public V1beta2PolicySpecInitProviderTargetTrackingScalingPolicyConfiguration? TargetTrackingScalingPolicyConfiguration { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecManagementPoliciesEnum>))]
public enum V1beta2PolicySpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2PolicySpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2PolicySpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PolicySpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>PolicySpec defines the desired state of Policy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpec
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
    public V1beta2PolicySpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2PolicySpecForProvider ForProvider { get; set; }

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
    public V1beta2PolicySpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2PolicySpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2PolicySpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2PolicySpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetricDimension
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
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

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
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQuery
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
    public V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized capacity metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetricDimension
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
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

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
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery
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
    public V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized load metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetricDimension
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
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetric
{
    /// <summary>Dimensions of the metric. See supported fields below.</summary>
    [JsonPropertyName("dimension")]
    public IList<V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetricDimension>? Dimension { get; set; }

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
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQuery
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
    public V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueryMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized scaling metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification
{
    /// <summary>One or more metric data queries to provide data points for a metric specification. See supported fields below.</summary>
    [JsonPropertyName("metricDataQuery")]
    public IList<V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQuery>? MetricDataQuery { get; set; }
}

/// <summary>Predefined load metric specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification
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
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification
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
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification
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
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecification
{
    /// <summary>Customized capacity metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedCapacityMetricSpecification")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedCapacityMetricSpecification? CustomizedCapacityMetricSpecification { get; set; }

    /// <summary>Customized load metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Customized scaling metric specification. See supported fields below.</summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Predefined load metric specification. See supported fields below.</summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>Predefined metric pair specification that determines the appropriate scaling metric and load metric to use. See supported fields below.</summary>
    [JsonPropertyName("predefinedMetricPairSpecification")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification { get; set; }

    /// <summary>Predefined scaling metric specification. See supported fields below.</summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public string? TargetValue { get; set; }
}

/// <summary>Predictive scaling policy configuration, requires policy_type = &quot;PredictiveScaling&quot;. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfiguration
{
    /// <summary>The behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity. Valid values are HonorMaxCapacity and IncreaseMaxCapacity.</summary>
    [JsonPropertyName("maxCapacityBreachBehavior")]
    public string? MaxCapacityBreachBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity. The value is specified as a percentage relative to the forecast capacity. Required if the max_capacity_breach_behavior argument is set to IncreaseMaxCapacity, and cannot be used otherwise.</summary>
    [JsonPropertyName("maxCapacityBuffer")]
    public double? MaxCapacityBuffer { get; set; }

    /// <summary>Metrics and target utilization to use for predictive scaling. See supported fields below.</summary>
    [JsonPropertyName("metricSpecification")]
    public IList<V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfigurationMetricSpecification>? MetricSpecification { get; set; }

    /// <summary>Predictive scaling mode. Valid values are ForecastOnly and ForecastAndScale.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Amount of time, in seconds, that the start time can be advanced.</summary>
    [JsonPropertyName("schedulingBufferTime")]
    public double? SchedulingBufferTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderStepScalingPolicyConfigurationStepAdjustment
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
public partial class V1beta2PolicyStatusAtProviderStepScalingPolicyConfiguration
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
    public IList<V1beta2PolicyStatusAtProviderStepScalingPolicyConfigurationStepAdjustment>? StepAdjustment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions
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
public partial class V1beta2PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions
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
public partial class V1beta2PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric
{
    /// <summary>Configuration block(s) with the dimensions of the metric if the metric was published with dimensions. Detailed below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions>? Dimensions { get; set; }

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
public partial class V1beta2PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetrics
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
    public V1beta2PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetricsMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Custom CloudWatch metric. Documentation can be found  at: AWS Customized Metric Specification. See supported fields below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification
{
    /// <summary>Configuration block(s) with the dimensions of the metric if the metric was published with dimensions. Detailed below.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Metrics to include, as a metric data query.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta2PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationMetrics>? Metrics { get; set; }

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
public partial class V1beta2PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification
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
public partial class V1beta2PolicyStatusAtProviderTargetTrackingScalingPolicyConfiguration
{
    /// <summary>Custom CloudWatch metric. Documentation can be found  at: AWS Customized Metric Specification. See supported fields below.</summary>
    [JsonPropertyName("customizedMetricSpecification")]
    public V1beta2PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification { get; set; }

    /// <summary>Whether scale in by the target tracking policy is disabled. If the value is true, scale in is disabled and the target tracking policy won&apos;t remove capacity from the scalable resource. Otherwise, scale in is enabled and the target tracking policy can remove capacity from the scalable resource. The default value is false.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>Predefined metric. See supported fields below.</summary>
    [JsonPropertyName("predefinedMetricSpecification")]
    public V1beta2PolicyStatusAtProviderTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification { get; set; }

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
public partial class V1beta2PolicyStatusAtProvider
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
    public V1beta2PolicyStatusAtProviderPredictiveScalingPolicyConfiguration? PredictiveScalingPolicyConfiguration { get; set; }

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
    public V1beta2PolicyStatusAtProviderStepScalingPolicyConfiguration? StepScalingPolicyConfiguration { get; set; }

    /// <summary>Target tracking policy configuration, requires policy_type = &quot;TargetTrackingScaling&quot;. See supported fields below.</summary>
    [JsonPropertyName("targetTrackingScalingPolicyConfiguration")]
    public V1beta2PolicyStatusAtProviderTargetTrackingScalingPolicyConfiguration? TargetTrackingScalingPolicyConfiguration { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusConditions
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
public partial class V1beta2PolicyStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2PolicyStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2PolicyStatusConditions>? Conditions { get; set; }

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
public partial class V1beta2Policy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2PolicySpec>, IStatus<V1beta2PolicyStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Policy";
    public const string KubeGroup = "appautoscaling.aws.upbound.io";
    public const string KubePluralName = "policies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "appautoscaling.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Policy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PolicySpec defines the desired state of Policy</summary>
    [JsonPropertyName("spec")]
    public required V1beta2PolicySpec Spec { get; set; }

    /// <summary>PolicyStatus defines the observed state of Policy.</summary>
    [JsonPropertyName("status")]
    public V1beta2PolicyStatus? Status { get; set; }
}