#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.cloudwatch.services.k8s.aws;
/// <summary>MetricAlarm is the Schema for the MetricAlarms API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MetricAlarmList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MetricAlarm>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MetricAlarmList";
    public const string KubeGroup = "cloudwatch.services.k8s.aws";
    public const string KubePluralName = "metricalarms";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudwatch.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetricAlarmList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1MetricAlarm objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1MetricAlarm> Items { get; set; }
}

/// <summary>
/// A dimension is a name/value pair that is part of the identity of a metric.
/// Because dimensions are part of the unique identifier for a metric, whenever
/// you add a unique name/value pair to one of your metrics, you are creating
/// a new variation of that metric. For example, many Amazon EC2 metrics publish
/// InstanceId as a dimension name, and the actual instance ID as the value for
/// that dimension.
/// 
/// You can assign up to 30 dimensions to a metric.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricAlarmSpecDimensions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A dimension is a name/value pair that is part of the identity of a metric.
/// Because dimensions are part of the unique identifier for a metric, whenever
/// you add a unique name/value pair to one of your metrics, you are creating
/// a new variation of that metric. For example, many Amazon EC2 metrics publish
/// InstanceId as a dimension name, and the actual instance ID as the value for
/// that dimension.
/// 
/// You can assign up to 30 dimensions to a metric.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricAlarmSpecMetricsMetricStatMetricDimensions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Represents a specific metric.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricAlarmSpecMetricsMetricStatMetric
{
    [JsonPropertyName("dimensions")]
    public IList<V1alpha1MetricAlarmSpecMetricsMetricStatMetricDimensions>? Dimensions { get; set; }

    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>
/// This structure defines the metric to be returned, along with the statistics,
/// period, and units.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricAlarmSpecMetricsMetricStat
{
    /// <summary>Represents a specific metric.</summary>
    [JsonPropertyName("metric")]
    public V1alpha1MetricAlarmSpecMetricsMetricStatMetric? Metric { get; set; }

    [JsonPropertyName("period")]
    public long? Period { get; set; }

    [JsonPropertyName("stat")]
    public string? Stat { get; set; }

    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>
/// This structure is used in both GetMetricData and PutMetricAlarm. The supported
/// use of this structure is different for those two operations.
/// 
/// When used in GetMetricData, it indicates the metric data to return, and whether
/// this call is just retrieving a batch set of data for one metric, or is performing
/// a Metrics Insights query or a math expression. A single GetMetricData call
/// can include up to 500 MetricDataQuery structures.
/// 
/// When used in PutMetricAlarm, it enables you to create an alarm based on a
/// metric math expression. Each MetricDataQuery in the array specifies either
/// a metric to retrieve, or a math expression to be performed on retrieved metrics.
/// A single PutMetricAlarm call can include up to 20 MetricDataQuery structures
/// in the array. The 20 structures can include as many as 10 structures that
/// contain a MetricStat parameter to retrieve a metric, and as many as 10 structures
/// that contain the Expression parameter to perform a math expression. Of those
/// Expression structures, one must have true as the value for ReturnData. The
/// result of this expression is the value the alarm watches.
/// 
/// Any expression used in a PutMetricAlarm operation must return a single time
/// series. For more information, see Metric Math Syntax and Functions (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/using-metric-math.html#metric-math-syntax)
/// in the Amazon CloudWatch User Guide.
/// 
/// Some of the parameters of this structure also have different uses whether
/// you are using this structure in a GetMetricData operation or a PutMetricAlarm
/// operation. These differences are explained in the following parameter list.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricAlarmSpecMetrics
{
    [JsonPropertyName("accountID")]
    public string? AccountID { get; set; }

    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>
    /// This structure defines the metric to be returned, along with the statistics,
    /// period, and units.
    /// </summary>
    [JsonPropertyName("metricStat")]
    public V1alpha1MetricAlarmSpecMetricsMetricStat? MetricStat { get; set; }

    [JsonPropertyName("period")]
    public long? Period { get; set; }

    [JsonPropertyName("returnData")]
    public bool? ReturnData { get; set; }
}

/// <summary>A key-value pair associated with a CloudWatch resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricAlarmSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// MetricAlarmSpec defines the desired state of MetricAlarm.
/// 
/// The details about a metric alarm.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricAlarmSpec
{
    /// <summary>
    /// Indicates whether actions should be executed during any changes to the alarm
    /// state. The default is TRUE.
    /// </summary>
    [JsonPropertyName("actionsEnabled")]
    public bool? ActionsEnabled { get; set; }

    /// <summary>
    /// The actions to execute when this alarm transitions to the ALARM state from
    /// any other state. Each action is specified as an Amazon Resource Name (ARN).
    /// Valid values:
    /// 
    /// EC2 actions:
    /// 
    ///   - arn:aws:automate:region:ec2:stop
    /// 
    ///   - arn:aws:automate:region:ec2:terminate
    /// 
    ///   - arn:aws:automate:region:ec2:reboot
    /// 
    ///   - arn:aws:automate:region:ec2:recover
    /// 
    ///   - arn:aws:swf:region:account-id:action/actions/AWS_EC2.InstanceId.Stop/1.0
    /// 
    ///   - arn:aws:swf:region:account-id:action/actions/AWS_EC2.InstanceId.Terminate/1.0
    /// 
    ///   - arn:aws:swf:region:account-id:action/actions/AWS_EC2.InstanceId.Reboot/1.0
    /// 
    ///   - arn:aws:swf:region:account-id:action/actions/AWS_EC2.InstanceId.Recover/1.0
    /// 
    /// Autoscaling action:
    /// 
    ///   - arn:aws:autoscaling:region:account-id:scalingPolicy:policy-id:autoScalingGroupName/group-friendly-name:policyName/policy-friendly-name
    /// 
    /// Lambda actions:
    /// 
    ///   - Invoke the latest version of a Lambda function: arn:aws:lambda:region:account-id:function:function-name
    /// 
    ///   - Invoke a specific version of a Lambda function: arn:aws:lambda:region:account-id:function:function-name:version-number
    /// 
    ///   - Invoke a function by using an alias Lambda function: arn:aws:lambda:region:account-id:function:function-name:alias-name
    /// 
    /// SNS notification action:
    /// 
    ///   - arn:aws:sns:region:account-id:sns-topic-name
    /// 
    /// SSM integration actions:
    /// 
    ///   - arn:aws:ssm:region:account-id:opsitem:severity#CATEGORY=category-name
    /// 
    ///   - arn:aws:ssm-incidents::account-id:responseplan/response-plan-name
    /// 
    /// # Start a Amazon Q Developer operational investigation
    /// 
    /// arn:aws:aiops:region:account-id:investigation-group:ingestigation-group-id
    /// </summary>
    [JsonPropertyName("alarmActions")]
    public IList<string>? AlarmActions { get; set; }

    /// <summary>The description for the alarm.</summary>
    [JsonPropertyName("alarmDescription")]
    public string? AlarmDescription { get; set; }

    /// <summary>
    /// The arithmetic operation to use when comparing the specified statistic and
    /// threshold. The specified statistic value is used as the first operand.
    /// 
    /// The values LessThanLowerOrGreaterThanUpperThreshold, LessThanLowerThreshold,
    /// and GreaterThanUpperThreshold are used only for alarms based on anomaly detection
    /// models.
    /// </summary>
    [JsonPropertyName("comparisonOperator")]
    public required string ComparisonOperator { get; set; }

    /// <summary>
    /// The number of data points that must be breaching to trigger the alarm. This
    /// is used only if you are setting an &quot;M out of N&quot; alarm. In that case, this
    /// value is the M. For more information, see Evaluating an Alarm (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/AlarmThatSendsEmail.html#alarm-evaluation)
    /// in the Amazon CloudWatch User Guide.
    /// </summary>
    [JsonPropertyName("datapointsToAlarm")]
    public long? DatapointsToAlarm { get; set; }

    /// <summary>The dimensions for the metric specified in MetricName.</summary>
    [JsonPropertyName("dimensions")]
    public IList<V1alpha1MetricAlarmSpecDimensions>? Dimensions { get; set; }

    /// <summary>
    /// Used only for alarms based on percentiles. If you specify ignore, the alarm
    /// state does not change during periods with too few data points to be statistically
    /// significant. If you specify evaluate or omit this parameter, the alarm is
    /// always evaluated and possibly changes state no matter how many data points
    /// are available. For more information, see Percentile-Based CloudWatch Alarms
    /// and Low Data Samples (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/AlarmThatSendsEmail.html#percentiles-with-low-samples).
    /// 
    /// Valid Values: evaluate | ignore
    /// </summary>
    [JsonPropertyName("evaluateLowSampleCountPercentile")]
    public string? EvaluateLowSampleCountPercentile { get; set; }

    /// <summary>
    /// The number of periods over which data is compared to the specified threshold.
    /// If you are setting an alarm that requires that a number of consecutive data
    /// points be breaching to trigger the alarm, this value specifies that number.
    /// If you are setting an &quot;M out of N&quot; alarm, this value is the N.
    /// 
    /// An alarm&apos;s total current evaluation period can be no longer than one day,
    /// so this number multiplied by Period cannot be more than 86,400 seconds.
    /// </summary>
    [JsonPropertyName("evaluationPeriods")]
    public required long EvaluationPeriods { get; set; }

    /// <summary>
    /// The extended statistic for the metric specified in MetricName. When you call
    /// PutMetricAlarm and specify a MetricName, you must specify either Statistic
    /// or ExtendedStatistic but not both.
    /// 
    /// If you specify ExtendedStatistic, the following are valid values:
    /// 
    ///   - p90
    /// 
    ///   - tm90
    /// 
    ///   - tc90
    /// 
    ///   - ts90
    /// 
    ///   - wm90
    /// 
    ///   - IQM
    /// 
    ///   - PR(n:m) where n and m are values of the metric
    /// 
    ///   - TC(X%:X%) where X is between 10 and 90 inclusive.
    /// 
    ///   - TM(X%:X%) where X is between 10 and 90 inclusive.
    /// 
    ///   - TS(X%:X%) where X is between 10 and 90 inclusive.
    /// 
    ///   - WM(X%:X%) where X is between 10 and 90 inclusive.
    /// 
    /// For more information about these extended statistics, see CloudWatch statistics
    /// definitions (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/Statistics-definitions.html).
    /// </summary>
    [JsonPropertyName("extendedStatistic")]
    public string? ExtendedStatistic { get; set; }

    /// <summary>
    /// The actions to execute when this alarm transitions to the INSUFFICIENT_DATA
    /// state from any other state. Each action is specified as an Amazon Resource
    /// Name (ARN). Valid values:
    /// 
    /// EC2 actions:
    /// 
    ///   - arn:aws:automate:region:ec2:stop
    /// 
    ///   - arn:aws:automate:region:ec2:terminate
    /// 
    ///   - arn:aws:automate:region:ec2:reboot
    /// 
    ///   - arn:aws:automate:region:ec2:recover
    /// 
    ///   - arn:aws:swf:region:account-id:action/actions/AWS_EC2.InstanceId.Stop/1.0
    /// 
    ///   - arn:aws:swf:region:account-id:action/actions/AWS_EC2.InstanceId.Terminate/1.0
    /// 
    ///   - arn:aws:swf:region:account-id:action/actions/AWS_EC2.InstanceId.Reboot/1.0
    /// 
    ///   - arn:aws:swf:region:account-id:action/actions/AWS_EC2.InstanceId.Recover/1.0
    /// 
    /// Autoscaling action:
    /// 
    ///   - arn:aws:autoscaling:region:account-id:scalingPolicy:policy-id:autoScalingGroupName/group-friendly-name:policyName/policy-friendly-name
    /// 
    /// Lambda actions:
    /// 
    ///   - Invoke the latest version of a Lambda function: arn:aws:lambda:region:account-id:function:function-name
    /// 
    ///   - Invoke a specific version of a Lambda function: arn:aws:lambda:region:account-id:function:function-name:version-number
    /// 
    ///   - Invoke a function by using an alias Lambda function: arn:aws:lambda:region:account-id:function:function-name:alias-name
    /// 
    /// SNS notification action:
    /// 
    ///   - arn:aws:sns:region:account-id:sns-topic-name
    /// 
    /// SSM integration actions:
    /// 
    ///   - arn:aws:ssm:region:account-id:opsitem:severity#CATEGORY=category-name
    /// 
    ///   - arn:aws:ssm-incidents::account-id:responseplan/response-plan-name
    /// </summary>
    [JsonPropertyName("insufficientDataActions")]
    public IList<string>? InsufficientDataActions { get; set; }

    /// <summary>
    /// The name for the metric associated with the alarm. For each PutMetricAlarm
    /// operation, you must specify either MetricName or a Metrics array.
    /// 
    /// If you are creating an alarm based on a math expression, you cannot specify
    /// this parameter, or any of the Namespace, Dimensions, Period, Unit, Statistic,
    /// or ExtendedStatistic parameters. Instead, you specify all this information
    /// in the Metrics array.
    /// </summary>
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    /// <summary>
    /// An array of MetricDataQuery structures that enable you to create an alarm
    /// based on the result of a metric math expression. For each PutMetricAlarm
    /// operation, you must specify either MetricName or a Metrics array.
    /// 
    /// Each item in the Metrics array either retrieves a metric or performs a math
    /// expression.
    /// 
    /// One item in the Metrics array is the expression that the alarm watches. You
    /// designate this expression by setting ReturnData to true for this object in
    /// the array. For more information, see MetricDataQuery (https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_MetricDataQuery.html).
    /// 
    /// If you use the Metrics parameter, you cannot include the Namespace, MetricName,
    /// Dimensions, Period, Unit, Statistic, or ExtendedStatistic parameters of PutMetricAlarm
    /// in the same operation. Instead, you retrieve the metrics you are using in
    /// your math expression as part of the Metrics array.
    /// </summary>
    [JsonPropertyName("metrics")]
    public IList<V1alpha1MetricAlarmSpecMetrics>? Metrics { get; set; }

    /// <summary>
    /// The name for the alarm. This name must be unique within the Region.
    /// 
    /// The name must contain only UTF-8 characters, and can&apos;t contain ASCII control
    /// characters
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The namespace for the metric associated specified in MetricName.
    /// 
    /// Regex Pattern: `^[^:]`
    /// </summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>
    /// The actions to execute when this alarm transitions to an OK state from any
    /// other state. Each action is specified as an Amazon Resource Name (ARN). Valid
    /// values:
    /// 
    /// EC2 actions:
    /// 
    ///   - arn:aws:automate:region:ec2:stop
    /// 
    ///   - arn:aws:automate:region:ec2:terminate
    /// 
    ///   - arn:aws:automate:region:ec2:reboot
    /// 
    ///   - arn:aws:automate:region:ec2:recover
    /// 
    ///   - arn:aws:swf:region:account-id:action/actions/AWS_EC2.InstanceId.Stop/1.0
    /// 
    ///   - arn:aws:swf:region:account-id:action/actions/AWS_EC2.InstanceId.Terminate/1.0
    /// 
    ///   - arn:aws:swf:region:account-id:action/actions/AWS_EC2.InstanceId.Reboot/1.0
    /// 
    ///   - arn:aws:swf:region:account-id:action/actions/AWS_EC2.InstanceId.Recover/1.0
    /// 
    /// Autoscaling action:
    /// 
    ///   - arn:aws:autoscaling:region:account-id:scalingPolicy:policy-id:autoScalingGroupName/group-friendly-name:policyName/policy-friendly-name
    /// 
    /// Lambda actions:
    /// 
    ///   - Invoke the latest version of a Lambda function: arn:aws:lambda:region:account-id:function:function-name
    /// 
    ///   - Invoke a specific version of a Lambda function: arn:aws:lambda:region:account-id:function:function-name:version-number
    /// 
    ///   - Invoke a function by using an alias Lambda function: arn:aws:lambda:region:account-id:function:function-name:alias-name
    /// 
    /// SNS notification action:
    /// 
    ///   - arn:aws:sns:region:account-id:sns-topic-name
    /// 
    /// SSM integration actions:
    /// 
    ///   - arn:aws:ssm:region:account-id:opsitem:severity#CATEGORY=category-name
    /// 
    ///   - arn:aws:ssm-incidents::account-id:responseplan/response-plan-name
    /// </summary>
    [JsonPropertyName("oKActions")]
    public IList<string>? OKActions { get; set; }

    /// <summary>
    /// The length, in seconds, used each time the metric specified in MetricName
    /// is evaluated. Valid values are 10, 30, and any multiple of 60.
    /// 
    /// Period is required for alarms based on static thresholds. If you are creating
    /// an alarm based on a metric math expression, you specify the period for each
    /// metric within the objects in the Metrics array.
    /// 
    /// Be sure to specify 10 or 30 only for metrics that are stored by a PutMetricData
    /// call with a StorageResolution of 1. If you specify a period of 10 or 30 for
    /// a metric that does not have sub-minute resolution, the alarm still attempts
    /// to gather data at the period rate that you specify. In this case, it does
    /// not receive data for the attempts that do not correspond to a one-minute
    /// data resolution, and the alarm might often lapse into INSUFFICENT_DATA status.
    /// Specifying 10 or 30 also sets this alarm as a high-resolution alarm, which
    /// has a higher charge than other alarms. For more information about pricing,
    /// see Amazon CloudWatch Pricing (https://aws.amazon.com/cloudwatch/pricing/).
    /// 
    /// An alarm&apos;s total current evaluation period can be no longer than one day,
    /// so Period multiplied by EvaluationPeriods cannot be more than 86,400 seconds.
    /// </summary>
    [JsonPropertyName("period")]
    public long? Period { get; set; }

    /// <summary>
    /// The statistic for the metric specified in MetricName, other than percentile.
    /// For percentile statistics, use ExtendedStatistic. When you call PutMetricAlarm
    /// and specify a MetricName, you must specify either Statistic or ExtendedStatistic,
    /// but not both.
    /// </summary>
    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    /// <summary>
    /// A list of key-value pairs to associate with the alarm. You can associate
    /// as many as 50 tags with an alarm. To be able to associate tags with the alarm
    /// when you create the alarm, you must have the cloudwatch:TagResource permission.
    /// 
    /// Tags can help you organize and categorize your resources. You can also use
    /// them to scope user permissions by granting a user permission to access or
    /// change only resources with certain tag values.
    /// 
    /// If you are using this operation to update an existing alarm, any tags you
    /// specify in this parameter are ignored. To change the tags of an existing
    /// alarm, use TagResource (https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_TagResource.html)
    /// or UntagResource (https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_UntagResource.html).
    /// 
    /// To use this field to set tags for an alarm when you create it, you must be
    /// signed on with both the cloudwatch:PutMetricAlarm and cloudwatch:TagResource
    /// permissions.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1MetricAlarmSpecTags>? Tags { get; set; }

    /// <summary>
    /// The value against which the specified statistic is compared.
    /// 
    /// This parameter is required for alarms based on static thresholds, but should
    /// not be used for alarms based on anomaly detection models.
    /// </summary>
    [JsonPropertyName("threshold")]
    public double? Threshold { get; set; }

    /// <summary>
    /// If this is an alarm based on an anomaly detection model, make this value
    /// match the ID of the ANOMALY_DETECTION_BAND function.
    /// 
    /// For an example of how to use this parameter, see the Anomaly Detection Model
    /// Alarm example on this page.
    /// 
    /// If your alarm uses this parameter, it cannot have Auto Scaling actions.
    /// </summary>
    [JsonPropertyName("thresholdMetricID")]
    public string? ThresholdMetricID { get; set; }

    /// <summary>
    /// Sets how this alarm is to handle missing data points. If TreatMissingData
    /// is omitted, the default behavior of missing is used. For more information,
    /// see Configuring How CloudWatch Alarms Treats Missing Data (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/AlarmThatSendsEmail.html#alarms-and-missing-data).
    /// 
    /// Valid Values: breaching | notBreaching | ignore | missing
    /// 
    /// Alarms that evaluate metrics in the AWS/DynamoDB namespace always ignore
    /// missing data even if you choose a different option for TreatMissingData.
    /// When an AWS/DynamoDB metric has missing data, alarms that evaluate that metric
    /// remain in their current state.
    /// </summary>
    [JsonPropertyName("treatMissingData")]
    public string? TreatMissingData { get; set; }

    /// <summary>
    /// The unit of measure for the statistic. For example, the units for the Amazon
    /// EC2 NetworkIn metric are Bytes because NetworkIn tracks the number of bytes
    /// that an instance receives on all network interfaces. You can also specify
    /// a unit when you create a custom metric. Units help provide conceptual meaning
    /// to your data. Metric data points that specify a unit of measure, such as
    /// Percent, are aggregated separately. If you are creating an alarm based on
    /// a metric math expression, you can specify the unit for each metric (if needed)
    /// within the objects in the Metrics array.
    /// 
    /// If you don&apos;t specify Unit, CloudWatch retrieves all unit types that have
    /// been published for the metric and attempts to evaluate the alarm. Usually,
    /// metrics are published with only one unit, so the alarm works as intended.
    /// 
    /// However, if the metric is published with multiple types of units and you
    /// don&apos;t specify a unit, the alarm&apos;s behavior is not defined and it behaves
    /// unpredictably.
    /// 
    /// We recommend omitting Unit so that you don&apos;t inadvertently specify an incorrect
    /// unit that is not published for this metric. Doing so causes the alarm to
    /// be stuck in the INSUFFICIENT DATA state.
    /// </summary>
    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricAlarmStatusAckResourceMetadata
{
    /// <summary>
    /// ARN is the Amazon Resource Name for the resource. This is a
    /// globally-unique identifier and is set only by the ACK service controller
    /// once the controller has orchestrated the creation of the resource OR
    /// when it has verified that an &quot;adopted&quot; resource (a resource where the
    /// ARN annotation was set by the Kubernetes user on the CR) exists and
    /// matches the supplied CR&apos;s Spec field values.
    /// https://github.com/aws/aws-controllers-k8s/issues/270
    /// </summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>
    /// OwnerAccountID is the AWS Account ID of the account that owns the
    /// backend AWS service API resource.
    /// </summary>
    [JsonPropertyName("ownerAccountID")]
    public required string OwnerAccountID { get; set; }

    /// <summary>Partition is the AWS partition in which the resource exists or will exist</summary>
    [JsonPropertyName("partition")]
    public string? Partition { get; set; }

    /// <summary>Region is the AWS region in which the resource exists or will exist.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricAlarmStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public DateTime? LastTransitionTime { get; set; }

    /// <summary>A human readable message indicating details about the transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>The reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status of the condition, one of True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>Type is the type of the Condition</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>MetricAlarmStatus defines the observed state of MetricAlarm</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MetricAlarmStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1MetricAlarmStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MetricAlarmStatusConditions>? Conditions { get; set; }
}

/// <summary>MetricAlarm is the Schema for the MetricAlarms API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MetricAlarm : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MetricAlarmSpec?>, IStatus<V1alpha1MetricAlarmStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MetricAlarm";
    public const string KubeGroup = "cloudwatch.services.k8s.aws";
    public const string KubePluralName = "metricalarms";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "cloudwatch.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MetricAlarm";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// MetricAlarmSpec defines the desired state of MetricAlarm.
    /// 
    /// The details about a metric alarm.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1MetricAlarmSpec? Spec { get; set; }

    /// <summary>MetricAlarmStatus defines the observed state of MetricAlarm</summary>
    [JsonPropertyName("status")]
    public V1alpha1MetricAlarmStatus? Status { get; set; }
}