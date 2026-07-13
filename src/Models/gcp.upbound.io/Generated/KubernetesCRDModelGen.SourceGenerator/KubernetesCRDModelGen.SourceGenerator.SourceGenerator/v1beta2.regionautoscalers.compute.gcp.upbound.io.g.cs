#nullable enable
using k8s;
using k8s.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace KubernetesCRDModelGen.Models.compute.gcp.upbound.io;
/// <summary>RegionAutoscaler is the Schema for the RegionAutoscalers API. Represents an Autoscaler resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RegionAutoscalerList : IKubernetesObject<V1ListMeta>, IItems<V1beta2RegionAutoscaler>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RegionAutoscalerList";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regionautoscalers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegionAutoscalerList";

    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects. A resource may have only one of {ObjectMeta, ListMeta}.</summary>
    [JsonPropertyName("metadata")]
    public V1ListMeta? Metadata { get; set; }

    /// <summary>List of V1beta2RegionAutoscaler objects.</summary>
    [JsonPropertyName("items")]
    public required IList<V1beta2RegionAutoscaler> Items { get; set; }
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionAutoscalerSpecDeletionPolicyEnum>))]
public enum V1beta2RegionAutoscalerSpecDeletionPolicyEnum
{
    [EnumMember(Value = "Orphan"), JsonStringEnumMemberName("Orphan")]
    Orphan,
    [EnumMember(Value = "Delete"), JsonStringEnumMemberName("Delete")]
    Delete
}

/// <summary>
/// Defines the CPU utilization policy that allows the autoscaler to
/// scale based on the average CPU utilization of a managed instance
/// group.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecForProviderAutoscalingPolicyCpuUtilization
{
    /// <summary>Indicates whether predictive autoscaling based on CPU metric is enabled. Valid values are:</summary>
    [JsonPropertyName("predictiveMethod")]
    public string? PredictiveMethod { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }
}

