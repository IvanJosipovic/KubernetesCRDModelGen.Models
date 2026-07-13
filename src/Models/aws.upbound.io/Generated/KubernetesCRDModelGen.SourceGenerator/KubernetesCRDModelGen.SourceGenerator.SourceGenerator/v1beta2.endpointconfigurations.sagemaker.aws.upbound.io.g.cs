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
/// <summary>EndpointConfiguration is the Schema for the EndpointConfigurations API. Provides a SageMaker AI Endpoint Configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2EndpointConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta2EndpointConfiguration>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "EndpointConfigurationList";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "endpointconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EndpointConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2EndpointConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2EndpointConfiguration> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecDeletionPolicyEnum>))]
public enum V1beta2EndpointConfigurationSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Configures the behavior of the client used by SageMaker AI to interact with the model container during asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderAsyncInferenceConfigClientConfig
{
    /// <summary>Maximum number of concurrent requests sent by the SageMaker AI client to the model container. If no value is provided, SageMaker AI will choose an optimal value for you.</summary>
    [JsonPropertyName("maxConcurrentInvocationsPerInstance")]
    public double? MaxConcurrentInvocationsPerInstance { get; set; }
}

/// <summary>Configuration for notifications of inference results for asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderAsyncInferenceConfigOutputConfigNotificationConfig
{
    /// <summary>SNS topic to post a notification to when inference fails. If no topic is provided, no notification is sent on failure.</summary>
    [JsonPropertyName("errorTopic")]
    public string? ErrorTopic { get; set; }

    /// <summary>SNS topics where you want the inference response to be included. Valid values are SUCCESS_NOTIFICATION_TOPIC and ERROR_NOTIFICATION_TOPIC.</summary>
    [JsonPropertyName("includeInferenceResponseIn")]
    public IList<string>? IncludeInferenceResponseIn { get; set; }

    /// <summary>SNS topic to post a notification to when inference completes successfully. If no topic is provided, no notification is sent on success.</summary>
    [JsonPropertyName("successTopic")]
    public string? SuccessTopic { get; set; }
}

