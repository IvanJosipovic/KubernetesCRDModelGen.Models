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
/// <summary>LabelingJob is the Schema for the LabelingJobs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1LabelingJobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1LabelingJob>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "LabelingJobList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "labelingjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LabelingJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1LabelingJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1LabelingJob> Items { get; set; }
}

/// <summary>
/// Configures how labels are consolidated across human workers and processes
/// output data.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobSpecHumanTaskConfigAnnotationConsolidationConfig
{
    [JsonPropertyName("annotationConsolidationLambdaARN")]
    public string? AnnotationConsolidationLambdaARN { get; set; }
}

/// <summary>Represents an amount of money in United States dollars.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobSpecHumanTaskConfigPublicWorkforceTaskPriceAmountInUsd
{
    [JsonPropertyName("cents")]
    public long? Cents { get; set; }

    [JsonPropertyName("dollars")]
    public long? Dollars { get; set; }

    [JsonPropertyName("tenthFractionsOfACent")]
    public long? TenthFractionsOfACent { get; set; }
}

/// <summary>
/// Defines the amount of money paid to an Amazon Mechanical Turk worker for
/// each task performed.
/// 
/// Use one of the following prices for bounding box tasks. Prices are in US
/// dollars and should be based on the complexity of the task; the longer it
/// takes in your initial testing, the more you should offer.
/// 
///    * 0.036
/// 
///    * 0.048
/// 
///    * 0.060
/// 
///    * 0.072
/// 
///    * 0.120
/// 
///    * 0.240
/// 
///    * 0.360
/// 
///    * 0.480
/// 
///    * 0.600
/// 
///    * 0.720
/// 
///    * 0.840
/// 
///    * 0.960
/// 
///    * 1.080
/// 
///    * 1.200
/// 
/// Use one of the following prices for image classification, text classification,
/// and custom tasks. Prices are in US dollars.
/// 
///    * 0.012
/// 
///    * 0.024
/// 
///    * 0.036
/// 
///    * 0.048
/// 
///    * 0.060
/// 
///    * 0.072
/// 
///    * 0.120
/// 
///    * 0.240
/// 
///    * 0.360
/// 
///    * 0.480
/// 
///    * 0.600
/// 
///    * 0.720
/// 
///    * 0.840
/// 
///    * 0.960
/// 
///    * 1.080
/// 
///    * 1.200
/// 
/// Use one of the following prices for semantic segmentation tasks. Prices are
/// in US dollars.
/// 
///    * 0.840
/// 
///    * 0.960
/// 
///    * 1.080
/// 
///    * 1.200
/// 
/// Use one of the following prices for Textract AnalyzeDocument Important Form
/// Key Amazon Augmented AI review tasks. Prices are in US dollars.
/// 
///    * 2.400
/// 
///    * 2.280
/// 
///    * 2.160
/// 
///    * 2.040
/// 
///    * 1.920
/// 
///    * 1.800
/// 
///    * 1.680
/// 
///    * 1.560
/// 
///    * 1.440
/// 
///    * 1.320
/// 
///    * 1.200
/// 
///    * 1.080
/// 
///    * 0.960
/// 
///    * 0.840
/// 
///    * 0.720
/// 
///    * 0.600
/// 
///    * 0.480
/// 
///    * 0.360
/// 
///    * 0.240
/// 
///    * 0.120
/// 
///    * 0.072
/// 
///    * 0.060
/// 
///    * 0.048
/// 
///    * 0.036
/// 
///    * 0.024
/// 
///    * 0.012
/// 
/// Use one of the following prices for Rekognition DetectModerationLabels Amazon
/// Augmented AI review tasks. Prices are in US dollars.
/// 
///    * 1.200
/// 
///    * 1.080
/// 
///    * 0.960
/// 
///    * 0.840
/// 
///    * 0.720
/// 
///    * 0.600
/// 
///    * 0.480
/// 
///    * 0.360
/// 
///    * 0.240
/// 
///    * 0.120
/// 
///    * 0.072
/// 
///    * 0.060
/// 
///    * 0.048
/// 
///    * 0.036
/// 
///    * 0.024
/// 
///    * 0.012
/// 
/// Use one of the following prices for Amazon Augmented AI custom human review
/// tasks. Prices are in US dollars.
/// 
///    * 1.200
/// 
///    * 1.080
/// 
///    * 0.960
/// 
///    * 0.840
/// 
///    * 0.720
/// 
///    * 0.600
/// 
///    * 0.480
/// 
///    * 0.360
/// 
///    * 0.240
/// 
///    * 0.120
/// 
///    * 0.072
/// 
///    * 0.060
/// 
///    * 0.048
/// 
///    * 0.036
/// 
///    * 0.024
/// 
///    * 0.012
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobSpecHumanTaskConfigPublicWorkforceTaskPrice
{
    /// <summary>Represents an amount of money in United States dollars.</summary>
    [JsonPropertyName("amountInUsd")]
    public V1alpha1LabelingJobSpecHumanTaskConfigPublicWorkforceTaskPriceAmountInUsd? AmountInUsd { get; set; }
}

