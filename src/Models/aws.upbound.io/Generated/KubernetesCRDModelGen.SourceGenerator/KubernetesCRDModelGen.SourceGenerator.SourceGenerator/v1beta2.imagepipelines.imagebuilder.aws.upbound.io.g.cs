#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.imagebuilder.aws.upbound.io;
/// <summary>ImagePipeline is the Schema for the ImagePipelines API. Manages an Image Builder Image Pipeline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ImagePipelineList : IKubernetesObject<V1ListMeta>, IItems<V1beta2ImagePipeline>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ImagePipelineList";
    public const string KubeGroup = "imagebuilder.aws.upbound.io";
    public const string KubePluralName = "imagepipelines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "imagebuilder.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ImagePipelineList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2ImagePipeline objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2ImagePipeline> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecDeletionPolicyEnum>))]
public enum V1beta2ImagePipelineSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecForProviderImageRecipeArnRefPolicyResolutionEnum>))]
public enum V1beta2ImagePipelineSpecForProviderImageRecipeArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecForProviderImageRecipeArnRefPolicyResolveEnum>))]
public enum V1beta2ImagePipelineSpecForProviderImageRecipeArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecForProviderImageRecipeArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImagePipelineSpecForProviderImageRecipeArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImagePipelineSpecForProviderImageRecipeArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecForProviderImageRecipeArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ImagePipelineSpecForProviderImageRecipeArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecForProviderImageRecipeArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ImagePipelineSpecForProviderImageRecipeArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecForProviderImageRecipeArnSelectorPolicyResolveEnum>))]
public enum V1beta2ImagePipelineSpecForProviderImageRecipeArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecForProviderImageRecipeArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImagePipelineSpecForProviderImageRecipeArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImagePipelineSpecForProviderImageRecipeArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecForProviderImageRecipeArnSelector
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
    public V1beta2ImagePipelineSpecForProviderImageRecipeArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block with ECR configuration for image scanning. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecForProviderImageScanningConfigurationEcrConfiguration
{
    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("containerTags")]
    public IList<string>? ContainerTags { get; set; }

    /// <summary>The name of the repository to scan</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }
}

/// <summary>Configuration block with image scanning configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecForProviderImageScanningConfiguration
{
    /// <summary>Configuration block with ECR configuration for image scanning. Detailed below.</summary>
    [JsonPropertyName("ecrConfiguration")]
    public V1beta2ImagePipelineSpecForProviderImageScanningConfigurationEcrConfiguration? EcrConfiguration { get; set; }

    /// <summary>Whether image scans are enabled. Defaults to false.</summary>
    [JsonPropertyName("imageScanningEnabled")]
    public bool? ImageScanningEnabled { get; set; }
}

/// <summary>Configuration block with image tests configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecForProviderImageTestsConfiguration
{
    /// <summary>Whether image tests are enabled. Defaults to true.</summary>
    [JsonPropertyName("imageTestsEnabled")]
    public bool? ImageTestsEnabled { get; set; }

    /// <summary>Number of minutes before image tests time out. Valid values are between 60 and 1440. Defaults to 720.</summary>
    [JsonPropertyName("timeoutMinutes")]
    public double? TimeoutMinutes { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnRefPolicyResolutionEnum>))]
public enum V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnRefPolicyResolveEnum>))]
public enum V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnSelectorPolicyResolveEnum>))]
public enum V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnSelector
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
    public V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block with logging configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecForProviderLoggingConfiguration
{
    /// <summary>Name of the CloudWatch Log Group to send image logs to.</summary>
    [JsonPropertyName("imageLogGroupName")]
    public string? ImageLogGroupName { get; set; }

    /// <summary>Name of the CloudWatch Log Group to send pipeline logs to.</summary>
    [JsonPropertyName("pipelineLogGroupName")]
    public string? PipelineLogGroupName { get; set; }
}