/// <summary>
/// Configuration parameters of autoscaling based on a load balancer.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecForProviderAutoscalingPolicyLoadBalancingUtilization
{
    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecForProviderAutoscalingPolicyMetric
{
    /// <summary>
    /// A filter string to be used as the filter string for
    /// a Stackdriver Monitoring TimeSeries.list API call.
    /// This filter is used to select a specific TimeSeries for
    /// the purpose of autoscaling and to determine whether the metric
    /// is exporting per-instance or per-group data.
    /// You can only use the AND operator for joining selectors.
    /// You can only use direct equality comparison operator (=) without
    /// any functions for each selector.
    /// You can specify the metric in both the filter string and in the
    /// metric field. However, if specified in both places, the metric must
    /// be identical.
    /// The monitored resource type determines what kind of values are
    /// expected for the metric. If it is a gce_instance, the autoscaler
    /// expects the metric to include a separate TimeSeries for each
    /// instance in a group. In such a case, you cannot filter on resource
    /// labels.
    /// If the resource type is any other value, the autoscaler expects
    /// this metric to contain values that apply to the entire autoscaled
    /// instance group and resource label filtering can be performed to
    /// point autoscaler at the correct TimeSeries to scale upon.
    /// This is called a per-group metric for the purpose of autoscaling.
    /// If not specified, the type defaults to gce_instance.
    /// You should provide a filter that is selective enough to pick just
    /// one TimeSeries for the autoscaled group or for each of the instances
    /// (if you are using gce_instance resource type). If multiple
    /// TimeSeries are returned upon the query execution, the autoscaler
    /// will sum their respective values to obtain its scaling value.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// If scaling is based on a per-group metric value that represents the
    /// total amount of work to be done or resource usage, set this value to
    /// an amount assigned for a single instance of the scaled group.
    /// The autoscaler will keep the number of instances proportional to the
    /// value of this metric, the metric itself should not change value due
    /// to group resizing.
    /// For example, a good metric to use with the target is
    /// pubsub.googleapis.com/subscription/num_undelivered_messages
    /// or a custom metric exporting the total number of requests coming to
    /// your instances.
    /// A bad example would be a metric exporting an average or median
    /// latency, since this value can&apos;t include a chunk assignable to a
    /// single instance, it could be better used with utilization_target
    /// instead.
    /// </summary>
    [JsonPropertyName("singleInstanceAssignment")]
    public double? SingleInstanceAssignment { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }

    /// <summary>
    /// Defines how target utilization value is expressed for a
    /// Stackdriver Monitoring metric.
    /// Possible values are: GAUGE, DELTA_PER_SECOND, DELTA_PER_MINUTE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecForProviderAutoscalingPolicyScaleInControlMaxScaledInReplicas
{
    /// <summary>
    /// Specifies a fixed number of VM instances. This must be a positive
    /// integer.
    /// </summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>
    /// Specifies a percentage of instances between 0 to 100%, inclusive.
    /// For example, specify 80 for 80%.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>
/// Defines scale in controls to reduce the risk of response latency
/// and outages due to abrupt scale-in events
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecForProviderAutoscalingPolicyScaleInControl
{
    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxScaledInReplicas")]
    public V1beta2RegionAutoscalerSpecForProviderAutoscalingPolicyScaleInControlMaxScaledInReplicas? MaxScaledInReplicas { get; set; }

    /// <summary>
    /// How long back autoscaling should look when computing recommendations
    /// to include directives regarding slower scale down, as described above.
    /// </summary>
    [JsonPropertyName("timeWindowSec")]
    public double? TimeWindowSec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecForProviderAutoscalingPolicyScalingSchedules
{
    /// <summary>A description of a scaling schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A boolean value that specifies if a scaling schedule can influence autoscaler recommendations. If set to true, then a scaling schedule has no effect.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The duration of time intervals (in seconds) for which this scaling schedule will be running. The minimum allowed value is 300.</summary>
    [JsonPropertyName("durationSec")]
    public double? DurationSec { get; set; }

    /// <summary>Minimum number of VM instances that autoscaler will recommend in time intervals starting according to schedule.</summary>
    [JsonPropertyName("minRequiredReplicas")]
    public double? MinRequiredReplicas { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The start timestamps of time intervals when this scaling schedule should provide a scaling signal. This field uses the extended cron format (with an optional year field).</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The time zone to be used when interpreting the schedule. The value of this field must be a time zone name from the tz database: http://en.wikipedia.org/wiki/Tz_database.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// The configuration parameters for the autoscaling algorithm. You can
/// define one or more of the policies for an autoscaler: cpuUtilization,
/// customMetricUtilizations, and loadBalancingUtilization.
/// If none of these are specified, the default will be to autoscale based
/// on cpuUtilization to 0.6 or 60%.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecForProviderAutoscalingPolicy
{
    /// <summary>
    /// The number of seconds that the autoscaler should wait before it
    /// starts collecting information from a new instance. This prevents
    /// the autoscaler from collecting information when the instance is
    /// initializing, during which the collected usage would not be
    /// reliable. The default time autoscaler waits is 60 seconds.
    /// Virtual machine initialization times might vary because of
    /// numerous factors. We recommend that you test how long an
    /// instance may take to initialize. To do this, create an instance
    /// and time the startup process.
    /// </summary>
    [JsonPropertyName("cooldownPeriod")]
    public double? CooldownPeriod { get; set; }

    /// <summary>
    /// Defines the CPU utilization policy that allows the autoscaler to
    /// scale based on the average CPU utilization of a managed instance
    /// group.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cpuUtilization")]
    public V1beta2RegionAutoscalerSpecForProviderAutoscalingPolicyCpuUtilization? CpuUtilization { get; set; }

    /// <summary>
    /// Configuration parameters of autoscaling based on a load balancer.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("loadBalancingUtilization")]
    public V1beta2RegionAutoscalerSpecForProviderAutoscalingPolicyLoadBalancingUtilization? LoadBalancingUtilization { get; set; }

    /// <summary>
    /// The maximum number of instances that the autoscaler can scale up
    /// to. This is required when creating or updating an autoscaler. The
    /// maximum number of replicas should not be lower than minimal number
    /// of replicas.
    /// </summary>
    [JsonPropertyName("maxReplicas")]
    public double? MaxReplicas { get; set; }

    /// <summary>
    /// Configuration parameters of autoscaling based on a custom metric.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metric")]
    public IList<V1beta2RegionAutoscalerSpecForProviderAutoscalingPolicyMetric>? Metric { get; set; }

    /// <summary>
    /// The minimum number of replicas that the autoscaler can scale down
    /// to. This cannot be less than 0. If not provided, autoscaler will
    /// choose a default value depending on maximum number of instances
    /// allowed.
    /// </summary>
    [JsonPropertyName("minReplicas")]
    public double? MinReplicas { get; set; }

    /// <summary>Defines operating mode for this policy.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Defines scale in controls to reduce the risk of response latency
    /// and outages due to abrupt scale-in events
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("scaleInControl")]
    public V1beta2RegionAutoscalerSpecForProviderAutoscalingPolicyScaleInControl? ScaleInControl { get; set; }

    /// <summary>
    /// Scaling schedules defined for an autoscaler. Multiple schedules can be set on an autoscaler and they can overlap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("scalingSchedules")]
    public IList<V1beta2RegionAutoscalerSpecForProviderAutoscalingPolicyScalingSchedules>? ScalingSchedules { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionAutoscalerSpecForProviderTargetRefPolicyResolutionEnum>))]
public enum V1beta2RegionAutoscalerSpecForProviderTargetRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionAutoscalerSpecForProviderTargetRefPolicyResolveEnum>))]
public enum V1beta2RegionAutoscalerSpecForProviderTargetRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecForProviderTargetRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionAutoscalerSpecForProviderTargetRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionAutoscalerSpecForProviderTargetRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionInstanceGroupManager in compute to populate target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecForProviderTargetRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionAutoscalerSpecForProviderTargetRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionAutoscalerSpecForProviderTargetSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionAutoscalerSpecForProviderTargetSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionAutoscalerSpecForProviderTargetSelectorPolicyResolveEnum>))]
public enum V1beta2RegionAutoscalerSpecForProviderTargetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecForProviderTargetSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionAutoscalerSpecForProviderTargetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionAutoscalerSpecForProviderTargetSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionInstanceGroupManager in compute to populate target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecForProviderTargetSelector
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
    public V1beta2RegionAutoscalerSpecForProviderTargetSelectorPolicy? Policy { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecForProvider
{
    /// <summary>
    /// The configuration parameters for the autoscaling algorithm. You can
    /// define one or more of the policies for an autoscaler: cpuUtilization,
    /// customMetricUtilizations, and loadBalancingUtilization.
    /// If none of these are specified, the default will be to autoscale based
    /// on cpuUtilization to 0.6 or 60%.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingPolicy")]
    public V1beta2RegionAutoscalerSpecForProviderAutoscalingPolicy? AutoscalingPolicy { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>URL of the region where the instance group resides.</summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Reference to a RegionInstanceGroupManager in compute to populate target.</summary>
    [JsonPropertyName("targetRef")]
    public V1beta2RegionAutoscalerSpecForProviderTargetRef? TargetRef { get; set; }

    /// <summary>Selector for a RegionInstanceGroupManager in compute to populate target.</summary>
    [JsonPropertyName("targetSelector")]
    public V1beta2RegionAutoscalerSpecForProviderTargetSelector? TargetSelector { get; set; }
}

/// <summary>
/// Defines the CPU utilization policy that allows the autoscaler to
/// scale based on the average CPU utilization of a managed instance
/// group.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecInitProviderAutoscalingPolicyCpuUtilization
{
    /// <summary>Indicates whether predictive autoscaling based on CPU metric is enabled. Valid values are:</summary>
    [JsonPropertyName("predictiveMethod")]
    public string? PredictiveMethod { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }
}

/// <summary>
/// Configuration parameters of autoscaling based on a load balancer.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecInitProviderAutoscalingPolicyLoadBalancingUtilization
{
    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecInitProviderAutoscalingPolicyMetric
{
    /// <summary>
    /// A filter string to be used as the filter string for
    /// a Stackdriver Monitoring TimeSeries.list API call.
    /// This filter is used to select a specific TimeSeries for
    /// the purpose of autoscaling and to determine whether the metric
    /// is exporting per-instance or per-group data.
    /// You can only use the AND operator for joining selectors.
    /// You can only use direct equality comparison operator (=) without
    /// any functions for each selector.
    /// You can specify the metric in both the filter string and in the
    /// metric field. However, if specified in both places, the metric must
    /// be identical.
    /// The monitored resource type determines what kind of values are
    /// expected for the metric. If it is a gce_instance, the autoscaler
    /// expects the metric to include a separate TimeSeries for each
    /// instance in a group. In such a case, you cannot filter on resource
    /// labels.
    /// If the resource type is any other value, the autoscaler expects
    /// this metric to contain values that apply to the entire autoscaled
    /// instance group and resource label filtering can be performed to
    /// point autoscaler at the correct TimeSeries to scale upon.
    /// This is called a per-group metric for the purpose of autoscaling.
    /// If not specified, the type defaults to gce_instance.
    /// You should provide a filter that is selective enough to pick just
    /// one TimeSeries for the autoscaled group or for each of the instances
    /// (if you are using gce_instance resource type). If multiple
    /// TimeSeries are returned upon the query execution, the autoscaler
    /// will sum their respective values to obtain its scaling value.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// If scaling is based on a per-group metric value that represents the
    /// total amount of work to be done or resource usage, set this value to
    /// an amount assigned for a single instance of the scaled group.
    /// The autoscaler will keep the number of instances proportional to the
    /// value of this metric, the metric itself should not change value due
    /// to group resizing.
    /// For example, a good metric to use with the target is
    /// pubsub.googleapis.com/subscription/num_undelivered_messages
    /// or a custom metric exporting the total number of requests coming to
    /// your instances.
    /// A bad example would be a metric exporting an average or median
    /// latency, since this value can&apos;t include a chunk assignable to a
    /// single instance, it could be better used with utilization_target
    /// instead.
    /// </summary>
    [JsonPropertyName("singleInstanceAssignment")]
    public double? SingleInstanceAssignment { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }

    /// <summary>
    /// Defines how target utilization value is expressed for a
    /// Stackdriver Monitoring metric.
    /// Possible values are: GAUGE, DELTA_PER_SECOND, DELTA_PER_MINUTE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecInitProviderAutoscalingPolicyScaleInControlMaxScaledInReplicas
{
    /// <summary>
    /// Specifies a fixed number of VM instances. This must be a positive
    /// integer.
    /// </summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>
    /// Specifies a percentage of instances between 0 to 100%, inclusive.
    /// For example, specify 80 for 80%.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>
/// Defines scale in controls to reduce the risk of response latency
/// and outages due to abrupt scale-in events
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecInitProviderAutoscalingPolicyScaleInControl
{
    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxScaledInReplicas")]
    public V1beta2RegionAutoscalerSpecInitProviderAutoscalingPolicyScaleInControlMaxScaledInReplicas? MaxScaledInReplicas { get; set; }

    /// <summary>
    /// How long back autoscaling should look when computing recommendations
    /// to include directives regarding slower scale down, as described above.
    /// </summary>
    [JsonPropertyName("timeWindowSec")]
    public double? TimeWindowSec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecInitProviderAutoscalingPolicyScalingSchedules
{
    /// <summary>A description of a scaling schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A boolean value that specifies if a scaling schedule can influence autoscaler recommendations. If set to true, then a scaling schedule has no effect.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The duration of time intervals (in seconds) for which this scaling schedule will be running. The minimum allowed value is 300.</summary>
    [JsonPropertyName("durationSec")]
    public double? DurationSec { get; set; }

    /// <summary>Minimum number of VM instances that autoscaler will recommend in time intervals starting according to schedule.</summary>
    [JsonPropertyName("minRequiredReplicas")]
    public double? MinRequiredReplicas { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The start timestamps of time intervals when this scaling schedule should provide a scaling signal. This field uses the extended cron format (with an optional year field).</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The time zone to be used when interpreting the schedule. The value of this field must be a time zone name from the tz database: http://en.wikipedia.org/wiki/Tz_database.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// The configuration parameters for the autoscaling algorithm. You can
/// define one or more of the policies for an autoscaler: cpuUtilization,
/// customMetricUtilizations, and loadBalancingUtilization.
/// If none of these are specified, the default will be to autoscale based
/// on cpuUtilization to 0.6 or 60%.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecInitProviderAutoscalingPolicy
{
    /// <summary>
    /// The number of seconds that the autoscaler should wait before it
    /// starts collecting information from a new instance. This prevents
    /// the autoscaler from collecting information when the instance is
    /// initializing, during which the collected usage would not be
    /// reliable. The default time autoscaler waits is 60 seconds.
    /// Virtual machine initialization times might vary because of
    /// numerous factors. We recommend that you test how long an
    /// instance may take to initialize. To do this, create an instance
    /// and time the startup process.
    /// </summary>
    [JsonPropertyName("cooldownPeriod")]
    public double? CooldownPeriod { get; set; }

    /// <summary>
    /// Defines the CPU utilization policy that allows the autoscaler to
    /// scale based on the average CPU utilization of a managed instance
    /// group.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cpuUtilization")]
    public V1beta2RegionAutoscalerSpecInitProviderAutoscalingPolicyCpuUtilization? CpuUtilization { get; set; }

    /// <summary>
    /// Configuration parameters of autoscaling based on a load balancer.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("loadBalancingUtilization")]
    public V1beta2RegionAutoscalerSpecInitProviderAutoscalingPolicyLoadBalancingUtilization? LoadBalancingUtilization { get; set; }

    /// <summary>
    /// The maximum number of instances that the autoscaler can scale up
    /// to. This is required when creating or updating an autoscaler. The
    /// maximum number of replicas should not be lower than minimal number
    /// of replicas.
    /// </summary>
    [JsonPropertyName("maxReplicas")]
    public double? MaxReplicas { get; set; }

    /// <summary>
    /// Configuration parameters of autoscaling based on a custom metric.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metric")]
    public IList<V1beta2RegionAutoscalerSpecInitProviderAutoscalingPolicyMetric>? Metric { get; set; }

    /// <summary>
    /// The minimum number of replicas that the autoscaler can scale down
    /// to. This cannot be less than 0. If not provided, autoscaler will
    /// choose a default value depending on maximum number of instances
    /// allowed.
    /// </summary>
    [JsonPropertyName("minReplicas")]
    public double? MinReplicas { get; set; }

    /// <summary>Defines operating mode for this policy.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Defines scale in controls to reduce the risk of response latency
    /// and outages due to abrupt scale-in events
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("scaleInControl")]
    public V1beta2RegionAutoscalerSpecInitProviderAutoscalingPolicyScaleInControl? ScaleInControl { get; set; }

    /// <summary>
    /// Scaling schedules defined for an autoscaler. Multiple schedules can be set on an autoscaler and they can overlap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("scalingSchedules")]
    public IList<V1beta2RegionAutoscalerSpecInitProviderAutoscalingPolicyScalingSchedules>? ScalingSchedules { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionAutoscalerSpecInitProviderTargetRefPolicyResolutionEnum>))]
public enum V1beta2RegionAutoscalerSpecInitProviderTargetRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionAutoscalerSpecInitProviderTargetRefPolicyResolveEnum>))]
public enum V1beta2RegionAutoscalerSpecInitProviderTargetRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecInitProviderTargetRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionAutoscalerSpecInitProviderTargetRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionAutoscalerSpecInitProviderTargetRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Reference to a RegionInstanceGroupManager in compute to populate target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecInitProviderTargetRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionAutoscalerSpecInitProviderTargetRefPolicy? Policy { get; set; }
}

/// <summary>
/// Resolution specifies whether resolution of this reference is required.
/// The default is &apos;Required&apos;, which means the reconcile will fail if the
/// reference cannot be resolved. &apos;Optional&apos; means this reference will be
/// a no-op if it cannot be resolved.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionAutoscalerSpecInitProviderTargetSelectorPolicyResolutionEnum>))]
public enum V1beta2RegionAutoscalerSpecInitProviderTargetSelectorPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionAutoscalerSpecInitProviderTargetSelectorPolicyResolveEnum>))]
public enum V1beta2RegionAutoscalerSpecInitProviderTargetSelectorPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for selection.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecInitProviderTargetSelectorPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionAutoscalerSpecInitProviderTargetSelectorPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionAutoscalerSpecInitProviderTargetSelectorPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>Selector for a RegionInstanceGroupManager in compute to populate target.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecInitProviderTargetSelector
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
    public V1beta2RegionAutoscalerSpecInitProviderTargetSelectorPolicy? Policy { get; set; }
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
public partial class V1beta2RegionAutoscalerSpecInitProvider
{
    /// <summary>
    /// The configuration parameters for the autoscaling algorithm. You can
    /// define one or more of the policies for an autoscaler: cpuUtilization,
    /// customMetricUtilizations, and loadBalancingUtilization.
    /// If none of these are specified, the default will be to autoscale based
    /// on cpuUtilization to 0.6 or 60%.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingPolicy")]
    public V1beta2RegionAutoscalerSpecInitProviderAutoscalingPolicy? AutoscalingPolicy { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    /// <summary>Reference to a RegionInstanceGroupManager in compute to populate target.</summary>
    [JsonPropertyName("targetRef")]
    public V1beta2RegionAutoscalerSpecInitProviderTargetRef? TargetRef { get; set; }

    /// <summary>Selector for a RegionInstanceGroupManager in compute to populate target.</summary>
    [JsonPropertyName("targetSelector")]
    public V1beta2RegionAutoscalerSpecInitProviderTargetSelector? TargetSelector { get; set; }
}

/// <summary>
/// A ManagementAction represents an action that the Crossplane controllers
/// can take on an external resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionAutoscalerSpecManagementPoliciesEnum>))]
public enum V1beta2RegionAutoscalerSpecManagementPoliciesEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionAutoscalerSpecProviderConfigRefPolicyResolutionEnum>))]
public enum V1beta2RegionAutoscalerSpecProviderConfigRefPolicyResolutionEnum
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
[JsonConverter(typeof(JsonStringEnumConverter<V1beta2RegionAutoscalerSpecProviderConfigRefPolicyResolveEnum>))]
public enum V1beta2RegionAutoscalerSpecProviderConfigRefPolicyResolveEnum
{
    [EnumMember(Value = "Always"), JsonStringEnumMemberName("Always")]
    Always,
    [EnumMember(Value = "IfNotPresent"), JsonStringEnumMemberName("IfNotPresent")]
    IfNotPresent
}