/// <summary>
/// Provided configuration information for the worker UI for a labeling job.
/// Provide either HumanTaskUiArn or UiTemplateS3Uri.
/// 
/// For named entity recognition, 3D point cloud and video frame labeling jobs,
/// use HumanTaskUiArn.
/// 
/// For all other Ground Truth built-in task types and custom task types, use
/// UiTemplateS3Uri to specify the location of a worker task template in Amazon
/// S3.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobSpecHumanTaskConfigUiConfig
{
    [JsonPropertyName("humanTaskUIARN")]
    public string? HumanTaskUIARN { get; set; }

    [JsonPropertyName("uiTemplateS3URI")]
    public string? UiTemplateS3URI { get; set; }
}

/// <summary>
/// Configures the labeling task and how it is presented to workers; including,
/// but not limited to price, keywords, and batch size (task count).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobSpecHumanTaskConfig
{
    /// <summary>
    /// Configures how labels are consolidated across human workers and processes
    /// output data.
    /// </summary>
    [JsonPropertyName("annotationConsolidationConfig")]
    public V1alpha1LabelingJobSpecHumanTaskConfigAnnotationConsolidationConfig? AnnotationConsolidationConfig { get; set; }

    [JsonPropertyName("maxConcurrentTaskCount")]
    public long? MaxConcurrentTaskCount { get; set; }

    [JsonPropertyName("numberOfHumanWorkersPerDataObject")]
    public long? NumberOfHumanWorkersPerDataObject { get; set; }

    [JsonPropertyName("preHumanTaskLambdaARN")]
    public string? PreHumanTaskLambdaARN { get; set; }

    /// <summary>
    /// Defines the amount of money paid to an Amazon Mechanical Turk worker for
    /// each task performed.
    /// 
    /// Use one of the following prices for bounding box tasks. Prices are in US
    /// dollars and should be based on the complexity of the task; the longer it
    /// takes in your initial testing, the more you should offer.
    /// 
    ///    * 0.036
    /// 
    ///    * 0.048
    /// 
    ///    * 0.060
    /// 
    ///    * 0.072
    /// 
    ///    * 0.120
    /// 
    ///    * 0.240
    /// 
    ///    * 0.360
    /// 
    ///    * 0.480
    /// 
    ///    * 0.600
    /// 
    ///    * 0.720
    /// 
    ///    * 0.840
    /// 
    ///    * 0.960
    /// 
    ///    * 1.080
    /// 
    ///    * 1.200
    /// 
    /// Use one of the following prices for image classification, text classification,
    /// and custom tasks. Prices are in US dollars.
    /// 
    ///    * 0.012
    /// 
    ///    * 0.024
    /// 
    ///    * 0.036
    /// 
    ///    * 0.048
    /// 
    ///    * 0.060
    /// 
    ///    * 0.072
    /// 
    ///    * 0.120
    /// 
    ///    * 0.240
    /// 
    ///    * 0.360
    /// 
    ///    * 0.480
    /// 
    ///    * 0.600
    /// 
    ///    * 0.720
    /// 
    ///    * 0.840
    /// 
    ///    * 0.960
    /// 
    ///    * 1.080
    /// 
    ///    * 1.200
    /// 
    /// Use one of the following prices for semantic segmentation tasks. Prices are
    /// in US dollars.
    /// 
    ///    * 0.840
    /// 
    ///    * 0.960
    /// 
    ///    * 1.080
    /// 
    ///    * 1.200
    /// 
    /// Use one of the following prices for Textract AnalyzeDocument Important Form
    /// Key Amazon Augmented AI review tasks. Prices are in US dollars.
    /// 
    ///    * 2.400
    /// 
    ///    * 2.280
    /// 
    ///    * 2.160
    /// 
    ///    * 2.040
    /// 
    ///    * 1.920
    /// 
    ///    * 1.800
    /// 
    ///    * 1.680
    /// 
    ///    * 1.560
    /// 
    ///    * 1.440
    /// 
    ///    * 1.320
    /// 
    ///    * 1.200
    /// 
    ///    * 1.080
    /// 
    ///    * 0.960
    /// 
    ///    * 0.840
    /// 
    ///    * 0.720
    /// 
    ///    * 0.600
    /// 
    ///    * 0.480
    /// 
    ///    * 0.360
    /// 
    ///    * 0.240
    /// 
    ///    * 0.120
    /// 
    ///    * 0.072
    /// 
    ///    * 0.060
    /// 
    ///    * 0.048
    /// 
    ///    * 0.036
    /// 
    ///    * 0.024
    /// 
    ///    * 0.012
    /// 
    /// Use one of the following prices for Rekognition DetectModerationLabels Amazon
    /// Augmented AI review tasks. Prices are in US dollars.
    /// 
    ///    * 1.200
    /// 
    ///    * 1.080
    /// 
    ///    * 0.960
    /// 
    ///    * 0.840
    /// 
    ///    * 0.720
    /// 
    ///    * 0.600
    /// 
    ///    * 0.480
    /// 
    ///    * 0.360
    /// 
    ///    * 0.240
    /// 
    ///    * 0.120
    /// 
    ///    * 0.072
    /// 
    ///    * 0.060
    /// 
    ///    * 0.048
    /// 
    ///    * 0.036
    /// 
    ///    * 0.024
    /// 
    ///    * 0.012
    /// 
    /// Use one of the following prices for Amazon Augmented AI custom human review
    /// tasks. Prices are in US dollars.
    /// 
    ///    * 1.200
    /// 
    ///    * 1.080
    /// 
    ///    * 0.960
    /// 
    ///    * 0.840
    /// 
    ///    * 0.720
    /// 
    ///    * 0.600
    /// 
    ///    * 0.480
    /// 
    ///    * 0.360
    /// 
    ///    * 0.240
    /// 
    ///    * 0.120
    /// 
    ///    * 0.072
    /// 
    ///    * 0.060
    /// 
    ///    * 0.048
    /// 
    ///    * 0.036
    /// 
    ///    * 0.024
    /// 
    ///    * 0.012
    /// </summary>
    [JsonPropertyName("publicWorkforceTaskPrice")]
    public V1alpha1LabelingJobSpecHumanTaskConfigPublicWorkforceTaskPrice? PublicWorkforceTaskPrice { get; set; }

    [JsonPropertyName("taskAvailabilityLifetimeInSeconds")]
    public long? TaskAvailabilityLifetimeInSeconds { get; set; }

    [JsonPropertyName("taskDescription")]
    public string? TaskDescription { get; set; }

    [JsonPropertyName("taskKeywords")]
    public IList<string>? TaskKeywords { get; set; }

    [JsonPropertyName("taskTimeLimitInSeconds")]
    public long? TaskTimeLimitInSeconds { get; set; }

    [JsonPropertyName("taskTitle")]
    public string? TaskTitle { get; set; }

    /// <summary>
    /// Provided configuration information for the worker UI for a labeling job.
    /// Provide either HumanTaskUiArn or UiTemplateS3Uri.
    /// 
    /// For named entity recognition, 3D point cloud and video frame labeling jobs,
    /// use HumanTaskUiArn.
    /// 
    /// For all other Ground Truth built-in task types and custom task types, use
    /// UiTemplateS3Uri to specify the location of a worker task template in Amazon
    /// S3.
    /// </summary>
    [JsonPropertyName("uiConfig")]
    public V1alpha1LabelingJobSpecHumanTaskConfigUiConfig? UiConfig { get; set; }

    [JsonPropertyName("workteamARN")]
    public string? WorkteamARN { get; set; }
}