/// <summary>Configuration block with schedule settings. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecForProviderSchedule
{
    /// <summary>Condition when the pipeline should trigger a new image build. Valid values are EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE and EXPRESSION_MATCH_ONLY. Defaults to EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE.</summary>
    [JsonPropertyName("pipelineExecutionStartCondition")]
    public string? PipelineExecutionStartCondition { get; set; }

    /// <summary>Cron expression of how often the pipeline start condition is evaluated. For example, cron(0 0 * * ? *) is evaluated every day at midnight UTC. Configurations using the five field syntax that was previously accepted by the API, such as cron(0 0 * * *), must be updated to the six field syntax. For more information, see the Image Builder User Guide.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>The timezone that applies to the scheduling expression. For example, &quot;Etc/UTC&quot;, &quot;America/Los_Angeles&quot; in the IANA timezone format. If not specified this defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecForProviderWorkflowParameter
{
    /// <summary>The name of the Workflow parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the Workflow parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecForProviderWorkflow
{
    /// <summary>The action to take if the workflow fails. Must be one of CONTINUE or ABORT.</summary>
    [JsonPropertyName("onFailure")]
    public string? OnFailure { get; set; }

    /// <summary>The parallel group in which to run a test Workflow.</summary>
    [JsonPropertyName("parallelGroup")]
    public string? ParallelGroup { get; set; }

    /// <summary>Configuration block for the workflow parameters. Detailed below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta2ImagePipelineSpecForProviderWorkflowParameter>? Parameter { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Workflow.</summary>
    [JsonPropertyName("workflowArn")]
    public string? WorkflowArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecForProvider
{
    /// <summary>Amazon Resource Name (ARN) of the container recipe.</summary>
    [JsonPropertyName("containerRecipeArn")]
    public string? ContainerRecipeArn { get; set; }

    /// <summary>Description of the image pipeline.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Distribution Configuration.</summary>
    [JsonPropertyName("distributionConfigurationArn")]
    public string? DistributionConfigurationArn { get; set; }

    /// <summary>Whether additional information about the image being created is collected. Defaults to true.</summary>
    [JsonPropertyName("enhancedImageMetadataEnabled")]
    public bool? EnhancedImageMetadataEnabled { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the service-linked role to be used by Image Builder to execute workflows.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the image recipe.</summary>
    [JsonPropertyName("imageRecipeArn")]
    public string? ImageRecipeArn { get; set; }

    /// <summary>Reference to a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
    [JsonPropertyName("imageRecipeArnRef")]
    public V1beta2ImagePipelineSpecForProviderImageRecipeArnRef? ImageRecipeArnRef { get; set; }

    /// <summary>Selector for a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
    [JsonPropertyName("imageRecipeArnSelector")]
    public V1beta2ImagePipelineSpecForProviderImageRecipeArnSelector? ImageRecipeArnSelector { get; set; }

    /// <summary>Configuration block with image scanning configuration. Detailed below.</summary>
    [JsonPropertyName("imageScanningConfiguration")]
    public V1beta2ImagePipelineSpecForProviderImageScanningConfiguration? ImageScanningConfiguration { get; set; }

    /// <summary>Configuration block with image tests configuration. Detailed below.</summary>
    [JsonPropertyName("imageTestsConfiguration")]
    public V1beta2ImagePipelineSpecForProviderImageTestsConfiguration? ImageTestsConfiguration { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Infrastructure Configuration.</summary>
    [JsonPropertyName("infrastructureConfigurationArn")]
    public string? InfrastructureConfigurationArn { get; set; }

    /// <summary>Reference to a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
    [JsonPropertyName("infrastructureConfigurationArnRef")]
    public V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnRef? InfrastructureConfigurationArnRef { get; set; }

    /// <summary>Selector for a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
    [JsonPropertyName("infrastructureConfigurationArnSelector")]
    public V1beta2ImagePipelineSpecForProviderInfrastructureConfigurationArnSelector? InfrastructureConfigurationArnSelector { get; set; }

    /// <summary>Configuration block with logging configuration. Detailed below.</summary>
    [JsonPropertyName("loggingConfiguration")]
    public V1beta2ImagePipelineSpecForProviderLoggingConfiguration? LoggingConfiguration { get; set; }

    /// <summary>Name of the image pipeline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Configuration block with schedule settings. Detailed below.</summary>
    [JsonPropertyName("schedule")]
    public V1beta2ImagePipelineSpecForProviderSchedule? Schedule { get; set; }

    /// <summary>Status of the image pipeline. Valid values are DISABLED and ENABLED. Defaults to ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block with the workflow configuration. Detailed below.</summary>
    [JsonPropertyName("workflow")]
    public IList<V1beta2ImagePipelineSpecForProviderWorkflow>? Workflow { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecInitProviderImageRecipeArnRefPolicyResolutionEnum>))]
public enum V1beta2ImagePipelineSpecInitProviderImageRecipeArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecInitProviderImageRecipeArnRefPolicyResolveEnum>))]
public enum V1beta2ImagePipelineSpecInitProviderImageRecipeArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecInitProviderImageRecipeArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImagePipelineSpecInitProviderImageRecipeArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImagePipelineSpecInitProviderImageRecipeArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecInitProviderImageRecipeArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ImagePipelineSpecInitProviderImageRecipeArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecInitProviderImageRecipeArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ImagePipelineSpecInitProviderImageRecipeArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecInitProviderImageRecipeArnSelectorPolicyResolveEnum>))]
public enum V1beta2ImagePipelineSpecInitProviderImageRecipeArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecInitProviderImageRecipeArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImagePipelineSpecInitProviderImageRecipeArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImagePipelineSpecInitProviderImageRecipeArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecInitProviderImageRecipeArnSelector
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
    public V1beta2ImagePipelineSpecInitProviderImageRecipeArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block with ECR configuration for image scanning. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecInitProviderImageScanningConfigurationEcrConfiguration
{
    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("containerTags")]
    public IList<string>? ContainerTags { get; set; }

    /// <summary>The name of the repository to scan</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }
}

