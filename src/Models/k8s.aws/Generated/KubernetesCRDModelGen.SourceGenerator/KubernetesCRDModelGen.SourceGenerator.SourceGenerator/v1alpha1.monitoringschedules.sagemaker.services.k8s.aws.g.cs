#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.services.k8s.aws;
/// <summary>MonitoringSchedule is the Schema for the MonitoringSchedules API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MonitoringScheduleList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1MonitoringSchedule>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MonitoringScheduleList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "monitoringschedules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MonitoringScheduleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1MonitoringSchedule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1MonitoringSchedule> Items { get; set; }
}

/// <summary>The constraints resource for a monitoring job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionBaselineConfigConstraintsResource
{
    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>The statistics resource for a monitoring job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionBaselineConfigStatisticsResource
{
    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>
/// Configuration for monitoring constraints and monitoring statistics. These
/// baseline resources are compared against the results of the current job from
/// the series of jobs scheduled to collect data periodically.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionBaselineConfig
{
    [JsonPropertyName("baseliningJobName")]
    public string? BaseliningJobName { get; set; }

    /// <summary>The constraints resource for a monitoring job.</summary>
    [JsonPropertyName("constraintsResource")]
    public V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionBaselineConfigConstraintsResource? ConstraintsResource { get; set; }

    /// <summary>The statistics resource for a monitoring job.</summary>
    [JsonPropertyName("statisticsResource")]
    public V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionBaselineConfigStatisticsResource? StatisticsResource { get; set; }
}

/// <summary>Container image configuration object for the monitoring job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionMonitoringAppSpecification
{
    [JsonPropertyName("containerArguments")]
    public IList<string>? ContainerArguments { get; set; }

    [JsonPropertyName("containerEntrypoint")]
    public IList<string>? ContainerEntrypoint { get; set; }

    [JsonPropertyName("imageURI")]
    public string? ImageURI { get; set; }

    [JsonPropertyName("postAnalyticsProcessorSourceURI")]
    public string? PostAnalyticsProcessorSourceURI { get; set; }

    [JsonPropertyName("recordPreprocessorSourceURI")]
    public string? RecordPreprocessorSourceURI { get; set; }
}

/// <summary>Input object for the endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsEndpointInput
{
    [JsonPropertyName("endTimeOffset")]
    public string? EndTimeOffset { get; set; }

    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    [JsonPropertyName("excludeFeaturesAttribute")]
    public string? ExcludeFeaturesAttribute { get; set; }

    [JsonPropertyName("featuresAttribute")]
    public string? FeaturesAttribute { get; set; }

    [JsonPropertyName("inferenceAttribute")]
    public string? InferenceAttribute { get; set; }

    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    [JsonPropertyName("probabilityAttribute")]
    public string? ProbabilityAttribute { get; set; }

    [JsonPropertyName("probabilityThresholdAttribute")]
    public double? ProbabilityThresholdAttribute { get; set; }

    [JsonPropertyName("s3DataDistributionType")]
    public string? S3DataDistributionType { get; set; }

    [JsonPropertyName("s3InputMode")]
    public string? S3InputMode { get; set; }

    [JsonPropertyName("startTimeOffset")]
    public string? StartTimeOffset { get; set; }
}

/// <summary>The inputs for a monitoring job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputs
{
    /// <summary>Input object for the endpoint</summary>
    [JsonPropertyName("endpointInput")]
    public V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputsEndpointInput? EndpointInput { get; set; }
}

/// <summary>
/// Information about where and how you want to store the results of a monitoring
/// job.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputsS3Output
{
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }

    [JsonPropertyName("s3UploadMode")]
    public string? S3UploadMode { get; set; }
}

/// <summary>The output object for a monitoring job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputs
{
    /// <summary>
    /// Information about where and how you want to store the results of a monitoring
    /// job.
    /// </summary>
    [JsonPropertyName("s3Output")]
    public V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputsS3Output? S3Output { get; set; }
}

/// <summary>The output configuration for monitoring jobs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfig
{
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("monitoringOutputs")]
    public IList<V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfigMonitoringOutputs>? MonitoringOutputs { get; set; }
}

/// <summary>Configuration for the cluster used to run model monitoring jobs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResourcesClusterConfig
{
    [JsonPropertyName("instanceCount")]
    public long? InstanceCount { get; set; }

    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    [JsonPropertyName("volumeKMSKeyID")]
    public string? VolumeKMSKeyID { get; set; }

    [JsonPropertyName("volumeSizeInGB")]
    public long? VolumeSizeInGB { get; set; }
}