/// <summary>
/// Attributes of the data specified by the customer. Use these to describe the
/// data to be labeled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobSpecInputConfigDataAttributes
{
    [JsonPropertyName("contentClassifiers")]
    public IList<string>? ContentClassifiers { get; set; }
}

/// <summary>The Amazon S3 location of the input data objects.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobSpecInputConfigDataSourceS3DataSource
{
    [JsonPropertyName("manifestS3URI")]
    public string? ManifestS3URI { get; set; }
}

/// <summary>An Amazon SNS data source used for streaming labeling jobs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobSpecInputConfigDataSourceSnsDataSource
{
    [JsonPropertyName("snsTopicARN")]
    public string? SnsTopicARN { get; set; }
}

/// <summary>
/// Provides information about the location of input data.
/// 
/// You must specify at least one of the following: S3DataSource or SnsDataSource.
/// 
/// Use SnsDataSource to specify an SNS input topic for a streaming labeling
/// job. If you do not specify and SNS input topic ARN, Ground Truth will create
/// a one-time labeling job.
/// 
/// Use S3DataSource to specify an input manifest file for both streaming and
/// one-time labeling jobs. Adding an S3DataSource is optional if you use SnsDataSource
/// to create a streaming labeling job.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobSpecInputConfigDataSource
{
    /// <summary>The Amazon S3 location of the input data objects.</summary>
    [JsonPropertyName("s3DataSource")]
    public V1alpha1LabelingJobSpecInputConfigDataSourceS3DataSource? S3DataSource { get; set; }

    /// <summary>An Amazon SNS data source used for streaming labeling jobs.</summary>
    [JsonPropertyName("snsDataSource")]
    public V1alpha1LabelingJobSpecInputConfigDataSourceSnsDataSource? SnsDataSource { get; set; }
}

