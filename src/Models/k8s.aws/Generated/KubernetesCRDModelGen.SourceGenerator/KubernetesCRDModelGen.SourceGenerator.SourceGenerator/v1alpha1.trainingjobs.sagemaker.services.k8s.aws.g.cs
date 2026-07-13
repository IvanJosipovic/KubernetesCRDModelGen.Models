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
/// <summary>TrainingJob is the Schema for the TrainingJobs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TrainingJobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1TrainingJob>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TrainingJobList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "trainingjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TrainingJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1TrainingJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1TrainingJob> Items { get; set; }
}

/// <summary>
/// Specifies a metric that the training algorithm writes to stderr or stdout.
/// You can view these logs to understand how your training job performs and
/// check for any errors encountered during training. SageMaker hyperparameter
/// tuning captures all defined metrics. Specify one of the defined metrics to
/// use as an objective metric using the TuningObjective (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTrainingJobDefinition.html#sagemaker-Type-HyperParameterTrainingJobDefinition-TuningObjective)
/// parameter in the HyperParameterTrainingJobDefinition API to evaluate job
/// performance during hyperparameter tuning.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecAlgorithmSpecificationMetricDefinitions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>
/// The registry path of the Docker image that contains the training algorithm
/// and algorithm-specific metadata, including the input mode. For more information
/// about algorithms provided by SageMaker, see Algorithms (https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html).
/// For information about providing your own algorithms, see Using Your Own Algorithms
/// with Amazon SageMaker (https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecAlgorithmSpecification
{
    [JsonPropertyName("algorithmName")]
    public string? AlgorithmName { get; set; }

    [JsonPropertyName("enableSageMakerMetricsTimeSeries")]
    public bool? EnableSageMakerMetricsTimeSeries { get; set; }

    [JsonPropertyName("metricDefinitions")]
    public IList<V1alpha1TrainingJobSpecAlgorithmSpecificationMetricDefinitions>? MetricDefinitions { get; set; }

    [JsonPropertyName("trainingImage")]
    public string? TrainingImage { get; set; }

    /// <summary>
    /// The training input mode that the algorithm supports. For more information
    /// about input modes, see Algorithms (https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html).
    /// 
    /// Pipe mode
    /// 
    /// If an algorithm supports Pipe mode, Amazon SageMaker streams data directly
    /// from Amazon S3 to the container.
    /// 
    /// File mode
    /// 
    /// If an algorithm supports File mode, SageMaker downloads the training data
    /// from S3 to the provisioned ML storage volume, and mounts the directory to
    /// the Docker volume for the training container.
    /// 
    /// You must provision the ML storage volume with sufficient capacity to accommodate
    /// the data downloaded from S3. In addition to the training data, the ML storage
    /// volume also stores the output model. The algorithm container uses the ML
    /// storage volume to also store intermediate information, if any.
    /// 
    /// For distributed algorithms, training data is distributed uniformly. Your
    /// training duration is predictable if the input data objects sizes are approximately
    /// the same. SageMaker does not split the files any further for model training.
    /// If the object sizes are skewed, training won&apos;t be optimal as the data distribution
    /// is also skewed when one host in a training cluster is overloaded, thus becoming
    /// a bottleneck in training.
    /// 
    /// FastFile mode
    /// 
    /// If an algorithm supports FastFile mode, SageMaker streams data directly from
    /// S3 to the container with no code changes, and provides file system access
    /// to the data. Users can author their training script to interact with these
    /// files as if they were stored on disk.
    /// 
    /// FastFile mode works best when the data is read sequentially. Augmented manifest
    /// files aren&apos;t supported. The startup time is lower when there are fewer files
    /// in the S3 bucket provided.
    /// </summary>
    [JsonPropertyName("trainingInputMode")]
    public string? TrainingInputMode { get; set; }
}