/// <summary>Identifies the resources to deploy for a monitoring job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResources
{
    /// <summary>Configuration for the cluster used to run model monitoring jobs.</summary>
    [JsonPropertyName("clusterConfig")]
    public V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResourcesClusterConfig? ClusterConfig { get; set; }
}

/// <summary>
/// Specifies an Amazon Virtual Private Cloud (VPC) that your SageMaker jobs,
/// hosted models, and compute resources have access to. You can control access
/// to and from your resources by configuring a VPC. For more information, see
/// Give SageMaker Access to Resources in your Amazon VPC (https://docs.aws.amazon.com/sagemaker/latest/dg/infrastructure-give-access.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionNetworkConfigVpcConfig
{
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>
/// Networking options for a job, such as network traffic encryption between
/// containers, whether to allow inbound and outbound network calls to and from
/// containers, and the VPC subnets and security groups to use for VPC-enabled
/// jobs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionNetworkConfig
{
    [JsonPropertyName("enableInterContainerTrafficEncryption")]
    public bool? EnableInterContainerTrafficEncryption { get; set; }

    [JsonPropertyName("enableNetworkIsolation")]
    public bool? EnableNetworkIsolation { get; set; }

    /// <summary>
    /// Specifies an Amazon Virtual Private Cloud (VPC) that your SageMaker jobs,
    /// hosted models, and compute resources have access to. You can control access
    /// to and from your resources by configuring a VPC. For more information, see
    /// Give SageMaker Access to Resources in your Amazon VPC (https://docs.aws.amazon.com/sagemaker/latest/dg/infrastructure-give-access.html).
    /// </summary>
    [JsonPropertyName("vpcConfig")]
    public V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionNetworkConfigVpcConfig? VpcConfig { get; set; }
}

/// <summary>A time limit for how long the monitoring job is allowed to run before stopping.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionStoppingCondition
{
    [JsonPropertyName("maxRuntimeInSeconds")]
    public long? MaxRuntimeInSeconds { get; set; }
}

/// <summary>Defines the monitoring job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinition
{
    /// <summary>
    /// Configuration for monitoring constraints and monitoring statistics. These
    /// baseline resources are compared against the results of the current job from
    /// the series of jobs scheduled to collect data periodically.
    /// </summary>
    [JsonPropertyName("baselineConfig")]
    public V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionBaselineConfig? BaselineConfig { get; set; }

    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>Container image configuration object for the monitoring job.</summary>
    [JsonPropertyName("monitoringAppSpecification")]
    public V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionMonitoringAppSpecification? MonitoringAppSpecification { get; set; }

    [JsonPropertyName("monitoringInputs")]
    public IList<V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionMonitoringInputs>? MonitoringInputs { get; set; }

    /// <summary>The output configuration for monitoring jobs.</summary>
    [JsonPropertyName("monitoringOutputConfig")]
    public V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionMonitoringOutputConfig? MonitoringOutputConfig { get; set; }

    /// <summary>Identifies the resources to deploy for a monitoring job.</summary>
    [JsonPropertyName("monitoringResources")]
    public V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionMonitoringResources? MonitoringResources { get; set; }

    /// <summary>
    /// Networking options for a job, such as network traffic encryption between
    /// containers, whether to allow inbound and outbound network calls to and from
    /// containers, and the VPC subnets and security groups to use for VPC-enabled
    /// jobs.
    /// </summary>
    [JsonPropertyName("networkConfig")]
    public V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionNetworkConfig? NetworkConfig { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    /// <summary>A time limit for how long the monitoring job is allowed to run before stopping.</summary>
    [JsonPropertyName("stoppingCondition")]
    public V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinitionStoppingCondition? StoppingCondition { get; set; }
}

/// <summary>Configuration details about the monitoring schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigScheduleConfig
{
    [JsonPropertyName("dataAnalysisEndTime")]
    public string? DataAnalysisEndTime { get; set; }

    [JsonPropertyName("dataAnalysisStartTime")]
    public string? DataAnalysisStartTime { get; set; }

    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }
}

/// <summary>
/// The configuration object that specifies the monitoring schedule and defines
/// the monitoring job.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecMonitoringScheduleConfig
{
    /// <summary>Defines the monitoring job.</summary>
    [JsonPropertyName("monitoringJobDefinition")]
    public V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigMonitoringJobDefinition? MonitoringJobDefinition { get; set; }

    [JsonPropertyName("monitoringJobDefinitionName")]
    public string? MonitoringJobDefinitionName { get; set; }

    [JsonPropertyName("monitoringType")]
    public string? MonitoringType { get; set; }

    /// <summary>Configuration details about the monitoring schedule.</summary>
    [JsonPropertyName("scheduleConfig")]
    public V1alpha1MonitoringScheduleSpecMonitoringScheduleConfigScheduleConfig? ScheduleConfig { get; set; }
}

/// <summary>
/// A tag object that consists of a key and an optional value, used to manage
/// metadata for SageMaker Amazon Web Services resources.
/// 
/// You can add tags to notebook instances, training jobs, hyperparameter tuning
/// jobs, batch transform jobs, models, labeling jobs, work teams, endpoint configurations,
/// and endpoints. For more information on adding tags to SageMaker resources,
/// see AddTags (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AddTags.html).
/// 
/// For more information on adding metadata to your Amazon Web Services resources
/// with tagging, see Tagging Amazon Web Services resources (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html).
/// For advice on best practices for managing Amazon Web Services resources with
/// tagging, see Tagging Best Practices: Implement an Effective Amazon Web Services
/// Resource Tagging Strategy (https://d1.awsstatic.com/whitepapers/aws-tagging-best-practices.pdf).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// MonitoringScheduleSpec defines the desired state of MonitoringSchedule.
/// 
/// A schedule for a model monitoring job. For information about model monitor,
/// see Amazon SageMaker Model Monitor (https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleSpec
{
    /// <summary>
    /// The configuration object that specifies the monitoring schedule and defines
    /// the monitoring job.
    /// </summary>
    [JsonPropertyName("monitoringScheduleConfig")]
    public required V1alpha1MonitoringScheduleSpecMonitoringScheduleConfig MonitoringScheduleConfig { get; set; }

    /// <summary>
    /// The name of the monitoring schedule. The name must be unique within an Amazon
    /// Web Services Region within an Amazon Web Services account.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$`
    /// </summary>
    [JsonPropertyName("monitoringScheduleName")]
    public required string MonitoringScheduleName { get; set; }

    /// <summary>
    /// (Optional) An array of key-value pairs. For more information, see Using Cost
    /// Allocation Tags (https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-whatURL)
    /// in the Amazon Web Services Billing and Cost Management User Guide.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1MonitoringScheduleSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleStatusAckResourceMetadata
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleStatusConditions
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

/// <summary>Describes metadata on the last execution to run, if there was one.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleStatusLastMonitoringExecutionSummary
{
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    [JsonPropertyName("endpointName")]
    public string? EndpointName { get; set; }

    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    [JsonPropertyName("monitoringExecutionStatus")]
    public string? MonitoringExecutionStatus { get; set; }

    [JsonPropertyName("monitoringJobDefinitionName")]
    public string? MonitoringJobDefinitionName { get; set; }

    [JsonPropertyName("monitoringScheduleName")]
    public string? MonitoringScheduleName { get; set; }

    [JsonPropertyName("monitoringType")]
    public string? MonitoringType { get; set; }

    [JsonPropertyName("processingJobARN")]
    public string? ProcessingJobARN { get; set; }

    [JsonPropertyName("scheduledTime")]
    public DateTime? ScheduledTime { get; set; }
}

/// <summary>MonitoringScheduleStatus defines the observed state of MonitoringSchedule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1MonitoringScheduleStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1MonitoringScheduleStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1MonitoringScheduleStatusConditions>? Conditions { get; set; }

    /// <summary>The time at which the monitoring job was created.</summary>
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>
    /// A string, up to one KB in size, that contains the reason a monitoring job
    /// failed, if it failed.
    /// </summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>The time at which the monitoring job was last modified.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    /// <summary>Describes metadata on the last execution to run, if there was one.</summary>
    [JsonPropertyName("lastMonitoringExecutionSummary")]
    public V1alpha1MonitoringScheduleStatusLastMonitoringExecutionSummary? LastMonitoringExecutionSummary { get; set; }

    /// <summary>The status of an monitoring job.</summary>
    [JsonPropertyName("monitoringScheduleStatus")]
    public string? MonitoringScheduleStatus { get; set; }
}

/// <summary>MonitoringSchedule is the Schema for the MonitoringSchedules API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1MonitoringSchedule : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1MonitoringScheduleSpec?>, IStatus<V1alpha1MonitoringScheduleStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "MonitoringSchedule";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "monitoringschedules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "MonitoringSchedule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// MonitoringScheduleSpec defines the desired state of MonitoringSchedule.
    /// 
    /// A schedule for a model monitoring job. For information about model monitor,
    /// see Amazon SageMaker Model Monitor (https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor.html).
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1MonitoringScheduleSpec? Spec { get; set; }

    /// <summary>MonitoringScheduleStatus defines the observed state of MonitoringSchedule</summary>
    [JsonPropertyName("status")]
    public V1alpha1MonitoringScheduleStatus? Status { get; set; }
}