/// <summary>
/// Input data for the labeling job, such as the Amazon S3 location of the data
/// objects and the location of the manifest file that describes the data objects.
/// 
/// You must specify at least one of the following: S3DataSource or SnsDataSource.
/// 
///   - Use SnsDataSource to specify an SNS input topic for a streaming labeling
///     job. If you do not specify and SNS input topic ARN, Ground Truth will
///     create a one-time labeling job that stops after all data objects in the
///     input manifest file have been labeled.
/// 
///   - Use S3DataSource to specify an input manifest file for both streaming
///     and one-time labeling jobs. Adding an S3DataSource is optional if you
///     use SnsDataSource to create a streaming labeling job.
/// 
/// If you use the Amazon Mechanical Turk workforce, your input data should not
/// include confidential information, personal information or protected health
/// information. Use ContentClassifiers to specify that your data is free of
/// personally identifiable information and adult content.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobSpecInputConfig
{
    /// <summary>
    /// Attributes of the data specified by the customer. Use these to describe the
    /// data to be labeled.
    /// </summary>
    [JsonPropertyName("dataAttributes")]
    public V1alpha1LabelingJobSpecInputConfigDataAttributes? DataAttributes { get; set; }

    /// <summary>
    /// Provides information about the location of input data.
    /// 
    /// You must specify at least one of the following: S3DataSource or SnsDataSource.
    /// 
    /// Use SnsDataSource to specify an SNS input topic for a streaming labeling
    /// job. If you do not specify and SNS input topic ARN, Ground Truth will create
    /// a one-time labeling job.
    /// 
    /// Use S3DataSource to specify an input manifest file for both streaming and
    /// one-time labeling jobs. Adding an S3DataSource is optional if you use SnsDataSource
    /// to create a streaming labeling job.
    /// </summary>
    [JsonPropertyName("dataSource")]
    public V1alpha1LabelingJobSpecInputConfigDataSource? DataSource { get; set; }
}