/// <summary>Configuration block with image scanning configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecInitProviderImageScanningConfiguration
{
    /// <summary>Configuration block with ECR configuration for image scanning. Detailed below.</summary>
    [JsonPropertyName("ecrConfiguration")]
    public V1beta2ImagePipelineSpecInitProviderImageScanningConfigurationEcrConfiguration? EcrConfiguration { get; set; }

    /// <summary>Whether image scans are enabled. Defaults to false.</summary>
    [JsonPropertyName("imageScanningEnabled")]
    public bool? ImageScanningEnabled { get; set; }
}

/// <summary>Configuration block with image tests configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecInitProviderImageTestsConfiguration
{
    /// <summary>Whether image tests are enabled. Defaults to true.</summary>
    [JsonPropertyName("imageTestsEnabled")]
    public bool? ImageTestsEnabled { get; set; }

    /// <summary>Number of minutes before image tests time out. Valid values are between 60 and 1440. Defaults to 720.</summary>
    [JsonPropertyName("timeoutMinutes")]
    public double? TimeoutMinutes { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnRefPolicyResolutionEnum>))]
public enum V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnRefPolicyResolveEnum>))]
public enum V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelectorPolicyResolveEnum>))]
public enum V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelector
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
    public V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block with logging configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecInitProviderLoggingConfiguration
{
    /// <summary>Name of the CloudWatch Log Group to send image logs to.</summary>
    [JsonPropertyName("imageLogGroupName")]
    public string? ImageLogGroupName { get; set; }

    /// <summary>Name of the CloudWatch Log Group to send pipeline logs to.</summary>
    [JsonPropertyName("pipelineLogGroupName")]
    public string? PipelineLogGroupName { get; set; }
}

