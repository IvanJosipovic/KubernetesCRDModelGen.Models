#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.deploy.aws.upbound.io;
/// <summary>DeploymentGroup is the Schema for the DeploymentGroups API. Provides a CodeDeploy deployment group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DeploymentGroupList : IKubernetesObject<V1ListMeta>, IItems<V1beta2DeploymentGroup>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DeploymentGroupList";
    public const string KubeGroup = "deploy.aws.upbound.io";
    public const string KubePluralName = "deploymentgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "deploy.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DeploymentGroupList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2DeploymentGroup objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2DeploymentGroup> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecDeletionPolicyEnum>))]
public enum V1beta2DeploymentGroupSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>Configuration block of alarms associated with the deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderAlarmConfiguration
{
    /// <summary>A list of alarms configured for the deployment group.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary>Indicates whether the alarm configuration is enabled. This option is useful when you want to temporarily deactivate alarm monitoring for a deployment group without having to add the same alarms again later.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Indicates whether a deployment should continue if information about the current state of alarms cannot be retrieved from CloudWatch. The default value is false.</summary>
    [JsonPropertyName("ignorePollAlarmFailure")]
    public bool? IgnorePollAlarmFailure { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderAppNameRefPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderAppNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderAppNameRefPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderAppNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderAppNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecForProviderAppNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecForProviderAppNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a App in deploy to populate appName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderAppNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeploymentGroupSpecForProviderAppNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderAppNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderAppNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderAppNameSelectorPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderAppNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderAppNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecForProviderAppNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecForProviderAppNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a App in deploy to populate appName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderAppNameSelector
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
    public V1beta2DeploymentGroupSpecForProviderAppNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block of the automatic rollback configuration associated with the deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderAutoRollbackConfiguration
{
    /// <summary>Indicates whether the alarm configuration is enabled. This option is useful when you want to temporarily deactivate alarm monitoring for a deployment group without having to add the same alarms again later.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The event type or types that trigger a rollback. Supported types are DEPLOYMENT_FAILURE, DEPLOYMENT_STOP_ON_ALARM and DEPLOYMENT_STOP_ON_REQUEST.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }
}

/// <summary>Information about the action to take when newly provisioned instances are ready to receive traffic in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderBlueGreenDeploymentConfigDeploymentReadyOption
{
    /// <summary>When to reroute traffic from an original environment to a replacement environment in a blue/green deployment.</summary>
    [JsonPropertyName("actionOnTimeout")]
    public string? ActionOnTimeout { get; set; }

    /// <summary>The number of minutes to wait before the status of a blue/green deployment changed to Stopped if rerouting is not started manually. Applies only to the STOP_DEPLOYMENT option for action_on_timeout.</summary>
    [JsonPropertyName("waitTimeInMinutes")]
    public double? WaitTimeInMinutes { get; set; }
}

/// <summary>Information about how instances are provisioned for a replacement environment in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderBlueGreenDeploymentConfigGreenFleetProvisioningOption
{
    /// <summary>The method used to add instances to a replacement environment.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }
}

/// <summary>Information about whether to terminate instances in the original fleet during a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess
{
    /// <summary>The method used to add instances to a replacement environment.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The number of minutes to wait after a successful blue/green deployment before terminating instances from the original environment.</summary>
    [JsonPropertyName("terminationWaitTimeInMinutes")]
    public double? TerminationWaitTimeInMinutes { get; set; }
}

/// <summary>Configuration block of the blue/green deployment options for a deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderBlueGreenDeploymentConfig
{
    /// <summary>Information about the action to take when newly provisioned instances are ready to receive traffic in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("deploymentReadyOption")]
    public V1beta2DeploymentGroupSpecForProviderBlueGreenDeploymentConfigDeploymentReadyOption? DeploymentReadyOption { get; set; }

    /// <summary>Information about how instances are provisioned for a replacement environment in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("greenFleetProvisioningOption")]
    public V1beta2DeploymentGroupSpecForProviderBlueGreenDeploymentConfigGreenFleetProvisioningOption? GreenFleetProvisioningOption { get; set; }

    /// <summary>Information about whether to terminate instances in the original fleet during a blue/green deployment (documented below).</summary>
    [JsonPropertyName("terminateBlueInstancesOnDeploymentSuccess")]
    public V1beta2DeploymentGroupSpecForProviderBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess? TerminateBlueInstancesOnDeploymentSuccess { get; set; }
}

/// <summary>Configuration block of the type of deployment, either in-place or blue/green, you want to run and whether to route deployment traffic behind a load balancer (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderDeploymentStyle
{
    /// <summary>Indicates whether to route deployment traffic behind a load balancer. Valid Values are WITH_TRAFFIC_CONTROL or WITHOUT_TRAFFIC_CONTROL. Default is WITHOUT_TRAFFIC_CONTROL.</summary>
    [JsonPropertyName("deploymentOption")]
    public string? DeploymentOption { get; set; }

    /// <summary>Indicates whether to run an in-place deployment or a blue/green deployment. Valid Values are IN_PLACE or BLUE_GREEN. Default is IN_PLACE.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderEc2TagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderEc2TagSetEc2TagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderEc2TagSet
{
    /// <summary>Tag filters associated with the deployment group. See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagFilter")]
    public IList<V1beta2DeploymentGroupSpecForProviderEc2TagSetEc2TagFilter>? Ec2TagFilter { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameRefPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameRefPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in ecs to populate clusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameSelectorPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in ecs to populate clusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameSelector
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
    public V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameRefPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameRefPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Service in ecs to populate serviceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameSelectorPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Service in ecs to populate serviceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameSelector
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
    public V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block(s) of the ECS services for a deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderEcsService
{
    /// <summary>The name of the ECS cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Reference to a Cluster in ecs to populate clusterName.</summary>
    [JsonPropertyName("clusterNameRef")]
    public V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameRef? ClusterNameRef { get; set; }

    /// <summary>Selector for a Cluster in ecs to populate clusterName.</summary>
    [JsonPropertyName("clusterNameSelector")]
    public V1beta2DeploymentGroupSpecForProviderEcsServiceClusterNameSelector? ClusterNameSelector { get; set; }

    /// <summary>The name of the ECS service.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Reference to a Service in ecs to populate serviceName.</summary>
    [JsonPropertyName("serviceNameRef")]
    public V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameRef? ServiceNameRef { get; set; }

    /// <summary>Selector for a Service in ecs to populate serviceName.</summary>
    [JsonPropertyName("serviceNameSelector")]
    public V1beta2DeploymentGroupSpecForProviderEcsServiceServiceNameSelector? ServiceNameSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameRefPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameRefPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ELB in elb to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameSelectorPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ELB in elb to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameSelector
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
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfo
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a ELB in elb to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameRef? NameRef { get; set; }

    /// <summary>Selector for a ELB in elb to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfoNameSelector? NameSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupInfo
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of LBListener in elbv2 to populate listenerArns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelector
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
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for the production traffic route (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute
{
    /// <summary>List of Amazon Resource Names (ARNs) of the load balancer listeners.</summary>
    [JsonPropertyName("listenerArns")]
    public IList<string>? ListenerArns { get; set; }

    /// <summary>References to LBListener in elbv2 to populate listenerArns.</summary>
    [JsonPropertyName("listenerArnsRefs")]
    public IList<V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefs>? ListenerArnsRefs { get; set; }

    /// <summary>Selector for a list of LBListener in elbv2 to populate listenerArns.</summary>
    [JsonPropertyName("listenerArnsSelector")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelector? ListenerArnsSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelector
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
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroup
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRef? NameRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelector? NameSelector { get; set; }
}

/// <summary>Configuration block for the test traffic route (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute
{
    /// <summary>List of Amazon Resource Names (ARNs) of the load balancer listeners.</summary>
    [JsonPropertyName("listenerArns")]
    public IList<string>? ListenerArns { get; set; }
}

/// <summary>The (Application/Network Load Balancer) target group pair to use in a deployment. Conflicts with elb_info and target_group_info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfo
{
    /// <summary>Configuration block for the production traffic route (documented below).</summary>
    [JsonPropertyName("prodTrafficRoute")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute? ProdTrafficRoute { get; set; }

    /// <summary>Configuration blocks for a target group within a target group pair (documented below).</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTargetGroup>? TargetGroup { get; set; }

    /// <summary>Configuration block for the test traffic route (documented below).</summary>
    [JsonPropertyName("testTrafficRoute")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute? TestTrafficRoute { get; set; }
}

/// <summary>Single configuration block of the load balancer to use in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderLoadBalancerInfo
{
    /// <summary>The Classic Elastic Load Balancer to use in a deployment. Conflicts with target_group_info and target_group_pair_info.</summary>
    [JsonPropertyName("elbInfo")]
    public IList<V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoElbInfo>? ElbInfo { get; set; }

    /// <summary>The (Application/Network Load Balancer) target group to use in a deployment. Conflicts with elb_info and target_group_pair_info.</summary>
    [JsonPropertyName("targetGroupInfo")]
    public IList<V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupInfo>? TargetGroupInfo { get; set; }

    /// <summary>The (Application/Network Load Balancer) target group pair to use in a deployment. Conflicts with elb_info and target_group_info.</summary>
    [JsonPropertyName("targetGroupPairInfo")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfoTargetGroupPairInfo? TargetGroupPairInfo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderOnPremisesInstanceTagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderServiceRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderServiceRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderServiceRoleArnRefPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderServiceRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderServiceRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecForProviderServiceRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecForProviderServiceRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeploymentGroupSpecForProviderServiceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderServiceRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderServiceRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderServiceRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderServiceRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderServiceRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecForProviderServiceRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecForProviderServiceRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderServiceRoleArnSelector
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
    public V1beta2DeploymentGroupSpecForProviderServiceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnRefPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnRefPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate triggerTargetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnSelectorPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnSelectorPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate triggerTargetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnSelector
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
    public V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProviderTriggerConfiguration
{
    /// <summary>The event type or types for which notifications are triggered. Some values that are supported: DeploymentStart, DeploymentSuccess, DeploymentFailure, DeploymentStop, DeploymentRollback, InstanceStart, InstanceSuccess, InstanceFailure.  See the CodeDeploy documentation for all possible values.</summary>
    [JsonPropertyName("triggerEvents")]
    public IList<string>? TriggerEvents { get; set; }

    /// <summary>The name of the notification trigger.</summary>
    [JsonPropertyName("triggerName")]
    public string? TriggerName { get; set; }

    /// <summary>The ARN of the SNS topic through which notifications are sent.</summary>
    [JsonPropertyName("triggerTargetArn")]
    public string? TriggerTargetArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate triggerTargetArn.</summary>
    [JsonPropertyName("triggerTargetArnRef")]
    public V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnRef? TriggerTargetArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate triggerTargetArn.</summary>
    [JsonPropertyName("triggerTargetArnSelector")]
    public V1beta2DeploymentGroupSpecForProviderTriggerConfigurationTriggerTargetArnSelector? TriggerTargetArnSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecForProvider
{
    /// <summary>Configuration block of alarms associated with the deployment group (documented below).</summary>
    [JsonPropertyName("alarmConfiguration")]
    public V1beta2DeploymentGroupSpecForProviderAlarmConfiguration? AlarmConfiguration { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("appName")]
    public string? AppName { get; set; }

    /// <summary>Reference to a App in deploy to populate appName.</summary>
    [JsonPropertyName("appNameRef")]
    public V1beta2DeploymentGroupSpecForProviderAppNameRef? AppNameRef { get; set; }

    /// <summary>Selector for a App in deploy to populate appName.</summary>
    [JsonPropertyName("appNameSelector")]
    public V1beta2DeploymentGroupSpecForProviderAppNameSelector? AppNameSelector { get; set; }

    /// <summary>Configuration block of the automatic rollback configuration associated with the deployment group (documented below).</summary>
    [JsonPropertyName("autoRollbackConfiguration")]
    public V1beta2DeploymentGroupSpecForProviderAutoRollbackConfiguration? AutoRollbackConfiguration { get; set; }

    /// <summary>Autoscaling groups associated with the deployment group.</summary>
    [JsonPropertyName("autoscalingGroups")]
    public IList<string>? AutoscalingGroups { get; set; }

    /// <summary>Configuration block of the blue/green deployment options for a deployment group (documented below).</summary>
    [JsonPropertyName("blueGreenDeploymentConfig")]
    public V1beta2DeploymentGroupSpecForProviderBlueGreenDeploymentConfig? BlueGreenDeploymentConfig { get; set; }

    /// <summary>The name of the group&apos;s deployment config. The default is &quot;CodeDeployDefault.OneAtATime&quot;.</summary>
    [JsonPropertyName("deploymentConfigName")]
    public string? DeploymentConfigName { get; set; }

    /// <summary>Configuration block of the type of deployment, either in-place or blue/green, you want to run and whether to route deployment traffic behind a load balancer (documented below).</summary>
    [JsonPropertyName("deploymentStyle")]
    public V1beta2DeploymentGroupSpecForProviderDeploymentStyle? DeploymentStyle { get; set; }

    /// <summary>Tag filters associated with the deployment group. See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagFilter")]
    public IList<V1beta2DeploymentGroupSpecForProviderEc2TagFilter>? Ec2TagFilter { get; set; }

    /// <summary>Configuration block(s) of Tag filters associated with the deployment group, which are also referred to as tag groups (documented below). See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagSet")]
    public IList<V1beta2DeploymentGroupSpecForProviderEc2TagSet>? Ec2TagSet { get; set; }

    /// <summary>Configuration block(s) of the ECS services for a deployment group (documented below).</summary>
    [JsonPropertyName("ecsService")]
    public V1beta2DeploymentGroupSpecForProviderEcsService? EcsService { get; set; }

    /// <summary>Single configuration block of the load balancer to use in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("loadBalancerInfo")]
    public V1beta2DeploymentGroupSpecForProviderLoadBalancerInfo? LoadBalancerInfo { get; set; }

    /// <summary>On premise tag filters associated with the group. See the AWS docs for details.</summary>
    [JsonPropertyName("onPremisesInstanceTagFilter")]
    public IList<V1beta2DeploymentGroupSpecForProviderOnPremisesInstanceTagFilter>? OnPremisesInstanceTagFilter { get; set; }

    /// <summary>Configuration block of Indicates what happens when new Amazon EC2 instances are launched mid-deployment and do not receive the deployed application revision. Valid values are UPDATE and IGNORE. Defaults to UPDATE.</summary>
    [JsonPropertyName("outdatedInstancesStrategy")]
    public string? OutdatedInstancesStrategy { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>The service role ARN that allows deployments.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnRef")]
    public V1beta2DeploymentGroupSpecForProviderServiceRoleArnRef? ServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnSelector")]
    public V1beta2DeploymentGroupSpecForProviderServiceRoleArnSelector? ServiceRoleArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Indicates whether the deployment group was configured to have CodeDeploy install a termination hook into an Auto Scaling group.</summary>
    [JsonPropertyName("terminationHookEnabled")]
    public bool? TerminationHookEnabled { get; set; }

    /// <summary>Configuration block(s) of the triggers for the deployment group (documented below).</summary>
    [JsonPropertyName("triggerConfiguration")]
    public IList<V1beta2DeploymentGroupSpecForProviderTriggerConfiguration>? TriggerConfiguration { get; set; }
}

/// <summary>Configuration block of alarms associated with the deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderAlarmConfiguration
{
    /// <summary>A list of alarms configured for the deployment group.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary>Indicates whether the alarm configuration is enabled. This option is useful when you want to temporarily deactivate alarm monitoring for a deployment group without having to add the same alarms again later.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Indicates whether a deployment should continue if information about the current state of alarms cannot be retrieved from CloudWatch. The default value is false.</summary>
    [JsonPropertyName("ignorePollAlarmFailure")]
    public bool? IgnorePollAlarmFailure { get; set; }
}

/// <summary>Configuration block of the automatic rollback configuration associated with the deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderAutoRollbackConfiguration
{
    /// <summary>Indicates whether the alarm configuration is enabled. This option is useful when you want to temporarily deactivate alarm monitoring for a deployment group without having to add the same alarms again later.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The event type or types that trigger a rollback. Supported types are DEPLOYMENT_FAILURE, DEPLOYMENT_STOP_ON_ALARM and DEPLOYMENT_STOP_ON_REQUEST.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }
}

/// <summary>Information about the action to take when newly provisioned instances are ready to receive traffic in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderBlueGreenDeploymentConfigDeploymentReadyOption
{
    /// <summary>When to reroute traffic from an original environment to a replacement environment in a blue/green deployment.</summary>
    [JsonPropertyName("actionOnTimeout")]
    public string? ActionOnTimeout { get; set; }

    /// <summary>The number of minutes to wait before the status of a blue/green deployment changed to Stopped if rerouting is not started manually. Applies only to the STOP_DEPLOYMENT option for action_on_timeout.</summary>
    [JsonPropertyName("waitTimeInMinutes")]
    public double? WaitTimeInMinutes { get; set; }
}

/// <summary>Information about how instances are provisioned for a replacement environment in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderBlueGreenDeploymentConfigGreenFleetProvisioningOption
{
    /// <summary>The method used to add instances to a replacement environment.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }
}

/// <summary>Information about whether to terminate instances in the original fleet during a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess
{
    /// <summary>The method used to add instances to a replacement environment.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The number of minutes to wait after a successful blue/green deployment before terminating instances from the original environment.</summary>
    [JsonPropertyName("terminationWaitTimeInMinutes")]
    public double? TerminationWaitTimeInMinutes { get; set; }
}

/// <summary>Configuration block of the blue/green deployment options for a deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderBlueGreenDeploymentConfig
{
    /// <summary>Information about the action to take when newly provisioned instances are ready to receive traffic in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("deploymentReadyOption")]
    public V1beta2DeploymentGroupSpecInitProviderBlueGreenDeploymentConfigDeploymentReadyOption? DeploymentReadyOption { get; set; }

    /// <summary>Information about how instances are provisioned for a replacement environment in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("greenFleetProvisioningOption")]
    public V1beta2DeploymentGroupSpecInitProviderBlueGreenDeploymentConfigGreenFleetProvisioningOption? GreenFleetProvisioningOption { get; set; }

    /// <summary>Information about whether to terminate instances in the original fleet during a blue/green deployment (documented below).</summary>
    [JsonPropertyName("terminateBlueInstancesOnDeploymentSuccess")]
    public V1beta2DeploymentGroupSpecInitProviderBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess? TerminateBlueInstancesOnDeploymentSuccess { get; set; }
}

/// <summary>Configuration block of the type of deployment, either in-place or blue/green, you want to run and whether to route deployment traffic behind a load balancer (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderDeploymentStyle
{
    /// <summary>Indicates whether to route deployment traffic behind a load balancer. Valid Values are WITH_TRAFFIC_CONTROL or WITHOUT_TRAFFIC_CONTROL. Default is WITHOUT_TRAFFIC_CONTROL.</summary>
    [JsonPropertyName("deploymentOption")]
    public string? DeploymentOption { get; set; }

    /// <summary>Indicates whether to run an in-place deployment or a blue/green deployment. Valid Values are IN_PLACE or BLUE_GREEN. Default is IN_PLACE.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderEc2TagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderEc2TagSetEc2TagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderEc2TagSet
{
    /// <summary>Tag filters associated with the deployment group. See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagFilter")]
    public IList<V1beta2DeploymentGroupSpecInitProviderEc2TagSetEc2TagFilter>? Ec2TagFilter { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameRefPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameRefPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Cluster in ecs to populate clusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameSelectorPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Cluster in ecs to populate clusterName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameSelector
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
    public V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameRefPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameRefPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Service in ecs to populate serviceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameSelectorPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Service in ecs to populate serviceName.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameSelector
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
    public V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block(s) of the ECS services for a deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderEcsService
{
    /// <summary>The name of the ECS cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>Reference to a Cluster in ecs to populate clusterName.</summary>
    [JsonPropertyName("clusterNameRef")]
    public V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameRef? ClusterNameRef { get; set; }

    /// <summary>Selector for a Cluster in ecs to populate clusterName.</summary>
    [JsonPropertyName("clusterNameSelector")]
    public V1beta2DeploymentGroupSpecInitProviderEcsServiceClusterNameSelector? ClusterNameSelector { get; set; }

    /// <summary>The name of the ECS service.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }

    /// <summary>Reference to a Service in ecs to populate serviceName.</summary>
    [JsonPropertyName("serviceNameRef")]
    public V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameRef? ServiceNameRef { get; set; }

    /// <summary>Selector for a Service in ecs to populate serviceName.</summary>
    [JsonPropertyName("serviceNameSelector")]
    public V1beta2DeploymentGroupSpecInitProviderEcsServiceServiceNameSelector? ServiceNameSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameRefPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameRefPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a ELB in elb to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameSelectorPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a ELB in elb to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameSelector
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
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfo
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a ELB in elb to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameRef? NameRef { get; set; }

    /// <summary>Selector for a ELB in elb to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfoNameSelector? NameSelector { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupInfo
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>A Reference to a named object.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefs
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefsPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a list of LBListener in elbv2 to populate listenerArns.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelector
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
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelectorPolicy? Policy { get; set; }
}

/// <summary>Configuration block for the production traffic route (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute
{
    /// <summary>List of Amazon Resource Names (ARNs) of the load balancer listeners.</summary>
    [JsonPropertyName("listenerArns")]
    public IList<string>? ListenerArns { get; set; }

    /// <summary>References to LBListener in elbv2 to populate listenerArns.</summary>
    [JsonPropertyName("listenerArnsRefs")]
    public IList<V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsRefs>? ListenerArnsRefs { get; set; }

    /// <summary>Selector for a list of LBListener in elbv2 to populate listenerArns.</summary>
    [JsonPropertyName("listenerArnsSelector")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRouteListenerArnsSelector? ListenerArnsSelector { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a LBTargetGroup in elbv2 to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a LBTargetGroup in elbv2 to populate name.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelector
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
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroup
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Reference to a LBTargetGroup in elbv2 to populate name.</summary>
    [JsonPropertyName("nameRef")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameRef? NameRef { get; set; }

    /// <summary>Selector for a LBTargetGroup in elbv2 to populate name.</summary>
    [JsonPropertyName("nameSelector")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroupNameSelector? NameSelector { get; set; }
}

/// <summary>Configuration block for the test traffic route (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute
{
    /// <summary>List of Amazon Resource Names (ARNs) of the load balancer listeners.</summary>
    [JsonPropertyName("listenerArns")]
    public IList<string>? ListenerArns { get; set; }
}

/// <summary>The (Application/Network Load Balancer) target group pair to use in a deployment. Conflicts with elb_info and target_group_info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfo
{
    /// <summary>Configuration block for the production traffic route (documented below).</summary>
    [JsonPropertyName("prodTrafficRoute")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute? ProdTrafficRoute { get; set; }

    /// <summary>Configuration blocks for a target group within a target group pair (documented below).</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTargetGroup>? TargetGroup { get; set; }

    /// <summary>Configuration block for the test traffic route (documented below).</summary>
    [JsonPropertyName("testTrafficRoute")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute? TestTrafficRoute { get; set; }
}

/// <summary>Single configuration block of the load balancer to use in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfo
{
    /// <summary>The Classic Elastic Load Balancer to use in a deployment. Conflicts with target_group_info and target_group_pair_info.</summary>
    [JsonPropertyName("elbInfo")]
    public IList<V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoElbInfo>? ElbInfo { get; set; }

    /// <summary>The (Application/Network Load Balancer) target group to use in a deployment. Conflicts with elb_info and target_group_pair_info.</summary>
    [JsonPropertyName("targetGroupInfo")]
    public IList<V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupInfo>? TargetGroupInfo { get; set; }

    /// <summary>The (Application/Network Load Balancer) target group pair to use in a deployment. Conflicts with elb_info and target_group_info.</summary>
    [JsonPropertyName("targetGroupPairInfo")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfoTargetGroupPairInfo? TargetGroupPairInfo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderOnPremisesInstanceTagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderServiceRoleArnRefPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderServiceRoleArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderServiceRoleArnRefPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderServiceRoleArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderServiceRoleArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecInitProviderServiceRoleArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecInitProviderServiceRoleArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderServiceRoleArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeploymentGroupSpecInitProviderServiceRoleArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderServiceRoleArnSelectorPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderServiceRoleArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderServiceRoleArnSelectorPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderServiceRoleArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderServiceRoleArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecInitProviderServiceRoleArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecInitProviderServiceRoleArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderServiceRoleArnSelector
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
    public V1beta2DeploymentGroupSpecInitProviderServiceRoleArnSelectorPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnRefPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnRefPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a Topic in sns to populate triggerTargetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnSelectorPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnSelectorPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a Topic in sns to populate triggerTargetArn.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnSelector
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
    public V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecInitProviderTriggerConfiguration
{
    /// <summary>The event type or types for which notifications are triggered. Some values that are supported: DeploymentStart, DeploymentSuccess, DeploymentFailure, DeploymentStop, DeploymentRollback, InstanceStart, InstanceSuccess, InstanceFailure.  See the CodeDeploy documentation for all possible values.</summary>
    [JsonPropertyName("triggerEvents")]
    public IList<string>? TriggerEvents { get; set; }

    /// <summary>The name of the notification trigger.</summary>
    [JsonPropertyName("triggerName")]
    public string? TriggerName { get; set; }

    /// <summary>The ARN of the SNS topic through which notifications are sent.</summary>
    [JsonPropertyName("triggerTargetArn")]
    public string? TriggerTargetArn { get; set; }

    /// <summary>Reference to a Topic in sns to populate triggerTargetArn.</summary>
    [JsonPropertyName("triggerTargetArnRef")]
    public V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnRef? TriggerTargetArnRef { get; set; }

    /// <summary>Selector for a Topic in sns to populate triggerTargetArn.</summary>
    [JsonPropertyName("triggerTargetArnSelector")]
    public V1beta2DeploymentGroupSpecInitProviderTriggerConfigurationTriggerTargetArnSelector? TriggerTargetArnSelector { get; set; }
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
public partial class V1beta2DeploymentGroupSpecInitProvider
{
    /// <summary>Configuration block of alarms associated with the deployment group (documented below).</summary>
    [JsonPropertyName("alarmConfiguration")]
    public V1beta2DeploymentGroupSpecInitProviderAlarmConfiguration? AlarmConfiguration { get; set; }

    /// <summary>Configuration block of the automatic rollback configuration associated with the deployment group (documented below).</summary>
    [JsonPropertyName("autoRollbackConfiguration")]
    public V1beta2DeploymentGroupSpecInitProviderAutoRollbackConfiguration? AutoRollbackConfiguration { get; set; }

    /// <summary>Autoscaling groups associated with the deployment group.</summary>
    [JsonPropertyName("autoscalingGroups")]
    public IList<string>? AutoscalingGroups { get; set; }

    /// <summary>Configuration block of the blue/green deployment options for a deployment group (documented below).</summary>
    [JsonPropertyName("blueGreenDeploymentConfig")]
    public V1beta2DeploymentGroupSpecInitProviderBlueGreenDeploymentConfig? BlueGreenDeploymentConfig { get; set; }

    /// <summary>The name of the group&apos;s deployment config. The default is &quot;CodeDeployDefault.OneAtATime&quot;.</summary>
    [JsonPropertyName("deploymentConfigName")]
    public string? DeploymentConfigName { get; set; }

    /// <summary>Configuration block of the type of deployment, either in-place or blue/green, you want to run and whether to route deployment traffic behind a load balancer (documented below).</summary>
    [JsonPropertyName("deploymentStyle")]
    public V1beta2DeploymentGroupSpecInitProviderDeploymentStyle? DeploymentStyle { get; set; }

    /// <summary>Tag filters associated with the deployment group. See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagFilter")]
    public IList<V1beta2DeploymentGroupSpecInitProviderEc2TagFilter>? Ec2TagFilter { get; set; }

    /// <summary>Configuration block(s) of Tag filters associated with the deployment group, which are also referred to as tag groups (documented below). See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagSet")]
    public IList<V1beta2DeploymentGroupSpecInitProviderEc2TagSet>? Ec2TagSet { get; set; }

    /// <summary>Configuration block(s) of the ECS services for a deployment group (documented below).</summary>
    [JsonPropertyName("ecsService")]
    public V1beta2DeploymentGroupSpecInitProviderEcsService? EcsService { get; set; }

    /// <summary>Single configuration block of the load balancer to use in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("loadBalancerInfo")]
    public V1beta2DeploymentGroupSpecInitProviderLoadBalancerInfo? LoadBalancerInfo { get; set; }

    /// <summary>On premise tag filters associated with the group. See the AWS docs for details.</summary>
    [JsonPropertyName("onPremisesInstanceTagFilter")]
    public IList<V1beta2DeploymentGroupSpecInitProviderOnPremisesInstanceTagFilter>? OnPremisesInstanceTagFilter { get; set; }

    /// <summary>Configuration block of Indicates what happens when new Amazon EC2 instances are launched mid-deployment and do not receive the deployed application revision. Valid values are UPDATE and IGNORE. Defaults to UPDATE.</summary>
    [JsonPropertyName("outdatedInstancesStrategy")]
    public string? OutdatedInstancesStrategy { get; set; }

    /// <summary>The service role ARN that allows deployments.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Reference to a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnRef")]
    public V1beta2DeploymentGroupSpecInitProviderServiceRoleArnRef? ServiceRoleArnRef { get; set; }

    /// <summary>Selector for a Role in iam to populate serviceRoleArn.</summary>
    [JsonPropertyName("serviceRoleArnSelector")]
    public V1beta2DeploymentGroupSpecInitProviderServiceRoleArnSelector? ServiceRoleArnSelector { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>Indicates whether the deployment group was configured to have CodeDeploy install a termination hook into an Auto Scaling group.</summary>
    [JsonPropertyName("terminationHookEnabled")]
    public bool? TerminationHookEnabled { get; set; }

    /// <summary>Configuration block(s) of the triggers for the deployment group (documented below).</summary>
    [JsonPropertyName("triggerConfiguration")]
    public IList<V1beta2DeploymentGroupSpecInitProviderTriggerConfiguration>? TriggerConfiguration { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecManagementPoliciesEnum>))]
public enum V1beta2DeploymentGroupSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2DeploymentGroupSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentGroupSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2DeploymentGroupSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentGroupSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentGroupSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeploymentGroupSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DeploymentGroupSpec defines the desired state of DeploymentGroup</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupSpec
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
    public V1beta2DeploymentGroupSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2DeploymentGroupSpecForProvider ForProvider { get; set; }

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
    public V1beta2DeploymentGroupSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2DeploymentGroupSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2DeploymentGroupSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2DeploymentGroupSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>Configuration block of alarms associated with the deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderAlarmConfiguration
{
    /// <summary>A list of alarms configured for the deployment group.</summary>
    [JsonPropertyName("alarms")]
    public IList<string>? Alarms { get; set; }

    /// <summary>Indicates whether the alarm configuration is enabled. This option is useful when you want to temporarily deactivate alarm monitoring for a deployment group without having to add the same alarms again later.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Indicates whether a deployment should continue if information about the current state of alarms cannot be retrieved from CloudWatch. The default value is false.</summary>
    [JsonPropertyName("ignorePollAlarmFailure")]
    public bool? IgnorePollAlarmFailure { get; set; }
}

/// <summary>Configuration block of the automatic rollback configuration associated with the deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderAutoRollbackConfiguration
{
    /// <summary>Indicates whether the alarm configuration is enabled. This option is useful when you want to temporarily deactivate alarm monitoring for a deployment group without having to add the same alarms again later.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>The event type or types that trigger a rollback. Supported types are DEPLOYMENT_FAILURE, DEPLOYMENT_STOP_ON_ALARM and DEPLOYMENT_STOP_ON_REQUEST.</summary>
    [JsonPropertyName("events")]
    public IList<string>? Events { get; set; }
}

/// <summary>Information about the action to take when newly provisioned instances are ready to receive traffic in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderBlueGreenDeploymentConfigDeploymentReadyOption
{
    /// <summary>When to reroute traffic from an original environment to a replacement environment in a blue/green deployment.</summary>
    [JsonPropertyName("actionOnTimeout")]
    public string? ActionOnTimeout { get; set; }

    /// <summary>The number of minutes to wait before the status of a blue/green deployment changed to Stopped if rerouting is not started manually. Applies only to the STOP_DEPLOYMENT option for action_on_timeout.</summary>
    [JsonPropertyName("waitTimeInMinutes")]
    public double? WaitTimeInMinutes { get; set; }
}

/// <summary>Information about how instances are provisioned for a replacement environment in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderBlueGreenDeploymentConfigGreenFleetProvisioningOption
{
    /// <summary>The method used to add instances to a replacement environment.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }
}

/// <summary>Information about whether to terminate instances in the original fleet during a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess
{
    /// <summary>The method used to add instances to a replacement environment.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>The number of minutes to wait after a successful blue/green deployment before terminating instances from the original environment.</summary>
    [JsonPropertyName("terminationWaitTimeInMinutes")]
    public double? TerminationWaitTimeInMinutes { get; set; }
}

/// <summary>Configuration block of the blue/green deployment options for a deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderBlueGreenDeploymentConfig
{
    /// <summary>Information about the action to take when newly provisioned instances are ready to receive traffic in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("deploymentReadyOption")]
    public V1beta2DeploymentGroupStatusAtProviderBlueGreenDeploymentConfigDeploymentReadyOption? DeploymentReadyOption { get; set; }

    /// <summary>Information about how instances are provisioned for a replacement environment in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("greenFleetProvisioningOption")]
    public V1beta2DeploymentGroupStatusAtProviderBlueGreenDeploymentConfigGreenFleetProvisioningOption? GreenFleetProvisioningOption { get; set; }

    /// <summary>Information about whether to terminate instances in the original fleet during a blue/green deployment (documented below).</summary>
    [JsonPropertyName("terminateBlueInstancesOnDeploymentSuccess")]
    public V1beta2DeploymentGroupStatusAtProviderBlueGreenDeploymentConfigTerminateBlueInstancesOnDeploymentSuccess? TerminateBlueInstancesOnDeploymentSuccess { get; set; }
}

/// <summary>Configuration block of the type of deployment, either in-place or blue/green, you want to run and whether to route deployment traffic behind a load balancer (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderDeploymentStyle
{
    /// <summary>Indicates whether to route deployment traffic behind a load balancer. Valid Values are WITH_TRAFFIC_CONTROL or WITHOUT_TRAFFIC_CONTROL. Default is WITHOUT_TRAFFIC_CONTROL.</summary>
    [JsonPropertyName("deploymentOption")]
    public string? DeploymentOption { get; set; }

    /// <summary>Indicates whether to run an in-place deployment or a blue/green deployment. Valid Values are IN_PLACE or BLUE_GREEN. Default is IN_PLACE.</summary>
    [JsonPropertyName("deploymentType")]
    public string? DeploymentType { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderEc2TagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderEc2TagSetEc2TagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderEc2TagSet
{
    /// <summary>Tag filters associated with the deployment group. See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagFilter")]
    public IList<V1beta2DeploymentGroupStatusAtProviderEc2TagSetEc2TagFilter>? Ec2TagFilter { get; set; }
}

/// <summary>Configuration block(s) of the ECS services for a deployment group (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderEcsService
{
    /// <summary>The name of the ECS cluster.</summary>
    [JsonPropertyName("clusterName")]
    public string? ClusterName { get; set; }

    /// <summary>The name of the ECS service.</summary>
    [JsonPropertyName("serviceName")]
    public string? ServiceName { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderLoadBalancerInfoElbInfo
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupInfo
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configuration block for the production traffic route (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute
{
    /// <summary>List of Amazon Resource Names (ARNs) of the load balancer listeners.</summary>
    [JsonPropertyName("listenerArns")]
    public IList<string>? ListenerArns { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupPairInfoTargetGroup
{
    /// <summary>The name of the target group that instances in the original environment are deregistered from, and instances in the replacement environment registered with. For in-place deployments, the name of the target group that instances are deregistered from, so they are not serving traffic during a deployment, and then re-registered with after the deployment completes.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }
}

/// <summary>Configuration block for the test traffic route (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute
{
    /// <summary>List of Amazon Resource Names (ARNs) of the load balancer listeners.</summary>
    [JsonPropertyName("listenerArns")]
    public IList<string>? ListenerArns { get; set; }
}

/// <summary>The (Application/Network Load Balancer) target group pair to use in a deployment. Conflicts with elb_info and target_group_info.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupPairInfo
{
    /// <summary>Configuration block for the production traffic route (documented below).</summary>
    [JsonPropertyName("prodTrafficRoute")]
    public V1beta2DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupPairInfoProdTrafficRoute? ProdTrafficRoute { get; set; }

    /// <summary>Configuration blocks for a target group within a target group pair (documented below).</summary>
    [JsonPropertyName("targetGroup")]
    public IList<V1beta2DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupPairInfoTargetGroup>? TargetGroup { get; set; }

    /// <summary>Configuration block for the test traffic route (documented below).</summary>
    [JsonPropertyName("testTrafficRoute")]
    public V1beta2DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupPairInfoTestTrafficRoute? TestTrafficRoute { get; set; }
}

/// <summary>Single configuration block of the load balancer to use in a blue/green deployment (documented below).</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderLoadBalancerInfo
{
    /// <summary>The Classic Elastic Load Balancer to use in a deployment. Conflicts with target_group_info and target_group_pair_info.</summary>
    [JsonPropertyName("elbInfo")]
    public IList<V1beta2DeploymentGroupStatusAtProviderLoadBalancerInfoElbInfo>? ElbInfo { get; set; }

    /// <summary>The (Application/Network Load Balancer) target group to use in a deployment. Conflicts with elb_info and target_group_pair_info.</summary>
    [JsonPropertyName("targetGroupInfo")]
    public IList<V1beta2DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupInfo>? TargetGroupInfo { get; set; }

    /// <summary>The (Application/Network Load Balancer) target group pair to use in a deployment. Conflicts with elb_info and target_group_info.</summary>
    [JsonPropertyName("targetGroupPairInfo")]
    public V1beta2DeploymentGroupStatusAtProviderLoadBalancerInfoTargetGroupPairInfo? TargetGroupPairInfo { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderOnPremisesInstanceTagFilter
{
    /// <summary>The key of the tag filter.</summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>The type of the tag filter, either KEY_ONLY, VALUE_ONLY, or KEY_AND_VALUE.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value of the tag filter.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProviderTriggerConfiguration
{
    /// <summary>The event type or types for which notifications are triggered. Some values that are supported: DeploymentStart, DeploymentSuccess, DeploymentFailure, DeploymentStop, DeploymentRollback, InstanceStart, InstanceSuccess, InstanceFailure.  See the CodeDeploy documentation for all possible values.</summary>
    [JsonPropertyName("triggerEvents")]
    public IList<string>? TriggerEvents { get; set; }

    /// <summary>The name of the notification trigger.</summary>
    [JsonPropertyName("triggerName")]
    public string? TriggerName { get; set; }

    /// <summary>The ARN of the SNS topic through which notifications are sent.</summary>
    [JsonPropertyName("triggerTargetArn")]
    public string? TriggerTargetArn { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusAtProvider
{
    /// <summary>Configuration block of alarms associated with the deployment group (documented below).</summary>
    [JsonPropertyName("alarmConfiguration")]
    public V1beta2DeploymentGroupStatusAtProviderAlarmConfiguration? AlarmConfiguration { get; set; }

    /// <summary>The name of the application.</summary>
    [JsonPropertyName("appName")]
    public string? AppName { get; set; }

    /// <summary>The ARN of the CodeDeploy deployment group.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>Configuration block of the automatic rollback configuration associated with the deployment group (documented below).</summary>
    [JsonPropertyName("autoRollbackConfiguration")]
    public V1beta2DeploymentGroupStatusAtProviderAutoRollbackConfiguration? AutoRollbackConfiguration { get; set; }

    /// <summary>Autoscaling groups associated with the deployment group.</summary>
    [JsonPropertyName("autoscalingGroups")]
    public IList<string>? AutoscalingGroups { get; set; }

    /// <summary>Configuration block of the blue/green deployment options for a deployment group (documented below).</summary>
    [JsonPropertyName("blueGreenDeploymentConfig")]
    public V1beta2DeploymentGroupStatusAtProviderBlueGreenDeploymentConfig? BlueGreenDeploymentConfig { get; set; }

    /// <summary>The destination platform type for the deployment.</summary>
    [JsonPropertyName("computePlatform")]
    public string? ComputePlatform { get; set; }

    /// <summary>The name of the group&apos;s deployment config. The default is &quot;CodeDeployDefault.OneAtATime&quot;.</summary>
    [JsonPropertyName("deploymentConfigName")]
    public string? DeploymentConfigName { get; set; }

    /// <summary>The ID of the CodeDeploy deployment group.</summary>
    [JsonPropertyName("deploymentGroupId")]
    public string? DeploymentGroupId { get; set; }

    /// <summary>Configuration block of the type of deployment, either in-place or blue/green, you want to run and whether to route deployment traffic behind a load balancer (documented below).</summary>
    [JsonPropertyName("deploymentStyle")]
    public V1beta2DeploymentGroupStatusAtProviderDeploymentStyle? DeploymentStyle { get; set; }

    /// <summary>Tag filters associated with the deployment group. See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagFilter")]
    public IList<V1beta2DeploymentGroupStatusAtProviderEc2TagFilter>? Ec2TagFilter { get; set; }

    /// <summary>Configuration block(s) of Tag filters associated with the deployment group, which are also referred to as tag groups (documented below). See the AWS docs for details.</summary>
    [JsonPropertyName("ec2TagSet")]
    public IList<V1beta2DeploymentGroupStatusAtProviderEc2TagSet>? Ec2TagSet { get; set; }

    /// <summary>Configuration block(s) of the ECS services for a deployment group (documented below).</summary>
    [JsonPropertyName("ecsService")]
    public V1beta2DeploymentGroupStatusAtProviderEcsService? EcsService { get; set; }

    /// <summary>Application name and deployment group name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Single configuration block of the load balancer to use in a blue/green deployment (documented below).</summary>
    [JsonPropertyName("loadBalancerInfo")]
    public V1beta2DeploymentGroupStatusAtProviderLoadBalancerInfo? LoadBalancerInfo { get; set; }

    /// <summary>On premise tag filters associated with the group. See the AWS docs for details.</summary>
    [JsonPropertyName("onPremisesInstanceTagFilter")]
    public IList<V1beta2DeploymentGroupStatusAtProviderOnPremisesInstanceTagFilter>? OnPremisesInstanceTagFilter { get; set; }

    /// <summary>Configuration block of Indicates what happens when new Amazon EC2 instances are launched mid-deployment and do not receive the deployed application revision. Valid values are UPDATE and IGNORE. Defaults to UPDATE.</summary>
    [JsonPropertyName("outdatedInstancesStrategy")]
    public string? OutdatedInstancesStrategy { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The service role ARN that allows deployments.</summary>
    [JsonPropertyName("serviceRoleArn")]
    public string? ServiceRoleArn { get; set; }

    /// <summary>Key-value map of resource tags.</summary>
    [JsonPropertyName("tags")]
    public IDictionary<string, string>? Tags { get; set; }

    /// <summary>A map of tags assigned to the resource, including those inherited from the provider default_tags configuration block.</summary>
    [JsonPropertyName("tagsAll")]
    public IDictionary<string, string>? TagsAll { get; set; }

    /// <summary>Indicates whether the deployment group was configured to have CodeDeploy install a termination hook into an Auto Scaling group.</summary>
    [JsonPropertyName("terminationHookEnabled")]
    public bool? TerminationHookEnabled { get; set; }

    /// <summary>Configuration block(s) of the triggers for the deployment group (documented below).</summary>
    [JsonPropertyName("triggerConfiguration")]
    public IList<V1beta2DeploymentGroupStatusAtProviderTriggerConfiguration>? TriggerConfiguration { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatusConditions
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

/// <summary>DeploymentGroupStatus defines the observed state of DeploymentGroup.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentGroupStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2DeploymentGroupStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DeploymentGroupStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DeploymentGroup is the Schema for the DeploymentGroups API. Provides a CodeDeploy deployment group.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DeploymentGroup : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2DeploymentGroupSpec>, IStatus<V1beta2DeploymentGroupStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DeploymentGroup";
    public const string KubeGroup = "deploy.aws.upbound.io";
    public const string KubePluralName = "deploymentgroups";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "deploy.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DeploymentGroup";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DeploymentGroupSpec defines the desired state of DeploymentGroup</summary>
    [JsonPropertyName("spec")]
    public required V1beta2DeploymentGroupSpec Spec { get; set; }

    /// <summary>DeploymentGroupStatus defines the observed state of DeploymentGroup.</summary>
    [JsonPropertyName("status")]
    public V1beta2DeploymentGroupStatus? Status { get; set; }
}