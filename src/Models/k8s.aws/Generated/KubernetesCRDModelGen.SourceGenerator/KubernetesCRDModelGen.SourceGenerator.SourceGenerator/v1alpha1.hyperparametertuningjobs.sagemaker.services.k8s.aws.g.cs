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
/// <summary>HyperParameterTuningJob is the Schema for the HyperParameterTuningJobs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1HyperParameterTuningJobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1HyperParameterTuningJob>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "HyperParameterTuningJobList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "hyperparametertuningjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HyperParameterTuningJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1HyperParameterTuningJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1HyperParameterTuningJob> Items { get; set; }
}

/// <summary>
/// Configures SageMaker Automatic model tuning (AMT) to automatically find optimal
/// parameters for the following fields:
/// 
///   - ParameterRanges (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobConfig.html#sagemaker-Type-HyperParameterTuningJobConfig-ParameterRanges):
///     The names and ranges of parameters that a hyperparameter tuning job can
///     optimize.
/// 
///   - ResourceLimits (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ResourceLimits.html):
///     The maximum resources that can be used for a training job. These resources
///     include the maximum number of training jobs, the maximum runtime of a
///     tuning job, and the maximum number of training jobs to run at the same
///     time.
/// 
///   - TrainingJobEarlyStoppingType (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobConfig.html#sagemaker-Type-HyperParameterTuningJobConfig-TrainingJobEarlyStoppingType):
///     A flag that specifies whether or not to use early stopping for training
///     jobs launched by a hyperparameter tuning job.
/// 
///   - RetryStrategy (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTrainingJobDefinition.html#sagemaker-Type-HyperParameterTrainingJobDefinition-RetryStrategy):
///     The number of times to retry a training job.
/// 
///   - Strategy (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobConfig.html):
///     Specifies how hyperparameter tuning chooses the combinations of hyperparameter
///     values to use for the training jobs that it launches.
/// 
///   - ConvergenceDetected (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ConvergenceDetected.html):
///     A flag to indicate that Automatic model tuning (AMT) has detected model
///     convergence.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecAutotune
{
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Defines the objective metric for a hyperparameter tuning job. Hyperparameter
/// tuning uses the value of this metric to evaluate the training jobs it launches,
/// and returns the training job that results in either the highest or lowest
/// value for this metric, depending on the value you specify for the Type parameter.
/// If you want to define a custom objective metric, see Define metrics and environment
/// variables (https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-define-metrics-variables.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfigHyperParameterTuningJobObjective
{
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>
/// The name and an example value of the hyperparameter that you want to use
/// in Autotune. If Automatic model tuning (AMT) determines that your hyperparameter
/// is eligible for Autotune, an optimal hyperparameter range is selected for
/// you.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfigParameterRangesAutoParameters
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("valueHint")]
    public string? ValueHint { get; set; }
}

/// <summary>A list of categorical hyperparameters to tune.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfigParameterRangesCategoricalParameterRanges
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A list of continuous hyperparameters to tune.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfigParameterRangesContinuousParameterRanges
{
    [JsonPropertyName("maxValue")]
    public string? MaxValue { get; set; }

    [JsonPropertyName("minValue")]
    public string? MinValue { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("scalingType")]
    public string? ScalingType { get; set; }
}

/// <summary>
/// For a hyperparameter of the integer type, specifies the range that a hyperparameter
/// tuning job searches.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfigParameterRangesIntegerParameterRanges
{
    [JsonPropertyName("maxValue")]
    public string? MaxValue { get; set; }

    [JsonPropertyName("minValue")]
    public string? MinValue { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("scalingType")]
    public string? ScalingType { get; set; }
}

/// <summary>
/// Specifies ranges of integer, continuous, and categorical hyperparameters
/// that a hyperparameter tuning job searches. The hyperparameter tuning job
/// launches training jobs with hyperparameter values within these ranges to
/// find the combination of values that result in the training job with the best
/// performance as measured by the objective metric of the hyperparameter tuning
/// job.
/// 
/// The maximum number of items specified for Array Members refers to the maximum
/// number of hyperparameters for each range and also the maximum for the hyperparameter
/// tuning job itself. That is, the sum of the number of hyperparameters for
/// all the ranges can&apos;t exceed the maximum number specified.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfigParameterRanges
{
    [JsonPropertyName("autoParameters")]
    public IList<V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfigParameterRangesAutoParameters>? AutoParameters { get; set; }

    [JsonPropertyName("categoricalParameterRanges")]
    public IList<V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfigParameterRangesCategoricalParameterRanges>? CategoricalParameterRanges { get; set; }

    [JsonPropertyName("continuousParameterRanges")]
    public IList<V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfigParameterRangesContinuousParameterRanges>? ContinuousParameterRanges { get; set; }

    [JsonPropertyName("integerParameterRanges")]
    public IList<V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfigParameterRangesIntegerParameterRanges>? IntegerParameterRanges { get; set; }
}

/// <summary>
/// Specifies the maximum number of training jobs and parallel training jobs
/// that a hyperparameter tuning job can launch.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfigResourceLimits
{
    [JsonPropertyName("maxNumberOfTrainingJobs")]
    public long? MaxNumberOfTrainingJobs { get; set; }

    [JsonPropertyName("maxParallelTrainingJobs")]
    public long? MaxParallelTrainingJobs { get; set; }
}

/// <summary>The job completion criteria.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfigTuningJobCompletionCriteria
{
    [JsonPropertyName("targetObjectiveMetricValue")]
    public double? TargetObjectiveMetricValue { get; set; }
}

