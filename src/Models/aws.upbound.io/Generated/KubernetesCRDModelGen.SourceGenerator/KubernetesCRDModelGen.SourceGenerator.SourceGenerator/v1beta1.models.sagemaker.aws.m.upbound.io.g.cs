#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.aws.m.upbound.io;
/// <summary>Model is the Schema for the Models API. Manages an Amazon SageMaker AI Model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1ModelList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Model>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "ModelList";
    public const string KubeGroup = "sagemaker.aws.m.upbound.io";
    public const string KubePluralName = "models";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ModelList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Model objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Model> Items { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderContainerAdditionalModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta1ModelSpecForProviderContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderContainerAdditionalModelDataSource
{
    /// <summary>Custom name for the additional model data source object. It will be stored in /opt/ml/additional-model-data-sources/&lt;channel_name&gt;/.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelSpecForProviderContainerAdditionalModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderContainerImageConfigRepositoryAuthConfig
{
    /// <summary>Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public V1beta1ModelSpecForProviderContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfig { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta1ModelSpecForProviderContainerModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderContainerModelDataSource
{
    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelSpecForProviderContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderContainer
{
    /// <summary>Additional data sources that are available to the model in addition to those specified in model_data_source. See Additional Model Data Source.</summary>
    [JsonPropertyName("additionalModelDataSource")]
    public IList<V1beta1ModelSpecForProviderContainerAdditionalModelDataSource>? AdditionalModelDataSource { get; set; }

    /// <summary>DNS host name for the container.</summary>
    [JsonPropertyName("containerHostname")]
    public string? ContainerHostname { get; set; }

    /// <summary>Environment variables for the Docker container.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>Registry path where the inference code image is stored in Amazon ECR.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
    [JsonPropertyName("imageConfig")]
    public V1beta1ModelSpecForProviderContainerImageConfig? ImageConfig { get; set; }

    /// <summary>Inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public V1beta1ModelSpecForProviderContainerModelDataSource? ModelDataSource { get; set; }

    /// <summary>URL for the S3 location where model artifacts are stored.</summary>
    [JsonPropertyName("modelDataUrl")]
    public string? ModelDataUrl { get; set; }

    /// <summary>
    /// Amazon Resource Name (ARN) of the model package to use to create the model.
    /// A list of key value pairs.
    /// </summary>
    [JsonPropertyName("modelPackageName")]
    public string? ModelPackageName { get; set; }

    /// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
    [JsonPropertyName("multiModelConfig")]
    public V1beta1ModelSpecForProviderContainerMultiModelConfig? MultiModelConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ModelSpecForProviderExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1ModelSpecForProviderExecutionRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ModelSpecForProviderExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta1ModelSpecForProviderExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ModelSpecForProviderExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ModelSpecForProviderExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ModelSpecForProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ModelSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ModelSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ModelSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1ModelSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ModelSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ModelSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderExecutionRoleArnSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ModelSpecForProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies details of how containers in a multi-container endpoint are called. See Inference Execution Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderInferenceExecutionConfig
{
    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderPrimaryContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderPrimaryContainerAdditionalModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta1ModelSpecForProviderPrimaryContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderPrimaryContainerAdditionalModelDataSource
{
    /// <summary>Custom name for the additional model data source object. It will be stored in /opt/ml/additional-model-data-sources/&lt;channel_name&gt;/.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelSpecForProviderPrimaryContainerAdditionalModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderPrimaryContainerImageConfigRepositoryAuthConfig
{
    /// <summary>Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderPrimaryContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public V1beta1ModelSpecForProviderPrimaryContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfig { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderPrimaryContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta1ModelSpecForProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderPrimaryContainerModelDataSource
{
    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelSpecForProviderPrimaryContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderPrimaryContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

/// <summary>Primary docker image containing inference code that is used when the model is deployed for predictions.  If not specified, the container argument is required. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderPrimaryContainer
{
    /// <summary>Additional data sources that are available to the model in addition to those specified in model_data_source. See Additional Model Data Source.</summary>
    [JsonPropertyName("additionalModelDataSource")]
    public IList<V1beta1ModelSpecForProviderPrimaryContainerAdditionalModelDataSource>? AdditionalModelDataSource { get; set; }

    /// <summary>DNS host name for the container.</summary>
    [JsonPropertyName("containerHostname")]
    public string? ContainerHostname { get; set; }

    /// <summary>Environment variables for the Docker container.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>Registry path where the inference code image is stored in Amazon ECR.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
    [JsonPropertyName("imageConfig")]
    public V1beta1ModelSpecForProviderPrimaryContainerImageConfig? ImageConfig { get; set; }

    /// <summary>Inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public V1beta1ModelSpecForProviderPrimaryContainerModelDataSource? ModelDataSource { get; set; }

    /// <summary>URL for the S3 location where model artifacts are stored.</summary>
    [JsonPropertyName("modelDataUrl")]
    public string? ModelDataUrl { get; set; }

    /// <summary>
    /// Amazon Resource Name (ARN) of the model package to use to create the model.
    /// A list of key value pairs.
    /// </summary>
    [JsonPropertyName("modelPackageName")]
    public string? ModelPackageName { get; set; }

    /// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
    [JsonPropertyName("multiModelConfig")]
    public V1beta1ModelSpecForProviderPrimaryContainerMultiModelConfig? MultiModelConfig { get; set; }
}

/// <summary>Specifies the VPC that you want your model to connect to. This configuration is used in hosting services and in batch transform. See VPC Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProviderVpcConfig
{
    /// <summary>List of security group IDs you want to be applied to your training job or model. Specify the security groups for the VPC that is specified in the Subnets field.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>List of subnet IDs in the VPC to which you want to connect your training job or model.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecForProvider
{
    /// <summary>Specifies containers in the inference pipeline. If not specified, the primary_container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta1ModelSpecForProviderContainer>? Container { get; set; }

    /// <summary>Isolates the model container. No inbound or outbound network calls can be made to or from the model container.</summary>
    [JsonPropertyName("enableNetworkIsolation")]
    public bool? EnableNetworkIsolation { get; set; }

    /// <summary>A role that SageMaker AI can assume to access model artifacts and docker images for deployment.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta1ModelSpecForProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta1ModelSpecForProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>Specifies details of how containers in a multi-container endpoint are called. See Inference Execution Config.</summary>
    [JsonPropertyName("inferenceExecutionConfig")]
    public V1beta1ModelSpecForProviderInferenceExecutionConfig? InferenceExecutionConfig { get; set; }

    /// <summary>Primary docker image containing inference code that is used when the model is deployed for predictions.  If not specified, the container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("primaryContainer")]
    public V1beta1ModelSpecForProviderPrimaryContainer? PrimaryContainer { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the VPC that you want your model to connect to. This configuration is used in hosting services and in batch transform. See VPC Config.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1ModelSpecForProviderVpcConfig? VpcConfig { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderContainerAdditionalModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta1ModelSpecInitProviderContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderContainerAdditionalModelDataSource
{
    /// <summary>Custom name for the additional model data source object. It will be stored in /opt/ml/additional-model-data-sources/&lt;channel_name&gt;/.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelSpecInitProviderContainerAdditionalModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderContainerImageConfigRepositoryAuthConfig
{
    /// <summary>Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public V1beta1ModelSpecInitProviderContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfig { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta1ModelSpecInitProviderContainerModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderContainerModelDataSource
{
    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelSpecInitProviderContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderContainer
{
    /// <summary>Additional data sources that are available to the model in addition to those specified in model_data_source. See Additional Model Data Source.</summary>
    [JsonPropertyName("additionalModelDataSource")]
    public IList<V1beta1ModelSpecInitProviderContainerAdditionalModelDataSource>? AdditionalModelDataSource { get; set; }

    /// <summary>DNS host name for the container.</summary>
    [JsonPropertyName("containerHostname")]
    public string? ContainerHostname { get; set; }

    /// <summary>Environment variables for the Docker container.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>Registry path where the inference code image is stored in Amazon ECR.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
    [JsonPropertyName("imageConfig")]
    public V1beta1ModelSpecInitProviderContainerImageConfig? ImageConfig { get; set; }

    /// <summary>Inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public V1beta1ModelSpecInitProviderContainerModelDataSource? ModelDataSource { get; set; }

    /// <summary>URL for the S3 location where model artifacts are stored.</summary>
    [JsonPropertyName("modelDataUrl")]
    public string? ModelDataUrl { get; set; }

    /// <summary>
    /// Amazon Resource Name (ARN) of the model package to use to create the model.
    /// A list of key value pairs.
    /// </summary>
    [JsonPropertyName("modelPackageName")]
    public string? ModelPackageName { get; set; }

    /// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
    [JsonPropertyName("multiModelConfig")]
    public V1beta1ModelSpecInitProviderContainerMultiModelConfig? MultiModelConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ModelSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1ModelSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ModelSpecInitProviderExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta1ModelSpecInitProviderExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ModelSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ModelSpecInitProviderExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ModelSpecInitProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ModelSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1ModelSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum
{
    [EnumMember(Value = "Required"), JsonStringEnumMemberName("Required")]
    Required,
    [EnumMember(Value = "Optional"), JsonStringEnumMemberName("Optional")]
    Optional
}

/// <summary>
/// Resolve specifies when this reference should be resolved. The default
/// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
/// the corresponding field is not present. Use &apos;Always&apos; to resolve the
/// reference on every reconcile.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ModelSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1ModelSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1ModelSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1ModelSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderExecutionRoleArnSelector
{
    /// <summary>
    /// MatchControllerRef ensures an object with the same controller reference
    /// as the selecting object is selected.
    /// </summary>
    [JsonPropertyName("matchControllerRef")]
    public bool? MatchControllerRef { get; set; }

    /// <summary>MatchLabels ensures an object with matching labels is selected.</summary>
    [JsonPropertyName("matchLabels")]
    public IDictionary<string, string>? MatchLabels { get; set; }

    /// <summary>Namespace for the selector</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta1ModelSpecInitProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies details of how containers in a multi-container endpoint are called. See Inference Execution Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderInferenceExecutionConfig
{
    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderPrimaryContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderPrimaryContainerAdditionalModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta1ModelSpecInitProviderPrimaryContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderPrimaryContainerAdditionalModelDataSource
{
    /// <summary>Custom name for the additional model data source object. It will be stored in /opt/ml/additional-model-data-sources/&lt;channel_name&gt;/.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelSpecInitProviderPrimaryContainerAdditionalModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderPrimaryContainerImageConfigRepositoryAuthConfig
{
    /// <summary>Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderPrimaryContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public V1beta1ModelSpecInitProviderPrimaryContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfig { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderPrimaryContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta1ModelSpecInitProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderPrimaryContainerModelDataSource
{
    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelSpecInitProviderPrimaryContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderPrimaryContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

/// <summary>Primary docker image containing inference code that is used when the model is deployed for predictions.  If not specified, the container argument is required. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderPrimaryContainer
{
    /// <summary>Additional data sources that are available to the model in addition to those specified in model_data_source. See Additional Model Data Source.</summary>
    [JsonPropertyName("additionalModelDataSource")]
    public IList<V1beta1ModelSpecInitProviderPrimaryContainerAdditionalModelDataSource>? AdditionalModelDataSource { get; set; }

    /// <summary>DNS host name for the container.</summary>
    [JsonPropertyName("containerHostname")]
    public string? ContainerHostname { get; set; }

    /// <summary>Environment variables for the Docker container.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>Registry path where the inference code image is stored in Amazon ECR.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
    [JsonPropertyName("imageConfig")]
    public V1beta1ModelSpecInitProviderPrimaryContainerImageConfig? ImageConfig { get; set; }

    /// <summary>Inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public V1beta1ModelSpecInitProviderPrimaryContainerModelDataSource? ModelDataSource { get; set; }

    /// <summary>URL for the S3 location where model artifacts are stored.</summary>
    [JsonPropertyName("modelDataUrl")]
    public string? ModelDataUrl { get; set; }

    /// <summary>
    /// Amazon Resource Name (ARN) of the model package to use to create the model.
    /// A list of key value pairs.
    /// </summary>
    [JsonPropertyName("modelPackageName")]
    public string? ModelPackageName { get; set; }

    /// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
    [JsonPropertyName("multiModelConfig")]
    public V1beta1ModelSpecInitProviderPrimaryContainerMultiModelConfig? MultiModelConfig { get; set; }
}

/// <summary>Specifies the VPC that you want your model to connect to. This configuration is used in hosting services and in batch transform. See VPC Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProviderVpcConfig
{
    /// <summary>List of security group IDs you want to be applied to your training job or model. Specify the security groups for the VPC that is specified in the Subnets field.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>List of subnet IDs in the VPC to which you want to connect your training job or model.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

/// <summary>
/// THIS IS A BETA FIELD. It will be honored
/// unless the Management Policies feature flag is disabled.
/// InitProvider holds the same fields as ForProvider, with the exception
/// of Identifier and other resource reference fields. The fields that are
/// in InitProvider are merged into ForProvider when the resource is created.
/// The same fields are also added to the terraform ignore_changes hook, to
/// avoid updating them after creation. This is useful for fields that are
/// required on creation, but we do not desire to update them after creation,
/// for example because of an external controller is managing them, like an
/// autoscaler.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecInitProvider
{
    /// <summary>Specifies containers in the inference pipeline. If not specified, the primary_container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta1ModelSpecInitProviderContainer>? Container { get; set; }

    /// <summary>Isolates the model container. No inbound or outbound network calls can be made to or from the model container.</summary>
    [JsonPropertyName("enableNetworkIsolation")]
    public bool? EnableNetworkIsolation { get; set; }

    /// <summary>A role that SageMaker AI can assume to access model artifacts and docker images for deployment.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta1ModelSpecInitProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta1ModelSpecInitProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>Specifies details of how containers in a multi-container endpoint are called. See Inference Execution Config.</summary>
    [JsonPropertyName("inferenceExecutionConfig")]
    public V1beta1ModelSpecInitProviderInferenceExecutionConfig? InferenceExecutionConfig { get; set; }

    /// <summary>Primary docker image containing inference code that is used when the model is deployed for predictions.  If not specified, the container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("primaryContainer")]
    public V1beta1ModelSpecInitProviderPrimaryContainer? PrimaryContainer { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the VPC that you want your model to connect to. This configuration is used in hosting services and in batch transform. See VPC Config.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1ModelSpecInitProviderVpcConfig? VpcConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1ModelSpecManagementPoliciesEnum>))]
public enum V1beta1ModelSpecManagementPoliciesEnum
{
    [EnumMember(Value = "Observe"), JsonStringEnumMemberName("Observe")]
    Observe,
    [EnumMember(Value = "Create"), JsonStringEnumMemberName("Create")]
    Create,
    [EnumMember(Value = "Update"), JsonStringEnumMemberName("Update")]
    Update,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete,
    [EnumMember(Value = "LateInitialize"), JsonStringEnumMemberName("LateInitialize")]
    LateInitialize,
    [EnumMember(Value = "*"), JsonStringEnumMemberName("*")]
    Option5
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecProviderConfigRef
{
    /// <summary>Kind of the referenced object.</summary>
    [JsonPropertyName("kind")]
    public required string Kind { get; set; }

    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>ModelSpec defines the desired state of Model</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1ModelSpecForProvider ForProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It will be honored
    /// unless the Management Policies feature flag is disabled.
    /// InitProvider holds the same fields as ForProvider, with the exception
    /// of Identifier and other resource reference fields. The fields that are
    /// in InitProvider are merged into ForProvider when the resource is created.
    /// The same fields are also added to the terraform ignore_changes hook, to
    /// avoid updating them after creation. This is useful for fields that are
    /// required on creation, but we do not desire to update them after creation,
    /// for example because of an external controller is managing them, like an
    /// autoscaler.
    /// </summary>
    [JsonPropertyName("initProvider")]
    public V1beta1ModelSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1ModelSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1ModelSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1ModelSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderContainerAdditionalModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta1ModelStatusAtProviderContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderContainerAdditionalModelDataSource
{
    /// <summary>Custom name for the additional model data source object. It will be stored in /opt/ml/additional-model-data-sources/&lt;channel_name&gt;/.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelStatusAtProviderContainerAdditionalModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderContainerImageConfigRepositoryAuthConfig
{
    /// <summary>Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public V1beta1ModelStatusAtProviderContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfig { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta1ModelStatusAtProviderContainerModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderContainerModelDataSource
{
    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelStatusAtProviderContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderContainer
{
    /// <summary>Additional data sources that are available to the model in addition to those specified in model_data_source. See Additional Model Data Source.</summary>
    [JsonPropertyName("additionalModelDataSource")]
    public IList<V1beta1ModelStatusAtProviderContainerAdditionalModelDataSource>? AdditionalModelDataSource { get; set; }

    /// <summary>DNS host name for the container.</summary>
    [JsonPropertyName("containerHostname")]
    public string? ContainerHostname { get; set; }

    /// <summary>Environment variables for the Docker container.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>Registry path where the inference code image is stored in Amazon ECR.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
    [JsonPropertyName("imageConfig")]
    public V1beta1ModelStatusAtProviderContainerImageConfig? ImageConfig { get; set; }

    /// <summary>Inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public V1beta1ModelStatusAtProviderContainerModelDataSource? ModelDataSource { get; set; }

    /// <summary>URL for the S3 location where model artifacts are stored.</summary>
    [JsonPropertyName("modelDataUrl")]
    public string? ModelDataUrl { get; set; }

    /// <summary>
    /// Amazon Resource Name (ARN) of the model package to use to create the model.
    /// A list of key value pairs.
    /// </summary>
    [JsonPropertyName("modelPackageName")]
    public string? ModelPackageName { get; set; }

    /// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
    [JsonPropertyName("multiModelConfig")]
    public V1beta1ModelStatusAtProviderContainerMultiModelConfig? MultiModelConfig { get; set; }
}

/// <summary>Specifies details of how containers in a multi-container endpoint are called. See Inference Execution Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderInferenceExecutionConfig
{
    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderPrimaryContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderPrimaryContainerAdditionalModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta1ModelStatusAtProviderPrimaryContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderPrimaryContainerAdditionalModelDataSource
{
    /// <summary>Custom name for the additional model data source object. It will be stored in /opt/ml/additional-model-data-sources/&lt;channel_name&gt;/.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelStatusAtProviderPrimaryContainerAdditionalModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderPrimaryContainerImageConfigRepositoryAuthConfig
{
    /// <summary>Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderPrimaryContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public V1beta1ModelStatusAtProviderPrimaryContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfig { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderPrimaryContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta1ModelStatusAtProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

/// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderPrimaryContainerModelDataSource
{
    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta1ModelStatusAtProviderPrimaryContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderPrimaryContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

/// <summary>Primary docker image containing inference code that is used when the model is deployed for predictions.  If not specified, the container argument is required. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderPrimaryContainer
{
    /// <summary>Additional data sources that are available to the model in addition to those specified in model_data_source. See Additional Model Data Source.</summary>
    [JsonPropertyName("additionalModelDataSource")]
    public IList<V1beta1ModelStatusAtProviderPrimaryContainerAdditionalModelDataSource>? AdditionalModelDataSource { get; set; }

    /// <summary>DNS host name for the container.</summary>
    [JsonPropertyName("containerHostname")]
    public string? ContainerHostname { get; set; }

    /// <summary>Environment variables for the Docker container.</summary>
    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    /// <summary>Registry path where the inference code image is stored in Amazon ECR.</summary>
    [JsonPropertyName("image")]
    public string? Image { get; set; }

    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
    [JsonPropertyName("imageConfig")]
    public V1beta1ModelStatusAtProviderPrimaryContainerImageConfig? ImageConfig { get; set; }

    /// <summary>Inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public V1beta1ModelStatusAtProviderPrimaryContainerModelDataSource? ModelDataSource { get; set; }

    /// <summary>URL for the S3 location where model artifacts are stored.</summary>
    [JsonPropertyName("modelDataUrl")]
    public string? ModelDataUrl { get; set; }

    /// <summary>
    /// Amazon Resource Name (ARN) of the model package to use to create the model.
    /// A list of key value pairs.
    /// </summary>
    [JsonPropertyName("modelPackageName")]
    public string? ModelPackageName { get; set; }

    /// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
    [JsonPropertyName("multiModelConfig")]
    public V1beta1ModelStatusAtProviderPrimaryContainerMultiModelConfig? MultiModelConfig { get; set; }
}

/// <summary>Specifies the VPC that you want your model to connect to. This configuration is used in hosting services and in batch transform. See VPC Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProviderVpcConfig
{
    /// <summary>List of security group IDs you want to be applied to your training job or model. Specify the security groups for the VPC that is specified in the Subnets field.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>List of subnet IDs in the VPC to which you want to connect your training job or model.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) assigned by AWS to this model.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Specifies containers in the inference pipeline. If not specified, the primary_container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta1ModelStatusAtProviderContainer>? Container { get; set; }

    /// <summary>Isolates the model container. No inbound or outbound network calls can be made to or from the model container.</summary>
    [JsonPropertyName("enableNetworkIsolation")]
    public bool? EnableNetworkIsolation { get; set; }

    /// <summary>A role that SageMaker AI can assume to access model artifacts and docker images for deployment.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Specifies details of how containers in a multi-container endpoint are called. See Inference Execution Config.</summary>
    [JsonPropertyName("inferenceExecutionConfig")]
    public V1beta1ModelStatusAtProviderInferenceExecutionConfig? InferenceExecutionConfig { get; set; }

    /// <summary>Primary docker image containing inference code that is used when the model is deployed for predictions.  If not specified, the container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("primaryContainer")]
    public V1beta1ModelStatusAtProviderPrimaryContainer? PrimaryContainer { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Specifies the VPC that you want your model to connect to. This configuration is used in hosting services and in batch transform. See VPC Config.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta1ModelStatusAtProviderVpcConfig? VpcConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatusConditions
{
    /// <summary>
    /// LastTransitionTime is the last time this condition transitioned from one
    /// status to another.
    /// </summary>
    [JsonPropertyName("lastTransitionTime")]
    public required DateTime LastTransitionTime { get; set; }

    /// <summary>
    /// A Message containing details about this condition&apos;s last transition from
    /// one status to another, if any.
    /// </summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>
    /// ObservedGeneration represents the .metadata.generation that the condition was set based upon.
    /// For instance, if .metadata.generation is currently 12, but the .status.conditions[x].observedGeneration is 9, the condition is out of date
    /// with respect to the current state of the instance.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>A Reason for this condition&apos;s last transition from one status to another.</summary>
    [JsonPropertyName("reason")]
    public required string Reason { get; set; }

    /// <summary>Status of this condition; is it currently True, False, or Unknown?</summary>
    [JsonPropertyName("status")]
    public required string Status { get; set; }

    /// <summary>
    /// Type of this condition. At most one of each condition type may apply to
    /// a resource at any point in time.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }
}

/// <summary>ModelStatus defines the observed state of Model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1ModelStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1ModelStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1ModelStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Model is the Schema for the Models API. Manages an Amazon SageMaker AI Model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Model : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1ModelSpec>, IStatus<V1beta1ModelStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Model";
    public const string KubeGroup = "sagemaker.aws.m.upbound.io";
    public const string KubePluralName = "models";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Model";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ModelSpec defines the desired state of Model</summary>
    [JsonPropertyName("spec")]
    public required V1beta1ModelSpec Spec { get; set; }

    /// <summary>ModelStatus defines the observed state of Model.</summary>
    [JsonPropertyName("status")]
    public V1beta1ModelStatus? Status { get; set; }
}