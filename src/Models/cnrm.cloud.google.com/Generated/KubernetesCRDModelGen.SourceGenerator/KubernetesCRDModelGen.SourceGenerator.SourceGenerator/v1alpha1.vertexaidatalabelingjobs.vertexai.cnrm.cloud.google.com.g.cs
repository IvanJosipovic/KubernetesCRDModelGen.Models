#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.vertexai.cnrm.cloud.google.com;
/// <summary>VertexAIDataLabelingJob is the Schema for the VertexAIDataLabelingJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAIDataLabelingJobList : IKubernetesObject<V1ListMeta>, IItems<V1alpha1VertexAIDataLabelingJob>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAIDataLabelingJobList";
    public const string KubeGroup = "vertexai.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaidatalabelingjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vertexai.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VertexAIDataLabelingJobList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1alpha1VertexAIDataLabelingJob objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1alpha1VertexAIDataLabelingJob> Items { get; set; }
}

/// <summary>Active learning data sampling config. For every active learning labeling iteration, it will select a batch of data based on the sampling strategy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDataLabelingJobSpecActiveLearningConfigSampleConfig
{
    /// <summary>The percentage of data needed to be labeled in each following batch (except the first batch).</summary>
    [JsonPropertyName("followingBatchSamplePercentage")]
    public int? FollowingBatchSamplePercentage { get; set; }

    /// <summary>The percentage of data needed to be labeled in the first batch.</summary>
    [JsonPropertyName("initialBatchSamplePercentage")]
    public int? InitialBatchSamplePercentage { get; set; }

    /// <summary>Field to choose sampling strategy. Sampling strategy will decide which data should be selected for human labeling in every batch.</summary>
    [JsonPropertyName("sampleStrategy")]
    public string? SampleStrategy { get; set; }
}

/// <summary>CMLE training config. For every active learning labeling iteration, system will train a machine learning model on CMLE. The trained model will be used by data sampling algorithm to select DataItems.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDataLabelingJobSpecActiveLearningConfigTrainingConfig
{
    /// <summary>The timeout hours for the CMLE training job, expressed in milli hours i.e. 1,000 value in this field means 1 hour.</summary>
    [JsonPropertyName("timeoutTrainingMilliHours")]
    public long? TimeoutTrainingMilliHours { get; set; }
}

/// <summary>Parameters that configure the active learning pipeline. Active learning will label the data incrementally via several iterations. For every iteration, it will select a batch of data based on the sampling strategy.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDataLabelingJobSpecActiveLearningConfig
{
    /// <summary>Max number of human labeled DataItems.</summary>
    [JsonPropertyName("maxDataItemCount")]
    public long? MaxDataItemCount { get; set; }

    /// <summary>Max percent of total DataItems for human labeling.</summary>
    [JsonPropertyName("maxDataItemPercentage")]
    public int? MaxDataItemPercentage { get; set; }

    /// <summary>Active learning data sampling config. For every active learning labeling iteration, it will select a batch of data based on the sampling strategy.</summary>
    [JsonPropertyName("sampleConfig")]
    public V1alpha1VertexAIDataLabelingJobSpecActiveLearningConfigSampleConfig? SampleConfig { get; set; }

    /// <summary>CMLE training config. For every active learning labeling iteration, system will train a machine learning model on CMLE. The trained model will be used by data sampling algorithm to select DataItems.</summary>
    [JsonPropertyName("trainingConfig")]
    public V1alpha1VertexAIDataLabelingJobSpecActiveLearningConfigTrainingConfig? TrainingConfig { get; set; }
}