/// <summary>
/// Specifies an Amazon Virtual Private Cloud (VPC) that your SageMaker jobs,
/// hosted models, and compute resources have access to. You can control access
/// to and from your resources by configuring a VPC. For more information, see
/// Give SageMaker Access to Resources in your Amazon VPC (https://docs.aws.amazon.com/sagemaker/latest/dg/infrastructure-give-access.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobSpecLabelingJobAlgorithmsConfigLabelingJobResourceConfigVpcConfig
{
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>
/// Configure encryption on the storage volume attached to the ML compute instance
/// used to run automated data labeling model training and inference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobSpecLabelingJobAlgorithmsConfigLabelingJobResourceConfig
{
    [JsonPropertyName("volumeKMSKeyID")]
    public string? VolumeKMSKeyID { get; set; }

    /// <summary>
    /// Specifies an Amazon Virtual Private Cloud (VPC) that your SageMaker jobs,
    /// hosted models, and compute resources have access to. You can control access
    /// to and from your resources by configuring a VPC. For more information, see
    /// Give SageMaker Access to Resources in your Amazon VPC (https://docs.aws.amazon.com/sagemaker/latest/dg/infrastructure-give-access.html).
    /// </summary>
    [JsonPropertyName("vpcConfig")]
    public V1alpha1LabelingJobSpecLabelingJobAlgorithmsConfigLabelingJobResourceConfigVpcConfig? VpcConfig { get; set; }
}

/// <summary>Configures the information required to perform automated data labeling.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobSpecLabelingJobAlgorithmsConfig
{
    [JsonPropertyName("initialActiveLearningModelARN")]
    public string? InitialActiveLearningModelARN { get; set; }

    [JsonPropertyName("labelingJobAlgorithmSpecificationARN")]
    public string? LabelingJobAlgorithmSpecificationARN { get; set; }

    /// <summary>
    /// Configure encryption on the storage volume attached to the ML compute instance
    /// used to run automated data labeling model training and inference.
    /// </summary>
    [JsonPropertyName("labelingJobResourceConfig")]
    public V1alpha1LabelingJobSpecLabelingJobAlgorithmsConfigLabelingJobResourceConfig? LabelingJobResourceConfig { get; set; }
}

/// <summary>
/// The location of the output data and the Amazon Web Services Key Management
/// Service key ID for the key used to encrypt the output data, if any.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobSpecOutputConfig
{
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }

    [JsonPropertyName("snsTopicARN")]
    public string? SnsTopicARN { get; set; }
}

