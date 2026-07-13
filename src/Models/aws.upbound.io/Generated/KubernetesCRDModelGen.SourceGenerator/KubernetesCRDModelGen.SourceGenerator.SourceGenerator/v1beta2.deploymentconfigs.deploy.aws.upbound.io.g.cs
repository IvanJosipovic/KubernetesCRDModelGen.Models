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
/// <summary>DeploymentConfig is the Schema for the DeploymentConfigs API. Provides a CodeDeploy deployment config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DeploymentConfigList : IKubernetesObject<V1ListMeta>, IItems<V1beta2DeploymentConfig>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DeploymentConfigList";
    public const string KubeGroup = "deploy.aws.upbound.io";
    public const string KubePluralName = "deploymentconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "deploy.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DeploymentConfigList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2DeploymentConfig objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2DeploymentConfig> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentConfigSpecDeletionPolicyEnum>))]
public enum V1beta2DeploymentConfigSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>A minimum_healthy_hosts block. Required for Server compute platform. Minimum Healthy Hosts are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigSpecForProviderMinimumHealthyHosts
{
    /// <summary>The type can either be FLEET_PERCENT or HOST_COUNT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// The value when the type is FLEET_PERCENT represents the minimum number of healthy instances as
    /// a percentage of the total number of instances in the deployment. If you specify FLEET_PERCENT, at the start of the
    /// deployment, AWS CodeDeploy converts the percentage to the equivalent number of instance and rounds up fractional instances.
    /// When the type is HOST_COUNT, the value represents the minimum number of healthy instances as an absolute value.
    /// </summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>The time based canary configuration information. If type is TimeBasedLinear, use time_based_linear instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigSpecForProviderTrafficRoutingConfigTimeBasedCanary
{
    /// <summary>The number of minutes between the first and second traffic shifts of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The percentage of traffic to shift in the first increment of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>The time based linear configuration information. If type is TimeBasedCanary, use time_based_canary instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigSpecForProviderTrafficRoutingConfigTimeBasedLinear
{
    /// <summary>The number of minutes between the first and second traffic shifts of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The percentage of traffic to shift in the first increment of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>A traffic_routing_config block. Traffic Routing Config is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigSpecForProviderTrafficRoutingConfig
{
    /// <summary>The time based canary configuration information. If type is TimeBasedLinear, use time_based_linear instead.</summary>
    [JsonPropertyName("timeBasedCanary")]
    public V1beta2DeploymentConfigSpecForProviderTrafficRoutingConfigTimeBasedCanary? TimeBasedCanary { get; set; }

    /// <summary>The time based linear configuration information. If type is TimeBasedCanary, use time_based_canary instead.</summary>
    [JsonPropertyName("timeBasedLinear")]
    public V1beta2DeploymentConfigSpecForProviderTrafficRoutingConfigTimeBasedLinear? TimeBasedLinear { get; set; }

    /// <summary>Type of traffic routing config. One of TimeBasedCanary, TimeBasedLinear, AllAtOnce.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The number or percentage of instances that must remain available per Availability Zone during a deployment. If you don&apos;t specify a value under minimum_healthy_hosts_per_zone, then CodeDeploy uses a default value of 0 percent. This block is more documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigSpecForProviderZonalConfigMinimumHealthyHostsPerZone
{
    /// <summary>The type can either be FLEET_PERCENT or HOST_COUNT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value when the type is FLEET_PERCENT represents the minimum number of healthy instances as a percentage of the total number of instances in the Availability Zone during a deployment. If you specify FLEET_PERCENT, at the start of the deployment, AWS CodeDeploy converts the percentage to the equivalent number of instance and rounds up fractional instances. When the type is HOST_COUNT, the value represents the minimum number of healthy instances in the Availability Zone as an absolute value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>A zonal_config block. Zonal Config is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigSpecForProviderZonalConfig
{
    /// <summary>The period of time, in seconds, that CodeDeploy must wait after completing a deployment to the first Availability Zone. CodeDeploy will wait this amount of time before starting a deployment to the second Availability Zone. If you don&apos;t specify a value for first_zone_monitor_duration_in_seconds, then CodeDeploy uses the monitor_duration_in_seconds value for the first Availability Zone.</summary>
    [JsonPropertyName("firstZoneMonitorDurationInSeconds")]
    public double? FirstZoneMonitorDurationInSeconds { get; set; }

    /// <summary>The number or percentage of instances that must remain available per Availability Zone during a deployment. If you don&apos;t specify a value under minimum_healthy_hosts_per_zone, then CodeDeploy uses a default value of 0 percent. This block is more documented below.</summary>
    [JsonPropertyName("minimumHealthyHostsPerZone")]
    public V1beta2DeploymentConfigSpecForProviderZonalConfigMinimumHealthyHostsPerZone? MinimumHealthyHostsPerZone { get; set; }

    /// <summary>The period of time, in seconds, that CodeDeploy must wait after completing a deployment to an Availability Zone. CodeDeploy will wait this amount of time before starting a deployment to the next Availability Zone. If you don&apos;t specify a monitor_duration_in_seconds, CodeDeploy starts deploying to the next Availability Zone immediately.</summary>
    [JsonPropertyName("monitorDurationInSeconds")]
    public double? MonitorDurationInSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigSpecForProvider
{
    /// <summary>The compute platform can be Server, Lambda, or ECS. Default is Server.</summary>
    [JsonPropertyName("computePlatform")]
    public string? ComputePlatform { get; set; }

    /// <summary>A minimum_healthy_hosts block. Required for Server compute platform. Minimum Healthy Hosts are documented below.</summary>
    [JsonPropertyName("minimumHealthyHosts")]
    public V1beta2DeploymentConfigSpecForProviderMinimumHealthyHosts? MinimumHealthyHosts { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>A traffic_routing_config block. Traffic Routing Config is documented below.</summary>
    [JsonPropertyName("trafficRoutingConfig")]
    public V1beta2DeploymentConfigSpecForProviderTrafficRoutingConfig? TrafficRoutingConfig { get; set; }

    /// <summary>A zonal_config block. Zonal Config is documented below.</summary>
    [JsonPropertyName("zonalConfig")]
    public V1beta2DeploymentConfigSpecForProviderZonalConfig? ZonalConfig { get; set; }
}

/// <summary>A minimum_healthy_hosts block. Required for Server compute platform. Minimum Healthy Hosts are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigSpecInitProviderMinimumHealthyHosts
{
    /// <summary>The type can either be FLEET_PERCENT or HOST_COUNT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// The value when the type is FLEET_PERCENT represents the minimum number of healthy instances as
    /// a percentage of the total number of instances in the deployment. If you specify FLEET_PERCENT, at the start of the
    /// deployment, AWS CodeDeploy converts the percentage to the equivalent number of instance and rounds up fractional instances.
    /// When the type is HOST_COUNT, the value represents the minimum number of healthy instances as an absolute value.
    /// </summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>The time based canary configuration information. If type is TimeBasedLinear, use time_based_linear instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigSpecInitProviderTrafficRoutingConfigTimeBasedCanary
{
    /// <summary>The number of minutes between the first and second traffic shifts of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The percentage of traffic to shift in the first increment of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>The time based linear configuration information. If type is TimeBasedCanary, use time_based_canary instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigSpecInitProviderTrafficRoutingConfigTimeBasedLinear
{
    /// <summary>The number of minutes between the first and second traffic shifts of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The percentage of traffic to shift in the first increment of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>A traffic_routing_config block. Traffic Routing Config is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigSpecInitProviderTrafficRoutingConfig
{
    /// <summary>The time based canary configuration information. If type is TimeBasedLinear, use time_based_linear instead.</summary>
    [JsonPropertyName("timeBasedCanary")]
    public V1beta2DeploymentConfigSpecInitProviderTrafficRoutingConfigTimeBasedCanary? TimeBasedCanary { get; set; }

    /// <summary>The time based linear configuration information. If type is TimeBasedCanary, use time_based_canary instead.</summary>
    [JsonPropertyName("timeBasedLinear")]
    public V1beta2DeploymentConfigSpecInitProviderTrafficRoutingConfigTimeBasedLinear? TimeBasedLinear { get; set; }

    /// <summary>Type of traffic routing config. One of TimeBasedCanary, TimeBasedLinear, AllAtOnce.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The number or percentage of instances that must remain available per Availability Zone during a deployment. If you don&apos;t specify a value under minimum_healthy_hosts_per_zone, then CodeDeploy uses a default value of 0 percent. This block is more documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigSpecInitProviderZonalConfigMinimumHealthyHostsPerZone
{
    /// <summary>The type can either be FLEET_PERCENT or HOST_COUNT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value when the type is FLEET_PERCENT represents the minimum number of healthy instances as a percentage of the total number of instances in the Availability Zone during a deployment. If you specify FLEET_PERCENT, at the start of the deployment, AWS CodeDeploy converts the percentage to the equivalent number of instance and rounds up fractional instances. When the type is HOST_COUNT, the value represents the minimum number of healthy instances in the Availability Zone as an absolute value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>A zonal_config block. Zonal Config is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigSpecInitProviderZonalConfig
{
    /// <summary>The period of time, in seconds, that CodeDeploy must wait after completing a deployment to the first Availability Zone. CodeDeploy will wait this amount of time before starting a deployment to the second Availability Zone. If you don&apos;t specify a value for first_zone_monitor_duration_in_seconds, then CodeDeploy uses the monitor_duration_in_seconds value for the first Availability Zone.</summary>
    [JsonPropertyName("firstZoneMonitorDurationInSeconds")]
    public double? FirstZoneMonitorDurationInSeconds { get; set; }

    /// <summary>The number or percentage of instances that must remain available per Availability Zone during a deployment. If you don&apos;t specify a value under minimum_healthy_hosts_per_zone, then CodeDeploy uses a default value of 0 percent. This block is more documented below.</summary>
    [JsonPropertyName("minimumHealthyHostsPerZone")]
    public V1beta2DeploymentConfigSpecInitProviderZonalConfigMinimumHealthyHostsPerZone? MinimumHealthyHostsPerZone { get; set; }

    /// <summary>The period of time, in seconds, that CodeDeploy must wait after completing a deployment to an Availability Zone. CodeDeploy will wait this amount of time before starting a deployment to the next Availability Zone. If you don&apos;t specify a monitor_duration_in_seconds, CodeDeploy starts deploying to the next Availability Zone immediately.</summary>
    [JsonPropertyName("monitorDurationInSeconds")]
    public double? MonitorDurationInSeconds { get; set; }
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
public partial class V1beta2DeploymentConfigSpecInitProvider
{
    /// <summary>The compute platform can be Server, Lambda, or ECS. Default is Server.</summary>
    [JsonPropertyName("computePlatform")]
    public string? ComputePlatform { get; set; }

    /// <summary>A minimum_healthy_hosts block. Required for Server compute platform. Minimum Healthy Hosts are documented below.</summary>
    [JsonPropertyName("minimumHealthyHosts")]
    public V1beta2DeploymentConfigSpecInitProviderMinimumHealthyHosts? MinimumHealthyHosts { get; set; }

    /// <summary>A traffic_routing_config block. Traffic Routing Config is documented below.</summary>
    [JsonPropertyName("trafficRoutingConfig")]
    public V1beta2DeploymentConfigSpecInitProviderTrafficRoutingConfig? TrafficRoutingConfig { get; set; }

    /// <summary>A zonal_config block. Zonal Config is documented below.</summary>
    [JsonPropertyName("zonalConfig")]
    public V1beta2DeploymentConfigSpecInitProviderZonalConfig? ZonalConfig { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentConfigSpecManagementPoliciesEnum>))]
public enum V1beta2DeploymentConfigSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentConfigSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2DeploymentConfigSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2DeploymentConfigSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2DeploymentConfigSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2DeploymentConfigSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2DeploymentConfigSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2DeploymentConfigSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>DeploymentConfigSpec defines the desired state of DeploymentConfig</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigSpec
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
    public V1beta2DeploymentConfigSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2DeploymentConfigSpecForProvider ForProvider { get; set; }

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
    public V1beta2DeploymentConfigSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2DeploymentConfigSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2DeploymentConfigSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2DeploymentConfigSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>A minimum_healthy_hosts block. Required for Server compute platform. Minimum Healthy Hosts are documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigStatusAtProviderMinimumHealthyHosts
{
    /// <summary>The type can either be FLEET_PERCENT or HOST_COUNT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// The value when the type is FLEET_PERCENT represents the minimum number of healthy instances as
    /// a percentage of the total number of instances in the deployment. If you specify FLEET_PERCENT, at the start of the
    /// deployment, AWS CodeDeploy converts the percentage to the equivalent number of instance and rounds up fractional instances.
    /// When the type is HOST_COUNT, the value represents the minimum number of healthy instances as an absolute value.
    /// </summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>The time based canary configuration information. If type is TimeBasedLinear, use time_based_linear instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigStatusAtProviderTrafficRoutingConfigTimeBasedCanary
{
    /// <summary>The number of minutes between the first and second traffic shifts of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The percentage of traffic to shift in the first increment of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>The time based linear configuration information. If type is TimeBasedCanary, use time_based_canary instead.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigStatusAtProviderTrafficRoutingConfigTimeBasedLinear
{
    /// <summary>The number of minutes between the first and second traffic shifts of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("interval")]
    public double? Interval { get; set; }

    /// <summary>The percentage of traffic to shift in the first increment of a TimeBasedCanary deployment.</summary>
    [JsonPropertyName("percentage")]
    public double? Percentage { get; set; }
}

/// <summary>A traffic_routing_config block. Traffic Routing Config is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigStatusAtProviderTrafficRoutingConfig
{
    /// <summary>The time based canary configuration information. If type is TimeBasedLinear, use time_based_linear instead.</summary>
    [JsonPropertyName("timeBasedCanary")]
    public V1beta2DeploymentConfigStatusAtProviderTrafficRoutingConfigTimeBasedCanary? TimeBasedCanary { get; set; }

    /// <summary>The time based linear configuration information. If type is TimeBasedCanary, use time_based_canary instead.</summary>
    [JsonPropertyName("timeBasedLinear")]
    public V1beta2DeploymentConfigStatusAtProviderTrafficRoutingConfigTimeBasedLinear? TimeBasedLinear { get; set; }

    /// <summary>Type of traffic routing config. One of TimeBasedCanary, TimeBasedLinear, AllAtOnce.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>The number or percentage of instances that must remain available per Availability Zone during a deployment. If you don&apos;t specify a value under minimum_healthy_hosts_per_zone, then CodeDeploy uses a default value of 0 percent. This block is more documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigStatusAtProviderZonalConfigMinimumHealthyHostsPerZone
{
    /// <summary>The type can either be FLEET_PERCENT or HOST_COUNT.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>The value when the type is FLEET_PERCENT represents the minimum number of healthy instances as a percentage of the total number of instances in the Availability Zone during a deployment. If you specify FLEET_PERCENT, at the start of the deployment, AWS CodeDeploy converts the percentage to the equivalent number of instance and rounds up fractional instances. When the type is HOST_COUNT, the value represents the minimum number of healthy instances in the Availability Zone as an absolute value.</summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }
}

/// <summary>A zonal_config block. Zonal Config is documented below.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigStatusAtProviderZonalConfig
{
    /// <summary>The period of time, in seconds, that CodeDeploy must wait after completing a deployment to the first Availability Zone. CodeDeploy will wait this amount of time before starting a deployment to the second Availability Zone. If you don&apos;t specify a value for first_zone_monitor_duration_in_seconds, then CodeDeploy uses the monitor_duration_in_seconds value for the first Availability Zone.</summary>
    [JsonPropertyName("firstZoneMonitorDurationInSeconds")]
    public double? FirstZoneMonitorDurationInSeconds { get; set; }

    /// <summary>The number or percentage of instances that must remain available per Availability Zone during a deployment. If you don&apos;t specify a value under minimum_healthy_hosts_per_zone, then CodeDeploy uses a default value of 0 percent. This block is more documented below.</summary>
    [JsonPropertyName("minimumHealthyHostsPerZone")]
    public V1beta2DeploymentConfigStatusAtProviderZonalConfigMinimumHealthyHostsPerZone? MinimumHealthyHostsPerZone { get; set; }

    /// <summary>The period of time, in seconds, that CodeDeploy must wait after completing a deployment to an Availability Zone. CodeDeploy will wait this amount of time before starting a deployment to the next Availability Zone. If you don&apos;t specify a monitor_duration_in_seconds, CodeDeploy starts deploying to the next Availability Zone immediately.</summary>
    [JsonPropertyName("monitorDurationInSeconds")]
    public double? MonitorDurationInSeconds { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigStatusAtProvider
{
    /// <summary>The ARN of the deployment config.</summary>
    [JsonPropertyName("arn")]
    public string? Arn { get; set; }

    /// <summary>The compute platform can be Server, Lambda, or ECS. Default is Server.</summary>
    [JsonPropertyName("computePlatform")]
    public string? ComputePlatform { get; set; }

    /// <summary>The AWS Assigned deployment config id</summary>
    [JsonPropertyName("deploymentConfigId")]
    public string? DeploymentConfigId { get; set; }

    /// <summary>The deployment group&apos;s config name.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>A minimum_healthy_hosts block. Required for Server compute platform. Minimum Healthy Hosts are documented below.</summary>
    [JsonPropertyName("minimumHealthyHosts")]
    public V1beta2DeploymentConfigStatusAtProviderMinimumHealthyHosts? MinimumHealthyHosts { get; set; }

    /// <summary>
    /// Region where this resource will be managed. Defaults to the Region set in the provider configuration.
    /// Region is the region you&apos;d like your resource to be created in.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>A traffic_routing_config block. Traffic Routing Config is documented below.</summary>
    [JsonPropertyName("trafficRoutingConfig")]
    public V1beta2DeploymentConfigStatusAtProviderTrafficRoutingConfig? TrafficRoutingConfig { get; set; }

    /// <summary>A zonal_config block. Zonal Config is documented below.</summary>
    [JsonPropertyName("zonalConfig")]
    public V1beta2DeploymentConfigStatusAtProviderZonalConfig? ZonalConfig { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigStatusConditions
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

/// <summary>DeploymentConfigStatus defines the observed state of DeploymentConfig.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2DeploymentConfigStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2DeploymentConfigStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2DeploymentConfigStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>DeploymentConfig is the Schema for the DeploymentConfigs API. Provides a CodeDeploy deployment config.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2DeploymentConfig : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2DeploymentConfigSpec>, IStatus<V1beta2DeploymentConfigStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "DeploymentConfig";
    public const string KubeGroup = "deploy.aws.upbound.io";
    public const string KubePluralName = "deploymentconfigs";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "deploy.aws.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "DeploymentConfig";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>DeploymentConfigSpec defines the desired state of DeploymentConfig</summary>
    [JsonPropertyName("spec")]
    public required V1beta2DeploymentConfigSpec Spec { get; set; }

    /// <summary>DeploymentConfigStatus defines the observed state of DeploymentConfig.</summary>
    [JsonPropertyName("status")]
    public V1beta2DeploymentConfigStatus? Status { get; set; }
}