/// <summary>Policies for referencing.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecProviderConfigRefPolicy
{
    /// <summary>
    /// Resolution specifies whether resolution of this reference is required.
    /// The default is &apos;Required&apos;, which means the reconcile will fail if the
    /// reference cannot be resolved. &apos;Optional&apos; means this reference will be
    /// a no-op if it cannot be resolved.
    /// </summary>
    [JsonPropertyName("resolution")]
    public V1beta2RegionAutoscalerSpecProviderConfigRefPolicyResolutionEnum? Resolution { get; set; }

    /// <summary>
    /// Resolve specifies when this reference should be resolved. The default
    /// is &apos;IfNotPresent&apos;, which will attempt to resolve the reference only when
    /// the corresponding field is not present. Use &apos;Always&apos; to resolve the
    /// reference on every reconcile.
    /// </summary>
    [JsonPropertyName("resolve")]
    public V1beta2RegionAutoscalerSpecProviderConfigRefPolicyResolveEnum? Resolve { get; set; }
}

/// <summary>
/// ProviderConfigReference specifies how the provider that will be used to
/// create, observe, update, and delete this managed resource should be
/// configured.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecProviderConfigRef
{
    /// <summary>Name of the referenced object.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Policies for referencing.</summary>
    [JsonPropertyName("policy")]
    public V1beta2RegionAutoscalerSpecProviderConfigRefPolicy? Policy { get; set; }
}

