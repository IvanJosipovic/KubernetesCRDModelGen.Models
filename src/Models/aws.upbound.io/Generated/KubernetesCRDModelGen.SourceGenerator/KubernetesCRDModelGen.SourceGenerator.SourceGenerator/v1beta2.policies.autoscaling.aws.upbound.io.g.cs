#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.autoscaling.aws.upbound.io;
/// <summary>Policy is the Schema for the Policys API. Provides an AutoScaling Scaling Group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2PolicyList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Policy>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "PolicyList";
    public const string KubeGroup = "autoscaling.aws.upbound.io";
    public const string KubePluralName = "policies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "autoscaling.aws.upbound.io/v1beta2";

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

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderAutoscalingGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2PolicySpecForProviderAutoscalingGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderAutoscalingGroupNameRefPolicyResolveEnum>))]
public enum V1beta2PolicySpecForProviderAutoscalingGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderAutoscalingGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecForProviderAutoscalingGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecForProviderAutoscalingGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a AutoscalingGroup in autoscaling to populate autoscalingGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderAutoscalingGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2PolicySpecForProviderAutoscalingGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderAutoscalingGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2PolicySpecForProviderAutoscalingGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2PolicySpecForProviderAutoscalingGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2PolicySpecForProviderAutoscalingGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderAutoscalingGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2PolicySpecForProviderAutoscalingGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2PolicySpecForProviderAutoscalingGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a AutoscalingGroup in autoscaling to populate autoscalingGroupName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderAutoscalingGroupNameSelector
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
    public V1beta2PolicySpecForProviderAutoscalingGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

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
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueries
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
    public V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized capacity metric specification. The field is only valid when you use customized_load_metric_specification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

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
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueries
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
    public V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized load metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

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
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueries
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
    public V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized scaling metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

