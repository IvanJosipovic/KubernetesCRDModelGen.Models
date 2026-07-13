#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.applicationautoscaling.services.k8s.aws;
/// <summary>ScalingPolicy is the Schema for the ScalingPolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ScalingPolicyList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ScalingPolicy>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ScalingPolicyList";
    public const string KubeGroup = "applicationautoscaling.services.k8s.aws";
    public const string KubePluralName = "scalingpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "applicationautoscaling.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ScalingPolicyList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ScalingPolicy objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ScalingPolicy> Items { get; set; }
}

/// <summary>
/// Represents a step adjustment for a StepScalingPolicyConfiguration (https://docs.aws.amazon.com/autoscaling/application/APIReference/API_StepScalingPolicyConfiguration.html).
/// Describes an adjustment based on the difference between the value of the
/// aggregated CloudWatch metric and the breach threshold that you&apos;ve defined
/// for the alarm.
/// 
/// For the following examples, suppose that you have an alarm with a breach
/// threshold of 50:
/// 
///   - To initiate the adjustment when the metric is greater than or equal
///     to 50 and less than 60, specify a lower bound of 0 and an upper bound
///     of 10.
/// 
///   - To initiate the adjustment when the metric is greater than 40 and less
///     than or equal to 50, specify a lower bound of -10 and an upper bound of
///     0.
/// 
/// There are a few rules for the step adjustments for your step policy:
/// 
///   - The ranges of your step adjustments can&apos;t overlap or have a gap.
/// 
///   - At most one step adjustment can have a null lower bound. If one step
///     adjustment has a negative lower bound, then there must be a step adjustment
///     with a null lower bound.
/// 
///   - At most one step adjustment can have a null upper bound. If one step
///     adjustment has a positive upper bound, then there must be a step adjustment
///     with a null upper bound.
/// 
///   - The upper and lower bound can&apos;t be null in the same step adjustment.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScalingPolicySpecStepScalingPolicyConfigurationStepAdjustments
{
    [JsonPropertyName("metricIntervalLowerBound")]
    public double? MetricIntervalLowerBound { get; set; }

    [JsonPropertyName("metricIntervalUpperBound")]
    public double? MetricIntervalUpperBound { get; set; }

    [JsonPropertyName("scalingAdjustment")]
    public long? ScalingAdjustment { get; set; }
}

/// <summary>
/// A step scaling policy.
/// 
/// This parameter is required if you are creating a policy and the policy type
/// is StepScaling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScalingPolicySpecStepScalingPolicyConfiguration
{
    [JsonPropertyName("adjustmentType")]
    public string? AdjustmentType { get; set; }

    [JsonPropertyName("cooldown")]
    public long? Cooldown { get; set; }

    [JsonPropertyName("metricAggregationType")]
    public string? MetricAggregationType { get; set; }

    [JsonPropertyName("minAdjustmentMagnitude")]
    public long? MinAdjustmentMagnitude { get; set; }

    [JsonPropertyName("stepAdjustments")]
    public IList<V1alpha1ScalingPolicySpecStepScalingPolicyConfigurationStepAdjustments>? StepAdjustments { get; set; }
}

/// <summary>Describes the dimension names and values associated with a metric.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScalingPolicySpecTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Represents a CloudWatch metric of your choosing for a target tracking scaling
/// policy to use with Application Auto Scaling.
/// 
/// For information about the available metrics for a service, see Amazon Web
/// Services services that publish CloudWatch metrics (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/aws-services-cloudwatch-metrics.html)
/// in the Amazon CloudWatch User Guide.
/// 
/// To create your customized metric specification:
/// 
///    * Add values for each required parameter from CloudWatch. You can use
///    an existing metric, or a new metric that you create. To use your own metric,
///    you must first publish the metric to CloudWatch. For more information,
///    see Publish custom metrics (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/publishingMetrics.html)
///    in the Amazon CloudWatch User Guide.
/// 
///    * Choose a metric that changes proportionally with capacity. The value
///    of the metric should increase or decrease in inverse proportion to the
///    number of capacity units. That is, the value of the metric should decrease
///    when capacity increases, and increase when capacity decreases.
/// 
/// For more information about the CloudWatch terminology below, see Amazon CloudWatch
/// concepts (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cloudwatch_concepts.html)
/// in the Amazon CloudWatch User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScalingPolicySpecTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification
{
    [JsonPropertyName("dimensions")]
    public IList<V1alpha1ScalingPolicySpecTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecificationDimensions>? Dimensions { get; set; }

    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    [JsonPropertyName("statistic")]
    public string? Statistic { get; set; }

    [JsonPropertyName("unit")]
    public string? Unit { get; set; }
}

