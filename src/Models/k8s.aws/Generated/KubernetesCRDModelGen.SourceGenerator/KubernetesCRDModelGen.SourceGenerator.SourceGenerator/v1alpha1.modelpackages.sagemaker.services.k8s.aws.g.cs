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
/// <summary>ModelPackage is the Schema for the ModelPackages API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ModelPackageList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1ModelPackage>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ModelPackageList";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "modelpackages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ModelPackageList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1ModelPackage objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1ModelPackage> Items { get; set; }
}

/// <summary>
/// A data source used for training or inference that is in addition to the input
/// dataset or model data.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecAdditionalInferenceSpecificationsContainersAdditionalS3DataSource
{
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Input object for the model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecAdditionalInferenceSpecificationsContainersModelInput
{
    [JsonPropertyName("dataInputConfig")]
    public string? DataInputConfig { get; set; }
}

/// <summary>Describes the Docker container for the model package.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecAdditionalInferenceSpecificationsContainers
{
    /// <summary>
    /// A data source used for training or inference that is in addition to the input
    /// dataset or model data.
    /// </summary>
    [JsonPropertyName("additionalS3DataSource")]
    public V1alpha1ModelPackageSpecAdditionalInferenceSpecificationsContainersAdditionalS3DataSource? AdditionalS3DataSource { get; set; }

    [JsonPropertyName("containerHostname")]
    public string? ContainerHostname { get; set; }

    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    [JsonPropertyName("framework")]
    public string? Framework { get; set; }

    [JsonPropertyName("frameworkVersion")]
    public string? FrameworkVersion { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imageDigest")]
    public string? ImageDigest { get; set; }

    [JsonPropertyName("modelDataURL")]
    public string? ModelDataURL { get; set; }

    /// <summary>Input object for the model.</summary>
    [JsonPropertyName("modelInput")]
    public V1alpha1ModelPackageSpecAdditionalInferenceSpecificationsContainersModelInput? ModelInput { get; set; }

    [JsonPropertyName("nearestModelName")]
    public string? NearestModelName { get; set; }

    [JsonPropertyName("productID")]
    public string? ProductID { get; set; }
}

/// <summary>
/// A structure of additional Inference Specification. Additional Inference Specification
/// specifies details about inference jobs that can be run with models based
/// on this model package
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecAdditionalInferenceSpecifications
{
    [JsonPropertyName("containers")]
    public IList<V1alpha1ModelPackageSpecAdditionalInferenceSpecificationsContainers>? Containers { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("supportedContentTypes")]
    public IList<string>? SupportedContentTypes { get; set; }

    [JsonPropertyName("supportedRealtimeInferenceInstanceTypes")]
    public IList<string>? SupportedRealtimeInferenceInstanceTypes { get; set; }

    [JsonPropertyName("supportedResponseMIMETypes")]
    public IList<string>? SupportedResponseMIMETypes { get; set; }

    [JsonPropertyName("supportedTransformInstanceTypes")]
    public IList<string>? SupportedTransformInstanceTypes { get; set; }
}

/// <summary>Contains details regarding the file source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecDriftCheckBaselinesBiasConfigFile
{
    [JsonPropertyName("contentDigest")]
    public string? ContentDigest { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Details about the metrics source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecDriftCheckBaselinesBiasPostTrainingConstraints
{
    [JsonPropertyName("contentDigest")]
    public string? ContentDigest { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Details about the metrics source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecDriftCheckBaselinesBiasPreTrainingConstraints
{
    [JsonPropertyName("contentDigest")]
    public string? ContentDigest { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>
/// Represents the drift check bias baselines that can be used when the model
/// monitor is set using the model package.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecDriftCheckBaselinesBias
{
    /// <summary>Contains details regarding the file source.</summary>
    [JsonPropertyName("configFile")]
    public V1alpha1ModelPackageSpecDriftCheckBaselinesBiasConfigFile? ConfigFile { get; set; }

    /// <summary>Details about the metrics source.</summary>
    [JsonPropertyName("postTrainingConstraints")]
    public V1alpha1ModelPackageSpecDriftCheckBaselinesBiasPostTrainingConstraints? PostTrainingConstraints { get; set; }

    /// <summary>Details about the metrics source.</summary>
    [JsonPropertyName("preTrainingConstraints")]
    public V1alpha1ModelPackageSpecDriftCheckBaselinesBiasPreTrainingConstraints? PreTrainingConstraints { get; set; }
}

/// <summary>Contains details regarding the file source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecDriftCheckBaselinesExplainabilityConfigFile
{
    [JsonPropertyName("contentDigest")]
    public string? ContentDigest { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Details about the metrics source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecDriftCheckBaselinesExplainabilityConstraints
{
    [JsonPropertyName("contentDigest")]
    public string? ContentDigest { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>
/// Represents the drift check explainability baselines that can be used when
/// the model monitor is set using the model package.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecDriftCheckBaselinesExplainability
{
    /// <summary>Contains details regarding the file source.</summary>
    [JsonPropertyName("configFile")]
    public V1alpha1ModelPackageSpecDriftCheckBaselinesExplainabilityConfigFile? ConfigFile { get; set; }

    /// <summary>Details about the metrics source.</summary>
    [JsonPropertyName("constraints")]
    public V1alpha1ModelPackageSpecDriftCheckBaselinesExplainabilityConstraints? Constraints { get; set; }
}

/// <summary>Details about the metrics source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecDriftCheckBaselinesModelDataQualityConstraints
{
    [JsonPropertyName("contentDigest")]
    public string? ContentDigest { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Details about the metrics source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecDriftCheckBaselinesModelDataQualityStatistics
{
    [JsonPropertyName("contentDigest")]
    public string? ContentDigest { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>
/// Represents the drift check data quality baselines that can be used when the
/// model monitor is set using the model package.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecDriftCheckBaselinesModelDataQuality
{
    /// <summary>Details about the metrics source.</summary>
    [JsonPropertyName("constraints")]
    public V1alpha1ModelPackageSpecDriftCheckBaselinesModelDataQualityConstraints? Constraints { get; set; }

    /// <summary>Details about the metrics source.</summary>
    [JsonPropertyName("statistics")]
    public V1alpha1ModelPackageSpecDriftCheckBaselinesModelDataQualityStatistics? Statistics { get; set; }
}

/// <summary>Details about the metrics source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecDriftCheckBaselinesModelQualityConstraints
{
    [JsonPropertyName("contentDigest")]
    public string? ContentDigest { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Details about the metrics source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecDriftCheckBaselinesModelQualityStatistics
{
    [JsonPropertyName("contentDigest")]
    public string? ContentDigest { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>
/// Represents the drift check model quality baselines that can be used when
/// the model monitor is set using the model package.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecDriftCheckBaselinesModelQuality
{
    /// <summary>Details about the metrics source.</summary>
    [JsonPropertyName("constraints")]
    public V1alpha1ModelPackageSpecDriftCheckBaselinesModelQualityConstraints? Constraints { get; set; }

    /// <summary>Details about the metrics source.</summary>
    [JsonPropertyName("statistics")]
    public V1alpha1ModelPackageSpecDriftCheckBaselinesModelQualityStatistics? Statistics { get; set; }
}

/// <summary>
/// Represents the drift check baselines that can be used when the model monitor
/// is set using the model package. For more information, see the topic on Drift
/// Detection against Previous Baselines in SageMaker Pipelines (https://docs.aws.amazon.com/sagemaker/latest/dg/pipelines-quality-clarify-baseline-lifecycle.html#pipelines-quality-clarify-baseline-drift-detection)
/// in the Amazon SageMaker Developer Guide.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecDriftCheckBaselines
{
    /// <summary>
    /// Represents the drift check bias baselines that can be used when the model
    /// monitor is set using the model package.
    /// </summary>
    [JsonPropertyName("bias")]
    public V1alpha1ModelPackageSpecDriftCheckBaselinesBias? Bias { get; set; }

    /// <summary>
    /// Represents the drift check explainability baselines that can be used when
    /// the model monitor is set using the model package.
    /// </summary>
    [JsonPropertyName("explainability")]
    public V1alpha1ModelPackageSpecDriftCheckBaselinesExplainability? Explainability { get; set; }

    /// <summary>
    /// Represents the drift check data quality baselines that can be used when the
    /// model monitor is set using the model package.
    /// </summary>
    [JsonPropertyName("modelDataQuality")]
    public V1alpha1ModelPackageSpecDriftCheckBaselinesModelDataQuality? ModelDataQuality { get; set; }

    /// <summary>
    /// Represents the drift check model quality baselines that can be used when
    /// the model monitor is set using the model package.
    /// </summary>
    [JsonPropertyName("modelQuality")]
    public V1alpha1ModelPackageSpecDriftCheckBaselinesModelQuality? ModelQuality { get; set; }
}

/// <summary>
/// A data source used for training or inference that is in addition to the input
/// dataset or model data.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecInferenceSpecificationContainersAdditionalS3DataSource
{
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Input object for the model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecInferenceSpecificationContainersModelInput
{
    [JsonPropertyName("dataInputConfig")]
    public string? DataInputConfig { get; set; }
}

/// <summary>Describes the Docker container for the model package.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecInferenceSpecificationContainers
{
    /// <summary>
    /// A data source used for training or inference that is in addition to the input
    /// dataset or model data.
    /// </summary>
    [JsonPropertyName("additionalS3DataSource")]
    public V1alpha1ModelPackageSpecInferenceSpecificationContainersAdditionalS3DataSource? AdditionalS3DataSource { get; set; }

    [JsonPropertyName("containerHostname")]
    public string? ContainerHostname { get; set; }

    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    [JsonPropertyName("framework")]
    public string? Framework { get; set; }

    [JsonPropertyName("frameworkVersion")]
    public string? FrameworkVersion { get; set; }

    [JsonPropertyName("image")]
    public string? Image { get; set; }

    [JsonPropertyName("imageDigest")]
    public string? ImageDigest { get; set; }

    [JsonPropertyName("modelDataURL")]
    public string? ModelDataURL { get; set; }

    /// <summary>Input object for the model.</summary>
    [JsonPropertyName("modelInput")]
    public V1alpha1ModelPackageSpecInferenceSpecificationContainersModelInput? ModelInput { get; set; }

    [JsonPropertyName("nearestModelName")]
    public string? NearestModelName { get; set; }

    [JsonPropertyName("productID")]
    public string? ProductID { get; set; }
}

/// <summary>
/// Specifies details about inference jobs that you can run with models based
/// on this model package, including the following information:
/// 
///   - The Amazon ECR paths of containers that contain the inference code and
///     model artifacts.
/// 
///   - The instance types that the model package supports for transform jobs
///     and real-time endpoints used for inference.
/// 
///   - The input and output content formats that the model package supports
///     for inference.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecInferenceSpecification
{
    [JsonPropertyName("containers")]
    public IList<V1alpha1ModelPackageSpecInferenceSpecificationContainers>? Containers { get; set; }

    [JsonPropertyName("supportedContentTypes")]
    public IList<string>? SupportedContentTypes { get; set; }

    [JsonPropertyName("supportedRealtimeInferenceInstanceTypes")]
    public IList<string>? SupportedRealtimeInferenceInstanceTypes { get; set; }

    [JsonPropertyName("supportedResponseMIMETypes")]
    public IList<string>? SupportedResponseMIMETypes { get; set; }

    [JsonPropertyName("supportedTransformInstanceTypes")]
    public IList<string>? SupportedTransformInstanceTypes { get; set; }
}

/// <summary>Metadata properties of the tracking entity, trial, or trial component.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecMetadataProperties
{
    [JsonPropertyName("commitID")]
    public string? CommitID { get; set; }

    [JsonPropertyName("generatedBy")]
    public string? GeneratedBy { get; set; }

    [JsonPropertyName("projectID")]
    public string? ProjectID { get; set; }

    [JsonPropertyName("repository")]
    public string? Repository { get; set; }
}

/// <summary>Details about the metrics source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecModelMetricsBiasPostTrainingReport
{
    [JsonPropertyName("contentDigest")]
    public string? ContentDigest { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Details about the metrics source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecModelMetricsBiasPreTrainingReport
{
    [JsonPropertyName("contentDigest")]
    public string? ContentDigest { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Details about the metrics source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecModelMetricsBiasReport
{
    [JsonPropertyName("contentDigest")]
    public string? ContentDigest { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Contains bias metrics for a model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecModelMetricsBias
{
    /// <summary>Details about the metrics source.</summary>
    [JsonPropertyName("postTrainingReport")]
    public V1alpha1ModelPackageSpecModelMetricsBiasPostTrainingReport? PostTrainingReport { get; set; }

    /// <summary>Details about the metrics source.</summary>
    [JsonPropertyName("preTrainingReport")]
    public V1alpha1ModelPackageSpecModelMetricsBiasPreTrainingReport? PreTrainingReport { get; set; }

    /// <summary>Details about the metrics source.</summary>
    [JsonPropertyName("report")]
    public V1alpha1ModelPackageSpecModelMetricsBiasReport? Report { get; set; }
}

/// <summary>Details about the metrics source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecModelMetricsExplainabilityReport
{
    [JsonPropertyName("contentDigest")]
    public string? ContentDigest { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Contains explainability metrics for a model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecModelMetricsExplainability
{
    /// <summary>Details about the metrics source.</summary>
    [JsonPropertyName("report")]
    public V1alpha1ModelPackageSpecModelMetricsExplainabilityReport? Report { get; set; }
}

/// <summary>Details about the metrics source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecModelMetricsModelDataQualityConstraints
{
    [JsonPropertyName("contentDigest")]
    public string? ContentDigest { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Details about the metrics source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecModelMetricsModelDataQualityStatistics
{
    [JsonPropertyName("contentDigest")]
    public string? ContentDigest { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Data quality constraints and statistics for a model.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecModelMetricsModelDataQuality
{
    /// <summary>Details about the metrics source.</summary>
    [JsonPropertyName("constraints")]
    public V1alpha1ModelPackageSpecModelMetricsModelDataQualityConstraints? Constraints { get; set; }

    /// <summary>Details about the metrics source.</summary>
    [JsonPropertyName("statistics")]
    public V1alpha1ModelPackageSpecModelMetricsModelDataQualityStatistics? Statistics { get; set; }
}

/// <summary>Details about the metrics source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecModelMetricsModelQualityConstraints
{
    [JsonPropertyName("contentDigest")]
    public string? ContentDigest { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Details about the metrics source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecModelMetricsModelQualityStatistics
{
    [JsonPropertyName("contentDigest")]
    public string? ContentDigest { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Model quality statistics and constraints.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecModelMetricsModelQuality
{
    /// <summary>Details about the metrics source.</summary>
    [JsonPropertyName("constraints")]
    public V1alpha1ModelPackageSpecModelMetricsModelQualityConstraints? Constraints { get; set; }

    /// <summary>Details about the metrics source.</summary>
    [JsonPropertyName("statistics")]
    public V1alpha1ModelPackageSpecModelMetricsModelQualityStatistics? Statistics { get; set; }
}

/// <summary>A structure that contains model metrics reports.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecModelMetrics
{
    /// <summary>Contains bias metrics for a model.</summary>
    [JsonPropertyName("bias")]
    public V1alpha1ModelPackageSpecModelMetricsBias? Bias { get; set; }

    /// <summary>Contains explainability metrics for a model.</summary>
    [JsonPropertyName("explainability")]
    public V1alpha1ModelPackageSpecModelMetricsExplainability? Explainability { get; set; }

    /// <summary>Data quality constraints and statistics for a model.</summary>
    [JsonPropertyName("modelDataQuality")]
    public V1alpha1ModelPackageSpecModelMetricsModelDataQuality? ModelDataQuality { get; set; }

    /// <summary>Model quality statistics and constraints.</summary>
    [JsonPropertyName("modelQuality")]
    public V1alpha1ModelPackageSpecModelMetricsModelQuality? ModelQuality { get; set; }
}

/// <summary>
/// Specifies an algorithm that was used to create the model package. The algorithm
/// must be either an algorithm resource in your SageMaker account or an algorithm
/// in Amazon Web Services Marketplace that you are subscribed to.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecSourceAlgorithmSpecificationSourceAlgorithms
{
    [JsonPropertyName("algorithmName")]
    public string? AlgorithmName { get; set; }

    [JsonPropertyName("modelDataURL")]
    public string? ModelDataURL { get; set; }
}

/// <summary>Details about the algorithm that was used to create the model package.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecSourceAlgorithmSpecification
{
    [JsonPropertyName("sourceAlgorithms")]
    public IList<V1alpha1ModelPackageSpecSourceAlgorithmSpecificationSourceAlgorithms>? SourceAlgorithms { get; set; }
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
public partial class V1alpha1ModelPackageSpecTags
{
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Describes the S3 data source.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecValidationSpecificationValidationProfilesTransformJobDefinitionTransformInputDataSourceS3DataSource
{
    [JsonPropertyName("s3DataType")]
    public string? S3DataType { get; set; }

    [JsonPropertyName("s3URI")]
    public string? S3URI { get; set; }
}

/// <summary>Describes the location of the channel data.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecValidationSpecificationValidationProfilesTransformJobDefinitionTransformInputDataSource
{
    /// <summary>Describes the S3 data source.</summary>
    [JsonPropertyName("s3DataSource")]
    public V1alpha1ModelPackageSpecValidationSpecificationValidationProfilesTransformJobDefinitionTransformInputDataSourceS3DataSource? S3DataSource { get; set; }
}

/// <summary>
/// Describes the input source of a transform job and the way the transform job
/// consumes it.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecValidationSpecificationValidationProfilesTransformJobDefinitionTransformInput
{
    [JsonPropertyName("compressionType")]
    public string? CompressionType { get; set; }

    [JsonPropertyName("contentType")]
    public string? ContentType { get; set; }

    /// <summary>Describes the location of the channel data.</summary>
    [JsonPropertyName("dataSource")]
    public V1alpha1ModelPackageSpecValidationSpecificationValidationProfilesTransformJobDefinitionTransformInputDataSource? DataSource { get; set; }

    [JsonPropertyName("splitType")]
    public string? SplitType { get; set; }
}

/// <summary>Describes the results of a transform job.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecValidationSpecificationValidationProfilesTransformJobDefinitionTransformOutput
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
/// to use for transform job.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecValidationSpecificationValidationProfilesTransformJobDefinitionTransformResources
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
/// Defines the input needed to run a transform job using the inference specification
/// specified in the algorithm.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecValidationSpecificationValidationProfilesTransformJobDefinition
{
    [JsonPropertyName("batchStrategy")]
    public string? BatchStrategy { get; set; }

    [JsonPropertyName("environment")]
    public IDictionary<string, string>? Environment { get; set; }

    [JsonPropertyName("maxConcurrentTransforms")]
    public long? MaxConcurrentTransforms { get; set; }

    [JsonPropertyName("maxPayloadInMB")]
    public long? MaxPayloadInMB { get; set; }

    /// <summary>
    /// Describes the input source of a transform job and the way the transform job
    /// consumes it.
    /// </summary>
    [JsonPropertyName("transformInput")]
    public V1alpha1ModelPackageSpecValidationSpecificationValidationProfilesTransformJobDefinitionTransformInput? TransformInput { get; set; }

    /// <summary>Describes the results of a transform job.</summary>
    [JsonPropertyName("transformOutput")]
    public V1alpha1ModelPackageSpecValidationSpecificationValidationProfilesTransformJobDefinitionTransformOutput? TransformOutput { get; set; }

    /// <summary>
    /// Describes the resources, including ML instance types and ML instance count,
    /// to use for transform job.
    /// </summary>
    [JsonPropertyName("transformResources")]
    public V1alpha1ModelPackageSpecValidationSpecificationValidationProfilesTransformJobDefinitionTransformResources? TransformResources { get; set; }
}

/// <summary>
/// Contains data, such as the inputs and targeted instance types that are used
/// in the process of validating the model package.
/// 
/// The data provided in the validation profile is made available to your buyers
/// on Amazon Web Services Marketplace.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecValidationSpecificationValidationProfiles
{
    [JsonPropertyName("profileName")]
    public string? ProfileName { get; set; }

    /// <summary>
    /// Defines the input needed to run a transform job using the inference specification
    /// specified in the algorithm.
    /// </summary>
    [JsonPropertyName("transformJobDefinition")]
    public V1alpha1ModelPackageSpecValidationSpecificationValidationProfilesTransformJobDefinition? TransformJobDefinition { get; set; }
}

/// <summary>
/// Specifies configurations for one or more transform jobs that SageMaker runs
/// to test the model package.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpecValidationSpecification
{
    [JsonPropertyName("validationProfiles")]
    public IList<V1alpha1ModelPackageSpecValidationSpecificationValidationProfiles>? ValidationProfiles { get; set; }

    [JsonPropertyName("validationRole")]
    public string? ValidationRole { get; set; }
}

/// <summary>
/// ModelPackageSpec defines the desired state of ModelPackage.
/// 
/// A container for your trained model that can be deployed for SageMaker inference.
/// This can include inference code, artifacts, and metadata. The model package
/// type can be one of the following.
/// 
///   - Versioned model: A part of a model package group in Model Registry.
/// 
///   - Unversioned model: Not part of a model package group and used in Amazon
///     Web Services Marketplace.
/// 
/// For more information, see CreateModelPackage (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateModelPackage.html).
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageSpec
{
    /// <summary>
    /// An array of additional Inference Specification objects. Each additional Inference
    /// Specification specifies artifacts based on this model package that can be
    /// used on inference endpoints. Generally used with SageMaker Neo to store the
    /// compiled artifacts.
    /// </summary>
    [JsonPropertyName("additionalInferenceSpecifications")]
    public IList<V1alpha1ModelPackageSpecAdditionalInferenceSpecifications>? AdditionalInferenceSpecifications { get; set; }

    /// <summary>
    /// A description for the approval status of the model.
    /// 
    /// Regex Pattern: `.*`
    /// </summary>
    [JsonPropertyName("approvalDescription")]
    public string? ApprovalDescription { get; set; }

    /// <summary>
    /// Whether to certify the model package for listing on Amazon Web Services Marketplace.
    /// 
    /// This parameter is optional for unversioned models, and does not apply to
    /// versioned models.
    /// </summary>
    [JsonPropertyName("certifyForMarketplace")]
    public bool? CertifyForMarketplace { get; set; }

    /// <summary>
    /// A unique token that guarantees that the call to this API is idempotent.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9-]+$`
    /// </summary>
    [JsonPropertyName("clientToken")]
    public string? ClientToken { get; set; }

    /// <summary>The metadata properties associated with the model package versions.</summary>
    [JsonPropertyName("customerMetadataProperties")]
    public IDictionary<string, string>? CustomerMetadataProperties { get; set; }

    /// <summary>
    /// The machine learning domain of your model package and its components. Common
    /// machine learning domains include computer vision and natural language processing.
    /// </summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>
    /// Represents the drift check baselines that can be used when the model monitor
    /// is set using the model package. For more information, see the topic on Drift
    /// Detection against Previous Baselines in SageMaker Pipelines (https://docs.aws.amazon.com/sagemaker/latest/dg/pipelines-quality-clarify-baseline-lifecycle.html#pipelines-quality-clarify-baseline-drift-detection)
    /// in the Amazon SageMaker Developer Guide.
    /// </summary>
    [JsonPropertyName("driftCheckBaselines")]
    public V1alpha1ModelPackageSpecDriftCheckBaselines? DriftCheckBaselines { get; set; }

    /// <summary>
    /// Specifies details about inference jobs that you can run with models based
    /// on this model package, including the following information:
    /// 
    ///   - The Amazon ECR paths of containers that contain the inference code and
    ///     model artifacts.
    /// 
    ///   - The instance types that the model package supports for transform jobs
    ///     and real-time endpoints used for inference.
    /// 
    ///   - The input and output content formats that the model package supports
    ///     for inference.
    /// </summary>
    [JsonPropertyName("inferenceSpecification")]
    public V1alpha1ModelPackageSpecInferenceSpecification? InferenceSpecification { get; set; }

    /// <summary>Metadata properties of the tracking entity, trial, or trial component.</summary>
    [JsonPropertyName("metadataProperties")]
    public V1alpha1ModelPackageSpecMetadataProperties? MetadataProperties { get; set; }

    /// <summary>
    /// Whether the model is approved for deployment.
    /// 
    /// This parameter is optional for versioned models, and does not apply to unversioned
    /// models.
    /// 
    /// For versioned models, the value of this parameter must be set to Approved
    /// to deploy the model.
    /// </summary>
    [JsonPropertyName("modelApprovalStatus")]
    public string? ModelApprovalStatus { get; set; }

    /// <summary>A structure that contains model metrics reports.</summary>
    [JsonPropertyName("modelMetrics")]
    public V1alpha1ModelPackageSpecModelMetrics? ModelMetrics { get; set; }

    /// <summary>
    /// A description of the model package.
    /// 
    /// Regex Pattern: `^[\p{L}\p{M}\p{Z}\p{S}\p{N}\p{P}]*$`
    /// </summary>
    [JsonPropertyName("modelPackageDescription")]
    public string? ModelPackageDescription { get; set; }

    /// <summary>
    /// The name or Amazon Resource Name (ARN) of the model package group that this
    /// model version belongs to.
    /// 
    /// This parameter is required for versioned models, and does not apply to unversioned
    /// models.
    /// 
    /// Regex Pattern: `^(arn:aws[a-z\-]*:sagemaker:[a-z0-9\-]*:[0-9]{12}:[a-z\-]*\/)?([a-zA-Z0-9]([a-zA-Z0-9-]){0,62})(?&lt;!-)$`
    /// </summary>
    [JsonPropertyName("modelPackageGroupName")]
    public string? ModelPackageGroupName { get; set; }

    /// <summary>
    /// The name of the model package. The name must have 1 to 63 characters. Valid
    /// characters are a-z, A-Z, 0-9, and - (hyphen).
    /// 
    /// This parameter is required for unversioned models. It is not applicable to
    /// versioned models.
    /// 
    /// Regex Pattern: `^[a-zA-Z0-9](-*[a-zA-Z0-9]){0,62}$`
    /// </summary>
    [JsonPropertyName("modelPackageName")]
    public string? ModelPackageName { get; set; }

    /// <summary>
    /// The Amazon Simple Storage Service (Amazon S3) path where the sample payload
    /// is stored. This path must point to a single gzip compressed tar archive (.tar.gz
    /// suffix). This archive can hold multiple files that are all equally used in
    /// the load test. Each file in the archive must satisfy the size constraints
    /// of the InvokeEndpoint (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_runtime_InvokeEndpoint.html#API_runtime_InvokeEndpoint_RequestSyntax)
    /// call.
    /// 
    /// Regex Pattern: `^(https|s3)://([^/]+)/?(.*)$`
    /// </summary>
    [JsonPropertyName("samplePayloadURL")]
    public string? SamplePayloadURL { get; set; }

    /// <summary>Indicates if you want to skip model validation.</summary>
    [JsonPropertyName("skipModelValidation")]
    public string? SkipModelValidation { get; set; }

    /// <summary>Details about the algorithm that was used to create the model package.</summary>
    [JsonPropertyName("sourceAlgorithmSpecification")]
    public V1alpha1ModelPackageSpecSourceAlgorithmSpecification? SourceAlgorithmSpecification { get; set; }

    /// <summary>
    /// A list of key value pairs associated with the model. For more information,
    /// see Tagging Amazon Web Services resources (https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html)
    /// in the Amazon Web Services General Reference Guide.
    /// 
    /// If you supply ModelPackageGroupName, your model package belongs to the model
    /// group you specify and uses the tags associated with the model group. In this
    /// case, you cannot supply a tag argument.
    /// </summary>
    [JsonPropertyName("tags")]
    public IList<V1alpha1ModelPackageSpecTags>? Tags { get; set; }

    /// <summary>
    /// The machine learning task your model package accomplishes. Common machine
    /// learning tasks include object detection and image classification. The following
    /// tasks are supported by Inference Recommender: &quot;IMAGE_CLASSIFICATION&quot; | &quot;OBJECT_DETECTION&quot;
    /// | &quot;TEXT_GENERATION&quot; |&quot;IMAGE_SEGMENTATION&quot; | &quot;FILL_MASK&quot; | &quot;CLASSIFICATION&quot;
    /// | &quot;REGRESSION&quot; | &quot;OTHER&quot;.
    /// 
    /// Specify &quot;OTHER&quot; if none of the tasks listed fit your use case.
    /// </summary>
    [JsonPropertyName("task")]
    public string? Task { get; set; }

    /// <summary>
    /// Specifies configurations for one or more transform jobs that SageMaker runs
    /// to test the model package.
    /// </summary>
    [JsonPropertyName("validationSpecification")]
    public V1alpha1ModelPackageSpecValidationSpecification? ValidationSpecification { get; set; }
}

/// <summary>
/// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
/// that is used to contain resource sync state, account ownership,
/// constructed ARN for the resource
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageStatusAckResourceMetadata
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
public partial class V1alpha1ModelPackageStatusConditions
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

/// <summary>Represents the overall status of a model package.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageStatusModelPackageStatusDetailsImageScanStatuses
{
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Represents the overall status of a model package.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageStatusModelPackageStatusDetailsValidationStatuses
{
    [JsonPropertyName("failureReason")]
    public string? FailureReason { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>Details about the current status of the model package.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageStatusModelPackageStatusDetails
{
    [JsonPropertyName("imageScanStatuses")]
    public IList<V1alpha1ModelPackageStatusModelPackageStatusDetailsImageScanStatuses>? ImageScanStatuses { get; set; }

    [JsonPropertyName("validationStatuses")]
    public IList<V1alpha1ModelPackageStatusModelPackageStatusDetailsValidationStatuses>? ValidationStatuses { get; set; }
}

/// <summary>ModelPackageStatus defines the observed state of ModelPackage</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1ModelPackageStatus
{
    /// <summary>
    /// All CRs managed by ACK have a common `Status.ACKResourceMetadata` member
    /// that is used to contain resource sync state, account ownership,
    /// constructed ARN for the resource
    /// </summary>
    [JsonPropertyName("ackResourceMetadata")]
    public V1alpha1ModelPackageStatusAckResourceMetadata? AckResourceMetadata { get; set; }

    /// <summary>
    /// All CRs managed by ACK have a common `Status.Conditions` member that
    /// contains a collection of `ackv1alpha1.Condition` objects that describe
    /// the various terminal states of the CR and its backend AWS service API
    /// resource
    /// </summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1ModelPackageStatusConditions>? Conditions { get; set; }

    /// <summary>A timestamp specifying when the model package was created.</summary>
    [JsonPropertyName("creationTime")]
    public DateTime? CreationTime { get; set; }

    /// <summary>The last time that the model package was modified.</summary>
    [JsonPropertyName("lastModifiedTime")]
    public DateTime? LastModifiedTime { get; set; }

    /// <summary>The current status of the model package.</summary>
    [JsonPropertyName("modelPackageStatus")]
    public string? ModelPackageStatus { get; set; }

    /// <summary>Details about the current status of the model package.</summary>
    [JsonPropertyName("modelPackageStatusDetails")]
    public V1alpha1ModelPackageStatusModelPackageStatusDetails? ModelPackageStatusDetails { get; set; }
}

/// <summary>ModelPackage is the Schema for the ModelPackages API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1ModelPackage : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1ModelPackageSpec?>, IStatus<V1alpha1ModelPackageStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "ModelPackage";
    public const string KubeGroup = "sagemaker.services.k8s.aws";
    public const string KubePluralName = "modelpackages";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.services.k8s.aws/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ModelPackage";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>
    /// ModelPackageSpec defines the desired state of ModelPackage.
    /// 
    /// A container for your trained model that can be deployed for SageMaker inference.
    /// This can include inference code, artifacts, and metadata. The model package
    /// type can be one of the following.
    /// 
    ///   - Versioned model: A part of a model package group in Model Registry.
    /// 
    ///   - Unversioned model: Not part of a model package group and used in Amazon
    ///     Web Services Marketplace.
    /// 
    /// For more information, see CreateModelPackage (https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateModelPackage.html).
    /// </summary>
    [JsonPropertyName("spec")]
    public V1alpha1ModelPackageSpec? Spec { get; set; }

    /// <summary>ModelPackageStatus defines the observed state of ModelPackage</summary>
    [JsonPropertyName("status")]
    public V1alpha1ModelPackageStatus? Status { get; set; }
}