/// <summary>Configuration block with schedule settings. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecInitProviderSchedule
{
    /// <summary>Condition when the pipeline should trigger a new image build. Valid values are EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE and EXPRESSION_MATCH_ONLY. Defaults to EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE.</summary>
    [JsonPropertyName("pipelineExecutionStartCondition")]
    public string? PipelineExecutionStartCondition { get; set; }

    /// <summary>Cron expression of how often the pipeline start condition is evaluated. For example, cron(0 0 * * ? *) is evaluated every day at midnight UTC. Configurations using the five field syntax that was previously accepted by the API, such as cron(0 0 * * *), must be updated to the six field syntax. For more information, see the Image Builder User Guide.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>The timezone that applies to the scheduling expression. For example, &quot;Etc/UTC&quot;, &quot;America/Los_Angeles&quot; in the IANA timezone format. If not specified this defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecInitProviderWorkflowParameter
{
    /// <summary>The name of the Workflow parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the Workflow parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecInitProviderWorkflow
{
    /// <summary>The action to take if the workflow fails. Must be one of CONTINUE or ABORT.</summary>
    [JsonPropertyName("onFailure")]
    public string? OnFailure { get; set; }

    /// <summary>The parallel group in which to run a test Workflow.</summary>
    [JsonPropertyName("parallelGroup")]
    public string? ParallelGroup { get; set; }

    /// <summary>Configuration block for the workflow parameters. Detailed below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta2ImagePipelineSpecInitProviderWorkflowParameter>? Parameter { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Workflow.</summary>
    [JsonPropertyName("workflowArn")]
    public string? WorkflowArn { get; set; }
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
public partial class V1beta2ImagePipelineSpecInitProvider
{
    /// <summary>Amazon Resource Name (ARN) of the container recipe.</summary>
    [JsonPropertyName("containerRecipeArn")]
    public string? ContainerRecipeArn { get; set; }

    /// <summary>Description of the image pipeline.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Distribution Configuration.</summary>
    [JsonPropertyName("distributionConfigurationArn")]
    public string? DistributionConfigurationArn { get; set; }

    /// <summary>Whether additional information about the image being created is collected. Defaults to true.</summary>
    [JsonPropertyName("enhancedImageMetadataEnabled")]
    public bool? EnhancedImageMetadataEnabled { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the service-linked role to be used by Image Builder to execute workflows.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the image recipe.</summary>
    [JsonPropertyName("imageRecipeArn")]
    public string? ImageRecipeArn { get; set; }

    /// <summary>Reference to a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
    [JsonPropertyName("imageRecipeArnRef")]
    public V1beta2ImagePipelineSpecInitProviderImageRecipeArnRef? ImageRecipeArnRef { get; set; }

    /// <summary>Selector for a ImageRecipe in imagebuilder to populate imageRecipeArn.</summary>
    [JsonPropertyName("imageRecipeArnSelector")]
    public V1beta2ImagePipelineSpecInitProviderImageRecipeArnSelector? ImageRecipeArnSelector { get; set; }

    /// <summary>Configuration block with image scanning configuration. Detailed below.</summary>
    [JsonPropertyName("imageScanningConfiguration")]
    public V1beta2ImagePipelineSpecInitProviderImageScanningConfiguration? ImageScanningConfiguration { get; set; }

    /// <summary>Configuration block with image tests configuration. Detailed below.</summary>
    [JsonPropertyName("imageTestsConfiguration")]
    public V1beta2ImagePipelineSpecInitProviderImageTestsConfiguration? ImageTestsConfiguration { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Infrastructure Configuration.</summary>
    [JsonPropertyName("infrastructureConfigurationArn")]
    public string? InfrastructureConfigurationArn { get; set; }

    /// <summary>Reference to a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
    [JsonPropertyName("infrastructureConfigurationArnRef")]
    public V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnRef? InfrastructureConfigurationArnRef { get; set; }

    /// <summary>Selector for a InfrastructureConfiguration in imagebuilder to populate infrastructureConfigurationArn.</summary>
    [JsonPropertyName("infrastructureConfigurationArnSelector")]
    public V1beta2ImagePipelineSpecInitProviderInfrastructureConfigurationArnSelector? InfrastructureConfigurationArnSelector { get; set; }

    /// <summary>Configuration block with logging configuration. Detailed below.</summary>
    [JsonPropertyName("loggingConfiguration")]
    public V1beta2ImagePipelineSpecInitProviderLoggingConfiguration? LoggingConfiguration { get; set; }

    /// <summary>Name of the image pipeline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block with schedule settings. Detailed below.</summary>
    [JsonPropertyName("schedule")]
    public V1beta2ImagePipelineSpecInitProviderSchedule? Schedule { get; set; }

    /// <summary>Status of the image pipeline. Valid values are DISABLED and ENABLED. Defaults to ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Configuration block with the workflow configuration. Detailed below.</summary>
    [JsonPropertyName("workflow")]
    public IList<V1beta2ImagePipelineSpecInitProviderWorkflow>? Workflow { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecManagementPoliciesEnum>))]
public enum V1beta2ImagePipelineSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ImagePipelineSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ImagePipelineSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ImagePipelineSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ImagePipelineSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ImagePipelineSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ImagePipelineSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ImagePipelineSpec defines the desired state of ImagePipeline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineSpec
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
    public V1beta2ImagePipelineSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ImagePipelineSpecForProvider ForProvider { get; set; }

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
    public V1beta2ImagePipelineSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ImagePipelineSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ImagePipelineSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ImagePipelineSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block with ECR configuration for image scanning. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineStatusAtProviderImageScanningConfigurationEcrConfiguration
{
    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("containerTags")]
    public IList<string>? ContainerTags { get; set; }

    /// <summary>The name of the repository to scan</summary>
    [JsonPropertyName("repositoryName")]
    public string? RepositoryName { get; set; }
}

/// <summary>Configuration block with image scanning configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineStatusAtProviderImageScanningConfiguration
{
    /// <summary>Configuration block with ECR configuration for image scanning. Detailed below.</summary>
    [JsonPropertyName("ecrConfiguration")]
    public V1beta2ImagePipelineStatusAtProviderImageScanningConfigurationEcrConfiguration? EcrConfiguration { get; set; }

    /// <summary>Whether image scans are enabled. Defaults to false.</summary>
    [JsonPropertyName("imageScanningEnabled")]
    public bool? ImageScanningEnabled { get; set; }
}

/// <summary>Configuration block with image tests configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineStatusAtProviderImageTestsConfiguration
{
    /// <summary>Whether image tests are enabled. Defaults to true.</summary>
    [JsonPropertyName("imageTestsEnabled")]
    public bool? ImageTestsEnabled { get; set; }

    /// <summary>Number of minutes before image tests time out. Valid values are between 60 and 1440. Defaults to 720.</summary>
    [JsonPropertyName("timeoutMinutes")]
    public double? TimeoutMinutes { get; set; }
}

/// <summary>Configuration block with logging configuration. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineStatusAtProviderLoggingConfiguration
{
    /// <summary>Name of the CloudWatch Log Group to send image logs to.</summary>
    [JsonPropertyName("imageLogGroupName")]
    public string? ImageLogGroupName { get; set; }

    /// <summary>Name of the CloudWatch Log Group to send pipeline logs to.</summary>
    [JsonPropertyName("pipelineLogGroupName")]
    public string? PipelineLogGroupName { get; set; }
}

/// <summary>Configuration block with schedule settings. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineStatusAtProviderSchedule
{
    /// <summary>Condition when the pipeline should trigger a new image build. Valid values are EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE and EXPRESSION_MATCH_ONLY. Defaults to EXPRESSION_MATCH_AND_DEPENDENCY_UPDATES_AVAILABLE.</summary>
    [JsonPropertyName("pipelineExecutionStartCondition")]
    public string? PipelineExecutionStartCondition { get; set; }

    /// <summary>Cron expression of how often the pipeline start condition is evaluated. For example, cron(0 0 * * ? *) is evaluated every day at midnight UTC. Configurations using the five field syntax that was previously accepted by the API, such as cron(0 0 * * *), must be updated to the six field syntax. For more information, see the Image Builder User Guide.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>The timezone that applies to the scheduling expression. For example, &quot;Etc/UTC&quot;, &quot;America/Los_Angeles&quot; in the IANA timezone format. If not specified this defaults to UTC.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineStatusAtProviderWorkflowParameter
{
    /// <summary>The name of the Workflow parameter.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The value of the Workflow parameter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineStatusAtProviderWorkflow
{
    /// <summary>The action to take if the workflow fails. Must be one of CONTINUE or ABORT.</summary>
    [JsonPropertyName("onFailure")]
    public string? OnFailure { get; set; }

    /// <summary>The parallel group in which to run a test Workflow.</summary>
    [JsonPropertyName("parallelGroup")]
    public string? ParallelGroup { get; set; }

    /// <summary>Configuration block for the workflow parameters. Detailed below.</summary>
    [JsonPropertyName("parameter")]
    public IList<V1beta2ImagePipelineStatusAtProviderWorkflowParameter>? Parameter { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Workflow.</summary>
    [JsonPropertyName("workflowArn")]
    public string? WorkflowArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineStatusAtProvider
{
    /// <summary>Amazon Resource Name (ARN) of the image pipeline.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the container recipe.</summary>
    [JsonPropertyName("containerRecipeArn")]
    public string? ContainerRecipeArn { get; set; }

    /// <summary>Date the image pipeline was created.</summary>
    [JsonPropertyName("dateCreated")]
    public string? DateCreated { get; set; }

    /// <summary>Date the image pipeline was last run.</summary>
    [JsonPropertyName("dateLastRun")]
    public string? DateLastRun { get; set; }

    /// <summary>Date the image pipeline will run next.</summary>
    [JsonPropertyName("dateNextRun")]
    public string? DateNextRun { get; set; }

    /// <summary>Date the image pipeline was updated.</summary>
    [JsonPropertyName("dateUpdated")]
    public string? DateUpdated { get; set; }

    /// <summary>Description of the image pipeline.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Distribution Configuration.</summary>
    [JsonPropertyName("distributionConfigurationArn")]
    public string? DistributionConfigurationArn { get; set; }

    /// <summary>Whether additional information about the image being created is collected. Defaults to true.</summary>
    [JsonPropertyName("enhancedImageMetadataEnabled")]
    public bool? EnhancedImageMetadataEnabled { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the service-linked role to be used by Image Builder to execute workflows.</summary>
    [JsonPropertyName("executionRole")]
    public string? ExecutionRole { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the image pipeline.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the image recipe.</summary>
    [JsonPropertyName("imageRecipeArn")]
    public string? ImageRecipeArn { get; set; }

    /// <summary>Configuration block with image scanning configuration. Detailed below.</summary>
    [JsonPropertyName("imageScanningConfiguration")]
    public V1beta2ImagePipelineStatusAtProviderImageScanningConfiguration? ImageScanningConfiguration { get; set; }

    /// <summary>Configuration block with image tests configuration. Detailed below.</summary>
    [JsonPropertyName("imageTestsConfiguration")]
    public V1beta2ImagePipelineStatusAtProviderImageTestsConfiguration? ImageTestsConfiguration { get; set; }

    /// <summary>Amazon Resource Name (ARN) of the Image Builder Infrastructure Configuration.</summary>
    [JsonPropertyName("infrastructureConfigurationArn")]
    public string? InfrastructureConfigurationArn { get; set; }

    /// <summary>Configuration block with logging configuration. Detailed below.</summary>
    [JsonPropertyName("loggingConfiguration")]
    public V1beta2ImagePipelineStatusAtProviderLoggingConfiguration? LoggingConfiguration { get; set; }

    /// <summary>Name of the image pipeline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Platform of the image pipeline.</summary>
    [JsonPropertyName("platform")]
    public string? Platform { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Configuration block with schedule settings. Detailed below.</summary>
    [JsonPropertyName("schedule")]
    public V1beta2ImagePipelineStatusAtProviderSchedule? Schedule { get; set; }

    /// <summary>Status of the image pipeline. Valid values are DISABLED and ENABLED. Defaults to ENABLED.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Configuration block with the workflow configuration. Detailed below.</summary>
    [JsonPropertyName("workflow")]
    public IList<V1beta2ImagePipelineStatusAtProviderWorkflow>? Workflow { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineStatusConditions
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

/// <summary>ImagePipelineStatus defines the observed state of ImagePipeline.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ImagePipelineStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ImagePipelineStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ImagePipelineStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>ImagePipeline is the Schema for the ImagePipelines API. Manages an Image Builder Image Pipeline</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ImagePipeline : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ImagePipelineSpec>, IStatus<V1beta2ImagePipelineStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ImagePipeline";
    public const string KubeGroup = "imagebuilder.aws.upbound.io";
    public const string KubePluralName = "imagepipelines";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "imagebuilder.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ImagePipeline";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ImagePipelineSpec defines the desired state of ImagePipeline</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ImagePipelineSpec Spec { get; set; }

    /// <summary>ImagePipelineStatus defines the observed state of ImagePipeline.</summary>
    [JsonPropertyName("status")]
    public V1beta2ImagePipelineStatus? Status { get; set; }
}