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
/// <summary>ModelBiasJobDefinition is the Schema for the ModelBiasJobDefinitions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ModelBiasJobDefinitionList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ModelBiasJobDefinition>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ModelBiasJobDefinitionList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "modelbiasjobdefinitions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ModelBiasJobDefinitionList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ModelBiasJobDefinition objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ModelBiasJobDefinition> Items { get; set; }
}

/// <summary>Configuration for the cluster used to run model monitoring jobs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelBiasJobDefinitionSpecJobResourcesClusterConfig
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
public partial class V1alpha1ModelBiasJobDefinitionSpecJobResources
{
    /// <summary>Configuration for the cluster used to run model monitoring jobs.</summary>
    [JsonPropertyName("clusterConfig")]
    public V1alpha1ModelBiasJobDefinitionSpecJobResourcesClusterConfig? ClusterConfig { get; set; }
}

/// <summary>Configures the model bias job to run a specified Docker container image.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelBiasJobDefinitionSpecModelBiasAppSpecification
{
    [JsonPropertyName("configURI")]
    public string? ConfigURI { get; set; }

    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    [JsonPropertyName("imageURI")]
    public string? ImageURI { get; set; }
}

/// <summary>The constraints resource for a monitoring job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelBiasJobDefinitionSpecModelBiasBaselineConfigConstraintsResource
{
    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>The baseline configuration for a model bias job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelBiasJobDefinitionSpecModelBiasBaselineConfig
{
    [JsonPropertyName("baseliningJobName")]
    public string? BaseliningJobName { get; set; }

    /// <summary>The constraints resource for a monitoring job.</summary>
    [JsonPropertyName("constraintsResource")]
    public V1alpha1ModelBiasJobDefinitionSpecModelBiasBaselineConfigConstraintsResource? ConstraintsResource { get; set; }
}

/// <summary>Input object for the endpoint</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelBiasJobDefinitionSpecModelBiasJobInputEndpointInput
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

/// <summary>The ground truth labels for the dataset used for the monitoring job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelBiasJobDefinitionSpecModelBiasJobInputGroundTruthS3Input
{
    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Inputs for the model bias job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelBiasJobDefinitionSpecModelBiasJobInput
{
    /// <summary>Input object for the endpoint</summary>
    [JsonPropertyName("endpointInput")]
    public V1alpha1ModelBiasJobDefinitionSpecModelBiasJobInputEndpointInput? EndpointInput { get; set; }

    /// <summary>The ground truth labels for the dataset used for the monitoring job.</summary>
    [JsonPropertyName("groundTruthS3Input")]
    public V1alpha1ModelBiasJobDefinitionSpecModelBiasJobInputGroundTruthS3Input? GroundTruthS3Input { get; set; }
}

/// <summary>
/// Information about where and how you want to store the results of a monitoring
/// job.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelBiasJobDefinitionSpecModelBiasJobOutputConfigMonitoringOutputsS3Output
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
public partial class V1alpha1ModelBiasJobDefinitionSpecModelBiasJobOutputConfigMonitoringOutputs
{
    /// <summary>
    /// Information about where and how you want to store the results of a monitoring
    /// job.
    /// </summary>
    [JsonPropertyName("s3Output")]
    public V1alpha1ModelBiasJobDefinitionSpecModelBiasJobOutputConfigMonitoringOutputsS3Output? S3Output { get; set; }
}

/// <summary>The output configuration for monitoring jobs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelBiasJobDefinitionSpecModelBiasJobOutputConfig
{
    [JsonPropertyName("kmsKeyID")]
    public string? KmsKeyID { get; set; }

    [JsonPropertyName("monitoringOutputs")]
    public IList<V1alpha1ModelBiasJobDefinitionSpecModelBiasJobOutputConfigMonitoringOutputs>? MonitoringOutputs { get; set; }
}

/// <summary>
/// Specifies an Amazon Virtual Private Cloud (VPC) that your SageMaker jobs,
/// hosted models, and compute resources have access to. You can control access
/// to and from your resources by configuring a VPC. For more information, see
/// Give SageMaker Access to Resources in your Amazon VPC (https://docs.aws.amazon.com/sagemaker/latest/dg/infrastructure-give-access.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelBiasJobDefinitionSpecNetworkConfigVpcConfig
{
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>Networking options for a model bias job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelBiasJobDefinitionSpecNetworkConfig
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
    public V1alpha1ModelBiasJobDefinitionSpecNetworkConfigVpcConfig? VpcConfig { get; set; }
}

/// <summary>A time limit for how long the monitoring job is allowed to run before stopping.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelBiasJobDefinitionSpecStoppingCondition
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
public partial class V1alpha1ModelBiasJobDefinitionSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>ModelBiasJobDefinitionSpec defines the desired state of ModelBiasJobDefinition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelBiasJobDefinitionSpec
{
    /// <summary>
    /// The name of the bias job definition. The name must be unique within an Amazon
    /// Web Services Region in the Amazon Web Services account.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$`
    /// </summary>
    [JsonPropertyName("jobDefinitionName")]
    public required string JobDefinitionName { get; set; }

    /// <summary>Identifies the resources to deploy for a monitoring job.</summary>
    [JsonPropertyName("jobResources")]
    public required V1alpha1ModelBiasJobDefinitionSpecJobResources JobResources { get; set; }

    /// <summary>Configures the model bias job to run a specified Docker container image.</summary>
    [JsonPropertyName("modelBiasAppSpecification")]
    public required V1alpha1ModelBiasJobDefinitionSpecModelBiasAppSpecification ModelBiasAppSpecification { get; set; }

    /// <summary>The baseline configuration for a model bias job.</summary>
    [JsonPropertyName("modelBiasBaselineConfig")]
    public V1alpha1ModelBiasJobDefinitionSpecModelBiasBaselineConfig? ModelBiasBaselineConfig { get; set; }

    /// <summary>Inputs for the model bias job.</summary>
    [JsonPropertyName("modelBiasJobInput")]
    public required V1alpha1ModelBiasJobDefinitionSpecModelBiasJobInput ModelBiasJobInput { get; set; }

    /// <summary>The output configuration for monitoring jobs.</summary>
    [JsonPropertyName("modelBiasJobOutputConfig")]
    public required V1alpha1ModelBiasJobDefinitionSpecModelBiasJobOutputConfig ModelBiasJobOutputConfig { get; set; }

    /// <summary>Networking options for a model bias job.</summary>
    [JsonPropertyName("networkConfig")]
    public V1alpha1ModelBiasJobDefinitionSpecNetworkConfig? NetworkConfig { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker AI can
    /// assume to perform tasks on your behalf.
    /// 
    /// Regex Pattern: `^arn:aws[a-z\-]*:iam::\d{12}:role/?[a-zA-Z_0-9+=,.@\-_/]+$`
    /// </summary>
    [JsonPropertyName("roleARN")]
    public required string RoleARN { get; set; }

    /// <summary>A time limit for how long the monitoring job is allowed to run before stopping.</summary>
    [JsonPropertyName("stoppingCondition")]
    public V1alpha1ModelBiasJobDefinitionSpecStoppingCondition? StoppingCondition { get; set; }

    /// <summary>
    /// (Optional) An array of key-value pairs. For more information, see Using Cost
    /// Allocation Tags (https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-whatURL)
    /// in the Amazon Web Services Billing and Cost Management User Guide.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ModelBiasJobDefinitionSpecTags>? Tags { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelBiasJobDefinitionStatusAckResourceMetadata
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
public partial class V1alpha1ModelBiasJobDefinitionStatusConditions
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

/// <summary>ModelBiasJobDefinitionStatus defines the observed state of ModelBiasJobDefinition</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelBiasJobDefinitionStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ModelBiasJobDefinitionStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ModelBiasJobDefinitionStatusConditions>? Conditions { get; set; }
}

/// <summary>ModelBiasJobDefinition is the Schema for the ModelBiasJobDefinitions API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ModelBiasJobDefinition : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ModelBiasJobDefinitionSpec?>, IStatus<V1alpha1ModelBiasJobDefinitionStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ModelBiasJobDefinition";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "modelbiasjobdefinitions";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ModelBiasJobDefinition";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ModelBiasJobDefinitionSpec defines the desired state of ModelBiasJobDefinition.</summary>
    [JsonPropertyName("spec")]
    public V1alpha1ModelBiasJobDefinitionSpec? Spec { get; set; }

    /// <summary>ModelBiasJobDefinitionStatus defines the observed state of ModelBiasJobDefinition</summary>
    [JsonPropertyName("status")]
    public V1alpha1ModelBiasJobDefinitionStatus? Status { get; set; }
}