/// <summary>
/// WriteConnectionSecretToReference specifies the namespace and name of a
/// Secret to which any connection details for this managed resource should
/// be written. Connection details frequently include the endpoint, username,
/// and password required to connect to the managed resource.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpecWriteConnectionSecretToRef
{
    /// <summary>Name of the secret.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Namespace of the secret.</summary>
    [JsonPropertyName("namespace")]
    public required string Namespace { get; set; }
}

/// <summary>RegionAutoscalerSpec defines the desired state of RegionAutoscaler</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerSpec
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
    public V1beta2RegionAutoscalerSpecDeletionPolicyEnum? DeletionPolicy { get; set; }

    [JsonPropertyName("forProvider")]
    public required V1beta2RegionAutoscalerSpecForProvider ForProvider { get; set; }

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
    public V1beta2RegionAutoscalerSpecInitProvider? InitProvider { get; set; }

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
    public IList<V1beta2RegionAutoscalerSpecManagementPoliciesEnum>? ManagementPolicies { get; set; }

    /// <summary>
    /// ProviderConfigReference specifies how the provider that will be used to
    /// create, observe, update, and delete this managed resource should be
    /// configured.
    /// </summary>
    [JsonPropertyName("providerConfigRef")]
    public V1beta2RegionAutoscalerSpecProviderConfigRef? ProviderConfigRef { get; set; }

    /// <summary>
    /// WriteConnectionSecretToReference specifies the namespace and name of a
    /// Secret to which any connection details for this managed resource should
    /// be written. Connection details frequently include the endpoint, username,
    /// and password required to connect to the managed resource.
    /// </summary>
    [JsonPropertyName("writeConnectionSecretToRef")]
    public V1beta2RegionAutoscalerSpecWriteConnectionSecretToRef? WriteConnectionSecretToRef { get; set; }
}

