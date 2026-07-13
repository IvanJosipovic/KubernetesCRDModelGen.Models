#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.ecs.aws.upbound.io;
/// <summary>Service is the Schema for the Services API. Provides an ECS service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2ServiceList : IKubernetesObject<V1ListMeta>, IItems<V1beta2Service>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "ServiceList";
    public const string KubeGroup = "ecs.aws.upbound.io";
    public const string KubePluralName = "services";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecs.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "ServiceList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2Service objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2Service> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecDeletionPolicyEnum>))]
public enum V1beta2ServiceSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Information about the CloudWatch alarms. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderAlarms
{
    /// <summary>One or more CloudWatch alarm names.</summary>
    [JsonPropertyName("alarmNames")]
    public IList<string>? AlarmNames { get; set; }

    /// <summary>Whether to use the CloudWatch alarm option in the service deployment process.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Whether to configure Amazon ECS to roll back the service if a service deployment fails. If rollback is used, when a service deployment fails, the service is rolled back to the last deployment that completed successfully.</summary>
    [JsonPropertyName("rollback")]
    public bool? Rollback { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderCapacityProviderStrategy
{
    /// <summary>Number of tasks, at a minimum, to run on the specified capacity provider. Only one capacity provider in a capacity provider strategy can have a base defined.</summary>
    [JsonPropertyName("base")]
    public double? Base { get; set; }

    /// <summary>Short name of the capacity provider.</summary>
    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    /// <summary>Relative percentage of the total number of launched tasks that should use the specified capacity provider.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderClusterRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderClusterRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderClusterRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderClusterRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderClusterRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderClusterRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderClusterRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in ecs to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderClusterRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecForProviderClusterRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderClusterSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderClusterSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderClusterSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderClusterSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderClusterSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderClusterSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderClusterSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in ecs to populate cluster.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderClusterSelector
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
    public V1beta2ServiceSpecForProviderClusterSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for deployment circuit breaker. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderDeploymentCircuitBreaker
{
    /// <summary>Whether to enable the deployment circuit breaker logic for the service.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Whether to enable Amazon ECS to roll back the service if a service deployment fails. If rollback is enabled, when a service deployment fails, the service is rolled back to the last deployment that completed successfully.</summary>
    [JsonPropertyName("rollback")]
    public bool? Rollback { get; set; }
}

/// <summary>Configuration block for canary deployment strategy. Required when strategy is set to CANARY. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderDeploymentConfigurationCanaryConfiguration
{
    /// <summary>Number of minutes to wait before shifting all traffic to the new deployment. Valid range: 0-1440 minutes.</summary>
    [JsonPropertyName("canaryBakeTimeInMinutes")]
    public string? CanaryBakeTimeInMinutes { get; set; }

    /// <summary>Percentage of traffic to route to the canary deployment. Valid range: 0.1-100.0.</summary>
    [JsonPropertyName("canaryPercent")]
    public double? CanaryPercent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderDeploymentConfigurationLifecycleHook
{
    /// <summary>Custom parameters that Amazon ECS will pass to the hook target invocations (such as a Lambda function).</summary>
    [JsonPropertyName("hookDetails")]
    public string? HookDetails { get; set; }

    /// <summary>ARN of the Lambda function to invoke for the lifecycle hook.</summary>
    [JsonPropertyName("hookTargetArn")]
    public string? HookTargetArn { get; set; }

    /// <summary>Stages during the deployment when the hook should be invoked. Valid values: RECONCILE_SERVICE, PRE_SCALE_UP, POST_SCALE_UP, TEST_TRAFFIC_SHIFT, POST_TEST_TRAFFIC_SHIFT, PRODUCTION_TRAFFIC_SHIFT, POST_PRODUCTION_TRAFFIC_SHIFT.</summary>
    [JsonPropertyName("lifecycleStages")]
    public IList<string>? LifecycleStages { get; set; }

    /// <summary>ARN of the IAM role that grants the service permission to invoke the Lambda function.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>Configuration block for linear deployment strategy. Required when strategy is set to LINEAR. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderDeploymentConfigurationLinearConfiguration
{
    /// <summary>Number of minutes to wait between each step during a linear deployment. Valid range: 0-1440 minutes.</summary>
    [JsonPropertyName("stepBakeTimeInMinutes")]
    public string? StepBakeTimeInMinutes { get; set; }

    /// <summary>Percentage of traffic to shift in each step during a linear deployment. Valid range: 3.0-100.0.</summary>
    [JsonPropertyName("stepPercent")]
    public double? StepPercent { get; set; }
}

/// <summary>Configuration block for deployment settings. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderDeploymentConfiguration
{
    /// <summary>Number of minutes to wait after a new deployment is fully provisioned before terminating the old deployment. Valid range: 0-1440 minutes. Used with BLUE_GREEN, LINEAR, and CANARY strategies.</summary>
    [JsonPropertyName("bakeTimeInMinutes")]
    public string? BakeTimeInMinutes { get; set; }

    /// <summary>Configuration block for canary deployment strategy. Required when strategy is set to CANARY. See below.</summary>
    [JsonPropertyName("canaryConfiguration")]
    public V1beta2ServiceSpecForProviderDeploymentConfigurationCanaryConfiguration? CanaryConfiguration { get; set; }

    /// <summary>Configuration block for lifecycle hooks that are invoked during deployments. See below.</summary>
    [JsonPropertyName("lifecycleHook")]
    public IList<V1beta2ServiceSpecForProviderDeploymentConfigurationLifecycleHook>? LifecycleHook { get; set; }

    /// <summary>Configuration block for linear deployment strategy. Required when strategy is set to LINEAR. See below.</summary>
    [JsonPropertyName("linearConfiguration")]
    public V1beta2ServiceSpecForProviderDeploymentConfigurationLinearConfiguration? LinearConfiguration { get; set; }

    /// <summary>Type of deployment strategy. Valid values: ROLLING, BLUE_GREEN, LINEAR, CANARY. Default: ROLLING.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

/// <summary>Configuration block for deployment controller configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderDeploymentController
{
    /// <summary>Type of deployment controller. Valid values: CODE_DEPLOY, ECS, EXTERNAL. Default: ECS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderIamRoleRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderIamRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderIamRoleRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderIamRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderIamRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderIamRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderIamRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate iamRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderIamRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecForProviderIamRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderIamRoleSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderIamRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderIamRoleSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderIamRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderIamRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderIamRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderIamRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate iamRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderIamRoleSelector
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
    public V1beta2ServiceSpecForProviderIamRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for Blue/Green deployment settings. Required when using BLUE_GREEN deployment strategy. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderLoadBalancerAdvancedConfiguration
{
    /// <summary>ARN of the alternate target group to use for Blue/Green deployments.</summary>
    [JsonPropertyName("alternateTargetGroupArn")]
    public string? AlternateTargetGroupArn { get; set; }

    /// <summary>ARN of the listener rule that routes production traffic.</summary>
    [JsonPropertyName("productionListenerRule")]
    public string? ProductionListenerRule { get; set; }

    /// <summary>ARN of the IAM role that allows ECS to manage the target groups.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>ARN of the listener rule that routes test traffic.</summary>
    [JsonPropertyName("testListenerRule")]
    public string? TestListenerRule { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnSelector
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
    public V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderLoadBalancer
{
    /// <summary>Configuration block for Blue/Green deployment settings. Required when using BLUE_GREEN deployment strategy. See below.</summary>
    [JsonPropertyName("advancedConfiguration")]
    public V1beta2ServiceSpecForProviderLoadBalancerAdvancedConfiguration? AdvancedConfiguration { get; set; }

    /// <summary>Name of the container to associate with the load balancer (as it appears in a container definition).</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Port on the container to associate with the load balancer.</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Name of the ELB (Classic) to associate with the service.</summary>
    [JsonPropertyName("elbName")]
    public string? ElbName { get; set; }

    /// <summary>ARN of the Load Balancer target group to associate with the service.</summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnRef")]
    public V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnRef? TargetGroupArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnSelector")]
    public V1beta2ServiceSpecForProviderLoadBalancerTargetGroupArnSelector? TargetGroupArnSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupRefsPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupRefsPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupSelector
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
    public V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderNetworkConfigurationSubnetRefsPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderNetworkConfigurationSubnetRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderNetworkConfigurationSubnetRefsPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderNetworkConfigurationSubnetRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderNetworkConfigurationSubnetRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationSubnetRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationSubnetRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderNetworkConfigurationSubnetRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationSubnetRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderNetworkConfigurationSubnetSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderNetworkConfigurationSubnetSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderNetworkConfigurationSubnetSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderNetworkConfigurationSubnetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderNetworkConfigurationSubnetSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationSubnetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationSubnetSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderNetworkConfigurationSubnetSelector
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
    public V1beta2ServiceSpecForProviderNetworkConfigurationSubnetSelectorPolicy? Policy { get; set; }
}

/// <summary>Network configuration for the service. This parameter is required for task definitions that use the awsvpc network mode to receive their own Elastic Network Interface, and it is not supported for other network modes. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderNetworkConfiguration
{
    /// <summary>Assign a public IP address to the ENI (Fargate launch type only). Valid values are true or false. Default false.</summary>
    [JsonPropertyName("assignPublicIp")]
    public bool? AssignPublicIp { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupSelector")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationSecurityGroupSelector? SecurityGroupSelector { get; set; }

    /// <summary>Security groups associated with the task or service. If you do not specify a security group, the default security group for the VPC is used.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetRefs")]
    public IList<V1beta2ServiceSpecForProviderNetworkConfigurationSubnetRefs>? SubnetRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetSelector")]
    public V1beta2ServiceSpecForProviderNetworkConfigurationSubnetSelector? SubnetSelector { get; set; }

    /// <summary>Subnets associated with the task or service.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderOrderedPlacementStrategy
{
    /// <summary>For the spread placement strategy, valid values are instanceId (or host, which has the same effect), or any platform or custom attribute that is applied to a container instance. For the binpack type, valid values are memory and cpu. For the random type, this attribute is not needed. For more information, see Placement Strategy.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>Type of placement strategy. Must be one of: binpack, random, or spread</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderPlacementConstraints
{
    /// <summary>Cluster Query Language expression to apply to the constraint. Does not need to be specified for the distinctInstance type. For more information, see Cluster Query Language in the Amazon EC2 Container Service Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Type of constraint. The only valid values at this time are memberOf and distinctInstance.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for Service Connect access logs. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderServiceConnectConfigurationAccessLogConfiguration
{
    /// <summary>The format for Service Connect access log output. Valid values: TEXT, JSON. See AWS documentation for format details.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Specifies whether to include query parameters in Service Connect access logs. Valid values: ENABLED, DISABLED. Default: DISABLED. Query parameters may contain sensitive information.</summary>
    [JsonPropertyName("includeQueryParameters")]
    public string? IncludeQueryParameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderServiceConnectConfigurationLogConfigurationSecretOption
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Secret to expose to the container. The supported values are either the full ARN of the AWS Secrets Manager secret or the full ARN of the parameter in the SSM Parameter Store.</summary>
    [JsonPropertyName("valueFrom")]
    public string? ValueFrom { get; set; }
}

/// <summary>Log configuration for the container. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderServiceConnectConfigurationLogConfiguration
{
    /// <summary>Log driver to use for the container.</summary>
    [JsonPropertyName("logDriver")]
    public string? LogDriver { get; set; }

    /// <summary>Configuration options to send to the log driver.</summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    /// <summary>Secrets to pass to the log configuration. See below.</summary>
    [JsonPropertyName("secretOption")]
    public IList<V1beta2ServiceSpecForProviderServiceConnectConfigurationLogConfigurationSecretOption>? SecretOption { get; set; }
}

/// <summary>Configuration block for header value matching criteria. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue
{
    /// <summary>Exact string value to match in the header.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary>Configuration block for header-based routing rules. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader
{
    /// <summary>Name of the HTTP header to match.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block for header value matching criteria. See below.</summary>
    [JsonPropertyName("value")]
    public V1beta2ServiceSpecForProviderServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderServiceConnectConfigurationServiceClientAliasTestTrafficRules
{
    /// <summary>Configuration block for header-based routing rules. See below.</summary>
    [JsonPropertyName("header")]
    public V1beta2ServiceSpecForProviderServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader? Header { get; set; }
}

/// <summary>List of client aliases for this Service Connect service. You use these to assign names that can be used by client applications. For each service block where enabled is true, exactly one client_alias with one port should be specified. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderServiceConnectConfigurationServiceClientAlias
{
    /// <summary>Name that you use in the applications of client tasks to connect to this service.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>Listening port number for the Service Connect proxy. This port is available inside of all of the tasks within the same namespace.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Configuration block for test traffic routing rules. See below.</summary>
    [JsonPropertyName("testTrafficRules")]
    public IList<V1beta2ServiceSpecForProviderServiceConnectConfigurationServiceClientAliasTestTrafficRules>? TestTrafficRules { get; set; }
}

/// <summary>Configuration timeouts for Service Connect</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderServiceConnectConfigurationServiceTimeout
{
    /// <summary>Amount of time in seconds a connection will stay active while idle. A value of 0 can be set to disable idleTimeout.</summary>
    [JsonPropertyName("idleTimeoutSeconds")]
    public double? IdleTimeoutSeconds { get; set; }

    /// <summary>Amount of time in seconds for the upstream to respond with a complete response per request. A value of 0 can be set to disable perRequestTimeout. Can only be set when appProtocol isn&apos;t TCP.</summary>
    [JsonPropertyName("perRequestTimeoutSeconds")]
    public double? PerRequestTimeoutSeconds { get; set; }
}

/// <summary>Details of the certificate authority which will issue the certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderServiceConnectConfigurationServiceTlsIssuerCertAuthority
{
    /// <summary>ARN of the aws_acmpca_certificate_authority used to create the TLS Certificates.</summary>
    [JsonPropertyName("awsPcaAuthorityArn")]
    public string? AwsPcaAuthorityArn { get; set; }
}

/// <summary>Configuration for enabling Transport Layer Security (TLS)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderServiceConnectConfigurationServiceTls
{
    /// <summary>Details of the certificate authority which will issue the certificate.</summary>
    [JsonPropertyName("issuerCertAuthority")]
    public V1beta2ServiceSpecForProviderServiceConnectConfigurationServiceTlsIssuerCertAuthority? IssuerCertAuthority { get; set; }

    /// <summary>KMS key used to encrypt the private key in Secrets Manager.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>ARN of the IAM Role that&apos;s associated with the Service Connect TLS.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderServiceConnectConfigurationService
{
    /// <summary>List of client aliases for this Service Connect service. You use these to assign names that can be used by client applications. For each service block where enabled is true, exactly one client_alias with one port should be specified. See below.</summary>
    [JsonPropertyName("clientAlias")]
    public V1beta2ServiceSpecForProviderServiceConnectConfigurationServiceClientAlias? ClientAlias { get; set; }

    /// <summary>Name of the new AWS Cloud Map service that Amazon ECS creates for this Amazon ECS service.</summary>
    [JsonPropertyName("discoveryName")]
    public string? DiscoveryName { get; set; }

    /// <summary>Port number for the Service Connect proxy to listen on.</summary>
    [JsonPropertyName("ingressPortOverride")]
    public double? IngressPortOverride { get; set; }

    /// <summary>Name of one of the portMappings from all the containers in the task definition of this Amazon ECS service.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Configuration timeouts for Service Connect</summary>
    [JsonPropertyName("timeout")]
    public V1beta2ServiceSpecForProviderServiceConnectConfigurationServiceTimeout? Timeout { get; set; }

    /// <summary>Configuration for enabling Transport Layer Security (TLS)</summary>
    [JsonPropertyName("tls")]
    public V1beta2ServiceSpecForProviderServiceConnectConfigurationServiceTls? Tls { get; set; }
}

/// <summary>ECS Service Connect configuration for this service to discover and connect to services, and be discovered by, and connected from, other services within a namespace. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderServiceConnectConfiguration
{
    /// <summary>Configuration for Service Connect access logs. See below.</summary>
    [JsonPropertyName("accessLogConfiguration")]
    public V1beta2ServiceSpecForProviderServiceConnectConfigurationAccessLogConfiguration? AccessLogConfiguration { get; set; }

    /// <summary>Whether to use Service Connect with this service.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Log configuration for the container. See below.</summary>
    [JsonPropertyName("logConfiguration")]
    public V1beta2ServiceSpecForProviderServiceConnectConfigurationLogConfiguration? LogConfiguration { get; set; }

    /// <summary>Namespace name or ARN of the aws_service_discovery_http_namespace for use with Service Connect.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>List of Service Connect service objects. See below.</summary>
    [JsonPropertyName("service")]
    public IList<V1beta2ServiceSpecForProviderServiceConnectConfigurationService>? Service { get; set; }
}

/// <summary>Service discovery registries for the service. The maximum number of service_registries blocks is 1. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderServiceRegistries
{
    /// <summary>Container name value, already specified in the task definition, to be used for your service discovery service.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Port value, already specified in the task definition, to be used for your service discovery service.</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Port value used if your Service Discovery service specified an SRV record.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>ARN of the Service Registry. The currently supported service registry is Amazon Route 53 Auto Naming Service(aws_service_discovery_service). For more information, see Service</summary>
    [JsonPropertyName("registryArn")]
    public string? RegistryArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderTaskDefinitionRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderTaskDefinitionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderTaskDefinitionRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderTaskDefinitionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTaskDefinitionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderTaskDefinitionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderTaskDefinitionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a TaskDefinition in ecs to populate taskDefinition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTaskDefinitionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecForProviderTaskDefinitionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderTaskDefinitionSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecForProviderTaskDefinitionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecForProviderTaskDefinitionSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecForProviderTaskDefinitionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTaskDefinitionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecForProviderTaskDefinitionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecForProviderTaskDefinitionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a TaskDefinition in ecs to populate taskDefinition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderTaskDefinitionSelector
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
    public V1beta2ServiceSpecForProviderTaskDefinitionSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderVolumeConfigurationManagedEbsVolumeTagSpecifications
{
    /// <summary>Whether to propagate the tags from the task definition or the service to the tasks. The valid values are SERVICE and TASK_DEFINITION.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>The type of volume resource. Valid values, volume.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Configuration for the Amazon EBS volume that Amazon ECS creates and manages on your behalf. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderVolumeConfigurationManagedEbsVolume
{
    /// <summary>Whether the volume should be encrypted. Default value is true.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Linux filesystem type for the volume. For volumes created from a snapshot, same filesystem type must be specified that the volume was using when the snapshot was created. Valid values are ext3, ext4, xfs. Default value is xfs.</summary>
    [JsonPropertyName("fileSystemType")]
    public string? FileSystemType { get; set; }

    /// <summary>Number of I/O operations per second (IOPS).</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) identifier of the Amazon Web Services Key Management Service key to use for Amazon EBS encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The ARN of the IAM role to associate with this volume. This is the Amazon ECS infrastructure IAM role that is used to manage your AWS infrastructure.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Size of the volume in GiB. You must specify either a size_in_gb or a snapshot_id. You can optionally specify a volume size greater than or equal to the snapshot size.</summary>
    [JsonPropertyName("sizeInGb")]
    public double? SizeInGb { get; set; }

    /// <summary>Snapshot that Amazon ECS uses to create the volume. You must specify either a size_in_gb or a snapshot_id.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The tags to apply to the volume. See below.</summary>
    [JsonPropertyName("tagSpecifications")]
    public IList<V1beta2ServiceSpecForProviderVolumeConfigurationManagedEbsVolumeTagSpecifications>? TagSpecifications { get; set; }

    /// <summary>Throughput to provision for a volume, in MiB/s, with a maximum of 1,000 MiB/s.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Volume Initialization Rate in MiB/s. You must also specify a snapshot_id.</summary>
    [JsonPropertyName("volumeInitializationRate")]
    public double? VolumeInitializationRate { get; set; }

    /// <summary>Volume type.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>Configuration for a volume specified in the task definition as a volume that is configured at launch time. Currently, the only supported volume type is an Amazon EBS volume. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderVolumeConfiguration
{
    /// <summary>Configuration for the Amazon EBS volume that Amazon ECS creates and manages on your behalf. See below.</summary>
    [JsonPropertyName("managedEbsVolume")]
    public V1beta2ServiceSpecForProviderVolumeConfigurationManagedEbsVolume? ManagedEbsVolume { get; set; }

    /// <summary>Name of the volume.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProviderVpcLatticeConfigurations
{
    /// <summary>The name of the port for a target group associated with the VPC Lattice configuration.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>The ARN of the IAM role to associate with this volume. This is the Amazon ECS infrastructure IAM role that is used to manage your AWS infrastructure.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The full ARN of the target group or groups associated with the VPC Lattice configuration.</summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecForProvider
{
    /// <summary>Information about the CloudWatch alarms. See below.</summary>
    [JsonPropertyName("alarms")]
    public V1beta2ServiceSpecForProviderAlarms? Alarms { get; set; }

    /// <summary>ECS automatically redistributes tasks within a service across Availability Zones (AZs) to mitigate the risk of impaired application availability due to underlying infrastructure failures and task lifecycle activities. The valid values are ENABLED and DISABLED. When creating a new service, if no value is specified, it defaults to ENABLED if the service is compatible with AvailabilityZoneRebalancing. When updating an existing service, if no value is specified it defaults to the existing service&apos;s AvailabilityZoneRebalancing value. If the service never had an AvailabilityZoneRebalancing value set, Amazon ECS treats this as DISABLED.</summary>
    [JsonPropertyName("availabilityZoneRebalancing")]
    public string? AvailabilityZoneRebalancing { get; set; }

    /// <summary>Capacity provider strategies to use for the service. Can be one or more. Updating this argument requires force_new_deployment = true. See below. Conflicts with launch_type.</summary>
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1beta2ServiceSpecForProviderCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    /// <summary>Name of an ECS cluster.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Reference to a Cluster in ecs to populate cluster.</summary>
    [JsonPropertyName("clusterRef")]
    public V1beta2ServiceSpecForProviderClusterRef? ClusterRef { get; set; }

    /// <summary>Selector for a Cluster in ecs to populate cluster.</summary>
    [JsonPropertyName("clusterSelector")]
    public V1beta2ServiceSpecForProviderClusterSelector? ClusterSelector { get; set; }

    /// <summary>Configuration block for deployment circuit breaker. See below.</summary>
    [JsonPropertyName("deploymentCircuitBreaker")]
    public V1beta2ServiceSpecForProviderDeploymentCircuitBreaker? DeploymentCircuitBreaker { get; set; }

    /// <summary>Configuration block for deployment settings. See below.</summary>
    [JsonPropertyName("deploymentConfiguration")]
    public V1beta2ServiceSpecForProviderDeploymentConfiguration? DeploymentConfiguration { get; set; }

    /// <summary>Configuration block for deployment controller configuration. See below.</summary>
    [JsonPropertyName("deploymentController")]
    public V1beta2ServiceSpecForProviderDeploymentController? DeploymentController { get; set; }

    /// <summary>Upper limit (as a percentage of the service&apos;s desiredCount) of the number of running tasks that can be running in a service during a deployment. Not valid when using the DAEMON scheduling strategy.</summary>
    [JsonPropertyName("deploymentMaximumPercent")]
    public double? DeploymentMaximumPercent { get; set; }

    /// <summary>Lower limit (as a percentage of the service&apos;s desiredCount) of the number of running tasks that must remain running and healthy in a service during a deployment.</summary>
    [JsonPropertyName("deploymentMinimumHealthyPercent")]
    public double? DeploymentMinimumHealthyPercent { get; set; }

    /// <summary>Number of instances of the task definition to place and keep running. Defaults to 0. Do not specify if using the DAEMON scheduling strategy.</summary>
    [JsonPropertyName("desiredCount")]
    public double? DesiredCount { get; set; }

    /// <summary>Whether to enable Amazon ECS managed tags for the tasks within the service.</summary>
    [JsonPropertyName("enableEcsManagedTags")]
    public bool? EnableEcsManagedTags { get; set; }

    /// <summary>Whether to enable Amazon ECS Exec for the tasks within the service.</summary>
    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    /// <summary>Enable to delete a service even if it wasn&apos;t scaled down to zero tasks. It&apos;s only necessary to use this if the service uses the REPLICA scheduling strategy.</summary>
    [JsonPropertyName("forceDelete")]
    public bool? ForceDelete { get; set; }

    /// <summary>Enable to force a new task deployment of the service. This can be used to update tasks to use a newer Docker image with same image/tag combination (e.g., myimage:latest), roll Fargate tasks onto a newer platform version, or immediately deploy ordered_placement_strategy and placement_constraints updates.</summary>
    [JsonPropertyName("forceNewDeployment")]
    public bool? ForceNewDeployment { get; set; }

    /// <summary>Seconds to ignore failing load balancer health checks on newly instantiated tasks to prevent premature shutdown, up to 2147483647. Only valid for services configured to use load balancers.</summary>
    [JsonPropertyName("healthCheckGracePeriodSeconds")]
    public double? HealthCheckGracePeriodSeconds { get; set; }

    /// <summary>ARN of the IAM role that allows Amazon ECS to make calls to your load balancer on your behalf. This parameter is required if you are using a load balancer with your service, but only if your task definition does not use the awsvpc network mode. If using awsvpc network mode, do not specify this role. If your account has already created the Amazon ECS service-linked role, that role is used by default for your service unless you specify a role here.</summary>
    [JsonPropertyName("iamRole")]
    public string? IamRole { get; set; }

    /// <summary>Reference to a Role in iam to populate iamRole.</summary>
    [JsonPropertyName("iamRoleRef")]
    public V1beta2ServiceSpecForProviderIamRoleRef? IamRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate iamRole.</summary>
    [JsonPropertyName("iamRoleSelector")]
    public V1beta2ServiceSpecForProviderIamRoleSelector? IamRoleSelector { get; set; }

    /// <summary>Launch type on which to run your service. The valid values are EC2, FARGATE, and EXTERNAL. Defaults to EC2. Conflicts with capacity_provider_strategy.</summary>
    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>Configuration block for load balancers. See below.</summary>
    [JsonPropertyName("loadBalancer")]
    public IList<V1beta2ServiceSpecForProviderLoadBalancer>? LoadBalancer { get; set; }

    /// <summary>Network configuration for the service. This parameter is required for task definitions that use the awsvpc network mode to receive their own Elastic Network Interface, and it is not supported for other network modes. See below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta2ServiceSpecForProviderNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>Service level strategy rules that are taken into consideration during task placement. List from top to bottom in order of precedence. Updates to this configuration will take effect next task deployment unless force_new_deployment is enabled. The maximum number of ordered_placement_strategy blocks is 5. See below.</summary>
    [JsonPropertyName("orderedPlacementStrategy")]
    public IList<V1beta2ServiceSpecForProviderOrderedPlacementStrategy>? OrderedPlacementStrategy { get; set; }

    /// <summary>Rules that are taken into consideration during task placement. Updates to this configuration will take effect next task deployment unless force_new_deployment is enabled. Maximum number of placement_constraints is 10. See below.</summary>
    [JsonPropertyName("placementConstraints")]
    public IList<V1beta2ServiceSpecForProviderPlacementConstraints>? PlacementConstraints { get; set; }

    /// <summary>Platform version on which to run your service. Only applicable for launch_type set to FARGATE. Defaults to LATEST. More information about Fargate platform versions can be found in the AWS ECS User Guide.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>Whether to propagate the tags from the task definition or the service to the tasks. The valid values are SERVICE and TASK_DEFINITION.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>Scheduling strategy to use for the service. The valid values are REPLICA and DAEMON. Defaults to REPLICA. Note that Tasks using the Fargate launch type or the .</summary>
    [JsonPropertyName("schedulingStrategy")]
    public string? SchedulingStrategy { get; set; }

    /// <summary>ECS Service Connect configuration for this service to discover and connect to services, and be discovered by, and connected from, other services within a namespace. See below.</summary>
    [JsonPropertyName("serviceConnectConfiguration")]
    public V1beta2ServiceSpecForProviderServiceConnectConfiguration? ServiceConnectConfiguration { get; set; }

    /// <summary>Service discovery registries for the service. The maximum number of service_registries blocks is 1. See below.</summary>
    [JsonPropertyName("serviceRegistries")]
    public V1beta2ServiceSpecForProviderServiceRegistries? ServiceRegistries { get; set; }

    /// <summary>Whether to enable graceful termination of deployments using SIGINT signals. When enabled, allows customers to safely cancel an in-progress deployment and automatically trigger a rollback to the previous stable state. Defaults to false. Only applicable when using ECS deployment controller and requires wait_for_steady_state = true.</summary>
    [JsonPropertyName("sigintRollback")]
    public bool? SigintRollback { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Family and revision (family:revision) or full ARN of the task definition that you want to run in your service. Required unless using the EXTERNAL deployment controller. If a revision is not specified, the latest ACTIVE revision is used.</summary>
    [JsonPropertyName("taskDefinition")]
    public string? TaskDefinition { get; set; }

    /// <summary>Reference to a TaskDefinition in ecs to populate taskDefinition.</summary>
    [JsonPropertyName("taskDefinitionRef")]
    public V1beta2ServiceSpecForProviderTaskDefinitionRef? TaskDefinitionRef { get; set; }

    /// <summary>Selector for a TaskDefinition in ecs to populate taskDefinition.</summary>
    [JsonPropertyName("taskDefinitionSelector")]
    public V1beta2ServiceSpecForProviderTaskDefinitionSelector? TaskDefinitionSelector { get; set; }

    /// <summary>Map of arbitrary keys and values that, when changed, will trigger an in-place update (redeployment). Useful with plantimestamp(). See example above.</summary>
    [JsonPropertyName("triggers")]
    public IDictionary<string, string>? Triggers { get; set; }

    /// <summary>Configuration for a volume specified in the task definition as a volume that is configured at launch time. Currently, the only supported volume type is an Amazon EBS volume. See below.</summary>
    [JsonPropertyName("volumeConfiguration")]
    public V1beta2ServiceSpecForProviderVolumeConfiguration? VolumeConfiguration { get; set; }

    /// <summary>The VPC Lattice configuration for your service that allows Lattice to connect, secure, and monitor your service across multiple accounts and VPCs. See below.</summary>
    [JsonPropertyName("vpcLatticeConfigurations")]
    public IList<V1beta2ServiceSpecForProviderVpcLatticeConfigurations>? VpcLatticeConfigurations { get; set; }

    /// <summary>Default false.</summary>
    [JsonPropertyName("waitForSteadyState")]
    public bool? WaitForSteadyState { get; set; }
}

/// <summary>Information about the CloudWatch alarms. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderAlarms
{
    /// <summary>One or more CloudWatch alarm names.</summary>
    [JsonPropertyName("alarmNames")]
    public IList<string>? AlarmNames { get; set; }

    /// <summary>Whether to use the CloudWatch alarm option in the service deployment process.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Whether to configure Amazon ECS to roll back the service if a service deployment fails. If rollback is used, when a service deployment fails, the service is rolled back to the last deployment that completed successfully.</summary>
    [JsonPropertyName("rollback")]
    public bool? Rollback { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderCapacityProviderStrategy
{
    /// <summary>Number of tasks, at a minimum, to run on the specified capacity provider. Only one capacity provider in a capacity provider strategy can have a base defined.</summary>
    [JsonPropertyName("base")]
    public double? Base { get; set; }

    /// <summary>Short name of the capacity provider.</summary>
    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    /// <summary>Relative percentage of the total number of launched tasks that should use the specified capacity provider.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Configuration block for deployment circuit breaker. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderDeploymentCircuitBreaker
{
    /// <summary>Whether to enable the deployment circuit breaker logic for the service.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Whether to enable Amazon ECS to roll back the service if a service deployment fails. If rollback is enabled, when a service deployment fails, the service is rolled back to the last deployment that completed successfully.</summary>
    [JsonPropertyName("rollback")]
    public bool? Rollback { get; set; }
}

/// <summary>Configuration block for canary deployment strategy. Required when strategy is set to CANARY. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderDeploymentConfigurationCanaryConfiguration
{
    /// <summary>Number of minutes to wait before shifting all traffic to the new deployment. Valid range: 0-1440 minutes.</summary>
    [JsonPropertyName("canaryBakeTimeInMinutes")]
    public string? CanaryBakeTimeInMinutes { get; set; }

    /// <summary>Percentage of traffic to route to the canary deployment. Valid range: 0.1-100.0.</summary>
    [JsonPropertyName("canaryPercent")]
    public double? CanaryPercent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderDeploymentConfigurationLifecycleHook
{
    /// <summary>Custom parameters that Amazon ECS will pass to the hook target invocations (such as a Lambda function).</summary>
    [JsonPropertyName("hookDetails")]
    public string? HookDetails { get; set; }

    /// <summary>ARN of the Lambda function to invoke for the lifecycle hook.</summary>
    [JsonPropertyName("hookTargetArn")]
    public string? HookTargetArn { get; set; }

    /// <summary>Stages during the deployment when the hook should be invoked. Valid values: RECONCILE_SERVICE, PRE_SCALE_UP, POST_SCALE_UP, TEST_TRAFFIC_SHIFT, POST_TEST_TRAFFIC_SHIFT, PRODUCTION_TRAFFIC_SHIFT, POST_PRODUCTION_TRAFFIC_SHIFT.</summary>
    [JsonPropertyName("lifecycleStages")]
    public IList<string>? LifecycleStages { get; set; }

    /// <summary>ARN of the IAM role that grants the service permission to invoke the Lambda function.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>Configuration block for linear deployment strategy. Required when strategy is set to LINEAR. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderDeploymentConfigurationLinearConfiguration
{
    /// <summary>Number of minutes to wait between each step during a linear deployment. Valid range: 0-1440 minutes.</summary>
    [JsonPropertyName("stepBakeTimeInMinutes")]
    public string? StepBakeTimeInMinutes { get; set; }

    /// <summary>Percentage of traffic to shift in each step during a linear deployment. Valid range: 3.0-100.0.</summary>
    [JsonPropertyName("stepPercent")]
    public double? StepPercent { get; set; }
}

/// <summary>Configuration block for deployment settings. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderDeploymentConfiguration
{
    /// <summary>Number of minutes to wait after a new deployment is fully provisioned before terminating the old deployment. Valid range: 0-1440 minutes. Used with BLUE_GREEN, LINEAR, and CANARY strategies.</summary>
    [JsonPropertyName("bakeTimeInMinutes")]
    public string? BakeTimeInMinutes { get; set; }

    /// <summary>Configuration block for canary deployment strategy. Required when strategy is set to CANARY. See below.</summary>
    [JsonPropertyName("canaryConfiguration")]
    public V1beta2ServiceSpecInitProviderDeploymentConfigurationCanaryConfiguration? CanaryConfiguration { get; set; }

    /// <summary>Configuration block for lifecycle hooks that are invoked during deployments. See below.</summary>
    [JsonPropertyName("lifecycleHook")]
    public IList<V1beta2ServiceSpecInitProviderDeploymentConfigurationLifecycleHook>? LifecycleHook { get; set; }

    /// <summary>Configuration block for linear deployment strategy. Required when strategy is set to LINEAR. See below.</summary>
    [JsonPropertyName("linearConfiguration")]
    public V1beta2ServiceSpecInitProviderDeploymentConfigurationLinearConfiguration? LinearConfiguration { get; set; }

    /// <summary>Type of deployment strategy. Valid values: ROLLING, BLUE_GREEN, LINEAR, CANARY. Default: ROLLING.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

/// <summary>Configuration block for deployment controller configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderDeploymentController
{
    /// <summary>Type of deployment controller. Valid values: CODE_DEPLOY, ECS, EXTERNAL. Default: ECS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderIamRoleRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderIamRoleRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderIamRoleRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderIamRoleRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderIamRoleRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderIamRoleRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderIamRoleRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate iamRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderIamRoleRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecInitProviderIamRoleRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderIamRoleSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderIamRoleSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderIamRoleSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderIamRoleSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderIamRoleSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderIamRoleSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderIamRoleSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate iamRole.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderIamRoleSelector
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
    public V1beta2ServiceSpecInitProviderIamRoleSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for Blue/Green deployment settings. Required when using BLUE_GREEN deployment strategy. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderLoadBalancerAdvancedConfiguration
{
    /// <summary>ARN of the alternate target group to use for Blue/Green deployments.</summary>
    [JsonPropertyName("alternateTargetGroupArn")]
    public string? AlternateTargetGroupArn { get; set; }

    /// <summary>ARN of the listener rule that routes production traffic.</summary>
    [JsonPropertyName("productionListenerRule")]
    public string? ProductionListenerRule { get; set; }

    /// <summary>ARN of the IAM role that allows ECS to manage the target groups.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>ARN of the listener rule that routes test traffic.</summary>
    [JsonPropertyName("testListenerRule")]
    public string? TestListenerRule { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnSelector
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
    public V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderLoadBalancer
{
    /// <summary>Configuration block for Blue/Green deployment settings. Required when using BLUE_GREEN deployment strategy. See below.</summary>
    [JsonPropertyName("advancedConfiguration")]
    public V1beta2ServiceSpecInitProviderLoadBalancerAdvancedConfiguration? AdvancedConfiguration { get; set; }

    /// <summary>Name of the container to associate with the load balancer (as it appears in a container definition).</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Port on the container to associate with the load balancer.</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Name of the ELB (Classic) to associate with the service.</summary>
    [JsonPropertyName("elbName")]
    public string? ElbName { get; set; }

    /// <summary>ARN of the Load Balancer target group to associate with the service.</summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnRef")]
    public V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnRef? TargetGroupArnRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate targetGroupArn.</summary>
    [JsonPropertyName("targetGroupArnSelector")]
    public V1beta2ServiceSpecInitProviderLoadBalancerTargetGroupArnSelector? TargetGroupArnSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupRefsPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupRefsPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupSelector
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
    public V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetRefsPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetRefsPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetSelector
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
    public V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetSelectorPolicy? Policy { get; set; }
}

/// <summary>Network configuration for the service. This parameter is required for task definitions that use the awsvpc network mode to receive their own Elastic Network Interface, and it is not supported for other network modes. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderNetworkConfiguration
{
    /// <summary>Assign a public IP address to the ENI (Fargate launch type only). Valid values are true or false. Default false.</summary>
    [JsonPropertyName("assignPublicIp")]
    public bool? AssignPublicIp { get; set; }

    /// <summary>References to SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupRefs")]
    public IList<V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupRefs>? SecurityGroupRefs { get; set; }

    /// <summary>Selector for a list of SecurityGroup in ec2 to populate securityGroups.</summary>
    [JsonPropertyName("securityGroupSelector")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationSecurityGroupSelector? SecurityGroupSelector { get; set; }

    /// <summary>Security groups associated with the task or service. If you do not specify a security group, the default security group for the VPC is used.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>References to Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetRefs")]
    public IList<V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetRefs>? SubnetRefs { get; set; }

    /// <summary>Selector for a list of Subnet in ec2 to populate subnets.</summary>
    [JsonPropertyName("subnetSelector")]
    public V1beta2ServiceSpecInitProviderNetworkConfigurationSubnetSelector? SubnetSelector { get; set; }

    /// <summary>Subnets associated with the task or service.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderOrderedPlacementStrategy
{
    /// <summary>For the spread placement strategy, valid values are instanceId (or host, which has the same effect), or any platform or custom attribute that is applied to a container instance. For the binpack type, valid values are memory and cpu. For the random type, this attribute is not needed. For more information, see Placement Strategy.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>Type of placement strategy. Must be one of: binpack, random, or spread</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderPlacementConstraints
{
    /// <summary>Cluster Query Language expression to apply to the constraint. Does not need to be specified for the distinctInstance type. For more information, see Cluster Query Language in the Amazon EC2 Container Service Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Type of constraint. The only valid values at this time are memberOf and distinctInstance.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for Service Connect access logs. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderServiceConnectConfigurationAccessLogConfiguration
{
    /// <summary>The format for Service Connect access log output. Valid values: TEXT, JSON. See AWS documentation for format details.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Specifies whether to include query parameters in Service Connect access logs. Valid values: ENABLED, DISABLED. Default: DISABLED. Query parameters may contain sensitive information.</summary>
    [JsonPropertyName("includeQueryParameters")]
    public string? IncludeQueryParameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderServiceConnectConfigurationLogConfigurationSecretOption
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Secret to expose to the container. The supported values are either the full ARN of the AWS Secrets Manager secret or the full ARN of the parameter in the SSM Parameter Store.</summary>
    [JsonPropertyName("valueFrom")]
    public string? ValueFrom { get; set; }
}

/// <summary>Log configuration for the container. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderServiceConnectConfigurationLogConfiguration
{
    /// <summary>Log driver to use for the container.</summary>
    [JsonPropertyName("logDriver")]
    public string? LogDriver { get; set; }

    /// <summary>Configuration options to send to the log driver.</summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    /// <summary>Secrets to pass to the log configuration. See below.</summary>
    [JsonPropertyName("secretOption")]
    public IList<V1beta2ServiceSpecInitProviderServiceConnectConfigurationLogConfigurationSecretOption>? SecretOption { get; set; }
}

/// <summary>Configuration block for header value matching criteria. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue
{
    /// <summary>Exact string value to match in the header.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary>Configuration block for header-based routing rules. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader
{
    /// <summary>Name of the HTTP header to match.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block for header value matching criteria. See below.</summary>
    [JsonPropertyName("value")]
    public V1beta2ServiceSpecInitProviderServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderServiceConnectConfigurationServiceClientAliasTestTrafficRules
{
    /// <summary>Configuration block for header-based routing rules. See below.</summary>
    [JsonPropertyName("header")]
    public V1beta2ServiceSpecInitProviderServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader? Header { get; set; }
}

/// <summary>List of client aliases for this Service Connect service. You use these to assign names that can be used by client applications. For each service block where enabled is true, exactly one client_alias with one port should be specified. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderServiceConnectConfigurationServiceClientAlias
{
    /// <summary>Name that you use in the applications of client tasks to connect to this service.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>Listening port number for the Service Connect proxy. This port is available inside of all of the tasks within the same namespace.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Configuration block for test traffic routing rules. See below.</summary>
    [JsonPropertyName("testTrafficRules")]
    public IList<V1beta2ServiceSpecInitProviderServiceConnectConfigurationServiceClientAliasTestTrafficRules>? TestTrafficRules { get; set; }
}

/// <summary>Configuration timeouts for Service Connect</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderServiceConnectConfigurationServiceTimeout
{
    /// <summary>Amount of time in seconds a connection will stay active while idle. A value of 0 can be set to disable idleTimeout.</summary>
    [JsonPropertyName("idleTimeoutSeconds")]
    public double? IdleTimeoutSeconds { get; set; }

    /// <summary>Amount of time in seconds for the upstream to respond with a complete response per request. A value of 0 can be set to disable perRequestTimeout. Can only be set when appProtocol isn&apos;t TCP.</summary>
    [JsonPropertyName("perRequestTimeoutSeconds")]
    public double? PerRequestTimeoutSeconds { get; set; }
}

/// <summary>Details of the certificate authority which will issue the certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderServiceConnectConfigurationServiceTlsIssuerCertAuthority
{
    /// <summary>ARN of the aws_acmpca_certificate_authority used to create the TLS Certificates.</summary>
    [JsonPropertyName("awsPcaAuthorityArn")]
    public string? AwsPcaAuthorityArn { get; set; }
}

/// <summary>Configuration for enabling Transport Layer Security (TLS)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderServiceConnectConfigurationServiceTls
{
    /// <summary>Details of the certificate authority which will issue the certificate.</summary>
    [JsonPropertyName("issuerCertAuthority")]
    public V1beta2ServiceSpecInitProviderServiceConnectConfigurationServiceTlsIssuerCertAuthority? IssuerCertAuthority { get; set; }

    /// <summary>KMS key used to encrypt the private key in Secrets Manager.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>ARN of the IAM Role that&apos;s associated with the Service Connect TLS.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderServiceConnectConfigurationService
{
    /// <summary>List of client aliases for this Service Connect service. You use these to assign names that can be used by client applications. For each service block where enabled is true, exactly one client_alias with one port should be specified. See below.</summary>
    [JsonPropertyName("clientAlias")]
    public V1beta2ServiceSpecInitProviderServiceConnectConfigurationServiceClientAlias? ClientAlias { get; set; }

    /// <summary>Name of the new AWS Cloud Map service that Amazon ECS creates for this Amazon ECS service.</summary>
    [JsonPropertyName("discoveryName")]
    public string? DiscoveryName { get; set; }

    /// <summary>Port number for the Service Connect proxy to listen on.</summary>
    [JsonPropertyName("ingressPortOverride")]
    public double? IngressPortOverride { get; set; }

    /// <summary>Name of one of the portMappings from all the containers in the task definition of this Amazon ECS service.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Configuration timeouts for Service Connect</summary>
    [JsonPropertyName("timeout")]
    public V1beta2ServiceSpecInitProviderServiceConnectConfigurationServiceTimeout? Timeout { get; set; }

    /// <summary>Configuration for enabling Transport Layer Security (TLS)</summary>
    [JsonPropertyName("tls")]
    public V1beta2ServiceSpecInitProviderServiceConnectConfigurationServiceTls? Tls { get; set; }
}

/// <summary>ECS Service Connect configuration for this service to discover and connect to services, and be discovered by, and connected from, other services within a namespace. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderServiceConnectConfiguration
{
    /// <summary>Configuration for Service Connect access logs. See below.</summary>
    [JsonPropertyName("accessLogConfiguration")]
    public V1beta2ServiceSpecInitProviderServiceConnectConfigurationAccessLogConfiguration? AccessLogConfiguration { get; set; }

    /// <summary>Whether to use Service Connect with this service.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Log configuration for the container. See below.</summary>
    [JsonPropertyName("logConfiguration")]
    public V1beta2ServiceSpecInitProviderServiceConnectConfigurationLogConfiguration? LogConfiguration { get; set; }

    /// <summary>Namespace name or ARN of the aws_service_discovery_http_namespace for use with Service Connect.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>List of Service Connect service objects. See below.</summary>
    [JsonPropertyName("service")]
    public IList<V1beta2ServiceSpecInitProviderServiceConnectConfigurationService>? Service { get; set; }
}

/// <summary>Service discovery registries for the service. The maximum number of service_registries blocks is 1. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderServiceRegistries
{
    /// <summary>Container name value, already specified in the task definition, to be used for your service discovery service.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Port value, already specified in the task definition, to be used for your service discovery service.</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Port value used if your Service Discovery service specified an SRV record.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>ARN of the Service Registry. The currently supported service registry is Amazon Route 53 Auto Naming Service(aws_service_discovery_service). For more information, see Service</summary>
    [JsonPropertyName("registryArn")]
    public string? RegistryArn { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderTaskDefinitionRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderTaskDefinitionRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderTaskDefinitionRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderTaskDefinitionRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTaskDefinitionRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderTaskDefinitionRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderTaskDefinitionRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a TaskDefinition in ecs to populate taskDefinition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTaskDefinitionRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecInitProviderTaskDefinitionRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderTaskDefinitionSelectorPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecInitProviderTaskDefinitionSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecInitProviderTaskDefinitionSelectorPolicyResolveEnum>))]
public enum V1beta2ServiceSpecInitProviderTaskDefinitionSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTaskDefinitionSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecInitProviderTaskDefinitionSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecInitProviderTaskDefinitionSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a TaskDefinition in ecs to populate taskDefinition.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderTaskDefinitionSelector
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
    public V1beta2ServiceSpecInitProviderTaskDefinitionSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderVolumeConfigurationManagedEbsVolumeTagSpecifications
{
    /// <summary>Whether to propagate the tags from the task definition or the service to the tasks. The valid values are SERVICE and TASK_DEFINITION.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>The type of volume resource. Valid values, volume.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Configuration for the Amazon EBS volume that Amazon ECS creates and manages on your behalf. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderVolumeConfigurationManagedEbsVolume
{
    /// <summary>Whether the volume should be encrypted. Default value is true.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Linux filesystem type for the volume. For volumes created from a snapshot, same filesystem type must be specified that the volume was using when the snapshot was created. Valid values are ext3, ext4, xfs. Default value is xfs.</summary>
    [JsonPropertyName("fileSystemType")]
    public string? FileSystemType { get; set; }

    /// <summary>Number of I/O operations per second (IOPS).</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) identifier of the Amazon Web Services Key Management Service key to use for Amazon EBS encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The ARN of the IAM role to associate with this volume. This is the Amazon ECS infrastructure IAM role that is used to manage your AWS infrastructure.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Size of the volume in GiB. You must specify either a size_in_gb or a snapshot_id. You can optionally specify a volume size greater than or equal to the snapshot size.</summary>
    [JsonPropertyName("sizeInGb")]
    public double? SizeInGb { get; set; }

    /// <summary>Snapshot that Amazon ECS uses to create the volume. You must specify either a size_in_gb or a snapshot_id.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The tags to apply to the volume. See below.</summary>
    [JsonPropertyName("tagSpecifications")]
    public IList<V1beta2ServiceSpecInitProviderVolumeConfigurationManagedEbsVolumeTagSpecifications>? TagSpecifications { get; set; }

    /// <summary>Throughput to provision for a volume, in MiB/s, with a maximum of 1,000 MiB/s.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Volume Initialization Rate in MiB/s. You must also specify a snapshot_id.</summary>
    [JsonPropertyName("volumeInitializationRate")]
    public double? VolumeInitializationRate { get; set; }

    /// <summary>Volume type.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>Configuration for a volume specified in the task definition as a volume that is configured at launch time. Currently, the only supported volume type is an Amazon EBS volume. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderVolumeConfiguration
{
    /// <summary>Configuration for the Amazon EBS volume that Amazon ECS creates and manages on your behalf. See below.</summary>
    [JsonPropertyName("managedEbsVolume")]
    public V1beta2ServiceSpecInitProviderVolumeConfigurationManagedEbsVolume? ManagedEbsVolume { get; set; }

    /// <summary>Name of the volume.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecInitProviderVpcLatticeConfigurations
{
    /// <summary>The name of the port for a target group associated with the VPC Lattice configuration.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>The ARN of the IAM role to associate with this volume. This is the Amazon ECS infrastructure IAM role that is used to manage your AWS infrastructure.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The full ARN of the target group or groups associated with the VPC Lattice configuration.</summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }
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
public partial class V1beta2ServiceSpecInitProvider
{
    /// <summary>Information about the CloudWatch alarms. See below.</summary>
    [JsonPropertyName("alarms")]
    public V1beta2ServiceSpecInitProviderAlarms? Alarms { get; set; }

    /// <summary>ECS automatically redistributes tasks within a service across Availability Zones (AZs) to mitigate the risk of impaired application availability due to underlying infrastructure failures and task lifecycle activities. The valid values are ENABLED and DISABLED. When creating a new service, if no value is specified, it defaults to ENABLED if the service is compatible with AvailabilityZoneRebalancing. When updating an existing service, if no value is specified it defaults to the existing service&apos;s AvailabilityZoneRebalancing value. If the service never had an AvailabilityZoneRebalancing value set, Amazon ECS treats this as DISABLED.</summary>
    [JsonPropertyName("availabilityZoneRebalancing")]
    public string? AvailabilityZoneRebalancing { get; set; }

    /// <summary>Capacity provider strategies to use for the service. Can be one or more. Updating this argument requires force_new_deployment = true. See below. Conflicts with launch_type.</summary>
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1beta2ServiceSpecInitProviderCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    /// <summary>Configuration block for deployment circuit breaker. See below.</summary>
    [JsonPropertyName("deploymentCircuitBreaker")]
    public V1beta2ServiceSpecInitProviderDeploymentCircuitBreaker? DeploymentCircuitBreaker { get; set; }

    /// <summary>Configuration block for deployment settings. See below.</summary>
    [JsonPropertyName("deploymentConfiguration")]
    public V1beta2ServiceSpecInitProviderDeploymentConfiguration? DeploymentConfiguration { get; set; }

    /// <summary>Configuration block for deployment controller configuration. See below.</summary>
    [JsonPropertyName("deploymentController")]
    public V1beta2ServiceSpecInitProviderDeploymentController? DeploymentController { get; set; }

    /// <summary>Upper limit (as a percentage of the service&apos;s desiredCount) of the number of running tasks that can be running in a service during a deployment. Not valid when using the DAEMON scheduling strategy.</summary>
    [JsonPropertyName("deploymentMaximumPercent")]
    public double? DeploymentMaximumPercent { get; set; }

    /// <summary>Lower limit (as a percentage of the service&apos;s desiredCount) of the number of running tasks that must remain running and healthy in a service during a deployment.</summary>
    [JsonPropertyName("deploymentMinimumHealthyPercent")]
    public double? DeploymentMinimumHealthyPercent { get; set; }

    /// <summary>Number of instances of the task definition to place and keep running. Defaults to 0. Do not specify if using the DAEMON scheduling strategy.</summary>
    [JsonPropertyName("desiredCount")]
    public double? DesiredCount { get; set; }

    /// <summary>Whether to enable Amazon ECS managed tags for the tasks within the service.</summary>
    [JsonPropertyName("enableEcsManagedTags")]
    public bool? EnableEcsManagedTags { get; set; }

    /// <summary>Whether to enable Amazon ECS Exec for the tasks within the service.</summary>
    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    /// <summary>Enable to delete a service even if it wasn&apos;t scaled down to zero tasks. It&apos;s only necessary to use this if the service uses the REPLICA scheduling strategy.</summary>
    [JsonPropertyName("forceDelete")]
    public bool? ForceDelete { get; set; }

    /// <summary>Enable to force a new task deployment of the service. This can be used to update tasks to use a newer Docker image with same image/tag combination (e.g., myimage:latest), roll Fargate tasks onto a newer platform version, or immediately deploy ordered_placement_strategy and placement_constraints updates.</summary>
    [JsonPropertyName("forceNewDeployment")]
    public bool? ForceNewDeployment { get; set; }

    /// <summary>Seconds to ignore failing load balancer health checks on newly instantiated tasks to prevent premature shutdown, up to 2147483647. Only valid for services configured to use load balancers.</summary>
    [JsonPropertyName("healthCheckGracePeriodSeconds")]
    public double? HealthCheckGracePeriodSeconds { get; set; }

    /// <summary>ARN of the IAM role that allows Amazon ECS to make calls to your load balancer on your behalf. This parameter is required if you are using a load balancer with your service, but only if your task definition does not use the awsvpc network mode. If using awsvpc network mode, do not specify this role. If your account has already created the Amazon ECS service-linked role, that role is used by default for your service unless you specify a role here.</summary>
    [JsonPropertyName("iamRole")]
    public string? IamRole { get; set; }

    /// <summary>Reference to a Role in iam to populate iamRole.</summary>
    [JsonPropertyName("iamRoleRef")]
    public V1beta2ServiceSpecInitProviderIamRoleRef? IamRoleRef { get; set; }

    /// <summary>Selector for a Role in iam to populate iamRole.</summary>
    [JsonPropertyName("iamRoleSelector")]
    public V1beta2ServiceSpecInitProviderIamRoleSelector? IamRoleSelector { get; set; }

    /// <summary>Launch type on which to run your service. The valid values are EC2, FARGATE, and EXTERNAL. Defaults to EC2. Conflicts with capacity_provider_strategy.</summary>
    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>Configuration block for load balancers. See below.</summary>
    [JsonPropertyName("loadBalancer")]
    public IList<V1beta2ServiceSpecInitProviderLoadBalancer>? LoadBalancer { get; set; }

    /// <summary>Network configuration for the service. This parameter is required for task definitions that use the awsvpc network mode to receive their own Elastic Network Interface, and it is not supported for other network modes. See below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta2ServiceSpecInitProviderNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>Service level strategy rules that are taken into consideration during task placement. List from top to bottom in order of precedence. Updates to this configuration will take effect next task deployment unless force_new_deployment is enabled. The maximum number of ordered_placement_strategy blocks is 5. See below.</summary>
    [JsonPropertyName("orderedPlacementStrategy")]
    public IList<V1beta2ServiceSpecInitProviderOrderedPlacementStrategy>? OrderedPlacementStrategy { get; set; }

    /// <summary>Rules that are taken into consideration during task placement. Updates to this configuration will take effect next task deployment unless force_new_deployment is enabled. Maximum number of placement_constraints is 10. See below.</summary>
    [JsonPropertyName("placementConstraints")]
    public IList<V1beta2ServiceSpecInitProviderPlacementConstraints>? PlacementConstraints { get; set; }

    /// <summary>Platform version on which to run your service. Only applicable for launch_type set to FARGATE. Defaults to LATEST. More information about Fargate platform versions can be found in the AWS ECS User Guide.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>Whether to propagate the tags from the task definition or the service to the tasks. The valid values are SERVICE and TASK_DEFINITION.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>Scheduling strategy to use for the service. The valid values are REPLICA and DAEMON. Defaults to REPLICA. Note that Tasks using the Fargate launch type or the .</summary>
    [JsonPropertyName("schedulingStrategy")]
    public string? SchedulingStrategy { get; set; }

    /// <summary>ECS Service Connect configuration for this service to discover and connect to services, and be discovered by, and connected from, other services within a namespace. See below.</summary>
    [JsonPropertyName("serviceConnectConfiguration")]
    public V1beta2ServiceSpecInitProviderServiceConnectConfiguration? ServiceConnectConfiguration { get; set; }

    /// <summary>Service discovery registries for the service. The maximum number of service_registries blocks is 1. See below.</summary>
    [JsonPropertyName("serviceRegistries")]
    public V1beta2ServiceSpecInitProviderServiceRegistries? ServiceRegistries { get; set; }

    /// <summary>Whether to enable graceful termination of deployments using SIGINT signals. When enabled, allows customers to safely cancel an in-progress deployment and automatically trigger a rollback to the previous stable state. Defaults to false. Only applicable when using ECS deployment controller and requires wait_for_steady_state = true.</summary>
    [JsonPropertyName("sigintRollback")]
    public bool? SigintRollback { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Family and revision (family:revision) or full ARN of the task definition that you want to run in your service. Required unless using the EXTERNAL deployment controller. If a revision is not specified, the latest ACTIVE revision is used.</summary>
    [JsonPropertyName("taskDefinition")]
    public string? TaskDefinition { get; set; }

    /// <summary>Reference to a TaskDefinition in ecs to populate taskDefinition.</summary>
    [JsonPropertyName("taskDefinitionRef")]
    public V1beta2ServiceSpecInitProviderTaskDefinitionRef? TaskDefinitionRef { get; set; }

    /// <summary>Selector for a TaskDefinition in ecs to populate taskDefinition.</summary>
    [JsonPropertyName("taskDefinitionSelector")]
    public V1beta2ServiceSpecInitProviderTaskDefinitionSelector? TaskDefinitionSelector { get; set; }

    /// <summary>Map of arbitrary keys and values that, when changed, will trigger an in-place update (redeployment). Useful with plantimestamp(). See example above.</summary>
    [JsonPropertyName("triggers")]
    public IDictionary<string, string>? Triggers { get; set; }

    /// <summary>Configuration for a volume specified in the task definition as a volume that is configured at launch time. Currently, the only supported volume type is an Amazon EBS volume. See below.</summary>
    [JsonPropertyName("volumeConfiguration")]
    public V1beta2ServiceSpecInitProviderVolumeConfiguration? VolumeConfiguration { get; set; }

    /// <summary>The VPC Lattice configuration for your service that allows Lattice to connect, secure, and monitor your service across multiple accounts and VPCs. See below.</summary>
    [JsonPropertyName("vpcLatticeConfigurations")]
    public IList<V1beta2ServiceSpecInitProviderVpcLatticeConfigurations>? VpcLatticeConfigurations { get; set; }

    /// <summary>Default false.</summary>
    [JsonPropertyName("waitForSteadyState")]
    public bool? WaitForSteadyState { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecManagementPoliciesEnum>))]
public enum V1beta2ServiceSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2ServiceSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2ServiceSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2ServiceSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2ServiceSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2ServiceSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2ServiceSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>ServiceSpec defines the desired state of Service</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceSpec
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
    public V1beta2ServiceSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2ServiceSpecForProvider ForProvider { get; set; }

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
    public V1beta2ServiceSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2ServiceSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2ServiceSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2ServiceSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Information about the CloudWatch alarms. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderAlarms
{
    /// <summary>One or more CloudWatch alarm names.</summary>
    [JsonPropertyName("alarmNames")]
    public IList<string>? AlarmNames { get; set; }

    /// <summary>Whether to use the CloudWatch alarm option in the service deployment process.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Whether to configure Amazon ECS to roll back the service if a service deployment fails. If rollback is used, when a service deployment fails, the service is rolled back to the last deployment that completed successfully.</summary>
    [JsonPropertyName("rollback")]
    public bool? Rollback { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderCapacityProviderStrategy
{
    /// <summary>Number of tasks, at a minimum, to run on the specified capacity provider. Only one capacity provider in a capacity provider strategy can have a base defined.</summary>
    [JsonPropertyName("base")]
    public double? Base { get; set; }

    /// <summary>Short name of the capacity provider.</summary>
    [JsonPropertyName("capacityProvider")]
    public string? CapacityProvider { get; set; }

    /// <summary>Relative percentage of the total number of launched tasks that should use the specified capacity provider.</summary>
    [JsonPropertyName("weight")]
    public double? Weight { get; set; }
}

/// <summary>Configuration block for deployment circuit breaker. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderDeploymentCircuitBreaker
{
    /// <summary>Whether to enable the deployment circuit breaker logic for the service.</summary>
    [JsonPropertyName("enable")]
    public bool? Enable { get; set; }

    /// <summary>Whether to enable Amazon ECS to roll back the service if a service deployment fails. If rollback is enabled, when a service deployment fails, the service is rolled back to the last deployment that completed successfully.</summary>
    [JsonPropertyName("rollback")]
    public bool? Rollback { get; set; }
}

/// <summary>Configuration block for canary deployment strategy. Required when strategy is set to CANARY. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderDeploymentConfigurationCanaryConfiguration
{
    /// <summary>Number of minutes to wait before shifting all traffic to the new deployment. Valid range: 0-1440 minutes.</summary>
    [JsonPropertyName("canaryBakeTimeInMinutes")]
    public string? CanaryBakeTimeInMinutes { get; set; }

    /// <summary>Percentage of traffic to route to the canary deployment. Valid range: 0.1-100.0.</summary>
    [JsonPropertyName("canaryPercent")]
    public double? CanaryPercent { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderDeploymentConfigurationLifecycleHook
{
    /// <summary>Custom parameters that Amazon ECS will pass to the hook target invocations (such as a Lambda function).</summary>
    [JsonPropertyName("hookDetails")]
    public string? HookDetails { get; set; }

    /// <summary>ARN of the Lambda function to invoke for the lifecycle hook.</summary>
    [JsonPropertyName("hookTargetArn")]
    public string? HookTargetArn { get; set; }

    /// <summary>Stages during the deployment when the hook should be invoked. Valid values: RECONCILE_SERVICE, PRE_SCALE_UP, POST_SCALE_UP, TEST_TRAFFIC_SHIFT, POST_TEST_TRAFFIC_SHIFT, PRODUCTION_TRAFFIC_SHIFT, POST_PRODUCTION_TRAFFIC_SHIFT.</summary>
    [JsonPropertyName("lifecycleStages")]
    public IList<string>? LifecycleStages { get; set; }

    /// <summary>ARN of the IAM role that grants the service permission to invoke the Lambda function.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

/// <summary>Configuration block for linear deployment strategy. Required when strategy is set to LINEAR. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderDeploymentConfigurationLinearConfiguration
{
    /// <summary>Number of minutes to wait between each step during a linear deployment. Valid range: 0-1440 minutes.</summary>
    [JsonPropertyName("stepBakeTimeInMinutes")]
    public string? StepBakeTimeInMinutes { get; set; }

    /// <summary>Percentage of traffic to shift in each step during a linear deployment. Valid range: 3.0-100.0.</summary>
    [JsonPropertyName("stepPercent")]
    public double? StepPercent { get; set; }
}

/// <summary>Configuration block for deployment settings. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderDeploymentConfiguration
{
    /// <summary>Number of minutes to wait after a new deployment is fully provisioned before terminating the old deployment. Valid range: 0-1440 minutes. Used with BLUE_GREEN, LINEAR, and CANARY strategies.</summary>
    [JsonPropertyName("bakeTimeInMinutes")]
    public string? BakeTimeInMinutes { get; set; }

    /// <summary>Configuration block for canary deployment strategy. Required when strategy is set to CANARY. See below.</summary>
    [JsonPropertyName("canaryConfiguration")]
    public V1beta2ServiceStatusAtProviderDeploymentConfigurationCanaryConfiguration? CanaryConfiguration { get; set; }

    /// <summary>Configuration block for lifecycle hooks that are invoked during deployments. See below.</summary>
    [JsonPropertyName("lifecycleHook")]
    public IList<V1beta2ServiceStatusAtProviderDeploymentConfigurationLifecycleHook>? LifecycleHook { get; set; }

    /// <summary>Configuration block for linear deployment strategy. Required when strategy is set to LINEAR. See below.</summary>
    [JsonPropertyName("linearConfiguration")]
    public V1beta2ServiceStatusAtProviderDeploymentConfigurationLinearConfiguration? LinearConfiguration { get; set; }

    /// <summary>Type of deployment strategy. Valid values: ROLLING, BLUE_GREEN, LINEAR, CANARY. Default: ROLLING.</summary>
    [JsonPropertyName("strategy")]
    public string? Strategy { get; set; }
}

/// <summary>Configuration block for deployment controller configuration. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderDeploymentController
{
    /// <summary>Type of deployment controller. Valid values: CODE_DEPLOY, ECS, EXTERNAL. Default: ECS.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration block for Blue/Green deployment settings. Required when using BLUE_GREEN deployment strategy. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderLoadBalancerAdvancedConfiguration
{
    /// <summary>ARN of the alternate target group to use for Blue/Green deployments.</summary>
    [JsonPropertyName("alternateTargetGroupArn")]
    public string? AlternateTargetGroupArn { get; set; }

    /// <summary>ARN of the listener rule that routes production traffic.</summary>
    [JsonPropertyName("productionListenerRule")]
    public string? ProductionListenerRule { get; set; }

    /// <summary>ARN of the IAM role that allows ECS to manage the target groups.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>ARN of the listener rule that routes test traffic.</summary>
    [JsonPropertyName("testListenerRule")]
    public string? TestListenerRule { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderLoadBalancer
{
    /// <summary>Configuration block for Blue/Green deployment settings. Required when using BLUE_GREEN deployment strategy. See below.</summary>
    [JsonPropertyName("advancedConfiguration")]
    public V1beta2ServiceStatusAtProviderLoadBalancerAdvancedConfiguration? AdvancedConfiguration { get; set; }

    /// <summary>Name of the container to associate with the load balancer (as it appears in a container definition).</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Port on the container to associate with the load balancer.</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Name of the ELB (Classic) to associate with the service.</summary>
    [JsonPropertyName("elbName")]
    public string? ElbName { get; set; }

    /// <summary>ARN of the Load Balancer target group to associate with the service.</summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }
}

/// <summary>Network configuration for the service. This parameter is required for task definitions that use the awsvpc network mode to receive their own Elastic Network Interface, and it is not supported for other network modes. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderNetworkConfiguration
{
    /// <summary>Assign a public IP address to the ENI (Fargate launch type only). Valid values are true or false. Default false.</summary>
    [JsonPropertyName("assignPublicIp")]
    public bool? AssignPublicIp { get; set; }

    /// <summary>Security groups associated with the task or service. If you do not specify a security group, the default security group for the VPC is used.</summary>
    [JsonPropertyName("securityGroups")]
    public IList<string>? SecurityGroups { get; set; }

    /// <summary>Subnets associated with the task or service.</summary>
    [JsonPropertyName("subnets")]
    public IList<string>? Subnets { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderOrderedPlacementStrategy
{
    /// <summary>For the spread placement strategy, valid values are instanceId (or host, which has the same effect), or any platform or custom attribute that is applied to a container instance. For the binpack type, valid values are memory and cpu. For the random type, this attribute is not needed. For more information, see Placement Strategy.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>Type of placement strategy. Must be one of: binpack, random, or spread</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderPlacementConstraints
{
    /// <summary>Cluster Query Language expression to apply to the constraint. Does not need to be specified for the distinctInstance type. For more information, see Cluster Query Language in the Amazon EC2 Container Service Developer Guide.</summary>
    [JsonPropertyName("expression")]
    public string? Expression { get; set; }

    /// <summary>Type of constraint. The only valid values at this time are memberOf and distinctInstance.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>Configuration for Service Connect access logs. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderServiceConnectConfigurationAccessLogConfiguration
{
    /// <summary>The format for Service Connect access log output. Valid values: TEXT, JSON. See AWS documentation for format details.</summary>
    [JsonPropertyName("format")]
    public string? Format { get; set; }

    /// <summary>Specifies whether to include query parameters in Service Connect access logs. Valid values: ENABLED, DISABLED. Default: DISABLED. Query parameters may contain sensitive information.</summary>
    [JsonPropertyName("includeQueryParameters")]
    public string? IncludeQueryParameters { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderServiceConnectConfigurationLogConfigurationSecretOption
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Secret to expose to the container. The supported values are either the full ARN of the AWS Secrets Manager secret or the full ARN of the parameter in the SSM Parameter Store.</summary>
    [JsonPropertyName("valueFrom")]
    public string? ValueFrom { get; set; }
}

/// <summary>Log configuration for the container. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderServiceConnectConfigurationLogConfiguration
{
    /// <summary>Log driver to use for the container.</summary>
    [JsonPropertyName("logDriver")]
    public string? LogDriver { get; set; }

    /// <summary>Configuration options to send to the log driver.</summary>
    [JsonPropertyName("options")]
    public IDictionary<string, string>? Options { get; set; }

    /// <summary>Secrets to pass to the log configuration. See below.</summary>
    [JsonPropertyName("secretOption")]
    public IList<V1beta2ServiceStatusAtProviderServiceConnectConfigurationLogConfigurationSecretOption>? SecretOption { get; set; }
}

/// <summary>Configuration block for header value matching criteria. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue
{
    /// <summary>Exact string value to match in the header.</summary>
    [JsonPropertyName("exact")]
    public string? Exact { get; set; }
}

/// <summary>Configuration block for header-based routing rules. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader
{
    /// <summary>Name of the HTTP header to match.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Configuration block for header value matching criteria. See below.</summary>
    [JsonPropertyName("value")]
    public V1beta2ServiceStatusAtProviderServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeaderValue? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderServiceConnectConfigurationServiceClientAliasTestTrafficRules
{
    /// <summary>Configuration block for header-based routing rules. See below.</summary>
    [JsonPropertyName("header")]
    public V1beta2ServiceStatusAtProviderServiceConnectConfigurationServiceClientAliasTestTrafficRulesHeader? Header { get; set; }
}

/// <summary>List of client aliases for this Service Connect service. You use these to assign names that can be used by client applications. For each service block where enabled is true, exactly one client_alias with one port should be specified. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderServiceConnectConfigurationServiceClientAlias
{
    /// <summary>Name that you use in the applications of client tasks to connect to this service.</summary>
    [JsonPropertyName("dnsName")]
    public string? DnsName { get; set; }

    /// <summary>Listening port number for the Service Connect proxy. This port is available inside of all of the tasks within the same namespace.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>Configuration block for test traffic routing rules. See below.</summary>
    [JsonPropertyName("testTrafficRules")]
    public IList<V1beta2ServiceStatusAtProviderServiceConnectConfigurationServiceClientAliasTestTrafficRules>? TestTrafficRules { get; set; }
}

/// <summary>Configuration timeouts for Service Connect</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderServiceConnectConfigurationServiceTimeout
{
    /// <summary>Amount of time in seconds a connection will stay active while idle. A value of 0 can be set to disable idleTimeout.</summary>
    [JsonPropertyName("idleTimeoutSeconds")]
    public double? IdleTimeoutSeconds { get; set; }

    /// <summary>Amount of time in seconds for the upstream to respond with a complete response per request. A value of 0 can be set to disable perRequestTimeout. Can only be set when appProtocol isn&apos;t TCP.</summary>
    [JsonPropertyName("perRequestTimeoutSeconds")]
    public double? PerRequestTimeoutSeconds { get; set; }
}

/// <summary>Details of the certificate authority which will issue the certificate.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderServiceConnectConfigurationServiceTlsIssuerCertAuthority
{
    /// <summary>ARN of the aws_acmpca_certificate_authority used to create the TLS Certificates.</summary>
    [JsonPropertyName("awsPcaAuthorityArn")]
    public string? AwsPcaAuthorityArn { get; set; }
}

/// <summary>Configuration for enabling Transport Layer Security (TLS)</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderServiceConnectConfigurationServiceTls
{
    /// <summary>Details of the certificate authority which will issue the certificate.</summary>
    [JsonPropertyName("issuerCertAuthority")]
    public V1beta2ServiceStatusAtProviderServiceConnectConfigurationServiceTlsIssuerCertAuthority? IssuerCertAuthority { get; set; }

    /// <summary>KMS key used to encrypt the private key in Secrets Manager.</summary>
    [JsonPropertyName("kmsKey")]
    public string? KmsKey { get; set; }

    /// <summary>ARN of the IAM Role that&apos;s associated with the Service Connect TLS.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderServiceConnectConfigurationService
{
    /// <summary>List of client aliases for this Service Connect service. You use these to assign names that can be used by client applications. For each service block where enabled is true, exactly one client_alias with one port should be specified. See below.</summary>
    [JsonPropertyName("clientAlias")]
    public V1beta2ServiceStatusAtProviderServiceConnectConfigurationServiceClientAlias? ClientAlias { get; set; }

    /// <summary>Name of the new AWS Cloud Map service that Amazon ECS creates for this Amazon ECS service.</summary>
    [JsonPropertyName("discoveryName")]
    public string? DiscoveryName { get; set; }

    /// <summary>Port number for the Service Connect proxy to listen on.</summary>
    [JsonPropertyName("ingressPortOverride")]
    public double? IngressPortOverride { get; set; }

    /// <summary>Name of one of the portMappings from all the containers in the task definition of this Amazon ECS service.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>Configuration timeouts for Service Connect</summary>
    [JsonPropertyName("timeout")]
    public V1beta2ServiceStatusAtProviderServiceConnectConfigurationServiceTimeout? Timeout { get; set; }

    /// <summary>Configuration for enabling Transport Layer Security (TLS)</summary>
    [JsonPropertyName("tls")]
    public V1beta2ServiceStatusAtProviderServiceConnectConfigurationServiceTls? Tls { get; set; }
}

/// <summary>ECS Service Connect configuration for this service to discover and connect to services, and be discovered by, and connected from, other services within a namespace. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderServiceConnectConfiguration
{
    /// <summary>Configuration for Service Connect access logs. See below.</summary>
    [JsonPropertyName("accessLogConfiguration")]
    public V1beta2ServiceStatusAtProviderServiceConnectConfigurationAccessLogConfiguration? AccessLogConfiguration { get; set; }

    /// <summary>Whether to use Service Connect with this service.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Log configuration for the container. See below.</summary>
    [JsonPropertyName("logConfiguration")]
    public V1beta2ServiceStatusAtProviderServiceConnectConfigurationLogConfiguration? LogConfiguration { get; set; }

    /// <summary>Namespace name or ARN of the aws_service_discovery_http_namespace for use with Service Connect.</summary>
    [JsonPropertyName("namespace")]
    public string? Namespace { get; set; }

    /// <summary>List of Service Connect service objects. See below.</summary>
    [JsonPropertyName("service")]
    public IList<V1beta2ServiceStatusAtProviderServiceConnectConfigurationService>? Service { get; set; }
}

/// <summary>Service discovery registries for the service. The maximum number of service_registries blocks is 1. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderServiceRegistries
{
    /// <summary>Container name value, already specified in the task definition, to be used for your service discovery service.</summary>
    [JsonPropertyName("containerName")]
    public string? ContainerName { get; set; }

    /// <summary>Port value, already specified in the task definition, to be used for your service discovery service.</summary>
    [JsonPropertyName("containerPort")]
    public double? ContainerPort { get; set; }

    /// <summary>Port value used if your Service Discovery service specified an SRV record.</summary>
    [JsonPropertyName("port")]
    public double? Port { get; set; }

    /// <summary>ARN of the Service Registry. The currently supported service registry is Amazon Route 53 Auto Naming Service(aws_service_discovery_service). For more information, see Service</summary>
    [JsonPropertyName("registryArn")]
    public string? RegistryArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderVolumeConfigurationManagedEbsVolumeTagSpecifications
{
    /// <summary>Whether to propagate the tags from the task definition or the service to the tasks. The valid values are SERVICE and TASK_DEFINITION.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>The type of volume resource. Valid values, volume.</summary>
    [JsonPropertyName("resourceType")]
    public string? ResourceType { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }
}

/// <summary>Configuration for the Amazon EBS volume that Amazon ECS creates and manages on your behalf. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderVolumeConfigurationManagedEbsVolume
{
    /// <summary>Whether the volume should be encrypted. Default value is true.</summary>
    [JsonPropertyName("encrypted")]
    public bool? Encrypted { get; set; }

    /// <summary>Linux filesystem type for the volume. For volumes created from a snapshot, same filesystem type must be specified that the volume was using when the snapshot was created. Valid values are ext3, ext4, xfs. Default value is xfs.</summary>
    [JsonPropertyName("fileSystemType")]
    public string? FileSystemType { get; set; }

    /// <summary>Number of I/O operations per second (IOPS).</summary>
    [JsonPropertyName("iops")]
    public double? Iops { get; set; }

    /// <summary>Amazon Resource Name (ARN) identifier of the Amazon Web Services Key Management Service key to use for Amazon EBS encryption.</summary>
    [JsonPropertyName("kmsKeyId")]
    public string? KmsKeyId { get; set; }

    /// <summary>The ARN of the IAM role to associate with this volume. This is the Amazon ECS infrastructure IAM role that is used to manage your AWS infrastructure.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>Size of the volume in GiB. You must specify either a size_in_gb or a snapshot_id. You can optionally specify a volume size greater than or equal to the snapshot size.</summary>
    [JsonPropertyName("sizeInGb")]
    public double? SizeInGb { get; set; }

    /// <summary>Snapshot that Amazon ECS uses to create the volume. You must specify either a size_in_gb or a snapshot_id.</summary>
    [JsonPropertyName("snapshotId")]
    public string? SnapshotId { get; set; }

    /// <summary>The tags to apply to the volume. See below.</summary>
    [JsonPropertyName("tagSpecifications")]
    public IList<V1beta2ServiceStatusAtProviderVolumeConfigurationManagedEbsVolumeTagSpecifications>? TagSpecifications { get; set; }

    /// <summary>Throughput to provision for a volume, in MiB/s, with a maximum of 1,000 MiB/s.</summary>
    [JsonPropertyName("throughput")]
    public double? Throughput { get; set; }

    /// <summary>Volume Initialization Rate in MiB/s. You must also specify a snapshot_id.</summary>
    [JsonPropertyName("volumeInitializationRate")]
    public double? VolumeInitializationRate { get; set; }

    /// <summary>Volume type.</summary>
    [JsonPropertyName("volumeType")]
    public string? VolumeType { get; set; }
}

/// <summary>Configuration for a volume specified in the task definition as a volume that is configured at launch time. Currently, the only supported volume type is an Amazon EBS volume. See below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderVolumeConfiguration
{
    /// <summary>Configuration for the Amazon EBS volume that Amazon ECS creates and manages on your behalf. See below.</summary>
    [JsonPropertyName("managedEbsVolume")]
    public V1beta2ServiceStatusAtProviderVolumeConfigurationManagedEbsVolume? ManagedEbsVolume { get; set; }

    /// <summary>Name of the volume.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProviderVpcLatticeConfigurations
{
    /// <summary>The name of the port for a target group associated with the VPC Lattice configuration.</summary>
    [JsonPropertyName("portName")]
    public string? PortName { get; set; }

    /// <summary>The ARN of the IAM role to associate with this volume. This is the Amazon ECS infrastructure IAM role that is used to manage your AWS infrastructure.</summary>
    [JsonPropertyName("roleArn")]
    public string? RoleArn { get; set; }

    /// <summary>The full ARN of the target group or groups associated with the VPC Lattice configuration.</summary>
    [JsonPropertyName("targetGroupArn")]
    public string? TargetGroupArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusAtProvider
{
    /// <summary>Information about the CloudWatch alarms. See below.</summary>
    [JsonPropertyName("alarms")]
    public V1beta2ServiceStatusAtProviderAlarms? Alarms { get; set; }

    /// <summary>ARN that identifies the service.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>ECS automatically redistributes tasks within a service across Availability Zones (AZs) to mitigate the risk of impaired application availability due to underlying infrastructure failures and task lifecycle activities. The valid values are ENABLED and DISABLED. When creating a new service, if no value is specified, it defaults to ENABLED if the service is compatible with AvailabilityZoneRebalancing. When updating an existing service, if no value is specified it defaults to the existing service&apos;s AvailabilityZoneRebalancing value. If the service never had an AvailabilityZoneRebalancing value set, Amazon ECS treats this as DISABLED.</summary>
    [JsonPropertyName("availabilityZoneRebalancing")]
    public string? AvailabilityZoneRebalancing { get; set; }

    /// <summary>Capacity provider strategies to use for the service. Can be one or more. Updating this argument requires force_new_deployment = true. See below. Conflicts with launch_type.</summary>
    [JsonPropertyName("capacityProviderStrategy")]
    public IList<V1beta2ServiceStatusAtProviderCapacityProviderStrategy>? CapacityProviderStrategy { get; set; }

    /// <summary>Name of an ECS cluster.</summary>
    [JsonPropertyName("cluster")]
    public string? Cluster { get; set; }

    /// <summary>Configuration block for deployment circuit breaker. See below.</summary>
    [JsonPropertyName("deploymentCircuitBreaker")]
    public V1beta2ServiceStatusAtProviderDeploymentCircuitBreaker? DeploymentCircuitBreaker { get; set; }

    /// <summary>Configuration block for deployment settings. See below.</summary>
    [JsonPropertyName("deploymentConfiguration")]
    public V1beta2ServiceStatusAtProviderDeploymentConfiguration? DeploymentConfiguration { get; set; }

    /// <summary>Configuration block for deployment controller configuration. See below.</summary>
    [JsonPropertyName("deploymentController")]
    public V1beta2ServiceStatusAtProviderDeploymentController? DeploymentController { get; set; }

    /// <summary>Upper limit (as a percentage of the service&apos;s desiredCount) of the number of running tasks that can be running in a service during a deployment. Not valid when using the DAEMON scheduling strategy.</summary>
    [JsonPropertyName("deploymentMaximumPercent")]
    public double? DeploymentMaximumPercent { get; set; }

    /// <summary>Lower limit (as a percentage of the service&apos;s desiredCount) of the number of running tasks that must remain running and healthy in a service during a deployment.</summary>
    [JsonPropertyName("deploymentMinimumHealthyPercent")]
    public double? DeploymentMinimumHealthyPercent { get; set; }

    /// <summary>Number of instances of the task definition to place and keep running. Defaults to 0. Do not specify if using the DAEMON scheduling strategy.</summary>
    [JsonPropertyName("desiredCount")]
    public double? DesiredCount { get; set; }

    /// <summary>Whether to enable Amazon ECS managed tags for the tasks within the service.</summary>
    [JsonPropertyName("enableEcsManagedTags")]
    public bool? EnableEcsManagedTags { get; set; }

    /// <summary>Whether to enable Amazon ECS Exec for the tasks within the service.</summary>
    [JsonPropertyName("enableExecuteCommand")]
    public bool? EnableExecuteCommand { get; set; }

    /// <summary>Enable to delete a service even if it wasn&apos;t scaled down to zero tasks. It&apos;s only necessary to use this if the service uses the REPLICA scheduling strategy.</summary>
    [JsonPropertyName("forceDelete")]
    public bool? ForceDelete { get; set; }

    /// <summary>Enable to force a new task deployment of the service. This can be used to update tasks to use a newer Docker image with same image/tag combination (e.g., myimage:latest), roll Fargate tasks onto a newer platform version, or immediately deploy ordered_placement_strategy and placement_constraints updates.</summary>
    [JsonPropertyName("forceNewDeployment")]
    public bool? ForceNewDeployment { get; set; }

    /// <summary>Seconds to ignore failing load balancer health checks on newly instantiated tasks to prevent premature shutdown, up to 2147483647. Only valid for services configured to use load balancers.</summary>
    [JsonPropertyName("healthCheckGracePeriodSeconds")]
    public double? HealthCheckGracePeriodSeconds { get; set; }

    /// <summary>ARN of the IAM role that allows Amazon ECS to make calls to your load balancer on your behalf. This parameter is required if you are using a load balancer with your service, but only if your task definition does not use the awsvpc network mode. If using awsvpc network mode, do not specify this role. If your account has already created the Amazon ECS service-linked role, that role is used by default for your service unless you specify a role here.</summary>
    [JsonPropertyName("iamRole")]
    public string? IamRole { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Launch type on which to run your service. The valid values are EC2, FARGATE, and EXTERNAL. Defaults to EC2. Conflicts with capacity_provider_strategy.</summary>
    [JsonPropertyName("launchType")]
    public string? LaunchType { get; set; }

    /// <summary>Configuration block for load balancers. See below.</summary>
    [JsonPropertyName("loadBalancer")]
    public IList<V1beta2ServiceStatusAtProviderLoadBalancer>? LoadBalancer { get; set; }

    /// <summary>Network configuration for the service. This parameter is required for task definitions that use the awsvpc network mode to receive their own Elastic Network Interface, and it is not supported for other network modes. See below.</summary>
    [JsonPropertyName("networkConfiguration")]
    public V1beta2ServiceStatusAtProviderNetworkConfiguration? NetworkConfiguration { get; set; }

    /// <summary>Service level strategy rules that are taken into consideration during task placement. List from top to bottom in order of precedence. Updates to this configuration will take effect next task deployment unless force_new_deployment is enabled. The maximum number of ordered_placement_strategy blocks is 5. See below.</summary>
    [JsonPropertyName("orderedPlacementStrategy")]
    public IList<V1beta2ServiceStatusAtProviderOrderedPlacementStrategy>? OrderedPlacementStrategy { get; set; }

    /// <summary>Rules that are taken into consideration during task placement. Updates to this configuration will take effect next task deployment unless force_new_deployment is enabled. Maximum number of placement_constraints is 10. See below.</summary>
    [JsonPropertyName("placementConstraints")]
    public IList<V1beta2ServiceStatusAtProviderPlacementConstraints>? PlacementConstraints { get; set; }

    /// <summary>Platform version on which to run your service. Only applicable for launch_type set to FARGATE. Defaults to LATEST. More information about Fargate platform versions can be found in the AWS ECS User Guide.</summary>
    [JsonPropertyName("platformVersion")]
    public string? PlatformVersion { get; set; }

    /// <summary>Whether to propagate the tags from the task definition or the service to the tasks. The valid values are SERVICE and TASK_DEFINITION.</summary>
    [JsonPropertyName("propagateTags")]
    public string? PropagateTags { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>Scheduling strategy to use for the service. The valid values are REPLICA and DAEMON. Defaults to REPLICA. Note that Tasks using the Fargate launch type or the .</summary>
    [JsonPropertyName("schedulingStrategy")]
    public string? SchedulingStrategy { get; set; }

    /// <summary>ECS Service Connect configuration for this service to discover and connect to services, and be discovered by, and connected from, other services within a namespace. See below.</summary>
    [JsonPropertyName("serviceConnectConfiguration")]
    public V1beta2ServiceStatusAtProviderServiceConnectConfiguration? ServiceConnectConfiguration { get; set; }

    /// <summary>Service discovery registries for the service. The maximum number of service_registries blocks is 1. See below.</summary>
    [JsonPropertyName("serviceRegistries")]
    public V1beta2ServiceStatusAtProviderServiceRegistries? ServiceRegistries { get; set; }

    /// <summary>Whether to enable graceful termination of deployments using SIGINT signals. When enabled, allows customers to safely cancel an in-progress deployment and automatically trigger a rollback to the previous stable state. Defaults to false. Only applicable when using ECS deployment controller and requires wait_for_steady_state = true.</summary>
    [JsonPropertyName("sigintRollback")]
    public bool? SigintRollback { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Family and revision (family:revision) or full ARN of the task definition that you want to run in your service. Required unless using the EXTERNAL deployment controller. If a revision is not specified, the latest ACTIVE revision is used.</summary>
    [JsonPropertyName("taskDefinition")]
    public string? TaskDefinition { get; set; }

    /// <summary>Map of arbitrary keys and values that, when changed, will trigger an in-place update (redeployment). Useful with plantimestamp(). See example above.</summary>
    [JsonPropertyName("triggers")]
    public IDictionary<string, string>? Triggers { get; set; }

    /// <summary>Configuration for a volume specified in the task definition as a volume that is configured at launch time. Currently, the only supported volume type is an Amazon EBS volume. See below.</summary>
    [JsonPropertyName("volumeConfiguration")]
    public V1beta2ServiceStatusAtProviderVolumeConfiguration? VolumeConfiguration { get; set; }

    /// <summary>The VPC Lattice configuration for your service that allows Lattice to connect, secure, and monitor your service across multiple accounts and VPCs. See below.</summary>
    [JsonPropertyName("vpcLatticeConfigurations")]
    public IList<V1beta2ServiceStatusAtProviderVpcLatticeConfigurations>? VpcLatticeConfigurations { get; set; }

    /// <summary>Default false.</summary>
    [JsonPropertyName("waitForSteadyState")]
    public bool? WaitForSteadyState { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatusConditions
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

/// <summary>ServiceStatus defines the observed state of Service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2ServiceStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2ServiceStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2ServiceStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>Service is the Schema for the Services API. Provides an ECS service.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2Service : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2ServiceSpec>, IStatus<V1beta2ServiceStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "Service";
    public const string KubeGroup = "ecs.aws.upbound.io";
    public const string KubePluralName = "services";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "ecs.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "Service";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>ServiceSpec defines the desired state of Service</summary>
    [JsonPropertyName("spec")]
    public required V1beta2ServiceSpec Spec { get; set; }

    /// <summary>ServiceStatus defines the observed state of Service.</summary>
    [JsonPropertyName("status")]
    public V1beta2ServiceStatus? Status { get; set; }
}