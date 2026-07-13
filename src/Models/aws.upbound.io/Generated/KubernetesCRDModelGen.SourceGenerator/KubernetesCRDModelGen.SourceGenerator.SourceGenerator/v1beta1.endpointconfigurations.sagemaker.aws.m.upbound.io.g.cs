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
/// <summary>EndpointConfiguration is the Schema for the EndpointConfigurations API. Provides a SageMaker AI Endpoint Configuration resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1EndpointConfigurationList : IKubernetesObject<V1ListMeta>, IItems<V1beta1EndpointConfiguration>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EndpointConfigurationList";
    public const string KubeGroup = "sagemaker.aws.m.upbound.io";
    public const string KubePluralName = "endpointconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EndpointConfigurationList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1EndpointConfiguration objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1EndpointConfiguration> Items { get; set; }
}

/// <summary>Configures the behavior of the client used by SageMaker AI to interact with the model container during asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderAsyncInferenceConfigClientConfig
{
    /// <summary>Maximum number of concurrent requests sent by the SageMaker AI client to the model container. If no value is provided, SageMaker AI will choose an optimal value for you.</summary>
    [JsonPropertyName("maxConcurrentInvocationsPerInstance")]
    public double? MaxConcurrentInvocationsPerInstance { get; set; }
}

/// <summary>Configuration for notifications of inference results for asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderAsyncInferenceConfigOutputConfigNotificationConfig
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
public partial class V1beta1EndpointConfigurationSpecForProviderAsyncInferenceConfigOutputConfig
{
    /// <summary>KMS key that SageMaker AI uses to encrypt the asynchronous inference output in S3.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Configuration for notifications of inference results for asynchronous inference.</summary>
    [JsonPropertyName("notificationConfig")]
    public V1beta1EndpointConfigurationSpecForProviderAsyncInferenceConfigOutputConfigNotificationConfig? NotificationConfig { get; set; }

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
public partial class V1beta1EndpointConfigurationSpecForProviderAsyncInferenceConfig
{
    /// <summary>Configures the behavior of the client used by SageMaker AI to interact with the model container during asynchronous inference.</summary>
    [JsonPropertyName("clientConfig")]
    public V1beta1EndpointConfigurationSpecForProviderAsyncInferenceConfigClientConfig? ClientConfig { get; set; }