/// <summary>
/// Represents a predefined metric for a target tracking scaling policy to use
/// with Application Auto Scaling.
/// 
/// For more information, Predefined metrics for target tracking scaling policies
/// (https://docs.aws.amazon.com/autoscaling/application/userguide/monitoring-cloudwatch.html#predefined-metrics)
/// in the Application Auto Scaling User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScalingPolicySpecTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification
{
    [JsonPropertyName("predefinedMetricType")]
    public string? PredefinedMetricType { get; set; }

    [JsonPropertyName("resourceLabel")]
    public string? ResourceLabel { get; set; }
}

/// <summary>
/// A target tracking scaling policy. Includes support for predefined or customized
/// metrics.
/// 
/// This parameter is required if you are creating a policy and the policy type
/// is TargetTrackingScaling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScalingPolicySpecTargetTrackingScalingPolicyConfiguration
{
    /// <summary>
    /// Represents a CloudWatch metric of your choosing for a target tracking scaling
    /// policy to use with Application Auto Scaling.
    /// 
    /// For information about the available metrics for a service, see Amazon Web
    /// Services services that publish CloudWatch metrics (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/aws-services-cloudwatch-metrics.html)
    /// in the Amazon CloudWatch User Guide.
    /// 
    /// To create your customized metric specification:
    /// 
    ///    * Add values for each required parameter from CloudWatch. You can use
    ///    an existing metric, or a new metric that you create. To use your own metric,
    ///    you must first publish the metric to CloudWatch. For more information,
    ///    see Publish custom metrics (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/publishingMetrics.html)
    ///    in the Amazon CloudWatch User Guide.
    /// 
    ///    * Choose a metric that changes proportionally with capacity. The value
    ///    of the metric should increase or decrease in inverse proportion to the
    ///    number of capacity units. That is, the value of the metric should decrease
    ///    when capacity increases, and increase when capacity decreases.
    /// 
    /// For more information about the CloudWatch terminology below, see Amazon CloudWatch
    /// concepts (https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/cloudwatch_concepts.html)
    /// in the Amazon CloudWatch User Guide.
    /// </summary>
    [JsonPropertyName("customizedMetricSpecification")]
    public V1alpha1ScalingPolicySpecTargetTrackingScalingPolicyConfigurationCustomizedMetricSpecification? CustomizedMetricSpecification { get; set; }

    [JsonPropertyName("disableScaleIn")]
    public bool? DisableScaleIn { get; set; }

    /// <summary>
    /// Represents a predefined metric for a target tracking scaling policy to use
    /// with Application Auto Scaling.
    /// 
    /// For more information, Predefined metrics for target tracking scaling policies
    /// (https://docs.aws.amazon.com/autoscaling/application/userguide/monitoring-cloudwatch.html#predefined-metrics)
    /// in the Application Auto Scaling User Guide.
    /// </summary>
    [JsonPropertyName("predefinedMetricSpecification")]
    public V1alpha1ScalingPolicySpecTargetTrackingScalingPolicyConfigurationPredefinedMetricSpecification? PredefinedMetricSpecification { get; set; }

    [JsonPropertyName("scaleInCooldown")]
    public long? ScaleInCooldown { get; set; }

    [JsonPropertyName("scaleOutCooldown")]
    public long? ScaleOutCooldown { get; set; }

    [JsonPropertyName("targetValue")]
    public double? TargetValue { get; set; }
}

