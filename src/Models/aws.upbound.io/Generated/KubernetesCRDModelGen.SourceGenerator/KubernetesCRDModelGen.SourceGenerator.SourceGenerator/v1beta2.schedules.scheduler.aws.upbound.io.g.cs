#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.scheduler.aws.upbound.io;
/// <summary>Schedule is the Schema for the Schedules API. Provides an EventBridge Scheduler Schedule resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ScheduleList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Schedule>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ScheduleList";
    public const string KubeGroup = "scheduler.aws.upbound.io";
    public const string KubePluralName = "schedules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "scheduler.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ScheduleList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Schedule objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Schedule> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecDeletionPolicyEnum>))]
public enum V1beta2ScheduleSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Configures a time window during which EventBridge Scheduler invokes the schedule. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderFlexibleTimeWindow
{
    /// <summary>Maximum time window during which a schedule can be invoked. Ranges from 1 to 1440 minutes.</summary>
    [JsonPropertyName("maximumWindowInMinutes")]
    public double? MaximumWindowInMinutes { get; set; }

    /// <summary>Determines whether the schedule is invoked within a flexible time window. One of: OFF, FLEXIBLE.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecForProviderKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta2ScheduleSpecForProviderKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecForProviderKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta2ScheduleSpecForProviderKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduleSpecForProviderKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduleSpecForProviderKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ScheduleSpecForProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ScheduleSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecForProviderKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta2ScheduleSpecForProviderKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduleSpecForProviderKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduleSpecForProviderKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderKmsKeyArnSelector
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
    public V1beta2ScheduleSpecForProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecForProviderTargetArnRefPolicyResolutionEnum>))]
public enum V1beta2ScheduleSpecForProviderTargetArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecForProviderTargetArnRefPolicyResolveEnum>))]
public enum V1beta2ScheduleSpecForProviderTargetArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduleSpecForProviderTargetArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduleSpecForProviderTargetArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Queue in sqs to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ScheduleSpecForProviderTargetArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecForProviderTargetArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ScheduleSpecForProviderTargetArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecForProviderTargetArnSelectorPolicyResolveEnum>))]
public enum V1beta2ScheduleSpecForProviderTargetArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduleSpecForProviderTargetArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduleSpecForProviderTargetArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Queue in sqs to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetArnSelector
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
    public V1beta2ScheduleSpecForProviderTargetArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Information about an Amazon SQS queue that EventBridge Scheduler uses as a dead-letter queue for your schedule. If specified, EventBridge Scheduler delivers failed events that could not be successfully delivered to a target to the queue. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetDeadLetterConfig
{
    /// <summary>ARN of the target of this schedule, such as a SQS queue or ECS cluster. For universal targets, this is a Service ARN specific to the target service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetEcsParametersCapacityProviderStrategy
{
    /// <summary>How many tasks, at a minimum, to run on the specified capacity provider. Only one capacity provider in a capacity provider strategy can have a base defined. Ranges from 0 (default) to 100000.</summary>
    [JsonPropertyName("base")]
    public double? Base { get; set; }

    /// <summary>Short name of the capacity provider.</summary>
    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    /// <summary>Designates the relative percentage of the total number of tasks launched that should use the specified capacity provider. The weight value is taken into consideration after the base value, if defined, is satisfied. Ranges from from 0 to 1000.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Configures the networking associated with the task. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetEcsParametersNetworkConfiguration
{
    /// <summary>Specifies whether the task&apos;s elastic network interface receives a public IP address. This attribute is a boolean type, where true maps to ENABLED and false to DISABLED. You can specify true only when the launch_type is set to FARGATE.</summary>
    [JsonPropertyName("assignPublicIp")]
    public bool? AssignPublicIp { get; set; }

    /// <summary>Set of 1 to 5 Security Group ID-s to be associated with the task. These security groups must all be in the same VPC.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Set of 1 to 16 subnets to be associated with the task. These subnets must all be in the same VPC.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetEcsParametersPlacementConstraints
{
    /// <summary>A cluster query language expression to apply to the constraint. You cannot specify an expression if the constraint type is distinctInstance. For more information, see Cluster query language in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The type of placement strategy. One of: random, spread, binpack.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetEcsParametersPlacementStrategy
{
    /// <summary>The field to apply the placement strategy against.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>The type of placement strategy. One of: random, spread, binpack.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Templated target type for the Amazon ECS RunTask API operation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetEcsParameters
{
    /// <summary>Up to 6 capacity provider strategies to use for the task. Detailed below.</summary>
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1beta2ScheduleSpecForProviderTargetEcsParametersCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    /// <summary>Specifies whether to enable Amazon ECS managed tags for the task. For more information, see Tagging Your Amazon ECS Resources in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("enableEcsManagedTags")]
    public bool? EnableEcsManagedTags { get; set; }

    /// <summary>Specifies whether to enable the execute command functionality for the containers in this task.</summary>
    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    /// <summary>Specifies an ECS task group for the task. At most 255 characters.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Specifies the launch type on which your task is running. The launch type that you specify here must match one of the launch type (compatibilities) of the target task. One of: EC2, FARGATE, EXTERNAL.</summary>
    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>Configures the networking associated with the task. Detailed below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta2ScheduleSpecForProviderTargetEcsParametersNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>A set of up to 10 placement constraints to use for the task. Detailed below.</summary>
    [JsonPropertyName("placementConstraints")]
    public IList<V1beta2ScheduleSpecForProviderTargetEcsParametersPlacementConstraints>? PlacementConstraints { get; set; }

    /// <summary>A set of up to 5 placement strategies. Detailed below.</summary>
    [JsonPropertyName("placementStrategy")]
    public IList<V1beta2ScheduleSpecForProviderTargetEcsParametersPlacementStrategy>? PlacementStrategy { get; set; }

    /// <summary>Specifies the platform version for the task. Specify only the numeric portion of the platform version, such as 1.1.0.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>Specifies whether to propagate the tags from the task definition to the task. One of: TASK_DEFINITION.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>Reference ID to use for the task.</summary>
    [JsonPropertyName("referenceId")]
    public string? ReferenceId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The number of tasks to create. Ranges from 1 (default) to 10.</summary>
    [JsonPropertyName("taskCount")]
    public double? TaskCount { get; set; }

    /// <summary>ARN of the task definition to use.</summary>
    [JsonPropertyName("taskDefinitionArn")]
    public string? TaskDefinitionArn { get; set; }
}

/// <summary>Templated target type for the EventBridge PutEvents API operation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetEventbridgeParameters
{
    /// <summary>Free-form string used to decide what fields to expect in the event detail. Up to 128 characters.</summary>
    [JsonPropertyName("detailType")]
    public string? DetailType { get; set; }

    /// <summary>Source of the event.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>Templated target type for the Amazon Kinesis PutRecord API operation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetKinesisParameters
{
    /// <summary>Specifies the shard to which EventBridge Scheduler sends the event. Up to 256 characters.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }
}

/// <summary>Information about the retry policy settings. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetRetryPolicy
{
    /// <summary>Maximum amount of time, in seconds, to continue to make retry attempts. Ranges from 60 to 86400 (default).</summary>
    [JsonPropertyName("maximumEventAgeInSeconds")]
    public double? MaximumEventAgeInSeconds { get; set; }

    /// <summary>Maximum number of retry attempts to make before the request fails. Ranges from 0 to 185 (default).</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecForProviderTargetRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ScheduleSpecForProviderTargetRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecForProviderTargetRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ScheduleSpecForProviderTargetRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduleSpecForProviderTargetRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduleSpecForProviderTargetRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ScheduleSpecForProviderTargetRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecForProviderTargetRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ScheduleSpecForProviderTargetRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecForProviderTargetRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ScheduleSpecForProviderTargetRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduleSpecForProviderTargetRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduleSpecForProviderTargetRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetRoleArnSelector
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
    public V1beta2ScheduleSpecForProviderTargetRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetSagemakerPipelineParametersPipelineParameter
{
    /// <summary>Name of parameter to start execution of a SageMaker AI Model Building Pipeline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of parameter to start execution of a SageMaker AI Model Building Pipeline.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Templated target type for the Amazon SageMaker AI StartPipelineExecution API operation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetSagemakerPipelineParameters
{
    /// <summary>Set of up to 200 parameter names and values to use when executing the SageMaker AI Model Building Pipeline. Detailed below.</summary>
    [JsonPropertyName("pipelineParameter")]
    public IList<V1beta2ScheduleSpecForProviderTargetSagemakerPipelineParametersPipelineParameter>? PipelineParameter { get; set; }
}

/// <summary>The templated target type for the Amazon SQS SendMessage API operation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTargetSqsParameters
{
    /// <summary>FIFO message group ID to use as the target.</summary>
    [JsonPropertyName("messageGroupId")]
    public string? MessageGroupId { get; set; }
}

/// <summary>Configures the target of the schedule. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProviderTarget
{
    /// <summary>ARN of the target of this schedule, such as a SQS queue or ECS cluster. For universal targets, this is a Service ARN specific to the target service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Queue in sqs to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2ScheduleSpecForProviderTargetArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Queue in sqs to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2ScheduleSpecForProviderTargetArnSelector? ArnSelector { get; set; }

    /// <summary>Information about an Amazon SQS queue that EventBridge Scheduler uses as a dead-letter queue for your schedule. If specified, EventBridge Scheduler delivers failed events that could not be successfully delivered to a target to the queue. Detailed below.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public V1beta2ScheduleSpecForProviderTargetDeadLetterConfig? DeadLetterConfig { get; set; }

    /// <summary>Templated target type for the Amazon ECS RunTask API operation. Detailed below.</summary>
    [JsonPropertyName("ecsParameters")]
    public V1beta2ScheduleSpecForProviderTargetEcsParameters? EcsParameters { get; set; }

    /// <summary>Templated target type for the EventBridge PutEvents API operation. Detailed below.</summary>
    [JsonPropertyName("eventbridgeParameters")]
    public V1beta2ScheduleSpecForProviderTargetEventbridgeParameters? EventbridgeParameters { get; set; }

    /// <summary>Text, or well-formed JSON, passed to the target. Read more in Universal target.</summary>
    [JsonPropertyName("input")]
    public string? Input { get; set; }

    /// <summary>Templated target type for the Amazon Kinesis PutRecord API operation. Detailed below.</summary>
    [JsonPropertyName("kinesisParameters")]
    public V1beta2ScheduleSpecForProviderTargetKinesisParameters? KinesisParameters { get; set; }

    /// <summary>Information about the retry policy settings. Detailed below.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2ScheduleSpecForProviderTargetRetryPolicy? RetryPolicy { get; set; }

    /// <summary>ARN of the IAM role that EventBridge Scheduler will use for this target when the schedule is invoked. Read more in Set up the execution role.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2ScheduleSpecForProviderTargetRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2ScheduleSpecForProviderTargetRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Templated target type for the Amazon SageMaker AI StartPipelineExecution API operation. Detailed below.</summary>
    [JsonPropertyName("sagemakerPipelineParameters")]
    public V1beta2ScheduleSpecForProviderTargetSagemakerPipelineParameters? SagemakerPipelineParameters { get; set; }

    /// <summary>The templated target type for the Amazon SQS SendMessage API operation. Detailed below.</summary>
    [JsonPropertyName("sqsParameters")]
    public V1beta2ScheduleSpecForProviderTargetSqsParameters? SqsParameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecForProvider
{
    /// <summary>Action that applies to the schedule after completing invocation of the target. Valid values are NONE and DELETE. Defaults to NONE.</summary>
    [JsonPropertyName("actionAfterCompletion")]
    public string? ActionAfterCompletion { get; set; }

    /// <summary>Brief description of the schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The date, in UTC, before which the schedule can invoke its target. Depending on the schedule&apos;s recurrence expression, invocations might stop on, or before, the end date you specify. EventBridge Scheduler ignores the end date for one-time schedules. Example: 2030-01-01T01:00:00Z.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>Configures a time window during which EventBridge Scheduler invokes the schedule. Detailed below.</summary>
    [JsonPropertyName("flexibleTimeWindow")]
    public V1beta2ScheduleSpecForProviderFlexibleTimeWindow? FlexibleTimeWindow { get; set; }

    /// <summary>Name of the schedule group to associate with this schedule. When omitted, the default schedule group is used.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>ARN for the customer managed KMS key that EventBridge Scheduler will use to encrypt and decrypt your data.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta2ScheduleSpecForProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta2ScheduleSpecForProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Name of the schedule. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Defines when the schedule runs. Read more in Schedule types on EventBridge Scheduler.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>Timezone in which the scheduling expression is evaluated. Defaults to UTC. Example: Australia/Sydney.</summary>
    [JsonPropertyName("scheduleExpressionTimezone")]
    public string? ScheduleExpressionTimezone { get; set; }

    /// <summary>The date, in UTC, after which the schedule can begin invoking its target. Depending on the schedule&apos;s recurrence expression, invocations might occur on, or after, the start date you specify. EventBridge Scheduler ignores the start date for one-time schedules. Example: 2030-01-01T01:00:00Z.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>Specifies whether the schedule is enabled or disabled. One of: ENABLED (default), DISABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Configures the target of the schedule. Detailed below.</summary>
    [JsonPropertyName("target")]
    public V1beta2ScheduleSpecForProviderTarget? Target { get; set; }
}

/// <summary>Configures a time window during which EventBridge Scheduler invokes the schedule. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderFlexibleTimeWindow
{
    /// <summary>Maximum time window during which a schedule can be invoked. Ranges from 1 to 1440 minutes.</summary>
    [JsonPropertyName("maximumWindowInMinutes")]
    public double? MaximumWindowInMinutes { get; set; }

    /// <summary>Determines whether the schedule is invoked within a flexible time window. One of: OFF, FLEXIBLE.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecInitProviderKmsKeyArnRefPolicyResolutionEnum>))]
public enum V1beta2ScheduleSpecInitProviderKmsKeyArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecInitProviderKmsKeyArnRefPolicyResolveEnum>))]
public enum V1beta2ScheduleSpecInitProviderKmsKeyArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderKmsKeyArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduleSpecInitProviderKmsKeyArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduleSpecInitProviderKmsKeyArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderKmsKeyArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ScheduleSpecInitProviderKmsKeyArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ScheduleSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum>))]
public enum V1beta2ScheduleSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderKmsKeyArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduleSpecInitProviderKmsKeyArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduleSpecInitProviderKmsKeyArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderKmsKeyArnSelector
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
    public V1beta2ScheduleSpecInitProviderKmsKeyArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecInitProviderTargetArnRefPolicyResolutionEnum>))]
public enum V1beta2ScheduleSpecInitProviderTargetArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecInitProviderTargetArnRefPolicyResolveEnum>))]
public enum V1beta2ScheduleSpecInitProviderTargetArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduleSpecInitProviderTargetArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduleSpecInitProviderTargetArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Queue in sqs to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ScheduleSpecInitProviderTargetArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecInitProviderTargetArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ScheduleSpecInitProviderTargetArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecInitProviderTargetArnSelectorPolicyResolveEnum>))]
public enum V1beta2ScheduleSpecInitProviderTargetArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduleSpecInitProviderTargetArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduleSpecInitProviderTargetArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Queue in sqs to populate arn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetArnSelector
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
    public V1beta2ScheduleSpecInitProviderTargetArnSelectorPolicy? Policy { get; set; }
}

