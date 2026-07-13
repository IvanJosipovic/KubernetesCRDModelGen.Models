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
/// <summary>TransformJob is the Schema for the TransformJobs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TransformJobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1TransformJob>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TransformJobList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "transformjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TransformJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1TransformJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1TransformJob> Items { get; set; }
}

/// <summary>
/// The data structure used to specify the data to be used for inference in a
/// batch transform job and to associate the data that is relevant to the prediction
/// results in the output. The input filter provided allows you to exclude input
/// data that is not needed for inference in a batch transform job. The output
/// filter provided allows you to include input data relevant to interpreting
/// the predictions in the output from the job. For more information, see Associate
/// Prediction Results with their Corresponding Input Records (https://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform-data-processing.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TransformJobSpecDataProcessing
{
    [JsonPropertyName("inputFilter")]
    public string? InputFilter { get; set; }

    [JsonPropertyName("joinSource")]
    public string? JoinSource { get; set; }

    [JsonPropertyName("outputFilter")]
    public string? OutputFilter { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TransformJobSpecExperimentConfig
{
    [JsonPropertyName("experimentName")]
    public string? ExperimentName { get; set; }

    [JsonPropertyName("trialComponentDisplayName")]
    public string? TrialComponentDisplayName { get; set; }

    [JsonPropertyName("trialName")]
    public string? TrialName { get; set; }
}

/// <summary>
/// Configures the timeout and maximum number of retries for processing a transform
/// job invocation.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TransformJobSpecModelClientConfig
{
    [JsonPropertyName("invocationsMaxRetries")]
    public long? InvocationsMaxRetries { get; set; }

    [JsonPropertyName("invocationsTimeoutInSeconds")]
    public long? InvocationsTimeoutInSeconds { get; set; }
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
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TransformJobSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Describes the S3 data source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TransformJobSpecTransformInputDataSourceS3DataSource
{
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Describes the location of the channel data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TransformJobSpecTransformInputDataSource
{
    /// <summary>Describes the S3 data source.</summary>
    [JsonPropertyName("s3DataSource")]
    public V1alpha1TransformJobSpecTransformInputDataSourceS3DataSource? S3DataSource { get; set; }
}

/// <summary>Describes the input source and the way the transform job consumes it.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TransformJobSpecTransformInput
{
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Describes the location of the channel data.</summary>
    [JsonPropertyName("dataSource")]
    public V1alpha1TransformJobSpecTransformInputDataSource? DataSource { get; set; }

    [JsonPropertyName("splitType")]
    public string? SplitType { get; set; }
}

/// <summary>Describes the results of the transform job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TransformJobSpecTransformOutput
{
    [JsonPropertyName("accept")]
    public string? Accept { get; set; }

    [JsonPropertyName("assembleWith")]
    public string? AssembleWith { get; set; }

    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>
/// Describes the resources, including ML instance types and ML instance count,
/// to use for the transform job.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TransformJobSpecTransformResources
{
    [JsonPropertyName("instanceCount")]
    public long? InstanceCount { get; set; }

    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    [JsonPropertyName("transformAMIVersion")]
    public string? TransformAMIVersion { get; set; }

    [JsonPropertyName("volumeKMSKeyID")]
    public string? VolumeKMSKeyID { get; set; }
}

/// <summary>
/// TransformJobSpec defines the desired state of TransformJob.
/// 
/// A batch transform job. For information about SageMaker batch transform, see
/// Use Batch Transform (https://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TransformJobSpec
{
    /// <summary>
    /// Specifies the number of records to include in a mini-batch for an HTTP inference
    /// request. A record is a single unit of input data that inference can be made
    /// on. For example, a single line in a CSV file is a record.
    /// 
    /// To enable the batch strategy, you must set the SplitType property to Line,
    /// RecordIO, or TFRecord.
    /// 
    /// To use only one record when making an HTTP invocation request to a container,
    /// set BatchStrategy to SingleRecord and SplitType to Line.
    /// 
    /// To fit as many records in a mini-batch as can fit within the MaxPayloadInMB
    /// limit, set BatchStrategy to MultiRecord and SplitType to Line.
    /// </summary>
    [JsonPropertyName("batchStrategy")]
    public string? BatchStrategy { get; set; }

    /// <summary>
    /// The data structure used to specify the data to be used for inference in a
    /// batch transform job and to associate the data that is relevant to the prediction
    /// results in the output. The input filter provided allows you to exclude input
    /// data that is not needed for inference in a batch transform job. The output
    /// filter provided allows you to include input data relevant to interpreting
    /// the predictions in the output from the job. For more information, see Associate
    /// Prediction Results with their Corresponding Input Records (https://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform-data-processing.html).
    /// </summary>
    [JsonPropertyName("dataProcessing")]
    public V1alpha1TransformJobSpecDataProcessing? DataProcessing { get; set; }

    /// <summary>
    /// The environment variables to set in the Docker container. Don&apos;t include any
    /// sensitive data in your environment variables. We support up to 16 key and
    /// values entries in the map.
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
    public V1alpha1TransformJobSpecExperimentConfig? ExperimentConfig { get; set; }

    /// <summary>
    /// The maximum number of parallel requests that can be sent to each instance
    /// in a transform job. If MaxConcurrentTransforms is set to 0 or left unset,
    /// Amazon SageMaker checks the optional execution-parameters to determine the
    /// settings for your chosen algorithm. If the execution-parameters endpoint
    /// is not enabled, the default value is 1. For more information on execution-parameters,
    /// see How Containers Serve Requests (https://docs.aws.amazon.com/sagemaker/latest/dg/your-algorithms-batch-code.html#your-algorithms-batch-code-how-containe-serves-requests).
    /// For built-in algorithms, you don&apos;t need to set a value for MaxConcurrentTransforms.
    /// </summary>
    [JsonPropertyName("maxConcurrentTransforms")]
    public long? MaxConcurrentTransforms { get; set; }

    /// <summary>
    /// The maximum allowed size of the payload, in MB. A payload is the data portion
    /// of a record (without metadata). The value in MaxPayloadInMB must be greater
    /// than, or equal to, the size of a single record. To estimate the size of a
    /// record in MB, divide the size of your dataset by the number of records. To
    /// ensure that the records fit within the maximum payload size, we recommend
    /// using a slightly larger value. The default value is 6 MB.
    /// 
    /// The value of MaxPayloadInMB cannot be greater than 100 MB. If you specify
    /// the MaxConcurrentTransforms parameter, the value of (MaxConcurrentTransforms
    /// * MaxPayloadInMB) also cannot exceed 100 MB.
    /// 
    /// For cases where the payload might be arbitrarily large and is transmitted
    /// using HTTP chunked encoding, set the value to 0. This feature works only
    /// in supported algorithms. Currently, Amazon SageMaker built-in algorithms
    /// do not support HTTP chunked encoding.
    /// </summary>
    [JsonPropertyName("maxPayloadInMB")]
    public long? MaxPayloadInMB { get; set; }

    /// <summary>
    /// Configures the timeout and maximum number of retries for processing a transform
    /// job invocation.
    /// </summary>
    [JsonPropertyName("modelClientConfig")]
    public V1alpha1TransformJobSpecModelClientConfig? ModelClientConfig { get; set; }

    /// <summary>
    /// The name of the model that you want to use for the transform job. ModelName
    /// must be the name of an existing Amazon SageMaker model within an Amazon Web
    /// Services Region in an Amazon Web Services account.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9]([\-a-zA-Z0-9]*[a-zA-Z0-9])?$`
    /// </summary>
    [JsonPropertyName("modelName")]
    public required string ModelName { get; set; }

    /// <summary>
    /// (Optional) An array of key-value pairs. For more information, see Using Cost
    /// Allocation Tags (https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-what)
    /// in the Amazon Web Services Billing and Cost Management User Guide.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1TransformJobSpecTags>? Tags { get; set; }

    /// <summary>Describes the input source and the way the transform job consumes it.</summary>
    [JsonPropertyName("transformInput")]
    public required V1alpha1TransformJobSpecTransformInput TransformInput { get; set; }

    /// <summary>
    /// The name of the transform job. The name must be unique within an Amazon Web
    /// Services Region in an Amazon Web Services account.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$`
    /// </summary>
    [JsonPropertyName("transformJobName")]
    public required string TransformJobName { get; set; }

    /// <summary>Describes the results of the transform job.</summary>
    [JsonPropertyName("transformOutput")]
    public required V1alpha1TransformJobSpecTransformOutput TransformOutput { get; set; }

    /// <summary>
    /// Describes the resources, including ML instance types and ML instance count,
    /// to use for the transform job.
    /// </summary>
    [JsonPropertyName("transformResources")]
    public required V1alpha1TransformJobSpecTransformResources TransformResources { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TransformJobStatusAckResourceMetadata
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
public partial class V1alpha1TransformJobStatusConditions
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

/// <summary>TransformJobStatus defines the observed state of TransformJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1TransformJobStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1TransformJobStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1TransformJobStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// If the transform job failed, FailureReason describes why it failed. A transform
    /// job creates a log file, which includes error messages, and stores it as an
    /// Amazon S3 object. For more information, see Log Amazon SageMaker Events with
    /// Amazon CloudWatch (https://docs.aws.amazon.com/sagemaker/latest/dg/logging-cloudwatch.html).
    /// </summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>
    /// The status of the transform job. If the transform job failed, the reason
    /// is returned in the FailureReason field.
    /// </summary>
    [JsonPropertyName("transformJobStatus")]
    public string? TransformJobStatus { get; set; }
}

/// <summary>TransformJob is the Schema for the TransformJobs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1TransformJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1TransformJobSpec?>, IStatus<V1alpha1TransformJobStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "TransformJob";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "transformjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "TransformJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// TransformJobSpec defines the desired state of TransformJob.
    /// 
    /// A batch transform job. For information about SageMaker batch transform, see
    /// Use Batch Transform (https://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform.html).
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1TransformJobSpec? Spec { get; set; }

    /// <summary>TransformJobStatus defines the observed state of TransformJob</summary>
    [JsonPropertyName("status")]
    public V1alpha1TransformJobStatus? Status { get; set; }
}