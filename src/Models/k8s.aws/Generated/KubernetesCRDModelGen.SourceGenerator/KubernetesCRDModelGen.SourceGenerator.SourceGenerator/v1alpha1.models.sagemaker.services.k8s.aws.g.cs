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
/// <summary>Model is the Schema for the Models API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ModelList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1Model>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ModelList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "models";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ModelList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1Model objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1Model> Items { get; set; }
}

/// <summary>
/// Specifies an authentication configuration for the private docker registry
/// where your model image is hosted. Specify a value for this property only
/// if you specified Vpc as the value for the RepositoryAccessMode field of the
/// ImageConfig object that you passed to a call to CreateModel and the private
/// Docker registry where the model image is hosted requires authentication.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelSpecContainersImageConfigRepositoryAuthConfig
{
    [JsonPropertyName("repositoryCredentialsProviderARN")]
    public string? RepositoryCredentialsProviderARN { get; set; }
}

/// <summary>
/// Specifies whether the model container is in Amazon ECR or a private Docker
/// registry accessible from your Amazon Virtual Private Cloud (VPC).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelSpecContainersImageConfig
{
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>
    /// Specifies an authentication configuration for the private docker registry
    /// where your model image is hosted. Specify a value for this property only
    /// if you specified Vpc as the value for the RepositoryAccessMode field of the
    /// ImageConfig object that you passed to a call to CreateModel and the private
    /// Docker registry where the model image is hosted requires authentication.
    /// </summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public V1alpha1ModelSpecContainersImageConfigRepositoryAuthConfig? RepositoryAuthConfig { get; set; }
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
public partial class V1alpha1ModelSpecContainersModelDataSourceS3DataSourceModelAccessConfig
{
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

/// <summary>Specifies the S3 location of ML model data to deploy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelSpecContainersModelDataSourceS3DataSource
{
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

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
    public V1alpha1ModelSpecContainersModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>
/// Specifies the location of ML model data to deploy. If specified, you must
/// specify one and only one of the available data sources.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelSpecContainersModelDataSource
{
    /// <summary>Specifies the S3 location of ML model data to deploy.</summary>
    [JsonPropertyName("s3DataSource")]
    public V1alpha1ModelSpecContainersModelDataSourceS3DataSource? S3DataSource { get; set; }
}

/// <summary>Specifies additional configuration for hosting multi-model endpoints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelSpecContainersMultiModelConfig
{
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

/// <summary>Describes the container, as part of model definition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelSpecContainers
{
    [JsonPropertyName("containerHostname")]
    public string? ContainerHostname { get; set; }

    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// Specifies whether the model container is in Amazon ECR or a private Docker
    /// registry accessible from your Amazon Virtual Private Cloud (VPC).
    /// </summary>
    [JsonPropertyName("imageConfig")]
    public V1alpha1ModelSpecContainersImageConfig? ImageConfig { get; set; }

    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Specifies the location of ML model data to deploy. If specified, you must
    /// specify one and only one of the available data sources.
    /// </summary>
    [JsonPropertyName("modelDataSource")]
    public V1alpha1ModelSpecContainersModelDataSource? ModelDataSource { get; set; }

    [JsonPropertyName("modelDataURL")]
    public string? ModelDataURL { get; set; }

    [JsonPropertyName("modelPackageName")]
    public string? ModelPackageName { get; set; }

    /// <summary>Specifies additional configuration for hosting multi-model endpoints.</summary>
    [JsonPropertyName("multiModelConfig")]
    public V1alpha1ModelSpecContainersMultiModelConfig? MultiModelConfig { get; set; }
}

/// <summary>Specifies details of how containers in a multi-container endpoint are called.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelSpecInferenceExecutionConfig
{
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Specifies an authentication configuration for the private docker registry
/// where your model image is hosted. Specify a value for this property only
/// if you specified Vpc as the value for the RepositoryAccessMode field of the
/// ImageConfig object that you passed to a call to CreateModel and the private
/// Docker registry where the model image is hosted requires authentication.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelSpecPrimaryContainerImageConfigRepositoryAuthConfig
{
    [JsonPropertyName("repositoryCredentialsProviderARN")]
    public string? RepositoryCredentialsProviderARN { get; set; }
}

/// <summary>
/// Specifies whether the model container is in Amazon ECR or a private Docker
/// registry accessible from your Amazon Virtual Private Cloud (VPC).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelSpecPrimaryContainerImageConfig
{
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>
    /// Specifies an authentication configuration for the private docker registry
    /// where your model image is hosted. Specify a value for this property only
    /// if you specified Vpc as the value for the RepositoryAccessMode field of the
    /// ImageConfig object that you passed to a call to CreateModel and the private
    /// Docker registry where the model image is hosted requires authentication.
    /// </summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public V1alpha1ModelSpecPrimaryContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfig { get; set; }
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
public partial class V1alpha1ModelSpecPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig
{
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

/// <summary>Specifies the S3 location of ML model data to deploy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelSpecPrimaryContainerModelDataSourceS3DataSource
{
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

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
    public V1alpha1ModelSpecPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>
/// Specifies the location of ML model data to deploy. If specified, you must
/// specify one and only one of the available data sources.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelSpecPrimaryContainerModelDataSource
{
    /// <summary>Specifies the S3 location of ML model data to deploy.</summary>
    [JsonPropertyName("s3DataSource")]
    public V1alpha1ModelSpecPrimaryContainerModelDataSourceS3DataSource? S3DataSource { get; set; }
}

/// <summary>Specifies additional configuration for hosting multi-model endpoints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelSpecPrimaryContainerMultiModelConfig
{
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

/// <summary>
/// The location of the primary docker image containing inference code, associated
/// artifacts, and custom environment map that the inference code uses when the
/// model is deployed for predictions.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelSpecPrimaryContainer
{
    [JsonPropertyName("containerHostname")]
    public string? ContainerHostname { get; set; }

    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>
    /// Specifies whether the model container is in Amazon ECR or a private Docker
    /// registry accessible from your Amazon Virtual Private Cloud (VPC).
    /// </summary>
    [JsonPropertyName("imageConfig")]
    public V1alpha1ModelSpecPrimaryContainerImageConfig? ImageConfig { get; set; }

    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Specifies the location of ML model data to deploy. If specified, you must
    /// specify one and only one of the available data sources.
    /// </summary>
    [JsonPropertyName("modelDataSource")]
    public V1alpha1ModelSpecPrimaryContainerModelDataSource? ModelDataSource { get; set; }

    [JsonPropertyName("modelDataURL")]
    public string? ModelDataURL { get; set; }

    [JsonPropertyName("modelPackageName")]
    public string? ModelPackageName { get; set; }

    /// <summary>Specifies additional configuration for hosting multi-model endpoints.</summary>
    [JsonPropertyName("multiModelConfig")]
    public V1alpha1ModelSpecPrimaryContainerMultiModelConfig? MultiModelConfig { get; set; }
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
public partial class V1alpha1ModelSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// A VpcConfig (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_VpcConfig.html)
/// object that specifies the VPC that you want your model to connect to. Control
/// access to and from your model container by configuring the VPC. VpcConfig
/// is used in hosting services and in batch transform. For more information,
/// see Protect Endpoints by Using an Amazon Virtual Private Cloud (https://docs.aws.amazon.com/sagemaker/latest/dg/host-vpc.html)
/// and Protect Data in Batch Transform Jobs by Using an Amazon Virtual Private
/// Cloud (https://docs.aws.amazon.com/sagemaker/latest/dg/batch-vpc.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelSpecVpcConfig
{
    [JsonPropertyName("securityGroupIDs")]
    public IList<string>? SecurityGroupIDs { get; set; }

    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>
/// ModelSpec defines the desired state of Model.
/// 
/// The properties of a model as returned by the Search (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_Search.html)
/// API.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelSpec
{
    /// <summary>Specifies the containers in the inference pipeline.</summary>
    [JsonPropertyName("containers")]
    public IList<V1alpha1ModelSpecContainers>? Containers { get; set; }

    /// <summary>
    /// Isolates the model container. No inbound or outbound network calls can be
    /// made to or from the model container.
    /// </summary>
    [JsonPropertyName("enableNetworkIsolation")]
    public bool? EnableNetworkIsolation { get; set; }

    /// <summary>
    /// The Amazon Resource Name (ARN) of the IAM role that SageMaker can assume
    /// to access model artifacts and docker image for deployment on ML compute instances
    /// or for batch transform jobs. Deploying on ML compute instances is part of
    /// model hosting. For more information, see SageMaker Roles (https://docs.aws.amazon.com/sagemaker/latest/dg/sagemaker-roles.html).
    /// 
    /// To be able to pass this role to SageMaker, the caller of this API must have
    /// the iam:PassRole permission.
    /// 
    /// Regex Pattern: `^arn:aws[a-z\-]*:iam::\d{12}:role/?[a-zA-Z_0-9+=,.@\-_/]+$`
    /// </summary>
    [JsonPropertyName("executionRoleARN")]
    public string? ExecutionRoleARN { get; set; }

    /// <summary>Specifies details of how containers in a multi-container endpoint are called.</summary>
    [JsonPropertyName("inferenceExecutionConfig")]
    public V1alpha1ModelSpecInferenceExecutionConfig? InferenceExecutionConfig { get; set; }

    /// <summary>
    /// The name of the new model.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9]([\-a-zA-Z0-9]*[a-zA-Z0-9])?$`
    /// </summary>
    [JsonPropertyName("modelName")]
    public required string ModelName { get; set; }

    /// <summary>
    /// The location of the primary docker image containing inference code, associated
    /// artifacts, and custom environment map that the inference code uses when the
    /// model is deployed for predictions.
    /// </summary>
    [JsonPropertyName("primaryContainer")]
    public V1alpha1ModelSpecPrimaryContainer? PrimaryContainer { get; set; }

    /// <summary>
    /// An array of key-value pairs. You can use tags to categorize your Amazon Web
    /// Services resources in different ways, for example, by purpose, owner, or
    /// environment. For more information, see Tagging Amazon Web Services Resources
    /// (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html).
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ModelSpecTags>? Tags { get; set; }

    /// <summary>
    /// A VpcConfig (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_VpcConfig.html)
    /// object that specifies the VPC that you want your model to connect to. Control
    /// access to and from your model container by configuring the VPC. VpcConfig
    /// is used in hosting services and in batch transform. For more information,
    /// see Protect Endpoints by Using an Amazon Virtual Private Cloud (https://docs.aws.amazon.com/sagemaker/latest/dg/host-vpc.html)
    /// and Protect Data in Batch Transform Jobs by Using an Amazon Virtual Private
    /// Cloud (https://docs.aws.amazon.com/sagemaker/latest/dg/batch-vpc.html).
    /// </summary>
    [JsonPropertyName("vpcConfig")]
    public V1alpha1ModelSpecVpcConfig? VpcConfig { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelStatusAckResourceMetadata
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
public partial class V1alpha1ModelStatusConditions
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

/// <summary>ModelStatus defines the observed state of Model</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ModelStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ModelStatusConditions>? Conditions { get; set; }
}

/// <summary>Model is the Schema for the Models API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.10+a22b941414add0bcc94c90de54d985f643c33be0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1Model : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ModelSpec?>, IStatus<V1alpha1ModelStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "Model";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "models";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Model";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ModelSpec defines the desired state of Model.
    /// 
    /// The properties of a model as returned by the Search (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_Search.html)
    /// API.
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ModelSpec? Spec { get; set; }

    /// <summary>ModelStatus defines the observed state of Model</summary>
    [JsonPropertyName("status")]
    public V1alpha1ModelStatus? Status { get; set; }
}