/// <summary>
/// ScalingPolicySpec defines the desired state of ScalingPolicy.
/// 
/// Represents a scaling policy to use with Application Auto Scaling.
/// 
/// For more information about configuring scaling policies for a specific service,
/// see Amazon Web Services services that you can use with Application Auto Scaling
/// (https://docs.aws.amazon.com/autoscaling/application/userguide/integrated-services-list.html)
/// in the Application Auto Scaling User Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScalingPolicySpec
{
    /// <summary>
    /// The name of the scaling policy.
    /// 
    /// You cannot change the name of a scaling policy, but you can delete the original
    /// scaling policy and create a new scaling policy with the same settings and
    /// a different name.
    /// 
    /// Regex Pattern: `^\p{Print}+$`
    /// </summary>
    [JsonPropertyName("policyName")]
    public required string PolicyName { get; set; }

    /// <summary>
    /// The scaling policy type. This parameter is required if you are creating a
    /// scaling policy.
    /// 
    /// The following policy types are supported:
    /// 
    /// TargetTrackingScaling—Not supported for Amazon EMR.
    /// 
    /// StepScaling—Not supported for DynamoDB, Amazon Comprehend, Lambda, Amazon
    /// Keyspaces, Amazon MSK, Amazon ElastiCache, or Neptune.
    /// 
    /// For more information, see Target tracking scaling policies (https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-target-tracking.html)
    /// and Step scaling policies (https://docs.aws.amazon.com/autoscaling/application/userguide/application-auto-scaling-step-scaling-policies.html)
    /// in the Application Auto Scaling User Guide.
    /// </summary>
    [JsonPropertyName("policyType")]
    public string? PolicyType { get; set; }

    /// <summary>
    /// The identifier of the resource associated with the scaling policy. This string
    /// consists of the resource type and unique identifier.
    /// 
    ///   - ECS service - The resource type is service and the unique identifier
    ///     is the cluster name and service name. Example: service/my-cluster/my-service.
    /// 
    ///   - Spot Fleet - The resource type is spot-fleet-request and the unique
    ///     identifier is the Spot Fleet request ID. Example: spot-fleet-request/sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE.
    /// 
    ///   - EMR cluster - The resource type is instancegroup and the unique identifier
    ///     is the cluster ID and instance group ID. Example: instancegroup/j-2EEZNYKUA1NTV/ig-1791Y4E1L8YI0.
    /// 
    ///   - AppStream 2.0 fleet - The resource type is fleet and the unique identifier
    ///     is the fleet name. Example: fleet/sample-fleet.
    /// 
    ///   - DynamoDB table - The resource type is table and the unique identifier
    ///     is the table name. Example: table/my-table.
    /// 
    ///   - DynamoDB global secondary index - The resource type is index and the
    ///     unique identifier is the index name. Example: table/my-table/index/my-table-index.
    /// 
    ///   - Aurora DB cluster - The resource type is cluster and the unique identifier
    ///     is the cluster name. Example: cluster:my-db-cluster.
    /// 
    ///   - SageMaker endpoint variant - The resource type is variant and the unique
    ///     identifier is the resource ID. Example: endpoint/my-end-point/variant/KMeansClustering.
    /// 
    ///   - Custom resources are not supported with a resource type. This parameter
    ///     must specify the OutputValue from the CloudFormation template stack used
    ///     to access the resources. The unique identifier is defined by the service
    ///     provider. More information is available in our GitHub repository (https://github.com/aws/aws-auto-scaling-custom-resource).
    /// 
    ///   - Amazon Comprehend document classification endpoint - The resource type
    ///     and unique identifier are specified using the endpoint ARN. Example: arn:aws:comprehend:us-west-2:123456789012:document-classifier-endpoint/EXAMPLE.
    /// 
    ///   - Amazon Comprehend entity recognizer endpoint - The resource type and
    ///     unique identifier are specified using the endpoint ARN. Example: arn:aws:comprehend:us-west-2:123456789012:entity-recognizer-endpoint/EXAMPLE.
    /// 
    ///   - Lambda provisioned concurrency - The resource type is function and the
    ///     unique identifier is the function name with a function version or alias
    ///     name suffix that is not $LATEST. Example: function:my-function:prod or
    ///     function:my-function:1.
    /// 
    ///   - Amazon Keyspaces table - The resource type is table and the unique identifier
    ///     is the table name. Example: keyspace/mykeyspace/table/mytable.
    /// 
    ///   - Amazon MSK cluster - The resource type and unique identifier are specified
    ///     using the cluster ARN. Example: arn:aws:kafka:us-east-1:123456789012:cluster/demo-cluster-1/6357e0b2-0e6a-4b86-a0b4-70df934c2e31-5.
    /// 
    ///   - Amazon ElastiCache replication group - The resource type is replication-group
    ///     and the unique identifier is the replication group name. Example: replication-group/mycluster.
    /// 
    ///   - Neptune cluster - The resource type is cluster and the unique identifier
    ///     is the cluster name. Example: cluster:mycluster.
    /// 
    ///   - SageMaker serverless endpoint - The resource type is variant and the
    ///     unique identifier is the resource ID. Example: endpoint/my-end-point/variant/KMeansClustering.
    /// 
    ///   - SageMaker inference component - The resource type is inference-component
    ///     and the unique identifier is the resource ID. Example: inference-component/my-inference-component.
    /// 
    ///   - Pool of WorkSpaces - The resource type is workspacespool and the unique
    ///     identifier is the pool ID. Example: workspacespool/wspool-123456.
    /// 
    /// Regex Pattern: `^[\u0020-\uD7FF\uE000-\uFFFD\uD800\uDC00-\uDBFF\uDFFF\r\n\t]*$`
    /// </summary>
    [JsonPropertyName("resourceID")]
    public required string ResourceID { get; set; }

    /// <summary>
    /// The scalable dimension. This string consists of the service namespace, resource
    /// type, and scaling property.
    /// 
    ///   - ecs:service:DesiredCount - The task count of an ECS service.
    /// 
    ///   - elasticmapreduce:instancegroup:InstanceCount - The instance count of
    ///     an EMR Instance Group.
    /// 
    ///   - ec2:spot-fleet-request:TargetCapacity - The target capacity of a Spot
    ///     Fleet.
    /// 
    ///   - appstream:fleet:DesiredCapacity - The capacity of an AppStream 2.0 fleet.
    /// 
    ///   - dynamodb:table:ReadCapacityUnits - The provisioned read capacity for
    ///     a DynamoDB table.
    /// 
    ///   - dynamodb:table:WriteCapacityUnits - The provisioned write capacity for
    ///     a DynamoDB table.
    /// 
    ///   - dynamodb:index:ReadCapacityUnits - The provisioned read capacity for
    ///     a DynamoDB global secondary index.
    /// 
    ///   - dynamodb:index:WriteCapacityUnits - The provisioned write capacity for
    ///     a DynamoDB global secondary index.
    /// 
    ///   - rds:cluster:ReadReplicaCount - The count of Aurora Replicas in an Aurora
    ///     DB cluster. Available for Aurora MySQL-compatible edition and Aurora PostgreSQL-compatible
    ///     edition.
    /// 
    ///   - sagemaker:variant:DesiredInstanceCount - The number of EC2 instances
    ///     for a SageMaker model endpoint variant.
    /// 
    ///   - custom-resource:ResourceType:Property - The scalable dimension for a
    ///     custom resource provided by your own application or service.
    /// 
    ///   - comprehend:document-classifier-endpoint:DesiredInferenceUnits - The
    ///     number of inference units for an Amazon Comprehend document classification
    ///     endpoint.
    /// 
    ///   - comprehend:entity-recognizer-endpoint:DesiredInferenceUnits - The number
    ///     of inference units for an Amazon Comprehend entity recognizer endpoint.
    /// 
    ///   - lambda:function:ProvisionedConcurrency - The provisioned concurrency
    ///     for a Lambda function.
    /// 
    ///   - cassandra:table:ReadCapacityUnits - The provisioned read capacity for
    ///     an Amazon Keyspaces table.
    /// 
    ///   - cassandra:table:WriteCapacityUnits - The provisioned write capacity
    ///     for an Amazon Keyspaces table.
    /// 
    ///   - kafka:broker-storage:VolumeSize - The provisioned volume size (in GiB)
    ///     for brokers in an Amazon MSK cluster.
    /// 
    ///   - elasticache:replication-group:NodeGroups - The number of node groups
    ///     for an Amazon ElastiCache replication group.
    /// 
    ///   - elasticache:replication-group:Replicas - The number of replicas per
    ///     node group for an Amazon ElastiCache replication group.
    /// 
    ///   - neptune:cluster:ReadReplicaCount - The count of read replicas in an
    ///     Amazon Neptune DB cluster.
    /// 
    ///   - sagemaker:variant:DesiredProvisionedConcurrency - The provisioned concurrency
    ///     for a SageMaker serverless endpoint.
    /// 
    ///   - sagemaker:inference-component:DesiredCopyCount - The number of copies
    ///     across an endpoint for a SageMaker inference component.
    /// 
    ///   - workspaces:workspacespool:DesiredUserSessions - The number of user sessions
    ///     for the WorkSpaces in the pool.
    /// </summary>
    [JsonPropertyName("scalableDimension")]
    public required string ScalableDimension { get; set; }

    /// <summary>
    /// The namespace of the Amazon Web Services service that provides the resource.
    /// For a resource provided by your own application or service, use custom-resource
    /// instead.
    /// </summary>
    [JsonPropertyName("serviceNamespace")]
    public required string ServiceNamespace { get; set; }

    /// <summary>
    /// A step scaling policy.
    /// 
    /// This parameter is required if you are creating a policy and the policy type
    /// is StepScaling.
    /// </summary>
    [JsonPropertyName("stepScalingPolicyConfiguration")]
    public V1alpha1ScalingPolicySpecStepScalingPolicyConfiguration? StepScalingPolicyConfiguration { get; set; }

    /// <summary>
    /// A target tracking scaling policy. Includes support for predefined or customized
    /// metrics.
    /// 
    /// This parameter is required if you are creating a policy and the policy type
    /// is TargetTrackingScaling.
    /// </summary>
    [JsonPropertyName("targetTrackingScalingPolicyConfiguration")]
    public V1alpha1ScalingPolicySpecTargetTrackingScalingPolicyConfiguration? TargetTrackingScalingPolicyConfiguration { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScalingPolicyStatusAckResourceMetadata
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

/// <summary>Represents a CloudWatch alarm associated with a scaling policy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScalingPolicyStatusAlarms
{
    [JsonPropertyName("alarmARN")]
    public string? AlarmARN { get; set; }

    [JsonPropertyName("alarmName")]
    public string? AlarmName { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScalingPolicyStatusConditions
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

/// <summary>ScalingPolicyStatus defines the observed state of ScalingPolicy</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ScalingPolicyStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ScalingPolicyStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>The CloudWatch alarms created for the target tracking scaling policy.</summary>
    [JsonPropertyName("alarms")]
    public IList<V1alpha1ScalingPolicyStatusAlarms>? Alarms { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ScalingPolicyStatusConditions>? Conditions { get; set; }

    /// <summary>The Unix timestamp for when the scaling policy was created.</summary>
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>The Unix timestamp for when the scaling policy was created.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }
}

/// <summary>ScalingPolicy is the Schema for the ScalingPolicies API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ScalingPolicy : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ScalingPolicySpec?>, IStatus<V1alpha1ScalingPolicyStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ScalingPolicy";
    public const string KubeGroup = "applicationautoscaling.services.k8s.aws";
    public const string KubePluralName = "scalingpolicies";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "applicationautoscaling.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ScalingPolicy";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ScalingPolicySpec defines the desired state of ScalingPolicy.
    /// 
    /// Represents a scaling policy to use with Application Auto Scaling.
    /// 
    /// For more information about configuring scaling policies for a specific service,
    /// see Amazon Web Services services that you can use with Application Auto Scaling
    /// (https://docs.aws.amazon.com/autoscaling/application/userguide/integrated-services-list.html)
    /// in the Application Auto Scaling User Guide.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ScalingPolicySpec? Spec { get; set; }

    /// <summary>ScalingPolicyStatus defines the observed state of ScalingPolicy</summary>
    [JsonPropertyName("status")]
    public V1alpha1ScalingPolicyStatus? Status { get; set; }
}