    /// <summary>Configuration for asynchronous inference invocation outputs.</summary>
    [JsonPropertyName("outputConfig")]
    public V1beta1EndpointConfigurationSpecForProviderAsyncInferenceConfigOutputConfig? OutputConfig { get; set; }
}

/// <summary>Content type headers to capture. See capture_content_type_header below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderDataCaptureConfigCaptureContentTypeHeader
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
public partial class V1beta1EndpointConfigurationSpecForProviderDataCaptureConfigCaptureOptions
{
    /// <summary>Data to be captured. Should be one of Input, Output or InputAndOutput.</summary>
    [JsonPropertyName("captureMode")]
    public string? CaptureMode { get; set; }
}

/// <summary>Parameters to capture input/output of SageMaker AI models endpoints. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderDataCaptureConfig
{
    /// <summary>Content type headers to capture. See capture_content_type_header below.</summary>
    [JsonPropertyName("captureContentTypeHeader")]
    public V1beta1EndpointConfigurationSpecForProviderDataCaptureConfigCaptureContentTypeHeader? CaptureContentTypeHeader { get; set; }

    /// <summary>What data to capture. Fields are documented below.</summary>
    [JsonPropertyName("captureOptions")]
    public IList<V1beta1EndpointConfigurationSpecForProviderDataCaptureConfigCaptureOptions>? CaptureOptions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnSelector
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
    public V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecForProviderKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1EndpointConfigurationSpecForProviderKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecForProviderKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1EndpointConfigurationSpecForProviderKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EndpointConfigurationSpecForProviderKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EndpointConfigurationSpecForProviderKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointConfigurationSpecForProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderKmsKeyArnSelector
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
    public V1beta1EndpointConfigurationSpecForProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariantsCoreDumpConfig
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
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariantsManagedInstanceScaling
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicyResolutionEnum>))]
public enum V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicyResolveEnum>))]
public enum V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Model in sagemaker to populate modelName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicyResolutionEnum>))]
public enum V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicyResolveEnum>))]
public enum V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Model in sagemaker to populate modelName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameSelector
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
    public V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariantsRoutingConfig
{
    /// <summary>How the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary>How an endpoint performs asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariantsServerlessConfig
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
public partial class V1beta1EndpointConfigurationSpecForProviderProductionVariants
{
    /// <summary>Size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public V1beta1EndpointConfigurationSpecForProviderProductionVariantsCoreDumpConfig? CoreDumpConfig { get; set; }

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
    public V1beta1EndpointConfigurationSpecForProviderProductionVariantsManagedInstanceScaling? ManagedInstanceScaling { get; set; }

    /// <summary>Timeout value, in seconds, to download and extract the model that you want to host from S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>Name of the model to use. Required unless using Inference Components (in which case execution_role_arn must be specified at the endpoint configuration level).</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Reference to a Model in sagemaker to populate modelName.</summary>
    [JsonPropertyName("modelNameRef")]
    public V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameRef? ModelNameRef { get; set; }

    /// <summary>Selector for a Model in sagemaker to populate modelName.</summary>
    [JsonPropertyName("modelNameSelector")]
    public V1beta1EndpointConfigurationSpecForProviderProductionVariantsModelNameSelector? ModelNameSelector { get; set; }

    /// <summary>How the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta1EndpointConfigurationSpecForProviderProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public V1beta1EndpointConfigurationSpecForProviderProductionVariantsServerlessConfig? ServerlessConfig { get; set; }

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
public partial class V1beta1EndpointConfigurationSpecForProviderShadowProductionVariantsCoreDumpConfig
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
public partial class V1beta1EndpointConfigurationSpecForProviderShadowProductionVariantsManagedInstanceScaling
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
public partial class V1beta1EndpointConfigurationSpecForProviderShadowProductionVariantsRoutingConfig
{
    /// <summary>How the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary>How an endpoint performs asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProviderShadowProductionVariantsServerlessConfig
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
public partial class V1beta1EndpointConfigurationSpecForProviderShadowProductionVariants
{
    /// <summary>Size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public V1beta1EndpointConfigurationSpecForProviderShadowProductionVariantsCoreDumpConfig? CoreDumpConfig { get; set; }

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
    public V1beta1EndpointConfigurationSpecForProviderShadowProductionVariantsManagedInstanceScaling? ManagedInstanceScaling { get; set; }

    /// <summary>Timeout value, in seconds, to download and extract the model that you want to host from S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>Name of the model to use. Required unless using Inference Components (in which case execution_role_arn must be specified at the endpoint configuration level).</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>How the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta1EndpointConfigurationSpecForProviderShadowProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public V1beta1EndpointConfigurationSpecForProviderShadowProductionVariantsServerlessConfig? ServerlessConfig { get; set; }

    /// <summary>Name of the variant.</summary>
    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }

    /// <summary>Size, in GB, of the ML storage volume attached to individual inference instance associated with the production variant. Valid values between 1 and 512.</summary>
    [JsonPropertyName("volumeSizeInGb")]
    public double? VolumeSizeInGb { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecForProvider
{
    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("asyncInferenceConfig")]
    public V1beta1EndpointConfigurationSpecForProviderAsyncInferenceConfig? AsyncInferenceConfig { get; set; }

    /// <summary>Parameters to capture input/output of SageMaker AI models endpoints. Fields are documented below.</summary>
    [JsonPropertyName("dataCaptureConfig")]
    public V1beta1EndpointConfigurationSpecForProviderDataCaptureConfig? DataCaptureConfig { get; set; }

    /// <summary>ARN of an IAM role that SageMaker AI can assume to perform actions on your behalf. Required when model_name is not specified in production_variants to support Inference Components.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta1EndpointConfigurationSpecForProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>ARN of a AWS KMS key that SageMaker AI uses to encrypt data on the storage volume attached to the ML compute instance that hosts the endpoint.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1EndpointConfigurationSpecForProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1EndpointConfigurationSpecForProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>List each model that you want to host at this endpoint. See below.</summary>
    [JsonPropertyName("productionVariants")]
    public IList<V1beta1EndpointConfigurationSpecForProviderProductionVariants>? ProductionVariants { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Models that you want to host at this endpoint in shadow mode with production traffic replicated from the model specified on production_variants. If you use this field, you can only specify one variant for production_variants and one variant for shadow_production_variants. See below (same arguments as production_variants).</summary>
    [JsonPropertyName("shadowProductionVariants")]
    public IList<V1beta1EndpointConfigurationSpecForProviderShadowProductionVariants>? ShadowProductionVariants { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Configures the behavior of the client used by SageMaker AI to interact with the model container during asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderAsyncInferenceConfigClientConfig
{
    /// <summary>Maximum number of concurrent requests sent by the SageMaker AI client to the model container. If no value is provided, SageMaker AI will choose an optimal value for you.</summary>
    [JsonPropertyName("maxConcurrentInvocationsPerInstance")]
    public double? MaxConcurrentInvocationsPerInstance { get; set; }
}

/// <summary>Configuration for notifications of inference results for asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderAsyncInferenceConfigOutputConfigNotificationConfig
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
public partial class V1beta1EndpointConfigurationSpecInitProviderAsyncInferenceConfigOutputConfig
{
    /// <summary>KMS key that SageMaker AI uses to encrypt the asynchronous inference output in S3.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Configuration for notifications of inference results for asynchronous inference.</summary>
    [JsonPropertyName("notificationConfig")]
    public V1beta1EndpointConfigurationSpecInitProviderAsyncInferenceConfigOutputConfigNotificationConfig? NotificationConfig { get; set; }

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
public partial class V1beta1EndpointConfigurationSpecInitProviderAsyncInferenceConfig
{
    /// <summary>Configures the behavior of the client used by SageMaker AI to interact with the model container during asynchronous inference.</summary>
    [JsonPropertyName("clientConfig")]
    public V1beta1EndpointConfigurationSpecInitProviderAsyncInferenceConfigClientConfig? ClientConfig { get; set; }

    /// <summary>Configuration for asynchronous inference invocation outputs.</summary>
    [JsonPropertyName("outputConfig")]
    public V1beta1EndpointConfigurationSpecInitProviderAsyncInferenceConfigOutputConfig? OutputConfig { get; set; }
}

/// <summary>Content type headers to capture. See capture_content_type_header below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderDataCaptureConfigCaptureContentTypeHeader
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
public partial class V1beta1EndpointConfigurationSpecInitProviderDataCaptureConfigCaptureOptions
{
    /// <summary>Data to be captured. Should be one of Input, Output or InputAndOutput.</summary>
    [JsonPropertyName("captureMode")]
    public string? CaptureMode { get; set; }
}

/// <summary>Parameters to capture input/output of SageMaker AI models endpoints. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderDataCaptureConfig
{
    /// <summary>Content type headers to capture. See capture_content_type_header below.</summary>
    [JsonPropertyName("captureContentTypeHeader")]
    public V1beta1EndpointConfigurationSpecInitProviderDataCaptureConfigCaptureContentTypeHeader? CaptureContentTypeHeader { get; set; }

    /// <summary>What data to capture. Fields are documented below.</summary>
    [JsonPropertyName("captureOptions")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderDataCaptureConfigCaptureOptions>? CaptureOptions { get; set; }

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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnRefPolicyResolveEnum>))]
public enum V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnSelector
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
    public V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnSelector
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
    public V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariantsCoreDumpConfig
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
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariantsManagedInstanceScaling
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicyResolutionEnum>))]
public enum V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicyResolveEnum>))]
public enum V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Model in sagemaker to populate modelName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicyResolutionEnum>))]
public enum V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicyResolveEnum>))]
public enum V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Model in sagemaker to populate modelName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelector
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
    public V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariantsRoutingConfig
{
    /// <summary>How the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary>How an endpoint performs asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariantsServerlessConfig
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
public partial class V1beta1EndpointConfigurationSpecInitProviderProductionVariants
{
    /// <summary>Size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public V1beta1EndpointConfigurationSpecInitProviderProductionVariantsCoreDumpConfig? CoreDumpConfig { get; set; }

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
    public V1beta1EndpointConfigurationSpecInitProviderProductionVariantsManagedInstanceScaling? ManagedInstanceScaling { get; set; }

    /// <summary>Timeout value, in seconds, to download and extract the model that you want to host from S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>Name of the model to use. Required unless using Inference Components (in which case execution_role_arn must be specified at the endpoint configuration level).</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>Reference to a Model in sagemaker to populate modelName.</summary>
    [JsonPropertyName("modelNameRef")]
    public V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameRef? ModelNameRef { get; set; }

    /// <summary>Selector for a Model in sagemaker to populate modelName.</summary>
    [JsonPropertyName("modelNameSelector")]
    public V1beta1EndpointConfigurationSpecInitProviderProductionVariantsModelNameSelector? ModelNameSelector { get; set; }

    /// <summary>How the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public V1beta1EndpointConfigurationSpecInitProviderProductionVariantsServerlessConfig? ServerlessConfig { get; set; }

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
public partial class V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariantsCoreDumpConfig
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
public partial class V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariantsManagedInstanceScaling
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
public partial class V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariantsRoutingConfig
{
    /// <summary>How the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary>How an endpoint performs asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariantsServerlessConfig
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
public partial class V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariants
{
    /// <summary>Size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariantsCoreDumpConfig? CoreDumpConfig { get; set; }

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
    public V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariantsManagedInstanceScaling? ManagedInstanceScaling { get; set; }

    /// <summary>Timeout value, in seconds, to download and extract the model that you want to host from S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>Name of the model to use. Required unless using Inference Components (in which case execution_role_arn must be specified at the endpoint configuration level).</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>How the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariantsServerlessConfig? ServerlessConfig { get; set; }

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
public partial class V1beta1EndpointConfigurationSpecInitProvider
{
    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("asyncInferenceConfig")]
    public V1beta1EndpointConfigurationSpecInitProviderAsyncInferenceConfig? AsyncInferenceConfig { get; set; }

    /// <summary>Parameters to capture input/output of SageMaker AI models endpoints. Fields are documented below.</summary>
    [JsonPropertyName("dataCaptureConfig")]
    public V1beta1EndpointConfigurationSpecInitProviderDataCaptureConfig? DataCaptureConfig { get; set; }

    /// <summary>ARN of an IAM role that SageMaker AI can assume to perform actions on your behalf. Required when model_name is not specified in production_variants to support Inference Components.</summary>
    [JsonPropertyName("executionRoleArn")]
    public string? ExecutionRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnRef")]
    public V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnRef? ExecutionRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate executionRoleArn.</summary>
    [JsonPropertyName("executionRoleArnSelector")]
    public V1beta1EndpointConfigurationSpecInitProviderExecutionRoleArnSelector? ExecutionRoleArnSelector { get; set; }

    /// <summary>ARN of a AWS KMS key that SageMaker AI uses to encrypt data on the storage volume attached to the ML compute instance that hosts the endpoint.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta1EndpointConfigurationSpecInitProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>List each model that you want to host at this endpoint. See below.</summary>
    [JsonPropertyName("productionVariants")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderProductionVariants>? ProductionVariants { get; set; }

    /// <summary>Models that you want to host at this endpoint in shadow mode with production traffic replicated from the model specified on production_variants. If you use this field, you can only specify one variant for production_variants and one variant for shadow_production_variants. See below (same arguments as production_variants).</summary>
    [JsonPropertyName("shadowProductionVariants")]
    public IList<V1beta1EndpointConfigurationSpecInitProviderShadowProductionVariants>? ShadowProductionVariants { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1EndpointConfigurationSpecManagementPoliciesEnum>))]
public enum V1beta1EndpointConfigurationSpecManagementPoliciesEnum
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
public partial class V1beta1EndpointConfigurationSpecProviderConfigRef
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
public partial class V1beta1EndpointConfigurationSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>EndpointConfigurationSpec defines the desired state of EndpointConfiguration</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1EndpointConfigurationSpecForProvider ForProvider { get; set; }

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
    public V1beta1EndpointConfigurationSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1EndpointConfigurationSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1EndpointConfigurationSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1EndpointConfigurationSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configures the behavior of the client used by SageMaker AI to interact with the model container during asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderAsyncInferenceConfigClientConfig
{
    /// <summary>Maximum number of concurrent requests sent by the SageMaker AI client to the model container. If no value is provided, SageMaker AI will choose an optimal value for you.</summary>
    [JsonPropertyName("maxConcurrentInvocationsPerInstance")]
    public double? MaxConcurrentInvocationsPerInstance { get; set; }
}

/// <summary>Configuration for notifications of inference results for asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderAsyncInferenceConfigOutputConfigNotificationConfig
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
public partial class V1beta1EndpointConfigurationStatusAtProviderAsyncInferenceConfigOutputConfig
{
    /// <summary>KMS key that SageMaker AI uses to encrypt the asynchronous inference output in S3.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>Configuration for notifications of inference results for asynchronous inference.</summary>
    [JsonPropertyName("notificationConfig")]
    public V1beta1EndpointConfigurationStatusAtProviderAsyncInferenceConfigOutputConfigNotificationConfig? NotificationConfig { get; set; }

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
public partial class V1beta1EndpointConfigurationStatusAtProviderAsyncInferenceConfig
{
    /// <summary>Configures the behavior of the client used by SageMaker AI to interact with the model container during asynchronous inference.</summary>
    [JsonPropertyName("clientConfig")]
    public V1beta1EndpointConfigurationStatusAtProviderAsyncInferenceConfigClientConfig? ClientConfig { get; set; }

    /// <summary>Configuration for asynchronous inference invocation outputs.</summary>
    [JsonPropertyName("outputConfig")]
    public V1beta1EndpointConfigurationStatusAtProviderAsyncInferenceConfigOutputConfig? OutputConfig { get; set; }
}

/// <summary>Content type headers to capture. See capture_content_type_header below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderDataCaptureConfigCaptureContentTypeHeader
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
public partial class V1beta1EndpointConfigurationStatusAtProviderDataCaptureConfigCaptureOptions
{
    /// <summary>Data to be captured. Should be one of Input, Output or InputAndOutput.</summary>
    [JsonPropertyName("captureMode")]
    public string? CaptureMode { get; set; }
}

/// <summary>Parameters to capture input/output of SageMaker AI models endpoints. Fields are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderDataCaptureConfig
{
    /// <summary>Content type headers to capture. See capture_content_type_header below.</summary>
    [JsonPropertyName("captureContentTypeHeader")]
    public V1beta1EndpointConfigurationStatusAtProviderDataCaptureConfigCaptureContentTypeHeader? CaptureContentTypeHeader { get; set; }

    /// <summary>What data to capture. Fields are documented below.</summary>
    [JsonPropertyName("captureOptions")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderDataCaptureConfigCaptureOptions>? CaptureOptions { get; set; }

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
public partial class V1beta1EndpointConfigurationStatusAtProviderProductionVariantsCoreDumpConfig
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
public partial class V1beta1EndpointConfigurationStatusAtProviderProductionVariantsManagedInstanceScaling
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
public partial class V1beta1EndpointConfigurationStatusAtProviderProductionVariantsRoutingConfig
{
    /// <summary>How the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary>How an endpoint performs asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderProductionVariantsServerlessConfig
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
public partial class V1beta1EndpointConfigurationStatusAtProviderProductionVariants
{
    /// <summary>Size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public V1beta1EndpointConfigurationStatusAtProviderProductionVariantsCoreDumpConfig? CoreDumpConfig { get; set; }

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
    public V1beta1EndpointConfigurationStatusAtProviderProductionVariantsManagedInstanceScaling? ManagedInstanceScaling { get; set; }

    /// <summary>Timeout value, in seconds, to download and extract the model that you want to host from S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>Name of the model to use. Required unless using Inference Components (in which case execution_role_arn must be specified at the endpoint configuration level).</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>How the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public V1beta1EndpointConfigurationStatusAtProviderProductionVariantsServerlessConfig? ServerlessConfig { get; set; }

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
public partial class V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariantsCoreDumpConfig
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
public partial class V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariantsManagedInstanceScaling
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
public partial class V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariantsRoutingConfig
{
    /// <summary>How the endpoint routes incoming traffic. Valid values are LEAST_OUTSTANDING_REQUESTS and RANDOM. LEAST_OUTSTANDING_REQUESTS routes requests to the specific instances that have more capacity to process them. RANDOM routes each request to a randomly chosen instance.</summary>
    [JsonPropertyName("routingStrategy")]
    public string? RoutingStrategy { get; set; }
}

/// <summary>How an endpoint performs asynchronous inference.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariantsServerlessConfig
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
public partial class V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariants
{
    /// <summary>Size of the Elastic Inference (EI) instance to use for the production variant.</summary>
    [JsonPropertyName("acceleratorType")]
    public string? AcceleratorType { get; set; }

    /// <summary>Timeout value, in seconds, for your inference container to pass health check by SageMaker AI Hosting. For more information about health check, see How Your Container Should Respond to Health Check (Ping) Requests. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("containerStartupHealthCheckTimeoutInSeconds")]
    public double? ContainerStartupHealthCheckTimeoutInSeconds { get; set; }

    /// <summary>Core dump configuration from the model container when the process crashes. Fields are documented below.</summary>
    [JsonPropertyName("coreDumpConfig")]
    public V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariantsCoreDumpConfig? CoreDumpConfig { get; set; }

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
    public V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariantsManagedInstanceScaling? ManagedInstanceScaling { get; set; }

    /// <summary>Timeout value, in seconds, to download and extract the model that you want to host from S3 to the individual inference instance associated with this production variant. Valid values between 60 and 3600.</summary>
    [JsonPropertyName("modelDataDownloadTimeoutInSeconds")]
    public double? ModelDataDownloadTimeoutInSeconds { get; set; }

    /// <summary>Name of the model to use. Required unless using Inference Components (in which case execution_role_arn must be specified at the endpoint configuration level).</summary>
    [JsonPropertyName("modelName")]
    public string? ModelName { get; set; }

    /// <summary>How the endpoint routes incoming traffic. See routing_config below.</summary>
    [JsonPropertyName("routingConfig")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariantsRoutingConfig>? RoutingConfig { get; set; }

    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("serverlessConfig")]
    public V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariantsServerlessConfig? ServerlessConfig { get; set; }

    /// <summary>Name of the variant.</summary>
    [JsonPropertyName("variantName")]
    public string? VariantName { get; set; }

    /// <summary>Size, in GB, of the ML storage volume attached to individual inference instance associated with the production variant. Valid values between 1 and 512.</summary>
    [JsonPropertyName("volumeSizeInGb")]
    public double? VolumeSizeInGb { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1EndpointConfigurationStatusAtProvider
{
    /// <summary>ARN assigned by AWS to this endpoint configuration.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>How an endpoint performs asynchronous inference.</summary>
    [JsonPropertyName("asyncInferenceConfig")]
    public V1beta1EndpointConfigurationStatusAtProviderAsyncInferenceConfig? AsyncInferenceConfig { get; set; }

    /// <summary>Parameters to capture input/output of SageMaker AI models endpoints. Fields are documented below.</summary>
    [JsonPropertyName("dataCaptureConfig")]
    public V1beta1EndpointConfigurationStatusAtProviderDataCaptureConfig? DataCaptureConfig { get; set; }

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
    public IList<V1beta1EndpointConfigurationStatusAtProviderProductionVariants>? ProductionVariants { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Models that you want to host at this endpoint in shadow mode with production traffic replicated from the model specified on production_variants. If you use this field, you can only specify one variant for production_variants and one variant for shadow_production_variants. See below (same arguments as production_variants).</summary>
    [JsonPropertyName("shadowProductionVariants")]
    public IList<V1beta1EndpointConfigurationStatusAtProviderShadowProductionVariants>? ShadowProductionVariants { get; set; }

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
public partial class V1beta1EndpointConfigurationStatusConditions
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
public partial class V1beta1EndpointConfigurationStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1EndpointConfigurationStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1EndpointConfigurationStatusConditions>? Conditions { get; set; }

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
public partial class V1beta1EndpointConfiguration : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1EndpointConfigurationSpec>, IStatus<V1beta1EndpointConfigurationStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "EndpointConfiguration";
    public const string KubeGroup = "sagemaker.aws.m.upbound.io";
    public const string KubePluralName = "endpointconfigurations";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "sagemaker.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "EndpointConfiguration";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>EndpointConfigurationSpec defines the desired state of EndpointConfiguration</summary>
    [JsonPropertyName("spec")]
    public required V1beta1EndpointConfigurationSpec Spec { get; set; }

    /// <summary>EndpointConfigurationStatus defines the observed state of EndpointConfiguration.</summary>
    [JsonPropertyName("status")]
    public V1beta1EndpointConfigurationStatus? Status { get; set; }
}