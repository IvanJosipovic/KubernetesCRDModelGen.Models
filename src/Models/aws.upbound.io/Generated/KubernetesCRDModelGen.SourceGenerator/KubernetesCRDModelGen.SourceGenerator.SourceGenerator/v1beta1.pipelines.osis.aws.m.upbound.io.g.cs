#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.osis.aws.m.upbound.io;
/// <summary>Pipeline is the Schema for the Pipelines API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1PipelineList : IKubernetesObject<V1ListMeta>, IItems<V1beta1Pipeline>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "PipelineList";
    public const string KubeGroup = "osis.aws.m.upbound.io";
    public const string KubePluralName = "pipelines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "osis.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "PipelineList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta1Pipeline objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta1Pipeline> Items { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderBufferOptions
{
    /// <summary>Whether persistent buffering should be enabled.</summary>
    [JsonPropertyName("persistentBufferEnabled")]
    public bool? PersistentBufferEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderEncryptionAtRestOptions
{
    /// <summary>The ARN of the KMS key used to encrypt data-at-rest in OpenSearch Ingestion. By default, data is encrypted using an AWS owned key.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderLogPublishingOptionsCloudwatchLogDestination
{
    /// <summary>The name of the CloudWatch Logs group to send pipeline logs to. You can specify an existing log group or create a new one. For example, /aws/OpenSearchService/IngestionService/my-pipeline.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderLogPublishingOptions
{
    /// <summary>The destination for OpenSearch Ingestion logs sent to Amazon CloudWatch Logs. This parameter is required if IsLoggingEnabled is set to true. See cloudwatch_log_destination below.</summary>
    [JsonPropertyName("cloudwatchLogDestination")]
    public IList<V1beta1PipelineSpecForProviderLogPublishingOptionsCloudwatchLogDestination>? CloudwatchLogDestination { get; set; }

    /// <summary>Whether logs should be published.</summary>
    [JsonPropertyName("isLoggingEnabled")]
    public bool? IsLoggingEnabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecForProviderPipelineRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1PipelineSpecForProviderPipelineRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecForProviderPipelineRoleArnRefPolicyResolveEnum>))]
public enum V1beta1PipelineSpecForProviderPipelineRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderPipelineRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PipelineSpecForProviderPipelineRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PipelineSpecForProviderPipelineRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate pipelineRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderPipelineRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipelineSpecForProviderPipelineRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecForProviderPipelineRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1PipelineSpecForProviderPipelineRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecForProviderPipelineRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1PipelineSpecForProviderPipelineRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderPipelineRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PipelineSpecForProviderPipelineRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PipelineSpecForProviderPipelineRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate pipelineRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderPipelineRoleArnSelector
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
    public V1beta1PipelineSpecForProviderPipelineRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProviderVpcOptions
{
    /// <summary>A list of security groups associated with the VPC endpoint.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>A list of subnet IDs associated with the VPC endpoint.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Whether you or Amazon OpenSearch Ingestion service create and manage the VPC endpoint configured for the pipeline. Valid values are CUSTOMER or SERVICE</summary>
    [JsonPropertyName("vpcEndpointManagement")]
    public string? VpcEndpointManagement { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecForProvider
{
    /// <summary>Key-value pairs to configure persistent buffering for the pipeline. See buffer_options below.</summary>
    [JsonPropertyName("bufferOptions")]
    public IList<V1beta1PipelineSpecForProviderBufferOptions>? BufferOptions { get; set; }

    /// <summary>Key-value pairs to configure encryption for data that is written to a persistent buffer. See encryption_at_rest_options below.</summary>
    [JsonPropertyName("encryptionAtRestOptions")]
    public IList<V1beta1PipelineSpecForProviderEncryptionAtRestOptions>? EncryptionAtRestOptions { get; set; }

    /// <summary>Key-value pairs to configure log publishing. See log_publishing_options below.</summary>
    [JsonPropertyName("logPublishingOptions")]
    public IList<V1beta1PipelineSpecForProviderLogPublishingOptions>? LogPublishingOptions { get; set; }

    /// <summary>The maximum pipeline capacity, in Ingestion Compute Units (ICUs).</summary>
    [JsonPropertyName("maxUnits")]
    public double? MaxUnits { get; set; }

    /// <summary>The minimum pipeline capacity, in Ingestion Compute Units (ICUs).</summary>
    [JsonPropertyName("minUnits")]
    public double? MinUnits { get; set; }

    /// <summary>The pipeline configuration in YAML format. This argument accepts the pipeline configuration as a string or within a .yaml file. If you provide the configuration as a string, each new line must be escaped with \n.</summary>
    [JsonPropertyName("pipelineConfigurationBody")]
    public string? PipelineConfigurationBody { get; set; }

    /// <summary>ARN of the IAM role that grants the pipeline permission to access AWS resources.</summary>
    [JsonPropertyName("pipelineRoleArn")]
    public string? PipelineRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate pipelineRoleArn.</summary>
    [JsonPropertyName("pipelineRoleArnRef")]
    public V1beta1PipelineSpecForProviderPipelineRoleArnRef? PipelineRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate pipelineRoleArn.</summary>
    [JsonPropertyName("pipelineRoleArnSelector")]
    public V1beta1PipelineSpecForProviderPipelineRoleArnSelector? PipelineRoleArnSelector { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Container for the values required to configure VPC access for the pipeline. If you don&apos;t specify these values, OpenSearch Ingestion creates the pipeline with a public endpoint. See vpc_options below.</summary>
    [JsonPropertyName("vpcOptions")]
    public IList<V1beta1PipelineSpecForProviderVpcOptions>? VpcOptions { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderBufferOptions
{
    /// <summary>Whether persistent buffering should be enabled.</summary>
    [JsonPropertyName("persistentBufferEnabled")]
    public bool? PersistentBufferEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderEncryptionAtRestOptions
{
    /// <summary>The ARN of the KMS key used to encrypt data-at-rest in OpenSearch Ingestion. By default, data is encrypted using an AWS owned key.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderLogPublishingOptionsCloudwatchLogDestination
{
    /// <summary>The name of the CloudWatch Logs group to send pipeline logs to. You can specify an existing log group or create a new one. For example, /aws/OpenSearchService/IngestionService/my-pipeline.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderLogPublishingOptions
{
    /// <summary>The destination for OpenSearch Ingestion logs sent to Amazon CloudWatch Logs. This parameter is required if IsLoggingEnabled is set to true. See cloudwatch_log_destination below.</summary>
    [JsonPropertyName("cloudwatchLogDestination")]
    public IList<V1beta1PipelineSpecInitProviderLogPublishingOptionsCloudwatchLogDestination>? CloudwatchLogDestination { get; set; }

    /// <summary>Whether logs should be published.</summary>
    [JsonPropertyName("isLoggingEnabled")]
    public bool? IsLoggingEnabled { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecInitProviderPipelineRoleArnRefPolicyResolutionEnum>))]
public enum V1beta1PipelineSpecInitProviderPipelineRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecInitProviderPipelineRoleArnRefPolicyResolveEnum>))]
public enum V1beta1PipelineSpecInitProviderPipelineRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderPipelineRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PipelineSpecInitProviderPipelineRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PipelineSpecInitProviderPipelineRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate pipelineRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderPipelineRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the referenced object</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta1PipelineSpecInitProviderPipelineRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecInitProviderPipelineRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta1PipelineSpecInitProviderPipelineRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecInitProviderPipelineRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta1PipelineSpecInitProviderPipelineRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderPipelineRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta1PipelineSpecInitProviderPipelineRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta1PipelineSpecInitProviderPipelineRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate pipelineRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderPipelineRoleArnSelector
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
    public V1beta1PipelineSpecInitProviderPipelineRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpecInitProviderVpcOptions
{
    /// <summary>A list of security groups associated with the VPC endpoint.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>A list of subnet IDs associated with the VPC endpoint.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Whether you or Amazon OpenSearch Ingestion service create and manage the VPC endpoint configured for the pipeline. Valid values are CUSTOMER or SERVICE</summary>
    [JsonPropertyName("vpcEndpointManagement")]
    public string? VpcEndpointManagement { get; set; }
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
public partial class V1beta1PipelineSpecInitProvider
{
    /// <summary>Key-value pairs to configure persistent buffering for the pipeline. See buffer_options below.</summary>
    [JsonPropertyName("bufferOptions")]
    public IList<V1beta1PipelineSpecInitProviderBufferOptions>? BufferOptions { get; set; }

    /// <summary>Key-value pairs to configure encryption for data that is written to a persistent buffer. See encryption_at_rest_options below.</summary>
    [JsonPropertyName("encryptionAtRestOptions")]
    public IList<V1beta1PipelineSpecInitProviderEncryptionAtRestOptions>? EncryptionAtRestOptions { get; set; }

    /// <summary>Key-value pairs to configure log publishing. See log_publishing_options below.</summary>
    [JsonPropertyName("logPublishingOptions")]
    public IList<V1beta1PipelineSpecInitProviderLogPublishingOptions>? LogPublishingOptions { get; set; }

    /// <summary>The maximum pipeline capacity, in Ingestion Compute Units (ICUs).</summary>
    [JsonPropertyName("maxUnits")]
    public double? MaxUnits { get; set; }

    /// <summary>The minimum pipeline capacity, in Ingestion Compute Units (ICUs).</summary>
    [JsonPropertyName("minUnits")]
    public double? MinUnits { get; set; }

    /// <summary>The pipeline configuration in YAML format. This argument accepts the pipeline configuration as a string or within a .yaml file. If you provide the configuration as a string, each new line must be escaped with \n.</summary>
    [JsonPropertyName("pipelineConfigurationBody")]
    public string? PipelineConfigurationBody { get; set; }

    /// <summary>ARN of the IAM role that grants the pipeline permission to access AWS resources.</summary>
    [JsonPropertyName("pipelineRoleArn")]
    public string? PipelineRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate pipelineRoleArn.</summary>
    [JsonPropertyName("pipelineRoleArnRef")]
    public V1beta1PipelineSpecInitProviderPipelineRoleArnRef? PipelineRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate pipelineRoleArn.</summary>
    [JsonPropertyName("pipelineRoleArnSelector")]
    public V1beta1PipelineSpecInitProviderPipelineRoleArnSelector? PipelineRoleArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Container for the values required to configure VPC access for the pipeline. If you don&apos;t specify these values, OpenSearch Ingestion creates the pipeline with a public endpoint. See vpc_options below.</summary>
    [JsonPropertyName("vpcOptions")]
    public IList<V1beta1PipelineSpecInitProviderVpcOptions>? VpcOptions { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta1PipelineSpecManagementPoliciesEnum>))]
public enum V1beta1PipelineSpecManagementPoliciesEnum
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
public partial class V1beta1PipelineSpecProviderConfigRef
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
public partial class V1beta1PipelineSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }
}

/// <summary>PipelineSpec defines the desired state of Pipeline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineSpec
{
    [JsonPropertyName("forProvider")]
    public required V1beta1PipelineSpecForProvider ForProvider { get; set; }

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
    public V1beta1PipelineSpecInitProvider? InitProvider { get; set; }

    /// <summary>
    /// THIS IS A BETA FIELD. It is on by default but can be opted out
    /// through a Crossplane feature flag.
    /// ManagementPolicies specify the array of actions Crossplane is allowed to
    /// take on the managed and external resources.
    /// See the design doc for more information: https://github.com/crossplane/crossplane/blob/499895a25d1a1a0ba1604944ef98ac7a1a71f197/design/design-doc-observe-only-resources.md?plain=1#L223
    /// and this one: https://github.com/crossplane/crossplane/blob/444267e84783136daa93568b364a5f01228cacbe/design/one-pager-ignore-changes.md
    /// </summary>
    [JsonPropertyName("managementPolicies")]
    public IList<V1beta1PipelineSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta1PipelineSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta1PipelineSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderBufferOptions
{
    /// <summary>Whether persistent buffering should be enabled.</summary>
    [JsonPropertyName("persistentBufferEnabled")]
    public bool? PersistentBufferEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderEncryptionAtRestOptions
{
    /// <summary>The ARN of the KMS key used to encrypt data-at-rest in OpenSearch Ingestion. By default, data is encrypted using an AWS owned key.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderLogPublishingOptionsCloudwatchLogDestination
{
    /// <summary>The name of the CloudWatch Logs group to send pipeline logs to. You can specify an existing log group or create a new one. For example, /aws/OpenSearchService/IngestionService/my-pipeline.</summary>
    [JsonPropertyName("logGroup")]
    public string? LogGroup { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderLogPublishingOptions
{
    /// <summary>The destination for OpenSearch Ingestion logs sent to Amazon CloudWatch Logs. This parameter is required if IsLoggingEnabled is set to true. See cloudwatch_log_destination below.</summary>
    [JsonPropertyName("cloudwatchLogDestination")]
    public IList<V1beta1PipelineStatusAtProviderLogPublishingOptionsCloudwatchLogDestination>? CloudwatchLogDestination { get; set; }

    /// <summary>Whether logs should be published.</summary>
    [JsonPropertyName("isLoggingEnabled")]
    public bool? IsLoggingEnabled { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProviderVpcOptions
{
    /// <summary>A list of security groups associated with the VPC endpoint.</summary>
    [JsonPropertyName("securityGroupIds")]
    public IList<string>? SecurityGroupIds { get; set; }

    /// <summary>A list of subnet IDs associated with the VPC endpoint.</summary>
    [JsonPropertyName("subnetIds")]
    public IList<string>? SubnetIds { get; set; }

    /// <summary>Whether you or Amazon OpenSearch Ingestion service create and manage the VPC endpoint configured for the pipeline. Valid values are CUSTOMER or SERVICE</summary>
    [JsonPropertyName("vpcEndpointManagement")]
    public string? VpcEndpointManagement { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusAtProvider
{
    /// <summary>Key-value pairs to configure persistent buffering for the pipeline. See buffer_options below.</summary>
    [JsonPropertyName("bufferOptions")]
    public IList<V1beta1PipelineStatusAtProviderBufferOptions>? BufferOptions { get; set; }

    /// <summary>Key-value pairs to configure encryption for data that is written to a persistent buffer. See encryption_at_rest_options below.</summary>
    [JsonPropertyName("encryptionAtRestOptions")]
    public IList<V1beta1PipelineStatusAtProviderEncryptionAtRestOptions>? EncryptionAtRestOptions { get; set; }

    /// <summary>Unique identifier for the pipeline.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>The list of ingestion endpoints for the pipeline, which you can send data to.</summary>
    [JsonPropertyName("ingestEndpointUrls")]
    public IList<string>? IngestEndpointUrls { get; set; }

    /// <summary>Key-value pairs to configure log publishing. See log_publishing_options below.</summary>
    [JsonPropertyName("logPublishingOptions")]
    public IList<V1beta1PipelineStatusAtProviderLogPublishingOptions>? LogPublishingOptions { get; set; }

    /// <summary>The maximum pipeline capacity, in Ingestion Compute Units (ICUs).</summary>
    [JsonPropertyName("maxUnits")]
    public double? MaxUnits { get; set; }

    /// <summary>The minimum pipeline capacity, in Ingestion Compute Units (ICUs).</summary>
    [JsonPropertyName("minUnits")]
    public double? MinUnits { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the pipeline.</summary>
    [JsonPropertyName("pipelineArn")]
    public string? PipelineArn { get; set; }

    /// <summary>The pipeline configuration in YAML format. This argument accepts the pipeline configuration as a string or within a .yaml file. If you provide the configuration as a string, each new line must be escaped with \n.</summary>
    [JsonPropertyName("pipelineConfigurationBody")]
    public string? PipelineConfigurationBody { get; set; }

    /// <summary>ARN of the IAM role that grants the pipeline permission to access AWS resources.</summary>
    [JsonPropertyName("pipelineRoleArn")]
    public string? PipelineRoleArn { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Container for the values required to configure VPC access for the pipeline. If you don&apos;t specify these values, OpenSearch Ingestion creates the pipeline with a public endpoint. See vpc_options below.</summary>
    [JsonPropertyName("vpcOptions")]
    public IList<V1beta1PipelineStatusAtProviderVpcOptions>? VpcOptions { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatusConditions
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

/// <summary>PipelineStatus defines the observed state of Pipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta1PipelineStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta1PipelineStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta1PipelineStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Pipeline is the Schema for the Pipelines API.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta1Pipeline : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta1PipelineSpec>, IStatus<V1beta1PipelineStatus?>
{
    public const string KubeApiVersion = "v1beta1";
    public const string KubeKind = "Pipeline";
    public const string KubeGroup = "osis.aws.m.upbound.io";
    public const string KubePluralName = "pipelines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "osis.aws.m.upbound.io/v1beta1";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Pipeline";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>PipelineSpec defines the desired state of Pipeline</summary>
    [JsonPropertyName("spec")]
    public required V1beta1PipelineSpec Spec { get; set; }

    /// <summary>PipelineStatus defines the observed state of Pipeline.</summary>
    [JsonPropertyName("status")]
    public V1beta1PipelineStatus? Status { get; set; }
}