/// <summary>VertexAIDatasetRef is a reference to a VertexAIDataset resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDataLabelingJobSpecDatasetRefs
{
    /// <summary>If provided, must be in the format `projects/[projectId]/locations/[location]/datasets/[datasetId]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `metadata.name` field of a `VertexAIDataset` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `metadata.namespace` field of a `VertexAIDataset` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. The key needs to be in the same region as where the compute resource is created.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDataLabelingJobSpecEncryptionSpecKmsKeyRef
{
    /// <summary>A reference to an externally managed KMSCryptoKey. Should be in the format `projects/[kms_project_id]/locations/[region]/keyRings/[key_ring_id]/cryptoKeys/[key]`.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The `name` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` of a `KMSCryptoKey` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>Customer-managed encryption key spec for a DataLabelingJob. If set, this DataLabelingJob will be secured by this key.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDataLabelingJobSpecEncryptionSpec
{
    /// <summary>Required. The Cloud KMS resource identifier of the customer managed encryption key used to protect a resource. The key needs to be in the same region as where the compute resource is created.</summary>
    [JsonPropertyName("kmsKeyRef")]
    public required V1alpha1VertexAIDataLabelingJobSpecEncryptionSpecKmsKeyRef KmsKeyRef { get; set; }
}

/// <summary>The project that this resource belongs to.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDataLabelingJobSpecProjectRef
{
    /// <summary>The `projectID` field of a project, when not managed by Config Connector.</summary>
    [JsonPropertyName("external")]
    public string? External { get; set; }

    /// <summary>The kind of the Project resource; optional but must be `Project` if provided.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>The `name` field of a `Project` resource.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The `namespace` field of a `Project` resource.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }
}

/// <summary>VertexAIDataLabelingJobSpec defines the desired state of VertexAIDataLabelingJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDataLabelingJobSpec
{
    /// <summary>Parameters that configure the active learning pipeline. Active learning will label the data incrementally via several iterations. For every iteration, it will select a batch of data based on the sampling strategy.</summary>
    [JsonPropertyName("activeLearningConfig")]
    public V1alpha1VertexAIDataLabelingJobSpecActiveLearningConfig? ActiveLearningConfig { get; set; }

    /// <summary>
    /// Labels to assign to annotations generated by this DataLabelingJob.
    /// 
    /// Label keys and values can be no longer than 64 characters
    /// (Unicode codepoints), can only contain lowercase letters, numeric
    /// characters, underscores and dashes. International characters are allowed.
    /// See https://goo.gl/xmQnxf for more information and examples of labels.
    /// System reserved label keys are prefixed with &quot;aiplatform.googleapis.com/&quot;
    /// and are immutable.
    /// </summary>
    [JsonPropertyName("annotationLabels")]
    public IDictionary<string, string>? AnnotationLabels { get; set; }

    /// <summary>Required. Dataset resource names. Right now we only support labeling from a single Dataset. Format: projects/{project}/locations/{location}/datasets/{dataset}</summary>
    [JsonPropertyName("datasetRefs")]
    public IList<V1alpha1VertexAIDataLabelingJobSpecDatasetRefs>? DatasetRefs { get; set; }

    /// <summary>Required. The user-defined name of the DataLabelingJob. The name can be up to 128 characters long and can consist of any UTF-8 characters. Display name of a DataLabelingJob.</summary>
    [JsonPropertyName("displayName")]
    public string? DisplayName { get; set; }

    /// <summary>Customer-managed encryption key spec for a DataLabelingJob. If set, this DataLabelingJob will be secured by this key.</summary>
    [JsonPropertyName("encryptionSpec")]
    public V1alpha1VertexAIDataLabelingJobSpecEncryptionSpec? EncryptionSpec { get; set; }

    /// <summary>Required. Input config parameters for the DataLabelingJob.</summary>
    [JsonPropertyName("inputs")]
    public JsonNode? Inputs { get; set; }

    /// <summary>Required. Points to a YAML file stored on Google Cloud Storage describing the config for a specific type of DataLabelingJob. The schema files that can be used here are found in the https://storage.googleapis.com/google-cloud-aiplatform bucket in the /schema/datalabelingjob/inputs/ folder.</summary>
    [JsonPropertyName("inputsSchemaURI")]
    public string? InputsSchemaURI { get; set; }

    /// <summary>Required. The Google Cloud Storage location of the instruction pdf. This pdf is shared with labelers, and provides detailed description on how to label DataItems in Datasets.</summary>
    [JsonPropertyName("instructionURI")]
    public string? InstructionURI { get; set; }

    /// <summary>Required. Number of labelers to work on each DataItem.</summary>
    [JsonPropertyName("labelerCount")]
    public int? LabelerCount { get; set; }

    /// <summary>The labels with user-defined metadata to organize your DataLabelingJobs.</summary>
    [JsonPropertyName("labels")]
    public IDictionary<string, string>? Labels { get; set; }

    /// <summary>The location of this resource.</summary>
    [JsonPropertyName("location")]
    public required string Location { get; set; }

    /// <summary>The project that this resource belongs to.</summary>
    [JsonPropertyName("projectRef")]
    public required V1alpha1VertexAIDataLabelingJobSpecProjectRef ProjectRef { get; set; }

    /// <summary>The VertexAIDataLabelingJob name. If not given, the metadata.name will be used.</summary>
    [JsonPropertyName("resourceID")]
    public string? ResourceID { get; set; }

    /// <summary>The SpecialistPools&apos; resource names associated with this job.</summary>
    [JsonPropertyName("specialistPools")]
    public IList<string>? SpecialistPools { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDataLabelingJobStatusConditions
{
    /// <summary>Last time the condition transitioned from one status to another.</summary>
    [JsonPropertyName("lastTransitionTime")]
    public string? LastTransitionTime { get; set; }

    /// <summary>Human-readable message indicating details about last transition.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Unique, one-word, CamelCase reason for the condition&apos;s last transition.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Status is the status of the condition. Can be True, False, Unknown.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Type is the type of the condition.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Output only. Estimated cost(in US dollars) that the DataLabelingJob has incurred to date.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDataLabelingJobStatusObservedStateCurrentSpend
{
    /// <summary>The three-letter currency code defined in ISO 4217.</summary>
    [JsonPropertyName("currencyCode")]
    public string? CurrencyCode { get; set; }

    /// <summary>Number of nano (10^-9) units of the amount. The value must be between -999,999,999 and +999,999,999 inclusive. If `units` is positive, `nanos` must be positive or zero. If `units` is zero, `nanos` can be positive, zero, or negative. If `units` is negative, `nanos` must be negative or zero. For example $-1.75 is represented as `units`=-1 and `nanos`=-750,000,000.</summary>
    [JsonPropertyName("nanos")]
    public int? Nanos { get; set; }

    /// <summary>The whole units of the amount. For example if `currencyCode` is `&quot;USD&quot;`, then 1 unit is one US dollar.</summary>
    [JsonPropertyName("units")]
    public long? Units { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDataLabelingJobStatusObservedStateErrorDetails
{
    /// <summary>
    /// A URL/resource name that uniquely identifies the type of the serialized
    ///  protocol buffer message. This string must contain at least
    ///  one &quot;/&quot; character. The last segment of the URL&apos;s path must represent
    ///  the fully qualified name of the type (as in
    ///  `path/google.protobuf.Duration`). The name should be in a canonical form
    ///  (e.g., leading &quot;.&quot; is not accepted).
    /// 
    ///  In practice, teams usually precompile into the binary all types that they
    ///  expect it to use in the context of Any. However, for URLs which use the
    ///  scheme `http`, `https`, or no scheme, one can optionally set up a type
    ///  server that maps type URLs to message definitions as follows:
    /// 
    ///  * If no scheme is provided, `https` is assumed.
    ///  * An HTTP GET on the URL must yield a [google.protobuf.Type][]
    ///    value in binary format, or produce an error.
    ///  * Applications are allowed to cache lookup results based on the
    ///    URL, or have them precompiled into a binary to avoid any
    ///    lookup. Therefore, binary compatibility needs to be preserved
    ///    on changes to types. (Use versioned type names to manage
    ///    breaking changes.)
    /// 
    ///  Note: this functionality is not currently available in the official
    ///  protobuf release, and it is not used for type URLs beginning with
    ///  type.googleapis.com.
    /// 
    ///  Schemes other than `http`, `https` (or the empty scheme) might be
    ///  used with implementation specific semantics.
    /// </summary>
    [JsonPropertyName("typeURL")]
    public string? TypeURL { get; set; }

    /// <summary>Must be a valid serialized protocol buffer of the above specified type.</summary>
    [JsonPropertyName("value")]
    public byte[]? Value { get; set; }
}

/// <summary>Output only. DataLabelingJob errors. It is only populated when job&apos;s state is `JOB_STATE_FAILED` or `JOB_STATE_CANCELLED`.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDataLabelingJobStatusObservedStateError
{
    /// <summary>The status code, which should be an enum value of [google.rpc.Code][google.rpc.Code].</summary>
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    /// <summary>A list of messages that carry the error details.  There is a common set of message types for APIs to use.</summary>
    [JsonPropertyName("details")]
    public IList<V1alpha1VertexAIDataLabelingJobStatusObservedStateErrorDetails>? Details { get; set; }

    /// <summary>A developer-facing error message, which should be in English. Any user-facing error message should be localized and sent in the [google.rpc.Status.details][google.rpc.Status.details] field, or localized by the client.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}

/// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDataLabelingJobStatusObservedState
{
    /// <summary>Output only. Timestamp when this DataLabelingJob was created.</summary>
    [JsonPropertyName("createTime")]
    public string? CreateTime { get; set; }

    /// <summary>Output only. Estimated cost(in US dollars) that the DataLabelingJob has incurred to date.</summary>
    [JsonPropertyName("currentSpend")]
    public V1alpha1VertexAIDataLabelingJobStatusObservedStateCurrentSpend? CurrentSpend { get; set; }

    /// <summary>Output only. DataLabelingJob errors. It is only populated when job&apos;s state is `JOB_STATE_FAILED` or `JOB_STATE_CANCELLED`.</summary>
    [JsonPropertyName("error")]
    public V1alpha1VertexAIDataLabelingJobStatusObservedStateError? Error { get; set; }

    /// <summary>Output only. Current labeling job progress percentage scaled in interval [0, 100], indicating the percentage of DataItems that has been finished.</summary>
    [JsonPropertyName("labelingProgress")]
    public int? LabelingProgress { get; set; }

    /// <summary>Output only. Resource name of the DataLabelingJob.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Output only. The detailed state of the job.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Output only. Timestamp when this DataLabelingJob was updated most recently.</summary>
    [JsonPropertyName("updateTime")]
    public string? UpdateTime { get; set; }
}

/// <summary>VertexAIDataLabelingJobStatus defines the config connector machine state of VertexAIDataLabelingJob</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1alpha1VertexAIDataLabelingJobStatus
{
    /// <summary>Conditions represent the latest available observations of the object&apos;s current state.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1alpha1VertexAIDataLabelingJobStatusConditions>? Conditions { get; set; }

    /// <summary>A unique specifier for the VertexAIDataLabelingJob resource in GCP.</summary>
    [JsonPropertyName("externalRef")]
    public string? ExternalRef { get; set; }

    /// <summary>ObservedGeneration is the generation of the resource that was most recently observed by the Config Connector controller. If this is equal to metadata.generation, then that means that the current reported status reflects the most recent desired state of the resource.</summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }

    /// <summary>ObservedState is the state of the resource as most recently observed in GCP.</summary>
    [JsonPropertyName("observedState")]
    public V1alpha1VertexAIDataLabelingJobStatusObservedState? ObservedState { get; set; }
}

/// <summary>VertexAIDataLabelingJob is the Schema for the VertexAIDataLabelingJob API</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1alpha1VertexAIDataLabelingJob : IKubernetesObject<V1ObjectMeta>, ISpec<V1alpha1VertexAIDataLabelingJobSpec>, IStatus<V1alpha1VertexAIDataLabelingJobStatus?>
{
    public const string KubeApiVersion = "v1alpha1";
    public const string KubeKind = "VertexAIDataLabelingJob";
    public const string KubeGroup = "vertexai.cnrm.cloud.google.com";
    public const string KubePluralName = "vertexaidatalabelingjobs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "vertexai.cnrm.cloud.google.com/v1alpha1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "VertexAIDataLabelingJob";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>VertexAIDataLabelingJobSpec defines the desired state of VertexAIDataLabelingJob</summary>
    [JsonPropertyName("spec")]
    public required V1alpha1VertexAIDataLabelingJobSpec Spec { get; set; }

    /// <summary>VertexAIDataLabelingJobStatus defines the config connector machine state of VertexAIDataLabelingJob</summary>
    [JsonPropertyName("status")]
    public V1alpha1VertexAIDataLabelingJobStatus? Status { get; set; }
}