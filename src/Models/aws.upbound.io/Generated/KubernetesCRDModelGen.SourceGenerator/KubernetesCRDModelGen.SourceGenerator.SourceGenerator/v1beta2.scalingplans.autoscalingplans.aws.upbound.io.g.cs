#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.autoscalingplans.aws.upbound.io;
/// <summary>ScalingPlan is the Schema for the ScalingPlans API. Manages an AWS Auto Scaling scaling plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ScalingPlanList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ScalingPlan>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ScalingPlanList";
    public const string KubeGroup = "autoscalingplans.aws.upbound.io";
    public const string KubePluralName = "scalingplans";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "autoscalingplans.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ScalingPlanList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ScalingPlan objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ScalingPlan> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScalingPlanSpecDeletionPolicyEnum>))]
public enum V1beta2ScalingPlanSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecForProviderApplicationSourceTagFilter
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Tag values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>CloudFormation stack or set of tags. You can create one scaling plan per application source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecForProviderApplicationSource
{
    /// <summary>ARN of a AWS CloudFormation stack.</summary>
    [JsonPropertyName("cloudformationStackArn")]
    public string? CloudformationStackArn { get; set; }

    /// <summary>Set of tags.</summary>
    [JsonPropertyName("tagFilter")]
    public IList<V1beta2ScalingPlanSpecForProviderApplicationSourceTagFilter>? TagFilter { get; set; }
}