/// <summary>
/// A set of conditions for stopping the labeling job. If any of the conditions
/// are met, the job is automatically stopped. You can use these conditions to
/// control the cost of data labeling.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobSpecStoppingConditions
{
    [JsonPropertyName("maxHumanLabeledObjectCount")]
    public long? MaxHumanLabeledObjectCount { get; set; }

    [JsonPropertyName("maxPercentageOfInputDatasetLabeled")]
    public long? MaxPercentageOfInputDatasetLabeled { get; set; }
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
public partial class V1alpha1LabelingJobSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>LabelingJobSpec defines the desired state of LabelingJob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobSpec
{
    /// <summary>
    /// Configures the labeling task and how it is presented to workers; including,
    /// but not limited to price, keywords, and batch size (task count).
    /// </summary>
    [JsonPropertyName("humanTaskConfig")]
    public required V1alpha1LabelingJobSpecHumanTaskConfig HumanTaskConfig { get; set; }

    /// <summary>
    /// Input data for the labeling job, such as the Amazon S3 location of the data
    /// objects and the location of the manifest file that describes the data objects.
    /// 
    /// You must specify at least one of the following: S3DataSource or SnsDataSource.
    /// 
    ///   - Use SnsDataSource to specify an SNS input topic for a streaming labeling
    ///     job. If you do not specify and SNS input topic ARN, Ground Truth will
    ///     create a one-time labeling job that stops after all data objects in the
    ///     input manifest file have been labeled.
    /// 
    ///   - Use S3DataSource to specify an input manifest file for both streaming
    ///     and one-time labeling jobs. Adding an S3DataSource is optional if you
    ///     use SnsDataSource to create a streaming labeling job.
    /// 
    /// If you use the Amazon Mechanical Turk workforce, your input data should not
    /// include confidential information, personal information or protected health
    /// information. Use ContentClassifiers to specify that your data is free of
    /// personally identifiable information and adult content.
    /// </summary>
    [JsonPropertyName("inputConfig")]
    public required V1alpha1LabelingJobSpecInputConfig InputConfig { get; set; }

    /// <summary>
    /// The attribute name to use for the label in the output manifest file. This
    /// is the key for the key/value pair formed with the label that a worker assigns
    /// to the object. The LabelAttributeName must meet the following requirements.
    /// 
    ///   - The name can&apos;t end with &quot;-metadata&quot;.
    /// 
    ///   - If you are using one of the built-in task types (https://docs.aws.amazon.com/sagemaker/latest/dg/sms-task-types.html)
    ///     or one of the following, the attribute name must end with &quot;-ref&quot;. Image
    ///     semantic segmentation (SemanticSegmentation) and adjustment (AdjustmentSemanticSegmentation)
    ///     labeling jobs for this task type. One exception is that verification (VerificationSemanticSegmentation)
    ///     must not end with -&quot;ref&quot;. Video frame object detection (VideoObjectDetection),
    ///     and adjustment and verification (AdjustmentVideoObjectDetection) labeling
    ///     jobs for this task type. Video frame object tracking (VideoObjectTracking),
    ///     and adjustment and verification (AdjustmentVideoObjectTracking) labeling
    ///     jobs for this task type. 3D point cloud semantic segmentation (3DPointCloudSemanticSegmentation),
    ///     and adjustment and verification (Adjustment3DPointCloudSemanticSegmentation)
    ///     labeling jobs for this task type. 3D point cloud object tracking (3DPointCloudObjectTracking),
    ///     and adjustment and verification (Adjustment3DPointCloudObjectTracking)
    ///     labeling jobs for this task type.
    /// 
    /// If you are creating an adjustment or verification labeling job, you must
    /// use a different LabelAttributeName than the one used in the original labeling
    /// job. The original labeling job is the Ground Truth labeling job that produced
    /// the labels that you want verified or adjusted. To learn more about adjustment
    /// and verification labeling jobs, see Verify and Adjust Labels (https://docs.aws.amazon.com/sagemaker/latest/dg/sms-verification-data.html).
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,126}$`
    /// </summary>
    [JsonPropertyName("labelAttributeName")]
    public required string LabelAttributeName { get; set; }

    /// <summary>
    /// The S3 URI of the file, referred to as a label category configuration file,
    /// that defines the categories used to label the data objects.
    /// 
    /// For 3D point cloud and video frame task types, you can add label category
    /// attributes and frame attributes to your label category configuration file.
    /// To learn how, see Create a Labeling Category Configuration File for 3D Point
    /// Cloud Labeling Jobs (https://docs.aws.amazon.com/sagemaker/latest/dg/sms-point-cloud-label-category-config.html).
    /// 
    /// For named entity recognition jobs, in addition to &quot;labels&quot;, you must provide
    /// worker instructions in the label category configuration file using the &quot;instructions&quot;
    /// parameter: &quot;instructions&quot;: {&quot;shortInstruction&quot;:&quot; &lt;h1&gt;Add header&lt;/h1&gt; &lt;p&gt;Add
    /// Instructions&lt;/p&gt; &quot;, &quot;fullInstruction&quot;:&quot; &lt;p&gt;Add additional instructions.&lt;/p&gt; &quot;}.
    /// For details and an example, see Create a Named Entity Recognition Labeling
    /// Job (API) (https://docs.aws.amazon.com/sagemaker/latest/dg/sms-named-entity-recg.html#sms-creating-ner-api).
    /// 
    /// For all other built-in task types (https://docs.aws.amazon.com/sagemaker/latest/dg/sms-task-types.html)
    /// and custom tasks (https://docs.aws.amazon.com/sagemaker/latest/dg/sms-custom-templates.html),
    /// your label category configuration file must be a JSON file in the following
    /// format. Identify the labels you want to use by replacing label_1, label_2,...,label_n
    /// with your label categories.
    /// 
    /// {
    /// 
    /// &quot;document-version&quot;: &quot;2018-11-28&quot;,
    /// 
    /// &quot;labels&quot;: [{&quot;label&quot;: &quot;label_1&quot;},{&quot;label&quot;: &quot;label_2&quot;},...{&quot;label&quot;: &quot;label_n&quot;}]
    /// 
    /// }
    /// 
    /// Note the following about the label category configuration file:
    /// 
    ///   - For image classification and text classification (single and multi-label)
    ///     you must specify at least two label categories. For all other task types,
    ///     the minimum number of label categories required is one.
    /// 
    ///   - Each label category must be unique, you cannot specify duplicate label
    ///     categories.
    /// 
    ///   - If you create a 3D point cloud or video frame adjustment or verification
    ///     labeling job, you must include auditLabelAttributeName in the label category
    ///     configuration. Use this parameter to enter the LabelAttributeName (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateLabelingJob.html#sagemaker-CreateLabelingJob-request-LabelAttributeName)
    ///     of the labeling job you want to adjust or verify annotations of.
    /// 
    /// Regex Pattern: `^(https|s3)://([^/]+)/?(.*)$`
    /// </summary>
    [JsonPropertyName("labelCategoryConfigS3URI")]
    public string? LabelCategoryConfigS3URI { get; set; }

    /// <summary>Configures the information required to perform automated data labeling.</summary>
    [JsonPropertyName("labelingJobAlgorithmsConfig")]
    public V1alpha1LabelingJobSpecLabelingJobAlgorithmsConfig? LabelingJobAlgorithmsConfig { get; set; }

    /// <summary>
    /// The name of the labeling job. This name is used to identify the job in a
    /// list of labeling jobs. Labeling job names must be unique within an Amazon
    /// Web Services account and region. LabelingJobName is not case sensitive. For
    /// example, Example-job and example-job are considered the same labeling job
    /// name by Ground Truth.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$`
    /// </summary>
    [JsonPropertyName("labelingJobName")]
    public required string LabelingJobName { get; set; }

    /// <summary>
    /// The location of the output data and the Amazon Web Services Key Management
    /// Service key ID for the key used to encrypt the output data, if any.
    /// </summary>
    [JsonPropertyName("outputConfig")]
    public required V1alpha1LabelingJobSpecOutputConfig OutputConfig { get; set; }

    /// <summary>
    /// The Amazon Resource Number (ARN) that Amazon SageMaker assumes to perform
    /// tasks on your behalf during data labeling. You must grant this role the necessary
    /// permissions so that Amazon SageMaker can successfully complete data labeling.
    /// 
    /// Regex Pattern: `^arn:aws[a-z\-]*:iam::\d{12}:role/?[a-zA-Z_0-9+=,.@\-_/]+$`
    /// </summary>
    [JsonPropertyName("roleARN")]
    public required string RoleARN { get; set; }

    /// <summary>
    /// A set of conditions for stopping the labeling job. If any of the conditions
    /// are met, the job is automatically stopped. You can use these conditions to
    /// control the cost of data labeling.
    /// </summary>
    [JsonPropertyName("stoppingConditions")]
    public V1alpha1LabelingJobSpecStoppingConditions? StoppingConditions { get; set; }

    /// <summary>
    /// An array of key/value pairs. For more information, see Using Cost Allocation
    /// Tags (https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-what)
    /// in the Amazon Web Services Billing and Cost Management User Guide.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1LabelingJobSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobStatusAckResourceMetadata
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
public partial class V1alpha1LabelingJobStatusConditions
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

/// <summary>
/// Provides a breakdown of the number of data objects labeled by humans, the
/// number of objects labeled by machine, the number of objects than couldn&apos;t
/// be labeled, and the total number of objects labeled.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobStatusLabelCounters
{
    [JsonPropertyName("failedNonRetryableError")]
    public long? FailedNonRetryableError { get; set; }

    [JsonPropertyName("humanLabeled")]
    public long? HumanLabeled { get; set; }

    [JsonPropertyName("machineLabeled")]
    public long? MachineLabeled { get; set; }

    [JsonPropertyName("totalLabeled")]
    public long? TotalLabeled { get; set; }

    [JsonPropertyName("unlabeled")]
    public long? Unlabeled { get; set; }
}

/// <summary>The location of the output produced by the labeling job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobStatusLabelingJobOutput
{
    [JsonPropertyName("finalActiveLearningModelARN")]
    public string? FinalActiveLearningModelARN { get; set; }

    [JsonPropertyName("outputDatasetS3URI")]
    public string? OutputDatasetS3URI { get; set; }
}

/// <summary>LabelingJobStatus defines the observed state of LabelingJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1LabelingJobStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1LabelingJobStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1LabelingJobStatusConditions>? Conditions { get; set; }

    /// <summary>If the job failed, the reason that it failed.</summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>
    /// A unique identifier for work done as part of a labeling job.
    /// 
    /// Regex Pattern: `^.+$`
    /// </summary>
    [JsonPropertyName("jobReferenceCode")]
    public string? JobReferenceCode { get; set; }

    /// <summary>
    /// Provides a breakdown of the number of data objects labeled by humans, the
    /// number of objects labeled by machine, the number of objects than couldn&apos;t
    /// be labeled, and the total number of objects labeled.
    /// </summary>
    [JsonPropertyName("labelCounters")]
    public V1alpha1LabelingJobStatusLabelCounters? LabelCounters { get; set; }

    /// <summary>The location of the output produced by the labeling job.</summary>
    [JsonPropertyName("labelingJobOutput")]
    public V1alpha1LabelingJobStatusLabelingJobOutput? LabelingJobOutput { get; set; }

    /// <summary>The processing status of the labeling job.</summary>
    [JsonPropertyName("labelingJobStatus")]
    public string? LabelingJobStatus { get; set; }
}

/// <summary>LabelingJob is the Schema for the LabelingJobs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1LabelingJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1LabelingJobSpec?>, IStatus<V1alpha1LabelingJobStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "LabelingJob";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "labelingjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "LabelingJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>LabelingJobSpec defines the desired state of LabelingJob.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1LabelingJobSpec? Spec { get; set; }

    /// <summary>LabelingJobStatus defines the observed state of LabelingJob</summary>
    [JsonPropertyName("status")]
    public V1alpha1LabelingJobStatus? Status { get; set; }
}