/// <summary>
/// The HyperParameterTuningJobConfig (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobConfig.html)
/// object that describes the tuning job, including the search strategy, the
/// objective metric used to evaluate training jobs, ranges of parameters to
/// search, and resource limits for the tuning job. For more information, see
/// How Hyperparameter Tuning Works (https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-how-it-works.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfig
{
    /// <summary>
    /// Defines the objective metric for a hyperparameter tuning job. Hyperparameter
    /// tuning uses the value of this metric to evaluate the training jobs it launches,
    /// and returns the training job that results in either the highest or lowest
    /// value for this metric, depending on the value you specify for the Type parameter.
    /// If you want to define a custom objective metric, see Define metrics and environment
    /// variables (https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-define-metrics-variables.html).
    /// </summary>
    [JsonPropertyName("hyperParameterTuningJobObjective")]
    public V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfigHyperParameterTuningJobObjective? HyperParameterTuningJobObjective { get; set; }

    /// <summary>
    /// Specifies ranges of integer, continuous, and categorical hyperparameters
    /// that a hyperparameter tuning job searches. The hyperparameter tuning job
    /// launches training jobs with hyperparameter values within these ranges to
    /// find the combination of values that result in the training job with the best
    /// performance as measured by the objective metric of the hyperparameter tuning
    /// job.
    /// 
    /// The maximum number of items specified for Array Members refers to the maximum
    /// number of hyperparameters for each range and also the maximum for the hyperparameter
    /// tuning job itself. That is, the sum of the number of hyperparameters for
    /// all the ranges can&apos;t exceed the maximum number specified.
    /// </summary>
    [JsonPropertyName("parameterRanges")]
    public V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfigParameterRanges? ParameterRanges { get; set; }

    /// <summary>
    /// Specifies the maximum number of training jobs and parallel training jobs
    /// that a hyperparameter tuning job can launch.
    /// </summary>
    [JsonPropertyName("resourceLimits")]
    public V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfigResourceLimits? ResourceLimits { get; set; }

    /// <summary>
    /// The strategy hyperparameter tuning uses to find the best combination of hyperparameters
    /// for your model.
    /// </summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }

    [JsonPropertyName("trainingJobEarlyStoppingType")]
    public string? TrainingJobEarlyStoppingType { get; set; }

    /// <summary>The job completion criteria.</summary>
    [JsonPropertyName("tuningJobCompletionCriteria")]
    public V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfigTuningJobCompletionCriteria? TuningJobCompletionCriteria { get; set; }
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
public partial class V1alpha1HyperParameterTuningJobSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionAlgorithmSpecificationMetricDefinitions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>
/// Specifies which training algorithm to use for training jobs that a hyperparameter
/// tuning job launches and the metrics to monitor.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionAlgorithmSpecification
{
    [JsonPropertyName("algorithmName")]
    public string? AlgorithmName { get; set; }

    [JsonPropertyName("metricDefinitions")]
    public IList<V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionAlgorithmSpecificationMetricDefinitions>? MetricDefinitions { get; set; }

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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionCheckpointConfig
{
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>
/// The name and an example value of the hyperparameter that you want to use
/// in Autotune. If Automatic model tuning (AMT) determines that your hyperparameter
/// is eligible for Autotune, an optimal hyperparameter range is selected for
/// you.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionHyperParameterRangesAutoParameters
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("valueHint")]
    public string? ValueHint { get; set; }
}

/// <summary>A list of categorical hyperparameters to tune.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionHyperParameterRangesCategoricalParameterRanges
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A list of continuous hyperparameters to tune.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionHyperParameterRangesContinuousParameterRanges
{
    [JsonPropertyName("maxValue")]
    public string? MaxValue { get; set; }

    [JsonPropertyName("minValue")]
    public string? MinValue { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("scalingType")]
    public string? ScalingType { get; set; }
}

/// <summary>
/// For a hyperparameter of the integer type, specifies the range that a hyperparameter
/// tuning job searches.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionHyperParameterRangesIntegerParameterRanges
{
    [JsonPropertyName("maxValue")]
    public string? MaxValue { get; set; }

    [JsonPropertyName("minValue")]
    public string? MinValue { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("scalingType")]
    public string? ScalingType { get; set; }
}

/// <summary>
/// Specifies ranges of integer, continuous, and categorical hyperparameters
/// that a hyperparameter tuning job searches. The hyperparameter tuning job
/// launches training jobs with hyperparameter values within these ranges to
/// find the combination of values that result in the training job with the best
/// performance as measured by the objective metric of the hyperparameter tuning
/// job.
/// 
/// The maximum number of items specified for Array Members refers to the maximum
/// number of hyperparameters for each range and also the maximum for the hyperparameter
/// tuning job itself. That is, the sum of the number of hyperparameters for
/// all the ranges can&apos;t exceed the maximum number specified.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionHyperParameterRanges
{
    [JsonPropertyName("autoParameters")]
    public IList<V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionHyperParameterRangesAutoParameters>? AutoParameters { get; set; }

    [JsonPropertyName("categoricalParameterRanges")]
    public IList<V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionHyperParameterRangesCategoricalParameterRanges>? CategoricalParameterRanges { get; set; }

    [JsonPropertyName("continuousParameterRanges")]
    public IList<V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionHyperParameterRangesContinuousParameterRanges>? ContinuousParameterRanges { get; set; }

    [JsonPropertyName("integerParameterRanges")]
    public IList<V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionHyperParameterRangesIntegerParameterRanges>? IntegerParameterRanges { get; set; }
}

/// <summary>Specifies a file system data source for a channel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionInputDataConfigDataSourceFileSystemDataSource
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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceHubAccessConfig
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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceModelAccessConfig
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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionInputDataConfigDataSourceS3DataSource
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
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceHubAccessConfig? HubAccessConfig { get; set; }

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
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionInputDataConfigDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionInputDataConfigDataSource
{
    /// <summary>Specifies a file system data source for a channel.</summary>
    [JsonPropertyName("fileSystemDataSource")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionInputDataConfigDataSourceFileSystemDataSource? FileSystemDataSource { get; set; }

    /// <summary>
    /// Describes the S3 data source.
    /// 
    /// Your input bucket must be in the same Amazon Web Services region as your
    /// training job.
    /// </summary>
    [JsonPropertyName("s3DataSource")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionInputDataConfigDataSourceS3DataSource? S3DataSource { get; set; }
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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionInputDataConfigShuffleConfig
{
    [JsonPropertyName("seed")]
    public long? Seed { get; set; }
}

/// <summary>A channel is a named input source that training algorithms can consume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionInputDataConfig
{
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Describes the location of the channel data.</summary>
    [JsonPropertyName("dataSource")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionInputDataConfigDataSource? DataSource { get; set; }

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
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionInputDataConfigShuffleConfig? ShuffleConfig { get; set; }
}

/// <summary>Provides information about how to store model training results (model artifacts).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionOutputDataConfig
{
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>
/// Defines an instance group for heterogeneous cluster training. When requesting
/// a training job using the CreateTrainingJob (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingJob.html)
/// API, you can configure multiple instance groups .
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionResourceConfigInstanceGroups
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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionResourceConfigInstancePlacementConfigPlacementSpecifications
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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionResourceConfigInstancePlacementConfig
{
    [JsonPropertyName("enableMultipleJobs")]
    public bool? EnableMultipleJobs { get; set; }

    [JsonPropertyName("placementSpecifications")]
    public IList<V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionResourceConfigInstancePlacementConfigPlacementSpecifications>? PlacementSpecifications { get; set; }
}

/// <summary>
/// Describes the resources, including machine learning (ML) compute instances
/// and ML storage volumes, to use for model training.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionResourceConfig
{
    [JsonPropertyName("instanceCount")]
    public long? InstanceCount { get; set; }

    [JsonPropertyName("instanceGroups")]
    public IList<V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionResourceConfigInstanceGroups>? InstanceGroups { get; set; }

    /// <summary>
    /// Configuration for how instances are placed and allocated within UltraServers.
    /// This is only applicable for UltraServer capacity.
    /// </summary>
    [JsonPropertyName("instancePlacementConfig")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionResourceConfigInstancePlacementConfig? InstancePlacementConfig { get; set; }

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

/// <summary>
/// The retry strategy to use when a training job fails due to an InternalServerError.
/// RetryStrategy is specified as part of the CreateTrainingJob and CreateHyperParameterTuningJob
/// requests. You can add the StoppingCondition parameter to the request to limit
/// the training time for the complete job.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionRetryStrategy
{
    [JsonPropertyName("maximumRetryAttempts")]
    public long? MaximumRetryAttempts { get; set; }
}

/// <summary>
/// Specifies a limit to how long a job can run. When the job reaches the time
/// limit, SageMaker ends the job. Use this API to cap costs.
/// 
/// To stop a training job, SageMaker sends the algorithm the SIGTERM signal,
/// which delays job termination for 120 seconds. Algorithms can use this 120-second
/// window to save the model artifacts, so the results of training are not lost.
/// 
/// The training algorithms provided by SageMaker automatically save the intermediate
/// results of a model training job when possible. This attempt to save artifacts
/// is only a best effort case as model might not be in a state from which it
/// can be saved. For example, if training has just started, the model might
/// not be ready to save. When saved, this intermediate data is a valid model
/// artifact. You can use it to create a model with CreateModel.
/// 
/// The Neural Topic Model (NTM) currently does not support saving intermediate
/// model artifacts. When training NTMs, make sure that the maximum runtime is
/// sufficient for the training job to complete.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionStoppingCondition
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
/// Defines the objective metric for a hyperparameter tuning job. Hyperparameter
/// tuning uses the value of this metric to evaluate the training jobs it launches,
/// and returns the training job that results in either the highest or lowest
/// value for this metric, depending on the value you specify for the Type parameter.
/// If you want to define a custom objective metric, see Define metrics and environment
/// variables (https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-define-metrics-variables.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionTuningObjective
{
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>
/// Specifies an Amazon Virtual Private Cloud (VPC) that your SageMaker jobs,
/// hosted models, and compute resources have access to. You can control access
/// to and from your resources by configuring a VPC. For more information, see
/// Give SageMaker Access to Resources in your Amazon VPC (https://docs.aws.amazon.com/sagemaker/latest/dg/infrastructure-give-access.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionVpcConfig
{
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>
/// The HyperParameterTrainingJobDefinition (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTrainingJobDefinition.html)
/// object that describes the training jobs that this tuning job launches, including
/// static hyperparameters, input data configuration, output data configuration,
/// resource configuration, and stopping condition.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinition
{
    /// <summary>
    /// Specifies which training algorithm to use for training jobs that a hyperparameter
    /// tuning job launches and the metrics to monitor.
    /// </summary>
    [JsonPropertyName("algorithmSpecification")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionAlgorithmSpecification? AlgorithmSpecification { get; set; }

    /// <summary>
    /// Contains information about the output location for managed spot training
    /// checkpoint data.
    /// </summary>
    [JsonPropertyName("checkpointConfig")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionCheckpointConfig? CheckpointConfig { get; set; }

    [JsonPropertyName("definitionName")]
    public string? DefinitionName { get; set; }

    [JsonPropertyName("enableInterContainerTrafficEncryption")]
    public bool? EnableInterContainerTrafficEncryption { get; set; }

    [JsonPropertyName("enableManagedSpotTraining")]
    public bool? EnableManagedSpotTraining { get; set; }

    [JsonPropertyName("enableNetworkIsolation")]
    public bool? EnableNetworkIsolation { get; set; }

    /// <summary>
    /// Specifies ranges of integer, continuous, and categorical hyperparameters
    /// that a hyperparameter tuning job searches. The hyperparameter tuning job
    /// launches training jobs with hyperparameter values within these ranges to
    /// find the combination of values that result in the training job with the best
    /// performance as measured by the objective metric of the hyperparameter tuning
    /// job.
    /// 
    /// The maximum number of items specified for Array Members refers to the maximum
    /// number of hyperparameters for each range and also the maximum for the hyperparameter
    /// tuning job itself. That is, the sum of the number of hyperparameters for
    /// all the ranges can&apos;t exceed the maximum number specified.
    /// </summary>
    [JsonPropertyName("hyperParameterRanges")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionHyperParameterRanges? HyperParameterRanges { get; set; }

    [JsonPropertyName("inputDataConfig")]
    public IList<V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionInputDataConfig>? InputDataConfig { get; set; }

    /// <summary>Provides information about how to store model training results (model artifacts).</summary>
    [JsonPropertyName("outputDataConfig")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionOutputDataConfig? OutputDataConfig { get; set; }

    /// <summary>
    /// Describes the resources, including machine learning (ML) compute instances
    /// and ML storage volumes, to use for model training.
    /// </summary>
    [JsonPropertyName("resourceConfig")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionResourceConfig? ResourceConfig { get; set; }

    /// <summary>
    /// The retry strategy to use when a training job fails due to an InternalServerError.
    /// RetryStrategy is specified as part of the CreateTrainingJob and CreateHyperParameterTuningJob
    /// requests. You can add the StoppingCondition parameter to the request to limit
    /// the training time for the complete job.
    /// </summary>
    [JsonPropertyName("retryStrategy")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionRetryStrategy? RetryStrategy { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("staticHyperParameters")]
    public IDictionary<string, string>? StaticHyperParameters { get; set; }

    /// <summary>
    /// Specifies a limit to how long a job can run. When the job reaches the time
    /// limit, SageMaker ends the job. Use this API to cap costs.
    /// 
    /// To stop a training job, SageMaker sends the algorithm the SIGTERM signal,
    /// which delays job termination for 120 seconds. Algorithms can use this 120-second
    /// window to save the model artifacts, so the results of training are not lost.
    /// 
    /// The training algorithms provided by SageMaker automatically save the intermediate
    /// results of a model training job when possible. This attempt to save artifacts
    /// is only a best effort case as model might not be in a state from which it
    /// can be saved. For example, if training has just started, the model might
    /// not be ready to save. When saved, this intermediate data is a valid model
    /// artifact. You can use it to create a model with CreateModel.
    /// 
    /// The Neural Topic Model (NTM) currently does not support saving intermediate
    /// model artifacts. When training NTMs, make sure that the maximum runtime is
    /// sufficient for the training job to complete.
    /// </summary>
    [JsonPropertyName("stoppingCondition")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionStoppingCondition? StoppingCondition { get; set; }

    /// <summary>
    /// Defines the objective metric for a hyperparameter tuning job. Hyperparameter
    /// tuning uses the value of this metric to evaluate the training jobs it launches,
    /// and returns the training job that results in either the highest or lowest
    /// value for this metric, depending on the value you specify for the Type parameter.
    /// If you want to define a custom objective metric, see Define metrics and environment
    /// variables (https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-define-metrics-variables.html).
    /// </summary>
    [JsonPropertyName("tuningObjective")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionTuningObjective? TuningObjective { get; set; }

    /// <summary>
    /// Specifies an Amazon Virtual Private Cloud (VPC) that your SageMaker jobs,
    /// hosted models, and compute resources have access to. You can control access
    /// to and from your resources by configuring a VPC. For more information, see
    /// Give SageMaker Access to Resources in your Amazon VPC (https://docs.aws.amazon.com/sagemaker/latest/dg/infrastructure-give-access.html).
    /// </summary>
    [JsonPropertyName("vpcConfig")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionVpcConfig? VpcConfig { get; set; }
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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsAlgorithmSpecificationMetricDefinitions
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("regex")]
    public string? Regex { get; set; }
}

/// <summary>
/// Specifies which training algorithm to use for training jobs that a hyperparameter
/// tuning job launches and the metrics to monitor.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsAlgorithmSpecification
{
    [JsonPropertyName("algorithmName")]
    public string? AlgorithmName { get; set; }

    [JsonPropertyName("metricDefinitions")]
    public IList<V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsAlgorithmSpecificationMetricDefinitions>? MetricDefinitions { get; set; }

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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsCheckpointConfig
{
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>
/// The name and an example value of the hyperparameter that you want to use
/// in Autotune. If Automatic model tuning (AMT) determines that your hyperparameter
/// is eligible for Autotune, an optimal hyperparameter range is selected for
/// you.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsHyperParameterRangesAutoParameters
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("valueHint")]
    public string? ValueHint { get; set; }
}

/// <summary>A list of categorical hyperparameters to tune.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsHyperParameterRangesCategoricalParameterRanges
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("values")]
    public IList<string>? Values { get; set; }
}

/// <summary>A list of continuous hyperparameters to tune.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsHyperParameterRangesContinuousParameterRanges
{
    [JsonPropertyName("maxValue")]
    public string? MaxValue { get; set; }

    [JsonPropertyName("minValue")]
    public string? MinValue { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("scalingType")]
    public string? ScalingType { get; set; }
}

/// <summary>
/// For a hyperparameter of the integer type, specifies the range that a hyperparameter
/// tuning job searches.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsHyperParameterRangesIntegerParameterRanges
{
    [JsonPropertyName("maxValue")]
    public string? MaxValue { get; set; }

    [JsonPropertyName("minValue")]
    public string? MinValue { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("scalingType")]
    public string? ScalingType { get; set; }
}

/// <summary>
/// Specifies ranges of integer, continuous, and categorical hyperparameters
/// that a hyperparameter tuning job searches. The hyperparameter tuning job
/// launches training jobs with hyperparameter values within these ranges to
/// find the combination of values that result in the training job with the best
/// performance as measured by the objective metric of the hyperparameter tuning
/// job.
/// 
/// The maximum number of items specified for Array Members refers to the maximum
/// number of hyperparameters for each range and also the maximum for the hyperparameter
/// tuning job itself. That is, the sum of the number of hyperparameters for
/// all the ranges can&apos;t exceed the maximum number specified.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsHyperParameterRanges
{
    [JsonPropertyName("autoParameters")]
    public IList<V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsHyperParameterRangesAutoParameters>? AutoParameters { get; set; }

    [JsonPropertyName("categoricalParameterRanges")]
    public IList<V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsHyperParameterRangesCategoricalParameterRanges>? CategoricalParameterRanges { get; set; }

    [JsonPropertyName("continuousParameterRanges")]
    public IList<V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsHyperParameterRangesContinuousParameterRanges>? ContinuousParameterRanges { get; set; }

    [JsonPropertyName("integerParameterRanges")]
    public IList<V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsHyperParameterRangesIntegerParameterRanges>? IntegerParameterRanges { get; set; }
}

/// <summary>Specifies a file system data source for a channel.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsInputDataConfigDataSourceFileSystemDataSource
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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsInputDataConfigDataSourceS3DataSourceHubAccessConfig
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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsInputDataConfigDataSourceS3DataSourceModelAccessConfig
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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsInputDataConfigDataSourceS3DataSource
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
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsInputDataConfigDataSourceS3DataSourceHubAccessConfig? HubAccessConfig { get; set; }

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
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsInputDataConfigDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsInputDataConfigDataSource
{
    /// <summary>Specifies a file system data source for a channel.</summary>
    [JsonPropertyName("fileSystemDataSource")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsInputDataConfigDataSourceFileSystemDataSource? FileSystemDataSource { get; set; }

    /// <summary>
    /// Describes the S3 data source.
    /// 
    /// Your input bucket must be in the same Amazon Web Services region as your
    /// training job.
    /// </summary>
    [JsonPropertyName("s3DataSource")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsInputDataConfigDataSourceS3DataSource? S3DataSource { get; set; }
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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsInputDataConfigShuffleConfig
{
    [JsonPropertyName("seed")]
    public long? Seed { get; set; }
}

/// <summary>A channel is a named input source that training algorithms can consume.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsInputDataConfig
{
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Describes the location of the channel data.</summary>
    [JsonPropertyName("dataSource")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsInputDataConfigDataSource? DataSource { get; set; }

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
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsInputDataConfigShuffleConfig? ShuffleConfig { get; set; }
}

/// <summary>Provides information about how to store model training results (model artifacts).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsOutputDataConfig
{
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>
/// Defines an instance group for heterogeneous cluster training. When requesting
/// a training job using the CreateTrainingJob (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateTrainingJob.html)
/// API, you can configure multiple instance groups .
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsResourceConfigInstanceGroups
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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsResourceConfigInstancePlacementConfigPlacementSpecifications
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
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsResourceConfigInstancePlacementConfig
{
    [JsonPropertyName("enableMultipleJobs")]
    public bool? EnableMultipleJobs { get; set; }

    [JsonPropertyName("placementSpecifications")]
    public IList<V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsResourceConfigInstancePlacementConfigPlacementSpecifications>? PlacementSpecifications { get; set; }
}

/// <summary>
/// Describes the resources, including machine learning (ML) compute instances
/// and ML storage volumes, to use for model training.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsResourceConfig
{
    [JsonPropertyName("instanceCount")]
    public long? InstanceCount { get; set; }

    [JsonPropertyName("instanceGroups")]
    public IList<V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsResourceConfigInstanceGroups>? InstanceGroups { get; set; }

    /// <summary>
    /// Configuration for how instances are placed and allocated within UltraServers.
    /// This is only applicable for UltraServer capacity.
    /// </summary>
    [JsonPropertyName("instancePlacementConfig")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsResourceConfigInstancePlacementConfig? InstancePlacementConfig { get; set; }

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

/// <summary>
/// The retry strategy to use when a training job fails due to an InternalServerError.
/// RetryStrategy is specified as part of the CreateTrainingJob and CreateHyperParameterTuningJob
/// requests. You can add the StoppingCondition parameter to the request to limit
/// the training time for the complete job.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsRetryStrategy
{
    [JsonPropertyName("maximumRetryAttempts")]
    public long? MaximumRetryAttempts { get; set; }
}

/// <summary>
/// Specifies a limit to how long a job can run. When the job reaches the time
/// limit, SageMaker ends the job. Use this API to cap costs.
/// 
/// To stop a training job, SageMaker sends the algorithm the SIGTERM signal,
/// which delays job termination for 120 seconds. Algorithms can use this 120-second
/// window to save the model artifacts, so the results of training are not lost.
/// 
/// The training algorithms provided by SageMaker automatically save the intermediate
/// results of a model training job when possible. This attempt to save artifacts
/// is only a best effort case as model might not be in a state from which it
/// can be saved. For example, if training has just started, the model might
/// not be ready to save. When saved, this intermediate data is a valid model
/// artifact. You can use it to create a model with CreateModel.
/// 
/// The Neural Topic Model (NTM) currently does not support saving intermediate
/// model artifacts. When training NTMs, make sure that the maximum runtime is
/// sufficient for the training job to complete.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsStoppingCondition
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
/// Defines the objective metric for a hyperparameter tuning job. Hyperparameter
/// tuning uses the value of this metric to evaluate the training jobs it launches,
/// and returns the training job that results in either the highest or lowest
/// value for this metric, depending on the value you specify for the Type parameter.
/// If you want to define a custom objective metric, see Define metrics and environment
/// variables (https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-define-metrics-variables.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsTuningObjective
{
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }
}

/// <summary>
/// Specifies an Amazon Virtual Private Cloud (VPC) that your SageMaker jobs,
/// hosted models, and compute resources have access to. You can control access
/// to and from your resources by configuring a VPC. For more information, see
/// Give SageMaker Access to Resources in your Amazon VPC (https://docs.aws.amazon.com/sagemaker/latest/dg/infrastructure-give-access.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsVpcConfig
{
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>Defines the training jobs launched by a hyperparameter tuning job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitions
{
    /// <summary>
    /// Specifies which training algorithm to use for training jobs that a hyperparameter
    /// tuning job launches and the metrics to monitor.
    /// </summary>
    [JsonPropertyName("algorithmSpecification")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsAlgorithmSpecification? AlgorithmSpecification { get; set; }

    /// <summary>
    /// Contains information about the output location for managed spot training
    /// checkpoint data.
    /// </summary>
    [JsonPropertyName("checkpointConfig")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsCheckpointConfig? CheckpointConfig { get; set; }

    [JsonPropertyName("definitionName")]
    public string? DefinitionName { get; set; }

    [JsonPropertyName("enableInterContainerTrafficEncryption")]
    public bool? EnableInterContainerTrafficEncryption { get; set; }

    [JsonPropertyName("enableManagedSpotTraining")]
    public bool? EnableManagedSpotTraining { get; set; }

    [JsonPropertyName("enableNetworkIsolation")]
    public bool? EnableNetworkIsolation { get; set; }

    /// <summary>
    /// Specifies ranges of integer, continuous, and categorical hyperparameters
    /// that a hyperparameter tuning job searches. The hyperparameter tuning job
    /// launches training jobs with hyperparameter values within these ranges to
    /// find the combination of values that result in the training job with the best
    /// performance as measured by the objective metric of the hyperparameter tuning
    /// job.
    /// 
    /// The maximum number of items specified for Array Members refers to the maximum
    /// number of hyperparameters for each range and also the maximum for the hyperparameter
    /// tuning job itself. That is, the sum of the number of hyperparameters for
    /// all the ranges can&apos;t exceed the maximum number specified.
    /// </summary>
    [JsonPropertyName("hyperParameterRanges")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsHyperParameterRanges? HyperParameterRanges { get; set; }

    [JsonPropertyName("inputDataConfig")]
    public IList<V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsInputDataConfig>? InputDataConfig { get; set; }

    /// <summary>Provides information about how to store model training results (model artifacts).</summary>
    [JsonPropertyName("outputDataConfig")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsOutputDataConfig? OutputDataConfig { get; set; }

    /// <summary>
    /// Describes the resources, including machine learning (ML) compute instances
    /// and ML storage volumes, to use for model training.
    /// </summary>
    [JsonPropertyName("resourceConfig")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsResourceConfig? ResourceConfig { get; set; }

    /// <summary>
    /// The retry strategy to use when a training job fails due to an InternalServerError.
    /// RetryStrategy is specified as part of the CreateTrainingJob and CreateHyperParameterTuningJob
    /// requests. You can add the StoppingCondition parameter to the request to limit
    /// the training time for the complete job.
    /// </summary>
    [JsonPropertyName("retryStrategy")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsRetryStrategy? RetryStrategy { get; set; }

    [JsonPropertyName("roleARN")]
    public string? RoleARN { get; set; }

    [JsonPropertyName("staticHyperParameters")]
    public IDictionary<string, string>? StaticHyperParameters { get; set; }

    /// <summary>
    /// Specifies a limit to how long a job can run. When the job reaches the time
    /// limit, SageMaker ends the job. Use this API to cap costs.
    /// 
    /// To stop a training job, SageMaker sends the algorithm the SIGTERM signal,
    /// which delays job termination for 120 seconds. Algorithms can use this 120-second
    /// window to save the model artifacts, so the results of training are not lost.
    /// 
    /// The training algorithms provided by SageMaker automatically save the intermediate
    /// results of a model training job when possible. This attempt to save artifacts
    /// is only a best effort case as model might not be in a state from which it
    /// can be saved. For example, if training has just started, the model might
    /// not be ready to save. When saved, this intermediate data is a valid model
    /// artifact. You can use it to create a model with CreateModel.
    /// 
    /// The Neural Topic Model (NTM) currently does not support saving intermediate
    /// model artifacts. When training NTMs, make sure that the maximum runtime is
    /// sufficient for the training job to complete.
    /// </summary>
    [JsonPropertyName("stoppingCondition")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsStoppingCondition? StoppingCondition { get; set; }

    /// <summary>
    /// Defines the objective metric for a hyperparameter tuning job. Hyperparameter
    /// tuning uses the value of this metric to evaluate the training jobs it launches,
    /// and returns the training job that results in either the highest or lowest
    /// value for this metric, depending on the value you specify for the Type parameter.
    /// If you want to define a custom objective metric, see Define metrics and environment
    /// variables (https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-define-metrics-variables.html).
    /// </summary>
    [JsonPropertyName("tuningObjective")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsTuningObjective? TuningObjective { get; set; }

    /// <summary>
    /// Specifies an Amazon Virtual Private Cloud (VPC) that your SageMaker jobs,
    /// hosted models, and compute resources have access to. You can control access
    /// to and from your resources by configuring a VPC. For more information, see
    /// Give SageMaker Access to Resources in your Amazon VPC (https://docs.aws.amazon.com/sagemaker/latest/dg/infrastructure-give-access.html).
    /// </summary>
    [JsonPropertyName("vpcConfig")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitionsVpcConfig? VpcConfig { get; set; }
}

/// <summary>
/// A previously completed or stopped hyperparameter tuning job to be used as
/// a starting point for a new hyperparameter tuning job.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecWarmStartConfigParentHyperParameterTuningJobs
{
    [JsonPropertyName("hyperParameterTuningJobName")]
    public string? HyperParameterTuningJobName { get; set; }
}

/// <summary>
/// Specifies the configuration for starting the hyperparameter tuning job using
/// one or more previous tuning jobs as a starting point. The results of previous
/// tuning jobs are used to inform which combinations of hyperparameters to search
/// over in the new tuning job.
/// 
/// All training jobs launched by the new hyperparameter tuning job are evaluated
/// by using the objective metric. If you specify IDENTICAL_DATA_AND_ALGORITHM
/// as the WarmStartType value for the warm start configuration, the training
/// job that performs the best in the new tuning job is compared to the best
/// training jobs from the parent tuning jobs. From these, the training job that
/// performs the best as measured by the objective metric is returned as the
/// overall best training job.
/// 
/// All training jobs launched by parent hyperparameter tuning jobs and the new
/// hyperparameter tuning jobs count against the limit of training jobs for the
/// tuning job.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpecWarmStartConfig
{
    [JsonPropertyName("parentHyperParameterTuningJobs")]
    public IList<V1alpha1HyperParameterTuningJobSpecWarmStartConfigParentHyperParameterTuningJobs>? ParentHyperParameterTuningJobs { get; set; }

    [JsonPropertyName("warmStartType")]
    public string? WarmStartType { get; set; }
}

/// <summary>HyperParameterTuningJobSpec defines the desired state of HyperParameterTuningJob.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobSpec
{
    /// <summary>
    /// Configures SageMaker Automatic model tuning (AMT) to automatically find optimal
    /// parameters for the following fields:
    /// 
    ///   - ParameterRanges (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobConfig.html#sagemaker-Type-HyperParameterTuningJobConfig-ParameterRanges):
    ///     The names and ranges of parameters that a hyperparameter tuning job can
    ///     optimize.
    /// 
    ///   - ResourceLimits (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ResourceLimits.html):
    ///     The maximum resources that can be used for a training job. These resources
    ///     include the maximum number of training jobs, the maximum runtime of a
    ///     tuning job, and the maximum number of training jobs to run at the same
    ///     time.
    /// 
    ///   - TrainingJobEarlyStoppingType (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobConfig.html#sagemaker-Type-HyperParameterTuningJobConfig-TrainingJobEarlyStoppingType):
    ///     A flag that specifies whether or not to use early stopping for training
    ///     jobs launched by a hyperparameter tuning job.
    /// 
    ///   - RetryStrategy (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTrainingJobDefinition.html#sagemaker-Type-HyperParameterTrainingJobDefinition-RetryStrategy):
    ///     The number of times to retry a training job.
    /// 
    ///   - Strategy (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobConfig.html):
    ///     Specifies how hyperparameter tuning chooses the combinations of hyperparameter
    ///     values to use for the training jobs that it launches.
    /// 
    ///   - ConvergenceDetected (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_ConvergenceDetected.html):
    ///     A flag to indicate that Automatic model tuning (AMT) has detected model
    ///     convergence.
    /// </summary>
    [JsonPropertyName("autotune")]
    public V1alpha1HyperParameterTuningJobSpecAutotune? Autotune { get; set; }

    /// <summary>
    /// The HyperParameterTuningJobConfig (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobConfig.html)
    /// object that describes the tuning job, including the search strategy, the
    /// objective metric used to evaluate training jobs, ranges of parameters to
    /// search, and resource limits for the tuning job. For more information, see
    /// How Hyperparameter Tuning Works (https://docs.aws.amazon.com/sagemaker/latest/dg/automatic-model-tuning-how-it-works.html).
    /// </summary>
    [JsonPropertyName("hyperParameterTuningJobConfig")]
    public required V1alpha1HyperParameterTuningJobSpecHyperParameterTuningJobConfig HyperParameterTuningJobConfig { get; set; }

    /// <summary>
    /// The name of the tuning job. This name is the prefix for the names of all
    /// training jobs that this tuning job launches. The name must be unique within
    /// the same Amazon Web Services account and Amazon Web Services Region. The
    /// name must have 1 to 32 characters. Valid characters are a-z, A-Z, 0-9, and
    /// : + = @ _ % - (hyphen). The name is not case sensitive.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,31}$`
    /// </summary>
    [JsonPropertyName("hyperParameterTuningJobName")]
    public required string HyperParameterTuningJobName { get; set; }

    /// <summary>
    /// An array of key-value pairs. You can use tags to categorize your Amazon Web
    /// Services resources in different ways, for example, by purpose, owner, or
    /// environment. For more information, see Tagging Amazon Web Services Resources
    /// (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html).
    /// 
    /// Tags that you specify for the tuning job are also added to all training jobs
    /// that the tuning job launches.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1HyperParameterTuningJobSpecTags>? Tags { get; set; }

    /// <summary>
    /// The HyperParameterTrainingJobDefinition (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTrainingJobDefinition.html)
    /// object that describes the training jobs that this tuning job launches, including
    /// static hyperparameters, input data configuration, output data configuration,
    /// resource configuration, and stopping condition.
    /// </summary>
    [JsonPropertyName("trainingJobDefinition")]
    public V1alpha1HyperParameterTuningJobSpecTrainingJobDefinition? TrainingJobDefinition { get; set; }

    /// <summary>
    /// A list of the HyperParameterTrainingJobDefinition (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTrainingJobDefinition.html)
    /// objects launched for this tuning job.
    /// </summary>
    [JsonPropertyName("trainingJobDefinitions")]
    public IList<V1alpha1HyperParameterTuningJobSpecTrainingJobDefinitions>? TrainingJobDefinitions { get; set; }

    /// <summary>
    /// Specifies the configuration for starting the hyperparameter tuning job using
    /// one or more previous tuning jobs as a starting point. The results of previous
    /// tuning jobs are used to inform which combinations of hyperparameters to search
    /// over in the new tuning job.
    /// 
    /// All training jobs launched by the new hyperparameter tuning job are evaluated
    /// by using the objective metric. If you specify IDENTICAL_DATA_AND_ALGORITHM
    /// as the WarmStartType value for the warm start configuration, the training
    /// job that performs the best in the new tuning job is compared to the best
    /// training jobs from the parent tuning jobs. From these, the training job that
    /// performs the best as measured by the objective metric is returned as the
    /// overall best training job.
    /// 
    /// All training jobs launched by parent hyperparameter tuning jobs and the new
    /// hyperparameter tuning jobs count against the limit of training jobs for the
    /// tuning job.
    /// </summary>
    [JsonPropertyName("warmStartConfig")]
    public V1alpha1HyperParameterTuningJobSpecWarmStartConfig? WarmStartConfig { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobStatusAckResourceMetadata
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
/// Shows the latest objective metric emitted by a training job that was launched
/// by a hyperparameter tuning job. You define the objective metric in the HyperParameterTuningJobObjective
/// parameter of HyperParameterTuningJobConfig (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobConfig.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobStatusBestTrainingJobFinalHyperParameterTuningJobObjectiveMetric
{
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>
/// A TrainingJobSummary (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_TrainingJobSummary.html)
/// object that describes the training job that completed with the best current
/// HyperParameterTuningJobObjective (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobObjective.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobStatusBestTrainingJob
{
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>
    /// Shows the latest objective metric emitted by a training job that was launched
    /// by a hyperparameter tuning job. You define the objective metric in the HyperParameterTuningJobObjective
    /// parameter of HyperParameterTuningJobConfig (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobConfig.html).
    /// </summary>
    [JsonPropertyName("finalHyperParameterTuningJobObjectiveMetric")]
    public V1alpha1HyperParameterTuningJobStatusBestTrainingJobFinalHyperParameterTuningJobObjectiveMetric? FinalHyperParameterTuningJobObjectiveMetric { get; set; }

    [JsonPropertyName("objectiveStatus")]
    public string? ObjectiveStatus { get; set; }

    [JsonPropertyName("trainingEndTime")]
    public DateTime? TrainingEndTime { get; set; }

    [JsonPropertyName("trainingJobARN")]
    public string? TrainingJobARN { get; set; }

    [JsonPropertyName("trainingJobDefinitionName")]
    public string? TrainingJobDefinitionName { get; set; }

    [JsonPropertyName("trainingJobName")]
    public string? TrainingJobName { get; set; }

    [JsonPropertyName("trainingJobStatus")]
    public string? TrainingJobStatus { get; set; }

    [JsonPropertyName("trainingStartTime")]
    public DateTime? TrainingStartTime { get; set; }

    [JsonPropertyName("tunedHyperParameters")]
    public IDictionary<string, string>? TunedHyperParameters { get; set; }

    [JsonPropertyName("tuningJobName")]
    public string? TuningJobName { get; set; }
}

/// <summary>
/// Condition is the common struct used by all CRDs managed by ACK service
/// controllers to indicate terminal states  of the CR and its backend AWS
/// service API resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobStatusConditions
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
/// Shows the latest objective metric emitted by a training job that was launched
/// by a hyperparameter tuning job. You define the objective metric in the HyperParameterTuningJobObjective
/// parameter of HyperParameterTuningJobConfig (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobConfig.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobStatusOverallBestTrainingJobFinalHyperParameterTuningJobObjectiveMetric
{
    [JsonPropertyName("metricName")]
    public string? MetricName { get; set; }

    [JsonPropertyName("type_")]
    public string? Type { get; set; }

    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>
/// If the hyperparameter tuning job is an warm start tuning job with a WarmStartType
/// of IDENTICAL_DATA_AND_ALGORITHM, this is the TrainingJobSummary (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_TrainingJobSummary.html)
/// for the training job with the best objective metric value of all training
/// jobs launched by this tuning job and all parent jobs specified for the warm
/// start tuning job.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobStatusOverallBestTrainingJob
{
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>
    /// Shows the latest objective metric emitted by a training job that was launched
    /// by a hyperparameter tuning job. You define the objective metric in the HyperParameterTuningJobObjective
    /// parameter of HyperParameterTuningJobConfig (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobConfig.html).
    /// </summary>
    [JsonPropertyName("finalHyperParameterTuningJobObjectiveMetric")]
    public V1alpha1HyperParameterTuningJobStatusOverallBestTrainingJobFinalHyperParameterTuningJobObjectiveMetric? FinalHyperParameterTuningJobObjectiveMetric { get; set; }

    [JsonPropertyName("objectiveStatus")]
    public string? ObjectiveStatus { get; set; }

    [JsonPropertyName("trainingEndTime")]
    public DateTime? TrainingEndTime { get; set; }

    [JsonPropertyName("trainingJobARN")]
    public string? TrainingJobARN { get; set; }

    [JsonPropertyName("trainingJobDefinitionName")]
    public string? TrainingJobDefinitionName { get; set; }

    [JsonPropertyName("trainingJobName")]
    public string? TrainingJobName { get; set; }

    [JsonPropertyName("trainingJobStatus")]
    public string? TrainingJobStatus { get; set; }

    [JsonPropertyName("trainingStartTime")]
    public DateTime? TrainingStartTime { get; set; }

    [JsonPropertyName("tunedHyperParameters")]
    public IDictionary<string, string>? TunedHyperParameters { get; set; }

    [JsonPropertyName("tuningJobName")]
    public string? TuningJobName { get; set; }
}

/// <summary>HyperParameterTuningJobStatus defines the observed state of HyperParameterTuningJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1HyperParameterTuningJobStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1HyperParameterTuningJobStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// A TrainingJobSummary (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_TrainingJobSummary.html)
    /// object that describes the training job that completed with the best current
    /// HyperParameterTuningJobObjective (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_HyperParameterTuningJobObjective.html).
    /// </summary>
    [JsonPropertyName("bestTrainingJob")]
    public V1alpha1HyperParameterTuningJobStatusBestTrainingJob? BestTrainingJob { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1HyperParameterTuningJobStatusConditions>? Conditions { get; set; }

    /// <summary>If the tuning job failed, the reason it failed.</summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>The status of the tuning job.</summary>
    [JsonPropertyName("hyperParameterTuningJobStatus")]
    public string? HyperParameterTuningJobStatus { get; set; }

    /// <summary>
    /// If the hyperparameter tuning job is an warm start tuning job with a WarmStartType
    /// of IDENTICAL_DATA_AND_ALGORITHM, this is the TrainingJobSummary (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_TrainingJobSummary.html)
    /// for the training job with the best objective metric value of all training
    /// jobs launched by this tuning job and all parent jobs specified for the warm
    /// start tuning job.
    /// </summary>
    [JsonPropertyName("overallBestTrainingJob")]
    public V1alpha1HyperParameterTuningJobStatusOverallBestTrainingJob? OverallBestTrainingJob { get; set; }
}

/// <summary>HyperParameterTuningJob is the Schema for the HyperParameterTuningJobs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1HyperParameterTuningJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1HyperParameterTuningJobSpec?>, IStatus<V1alpha1HyperParameterTuningJobStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "HyperParameterTuningJob";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "hyperparametertuningjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "HyperParameterTuningJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>HyperParameterTuningJobSpec defines the desired state of HyperParameterTuningJob.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1HyperParameterTuningJobSpec? Spec { get; set; }

    /// <summary>HyperParameterTuningJobStatus defines the observed state of HyperParameterTuningJob</summary>
    [JsonPropertyName("status")]
    public V1alpha1HyperParameterTuningJobStatus? Status { get; set; }
}