/// <summary>
/// Customized load metric to use for predictive scaling. You must specify either customized_load_metric_specification or predefined_load_metric_specification when configuring predictive scaling.
/// More details can be found in the AWS Auto Scaling API Reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecForProviderScalingInstructionCustomizedLoadMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Statistic of the metric. Currently, the value must always be Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>
/// Predefined load metric to use for predictive scaling. You must specify either predefined_load_metric_specification or customized_load_metric_specification when configuring predictive scaling.
/// More details can be found in the AWS Auto Scaling API Reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecForProviderScalingInstructionPredefinedLoadMetricSpecification
{
    /// <summary>Metric type. Valid values: ALBTargetGroupRequestCount, ASGTotalCPUUtilization, ASGTotalNetworkIn, ASGTotalNetworkOut.</summary>
    [JsonPropertyName("predefinedLoadMetricType")]
    public string? PredefinedLoadMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>
/// Customized metric. You can specify either customized_scaling_metric_specification or predefined_scaling_metric_specification.
/// More details can be found in the AWS Auto Scaling API Reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecForProviderScalingInstructionTargetTrackingConfigurationCustomizedScalingMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Statistic of the metric. Currently, the value must always be Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>
/// Predefined metric. You can specify either predefined_scaling_metric_specification or customized_scaling_metric_specification.
/// More details can be found in the AWS Auto Scaling API Reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecForProviderScalingInstructionTargetTrackingConfigurationPredefinedScalingMetricSpecification
{
    /// <summary>Metric type. Valid values: ALBRequestCountPerTarget, ASGAverageCPUUtilization, ASGAverageNetworkIn, ASGAverageNetworkOut, DynamoDBReadCapacityUtilization, DynamoDBWriteCapacityUtilization, ECSServiceAverageCPUUtilization, ECSServiceAverageMemoryUtilization, EC2SpotFleetRequestAverageCPUUtilization, EC2SpotFleetRequestAverageNetworkIn, EC2SpotFleetRequestAverageNetworkOut, RDSReaderAverageCPUUtilization, RDSReaderAverageDatabaseConnections.</summary>
    [JsonPropertyName("predefinedScalingMetricType")]
    public string? PredefinedScalingMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecForProviderScalingInstructionTargetTrackingConfiguration
{
    /// <summary>
    /// Customized metric. You can specify either customized_scaling_metric_specification or predefined_scaling_metric_specification.
    /// More details can be found in the AWS Auto Scaling API Reference.
    /// </summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public V1beta2ScalingPlanSpecForProviderScalingInstructionTargetTrackingConfigurationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Boolean indicating whether scale in by the target tracking scaling policy is disabled. Defaults to false.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>
    /// Estimated time, in seconds, until a newly launched instance can contribute to the CloudWatch metrics.
    /// This value is used only if the resource is an Auto Scaling group.
    /// </summary>
    [JsonPropertyName("estimatedInstanceWarmup")]
    public double? EstimatedInstanceWarmup { get; set; }

    /// <summary>
    /// Predefined metric. You can specify either predefined_scaling_metric_specification or customized_scaling_metric_specification.
    /// More details can be found in the AWS Auto Scaling API Reference.
    /// </summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public V1beta2ScalingPlanSpecForProviderScalingInstructionTargetTrackingConfigurationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>
    /// Amount of time, in seconds, after a scale in activity completes before another scale in activity can start.
    /// This value is not used if the scalable resource is an Auto Scaling group.
    /// </summary>
    [JsonPropertyName("scaleInCooldown")]
    public double? ScaleInCooldown { get; set; }

    /// <summary>
    /// Amount of time, in seconds, after a scale-out activity completes before another scale-out activity can start.
    /// This value is not used if the scalable resource is an Auto Scaling group.
    /// </summary>
    [JsonPropertyName("scaleOutCooldown")]
    public double? ScaleOutCooldown { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecForProviderScalingInstruction
{
    /// <summary>
    /// Customized load metric to use for predictive scaling. You must specify either customized_load_metric_specification or predefined_load_metric_specification when configuring predictive scaling.
    /// More details can be found in the AWS Auto Scaling API Reference.
    /// </summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public V1beta2ScalingPlanSpecForProviderScalingInstructionCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Boolean controlling whether dynamic scaling by AWS Auto Scaling is disabled. Defaults to false.</summary>
    [JsonPropertyName("disableDynamicScaling")]
    public bool? DisableDynamicScaling { get; set; }

    /// <summary>Maximum capacity of the resource. The exception to this upper limit is if you specify a non-default setting for predictive_scaling_max_capacity_behavior.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity of the resource.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>
    /// Predefined load metric to use for predictive scaling. You must specify either predefined_load_metric_specification or customized_load_metric_specification when configuring predictive scaling.
    /// More details can be found in the AWS Auto Scaling API Reference.
    /// </summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public V1beta2ScalingPlanSpecForProviderScalingInstructionPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>
    /// Defines the behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity specified for the resource.
    /// Valid values: SetForecastCapacityToMaxCapacity, SetMaxCapacityAboveForecastCapacity, SetMaxCapacityToForecastCapacity.
    /// </summary>
    [JsonPropertyName("predictiveScalingMaxCapacityBehavior")]
    public string? PredictiveScalingMaxCapacityBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity.</summary>
    [JsonPropertyName("predictiveScalingMaxCapacityBuffer")]
    public double? PredictiveScalingMaxCapacityBuffer { get; set; }

    /// <summary>Predictive scaling mode. Valid values: ForecastAndScale, ForecastOnly.</summary>
    [JsonPropertyName("predictiveScalingMode")]
    public string? PredictiveScalingMode { get; set; }

    /// <summary>ID of the resource. This string consists of the resource type and unique identifier.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Scalable dimension associated with the resource. Valid values: autoscaling:autoScalingGroup:DesiredCapacity, dynamodb:index:ReadCapacityUnits, dynamodb:index:WriteCapacityUnits, dynamodb:table:ReadCapacityUnits, dynamodb:table:WriteCapacityUnits, ecs:service:DesiredCount, ec2:spot-fleet-request:TargetCapacity, rds:cluster:ReadReplicaCount.</summary>
    [JsonPropertyName("scalableDimension")]
    public string? ScalableDimension { get; set; }

    /// <summary>Controls whether a resource&apos;s externally created scaling policies are kept or replaced. Valid values: KeepExternalPolicies, ReplaceExternalPolicies. Defaults to KeepExternalPolicies.</summary>
    [JsonPropertyName("scalingPolicyUpdateBehavior")]
    public string? ScalingPolicyUpdateBehavior { get; set; }

    /// <summary>Amount of time, in seconds, to buffer the run time of scheduled scaling actions when scaling out.</summary>
    [JsonPropertyName("scheduledActionBufferTime")]
    public double? ScheduledActionBufferTime { get; set; }

    /// <summary>Namespace of the AWS service. Valid values: autoscaling, dynamodb, ecs, ec2, rds.</summary>
    [JsonPropertyName("serviceNamespace")]
    public string? ServiceNamespace { get; set; }

    /// <summary>
    /// Structure that defines new target tracking configurations. Each of these structures includes a specific scaling metric and a target value for the metric, along with various parameters to use with dynamic scaling.
    /// More details can be found in the AWS Auto Scaling API Reference.
    /// </summary>
    [JsonPropertyName("targetTrackingConfiguration")]
    public IList<V1beta2ScalingPlanSpecForProviderScalingInstructionTargetTrackingConfiguration>? TargetTrackingConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecForProvider
{
    /// <summary>CloudFormation stack or set of tags. You can create one scaling plan per application source.</summary>
    [JsonPropertyName("applicationSource")]
    public V1beta2ScalingPlanSpecForProviderApplicationSource? ApplicationSource { get; set; }

    /// <summary>Name of the scaling plan. Names cannot contain vertical bars, colons, or forward slashes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Scaling instructions. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("scalingInstruction")]
    public IList<V1beta2ScalingPlanSpecForProviderScalingInstruction>? ScalingInstruction { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecInitProviderApplicationSourceTagFilter
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Tag values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>CloudFormation stack or set of tags. You can create one scaling plan per application source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecInitProviderApplicationSource
{
    /// <summary>ARN of a AWS CloudFormation stack.</summary>
    [JsonPropertyName("cloudformationStackArn")]
    public string? CloudformationStackArn { get; set; }

    /// <summary>Set of tags.</summary>
    [JsonPropertyName("tagFilter")]
    public IList<V1beta2ScalingPlanSpecInitProviderApplicationSourceTagFilter>? TagFilter { get; set; }
}

/// <summary>
/// Customized load metric to use for predictive scaling. You must specify either customized_load_metric_specification or predefined_load_metric_specification when configuring predictive scaling.
/// More details can be found in the AWS Auto Scaling API Reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecInitProviderScalingInstructionCustomizedLoadMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Statistic of the metric. Currently, the value must always be Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>
/// Predefined load metric to use for predictive scaling. You must specify either predefined_load_metric_specification or customized_load_metric_specification when configuring predictive scaling.
/// More details can be found in the AWS Auto Scaling API Reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecInitProviderScalingInstructionPredefinedLoadMetricSpecification
{
    /// <summary>Metric type. Valid values: ALBTargetGroupRequestCount, ASGTotalCPUUtilization, ASGTotalNetworkIn, ASGTotalNetworkOut.</summary>
    [JsonPropertyName("predefinedLoadMetricType")]
    public string? PredefinedLoadMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>
/// Customized metric. You can specify either customized_scaling_metric_specification or predefined_scaling_metric_specification.
/// More details can be found in the AWS Auto Scaling API Reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecInitProviderScalingInstructionTargetTrackingConfigurationCustomizedScalingMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Statistic of the metric. Currently, the value must always be Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>
/// Predefined metric. You can specify either predefined_scaling_metric_specification or customized_scaling_metric_specification.
/// More details can be found in the AWS Auto Scaling API Reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecInitProviderScalingInstructionTargetTrackingConfigurationPredefinedScalingMetricSpecification
{
    /// <summary>Metric type. Valid values: ALBRequestCountPerTarget, ASGAverageCPUUtilization, ASGAverageNetworkIn, ASGAverageNetworkOut, DynamoDBReadCapacityUtilization, DynamoDBWriteCapacityUtilization, ECSServiceAverageCPUUtilization, ECSServiceAverageMemoryUtilization, EC2SpotFleetRequestAverageCPUUtilization, EC2SpotFleetRequestAverageNetworkIn, EC2SpotFleetRequestAverageNetworkOut, RDSReaderAverageCPUUtilization, RDSReaderAverageDatabaseConnections.</summary>
    [JsonPropertyName("predefinedScalingMetricType")]
    public string? PredefinedScalingMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecInitProviderScalingInstructionTargetTrackingConfiguration
{
    /// <summary>
    /// Customized metric. You can specify either customized_scaling_metric_specification or predefined_scaling_metric_specification.
    /// More details can be found in the AWS Auto Scaling API Reference.
    /// </summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public V1beta2ScalingPlanSpecInitProviderScalingInstructionTargetTrackingConfigurationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Boolean indicating whether scale in by the target tracking scaling policy is disabled. Defaults to false.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>
    /// Estimated time, in seconds, until a newly launched instance can contribute to the CloudWatch metrics.
    /// This value is used only if the resource is an Auto Scaling group.
    /// </summary>
    [JsonPropertyName("estimatedInstanceWarmup")]
    public double? EstimatedInstanceWarmup { get; set; }

    /// <summary>
    /// Predefined metric. You can specify either predefined_scaling_metric_specification or customized_scaling_metric_specification.
    /// More details can be found in the AWS Auto Scaling API Reference.
    /// </summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public V1beta2ScalingPlanSpecInitProviderScalingInstructionTargetTrackingConfigurationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>
    /// Amount of time, in seconds, after a scale in activity completes before another scale in activity can start.
    /// This value is not used if the scalable resource is an Auto Scaling group.
    /// </summary>
    [JsonPropertyName("scaleInCooldown")]
    public double? ScaleInCooldown { get; set; }

    /// <summary>
    /// Amount of time, in seconds, after a scale-out activity completes before another scale-out activity can start.
    /// This value is not used if the scalable resource is an Auto Scaling group.
    /// </summary>
    [JsonPropertyName("scaleOutCooldown")]
    public double? ScaleOutCooldown { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecInitProviderScalingInstruction
{
    /// <summary>
    /// Customized load metric to use for predictive scaling. You must specify either customized_load_metric_specification or predefined_load_metric_specification when configuring predictive scaling.
    /// More details can be found in the AWS Auto Scaling API Reference.
    /// </summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public V1beta2ScalingPlanSpecInitProviderScalingInstructionCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Boolean controlling whether dynamic scaling by AWS Auto Scaling is disabled. Defaults to false.</summary>
    [JsonPropertyName("disableDynamicScaling")]
    public bool? DisableDynamicScaling { get; set; }

    /// <summary>Maximum capacity of the resource. The exception to this upper limit is if you specify a non-default setting for predictive_scaling_max_capacity_behavior.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity of the resource.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>
    /// Predefined load metric to use for predictive scaling. You must specify either predefined_load_metric_specification or customized_load_metric_specification when configuring predictive scaling.
    /// More details can be found in the AWS Auto Scaling API Reference.
    /// </summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public V1beta2ScalingPlanSpecInitProviderScalingInstructionPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>
    /// Defines the behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity specified for the resource.
    /// Valid values: SetForecastCapacityToMaxCapacity, SetMaxCapacityAboveForecastCapacity, SetMaxCapacityToForecastCapacity.
    /// </summary>
    [JsonPropertyName("predictiveScalingMaxCapacityBehavior")]
    public string? PredictiveScalingMaxCapacityBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity.</summary>
    [JsonPropertyName("predictiveScalingMaxCapacityBuffer")]
    public double? PredictiveScalingMaxCapacityBuffer { get; set; }

    /// <summary>Predictive scaling mode. Valid values: ForecastAndScale, ForecastOnly.</summary>
    [JsonPropertyName("predictiveScalingMode")]
    public string? PredictiveScalingMode { get; set; }

    /// <summary>ID of the resource. This string consists of the resource type and unique identifier.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Scalable dimension associated with the resource. Valid values: autoscaling:autoScalingGroup:DesiredCapacity, dynamodb:index:ReadCapacityUnits, dynamodb:index:WriteCapacityUnits, dynamodb:table:ReadCapacityUnits, dynamodb:table:WriteCapacityUnits, ecs:service:DesiredCount, ec2:spot-fleet-request:TargetCapacity, rds:cluster:ReadReplicaCount.</summary>
    [JsonPropertyName("scalableDimension")]
    public string? ScalableDimension { get; set; }

    /// <summary>Controls whether a resource&apos;s externally created scaling policies are kept or replaced. Valid values: KeepExternalPolicies, ReplaceExternalPolicies. Defaults to KeepExternalPolicies.</summary>
    [JsonPropertyName("scalingPolicyUpdateBehavior")]
    public string? ScalingPolicyUpdateBehavior { get; set; }

    /// <summary>Amount of time, in seconds, to buffer the run time of scheduled scaling actions when scaling out.</summary>
    [JsonPropertyName("scheduledActionBufferTime")]
    public double? ScheduledActionBufferTime { get; set; }

    /// <summary>Namespace of the AWS service. Valid values: autoscaling, dynamodb, ecs, ec2, rds.</summary>
    [JsonPropertyName("serviceNamespace")]
    public string? ServiceNamespace { get; set; }

    /// <summary>
    /// Structure that defines new target tracking configurations. Each of these structures includes a specific scaling metric and a target value for the metric, along with various parameters to use with dynamic scaling.
    /// More details can be found in the AWS Auto Scaling API Reference.
    /// </summary>
    [JsonPropertyName("targetTrackingConfiguration")]
    public IList<V1beta2ScalingPlanSpecInitProviderScalingInstructionTargetTrackingConfiguration>? TargetTrackingConfiguration { get; set; }
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
public partial class V1beta2ScalingPlanSpecInitProvider
{
    /// <summary>CloudFormation stack or set of tags. You can create one scaling plan per application source.</summary>
    [JsonPropertyName("applicationSource")]
    public V1beta2ScalingPlanSpecInitProviderApplicationSource? ApplicationSource { get; set; }

    /// <summary>Name of the scaling plan. Names cannot contain vertical bars, colons, or forward slashes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Scaling instructions. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("scalingInstruction")]
    public IList<V1beta2ScalingPlanSpecInitProviderScalingInstruction>? ScalingInstruction { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScalingPlanSpecManagementPoliciesEnum>))]
public enum V1beta2ScalingPlanSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScalingPlanSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ScalingPlanSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScalingPlanSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ScalingPlanSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScalingPlanSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScalingPlanSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ScalingPlanSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ScalingPlanSpec defines the desired state of ScalingPlan</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanSpec
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
    public V1beta2ScalingPlanSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ScalingPlanSpecForProvider ForProvider { get; set; }

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
    public V1beta2ScalingPlanSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ScalingPlanSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ScalingPlanSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ScalingPlanSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanStatusAtProviderApplicationSourceTagFilter
{
    /// <summary>Tag key.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>Tag values.</summary>
    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>CloudFormation stack or set of tags. You can create one scaling plan per application source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanStatusAtProviderApplicationSource
{
    /// <summary>ARN of a AWS CloudFormation stack.</summary>
    [JsonPropertyName("cloudformationStackArn")]
    public string? CloudformationStackArn { get; set; }

    /// <summary>Set of tags.</summary>
    [JsonPropertyName("tagFilter")]
    public IList<V1beta2ScalingPlanStatusAtProviderApplicationSourceTagFilter>? TagFilter { get; set; }
}

/// <summary>
/// Customized load metric to use for predictive scaling. You must specify either customized_load_metric_specification or predefined_load_metric_specification when configuring predictive scaling.
/// More details can be found in the AWS Auto Scaling API Reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanStatusAtProviderScalingInstructionCustomizedLoadMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Statistic of the metric. Currently, the value must always be Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>
/// Predefined load metric to use for predictive scaling. You must specify either predefined_load_metric_specification or customized_load_metric_specification when configuring predictive scaling.
/// More details can be found in the AWS Auto Scaling API Reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanStatusAtProviderScalingInstructionPredefinedLoadMetricSpecification
{
    /// <summary>Metric type. Valid values: ALBTargetGroupRequestCount, ASGTotalCPUUtilization, ASGTotalNetworkIn, ASGTotalNetworkOut.</summary>
    [JsonPropertyName("predefinedLoadMetricType")]
    public string? PredefinedLoadMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>
/// Customized metric. You can specify either customized_scaling_metric_specification or predefined_scaling_metric_specification.
/// More details can be found in the AWS Auto Scaling API Reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanStatusAtProviderScalingInstructionTargetTrackingConfigurationCustomizedScalingMetricSpecification
{
    /// <summary>Dimensions of the metric.</summary>
    [JsonPropertyName("dimensions")]
    public IDictionary<string, string>? Dimensions { get; set; }

    /// <summary>Name of the metric.</summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>Namespace of the metric.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Statistic of the metric. Currently, the value must always be Sum.</summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>Unit of the metric.</summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>
/// Predefined metric. You can specify either predefined_scaling_metric_specification or customized_scaling_metric_specification.
/// More details can be found in the AWS Auto Scaling API Reference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanStatusAtProviderScalingInstructionTargetTrackingConfigurationPredefinedScalingMetricSpecification
{
    /// <summary>Metric type. Valid values: ALBRequestCountPerTarget, ASGAverageCPUUtilization, ASGAverageNetworkIn, ASGAverageNetworkOut, DynamoDBReadCapacityUtilization, DynamoDBWriteCapacityUtilization, ECSServiceAverageCPUUtilization, ECSServiceAverageMemoryUtilization, EC2SpotFleetRequestAverageCPUUtilization, EC2SpotFleetRequestAverageNetworkIn, EC2SpotFleetRequestAverageNetworkOut, RDSReaderAverageCPUUtilization, RDSReaderAverageDatabaseConnections.</summary>
    [JsonPropertyName("predefinedScalingMetricType")]
    public string? PredefinedScalingMetricType { get; set; }

    /// <summary>Identifies the resource associated with the metric type.</summary>
    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanStatusAtProviderScalingInstructionTargetTrackingConfiguration
{
    /// <summary>
    /// Customized metric. You can specify either customized_scaling_metric_specification or predefined_scaling_metric_specification.
    /// More details can be found in the AWS Auto Scaling API Reference.
    /// </summary>
    [JsonPropertyName("customizedScalingMetricSpecification")]
    public V1beta2ScalingPlanStatusAtProviderScalingInstructionTargetTrackingConfigurationCustomizedScalingMetricSpecification? CustomizedScalingMetricSpecification { get; set; }

    /// <summary>Boolean indicating whether scale in by the target tracking scaling policy is disabled. Defaults to false.</summary>
    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>
    /// Estimated time, in seconds, until a newly launched instance can contribute to the CloudWatch metrics.
    /// This value is used only if the resource is an Auto Scaling group.
    /// </summary>
    [JsonPropertyName("estimatedInstanceWarmup")]
    public double? EstimatedInstanceWarmup { get; set; }

    /// <summary>
    /// Predefined metric. You can specify either predefined_scaling_metric_specification or customized_scaling_metric_specification.
    /// More details can be found in the AWS Auto Scaling API Reference.
    /// </summary>
    [JsonPropertyName("predefinedScalingMetricSpecification")]
    public V1beta2ScalingPlanStatusAtProviderScalingInstructionTargetTrackingConfigurationPredefinedScalingMetricSpecification? PredefinedScalingMetricSpecification { get; set; }

    /// <summary>
    /// Amount of time, in seconds, after a scale in activity completes before another scale in activity can start.
    /// This value is not used if the scalable resource is an Auto Scaling group.
    /// </summary>
    [JsonPropertyName("scaleInCooldown")]
    public double? ScaleInCooldown { get; set; }

    /// <summary>
    /// Amount of time, in seconds, after a scale-out activity completes before another scale-out activity can start.
    /// This value is not used if the scalable resource is an Auto Scaling group.
    /// </summary>
    [JsonPropertyName("scaleOutCooldown")]
    public double? ScaleOutCooldown { get; set; }

    /// <summary>Target value for the metric.</summary>
    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanStatusAtProviderScalingInstruction
{
    /// <summary>
    /// Customized load metric to use for predictive scaling. You must specify either customized_load_metric_specification or predefined_load_metric_specification when configuring predictive scaling.
    /// More details can be found in the AWS Auto Scaling API Reference.
    /// </summary>
    [JsonPropertyName("customizedLoadMetricSpecification")]
    public V1beta2ScalingPlanStatusAtProviderScalingInstructionCustomizedLoadMetricSpecification? CustomizedLoadMetricSpecification { get; set; }

    /// <summary>Boolean controlling whether dynamic scaling by AWS Auto Scaling is disabled. Defaults to false.</summary>
    [JsonPropertyName("disableDynamicScaling")]
    public bool? DisableDynamicScaling { get; set; }

    /// <summary>Maximum capacity of the resource. The exception to this upper limit is if you specify a non-default setting for predictive_scaling_max_capacity_behavior.</summary>
    [JsonPropertyName("maxCapacity")]
    public double? MaxCapacity { get; set; }

    /// <summary>Minimum capacity of the resource.</summary>
    [JsonPropertyName("minCapacity")]
    public double? MinCapacity { get; set; }

    /// <summary>
    /// Predefined load metric to use for predictive scaling. You must specify either predefined_load_metric_specification or customized_load_metric_specification when configuring predictive scaling.
    /// More details can be found in the AWS Auto Scaling API Reference.
    /// </summary>
    [JsonPropertyName("predefinedLoadMetricSpecification")]
    public V1beta2ScalingPlanStatusAtProviderScalingInstructionPredefinedLoadMetricSpecification? PredefinedLoadMetricSpecification { get; set; }

    /// <summary>
    /// Defines the behavior that should be applied if the forecast capacity approaches or exceeds the maximum capacity specified for the resource.
    /// Valid values: SetForecastCapacityToMaxCapacity, SetMaxCapacityAboveForecastCapacity, SetMaxCapacityToForecastCapacity.
    /// </summary>
    [JsonPropertyName("predictiveScalingMaxCapacityBehavior")]
    public string? PredictiveScalingMaxCapacityBehavior { get; set; }

    /// <summary>Size of the capacity buffer to use when the forecast capacity is close to or exceeds the maximum capacity.</summary>
    [JsonPropertyName("predictiveScalingMaxCapacityBuffer")]
    public double? PredictiveScalingMaxCapacityBuffer { get; set; }

    /// <summary>Predictive scaling mode. Valid values: ForecastAndScale, ForecastOnly.</summary>
    [JsonPropertyName("predictiveScalingMode")]
    public string? PredictiveScalingMode { get; set; }

    /// <summary>ID of the resource. This string consists of the resource type and unique identifier.</summary>
    [JsonPropertyName("resourceId")]
    public string? ResourceId { get; set; }

    /// <summary>Scalable dimension associated with the resource. Valid values: autoscaling:autoScalingGroup:DesiredCapacity, dynamodb:index:ReadCapacityUnits, dynamodb:index:WriteCapacityUnits, dynamodb:table:ReadCapacityUnits, dynamodb:table:WriteCapacityUnits, ecs:service:DesiredCount, ec2:spot-fleet-request:TargetCapacity, rds:cluster:ReadReplicaCount.</summary>
    [JsonPropertyName("scalableDimension")]
    public string? ScalableDimension { get; set; }

    /// <summary>Controls whether a resource&apos;s externally created scaling policies are kept or replaced. Valid values: KeepExternalPolicies, ReplaceExternalPolicies. Defaults to KeepExternalPolicies.</summary>
    [JsonPropertyName("scalingPolicyUpdateBehavior")]
    public string? ScalingPolicyUpdateBehavior { get; set; }

    /// <summary>Amount of time, in seconds, to buffer the run time of scheduled scaling actions when scaling out.</summary>
    [JsonPropertyName("scheduledActionBufferTime")]
    public double? ScheduledActionBufferTime { get; set; }

    /// <summary>Namespace of the AWS service. Valid values: autoscaling, dynamodb, ecs, ec2, rds.</summary>
    [JsonPropertyName("serviceNamespace")]
    public string? ServiceNamespace { get; set; }

    /// <summary>
    /// Structure that defines new target tracking configurations. Each of these structures includes a specific scaling metric and a target value for the metric, along with various parameters to use with dynamic scaling.
    /// More details can be found in the AWS Auto Scaling API Reference.
    /// </summary>
    [JsonPropertyName("targetTrackingConfiguration")]
    public IList<V1beta2ScalingPlanStatusAtProviderScalingInstructionTargetTrackingConfiguration>? TargetTrackingConfiguration { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanStatusAtProvider
{
    /// <summary>CloudFormation stack or set of tags. You can create one scaling plan per application source.</summary>
    [JsonPropertyName("applicationSource")]
    public V1beta2ScalingPlanStatusAtProviderApplicationSource? ApplicationSource { get; set; }

    /// <summary>Scaling plan identifier.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Name of the scaling plan. Names cannot contain vertical bars, colons, or forward slashes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Scaling instructions. More details can be found in the AWS Auto Scaling API Reference.</summary>
    [JsonPropertyName("scalingInstruction")]
    public IList<V1beta2ScalingPlanStatusAtProviderScalingInstruction>? ScalingInstruction { get; set; }

    /// <summary>The version number of the scaling plan. This value is always 1.</summary>
    [JsonPropertyName("scalingPlanVersion")]
    public double? ScalingPlanVersion { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanStatusConditions
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

/// <summary>ScalingPlanStatus defines the observed state of ScalingPlan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScalingPlanStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ScalingPlanStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ScalingPlanStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ScalingPlan is the Schema for the ScalingPlans API. Manages an AWS Auto Scaling scaling plan.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ScalingPlan : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ScalingPlanSpec>, IStatus<V1beta2ScalingPlanStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ScalingPlan";
    public const string KubeGroup = "autoscalingplans.aws.upbound.io";
    public const string KubePluralName = "scalingplans";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "autoscalingplans.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ScalingPlan";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ScalingPlanSpec defines the desired state of ScalingPlan</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ScalingPlanSpec Spec { get; set; }

    /// <summary>ScalingPlanStatus defines the observed state of ScalingPlan.</summary>
    [JsonPropertyName("status")]
    public V1beta2ScalingPlanStatus? Status { get; set; }
}