/// <summary>Predefined load metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Metric pair specification from which Amazon EC2 Auto Scaling determines the appropriate scaling metric and load metric to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Predefined scaling metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>This structure includes the metrics and target utilization to use for predictive scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecification
{
    /// <summary>Customized capacity metric specification. The field is only valid when you use customized_load_metric_specification</summary>
    [JsonPropertyName("customizedCapacityMetricSpecification")]
    public V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecification? CustomizedCapacityMetricSpecification { get; set; }

    /// <summary>Customized load metric specification.</summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Customized scaling metric specification.</summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Predefined load metric specification.</summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>Metric pair specification from which Amazon EC2 Auto Scaling determines the appropriate scaling metric and load metric to use.</summary>
    [JsonPropertyName("predefinedMetricPairSpecification")]
    public V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification { get; set; }

    /// <summary>Predefined scaling metric specification.</summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

/// <summary>Predictive scaling policy configuration to use with Amazon EC2 Auto Scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderPredictiveScalingConfiguration
{
    /// <summary>Defines the behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity of the Auto Scaling group. Valid values are HonorMaxCapacity or IncreaseMaxCapacity. Default is HonorMaxCapacity.</summary>
    [JsonPropertyName("maxCapacityBreachBehavior")]
    public string? MaxCapacityBreachBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity. Valid range is 0 to 100. If set to 0, Amazon EC2 Auto Scaling may scale capacity higher than the maximum capacity to equal but not exceed forecast capacity.</summary>
    [JsonPropertyName("maxCapacityBuffer")]
    public string? MaxCapacityBuffer { get; set; }

    /// <summary>This structure includes the metrics and target utilization to use for predictive scaling.</summary>
    [JsonPropertyName("metricSpecification")]
    public V1beta2PolicySpecForProviderPredictiveScalingConfigurationMetricSpecification? MetricSpecification { get; set; }

    /// <summary>Predictive scaling mode. Valid values are ForecastAndScale and ForecastOnly. Default is ForecastOnly.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Amount of time, in seconds, by which the instance launch time can be advanced. Minimum is 0.</summary>
    [JsonPropertyName("schedulingBufferTime")]
    public string? SchedulingBufferTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderStepAdjustment
{
    /// <summary>
    /// Lower bound for the
    /// difference between the alarm threshold and the CloudWatch metric.
    /// Without a value, AWS will treat this bound as negative infinity.
    /// </summary>
    [JsonPropertyName("metricIntervalLowerBound")]
    public string? MetricIntervalLowerBound { get; set; }

    /// <summary>
    /// Upper bound for the
    /// difference between the alarm threshold and the CloudWatch metric.
    /// Without a value, AWS will treat this bound as positive infinity. The upper bound
    /// must be greater than the lower bound.
    /// </summary>
    [JsonPropertyName("metricIntervalUpperBound")]
    public string? MetricIntervalUpperBound { get; set; }

    /// <summary>Number of instances by which to scale. adjustment_type determines the interpretation of this number (e.g., as an absolute number or as a percentage of the existing Auto Scaling group size). A positive increment adds to the current capacity and a negative value removes from the current capacity.</summary>
    [JsonPropertyName("scalingAdjustment")]
    public double? ScalingAdjustment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions>? Dimensions { get; set; }

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
public partial class V1beta2PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric? Metric { get; set; }

    /// <summary>The period of the metric in seconds.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetrics
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
    public V1beta2PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized metric. Conflicts with predefined_metric_specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("metricDimension")]
    public IList<V1beta2PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension>? MetricDimension { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Metrics to include, as a metric data query.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta2PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetrics>? Metrics { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The period of the metric in seconds.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Statistic of the metric.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>Predefined metric. Conflicts with customized_metric_specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderTargetTrackingConfigurationPredefinedMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Target tracking policy. These have the following structure:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProviderTargetTrackingConfiguration
{
    /// <summary>Customized metric. Conflicts with predefined_metric_specification.</summary>
    [JsonPropertyName("customizedMetricSpecification")]
    public V1beta2PolicySpecForProviderTargetTrackingConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification { get; set; }

    /// <summary>Whether scale in by the target tracking policy is disabled.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>Predefined metric. Conflicts with customized_metric_specification.</summary>
    [JsonPropertyName("predefinedMetricSpecification")]
    public V1beta2PolicySpecForProviderTargetTrackingConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecForProvider
{
    /// <summary>Whether the adjustment is an absolute number or a percentage of the current capacity. Valid values are ChangeInCapacity, ExactCapacity, and PercentChangeInCapacity.</summary>
    [JsonPropertyName("adjustmentType")]
    public string? AdjustmentType { get; set; }

    /// <summary>Name of the autoscaling group.</summary>
    [JsonPropertyName("autoscalingGroupName")]
    public string? AutoscalingGroupName { get; set; }

    /// <summary>Reference to a AutoscalingGroup in autoscaling to populate autoscalingGroupName.</summary>
    [JsonPropertyName("autoscalingGroupNameRef")]
    public V1beta2PolicySpecForProviderAutoscalingGroupNameRef? AutoscalingGroupNameRef { get; set; }

    /// <summary>Selector for a AutoscalingGroup in autoscaling to populate autoscalingGroupName.</summary>
    [JsonPropertyName("autoscalingGroupNameSelector")]
    public V1beta2PolicySpecForProviderAutoscalingGroupNameSelector? AutoscalingGroupNameSelector { get; set; }

    /// <summary>Amount of time, in seconds, after a scaling activity completes and before the next scaling activity can start.</summary>
    [JsonPropertyName("cooldown")]
    public double? Cooldown { get; set; }

    /// <summary>Whether the scaling policy is enabled or disabled. Default: true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Estimated time, in seconds, until a newly launched instance will contribute CloudWatch metrics. Without a value, AWS will default to the group&apos;s specified cooldown period.</summary>
    [JsonPropertyName("estimatedInstanceWarmup")]
    public double? EstimatedInstanceWarmup { get; set; }

    /// <summary>Aggregation type for the policy&apos;s metrics. Valid values are &quot;Minimum&quot;, &quot;Maximum&quot;, and &quot;Average&quot;. Without a value, AWS will treat the aggregation type as &quot;Average&quot;.</summary>
    [JsonPropertyName("metricAggregationType")]
    public string? MetricAggregationType { get; set; }

    /// <summary>Minimum value to scale by when adjustment_type is set to PercentChangeInCapacity.</summary>
    [JsonPropertyName("minAdjustmentMagnitude")]
    public double? MinAdjustmentMagnitude { get; set; }

    /// <summary>Policy type, either &quot;SimpleScaling&quot;, &quot;StepScaling&quot;, &quot;TargetTrackingScaling&quot;, or &quot;PredictiveScaling&quot;. If this value isn&apos;t provided, AWS will default to &quot;SimpleScaling.&quot;</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>Predictive scaling policy configuration to use with Amazon EC2 Auto Scaling.</summary>
    [JsonPropertyName("predictiveScalingConfiguration")]
    public V1beta2PolicySpecForProviderPredictiveScalingConfiguration? PredictiveScalingConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Number of instances by which to scale. adjustment_type determines the interpretation of this number (e.g., as an absolute number or as a percentage of the existing Auto Scaling group size). A positive increment adds to the current capacity and a negative value removes from the current capacity.</summary>
    [JsonPropertyName("scalingAdjustment")]
    public double? ScalingAdjustment { get; set; }

    /// <summary>
    /// Set of adjustments that manage
    /// group scaling. These have the following structure:
    /// </summary>
    [JsonPropertyName("stepAdjustment")]
    public IList<V1beta2PolicySpecForProviderStepAdjustment>? StepAdjustment { get; set; }

    /// <summary>Target tracking policy. These have the following structure:</summary>
    [JsonPropertyName("targetTrackingConfiguration")]
    public V1beta2PolicySpecForProviderTargetTrackingConfiguration? TargetTrackingConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

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
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueries
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
    public V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized capacity metric specification. The field is only valid when you use customized_load_metric_specification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

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
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueries
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
    public V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized load metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

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
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueries
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
    public V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized scaling metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

/// <summary>Predefined load metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Metric pair specification from which Amazon EC2 Auto Scaling determines the appropriate scaling metric and load metric to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Predefined scaling metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>This structure includes the metrics and target utilization to use for predictive scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecification
{
    /// <summary>Customized capacity metric specification. The field is only valid when you use customized_load_metric_specification</summary>
    [JsonPropertyName("customizedCapacityMetricSpecification")]
    public V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecification? CustomizedCapacityMetricSpecification { get; set; }

    /// <summary>Customized load metric specification.</summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Customized scaling metric specification.</summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Predefined load metric specification.</summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>Metric pair specification from which Amazon EC2 Auto Scaling determines the appropriate scaling metric and load metric to use.</summary>
    [JsonPropertyName("predefinedMetricPairSpecification")]
    public V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification { get; set; }

    /// <summary>Predefined scaling metric specification.</summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

/// <summary>Predictive scaling policy configuration to use with Amazon EC2 Auto Scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderPredictiveScalingConfiguration
{
    /// <summary>Defines the behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity of the Auto Scaling group. Valid values are HonorMaxCapacity or IncreaseMaxCapacity. Default is HonorMaxCapacity.</summary>
    [JsonPropertyName("maxCapacityBreachBehavior")]
    public string? MaxCapacityBreachBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity. Valid range is 0 to 100. If set to 0, Amazon EC2 Auto Scaling may scale capacity higher than the maximum capacity to equal but not exceed forecast capacity.</summary>
    [JsonPropertyName("maxCapacityBuffer")]
    public string? MaxCapacityBuffer { get; set; }

    /// <summary>This structure includes the metrics and target utilization to use for predictive scaling.</summary>
    [JsonPropertyName("metricSpecification")]
    public V1beta2PolicySpecInitProviderPredictiveScalingConfigurationMetricSpecification? MetricSpecification { get; set; }

    /// <summary>Predictive scaling mode. Valid values are ForecastAndScale and ForecastOnly. Default is ForecastOnly.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Amount of time, in seconds, by which the instance launch time can be advanced. Minimum is 0.</summary>
    [JsonPropertyName("schedulingBufferTime")]
    public string? SchedulingBufferTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderStepAdjustment
{
    /// <summary>
    /// Lower bound for the
    /// difference between the alarm threshold and the CloudWatch metric.
    /// Without a value, AWS will treat this bound as negative infinity.
    /// </summary>
    [JsonPropertyName("metricIntervalLowerBound")]
    public string? MetricIntervalLowerBound { get; set; }

    /// <summary>
    /// Upper bound for the
    /// difference between the alarm threshold and the CloudWatch metric.
    /// Without a value, AWS will treat this bound as positive infinity. The upper bound
    /// must be greater than the lower bound.
    /// </summary>
    [JsonPropertyName("metricIntervalUpperBound")]
    public string? MetricIntervalUpperBound { get; set; }

    /// <summary>Number of instances by which to scale. adjustment_type determines the interpretation of this number (e.g., as an absolute number or as a percentage of the existing Auto Scaling group size). A positive increment adds to the current capacity and a negative value removes from the current capacity.</summary>
    [JsonPropertyName("scalingAdjustment")]
    public double? ScalingAdjustment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions>? Dimensions { get; set; }

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
public partial class V1beta2PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric? Metric { get; set; }

    /// <summary>The period of the metric in seconds.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetrics
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
    public V1beta2PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized metric. Conflicts with predefined_metric_specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("metricDimension")]
    public IList<V1beta2PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension>? MetricDimension { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Metrics to include, as a metric data query.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta2PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetrics>? Metrics { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The period of the metric in seconds.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Statistic of the metric.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>Predefined metric. Conflicts with customized_metric_specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderTargetTrackingConfigurationPredefinedMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Target tracking policy. These have the following structure:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicySpecInitProviderTargetTrackingConfiguration
{
    /// <summary>Customized metric. Conflicts with predefined_metric_specification.</summary>
    [JsonPropertyName("customizedMetricSpecification")]
    public V1beta2PolicySpecInitProviderTargetTrackingConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification { get; set; }

    /// <summary>Whether scale in by the target tracking policy is disabled.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>Predefined metric. Conflicts with customized_metric_specification.</summary>
    [JsonPropertyName("predefinedMetricSpecification")]
    public V1beta2PolicySpecInitProviderTargetTrackingConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification { get; set; }

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
    /// <summary>Whether the adjustment is an absolute number or a percentage of the current capacity. Valid values are ChangeInCapacity, ExactCapacity, and PercentChangeInCapacity.</summary>
    [JsonPropertyName("adjustmentType")]
    public string? AdjustmentType { get; set; }

    /// <summary>Amount of time, in seconds, after a scaling activity completes and before the next scaling activity can start.</summary>
    [JsonPropertyName("cooldown")]
    public double? Cooldown { get; set; }

    /// <summary>Whether the scaling policy is enabled or disabled. Default: true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Estimated time, in seconds, until a newly launched instance will contribute CloudWatch metrics. Without a value, AWS will default to the group&apos;s specified cooldown period.</summary>
    [JsonPropertyName("estimatedInstanceWarmup")]
    public double? EstimatedInstanceWarmup { get; set; }

    /// <summary>Aggregation type for the policy&apos;s metrics. Valid values are &quot;Minimum&quot;, &quot;Maximum&quot;, and &quot;Average&quot;. Without a value, AWS will treat the aggregation type as &quot;Average&quot;.</summary>
    [JsonPropertyName("metricAggregationType")]
    public string? MetricAggregationType { get; set; }

    /// <summary>Minimum value to scale by when adjustment_type is set to PercentChangeInCapacity.</summary>
    [JsonPropertyName("minAdjustmentMagnitude")]
    public double? MinAdjustmentMagnitude { get; set; }

    /// <summary>Policy type, either &quot;SimpleScaling&quot;, &quot;StepScaling&quot;, &quot;TargetTrackingScaling&quot;, or &quot;PredictiveScaling&quot;. If this value isn&apos;t provided, AWS will default to &quot;SimpleScaling.&quot;</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>Predictive scaling policy configuration to use with Amazon EC2 Auto Scaling.</summary>
    [JsonPropertyName("predictiveScalingConfiguration")]
    public V1beta2PolicySpecInitProviderPredictiveScalingConfiguration? PredictiveScalingConfiguration { get; set; }

    /// <summary>Number of instances by which to scale. adjustment_type determines the interpretation of this number (e.g., as an absolute number or as a percentage of the existing Auto Scaling group size). A positive increment adds to the current capacity and a negative value removes from the current capacity.</summary>
    [JsonPropertyName("scalingAdjustment")]
    public double? ScalingAdjustment { get; set; }

    /// <summary>
    /// Set of adjustments that manage
    /// group scaling. These have the following structure:
    /// </summary>
    [JsonPropertyName("stepAdjustment")]
    public IList<V1beta2PolicySpecInitProviderStepAdjustment>? StepAdjustment { get; set; }

    /// <summary>Target tracking policy. These have the following structure:</summary>
    [JsonPropertyName("targetTrackingConfiguration")]
    public V1beta2PolicySpecInitProviderTargetTrackingConfiguration? TargetTrackingConfiguration { get; set; }
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
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

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
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueries
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
    public V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized capacity metric specification. The field is only valid when you use customized_load_metric_specification</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

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
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueries
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
    public V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized load metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetricDimensions>? Dimensions { get; set; }

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
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStatMetric? Metric { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueries
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
    public V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueriesMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized scaling metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecification
{
    /// <summary>List of up to 10 structures that defines custom scaling metric in predictive scaling policy</summary>
    [JsonPropertyName("metricDataQueries")]
    public IList<V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecificationMetricDataQueries>? MetricDataQueries { get; set; }
}

/// <summary>Predefined load metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Metric pair specification from which Amazon EC2 Auto Scaling determines the appropriate scaling metric and load metric to use.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Predefined scaling metric specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>This structure includes the metrics and target utilization to use for predictive scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecification
{
    /// <summary>Customized capacity metric specification. The field is only valid when you use customized_load_metric_specification</summary>
    [JsonPropertyName("customizedCapacityMetricSpecification")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedCapacityMetricSpecification? CustomizedCapacityMetricSpecification { get; set; }

    /// <summary>Customized load metric specification.</summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Customized scaling metric specification.</summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Predefined load metric specification.</summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>Metric pair specification from which Amazon EC2 Auto Scaling determines the appropriate scaling metric and load metric to use.</summary>
    [JsonPropertyName("predefinedMetricPairSpecification")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationPredefinedMetricPairSpecification? PredefinedMetricPairSpecification { get; set; }

    /// <summary>Predefined scaling metric specification.</summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecificationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

/// <summary>Predictive scaling policy configuration to use with Amazon EC2 Auto Scaling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderPredictiveScalingConfiguration
{
    /// <summary>Defines the behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity of the Auto Scaling group. Valid values are HonorMaxCapacity or IncreaseMaxCapacity. Default is HonorMaxCapacity.</summary>
    [JsonPropertyName("maxCapacityBreachBehavior")]
    public string? MaxCapacityBreachBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity. Valid range is 0 to 100. If set to 0, Amazon EC2 Auto Scaling may scale capacity higher than the maximum capacity to equal but not exceed forecast capacity.</summary>
    [JsonPropertyName("maxCapacityBuffer")]
    public string? MaxCapacityBuffer { get; set; }

    /// <summary>This structure includes the metrics and target utilization to use for predictive scaling.</summary>
    [JsonPropertyName("metricSpecification")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingConfigurationMetricSpecification? MetricSpecification { get; set; }

    /// <summary>Predictive scaling mode. Valid values are ForecastAndScale and ForecastOnly. Default is ForecastOnly.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Amount of time, in seconds, by which the instance launch time can be advanced. Minimum is 0.</summary>
    [JsonPropertyName("schedulingBufferTime")]
    public string? SchedulingBufferTime { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderStepAdjustment
{
    /// <summary>
    /// Lower bound for the
    /// difference between the alarm threshold and the CloudWatch metric.
    /// Without a value, AWS will treat this bound as negative infinity.
    /// </summary>
    [JsonPropertyName("metricIntervalLowerBound")]
    public string? MetricIntervalLowerBound { get; set; }

    /// <summary>
    /// Upper bound for the
    /// difference between the alarm threshold and the CloudWatch metric.
    /// Without a value, AWS will treat this bound as positive infinity. The upper bound
    /// must be greater than the lower bound.
    /// </summary>
    [JsonPropertyName("metricIntervalUpperBound")]
    public string? MetricIntervalUpperBound { get; set; }

    /// <summary>Number of instances by which to scale. adjustment_type determines the interpretation of this number (e.g., as an absolute number or as a percentage of the existing Auto Scaling group size). A positive increment adds to the current capacity and a negative value removes from the current capacity.</summary>
    [JsonPropertyName("scalingAdjustment")]
    public double? ScalingAdjustment { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions
{
    /// <summary>Name of the policy.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of the dimension.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1beta2PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetricDimensions>? Dimensions { get; set; }

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
public partial class V1beta2PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStat
{
    /// <summary>Structure that defines the CloudWatch metric to return, including the metric name, namespace, and dimensions.</summary>
    [JsonPropertyName("metric")]
    public V1beta2PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStatMetric? Metric { get; set; }

    /// <summary>The period of the metric in seconds.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Statistic of the metrics to return.</summary>
    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetrics
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
    public V1beta2PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricsMetricStat? MetricStat { get; set; }

    /// <summary>Boolean that indicates whether to return the timestamps and raw data values of this metric, the default is true</summary>
    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>Customized metric. Conflicts with predefined_metric_specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("metricDimension")]
    public IList<V1beta2PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetricDimension>? MetricDimension { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Metrics to include, as a metric data query.</summary>
    [JsonPropertyName("metrics")]
    public IList<V1beta2PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecificationMetrics>? Metrics { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>The period of the metric in seconds.</summary>
    [JsonPropertyName("period")]
    public double? Period { get; set; }

    /// <summary>Statistic of the metric.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>Predefined metric. Conflicts with customized_metric_specification.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderTargetTrackingConfigurationPredefinedMetricSpecification
{
    /// <summary>Metric type.</summary>
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>Target tracking policy. These have the following structure:</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProviderTargetTrackingConfiguration
{
    /// <summary>Customized metric. Conflicts with predefined_metric_specification.</summary>
    [JsonPropertyName("customizedMetricSpecification")]
    public V1beta2PolicyStatusAtProviderTargetTrackingConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification { get; set; }

    /// <summary>Whether scale in by the target tracking policy is disabled.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>Predefined metric. Conflicts with customized_metric_specification.</summary>
    [JsonPropertyName("predefinedMetricSpecification")]
    public V1beta2PolicyStatusAtProviderTargetTrackingConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2PolicyStatusAtProvider
{
    /// <summary>Whether the adjustment is an absolute number or a percentage of the current capacity. Valid values are ChangeInCapacity, ExactCapacity, and PercentChangeInCapacity.</summary>
    [JsonPropertyName("adjustmentType")]
    public string? AdjustmentType { get; set; }

    /// <summary>ARN assigned by AWS to the scaling policy.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Name of the autoscaling group.</summary>
    [JsonPropertyName("autoscalingGroupName")]
    public string? AutoscalingGroupName { get; set; }

    /// <summary>Amount of time, in seconds, after a scaling activity completes and before the next scaling activity can start.</summary>
    [JsonPropertyName("cooldown")]
    public double? Cooldown { get; set; }

    /// <summary>Whether the scaling policy is enabled or disabled. Default: true.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Estimated time, in seconds, until a newly launched instance will contribute CloudWatch metrics. Without a value, AWS will default to the group&apos;s specified cooldown period.</summary>
    [JsonPropertyName("estimatedInstanceWarmup")]
    public double? EstimatedInstanceWarmup { get; set; }

    /// <summary>Short name for the metric used in target tracking scaling policy.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Aggregation type for the policy&apos;s metrics. Valid values are &quot;Minimum&quot;, &quot;Maximum&quot;, and &quot;Average&quot;. Without a value, AWS will treat the aggregation type as &quot;Average&quot;.</summary>
    [JsonPropertyName("metricAggregationType")]
    public string? MetricAggregationType { get; set; }

    /// <summary>Minimum value to scale by when adjustment_type is set to PercentChangeInCapacity.</summary>
    [JsonPropertyName("minAdjustmentMagnitude")]
    public double? MinAdjustmentMagnitude { get; set; }

    /// <summary>Policy type, either &quot;SimpleScaling&quot;, &quot;StepScaling&quot;, &quot;TargetTrackingScaling&quot;, or &quot;PredictiveScaling&quot;. If this value isn&apos;t provided, AWS will default to &quot;SimpleScaling.&quot;</summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>Predictive scaling policy configuration to use with Amazon EC2 Auto Scaling.</summary>
    [JsonPropertyName("predictiveScalingConfiguration")]
    public V1beta2PolicyStatusAtProviderPredictiveScalingConfiguration? PredictiveScalingConfiguration { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Number of instances by which to scale. adjustment_type determines the interpretation of this number (e.g., as an absolute number or as a percentage of the existing Auto Scaling group size). A positive increment adds to the current capacity and a negative value removes from the current capacity.</summary>
    [JsonPropertyName("scalingAdjustment")]
    public double? ScalingAdjustment { get; set; }

    /// <summary>
    /// Set of adjustments that manage
    /// group scaling. These have the following structure:
    /// </summary>
    [JsonPropertyName("stepAdjustment")]
    public IList<V1beta2PolicyStatusAtProviderStepAdjustment>? StepAdjustment { get; set; }

    /// <summary>Target tracking policy. These have the following structure:</summary>
    [JsonPropertyName("targetTrackingConfiguration")]
    public V1beta2PolicyStatusAtProviderTargetTrackingConfiguration? TargetTrackingConfiguration { get; set; }
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

/// <summary>Policy is the Schema for the Policys API. Provides an AutoScaling Scaling Group resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Policy : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2PolicySpec>, IStatus<V1beta2PolicyStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Policy";
    public const string KubeGroup = "autoscaling.aws.upbound.io";
    public const string KubePluralName = "policies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "autoscaling.aws.upbound.io/v1beta2";

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