/// <summary>Information about an Amazon SQS queue that EventBridge Scheduler uses as a dead-letter queue for your schedule. If specified, EventBridge Scheduler delivers failed events that could not be successfully delivered to a target to the queue. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetDeadLetterConfig
{
    /// <summary>ARN of the target of this schedule, such as a SQS queue or ECS cluster. For universal targets, this is a Service ARN specific to the target service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetEcsParametersCapacityProviderStrategy
{
    /// <summary>How many tasks, at a minimum, to run on the specified capacity provider. Only one capacity provider in a capacity provider strategy can have a base defined. Ranges from 0 (default) to 100000.</summary>
    [JsonPropertyName("base")]
    public double? Base { get; set; }

    /// <summary>Short name of the capacity provider.</summary>
    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    /// <summary>Designates the relative percentage of the total number of tasks launched that should use the specified capacity provider. The weight value is taken into consideration after the base value, if defined, is satisfied. Ranges from from 0 to 1000.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Configures the networking associated with the task. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetEcsParametersNetworkConfiguration
{
    /// <summary>Specifies whether the task&apos;s elastic network interface receives a public IP address. This attribute is a boolean type, where true maps to ENABLED and false to DISABLED. You can specify true only when the launch_type is set to FARGATE.</summary>
    [JsonPropertyName("assignPublicIp")]
    public bool? AssignPublicIp { get; set; }

    /// <summary>Set of 1 to 5 Security Group ID-s to be associated with the task. These security groups must all be in the same VPC.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Set of 1 to 16 subnets to be associated with the task. These subnets must all be in the same VPC.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetEcsParametersPlacementConstraints
{
    /// <summary>A cluster query language expression to apply to the constraint. You cannot specify an expression if the constraint type is distinctInstance. For more information, see Cluster query language in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The type of placement strategy. One of: random, spread, binpack.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetEcsParametersPlacementStrategy
{
    /// <summary>The field to apply the placement strategy against.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>The type of placement strategy. One of: random, spread, binpack.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Templated target type for the Amazon ECS RunTask API operation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetEcsParameters
{
    /// <summary>Up to 6 capacity provider strategies to use for the task. Detailed below.</summary>
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1beta2ScheduleSpecInitProviderTargetEcsParametersCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    /// <summary>Specifies whether to enable Amazon ECS managed tags for the task. For more information, see Tagging Your Amazon ECS Resources in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("enableEcsManagedTags")]
    public bool? EnableEcsManagedTags { get; set; }

    /// <summary>Specifies whether to enable the execute command functionality for the containers in this task.</summary>
    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    /// <summary>Specifies an ECS task group for the task. At most 255 characters.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Specifies the launch type on which your task is running. The launch type that you specify here must match one of the launch type (compatibilities) of the target task. One of: EC2, FARGATE, EXTERNAL.</summary>
    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>Configures the networking associated with the task. Detailed below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta2ScheduleSpecInitProviderTargetEcsParametersNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>A set of up to 10 placement constraints to use for the task. Detailed below.</summary>
    [JsonPropertyName("placementConstraints")]
    public IList<V1beta2ScheduleSpecInitProviderTargetEcsParametersPlacementConstraints>? PlacementConstraints { get; set; }

    /// <summary>A set of up to 5 placement strategies. Detailed below.</summary>
    [JsonPropertyName("placementStrategy")]
    public IList<V1beta2ScheduleSpecInitProviderTargetEcsParametersPlacementStrategy>? PlacementStrategy { get; set; }

    /// <summary>Specifies the platform version for the task. Specify only the numeric portion of the platform version, such as 1.1.0.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>Specifies whether to propagate the tags from the task definition to the task. One of: TASK_DEFINITION.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>Reference ID to use for the task.</summary>
    [JsonPropertyName("referenceId")]
    public string? ReferenceId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The number of tasks to create. Ranges from 1 (default) to 10.</summary>
    [JsonPropertyName("taskCount")]
    public double? TaskCount { get; set; }

    /// <summary>ARN of the task definition to use.</summary>
    [JsonPropertyName("taskDefinitionArn")]
    public string? TaskDefinitionArn { get; set; }
}

/// <summary>Templated target type for the EventBridge PutEvents API operation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetEventbridgeParameters
{
    /// <summary>Free-form string used to decide what fields to expect in the event detail. Up to 128 characters.</summary>
    [JsonPropertyName("detailType")]
    public string? DetailType { get; set; }

    /// <summary>Source of the event.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>Templated target type for the Amazon Kinesis PutRecord API operation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetKinesisParameters
{
    /// <summary>Specifies the shard to which EventBridge Scheduler sends the event. Up to 256 characters.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }
}

/// <summary>Information about the retry policy settings. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetRetryPolicy
{
    /// <summary>Maximum amount of time, in seconds, to continue to make retry attempts. Ranges from 60 to 86400 (default).</summary>
    [JsonPropertyName("maximumEventAgeInSeconds")]
    public double? MaximumEventAgeInSeconds { get; set; }

    /// <summary>Maximum number of retry attempts to make before the request fails. Ranges from 0 to 185 (default).</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecInitProviderTargetRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2ScheduleSpecInitProviderTargetRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecInitProviderTargetRoleArnRefPolicyResolveEnum>))]
public enum V1beta2ScheduleSpecInitProviderTargetRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduleSpecInitProviderTargetRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduleSpecInitProviderTargetRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ScheduleSpecInitProviderTargetRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecInitProviderTargetRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ScheduleSpecInitProviderTargetRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecInitProviderTargetRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2ScheduleSpecInitProviderTargetRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduleSpecInitProviderTargetRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduleSpecInitProviderTargetRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate roleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetRoleArnSelector
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
    public V1beta2ScheduleSpecInitProviderTargetRoleArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetSagemakerPipelineParametersPipelineParameter
{
    /// <summary>Name of parameter to start execution of a SageMaker AI Model Building Pipeline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of parameter to start execution of a SageMaker AI Model Building Pipeline.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Templated target type for the Amazon SageMaker AI StartPipelineExecution API operation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetSagemakerPipelineParameters
{
    /// <summary>Set of up to 200 parameter names and values to use when executing the SageMaker AI Model Building Pipeline. Detailed below.</summary>
    [JsonPropertyName("pipelineParameter")]
    public IList<V1beta2ScheduleSpecInitProviderTargetSagemakerPipelineParametersPipelineParameter>? PipelineParameter { get; set; }
}

/// <summary>The templated target type for the Amazon SQS SendMessage API operation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTargetSqsParameters
{
    /// <summary>FIFO message group ID to use as the target.</summary>
    [JsonPropertyName("messageGroupId")]
    public string? MessageGroupId { get; set; }
}

/// <summary>Configures the target of the schedule. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecInitProviderTarget
{
    /// <summary>ARN of the target of this schedule, such as a SQS queue or ECS cluster. For universal targets, this is a Service ARN specific to the target service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Reference to a Queue in sqs to populate arn.</summary>
    [JsonPropertyName("arnRef")]
    public V1beta2ScheduleSpecInitProviderTargetArnRef? ArnRef { get; set; }

    /// <summary>Selector for a Queue in sqs to populate arn.</summary>
    [JsonPropertyName("arnSelector")]
    public V1beta2ScheduleSpecInitProviderTargetArnSelector? ArnSelector { get; set; }

    /// <summary>Information about an Amazon SQS queue that EventBridge Scheduler uses as a dead-letter queue for your schedule. If specified, EventBridge Scheduler delivers failed events that could not be successfully delivered to a target to the queue. Detailed below.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public V1beta2ScheduleSpecInitProviderTargetDeadLetterConfig? DeadLetterConfig { get; set; }

    /// <summary>Templated target type for the Amazon ECS RunTask API operation. Detailed below.</summary>
    [JsonPropertyName("ecsParameters")]
    public V1beta2ScheduleSpecInitProviderTargetEcsParameters? EcsParameters { get; set; }

    /// <summary>Templated target type for the EventBridge PutEvents API operation. Detailed below.</summary>
    [JsonPropertyName("eventbridgeParameters")]
    public V1beta2ScheduleSpecInitProviderTargetEventbridgeParameters? EventbridgeParameters { get; set; }

    /// <summary>Text, or well-formed JSON, passed to the target. Read more in Universal target.</summary>
    [JsonPropertyName("input")]
    public string? Input { get; set; }

    /// <summary>Templated target type for the Amazon Kinesis PutRecord API operation. Detailed below.</summary>
    [JsonPropertyName("kinesisParameters")]
    public V1beta2ScheduleSpecInitProviderTargetKinesisParameters? KinesisParameters { get; set; }

    /// <summary>Information about the retry policy settings. Detailed below.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2ScheduleSpecInitProviderTargetRetryPolicy? RetryPolicy { get; set; }

    /// <summary>ARN of the IAM role that EventBridge Scheduler will use for this target when the schedule is invoked. Read more in Set up the execution role.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnRef")]
    public V1beta2ScheduleSpecInitProviderTargetRoleArnRef? RoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate roleArn.</summary>
    [JsonPropertyName("roleArnSelector")]
    public V1beta2ScheduleSpecInitProviderTargetRoleArnSelector? RoleArnSelector { get; set; }

    /// <summary>Templated target type for the Amazon SageMaker AI StartPipelineExecution API operation. Detailed below.</summary>
    [JsonPropertyName("sagemakerPipelineParameters")]
    public V1beta2ScheduleSpecInitProviderTargetSagemakerPipelineParameters? SagemakerPipelineParameters { get; set; }

    /// <summary>The templated target type for the Amazon SQS SendMessage API operation. Detailed below.</summary>
    [JsonPropertyName("sqsParameters")]
    public V1beta2ScheduleSpecInitProviderTargetSqsParameters? SqsParameters { get; set; }
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
public partial class V1beta2ScheduleSpecInitProvider
{
    /// <summary>Action that applies to the schedule after completing invocation of the target. Valid values are NONE and DELETE. Defaults to NONE.</summary>
    [JsonPropertyName("actionAfterCompletion")]
    public string? ActionAfterCompletion { get; set; }

    /// <summary>Brief description of the schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The date, in UTC, before which the schedule can invoke its target. Depending on the schedule&apos;s recurrence expression, invocations might stop on, or before, the end date you specify. EventBridge Scheduler ignores the end date for one-time schedules. Example: 2030-01-01T01:00:00Z.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>Configures a time window during which EventBridge Scheduler invokes the schedule. Detailed below.</summary>
    [JsonPropertyName("flexibleTimeWindow")]
    public V1beta2ScheduleSpecInitProviderFlexibleTimeWindow? FlexibleTimeWindow { get; set; }

    /// <summary>Name of the schedule group to associate with this schedule. When omitted, the default schedule group is used.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>ARN for the customer managed KMS key that EventBridge Scheduler will use to encrypt and decrypt your data.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Reference to a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnRef")]
    public V1beta2ScheduleSpecInitProviderKmsKeyArnRef? KmsKeyArnRef { get; set; }

    /// <summary>Selector for a Key in kms to populate kmsKeyArn.</summary>
    [JsonPropertyName("kmsKeyArnSelector")]
    public V1beta2ScheduleSpecInitProviderKmsKeyArnSelector? KmsKeyArnSelector { get; set; }

    /// <summary>Name of the schedule. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Defines when the schedule runs. Read more in Schedule types on EventBridge Scheduler.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>Timezone in which the scheduling expression is evaluated. Defaults to UTC. Example: Australia/Sydney.</summary>
    [JsonPropertyName("scheduleExpressionTimezone")]
    public string? ScheduleExpressionTimezone { get; set; }

    /// <summary>The date, in UTC, after which the schedule can begin invoking its target. Depending on the schedule&apos;s recurrence expression, invocations might occur on, or after, the start date you specify. EventBridge Scheduler ignores the start date for one-time schedules. Example: 2030-01-01T01:00:00Z.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>Specifies whether the schedule is enabled or disabled. One of: ENABLED (default), DISABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Configures the target of the schedule. Detailed below.</summary>
    [JsonPropertyName("target")]
    public V1beta2ScheduleSpecInitProviderTarget? Target { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecManagementPoliciesEnum>))]
public enum V1beta2ScheduleSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ScheduleSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ScheduleSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ScheduleSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ScheduleSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ScheduleSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ScheduleSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ScheduleSpec defines the desired state of Schedule</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleSpec
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
    public V1beta2ScheduleSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ScheduleSpecForProvider ForProvider { get; set; }

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
    public V1beta2ScheduleSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ScheduleSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ScheduleSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ScheduleSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configures a time window during which EventBridge Scheduler invokes the schedule. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleStatusAtProviderFlexibleTimeWindow
{
    /// <summary>Maximum time window during which a schedule can be invoked. Ranges from 1 to 1440 minutes.</summary>
    [JsonPropertyName("maximumWindowInMinutes")]
    public double? MaximumWindowInMinutes { get; set; }

    /// <summary>Determines whether the schedule is invoked within a flexible time window. One of: OFF, FLEXIBLE.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }
}

/// <summary>Information about an Amazon SQS queue that EventBridge Scheduler uses as a dead-letter queue for your schedule. If specified, EventBridge Scheduler delivers failed events that could not be successfully delivered to a target to the queue. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleStatusAtProviderTargetDeadLetterConfig
{
    /// <summary>ARN of the target of this schedule, such as a SQS queue or ECS cluster. For universal targets, this is a Service ARN specific to the target service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleStatusAtProviderTargetEcsParametersCapacityProviderStrategy
{
    /// <summary>How many tasks, at a minimum, to run on the specified capacity provider. Only one capacity provider in a capacity provider strategy can have a base defined. Ranges from 0 (default) to 100000.</summary>
    [JsonPropertyName("base")]
    public double? Base { get; set; }

    /// <summary>Short name of the capacity provider.</summary>
    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    /// <summary>Designates the relative percentage of the total number of tasks launched that should use the specified capacity provider. The weight value is taken into consideration after the base value, if defined, is satisfied. Ranges from from 0 to 1000.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Configures the networking associated with the task. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleStatusAtProviderTargetEcsParametersNetworkConfiguration
{
    /// <summary>Specifies whether the task&apos;s elastic network interface receives a public IP address. This attribute is a boolean type, where true maps to ENABLED and false to DISABLED. You can specify true only when the launch_type is set to FARGATE.</summary>
    [JsonPropertyName("assignPublicIp")]
    public bool? AssignPublicIp { get; set; }

    /// <summary>Set of 1 to 5 Security Group ID-s to be associated with the task. These security groups must all be in the same VPC.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Set of 1 to 16 subnets to be associated with the task. These subnets must all be in the same VPC.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleStatusAtProviderTargetEcsParametersPlacementConstraints
{
    /// <summary>A cluster query language expression to apply to the constraint. You cannot specify an expression if the constraint type is distinctInstance. For more information, see Cluster query language in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>The type of placement strategy. One of: random, spread, binpack.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleStatusAtProviderTargetEcsParametersPlacementStrategy
{
    /// <summary>The field to apply the placement strategy against.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>The type of placement strategy. One of: random, spread, binpack.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Templated target type for the Amazon ECS RunTask API operation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleStatusAtProviderTargetEcsParameters
{
    /// <summary>Up to 6 capacity provider strategies to use for the task. Detailed below.</summary>
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1beta2ScheduleStatusAtProviderTargetEcsParametersCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    /// <summary>Specifies whether to enable Amazon ECS managed tags for the task. For more information, see Tagging Your Amazon ECS Resources in the Amazon ECS Developer Guide.</summary>
    [JsonPropertyName("enableEcsManagedTags")]
    public bool? EnableEcsManagedTags { get; set; }

    /// <summary>Specifies whether to enable the execute command functionality for the containers in this task.</summary>
    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    /// <summary>Specifies an ECS task group for the task. At most 255 characters.</summary>
    [JsonPropertyName("group")]
    public string? Group { get; set; }

    /// <summary>Specifies the launch type on which your task is running. The launch type that you specify here must match one of the launch type (compatibilities) of the target task. One of: EC2, FARGATE, EXTERNAL.</summary>
    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>Configures the networking associated with the task. Detailed below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta2ScheduleStatusAtProviderTargetEcsParametersNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>A set of up to 10 placement constraints to use for the task. Detailed below.</summary>
    [JsonPropertyName("placementConstraints")]
    public IList<V1beta2ScheduleStatusAtProviderTargetEcsParametersPlacementConstraints>? PlacementConstraints { get; set; }

    /// <summary>A set of up to 5 placement strategies. Detailed below.</summary>
    [JsonPropertyName("placementStrategy")]
    public IList<V1beta2ScheduleStatusAtProviderTargetEcsParametersPlacementStrategy>? PlacementStrategy { get; set; }

    /// <summary>Specifies the platform version for the task. Specify only the numeric portion of the platform version, such as 1.1.0.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>Specifies whether to propagate the tags from the task definition to the task. One of: TASK_DEFINITION.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>Reference ID to use for the task.</summary>
    [JsonPropertyName("referenceId")]
    public string? ReferenceId { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>The number of tasks to create. Ranges from 1 (default) to 10.</summary>
    [JsonPropertyName("taskCount")]
    public double? TaskCount { get; set; }

    /// <summary>ARN of the task definition to use.</summary>
    [JsonPropertyName("taskDefinitionArn")]
    public string? TaskDefinitionArn { get; set; }
}

/// <summary>Templated target type for the EventBridge PutEvents API operation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleStatusAtProviderTargetEventbridgeParameters
{
    /// <summary>Free-form string used to decide what fields to expect in the event detail. Up to 128 characters.</summary>
    [JsonPropertyName("detailType")]
    public string? DetailType { get; set; }

    /// <summary>Source of the event.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }
}

/// <summary>Templated target type for the Amazon Kinesis PutRecord API operation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleStatusAtProviderTargetKinesisParameters
{
    /// <summary>Specifies the shard to which EventBridge Scheduler sends the event. Up to 256 characters.</summary>
    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }
}

/// <summary>Information about the retry policy settings. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleStatusAtProviderTargetRetryPolicy
{
    /// <summary>Maximum amount of time, in seconds, to continue to make retry attempts. Ranges from 60 to 86400 (default).</summary>
    [JsonPropertyName("maximumEventAgeInSeconds")]
    public double? MaximumEventAgeInSeconds { get; set; }

    /// <summary>Maximum number of retry attempts to make before the request fails. Ranges from 0 to 185 (default).</summary>
    [JsonPropertyName("maximumRetryAttempts")]
    public double? MaximumRetryAttempts { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleStatusAtProviderTargetSagemakerPipelineParametersPipelineParameter
{
    /// <summary>Name of parameter to start execution of a SageMaker AI Model Building Pipeline.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Value of parameter to start execution of a SageMaker AI Model Building Pipeline.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>Templated target type for the Amazon SageMaker AI StartPipelineExecution API operation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleStatusAtProviderTargetSagemakerPipelineParameters
{
    /// <summary>Set of up to 200 parameter names and values to use when executing the SageMaker AI Model Building Pipeline. Detailed below.</summary>
    [JsonPropertyName("pipelineParameter")]
    public IList<V1beta2ScheduleStatusAtProviderTargetSagemakerPipelineParametersPipelineParameter>? PipelineParameter { get; set; }
}

/// <summary>The templated target type for the Amazon SQS SendMessage API operation. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleStatusAtProviderTargetSqsParameters
{
    /// <summary>FIFO message group ID to use as the target.</summary>
    [JsonPropertyName("messageGroupId")]
    public string? MessageGroupId { get; set; }
}

/// <summary>Configures the target of the schedule. Detailed below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleStatusAtProviderTarget
{
    /// <summary>ARN of the target of this schedule, such as a SQS queue or ECS cluster. For universal targets, this is a Service ARN specific to the target service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Information about an Amazon SQS queue that EventBridge Scheduler uses as a dead-letter queue for your schedule. If specified, EventBridge Scheduler delivers failed events that could not be successfully delivered to a target to the queue. Detailed below.</summary>
    [JsonPropertyName("deadLetterConfig")]
    public V1beta2ScheduleStatusAtProviderTargetDeadLetterConfig? DeadLetterConfig { get; set; }

    /// <summary>Templated target type for the Amazon ECS RunTask API operation. Detailed below.</summary>
    [JsonPropertyName("ecsParameters")]
    public V1beta2ScheduleStatusAtProviderTargetEcsParameters? EcsParameters { get; set; }

    /// <summary>Templated target type for the EventBridge PutEvents API operation. Detailed below.</summary>
    [JsonPropertyName("eventbridgeParameters")]
    public V1beta2ScheduleStatusAtProviderTargetEventbridgeParameters? EventbridgeParameters { get; set; }

    /// <summary>Text, or well-formed JSON, passed to the target. Read more in Universal target.</summary>
    [JsonPropertyName("input")]
    public string? Input { get; set; }

    /// <summary>Templated target type for the Amazon Kinesis PutRecord API operation. Detailed below.</summary>
    [JsonPropertyName("kinesisParameters")]
    public V1beta2ScheduleStatusAtProviderTargetKinesisParameters? KinesisParameters { get; set; }

    /// <summary>Information about the retry policy settings. Detailed below.</summary>
    [JsonPropertyName("retryPolicy")]
    public V1beta2ScheduleStatusAtProviderTargetRetryPolicy? RetryPolicy { get; set; }

    /// <summary>ARN of the IAM role that EventBridge Scheduler will use for this target when the schedule is invoked. Read more in Set up the execution role.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Templated target type for the Amazon SageMaker AI StartPipelineExecution API operation. Detailed below.</summary>
    [JsonPropertyName("sagemakerPipelineParameters")]
    public V1beta2ScheduleStatusAtProviderTargetSagemakerPipelineParameters? SagemakerPipelineParameters { get; set; }

    /// <summary>The templated target type for the Amazon SQS SendMessage API operation. Detailed below.</summary>
    [JsonPropertyName("sqsParameters")]
    public V1beta2ScheduleStatusAtProviderTargetSqsParameters? SqsParameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleStatusAtProvider
{
    /// <summary>Action that applies to the schedule after completing invocation of the target. Valid values are NONE and DELETE. Defaults to NONE.</summary>
    [JsonPropertyName("actionAfterCompletion")]
    public string? ActionAfterCompletion { get; set; }

    /// <summary>ARN of the SQS queue specified as the destination for the dead-letter queue.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Brief description of the schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>The date, in UTC, before which the schedule can invoke its target. Depending on the schedule&apos;s recurrence expression, invocations might stop on, or before, the end date you specify. EventBridge Scheduler ignores the end date for one-time schedules. Example: 2030-01-01T01:00:00Z.</summary>
    [JsonPropertyName("endDate")]
    public string? EndDate { get; set; }

    /// <summary>Configures a time window during which EventBridge Scheduler invokes the schedule. Detailed below.</summary>
    [JsonPropertyName("flexibleTimeWindow")]
    public V1beta2ScheduleStatusAtProviderFlexibleTimeWindow? FlexibleTimeWindow { get; set; }

    /// <summary>Name of the schedule group to associate with this schedule. When omitted, the default schedule group is used.</summary>
    [JsonPropertyName("groupName")]
    public string? GroupName { get; set; }

    /// <summary>Name of the schedule.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>ARN for the customer managed KMS key that EventBridge Scheduler will use to encrypt and decrypt your data.</summary>
    [JsonPropertyName("kmsKeyArn")]
    public string? KmsKeyArn { get; set; }

    /// <summary>Name of the schedule. Conflicts with name_prefix.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Defines when the schedule runs. Read more in Schedule types on EventBridge Scheduler.</summary>
    [JsonPropertyName("scheduleExpression")]
    public string? ScheduleExpression { get; set; }

    /// <summary>Timezone in which the scheduling expression is evaluated. Defaults to UTC. Example: Australia/Sydney.</summary>
    [JsonPropertyName("scheduleExpressionTimezone")]
    public string? ScheduleExpressionTimezone { get; set; }

    /// <summary>The date, in UTC, after which the schedule can begin invoking its target. Depending on the schedule&apos;s recurrence expression, invocations might occur on, or after, the start date you specify. EventBridge Scheduler ignores the start date for one-time schedules. Example: 2030-01-01T01:00:00Z.</summary>
    [JsonPropertyName("startDate")]
    public string? StartDate { get; set; }

    /// <summary>Specifies whether the schedule is enabled or disabled. One of: ENABLED (default), DISABLED.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    /// <summary>Configures the target of the schedule. Detailed below.</summary>
    [JsonPropertyName("target")]
    public V1beta2ScheduleStatusAtProviderTarget? Target { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleStatusConditions
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

/// <summary>ScheduleStatus defines the observed state of Schedule.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ScheduleStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ScheduleStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ScheduleStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Schedule is the Schema for the Schedules API. Provides an EventBridge Scheduler Schedule resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Schedule : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ScheduleSpec>, IStatus<V1beta2ScheduleStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Schedule";
    public const string KubeGroup = "scheduler.aws.upbound.io";
    public const string KubePluralName = "schedules";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "scheduler.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Schedule";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ScheduleSpec defines the desired state of Schedule</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ScheduleSpec Spec { get; set; }

    /// <summary>ScheduleStatus defines the observed state of Schedule.</summary>
    [JsonPropertyName("status")]
    public V1beta2ScheduleStatus? Status { get; set; }
}