/// <summary>
/// Contains information about the output location for managed spot training
/// checkpoint data.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecCheckpointConfig
{
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>
/// Configuration information for the Amazon SageMaker Debugger output tensor
/// collections.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecDebugHookConfigCollectionConfigurations
{
    [JsonPropertyName("collectionName")]
    public string? CollectionName { get; set; }

    [JsonPropertyName("collectionParameters")]
    public IDictionary<string, string>? CollectionParameters { get; set; }
}

/// <summary>
/// Configuration information for the Amazon SageMaker Debugger hook parameters,
/// metric and tensor collections, and storage paths. To learn more about how
/// to configure the DebugHookConfig parameter, see Use the SageMaker and Debugger
/// Configuration API Operations to Create, Update, and Debug Your Training Job
/// (https://docs.aws.amazon.com/sagemaker/latest/dg/debugger-createtrainingjob-api.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecDebugHookConfig
{
    [JsonPropertyName("collectionConfigurations")]
    public IList<V1alpha1TrainingJobSpecDebugHookConfigCollectionConfigurations>? CollectionConfigurations { get; set; }

    [JsonPropertyName("hookParameters")]
    public IDictionary<string, string>? HookParameters { get; set; }

    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>
/// Configuration information for SageMaker Debugger rules for debugging. To
/// learn more about how to configure the DebugRuleConfiguration parameter, see
/// Use the SageMaker and Debugger Configuration API Operations to Create, Update,
/// and Debug Your Training Job (https://docs.aws.amazon.com/sagemaker/latest/dg/debugger-createtrainingjob-api.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecDebugRuleConfigurations
{
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    [JsonPropertyName("ruleConfigurationName")]
    public string? RuleConfigurationName { get; set; }

    [JsonPropertyName("ruleEvaluatorImage")]
    public string? RuleEvaluatorImage { get; set; }

    [JsonPropertyName("ruleParameters")]
    public IDictionary<string, string>? RuleParameters { get; set; }

    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }

    [JsonPropertyName("volumeSizeInGB")]
    public long? VolumeSizeInGB { get; set; }
}

/// <summary>
/// Associates a SageMaker job as a trial component with an experiment and trial.
/// Specified when you call the following APIs:
/// 
///   - CreateProcessingJob (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateProcessingJob.html)
/// 
///   - CreateTrainingJob (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingJob.html)
/// 
///   - CreateTransformJob (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTransformJob.html)
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecExperimentConfig
{
    [JsonPropertyName("experimentName")]
    public string? ExperimentName { get; set; }

    [JsonPropertyName("trialComponentDisplayName")]
    public string? TrialComponentDisplayName { get; set; }

    [JsonPropertyName("trialName")]
    public string? TrialName { get; set; }
}

/// <summary>
/// Contains information about the infrastructure health check configuration
/// for the training job.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecInfraCheckConfig
{
    [JsonPropertyName("enableInfraCheck")]
    public bool? EnableInfraCheck { get; set; }
}

/// <summary>Specifies a file system data source for a channel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecInputDataConfigDataSourceFileSystemDataSource
{
    [JsonPropertyName("directoryPath")]
    public string? DirectoryPath { get; set; }

    [JsonPropertyName("fileSystemAccessMode")]
    public string? FileSystemAccessMode { get; set; }

    [JsonPropertyName("fileSystemID")]
    public string? FileSystemID { get; set; }

    [JsonPropertyName("fileSystemType")]
    public string? FileSystemType { get; set; }
}

/// <summary>
/// The configuration for a private hub model reference that points to a public
/// SageMaker JumpStart model.
/// 
/// For more information about private hubs, see Private curated hubs for foundation
/// model access control in JumpStart (https://docs.aws.amazon.com/sagemaker/latest/dg/jumpstart-curated-hubs.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecInputDataConfigDataSourceS3DataSourceHubAccessConfig
{
    [JsonPropertyName("hubContentARN")]
    public string? HubContentARN { get; set; }
}

/// <summary>
/// The access configuration file to control access to the ML model. You can
/// explicitly accept the model end-user license agreement (EULA) within the
/// ModelAccessConfig.
/// 
///    * If you are a Jumpstart user, see the End-user license agreements (https://docs.aws.amazon.com/sagemaker/latest/dg/jumpstart-foundation-models-choose.html#jumpstart-foundation-models-choose-eula)
///    section for more details on accepting the EULA.
/// 
///    * If you are an AutoML user, see the Optional Parameters section of Create
///    an AutoML job to fine-tune text generation models using the API for details
///    on How to set the EULA acceptance when fine-tuning a model using the AutoML
///    API (https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-create-experiment-finetune-llms.html#autopilot-llms-finetuning-api-optional-params).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecInputDataConfigDataSourceS3DataSourceModelAccessConfig
{
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

/// <summary>
/// Describes the S3 data source.
/// 
/// Your input bucket must be in the same Amazon Web Services region as your
/// training job.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecInputDataConfigDataSourceS3DataSource
{
    [JsonPropertyName("attributeNames")]
    public IList<string>? AttributeNames { get; set; }

    /// <summary>
    /// The configuration for a private hub model reference that points to a public
    /// SageMaker JumpStart model.
    /// 
    /// For more information about private hubs, see Private curated hubs for foundation
    /// model access control in JumpStart (https://docs.aws.amazon.com/sagemaker/latest/dg/jumpstart-curated-hubs.html).
    /// </summary>
    [JsonPropertyName("hubAccessConfig")]
    public V1alpha1TrainingJobSpecInputDataConfigDataSourceS3DataSourceHubAccessConfig? HubAccessConfig { get; set; }

    [JsonPropertyName("instanceGroupNames")]
    public IList<string>? InstanceGroupNames { get; set; }

    /// <summary>
    /// The access configuration file to control access to the ML model. You can
    /// explicitly accept the model end-user license agreement (EULA) within the
    /// ModelAccessConfig.
    /// 
    ///    * If you are a Jumpstart user, see the End-user license agreements (https://docs.aws.amazon.com/sagemaker/latest/dg/jumpstart-foundation-models-choose.html#jumpstart-foundation-models-choose-eula)
    ///    section for more details on accepting the EULA.
    /// 
    ///    * If you are an AutoML user, see the Optional Parameters section of Create
    ///    an AutoML job to fine-tune text generation models using the API for details
    ///    on How to set the EULA acceptance when fine-tuning a model using the AutoML
    ///    API (https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-create-experiment-finetune-llms.html#autopilot-llms-finetuning-api-optional-params).
    /// </summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1alpha1TrainingJobSpecInputDataConfigDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    [JsonPropertyName("s3DataDistributionType")]
    public string? S3DataDistributionType { get; set; }

    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Describes the location of the channel data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecInputDataConfigDataSource
{
    /// <summary>Specifies a file system data source for a channel.</summary>
    [JsonPropertyName("fileSystemDataSource")]
    public V1alpha1TrainingJobSpecInputDataConfigDataSourceFileSystemDataSource? FileSystemDataSource { get; set; }

    /// <summary>
    /// Describes the S3 data source.
    /// 
    /// Your input bucket must be in the same Amazon Web Services region as your
    /// training job.
    /// </summary>
    [JsonPropertyName("s3DataSource")]
    public V1alpha1TrainingJobSpecInputDataConfigDataSourceS3DataSource? S3DataSource { get; set; }
}

/// <summary>
/// A configuration for a shuffle option for input data in a channel. If you
/// use S3Prefix for S3DataType, the results of the S3 key prefix matches are
/// shuffled. If you use ManifestFile, the order of the S3 object references
/// in the ManifestFile is shuffled. If you use AugmentedManifestFile, the order
/// of the JSON lines in the AugmentedManifestFile is shuffled. The shuffling
/// order is determined using the Seed value.
/// 
/// For Pipe input mode, when ShuffleConfig is specified shuffling is done at
/// the start of every epoch. With large datasets, this ensures that the order
/// of the training data is different for each epoch, and it helps reduce bias
/// and possible overfitting. In a multi-node training job when ShuffleConfig
/// is combined with S3DataDistributionType of ShardedByS3Key, the data is shuffled
/// across nodes so that the content sent to a particular node on the first epoch
/// might be sent to a different node on the second epoch.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecInputDataConfigShuffleConfig
{
    [JsonPropertyName("seed")]
    public long? Seed { get; set; }
}

/// <summary>A channel is a named input source that training algorithms can consume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecInputDataConfig
{
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Describes the location of the channel data.</summary>
    [JsonPropertyName("dataSource")]
    public V1alpha1TrainingJobSpecInputDataConfigDataSource? DataSource { get; set; }

    /// <summary>
    /// The training input mode that the algorithm supports. For more information
    /// about input modes, see Algorithms (https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html).
    /// 
    /// Pipe mode
    /// 
    /// If an algorithm supports Pipe mode, Amazon SageMaker streams data directly
    /// from Amazon S3 to the container.
    /// 
    /// File mode
    /// 
    /// If an algorithm supports File mode, SageMaker downloads the training data
    /// from S3 to the provisioned ML storage volume, and mounts the directory to
    /// the Docker volume for the training container.
    /// 
    /// You must provision the ML storage volume with sufficient capacity to accommodate
    /// the data downloaded from S3. In addition to the training data, the ML storage
    /// volume also stores the output model. The algorithm container uses the ML
    /// storage volume to also store intermediate information, if any.
    /// 
    /// For distributed algorithms, training data is distributed uniformly. Your
    /// training duration is predictable if the input data objects sizes are approximately
    /// the same. SageMaker does not split the files any further for model training.
    /// If the object sizes are skewed, training won&apos;t be optimal as the data distribution
    /// is also skewed when one host in a training cluster is overloaded, thus becoming
    /// a bottleneck in training.
    /// 
    /// FastFile mode
    /// 
    /// If an algorithm supports FastFile mode, SageMaker streams data directly from
    /// S3 to the container with no code changes, and provides file system access
    /// to the data. Users can author their training script to interact with these
    /// files as if they were stored on disk.
    /// 
    /// FastFile mode works best when the data is read sequentially. Augmented manifest
    /// files aren&apos;t supported. The startup time is lower when there are fewer files
    /// in the S3 bucket provided.
    /// </summary>
    [JsonPropertyName("inputMode")]
    public string? InputMode { get; set; }

    [JsonPropertyName("recordWrapperType")]
    public string? RecordWrapperType { get; set; }

    /// <summary>
    /// A configuration for a shuffle option for input data in a channel. If you
    /// use S3Prefix for S3DataType, the results of the S3 key prefix matches are
    /// shuffled. If you use ManifestFile, the order of the S3 object references
    /// in the ManifestFile is shuffled. If you use AugmentedManifestFile, the order
    /// of the JSON lines in the AugmentedManifestFile is shuffled. The shuffling
    /// order is determined using the Seed value.
    /// 
    /// For Pipe input mode, when ShuffleConfig is specified shuffling is done at
    /// the start of every epoch. With large datasets, this ensures that the order
    /// of the training data is different for each epoch, and it helps reduce bias
    /// and possible overfitting. In a multi-node training job when ShuffleConfig
    /// is combined with S3DataDistributionType of ShardedByS3Key, the data is shuffled
    /// across nodes so that the content sent to a particular node on the first epoch
    /// might be sent to a different node on the second epoch.
    /// </summary>
    [JsonPropertyName("shuffleConfig")]
    public V1alpha1TrainingJobSpecInputDataConfigShuffleConfig? ShuffleConfig { get; set; }
}

/// <summary>
/// Specifies the path to the S3 location where you want to store model artifacts.
/// SageMaker creates subfolders for the artifacts.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecOutputDataConfig
{
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>
/// Configuration information for Amazon SageMaker Debugger system monitoring,
/// framework profiling, and storage paths.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecProfilerConfig
{
    [JsonPropertyName("profilingIntervalInMilliseconds")]
    public long? ProfilingIntervalInMilliseconds { get; set; }

    [JsonPropertyName("profilingParameters")]
    public IDictionary<string, string>? ProfilingParameters { get; set; }

    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>Configuration information for profiling rules.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecProfilerRuleConfigurations
{
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    [JsonPropertyName("ruleConfigurationName")]
    public string? RuleConfigurationName { get; set; }

    [JsonPropertyName("ruleEvaluatorImage")]
    public string? RuleEvaluatorImage { get; set; }

    [JsonPropertyName("ruleParameters")]
    public IDictionary<string, string>? RuleParameters { get; set; }

    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }

    [JsonPropertyName("volumeSizeInGB")]
    public long? VolumeSizeInGB { get; set; }
}

/// <summary>
/// Configuration for remote debugging. To learn more about the remote debugging
/// functionality of SageMaker, see Access a training container through Amazon
/// Web Services Systems Manager (SSM) for remote debugging (https://docs.aws.amazon.com/sagemaker/latest/dg/train-remote-debugging.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecRemoteDebugConfig
{
    [JsonPropertyName("enableRemoteDebug")]
    public bool? EnableRemoteDebug { get; set; }
}

/// <summary>
/// Defines an instance group for heterogeneous cluster training. When requesting
/// a training job using the CreateTrainingJob (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingJob.html)
/// API, you can configure multiple instance groups .
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecResourceConfigInstanceGroups
{
    [JsonPropertyName("instanceCount")]
    public long? InstanceCount { get; set; }

    [JsonPropertyName("instanceGroupName")]
    public string? InstanceGroupName { get; set; }

    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }
}

/// <summary>Specifies how instances should be placed on a specific UltraServer.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecResourceConfigInstancePlacementConfigPlacementSpecifications
{
    [JsonPropertyName("instanceCount")]
    public long? InstanceCount { get; set; }

    [JsonPropertyName("ultraServerID")]
    public string? UltraServerID { get; set; }
}

/// <summary>
/// Configuration for how instances are placed and allocated within UltraServers.
/// This is only applicable for UltraServer capacity.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecResourceConfigInstancePlacementConfig
{
    [JsonPropertyName("enableMultipleJobs")]
    public bool? EnableMultipleJobs { get; set; }

    [JsonPropertyName("placementSpecifications")]
    public IList<V1alpha1TrainingJobSpecResourceConfigInstancePlacementConfigPlacementSpecifications>? PlacementSpecifications { get; set; }
}

/// <summary>
/// The resources, including the ML compute instances and ML storage volumes,
/// to use for model training.
/// 
/// ML storage volumes store model artifacts and incremental states. Training
/// algorithms might also use ML storage volumes for scratch space. If you want
/// SageMaker to use the ML storage volume to store the training data, choose
/// File as the TrainingInputMode in the algorithm specification. For distributed
/// training algorithms, specify an instance count greater than 1.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecResourceConfig
{
    [JsonPropertyName("instanceCount")]
    public long? InstanceCount { get; set; }

    [JsonPropertyName("instanceGroups")]
    public IList<V1alpha1TrainingJobSpecResourceConfigInstanceGroups>? InstanceGroups { get; set; }

    /// <summary>
    /// Configuration for how instances are placed and allocated within UltraServers.
    /// This is only applicable for UltraServer capacity.
    /// </summary>
    [JsonPropertyName("instancePlacementConfig")]
    public V1alpha1TrainingJobSpecResourceConfigInstancePlacementConfig? InstancePlacementConfig { get; set; }

    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>
    /// Optional. Customer requested period in seconds for which the Training cluster
    /// is kept alive after the job is finished.
    /// </summary>
    [JsonPropertyName("keepAlivePeriodInSeconds")]
    public long? KeepAlivePeriodInSeconds { get; set; }

    [JsonPropertyName("volumeKMSKeyID")]
    public string? VolumeKMSKeyID { get; set; }

    [JsonPropertyName("volumeSizeInGB")]
    public long? VolumeSizeInGB { get; set; }
}

/// <summary>The number of times to retry the job when the job fails due to an InternalServerError.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecRetryStrategy
{
    [JsonPropertyName("maximumRetryAttempts")]
    public long? MaximumRetryAttempts { get; set; }
}

/// <summary>
/// Specifies a limit to how long a model training job can run. It also specifies
/// how long a managed Spot training job has to complete. When the job reaches
/// the time limit, SageMaker ends the training job. Use this API to cap model
/// training costs.
/// 
/// To stop a job, SageMaker sends the algorithm the SIGTERM signal, which delays
/// job termination for 120 seconds. Algorithms can use this 120-second window
/// to save the model artifacts, so the results of training are not lost.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecStoppingCondition
{
    /// <summary>Maximum job scheduler pending time in seconds.</summary>
    [JsonPropertyName("maxPendingTimeInSeconds")]
    public long? MaxPendingTimeInSeconds { get; set; }

    [JsonPropertyName("maxRuntimeInSeconds")]
    public long? MaxRuntimeInSeconds { get; set; }

    [JsonPropertyName("maxWaitTimeInSeconds")]
    public long? MaxWaitTimeInSeconds { get; set; }
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
public partial class V1alpha1TrainingJobSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Configuration of storage locations for the Amazon SageMaker Debugger TensorBoard
/// output data.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecTensorBoardOutputConfig
{
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>
/// A VpcConfig (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_VpcConfig.html)
/// object that specifies the VPC that you want your training job to connect
/// to. Control access to and from your training container by configuring the
/// VPC. For more information, see Protect Training Jobs by Using an Amazon Virtual
/// Private Cloud (https://docs.aws.amazon.com/sagemaker/latest/dg/train-vpc.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpecVpcConfig
{
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>
/// TrainingJobSpec defines the desired state of TrainingJob.
/// 
/// Contains information about a training job.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobSpec
{
    /// <summary>
    /// The registry path of the Docker image that contains the training algorithm
    /// and algorithm-specific metadata, including the input mode. For more information
    /// about algorithms provided by SageMaker, see Algorithms (https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html).
    /// For information about providing your own algorithms, see Using Your Own Algorithms
    /// with Amazon SageMaker (https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms.html).
    /// </summary>
    [JsonPropertyName("algorithmSpecification")]
    public required V1alpha1TrainingJobSpecAlgorithmSpecification AlgorithmSpecification { get; set; }

    /// <summary>
    /// Contains information about the output location for managed spot training
    /// checkpoint data.
    /// </summary>
    [JsonPropertyName("checkpointConfig")]
    public V1alpha1TrainingJobSpecCheckpointConfig? CheckpointConfig { get; set; }

    /// <summary>
    /// Configuration information for the Amazon SageMaker Debugger hook parameters,
    /// metric and tensor collections, and storage paths. To learn more about how
    /// to configure the DebugHookConfig parameter, see Use the SageMaker and Debugger
    /// Configuration API Operations to Create, Update, and Debug Your Training Job
    /// (https://docs.aws.amazon.com/sagemaker/latest/dg/debugger-createtrainingjob-api.html).
    /// </summary>
    [JsonPropertyName("debugHookConfig")]
    public V1alpha1TrainingJobSpecDebugHookConfig? DebugHookConfig { get; set; }

    /// <summary>
    /// Configuration information for Amazon SageMaker Debugger rules for debugging
    /// output tensors.
    /// </summary>
    [JsonPropertyName("debugRuleConfigurations")]
    public IList<V1alpha1TrainingJobSpecDebugRuleConfigurations>? DebugRuleConfigurations { get; set; }

    /// <summary>
    /// To encrypt all communications between ML compute instances in distributed
    /// training, choose True. Encryption provides greater security for distributed
    /// training, but training might take longer. How long it takes depends on the
    /// amount of communication between compute instances, especially if you use
    /// a deep learning algorithm in distributed training. For more information,
    /// see Protect Communications Between ML Compute Instances in a Distributed
    /// Training Job (https://docs.aws.amazon.com/sagemaker/latest/dg/train-encrypt.html).
    /// </summary>
    [JsonPropertyName("enableInterContainerTrafficEncryption")]
    public bool? EnableInterContainerTrafficEncryption { get; set; }

    /// <summary>
    /// To train models using managed spot training, choose True. Managed spot training
    /// provides a fully managed and scalable infrastructure for training machine
    /// learning models. this option is useful when training jobs can be interrupted
    /// and when there is flexibility when the training job is run.
    /// 
    /// The complete and intermediate results of jobs are stored in an Amazon S3
    /// bucket, and can be used as a starting point to train models incrementally.
    /// Amazon SageMaker provides metrics and logs in CloudWatch. They can be used
    /// to see when managed spot training jobs are running, interrupted, resumed,
    /// or completed.
    /// </summary>
    [JsonPropertyName("enableManagedSpotTraining")]
    public bool? EnableManagedSpotTraining { get; set; }

    /// <summary>
    /// Isolates the training container. No inbound or outbound network calls can
    /// be made, except for calls between peers within a training cluster for distributed
    /// training. If you enable network isolation for training jobs that are configured
    /// to use a VPC, SageMaker downloads and uploads customer data and model artifacts
    /// through the specified VPC, but the training container does not have network
    /// access.
    /// </summary>
    [JsonPropertyName("enableNetworkIsolation")]
    public bool? EnableNetworkIsolation { get; set; }

    /// <summary>
    /// The environment variables to set in the Docker container.
    /// 
    /// Do not include any security-sensitive information including account access
    /// IDs, secrets, or tokens in any environment fields. As part of the shared
    /// responsibility model, you are responsible for any potential exposure, unauthorized
    /// access, or compromise of your sensitive data if caused by security-sensitive
    /// information included in the request environment variable or plain text fields.
    /// </summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>
    /// Associates a SageMaker job as a trial component with an experiment and trial.
    /// Specified when you call the following APIs:
    /// 
    ///   - CreateProcessingJob (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateProcessingJob.html)
    /// 
    ///   - CreateTrainingJob (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingJob.html)
    /// 
    ///   - CreateTransformJob (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTransformJob.html)
    /// </summary>
    [JsonPropertyName("experimentConfig")]
    public V1alpha1TrainingJobSpecExperimentConfig? ExperimentConfig { get; set; }

    /// <summary>
    /// Algorithm-specific parameters that influence the quality of the model. You
    /// set hyperparameters before you start the learning process. For a list of
    /// hyperparameters for each training algorithm provided by SageMaker, see Algorithms
    /// (https://docs.aws.amazon.com/sagemaker/latest/dg/algos.html).
    /// 
    /// You can specify a maximum of 100 hyperparameters. Each hyperparameter is
    /// a key-value pair. Each key and value is limited to 256 characters, as specified
    /// by the Length Constraint.
    /// 
    /// Do not include any security-sensitive information including account access
    /// IDs, secrets, or tokens in any hyperparameter fields. As part of the shared
    /// responsibility model, you are responsible for any potential exposure, unauthorized
    /// access, or compromise of your sensitive data if caused by any security-sensitive
    /// information included in the request hyperparameter variable or plain text
    /// fields.
    /// </summary>
    [JsonPropertyName("hyperParameters")]
    public IDictionary<string, string>? HyperParameters { get; set; }

    /// <summary>
    /// Contains information about the infrastructure health check configuration
    /// for the training job.
    /// </summary>
    [JsonPropertyName("infraCheckConfig")]
    public V1alpha1TrainingJobSpecInfraCheckConfig? InfraCheckConfig { get; set; }

    /// <summary>
    /// An array of Channel objects. Each channel is a named input source. InputDataConfig
    /// describes the input data and its location.
    /// 
    /// Algorithms can accept input data from one or more channels. For example,
    /// an algorithm might have two channels of input data, training_data and validation_data.
    /// The configuration for each channel provides the S3, EFS, or FSx location
    /// where the input data is stored. It also provides information about the stored
    /// data: the MIME type, compression method, and whether the data is wrapped
    /// in RecordIO format.
    /// 
    /// Depending on the input mode that the algorithm supports, SageMaker either
    /// copies input data files from an S3 bucket to a local directory in the Docker
    /// container, or makes it available as input streams. For example, if you specify
    /// an EFS location, input data files are available as input streams. They do
    /// not need to be downloaded.
    /// 
    /// Your input must be in the same Amazon Web Services region as your training
    /// job.
    /// </summary>
    [JsonPropertyName("inputDataConfig")]
    public IList<V1alpha1TrainingJobSpecInputDataConfig>? InputDataConfig { get; set; }

    /// <summary>
    /// Specifies the path to the S3 location where you want to store model artifacts.
    /// SageMaker creates subfolders for the artifacts.
    /// </summary>
    [JsonPropertyName("outputDataConfig")]
    public required V1alpha1TrainingJobSpecOutputDataConfig OutputDataConfig { get; set; }

    /// <summary>
    /// Configuration information for Amazon SageMaker Debugger system monitoring,
    /// framework profiling, and storage paths.
    /// </summary>
    [JsonPropertyName("profilerConfig")]
    public V1alpha1TrainingJobSpecProfilerConfig? ProfilerConfig { get; set; }

    /// <summary>
    /// Configuration information for Amazon SageMaker Debugger rules for profiling
    /// system and framework metrics.
    /// </summary>
    [JsonPropertyName("profilerRuleConfigurations")]
    public IList<V1alpha1TrainingJobSpecProfilerRuleConfigurations>? ProfilerRuleConfigurations { get; set; }

    /// <summary>
    /// Configuration for remote debugging. To learn more about the remote debugging
    /// functionality of SageMaker, see Access a training container through Amazon
    /// Web Services Systems Manager (SSM) for remote debugging (https://docs.aws.amazon.com/sagemaker/latest/dg/train-remote-debugging.html).
    /// </summary>
    [JsonPropertyName("remoteDebugConfig")]
    public V1alpha1TrainingJobSpecRemoteDebugConfig? RemoteDebugConfig { get; set; }

    /// <summary>
    /// The resources, including the ML compute instances and ML storage volumes,
    /// to use for model training.
    /// 
    /// ML storage volumes store model artifacts and incremental states. Training
    /// algorithms might also use ML storage volumes for scratch space. If you want
    /// SageMaker to use the ML storage volume to store the training data, choose
    /// File as the TrainingInputMode in the algorithm specification. For distributed
    /// training algorithms, specify an instance count greater than 1.
    /// </summary>
    [JsonPropertyName("resourceConfig")]
    public required V1alpha1TrainingJobSpecResourceConfig ResourceConfig { get; set; }

    /// <summary>The number of times to retry the job when the job fails due to an InternalServerError.</summary>
    [JsonPropertyName("retryStrategy")]
    public V1alpha1TrainingJobSpecRetryStrategy? RetryStrategy { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of an IAM role that SageMaker can assume to
    /// perform tasks on your behalf.
    /// 
    /// During model training, SageMaker needs your permission to read input data
    /// from an S3 bucket, download a Docker image that contains training code, write
    /// model artifacts to an S3 bucket, write logs to Amazon CloudWatch Logs, and
    /// publish metrics to Amazon CloudWatch. You grant permissions for all of these
    /// tasks to an IAM role. For more information, see SageMaker Roles (https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-roles.html).
    /// 
    /// To be able to pass this role to SageMaker, the caller of this API must have
    /// the iam:PassRole permission.
    /// 
    /// Regex Pattern: `^arn:aws[a-z\-]*:iam::\d{12}:role/?[a-zA-Z_0-9+=,.@\-_/]+$`
    /// </summary>
    [JsonPropertyName("roleARN")]
    public required string RoleARN { get; set; }

    /// <summary>
    /// Specifies a limit to how long a model training job can run. It also specifies
    /// how long a managed Spot training job has to complete. When the job reaches
    /// the time limit, SageMaker ends the training job. Use this API to cap model
    /// training costs.
    /// 
    /// To stop a job, SageMaker sends the algorithm the SIGTERM signal, which delays
    /// job termination for 120 seconds. Algorithms can use this 120-second window
    /// to save the model artifacts, so the results of training are not lost.
    /// </summary>
    [JsonPropertyName("stoppingCondition")]
    public required V1alpha1TrainingJobSpecStoppingCondition StoppingCondition { get; set; }

    /// <summary>
    /// An array of key-value pairs. You can use tags to categorize your Amazon Web
    /// Services resources in different ways, for example, by purpose, owner, or
    /// environment. For more information, see Tagging Amazon Web Services Resources
    /// (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html).
    /// 
    /// Do not include any security-sensitive information including account access
    /// IDs, secrets, or tokens in any tags. As part of the shared responsibility
    /// model, you are responsible for any potential exposure, unauthorized access,
    /// or compromise of your sensitive data if caused by any security-sensitive
    /// information included in the request tag variable or plain text fields.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1TrainingJobSpecTags>? Tags { get; set; }

    /// <summary>
    /// Configuration of storage locations for the Amazon SageMaker Debugger TensorBoard
    /// output data.
    /// </summary>
    [JsonPropertyName("tensorBoardOutputConfig")]
    public V1alpha1TrainingJobSpecTensorBoardOutputConfig? TensorBoardOutputConfig { get; set; }

    /// <summary>
    /// The name of the training job. The name must be unique within an Amazon Web
    /// Services Region in an Amazon Web Services account.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$`
    /// </summary>
    [JsonPropertyName("trainingJobName")]
    public required string TrainingJobName { get; set; }

    /// <summary>
    /// A VpcConfig (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_VpcConfig.html)
    /// object that specifies the VPC that you want your training job to connect
    /// to. Control access to and from your training container by configuring the
    /// VPC. For more information, see Protect Training Jobs by Using an Amazon Virtual
    /// Private Cloud (https://docs.aws.amazon.com/sagemaker/latest/dg/train-vpc.html).
    /// </summary>
    [JsonPropertyName("vpcConfig")]
    public V1alpha1TrainingJobSpecVpcConfig? VpcConfig { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobStatusAckResourceMetadata
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
public partial class V1alpha1TrainingJobStatusConditions
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

/// <summary>Information about the status of the rule evaluation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobStatusDebugRuleEvaluationStatuses
{
    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    [JsonPropertyName("ruleConfigurationName")]
    public string? RuleConfigurationName { get; set; }

    [JsonPropertyName("ruleEvaluationJobARN")]
    public string? RuleEvaluationJobARN { get; set; }

    [JsonPropertyName("ruleEvaluationStatus")]
    public string? RuleEvaluationStatus { get; set; }

    [JsonPropertyName("statusDetails")]
    public string? StatusDetails { get; set; }
}

/// <summary>
/// Information about the Amazon S3 location that is configured for storing model
/// artifacts.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobStatusModelArtifacts
{
    [JsonPropertyName("s3ModelArtifacts")]
    public string? S3ModelArtifacts { get; set; }
}

/// <summary>Information about the status of the rule evaluation.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobStatusProfilerRuleEvaluationStatuses
{
    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    [JsonPropertyName("ruleConfigurationName")]
    public string? RuleConfigurationName { get; set; }

    [JsonPropertyName("ruleEvaluationJobARN")]
    public string? RuleEvaluationJobARN { get; set; }

    [JsonPropertyName("ruleEvaluationStatus")]
    public string? RuleEvaluationStatus { get; set; }

    [JsonPropertyName("statusDetails")]
    public string? StatusDetails { get; set; }
}

/// <summary>The status of the warm pool associated with the training job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobStatusWarmPoolStatus
{
    /// <summary>
    /// Optional. Indicates how many seconds the resource stayed in ResourceRetained
    /// state. Populated only after resource reaches ResourceReused or ResourceReleased
    /// state.
    /// </summary>
    [JsonPropertyName("resourceRetainedBillableTimeInSeconds")]
    public long? ResourceRetainedBillableTimeInSeconds { get; set; }

    [JsonPropertyName("reusedByJob")]
    public string? ReusedByJob { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>TrainingJobStatus defines the observed state of TrainingJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TrainingJobStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1TrainingJobStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1TrainingJobStatusConditions>? Conditions { get; set; }

    /// <summary>A timestamp that indicates when the training job was created.</summary>
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>
    /// Evaluation status of Amazon SageMaker Debugger rules for debugging on a training
    /// job.
    /// </summary>
    [JsonPropertyName("debugRuleEvaluationStatuses")]
    public IList<V1alpha1TrainingJobStatusDebugRuleEvaluationStatuses>? DebugRuleEvaluationStatuses { get; set; }

    /// <summary>If the training job failed, the reason it failed.</summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>A timestamp that indicates when the status of the training job was last modified.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    /// <summary>
    /// Information about the Amazon S3 location that is configured for storing model
    /// artifacts.
    /// </summary>
    [JsonPropertyName("modelArtifacts")]
    public V1alpha1TrainingJobStatusModelArtifacts? ModelArtifacts { get; set; }

    /// <summary>
    /// Evaluation status of Amazon SageMaker Debugger rules for profiling on a training
    /// job.
    /// </summary>
    [JsonPropertyName("profilerRuleEvaluationStatuses")]
    public IList<V1alpha1TrainingJobStatusProfilerRuleEvaluationStatuses>? ProfilerRuleEvaluationStatuses { get; set; }

    /// <summary>Profiling status of a training job.</summary>
    [JsonPropertyName("profilingStatus")]
    public string? ProfilingStatus { get; set; }

    /// <summary>
    /// Provides detailed information about the state of the training job. For detailed
    /// information on the secondary status of the training job, see StatusMessage
    /// under SecondaryStatusTransition (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_SecondaryStatusTransition.html).
    /// 
    /// SageMaker provides primary statuses and secondary statuses that apply to
    /// each of them:
    /// 
    /// InProgress
    /// 
    ///    * Starting - Starting the training job.
    /// 
    ///    * Downloading - An optional stage for algorithms that support File training
    ///    input mode. It indicates that data is being downloaded to the ML storage
    ///    volumes.
    /// 
    ///    * Training - Training is in progress.
    /// 
    ///    * Interrupted - The job stopped because the managed spot training instances
    ///    were interrupted.
    /// 
    ///    * Uploading - Training is complete and the model artifacts are being uploaded
    ///    to the S3 location.
    /// 
    /// Completed
    /// 
    ///    * Completed - The training job has completed.
    /// 
    /// Failed
    /// 
    ///    * Failed - The training job has failed. The reason for the failure is
    ///    returned in the FailureReason field of DescribeTrainingJobResponse.
    /// 
    /// Stopped
    /// 
    ///    * MaxRuntimeExceeded - The job stopped because it exceeded the maximum
    ///    allowed runtime.
    /// 
    ///    * MaxWaitTimeExceeded - The job stopped because it exceeded the maximum
    ///    allowed wait time.
    /// 
    ///    * Stopped - The training job has stopped.
    /// 
    /// Stopping
    /// 
    ///    * Stopping - Stopping the training job.
    /// 
    /// Valid values for SecondaryStatus are subject to change.
    /// 
    /// We no longer support the following secondary statuses:
    /// 
    ///    * LaunchingMLInstances
    /// 
    ///    * PreparingTraining
    /// 
    ///    * DownloadingTrainingImage
    /// </summary>
    [JsonPropertyName("secondaryStatus")]
    public string? SecondaryStatus { get; set; }

    /// <summary>
    /// The status of the training job.
    /// 
    /// SageMaker provides the following training job statuses:
    /// 
    ///    * InProgress - The training is in progress.
    /// 
    ///    * Completed - The training job has completed.
    /// 
    ///    * Failed - The training job has failed. To see the reason for the failure,
    ///    see the FailureReason field in the response to a DescribeTrainingJobResponse
    ///    call.
    /// 
    ///    * Stopping - The training job is stopping.
    /// 
    ///    * Stopped - The training job has stopped.
    /// 
    /// For more detailed information, see SecondaryStatus.
    /// </summary>
    [JsonPropertyName("trainingJobStatus")]
    public string? TrainingJobStatus { get; set; }

    /// <summary>The status of the warm pool associated with the training job.</summary>
    [JsonPropertyName("warmPoolStatus")]
    public V1alpha1TrainingJobStatusWarmPoolStatus? WarmPoolStatus { get; set; }
}

/// <summary>TrainingJob is the Schema for the TrainingJobs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TrainingJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TrainingJobSpec?>, IStatus<V1alpha1TrainingJobStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TrainingJob";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "trainingjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TrainingJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// TrainingJobSpec defines the desired state of TrainingJob.
    /// 
    /// Contains information about a training job.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1TrainingJobSpec? Spec { get; set; }

    /// <summary>TrainingJobStatus defines the observed state of TrainingJob</summary>
    [JsonPropertyName("status")]
    public V1alpha1TrainingJobStatus? Status { get; set; }
}