/// <summary>Configuration for asynchronous inference invocation outputs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderAsyncInferenceConfigOutputConfig
{
    /// <summary>KMS key that SageMaker AI uses to encrypt the asynchronous inference output in S3.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Configuration for notifications of inference results for asynchronous inference.</summary>
    [JsonPropertyName("notificationConfig")]
    public V1beta2EndpointConfigurationSpecForProviderAsyncInferenceConfigOutputConfigNotificationConfig? NotificationConfig { get; set; }

    /// <summary>S3 location to upload failure inference responses to.</summary>
    [JsonPropertyName("s3FailurePath")]
    public string? S3FailurePath { get; set; }

    /// <summary>S3 location to upload inference responses to.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>How an endpoint performs asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderAsyncInferenceConfig
{
    /// <summary>Configures the behavior of the client used by SageMaker AI to interact with the model container during asynchronous inference.</summary>
    [JsonPropertyName("clientConfig")]
    public V1beta2EndpointConfigurationSpecForProviderAsyncInferenceConfigClientConfig? ClientConfig { get; set; }

    /// <summary>Configuration for asynchronous inference invocation outputs.</summary>
    [JsonPropertyName("outputConfig")]
    public V1beta2EndpointConfigurationSpecForProviderAsyncInferenceConfigOutputConfig? OutputConfig { get; set; }
}

/// <summary>Content type headers to capture. See capture_content_type_header below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderDataCaptureConfigCaptureContentTypeHeader
{
    /// <summary>CSV content type headers to capture. One of csv_content_types or json_content_types is required.</summary>
    [JsonPropertyName("csvContentTypes")]
    public IList<string>? CsvContentTypes { get; set; }

    /// <summary>The JSON content type headers to capture. One of json_content_types or csv_content_types is required.</summary>
    [JsonPropertyName("jsonContentTypes")]
    public IList<string>? JsonContentTypes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderDataCaptureConfigCaptureOptions
{
    /// <summary>Data to be captured. Should be one of Input, Output or InputAndOutput.</summary>
    [JsonPropertyName("captureMode")]
    public string? CaptureMode { get; set; }
}

/// <summary>Parameters to capture input/output of SageMaker AI models endpoints. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderDataCaptureConfig
{
    /// <summary>Content type headers to capture. See capture_content_type_header below.</summary>
    [JsonPropertyName("captureContentTypeHeader")]
    public V1beta2EndpointConfigurationSpecForProviderDataCaptureConfigCaptureContentTypeHeader? CaptureContentTypeHeader { get; set; }

    /// <summary>What data to capture. Fields are documented below.</summary>
    [JsonPropertyName("captureOptions")]
    public IList<V1beta2EndpointConfigurationSpecForProviderDataCaptureConfigCaptureOptions>? CaptureOptions { get; set; }

    /// <summary>URL for S3 location where the captured data is stored.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>Flag to enable data capture. Defaults to false.</summary>
    [JsonPropertyName("enableCapture")]
    public bool? EnableCapture { get; set; }

    /// <summary>Portion of data to capture. Should be between 0 and 100.</summary>
    [JsonPropertyName("initialSamplingPercentage")]
    public double? InitialSamplingPercentage { get; set; }

    /// <summary>ARN of a KMS key that SageMaker AI uses to encrypt the captured data on S3.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnSelector
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
    public V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecForProviderKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta2EndpointConfigurationSpecForProviderKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecForProviderKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta2EndpointConfigurationSpecForProviderKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointConfigurationSpecForProviderKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointConfigurationSpecForProviderKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EndpointConfigurationSpecForProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta2EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta2EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderKmsKeyArnSelector
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
    public V1beta2EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderProductionVariantsCoreDumpConfig
{
    /// <summary>S3 bucket to send the core dump to.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>KMS key that SageMaker AI uses to encrypt the core dump data at rest using S3 server-side encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>Control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderProductionVariantsManagedInstanceScaling
{
    /// <summary>Maximum number of instances that the endpoint can provision when it scales up to accommodate an increase in traffic.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>Minimum number of instances that the endpoint must retain when it scales down to accommodate a decrease in traffic.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }

    /// <summary>Whether managed instance scaling is enabled. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicyResolutionEnum>))]
public enum V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicyResolveEnum>))]
public enum V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Model in sagemaker to populate modelName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicyResolutionEnum>))]
public enum V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicyResolveEnum>))]
public enum V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Model in sagemaker to populate modelName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameSelector
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
    public V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderProductionVariantsRoutingConfig
{
    /// <summary>How the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary>How an endpoint performs asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderProductionVariantsServerlessConfig
{
    /// <summary>Maximum number of concurrent invocations your serverless endpoint can process. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("maxConcurrency")]
    public double? MaxConcurrency { get; set; }

    /// <summary>Memory size of your serverless endpoint. Valid values are in 1 GB increments: 1024 MB, 2048 MB, 3072 MB, 4096 MB, 5120 MB, or 6144 MB.</summary>
    [JsonPropertyName("memorySizeInMb")]
    public double? MemorySizeInMb { get; set; }

    /// <summary>Amount of provisioned concurrency to allocate for the serverless endpoint. Should be less than or equal to max_concurrency. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("provisionedConcurrency")]
    public double? ProvisionedConcurrency { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderProductionVariants
{
    /// <summary>Size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public V1beta2EndpointConfigurationSpecForProviderProductionVariantsCoreDumpConfig? CoreDumpConfig { get; set; }

    /// <summary>Whether to turn on native AWS SSM access for a production variant behind an endpoint. By default, SSM access is disabled for all production variants behind endpoints. Ignored if model_name is not set (Inference Components endpoint).</summary>
    [JsonPropertyName("enableSsmAccess")]
    public bool? EnableSsmAccess { get; set; }

    /// <summary>Option from a collection of preconfigured AMI images. Each image is configured by AWS with a set of software and driver versions. AWS optimizes these configurations for different machine learning workloads.</summary>
    [JsonPropertyName("inferenceAmiVersion")]
    public string? InferenceAmiVersion { get; set; }

    /// <summary>Initial number of instances used for auto-scaling.</summary>
    [JsonPropertyName("initialInstanceCount")]
    public double? InitialInstanceCount { get; set; }

    /// <summary>Initial traffic distribution among all of the models that you specify in the endpoint configuration. If unspecified, defaults to 1.0. Ignored if model_name is not set (Inference Components endpoint).</summary>
    [JsonPropertyName("initialVariantWeight")]
    public double? InitialVariantWeight { get; set; }

    /// <summary>Type of instance to start.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
    [JsonPropertyName("managedInstanceScaling")]
    public V1beta2EndpointConfigurationSpecForProviderProductionVariantsManagedInstanceScaling? ManagedInstanceScaling { get; set; }

    /// <summary>Timeout value, in seconds, to download and extract the model that you want to host from S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>Name of the model to use. Required unless using Inference Components (in which case execution_role_arn must be specified at the endpoint configuration level).</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Reference to a Model in sagemaker to populate modelName.</summary>
    [JsonPropertyName("modelNameRef")]
    public V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameRef? ModelNameRef { get; set; }

    /// <summary>Selector for a Model in sagemaker to populate modelName.</summary>
    [JsonPropertyName("modelNameSelector")]
    public V1beta2EndpointConfigurationSpecForProviderProductionVariantsModelNameSelector? ModelNameSelector { get; set; }

    /// <summary>How the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta2EndpointConfigurationSpecForProviderProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public V1beta2EndpointConfigurationSpecForProviderProductionVariantsServerlessConfig? ServerlessConfig { get; set; }

    /// <summary>Name of the variant.</summary>
    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }

    /// <summary>Size, in GB, of the ML storage volume attached to individual inference instance associated with the production variant. Valid values between 1 and 512.</summary>
    [JsonPropertyName("volumeSizeInGb")]
    public double? VolumeSizeInGb { get; set; }
}

/// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderShadowProductionVariantsCoreDumpConfig
{
    /// <summary>S3 bucket to send the core dump to.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>KMS key that SageMaker AI uses to encrypt the core dump data at rest using S3 server-side encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>Control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderShadowProductionVariantsManagedInstanceScaling
{
    /// <summary>Maximum number of instances that the endpoint can provision when it scales up to accommodate an increase in traffic.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>Minimum number of instances that the endpoint must retain when it scales down to accommodate a decrease in traffic.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }

    /// <summary>Whether managed instance scaling is enabled. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderShadowProductionVariantsRoutingConfig
{
    /// <summary>How the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary>How an endpoint performs asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderShadowProductionVariantsServerlessConfig
{
    /// <summary>Maximum number of concurrent invocations your serverless endpoint can process. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("maxConcurrency")]
    public double? MaxConcurrency { get; set; }

    /// <summary>Memory size of your serverless endpoint. Valid values are in 1 GB increments: 1024 MB, 2048 MB, 3072 MB, 4096 MB, 5120 MB, or 6144 MB.</summary>
    [JsonPropertyName("memorySizeInMb")]
    public double? MemorySizeInMb { get; set; }

    /// <summary>Amount of provisioned concurrency to allocate for the serverless endpoint. Should be less than or equal to max_concurrency. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("provisionedConcurrency")]
    public double? ProvisionedConcurrency { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProviderShadowProductionVariants
{
    /// <summary>Size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public V1beta2EndpointConfigurationSpecForProviderShadowProductionVariantsCoreDumpConfig? CoreDumpConfig { get; set; }

    /// <summary>Whether to turn on native AWS SSM access for a production variant behind an endpoint. By default, SSM access is disabled for all production variants behind endpoints. Ignored if model_name is not set (Inference Components endpoint).</summary>
    [JsonPropertyName("enableSsmAccess")]
    public bool? EnableSsmAccess { get; set; }

    /// <summary>Option from a collection of preconfigured AMI images. Each image is configured by AWS with a set of software and driver versions. AWS optimizes these configurations for different machine learning workloads.</summary>
    [JsonPropertyName("inferenceAmiVersion")]
    public string? InferenceAmiVersion { get; set; }

    /// <summary>Initial number of instances used for auto-scaling.</summary>
    [JsonPropertyName("initialInstanceCount")]
    public double? InitialInstanceCount { get; set; }

    /// <summary>Initial traffic distribution among all of the models that you specify in the endpoint configuration. If unspecified, defaults to 1.0. Ignored if model_name is not set (Inference Components endpoint).</summary>
    [JsonPropertyName("initialVariantWeight")]
    public double? InitialVariantWeight { get; set; }

    /// <summary>Type of instance to start.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
    [JsonPropertyName("managedInstanceScaling")]
    public V1beta2EndpointConfigurationSpecForProviderShadowProductionVariantsManagedInstanceScaling? ManagedInstanceScaling { get; set; }

    /// <summary>Timeout value, in seconds, to download and extract the model that you want to host from S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>Name of the model to use. Required unless using Inference Components (in which case execution_role_arn must be specified at the endpoint configuration level).</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>How the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta2EndpointConfigurationSpecForProviderShadowProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public V1beta2EndpointConfigurationSpecForProviderShadowProductionVariantsServerlessConfig? ServerlessConfig { get; set; }

    /// <summary>Name of the variant.</summary>
    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }

    /// <summary>Size, in GB, of the ML storage volume attached to individual inference instance associated with the production variant. Valid values between 1 and 512.</summary>
    [JsonPropertyName("volumeSizeInGb")]
    public double? VolumeSizeInGb { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecForProvider
{
    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("asyncInferenceConfig")]
    public V1beta2EndpointConfigurationSpecForProviderAsyncInferenceConfig? AsyncInferenceConfig { get; set; }

    /// <summary>Parameters to capture input/output of SageMaker AI models endpoints. Fields are documented below.</summary>
    [JsonPropertyName("dataCaptureConfig")]
    public V1beta2EndpointConfigurationSpecForProviderDataCaptureConfig? DataCaptureConfig { get; set; }

    /// <summary>ARN of an IAM role that SageMaker AI can assume to perform actions on your behalf. Required when model_name is not specified in production_variants to support Inference Components.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta2EndpointConfigurationSpecForProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>ARN of a AWS KMS key that SageMaker AI uses to encrypt data on the storage volume attached to the ML compute instance that hosts the endpoint.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta2EndpointConfigurationSpecForProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta2EndpointConfigurationSpecForProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>List each model that you want to host at this endpoint. See below.</summary>
    [JsonPropertyName("productionVariants")]
    public IList<V1beta2EndpointConfigurationSpecForProviderProductionVariants>? ProductionVariants { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Models that you want to host at this endpoint in shadow mode with production traffic replicated from the model specified on production_variants. If you use this field, you can only specify one variant for production_variants and one variant for shadow_production_variants. See below (same arguments as production_variants).</summary>
    [JsonPropertyName("shadowProductionVariants")]
    public IList<V1beta2EndpointConfigurationSpecForProviderShadowProductionVariants>? ShadowProductionVariants { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Configures the behavior of the client used by SageMaker AI to interact with the model container during asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderAsyncInferenceConfigClientConfig
{
    /// <summary>Maximum number of concurrent requests sent by the SageMaker AI client to the model container. If no value is provided, SageMaker AI will choose an optimal value for you.</summary>
    [JsonPropertyName("maxConcurrentInvocationsPerInstance")]
    public double? MaxConcurrentInvocationsPerInstance { get; set; }
}

/// <summary>Configuration for notifications of inference results for asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderAsyncInferenceConfigOutputConfigNotificationConfig
{
    /// <summary>SNS topic to post a notification to when inference fails. If no topic is provided, no notification is sent on failure.</summary>
    [JsonPropertyName("errorTopic")]
    public string? ErrorTopic { get; set; }

    /// <summary>SNS topics where you want the inference response to be included. Valid values are SUCCESS_NOTIFICATION_TOPIC and ERROR_NOTIFICATION_TOPIC.</summary>
    [JsonPropertyName("includeInferenceResponseIn")]
    public IList<string>? IncludeInferenceResponseIn { get; set; }

    /// <summary>SNS topic to post a notification to when inference completes successfully. If no topic is provided, no notification is sent on success.</summary>
    [JsonPropertyName("successTopic")]
    public string? SuccessTopic { get; set; }
}

/// <summary>Configuration for asynchronous inference invocation outputs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderAsyncInferenceConfigOutputConfig
{
    /// <summary>KMS key that SageMaker AI uses to encrypt the asynchronous inference output in S3.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Configuration for notifications of inference results for asynchronous inference.</summary>
    [JsonPropertyName("notificationConfig")]
    public V1beta2EndpointConfigurationSpecInitProviderAsyncInferenceConfigOutputConfigNotificationConfig? NotificationConfig { get; set; }

    /// <summary>S3 location to upload failure inference responses to.</summary>
    [JsonPropertyName("s3FailurePath")]
    public string? S3FailurePath { get; set; }

    /// <summary>S3 location to upload inference responses to.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>How an endpoint performs asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderAsyncInferenceConfig
{
    /// <summary>Configures the behavior of the client used by SageMaker AI to interact with the model container during asynchronous inference.</summary>
    [JsonPropertyName("clientConfig")]
    public V1beta2EndpointConfigurationSpecInitProviderAsyncInferenceConfigClientConfig? ClientConfig { get; set; }

    /// <summary>Configuration for asynchronous inference invocation outputs.</summary>
    [JsonPropertyName("outputConfig")]
    public V1beta2EndpointConfigurationSpecInitProviderAsyncInferenceConfigOutputConfig? OutputConfig { get; set; }
}

/// <summary>Content type headers to capture. See capture_content_type_header below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderDataCaptureConfigCaptureContentTypeHeader
{
    /// <summary>CSV content type headers to capture. One of csv_content_types or json_content_types is required.</summary>
    [JsonPropertyName("csvContentTypes")]
    public IList<string>? CsvContentTypes { get; set; }

    /// <summary>The JSON content type headers to capture. One of json_content_types or csv_content_types is required.</summary>
    [JsonPropertyName("jsonContentTypes")]
    public IList<string>? JsonContentTypes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderDataCaptureConfigCaptureOptions
{
    /// <summary>Data to be captured. Should be one of Input, Output or InputAndOutput.</summary>
    [JsonPropertyName("captureMode")]
    public string? CaptureMode { get; set; }
}

/// <summary>Parameters to capture input/output of SageMaker AI models endpoints. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderDataCaptureConfig
{
    /// <summary>Content type headers to capture. See capture_content_type_header below.</summary>
    [JsonPropertyName("captureContentTypeHeader")]
    public V1beta2EndpointConfigurationSpecInitProviderDataCaptureConfigCaptureContentTypeHeader? CaptureContentTypeHeader { get; set; }

    /// <summary>What data to capture. Fields are documented below.</summary>
    [JsonPropertyName("captureOptions")]
    public IList<V1beta2EndpointConfigurationSpecInitProviderDataCaptureConfigCaptureOptions>? CaptureOptions { get; set; }

    /// <summary>URL for S3 location where the captured data is stored.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>Flag to enable data capture. Defaults to false.</summary>
    [JsonPropertyName("enableCapture")]
    public bool? EnableCapture { get; set; }

    /// <summary>Portion of data to capture. Should be between 0 and 100.</summary>
    [JsonPropertyName("initialSamplingPercentage")]
    public double? InitialSamplingPercentage { get; set; }

    /// <summary>ARN of a KMS key that SageMaker AI uses to encrypt the captured data on S3.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnSelector
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
    public V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnSelector
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
    public V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderProductionVariantsCoreDumpConfig
{
    /// <summary>S3 bucket to send the core dump to.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>KMS key that SageMaker AI uses to encrypt the core dump data at rest using S3 server-side encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>Control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderProductionVariantsManagedInstanceScaling
{
    /// <summary>Maximum number of instances that the endpoint can provision when it scales up to accommodate an increase in traffic.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>Minimum number of instances that the endpoint must retain when it scales down to accommodate a decrease in traffic.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }

    /// <summary>Whether managed instance scaling is enabled. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicyResolutionEnum>))]
public enum V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicyResolveEnum>))]
public enum V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Model in sagemaker to populate modelName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicyResolutionEnum>))]
public enum V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicyResolveEnum>))]
public enum V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Model in sagemaker to populate modelName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelector
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
    public V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderProductionVariantsRoutingConfig
{
    /// <summary>How the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary>How an endpoint performs asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderProductionVariantsServerlessConfig
{
    /// <summary>Maximum number of concurrent invocations your serverless endpoint can process. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("maxConcurrency")]
    public double? MaxConcurrency { get; set; }

    /// <summary>Memory size of your serverless endpoint. Valid values are in 1 GB increments: 1024 MB, 2048 MB, 3072 MB, 4096 MB, 5120 MB, or 6144 MB.</summary>
    [JsonPropertyName("memorySizeInMb")]
    public double? MemorySizeInMb { get; set; }

    /// <summary>Amount of provisioned concurrency to allocate for the serverless endpoint. Should be less than or equal to max_concurrency. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("provisionedConcurrency")]
    public double? ProvisionedConcurrency { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderProductionVariants
{
    /// <summary>Size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public V1beta2EndpointConfigurationSpecInitProviderProductionVariantsCoreDumpConfig? CoreDumpConfig { get; set; }

    /// <summary>Whether to turn on native AWS SSM access for a production variant behind an endpoint. By default, SSM access is disabled for all production variants behind endpoints. Ignored if model_name is not set (Inference Components endpoint).</summary>
    [JsonPropertyName("enableSsmAccess")]
    public bool? EnableSsmAccess { get; set; }

    /// <summary>Option from a collection of preconfigured AMI images. Each image is configured by AWS with a set of software and driver versions. AWS optimizes these configurations for different machine learning workloads.</summary>
    [JsonPropertyName("inferenceAmiVersion")]
    public string? InferenceAmiVersion { get; set; }

    /// <summary>Initial number of instances used for auto-scaling.</summary>
    [JsonPropertyName("initialInstanceCount")]
    public double? InitialInstanceCount { get; set; }

    /// <summary>Initial traffic distribution among all of the models that you specify in the endpoint configuration. If unspecified, defaults to 1.0. Ignored if model_name is not set (Inference Components endpoint).</summary>
    [JsonPropertyName("initialVariantWeight")]
    public double? InitialVariantWeight { get; set; }

    /// <summary>Type of instance to start.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
    [JsonPropertyName("managedInstanceScaling")]
    public V1beta2EndpointConfigurationSpecInitProviderProductionVariantsManagedInstanceScaling? ManagedInstanceScaling { get; set; }

    /// <summary>Timeout value, in seconds, to download and extract the model that you want to host from S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>Name of the model to use. Required unless using Inference Components (in which case execution_role_arn must be specified at the endpoint configuration level).</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Reference to a Model in sagemaker to populate modelName.</summary>
    [JsonPropertyName("modelNameRef")]
    public V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameRef? ModelNameRef { get; set; }

    /// <summary>Selector for a Model in sagemaker to populate modelName.</summary>
    [JsonPropertyName("modelNameSelector")]
    public V1beta2EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelector? ModelNameSelector { get; set; }

    /// <summary>How the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta2EndpointConfigurationSpecInitProviderProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public V1beta2EndpointConfigurationSpecInitProviderProductionVariantsServerlessConfig? ServerlessConfig { get; set; }

    /// <summary>Name of the variant.</summary>
    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }

    /// <summary>Size, in GB, of the ML storage volume attached to individual inference instance associated with the production variant. Valid values between 1 and 512.</summary>
    [JsonPropertyName("volumeSizeInGb")]
    public double? VolumeSizeInGb { get; set; }
}

/// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderShadowProductionVariantsCoreDumpConfig
{
    /// <summary>S3 bucket to send the core dump to.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>KMS key that SageMaker AI uses to encrypt the core dump data at rest using S3 server-side encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>Control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderShadowProductionVariantsManagedInstanceScaling
{
    /// <summary>Maximum number of instances that the endpoint can provision when it scales up to accommodate an increase in traffic.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>Minimum number of instances that the endpoint must retain when it scales down to accommodate a decrease in traffic.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }

    /// <summary>Whether managed instance scaling is enabled. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderShadowProductionVariantsRoutingConfig
{
    /// <summary>How the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary>How an endpoint performs asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderShadowProductionVariantsServerlessConfig
{
    /// <summary>Maximum number of concurrent invocations your serverless endpoint can process. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("maxConcurrency")]
    public double? MaxConcurrency { get; set; }

    /// <summary>Memory size of your serverless endpoint. Valid values are in 1 GB increments: 1024 MB, 2048 MB, 3072 MB, 4096 MB, 5120 MB, or 6144 MB.</summary>
    [JsonPropertyName("memorySizeInMb")]
    public double? MemorySizeInMb { get; set; }

    /// <summary>Amount of provisioned concurrency to allocate for the serverless endpoint. Should be less than or equal to max_concurrency. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("provisionedConcurrency")]
    public double? ProvisionedConcurrency { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecInitProviderShadowProductionVariants
{
    /// <summary>Size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public V1beta2EndpointConfigurationSpecInitProviderShadowProductionVariantsCoreDumpConfig? CoreDumpConfig { get; set; }

    /// <summary>Whether to turn on native AWS SSM access for a production variant behind an endpoint. By default, SSM access is disabled for all production variants behind endpoints. Ignored if model_name is not set (Inference Components endpoint).</summary>
    [JsonPropertyName("enableSsmAccess")]
    public bool? EnableSsmAccess { get; set; }

    /// <summary>Option from a collection of preconfigured AMI images. Each image is configured by AWS with a set of software and driver versions. AWS optimizes these configurations for different machine learning workloads.</summary>
    [JsonPropertyName("inferenceAmiVersion")]
    public string? InferenceAmiVersion { get; set; }

    /// <summary>Initial number of instances used for auto-scaling.</summary>
    [JsonPropertyName("initialInstanceCount")]
    public double? InitialInstanceCount { get; set; }

    /// <summary>Initial traffic distribution among all of the models that you specify in the endpoint configuration. If unspecified, defaults to 1.0. Ignored if model_name is not set (Inference Components endpoint).</summary>
    [JsonPropertyName("initialVariantWeight")]
    public double? InitialVariantWeight { get; set; }

    /// <summary>Type of instance to start.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
    [JsonPropertyName("managedInstanceScaling")]
    public V1beta2EndpointConfigurationSpecInitProviderShadowProductionVariantsManagedInstanceScaling? ManagedInstanceScaling { get; set; }

    /// <summary>Timeout value, in seconds, to download and extract the model that you want to host from S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>Name of the model to use. Required unless using Inference Components (in which case execution_role_arn must be specified at the endpoint configuration level).</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>How the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta2EndpointConfigurationSpecInitProviderShadowProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public V1beta2EndpointConfigurationSpecInitProviderShadowProductionVariantsServerlessConfig? ServerlessConfig { get; set; }

    /// <summary>Name of the variant.</summary>
    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }

    /// <summary>Size, in GB, of the ML storage volume attached to individual inference instance associated with the production variant. Valid values between 1 and 512.</summary>
    [JsonPropertyName("volumeSizeInGb")]
    public double? VolumeSizeInGb { get; set; }
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
public partial class V1beta2EndpointConfigurationSpecInitProvider
{
    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("asyncInferenceConfig")]
    public V1beta2EndpointConfigurationSpecInitProviderAsyncInferenceConfig? AsyncInferenceConfig { get; set; }

    /// <summary>Parameters to capture input/output of SageMaker AI models endpoints. Fields are documented below.</summary>
    [JsonPropertyName("dataCaptureConfig")]
    public V1beta2EndpointConfigurationSpecInitProviderDataCaptureConfig? DataCaptureConfig { get; set; }

    /// <summary>ARN of an IAM role that SageMaker AI can assume to perform actions on your behalf. Required when model_name is not specified in production_variants to support Inference Components.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta2EndpointConfigurationSpecInitProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>ARN of a AWS KMS key that SageMaker AI uses to encrypt data on the storage volume attached to the ML compute instance that hosts the endpoint.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta2EndpointConfigurationSpecInitProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>List each model that you want to host at this endpoint. See below.</summary>
    [JsonPropertyName("productionVariants")]
    public IList<V1beta2EndpointConfigurationSpecInitProviderProductionVariants>? ProductionVariants { get; set; }

    /// <summary>Models that you want to host at this endpoint in shadow mode with production traffic replicated from the model specified on production_variants. If you use this field, you can only specify one variant for production_variants and one variant for shadow_production_variants. See below (same arguments as production_variants).</summary>
    [JsonPropertyName("shadowProductionVariants")]
    public IList<V1beta2EndpointConfigurationSpecInitProviderShadowProductionVariants>? ShadowProductionVariants { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecManagementPoliciesEnum>))]
public enum V1beta2EndpointConfigurationSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2EndpointConfigurationSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2EndpointConfigurationSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2EndpointConfigurationSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2EndpointConfigurationSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2EndpointConfigurationSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2EndpointConfigurationSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>EndpointConfigurationSpec defines the desired state of EndpointConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationSpec
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
    public V1beta2EndpointConfigurationSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2EndpointConfigurationSpecForProvider ForProvider { get; set; }

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
    public V1beta2EndpointConfigurationSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2EndpointConfigurationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2EndpointConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2EndpointConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configures the behavior of the client used by SageMaker AI to interact with the model container during asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProviderAsyncInferenceConfigClientConfig
{
    /// <summary>Maximum number of concurrent requests sent by the SageMaker AI client to the model container. If no value is provided, SageMaker AI will choose an optimal value for you.</summary>
    [JsonPropertyName("maxConcurrentInvocationsPerInstance")]
    public double? MaxConcurrentInvocationsPerInstance { get; set; }
}

/// <summary>Configuration for notifications of inference results for asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProviderAsyncInferenceConfigOutputConfigNotificationConfig
{
    /// <summary>SNS topic to post a notification to when inference fails. If no topic is provided, no notification is sent on failure.</summary>
    [JsonPropertyName("errorTopic")]
    public string? ErrorTopic { get; set; }

    /// <summary>SNS topics where you want the inference response to be included. Valid values are SUCCESS_NOTIFICATION_TOPIC and ERROR_NOTIFICATION_TOPIC.</summary>
    [JsonPropertyName("includeInferenceResponseIn")]
    public IList<string>? IncludeInferenceResponseIn { get; set; }

    /// <summary>SNS topic to post a notification to when inference completes successfully. If no topic is provided, no notification is sent on success.</summary>
    [JsonPropertyName("successTopic")]
    public string? SuccessTopic { get; set; }
}

/// <summary>Configuration for asynchronous inference invocation outputs.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProviderAsyncInferenceConfigOutputConfig
{
    /// <summary>KMS key that SageMaker AI uses to encrypt the asynchronous inference output in S3.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Configuration for notifications of inference results for asynchronous inference.</summary>
    [JsonPropertyName("notificationConfig")]
    public V1beta2EndpointConfigurationStatusAtProviderAsyncInferenceConfigOutputConfigNotificationConfig? NotificationConfig { get; set; }

    /// <summary>S3 location to upload failure inference responses to.</summary>
    [JsonPropertyName("s3FailurePath")]
    public string? S3FailurePath { get; set; }

    /// <summary>S3 location to upload inference responses to.</summary>
    [JsonPropertyName("s3OutputPath")]
    public string? S3OutputPath { get; set; }
}

/// <summary>How an endpoint performs asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProviderAsyncInferenceConfig
{
    /// <summary>Configures the behavior of the client used by SageMaker AI to interact with the model container during asynchronous inference.</summary>
    [JsonPropertyName("clientConfig")]
    public V1beta2EndpointConfigurationStatusAtProviderAsyncInferenceConfigClientConfig? ClientConfig { get; set; }

    /// <summary>Configuration for asynchronous inference invocation outputs.</summary>
    [JsonPropertyName("outputConfig")]
    public V1beta2EndpointConfigurationStatusAtProviderAsyncInferenceConfigOutputConfig? OutputConfig { get; set; }
}

/// <summary>Content type headers to capture. See capture_content_type_header below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProviderDataCaptureConfigCaptureContentTypeHeader
{
    /// <summary>CSV content type headers to capture. One of csv_content_types or json_content_types is required.</summary>
    [JsonPropertyName("csvContentTypes")]
    public IList<string>? CsvContentTypes { get; set; }

    /// <summary>The JSON content type headers to capture. One of json_content_types or csv_content_types is required.</summary>
    [JsonPropertyName("jsonContentTypes")]
    public IList<string>? JsonContentTypes { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProviderDataCaptureConfigCaptureOptions
{
    /// <summary>Data to be captured. Should be one of Input, Output or InputAndOutput.</summary>
    [JsonPropertyName("captureMode")]
    public string? CaptureMode { get; set; }
}

/// <summary>Parameters to capture input/output of SageMaker AI models endpoints. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProviderDataCaptureConfig
{
    /// <summary>Content type headers to capture. See capture_content_type_header below.</summary>
    [JsonPropertyName("captureContentTypeHeader")]
    public V1beta2EndpointConfigurationStatusAtProviderDataCaptureConfigCaptureContentTypeHeader? CaptureContentTypeHeader { get; set; }

    /// <summary>What data to capture. Fields are documented below.</summary>
    [JsonPropertyName("captureOptions")]
    public IList<V1beta2EndpointConfigurationStatusAtProviderDataCaptureConfigCaptureOptions>? CaptureOptions { get; set; }

    /// <summary>URL for S3 location where the captured data is stored.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>Flag to enable data capture. Defaults to false.</summary>
    [JsonPropertyName("enableCapture")]
    public bool? EnableCapture { get; set; }

    /// <summary>Portion of data to capture. Should be between 0 and 100.</summary>
    [JsonPropertyName("initialSamplingPercentage")]
    public double? InitialSamplingPercentage { get; set; }

    /// <summary>ARN of a KMS key that SageMaker AI uses to encrypt the captured data on S3.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProviderProductionVariantsCoreDumpConfig
{
    /// <summary>S3 bucket to send the core dump to.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>KMS key that SageMaker AI uses to encrypt the core dump data at rest using S3 server-side encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>Control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProviderProductionVariantsManagedInstanceScaling
{
    /// <summary>Maximum number of instances that the endpoint can provision when it scales up to accommodate an increase in traffic.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>Minimum number of instances that the endpoint must retain when it scales down to accommodate a decrease in traffic.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }

    /// <summary>Whether managed instance scaling is enabled. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProviderProductionVariantsRoutingConfig
{
    /// <summary>How the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary>How an endpoint performs asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProviderProductionVariantsServerlessConfig
{
    /// <summary>Maximum number of concurrent invocations your serverless endpoint can process. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("maxConcurrency")]
    public double? MaxConcurrency { get; set; }

    /// <summary>Memory size of your serverless endpoint. Valid values are in 1 GB increments: 1024 MB, 2048 MB, 3072 MB, 4096 MB, 5120 MB, or 6144 MB.</summary>
    [JsonPropertyName("memorySizeInMb")]
    public double? MemorySizeInMb { get; set; }

    /// <summary>Amount of provisioned concurrency to allocate for the serverless endpoint. Should be less than or equal to max_concurrency. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("provisionedConcurrency")]
    public double? ProvisionedConcurrency { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProviderProductionVariants
{
    /// <summary>Size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public V1beta2EndpointConfigurationStatusAtProviderProductionVariantsCoreDumpConfig? CoreDumpConfig { get; set; }

    /// <summary>Whether to turn on native AWS SSM access for a production variant behind an endpoint. By default, SSM access is disabled for all production variants behind endpoints. Ignored if model_name is not set (Inference Components endpoint).</summary>
    [JsonPropertyName("enableSsmAccess")]
    public bool? EnableSsmAccess { get; set; }

    /// <summary>Option from a collection of preconfigured AMI images. Each image is configured by AWS with a set of software and driver versions. AWS optimizes these configurations for different machine learning workloads.</summary>
    [JsonPropertyName("inferenceAmiVersion")]
    public string? InferenceAmiVersion { get; set; }

    /// <summary>Initial number of instances used for auto-scaling.</summary>
    [JsonPropertyName("initialInstanceCount")]
    public double? InitialInstanceCount { get; set; }

    /// <summary>Initial traffic distribution among all of the models that you specify in the endpoint configuration. If unspecified, defaults to 1.0. Ignored if model_name is not set (Inference Components endpoint).</summary>
    [JsonPropertyName("initialVariantWeight")]
    public double? InitialVariantWeight { get; set; }

    /// <summary>Type of instance to start.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
    [JsonPropertyName("managedInstanceScaling")]
    public V1beta2EndpointConfigurationStatusAtProviderProductionVariantsManagedInstanceScaling? ManagedInstanceScaling { get; set; }

    /// <summary>Timeout value, in seconds, to download and extract the model that you want to host from S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>Name of the model to use. Required unless using Inference Components (in which case execution_role_arn must be specified at the endpoint configuration level).</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>How the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta2EndpointConfigurationStatusAtProviderProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public V1beta2EndpointConfigurationStatusAtProviderProductionVariantsServerlessConfig? ServerlessConfig { get; set; }

    /// <summary>Name of the variant.</summary>
    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }

    /// <summary>Size, in GB, of the ML storage volume attached to individual inference instance associated with the production variant. Valid values between 1 and 512.</summary>
    [JsonPropertyName("volumeSizeInGb")]
    public double? VolumeSizeInGb { get; set; }
}

/// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProviderShadowProductionVariantsCoreDumpConfig
{
    /// <summary>S3 bucket to send the core dump to.</summary>
    [JsonPropertyName("destinationS3Uri")]
    public string? DestinationS3Uri { get; set; }

    /// <summary>KMS key that SageMaker AI uses to encrypt the core dump data at rest using S3 server-side encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }
}

/// <summary>Control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProviderShadowProductionVariantsManagedInstanceScaling
{
    /// <summary>Maximum number of instances that the endpoint can provision when it scales up to accommodate an increase in traffic.</summary>
    [JsonPropertyName("maxInstanceCount")]
    public double? MaxInstanceCount { get; set; }

    /// <summary>Minimum number of instances that the endpoint must retain when it scales down to accommodate a decrease in traffic.</summary>
    [JsonPropertyName("minInstanceCount")]
    public double? MinInstanceCount { get; set; }

    /// <summary>Whether managed instance scaling is enabled. Valid values are ENABLED and DISABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProviderShadowProductionVariantsRoutingConfig
{
    /// <summary>How the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary>How an endpoint performs asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProviderShadowProductionVariantsServerlessConfig
{
    /// <summary>Maximum number of concurrent invocations your serverless endpoint can process. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("maxConcurrency")]
    public double? MaxConcurrency { get; set; }

    /// <summary>Memory size of your serverless endpoint. Valid values are in 1 GB increments: 1024 MB, 2048 MB, 3072 MB, 4096 MB, 5120 MB, or 6144 MB.</summary>
    [JsonPropertyName("memorySizeInMb")]
    public double? MemorySizeInMb { get; set; }

    /// <summary>Amount of provisioned concurrency to allocate for the serverless endpoint. Should be less than or equal to max_concurrency. Valid values are between 1 and 200.</summary>
    [JsonPropertyName("provisionedConcurrency")]
    public double? ProvisionedConcurrency { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProviderShadowProductionVariants
{
    /// <summary>Size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public V1beta2EndpointConfigurationStatusAtProviderShadowProductionVariantsCoreDumpConfig? CoreDumpConfig { get; set; }

    /// <summary>Whether to turn on native AWS SSM access for a production variant behind an endpoint. By default, SSM access is disabled for all production variants behind endpoints. Ignored if model_name is not set (Inference Components endpoint).</summary>
    [JsonPropertyName("enableSsmAccess")]
    public bool? EnableSsmAccess { get; set; }

    /// <summary>Option from a collection of preconfigured AMI images. Each image is configured by AWS with a set of software and driver versions. AWS optimizes these configurations for different machine learning workloads.</summary>
    [JsonPropertyName("inferenceAmiVersion")]
    public string? InferenceAmiVersion { get; set; }

    /// <summary>Initial number of instances used for auto-scaling.</summary>
    [JsonPropertyName("initialInstanceCount")]
    public double? InitialInstanceCount { get; set; }

    /// <summary>Initial traffic distribution among all of the models that you specify in the endpoint configuration. If unspecified, defaults to 1.0. Ignored if model_name is not set (Inference Components endpoint).</summary>
    [JsonPropertyName("initialVariantWeight")]
    public double? InitialVariantWeight { get; set; }

    /// <summary>Type of instance to start.</summary>
    [JsonPropertyName("instanceType")]
    public string? InstanceType { get; set; }

    /// <summary>Control the range in the number of instances that the endpoint provisions as it scales up or down to accommodate traffic.</summary>
    [JsonPropertyName("managedInstanceScaling")]
    public V1beta2EndpointConfigurationStatusAtProviderShadowProductionVariantsManagedInstanceScaling? ManagedInstanceScaling { get; set; }

    /// <summary>Timeout value, in seconds, to download and extract the model that you want to host from S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>Name of the model to use. Required unless using Inference Components (in which case execution_role_arn must be specified at the endpoint configuration level).</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>How the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta2EndpointConfigurationStatusAtProviderShadowProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public V1beta2EndpointConfigurationStatusAtProviderShadowProductionVariantsServerlessConfig? ServerlessConfig { get; set; }

    /// <summary>Name of the variant.</summary>
    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }

    /// <summary>Size, in GB, of the ML storage volume attached to individual inference instance associated with the production variant. Valid values between 1 and 512.</summary>
    [JsonPropertyName("volumeSizeInGb")]
    public double? VolumeSizeInGb { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusAtProvider
{
    /// <summary>ARN assigned by AWS to this endpoint configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("asyncInferenceConfig")]
    public V1beta2EndpointConfigurationStatusAtProviderAsyncInferenceConfig? AsyncInferenceConfig { get; set; }

    /// <summary>Parameters to capture input/output of SageMaker AI models endpoints. Fields are documented below.</summary>
    [JsonPropertyName("dataCaptureConfig")]
    public V1beta2EndpointConfigurationStatusAtProviderDataCaptureConfig? DataCaptureConfig { get; set; }

    /// <summary>ARN of an IAM role that SageMaker AI can assume to perform actions on your behalf. Required when model_name is not specified in production_variants to support Inference Components.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN of a AWS KMS key that SageMaker AI uses to encrypt data on the storage volume attached to the ML compute instance that hosts the endpoint.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>List each model that you want to host at this endpoint. See below.</summary>
    [JsonPropertyName("productionVariants")]
    public IList<V1beta2EndpointConfigurationStatusAtProviderProductionVariants>? ProductionVariants { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Models that you want to host at this endpoint in shadow mode with production traffic replicated from the model specified on production_variants. If you use this field, you can only specify one variant for production_variants and one variant for shadow_production_variants. See below (same arguments as production_variants).</summary>
    [JsonPropertyName("shadowProductionVariants")]
    public IList<V1beta2EndpointConfigurationStatusAtProviderShadowProductionVariants>? ShadowProductionVariants { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatusConditions
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

/// <summary>EndpointConfigurationStatus defines the observed state of EndpointConfiguration.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2EndpointConfigurationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2EndpointConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2EndpointConfigurationStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>EndpointConfiguration is the Schema for the EndpointConfigurations API. Provides a SageMaker AI Endpoint Configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2EndpointConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2EndpointConfigurationSpec>, IStatus<V1beta2EndpointConfigurationStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "EndpointConfiguration";
    public const string KubeGroup = "sagemaker.aws.upbound.io";
    public const string KubePluralName = "endpointconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EndpointConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EndpointConfigurationSpec defines the desired state of EndpointConfiguration</summary>
    [JsonPropertyName("spec")]
    public required V1beta2EndpointConfigurationSpec Spec { get; set; }

    /// <summary>EndpointConfigurationStatus defines the observed state of EndpointConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta2EndpointConfigurationStatus? Status { get; set; }
}