/// <summary>
/// Defines the CPU utilization policy that allows the autoscaler to
/// scale based on the average CPU utilization of a managed instance
/// group.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerStatusAtProviderAutoscalingPolicyCpuUtilization
{
    /// <summary>Indicates whether predictive autoscaling based on CPU metric is enabled. Valid values are:</summary>
    [JsonPropertyName("predictiveMethod")]
    public string? PredictiveMethod { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }
}

/// <summary>
/// Configuration parameters of autoscaling based on a load balancer.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerStatusAtProviderAutoscalingPolicyLoadBalancingUtilization
{
    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerStatusAtProviderAutoscalingPolicyMetric
{
    /// <summary>
    /// A filter string to be used as the filter string for
    /// a Stackdriver Monitoring TimeSeries.list API call.
    /// This filter is used to select a specific TimeSeries for
    /// the purpose of autoscaling and to determine whether the metric
    /// is exporting per-instance or per-group data.
    /// You can only use the AND operator for joining selectors.
    /// You can only use direct equality comparison operator (=) without
    /// any functions for each selector.
    /// You can specify the metric in both the filter string and in the
    /// metric field. However, if specified in both places, the metric must
    /// be identical.
    /// The monitored resource type determines what kind of values are
    /// expected for the metric. If it is a gce_instance, the autoscaler
    /// expects the metric to include a separate TimeSeries for each
    /// instance in a group. In such a case, you cannot filter on resource
    /// labels.
    /// If the resource type is any other value, the autoscaler expects
    /// this metric to contain values that apply to the entire autoscaled
    /// instance group and resource label filtering can be performed to
    /// point autoscaler at the correct TimeSeries to scale upon.
    /// This is called a per-group metric for the purpose of autoscaling.
    /// If not specified, the type defaults to gce_instance.
    /// You should provide a filter that is selective enough to pick just
    /// one TimeSeries for the autoscaled group or for each of the instances
    /// (if you are using gce_instance resource type). If multiple
    /// TimeSeries are returned upon the query execution, the autoscaler
    /// will sum their respective values to obtain its scaling value.
    /// </summary>
    [JsonPropertyName("filter")]
    public string? Filter { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// If scaling is based on a per-group metric value that represents the
    /// total amount of work to be done or resource usage, set this value to
    /// an amount assigned for a single instance of the scaled group.
    /// The autoscaler will keep the number of instances proportional to the
    /// value of this metric, the metric itself should not change value due
    /// to group resizing.
    /// For example, a good metric to use with the target is
    /// pubsub.googleapis.com/subscription/num_undelivered_messages
    /// or a custom metric exporting the total number of requests coming to
    /// your instances.
    /// A bad example would be a metric exporting an average or median
    /// latency, since this value can&apos;t include a chunk assignable to a
    /// single instance, it could be better used with utilization_target
    /// instead.
    /// </summary>
    [JsonPropertyName("singleInstanceAssignment")]
    public double? SingleInstanceAssignment { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public double? Target { get; set; }

    /// <summary>
    /// Defines how target utilization value is expressed for a
    /// Stackdriver Monitoring metric.
    /// Possible values are: GAUGE, DELTA_PER_SECOND, DELTA_PER_MINUTE.
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }
}

/// <summary>
/// A nested object resource.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerStatusAtProviderAutoscalingPolicyScaleInControlMaxScaledInReplicas
{
    /// <summary>
    /// Specifies a fixed number of VM instances. This must be a positive
    /// integer.
    /// </summary>
    [JsonPropertyName("fixed")]
    public double? Fixed { get; set; }

    /// <summary>
    /// Specifies a percentage of instances between 0 to 100%, inclusive.
    /// For example, specify 80 for 80%.
    /// </summary>
    [JsonPropertyName("percent")]
    public double? Percent { get; set; }
}

/// <summary>
/// Defines scale in controls to reduce the risk of response latency
/// and outages due to abrupt scale-in events
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerStatusAtProviderAutoscalingPolicyScaleInControl
{
    /// <summary>
    /// A nested object resource.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("maxScaledInReplicas")]
    public V1beta2RegionAutoscalerStatusAtProviderAutoscalingPolicyScaleInControlMaxScaledInReplicas? MaxScaledInReplicas { get; set; }

    /// <summary>
    /// How long back autoscaling should look when computing recommendations
    /// to include directives regarding slower scale down, as described above.
    /// </summary>
    [JsonPropertyName("timeWindowSec")]
    public double? TimeWindowSec { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerStatusAtProviderAutoscalingPolicyScalingSchedules
{
    /// <summary>A description of a scaling schedule.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>A boolean value that specifies if a scaling schedule can influence autoscaler recommendations. If set to true, then a scaling schedule has no effect.</summary>
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; set; }

    /// <summary>The duration of time intervals (in seconds) for which this scaling schedule will be running. The minimum allowed value is 300.</summary>
    [JsonPropertyName("durationSec")]
    public double? DurationSec { get; set; }

    /// <summary>Minimum number of VM instances that autoscaler will recommend in time intervals starting according to schedule.</summary>
    [JsonPropertyName("minRequiredReplicas")]
    public double? MinRequiredReplicas { get; set; }

    /// <summary>The identifier for this object. Format specified above.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>The start timestamps of time intervals when this scaling schedule should provide a scaling signal. This field uses the extended cron format (with an optional year field).</summary>
    [JsonPropertyName("schedule")]
    public string? Schedule { get; set; }

    /// <summary>The time zone to be used when interpreting the schedule. The value of this field must be a time zone name from the tz database: http://en.wikipedia.org/wiki/Tz_database.</summary>
    [JsonPropertyName("timeZone")]
    public string? TimeZone { get; set; }
}

/// <summary>
/// The configuration parameters for the autoscaling algorithm. You can
/// define one or more of the policies for an autoscaler: cpuUtilization,
/// customMetricUtilizations, and loadBalancingUtilization.
/// If none of these are specified, the default will be to autoscale based
/// on cpuUtilization to 0.6 or 60%.
/// Structure is documented below.
/// </summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerStatusAtProviderAutoscalingPolicy
{
    /// <summary>
    /// The number of seconds that the autoscaler should wait before it
    /// starts collecting information from a new instance. This prevents
    /// the autoscaler from collecting information when the instance is
    /// initializing, during which the collected usage would not be
    /// reliable. The default time autoscaler waits is 60 seconds.
    /// Virtual machine initialization times might vary because of
    /// numerous factors. We recommend that you test how long an
    /// instance may take to initialize. To do this, create an instance
    /// and time the startup process.
    /// </summary>
    [JsonPropertyName("cooldownPeriod")]
    public double? CooldownPeriod { get; set; }

    /// <summary>
    /// Defines the CPU utilization policy that allows the autoscaler to
    /// scale based on the average CPU utilization of a managed instance
    /// group.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("cpuUtilization")]
    public V1beta2RegionAutoscalerStatusAtProviderAutoscalingPolicyCpuUtilization? CpuUtilization { get; set; }

    /// <summary>
    /// Configuration parameters of autoscaling based on a load balancer.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("loadBalancingUtilization")]
    public V1beta2RegionAutoscalerStatusAtProviderAutoscalingPolicyLoadBalancingUtilization? LoadBalancingUtilization { get; set; }

    /// <summary>
    /// The maximum number of instances that the autoscaler can scale up
    /// to. This is required when creating or updating an autoscaler. The
    /// maximum number of replicas should not be lower than minimal number
    /// of replicas.
    /// </summary>
    [JsonPropertyName("maxReplicas")]
    public double? MaxReplicas { get; set; }

    /// <summary>
    /// Configuration parameters of autoscaling based on a custom metric.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("metric")]
    public IList<V1beta2RegionAutoscalerStatusAtProviderAutoscalingPolicyMetric>? Metric { get; set; }

    /// <summary>
    /// The minimum number of replicas that the autoscaler can scale down
    /// to. This cannot be less than 0. If not provided, autoscaler will
    /// choose a default value depending on maximum number of instances
    /// allowed.
    /// </summary>
    [JsonPropertyName("minReplicas")]
    public double? MinReplicas { get; set; }

    /// <summary>Defines operating mode for this policy.</summary>
    [JsonPropertyName("mode")]
    public string? Mode { get; set; }

    /// <summary>
    /// Defines scale in controls to reduce the risk of response latency
    /// and outages due to abrupt scale-in events
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("scaleInControl")]
    public V1beta2RegionAutoscalerStatusAtProviderAutoscalingPolicyScaleInControl? ScaleInControl { get; set; }

    /// <summary>
    /// Scaling schedules defined for an autoscaler. Multiple schedules can be set on an autoscaler and they can overlap.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("scalingSchedules")]
    public IList<V1beta2RegionAutoscalerStatusAtProviderAutoscalingPolicyScalingSchedules>? ScalingSchedules { get; set; }
}

[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerStatusAtProvider
{
    /// <summary>
    /// The configuration parameters for the autoscaling algorithm. You can
    /// define one or more of the policies for an autoscaler: cpuUtilization,
    /// customMetricUtilizations, and loadBalancingUtilization.
    /// If none of these are specified, the default will be to autoscale based
    /// on cpuUtilization to 0.6 or 60%.
    /// Structure is documented below.
    /// </summary>
    [JsonPropertyName("autoscalingPolicy")]
    public V1beta2RegionAutoscalerStatusAtProviderAutoscalingPolicy? AutoscalingPolicy { get; set; }

    /// <summary>Creation timestamp in RFC3339 text format.</summary>
    [JsonPropertyName("creationTimestamp")]
    public string? CreationTimestamp { get; set; }

    /// <summary>An optional description of this resource.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>an identifier for the resource with format projects/{{project}}/regions/{{region}}/autoscalers/{{name}}</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>
    /// The ID of the project in which the resource belongs.
    /// If it is not provided, the provider project is used.
    /// </summary>
    [JsonPropertyName("project")]
    public string? Project { get; set; }

    /// <summary>URL of the region where the instance group resides.</summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>The URI of the created resource.</summary>
    [JsonPropertyName("selfLink")]
    public string? SelfLink { get; set; }

    /// <summary>URL of the managed instance group that this autoscaler will scale.</summary>
    [JsonPropertyName("target")]
    public string? Target { get; set; }
}

/// <summary>A Condition that may apply to a resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerStatusConditions
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

/// <summary>RegionAutoscalerStatus defines the observed state of RegionAutoscaler.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public partial class V1beta2RegionAutoscalerStatus
{
    [JsonPropertyName("atProvider")]
    public V1beta2RegionAutoscalerStatusAtProvider? AtProvider { get; set; }

    /// <summary>Conditions of the resource.</summary>
    [JsonPropertyName("conditions")]
    public IList<V1beta2RegionAutoscalerStatusConditions>? Conditions { get; set; }

    /// <summary>
    /// ObservedGeneration is the latest metadata.generation
    /// which resulted in either a ready state, or stalled due to error
    /// it can not recover from without human intervention.
    /// </summary>
    [JsonPropertyName("observedGeneration")]
    public long? ObservedGeneration { get; set; }
}

/// <summary>RegionAutoscaler is the Schema for the RegionAutoscalers API. Represents an Autoscaler resource.</summary>
[global::System.CodeDom.Compiler.GeneratedCode("KubernetesCRDModelGen", "1.6.0+0fbafdb9fc339df17b265ba23ecc4a7be2359877")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
[KubernetesEntity(Group = KubeGroup, Kind = KubeKind, ApiVersion = KubeApiVersion, PluralName = KubePluralName)]
public partial class V1beta2RegionAutoscaler : IKubernetesObject<V1ObjectMeta>, ISpec<V1beta2RegionAutoscalerSpec>, IStatus<V1beta2RegionAutoscalerStatus?>
{
    public const string KubeApiVersion = "v1beta2";
    public const string KubeKind = "RegionAutoscaler";
    public const string KubeGroup = "compute.gcp.upbound.io";
    public const string KubePluralName = "regionautoscalers";
    /// <summary>APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</summary>
    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; } = "compute.gcp.upbound.io/v1beta2";

    /// <summary>Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</summary>
    [JsonPropertyName("kind")]
    public string Kind { get; set; } = "RegionAutoscaler";

    /// <summary>Standard object&apos;s metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</summary>
    [JsonPropertyName("metadata")]
    public V1ObjectMeta Metadata { get; set; }

    /// <summary>RegionAutoscalerSpec defines the desired state of RegionAutoscaler</summary>
    [JsonPropertyName("spec")]
    public required V1beta2RegionAutoscalerSpec Spec { get; set; }

    /// <summary>RegionAutoscalerStatus defines the observed state of RegionAutoscaler.</summary>
    [JsonPropertyName("status")]
    public V1beta2RegionAutoscalerStatus? Status { get; set; }
}