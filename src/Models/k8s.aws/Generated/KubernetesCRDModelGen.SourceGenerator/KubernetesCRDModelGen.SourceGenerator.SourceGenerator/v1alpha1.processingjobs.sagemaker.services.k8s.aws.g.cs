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
/// <summary>ProcessingJob is the Schema for the ProcessingJobs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ProcessingJobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ProcessingJob>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ProcessingJobList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "processingjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ProcessingJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ProcessingJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ProcessingJob> Items { get; set; }
}

/// <summary>Configures the processing job to run a specified Docker container image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobSpecAppSpecification
{
    [JsonPropertyName("containerArguments")]
    public IList<string>? ContainerArguments { get; set; }

    [JsonPropertyName("containerEntrypoint")]
    public IList<string>? ContainerEntrypoint { get; set; }

    [JsonPropertyName("imageURI")]
    public string? ImageURI { get; set; }
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
public partial class V1alpha1ProcessingJobSpecExperimentConfig
{
    [JsonPropertyName("experimentName")]
    public string? ExperimentName { get; set; }

    [JsonPropertyName("trialComponentDisplayName")]
    public string? TrialComponentDisplayName { get; set; }

    [JsonPropertyName("trialName")]
    public string? TrialName { get; set; }
}

/// <summary>
/// Specifies an Amazon Virtual Private Cloud (VPC) that your SageMaker jobs,
/// hosted models, and compute resources have access to. You can control access
/// to and from your resources by configuring a VPC. For more information, see
/// Give SageMaker Access to Resources in your Amazon VPC (https://docs.aws.amazon.com/sagemaker/latest/dg/infrastructure-give-access.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobSpecNetworkConfigVpcConfig
{
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>
/// Networking options for a processing job, such as whether to allow inbound
/// and outbound network calls to and from processing containers, and the VPC
/// subnets and security groups to use for VPC-enabled processing jobs.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobSpecNetworkConfig
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
    public V1alpha1ProcessingJobSpecNetworkConfigVpcConfig? VpcConfig { get; set; }
}

/// <summary>Configuration for Athena Dataset Definition input.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobSpecProcessingInputsDatasetDefinitionAthenaDatasetDefinition
{
    /// <summary>The name of the data catalog used in Athena query execution.</summary>
    [JsonPropertyName("catalog")]
    public string? Catalog { get; set; }

    /// <summary>The name of the database used in the Athena query execution.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>The compression used for Athena query results.</summary>
    [JsonPropertyName("outputCompression")]
    public string? OutputCompression { get; set; }

    /// <summary>The data storage format for Athena query results.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    [JsonPropertyName("outputS3URI")]
    public string? OutputS3URI { get; set; }

    /// <summary>The SQL query statements, to be executed.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }

    /// <summary>The name of the workgroup in which the Athena query is being started.</summary>
    [JsonPropertyName("workGroup")]
    public string? WorkGroup { get; set; }
}

/// <summary>Configuration for Redshift Dataset Definition input.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobSpecProcessingInputsDatasetDefinitionRedshiftDatasetDefinition
{
    /// <summary>The Redshift cluster Identifier.</summary>
    [JsonPropertyName("clusterID")]
    public string? ClusterID { get; set; }

    [JsonPropertyName("clusterRoleARN")]
    public string? ClusterRoleARN { get; set; }

    /// <summary>The name of the Redshift database used in Redshift query execution.</summary>
    [JsonPropertyName("database")]
    public string? Database { get; set; }

    /// <summary>The database user name used in Redshift query execution.</summary>
    [JsonPropertyName("dbUser")]
    public string? DbUser { get; set; }

    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    /// <summary>The compression used for Redshift query results.</summary>
    [JsonPropertyName("outputCompression")]
    public string? OutputCompression { get; set; }

    /// <summary>The data storage format for Redshift query results.</summary>
    [JsonPropertyName("outputFormat")]
    public string? OutputFormat { get; set; }

    [JsonPropertyName("outputS3URI")]
    public string? OutputS3URI { get; set; }

    /// <summary>The SQL query statements to be executed.</summary>
    [JsonPropertyName("queryString")]
    public string? QueryString { get; set; }
}

/// <summary>
/// Configuration for Dataset Definition inputs. The Dataset Definition input
/// must specify exactly one of either AthenaDatasetDefinition or RedshiftDatasetDefinition
/// types.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobSpecProcessingInputsDatasetDefinition
{
    /// <summary>Configuration for Athena Dataset Definition input.</summary>
    [JsonPropertyName("athenaDatasetDefinition")]
    public V1alpha1ProcessingJobSpecProcessingInputsDatasetDefinitionAthenaDatasetDefinition? AthenaDatasetDefinition { get; set; }

    [JsonPropertyName("dataDistributionType")]
    public string? DataDistributionType { get; set; }

    [JsonPropertyName("inputMode")]
    public string? InputMode { get; set; }

    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    /// <summary>Configuration for Redshift Dataset Definition input.</summary>
    [JsonPropertyName("redshiftDatasetDefinition")]
    public V1alpha1ProcessingJobSpecProcessingInputsDatasetDefinitionRedshiftDatasetDefinition? RedshiftDatasetDefinition { get; set; }
}

/// <summary>
/// Configuration for downloading input data from Amazon S3 into the processing
/// container.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobSpecProcessingInputsS3Input
{
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    [JsonPropertyName("s3CompressionType")]
    public string? S3CompressionType { get; set; }

    [JsonPropertyName("s3DataDistributionType")]
    public string? S3DataDistributionType { get; set; }

    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    [JsonPropertyName("s3InputMode")]
    public string? S3InputMode { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>
/// The inputs for a processing job. The processing input must specify exactly
/// one of either S3Input or DatasetDefinition types.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobSpecProcessingInputs
{
    [JsonPropertyName("appManaged")]
    public bool? AppManaged { get; set; }

    /// <summary>
    /// Configuration for Dataset Definition inputs. The Dataset Definition input
    /// must specify exactly one of either AthenaDatasetDefinition or RedshiftDatasetDefinition
    /// types.
    /// </summary>
    [JsonPropertyName("datasetDefinition")]
    public V1alpha1ProcessingJobSpecProcessingInputsDatasetDefinition? DatasetDefinition { get; set; }

    [JsonPropertyName("inputName")]
    public string? InputName { get; set; }

    /// <summary>
    /// Configuration for downloading input data from Amazon S3 into the processing
    /// container.
    /// </summary>
    [JsonPropertyName("s3Input")]
    public V1alpha1ProcessingJobSpecProcessingInputsS3Input? S3Input { get; set; }
}

/// <summary>Configuration for processing job outputs in Amazon SageMaker Feature Store.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobSpecProcessingOutputConfigOutputsFeatureStoreOutput
{
    [JsonPropertyName("featureGroupName")]
    public string? FeatureGroupName { get; set; }
}

/// <summary>
/// Configuration for uploading output data to Amazon S3 from the processing
/// container.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobSpecProcessingOutputConfigOutputsS3Output
{
    [JsonPropertyName("localPath")]
    public string? LocalPath { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }

    [JsonPropertyName("s3UploadMode")]
    public string? S3UploadMode { get; set; }
}

/// <summary>
/// Describes the results of a processing job. The processing output must specify
/// exactly one of either S3Output or FeatureStoreOutput types.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobSpecProcessingOutputConfigOutputs
{
    [JsonPropertyName("appManaged")]
    public bool? AppManaged { get; set; }

    /// <summary>Configuration for processing job outputs in Amazon SageMaker Feature Store.</summary>
    [JsonPropertyName("featureStoreOutput")]
    public V1alpha1ProcessingJobSpecProcessingOutputConfigOutputsFeatureStoreOutput? FeatureStoreOutput { get; set; }

    [JsonPropertyName("outputName")]
    public string? OutputName { get; set; }

    /// <summary>
    /// Configuration for uploading output data to Amazon S3 from the processing
    /// container.
    /// </summary>
    [JsonPropertyName("s3Output")]
    public V1alpha1ProcessingJobSpecProcessingOutputConfigOutputsS3Output? S3Output { get; set; }
}

/// <summary>Output configuration for the processing job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobSpecProcessingOutputConfig
{
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("outputs")]
    public IList<V1alpha1ProcessingJobSpecProcessingOutputConfigOutputs>? Outputs { get; set; }
}

/// <summary>Configuration for the cluster used to run a processing job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobSpecProcessingResourcesClusterConfig
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

/// <summary>
/// Identifies the resources, ML compute instances, and ML storage volumes to
/// deploy for a processing job. In distributed training, you specify more than
/// one instance.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobSpecProcessingResources
{
    /// <summary>Configuration for the cluster used to run a processing job.</summary>
    [JsonPropertyName("clusterConfig")]
    public V1alpha1ProcessingJobSpecProcessingResourcesClusterConfig? ClusterConfig { get; set; }
}

/// <summary>The time limit for how long the processing job is allowed to run.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobSpecStoppingCondition
{
    [JsonPropertyName("maxRuntimeInSeconds")]
    public long? MaxRuntimeInSeconds { get; set; }
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
public partial class V1alpha1ProcessingJobSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// ProcessingJobSpec defines the desired state of ProcessingJob.
/// 
/// An Amazon SageMaker processing job that is used to analyze data and evaluate
/// models. For more information, see Process Data and Evaluate Models (https://docs.aws.amazon.com/sagemaker/latest/dg/processing-job.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobSpec
{
    /// <summary>Configures the processing job to run a specified Docker container image.</summary>
    [JsonPropertyName("appSpecification")]
    public required V1alpha1ProcessingJobSpecAppSpecification AppSpecification { get; set; }

    /// <summary>
    /// The environment variables to set in the Docker container. Up to 100 key and
    /// values entries in the map are supported.
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
    public V1alpha1ProcessingJobSpecExperimentConfig? ExperimentConfig { get; set; }

    /// <summary>
    /// Networking options for a processing job, such as whether to allow inbound
    /// and outbound network calls to and from processing containers, and the VPC
    /// subnets and security groups to use for VPC-enabled processing jobs.
    /// </summary>
    [JsonPropertyName("networkConfig")]
    public V1alpha1ProcessingJobSpecNetworkConfig? NetworkConfig { get; set; }

    /// <summary>An array of inputs configuring the data to download into the processing container.</summary>
    [JsonPropertyName("processingInputs")]
    public IList<V1alpha1ProcessingJobSpecProcessingInputs>? ProcessingInputs { get; set; }

    /// <summary>
    /// The name of the processing job. The name must be unique within an Amazon
    /// Web Services Region in the Amazon Web Services account.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$`
    /// </summary>
    [JsonPropertyName("processingJobName")]
    public required string ProcessingJobName { get; set; }

    /// <summary>Output configuration for the processing job.</summary>
    [JsonPropertyName("processingOutputConfig")]
    public V1alpha1ProcessingJobSpecProcessingOutputConfig? ProcessingOutputConfig { get; set; }

    /// <summary>
    /// Identifies the resources, ML compute instances, and ML storage volumes to
    /// deploy for a processing job. In distributed training, you specify more than
    /// one instance.
    /// </summary>
    [JsonPropertyName("processingResources")]
    public required V1alpha1ProcessingJobSpecProcessingResources ProcessingResources { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker can assume
    /// to perform tasks on your behalf.
    /// 
    /// Regex Pattern: `^arn:aws[a-z\-]*:iam::\d{12}:role/?[a-zA-Z_0-9+=,.@\-_/]+$`
    /// </summary>
    [JsonPropertyName("roleARN")]
    public required string RoleARN { get; set; }

    /// <summary>The time limit for how long the processing job is allowed to run.</summary>
    [JsonPropertyName("stoppingCondition")]
    public V1alpha1ProcessingJobSpecStoppingCondition? StoppingCondition { get; set; }

    /// <summary>
    /// (Optional) An array of key-value pairs. For more information, see Using Cost
    /// Allocation Tags (https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-whatURL)
    /// in the Amazon Web Services Billing and Cost Management User Guide.
    /// 
    /// Do not include any security-sensitive information including account access
    /// IDs, secrets, or tokens in any tags. As part of the shared responsibility
    /// model, you are responsible for any potential exposure, unauthorized access,
    /// or compromise of your sensitive data if caused by security-sensitive information
    /// included in the request tag variable or plain text fields.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ProcessingJobSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobStatusAckResourceMetadata
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
public partial class V1alpha1ProcessingJobStatusConditions
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

/// <summary>ProcessingJobStatus defines the observed state of ProcessingJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ProcessingJobStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ProcessingJobStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ProcessingJobStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// A string, up to one KB in size, that contains the reason a processing job
    /// failed, if it failed.
    /// </summary>
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    /// <summary>Provides the status of a processing job.</summary>
    [JsonPropertyName("processingJobStatus")]
    public string? ProcessingJobStatus { get; set; }
}

/// <summary>ProcessingJob is the Schema for the ProcessingJobs API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ProcessingJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ProcessingJobSpec?>, IStatus<V1alpha1ProcessingJobStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ProcessingJob";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "processingjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ProcessingJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ProcessingJobSpec defines the desired state of ProcessingJob.
    /// 
    /// An Amazon SageMaker processing job that is used to analyze data and evaluate
    /// models. For more information, see Process Data and Evaluate Models (https://docs.aws.amazon.com/sagemaker/latest/dg/processing-job.html).
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ProcessingJobSpec? Spec { get; set; }

    /// <summary>ProcessingJobStatus defines the observed state of ProcessingJob</summary>
    [JsonPropertyName("status")]
    public V1alpha1ProcessingJobStatus? Status { get; set; }
}