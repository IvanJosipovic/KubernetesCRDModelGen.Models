#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.sagemaker.aws.upbound.io;
/// <summary>Model is the Schema for the Models API. Manages an Amazon SageMaker AI Model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ModelList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Model>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ModelList";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "models";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ModelList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Model objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Model> Items { get; set; }
}

/// <summary>
/// DeletionPolicy specifies what will happen to the underlying external
/// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
/// external resource.
/// This field is planned to be deprecated in favor of the ManagementPolicies
/// field in a future release. Currently, both could be set independently and
/// non-default values would be honored if the feature flag is enabled.
/// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ModelSpecDeletionPolicyEnum>))]
public enum V1beta2ModelSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderContainerAdditionalModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta2ModelSpecForProviderContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderContainerAdditionalModelDataSource
{
    /// <summary>Custom name for the additional model data source object. It will be stored in /opt/ml/additional-model-data-sources/&lt;channel_name&gt;/.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta2ModelSpecForProviderContainerAdditionalModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderContainerImageConfigRepositoryAuthConfig
{
    /// <summary>Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public V1beta2ModelSpecForProviderContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfig { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta2ModelSpecForProviderContainerModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

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
public partial class V1beta2ModelSpecForProviderContainerModelDataSource
{
    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta2ModelSpecForProviderContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderContainer
{
    /// <summary>Additional data sources that are available to the model in addition to those specified in model_data_source. See Additional Model Data Source.</summary>
    [JsonPropertyName("additionalModelDataSource")]
    public IList<V1beta2ModelSpecForProviderContainerAdditionalModelDataSource>? AdditionalModelDataSource { get; set; }

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
    public V1beta2ModelSpecForProviderContainerImageConfig? ImageConfig { get; set; }

    /// <summary>Inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public V1beta2ModelSpecForProviderContainerModelDataSource? ModelDataSource { get; set; }

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
    public V1beta2ModelSpecForProviderContainerMultiModelConfig? MultiModelConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ModelSpecForProviderExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ModelSpecForProviderExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ModelSpecForProviderExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ModelSpecForProviderExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ModelSpecForProviderExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ModelSpecForProviderExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ModelSpecForProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ModelSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ModelSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ModelSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ModelSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ModelSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ModelSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderExecutionRoleArnSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ModelSpecForProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies details of how containers in a multi-container endpoint are called. See Inference Execution Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderInferenceExecutionConfig
{
    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderPrimaryContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderPrimaryContainerAdditionalModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta2ModelSpecForProviderPrimaryContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderPrimaryContainerAdditionalModelDataSource
{
    /// <summary>Custom name for the additional model data source object. It will be stored in /opt/ml/additional-model-data-sources/&lt;channel_name&gt;/.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta2ModelSpecForProviderPrimaryContainerAdditionalModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderPrimaryContainerImageConfigRepositoryAuthConfig
{
    /// <summary>Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderPrimaryContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public V1beta2ModelSpecForProviderPrimaryContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfig { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderPrimaryContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta2ModelSpecForProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

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
public partial class V1beta2ModelSpecForProviderPrimaryContainerModelDataSource
{
    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta2ModelSpecForProviderPrimaryContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderPrimaryContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

/// <summary>Primary docker image containing inference code that is used when the model is deployed for predictions.  If not specified, the container argument is required. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderPrimaryContainer
{
    /// <summary>Additional data sources that are available to the model in addition to those specified in model_data_source. See Additional Model Data Source.</summary>
    [JsonPropertyName("additionalModelDataSource")]
    public IList<V1beta2ModelSpecForProviderPrimaryContainerAdditionalModelDataSource>? AdditionalModelDataSource { get; set; }

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
    public V1beta2ModelSpecForProviderPrimaryContainerImageConfig? ImageConfig { get; set; }

    /// <summary>Inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public V1beta2ModelSpecForProviderPrimaryContainerModelDataSource? ModelDataSource { get; set; }

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
    public V1beta2ModelSpecForProviderPrimaryContainerMultiModelConfig? MultiModelConfig { get; set; }
}

/// <summary>Specifies the VPC that you want your model to connect to. This configuration is used in hosting services and in batch transform. See VPC Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecForProviderVpcConfig
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
public partial class V1beta2ModelSpecForProvider
{
    /// <summary>Specifies containers in the inference pipeline. If not specified, the primary_container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta2ModelSpecForProviderContainer>? Container { get; set; }

    /// <summary>Isolates the model container. No inbound or outbound network calls can be made to or from the model container.</summary>
    [JsonPropertyName("enableNetworkIsolation")]
    public bool? EnableNetworkIsolation { get; set; }

    /// <summary>A role that SageMaker AI can assume to access model artifacts and docker images for deployment.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta2ModelSpecForProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta2ModelSpecForProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>Specifies details of how containers in a multi-container endpoint are called. See Inference Execution Config.</summary>
    [JsonPropertyName("inferenceExecutionConfig")]
    public V1beta2ModelSpecForProviderInferenceExecutionConfig? InferenceExecutionConfig { get; set; }

    /// <summary>Primary docker image containing inference code that is used when the model is deployed for predictions.  If not specified, the container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("primaryContainer")]
    public V1beta2ModelSpecForProviderPrimaryContainer? PrimaryContainer { get; set; }

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
    public V1beta2ModelSpecForProviderVpcConfig? VpcConfig { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderContainerAdditionalModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta2ModelSpecInitProviderContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderContainerAdditionalModelDataSource
{
    /// <summary>Custom name for the additional model data source object. It will be stored in /opt/ml/additional-model-data-sources/&lt;channel_name&gt;/.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta2ModelSpecInitProviderContainerAdditionalModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderContainerImageConfigRepositoryAuthConfig
{
    /// <summary>Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public V1beta2ModelSpecInitProviderContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfig { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta2ModelSpecInitProviderContainerModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

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
public partial class V1beta2ModelSpecInitProviderContainerModelDataSource
{
    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta2ModelSpecInitProviderContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderContainer
{
    /// <summary>Additional data sources that are available to the model in addition to those specified in model_data_source. See Additional Model Data Source.</summary>
    [JsonPropertyName("additionalModelDataSource")]
    public IList<V1beta2ModelSpecInitProviderContainerAdditionalModelDataSource>? AdditionalModelDataSource { get; set; }

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
    public V1beta2ModelSpecInitProviderContainerImageConfig? ImageConfig { get; set; }

    /// <summary>Inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public V1beta2ModelSpecInitProviderContainerModelDataSource? ModelDataSource { get; set; }

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
    public V1beta2ModelSpecInitProviderContainerMultiModelConfig? MultiModelConfig { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ModelSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ModelSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ModelSpecInitProviderExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ModelSpecInitProviderExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ModelSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ModelSpecInitProviderExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ModelSpecInitProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ModelSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ModelSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ModelSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ModelSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ModelSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ModelSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderExecutionRoleArnSelector
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

    /// <summary>Policies for selection.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ModelSpecInitProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Specifies details of how containers in a multi-container endpoint are called. See Inference Execution Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderInferenceExecutionConfig
{
    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderPrimaryContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderPrimaryContainerAdditionalModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta2ModelSpecInitProviderPrimaryContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderPrimaryContainerAdditionalModelDataSource
{
    /// <summary>Custom name for the additional model data source object. It will be stored in /opt/ml/additional-model-data-sources/&lt;channel_name&gt;/.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta2ModelSpecInitProviderPrimaryContainerAdditionalModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderPrimaryContainerImageConfigRepositoryAuthConfig
{
    /// <summary>Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderPrimaryContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public V1beta2ModelSpecInitProviderPrimaryContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfig { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderPrimaryContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta2ModelSpecInitProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

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
public partial class V1beta2ModelSpecInitProviderPrimaryContainerModelDataSource
{
    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta2ModelSpecInitProviderPrimaryContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderPrimaryContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

/// <summary>Primary docker image containing inference code that is used when the model is deployed for predictions.  If not specified, the container argument is required. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderPrimaryContainer
{
    /// <summary>Additional data sources that are available to the model in addition to those specified in model_data_source. See Additional Model Data Source.</summary>
    [JsonPropertyName("additionalModelDataSource")]
    public IList<V1beta2ModelSpecInitProviderPrimaryContainerAdditionalModelDataSource>? AdditionalModelDataSource { get; set; }

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
    public V1beta2ModelSpecInitProviderPrimaryContainerImageConfig? ImageConfig { get; set; }

    /// <summary>Inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public V1beta2ModelSpecInitProviderPrimaryContainerModelDataSource? ModelDataSource { get; set; }

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
    public V1beta2ModelSpecInitProviderPrimaryContainerMultiModelConfig? MultiModelConfig { get; set; }
}

/// <summary>Specifies the VPC that you want your model to connect to. This configuration is used in hosting services and in batch transform. See VPC Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecInitProviderVpcConfig
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
public partial class V1beta2ModelSpecInitProvider
{
    /// <summary>Specifies containers in the inference pipeline. If not specified, the primary_container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta2ModelSpecInitProviderContainer>? Container { get; set; }

    /// <summary>Isolates the model container. No inbound or outbound network calls can be made to or from the model container.</summary>
    [JsonPropertyName("enableNetworkIsolation")]
    public bool? EnableNetworkIsolation { get; set; }

    /// <summary>A role that SageMaker AI can assume to access model artifacts and docker images for deployment.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta2ModelSpecInitProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta2ModelSpecInitProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>Specifies details of how containers in a multi-container endpoint are called. See Inference Execution Config.</summary>
    [JsonPropertyName("inferenceExecutionConfig")]
    public V1beta2ModelSpecInitProviderInferenceExecutionConfig? InferenceExecutionConfig { get; set; }

    /// <summary>Primary docker image containing inference code that is used when the model is deployed for predictions.  If not specified, the container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("primaryContainer")]
    public V1beta2ModelSpecInitProviderPrimaryContainer? PrimaryContainer { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Specifies the VPC that you want your model to connect to. This configuration is used in hosting services and in batch transform. See VPC Config.</summary>
    [JsonPropertyName("vpcConfig")]
    public V1beta2ModelSpecInitProviderVpcConfig? VpcConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ModelSpecManagementPoliciesEnum>))]
public enum V1beta2ModelSpecManagementPoliciesEnum
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
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ModelSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ModelSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ModelSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ModelSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ModelSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ModelSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ModelSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ModelSpec defines the desired state of Model</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelSpec
{
    /// <summary>
    /// DeletionPolicy specifies what will happen to the underlying external
    /// when this managed resource is deleted - either &quot;Delete&quot; or &quot;Orphan&quot; the
    /// external resource.
    /// This field is planned to be deprecated in favor of the ManagementPolicies
    /// field in a future release. Currently, both could be set independently and
    /// non-default values would be honored if the feature flag is enabled.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// </summary>
    [JsonPropertyName("deletionPolicy")]
    public V1beta2ModelSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ModelSpecForProvider ForProvider { get; set; }

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
    public V1beta2ModelSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// This field is planned to replace the DeletionPolicy field in a future
    /// release. Currently, both could be set independently and non-default
    /// values would be honored if the feature flag is enabled. If both are
    /// custom, the DeletionPolicy field will be ignored.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta2ModelSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ModelSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ModelSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderContainerAdditionalModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta2ModelStatusAtProviderContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderContainerAdditionalModelDataSource
{
    /// <summary>Custom name for the additional model data source object. It will be stored in /opt/ml/additional-model-data-sources/&lt;channel_name&gt;/.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta2ModelStatusAtProviderContainerAdditionalModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderContainerImageConfigRepositoryAuthConfig
{
    /// <summary>Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public V1beta2ModelStatusAtProviderContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfig { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta2ModelStatusAtProviderContainerModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

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
public partial class V1beta2ModelStatusAtProviderContainerModelDataSource
{
    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta2ModelStatusAtProviderContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderContainer
{
    /// <summary>Additional data sources that are available to the model in addition to those specified in model_data_source. See Additional Model Data Source.</summary>
    [JsonPropertyName("additionalModelDataSource")]
    public IList<V1beta2ModelStatusAtProviderContainerAdditionalModelDataSource>? AdditionalModelDataSource { get; set; }

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
    public V1beta2ModelStatusAtProviderContainerImageConfig? ImageConfig { get; set; }

    /// <summary>Inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public V1beta2ModelStatusAtProviderContainerModelDataSource? ModelDataSource { get; set; }

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
    public V1beta2ModelStatusAtProviderContainerMultiModelConfig? MultiModelConfig { get; set; }
}

/// <summary>Specifies details of how containers in a multi-container endpoint are called. See Inference Execution Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderInferenceExecutionConfig
{
    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderPrimaryContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderPrimaryContainerAdditionalModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta2ModelStatusAtProviderPrimaryContainerAdditionalModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

    /// <summary>Type of model data to deploy. Allowed values are: S3Object and S3Prefix.</summary>
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    /// <summary>The S3 path of model data to deploy.</summary>
    [JsonPropertyName("s3Uri")]
    public string? S3Uri { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderPrimaryContainerAdditionalModelDataSource
{
    /// <summary>Custom name for the additional model data source object. It will be stored in /opt/ml/additional-model-data-sources/&lt;channel_name&gt;/.</summary>
    [JsonPropertyName("channelName")]
    public string? ChannelName { get; set; }

    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta2ModelStatusAtProviderPrimaryContainerAdditionalModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderPrimaryContainerImageConfigRepositoryAuthConfig
{
    /// <summary>Amazon Resource Name (ARN) of an AWS Lambda function that provides credentials to authenticate to the private Docker registry where your model image is hosted. For information about how to create an AWS Lambda function, see Create a Lambda function with the console in the AWS Lambda Developer Guide.</summary>
    [JsonPropertyName("repositoryCredentialsProviderArn")]
    public string? RepositoryCredentialsProviderArn { get; set; }
}

/// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). For more information see Using a Private Docker Registry for Real-Time Inference Containers. see Image Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderPrimaryContainerImageConfig
{
    /// <summary>Specifies whether the model container is in Amazon ECR or a private Docker registry accessible from your Amazon Virtual Private Cloud (VPC). Allowed values are: Platform and Vpc.</summary>
    [JsonPropertyName("repositoryAccessMode")]
    public string? RepositoryAccessMode { get; set; }

    /// <summary>Specifies an authentication configuration for the private docker registry where your model image is hosted. Specify a value for this property only if you specified Vpc as the value for the RepositoryAccessMode field, and the private Docker registry where the model image is hosted requires authentication. see Repository Auth Config.</summary>
    [JsonPropertyName("repositoryAuthConfig")]
    public V1beta2ModelStatusAtProviderPrimaryContainerImageConfigRepositoryAuthConfig? RepositoryAuthConfig { get; set; }
}

/// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig
{
    /// <summary>Specifies agreement to the model end-user license agreement (EULA). The value must be set to true in order to accept the EULA that this model requires. You are responsible for reviewing and complying with any applicable license terms and making sure they are acceptable for your use case before downloading or using a model.</summary>
    [JsonPropertyName("acceptEula")]
    public bool? AcceptEula { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderPrimaryContainerModelDataSourceS3DataSource
{
    /// <summary>How the model data is prepared. Allowed values are: None and Gzip.</summary>
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    /// <summary>Specifies the access configuration file for the ML model. You can explicitly accept the model end-user license agreement (EULA) within the [model_access_config configuration block]. See Model Access Config.</summary>
    [JsonPropertyName("modelAccessConfig")]
    public V1beta2ModelStatusAtProviderPrimaryContainerModelDataSourceS3DataSourceModelAccessConfig? ModelAccessConfig { get; set; }

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
public partial class V1beta2ModelStatusAtProviderPrimaryContainerModelDataSource
{
    /// <summary>S3 location of model data to deploy. See S3 Data Source.</summary>
    [JsonPropertyName("s3DataSource")]
    public IList<V1beta2ModelStatusAtProviderPrimaryContainerModelDataSourceS3DataSource>? S3DataSource { get; set; }
}

/// <summary>Specifies additional configuration for multi-model endpoints. see Multi Model Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderPrimaryContainerMultiModelConfig
{
    /// <summary>Whether to cache models for a multi-model endpoint. By default, multi-model endpoints cache models so that a model does not have to be loaded into memory each time it is invoked. Some use cases do not benefit from model caching. For example, if an endpoint hosts a large number of models that are each invoked infrequently, the endpoint might perform better if you disable model caching. To disable model caching, set the value of this parameter to Disabled. Allowed values are: Enabled and Disabled.</summary>
    [JsonPropertyName("modelCacheSetting")]
    public string? ModelCacheSetting { get; set; }
}

/// <summary>Primary docker image containing inference code that is used when the model is deployed for predictions.  If not specified, the container argument is required. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderPrimaryContainer
{
    /// <summary>Additional data sources that are available to the model in addition to those specified in model_data_source. See Additional Model Data Source.</summary>
    [JsonPropertyName("additionalModelDataSource")]
    public IList<V1beta2ModelStatusAtProviderPrimaryContainerAdditionalModelDataSource>? AdditionalModelDataSource { get; set; }

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
    public V1beta2ModelStatusAtProviderPrimaryContainerImageConfig? ImageConfig { get; set; }

    /// <summary>Inference specification name in the model package version.</summary>
    [JsonPropertyName("inferenceSpecificationName")]
    public string? InferenceSpecificationName { get; set; }

    /// <summary>Container hosts value. Allowed values are: SingleModel and MultiModel. The default value is SingleModel.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>Location of model data to deploy. Use this for uncompressed model deployment. For information about how to deploy an uncompressed model, see Deploying uncompressed models in the AWS SageMaker AI Developer Guide.</summary>
    [JsonPropertyName("modelDataSource")]
    public V1beta2ModelStatusAtProviderPrimaryContainerModelDataSource? ModelDataSource { get; set; }

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
    public V1beta2ModelStatusAtProviderPrimaryContainerMultiModelConfig? MultiModelConfig { get; set; }
}

/// <summary>Specifies the VPC that you want your model to connect to. This configuration is used in hosting services and in batch transform. See VPC Config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusAtProviderVpcConfig
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
public partial class V1beta2ModelStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) assigned by AWS to this model.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Specifies containers in the inference pipeline. If not specified, the primary_container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("container")]
    public IList<V1beta2ModelStatusAtProviderContainer>? Container { get; set; }

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
    public V1beta2ModelStatusAtProviderInferenceExecutionConfig? InferenceExecutionConfig { get; set; }

    /// <summary>Primary docker image containing inference code that is used when the model is deployed for predictions.  If not specified, the container argument is required. Fields are documented below.</summary>
    [JsonPropertyName("primaryContainer")]
    public V1beta2ModelStatusAtProviderPrimaryContainer? PrimaryContainer { get; set; }

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
    public V1beta2ModelStatusAtProviderVpcConfig? VpcConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ModelStatusConditions
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
public partial class V1beta2ModelStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ModelStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ModelStatusConditions>? Conditions { get; set; }

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
public partial class V1beta2Model : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ModelSpec>, IStatus<V1beta2ModelStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Model";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "models";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Model";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ModelSpec defines the desired state of Model</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ModelSpec Spec { get; set; }

    /// <summary>ModelStatus defines the observed state of Model.</summary>
    [JsonPropertyName("status")]
    public V1beta2ModelStatus? Status { get; set; }
}